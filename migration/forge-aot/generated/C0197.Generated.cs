// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C197{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/AirbendEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3007,"forge/game/ability/effects/AirbendEffect","<init>","()V",1,1,1,new JHandler[]{},M3007));
c.Add(new JMethod(3008,"forge/game/ability/effects/AirbendEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,4,new JHandler[]{},M3008));
c.Add(new JMethod(3009,"forge/game/ability/effects/AirbendEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,16,6,new JHandler[]{},M3009));
}

internal static JStep M3007(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3008(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Airbend ")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?25:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/ability/effects/AirbendEffect","getCardsfromTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",21);}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Pc=36;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("Defined")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",32);}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","knownDetermineDefined","(Ljava/lang/String;)Lforge/game/card/CardCollection;","invokevirtual",35);}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("DefinedDesc")));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/lang/Iterable;)Ljava/lang/String;","invokestatic",44);}
case 44:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",47);}
case 47:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",50);}
case 50:{f.StackOp("pop");f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String(".")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",57);}
case 57:{f.StackOp("pop");f.Pc=58;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"com/google/common/collect/Iterables","size","(Ljava/lang/Iterable;)I","invokestatic",62);}
case 62:{f.Push(JValue.I(1));f.Pc=63;continue;}
case 63:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?76:66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String(" (Exile them. While each one is exiled, its owner may cast it for {2} rather than its mana cost.)")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",72);}
case 72:{f.StackOp("pop");f.Pc=73;continue;}
case 73:{f.Pc=83;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String(" (Exile it. While it\u2019s exiled, its owner may cast it for {2} rather than its mana cost.)")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",87);}
case 87:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3009(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",19);}
case 19:{f.Locals[5]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[5]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",27);}
case 27:{f.Locals[6]=f.Pop();f.Pc=29;continue;}
case 29:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",36);}
case 36:{f.Locals[7]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/ability/effects/AirbendEffect","getCardsfromTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",42);}
case 42:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",47);}
case 47:{f.Locals[8]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[8]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",56);}
case 56:{f.Pc=f.Pop().Int==0?345:59;continue;}
case 59:{f.Push(f.Locals[8]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",66);}
case 66:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=69;continue;}
case 69:{f.Locals[9]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[9]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(null));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",78);}
case 78:{f.Locals[10]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[10]);f.Pc=82;continue;}
case 82:{f.Pc=f.Pop().Reference==null?49:85;continue;}
case 85:{f.Push(f.Locals[9]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[10]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int==0?49:95;continue;}
case 95:{f.Push(f.Locals[10]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int==0?106:103;continue;}
case 103:{f.Pc=49;continue;}
case 106:{f.Push(f.Locals[10]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/ability/effects/AirbendEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",112);}
case 112:{f.Push(JValue.R(null));f.Pc=113;continue;}
case 113:{f.Locals[11]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[10]);f.Pc=117;continue;}
case 117:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",123);}
case 123:{f.Pc=f.Pop().Int==0?148:126;continue;}
case 126:{f.Push(f.Locals[3]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",130);}
case 130:{f.Push(f.Locals[10]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/zone/MagicStack","getSpellMatchingHost","(Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokevirtual",135);}
case 135:{f.Locals[12]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[3]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",141);}
case 141:{f.Push(f.Locals[12]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/zone/MagicStack","getInstanceMatchingSpellAbilityID","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbilityStackInstance;","invokevirtual",146);}
case 146:{f.Locals[11]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[3]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",152);}
case 152:{f.Push(f.Locals[10]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[1]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[5]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/GameAction","exile","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",160);}
case 160:{f.Locals[12]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[12]);f.Pc=164;continue;}
case 164:{f.Pc=f.Pop().Reference==null?49:167;continue;}
case 167:{f.Push(f.Locals[12]);f.Pc=169;continue;}
case 169:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",175);}
case 175:{f.Pc=f.Pop().Int!=0?181:178;continue;}
case 178:{f.Pc=49;continue;}
case 181:{f.Push(f.Locals[11]);f.Pc=183;continue;}
case 183:{f.Pc=f.Pop().Reference==null?195:186;continue;}
case 186:{f.Push(f.Locals[3]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",190);}
case 190:{f.Push(f.Locals[11]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/game/zone/MagicStack","remove","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",195);}
case 195:{f.Push(f.Locals[6]);f.Pc=197;continue;}
case 197:{f.Push(JValue.R(null));f.Pc=198;continue;}
case 198:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",204);}
case 204:{f.Push(JValue.R(null));f.Pc=205;continue;}
case 205:{f.Push(JValue.R(null));f.Pc=206;continue;}
case 206:{f.Push(JValue.R(null));f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/card/CardZoneTable","filterCards","(Ljava/lang/Iterable;Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokevirtual",210);}
case 210:{f.Locals[13]=f.Pop();f.Pc=212;continue;}
case 212:{f.Push(f.Locals[13]);f.Pc=214;continue;}
case 214:{return rt.DynamicCall(f,"forge/game/ability/effects/AirbendEffect:3009:214:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",219);}
case 219:{return rt.Call(f,"forge/game/card/CardCollection","removeIf","(Ljava/util/function/Predicate;)Z","invokevirtual",222);}
case 222:{f.StackOp("pop");f.Pc=223;continue;}
case 223:{f.Push(f.Locals[13]);f.Pc=225;continue;}
case 225:{f.Push(f.Locals[7]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",230);}
case 230:{f.StackOp("pop");f.Pc=231;continue;}
case 231:{f.Push(f.Locals[13]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",236);}
case 236:{f.Pc=f.Pop().Int==0?242:239;continue;}
case 239:{f.Pc=49;continue;}
case 242:{f.Push(f.Locals[7]);f.Pc=244;continue;}
case 244:{f.Push(f.Locals[13]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",249);}
case 249:{f.StackOp("pop");f.Pc=250;continue;}
case 250:{f.Push(f.Locals[1]);f.Pc=251;continue;}
case 251:{f.Push(f.Locals[12]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",256);}
case 256:{f.Push(f.Locals[12]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",261);}
case 261:{return rt.DynamicCall(f,"forge/game/ability/effects/AirbendEffect:3009:261:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",266);}
case 266:{f.Push(f.Locals[2]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",270);}
case 270:{return rt.Call(f,"forge/game/ability/effects/AirbendEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Lforge/game/card/Card;","invokestatic",273);}
case 273:{f.Locals[14]=f.Pop();f.Pc=275;continue;}
case 275:{f.Push(f.Locals[14]);f.Pc=277;continue;}
case 277:{f.Push(f.Locals[13]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",282);}
case 282:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=285;continue;}
case 285:{f.StackOp("dup");f.Pc=286;continue;}
case 286:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",289);}
case 289:{f.Locals[15]=f.Pop();f.Pc=291;continue;}
case 291:{f.Push(f.Locals[15]);f.Pc=293;continue;}
case 293:{f.Push(JValue.R(rt.String("Mode$ Continuous | MayPlay$ True | MayPlayAltManaCost$ 2 | EffectZone$ Command | Affected$ Card.IsRemembered+nonLand")));f.Pc=295;continue;}
case 295:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",298);}
case 298:{f.StackOp("pop");f.Pc=299;continue;}
case 299:{f.Push(f.Locals[15]);f.Pc=301;continue;}
case 301:{f.Push(JValue.R(rt.String(" | AffectedZone$ Exile | Description$ You may cast the card.")));f.Pc=303;continue;}
case 303:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",306);}
case 306:{f.StackOp("pop");f.Pc=307;continue;}
case 307:{f.Push(f.Locals[14]);f.Pc=309;continue;}
case 309:{f.Push(f.Locals[15]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",314);}
case 314:{return rt.Call(f,"forge/game/card/Card","addStaticAbility","(Ljava/lang/String;)Lforge/game/staticability/StaticAbility;","invokevirtual",317);}
case 317:{f.StackOp("pop");f.Pc=318;continue;}
case 318:{f.Push(f.Locals[14]);f.Pc=320;continue;}
case 320:{f.Push(JValue.R(rt.String("Exile")));f.Pc=322;continue;}
case 322:{return rt.Call(f,"forge/game/ability/effects/AirbendEffect","addForgetOnMovedTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",325);}
case 325:{f.Push(f.Locals[14]);f.Pc=327;continue;}
case 327:{f.Push(JValue.R(rt.String("Card.IsRemembered")));f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/game/ability/effects/AirbendEffect","addForgetOnCastTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",332);}
case 332:{f.Push(f.Locals[3]);f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",336);}
case 336:{f.Push(f.Locals[14]);f.Pc=338;continue;}
case 338:{f.Push(f.Locals[1]);f.Pc=339;continue;}
case 339:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",342);}
case 342:{f.Pc=49;continue;}
case 345:{f.Push(f.Locals[6]);f.Pc=347;continue;}
case 347:{f.Push(f.Locals[3]);f.Pc=348;continue;}
case 348:{f.Push(f.Locals[1]);f.Pc=349;continue;}
case 349:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",352);}
case 352:{f.Push(f.Locals[6]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/card/CardZoneTable","allCards","()Ljava/lang/Iterable;","invokevirtual",357);}
case 357:{f.Push(f.Locals[1]);f.Pc=358;continue;}
case 358:{return rt.Call(f,"forge/game/ability/effects/AirbendEffect","handleExiledWith","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;)V","invokestatic",361);}
case 361:{f.Push(f.Locals[6]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/game/card/CardZoneTable","isEmpty","()Z","invokevirtual",366);}
case 366:{f.Pc=f.Pop().Int!=0?377:369;continue;}
case 369:{f.Push(f.Locals[4]);f.Pc=371;continue;}
case 371:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Airbend","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Airbend","Lforge/game/trigger/TriggerType;"));f.Pc=374;continue;}
case 374:{return rt.Call(f,"forge/game/player/Player","triggerElementalBend","(Lforge/game/trigger/TriggerType;)V","invokevirtual",377);}
case 377:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
