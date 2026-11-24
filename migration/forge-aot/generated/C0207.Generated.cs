// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C207{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/AssimilateEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("ANIMATE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Mode$ Continuous | Affected$ Card.IsRemembered | AddType$ Artifact & Creature & Borg | RemoveCreatureTypes$ True"));
c.Add(new JMethod(3041,"forge/game/ability/effects/AssimilateEffect","<init>","()V",1,1,1,new JHandler[]{},M3041));
c.Add(new JMethod(3042,"forge/game/ability/effects/AssimilateEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,1,new JHandler[]{},M3042));
c.Add(new JMethod(3043,"forge/game/ability/effects/AssimilateEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,12,5,new JHandler[]{},M3043));
c.Add(new JMethod(3044,"forge/game/ability/effects/AssimilateEffect","entering","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;",10,4,2,new JHandler[]{},M3044));
c.Add(new JMethod(3045,"forge/game/ability/effects/AssimilateEffect","animateInPlace","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/Game;)V",2,5,17,new JHandler[]{},M3045));
}

internal static JStep M3041(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3042(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/AssimilateEffect","getCardsfromTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",4);}
case 4:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",7);}
case 7:{return rt.DynamicCall(f,"forge/game/ability/effects/AssimilateEffect:3042:7:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3043(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"));f.Pc=16;continue;}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",26);}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/Game","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",30);}
case 30:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;)V","invokespecial",33);}
case 33:{f.Locals[5]=f.Pop();f.Pc=35;continue;}
case 35:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=38;continue;}
case 38:{f.StackOp("dup");f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",42);}
case 42:{f.Locals[6]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/ability/effects/AssimilateEffect","getCardsfromTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",48);}
case 48:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",53);}
case 53:{f.Locals[7]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[7]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",62);}
case 62:{f.Pc=f.Pop().Int==0?264:65;continue;}
case 65:{f.Push(f.Locals[7]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",72);}
case 72:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=75;continue;}
case 75:{f.Locals[8]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[8]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(null));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",84);}
case 84:{f.Locals[9]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[9]);f.Pc=88;continue;}
case 88:{f.Pc=f.Pop().Reference==null?55:91;continue;}
case 91:{f.Push(f.Locals[8]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[9]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?55:101;continue;}
case 101:{f.Push(f.Locals[9]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?112:109;continue;}
case 109:{f.Pc=55;continue;}
case 112:{f.Push(f.Locals[3]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[9]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",118);}
case 118:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int!=0?139:124;continue;}
case 124:{f.Push(f.Locals[9]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/card/Card","runChangeControllerCommands","()V","invokevirtual",129);}
case 129:{f.Push(f.Locals[9]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[3]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[2]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",136);}
case 136:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",139);}
case 139:{f.Push(f.Locals[9]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",144);}
case 144:{f.Pc=f.Pop().Int==0?169:147;continue;}
case 147:{f.Push(f.Locals[9]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[4]);f.Pc=151;continue;}
case 151:{f.Push(JValue.I(1));f.Pc=152;continue;}
case 152:{f.Push(f.Locals[3]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[6]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",158);}
case 158:{f.Push(f.Locals[0]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[9]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[1]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[2]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/ability/effects/AssimilateEffect","animateInPlace","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/Game;)V","invokevirtual",166);}
case 166:{f.Pc=261;continue;}
case 169:{f.Push(f.Locals[1]);f.Pc=170;continue;}
case 170:{f.Push(JValue.R(rt.String("StaticEffect")));f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.String("AssimilateAnimate")));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",177);}
case 177:{f.StackOp("pop");f.Pc=178;continue;}
case 178:{f.Push(f.Locals[1]);f.Pc=179;continue;}
case 179:{f.Push(JValue.R(rt.String("AssimilateAnimate")));f.Pc=181;continue;}
case 181:{f.Push(JValue.R(rt.String("Mode$ Continuous | Affected$ Card.IsRemembered | AddType$ Artifact & Creature & Borg | RemoveCreatureTypes$ True")));f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",186);}
case 186:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",189);}
case 189:{f.Locals[10]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(f.Locals[10]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[5]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",198);}
case 198:{f.Push(f.Locals[10]);f.Pc=200;continue;}
case 200:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SimultaneousETB","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SimultaneousETB","Lforge/game/ability/AbilityKey;"));f.Pc=203;continue;}
case 203:{f.Push(f.Locals[1]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/ability/effects/AssimilateEffect","entering","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",207);}
case 207:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",212);}
case 212:{f.StackOp("pop");f.Pc=213;continue;}
case 213:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=216;continue;}
case 216:{f.StackOp("dup");f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",220);}
case 220:{f.Locals[11]=f.Pop();f.Pc=222;continue;}
case 222:{f.Push(f.Locals[11]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[3]);f.Pc=225;continue;}
case 225:{f.Push(f.Locals[9]);f.Pc=227;continue;}
case 227:{f.Push(f.Locals[4]);f.Pc=229;continue;}
case 229:{f.Push(JValue.I(1));f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/GameEntityCounterTable","put","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)I","invokevirtual",233);}
case 233:{f.StackOp("pop");f.Pc=234;continue;}
case 234:{f.Push(f.Locals[10]);f.Pc=236;continue;}
case 236:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"));f.Pc=239;continue;}
case 239:{f.Push(f.Locals[11]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",246);}
case 246:{f.StackOp("pop");f.Pc=247;continue;}
case 247:{f.Push(f.Locals[2]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",251);}
case 251:{f.Push(f.Locals[9]);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[3]);f.Pc=254;continue;}
case 254:{f.Push(f.Locals[1]);f.Pc=255;continue;}
case 255:{f.Push(f.Locals[10]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/GameAction","moveToPlay","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",260);}
case 260:{f.StackOp("pop");f.Pc=261;continue;}
case 261:{f.Pc=55;continue;}
case 264:{f.Push(f.Locals[6]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[2]);f.Pc=267;continue;}
case 267:{f.Push(f.Locals[1]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",271);}
case 271:{f.Push(f.Locals[5]);f.Pc=273;continue;}
case 273:{f.Push(f.Locals[2]);f.Pc=274;continue;}
case 274:{f.Push(f.Locals[1]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",278);}
case 278:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3044(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/AssimilateEffect","getCardsfromTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",12);}
case 12:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?53:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int!=0?50:44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",49);}
case 49:{f.StackOp("pop");f.Pc=50;continue;}
case 50:{f.Pc=18;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3045(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardType","<init>","(Z)V","invokespecial",8);}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{f.Push(JValue.I(3));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("Artifact")));f.Pc=20;continue;}
case 20:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("Creature")));f.Pc=25;continue;}
case 25:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{f.Push(JValue.I(2));f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("Borg")));f.Pc=30;continue;}
case 30:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",34);}
case 34:{return rt.Call(f,"forge/card/CardType","addAll","(Ljava/lang/Iterable;)Z","invokevirtual",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("RemoveCreatureTypes")));f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("True")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",46);}
case 46:{f.StackOp("pop");f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(null));f.Pc=50;continue;}
case 50:{f.Push(JValue.R(null));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{f.Push(JValue.I(1));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/card/CardType","<init>","(Z)V","invokespecial",61);}
case 61:{f.Push(JValue.R(null));f.Pc=62;continue;}
case 62:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",65);}
case 65:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",68);}
case 68:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",71);}
case 71:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",74);}
case 74:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",77);}
case 77:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",80);}
case 80:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",83);}
case 83:{f.Push(f.Locals[3]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",87);}
case 87:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/ability/effects/AnimateEffectBase","doAnimate","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/lang/Integer;Ljava/lang/Integer;Lforge/card/CardType;Lforge/card/CardType;Lforge/card/ColorSet;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;JLjava/lang/String;)V","invokestatic",92);}
case 92:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
