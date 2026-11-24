// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C683{
internal static JClass Build(){var c=new JClass("forge/game/mana/ManaPool","forge/game/mana/ManaConversionMatrix",new string[]{"java/lang/Iterable"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("owner","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JField("floatingMana","Lcom/google/common/collect/ArrayListMultimap;",false,JValue.Default("Lcom/google/common/collect/ArrayListMultimap;"),null));
c.Add(new JMethod(7772,"forge/game/mana/ManaPool","<init>","(Lforge/game/player/Player;)V",1,2,2,new JHandler[]{},M7772));
c.Add(new JMethod(7773,"forge/game/mana/ManaPool","getAmountOfColor","(B)I",17,3,2,new JHandler[]{},M7773));
c.Add(new JMethod(7774,"forge/game/mana/ManaPool","addManaNoEvent","(Lforge/game/mana/Mana;)V",1,2,3,new JHandler[]{},M7774));
c.Add(new JMethod(7775,"forge/game/mana/ManaPool","addMana","([Lforge/game/mana/Mana;)V",145,2,2,new JHandler[]{},M7775));
c.Add(new JMethod(7776,"forge/game/mana/ManaPool","addMana","(Ljava/lang/Iterable;)V",17,5,6,new JHandler[]{},M7776));
c.Add(new JMethod(7777,"forge/game/mana/ManaPool","willManaBeLostAtEndOfPhase","()Z",17,5,4,new JHandler[]{},M7777));
c.Add(new JMethod(7778,"forge/game/mana/ManaPool","hasBurn","()Z",17,2,1,new JHandler[]{},M7778));
c.Add(new JMethod(7779,"forge/game/mana/ManaPool","resetPool","()V",17,1,1,new JHandler[]{},M7779));
c.Add(new JMethod(7780,"forge/game/mana/ManaPool","clearPool","(Z)Ljava/util/List;",17,12,6,new JHandler[]{},M7780));
c.Add(new JMethod(7781,"forge/game/mana/ManaPool","convertManaColor","(BB)V",2,7,3,new JHandler[]{},M7781));
c.Add(new JMethod(7782,"forge/game/mana/ManaPool","removeManaNoEvent","(Lforge/game/mana/Mana;)Z",1,2,3,new JHandler[]{},M7782));
c.Add(new JMethod(7783,"forge/game/mana/ManaPool","removeMana","([Lforge/game/mana/Mana;)Z",129,2,2,new JHandler[]{},M7783));
c.Add(new JMethod(7784,"forge/game/mana/ManaPool","removeMana","(Ljava/lang/Iterable;)Z",1,5,6,new JHandler[]{},M7784));
c.Add(new JMethod(7785,"forge/game/mana/ManaPool","payManaFromAbility","(Lforge/game/spellability/SpellAbility;Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;)V",17,9,5,new JHandler[]{},M7785));
c.Add(new JMethod(7786,"forge/game/mana/ManaPool","tryPayCostWithColor","(BLforge/game/spellability/SpellAbility;Lforge/game/mana/ManaCostBeingPaid;Ljava/util/List;)Z",1,9,5,new JHandler[]{},M7786));
c.Add(new JMethod(7787,"forge/game/mana/ManaPool","tryPayCostWithMana","(Lforge/game/spellability/SpellAbility;Lforge/game/mana/ManaCostBeingPaid;Lforge/game/mana/Mana;Z)Z",1,5,5,new JHandler[]{},M7787));
c.Add(new JMethod(7788,"forge/game/mana/ManaPool","isEmpty","()Z",17,1,1,new JHandler[]{},M7788));
c.Add(new JMethod(7789,"forge/game/mana/ManaPool","totalMana","()I",17,1,1,new JHandler[]{},M7789));
c.Add(new JMethod(7790,"forge/game/mana/ManaPool","accountFor","(Lforge/game/spellability/AbilityManaPart;)Z",1,7,2,new JHandler[]{},M7790));
c.Add(new JMethod(7791,"forge/game/mana/ManaPool","refundMana","(Ljava/util/List;)V",1,2,2,new JHandler[]{},M7791));
c.Add(new JMethod(7792,"forge/game/mana/ManaPool","canPayForShardWithColor","(Lforge/card/mana/ManaCostShard;B)Z",1,8,2,new JHandler[]{},M7792));
c.Add(new JMethod(7793,"forge/game/mana/ManaPool","payManaCostFromPool","(Lforge/game/mana/ManaCostBeingPaid;Lforge/game/spellability/SpellAbility;ZLjava/util/List;)Z",1,10,5,new JHandler[]{},M7793));
c.Add(new JMethod(7794,"forge/game/mana/ManaPool","iterator","()Ljava/util/Iterator;",1,1,1,new JHandler[]{},M7794));
}

internal static JStep M7772(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/mana/ManaConversionMatrix","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/mana/ManaPool","restoreColorReplacements","()V","invokevirtual",20);}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7773(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Byte","valueOf","(B)Ljava/lang/Byte;","invokestatic",8);}
case 8:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokevirtual",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Reference!=null?20:16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{f.Pc=26;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",26);}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7774(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Byte","valueOf","(B)Ljava/lang/Byte;","invokestatic",11);}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.StackOp("pop");f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7775(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/game/mana/ManaPool","addMana","(Ljava/lang/Iterable;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7776(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/MagicColor$Color")));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?69:22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",42);}
case 42:{return rt.Call(f,"java/lang/Byte","valueOf","(B)Ljava/lang/Byte;","invokestatic",45);}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokevirtual",50);}
case 50:{f.StackOp("pop");f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",57);}
case 57:{return rt.Call(f,"forge/card/MagicColor$Color","fromByte","(B)Lforge/card/MagicColor$Color;","invokestatic",60);}
case 60:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Pc=13;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",75);}
case 75:{f.Pc=f.Pop().Int!=0?110:78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/player/Player","updateManaForView","()V","invokevirtual",85);}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",92);}
case 92:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventManaPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventManaPool")));f.Pc=95;continue;}
case 95:{f.StackOp("dup");f.Pc=96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/game/event/EventValueChangeType","Added","Lforge/game/event/EventValueChangeType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/event/EventValueChangeType","Added","Lforge/game/event/EventValueChangeType;"));f.Pc=103;continue;}
case 103:{f.Push(f.Locals[2]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/event/GameEventManaPool","<init>","(Lforge/game/player/Player;Lforge/game/event/EventValueChangeType;Ljava/util/Set;)V","invokespecial",107);}
case 107:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",110);}
case 110:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7777(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",19);}
case 19:{f.Locals[1]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",27);}
case 27:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",30);}
case 30:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","LoseMana","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","LoseMana","Lforge/game/replacement/ReplacementType;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","getReplacementList","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;Lforge/game/replacement/ReplacementLayer;)Ljava/util/List;","invokevirtual",40);}
case 40:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",45);}
case 45:{f.Pc=f.Pop().Int!=0?50:48;continue;}
case 48:{f.Push(JValue.I(0));f.Pc=49;continue;}
case 49:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{f.Locals[2]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/staticability/StaticAbilityUnspentMana","getManaToKeep","(Lforge/game/player/Player;)Ljava/util/Collection;","invokestatic",59);}
case 59:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",64);}
case 64:{f.Locals[3]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",71);}
case 71:{f.Pc=f.Pop().Int==0?100:74;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",80);}
case 80:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Byte"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/Byte","byteValue","()B","invokevirtual",86);}
case 86:{f.Locals[4]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/mana/ManaPool","getAmountOfColor","(B)I","invokevirtual",95);}
case 95:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=96;continue;}
case 96:{f.Locals[2]=f.Pop();f.Pc=97;continue;}
case 97:{f.Pc=65;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/mana/ManaPool","totalMana","()I","invokevirtual",104);}
case 104:{f.Push(f.Locals[2]);f.Pc=105;continue;}
case 105:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?112:108;continue;}
case 108:{f.Push(JValue.I(1));f.Pc=109;continue;}
case 109:{f.Pc=113;continue;}
case 112:{f.Push(JValue.I(0));f.Pc=113;continue;}
case 113:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7778(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/Game","getRules","()Lforge/game/GameRules;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/GameRules","hasManaBurn","()Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?28:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/staticability/StaticAbilityUnspentMana","hasManaBurn","(Lforge/game/player/Player;)Z","invokestatic",25);}
case 25:{f.Pc=f.Pop().Int==0?32:28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Pc=33;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7779(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","clear","()V","invokevirtual",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7780(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","isEmpty","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?16:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",25);}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"));f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("C")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{if(!rt.StaticReady(f,"forge/game/mana/ManaPool$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/mana/ManaPool$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",50);}
case 50:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",53);}
case 53:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","LoseMana","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","LoseMana","Lforge/game/replacement/ReplacementType;"));f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",61);}
case 61:{return rt.Call(f,"forge/game/replacement/ReplacementResult","ordinal","()I","invokevirtual",64);}
case 64:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=65;continue;}
case 65:{switch(f.Pop().Int){case 1:f.Pc=92;break;case 2:f.Pc=95;break;default:f.Pc=97;break;}continue;}
case 92:{f.Pc=117;continue;}
case 95:{f.Push(f.Locals[2]);f.Pc=96;continue;}
case 96:{return JStep.Return(f.Pop());}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",107);}
case 107:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/card/mana/ManaAtom","fromName","(Ljava/lang/String;)B","invokestatic",113);}
case 113:{return rt.Call(f,"java/lang/Byte","valueOf","(B)Ljava/lang/Byte;","invokestatic",116);}
case 116:{f.Locals[3]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=121;continue;}
case 121:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","keySet","()Ljava/util/Set;","invokevirtual",124);}
case 124:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",127);}
case 127:{f.Locals[5]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{f.Pc=f.Pop().Int==0?148:133;continue;}
case 133:{f.Push(f.Locals[5]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/staticability/StaticAbilityUnspentMana","getManaToKeep","(Lforge/game/player/Player;)Ljava/util/Collection;","invokestatic",142);}
case 142:{return rt.Call(f,"java/util/List","removeAll","(Ljava/util/Collection;)Z","invokeinterface",147);}
case 147:{f.StackOp("pop");f.Pc=148;continue;}
case 148:{f.Push(f.Locals[3]);f.Pc=149;continue;}
case 149:{f.Pc=f.Pop().Reference==null?161:152;continue;}
case 152:{f.Push(f.Locals[5]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[3]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",160);}
case 160:{f.StackOp("pop");f.Pc=161;continue;}
case 161:{f.Push(f.Locals[5]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",168);}
case 168:{f.Locals[6]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[6]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",177);}
case 177:{f.Pc=f.Pop().Int==0?391:180;continue;}
case 180:{f.Push(f.Locals[6]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",187);}
case 187:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Byte"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=190;continue;}
case 190:{f.Locals[7]=f.Pop();f.Pc=192;continue;}
case 192:{f.Push(f.Locals[0]);f.Pc=193;continue;}
case 193:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=196;continue;}
case 196:{f.Push(f.Locals[7]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokevirtual",201);}
case 201:{f.Locals[8]=f.Pop();f.Pc=203;continue;}
case 203:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",206);}
case 206:{f.Locals[9]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[1]);f.Pc=209;continue;}
case 209:{f.Pc=f.Pop().Int==0?320:212;continue;}
case 212:{f.Push(f.Locals[0]);f.Pc=213;continue;}
case 213:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",219);}
case 219:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",222);}
case 222:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"));f.Pc=225;continue;}
case 225:{return rt.Call(f,"forge/game/phase/PhaseHandler","is","(Lforge/game/phase/PhaseType;)Z","invokevirtual",228);}
case 228:{f.Pc=f.Pop().Int!=0?320:231;continue;}
case 231:{f.Push(f.Locals[8]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",238);}
case 238:{f.Locals[10]=f.Pop();f.Pc=240;continue;}
case 240:{f.Push(f.Locals[10]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",247);}
case 247:{f.Pc=f.Pop().Int==0?320:250;continue;}
case 250:{f.Push(f.Locals[10]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",257);}
case 257:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=260;continue;}
case 260:{f.Locals[11]=f.Pop();f.Pc=262;continue;}
case 262:{f.Push(f.Locals[11]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/mana/Mana","isPersistentMana","()Z","invokevirtual",267);}
case 267:{f.Pc=f.Pop().Int==0?280:270;continue;}
case 270:{f.Push(f.Locals[9]);f.Pc=272;continue;}
case 272:{f.Push(f.Locals[11]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",279);}
case 279:{f.StackOp("pop");f.Pc=280;continue;}
case 280:{f.Push(f.Locals[11]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/mana/Mana","isCombatMana","()Z","invokevirtual",285);}
case 285:{f.Pc=f.Pop().Int==0?317:288;continue;}
case 288:{f.Push(f.Locals[0]);f.Pc=289;continue;}
case 289:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",295);}
case 295:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",298);}
case 298:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_END","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_END","Lforge/game/phase/PhaseType;"));f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/phase/PhaseHandler","is","(Lforge/game/phase/PhaseType;)Z","invokevirtual",304);}
case 304:{f.Pc=f.Pop().Int!=0?317:307;continue;}
case 307:{f.Push(f.Locals[9]);f.Pc=309;continue;}
case 309:{f.Push(f.Locals[11]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",316);}
case 316:{f.StackOp("pop");f.Pc=317;continue;}
case 317:{f.Pc=240;continue;}
case 320:{f.Push(f.Locals[8]);f.Pc=322;continue;}
case 322:{f.Push(f.Locals[9]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"java/util/Collection","removeAll","(Ljava/util/Collection;)Z","invokeinterface",329);}
case 329:{f.StackOp("pop");f.Pc=330;continue;}
case 330:{f.Push(f.Locals[3]);f.Pc=331;continue;}
case 331:{f.Pc=f.Pop().Reference==null?360:334;continue;}
case 334:{f.Push(f.Locals[0]);f.Pc=335;continue;}
case 335:{f.Push(f.Locals[7]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"java/lang/Byte","byteValue","()B","invokevirtual",340);}
case 340:{f.Push(f.Locals[3]);f.Pc=341;continue;}
case 341:{return rt.Call(f,"java/lang/Byte","byteValue","()B","invokevirtual",344);}
case 344:{return rt.Call(f,"forge/game/mana/ManaPool","convertManaColor","(BB)V","invokevirtual",347);}
case 347:{f.Push(f.Locals[8]);f.Pc=349;continue;}
case 349:{f.Push(f.Locals[9]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"java/util/Collection","addAll","(Ljava/util/Collection;)Z","invokeinterface",356);}
case 356:{f.StackOp("pop");f.Pc=357;continue;}
case 357:{f.Pc=388;continue;}
case 360:{f.Push(f.Locals[2]);f.Pc=361;continue;}
case 361:{f.Push(f.Locals[8]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",368);}
case 368:{f.StackOp("pop");f.Pc=369;continue;}
case 369:{f.Push(f.Locals[8]);f.Pc=371;continue;}
case 371:{return rt.Call(f,"java/util/Collection","clear","()V","invokeinterface",376);}
case 376:{f.Push(f.Locals[0]);f.Pc=377;continue;}
case 377:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=380;continue;}
case 380:{f.Push(f.Locals[7]);f.Pc=382;continue;}
case 382:{f.Push(f.Locals[9]);f.Pc=384;continue;}
case 384:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","putAll","(Ljava/lang/Object;Ljava/lang/Iterable;)Z","invokevirtual",387);}
case 387:{f.StackOp("pop");f.Pc=388;continue;}
case 388:{f.Pc=170;continue;}
case 391:{f.Push(f.Locals[0]);f.Pc=392;continue;}
case 392:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/game/player/Player","updateManaForView","()V","invokevirtual",398);}
case 398:{f.Push(f.Locals[0]);f.Pc=399;continue;}
case 399:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=402;continue;}
case 402:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",405);}
case 405:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventManaPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventManaPool")));f.Pc=408;continue;}
case 408:{f.StackOp("dup");f.Pc=409;continue;}
case 409:{f.Push(f.Locals[0]);f.Pc=410;continue;}
case 410:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=413;continue;}
case 413:{if(!rt.StaticReady(f,"forge/game/event/EventValueChangeType","Cleared","Lforge/game/event/EventValueChangeType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/event/EventValueChangeType","Cleared","Lforge/game/event/EventValueChangeType;"));f.Pc=416;continue;}
case 416:{f.Push(JValue.R(null));f.Pc=417;continue;}
case 417:{return rt.Call(f,"forge/game/event/GameEventManaPool","<init>","(Lforge/game/player/Player;Lforge/game/event/EventValueChangeType;Ljava/util/Set;)V","invokespecial",420);}
case 420:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",423);}
case 423:{f.Push(f.Locals[2]);f.Pc=424;continue;}
case 424:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7781(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Byte","valueOf","(B)Ljava/lang/Byte;","invokestatic",12);}
case 12:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokevirtual",15);}
case 15:{f.Locals[4]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",24);}
case 24:{f.Locals[5]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",33);}
case 33:{f.Pc=f.Pop().Int==0?64:36;continue;}
case 36:{f.Push(f.Locals[5]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{f.Locals[6]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[6]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/mana/Mana","convertColor","(B)Lforge/game/mana/Mana;","invokevirtual",55);}
case 55:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",60);}
case 60:{f.StackOp("pop");f.Pc=61;continue;}
case 61:{f.Pc=26;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Collection","clear","()V","invokeinterface",71);}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/Byte","valueOf","(B)Ljava/lang/Byte;","invokestatic",79);}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","putAll","(Ljava/lang/Object;Ljava/lang/Iterable;)Z","invokevirtual",83);}
case 83:{f.StackOp("pop");f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/player/Player","updateManaForView","()V","invokevirtual",91);}
case 91:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7782(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Byte","valueOf","(B)Ljava/lang/Byte;","invokestatic",11);}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","remove","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7783(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/game/mana/ManaPool","removeMana","(Ljava/lang/Iterable;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7784(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/MagicColor$Color")));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?71:22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",42);}
case 42:{return rt.Call(f,"java/lang/Byte","valueOf","(B)Ljava/lang/Byte;","invokestatic",45);}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","remove","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?68:53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",59);}
case 59:{return rt.Call(f,"forge/card/MagicColor$Color","fromByte","(B)Lforge/card/MagicColor$Color;","invokestatic",62);}
case 62:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",67);}
case 67:{f.StackOp("pop");f.Pc=68;continue;}
case 68:{f.Pc=13;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",77);}
case 77:{f.Pc=f.Pop().Int!=0?112:80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/player/Player","updateManaForView","()V","invokevirtual",87);}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",94);}
case 94:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventManaPool"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventManaPool")));f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=102;continue;}
case 102:{if(!rt.StaticReady(f,"forge/game/event/EventValueChangeType","Removed","Lforge/game/event/EventValueChangeType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/event/EventValueChangeType","Removed","Lforge/game/event/EventValueChangeType;"));f.Pc=105;continue;}
case 105:{f.Push(f.Locals[2]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/event/GameEventManaPool","<init>","(Lforge/game/player/Player;Lforge/game/event/EventValueChangeType;Ljava/util/Set;)V","invokespecial",109);}
case 109:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",112);}
case 112:{f.Push(f.Locals[2]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",118);}
case 118:{f.Pc=f.Pop().Int!=0?125:121;continue;}
case 121:{f.Push(JValue.I(1));f.Pc=122;continue;}
case 122:{f.Pc=126;continue;}
case 125:{f.Push(JValue.I(0));f.Pc=126;continue;}
case 126:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7785(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingManaAbilities","()Ljava/util/List;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[4]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAllManaParts","()Ljava/util/List;","invokevirtual",19);}
case 19:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",24);}
case 24:{f.Locals[5]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",33);}
case 33:{f.Pc=f.Pop().Int==0?132:36;continue;}
case 36:{f.Push(f.Locals[5]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilityManaPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{f.Locals[6]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[6]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getLastManaProduced","()Ljava/util/Collection;","invokevirtual",53);}
case 53:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",58);}
case 58:{f.Locals[7]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[7]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",67);}
case 67:{f.Pc=f.Pop().Int==0?129:70;continue;}
case 70:{f.Push(f.Locals[7]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",77);}
case 77:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=80;continue;}
case 80:{f.Locals[8]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceCard","()Lforge/game/card/Card;","invokevirtual",88);}
case 88:{f.Push(f.Locals[8]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",93);}
case 93:{return rt.Call(f,"forge/game/spellability/SpellAbility","allowsPayingWithShard","(Lforge/game/card/Card;B)Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int!=0?102:99;continue;}
case 99:{f.Pc=60;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[2]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[8]);f.Pc=107;continue;}
case 107:{f.Push(JValue.I(0));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/mana/ManaPool","tryPayCostWithMana","(Lforge/game/spellability/SpellAbility;Lforge/game/mana/ManaCostBeingPaid;Lforge/game/mana/Mana;Z)Z","invokevirtual",111);}
case 111:{f.Pc=f.Pop().Int==0?126:114;continue;}
case 114:{f.Push(f.Locals[1]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingMana","()Ljava/util/List;","invokevirtual",118);}
case 118:{f.Push(f.Locals[8]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",125);}
case 125:{f.StackOp("pop");f.Pc=126;continue;}
case 126:{f.Pc=60;continue;}
case 129:{f.Pc=26;continue;}
case 132:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7786(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[5]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/Byte","valueOf","(B)Ljava/lang/Byte;","invokestatic",11);}
case 11:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokevirtual",14);}
case 14:{f.Locals[6]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[6]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",23);}
case 23:{f.Locals[7]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[7]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?82:35;continue;}
case 35:{f.Push(f.Locals[7]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[8]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[8]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/mana/Mana","meetsManaRestrictions","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int!=0?59:56;continue;}
case 56:{f.Pc=25;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[8]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/mana/Mana","getSourceCard","()Lforge/game/card/Card;","invokevirtual",65);}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/spellability/SpellAbility","allowsPayingWithShard","(Lforge/game/card/Card;B)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int!=0?75:72;continue;}
case 72:{f.Pc=25;continue;}
case 75:{f.Push(f.Locals[8]);f.Pc=77;continue;}
case 77:{f.Locals[5]=f.Pop();f.Pc=79;continue;}
case 79:{f.Pc=82;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{f.Pc=f.Pop().Reference==null?111:87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[3]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[5]);f.Pc=92;continue;}
case 92:{f.Push(JValue.I(0));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/mana/ManaPool","tryPayCostWithMana","(Lforge/game/spellability/SpellAbility;Lforge/game/mana/ManaCostBeingPaid;Lforge/game/mana/Mana;Z)Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int==0?111:99;continue;}
case 99:{f.Push(f.Locals[4]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[5]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",108);}
case 108:{f.StackOp("pop");f.Pc=109;continue;}
case 109:{f.Push(JValue.I(1));f.Pc=110;continue;}
case 110:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 111:{f.Push(JValue.I(0));f.Pc=112;continue;}
case 112:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7787(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[3]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","isNeeded","(Lforge/game/mana/Mana;Lforge/game/mana/ManaPool;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int!=0?11:9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.NewArray("Lforge/game/mana/Mana;",f.Pop().Int)));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/mana/ManaPool","removeMana","([Lforge/game/mana/Mana;)Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?28:26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","payMana","(Lforge/game/mana/Mana;Lforge/game/mana/ManaPool;)Z","invokevirtual",34);}
case 34:{f.StackOp("pop");f.Pc=35;continue;}
case 35:{f.Push(JValue.I(1));f.Pc=36;continue;}
case 36:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7788(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","isEmpty","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7789(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","values","()Ljava/util/Collection;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7790(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","isEmpty","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?18:16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 18:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getLastManaProduced","()Ljava/util/Collection;","invokevirtual",28);}
case 28:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",33);}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?111:45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Locals[5]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",66);}
case 66:{return rt.Call(f,"java/lang/Byte","valueOf","(B)Ljava/lang/Byte;","invokestatic",69);}
case 69:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokevirtual",72);}
case 72:{f.Locals[6]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{f.Pc=f.Pop().Reference==null?103:79;continue;}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[5]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Collection","contains","(Ljava/lang/Object;)Z","invokeinterface",88);}
case 88:{f.Pc=f.Pop().Int==0?103:91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[5]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",99);}
case 99:{f.StackOp("pop");f.Pc=100;continue;}
case 100:{f.Pc=108;continue;}
case 103:{f.Push(JValue.I(1));f.Pc=104;continue;}
case 104:{f.Locals[3]=f.Pop();f.Pc=105;continue;}
case 105:{f.Pc=111;continue;}
case 108:{f.Pc=35;continue;}
case 111:{f.Push(f.Locals[3]);f.Pc=112;continue;}
case 112:{f.Pc=f.Pop().Int==0?117:115;continue;}
case 115:{f.Push(JValue.I(0));f.Pc=116;continue;}
case 116:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[2]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/mana/ManaPool","removeMana","(Ljava/lang/Iterable;)Z","invokevirtual",122);}
case 122:{f.StackOp("pop");f.Pc=123;continue;}
case 123:{f.Push(JValue.I(1));f.Pc=124;continue;}
case 124:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7791(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/mana/ManaPool","addMana","(Ljava/lang/Iterable;)V","invokevirtual",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7792(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(32));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/mana/ManaCostShard","isOfKind","(I)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?17:9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(64));f.Pc=12;continue;}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?17:15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/mana/ManaPool","getPossibleColorUses","(B)B","invokevirtual",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{if(!rt.StaticReady(f,"forge/card/mana/ManaAtom","MANATYPES","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaAtom","MANATYPES","[B"));f.Pc=26;continue;}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=31;continue;}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{f.Locals[6]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[6]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?74:43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[6]);f.Pc=47;continue;}
case 47:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=48;continue;}
case 48:{f.Locals[7]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[7]);f.Pc=53;continue;}
case 53:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=54;continue;}
case 54:{f.Pc=f.Pop().Int==0?68:57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[7]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/card/mana/ManaCostShard","canBePaidWithManaOfColor","(B)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?68:66;continue;}
case 66:{f.Push(JValue.I(1));f.Pc=67;continue;}
case 67:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 68:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=71;continue;}
case 71:{f.Pc=36;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{f.Push(JValue.I(0));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/card/mana/ManaCostShard","canBePaidWithManaOfColor","(B)Z","invokevirtual",79);}
case 79:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7793(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","hasConverge","()Z","invokevirtual",7);}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","getUnpaidShards","()Ljava/util/List;","invokevirtual",13);}
case 13:{f.Locals[6]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[6]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Collections","sort","(Ljava/util/List;)V","invokestatic",20);}
case 20:{f.Push(f.Locals[6]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",27);}
case 27:{f.Locals[7]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[7]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",36);}
case 36:{f.Pc=f.Pop().Int==0?128:39;continue;}
case 39:{f.Push(f.Locals[7]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[8]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[8]);f.Pc=53;continue;}
case 53:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"));f.Pc=56;continue;}
case 56:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?125:59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","isPaid","()Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?69:66;continue;}
case 66:{f.Pc=29;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","owner","Lforge/game/player/Player;"));f.Pc=73;continue;}
case 73:{f.Push(f.Locals[8]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{f.Pc=f.Pop().Int==0?88:81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","getColorsPaid","()B","invokevirtual",85);}
case 85:{f.Pc=89;continue;}
case 88:{f.Push(JValue.I(-1));f.Pc=89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","getXManaCostPaidByColor","()Ljava/util/Map;","invokevirtual",93);}
case 93:{return rt.Call(f,"forge/game/cost/CostPayment","getMana","(Lforge/game/player/Player;Lforge/card/mana/ManaCostShard;Lforge/game/spellability/SpellAbility;BLjava/util/Map;)Lforge/game/mana/Mana;","invokestatic",96);}
case 96:{f.Locals[9]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[9]);f.Pc=100;continue;}
case 100:{f.Pc=f.Pop().Reference==null?125:103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[2]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[9]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/mana/ManaPool","tryPayCostWithMana","(Lforge/game/spellability/SpellAbility;Lforge/game/mana/ManaCostBeingPaid;Lforge/game/mana/Mana;Z)Z","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Int==0?125:115;continue;}
case 115:{f.Push(f.Locals[4]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[9]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",124);}
case 124:{f.StackOp("pop");f.Pc=125;continue;}
case 125:{f.Pc=29;continue;}
case 128:{f.Push(f.Locals[1]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","isPaid","()Z","invokevirtual",132);}
case 132:{f.Pc=f.Pop().Int==0?147:135;continue;}
case 135:{f.Push(f.Locals[3]);f.Pc=136;continue;}
case 136:{f.Pc=f.Pop().Int==0?145:139;continue;}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[4]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/mana/ManaPool","refundMana","(Ljava/util/List;)V","invokevirtual",145);}
case 145:{f.Push(JValue.I(1));f.Pc=146;continue;}
case 146:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 147:{f.Push(JValue.I(0));f.Pc=148;continue;}
case 148:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7794(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaPool","floatingMana","Lcom/google/common/collect/ArrayListMultimap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","values","()Ljava/util/Collection;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
