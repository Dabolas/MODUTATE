// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1024{
internal static JClass Build(){var c=new JClass("forge/game/trigger/WrappedAbility","forge/game/spellability/Ability",new string[]{},33);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("sa","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JField("decider","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JMethod(10800,"forge/game/trigger/WrappedAbility","<init>","(Lforge/game/trigger/Trigger;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)V",1,4,3,new JHandler[]{},M10800));
c.Add(new JMethod(10801,"forge/game/trigger/WrappedAbility","getWrappedAbility","()Lforge/game/spellability/SpellAbility;",1,1,1,new JHandler[]{},M10801));
c.Add(new JMethod(10802,"forge/game/trigger/WrappedAbility","isWrapper","()Z",1,1,1,new JHandler[]{},M10802));
c.Add(new JMethod(10803,"forge/game/trigger/WrappedAbility","getDecider","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M10803));
c.Add(new JMethod(10804,"forge/game/trigger/WrappedAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;",1,2,2,new JHandler[]{},M10804));
c.Add(new JMethod(10805,"forge/game/trigger/WrappedAbility","hasParam","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M10805));
c.Add(new JMethod(10806,"forge/game/trigger/WrappedAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1,3,3,new JHandler[]{},M10806));
c.Add(new JMethod(10807,"forge/game/trigger/WrappedAbility","getApi","()Lforge/game/ability/ApiType;",1,1,1,new JHandler[]{},M10807));
c.Add(new JMethod(10808,"forge/game/trigger/WrappedAbility","setPaidHash","(Lcom/google/common/collect/TreeBasedTable;)V",1,2,2,new JHandler[]{},M10808));
c.Add(new JMethod(10809,"forge/game/trigger/WrappedAbility","getPaidHash","()Lcom/google/common/collect/TreeBasedTable;",1,1,1,new JHandler[]{},M10809));
c.Add(new JMethod(10810,"forge/game/trigger/WrappedAbility","getPaidList","(Ljava/lang/String;Z)Lforge/game/card/CardCollection;",1,3,3,new JHandler[]{},M10810));
c.Add(new JMethod(10811,"forge/game/trigger/WrappedAbility","addCostToHashList","(Lforge/game/card/Card;Ljava/lang/String;Z)V",1,4,4,new JHandler[]{},M10811));
c.Add(new JMethod(10812,"forge/game/trigger/WrappedAbility","resetPaidHash","()V",1,1,1,new JHandler[]{},M10812));
c.Add(new JMethod(10813,"forge/game/trigger/WrappedAbility","getTriggeringObjects","()Ljava/util/Map;",1,1,1,new JHandler[]{},M10813));
c.Add(new JMethod(10814,"forge/game/trigger/WrappedAbility","setTriggeringObjects","(Ljava/util/Map;)V",1,2,2,new JHandler[]{},M10814));
c.Add(new JMethod(10815,"forge/game/trigger/WrappedAbility","setTriggeringObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V",1,3,3,new JHandler[]{},M10815));
c.Add(new JMethod(10816,"forge/game/trigger/WrappedAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M10816));
c.Add(new JMethod(10817,"forge/game/trigger/WrappedAbility","hasTriggeringObject","(Lforge/game/ability/AbilityKey;)Z",1,2,2,new JHandler[]{},M10817));
c.Add(new JMethod(10818,"forge/game/trigger/WrappedAbility","resetTriggeringObjects","()V",1,1,1,new JHandler[]{},M10818));
c.Add(new JMethod(10819,"forge/game/trigger/WrappedAbility","canPlay","()Z",1,1,1,new JHandler[]{},M10819));
c.Add(new JMethod(10820,"forge/game/trigger/WrappedAbility","copy","()Lforge/game/spellability/SpellAbility;",1,1,1,new JHandler[]{},M10820));
c.Add(new JMethod(10821,"forge/game/trigger/WrappedAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;",1,1,1,new JHandler[]{},M10821));
c.Add(new JMethod(10822,"forge/game/trigger/WrappedAbility","getSATargetingCard","()Lforge/game/spellability/SpellAbility;",1,1,1,new JHandler[]{},M10822));
c.Add(new JMethod(10823,"forge/game/trigger/WrappedAbility","yieldKey","()Ljava/lang/String;",1,1,2,new JHandler[]{},M10823));
c.Add(new JMethod(10824,"forge/game/trigger/WrappedAbility","toUnsuppressedString","()Ljava/lang/String;",1,3,2,new JHandler[]{},M10824));
c.Add(new JMethod(10825,"forge/game/trigger/WrappedAbility","getStackDescription","()Ljava/lang/String;",1,1,2,new JHandler[]{},M10825));
c.Add(new JMethod(10826,"forge/game/trigger/WrappedAbility","getStackDescription","(Z)Ljava/lang/String;",1,5,6,new JHandler[]{},M10826));
c.Add(new JMethod(10827,"forge/game/trigger/WrappedAbility","setStackDescription","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M10827));
c.Add(new JMethod(10828,"forge/game/trigger/WrappedAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;",1,1,1,new JHandler[]{},M10828));
c.Add(new JMethod(10829,"forge/game/trigger/WrappedAbility","setTargetRestrictions","(Lforge/game/spellability/TargetRestrictions;)V",1,2,2,new JHandler[]{},M10829));
c.Add(new JMethod(10830,"forge/game/trigger/WrappedAbility","getTargetCard","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M10830));
c.Add(new JMethod(10831,"forge/game/trigger/WrappedAbility","getTargets","()Lforge/game/spellability/TargetChoices;",1,1,1,new JHandler[]{},M10831));
c.Add(new JMethod(10832,"forge/game/trigger/WrappedAbility","setTargets","(Lforge/game/spellability/TargetChoices;)V",1,2,2,new JHandler[]{},M10832));
c.Add(new JMethod(10833,"forge/game/trigger/WrappedAbility","isAbility","()Z",1,1,1,new JHandler[]{},M10833));
c.Add(new JMethod(10834,"forge/game/trigger/WrappedAbility","isBuyback","()Z",1,1,1,new JHandler[]{},M10834));
c.Add(new JMethod(10835,"forge/game/trigger/WrappedAbility","isCycling","()Z",1,1,1,new JHandler[]{},M10835));
c.Add(new JMethod(10836,"forge/game/trigger/WrappedAbility","isChapter","()Z",1,1,1,new JHandler[]{},M10836));
c.Add(new JMethod(10837,"forge/game/trigger/WrappedAbility","getChapter","()Ljava/lang/Integer;",1,1,1,new JHandler[]{},M10837));
c.Add(new JMethod(10838,"forge/game/trigger/WrappedAbility","isFlashback","()Z",1,1,1,new JHandler[]{},M10838));
c.Add(new JMethod(10839,"forge/game/trigger/WrappedAbility","isSpell","()Z",1,1,1,new JHandler[]{},M10839));
c.Add(new JMethod(10840,"forge/game/trigger/WrappedAbility","hasSVar","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M10840));
c.Add(new JMethod(10841,"forge/game/trigger/WrappedAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;",1,2,2,new JHandler[]{},M10841));
c.Add(new JMethod(10842,"forge/game/trigger/WrappedAbility","getSVarInt","(Ljava/lang/String;)Ljava/lang/Integer;",1,2,2,new JHandler[]{},M10842));
c.Add(new JMethod(10843,"forge/game/trigger/WrappedAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V",1,3,3,new JHandler[]{},M10843));
c.Add(new JMethod(10844,"forge/game/trigger/WrappedAbility","getSVars","()Ljava/util/Map;",1,1,1,new JHandler[]{},M10844));
c.Add(new JMethod(10845,"forge/game/trigger/WrappedAbility","resetOnceResolved","()V",1,1,0,new JHandler[]{},M10845));
c.Add(new JMethod(10846,"forge/game/trigger/WrappedAbility","getActivatingPlayer","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M10846));
c.Add(new JMethod(10847,"forge/game/trigger/WrappedAbility","setActivatingPlayer","(Lforge/game/player/Player;)V",1,2,2,new JHandler[]{},M10847));
c.Add(new JMethod(10848,"forge/game/trigger/WrappedAbility","getDescription","()Ljava/lang/String;",1,1,1,new JHandler[]{},M10848));
c.Add(new JMethod(10849,"forge/game/trigger/WrappedAbility","setDescription","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M10849));
c.Add(new JMethod(10850,"forge/game/trigger/WrappedAbility","setPayCosts","(Lforge/game/cost/Cost;)V",1,2,2,new JHandler[]{},M10850));
c.Add(new JMethod(10851,"forge/game/trigger/WrappedAbility","setRestrictions","(Lforge/game/spellability/SpellAbilityRestriction;)V",1,2,2,new JHandler[]{},M10851));
c.Add(new JMethod(10852,"forge/game/trigger/WrappedAbility","setHostCard","(Lforge/game/card/Card;)V",1,2,2,new JHandler[]{},M10852));
c.Add(new JMethod(10853,"forge/game/trigger/WrappedAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;",1,1,1,new JHandler[]{},M10853));
c.Add(new JMethod(10854,"forge/game/trigger/WrappedAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V",1,2,2,new JHandler[]{},M10854));
c.Add(new JMethod(10855,"forge/game/trigger/WrappedAbility","setTargetCard","(Lforge/game/card/Card;)V",1,2,2,new JHandler[]{},M10855));
c.Add(new JMethod(10856,"forge/game/trigger/WrappedAbility","getSourceTrigger","()I",1,1,1,new JHandler[]{},M10856));
c.Add(new JMethod(10857,"forge/game/trigger/WrappedAbility","setOptionalTrigger","(Z)V",1,2,2,new JHandler[]{},M10857));
c.Add(new JMethod(10858,"forge/game/trigger/WrappedAbility","isOptionalTrigger","()Z",1,1,1,new JHandler[]{},M10858));
c.Add(new JMethod(10859,"forge/game/trigger/WrappedAbility","usesTargeting","()Z",1,1,1,new JHandler[]{},M10859));
c.Add(new JMethod(10860,"forge/game/trigger/WrappedAbility","hasAdditionalAbility","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M10860));
c.Add(new JMethod(10861,"forge/game/trigger/WrappedAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;",1,2,2,new JHandler[]{},M10861));
}

private static void Add1(JClass c){
c.Add(new JMethod(10862,"forge/game/trigger/WrappedAbility","getAdditionalAbilityLists","()Ljava/util/Map;",1,1,1,new JHandler[]{},M10862));
c.Add(new JMethod(10863,"forge/game/trigger/WrappedAbility","getAdditionalAbilityList","(Ljava/lang/String;)Ljava/util/List;",1,2,2,new JHandler[]{},M10863));
c.Add(new JMethod(10864,"forge/game/trigger/WrappedAbility","setAdditionalAbilityList","(Ljava/lang/String;Ljava/util/List;)V",1,3,3,new JHandler[]{},M10864));
c.Add(new JMethod(10865,"forge/game/trigger/WrappedAbility","resetTargets","()V",1,1,1,new JHandler[]{},M10865));
c.Add(new JMethod(10866,"forge/game/trigger/WrappedAbility","resolve","()V",1,5,5,new JHandler[]{},M10866));
c.Add(new JMethod(10867,"forge/game/trigger/WrappedAbility","getDamageMap","()Lforge/game/card/CardDamageTable;",1,1,1,new JHandler[]{},M10867));
c.Add(new JMethod(10868,"forge/game/trigger/WrappedAbility","getPreventMap","()Lforge/game/card/CardDamageTable;",1,1,1,new JHandler[]{},M10868));
c.Add(new JMethod(10869,"forge/game/trigger/WrappedAbility","getCounterTable","()Lforge/game/GameEntityCounterTable;",1,1,1,new JHandler[]{},M10869));
c.Add(new JMethod(10870,"forge/game/trigger/WrappedAbility","getChangeZoneTable","()Lforge/game/card/CardZoneTable;",1,1,1,new JHandler[]{},M10870));
c.Add(new JMethod(10871,"forge/game/trigger/WrappedAbility","setDamageMap","(Lforge/game/card/CardDamageTable;)V",1,2,2,new JHandler[]{},M10871));
c.Add(new JMethod(10872,"forge/game/trigger/WrappedAbility","setPreventMap","(Lforge/game/card/CardDamageTable;)V",1,2,2,new JHandler[]{},M10872));
c.Add(new JMethod(10873,"forge/game/trigger/WrappedAbility","setCounterTable","(Lforge/game/GameEntityCounterTable;)V",1,2,2,new JHandler[]{},M10873));
c.Add(new JMethod(10874,"forge/game/trigger/WrappedAbility","setChangeZoneTable","(Lforge/game/card/CardZoneTable;)V",1,2,2,new JHandler[]{},M10874));
c.Add(new JMethod(10875,"forge/game/trigger/WrappedAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z",1,2,2,new JHandler[]{},M10875));
c.Add(new JMethod(10876,"forge/game/trigger/WrappedAbility","getAlternativeCost","()Lforge/game/spellability/AlternativeCost;",1,1,1,new JHandler[]{},M10876));
c.Add(new JMethod(10877,"forge/game/trigger/WrappedAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V",1,2,2,new JHandler[]{},M10877));
c.Add(new JMethod(10878,"forge/game/trigger/WrappedAbility","getXManaCostPaid","()Ljava/lang/Integer;",1,1,1,new JHandler[]{},M10878));
c.Add(new JMethod(10879,"forge/game/trigger/WrappedAbility","setXManaCostPaid","(Ljava/lang/Integer;)V",1,2,2,new JHandler[]{},M10879));
c.Add(new JMethod(10880,"forge/game/trigger/WrappedAbility","getCardState","()Lforge/game/card/CardState;",1,1,1,new JHandler[]{},M10880));
c.Add(new JMethod(10881,"forge/game/trigger/WrappedAbility","setCardState","(Lforge/game/card/CardState;)V",1,2,2,new JHandler[]{},M10881));
c.Add(new JMethod(10882,"forge/game/trigger/WrappedAbility","getChosenList","()Ljava/util/List;",1,1,1,new JHandler[]{},M10882));
c.Add(new JMethod(10883,"forge/game/trigger/WrappedAbility","setChosenList","(Ljava/util/List;)V",1,2,2,new JHandler[]{},M10883));
c.Add(new JMethod(10884,"forge/game/trigger/WrappedAbility","isIntrinsic","()Z",1,1,1,new JHandler[]{},M10884));
c.Add(new JMethod(10885,"forge/game/trigger/WrappedAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z",1,2,2,new JHandler[]{},M10885));
c.Add(new JMethod(10886,"forge/game/trigger/WrappedAbility","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M10886));
c.Add(new JMethod(10887,"forge/game/trigger/WrappedAbility","lambda$resolve$0","(Lforge/game/trigger/Trigger;Lforge/game/Game;)Z",4098,3,3,new JHandler[]{},M10887));
}

internal static JStep M10800(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",5);}
case 5:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/Ability","<init>","(Lforge/game/card/Card;Lforge/card/mana/ManaCost;)V","invokespecial",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/trigger/WrappedAbility","setTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","setTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",29);}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/WrappedAbility","decider","Lforge/game/player/Player;",value);f.Pc=34;continue;}
case 34:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10801(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10802(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10803(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","decider","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10804(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10805(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10806(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10807(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10808(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPaidHash","(Lcom/google/common/collect/TreeBasedTable;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10809(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPaidHash","()Lcom/google/common/collect/TreeBasedTable;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10810(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPaidList","(Ljava/lang/String;Z)Lforge/game/card/CardCollection;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10811(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","addCostToHashList","(Lforge/game/card/Card;Ljava/lang/String;Z)V","invokevirtual",10);}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10812(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","resetPaidHash","()V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10813(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObjects","()Ljava/util/Map;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10814(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setTriggeringObjects","(Ljava/util/Map;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10815(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","setTriggeringObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10816(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10817(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasTriggeringObject","(Lforge/game/ability/AbilityKey;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10818(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","resetTriggeringObjects","()V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10819(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","canPlay","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10820(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","()Lforge/game/spellability/SpellAbility;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10821(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10822(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSATargetingCard","()Lforge/game/spellability/SpellAbility;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10823(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?42:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Reference==null?34:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",25);}
case 25:{return rt.Call(f,"forge/game/trigger/Trigger","toString","()Ljava/lang/String;","invokevirtual",28);}
case 28:{return rt.DynamicCall(f,"forge/game/trigger/WrappedAbility:10823:28:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",33);}
case 33:{return JStep.Return(f.Pop());}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",38);}
case 38:{return rt.Call(f,"forge/game/trigger/Trigger","toString","()Ljava/lang/String;","invokevirtual",41);}
case 41:{return JStep.Return(f.Pop());}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/Ability","yieldKey","()Ljava/lang/String;","invokespecial",46);}
case 46:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10824(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getStackDescription","(Z)Ljava/lang/String;","invokevirtual",5);}
case 5:{f.Locals[1]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int!=0?39:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String(" this ")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?39:31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.DynamicCall(f,"forge/game/trigger/WrappedAbility:10824:33:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",38);}
case 38:{return JStep.Return(f.Pop());}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10825(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getStackDescription","(Z)Ljava/lang/String;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10826(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?12:9;continue;}
case 9:{f.Push(JValue.R(rt.String("")));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/trigger/Trigger","toString","(Z)Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/trigger/Trigger","replaceAbilityText","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Z)Ljava/lang/String;","invokevirtual",27);}
case 27:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",30);}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/trigger/Trigger","getTriggerRemembered","()Ljava/util/List;","invokevirtual",35);}
case 35:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Int!=0?62:43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String(" (")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",49);}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/trigger/Trigger","getTriggerRemembered","()Ljava/util/List;","invokevirtual",53);}
case 53:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",56);}
case 56:{f.Push(JValue.R(rt.String(")")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{f.Pc=f.Pop().Int==0?122:66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAllTargetChoices","()Ljava/util/List;","invokevirtual",73);}
case 73:{f.Locals[4]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",82);}
case 82:{f.Pc=f.Pop().Int!=0?122:85;continue;}
case 85:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"));f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",95);}
case 95:{return rt.Call(f,"forge/game/ability/ApiType","equals","(Ljava/lang/Object;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int!=0?122:101;continue;}
case 101:{f.Push(f.Locals[3]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String(" (Targeting: ")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",107);}
case 107:{f.StackOp("pop");f.Pc=108;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[4]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",114);}
case 114:{f.StackOp("pop");f.Pc=115;continue;}
case 115:{f.Push(f.Locals[3]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String(")")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",121);}
case 121:{f.StackOp("pop");f.Pc=122;continue;}
case 122:{f.Push(f.Locals[2]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/trigger/Trigger","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",127);}
case 127:{f.Locals[4]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[4]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",134);}
case 134:{f.Pc=f.Pop().Int!=0?158:137;continue;}
case 137:{f.Push(f.Locals[3]);f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String(" [")));f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",143);}
case 143:{f.StackOp("pop");f.Pc=144;continue;}
case 144:{f.Push(f.Locals[3]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[4]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",150);}
case 150:{f.StackOp("pop");f.Pc=151;continue;}
case 151:{f.Push(f.Locals[3]);f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String("]")));f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",157);}
case 157:{f.StackOp("pop");f.Pc=158;continue;}
case 158:{f.Push(f.Locals[3]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",162);}
case 162:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10827(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setStackDescription","(Ljava/lang/String;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10828(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10829(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setTargetRestrictions","(Lforge/game/spellability/TargetRestrictions;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10830(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetCard","()Lforge/game/card/Card;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10831(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10832(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setTargets","(Lforge/game/spellability/TargetChoices;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10833(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10834(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isBuyback","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10835(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCycling","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10836(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isChapter","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10837(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getChapter","()Ljava/lang/Integer;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10838(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isFlashback","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10839(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10840(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasSVar","(Ljava/lang/String;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10841(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10842(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVarInt","(Ljava/lang/String;)Ljava/lang/Integer;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10843(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10844(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVars","()Ljava/util/Map;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10845(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10846(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10847(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10848(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10849(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10850(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPayCosts","(Lforge/game/cost/Cost;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10851(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setRestrictions","(Lforge/game/spellability/SpellAbilityRestriction;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10852(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10853(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10854(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10855(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setTargetCard","(Lforge/game/card/Card;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10856(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSourceTrigger","()I","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10857(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setOptionalTrigger","(Z)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10858(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOptionalTrigger","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10859(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10860(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasAdditionalAbility","(Ljava/lang/String;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10861(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10862(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbilityLists","()Ljava/util/Map;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10863(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbilityList","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10864(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAdditionalAbilityList","(Ljava/lang/String;Ljava/util/List;)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10865(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","resetTargets","()V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10866(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Always","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Always","Lforge/game/trigger/TriggerType;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?53:26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("NoResolvingCheck")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int!=0?53:36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.DynamicCall(f,"forge/game/trigger/WrappedAbility:10866:41:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/trigger/WrappedAbility;Lforge/game/trigger/Trigger;Lforge/game/Game;)Ljava/util/function/BooleanSupplier;",46);}
case 46:{return rt.Call(f,"forge/game/trigger/Trigger","checkWith","(Lforge/game/spellability/SpellAbility;Ljava/util/function/BooleanSupplier;)Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int!=0?53:52;continue;}
case 52:{return JStep.ReturnVoid;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",58);}
case 58:{return rt.Call(f,"forge/game/trigger/Trigger","checkResolvedLimit","(Lforge/game/player/Player;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int!=0?65:64;continue;}
case 64:{return JStep.ReturnVoid;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("ResolvingCheck")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?112:75;continue;}
case 75:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",78);}
case 78:{f.Locals[3]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("ResolvingCheck")));f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",86);}
case 86:{f.Locals[4]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[3]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[4]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",97);}
case 97:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",102);}
case 102:{f.StackOp("pop");f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[3]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/trigger/WrappedAbility","meetsCommonRequirements","(Ljava/util/Map;)Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int!=0?112:111;continue;}
case 111:{return JStep.ReturnVoid;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","decider","Lforge/game/player/Player;"));f.Pc=116;continue;}
case 116:{f.Pc=f.Pop().Reference==null?159:119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","decider","Lforge/game/player/Player;"));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int!=0?144:129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[0]);f.Pc=131;continue;}
case 131:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=134;continue;}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","decider","Lforge/game/player/Player;"));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","getNewChooser","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/player/Player;","invokestatic",141);}
case 141:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/WrappedAbility","decider","Lforge/game/player/Player;",value);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","decider","Lforge/game/player/Player;"));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",151);}
case 151:{f.Push(f.Locals[0]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/player/PlayerController","confirmTrigger","(Lforge/game/trigger/WrappedAbility;)Z","invokevirtual",155);}
case 155:{f.Pc=f.Pop().Int!=0?159:158;continue;}
case 158:{return JStep.ReturnVoid;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",163);}
case 163:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",166);}
case 166:{f.Push(f.Locals[0]);f.Pc=167;continue;}
case 167:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=170;continue;}
case 170:{f.Push(JValue.I(0));f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/player/PlayerController","playSpellAbilityNoStack","(Lforge/game/spellability/SpellAbility;Z)V","invokevirtual",174);}
case 174:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10867(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDamageMap","()Lforge/game/card/CardDamageTable;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10868(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPreventMap","()Lforge/game/card/CardDamageTable;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10869(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCounterTable","()Lforge/game/GameEntityCounterTable;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10870(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getChangeZoneTable","()Lforge/game/card/CardZoneTable;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10871(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDamageMap","(Lforge/game/card/CardDamageTable;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10872(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPreventMap","(Lforge/game/card/CardDamageTable;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10873(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCounterTable","(Lforge/game/GameEntityCounterTable;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10874(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setChangeZoneTable","(Lforge/game/card/CardZoneTable;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10875(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAlternativeCost","(Lforge/game/spellability/AlternativeCost;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10876(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAlternativeCost","()Lforge/game/spellability/AlternativeCost;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10877(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10878(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getXManaCostPaid","()Ljava/lang/Integer;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10879(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setXManaCostPaid","(Ljava/lang/Integer;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10880(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCardState","()Lforge/game/card/CardState;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10881(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10882(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getChosenList","()Ljava/util/List;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10883(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setChosenList","(Ljava/util/List;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10884(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10885(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10886(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/WrappedAbility","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getName","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10887(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/trigger/Trigger","requirementsCheck","(Lforge/game/Game;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?24:8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getTriggeringObjects","()Ljava/util/Map;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/trigger/Trigger","meetsRequirementsOnTriggeredObjects","(Lforge/game/Game;Ljava/util/Map;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
