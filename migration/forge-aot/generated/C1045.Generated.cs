// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1045{
internal static JClass Build(){var c=new JClass("forge/game/zone/MagicStack","java/lang/Object",new string[]{"java/lang/Iterable"},33);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("MAX_TRIGGER_REPEATS","I",true,JValue.I(50),null));
c.Add(new JField("MAX_ILLEGAL_ADDITIONS_PER_TURN","I",true,JValue.I(2),null));
c.Add(new JField("simultaneousStackEntryList","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("activePlayerSAs","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("stack","Ljava/util/Deque;",false,JValue.Default("Ljava/util/Deque;"),null));
c.Add(new JField("undoStack","Ljava/util/Stack;",false,JValue.Default("Ljava/util/Stack;"),null));
c.Add(new JField("undoStackOwner","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("primaryAbility","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JField("frozen","Z",false,JValue.Default("Z"),null));
c.Add(new JField("thisTurnCast","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("lastTurnCast","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("thisTurnActivated","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("curResolving","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JField("triggerRepeats","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("illegalAdditions","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("game","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JField("maxDistinctSources","I",false,JValue.Default("I"),null));
c.Add(new JMethod(11029,"forge/game/zone/MagicStack","<init>","(Lforge/game/Game;)V",1,2,3,new JHandler[]{},M11029));
c.Add(new JMethod(11030,"forge/game/zone/MagicStack","isFrozen","()Z",17,1,1,new JHandler[]{},M11030));
c.Add(new JMethod(11031,"forge/game/zone/MagicStack","setFrozen","(Z)V",17,2,2,new JHandler[]{},M11031));
c.Add(new JMethod(11032,"forge/game/zone/MagicStack","getMaxDistinctSources","()I",1,1,1,new JHandler[]{},M11032));
c.Add(new JMethod(11033,"forge/game/zone/MagicStack","resetMaxDistinctSources","()V",1,1,2,new JHandler[]{},M11033));
c.Add(new JMethod(11034,"forge/game/zone/MagicStack","reset","()V",17,1,2,new JHandler[]{},M11034));
c.Add(new JMethod(11035,"forge/game/zone/MagicStack","isSplitSecondOnStack","()Z",17,3,2,new JHandler[]{},M11035));
c.Add(new JMethod(11036,"forge/game/zone/MagicStack","freezeStack","(Lforge/game/spellability/SpellAbility;)V",17,2,2,new JHandler[]{},M11036));
c.Add(new JMethod(11037,"forge/game/zone/MagicStack","addAndUnfreeze","(Lforge/game/spellability/SpellAbility;)V",17,4,4,new JHandler[]{},M11037));
c.Add(new JMethod(11038,"forge/game/zone/MagicStack","unfreezeStack","()V",17,1,2,new JHandler[]{},M11038));
c.Add(new JMethod(11039,"forge/game/zone/MagicStack","isResolving","()Z",17,1,1,new JHandler[]{},M11039));
c.Add(new JMethod(11040,"forge/game/zone/MagicStack","isResolving","(Lforge/game/card/Card;)Z",17,2,2,new JHandler[]{},M11040));
c.Add(new JMethod(11041,"forge/game/zone/MagicStack","getResolvingAbility","()Lforge/game/spellability/SpellAbility;",17,1,1,new JHandler[]{},M11041));
c.Add(new JMethod(11042,"forge/game/zone/MagicStack","add","(Lforge/game/spellability/SpellAbility;)V",17,2,4,new JHandler[]{},M11042));
c.Add(new JMethod(11043,"forge/game/zone/MagicStack","add","(Lforge/game/spellability/SpellAbility;I)V",17,3,4,new JHandler[]{},M11043));
c.Add(new JMethod(11044,"forge/game/zone/MagicStack","add","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbilityStackInstance;)V",17,3,4,new JHandler[]{},M11044));
c.Add(new JMethod(11045,"forge/game/zone/MagicStack","add","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbilityStackInstance;I)V",17,16,7,new JHandler[]{},M11045));
c.Add(new JMethod(11046,"forge/game/zone/MagicStack","abortIllegalAddition","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;)V",2,4,5,new JHandler[]{},M11046));
c.Add(new JMethod(11047,"forge/game/zone/MagicStack","returnStrandedSpell","(Lforge/game/card/Card;Lforge/game/zone/Zone;)Lforge/game/card/Card;",17,4,6,new JHandler[]{},M11047));
c.Add(new JMethod(11048,"forge/game/zone/MagicStack","getIllegalAdditionCount","(Lforge/game/card/Card;)I",17,2,3,new JHandler[]{},M11048));
c.Add(new JMethod(11049,"forge/game/zone/MagicStack","hasRepeatedlyFailedToAdd","(Lforge/game/card/Card;)Z",17,2,2,new JHandler[]{},M11049));
c.Add(new JMethod(11050,"forge/game/zone/MagicStack","isRepeatingTrigger","(Lforge/game/spellability/SpellAbility;)Z",2,5,4,new JHandler[]{},M11050));
c.Add(new JMethod(11051,"forge/game/zone/MagicStack","clearTriggerRepeats","()V",17,1,1,new JHandler[]{},M11051));
c.Add(new JMethod(11052,"forge/game/zone/MagicStack","recordUndoableActions","(Lforge/game/spellability/SpellAbility;)V",2,3,2,new JHandler[]{},M11052));
c.Add(new JMethod(11053,"forge/game/zone/MagicStack","getUndoStackSize","()I",1,1,1,new JHandler[]{},M11053));
c.Add(new JMethod(11054,"forge/game/zone/MagicStack","canUndo","(Lforge/game/player/Player;)Z",17,2,2,new JHandler[]{},M11054));
c.Add(new JMethod(11055,"forge/game/zone/MagicStack","undo","()Z",17,4,3,new JHandler[]{},M11055));
c.Add(new JMethod(11056,"forge/game/zone/MagicStack","clearUndoStack","(Lforge/game/spellability/SpellAbility;)V",17,2,5,new JHandler[]{},M11056));
c.Add(new JMethod(11057,"forge/game/zone/MagicStack","clearUndoStack","(Ljava/util/List;)V",2,5,2,new JHandler[]{},M11057));
c.Add(new JMethod(11058,"forge/game/zone/MagicStack","clearUndoStack","()V",17,1,2,new JHandler[]{},M11058));
c.Add(new JMethod(11059,"forge/game/zone/MagicStack","filterUndoStackByHost","(Lforge/game/card/Card;)Ljava/lang/Iterable;",1,2,2,new JHandler[]{},M11059));
c.Add(new JMethod(11060,"forge/game/zone/MagicStack","size","()I",17,1,1,new JHandler[]{},M11060));
c.Add(new JMethod(11061,"forge/game/zone/MagicStack","isEmpty","()Z",17,1,1,new JHandler[]{},M11061));
c.Add(new JMethod(11062,"forge/game/zone/MagicStack","resolveStack","()V",17,5,5,new JHandler[]{},M11062));
c.Add(new JMethod(11063,"forge/game/zone/MagicStack","finishResolving","(Lforge/game/spellability/SpellAbility;Z)V",2,4,4,new JHandler[]{},M11063));
c.Add(new JMethod(11064,"forge/game/zone/MagicStack","removeCardFromStack","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbilityStackInstance;Z)V",2,6,4,new JHandler[]{},M11064));
c.Add(new JMethod(11065,"forge/game/zone/MagicStack","hasLegalTargeting","(Lforge/game/spellability/SpellAbility;)Z",17,2,2,new JHandler[]{},M11065));
c.Add(new JMethod(11066,"forge/game/zone/MagicStack","hasFizzled","(Lforge/game/spellability/SpellAbility;Ljava/lang/Boolean;)Z",2,9,3,new JHandler[]{},M11066));
c.Add(new JMethod(11067,"forge/game/zone/MagicStack","peek","()Lforge/game/spellability/SpellAbilityStackInstance;",17,1,1,new JHandler[]{},M11067));
c.Add(new JMethod(11068,"forge/game/zone/MagicStack","peekAbility","()Lforge/game/spellability/SpellAbility;",17,1,1,new JHandler[]{},M11068));
c.Add(new JMethod(11069,"forge/game/zone/MagicStack","remove","(Lforge/game/spellability/SpellAbilityStackInstance;)V",17,2,4,new JHandler[]{},M11069));
c.Add(new JMethod(11070,"forge/game/zone/MagicStack","remove","(Lforge/game/card/Card;)V",17,4,2,new JHandler[]{},M11070));
c.Add(new JMethod(11071,"forge/game/zone/MagicStack","removeInstancesControlledBy","(Lforge/game/player/Player;)V",17,5,2,new JHandler[]{},M11071));
c.Add(new JMethod(11072,"forge/game/zone/MagicStack","getInstanceMatchingSpellAbilityID","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbilityStackInstance;",17,4,2,new JHandler[]{},M11072));
c.Add(new JMethod(11073,"forge/game/zone/MagicStack","getSpellMatchingHost","(Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;",17,4,2,new JHandler[]{},M11073));
c.Add(new JMethod(11074,"forge/game/zone/MagicStack","hasSimultaneousStackEntries","()Z",17,1,1,new JHandler[]{},M11074));
c.Add(new JMethod(11075,"forge/game/zone/MagicStack","clearSimultaneousStack","()V",17,1,1,new JHandler[]{},M11075));
}

private static void Add1(JClass c){
c.Add(new JMethod(11076,"forge/game/zone/MagicStack","addSimultaneousStackEntry","(Lforge/game/spellability/SpellAbility;)V",17,2,2,new JHandler[]{},M11076));
c.Add(new JMethod(11077,"forge/game/zone/MagicStack","addAllTriggeredAbilitiesToStack","()Z",1,6,4,new JHandler[]{},M11077));
c.Add(new JMethod(11078,"forge/game/zone/MagicStack","chooseOrderOfSimultaneousStackEntry","(Lforge/game/player/Player;Z)Z",2,6,3,new JHandler[]{},M11078));
c.Add(new JMethod(11079,"forge/game/zone/MagicStack","adjustAuraHost","(Lforge/game/spellability/SpellAbility;)V",2,5,3,new JHandler[]{},M11079));
c.Add(new JMethod(11080,"forge/game/zone/MagicStack","hasStateTrigger","(I)Z",17,4,2,new JHandler[]{},M11080));
c.Add(new JMethod(11081,"forge/game/zone/MagicStack","getSpellsCastThisTurn","()Ljava/util/List;",17,1,1,new JHandler[]{},M11081));
c.Add(new JMethod(11082,"forge/game/zone/MagicStack","getSpellCardsCastThisTurn","()Ljava/util/List;",17,1,2,new JHandler[]{},M11082));
c.Add(new JMethod(11083,"forge/game/zone/MagicStack","getSpellsCastLastTurn","()Ljava/util/List;",17,1,1,new JHandler[]{},M11083));
c.Add(new JMethod(11084,"forge/game/zone/MagicStack","onNextTurn","()V",17,4,2,new JHandler[]{},M11084));
c.Add(new JMethod(11085,"forge/game/zone/MagicStack","addAbilityActivatedThisTurn","(Lforge/game/spellability/SpellAbility;)V",1,3,4,new JHandler[]{},M11085));
c.Add(new JMethod(11086,"forge/game/zone/MagicStack","getAbilityActivatedThisTurn","()Ljava/util/List;",1,1,1,new JHandler[]{},M11086));
c.Add(new JMethod(11087,"forge/game/zone/MagicStack","hasSourceOnStack","(Lforge/game/card/Card;Ljava/util/function/Predicate;)Z",17,5,2,new JHandler[]{},M11087));
c.Add(new JMethod(11088,"forge/game/zone/MagicStack","iterator","()Ljava/util/Iterator;",1,1,1,new JHandler[]{},M11088));
c.Add(new JMethod(11089,"forge/game/zone/MagicStack","reverseIterator","()Ljava/util/Iterator;",1,1,1,new JHandler[]{},M11089));
c.Add(new JMethod(11090,"forge/game/zone/MagicStack","clear","()V",1,1,4,new JHandler[]{},M11090));
c.Add(new JMethod(11091,"forge/game/zone/MagicStack","toString","()Ljava/lang/String;",1,1,4,new JHandler[]{},M11091));
c.Add(new JMethod(11092,"forge/game/zone/MagicStack","commitCrimeCheck","(Lforge/game/player/Player;Ljava/lang/Iterable;)Z",12,7,3,new JHandler[]{},M11092));
}

internal static JStep M11029(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","simultaneousStackEntryList","Ljava/util/List;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","activePlayerSAs","Ljava/util/List;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"java/util/concurrent/LinkedBlockingDeque"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/LinkedBlockingDeque")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/concurrent/LinkedBlockingDeque","<init>","()V","invokespecial",26);}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{if(!rt.EnsureInitialized(f,"java/util/Stack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/Stack")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Stack","<init>","()V","invokespecial",37);}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","undoStack","Ljava/util/Stack;",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(null));f.Pc=42;continue;}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","primaryAbility","Lforge/game/spellability/SpellAbility;",value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","frozen","Z",value);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",54);}
case 54:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","thisTurnCast","Ljava/util/List;",value);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",61);}
case 61:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","lastTurnCast","Ljava/util/List;",value);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",68);}
case 68:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","thisTurnActivated","Ljava/util/List;",value);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(null));f.Pc=73;continue;}
case 73:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","curResolving","Lforge/game/spellability/SpellAbility;",value);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=80;continue;}
case 80:{f.StackOp("dup");f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",84);}
case 84:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","triggerRepeats","Ljava/util/Map;",value);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=91;continue;}
case 91:{f.StackOp("dup");f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",95);}
case 95:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","illegalAdditions","Ljava/util/Map;",value);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(JValue.I(0));f.Pc=100;continue;}
case 100:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","maxDistinctSources","I",value);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;",value);f.Pc=108;continue;}
case 108:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11030(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","frozen","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11031(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","frozen","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11032(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","maxDistinctSources","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11033(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","maxDistinctSources","I",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11034(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","simultaneousStackEntryList","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","frozen","Z",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(null));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","primaryAbility","Lforge/game/spellability/SpellAbility;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","lastTurnCast","Ljava/util/List;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",28);}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","thisTurnCast","Ljava/util/List;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",37);}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","thisTurnActivated","Ljava/util/List;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",46);}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(null));f.Pc=48;continue;}
case 48:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","curResolving","Lforge/game/spellability/SpellAbility;",value);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","triggerRepeats","Ljava/util/Map;"));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",60);}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","illegalAdditions","Ljava/util/Map;"));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",69);}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/zone/MagicStack","clearUndoStack","()V","invokevirtual",73);}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/zone/MagicStack","clear","()V","invokevirtual",77);}
case 77:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11035(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Deque","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?54:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","isSpell","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?51:36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSourceCard","()Lforge/game/card/Card;","invokevirtual",40);}
case 40:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","SPLIT_SECOND","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","SPLIT_SECOND","Lforge/game/keyword/Keyword;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?51:49;continue;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 51:{f.Pc=10;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11036(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","primaryAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?12:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","primaryAbility","Lforge/game/spellability/SpellAbility;",value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","frozen","Z",value);f.Pc=17;continue;}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11037(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?97:12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/Card","isCopiedSpell","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int!=0?97:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int!=0?45:29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",37);}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/GameAction","moveToStack","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",42);}
case 42:{return rt.Call(f,"forge/game/spellability/SpellAbility","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",45);}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",50);}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","equals","(Ljava/lang/Object;)Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int==0?93:56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",61);}
case 61:{f.Push(JValue.I(1));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",65);}
case 65:{f.Locals[3]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",74);}
case 74:{return rt.Call(f,"forge/game/spellability/SpellAbility","setLastStateBattlefield","(Lforge/game/card/CardCollectionView;)V","invokevirtual",77);}
case 77:{f.Push(f.Locals[3]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/Game","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",85);}
case 85:{return rt.Call(f,"forge/game/spellability/SpellAbility","setLastStateGraveyard","(Lforge/game/card/CardCollectionView;)V","invokevirtual",88);}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/card/Card","setCastSA","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",93);}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/card/Card","cleanupExiledWith","()V","invokevirtual",97);}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/zone/MagicStack","add","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",102);}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","primaryAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=106;continue;}
case 106:{f.Pc=f.Pop().Reference==null?120:109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","primaryAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/spellability/SpellAbility","equals","(Ljava/lang/Object;)Z","invokevirtual",117);}
case 117:{f.Pc=f.Pop().Int==0?124:120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/zone/MagicStack","unfreezeStack","()V","invokevirtual",124);}
case 124:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11038(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","frozen","Z",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","primaryAbility","Lforge/game/spellability/SpellAbility;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/game/trigger/TriggerHandler","resetActiveTriggers","()V","invokevirtual",20);}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",27);}
case 27:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runWaitingTriggers","()Z","invokevirtual",30);}
case 30:{f.StackOp("pop");f.Pc=31;continue;}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11039(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","curResolving","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11040(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/zone/MagicStack","isResolving","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","curResolving","Lforge/game/spellability/SpellAbility;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",20);}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11041(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","curResolving","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11042(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","nextId","()I","invokestatic",6);}
case 6:{return rt.Call(f,"forge/game/zone/MagicStack","add","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbilityStackInstance;I)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11043(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/zone/MagicStack","add","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbilityStackInstance;I)V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11044(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getId","()I","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/zone/MagicStack","add","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbilityStackInstance;I)V","invokevirtual",10);}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11045(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Reference!=null?38:13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[4]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",19);}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",22);}
case 22:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",30);}
case 30:{return rt.DynamicCall(f,"forge/game/zone/MagicStack:11045:30:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",35);}
case 35:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",38);}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",42);}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",51);}
case 51:{return rt.Call(f,"forge/game/zone/MagicStack","size","()I","invokevirtual",54);}
case 54:{f.Push(JValue.I(999));f.Pc=57;continue;}
case 57:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?72:60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Reference!=null?125:64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/zone/MagicStack","isRepeatingTrigger","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?125:72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",79);}
case 79:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",82);}
case 82:{f.Locals[6]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[6]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",91);}
case 91:{f.Pc=f.Pop().Int==0?114:94;continue;}
case 94:{f.Push(f.Locals[6]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",101);}
case 101:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=104;continue;}
case 104:{f.Locals[7]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[7]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/player/Player","intentionalDraw","()V","invokevirtual",111);}
case 111:{f.Pc=84;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=118;continue;}
case 118:{if(!rt.StaticReady(f,"forge/game/GameEndReason","Draw","Lforge/game/GameEndReason;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameEndReason","Draw","Lforge/game/GameEndReason;"));f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/Game","setGameOver","(Lforge/game/GameEndReason;)V","invokevirtual",124);}
case 124:{return JStep.ReturnVoid;}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[1]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/zone/MagicStack","recordUndoableActions","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",130);}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/spellability/SpellAbility","isManaAbility","()Z","invokevirtual",134);}
case 134:{f.Pc=f.Pop().Int==0?333:137;continue;}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",144);}
case 144:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","()V","invokevirtual",147);}
case 147:{f.Push(f.Locals[1]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCopied","()Z","invokevirtual",151);}
case 151:{f.Pc=f.Pop().Int!=0?166:154;continue;}
case 154:{f.Push(f.Locals[1]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",158);}
case 158:{f.Pc=f.Pop().Int!=0?166:161;continue;}
case 161:{f.Push(f.Locals[0]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[1]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/zone/MagicStack","addAbilityActivatedThisTurn","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",166);}
case 166:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",169);}
case 169:{f.Locals[6]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[6]);f.Pc=173;continue;}
case 173:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"));f.Pc=176;continue;}
case 176:{f.Push(f.Locals[5]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",183);}
case 183:{f.StackOp("pop");f.Pc=184;continue;}
case 184:{f.Push(f.Locals[6]);f.Pc=186;continue;}
case 186:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"));f.Pc=189;continue;}
case 189:{f.Push(f.Locals[1]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",195);}
case 195:{f.StackOp("pop");f.Pc=196;continue;}
case 196:{f.Push(f.Locals[0]);f.Pc=197;continue;}
case 197:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",203);}
case 203:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","SpellAbilityCast","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","SpellAbilityCast","Lforge/game/trigger/TriggerType;"));f.Pc=206;continue;}
case 206:{f.Push(f.Locals[6]);f.Pc=208;continue;}
case 208:{f.Push(JValue.I(1));f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",212);}
case 212:{f.Push(f.Locals[1]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/spellability/SpellAbility","isActivatedAbility","()Z","invokevirtual",216);}
case 216:{f.Pc=f.Pop().Int==0?235:219;continue;}
case 219:{f.Push(f.Locals[0]);f.Pc=220;continue;}
case 220:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",226);}
case 226:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AbilityCast","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AbilityCast","Lforge/game/trigger/TriggerType;"));f.Pc=229;continue;}
case 229:{f.Push(f.Locals[6]);f.Pc=231;continue;}
case 231:{f.Push(JValue.I(1));f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",235);}
case 235:{f.Push(f.Locals[1]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",239);}
case 239:{f.Push(f.Locals[4]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",244);}
case 244:{f.Locals[6]=f.Pop();f.Pc=246;continue;}
case 246:{f.Push(f.Locals[6]);f.Pc=248;continue;}
case 248:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"));f.Pc=251;continue;}
case 251:{f.Push(f.Locals[1]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",257);}
case 257:{f.StackOp("pop");f.Pc=258;continue;}
case 258:{f.Push(f.Locals[0]);f.Pc=259;continue;}
case 259:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",265);}
case 265:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AbilityResolves","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AbilityResolves","Lforge/game/trigger/TriggerType;"));f.Pc=268;continue;}
case 268:{f.Push(f.Locals[6]);f.Pc=270;continue;}
case 270:{f.Push(JValue.I(0));f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",274);}
case 274:{f.Push(f.Locals[0]);f.Pc=275;continue;}
case 275:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=278;continue;}
case 278:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=281;continue;}
case 281:{f.StackOp("dup");f.Pc=282;continue;}
case 282:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","MANA","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","MANA","Lforge/game/GameLogEntryType;"));f.Pc=285;continue;}
case 285:{f.Push(f.Locals[4]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",290);}
case 290:{f.Push(f.Locals[1]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",294);}
case 294:{return rt.DynamicCall(f,"forge/game/zone/MagicStack:11045:294:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",299);}
case 299:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",302);}
case 302:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",305);}
case 305:{f.Push(f.Locals[1]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/spellability/SpellAbility","resetOnceResolved","()V","invokevirtual",309);}
case 309:{f.Push(f.Locals[0]);f.Pc=310;continue;}
case 310:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=313;continue;}
case 313:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;"));f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/zone/CostPaymentStack","peek","()Lforge/game/zone/CostPaymentStack$Entry;","invokevirtual",319);}
case 319:{f.Pc=f.Pop().Reference==null?332:322;continue;}
case 322:{f.Push(f.Locals[0]);f.Pc=323;continue;}
case 323:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",329);}
case 329:{return rt.Call(f,"forge/game/trigger/TriggerHandler","collectTriggerForWaiting","()V","invokevirtual",332);}
case 332:{return JStep.ReturnVoid;}
case 333:{f.Push(f.Locals[1]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",337);}
case 337:{f.Pc=f.Pop().Int==0?396:340;continue;}
case 340:{f.Push(f.Locals[4]);f.Pc=342;continue;}
case 342:{f.Push(f.Locals[5]);f.Pc=344;continue;}
case 344:{f.Push(JValue.L(0));f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",348);}
case 348:{f.Push(f.Locals[4]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",353);}
case 353:{f.Pc=f.Pop().Int==0?370:356;continue;}
case 356:{f.Push(f.Locals[1]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCastFaceDown","()Z","invokevirtual",360);}
case 360:{f.Pc=f.Pop().Int!=0?370:363;continue;}
case 363:{f.Push(f.Locals[4]);f.Pc=365;continue;}
case 365:{f.Push(JValue.R(null));f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/game/card/Card","turnFaceUp","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",369);}
case 369:{f.StackOp("pop");f.Pc=370;continue;}
case 370:{f.Push(f.Locals[4]);f.Pc=372;continue;}
case 372:{f.Push(f.Locals[1]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/game/card/Card","setSplitStateToPlayAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",376);}
case 376:{f.Push(f.Locals[4]);f.Pc=378;continue;}
case 378:{return rt.Call(f,"forge/game/card/Card","isCopiedSpell","()Z","invokevirtual",381);}
case 381:{f.Pc=f.Pop().Int==0?396:384;continue;}
case 384:{f.Push(f.Locals[0]);f.Pc=385;continue;}
case 385:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=388;continue;}
case 388:{return rt.Call(f,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;","invokevirtual",391);}
case 391:{f.Push(f.Locals[4]);f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/zone/Zone","add","(Lforge/game/card/Card;)V","invokevirtual",396);}
case 396:{f.Push(f.Locals[1]);f.Pc=397;continue;}
case 397:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCopied","()Z","invokevirtual",400);}
case 400:{f.Pc=f.Pop().Int!=0?419:403;continue;}
case 403:{f.Push(f.Locals[0]);f.Pc=404;continue;}
case 404:{f.Push(f.Locals[1]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"forge/game/zone/MagicStack","hasLegalTargeting","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",408);}
case 408:{f.Pc=f.Pop().Int!=0?419:411;continue;}
case 411:{f.Push(f.Locals[0]);f.Pc=412;continue;}
case 412:{f.Push(f.Locals[1]);f.Pc=413;continue;}
case 413:{f.Push(f.Locals[4]);f.Pc=415;continue;}
case 415:{return rt.Call(f,"forge/game/zone/MagicStack","abortIllegalAddition","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;)V","invokevirtual",418);}
case 418:{return JStep.ReturnVoid;}
case 419:{f.Push(f.Locals[1]);f.Pc=420;continue;}
case 420:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilityStatic")?1:0));f.Pc=423;continue;}
case 423:{f.Pc=f.Pop().Int!=0?446:426;continue;}
case 426:{f.Push(f.Locals[1]);f.Pc=427;continue;}
case 427:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",430);}
case 430:{f.Pc=f.Pop().Int==0?451:433;continue;}
case 433:{f.Push(f.Locals[1]);f.Pc=434;continue;}
case 434:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",437);}
case 437:{return rt.Call(f,"forge/game/trigger/Trigger","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",440);}
case 440:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilityStatic")?1:0));f.Pc=443;continue;}
case 443:{f.Pc=f.Pop().Int==0?451:446;continue;}
case 446:{f.Push(f.Locals[1]);f.Pc=447;continue;}
case 447:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",450);}
case 450:{return JStep.ReturnVoid;}
case 451:{f.Push(f.Locals[2]);f.Pc=452;continue;}
case 452:{f.Pc=f.Pop().Reference!=null?519:455;continue;}
case 455:{f.Push(f.Locals[1]);f.Pc=456;continue;}
case 456:{return rt.Call(f,"forge/game/spellability/SpellAbility","isActivatedAbility","()Z","invokevirtual",459);}
case 459:{f.Pc=f.Pop().Int==0?519:462;continue;}
case 462:{f.Push(f.Locals[1]);f.Pc=463;continue;}
case 463:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCopied","()Z","invokevirtual",466);}
case 466:{f.Pc=f.Pop().Int!=0?519:469;continue;}
case 469:{f.Push(f.Locals[1]);f.Pc=470;continue;}
case 470:{f.Locals[6]=f.Pop();f.Pc=472;continue;}
case 472:{f.Push(f.Locals[1]);f.Pc=473;continue;}
case 473:{f.Push(f.Locals[1]);f.Pc=474;continue;}
case 474:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",477);}
case 477:{f.Push(f.Locals[5]);f.Pc=479;continue;}
case 479:{f.Push(JValue.I(0));f.Pc=480;continue;}
case 480:{f.Push(JValue.I(1));f.Pc=481;continue;}
case 481:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Lforge/game/player/Player;ZZ)Lforge/game/spellability/SpellAbility;","invokevirtual",484);}
case 484:{f.Locals[1]=f.Pop();f.Pc=485;continue;}
case 485:{f.Push(f.Locals[1]);f.Pc=486;continue;}
case 486:{f.Push(f.Locals[6]);f.Pc=488;continue;}
case 488:{return rt.Call(f,"forge/game/spellability/SpellAbility","setOriginalAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",491);}
case 491:{f.Push(f.Locals[6]);f.Pc=493;continue;}
case 493:{return rt.Call(f,"forge/game/spellability/SpellAbility","clearTargets","()V","invokevirtual",496);}
case 496:{f.Push(f.Locals[6]);f.Pc=498;continue;}
case 498:{f.Push(JValue.R(null));f.Pc=499;continue;}
case 499:{return rt.Call(f,"forge/game/spellability/SpellAbility","setXManaCostPaid","(Ljava/lang/Integer;)V","invokevirtual",502);}
case 502:{f.Push(f.Locals[6]);f.Pc=504;continue;}
case 504:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",507);}
case 507:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"));f.Pc=510;continue;}
case 510:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?519:513;continue;}
case 513:{f.Push(f.Locals[6]);f.Pc=515;continue;}
case 515:{f.Push(JValue.R(null));f.Pc=516;continue;}
case 516:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",519);}
case 519:{f.Push(f.Locals[1]);f.Pc=520;continue;}
case 520:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",523);}
case 523:{f.Pc=f.Pop().Int==0?545:526;continue;}
case 526:{f.Push(f.Locals[1]);f.Pc=527;continue;}
case 527:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCopied","()Z","invokevirtual",530);}
case 530:{f.Pc=f.Pop().Int!=0?545:533;continue;}
case 533:{f.Push(f.Locals[1]);f.Pc=534;continue;}
case 534:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",537);}
case 537:{f.Pc=f.Pop().Int!=0?545:540;continue;}
case 540:{f.Push(f.Locals[0]);f.Pc=541;continue;}
case 541:{f.Push(f.Locals[1]);f.Pc=542;continue;}
case 542:{return rt.Call(f,"forge/game/zone/MagicStack","addAbilityActivatedThisTurn","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",545);}
case 545:{f.Push(JValue.R(null));f.Pc=546;continue;}
case 546:{f.Push(f.Locals[1]);f.Pc=547;continue;}
case 547:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",550);}
case 550:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?582:553;continue;}
case 553:{f.Push(f.Locals[1]);f.Pc=554;continue;}
case 554:{f.Push(f.Locals[1]);f.Pc=555;continue;}
case 555:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",558);}
case 558:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",561);}
case 561:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",564);}
case 564:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=567;continue;}
case 567:{f.Push(f.Locals[1]);f.Pc=568;continue;}
case 568:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",571);}
case 571:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",574);}
case 574:{return rt.DynamicCall(f,"forge/game/zone/MagicStack:11045:574:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",579);}
case 579:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",582);}
case 582:{f.Push(f.Locals[1]);f.Pc=583;continue;}
case 583:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",586);}
case 586:{f.Pc=f.Pop().Int==0?635:589;continue;}
case 589:{f.Push(f.Locals[1]);f.Pc=590;continue;}
case 590:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMayPlay","()Lforge/game/staticability/StaticAbility;","invokevirtual",593);}
case 593:{f.Pc=f.Pop().Reference==null?635:596;continue;}
case 596:{f.Push(f.Locals[1]);f.Pc=597;continue;}
case 597:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMayPlay","()Lforge/game/staticability/StaticAbility;","invokevirtual",600);}
case 600:{f.Push(JValue.R(rt.String("ReplaceGraveyard")));f.Pc=603;continue;}
case 603:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",606);}
case 606:{f.Pc=f.Pop().Int==0?635:609;continue;}
case 609:{f.Push(f.Locals[1]);f.Pc=610;continue;}
case 610:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",613);}
case 613:{f.Push(f.Locals[1]);f.Pc=614;continue;}
case 614:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMayPlay","()Lforge/game/staticability/StaticAbility;","invokevirtual",617);}
case 617:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",620);}
case 620:{f.Push(f.Locals[1]);f.Pc=621;continue;}
case 621:{f.Push(f.Locals[1]);f.Pc=622;continue;}
case 622:{f.Push(f.Locals[1]);f.Pc=623;continue;}
case 623:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMayPlay","()Lforge/game/staticability/StaticAbility;","invokevirtual",626);}
case 626:{f.Push(JValue.R(rt.String("ReplaceGraveyard")));f.Pc=629;continue;}
case 629:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",632);}
case 632:{return rt.Call(f,"forge/game/ability/effects/PlayEffect","addReplaceGraveyardEffect","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Ljava/lang/String;)V","invokestatic",635);}
case 635:{f.Push(f.Locals[2]);f.Pc=636;continue;}
case 636:{f.Pc=f.Pop().Reference!=null?651:639;continue;}
case 639:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbilityStackInstance"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbilityStackInstance")));f.Pc=642;continue;}
case 642:{f.StackOp("dup");f.Pc=643;continue;}
case 643:{f.Push(f.Locals[1]);f.Pc=644;continue;}
case 644:{f.Push(f.Locals[3]);f.Pc=645;continue;}
case 645:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","<init>","(Lforge/game/spellability/SpellAbility;I)V","invokespecial",648);}
case 648:{f.Pc=652;continue;}
case 651:{f.Push(f.Locals[2]);f.Pc=652;continue;}
case 652:{f.Locals[2]=f.Pop();f.Pc=653;continue;}
case 653:{f.Push(f.Locals[0]);f.Pc=654;continue;}
case 654:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=657;continue;}
case 657:{f.Push(f.Locals[2]);f.Pc=658;continue;}
case 658:{return rt.Call(f,"java/util/Deque","addFirst","(Ljava/lang/Object;)V","invokeinterface",663);}
case 663:{f.Push(JValue.I(0));f.Pc=664;continue;}
case 664:{f.Locals[6]=f.Pop();f.Pc=666;continue;}
case 666:{if(!rt.EnsureInitialized(f,"java/util/TreeSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeSet")));f.Pc=669;continue;}
case 669:{f.StackOp("dup");f.Pc=670;continue;}
case 670:{return rt.Call(f,"java/util/TreeSet","<init>","()V","invokespecial",673);}
case 673:{f.Locals[7]=f.Pop();f.Pc=675;continue;}
case 675:{f.Push(f.Locals[0]);f.Pc=676;continue;}
case 676:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=679;continue;}
case 679:{return rt.Call(f,"java/util/Deque","iterator","()Ljava/util/Iterator;","invokeinterface",684);}
case 684:{f.Locals[8]=f.Pop();f.Pc=686;continue;}
case 686:{f.Push(f.Locals[8]);f.Pc=688;continue;}
case 688:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",693);}
case 693:{f.Pc=f.Pop().Int==0?744:696;continue;}
case 696:{f.Push(f.Locals[8]);f.Pc=698;continue;}
case 698:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",703);}
case 703:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=706;continue;}
case 706:{f.Locals[9]=f.Pop();f.Pc=708;continue;}
case 708:{f.Push(f.Locals[9]);f.Pc=710;continue;}
case 710:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","isSpell","()Z","invokevirtual",713);}
case 713:{f.Pc=f.Pop().Int==0?722:716;continue;}
case 716:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=719;continue;}
case 719:{f.Pc=741;continue;}
case 722:{f.Push(f.Locals[7]);f.Pc=724;continue;}
case 724:{f.Push(f.Locals[9]);f.Pc=726;continue;}
case 726:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSourceCard","()Lforge/game/card/Card;","invokevirtual",729);}
case 729:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",732);}
case 732:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",735);}
case 735:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",740);}
case 740:{f.StackOp("pop");f.Pc=741;continue;}
case 741:{f.Pc=686;continue;}
case 744:{f.Push(f.Locals[6]);f.Pc=746;continue;}
case 746:{f.Push(f.Locals[7]);f.Pc=748;continue;}
case 748:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",753);}
case 753:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=754;continue;}
case 754:{f.Locals[6]=f.Pop();f.Pc=756;continue;}
case 756:{f.Push(f.Locals[6]);f.Pc=758;continue;}
case 758:{f.Push(f.Locals[0]);f.Pc=759;continue;}
case 759:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","maxDistinctSources","I"));f.Pc=762;continue;}
case 762:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?771:765;continue;}
case 765:{f.Push(f.Locals[0]);f.Pc=766;continue;}
case 766:{f.Push(f.Locals[6]);f.Pc=768;continue;}
case 768:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","maxDistinctSources","I",value);f.Pc=771;continue;}
case 771:{f.Push(f.Locals[1]);f.Pc=772;continue;}
case 772:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",775);}
case 775:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",778);}
case 778:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",781);}
case 781:{f.Push(JValue.I(0));f.Pc=782;continue;}
case 782:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(Z)V","invokevirtual",785);}
case 785:{f.Push(f.Locals[1]);f.Pc=786;continue;}
case 786:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",789);}
case 789:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",792);}
case 792:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",795);}
case 795:{return rt.Call(f,"forge/game/trigger/TriggerHandler","resetActiveTriggers","()V","invokevirtual",798);}
case 798:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",801);}
case 801:{f.Locals[8]=f.Pop();f.Pc=803;continue;}
case 803:{f.Push(f.Locals[1]);f.Pc=804;continue;}
case 804:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",807);}
case 807:{f.Pc=f.Pop().Int==0?1001:810;continue;}
case 810:{f.Push(f.Locals[1]);f.Pc=811;continue;}
case 811:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCopied","()Z","invokevirtual",814);}
case 814:{f.Pc=f.Pop().Int!=0?1001:817;continue;}
case 817:{f.Push(f.Locals[1]);f.Pc=818;continue;}
case 818:{f.Push(f.Locals[4]);f.Pc=820;continue;}
case 820:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",823);}
case 823:{return rt.Call(f,"forge/game/spellability/SpellAbility","equals","(Ljava/lang/Object;)Z","invokevirtual",826);}
case 826:{f.Pc=f.Pop().Int==0?840:829;continue;}
case 829:{f.Push(f.Locals[4]);f.Pc=831;continue;}
case 831:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",834);}
case 834:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",837);}
case 837:{f.Pc=845;continue;}
case 840:{f.Push(f.Locals[4]);f.Pc=842;continue;}
case 842:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",845);}
case 845:{f.Locals[9]=f.Pop();f.Pc=847;continue;}
case 847:{f.Push(f.Locals[8]);f.Pc=849;continue;}
case 849:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=852;continue;}
case 852:{f.Push(f.Locals[9]);f.Pc=854;continue;}
case 854:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",859);}
case 859:{f.StackOp("pop");f.Pc=860;continue;}
case 860:{f.Push(f.Locals[0]);f.Pc=861;continue;}
case 861:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","thisTurnCast","Ljava/util/List;"));f.Pc=864;continue;}
case 864:{f.Push(f.Locals[1]);f.Pc=865;continue;}
case 865:{f.Push(f.Locals[4]);f.Pc=867;continue;}
case 867:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",870);}
case 870:{return rt.Call(f,"forge/game/spellability/SpellAbility","equals","(Ljava/lang/Object;)Z","invokevirtual",873);}
case 873:{f.Pc=f.Pop().Int==0?884:876;continue;}
case 876:{f.Push(f.Locals[4]);f.Pc=878;continue;}
case 878:{return rt.Call(f,"forge/game/card/Card","getCastSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",881);}
case 881:{f.Pc=891;continue;}
case 884:{f.Push(f.Locals[1]);f.Pc=885;continue;}
case 885:{f.Push(f.Locals[9]);f.Pc=887;continue;}
case 887:{f.Push(JValue.I(1));f.Pc=888;continue;}
case 888:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",891);}
case 891:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",896);}
case 896:{f.StackOp("pop");f.Pc=897;continue;}
case 897:{f.Push(f.Locals[1]);f.Pc=898;continue;}
case 898:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",901);}
case 901:{return rt.Call(f,"forge/game/player/Player","addSpellCastThisTurn","()V","invokevirtual",904);}
case 904:{f.Push(f.Locals[1]);f.Pc=905;continue;}
case 905:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingMana","()Ljava/util/List;","invokevirtual",908);}
case 908:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",913);}
case 913:{return rt.DynamicCall(f,"forge/game/zone/MagicStack:11045:913:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",918);}
case 918:{return rt.Call(f,"java/util/stream/Collectors","counting","()Ljava/util/stream/Collector;","invokestatic",921);}
case 921:{return rt.Call(f,"java/util/stream/Collectors","groupingBy","(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;","invokestatic",924);}
case 924:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",929);}
case 929:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=932;continue;}
case 932:{f.Locals[10]=f.Pop();f.Pc=934;continue;}
case 934:{f.Push(f.Locals[10]);f.Pc=936;continue;}
case 936:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",941);}
case 941:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",946);}
case 946:{f.Locals[11]=f.Pop();f.Pc=948;continue;}
case 948:{f.Push(f.Locals[11]);f.Pc=950;continue;}
case 950:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",955);}
case 955:{f.Pc=f.Pop().Int==0?1001:958;continue;}
case 958:{f.Push(f.Locals[11]);f.Pc=960;continue;}
case 960:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",965);}
case 965:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=968;continue;}
case 968:{f.Locals[12]=f.Pop();f.Pc=970;continue;}
case 970:{f.Push(f.Locals[12]);f.Pc=972;continue;}
case 972:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",977);}
case 977:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=980;continue;}
case 980:{f.Push(f.Locals[12]);f.Pc=982;continue;}
case 982:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",987);}
case 987:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Long"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=990;continue;}
case 990:{return rt.Call(f,"java/lang/Long","longValue","()J","invokevirtual",993);}
case 993:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=994;continue;}
case 994:{f.Push(f.Locals[1]);f.Pc=995;continue;}
case 995:{return rt.Call(f,"forge/game/player/Player","addExpentThisTurn","(ILforge/game/spellability/SpellAbility;)V","invokevirtual",998);}
case 998:{f.Pc=948;continue;}
case 1001:{f.Push(f.Locals[8]);f.Pc=1003;continue;}
case 1003:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"));f.Pc=1006;continue;}
case 1006:{f.Push(f.Locals[5]);f.Pc=1008;continue;}
case 1008:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1013);}
case 1013:{f.StackOp("pop");f.Pc=1014;continue;}
case 1014:{f.Push(f.Locals[8]);f.Pc=1016;continue;}
case 1016:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"));f.Pc=1019;continue;}
case 1019:{f.Push(f.Locals[1]);f.Pc=1020;continue;}
case 1020:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1025);}
case 1025:{f.StackOp("pop");f.Pc=1026;continue;}
case 1026:{f.Push(f.Locals[8]);f.Pc=1028;continue;}
case 1028:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CurrentStormCount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CurrentStormCount","Lforge/game/ability/AbilityKey;"));f.Pc=1031;continue;}
case 1031:{f.Push(f.Locals[0]);f.Pc=1032;continue;}
case 1032:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","thisTurnCast","Ljava/util/List;"));f.Pc=1035;continue;}
case 1035:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1040);}
case 1040:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1043);}
case 1043:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1048);}
case 1048:{f.StackOp("pop");f.Pc=1049;continue;}
case 1049:{f.Push(f.Locals[8]);f.Pc=1051;continue;}
case 1051:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CurrentCastSpells","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CurrentCastSpells","Lforge/game/ability/AbilityKey;"));f.Pc=1054;continue;}
case 1054:{f.Push(f.Locals[0]);f.Pc=1055;continue;}
case 1055:{return rt.Call(f,"forge/game/zone/MagicStack","getSpellCardsCastThisTurn","()Ljava/util/List;","invokevirtual",1058);}
case 1058:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1063);}
case 1063:{f.StackOp("pop");f.Pc=1064;continue;}
case 1064:{f.Push(f.Locals[0]);f.Pc=1065;continue;}
case 1065:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=1068;continue;}
case 1068:{return rt.Call(f,"forge/game/Game","updateStackForView","()V","invokevirtual",1071);}
case 1071:{f.Push(f.Locals[0]);f.Pc=1072;continue;}
case 1072:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=1075;continue;}
case 1075:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventSpellAbilityCast"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventSpellAbilityCast")));f.Pc=1078;continue;}
case 1078:{f.StackOp("dup");f.Pc=1079;continue;}
case 1079:{f.Push(f.Locals[1]);f.Pc=1080;continue;}
case 1080:{f.Push(f.Locals[2]);f.Pc=1081;continue;}
case 1081:{f.Push(f.Locals[0]);f.Pc=1082;continue;}
case 1082:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=1085;continue;}
case 1085:{return rt.Call(f,"java/util/Deque","size","()I","invokeinterface",1090);}
case 1090:{f.Push(JValue.I(1));f.Pc=1091;continue;}
case 1091:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=1092;continue;}
case 1092:{return rt.Call(f,"forge/game/event/GameEventSpellAbilityCast","<init>","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbilityStackInstance;I)V","invokespecial",1095);}
case 1095:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",1098);}
case 1098:{f.Push(f.Locals[1]);f.Pc=1099;continue;}
case 1099:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCopied","()Z","invokevirtual",1102);}
case 1102:{f.Pc=f.Pop().Int!=0?1598:1105;continue;}
case 1105:{f.Push(f.Locals[0]);f.Pc=1106;continue;}
case 1106:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=1109;continue;}
case 1109:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1112);}
case 1112:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","SpellAbilityCast","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","SpellAbilityCast","Lforge/game/trigger/TriggerType;"));f.Pc=1115;continue;}
case 1115:{f.Push(f.Locals[8]);f.Pc=1117;continue;}
case 1117:{f.Push(JValue.I(1));f.Pc=1118;continue;}
case 1118:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1121);}
case 1121:{f.Push(f.Locals[1]);f.Pc=1122;continue;}
case 1122:{return rt.Call(f,"forge/game/spellability/SpellAbility","applyPayingManaEffects","()V","invokevirtual",1125);}
case 1125:{f.Push(f.Locals[1]);f.Pc=1126;continue;}
case 1126:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",1129);}
case 1129:{f.Pc=f.Pop().Int==0?1198:1132;continue;}
case 1132:{f.Push(f.Locals[4]);f.Pc=1134;continue;}
case 1134:{return rt.Call(f,"forge/game/card/Card","isCommander","()Z","invokevirtual",1137);}
case 1137:{f.Pc=f.Pop().Int==0?1182:1140;continue;}
case 1140:{f.Push(f.Locals[4]);f.Pc=1142;continue;}
case 1142:{return rt.Call(f,"forge/game/card/Card","getCastFrom","()Lforge/game/zone/Zone;","invokevirtual",1145);}
case 1145:{f.Pc=f.Pop().Reference==null?1182:1148;continue;}
case 1148:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=1151;continue;}
case 1151:{f.Push(f.Locals[4]);f.Pc=1153;continue;}
case 1153:{return rt.Call(f,"forge/game/card/Card","getCastFrom","()Lforge/game/zone/Zone;","invokevirtual",1156);}
case 1156:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1159);}
case 1159:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?1182:1162;continue;}
case 1162:{f.Push(f.Locals[4]);f.Pc=1164;continue;}
case 1164:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",1167);}
case 1167:{f.Push(f.Locals[5]);f.Pc=1169;continue;}
case 1169:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",1172);}
case 1172:{f.Pc=f.Pop().Int==0?1182:1175;continue;}
case 1175:{f.Push(f.Locals[5]);f.Pc=1177;continue;}
case 1177:{f.Push(f.Locals[4]);f.Pc=1179;continue;}
case 1179:{return rt.Call(f,"forge/game/player/Player","incCommanderCast","(Lforge/game/card/Card;)V","invokevirtual",1182);}
case 1182:{f.Push(f.Locals[0]);f.Pc=1183;continue;}
case 1183:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=1186;continue;}
case 1186:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1189);}
case 1189:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","SpellCast","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","SpellCast","Lforge/game/trigger/TriggerType;"));f.Pc=1192;continue;}
case 1192:{f.Push(f.Locals[8]);f.Pc=1194;continue;}
case 1194:{f.Push(JValue.I(1));f.Pc=1195;continue;}
case 1195:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1198);}
case 1198:{f.Push(f.Locals[1]);f.Pc=1199;continue;}
case 1199:{return rt.Call(f,"forge/game/spellability/SpellAbility","isActivatedAbility","()Z","invokevirtual",1202);}
case 1202:{f.Pc=f.Pop().Int==0?1221:1205;continue;}
case 1205:{f.Push(f.Locals[0]);f.Pc=1206;continue;}
case 1206:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=1209;continue;}
case 1209:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1212);}
case 1212:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AbilityCast","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AbilityCast","Lforge/game/trigger/TriggerType;"));f.Pc=1215;continue;}
case 1215:{f.Push(f.Locals[8]);f.Pc=1217;continue;}
case 1217:{f.Push(JValue.I(1));f.Pc=1218;continue;}
case 1218:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1221);}
case 1221:{f.Push(f.Locals[1]);f.Pc=1222;continue;}
case 1222:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMaxWaterbend","()Ljava/lang/Integer;","invokevirtual",1225);}
case 1225:{f.Pc=f.Pop().Reference==null?1236:1228;continue;}
case 1228:{f.Push(f.Locals[5]);f.Pc=1230;continue;}
case 1230:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Waterbend","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Waterbend","Lforge/game/trigger/TriggerType;"));f.Pc=1233;continue;}
case 1233:{return rt.Call(f,"forge/game/player/Player","triggerElementalBend","(Lforge/game/trigger/TriggerType;)V","invokevirtual",1236);}
case 1236:{f.Push(f.Locals[1]);f.Pc=1237;continue;}
case 1237:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCycling","()Z","invokevirtual",1240);}
case 1240:{f.Pc=f.Pop().Int==0?1249:1243;continue;}
case 1243:{f.Push(f.Locals[5]);f.Pc=1245;continue;}
case 1245:{f.Push(f.Locals[1]);f.Pc=1246;continue;}
case 1246:{return rt.Call(f,"forge/game/player/Player","addCycled","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1249);}
case 1249:{f.Push(f.Locals[1]);f.Pc=1250;continue;}
case 1250:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCrew","()Z","invokevirtual",1253);}
case 1253:{f.Pc=f.Pop().Int==0?1357:1256;continue;}
case 1256:{f.Push(f.Locals[4]);f.Pc=1258;continue;}
case 1258:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",1261);}
case 1261:{f.Push(JValue.R(rt.String("Vehicle")));f.Pc=1264;continue;}
case 1264:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",1269);}
case 1269:{f.Pc=f.Pop().Int==0?1357:1272;continue;}
case 1272:{f.Push(f.Locals[1]);f.Pc=1273;continue;}
case 1273:{f.Push(JValue.R(rt.String("Tapped")));f.Pc=1276;continue;}
case 1276:{f.Push(JValue.I(1));f.Pc=1277;continue;}
case 1277:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPaidList","(Ljava/lang/String;Z)Lforge/game/card/CardCollection;","invokevirtual",1280);}
case 1280:{f.Locals[9]=f.Pop();f.Pc=1282;continue;}
case 1282:{f.Push(f.Locals[9]);f.Pc=1284;continue;}
case 1284:{f.Pc=f.Pop().Reference==null?1357:1287;continue;}
case 1287:{f.Push(f.Locals[9]);f.Pc=1289;continue;}
case 1289:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",1294);}
case 1294:{f.Locals[10]=f.Pop();f.Pc=1296;continue;}
case 1296:{f.Push(f.Locals[10]);f.Pc=1298;continue;}
case 1298:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1303);}
case 1303:{f.Pc=f.Pop().Int==0?1357:1306;continue;}
case 1306:{f.Push(f.Locals[10]);f.Pc=1308;continue;}
case 1308:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1313);}
case 1313:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1316;continue;}
case 1316:{f.Locals[11]=f.Pop();f.Pc=1318;continue;}
case 1318:{f.Push(f.Locals[4]);f.Pc=1320;continue;}
case 1320:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",1323);}
case 1323:{f.Locals[12]=f.Pop();f.Pc=1325;continue;}
case 1325:{f.Push(f.Locals[12]);f.Pc=1327;continue;}
case 1327:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Crew","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Crew","Lforge/game/ability/AbilityKey;"));f.Pc=1330;continue;}
case 1330:{f.Push(f.Locals[11]);f.Pc=1332;continue;}
case 1332:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1337);}
case 1337:{f.StackOp("pop");f.Pc=1338;continue;}
case 1338:{f.Push(f.Locals[0]);f.Pc=1339;continue;}
case 1339:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=1342;continue;}
case 1342:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1345);}
case 1345:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Crewed","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Crewed","Lforge/game/trigger/TriggerType;"));f.Pc=1348;continue;}
case 1348:{f.Push(f.Locals[12]);f.Pc=1350;continue;}
case 1350:{f.Push(JValue.I(0));f.Pc=1351;continue;}
case 1351:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1354);}
case 1354:{f.Pc=1296;continue;}
case 1357:{f.Push(f.Locals[1]);f.Pc=1358;continue;}
case 1358:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","SADDLE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","SADDLE","Lforge/game/keyword/Keyword;"));f.Pc=1361;continue;}
case 1361:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",1364);}
case 1364:{f.Pc=f.Pop().Int==0?1468:1367;continue;}
case 1367:{f.Push(f.Locals[4]);f.Pc=1369;continue;}
case 1369:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",1372);}
case 1372:{f.Push(JValue.R(rt.String("Mount")));f.Pc=1375;continue;}
case 1375:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",1380);}
case 1380:{f.Pc=f.Pop().Int==0?1468:1383;continue;}
case 1383:{f.Push(f.Locals[1]);f.Pc=1384;continue;}
case 1384:{f.Push(JValue.R(rt.String("Tapped")));f.Pc=1387;continue;}
case 1387:{f.Push(JValue.I(1));f.Pc=1388;continue;}
case 1388:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPaidList","(Ljava/lang/String;Z)Lforge/game/card/CardCollection;","invokevirtual",1391);}
case 1391:{f.Locals[9]=f.Pop();f.Pc=1393;continue;}
case 1393:{f.Push(f.Locals[9]);f.Pc=1395;continue;}
case 1395:{f.Pc=f.Pop().Reference==null?1468:1398;continue;}
case 1398:{f.Push(f.Locals[9]);f.Pc=1400;continue;}
case 1400:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",1405);}
case 1405:{f.Locals[10]=f.Pop();f.Pc=1407;continue;}
case 1407:{f.Push(f.Locals[10]);f.Pc=1409;continue;}
case 1409:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1414);}
case 1414:{f.Pc=f.Pop().Int==0?1468:1417;continue;}
case 1417:{f.Push(f.Locals[10]);f.Pc=1419;continue;}
case 1419:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1424);}
case 1424:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1427;continue;}
case 1427:{f.Locals[11]=f.Pop();f.Pc=1429;continue;}
case 1429:{f.Push(f.Locals[4]);f.Pc=1431;continue;}
case 1431:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",1434);}
case 1434:{f.Locals[12]=f.Pop();f.Pc=1436;continue;}
case 1436:{f.Push(f.Locals[12]);f.Pc=1438;continue;}
case 1438:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Crew","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Crew","Lforge/game/ability/AbilityKey;"));f.Pc=1441;continue;}
case 1441:{f.Push(f.Locals[11]);f.Pc=1443;continue;}
case 1443:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1448);}
case 1448:{f.StackOp("pop");f.Pc=1449;continue;}
case 1449:{f.Push(f.Locals[0]);f.Pc=1450;continue;}
case 1450:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=1453;continue;}
case 1453:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1456);}
case 1456:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Saddled","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Saddled","Lforge/game/trigger/TriggerType;"));f.Pc=1459;continue;}
case 1459:{f.Push(f.Locals[12]);f.Pc=1461;continue;}
case 1461:{f.Push(JValue.I(0));f.Pc=1462;continue;}
case 1462:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1465);}
case 1465:{f.Pc=1407;continue;}
case 1468:{f.Push(f.Locals[1]);f.Pc=1469;continue;}
case 1469:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","STATION","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","STATION","Lforge/game/keyword/Keyword;"));f.Pc=1472;continue;}
case 1472:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",1475);}
case 1475:{f.Pc=f.Pop().Int==0?1637:1478;continue;}
case 1478:{f.Push(f.Locals[4]);f.Pc=1480;continue;}
case 1480:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",1483);}
case 1483:{f.Push(JValue.R(rt.String("Spacecraft")));f.Pc=1486;continue;}
case 1486:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",1491);}
case 1491:{f.Pc=f.Pop().Int!=0?1510:1494;continue;}
case 1494:{f.Push(f.Locals[4]);f.Pc=1496;continue;}
case 1496:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",1499);}
case 1499:{f.Push(JValue.R(rt.String("Planet")));f.Pc=1502;continue;}
case 1502:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",1507);}
case 1507:{f.Pc=f.Pop().Int==0?1637:1510;continue;}
case 1510:{f.Push(f.Locals[1]);f.Pc=1511;continue;}
case 1511:{f.Push(JValue.R(rt.String("Tapped")));f.Pc=1514;continue;}
case 1514:{f.Push(JValue.I(1));f.Pc=1515;continue;}
case 1515:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPaidList","(Ljava/lang/String;Z)Lforge/game/card/CardCollection;","invokevirtual",1518);}
case 1518:{f.Locals[9]=f.Pop();f.Pc=1520;continue;}
case 1520:{f.Push(f.Locals[9]);f.Pc=1522;continue;}
case 1522:{f.Pc=f.Pop().Reference==null?1595:1525;continue;}
case 1525:{f.Push(f.Locals[9]);f.Pc=1527;continue;}
case 1527:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",1532);}
case 1532:{f.Locals[10]=f.Pop();f.Pc=1534;continue;}
case 1534:{f.Push(f.Locals[10]);f.Pc=1536;continue;}
case 1536:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1541);}
case 1541:{f.Pc=f.Pop().Int==0?1595:1544;continue;}
case 1544:{f.Push(f.Locals[10]);f.Pc=1546;continue;}
case 1546:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1551);}
case 1551:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1554;continue;}
case 1554:{f.Locals[11]=f.Pop();f.Pc=1556;continue;}
case 1556:{f.Push(f.Locals[4]);f.Pc=1558;continue;}
case 1558:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",1561);}
case 1561:{f.Locals[12]=f.Pop();f.Pc=1563;continue;}
case 1563:{f.Push(f.Locals[12]);f.Pc=1565;continue;}
case 1565:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Crew","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Crew","Lforge/game/ability/AbilityKey;"));f.Pc=1568;continue;}
case 1568:{f.Push(f.Locals[11]);f.Pc=1570;continue;}
case 1570:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1575);}
case 1575:{f.StackOp("pop");f.Pc=1576;continue;}
case 1576:{f.Push(f.Locals[0]);f.Pc=1577;continue;}
case 1577:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=1580;continue;}
case 1580:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1583);}
case 1583:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Stationed","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Stationed","Lforge/game/trigger/TriggerType;"));f.Pc=1586;continue;}
case 1586:{f.Push(f.Locals[12]);f.Pc=1588;continue;}
case 1588:{f.Push(JValue.I(0));f.Pc=1589;continue;}
case 1589:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1592);}
case 1592:{f.Pc=1534;continue;}
case 1595:{f.Pc=1637;continue;}
case 1598:{f.Push(f.Locals[1]);f.Pc=1599;continue;}
case 1599:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",1602);}
case 1602:{f.Pc=f.Pop().Int==0?1621:1605;continue;}
case 1605:{f.Push(f.Locals[0]);f.Pc=1606;continue;}
case 1606:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=1609;continue;}
case 1609:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1612);}
case 1612:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","SpellCopy","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","SpellCopy","Lforge/game/trigger/TriggerType;"));f.Pc=1615;continue;}
case 1615:{f.Push(f.Locals[8]);f.Pc=1617;continue;}
case 1617:{f.Push(JValue.I(0));f.Pc=1618;continue;}
case 1618:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1621);}
case 1621:{f.Push(f.Locals[0]);f.Pc=1622;continue;}
case 1622:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=1625;continue;}
case 1625:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1628);}
case 1628:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","SpellAbilityCopy","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","SpellAbilityCopy","Lforge/game/trigger/TriggerType;"));f.Pc=1631;continue;}
case 1631:{f.Push(f.Locals[8]);f.Pc=1633;continue;}
case 1633:{f.Push(JValue.I(0));f.Pc=1634;continue;}
case 1634:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1637);}
case 1637:{f.Push(f.Locals[1]);f.Pc=1638;continue;}
case 1638:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",1641);}
case 1641:{f.Pc=f.Pop().Int==0?1660:1644;continue;}
case 1644:{f.Push(f.Locals[0]);f.Pc=1645;continue;}
case 1645:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=1648;continue;}
case 1648:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1651);}
case 1651:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","SpellCastOrCopy","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","SpellCastOrCopy","Lforge/game/trigger/TriggerType;"));f.Pc=1654;continue;}
case 1654:{f.Push(f.Locals[8]);f.Pc=1656;continue;}
case 1656:{f.Push(JValue.I(0));f.Pc=1657;continue;}
case 1657:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1660);}
case 1660:{f.Push(f.Locals[1]);f.Pc=1661;continue;}
case 1661:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAllTargetChoices","()Ljava/util/List;","invokevirtual",1664);}
case 1664:{f.Locals[9]=f.Pop();f.Pc=1666;continue;}
case 1666:{f.Push(f.Locals[9]);f.Pc=1668;continue;}
case 1668:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1673);}
case 1673:{f.Pc=f.Pop().Int!=0?1999:1676;continue;}
case 1676:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",1679);}
case 1679:{f.Locals[10]=f.Pop();f.Pc=1681;continue;}
case 1681:{f.Push(f.Locals[9]);f.Pc=1683;continue;}
case 1683:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1688);}
case 1688:{f.Locals[11]=f.Pop();f.Pc=1690;continue;}
case 1690:{f.Push(f.Locals[11]);f.Pc=1692;continue;}
case 1692:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1697);}
case 1697:{f.Pc=f.Pop().Int==0?1872:1700;continue;}
case 1700:{f.Push(f.Locals[11]);f.Pc=1702;continue;}
case 1702:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1707);}
case 1707:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/TargetChoices"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1710;continue;}
case 1710:{f.Locals[12]=f.Pop();f.Pc=1712;continue;}
case 1712:{f.Push(f.Locals[12]);f.Pc=1714;continue;}
case 1714:{return rt.Call(f,"forge/game/spellability/TargetChoices","iterator","()Ljava/util/Iterator;","invokevirtual",1717);}
case 1717:{f.Locals[13]=f.Pop();f.Pc=1719;continue;}
case 1719:{f.Push(f.Locals[13]);f.Pc=1721;continue;}
case 1721:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1726);}
case 1726:{f.Pc=f.Pop().Int==0?1869:1729;continue;}
case 1729:{f.Push(f.Locals[13]);f.Pc=1731;continue;}
case 1731:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1736);}
case 1736:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1739;continue;}
case 1739:{f.Locals[14]=f.Pop();f.Pc=1741;continue;}
case 1741:{f.Push(f.Locals[10]);f.Pc=1743;continue;}
case 1743:{f.Push(f.Locals[14]);f.Pc=1745;continue;}
case 1745:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",1750);}
case 1750:{f.Pc=f.Pop().Int!=0?1756:1753;continue;}
case 1753:{f.Pc=1719;continue;}
case 1756:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",1759);}
case 1759:{f.Locals[8]=f.Pop();f.Pc=1761;continue;}
case 1761:{f.Push(f.Locals[8]);f.Pc=1763;continue;}
case 1763:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SourceSA","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SourceSA","Lforge/game/ability/AbilityKey;"));f.Pc=1766;continue;}
case 1766:{f.Push(f.Locals[1]);f.Pc=1767;continue;}
case 1767:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1772);}
case 1772:{f.StackOp("pop");f.Pc=1773;continue;}
case 1773:{f.Push(f.Locals[8]);f.Pc=1775;continue;}
case 1775:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Target","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Target","Lforge/game/ability/AbilityKey;"));f.Pc=1778;continue;}
case 1778:{f.Push(f.Locals[14]);f.Pc=1780;continue;}
case 1780:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1785);}
case 1785:{f.StackOp("pop");f.Pc=1786;continue;}
case 1786:{f.Push(f.Locals[14]);f.Pc=1788;continue;}
case 1788:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=1791;continue;}
case 1791:{f.Pc=f.Pop().Int==0?1850:1794;continue;}
case 1794:{f.Push(f.Locals[14]);f.Pc=1796;continue;}
case 1796:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1799;continue;}
case 1799:{f.Locals[15]=f.Pop();f.Pc=1801;continue;}
case 1801:{f.Push(f.Locals[15]);f.Pc=1803;continue;}
case 1803:{return rt.Call(f,"forge/game/card/Card","hasBecomeTargetThisTurn","()Z","invokevirtual",1806);}
case 1806:{f.Pc=f.Pop().Int!=0?1821:1809;continue;}
case 1809:{f.Push(f.Locals[8]);f.Pc=1811;continue;}
case 1811:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","FirstTime","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","FirstTime","Lforge/game/ability/AbilityKey;"));f.Pc=1814;continue;}
case 1814:{f.Push(JValue.R(null));f.Pc=1815;continue;}
case 1815:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1820);}
case 1820:{f.StackOp("pop");f.Pc=1821;continue;}
case 1821:{f.Push(f.Locals[15]);f.Pc=1823;continue;}
case 1823:{f.Push(f.Locals[5]);f.Pc=1825;continue;}
case 1825:{return rt.Call(f,"forge/game/card/Card","isValiant","(Lforge/game/player/Player;)Z","invokevirtual",1828);}
case 1828:{f.Pc=f.Pop().Int==0?1843:1831;continue;}
case 1831:{f.Push(f.Locals[8]);f.Pc=1833;continue;}
case 1833:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Valiant","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Valiant","Lforge/game/ability/AbilityKey;"));f.Pc=1836;continue;}
case 1836:{f.Push(JValue.R(null));f.Pc=1837;continue;}
case 1837:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1842);}
case 1842:{f.StackOp("pop");f.Pc=1843;continue;}
case 1843:{f.Push(f.Locals[15]);f.Pc=1845;continue;}
case 1845:{f.Push(f.Locals[5]);f.Pc=1847;continue;}
case 1847:{return rt.Call(f,"forge/game/card/Card","addTargetFromThisTurn","(Lforge/game/player/Player;)V","invokevirtual",1850);}
case 1850:{f.Push(f.Locals[0]);f.Pc=1851;continue;}
case 1851:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=1854;continue;}
case 1854:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1857);}
case 1857:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","BecomesTarget","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","BecomesTarget","Lforge/game/trigger/TriggerType;"));f.Pc=1860;continue;}
case 1860:{f.Push(f.Locals[8]);f.Pc=1862;continue;}
case 1862:{f.Push(JValue.I(0));f.Pc=1863;continue;}
case 1863:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1866);}
case 1866:{f.Pc=1719;continue;}
case 1869:{f.Pc=1690;continue;}
case 1872:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",1875);}
case 1875:{f.Locals[8]=f.Pop();f.Pc=1877;continue;}
case 1877:{f.Push(f.Locals[8]);f.Pc=1879;continue;}
case 1879:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SourceSA","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SourceSA","Lforge/game/ability/AbilityKey;"));f.Pc=1882;continue;}
case 1882:{f.Push(f.Locals[1]);f.Pc=1883;continue;}
case 1883:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1888);}
case 1888:{f.StackOp("pop");f.Pc=1889;continue;}
case 1889:{f.Push(f.Locals[8]);f.Pc=1891;continue;}
case 1891:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Targets","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Targets","Lforge/game/ability/AbilityKey;"));f.Pc=1894;continue;}
case 1894:{f.Push(f.Locals[10]);f.Pc=1896;continue;}
case 1896:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1901);}
case 1901:{f.StackOp("pop");f.Pc=1902;continue;}
case 1902:{f.Push(f.Locals[8]);f.Pc=1904;continue;}
case 1904:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=1907;continue;}
case 1907:{f.Push(f.Locals[1]);f.Pc=1908;continue;}
case 1908:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",1911);}
case 1911:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1916);}
case 1916:{f.StackOp("pop");f.Pc=1917;continue;}
case 1917:{f.Push(f.Locals[1]);f.Pc=1918;continue;}
case 1918:{f.Locals[11]=f.Pop();f.Pc=1920;continue;}
case 1920:{f.Push(f.Locals[11]);f.Pc=1922;continue;}
case 1922:{f.Pc=f.Pop().Reference==null?1983:1925;continue;}
case 1925:{f.Push(f.Locals[11]);f.Pc=1927;continue;}
case 1927:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",1930);}
case 1930:{f.Pc=f.Pop().Int==0?1973:1933;continue;}
case 1933:{f.Push(f.Locals[11]);f.Pc=1935;continue;}
case 1935:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",1938);}
case 1938:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isRandomTarget","()Z","invokevirtual",1941);}
case 1941:{f.Pc=f.Pop().Int==0?1973:1944;continue;}
case 1944:{f.Push(f.Locals[11]);f.Pc=1946;continue;}
case 1946:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",1949);}
case 1949:{return rt.Call(f,"forge/game/spellability/TargetChoices","isEmpty","()Z","invokevirtual",1952);}
case 1952:{f.Pc=f.Pop().Int!=0?1973:1955;continue;}
case 1955:{f.Push(f.Locals[8]);f.Pc=1957;continue;}
case 1957:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Random","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Random","Lforge/game/ability/AbilityKey;"));f.Pc=1960;continue;}
case 1960:{f.Push(JValue.I(1));f.Pc=1961;continue;}
case 1961:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",1964);}
case 1964:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1969);}
case 1969:{f.StackOp("pop");f.Pc=1970;continue;}
case 1970:{f.Pc=1983;continue;}
case 1973:{f.Push(f.Locals[11]);f.Pc=1975;continue;}
case 1975:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",1978);}
case 1978:{f.Locals[11]=f.Pop();f.Pc=1980;continue;}
case 1980:{f.Pc=1920;continue;}
case 1983:{f.Push(f.Locals[0]);f.Pc=1984;continue;}
case 1984:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=1987;continue;}
case 1987:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1990);}
case 1990:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","BecomesTargetOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","BecomesTargetOnce","Lforge/game/trigger/TriggerType;"));f.Pc=1993;continue;}
case 1993:{f.Push(f.Locals[8]);f.Pc=1995;continue;}
case 1995:{f.Push(JValue.I(0));f.Pc=1996;continue;}
case 1996:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1999);}
case 1999:{f.Push(f.Locals[5]);f.Pc=2001;continue;}
case 2001:{f.Push(f.Locals[9]);f.Pc=2003;continue;}
case 2003:{return rt.Call(f,"forge/game/zone/MagicStack","commitCrimeCheck","(Lforge/game/player/Player;Ljava/lang/Iterable;)Z","invokestatic",2006);}
case 2006:{f.Pc=f.Pop().Int==0?2014:2009;continue;}
case 2009:{f.Push(f.Locals[5]);f.Pc=2011;continue;}
case 2011:{return rt.Call(f,"forge/game/player/Player","commitCrime","()V","invokevirtual",2014);}
case 2014:{f.Push(f.Locals[0]);f.Pc=2015;continue;}
case 2015:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=2018;continue;}
case 2018:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventZone"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventZone")));f.Pc=2021;continue;}
case 2021:{f.StackOp("dup");f.Pc=2022;continue;}
case 2022:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=2025;continue;}
case 2025:{f.Push(f.Locals[1]);f.Pc=2026;continue;}
case 2026:{if(!rt.StaticReady(f,"forge/game/event/EventValueChangeType","Added","Lforge/game/event/EventValueChangeType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/event/EventValueChangeType","Added","Lforge/game/event/EventValueChangeType;"));f.Pc=2029;continue;}
case 2029:{return rt.Call(f,"forge/game/event/GameEventZone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;Lforge/game/event/EventValueChangeType;)V","invokespecial",2032);}
case 2032:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",2035);}
case 2035:{f.Push(f.Locals[0]);f.Pc=2036;continue;}
case 2036:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=2039;continue;}
case 2039:{return rt.Call(f,"forge/game/Game","getCardsPlayerCanActivateInStack","()Lforge/game/card/CardCollectionView;","invokevirtual",2042);}
case 2042:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",2047);}
case 2047:{f.Pc=f.Pop().Int!=0?2065:2050;continue;}
case 2050:{f.Push(f.Locals[0]);f.Pc=2051;continue;}
case 2051:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=2054;continue;}
case 2054:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",2057);}
case 2057:{return rt.DynamicCall(f,"forge/game/zone/MagicStack:11045:2057:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Consumer;",2062);}
case 2062:{return rt.Call(f,"forge/game/player/PlayerCollection","forEach","(Ljava/util/function/Consumer;)V","invokevirtual",2065);}
case 2065:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11046(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.DynamicCall(f,"forge/game/zone/MagicStack:11046:8:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAllTargetChoices","()Ljava/util/List;","invokevirtual",22);}
case 22:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",25);}
case 25:{return rt.DynamicCall(f,"forge/game/zone/MagicStack:11046:25:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",30);}
case 30:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",33);}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=37;continue;}
case 37:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=40;continue;}
case 40:{f.StackOp("dup");f.Pc=41;continue;}
case 41:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_ADD","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_ADD","Lforge/game/GameLogEntryType;"));f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",48);}
case 48:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",51);}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","illegalAdditions","Ljava/util/Map;"));f.Pc=55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",59);}
case 59:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",62);}
case 62:{f.Push(JValue.I(1));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",66);}
case 66:{return rt.DynamicCall(f,"forge/game/zone/MagicStack:11046:66:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BiFunction;",71);}
case 71:{return rt.Call(f,"java/util/Map","merge","(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;","invokeinterface",76);}
case 76:{f.StackOp("pop");f.Pc=77;continue;}
case 77:{if(!rt.EnsureInitialized(f,"forge/game/mana/ManaRefundService"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/ManaRefundService")));f.Pc=80;continue;}
case 80:{f.StackOp("dup");f.Pc=81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/mana/ManaRefundService","<init>","(Lforge/game/spellability/SpellAbility;)V","invokespecial",85);}
case 85:{return rt.Call(f,"forge/game/mana/ManaRefundService","refundManaPaid","()V","invokevirtual",88);}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int==0?122:95;continue;}
case 95:{f.Push(f.Locals[2]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/card/Card","isCopiedSpell","()Z","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Int!=0?122:102;continue;}
case 102:{f.Push(f.Locals[2]);f.Pc=103;continue;}
case 103:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int==0?122:112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[2]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/card/Card","getCastFrom","()Lforge/game/zone/Zone;","invokevirtual",118);}
case 118:{return rt.Call(f,"forge/game/zone/MagicStack","returnStrandedSpell","(Lforge/game/card/Card;Lforge/game/zone/Zone;)Lforge/game/card/Card;","invokevirtual",121);}
case 121:{f.StackOp("pop");f.Pc=122;continue;}
case 122:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11047(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?20:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",11);}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/GameAction","moveToHand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Pc=61;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?47:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",37);}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{f.Push(JValue.R(null));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",43);}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{f.Pc=61;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",54);}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(null));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/Zone;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",60);}
case 60:{f.Locals[3]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{f.Pc=f.Pop().Reference==null?75:65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(null));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/Card","setCastFrom","(Lforge/game/zone/Zone;)V","invokevirtual",70);}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(null));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/card/Card","setCastSA","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",75);}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=79;continue;}
case 79:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=82;continue;}
case 82:{f.StackOp("dup");f.Pc=83;continue;}
case 83:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_ADD","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_ADD","Lforge/game/GameLogEntryType;"));f.Pc=86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",90);}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{f.Pc=f.Pop().Reference!=null?100:94;continue;}
case 94:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=97;continue;}
case 97:{f.Pc=104;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",104);}
case 104:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",107);}
case 107:{return rt.DynamicCall(f,"forge/game/zone/MagicStack:11047:107:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",112);}
case 112:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",115);}
case 115:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",118);}
case 118:{f.Push(f.Locals[3]);f.Pc=119;continue;}
case 119:{f.Pc=f.Pop().Reference!=null?126:122;continue;}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{f.Pc=127;continue;}
case 126:{f.Push(f.Locals[3]);f.Pc=127;continue;}
case 127:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11048(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?8:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{f.Pc=34;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","illegalAdditions","Ljava/util/Map;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",16);}
case 16:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",19);}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",23);}
case 23:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",34);}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11049(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/zone/MagicStack","getIllegalAdditionCount","(Lforge/game/card/Card;)I","invokevirtual",5);}
case 5:{f.Push(JValue.I(2));f.Pc=6;continue;}
case 6:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?13:9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{f.Pc=14;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11050(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?16:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","triggerRepeats","Ljava/util/Map;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",16);}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","isMandatory","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?30:23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?32:30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSourceTrigger","()I","invokevirtual",36);}
case 36:{f.Locals[2]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Deque","iterator","()Ljava/util/Iterator;","invokeinterface",46);}
case 46:{f.Locals[3]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",53);}
case 53:{f.Pc=f.Pop().Int==0?81:56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",62);}
case 62:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=65;continue;}
case 65:{f.Locals[4]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","isStateTrigger","(I)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int==0?78:76;continue;}
case 76:{f.Push(JValue.I(0));f.Pc=77;continue;}
case 77:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 78:{f.Pc=47;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","triggerRepeats","Ljava/util/Map;"));f.Pc=85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",89);}
case 89:{f.Push(JValue.I(1));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",93);}
case 93:{return rt.DynamicCall(f,"forge/game/zone/MagicStack:11050:93:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BiFunction;",98);}
case 98:{return rt.Call(f,"java/util/Map","merge","(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;","invokeinterface",103);}
case 103:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",109);}
case 109:{f.Push(JValue.I(50));f.Pc=111;continue;}
case 111:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?118:114;continue;}
case 114:{f.Push(JValue.I(1));f.Pc=115;continue;}
case 115:{f.Pc=119;continue;}
case 118:{f.Push(JValue.I(0));f.Pc=119;continue;}
case 119:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11051(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","triggerRepeats","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11052(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","isUndoable","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?41:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/zone/MagicStack","canUndo","(Lforge/game/player/Player;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int!=0?29:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/zone/MagicStack","clearUndoStack","()V","invokevirtual",24);}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","undoStackOwner","Lforge/game/player/Player;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","undoStack","Ljava/util/Stack;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Stack","push","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{f.Pc=45;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/zone/MagicStack","clearUndoStack","()V","invokevirtual",45);}
case 45:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11053(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","undoStack","Ljava/util/Stack;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Stack","size","()I","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11054(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","undoStackOwner","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11055(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","undoStack","Ljava/util/Stack;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Stack","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","undoStack","Ljava/util/Stack;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Stack","peek","()Ljava/lang/Object;","invokevirtual",19);}
case 19:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=22;continue;}
case 22:{f.Locals[1]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","undo","()Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?49:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/zone/MagicStack","clearUndoStack","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",35);}
case 35:{if(!rt.EnsureInitialized(f,"forge/game/mana/ManaRefundService"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/ManaRefundService")));f.Pc=38;continue;}
case 38:{f.StackOp("dup");f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/mana/ManaRefundService","<init>","(Lforge/game/spellability/SpellAbility;)V","invokespecial",43);}
case 43:{return rt.Call(f,"forge/game/mana/ManaRefundService","refundManaPaid","()V","invokevirtual",46);}
case 46:{f.Pc=97;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/zone/MagicStack","clearUndoStack","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",54);}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingMana","()Ljava/util/List;","invokevirtual",58);}
case 58:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",63);}
case 63:{f.Locals[2]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",70);}
case 70:{f.Pc=f.Pop().Int==0?97:73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",79);}
case 79:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=82;continue;}
case 82:{f.Locals[3]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/mana/Mana","getManaAbility","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",88);}
case 88:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",91);}
case 91:{return rt.Call(f,"forge/game/zone/MagicStack","clearUndoStack","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",94);}
case 94:{f.Pc=64;continue;}
case 97:{f.Push(JValue.I(1));f.Pc=98;continue;}
case 98:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11056(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?5:4;continue;}
case 4:{return JStep.ReturnVoid;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.NewArray("Lforge/game/spellability/SpellAbility;",f.Pop().Int)));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=14;continue;}
case 14:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",17);}
case 17:{return rt.Call(f,"forge/game/zone/MagicStack","clearUndoStack","(Ljava/util/List;)V","invokevirtual",20);}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11057(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?60:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","setUndoable","(Z)V","invokevirtual",31);}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","undoStack","Ljava/util/Stack;"));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Stack","lastIndexOf","(Ljava/lang/Object;)I","invokevirtual",39);}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{f.Push(JValue.I(-1));f.Pc=44;continue;}
case 44:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?57:47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","undoStack","Ljava/util/Stack;"));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Stack","remove","(I)Ljava/lang/Object;","invokevirtual",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{f.Pc=7;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","undoStack","Ljava/util/Stack;"));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Stack","isEmpty","()Z","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Int==0?75:70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(null));f.Pc=72;continue;}
case 72:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","undoStackOwner","Lforge/game/player/Player;",value);f.Pc=75;continue;}
case 75:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11058(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","undoStackOwner","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","undoStack","Ljava/util/Stack;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",16);}
case 16:{return rt.Call(f,"forge/game/zone/MagicStack","clearUndoStack","(Ljava/util/List;)V","invokevirtual",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(null));f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","undoStackOwner","Lforge/game/player/Player;",value);f.Pc=24;continue;}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11059(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","undoStack","Ljava/util/Stack;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/CardTraitPredicates","isHostCard","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/util/Collection;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11060(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Deque","size","()I","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11061(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Deque","isEmpty","()Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11062(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/zone/MagicStack","freezeStack","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/zone/MagicStack","peekAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","changeText","()V","invokevirtual",21);}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",28);}
case 28:{return rt.Call(f,"forge/game/phase/PhaseHandler","resetPriority","()V","invokevirtual",31);}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",35);}
case 35:{f.Locals[2]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","curResolving","Lforge/game/spellability/SpellAbility;",value);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(null));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/zone/MagicStack","hasFizzled","(Lforge/game/spellability/SpellAbility;Ljava/lang/Boolean;)Z","invokevirtual",47);}
case 47:{f.Locals[3]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Pc=f.Pop().Int!=0?59:52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/Game","copyLastState","()V","invokevirtual",59);}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/spellability/SpellAbility","getControlledByPlayer","()Lorg/apache/commons/lang3/tuple/Pair;","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Reference==null?96:66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",70);}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/spellability/SpellAbility","getControlledByPlayer","()Lorg/apache/commons/lang3/tuple/Pair;","invokevirtual",74);}
case 74:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",77);}
case 77:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Long"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/Long","longValue","()J","invokevirtual",83);}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/spellability/SpellAbility","getControlledByPlayer","()Lorg/apache/commons/lang3/tuple/Pair;","invokevirtual",87);}
case 87:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",90);}
case 90:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/player/Player","addController","(JLforge/game/player/Player;)V","invokevirtual",96);}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{f.Pc=f.Pop().Int==0?194:100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBestow","()Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int==0?149:107;continue;}
case 107:{f.Push(f.Locals[2]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/card/Card","unanimateBestow","()V","invokevirtual",111);}
case 111:{f.Push(f.Locals[2]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/Card","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",115);}
case 115:{f.Locals[4]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[4]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",123);}
case 123:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",126);}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=130;continue;}
case 130:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=133;continue;}
case 133:{f.StackOp("dup");f.Pc=134;continue;}
case 134:{f.Push(f.Locals[2]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",138);}
case 138:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",141);}
case 141:{f.Push(f.Locals[4]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",146);}
case 146:{f.Pc=250;continue;}
case 149:{f.Push(f.Locals[1]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/spellability/SpellAbility","isMutate","()Z","invokevirtual",153);}
case 153:{f.Pc=f.Pop().Int==0?250:156;continue;}
case 156:{f.Push(f.Locals[2]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/card/Card","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",160);}
case 160:{f.Locals[4]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[4]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[1]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",168);}
case 168:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",171);}
case 171:{f.Push(f.Locals[0]);f.Pc=172;continue;}
case 172:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=175;continue;}
case 175:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=178;continue;}
case 178:{f.StackOp("dup");f.Pc=179;continue;}
case 179:{f.Push(f.Locals[2]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",183);}
case 183:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",186);}
case 186:{f.Push(f.Locals[4]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",191);}
case 191:{f.Pc=250;continue;}
case 194:{f.Push(f.Locals[1]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",198);}
case 198:{f.Pc=f.Pop().Reference==null?246:201;continue;}
case 201:{f.Push(f.Locals[1]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/ability/AbilityUtils","handleRemembering","(Lforge/game/spellability/SpellAbility;)V","invokestatic",205);}
case 205:{f.Push(f.Locals[1]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",209);}
case 209:{f.Push(f.Locals[2]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",213);}
case 213:{f.Locals[4]=f.Pop();f.Pc=215;continue;}
case 215:{f.Push(f.Locals[4]);f.Pc=217;continue;}
case 217:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"));f.Pc=220;continue;}
case 220:{f.Push(f.Locals[1]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",226);}
case 226:{f.StackOp("pop");f.Pc=227;continue;}
case 227:{f.Push(f.Locals[0]);f.Pc=228;continue;}
case 228:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",234);}
case 234:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AbilityResolves","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AbilityResolves","Lforge/game/trigger/TriggerType;"));f.Pc=237;continue;}
case 237:{f.Push(f.Locals[4]);f.Pc=239;continue;}
case 239:{f.Push(JValue.I(0));f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",243);}
case 243:{f.Pc=250;continue;}
case 246:{f.Push(f.Locals[1]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/spellability/SpellAbility","resolve","()V","invokevirtual",250);}
case 250:{f.Push(f.Locals[1]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/spellability/SpellAbility","getControlledByPlayer","()Lorg/apache/commons/lang3/tuple/Pair;","invokevirtual",254);}
case 254:{f.Pc=f.Pop().Reference==null?290:257;continue;}
case 257:{f.Push(f.Locals[1]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",261);}
case 261:{f.Push(f.Locals[1]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/spellability/SpellAbility","getControlledByPlayer","()Lorg/apache/commons/lang3/tuple/Pair;","invokevirtual",265);}
case 265:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",268);}
case 268:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Long"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/lang/Long","longValue","()J","invokevirtual",274);}
case 274:{return rt.Call(f,"forge/game/player/Player","removeController","(J)V","invokevirtual",277);}
case 277:{f.Push(f.Locals[1]);f.Pc=278;continue;}
case 278:{f.Push(JValue.L(-1L));f.Pc=281;continue;}
case 281:{f.Push(JValue.R(null));f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/spellability/SpellAbility","setControlledByPlayer","(JLforge/game/player/Player;)V","invokevirtual",285);}
case 285:{f.Push(f.Locals[1]);f.Pc=286;continue;}
case 286:{f.Push(JValue.R(null));f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/spellability/SpellAbility","setManaCostBeingPaid","(Lforge/game/mana/ManaCostBeingPaid;)V","invokevirtual",290);}
case 290:{f.Push(f.Locals[0]);f.Pc=291;continue;}
case 291:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=294;continue;}
case 294:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventSpellResolved"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventSpellResolved")));f.Pc=297;continue;}
case 297:{f.StackOp("dup");f.Pc=298;continue;}
case 298:{f.Push(f.Locals[1]);f.Pc=299;continue;}
case 299:{f.Push(f.Locals[3]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/game/event/GameEventSpellResolved","<init>","(Lforge/game/spellability/SpellAbility;Z)V","invokespecial",303);}
case 303:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",306);}
case 306:{f.Push(f.Locals[0]);f.Pc=307;continue;}
case 307:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",313);}
case 313:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","()V","invokevirtual",316);}
case 316:{f.Push(f.Locals[0]);f.Pc=317;continue;}
case 317:{f.Push(f.Locals[1]);f.Pc=318;continue;}
case 318:{f.Push(f.Locals[3]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/zone/MagicStack","finishResolving","(Lforge/game/spellability/SpellAbility;Z)V","invokevirtual",322);}
case 322:{f.Push(f.Locals[0]);f.Pc=323;continue;}
case 323:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/game/Game","copyLastState","()V","invokevirtual",329);}
case 329:{f.Push(f.Locals[0]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/zone/MagicStack","isEmpty","()Z","invokevirtual",333);}
case 333:{f.Pc=f.Pop().Int==0?350:336;continue;}
case 336:{f.Push(f.Locals[0]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/game/zone/MagicStack","hasSimultaneousStackEntries","()Z","invokevirtual",340);}
case 340:{f.Pc=f.Pop().Int!=0?350:343;continue;}
case 343:{f.Push(f.Locals[0]);f.Pc=344;continue;}
case 344:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/Game","clearChangeZoneLKIInfo","()V","invokevirtual",350);}
case 350:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11063(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/zone/MagicStack","getInstanceMatchingSpellAbilityID","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbilityStackInstance;","invokevirtual",5);}
case 5:{f.Locals[3]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/zone/MagicStack","removeCardFromStack","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbilityStackInstance;Z)V","invokevirtual",13);}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Reference==null?22:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/zone/MagicStack","remove","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/zone/MagicStack","unfreezeStack","()V","invokevirtual",26);}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","resetOnceResolved","()V","invokevirtual",30);}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(null));f.Pc=32;continue;}
case 32:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","curResolving","Lforge/game/spellability/SpellAbility;",value);f.Pc=35;continue;}
case 35:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11064(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/trigger/TriggerHandler","resetActiveTriggers","()V","invokevirtual",16);}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?24:23;continue;}
case 23:{return JStep.ReturnVoid;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/Card","isCopiedSpell","()Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?57:32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?57:43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",50);}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/GameAction","ceaseToExist","(Lforge/game/card/Card;Z)V","invokevirtual",56);}
case 56:{return JStep.ReturnVoid;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/card/Card","isInstant","()Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int!=0?77:65;continue;}
case 65:{f.Push(f.Locals[4]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/Card","isSorcery","()Z","invokevirtual",70);}
case 70:{f.Pc=f.Pop().Int!=0?77:73;continue;}
case 73:{f.Push(f.Locals[3]);f.Pc=74;continue;}
case 74:{f.Pc=f.Pop().Int==0?136:77;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int==0?136:88;continue;}
case 88:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",91);}
case 91:{f.Locals[5]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[5]);f.Pc=95;continue;}
case 95:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","StackSa","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","StackSa","Lforge/game/ability/AbilityKey;"));f.Pc=98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",104);}
case 104:{f.StackOp("pop");f.Pc=105;continue;}
case 105:{f.Push(f.Locals[5]);f.Pc=107;continue;}
case 107:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Fizzle","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Fizzle","Lforge/game/ability/AbilityKey;"));f.Pc=110;continue;}
case 110:{f.Push(f.Locals[3]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",114);}
case 114:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",119);}
case 119:{f.StackOp("pop");f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",127);}
case 127:{f.Push(f.Locals[4]);f.Pc=129;continue;}
case 129:{f.Push(JValue.R(null));f.Pc=130;continue;}
case 130:{f.Push(f.Locals[5]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/GameAction","moveToGraveyard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",135);}
case 135:{f.StackOp("pop");f.Pc=136;continue;}
case 136:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11065(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTargetNumberValid","()Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int!=0?15:13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/game/zone/MagicStack","hasLegalTargeting","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",23);}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11066(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?242:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","isZeroTargets","()Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?242:18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Reference!=null?27:22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/spellability/TargetChoices","iterator","()Ljava/util/Iterator;","invokevirtual",34);}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",43);}
case 43:{f.Pc=f.Pop().Int==0?242:46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",53);}
case 53:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=56;continue;}
case 56:{f.Locals[5]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(JValue.I(0));f.Pc=59;continue;}
case 59:{f.Locals[6]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Int==0?134:69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=74;continue;}
case 74:{f.Locals[7]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=80;continue;}
case 80:{f.Push(f.Locals[7]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",85);}
case 85:{f.Locals[8]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[8]);f.Pc=89;continue;}
case 89:{f.Pc=f.Pop().Reference==null?109:92;continue;}
case 92:{f.Push(f.Locals[8]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[7]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Int!=0?106:102;continue;}
case 102:{f.Push(JValue.I(1));f.Pc=103;continue;}
case 103:{f.Pc=107;continue;}
case 106:{f.Push(JValue.I(0));f.Pc=107;continue;}
case 107:{f.Locals[6]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[6]);f.Pc=111;continue;}
case 111:{f.Pc=f.Pop().Int!=0?124:114;continue;}
case 114:{f.Push(f.Locals[1]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[7]);f.Pc=117;continue;}
case 117:{f.Push(JValue.I(1));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","canTarget","(Lforge/game/GameObject;Z)Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int!=0?128:124;continue;}
case 124:{f.Push(JValue.I(1));f.Pc=125;continue;}
case 125:{f.Pc=129;continue;}
case 128:{f.Push(JValue.I(0));f.Pc=129;continue;}
case 129:{f.Locals[6]=f.Pop();f.Pc=131;continue;}
case 131:{f.Pc=202;continue;}
case 134:{f.Push(f.Locals[5]);f.Pc=136;continue;}
case 136:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/SpellAbility")?1:0));f.Pc=139;continue;}
case 139:{f.Pc=f.Pop().Int==0?185:142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[5]);f.Pc=145;continue;}
case 145:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/zone/MagicStack","getInstanceMatchingSpellAbilityID","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbilityStackInstance;","invokevirtual",151);}
case 151:{f.Locals[7]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[7]);f.Pc=155;continue;}
case 155:{f.Pc=f.Pop().Reference!=null?162:158;continue;}
case 158:{f.Push(JValue.I(1));f.Pc=159;continue;}
case 159:{f.Pc=180;continue;}
case 162:{f.Push(f.Locals[1]);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[7]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",168);}
case 168:{f.Push(JValue.I(1));f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/spellability/SpellAbility","canTarget","(Lforge/game/GameObject;Z)Z","invokevirtual",172);}
case 172:{f.Pc=f.Pop().Int!=0?179:175;continue;}
case 175:{f.Push(JValue.I(1));f.Pc=176;continue;}
case 176:{f.Pc=180;continue;}
case 179:{f.Push(JValue.I(0));f.Pc=180;continue;}
case 180:{f.Locals[6]=f.Pop();f.Pc=182;continue;}
case 182:{f.Pc=202;continue;}
case 185:{f.Push(f.Locals[1]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[5]);f.Pc=188;continue;}
case 188:{f.Push(JValue.I(1));f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/spellability/SpellAbility","canTarget","(Lforge/game/GameObject;Z)Z","invokevirtual",192);}
case 192:{f.Pc=f.Pop().Int!=0?199:195;continue;}
case 195:{f.Push(JValue.I(1));f.Pc=196;continue;}
case 196:{f.Pc=200;continue;}
case 199:{f.Push(JValue.I(0));f.Pc=200;continue;}
case 200:{f.Locals[6]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[6]);f.Pc=204;continue;}
case 204:{f.Pc=f.Pop().Int==0?219:207;continue;}
case 207:{f.Push(f.Locals[3]);f.Pc=208;continue;}
case 208:{f.Push(f.Locals[5]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",215);}
case 215:{f.StackOp("pop");f.Pc=216;continue;}
case 216:{f.Pc=224;continue;}
case 219:{f.Push(JValue.I(0));f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",223);}
case 223:{f.Locals[2]=f.Pop();f.Pc=224;continue;}
case 224:{f.Push(f.Locals[1]);f.Pc=225;continue;}
case 225:{f.Push(JValue.R(rt.String("CantFizzle")));f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",231);}
case 231:{f.Pc=f.Pop().Int==0?239:234;continue;}
case 234:{f.Push(JValue.I(0));f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",238);}
case 238:{f.Locals[2]=f.Pop();f.Pc=239;continue;}
case 239:{f.Pc=36;continue;}
case 242:{f.Push(f.Locals[1]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",246);}
case 246:{f.Pc=f.Pop().Reference==null?262:249;continue;}
case 249:{f.Push(f.Locals[0]);f.Pc=250;continue;}
case 250:{f.Push(f.Locals[1]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",254);}
case 254:{f.Push(f.Locals[2]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/zone/MagicStack","hasFizzled","(Lforge/game/spellability/SpellAbility;Ljava/lang/Boolean;)Z","invokevirtual",258);}
case 258:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",261);}
case 261:{f.Locals[2]=f.Pop();f.Pc=262;continue;}
case 262:{f.Push(f.Locals[1]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",266);}
case 266:{f.Pc=f.Pop().Int==0?285:269;continue;}
case 269:{f.Push(f.Locals[1]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/spellability/SpellAbility","isZeroTargets","()Z","invokevirtual",273);}
case 273:{f.Pc=f.Pop().Int!=0?285:276;continue;}
case 276:{f.Push(f.Locals[1]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",280);}
case 280:{f.Push(f.Locals[3]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/spellability/TargetChoices","removeAll","(Ljava/util/Collection;)Z","invokevirtual",284);}
case 284:{f.StackOp("pop");f.Pc=285;continue;}
case 285:{f.Push(f.Locals[2]);f.Pc=286;continue;}
case 286:{f.Pc=f.Pop().Reference==null?300:289;continue;}
case 289:{f.Push(f.Locals[2]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",293);}
case 293:{f.Pc=f.Pop().Int==0?300:296;continue;}
case 296:{f.Push(JValue.I(1));f.Pc=297;continue;}
case 297:{f.Pc=301;continue;}
case 300:{f.Push(JValue.I(0));f.Pc=301;continue;}
case 301:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11067(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Deque","peekFirst","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11068(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Deque","peekFirst","()Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11069(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Deque","remove","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/Game","updateStackForView","()V","invokevirtual",18);}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=22;continue;}
case 22:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventSpellRemovedFromStack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventSpellRemovedFromStack")));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",30);}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","get","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbilityView;","invokestatic",33);}
case 33:{return rt.Call(f,"forge/game/event/GameEventSpellRemovedFromStack","<init>","(Lforge/game/spellability/SpellAbilityView;)V","invokespecial",36);}
case 36:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",39);}
case 39:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11070(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Deque","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?55:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSourceCard","()Lforge/game/card/Card;","invokevirtual",34);}
case 34:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?52:40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","isSpell","()Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int==0?52:47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/zone/MagicStack","remove","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",52);}
case 52:{f.Pc=10;continue;}
case 55:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11071(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Deque","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?48:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",33);}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?45:40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/zone/MagicStack","remove","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",45);}
case 45:{f.Pc=10;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","simultaneousStackEntryList","Ljava/util/List;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",55);}
case 55:{return rt.Call(f,"java/util/ArrayList","iterator","()Ljava/util/Iterator;","invokevirtual",58);}
case 58:{f.Locals[2]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int==0?140:68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",74);}
case 74:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=77;continue;}
case 77:{f.Locals[3]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",82);}
case 82:{f.Locals[4]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[4]);f.Pc=86;continue;}
case 86:{f.Pc=f.Pop().Reference!=null?117:89;continue;}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",93);}
case 93:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",96);}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int==0?137:103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","simultaneousStackEntryList","Ljava/util/List;"));f.Pc=107;continue;}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",113);}
case 113:{f.StackOp("pop");f.Pc=114;continue;}
case 114:{f.Pc=137;continue;}
case 117:{f.Push(f.Locals[4]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",123);}
case 123:{f.Pc=f.Pop().Int==0?137:126;continue;}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","simultaneousStackEntryList","Ljava/util/List;"));f.Pc=130;continue;}
case 130:{f.Push(f.Locals[3]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",136);}
case 136:{f.StackOp("pop");f.Pc=137;continue;}
case 137:{f.Pc=59;continue;}
case 140:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11072(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Deque","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?48:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","getId","()I","invokevirtual",33);}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",37);}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","getId","()I","invokevirtual",40);}
case 40:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?45:43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return JStep.Return(f.Pop());}
case 45:{f.Pc=10;continue;}
case 48:{f.Push(JValue.R(null));f.Pc=49;continue;}
case 49:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11073(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Deque","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?58:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","isSpell","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?55:36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?55:50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",54);}
case 54:{return JStep.Return(f.Pop());}
case 55:{f.Pc=10;continue;}
case 58:{f.Push(JValue.R(null));f.Pc=59;continue;}
case 59:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11074(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","simultaneousStackEntryList","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int!=0?16:12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Pc=17;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11075(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","simultaneousStackEntryList","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11076(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","simultaneousStackEntryList","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11077(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/zone/MagicStack","hasSimultaneousStackEntries","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",19);}
case 19:{f.Locals[1]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Reference!=null?26:24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/Game","getPlayersInTurnOrder","(Lforge/game/player/Player;)Lforge/game/player/PlayerCollection;","invokevirtual",34);}
case 34:{f.Locals[2]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",43);}
case 43:{f.Locals[4]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",52);}
case 52:{f.Pc=f.Pop().Int==0?80:55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",62);}
case 62:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=65;continue;}
case 65:{f.Locals[5]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[3]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/zone/MagicStack","chooseOrderOfSimultaneousStackEntry","(Lforge/game/player/Player;Z)Z","invokevirtual",75);}
case 75:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=76;continue;}
case 76:{f.Locals[3]=f.Pop();f.Pc=77;continue;}
case 77:{f.Pc=45;continue;}
case 80:{f.Push(f.Locals[2]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",86);}
case 86:{f.Locals[4]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[4]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",95);}
case 95:{f.Pc=f.Pop().Int==0?123:98;continue;}
case 98:{f.Push(f.Locals[4]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",105);}
case 105:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=108;continue;}
case 108:{f.Locals[5]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[3]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[5]);f.Pc=114;continue;}
case 114:{f.Push(JValue.I(1));f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/zone/MagicStack","chooseOrderOfSimultaneousStackEntry","(Lforge/game/player/Player;Z)Z","invokevirtual",118);}
case 118:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=119;continue;}
case 119:{f.Locals[3]=f.Pop();f.Pc=120;continue;}
case 120:{f.Pc=88;continue;}
case 123:{f.Push(f.Locals[3]);f.Pc=124;continue;}
case 124:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11078(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/zone/MagicStack","hasSimultaneousStackEntries","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int!=0?18:16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","activePlayerSAs","Ljava/util/List;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",27);}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","simultaneousStackEntryList","Ljava/util/List;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",36);}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",43);}
case 43:{f.Pc=f.Pop().Int==0?143:46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Locals[4]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?84:66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",71);}
case 71:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",74);}
case 74:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AbilityTriggered","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AbilityTriggered","Lforge/game/trigger/TriggerType;"));f.Pc=77;continue;}
case 77:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?84:80;continue;}
case 80:{f.Push(JValue.I(1));f.Pc=81;continue;}
case 81:{f.Pc=85;continue;}
case 84:{f.Push(JValue.I(0));f.Pc=85;continue;}
case 85:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?91:88;continue;}
case 88:{f.Pc=37;continue;}
case 91:{f.Push(f.Locals[4]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",96);}
case 96:{f.Locals[5]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[5]);f.Pc=100;continue;}
case 100:{f.Pc=f.Pop().Reference!=null?113:103;continue;}
case 103:{f.Push(f.Locals[4]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",108);}
case 108:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",111);}
case 111:{f.Locals[5]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[5]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/player/Player","sharesTeamWith","(Lforge/game/player/Player;)Z","invokevirtual",119);}
case 119:{f.Pc=f.Pop().Int==0?140:122;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[4]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/zone/MagicStack","adjustAuraHost","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",128);}
case 128:{f.Push(f.Locals[0]);f.Pc=129;continue;}
case 129:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","activePlayerSAs","Ljava/util/List;"));f.Pc=132;continue;}
case 132:{f.Push(f.Locals[4]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",139);}
case 139:{f.StackOp("pop");f.Pc=140;continue;}
case 140:{f.Pc=37;continue;}
case 143:{f.Push(f.Locals[0]);f.Pc=144;continue;}
case 144:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","simultaneousStackEntryList","Ljava/util/List;"));f.Pc=147;continue;}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","activePlayerSAs","Ljava/util/List;"));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/util/List","removeAll","(Ljava/util/Collection;)Z","invokeinterface",156);}
case 156:{f.StackOp("pop");f.Pc=157;continue;}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","activePlayerSAs","Ljava/util/List;"));f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",166);}
case 166:{f.Pc=f.Pop().Int==0?171:169;continue;}
case 169:{f.Push(JValue.I(0));f.Pc=170;continue;}
case 170:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 171:{f.Push(f.Locals[1]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",175);}
case 175:{f.Push(f.Locals[0]);f.Pc=176;continue;}
case 176:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","activePlayerSAs","Ljava/util/List;"));f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/player/PlayerController","orderAndPlaySimultaneousSa","(Ljava/util/List;)V","invokevirtual",182);}
case 182:{f.Push(f.Locals[0]);f.Pc=183;continue;}
case 183:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","activePlayerSAs","Ljava/util/List;"));f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",191);}
case 191:{f.Push(JValue.I(1));f.Pc=192;continue;}
case 192:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11079(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/Card","isAura","()Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?96:27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?96:38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",42);}
case 42:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"));f.Pc=45;continue;}
case 45:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?96:48;continue;}
case 48:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("Origin")));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",58);}
case 58:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int==0?96:64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",71);}
case 71:{f.Pc=f.Pop().Int==0?96:74;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",81);}
case 81:{f.Push(JValue.R(rt.String("Card.EnchantedBy")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int==0?96:90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[4]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/spellability/SpellAbility","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",96);}
case 96:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11080(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Deque","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?42:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","isStateTrigger","(I)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?39:37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 39:{f.Pc=10;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","simultaneousStackEntryList","Ljava/util/List;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",51);}
case 51:{f.Locals[2]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",58);}
case 58:{f.Pc=f.Pop().Int==0?84:61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",67);}
case 67:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=70;continue;}
case 70:{f.Locals[3]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSourceTrigger","()I","invokevirtual",75);}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?81:79;continue;}
case 79:{f.Push(JValue.I(1));f.Pc=80;continue;}
case 80:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 81:{f.Pc=52;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","activePlayerSAs","Ljava/util/List;"));f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",93);}
case 93:{f.Locals[2]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",100);}
case 100:{f.Pc=f.Pop().Int==0?126:103;continue;}
case 103:{f.Push(f.Locals[2]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",109);}
case 109:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=112;continue;}
case 112:{f.Locals[3]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[3]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSourceTrigger","()I","invokevirtual",117);}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?123:121;continue;}
case 121:{f.Push(JValue.I(1));f.Pc=122;continue;}
case 122:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 123:{f.Pc=94;continue;}
case 126:{f.Push(JValue.I(0));f.Pc=127;continue;}
case 127:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11081(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","thisTurnCast","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11082(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","thisTurnCast","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",9);}
case 9:{return rt.DynamicCall(f,"forge/game/zone/MagicStack:11082:9:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",14);}
case 14:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",19);}
case 19:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",22);}
case 22:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11083(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","lastTurnCast","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11084(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Game","getStackZone","()Lforge/game/zone/Zone;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/zone/Zone","resetCardsAddedThisTurn","()V","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","thisTurnActivated","Ljava/util/List;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","illegalAdditions","Ljava/util/Map;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",28);}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",35);}
case 35:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",38);}
case 38:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",41);}
case 41:{f.Locals[1]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",48);}
case 48:{f.Pc=f.Pop().Int==0?68:51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",57);}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{f.Locals[2]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/player/Player","resetSpellCastSinceBegOfYourLastTurn","()V","invokevirtual",65);}
case 65:{f.Pc=42;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","thisTurnCast","Ljava/util/List;"));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",77);}
case 77:{f.Pc=f.Pop().Int==0?88:80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",84);}
case 84:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","lastTurnCast","Ljava/util/List;",value);f.Pc=87;continue;}
case 87:{return JStep.ReturnVoid;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/zone/MagicStack","getSpellCardsCastThisTurn","()Ljava/util/List;","invokevirtual",92);}
case 92:{f.Locals[1]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",100);}
case 100:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",103);}
case 103:{f.Locals[2]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[2]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",110);}
case 110:{f.Pc=f.Pop().Int==0?131:113;continue;}
case 113:{f.Push(f.Locals[2]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",119);}
case 119:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=122;continue;}
case 122:{f.Locals[3]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[3]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/player/Player","addSpellCastSinceBegOfYourLastTurn","(Ljava/util/List;)V","invokevirtual",128);}
case 128:{f.Pc=104;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[1]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",136);}
case 136:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/MagicStack","lastTurnCast","Ljava/util/List;",value);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","thisTurnCast","Ljava/util/List;"));f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",148);}
case 148:{f.Push(f.Locals[0]);f.Pc=149;continue;}
case 149:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/Game","updateStackForView","()V","invokevirtual",155);}
case 155:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11085(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/Card","addAbilityActivated","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","thisTurnActivated","Ljava/util/List;"));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",19);}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",23);}
case 23:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11086(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","thisTurnActivated","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11087(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Deque","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?79:25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","isTrigger","()Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?76:44;continue;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSourceCard","()Lforge/game/card/Card;","invokevirtual",49);}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int==0?76:56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{f.Pc=f.Pop().Reference==null?74:60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[4]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",66);}
case 66:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",71);}
case 71:{f.Pc=f.Pop().Int==0?76:74;continue;}
case 74:{f.Push(JValue.I(1));f.Pc=75;continue;}
case 75:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 76:{f.Pc=16;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","simultaneousStackEntryList","Ljava/util/List;"));f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",88);}
case 88:{f.Locals[3]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",95);}
case 95:{f.Pc=f.Pop().Int==0?149:98;continue;}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",104);}
case 104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=107;continue;}
case 107:{f.Locals[4]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[4]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?146:117;continue;}
case 117:{f.Push(f.Locals[4]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",122);}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int==0?146:129;continue;}
case 129:{f.Push(f.Locals[2]);f.Pc=130;continue;}
case 130:{f.Pc=f.Pop().Reference==null?144:133;continue;}
case 133:{f.Push(f.Locals[2]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[4]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",141);}
case 141:{f.Pc=f.Pop().Int==0?146:144;continue;}
case 144:{f.Push(JValue.I(1));f.Pc=145;continue;}
case 145:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 146:{f.Pc=89;continue;}
case 149:{f.Push(JValue.I(0));f.Pc=150;continue;}
case 150:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11088(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Deque","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11089(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Deque","descendingIterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11090(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Deque","isEmpty","()Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int==0?13:12;continue;}
case 12:{return JStep.ReturnVoid;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Deque","clear","()V","invokeinterface",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/Game","updateStackForView","()V","invokevirtual",29);}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","game","Lforge/game/Game;"));f.Pc=33;continue;}
case 33:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventSpellRemovedFromStack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventSpellRemovedFromStack")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(JValue.R(null));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/event/GameEventSpellRemovedFromStack","<init>","(Lforge/game/spellability/SpellAbilityView;)V","invokespecial",41);}
case 41:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",44);}
case 44:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11091(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(3));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","simultaneousStackEntryList","Ljava/util/List;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",13);}
case 13:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("==")));f.Pc=19;continue;}
case 19:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(JValue.I(2));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/MagicStack","stack","Ljava/util/Deque;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",29);}
case 29:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",33);}
case 33:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11092(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=3;continue;}
case 3:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;","invokestatic",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",19);}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?171:29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/TargetChoices"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetPlayers","()Ljava/lang/Iterable;","invokevirtual",45);}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/player/PlayerPredicates","isOpponentOf","(Lforge/game/player/Player;)Ljava/util/function/Predicate;","invokestatic",49);}
case 49:{return rt.Call(f,"forge/util/IterableUtil","any","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Z","invokestatic",52);}
case 52:{f.Pc=f.Pop().Int==0?57:55;continue;}
case 55:{f.Push(JValue.I(1));f.Pc=56;continue;}
case 56:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetSpells","()Ljava/lang/Iterable;","invokevirtual",62);}
case 62:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",67);}
case 67:{f.Locals[5]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",76);}
case 76:{f.Pc=f.Pop().Int==0?108:79;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",86);}
case 86:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=89;continue;}
case 89:{f.Locals[6]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[6]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",96);}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/player/Player","isOpponentOf","(Lforge/game/player/Player;)Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int==0?105:103;continue;}
case 103:{f.Push(JValue.I(1));f.Pc=104;continue;}
case 104:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 105:{f.Pc=69;continue;}
case 108:{f.Push(f.Locals[4]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",113);}
case 113:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",118);}
case 118:{f.Locals[5]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[5]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",127);}
case 127:{f.Pc=f.Pop().Int==0?168:130;continue;}
case 130:{f.Push(f.Locals[5]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",137);}
case 137:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=140;continue;}
case 140:{f.Locals[6]=f.Pop();f.Pc=142;continue;}
case 142:{f.Push(f.Locals[6]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[2]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/card/Card","isInZones","(Ljava/util/List;)Z","invokevirtual",148);}
case 148:{f.Pc=f.Pop().Int==0?165:151;continue;}
case 151:{f.Push(f.Locals[6]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",156);}
case 156:{f.Push(f.Locals[0]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/player/Player","isOpponentOf","(Lforge/game/player/Player;)Z","invokevirtual",160);}
case 160:{f.Pc=f.Pop().Int==0?165:163;continue;}
case 163:{f.Push(JValue.I(1));f.Pc=164;continue;}
case 164:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 165:{f.Pc=120;continue;}
case 168:{f.Pc=20;continue;}
case 171:{f.Push(JValue.I(0));f.Pc=172;continue;}
case 172:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
