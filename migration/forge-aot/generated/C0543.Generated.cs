// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C543{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostPartWithList","forge/game/cost/CostPart",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("lkiList","Lforge/game/card/CardCollection;",false,JValue.Default("Lforge/game/card/CardCollection;"),null));
c.Add(new JField("cardList","Lforge/game/card/CardCollection;",false,JValue.Default("Lforge/game/card/CardCollection;"),null));
c.Add(new JField("intrinsic","Z",false,JValue.Default("Z"),null));
c.Add(new JField("table","Lforge/game/card/CardZoneTable;",false,JValue.Default("Lforge/game/card/CardZoneTable;"),null));
c.Add(new JMethod(6427,"forge/game/cost/CostPartWithList","readObject","(Ljava/io/ObjectInputStream;)V",2,2,3,new JHandler[]{},M6427));
c.Add(new JMethod(6428,"forge/game/cost/CostPartWithList","getLKIList","()Lforge/game/card/CardCollectionView;",17,1,1,new JHandler[]{},M6428));
c.Add(new JMethod(6429,"forge/game/cost/CostPartWithList","getCardList","()Lforge/game/card/CardCollectionView;",17,1,1,new JHandler[]{},M6429));
c.Add(new JMethod(6430,"forge/game/cost/CostPartWithList","setIntrinsic","(Z)V",17,2,2,new JHandler[]{},M6430));
c.Add(new JMethod(6431,"forge/game/cost/CostPartWithList","resetLists","()V",1,1,1,new JHandler[]{},M6431));
c.Add(new JMethod(6432,"forge/game/cost/CostPartWithList","reportPaidCardsTo","(Lforge/game/spellability/SpellAbility;)V",17,6,4,new JHandler[]{},M6432));
c.Add(new JMethod(6433,"forge/game/cost/CostPartWithList","<init>","()V",1,1,3,new JHandler[]{},M6433));
c.Add(new JMethod(6434,"forge/game/cost/CostPartWithList","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",1,4,4,new JHandler[]{},M6434));
c.Add(new JMethod(6435,"forge/game/cost/CostPartWithList","executePayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Z)Z",17,6,5,new JHandler[]{},M6435));
c.Add(new JMethod(6436,"forge/game/cost/CostPartWithList","executePayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;Z)Z",4,7,6,new JHandler[]{},M6436));
c.Add(new JMethod(6437,"forge/game/cost/CostPartWithList","doPayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Z)Lforge/game/card/Card;",1028,0,0,new JHandler[]{},null));
c.Add(new JMethod(6438,"forge/game/cost/CostPartWithList","canPayListAtOnce","()Z",4,1,1,new JHandler[]{},M6438));
c.Add(new JMethod(6439,"forge/game/cost/CostPartWithList","doListPayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;Z)Lforge/game/card/CardCollectionView;",4,5,1,new JHandler[]{},M6439));
c.Add(new JMethod(6440,"forge/game/cost/CostPartWithList","getHashForLKIList","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6441,"forge/game/cost/CostPartWithList","getHashForCardList","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6442,"forge/game/cost/CostPartWithList","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",1,5,5,new JHandler[]{},M6442));
c.Add(new JMethod(6443,"forge/game/cost/CostPartWithList","handleBeforePayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;)V",4,4,0,new JHandler[]{},M6443));
c.Add(new JMethod(6444,"forge/game/cost/CostPartWithList","handleChangeZoneTrigger","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;)V",4,4,3,new JHandler[]{},M6444));
}

internal static JStep M6427(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/io/ObjectInputStream","defaultReadObject","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartWithList","table","Lforge/game/card/CardZoneTable;",value);f.Pc=15;continue;}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6428(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithList","lkiList","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6429(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithList","cardList","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6430(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartWithList","intrinsic","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6431(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithList","lkiList","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","clear","()V","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithList","cardList","Lforge/game/card/CardCollection;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardCollection","clear","()V","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithList","table","Lforge/game/card/CardZoneTable;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/CardZoneTable","clear","()V","invokevirtual",21);}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6432(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?5:4;continue;}
case 4:{return JStep.ReturnVoid;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/cost/CostPartWithList","getHashForLKIList","()Ljava/lang/String;","invokevirtual",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithList","lkiList","Lforge/game/card/CardCollection;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?52:27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithList","intrinsic","Z"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/spellability/SpellAbility","addCostToHashList","(Lforge/game/card/Card;Ljava/lang/String;Z)V","invokevirtual",49);}
case 49:{f.Pc=18;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/cost/CostPartWithList","getHashForCardList","()Ljava/lang/String;","invokevirtual",56);}
case 56:{f.Locals[3]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithList","cardList","Lforge/game/card/CardCollection;"));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",64);}
case 64:{f.Locals[4]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",73);}
case 73:{f.Pc=f.Pop().Int==0?102:76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",83);}
case 83:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=86;continue;}
case 86:{f.Locals[5]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[5]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[3]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithList","intrinsic","Z"));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/spellability/SpellAbility","addCostToHashList","(Lforge/game/card/Card;Ljava/lang/String;Z)V","invokevirtual",99);}
case 99:{f.Pc=66;continue;}
case 102:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6433(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostPart","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartWithList","lkiList","Lforge/game/card/CardCollection;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",23);}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartWithList","cardList","Lforge/game/card/CardCollection;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(JValue.I(1));f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartWithList","intrinsic","Z",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",39);}
case 39:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartWithList","table","Lforge/game/card/CardZoneTable;",value);f.Pc=42;continue;}
case 42:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6434(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/CostPart","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartWithList","lkiList","Lforge/game/card/CardCollection;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",26);}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartWithList","cardList","Lforge/game/card/CardCollection;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(1));f.Pc=31;continue;}
case 31:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartWithList","intrinsic","Z",value);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=38;continue;}
case 38:{f.StackOp("dup");f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",42);}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartWithList","table","Lforge/game/card/CardZoneTable;",value);f.Pc=45;continue;}
case 45:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6435(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithList","lkiList","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",11);}
case 11:{f.StackOp("pop");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/cost/CostPartWithList","doPayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Z)Lforge/game/card/Card;","invokevirtual",21);}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",27);}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/Game","updateLastStateForCard","(Lforge/game/card/Card;)V","invokevirtual",31);}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Reference==null?46:36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithList","cardList","Lforge/game/card/CardCollection;"));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",45);}
case 45:{f.StackOp("pop");f.Pc=46;continue;}
case 46:{f.Push(JValue.I(1));f.Pc=47;continue;}
case 47:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6436(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","()V","invokevirtual",10);}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/game/trigger/TriggerHandler","collectTriggerForWaiting","()V","invokevirtual",20);}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithList","table","Lforge/game/card/CardZoneTable;"));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",28);}
case 28:{return rt.Call(f,"forge/game/Game","copyLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/card/CardZoneTable","setLastStateBattlefield","(Lforge/game/card/CardCollectionView;)V","invokevirtual",34);}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithList","table","Lforge/game/card/CardZoneTable;"));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",42);}
case 42:{return rt.Call(f,"forge/game/Game","copyLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/game/card/CardZoneTable","setLastStateGraveyard","(Lforge/game/card/CardCollectionView;)V","invokevirtual",48);}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/cost/CostPartWithList","handleBeforePayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;)V","invokevirtual",55);}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/cost/CostPartWithList","canPayListAtOnce","()Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int==0?128:62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",68);}
case 68:{f.Locals[5]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[5]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",77);}
case 77:{f.Pc=f.Pop().Int==0?108:80;continue;}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",87);}
case 87:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=90;continue;}
case 90:{f.Locals[6]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithList","lkiList","Lforge/game/card/CardCollection;"));f.Pc=96;continue;}
case 96:{f.Push(f.Locals[6]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",101);}
case 101:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",104);}
case 104:{f.StackOp("pop");f.Pc=105;continue;}
case 105:{f.Pc=70;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithList","cardList","Lforge/game/card/CardCollection;"));f.Pc=112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[3]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[4]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/cost/CostPartWithList","doListPayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;Z)Lforge/game/card/CardCollectionView;","invokevirtual",121);}
case 121:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",124);}
case 124:{f.StackOp("pop");f.Pc=125;continue;}
case 125:{f.Pc=172;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",134);}
case 134:{f.Locals[5]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[5]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",143);}
case 143:{f.Pc=f.Pop().Int==0?172:146;continue;}
case 146:{f.Push(f.Locals[5]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",153);}
case 153:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=156;continue;}
case 156:{f.Locals[6]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[0]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[2]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[6]);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[4]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/cost/CostPartWithList","executePayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Z)Z","invokevirtual",168);}
case 168:{f.StackOp("pop");f.Pc=169;continue;}
case 169:{f.Pc=136;continue;}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[1]);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[2]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[3]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/cost/CostPartWithList","handleChangeZoneTrigger","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;)V","invokevirtual",179);}
case 179:{f.Push(JValue.I(1));f.Pc=180;continue;}
case 180:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6438(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6439(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6442(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/PaymentDecision","cards","Lforge/game/card/CardCollection;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[4]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/CostPartWithList","executePayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;Z)Z","invokevirtual",12);}
case 12:{f.StackOp("pop");f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/cost/CostPartWithList","reportPaidCardsTo","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",18);}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6443(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6444(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithList","table","Lforge/game/card/CardZoneTable;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardZoneTable","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?11:10;continue;}
case 10:{return JStep.ReturnVoid;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartWithList","table","Lforge/game/card/CardZoneTable;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",19);}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",23);}
case 23:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
