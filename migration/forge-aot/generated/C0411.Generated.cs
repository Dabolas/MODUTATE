// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C411{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/TapOrUntapEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3764,"forge/game/ability/effects/TapOrUntapEffect","<init>","()V",1,1,1,new JHandler[]{},M3764));
c.Add(new JMethod(3765,"forge/game/ability/effects/TapOrUntapEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,3,2,new JHandler[]{},M3765));
c.Add(new JMethod(3766,"forge/game/ability/effects/TapOrUntapEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,11,8,new JHandler[]{},M3766));
c.Add(new JMethod(3767,"forge/game/ability/effects/TapOrUntapEffect","lambda$resolve$0","(Lforge/game/player/Player;)Lforge/game/card/CardCollection;",4106,1,2,new JHandler[]{},M3767));
}

internal static JStep M3764(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3765(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Tap or untap ")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/ability/effects/TapOrUntapEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",20);}
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

internal static JStep M3766(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Tapper")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?35:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",18);}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Tapper")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",28);}
case 28:{return rt.Call(f,"forge/game/player/PlayerCollection","getFirst","()Ljava/lang/Object;","invokevirtual",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[2]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",39);}
case 39:{f.Locals[3]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("Toggle")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",46);}
case 46:{f.Locals[4]=f.Pop();f.Pc=48;continue;}
case 48:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=51;continue;}
case 51:{f.StackOp("dup");f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",55);}
case 55:{f.Locals[5]=f.Pop();f.Pc=57;continue;}
case 57:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",60);}
case 60:{f.Locals[6]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/ability/effects/TapOrUntapEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",66);}
case 66:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",69);}
case 69:{f.Locals[7]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[7]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",78);}
case 78:{f.Pc=f.Pop().Int==0?277:81;continue;}
case 81:{f.Push(f.Locals[7]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",88);}
case 88:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=91;continue;}
case 91:{f.Locals[8]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[8]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int!=0?104:101;continue;}
case 101:{f.Pc=71;continue;}
case 104:{f.Push(f.Locals[8]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int==0?115:112;continue;}
case 112:{f.Pc=71;continue;}
case 115:{f.Push(f.Locals[2]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",119);}
case 119:{f.Push(f.Locals[8]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(null));f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",125);}
case 125:{f.Locals[9]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[9]);f.Pc=129;continue;}
case 129:{f.Pc=f.Pop().Reference==null?71:132;continue;}
case 132:{f.Push(f.Locals[8]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[9]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",139);}
case 139:{f.Pc=f.Pop().Int!=0?145:142;continue;}
case 142:{f.Pc=71;continue;}
case 145:{f.Push(f.Locals[4]);f.Pc=147;continue;}
case 147:{f.Pc=f.Pop().Int==0?168:150;continue;}
case 150:{f.Push(f.Locals[9]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/card/Card","isTapped","()Z","invokevirtual",155);}
case 155:{f.Pc=f.Pop().Int!=0?162:158;continue;}
case 158:{f.Push(JValue.I(1));f.Pc=159;continue;}
case 159:{f.Pc=163;continue;}
case 162:{f.Push(JValue.I(0));f.Pc=163;continue;}
case 163:{f.Locals[10]=f.Pop();f.Pc=165;continue;}
case 165:{f.Pc=218;continue;}
case 168:{f.Push(f.Locals[3]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[1]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",173);}
case 173:{f.Push(JValue.R(rt.String("lblTapOrUntapTarget")));f.Pc=175;continue;}
case 175:{f.Push(JValue.I(1));f.Pc=176;continue;}
case 176:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=179;continue;}
case 179:{f.StackOp("dup");f.Pc=180;continue;}
case 180:{f.Push(JValue.I(0));f.Pc=181;continue;}
case 181:{f.Push(f.Locals[9]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",186);}
case 186:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",190);}
case 190:{if(!rt.StaticReady(f,"forge/game/player/PlayerController$BinaryChoiceType","TapOrUntap","Lforge/game/player/PlayerController$BinaryChoiceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerController$BinaryChoiceType","TapOrUntap","Lforge/game/player/PlayerController$BinaryChoiceType;"));f.Pc=193;continue;}
case 193:{f.Push(f.Locals[9]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",198);}
case 198:{f.Push(f.Locals[2]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",202);}
case 202:{f.Pc=f.Pop().Int!=0?209:205;continue;}
case 205:{f.Push(JValue.I(1));f.Pc=206;continue;}
case 206:{f.Pc=210;continue;}
case 209:{f.Push(JValue.I(0));f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",213);}
case 213:{return rt.Call(f,"forge/game/player/PlayerController","chooseBinary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/PlayerController$BinaryChoiceType;Ljava/lang/Boolean;)Z","invokevirtual",216);}
case 216:{f.Locals[10]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(f.Locals[10]);f.Pc=220;continue;}
case 220:{f.Pc=f.Pop().Int==0?244:223;continue;}
case 223:{f.Push(f.Locals[9]);f.Pc=225;continue;}
case 225:{f.Push(f.Locals[1]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[2]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/card/Card","tap","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z","invokevirtual",230);}
case 230:{f.Pc=f.Pop().Int==0?274:233;continue;}
case 233:{f.Push(f.Locals[5]);f.Pc=235;continue;}
case 235:{f.Push(f.Locals[9]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",240);}
case 240:{f.StackOp("pop");f.Pc=241;continue;}
case 241:{f.Pc=274;continue;}
case 244:{f.Push(f.Locals[9]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/card/Card","untap","()Z","invokevirtual",249);}
case 249:{f.Pc=f.Pop().Int==0?274:252;continue;}
case 252:{f.Push(f.Locals[6]);f.Pc=254;continue;}
case 254:{f.Push(f.Locals[2]);f.Pc=255;continue;}
case 255:{return rt.DynamicCall(f,"forge/game/ability/effects/TapOrUntapEffect:3766:255:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",260);}
case 260:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",265);}
case 265:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[9]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",273);}
case 273:{f.StackOp("pop");f.Pc=274;continue;}
case 274:{f.Pc=71;continue;}
case 277:{f.Push(f.Locals[6]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",284);}
case 284:{f.Pc=f.Pop().Int!=0?321:287;continue;}
case 287:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",290);}
case 290:{f.Locals[7]=f.Pop();f.Pc=292;continue;}
case 292:{f.Push(f.Locals[7]);f.Pc=294;continue;}
case 294:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"));f.Pc=297;continue;}
case 297:{f.Push(f.Locals[6]);f.Pc=299;continue;}
case 299:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",304);}
case 304:{f.StackOp("pop");f.Pc=305;continue;}
case 305:{f.Push(f.Locals[2]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",309);}
case 309:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",312);}
case 312:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","UntapAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","UntapAll","Lforge/game/trigger/TriggerType;"));f.Pc=315;continue;}
case 315:{f.Push(f.Locals[7]);f.Pc=317;continue;}
case 317:{f.Push(JValue.I(0));f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",321);}
case 321:{f.Push(f.Locals[5]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",326);}
case 326:{f.Pc=f.Pop().Int!=0?363:329;continue;}
case 329:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",332);}
case 332:{f.Locals[7]=f.Pop();f.Pc=334;continue;}
case 334:{f.Push(f.Locals[7]);f.Pc=336;continue;}
case 336:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=339;continue;}
case 339:{f.Push(f.Locals[5]);f.Pc=341;continue;}
case 341:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",346);}
case 346:{f.StackOp("pop");f.Pc=347;continue;}
case 347:{f.Push(f.Locals[2]);f.Pc=348;continue;}
case 348:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",351);}
case 351:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",354);}
case 354:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TapAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TapAll","Lforge/game/trigger/TriggerType;"));f.Pc=357;continue;}
case 357:{f.Push(f.Locals[7]);f.Pc=359;continue;}
case 359:{f.Push(JValue.I(0));f.Pc=360;continue;}
case 360:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",363);}
case 363:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3767(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
