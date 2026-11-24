// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C548{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostPayment","forge/game/mana/ManaConversionMatrix",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cost","Lforge/game/cost/Cost;",false,JValue.Default("Lforge/game/cost/Cost;"),null));
c.Add(new JField("adjustedCost","Lforge/game/cost/Cost;",false,JValue.Default("Lforge/game/cost/Cost;"),null));
c.Add(new JField("ability","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JField("paidCostParts","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(6470,"forge/game/cost/CostPayment","getCost","()Lforge/game/cost/Cost;",17,1,1,new JHandler[]{},M6470));
c.Add(new JMethod(6471,"forge/game/cost/CostPayment","getAbility","()Lforge/game/spellability/SpellAbility;",17,1,1,new JHandler[]{},M6471));
c.Add(new JMethod(6472,"forge/game/cost/CostPayment","<init>","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;)V",1,3,2,new JHandler[]{},M6472));
c.Add(new JMethod(6473,"forge/game/cost/CostPayment","canPayAdditionalCosts","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Z)Z",9,3,4,new JHandler[]{},M6473));
c.Add(new JMethod(6474,"forge/game/cost/CostPayment","canPayAdditionalCosts","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;ZLforge/game/player/Player;)Z",9,4,4,new JHandler[]{},M6474));
c.Add(new JMethod(6475,"forge/game/cost/CostPayment","isFullyPaid","()Z",17,1,2,new JHandler[]{},M6475));
c.Add(new JMethod(6476,"forge/game/cost/CostPayment","refundPayment","()V",17,4,3,new JHandler[]{},M6476));
c.Add(new JMethod(6477,"forge/game/cost/CostPayment","payCost","(Lforge/game/cost/CostDecisionMakerBase;)Z",1,9,5,new JHandler[]{new JHandler(93,156,190,""),new JHandler(167,179,190,""),new JHandler(190,192,190,"")},M6477));
c.Add(new JMethod(6478,"forge/game/cost/CostPayment","payComputerCosts","(Lforge/game/cost/CostDecisionMakerBase;)Z",17,11,5,new JHandler[]{new JHandler(102,146,170,""),new JHandler(170,172,170,""),new JHandler(228,274,314,""),new JHandler(286,302,314,""),new JHandler(314,316,314,"")},M6478));
c.Add(new JMethod(6479,"forge/game/cost/CostPayment","getMana","(Lforge/game/player/Player;Lforge/card/mana/ManaCostShard;Lforge/game/spellability/SpellAbility;BLjava/util/Map;)Lforge/game/mana/Mana;",9,15,5,new JHandler[]{},M6479));
c.Add(new JMethod(6480,"forge/game/cost/CostPayment","selectManaToPayFor","(Lforge/game/mana/ManaPool;Lforge/card/mana/ManaCostShard;Lforge/game/spellability/SpellAbility;BLjava/util/Map;)Ljava/util/List;",10,9,4,new JHandler[]{},M6480));
c.Add(new JMethod(6481,"forge/game/cost/CostPayment","handleOfferings","(Lforge/game/spellability/SpellAbility;ZZ)Z",9,7,5,new JHandler[]{},M6481));
}

internal static JStep M6470(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","cost","Lforge/game/cost/Cost;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6471(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6472(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/mana/ManaConversionMatrix","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPayment","paidCostParts","Ljava/util/List;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPayment","cost","Lforge/game/cost/Cost;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPayment","adjustedCost","Lforge/game/cost/Cost;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPayment","ability","Lforge/game/spellability/SpellAbility;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/cost/CostPayment","restoreColorReplacements","()V","invokevirtual",30);}
case 30:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6473(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/cost/CostPayment","canPayAdditionalCosts","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;ZLforge/game/player/Player;)Z","invokestatic",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6474(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/CostAdjustment","adjust","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Z)Lforge/game/cost/Cost;","invokestatic",12);}
case 12:{f.Locals[0]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/cost/Cost","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z","invokevirtual",20);}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6475(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","paidCostParts","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","adjustedCost","Lforge/game/cost/Cost;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/cost/Cost","getCostParts","()Ljava/util/List;","invokevirtual",11);}
case 11:{return rt.Call(f,"java/util/List","containsAll","(Ljava/util/Collection;)Z","invokeinterface",16);}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6476(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","paidCostParts","Ljava/util/List;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?59:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/cost/CostPart","refund","(Lforge/game/card/Card;)V","invokevirtual",42);}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPartWithList")?1:0));f.Pc=46;continue;}
case 46:{f.Pc=f.Pop().Int==0?56:49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPartWithList"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/cost/CostPartWithList","resetLists","()V","invokevirtual",56);}
case 56:{f.Pc=18;continue;}
case 59:{if(!rt.EnsureInitialized(f,"forge/game/mana/ManaRefundService"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/ManaRefundService")));f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/mana/ManaRefundService","<init>","(Lforge/game/spellability/SpellAbility;)V","invokespecial",70);}
case 70:{return rt.Call(f,"forge/game/mana/ManaRefundService","refundManaPaid","()V","invokevirtual",73);}
case 73:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6477(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","cost","Lforge/game/cost/Cost;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/cost/CostAdjustment","adjust","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Z)Lforge/game/cost/Cost;","invokestatic",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPayment","adjustedCost","Lforge/game/cost/Cost;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","adjustedCost","Lforge/game/cost/Cost;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/cost/Cost","getCostPartsWithZeroMana","()Ljava/util/List;","invokevirtual",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","adjustedCost","Lforge/game/cost/Cost;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/cost/Cost","getCostParts","()Ljava/util/List;","invokevirtual",34);}
case 34:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",39);}
case 39:{f.Push(JValue.I(1));f.Pc=40;continue;}
case 40:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?55:43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","getPlayer","()Lforge/game/player/Player;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",50);}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/player/PlayerController","orderCosts","(Ljava/util/List;)Ljava/util/List;","invokevirtual",54);}
case 54:{f.Locals[2]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","getPlayer","()Lforge/game/player/Player;","invokevirtual",59);}
case 59:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",62);}
case 62:{f.Locals[3]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",69);}
case 69:{f.Locals[4]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",78);}
case 78:{f.Pc=f.Pop().Int==0?206:81;continue;}
case 81:{f.Push(f.Locals[4]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",88);}
case 88:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=91;continue;}
case 91:{f.Locals[5]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[3]);f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;"));f.Pc=97;continue;}
case 97:{f.Push(f.Locals[5]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/zone/CostPaymentStack","push","(Lforge/game/cost/CostPart;Lforge/game/cost/CostPayment;)Lforge/game/zone/CostPaymentStack$Entry;","invokevirtual",103);}
case 103:{f.StackOp("pop");f.Pc=104;continue;}
case 104:{f.Push(f.Locals[5]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[1]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/cost/CostPart","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;","invokevirtual",110);}
case 110:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/PaymentDecision"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=113;continue;}
case 113:{f.Locals[6]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[6]);f.Pc=117;continue;}
case 117:{f.Pc=f.Pop().Reference==null?126:120;continue;}
case 120:{f.Push(f.Locals[6]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/PaymentDecision","matrix","Lforge/game/mana/ManaConversionMatrix;",value);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[6]);f.Pc=128;continue;}
case 128:{f.Pc=f.Pop().Reference==null?153:131;continue;}
case 131:{f.Push(f.Locals[5]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","getPlayer","()Lforge/game/player/Player;","invokevirtual",137);}
case 137:{f.Push(f.Locals[6]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=143;continue;}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",147);}
case 147:{return rt.Call(f,"forge/game/cost/CostPart","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",150);}
case 150:{f.Pc=f.Pop().Int!=0?167:153;continue;}
case 153:{f.Push(JValue.I(0));f.Pc=154;continue;}
case 154:{f.Locals[7]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[3]);f.Pc=157;continue;}
case 157:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;"));f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/zone/CostPaymentStack","pop","()Lforge/game/zone/CostPaymentStack$Entry;","invokevirtual",163);}
case 163:{f.StackOp("pop");f.Pc=164;continue;}
case 164:{f.Push(f.Locals[7]);f.Pc=166;continue;}
case 166:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 167:{f.Push(f.Locals[0]);f.Pc=168;continue;}
case 168:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","paidCostParts","Ljava/util/List;"));f.Pc=171;continue;}
case 171:{f.Push(f.Locals[5]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",178);}
case 178:{f.StackOp("pop");f.Pc=179;continue;}
case 179:{f.Push(f.Locals[3]);f.Pc=180;continue;}
case 180:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;"));f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/zone/CostPaymentStack","pop","()Lforge/game/zone/CostPaymentStack$Entry;","invokevirtual",186);}
case 186:{f.StackOp("pop");f.Pc=187;continue;}
case 187:{f.Pc=203;continue;}
case 190:{f.Locals[8]=f.Pop();f.Pc=192;continue;}
case 192:{f.Push(f.Locals[3]);f.Pc=193;continue;}
case 193:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;"));f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/zone/CostPaymentStack","pop","()Lforge/game/zone/CostPaymentStack$Entry;","invokevirtual",199);}
case 199:{f.StackOp("pop");f.Pc=200;continue;}
case 200:{f.Push(f.Locals[8]);f.Pc=202;continue;}
case 202:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 203:{f.Pc=71;continue;}
case 206:{f.Push(f.Locals[0]);f.Pc=207;continue;}
case 207:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","paidCostParts","Ljava/util/List;"));f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",215);}
case 215:{f.Locals[4]=f.Pop();f.Pc=217;continue;}
case 217:{f.Push(f.Locals[4]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",224);}
case 224:{f.Pc=f.Pop().Int==0?262:227;continue;}
case 227:{f.Push(f.Locals[4]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",234);}
case 234:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=237;continue;}
case 237:{f.Locals[5]=f.Pop();f.Pc=239;continue;}
case 239:{f.Push(f.Locals[5]);f.Pc=241;continue;}
case 241:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPartWithList")?1:0));f.Pc=244;continue;}
case 244:{f.Pc=f.Pop().Int==0?259:247;continue;}
case 247:{f.Push(f.Locals[5]);f.Pc=249;continue;}
case 249:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPartWithList"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=252;continue;}
case 252:{f.Locals[6]=f.Pop();f.Pc=254;continue;}
case 254:{f.Push(f.Locals[6]);f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/game/cost/CostPartWithList","resetLists","()V","invokevirtual",259);}
case 259:{f.Pc=217;continue;}
case 262:{f.Push(JValue.I(1));f.Pc=263;continue;}
case 263:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6478(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Reference!=null?21:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","getPlayer","()Lforge/game/player/Player;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",21);}
case 21:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",24);}
case 24:{f.Locals[2]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","cost","Lforge/game/cost/Cost;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",37);}
case 37:{return rt.Call(f,"forge/game/cost/CostAdjustment","adjust","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;Z)Lforge/game/cost/Cost;","invokestatic",40);}
case 40:{return rt.Call(f,"forge/game/cost/Cost","getCostPartsWithZeroMana","()Ljava/util/List;","invokevirtual",43);}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","getPlayer","()Lforge/game/player/Player;","invokevirtual",48);}
case 48:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",51);}
case 51:{f.Locals[4]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",59);}
case 59:{f.Locals[5]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",68);}
case 68:{f.Pc=f.Pop().Int==0?198:71;continue;}
case 71:{f.Push(f.Locals[5]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",78);}
case 78:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=81;continue;}
case 81:{f.Locals[6]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/cost/CostPart","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;","invokevirtual",89);}
case 89:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/PaymentDecision"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=92;continue;}
case 92:{f.Locals[7]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(JValue.R(null));f.Pc=95;continue;}
case 95:{f.Push(f.Locals[7]);f.Pc=97;continue;}
case 97:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?102:100;continue;}
case 100:{f.Push(JValue.I(0));f.Pc=101;continue;}
case 101:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 102:{f.Push(f.Locals[4]);f.Pc=104;continue;}
case 104:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;"));f.Pc=107;continue;}
case 107:{f.Push(f.Locals[6]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/zone/CostPaymentStack","push","(Lforge/game/cost/CostPart;Lforge/game/cost/CostPayment;)Lforge/game/zone/CostPaymentStack$Entry;","invokevirtual",113);}
case 113:{f.StackOp("pop");f.Pc=114;continue;}
case 114:{f.Push(f.Locals[1]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","paysRightAfterDecision","()Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int==0?158:121;continue;}
case 121:{f.Push(f.Locals[6]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","getPlayer","()Lforge/game/player/Player;","invokevirtual",127);}
case 127:{f.Push(f.Locals[7]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=133;continue;}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",137);}
case 137:{return rt.Call(f,"forge/game/cost/CostPart","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",140);}
case 140:{f.Pc=f.Pop().Int!=0?158:143;continue;}
case 143:{f.Push(JValue.I(0));f.Pc=144;continue;}
case 144:{f.Locals[8]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[4]);f.Pc=148;continue;}
case 148:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;"));f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/zone/CostPaymentStack","pop","()Lforge/game/zone/CostPaymentStack$Entry;","invokevirtual",154);}
case 154:{f.StackOp("pop");f.Pc=155;continue;}
case 155:{f.Push(f.Locals[8]);f.Pc=157;continue;}
case 157:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 158:{f.Push(f.Locals[4]);f.Pc=160;continue;}
case 160:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;"));f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/zone/CostPaymentStack","pop","()Lforge/game/zone/CostPaymentStack$Entry;","invokevirtual",166);}
case 166:{f.StackOp("pop");f.Pc=167;continue;}
case 167:{f.Pc=184;continue;}
case 170:{f.Locals[9]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(f.Locals[4]);f.Pc=174;continue;}
case 174:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;"));f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/zone/CostPaymentStack","pop","()Lforge/game/zone/CostPaymentStack$Entry;","invokevirtual",180);}
case 180:{f.StackOp("pop");f.Pc=181;continue;}
case 181:{f.Push(f.Locals[9]);f.Pc=183;continue;}
case 183:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 184:{f.Push(f.Locals[2]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[6]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[7]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",194);}
case 194:{f.StackOp("pop");f.Pc=195;continue;}
case 195:{f.Pc=61;continue;}
case 198:{f.Push(f.Locals[3]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",204);}
case 204:{f.Locals[5]=f.Pop();f.Pc=206;continue;}
case 206:{f.Push(f.Locals[5]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",213);}
case 213:{f.Pc=f.Pop().Int==0?331:216;continue;}
case 216:{f.Push(f.Locals[5]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",223);}
case 223:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=226;continue;}
case 226:{f.Locals[6]=f.Pop();f.Pc=228;continue;}
case 228:{f.Push(f.Locals[4]);f.Pc=230;continue;}
case 230:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;"));f.Pc=233;continue;}
case 233:{f.Push(f.Locals[6]);f.Pc=235;continue;}
case 235:{f.Push(f.Locals[0]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/game/zone/CostPaymentStack","push","(Lforge/game/cost/CostPart;Lforge/game/cost/CostPayment;)Lforge/game/zone/CostPaymentStack$Entry;","invokevirtual",239);}
case 239:{f.StackOp("pop");f.Pc=240;continue;}
case 240:{f.Push(f.Locals[6]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[1]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","getPlayer","()Lforge/game/player/Player;","invokevirtual",246);}
case 246:{f.Push(f.Locals[2]);f.Pc=247;continue;}
case 247:{f.Push(f.Locals[6]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",254);}
case 254:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/PaymentDecision"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[0]);f.Pc=258;continue;}
case 258:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPayment","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=261;continue;}
case 261:{f.Push(f.Locals[1]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/cost/CostDecisionMakerBase","isEffect","()Z","invokevirtual",265);}
case 265:{return rt.Call(f,"forge/game/cost/CostPart","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",268);}
case 268:{f.Pc=f.Pop().Int!=0?286:271;continue;}
case 271:{f.Push(JValue.I(0));f.Pc=272;continue;}
case 272:{f.Locals[7]=f.Pop();f.Pc=274;continue;}
case 274:{f.Push(f.Locals[4]);f.Pc=276;continue;}
case 276:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;"));f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/zone/CostPaymentStack","pop","()Lforge/game/zone/CostPaymentStack$Entry;","invokevirtual",282);}
case 282:{f.StackOp("pop");f.Pc=283;continue;}
case 283:{f.Push(f.Locals[7]);f.Pc=285;continue;}
case 285:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 286:{f.Push(f.Locals[6]);f.Pc=288;continue;}
case 288:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPartWithList")?1:0));f.Pc=291;continue;}
case 291:{f.Pc=f.Pop().Int==0?302:294;continue;}
case 294:{f.Push(f.Locals[6]);f.Pc=296;continue;}
case 296:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPartWithList"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/game/cost/CostPartWithList","resetLists","()V","invokevirtual",302);}
case 302:{f.Push(f.Locals[4]);f.Pc=304;continue;}
case 304:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;"));f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/game/zone/CostPaymentStack","pop","()Lforge/game/zone/CostPaymentStack$Entry;","invokevirtual",310);}
case 310:{f.StackOp("pop");f.Pc=311;continue;}
case 311:{f.Pc=328;continue;}
case 314:{f.Locals[10]=f.Pop();f.Pc=316;continue;}
case 316:{f.Push(f.Locals[4]);f.Pc=318;continue;}
case 318:{f.Push(rt.GetField(f.Pop(),"forge/game/Game","costPaymentStack","Lforge/game/zone/CostPaymentStack;"));f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/zone/CostPaymentStack","pop","()Lforge/game/zone/CostPaymentStack$Entry;","invokevirtual",324);}
case 324:{f.StackOp("pop");f.Pc=325;continue;}
case 325:{f.Push(f.Locals[10]);f.Pc=327;continue;}
case 327:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 328:{f.Pc=206;continue;}
case 331:{f.Push(JValue.I(1));f.Pc=332;continue;}
case 332:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6479(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[4]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/CostPayment","selectManaToPayFor","(Lforge/game/mana/ManaPool;Lforge/card/mana/ManaCostShard;Lforge/game/spellability/SpellAbility;BLjava/util/Map;)Ljava/util/List;","invokestatic",12);}
case 12:{f.Locals[5]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[5]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?26:24;continue;}
case 24:{f.Push(JValue.R(null));f.Pc=25;continue;}
case 25:{return JStep.Return(f.Pop());}
case 26:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",33);}
case 33:{f.Locals[6]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(JValue.I(int.MinValue));f.Pc=37;continue;}
case 37:{f.Locals[7]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",46);}
case 46:{f.Locals[8]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[8]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int==0?189:58;continue;}
case 58:{f.Push(f.Locals[8]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{f.Locals[9]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[9]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",75);}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",81);}
case 81:{f.Locals[10]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[9]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",88);}
case 88:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=91;continue;}
case 91:{f.Locals[11]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[10]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[7]);f.Pc=97;continue;}
case 97:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?111:100;continue;}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",107);}
case 107:{f.Push(f.Locals[10]);f.Pc=109;continue;}
case 109:{f.Locals[7]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[10]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[7]);f.Pc=115;continue;}
case 115:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?186:118;continue;}
case 118:{f.Push(JValue.I(0));f.Pc=119;continue;}
case 119:{f.Locals[12]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[6]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",128);}
case 128:{f.Locals[13]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[13]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",137);}
case 137:{f.Pc=f.Pop().Int==0?171:140;continue;}
case 140:{f.Push(f.Locals[13]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",147);}
case 147:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=150;continue;}
case 150:{f.Locals[14]=f.Pop();f.Pc=152;continue;}
case 152:{f.Push(f.Locals[14]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[11]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/mana/Mana","equals","(Ljava/lang/Object;)Z","invokevirtual",159);}
case 159:{f.Pc=f.Pop().Int==0?168:162;continue;}
case 162:{f.Push(JValue.I(1));f.Pc=163;continue;}
case 163:{f.Locals[12]=f.Pop();f.Pc=165;continue;}
case 165:{f.Pc=171;continue;}
case 168:{f.Pc=130;continue;}
case 171:{f.Push(f.Locals[12]);f.Pc=173;continue;}
case 173:{f.Pc=f.Pop().Int!=0?186:176;continue;}
case 176:{f.Push(f.Locals[6]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[11]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",185);}
case 185:{f.StackOp("pop");f.Pc=186;continue;}
case 186:{f.Pc=48;continue;}
case 189:{f.Push(f.Locals[6]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",196);}
case 196:{f.Push(JValue.I(1));f.Pc=197;continue;}
case 197:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?212:200;continue;}
case 200:{f.Push(f.Locals[6]);f.Pc=202;continue;}
case 202:{f.Push(JValue.I(0));f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",208);}
case 208:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=211;continue;}
case 211:{return JStep.Return(f.Pop());}
case 212:{f.Push(f.Locals[0]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",216);}
case 216:{f.Push(f.Locals[6]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/game/player/PlayerController","chooseManaFromPool","(Ljava/util/List;)Lforge/game/mana/Mana;","invokevirtual",221);}
case 221:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6480(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",13);}
case 13:{return rt.Call(f,"java/util/ArrayList","iterator","()Ljava/util/Iterator;","invokevirtual",16);}
case 16:{f.Locals[6]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[6]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?242:28;continue;}
case 28:{f.Push(f.Locals[6]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[7]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","COLORED_X","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","COLORED_X","Lforge/card/mana/ManaCostShard;"));f.Pc=44;continue;}
case 44:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?66:47;continue;}
case 47:{f.Push(f.Locals[7]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",52);}
case 52:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",55);}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","canColoredXShardBePaidByColor","(Ljava/lang/String;Ljava/util/Map;)Z","invokestatic",60);}
case 60:{f.Pc=f.Pop().Int!=0?66:63;continue;}
case 63:{f.Pc=18;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[7]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",73);}
case 73:{return rt.Call(f,"forge/game/mana/ManaPool","canPayForShardWithColor","(Lforge/card/mana/ManaCostShard;B)Z","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int!=0?82:79;continue;}
case 79:{f.Pc=18;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/card/mana/ManaCostShard","isSnow","()Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int==0?100:89;continue;}
case 89:{f.Push(f.Locals[7]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/mana/Mana","isSnow","()Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int!=0?100:97;continue;}
case 97:{f.Pc=18;continue;}
case 100:{f.Push(f.Locals[7]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/mana/Mana","getManaAbility","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Reference==null?129:108;continue;}
case 108:{f.Push(f.Locals[7]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/mana/Mana","getManaAbility","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",113);}
case 113:{f.Push(f.Locals[2]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[1]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[7]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",120);}
case 120:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","meetsSpellAndShardRestrictions","(Lforge/game/spellability/SpellAbility;Lforge/card/mana/ManaCostShard;B)Z","invokevirtual",123);}
case 123:{f.Pc=f.Pop().Int!=0?129:126;continue;}
case 126:{f.Pc=18;continue;}
case 129:{f.Push(f.Locals[2]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[7]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/mana/Mana","getSourceCard","()Lforge/game/card/Card;","invokevirtual",135);}
case 135:{f.Push(f.Locals[7]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",140);}
case 140:{return rt.Call(f,"forge/game/spellability/SpellAbility","allowsPayingWithShard","(Lforge/game/card/Card;B)Z","invokevirtual",143);}
case 143:{f.Pc=f.Pop().Int!=0?149:146;continue;}
case 146:{f.Pc=18;continue;}
case 149:{f.Push(JValue.I(0));f.Pc=150;continue;}
case 150:{f.Locals[8]=f.Pop();f.Pc=152;continue;}
case 152:{f.Push(f.Locals[3]);f.Pc=153;continue;}
case 153:{f.Push(JValue.I(-1));f.Pc=154;continue;}
case 154:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?178:157;continue;}
case 157:{f.Push(f.Locals[8]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[7]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/mana/Mana","isColorless","()Z","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Int==0?171:167;continue;}
case 167:{f.Push(JValue.I(5));f.Pc=168;continue;}
case 168:{f.Pc=172;continue;}
case 171:{f.Push(JValue.I(0));f.Pc=172;continue;}
case 172:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=173;continue;}
case 173:{f.Locals[8]=f.Pop();f.Pc=175;continue;}
case 175:{f.Pc=199;continue;}
case 178:{f.Push(f.Locals[8]);f.Pc=180;continue;}
case 180:{f.Push(f.Locals[7]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",185);}
case 185:{f.Push(f.Locals[3]);f.Pc=186;continue;}
case 186:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=187;continue;}
case 187:{f.Push(f.Locals[3]);f.Pc=188;continue;}
case 188:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?195:191;continue;}
case 191:{f.Push(JValue.I(5));f.Pc=192;continue;}
case 192:{f.Pc=196;continue;}
case 195:{f.Push(JValue.I(0));f.Pc=196;continue;}
case 196:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=197;continue;}
case 197:{f.Locals[8]=f.Pop();f.Pc=199;continue;}
case 199:{f.Push(f.Locals[7]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/game/mana/Mana","isRestricted","()Z","invokevirtual",204);}
case 204:{f.Pc=f.Pop().Int==0?210:207;continue;}
case 207:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(2)));f.Pc=210;continue;}
case 210:{f.Push(f.Locals[7]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/mana/Mana","isSnow","()Z","invokevirtual",215);}
case 215:{f.Pc=f.Pop().Int!=0?221:218;continue;}
case 218:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=221;continue;}
case 221:{f.Push(f.Locals[5]);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[7]);f.Pc=225;continue;}
case 225:{f.Push(f.Locals[8]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",230);}
case 230:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",233);}
case 233:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",238);}
case 238:{f.StackOp("pop");f.Pc=239;continue;}
case 239:{f.Pc=18;continue;}
case 242:{f.Push(f.Locals[5]);f.Pc=244;continue;}
case 244:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6481(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",16);}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/Game","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;)V","invokespecial",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",28);}
case 28:{f.Locals[5]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[5]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",37);}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOffering","()Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?101:44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSacrificedAsOffering","()Lforge/game/card/Card;","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Reference!=null?53:51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSacrificedAsOffering","()Lforge/game/card/Card;","invokevirtual",57);}
case 57:{f.Locals[6]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[6]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/Card","setUsedToPay","(Z)V","invokevirtual",65);}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Int==0?76:69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","resetSacrificedAsOffering","()V","invokevirtual",73);}
case 73:{f.Pc=101;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{f.Pc=f.Pop().Int==0?101:80;continue;}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",84);}
case 84:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=87;continue;}
case 87:{f.StackOp("dup");f.Pc=88;continue;}
case 88:{f.Push(f.Locals[6]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",93);}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(JValue.I(0));f.Pc=95;continue;}
case 95:{f.Push(f.Locals[5]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/GameAction","sacrifice","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Lforge/game/card/CardCollection;","invokevirtual",100);}
case 100:{f.StackOp("pop");f.Pc=101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/spellability/SpellAbility","isEmerge","()Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int==0?175:108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSacrificedAsEmerge","()Lforge/game/card/Card;","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Reference!=null?117:115;continue;}
case 115:{f.Push(JValue.I(0));f.Pc=116;continue;}
case 116:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSacrificedAsEmerge","()Lforge/game/card/Card;","invokevirtual",121);}
case 121:{f.Locals[6]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[6]);f.Pc=125;continue;}
case 125:{f.Push(JValue.I(0));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/card/Card","setUsedToPay","(Z)V","invokevirtual",129);}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{f.Pc=f.Pop().Int==0?140:133;continue;}
case 133:{f.Push(f.Locals[0]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/spellability/SpellAbility","resetSacrificedAsEmerge","()V","invokevirtual",137);}
case 137:{f.Pc=175;continue;}
case 140:{f.Push(f.Locals[2]);f.Pc=141;continue;}
case 141:{f.Pc=f.Pop().Int==0?175:144;continue;}
case 144:{f.Push(f.Locals[3]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",148);}
case 148:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=151;continue;}
case 151:{f.StackOp("dup");f.Pc=152;continue;}
case 152:{f.Push(f.Locals[6]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",157);}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{f.Push(JValue.I(0));f.Pc=159;continue;}
case 159:{f.Push(f.Locals[5]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/GameAction","sacrifice","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Lforge/game/card/CardCollection;","invokevirtual",164);}
case 164:{f.StackOp("pop");f.Pc=165;continue;}
case 165:{f.Push(f.Locals[0]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[3]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[6]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/Game","getChangeZoneLKIInfo","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",172);}
case 172:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSacrificedAsEmerge","(Lforge/game/card/Card;)V","invokevirtual",175);}
case 175:{f.Push(f.Locals[4]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/card/CardZoneTable","isEmpty","()Z","invokevirtual",180);}
case 180:{f.Pc=f.Pop().Int!=0?196:183;continue;}
case 183:{f.Push(f.Locals[4]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[0]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",189);}
case 189:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",192);}
case 192:{f.Push(f.Locals[0]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",196);}
case 196:{f.Push(JValue.I(1));f.Pc=197;continue;}
case 197:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
