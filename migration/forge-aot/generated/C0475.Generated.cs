// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C475{
internal static JClass Build(){var c=new JClass("forge/game/card/CardUtil","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("NON_STACKING_LIST","Ljava/util/List;",true,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("modifiableKeywords","Lcom/google/common/collect/ImmutableList;",true,JValue.Default("Lcom/google/common/collect/ImmutableList;"),null));
c.Add(new JMethod(5433,"forge/game/card/CardUtil","<init>","()V",2,1,1,new JHandler[]{},M5433));
c.Add(new JMethod(5434,"forge/game/card/CardUtil","isKeywordModifiable","(Ljava/lang/String;)Z",9,3,2,new JHandler[]{},M5434));
c.Add(new JMethod(5435,"forge/game/card/CardUtil","isStackingKeyword","(Ljava/lang/String;)Z",9,2,2,new JHandler[]{},M5435));
c.Add(new JMethod(5436,"forge/game/card/CardUtil","getThisTurnEntered","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/player/Player;)Ljava/util/List;",9,10,5,new JHandler[]{},M5436));
c.Add(new JMethod(5437,"forge/game/card/CardUtil","getLastTurnEntered","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/player/Player;)Ljava/util/List;",9,10,5,new JHandler[]{},M5437));
c.Add(new JMethod(5438,"forge/game/card/CardUtil","getThisTurnCast","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/player/Player;)Ljava/util/List;",9,4,5,new JHandler[]{},M5438));
c.Add(new JMethod(5439,"forge/game/card/CardUtil","getLastTurnCast","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/player/Player;)Ljava/util/List;",9,4,5,new JHandler[]{},M5439));
c.Add(new JMethod(5440,"forge/game/card/CardUtil","getThisTurnActivated","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/player/Player;)Ljava/util/List;",9,4,5,new JHandler[]{},M5440));
c.Add(new JMethod(5441,"forge/game/card/CardUtil","getCastSinceBeginningOfYourLastTurn","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/player/Player;)Ljava/util/List;",9,4,5,new JHandler[]{},M5441));
c.Add(new JMethod(5442,"forge/game/card/CardUtil","getRadiance","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;",9,15,5,new JHandler[]{},M5442));
c.Add(new JMethod(5443,"forge/game/card/CardUtil","getColorsFromCards","(Ljava/lang/Iterable;)Lforge/card/ColorSet;",9,4,2,new JHandler[]{},M5443));
c.Add(new JMethod(5444,"forge/game/card/CardUtil","getFaceDownCharacteristic","(Lforge/game/card/Card;)Lforge/game/card/CardState;",9,1,2,new JHandler[]{},M5444));
c.Add(new JMethod(5445,"forge/game/card/CardUtil","getFaceDownCharacteristic","(Lforge/game/card/Card;Lforge/card/CardStateName;)Lforge/game/card/CardState;",9,4,4,new JHandler[]{},M5445));
c.Add(new JMethod(5446,"forge/game/card/CardUtil","getEmptyRoomCharacteristic","(Lforge/game/card/Card;)Lforge/game/card/CardState;",9,1,2,new JHandler[]{},M5446));
c.Add(new JMethod(5447,"forge/game/card/CardUtil","getEmptyRoomCharacteristic","(Lforge/game/card/Card;Lforge/card/CardStateName;)Lforge/game/card/CardState;",9,4,4,new JHandler[]{},M5447));
c.Add(new JMethod(5448,"forge/game/card/CardUtil","getReflectableManaColors","(Lforge/game/spellability/SpellAbility;)Ljava/util/Set;",9,1,5,new JHandler[]{},M5448));
c.Add(new JMethod(5449,"forge/game/card/CardUtil","getReflectableManaColors","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Ljava/util/Set;Lforge/game/card/CardCollection;)Ljava/util/Set;",10,14,5,new JHandler[]{},M5449));
c.Add(new JMethod(5450,"forge/game/card/CardUtil","canProduce","(ILforge/game/spellability/SpellAbility;Ljava/util/Set;)Ljava/util/Set;",9,5,2,new JHandler[]{},M5450));
c.Add(new JMethod(5451,"forge/game/card/CardUtil","getValidCardsToTarget","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;",9,8,2,new JHandler[]{},M5451));
c.Add(new JMethod(5452,"forge/game/card/CardUtil","turnToRightFace","(Ljava/lang/String;Lforge/game/card/Card;)V",9,4,2,new JHandler[]{},M5452));
c.Add(new JMethod(5453,"forge/game/card/CardUtil","<clinit>","()V",8,0,5,new JHandler[]{},M5453));
}

internal static JStep M5433(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5434(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/card/CardUtil","modifiableKeywords","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardUtil","modifiableKeywords","Lcom/google/common/collect/ImmutableList;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"com/google/common/collect/ImmutableList","iterator","()Lcom/google/common/collect/UnmodifiableIterator;","invokevirtual",6);}
case 6:{f.Locals[1]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?39:16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?36:34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 36:{f.Pc=7;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5435(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("HIDDEN")));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?18:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(JValue.I(7));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Locals[1]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Protection")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int!=0?43:27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/game/card/CardUtil","NON_STACKING_LIST","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardUtil","NON_STACKING_LIST","Ljava/util/List;"));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",36);}
case 36:{f.Pc=f.Pop().Int!=0?43:39;continue;}
case 39:{f.Push(JValue.I(1));f.Pc=40;continue;}
case 40:{f.Pc=44;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5436(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[6]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[7]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=15;continue;}
case 15:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?74:18;continue;}
case 18:{f.Push(f.Locals[7]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/Game","getRegisteredPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",26);}
case 26:{f.Locals[8]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[8]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int==0?71:38;continue;}
case 38:{f.Push(f.Locals[8]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",45);}
case 45:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=48;continue;}
case 48:{f.Locals[9]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[6]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[9]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",58);}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/zone/PlayerZone","getCardsAddedThisTurn","(Lforge/game/zone/ZoneType;)Ljava/util/List;","invokevirtual",62);}
case 62:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",67);}
case 67:{f.StackOp("pop");f.Pc=68;continue;}
case 68:{f.Pc=28;continue;}
case 71:{f.Pc=91;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[7]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;","invokevirtual",81);}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/zone/Zone","getCardsAddedThisTurn","(Lforge/game/zone/ZoneType;)Ljava/util/List;","invokevirtual",85);}
case 85:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",90);}
case 90:{f.StackOp("pop");f.Pc=91;continue;}
case 91:{f.Push(f.Locals[6]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[5]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/card/CardLists","getValidCardsAsList","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/List;","invokestatic",102);}
case 102:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5437(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[6]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[7]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=15;continue;}
case 15:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?74:18;continue;}
case 18:{f.Push(f.Locals[7]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",26);}
case 26:{f.Locals[8]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[8]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int==0?71:38;continue;}
case 38:{f.Push(f.Locals[8]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",45);}
case 45:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=48;continue;}
case 48:{f.Locals[9]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[6]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[9]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",58);}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/zone/PlayerZone","getCardsAddedLastTurn","(Lforge/game/zone/ZoneType;)Ljava/util/List;","invokevirtual",62);}
case 62:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",67);}
case 67:{f.StackOp("pop");f.Pc=68;continue;}
case 68:{f.Pc=28;continue;}
case 71:{f.Pc=91;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[7]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;","invokevirtual",81);}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/zone/Zone","getCardsAddedLastTurn","(Lforge/game/zone/ZoneType;)Ljava/util/List;","invokevirtual",85);}
case 85:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",90);}
case 90:{f.StackOp("pop");f.Pc=91;continue;}
case 91:{f.Push(f.Locals[6]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[5]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/card/CardLists","getValidCardsAsList","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/List;","invokestatic",102);}
case 102:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5438(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/zone/MagicStack","getSpellCardsCastThisTurn","()Ljava/util/List;","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/CardLists","getValidCardsAsList","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/List;","invokestatic",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5439(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/zone/MagicStack","getSpellsCastLastTurn","()Ljava/util/List;","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/CardLists","getValidCardsAsList","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/List;","invokestatic",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5440(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/zone/MagicStack","getAbilityActivatedThisTurn","()Ljava/util/List;","invokevirtual",10);}
case 10:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",15);}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String(",")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbilityPredicates","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",27);}
case 27:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",32);}
case 32:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",35);}
case 35:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5441(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getSpellsCastSinceBegOfYourLastTurn","()Ljava/util/List;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardLists","getValidCardsAsList","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/List;","invokestatic",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5442(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSATargetingCard","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?25:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?25:16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Radiance")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int!=0?33:25;continue;}
case 25:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",32);}
case 32:{return JStep.Return(f.Pop());}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",37);}
case 37:{f.Locals[2]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",42);}
case 42:{f.Locals[3]=f.Pop();f.Pc=43;continue;}
case 43:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=46;continue;}
case 46:{f.StackOp("dup");f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",50);}
case 50:{f.Locals[4]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{f.Push(JValue.R(rt.String("ValidTgts")));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",58);}
case 58:{f.Push(JValue.R(rt.String(",")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",63);}
case 63:{f.Locals[5]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",69);}
case 69:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",72);}
case 72:{f.Locals[6]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(JValue.I(0));f.Pc=75;continue;}
case 75:{f.Locals[7]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[6]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",84);}
case 84:{f.Locals[8]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[8]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",93);}
case 93:{f.Pc=f.Pop().Int==0?172:96;continue;}
case 96:{f.Push(f.Locals[8]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",103);}
case 103:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=106;continue;}
case 106:{f.Locals[9]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[9]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",113);}
case 113:{f.Locals[10]=f.Pop();f.Pc=115;continue;}
case 115:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=118;continue;}
case 118:{f.Locals[11]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[11]);f.Pc=122;continue;}
case 122:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=123;continue;}
case 123:{f.Locals[12]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(JValue.I(0));f.Pc=126;continue;}
case 126:{f.Locals[13]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[13]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[12]);f.Pc=132;continue;}
case 132:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?169:135;continue;}
case 135:{f.Push(f.Locals[11]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[13]);f.Pc=139;continue;}
case 139:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=140;continue;}
case 140:{f.Locals[14]=f.Pop();f.Pc=142;continue;}
case 142:{f.Push(f.Locals[10]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[14]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",149);}
case 149:{f.Pc=f.Pop().Int!=0?155:152;continue;}
case 152:{f.Pc=163;continue;}
case 155:{f.Push(f.Locals[7]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[14]);f.Pc=159;continue;}
case 159:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=160;continue;}
case 160:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=161;continue;}
case 161:{f.Locals[7]=f.Pop();f.Pc=163;continue;}
case 163:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(1)));f.Pc=166;continue;}
case 166:{f.Pc=128;continue;}
case 169:{f.Pc=86;continue;}
case 172:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=175;continue;}
case 175:{f.Locals[8]=f.Pop();f.Pc=177;continue;}
case 177:{f.Push(f.Locals[8]);f.Pc=179;continue;}
case 179:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=180;continue;}
case 180:{f.Locals[9]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(JValue.I(0));f.Pc=183;continue;}
case 183:{f.Locals[10]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[10]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[9]);f.Pc=189;continue;}
case 189:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?300:192;continue;}
case 192:{f.Push(f.Locals[8]);f.Pc=194;continue;}
case 194:{f.Push(f.Locals[10]);f.Pc=196;continue;}
case 196:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=197;continue;}
case 197:{f.Locals[11]=f.Pop();f.Pc=199;continue;}
case 199:{f.Push(f.Locals[7]);f.Pc=201;continue;}
case 201:{f.Push(f.Locals[11]);f.Pc=203;continue;}
case 203:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=204;continue;}
case 204:{f.Pc=f.Pop().Int!=0?210:207;continue;}
case 207:{f.Pc=294;continue;}
case 210:{f.Push(f.Locals[3]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[11]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/Game","getColoredCardsInPlay","(B)Lforge/game/card/CardCollectionView;","invokevirtual",216);}
case 216:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",221);}
case 221:{f.Locals[12]=f.Pop();f.Pc=223;continue;}
case 223:{f.Push(f.Locals[12]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",230);}
case 230:{f.Pc=f.Pop().Int==0?294:233;continue;}
case 233:{f.Push(f.Locals[12]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",240);}
case 240:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=243;continue;}
case 243:{f.Locals[13]=f.Pop();f.Pc=245;continue;}
case 245:{f.Push(f.Locals[4]);f.Pc=247;continue;}
case 247:{f.Push(f.Locals[13]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",252);}
case 252:{f.Pc=f.Pop().Int!=0?291:255;continue;}
case 255:{f.Push(f.Locals[6]);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[13]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",264);}
case 264:{f.Pc=f.Pop().Int!=0?291:267;continue;}
case 267:{f.Push(f.Locals[13]);f.Pc=269;continue;}
case 269:{f.Push(f.Locals[5]);f.Pc=271;continue;}
case 271:{f.Push(f.Locals[2]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",275);}
case 275:{f.Push(f.Locals[2]);f.Pc=276;continue;}
case 276:{f.Push(f.Locals[1]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/card/Card","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",280);}
case 280:{f.Pc=f.Pop().Int==0?291:283;continue;}
case 283:{f.Push(f.Locals[4]);f.Pc=285;continue;}
case 285:{f.Push(f.Locals[13]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",290);}
case 290:{f.StackOp("pop");f.Pc=291;continue;}
case 291:{f.Pc=223;continue;}
case 294:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=297;continue;}
case 297:{f.Pc=185;continue;}
case 300:{f.Push(f.Locals[4]);f.Pc=302;continue;}
case 302:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5443(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int==0?42:18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Locals[3]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",33);}
case 33:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",36);}
case 36:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=37;continue;}
case 37:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=38;continue;}
case 38:{f.Locals[1]=f.Pop();f.Pc=39;continue;}
case 39:{f.Pc=9;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",46);}
case 46:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5444(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/card/CardStateName","FaceDown","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","FaceDown","Lforge/card/CardStateName;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardUtil","getFaceDownCharacteristic","(Lforge/game/card/Card;Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5445(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardType","<init>","(Z)V","invokespecial",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("Creature")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/CardType","add","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.StackOp("pop");f.Pc=17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"forge/game/card/CardState"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardState")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/CardState","<init>","(Lforge/game/card/Card;Lforge/card/CardStateName;)V","invokespecial",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{f.Push(JValue.I(2));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/CardState","setBasePower","(I)V","invokevirtual",32);}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{f.Push(JValue.I(2));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/card/CardState","setBaseToughness","(I)V","invokevirtual",37);}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/card/CardState","setName","(Ljava/lang/String;)V","invokevirtual",44);}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/CardState","setType","(Lforge/card/CardType;)V","invokevirtual",49);}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/card/CardStateName","FaceDown","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","FaceDown","Lforge/card/CardStateName;"));f.Pc=53;continue;}
case 53:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?69:56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String("hidden")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/ImageKeys","getTokenKey","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",63);}
case 63:{return rt.Call(f,"forge/game/card/CardState","setImageKey","(Ljava/lang/String;)V","invokevirtual",66);}
case 66:{f.Pc=77;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",74);}
case 74:{return rt.Call(f,"forge/game/card/CardState","setImageKey","(Ljava/lang/String;)V","invokevirtual",77);}
case 77:{f.Push(f.Locals[3]);f.Pc=78;continue;}
case 78:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5446(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/card/CardStateName","EmptyRoom","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","EmptyRoom","Lforge/card/CardStateName;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardUtil","getEmptyRoomCharacteristic","(Lforge/game/card/Card;Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5447(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardType","<init>","(Z)V","invokespecial",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("Enchantment")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/CardType","add","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.StackOp("pop");f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("Room")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/card/CardType","add","(Ljava/lang/String;)Z","invokevirtual",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{if(!rt.EnsureInitialized(f,"forge/game/card/CardState"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardState")));f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/CardState","<init>","(Lforge/game/card/Card;Lforge/card/CardStateName;)V","invokespecial",34);}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/CardState","setName","(Ljava/lang/String;)V","invokevirtual",42);}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/CardState","setType","(Lforge/card/CardType;)V","invokevirtual",47);}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",52);}
case 52:{return rt.Call(f,"forge/game/card/CardState","setImageKey","(Ljava/lang/String;)V","invokevirtual",55);}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5448(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",5);}
case 5:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",12);}
case 12:{return rt.Call(f,"forge/game/card/CardUtil","getReflectableManaColors","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Ljava/util/Set;Lforge/game/card/CardCollection;)Ljava/util/Set;","invokestatic",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5449(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",10);}
case 10:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ManaReflected","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ManaReflected","Lforge/game/ability/ApiType;"));f.Pc=13;continue;}
case 13:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?18:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("ColorOrType")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",25);}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("ReflectProperty")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Locals[6]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{f.Locals[7]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("Type")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?53:50;continue;}
case 50:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("Valid")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int==0?172:63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("Valid")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",70);}
case 70:{f.Locals[9]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[9]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("Defined.")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int==0?105:83;continue;}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[9]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("Defined.")));f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",96);}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",100);}
case 100:{f.Locals[8]=f.Pop();f.Pc=102;continue;}
case 102:{f.Pc=152;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Reference!=null?123:112;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",117);}
case 117:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",120);}
case 120:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",123);}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",127);}
case 127:{f.Locals[10]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[10]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",134);}
case 134:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",140);}
case 140:{f.Push(f.Locals[9]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[10]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[4]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",150);}
case 150:{f.Locals[8]=f.Pop();f.Pc=152;continue;}
case 152:{f.Push(f.Locals[8]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[3]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",158);}
case 158:{f.StackOp("pop");f.Pc=159;continue;}
case 159:{f.Push(f.Locals[8]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Int==0?169:167;continue;}
case 167:{f.Push(f.Locals[2]);f.Pc=168;continue;}
case 168:{return JStep.Return(f.Pop());}
case 169:{f.Pc=181;continue;}
case 172:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=175;continue;}
case 175:{f.StackOp("dup");f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",179);}
case 179:{f.Locals[8]=f.Pop();f.Pc=181;continue;}
case 181:{f.Push(f.Locals[6]);f.Pc=183;continue;}
case 183:{f.Push(JValue.R(rt.String("Is")));f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",189);}
case 189:{f.Pc=f.Pop().Int==0?293:192;continue;}
case 192:{f.Push(f.Locals[8]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",197);}
case 197:{f.Locals[9]=f.Pop();f.Pc=199;continue;}
case 199:{f.Push(f.Locals[9]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",206);}
case 206:{f.Pc=f.Pop().Int==0?290:209;continue;}
case 209:{f.Push(f.Locals[9]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",216);}
case 216:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=219;continue;}
case 219:{f.Locals[10]=f.Pop();f.Pc=221;continue;}
case 221:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","ONLY_COLORS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","ONLY_COLORS","Lcom/google/common/collect/ImmutableList;"));f.Pc=224;continue;}
case 224:{return rt.Call(f,"com/google/common/collect/ImmutableList","iterator","()Lcom/google/common/collect/UnmodifiableIterator;","invokevirtual",227);}
case 227:{f.Locals[11]=f.Pop();f.Pc=229;continue;}
case 229:{f.Push(f.Locals[11]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",236);}
case 236:{f.Pc=f.Pop().Int==0?287:239;continue;}
case 239:{f.Push(f.Locals[11]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",246);}
case 246:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=249;continue;}
case 249:{f.Locals[12]=f.Pop();f.Pc=251;continue;}
case 251:{f.Push(f.Locals[10]);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[12]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/card/Card","isOfColor","(Ljava/lang/String;)Z","invokevirtual",258);}
case 258:{f.Pc=f.Pop().Int==0?284:261;continue;}
case 261:{f.Push(f.Locals[2]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[12]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",269);}
case 269:{f.StackOp("pop");f.Pc=270;continue;}
case 270:{f.Push(f.Locals[2]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",276);}
case 276:{f.Push(f.Locals[7]);f.Pc=278;continue;}
case 278:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?284:281;continue;}
case 281:{f.Pc=287;continue;}
case 284:{f.Pc=229;continue;}
case 287:{f.Pc=199;continue;}
case 290:{f.Pc=743;continue;}
case 293:{f.Push(f.Locals[6]);f.Pc=295;continue;}
case 295:{f.Push(JValue.R(rt.String("Produced")));f.Pc=298;continue;}
case 298:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",301);}
case 301:{f.Pc=f.Pop().Int==0?420:304;continue;}
case 304:{f.Push(f.Locals[0]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",308);}
case 308:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"));f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",314);}
case 314:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=317;continue;}
case 317:{f.Locals[9]=f.Pop();f.Pc=319;continue;}
case 319:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","ONLY_COLORS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","ONLY_COLORS","Lcom/google/common/collect/ImmutableList;"));f.Pc=322;continue;}
case 322:{return rt.Call(f,"com/google/common/collect/ImmutableList","iterator","()Lcom/google/common/collect/UnmodifiableIterator;","invokevirtual",325);}
case 325:{f.Locals[10]=f.Pop();f.Pc=327;continue;}
case 327:{f.Push(f.Locals[10]);f.Pc=329;continue;}
case 329:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",334);}
case 334:{f.Pc=f.Pop().Int==0?378:337;continue;}
case 337:{f.Push(f.Locals[10]);f.Pc=339;continue;}
case 339:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",344);}
case 344:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=347;continue;}
case 347:{f.Locals[11]=f.Pop();f.Pc=349;continue;}
case 349:{f.Push(f.Locals[11]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/card/MagicColor","toShortString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",354);}
case 354:{f.Locals[12]=f.Pop();f.Pc=356;continue;}
case 356:{f.Push(f.Locals[9]);f.Pc=358;continue;}
case 358:{f.Push(f.Locals[12]);f.Pc=360;continue;}
case 360:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",363);}
case 363:{f.Pc=f.Pop().Int==0?375:366;continue;}
case 366:{f.Push(f.Locals[2]);f.Pc=367;continue;}
case 367:{f.Push(f.Locals[11]);f.Pc=369;continue;}
case 369:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",374);}
case 374:{f.StackOp("pop");f.Pc=375;continue;}
case 375:{f.Pc=327;continue;}
case 378:{f.Push(f.Locals[7]);f.Pc=380;continue;}
case 380:{f.Push(JValue.I(6));f.Pc=382;continue;}
case 382:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?417:385;continue;}
case 385:{f.Push(f.Locals[9]);f.Pc=387;continue;}
case 387:{f.Push(JValue.R(rt.String("1")));f.Pc=390;continue;}
case 390:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",393);}
case 393:{f.Pc=f.Pop().Int!=0?407:396;continue;}
case 396:{f.Push(f.Locals[9]);f.Pc=398;continue;}
case 398:{f.Push(JValue.R(rt.String("C")));f.Pc=401;continue;}
case 401:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",404);}
case 404:{f.Pc=f.Pop().Int==0?417:407;continue;}
case 407:{f.Push(f.Locals[2]);f.Pc=408;continue;}
case 408:{f.Push(JValue.R(rt.String("colorless")));f.Pc=411;continue;}
case 411:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",416);}
case 416:{f.StackOp("pop");f.Pc=417;continue;}
case 417:{f.Pc=743;continue;}
case 420:{f.Push(f.Locals[6]);f.Pc=422;continue;}
case 422:{f.Push(JValue.R(rt.String("Produce")));f.Pc=425;continue;}
case 425:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",428);}
case 428:{f.Pc=f.Pop().Int==0?743:431;continue;}
case 431:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=434;continue;}
case 434:{f.StackOp("dup");f.Pc=435;continue;}
case 435:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",438);}
case 438:{f.Locals[9]=f.Pop();f.Pc=440;continue;}
case 440:{f.Push(f.Locals[8]);f.Pc=442;continue;}
case 442:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",445);}
case 445:{f.Locals[10]=f.Pop();f.Pc=447;continue;}
case 447:{f.Push(f.Locals[10]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",454);}
case 454:{f.Pc=f.Pop().Int==0?531:457;continue;}
case 457:{f.Push(f.Locals[10]);f.Pc=459;continue;}
case 459:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",464);}
case 464:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=467;continue;}
case 467:{f.Locals[11]=f.Pop();f.Pc=469;continue;}
case 469:{f.Push(f.Locals[9]);f.Pc=471;continue;}
case 471:{f.Push(f.Locals[11]);f.Pc=473;continue;}
case 473:{return rt.Call(f,"forge/game/card/Card","getSpellAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",476);}
case 476:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",479);}
case 479:{f.StackOp("pop");f.Pc=480;continue;}
case 480:{f.Push(f.Locals[11]);f.Pc=482;continue;}
case 482:{return rt.Call(f,"forge/game/card/Card","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",485);}
case 485:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",490);}
case 490:{f.Locals[12]=f.Pop();f.Pc=492;continue;}
case 492:{f.Push(f.Locals[12]);f.Pc=494;continue;}
case 494:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",499);}
case 499:{f.Pc=f.Pop().Int==0?528:502;continue;}
case 502:{f.Push(f.Locals[12]);f.Pc=504;continue;}
case 504:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",509);}
case 509:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=512;continue;}
case 512:{f.Locals[13]=f.Pop();f.Pc=514;continue;}
case 514:{f.Push(f.Locals[9]);f.Pc=516;continue;}
case 516:{f.Push(f.Locals[13]);f.Pc=518;continue;}
case 518:{return rt.Call(f,"forge/game/trigger/Trigger","ensureAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",521);}
case 521:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",524);}
case 524:{f.StackOp("pop");f.Pc=525;continue;}
case 525:{f.Pc=492;continue;}
case 528:{f.Pc=447;continue;}
case 531:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",534);}
case 534:{f.Locals[10]=f.Pop();f.Pc=536;continue;}
case 536:{f.Push(f.Locals[9]);f.Pc=538;continue;}
case 538:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",541);}
case 541:{f.Locals[11]=f.Pop();f.Pc=543;continue;}
case 543:{f.Push(f.Locals[11]);f.Pc=545;continue;}
case 545:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",550);}
case 550:{f.Pc=f.Pop().Int==0?686:553;continue;}
case 553:{f.Push(f.Locals[11]);f.Pc=555;continue;}
case 555:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",560);}
case 560:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=563;continue;}
case 563:{f.Locals[12]=f.Pop();f.Pc=565;continue;}
case 565:{f.Push(f.Locals[12]);f.Pc=567;continue;}
case 567:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",570);}
case 570:{f.Pc=f.Pop().Int!=0?543:573;continue;}
case 573:{f.Push(f.Locals[12]);f.Pc=575;continue;}
case 575:{return rt.Call(f,"forge/game/spellability/SpellAbility","isLandAbility","()Z","invokevirtual",578);}
case 578:{f.Pc=f.Pop().Int==0?584:581;continue;}
case 581:{f.Pc=543;continue;}
case 584:{f.Push(f.Locals[7]);f.Pc=586;continue;}
case 586:{f.Push(f.Locals[2]);f.Pc=587;continue;}
case 587:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",592);}
case 592:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?598:595;continue;}
case 595:{f.Pc=686;continue;}
case 598:{f.Push(f.Locals[3]);f.Pc=599;continue;}
case 599:{f.Push(f.Locals[12]);f.Pc=601;continue;}
case 601:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",604);}
case 604:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",607);}
case 607:{f.Pc=f.Pop().Int!=0?620:610;continue;}
case 610:{f.Push(f.Locals[3]);f.Pc=611;continue;}
case 611:{f.Push(f.Locals[12]);f.Pc=613;continue;}
case 613:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",616);}
case 616:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",619);}
case 619:{f.StackOp("pop");f.Pc=620;continue;}
case 620:{f.Push(f.Locals[12]);f.Pc=622;continue;}
case 622:{f.Push(f.Locals[12]);f.Pc=624;continue;}
case 624:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",627);}
case 627:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",630);}
case 630:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",633);}
case 633:{f.Push(f.Locals[12]);f.Pc=635;continue;}
case 635:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",638);}
case 638:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ManaReflected","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ManaReflected","Lforge/game/ability/ApiType;"));f.Pc=641;continue;}
case 641:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?674:644;continue;}
case 644:{f.Push(JValue.R(rt.String("Produced")));f.Pc=647;continue;}
case 647:{f.Push(f.Locals[12]);f.Pc=649;continue;}
case 649:{f.Push(JValue.R(rt.String("ReflectProperty")));f.Pc=652;continue;}
case 652:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",655);}
case 655:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",658);}
case 658:{f.Pc=f.Pop().Int!=0?674:661;continue;}
case 661:{f.Push(f.Locals[10]);f.Pc=663;continue;}
case 663:{f.Push(f.Locals[12]);f.Pc=665;continue;}
case 665:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",670);}
case 670:{f.StackOp("pop");f.Pc=671;continue;}
case 671:{f.Pc=543;continue;}
case 674:{f.Push(f.Locals[7]);f.Pc=676;continue;}
case 676:{f.Push(f.Locals[12]);f.Pc=678;continue;}
case 678:{f.Push(f.Locals[2]);f.Pc=679;continue;}
case 679:{return rt.Call(f,"forge/game/card/CardUtil","canProduce","(ILforge/game/spellability/SpellAbility;Ljava/util/Set;)Ljava/util/Set;","invokestatic",682);}
case 682:{f.Locals[2]=f.Pop();f.Pc=683;continue;}
case 683:{f.Pc=543;continue;}
case 686:{f.Push(f.Locals[10]);f.Pc=688;continue;}
case 688:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",693);}
case 693:{f.Locals[11]=f.Pop();f.Pc=695;continue;}
case 695:{f.Push(f.Locals[11]);f.Pc=697;continue;}
case 697:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",702);}
case 702:{f.Pc=f.Pop().Int==0?743:705;continue;}
case 705:{f.Push(f.Locals[11]);f.Pc=707;continue;}
case 707:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",712);}
case 712:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=715;continue;}
case 715:{f.Locals[12]=f.Pop();f.Pc=717;continue;}
case 717:{f.Push(f.Locals[7]);f.Pc=719;continue;}
case 719:{f.Push(f.Locals[2]);f.Pc=720;continue;}
case 720:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",725);}
case 725:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?731:728;continue;}
case 728:{f.Pc=743;continue;}
case 731:{f.Push(f.Locals[1]);f.Pc=732;continue;}
case 732:{f.Push(f.Locals[12]);f.Pc=734;continue;}
case 734:{f.Push(f.Locals[2]);f.Pc=735;continue;}
case 735:{f.Push(f.Locals[3]);f.Pc=736;continue;}
case 736:{return rt.Call(f,"forge/game/card/CardUtil","getReflectableManaColors","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Ljava/util/Set;Lforge/game/card/CardCollection;)Ljava/util/Set;","invokestatic",739);}
case 739:{f.Locals[2]=f.Pop();f.Pc=740;continue;}
case 740:{f.Pc=695;continue;}
case 743:{f.Push(f.Locals[2]);f.Pc=744;continue;}
case 744:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5450(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","ONLY_COLORS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","ONLY_COLORS","Lcom/google/common/collect/ImmutableList;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"com/google/common/collect/ImmutableList","iterator","()Lcom/google/common/collect/UnmodifiableIterator;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?57:22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/card/MagicColor","toShortString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",39);}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","canProduce","(Ljava/lang/String;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?54:45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",53);}
case 53:{f.StackOp("pop");f.Pc=54;continue;}
case 54:{f.Pc=13;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(JValue.I(6));f.Pc=60;continue;}
case 60:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?83:63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("C")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/spellability/SpellAbility","canProduce","(Ljava/lang/String;)Z","invokevirtual",70);}
case 70:{f.Pc=f.Pop().Int==0?83:73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("colorless")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5451(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getZone","()Ljava/util/List;","invokevirtual",22);}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",30);}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/CardLists","getTargetableCards","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",34);}
case 34:{f.Locals[5]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",46);}
case 46:{f.Locals[6]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[6]);f.Pc=50;continue;}
case 50:{f.Pc=f.Pop().Int==0?70:53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int==0?70:63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",74);}
case 74:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",77);}
case 77:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",80);}
case 80:{f.Locals[7]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[7]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",89);}
case 89:{f.StackOp("pop");f.Pc=90;continue;}
case 90:{f.Push(f.Locals[5]);f.Pc=92;continue;}
case 92:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5452(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int!=0?139:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",18);}
case 18:{if(!rt.StaticReady(f,"forge/card/CardSplitType","Specialize","Lforge/card/CardSplitType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","Specialize","Lforge/card/CardSplitType;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/card/CardSplitType","equals","(Ljava/lang/Object;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?106:27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/card/CardRules","getSpecializeParts","()Ljava/util/Map;","invokevirtual",34);}
case 34:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",39);}
case 39:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",44);}
case 44:{f.Locals[2]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",51);}
case 51:{f.Pc=f.Pop().Int==0?103:54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",60);}
case 60:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=63;continue;}
case 63:{f.Locals[3]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",71);}
case 71:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",79);}
case 79:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",82);}
case 82:{f.Pc=f.Pop().Int==0?100:85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",92);}
case 92:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardStateName"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/card/Card","changeToState","(Lforge/card/CardStateName;)Z","invokevirtual",98);}
case 98:{f.StackOp("pop");f.Pc=99;continue;}
case 99:{return JStep.ReturnVoid;}
case 100:{f.Pc=45;continue;}
case 103:{f.Pc=139;continue;}
case 106:{f.Push(f.Locals[1]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",111);}
case 111:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",114);}
case 114:{return rt.Call(f,"forge/card/CardSplitType","getChangedStateName","()Lforge/card/CardStateName;","invokevirtual",117);}
case 117:{return rt.Call(f,"forge/game/card/Card","changeToState","(Lforge/card/CardStateName;)Z","invokevirtual",120);}
case 120:{f.StackOp("pop");f.Pc=121;continue;}
case 121:{f.Push(f.Locals[1]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/card/Card","getCurrentStateName","()Lforge/card/CardStateName;","invokevirtual",125);}
case 125:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;"));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int==0?139:134;continue;}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{f.Push(JValue.I(1));f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/card/Card","setBackSide","(Z)V","invokevirtual",139);}
case 139:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5453(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{if(!rt.StaticReady(f,"forge/game/card/CardUtil","NON_STACKING_LIST","Ljava/util/List;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardUtil","NON_STACKING_LIST","Ljava/util/List;",f.Pop());f.Pc=6;continue;}
case 6:{return rt.Call(f,"com/google/common/collect/ImmutableList","builder","()Lcom/google/common/collect/ImmutableList$Builder;","invokestatic",9);}
case 9:{f.Push(JValue.I(47));f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("Enchant")));f.Pc=19;continue;}
case 19:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("Protection")));f.Pc=24;continue;}
case 24:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{f.Push(JValue.I(2));f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("Cumulative upkeep")));f.Pc=30;continue;}
case 30:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{f.Push(JValue.I(3));f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("Equip")));f.Pc=36;continue;}
case 36:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{f.Push(JValue.I(4));f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("Buyback")));f.Pc=42;continue;}
case 42:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=43;continue;}
case 43:{f.StackOp("dup");f.Pc=44;continue;}
case 44:{f.Push(JValue.I(5));f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("Cycling")));f.Pc=48;continue;}
case 48:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=49;continue;}
case 49:{f.StackOp("dup");f.Pc=50;continue;}
case 50:{f.Push(JValue.I(6));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("Echo")));f.Pc=55;continue;}
case 55:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{f.Push(JValue.I(7));f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("Kicker")));f.Pc=62;continue;}
case 62:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=63;continue;}
case 63:{f.StackOp("dup");f.Pc=64;continue;}
case 64:{f.Push(JValue.I(8));f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("Flashback")));f.Pc=69;continue;}
case 69:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=70;continue;}
case 70:{f.StackOp("dup");f.Pc=71;continue;}
case 71:{f.Push(JValue.I(9));f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("Madness")));f.Pc=76;continue;}
case 76:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=77;continue;}
case 77:{f.StackOp("dup");f.Pc=78;continue;}
case 78:{f.Push(JValue.I(10));f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("Morph")));f.Pc=83;continue;}
case 83:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=84;continue;}
case 84:{f.StackOp("dup");f.Pc=85;continue;}
case 85:{f.Push(JValue.I(11));f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("Affinity")));f.Pc=90;continue;}
case 90:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=91;continue;}
case 91:{f.StackOp("dup");f.Pc=92;continue;}
case 92:{f.Push(JValue.I(12));f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("Entwine")));f.Pc=97;continue;}
case 97:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=98;continue;}
case 98:{f.StackOp("dup");f.Pc=99;continue;}
case 99:{f.Push(JValue.I(13));f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("Splice")));f.Pc=104;continue;}
case 104:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=105;continue;}
case 105:{f.StackOp("dup");f.Pc=106;continue;}
case 106:{f.Push(JValue.I(14));f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("Ninjutsu")));f.Pc=111;continue;}
case 111:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=112;continue;}
case 112:{f.StackOp("dup");f.Pc=113;continue;}
case 113:{f.Push(JValue.I(15));f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String("Transmute")));f.Pc=118;continue;}
case 118:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=119;continue;}
case 119:{f.StackOp("dup");f.Pc=120;continue;}
case 120:{f.Push(JValue.I(16));f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("Replicate")));f.Pc=125;continue;}
case 125:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=126;continue;}
case 126:{f.StackOp("dup");f.Pc=127;continue;}
case 127:{f.Push(JValue.I(17));f.Pc=129;continue;}
case 129:{f.Push(JValue.R(rt.String("Recover")));f.Pc=132;continue;}
case 132:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=133;continue;}
case 133:{f.StackOp("dup");f.Pc=134;continue;}
case 134:{f.Push(JValue.I(18));f.Pc=136;continue;}
case 136:{f.Push(JValue.R(rt.String("Squad")));f.Pc=139;continue;}
case 139:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=140;continue;}
case 140:{f.StackOp("dup");f.Pc=141;continue;}
case 141:{f.Push(JValue.I(19));f.Pc=143;continue;}
case 143:{f.Push(JValue.R(rt.String("Suspend")));f.Pc=146;continue;}
case 146:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=147;continue;}
case 147:{f.StackOp("dup");f.Pc=148;continue;}
case 148:{f.Push(JValue.I(20));f.Pc=150;continue;}
case 150:{f.Push(JValue.R(rt.String("Aura swap")));f.Pc=153;continue;}
case 153:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=154;continue;}
case 154:{f.StackOp("dup");f.Pc=155;continue;}
case 155:{f.Push(JValue.I(21));f.Pc=157;continue;}
case 157:{f.Push(JValue.R(rt.String("Fortify")));f.Pc=160;continue;}
case 160:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=161;continue;}
case 161:{f.StackOp("dup");f.Pc=162;continue;}
case 162:{f.Push(JValue.I(22));f.Pc=164;continue;}
case 164:{f.Push(JValue.R(rt.String("Transfigure")));f.Pc=167;continue;}
case 167:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=168;continue;}
case 168:{f.StackOp("dup");f.Pc=169;continue;}
case 169:{f.Push(JValue.I(23));f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.String("Champion")));f.Pc=174;continue;}
case 174:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=175;continue;}
case 175:{f.StackOp("dup");f.Pc=176;continue;}
case 176:{f.Push(JValue.I(24));f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("Evoke")));f.Pc=181;continue;}
case 181:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=182;continue;}
case 182:{f.StackOp("dup");f.Pc=183;continue;}
case 183:{f.Push(JValue.I(25));f.Pc=185;continue;}
case 185:{f.Push(JValue.R(rt.String("Prowl")));f.Pc=188;continue;}
case 188:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=189;continue;}
case 189:{f.StackOp("dup");f.Pc=190;continue;}
case 190:{f.Push(JValue.I(26));f.Pc=192;continue;}
case 192:{f.Push(JValue.R(rt.String("Freerunning")));f.Pc=195;continue;}
case 195:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=196;continue;}
case 196:{f.StackOp("dup");f.Pc=197;continue;}
case 197:{f.Push(JValue.I(27));f.Pc=199;continue;}
case 199:{f.Push(JValue.R(rt.String("Reinforce")));f.Pc=202;continue;}
case 202:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=203;continue;}
case 203:{f.StackOp("dup");f.Pc=204;continue;}
case 204:{f.Push(JValue.I(28));f.Pc=206;continue;}
case 206:{f.Push(JValue.R(rt.String("Unearth")));f.Pc=209;continue;}
case 209:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=210;continue;}
case 210:{f.StackOp("dup");f.Pc=211;continue;}
case 211:{f.Push(JValue.I(29));f.Pc=213;continue;}
case 213:{f.Push(JValue.R(rt.String("Level up")));f.Pc=216;continue;}
case 216:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=217;continue;}
case 217:{f.StackOp("dup");f.Pc=218;continue;}
case 218:{f.Push(JValue.I(30));f.Pc=220;continue;}
case 220:{f.Push(JValue.R(rt.String("Miracle")));f.Pc=223;continue;}
case 223:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=224;continue;}
case 224:{f.StackOp("dup");f.Pc=225;continue;}
case 225:{f.Push(JValue.I(31));f.Pc=227;continue;}
case 227:{f.Push(JValue.R(rt.String("Overload")));f.Pc=230;continue;}
case 230:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=231;continue;}
case 231:{f.StackOp("dup");f.Pc=232;continue;}
case 232:{f.Push(JValue.I(32));f.Pc=234;continue;}
case 234:{f.Push(JValue.R(rt.String("Cleave")));f.Pc=237;continue;}
case 237:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=238;continue;}
case 238:{f.StackOp("dup");f.Pc=239;continue;}
case 239:{f.Push(JValue.I(33));f.Pc=241;continue;}
case 241:{f.Push(JValue.R(rt.String("Scavenge")));f.Pc=244;continue;}
case 244:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=245;continue;}
case 245:{f.StackOp("dup");f.Pc=246;continue;}
case 246:{f.Push(JValue.I(34));f.Pc=248;continue;}
case 248:{f.Push(JValue.R(rt.String("Encore")));f.Pc=251;continue;}
case 251:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=252;continue;}
case 252:{f.StackOp("dup");f.Pc=253;continue;}
case 253:{f.Push(JValue.I(35));f.Pc=255;continue;}
case 255:{f.Push(JValue.R(rt.String("Bestow")));f.Pc=258;continue;}
case 258:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=259;continue;}
case 259:{f.StackOp("dup");f.Pc=260;continue;}
case 260:{f.Push(JValue.I(36));f.Pc=262;continue;}
case 262:{f.Push(JValue.R(rt.String("Outlast")));f.Pc=265;continue;}
case 265:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=266;continue;}
case 266:{f.StackOp("dup");f.Pc=267;continue;}
case 267:{f.Push(JValue.I(37));f.Pc=269;continue;}
case 269:{f.Push(JValue.R(rt.String("Dash")));f.Pc=272;continue;}
case 272:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=273;continue;}
case 273:{f.StackOp("dup");f.Pc=274;continue;}
case 274:{f.Push(JValue.I(38));f.Pc=276;continue;}
case 276:{f.Push(JValue.R(rt.String("Surge")));f.Pc=279;continue;}
case 279:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=280;continue;}
case 280:{f.StackOp("dup");f.Pc=281;continue;}
case 281:{f.Push(JValue.I(39));f.Pc=283;continue;}
case 283:{f.Push(JValue.R(rt.String("Emerge")));f.Pc=286;continue;}
case 286:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=287;continue;}
case 287:{f.StackOp("dup");f.Pc=288;continue;}
case 288:{f.Push(JValue.I(40));f.Pc=290;continue;}
case 290:{f.Push(JValue.R(rt.String("Hexproof:")));f.Pc=293;continue;}
case 293:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=294;continue;}
case 294:{f.StackOp("dup");f.Pc=295;continue;}
case 295:{f.Push(JValue.I(41));f.Pc=297;continue;}
case 297:{f.Push(JValue.R(rt.String("Bands with other")));f.Pc=300;continue;}
case 300:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=301;continue;}
case 301:{f.StackOp("dup");f.Pc=302;continue;}
case 302:{f.Push(JValue.I(42));f.Pc=304;continue;}
case 304:{f.Push(JValue.R(rt.String("Landwalk")));f.Pc=307;continue;}
case 307:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=308;continue;}
case 308:{f.StackOp("dup");f.Pc=309;continue;}
case 309:{f.Push(JValue.I(43));f.Pc=311;continue;}
case 311:{f.Push(JValue.R(rt.String("Offering")));f.Pc=314;continue;}
case 314:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=315;continue;}
case 315:{f.StackOp("dup");f.Pc=316;continue;}
case 316:{f.Push(JValue.I(44));f.Pc=318;continue;}
case 318:{f.Push(JValue.R(rt.String("etbCounter")));f.Pc=321;continue;}
case 321:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=322;continue;}
case 322:{f.StackOp("dup");f.Pc=323;continue;}
case 323:{f.Push(JValue.I(45));f.Pc=325;continue;}
case 325:{f.Push(JValue.R(rt.String("Reflect")));f.Pc=328;continue;}
case 328:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=329;continue;}
case 329:{f.StackOp("dup");f.Pc=330;continue;}
case 330:{f.Push(JValue.I(46));f.Pc=332;continue;}
case 332:{f.Push(JValue.R(rt.String("Ward")));f.Pc=335;continue;}
case 335:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=336;continue;}
case 336:{return rt.Call(f,"com/google/common/collect/ImmutableList$Builder","add","([Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList$Builder;","invokevirtual",339);}
case 339:{return rt.Call(f,"com/google/common/collect/ImmutableList$Builder","build","()Lcom/google/common/collect/ImmutableList;","invokevirtual",342);}
case 342:{if(!rt.StaticReady(f,"forge/game/card/CardUtil","modifiableKeywords","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;rt.PutStatic("forge/game/card/CardUtil","modifiableKeywords","Lcom/google/common/collect/ImmutableList;",f.Pop());f.Pc=345;continue;}
case 345:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
