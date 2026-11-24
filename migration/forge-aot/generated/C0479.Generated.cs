// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C479{
internal static JClass Build(){var c=new JClass("forge/game/card/CardZoneTable","com/google/common/collect/ForwardingTable",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("dataMap","Lcom/google/common/collect/Table;",false,JValue.Default("Lcom/google/common/collect/Table;"),null));
c.Add(new JField("createdTokens","Lforge/game/card/CardCollection;",false,JValue.Default("Lforge/game/card/CardCollection;"),null));
c.Add(new JField("firstTimeTokenCreators","Lforge/game/player/PlayerCollection;",false,JValue.Default("Lforge/game/player/PlayerCollection;"),null));
c.Add(new JField("lastStateBattlefield","Lforge/game/card/CardCollectionView;",false,JValue.Default("Lforge/game/card/CardCollectionView;"),null));
c.Add(new JField("lastStateGraveyard","Lforge/game/card/CardCollectionView;",false,JValue.Default("Lforge/game/card/CardCollectionView;"),null));
c.Add(new JMethod(5740,"forge/game/card/CardZoneTable","<init>","()V",1,1,3,new JHandler[]{},M5740));
c.Add(new JMethod(5741,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;)V",1,3,3,new JHandler[]{},M5741));
c.Add(new JMethod(5742,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardZoneTable;)V",1,2,3,new JHandler[]{},M5742));
c.Add(new JMethod(5743,"forge/game/card/CardZoneTable","getSimultaneousInstance","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;",9,2,8,new JHandler[]{},M5743));
c.Add(new JMethod(5744,"forge/game/card/CardZoneTable","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;",1,1,1,new JHandler[]{},M5744));
c.Add(new JMethod(5745,"forge/game/card/CardZoneTable","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;",1,1,1,new JHandler[]{},M5745));
c.Add(new JMethod(5746,"forge/game/card/CardZoneTable","setLastStateBattlefield","(Lforge/game/card/CardCollectionView;)V",1,2,4,new JHandler[]{},M5746));
c.Add(new JMethod(5747,"forge/game/card/CardZoneTable","setLastStateGraveyard","(Lforge/game/card/CardCollectionView;)V",1,2,4,new JHandler[]{},M5747));
c.Add(new JMethod(5748,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;",1,5,4,new JHandler[]{},M5748));
c.Add(new JMethod(5749,"forge/game/card/CardZoneTable","delegate","()Lcom/google/common/collect/Table;",4,1,1,new JHandler[]{},M5749));
c.Add(new JMethod(5750,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V",1,5,5,new JHandler[]{},M5750));
c.Add(new JMethod(5751,"forge/game/card/CardZoneTable","triggerTokenCreatedOnce","(Lforge/game/Game;)V",2,3,4,new JHandler[]{},M5751));
c.Add(new JMethod(5752,"forge/game/card/CardZoneTable","filterCards","(Ljava/lang/Iterable;Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;",1,14,5,new JHandler[]{},M5752));
c.Add(new JMethod(5753,"forge/game/card/CardZoneTable","allCards","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M5753));
c.Add(new JMethod(5754,"forge/game/card/CardZoneTable","addToken","(Lforge/game/card/Card;Z)V",1,3,2,new JHandler[]{},M5754));
c.Add(new JMethod(5755,"forge/game/card/CardZoneTable","delegate","()Ljava/lang/Object;",4164,1,1,new JHandler[]{},M5755));
c.Add(new JMethod(5756,"forge/game/card/CardZoneTable","lambda$filterCards$0","(Lforge/game/zone/ZoneType;)Z",4098,2,2,new JHandler[]{},M5756));
}

internal static JStep M5740(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5741(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/ForwardingTable","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","()Lcom/google/common/collect/HashBasedTable;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardZoneTable","dataMap","Lcom/google/common/collect/Table;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardZoneTable","createdTokens","Lforge/game/card/CardCollection;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","()V","invokespecial",30);}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardZoneTable","firstTimeTokenCreators","Lforge/game/player/PlayerCollection;",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/CardZoneTable","setLastStateBattlefield","(Lforge/game/card/CardCollectionView;)V","invokevirtual",38);}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/CardZoneTable","setLastStateGraveyard","(Lforge/game/card/CardCollectionView;)V","invokevirtual",43);}
case 43:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5742(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/ForwardingTable","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","()Lcom/google/common/collect/HashBasedTable;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardZoneTable","dataMap","Lcom/google/common/collect/Table;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardZoneTable","createdTokens","Lforge/game/card/CardCollection;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","()V","invokespecial",30);}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardZoneTable","firstTimeTokenCreators","Lforge/game/player/PlayerCollection;",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/CardZoneTable","putAll","(Lcom/google/common/collect/Table;)V","invokevirtual",38);}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",43);}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardZoneTable","lastStateBattlefield","Lforge/game/card/CardCollectionView;",value);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",51);}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardZoneTable","lastStateGraveyard","Lforge/game/card/CardCollectionView;",value);f.Pc=54;continue;}
case 54:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5743(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?41:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacementEffect","()Lforge/game/replacement/ReplacementEffect;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getMode","()Lforge/game/replacement/ReplacementType;","invokevirtual",14);}
case 14:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"));f.Pc=17;continue;}
case 17:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?41:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","InternalTriggerTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","InternalTriggerTable","Lforge/game/ability/AbilityKey;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Reference==null?41:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","InternalTriggerTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","InternalTriggerTable","Lforge/game/ability/AbilityKey;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardZoneTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",48);}
case 48:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",51);}
case 51:{f.Locals[1]=f.Pop();f.Pc=52;continue;}
case 52:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(null));f.Pc=62;continue;}
case 62:{f.Push(JValue.I(1));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/GameAction","getLastState","(Lforge/game/ability/AbilityKey;Lforge/game/spellability/SpellAbility;Ljava/util/Map;Z)Lforge/game/card/CardCollectionView;","invokevirtual",66);}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(null));f.Pc=72;continue;}
case 72:{f.Push(JValue.I(1));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/GameAction","getLastState","(Lforge/game/ability/AbilityKey;Lforge/game/spellability/SpellAbility;Ljava/util/Map;Z)Lforge/game/card/CardCollectionView;","invokevirtual",76);}
case 76:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;)V","invokespecial",79);}
case 79:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5744(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardZoneTable","lastStateBattlefield","Lforge/game/card/CardCollectionView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5745(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardZoneTable","lastStateGraveyard","Lforge/game/card/CardCollectionView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5746(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Pc=f.Pop().Reference!=null?11:5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=8;continue;}
case 8:{f.Pc=19;continue;}
case 11:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardZoneTable","lastStateBattlefield","Lforge/game/card/CardCollectionView;",value);f.Pc=22;continue;}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5747(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Pc=f.Pop().Reference!=null?11:5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=8;continue;}
case 8:{f.Pc=19;continue;}
case 11:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardZoneTable","lastStateGraveyard","Lforge/game/card/CardCollectionView;",value);f.Pc=22;continue;}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5748(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?8:4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=7;continue;}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference!=null?16:12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=15;continue;}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/CardZoneTable","contains","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?46:25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/CardZoneTable","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{f.Pc=70;continue;}
case 46:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=49;continue;}
case 49:{f.StackOp("dup");f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",54);}
case 54:{f.Locals[4]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/CardZoneTable","delegate","()Lcom/google/common/collect/Table;","invokevirtual",60);}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"com/google/common/collect/Table","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5749(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardZoneTable","dataMap","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5750(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerTokenCreatedOnce","(Lforge/game/Game;)V","invokevirtual",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?21:9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","InternalTriggerTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","InternalTriggerTable","Lforge/game/ability/AbilityKey;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?21:20;continue;}
case 20:{return JStep.ReturnVoid;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/CardZoneTable","isEmpty","()Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int!=0?259:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/CardZoneTable","allCards","()Ljava/lang/Iterable;","invokevirtual",32);}
case 32:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",37);}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",44);}
case 44:{f.Pc=f.Pop().Int==0?78:47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",53);}
case 53:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=56;continue;}
case 56:{f.Locals[4]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?75:66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/Game","getTimestamp","()J","invokevirtual",72);}
case 72:{return rt.Call(f,"forge/game/card/Card","updateWorldTimestamp","(J)V","invokevirtual",75);}
case 75:{f.Pc=38;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/card/CardZoneTable","containsColumn","(Ljava/lang/Object;)Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int==0?150:88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/card/CardZoneTable","column","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",95);}
case 95:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",100);}
case 100:{return rt.Call(f,"com/google/common/collect/Iterables","concat","(Ljava/lang/Iterable;)Ljava/lang/Iterable;","invokestatic",103);}
case 103:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",108);}
case 108:{f.Locals[3]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[3]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",115);}
case 115:{f.Pc=f.Pop().Int==0?150:118;continue;}
case 118:{f.Push(f.Locals[3]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",124);}
case 124:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=127;continue;}
case 127:{f.Locals[4]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[4]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",134);}
case 134:{f.Pc=f.Pop().Int==0?147:137;continue;}
case 137:{f.Push(f.Locals[4]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",142);}
case 142:{f.Push(f.Locals[4]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/zone/Zone","updateLKI","(Lforge/game/card/Card;)V","invokevirtual",147);}
case 147:{f.Pc=109;continue;}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardZoneTable","lastStateBattlefield","Lforge/game/card/CardCollectionView;"));f.Pc=154;continue;}
case 154:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=157;continue;}
case 157:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?214:160;continue;}
case 160:{f.Push(f.Locals[1]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",164);}
case 164:{f.Push(JValue.I(0));f.Pc=165;continue;}
case 165:{f.Push(f.Locals[0]);f.Pc=166;continue;}
case 166:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardZoneTable","lastStateBattlefield","Lforge/game/card/CardCollectionView;"));f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/trigger/TriggerHandler","resetActiveTriggers","(ZLforge/game/card/CardCollectionView;)V","invokevirtual",172);}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardZoneTable","lastStateBattlefield","Lforge/game/card/CardCollectionView;"));f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",181);}
case 181:{f.Locals[3]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(f.Locals[3]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",188);}
case 188:{f.Pc=f.Pop().Int==0?214:191;continue;}
case 191:{f.Push(f.Locals[3]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",197);}
case 197:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=200;continue;}
case 200:{f.Locals[4]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[1]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",206);}
case 206:{f.Push(f.Locals[4]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerActiveLTBTrigger","(Lforge/game/card/Card;)V","invokevirtual",211);}
case 211:{f.Pc=182;continue;}
case 214:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",217);}
case 217:{f.Locals[3]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(f.Locals[3]);f.Pc=219;continue;}
case 219:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=222;continue;}
case 222:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=225;continue;}
case 225:{f.StackOp("dup");f.Pc=226;continue;}
case 226:{f.Push(f.Locals[0]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardZoneTable;)V","invokespecial",230);}
case 230:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",235);}
case 235:{f.StackOp("pop");f.Pc=236;continue;}
case 236:{f.Push(f.Locals[3]);f.Pc=237;continue;}
case 237:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=240;continue;}
case 240:{f.Push(f.Locals[2]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",246);}
case 246:{f.StackOp("pop");f.Pc=247;continue;}
case 247:{f.Push(f.Locals[1]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",251);}
case 251:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesZoneAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesZoneAll","Lforge/game/trigger/TriggerType;"));f.Pc=254;continue;}
case 254:{f.Push(f.Locals[3]);f.Pc=255;continue;}
case 255:{f.Push(JValue.I(0));f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",259);}
case 259:{f.Push(f.Locals[1]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/Game","getUntilHostLeavesPlayTriggerList","()Lforge/game/card/CardZoneTable;","invokevirtual",263);}
case 263:{f.Locals[3]=f.Pop();f.Pc=264;continue;}
case 264:{f.Push(f.Locals[0]);f.Pc=265;continue;}
case 265:{f.Push(f.Locals[3]);f.Pc=266;continue;}
case 266:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?279:269;continue;}
case 269:{f.Push(f.Locals[3]);f.Pc=270;continue;}
case 270:{f.Push(f.Locals[1]);f.Pc=271;continue;}
case 271:{f.Push(JValue.R(null));f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",275);}
case 275:{f.Push(f.Locals[3]);f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/card/CardZoneTable","clear","()V","invokevirtual",279);}
case 279:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5751(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardZoneTable","createdTokens","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?54:10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardZoneTable","createdTokens","Lforge/game/card/CardCollection;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",27);}
case 27:{f.StackOp("pop");f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","FirstTime","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","FirstTime","Lforge/game/ability/AbilityKey;"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardZoneTable","firstTimeTokenCreators","Lforge/game/player/PlayerCollection;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",46);}
case 46:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TokenCreatedOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TokenCreatedOnce","Lforge/game/trigger/TriggerType;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",54);}
case 54:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5752(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[6]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference==null?29:13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.DynamicCall(f,"forge/game/card/CardZoneTable:5752:15:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/CardZoneTable;)Ljava/util/function/Predicate;",20);}
case 20:{return rt.Call(f,"forge/util/IterableUtil","any","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Z","invokestatic",23);}
case 23:{f.Pc=f.Pop().Int!=0?29:26;continue;}
case 26:{f.Push(f.Locals[6]);f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Reference==null?374:33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",39);}
case 39:{f.Locals[7]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[7]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",48);}
case 48:{f.Pc=f.Pop().Int==0?371:51;continue;}
case 51:{f.Push(f.Locals[7]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{f.Locals[8]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[8]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/card/CardZoneTable","containsRow","(Ljava/lang/Object;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?368:72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=75;continue;}
case 75:{f.Locals[9]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[8]);f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=82;continue;}
case 82:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?91:85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardZoneTable","lastStateBattlefield","Lforge/game/card/CardCollectionView;"));f.Pc=89;continue;}
case 89:{f.Locals[9]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[8]);f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=96;continue;}
case 96:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?109:99;continue;}
case 99:{f.Push(f.Locals[2]);f.Pc=100;continue;}
case 100:{f.Pc=f.Pop().Reference!=null?109:103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardZoneTable","lastStateGraveyard","Lforge/game/card/CardCollectionView;"));f.Pc=107;continue;}
case 107:{f.Locals[9]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{f.Pc=f.Pop().Reference==null?252:113;continue;}
case 113:{f.Push(f.Locals[2]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",119);}
case 119:{f.Locals[10]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[10]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",128);}
case 128:{f.Pc=f.Pop().Int==0?249:131;continue;}
case 131:{f.Push(f.Locals[10]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",138);}
case 138:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=141;continue;}
case 141:{f.Locals[11]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(f.Locals[0]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[8]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/card/CardZoneTable","row","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",149);}
case 149:{f.Push(f.Locals[11]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",156);}
case 156:{f.Pc=f.Pop().Int==0?246:159;continue;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[8]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/card/CardZoneTable","row","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",165);}
case 165:{f.Push(f.Locals[11]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",172);}
case 172:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",178);}
case 178:{f.Locals[12]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[12]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",187);}
case 187:{f.Pc=f.Pop().Int==0?246:190;continue;}
case 190:{f.Push(f.Locals[12]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",197);}
case 197:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=200;continue;}
case 200:{f.Locals[13]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[9]);f.Pc=204;continue;}
case 204:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=207;continue;}
case 207:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?225:210;continue;}
case 210:{f.Push(f.Locals[9]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[13]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",219);}
case 219:{f.Pc=f.Pop().Int!=0?225:222;continue;}
case 222:{f.Pc=180;continue;}
case 225:{f.Push(f.Locals[6]);f.Pc=227;continue;}
case 227:{f.Push(f.Locals[9]);f.Pc=229;continue;}
case 229:{f.Push(f.Locals[13]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",236);}
case 236:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",242);}
case 242:{f.StackOp("pop");f.Pc=243;continue;}
case 243:{f.Pc=180;continue;}
case 246:{f.Pc=121;continue;}
case 249:{f.Pc=368;continue;}
case 252:{f.Push(f.Locals[0]);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[8]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/card/CardZoneTable","row","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",258);}
case 258:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",263);}
case 263:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",268);}
case 268:{f.Locals[10]=f.Pop();f.Pc=270;continue;}
case 270:{f.Push(f.Locals[10]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",277);}
case 277:{f.Pc=f.Pop().Int==0?368:280;continue;}
case 280:{f.Push(f.Locals[10]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",287);}
case 287:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=290;continue;}
case 290:{f.Locals[11]=f.Pop();f.Pc=292;continue;}
case 292:{f.Push(f.Locals[11]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",297);}
case 297:{f.Locals[12]=f.Pop();f.Pc=299;continue;}
case 299:{f.Push(f.Locals[12]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",306);}
case 306:{f.Pc=f.Pop().Int==0?365:309;continue;}
case 309:{f.Push(f.Locals[12]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",316);}
case 316:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=319;continue;}
case 319:{f.Locals[13]=f.Pop();f.Pc=321;continue;}
case 321:{f.Push(f.Locals[9]);f.Pc=323;continue;}
case 323:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=326;continue;}
case 326:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?344:329;continue;}
case 329:{f.Push(f.Locals[9]);f.Pc=331;continue;}
case 331:{f.Push(f.Locals[13]);f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",338);}
case 338:{f.Pc=f.Pop().Int!=0?344:341;continue;}
case 341:{f.Pc=299;continue;}
case 344:{f.Push(f.Locals[6]);f.Pc=346;continue;}
case 346:{f.Push(f.Locals[9]);f.Pc=348;continue;}
case 348:{f.Push(f.Locals[13]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",355);}
case 355:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=358;continue;}
case 358:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",361);}
case 361:{f.StackOp("pop");f.Pc=362;continue;}
case 362:{f.Pc=299;continue;}
case 365:{f.Pc=270;continue;}
case 368:{f.Pc=41;continue;}
case 371:{f.Pc=509;continue;}
case 374:{f.Push(f.Locals[2]);f.Pc=375;continue;}
case 375:{f.Pc=f.Pop().Reference==null?465:378;continue;}
case 378:{f.Push(f.Locals[2]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",384);}
case 384:{f.Locals[7]=f.Pop();f.Pc=386;continue;}
case 386:{f.Push(f.Locals[7]);f.Pc=388;continue;}
case 388:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",393);}
case 393:{f.Pc=f.Pop().Int==0?462:396;continue;}
case 396:{f.Push(f.Locals[7]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",403);}
case 403:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=406;continue;}
case 406:{f.Locals[8]=f.Pop();f.Pc=408;continue;}
case 408:{f.Push(f.Locals[0]);f.Pc=409;continue;}
case 409:{f.Push(f.Locals[8]);f.Pc=411;continue;}
case 411:{return rt.Call(f,"forge/game/card/CardZoneTable","column","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",414);}
case 414:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",419);}
case 419:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",424);}
case 424:{f.Locals[9]=f.Pop();f.Pc=426;continue;}
case 426:{f.Push(f.Locals[9]);f.Pc=428;continue;}
case 428:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",433);}
case 433:{f.Pc=f.Pop().Int==0?459:436;continue;}
case 436:{f.Push(f.Locals[9]);f.Pc=438;continue;}
case 438:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",443);}
case 443:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=446;continue;}
case 446:{f.Locals[10]=f.Pop();f.Pc=448;continue;}
case 448:{f.Push(f.Locals[6]);f.Pc=450;continue;}
case 450:{f.Push(f.Locals[10]);f.Pc=452;continue;}
case 452:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",455);}
case 455:{f.StackOp("pop");f.Pc=456;continue;}
case 456:{f.Pc=426;continue;}
case 459:{f.Pc=386;continue;}
case 462:{f.Pc=509;continue;}
case 465:{f.Push(f.Locals[0]);f.Pc=466;continue;}
case 466:{return rt.Call(f,"forge/game/card/CardZoneTable","values","()Ljava/util/Collection;","invokevirtual",469);}
case 469:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",474);}
case 474:{f.Locals[7]=f.Pop();f.Pc=476;continue;}
case 476:{f.Push(f.Locals[7]);f.Pc=478;continue;}
case 478:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",483);}
case 483:{f.Pc=f.Pop().Int==0?509:486;continue;}
case 486:{f.Push(f.Locals[7]);f.Pc=488;continue;}
case 488:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",493);}
case 493:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=496;continue;}
case 496:{f.Locals[8]=f.Pop();f.Pc=498;continue;}
case 498:{f.Push(f.Locals[6]);f.Pc=500;continue;}
case 500:{f.Push(f.Locals[8]);f.Pc=502;continue;}
case 502:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",505);}
case 505:{f.StackOp("pop");f.Pc=506;continue;}
case 506:{f.Pc=476;continue;}
case 509:{f.Push(f.Locals[3]);f.Pc=510;continue;}
case 510:{f.Pc=f.Pop().Reference==null?530:513;continue;}
case 513:{f.Push(f.Locals[6]);f.Pc=515;continue;}
case 515:{f.Push(f.Locals[3]);f.Pc=516;continue;}
case 516:{f.Push(f.Locals[4]);f.Pc=518;continue;}
case 518:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",521);}
case 521:{f.Push(f.Locals[4]);f.Pc=523;continue;}
case 523:{f.Push(f.Locals[5]);f.Pc=525;continue;}
case 525:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",528);}
case 528:{f.Locals[6]=f.Pop();f.Pc=530;continue;}
case 530:{f.Push(f.Locals[6]);f.Pc=532;continue;}
case 532:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5753(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardZoneTable","values","()Ljava/util/Collection;","invokevirtual",4);}
case 4:{return rt.Call(f,"com/google/common/collect/Iterables","concat","(Ljava/lang/Iterable;)Ljava/lang/Iterable;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5754(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardZoneTable","createdTokens","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.StackOp("pop");f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Int==0?25:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardZoneTable","firstTimeTokenCreators","Lforge/game/player/PlayerCollection;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/game/player/PlayerCollection","add","(Ljava/lang/Object;)Z","invokevirtual",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5755(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardZoneTable","delegate","()Lcom/google/common/collect/Table;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5756(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardZoneTable","columnKeySet","()Ljava/util/Set;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
