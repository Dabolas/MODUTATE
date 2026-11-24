// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C551{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostPutCounter","forge/game/cost/CostPartWithList",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("counter","Lforge/game/card/CounterType;",false,JValue.Default("Lforge/game/card/CounterType;"),null));
c.Add(new JField("counterTable","Lforge/game/GameEntityCounterTable;",false,JValue.Default("Lforge/game/GameEntityCounterTable;"),null));
c.Add(new JMethod(6501,"forge/game/cost/CostPutCounter","getCounter","()Lforge/game/card/CounterType;",17,1,1,new JHandler[]{},M6501));
c.Add(new JMethod(6502,"forge/game/cost/CostPutCounter","<init>","(Ljava/lang/String;Lforge/game/card/CounterType;Ljava/lang/String;Ljava/lang/String;)V",1,5,4,new JHandler[]{},M6502));
c.Add(new JMethod(6503,"forge/game/cost/CostPutCounter","paymentOrder","()I",1,1,1,new JHandler[]{},M6503));
c.Add(new JMethod(6504,"forge/game/cost/CostPutCounter","isReusable","()Z",1,1,2,new JHandler[]{},M6504));
c.Add(new JMethod(6505,"forge/game/cost/CostPutCounter","toString","()Ljava/lang/String;",1,4,4,new JHandler[]{},M6505));
c.Add(new JMethod(6506,"forge/game/cost/CostPutCounter","refund","(Lforge/game/card/Card;)V",17,5,4,new JHandler[]{},M6506));
c.Add(new JMethod(6507,"forge/game/cost/CostPutCounter","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,8,6,new JHandler[]{},M6507));
c.Add(new JMethod(6508,"forge/game/cost/CostPutCounter","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",1,5,5,new JHandler[]{},M6508));
c.Add(new JMethod(6509,"forge/game/cost/CostPutCounter","doPayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Z)Lforge/game/card/Card;",4,7,5,new JHandler[]{},M6509));
c.Add(new JMethod(6510,"forge/game/cost/CostPutCounter","getHashForLKIList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6510));
c.Add(new JMethod(6511,"forge/game/cost/CostPutCounter","getHashForCardList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6511));
c.Add(new JMethod(6512,"forge/game/cost/CostPutCounter","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6512));
c.Add(new JMethod(6513,"forge/game/cost/CostPutCounter","triggerCounterPutAll","(Lforge/game/spellability/SpellAbility;Z)V",4,4,6,new JHandler[]{},M6513));
c.Add(new JMethod(6514,"forge/game/cost/CostPutCounter","resetLists","()V",1,1,1,new JHandler[]{},M6514));
c.Add(new JMethod(6515,"forge/game/cost/CostPutCounter","isETBReplacement","(Lforge/game/spellability/SpellAbility;Z)Z",4,4,3,new JHandler[]{},M6515));
}

internal static JStep M6501(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCounter","counter","Lforge/game/card/CounterType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6502(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[4]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/cost/CostPartWithList","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPutCounter","counterTable","Lforge/game/GameEntityCounterTable;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPutCounter","counter","Lforge/game/card/CounterType;",value);f.Pc=24;continue;}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6503(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(6));f.Pc=2;continue;}
case 2:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6504(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCounter","counter","Lforge/game/card/CounterType;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","M1M1","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","M1M1","Lforge/game/card/CounterEnumType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/CounterType","is","(Lforge/game/card/CounterEnumType;)Z","invokeinterface",12);}
case 12:{f.Pc=f.Pop().Int!=0?19:15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{f.Pc=20;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6505(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCounter","counter","Lforge/game/card/CounterType;"));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/CounterType","is","(Lforge/game/card/CounterEnumType;)Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?62:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/cost/CostPutCounter","getAmount","()Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Push(JValue.R(rt.String("0")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?45:35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("0")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Pc=152;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("+")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",51);}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/cost/CostPutCounter","getAmount","()Ljava/lang/String;","invokevirtual",55);}
case 55:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",58);}
case 58:{f.StackOp("pop");f.Pc=59;continue;}
case 59:{f.Pc=152;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("Put ")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",68);}
case 68:{f.StackOp("pop");f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/cost/CostPutCounter","convertAmount","()Ljava/lang/Integer;","invokevirtual",73);}
case 73:{f.Locals[2]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/cost/CostPutCounter","getAmount","()Ljava/lang/String;","invokevirtual",80);}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCounter","counter","Lforge/game/card/CounterType;"));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",89);}
case 89:{return rt.DynamicCall(f,"forge/game/cost/CostPutCounter:6505:89:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",94);}
case 94:{return rt.Call(f,"forge/game/cost/Cost","convertAmountTypeToWords","(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",97);}
case 97:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",100);}
case 100:{f.StackOp("pop");f.Pc=101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String(" on ")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",107);}
case 107:{f.StackOp("pop");f.Pc=108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/cost/CostPutCounter","payCostFromSource","()Z","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Int==0?127:115;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/cost/CostPutCounter","getType","()Ljava/lang/String;","invokevirtual",120);}
case 120:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",123);}
case 123:{f.StackOp("pop");f.Pc=124;continue;}
case 124:{f.Pc=152;continue;}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/cost/CostPutCounter","getTypeDescription","()Ljava/lang/String;","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Reference!=null?141:134;continue;}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/cost/CostPutCounter","getType","()Ljava/lang/String;","invokevirtual",138);}
case 138:{f.Pc=145;continue;}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/cost/CostPutCounter","getTypeDescription","()Ljava/lang/String;","invokevirtual",145);}
case 145:{f.Locals[3]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[3]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",151);}
case 151:{f.StackOp("pop");f.Pc=152;continue;}
case 152:{f.Push(f.Locals[1]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",156);}
case 156:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6506(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostPutCounter","convertAmount","()Ljava/lang/Integer;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/cost/CostPutCounter","getCardList","()Lforge/game/card/CardCollectionView;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?53:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCounter","counter","Lforge/game/card/CounterType;"));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",45);}
case 45:{f.Push(JValue.R(null));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/Card","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",49);}
case 49:{f.StackOp("pop");f.Pc=50;continue;}
case 50:{f.Pc=15;continue;}
case 53:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6507(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[4]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",11);}
case 11:{f.Locals[5]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/cost/CostPutCounter","payCostFromSource","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?146:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/cost/CostPutCounter","isETBReplacement","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int==0?108:29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",34);}
case 34:{f.Locals[6]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[6]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/game/card/Card","setLastKnownZone","(Lforge/game/zone/Zone;)V","invokevirtual",48);}
case 48:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=51;continue;}
case 51:{f.StackOp("dup");f.Pc=52;continue;}
case 52:{f.Push(f.Locals[6]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",57);}
case 57:{f.Locals[7]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[5]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",64);}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{f.Push(JValue.I(1));f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(0));f.Pc=71;continue;}
case 71:{f.Push(f.Locals[6]);f.Pc=73;continue;}
case 73:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=74;continue;}
case 74:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","([Ljava/lang/Object;)Ljava/util/HashSet;","invokestatic",77);}
case 77:{f.Push(f.Locals[7]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(ZLjava/util/Set;Lforge/game/card/CardCollectionView;)V","invokevirtual",82);}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",87);}
case 87:{f.Push(JValue.I(0));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(Z)V","invokevirtual",91);}
case 91:{f.Push(f.Locals[6]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/cost/CostPutCounter","getCounter","()Lforge/game/card/CounterType;","invokevirtual",97);}
case 97:{return rt.Call(f,"forge/game/card/Card","canReceiveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int==0?105:103;continue;}
case 103:{f.Push(JValue.I(1));f.Pc=104;continue;}
case 104:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 105:{f.Pc=132;continue;}
case 108:{f.Push(f.Locals[4]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int!=0?118:116;continue;}
case 116:{f.Push(JValue.I(0));f.Pc=117;continue;}
case 117:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 118:{f.Push(f.Locals[4]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/cost/CostPutCounter","getCounter","()Lforge/game/card/CounterType;","invokevirtual",124);}
case 124:{return rt.Call(f,"forge/game/card/Card","canReceiveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",127);}
case 127:{f.Pc=f.Pop().Int==0?132:130;continue;}
case 130:{f.Push(JValue.I(1));f.Pc=131;continue;}
case 131:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/cost/CostPutCounter","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",137);}
case 137:{f.Pc=f.Pop().Int!=0?144:140;continue;}
case 140:{f.Push(JValue.I(1));f.Pc=141;continue;}
case 141:{f.Pc=145;continue;}
case 144:{f.Push(JValue.I(0));f.Pc=145;continue;}
case 145:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 146:{f.Push(f.Locals[4]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",151);}
case 151:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",157);}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/cost/CostPutCounter","getType","()Ljava/lang/String;","invokevirtual",161);}
case 161:{f.Push(JValue.R(rt.String(";")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",166);}
case 166:{f.Push(f.Locals[2]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[4]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[1]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",173);}
case 173:{f.Locals[6]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[6]);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[0]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/cost/CostPutCounter","getCounter","()Lforge/game/card/CounterType;","invokevirtual",181);}
case 181:{return rt.Call(f,"forge/game/card/CardPredicates","canReceiveCounters","(Lforge/game/card/CounterType;)Ljava/util/function/Predicate;","invokestatic",184);}
case 184:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",187);}
case 187:{f.Locals[6]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[6]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",196);}
case 196:{f.Pc=f.Pop().Int!=0?203:199;continue;}
case 199:{f.Push(JValue.I(1));f.Pc=200;continue;}
case 200:{f.Pc=204;continue;}
case 203:{f.Push(JValue.I(0));f.Pc=204;continue;}
case 204:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6508(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/cost/CostPartWithList","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z","invokespecial",9);}
case 9:{f.StackOp("pop");f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/cost/CostPutCounter","triggerCounterPutAll","(Lforge/game/spellability/SpellAbility;Z)V","invokevirtual",17);}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6509(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/CostPutCounter","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",5);}
case 5:{f.Locals[5]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[4]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/cost/CostPutCounter","isETBReplacement","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?46:17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntityCounterTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Locals[6]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[6]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/cost/CostPutCounter","getCounter","()Lforge/game/card/CounterType;","invokevirtual",37);}
case 37:{f.Push(f.Locals[5]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/GameEntityCounterTable","put","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)I","invokevirtual",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{f.Pc=61;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/cost/CostPutCounter","getCounter","()Lforge/game/card/CounterType;","invokevirtual",51);}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCounter","counterTable","Lforge/game/GameEntityCounterTable;"));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",61);}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6510(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("CounterPut")));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6511(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("CounterPutCards")));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6512(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostPutCounter;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6513(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCounter","counterTable","Lforge/game/GameEntityCounterTable;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameEntityCounterTable","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?11:10;continue;}
case 10:{return JStep.ReturnVoid;}
case 11:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCounter","counterTable","Lforge/game/GameEntityCounterTable;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","(Lcom/google/common/collect/Table;)V","invokespecial",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",28);}
case 28:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",31);}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{f.Push(JValue.R(null));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;ZZLjava/util/Map;)Z","invokevirtual",38);}
case 38:{f.StackOp("pop");f.Pc=39;continue;}
case 39:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6514(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostPartWithList","resetLists","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCounter","counterTable","Lforge/game/GameEntityCounterTable;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/GameEntityCounterTable","clear","()V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6515(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int!=0?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/cost/CostPutCounter","payCostFromSource","()Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int!=0?15:13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Pc=f.Pop().Reference!=null?21:19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int!=0?30:28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacementEffect","()Lforge/game/replacement/ReplacementEffect;","invokevirtual",34);}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getMode","()Lforge/game/replacement/ReplacementType;","invokevirtual",39);}
case 39:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Moved","Lforge/game/replacement/ReplacementType;"));f.Pc=42;continue;}
case 42:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?47:45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",51);}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",58);}
case 58:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int!=0?66:64;continue;}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 66:{f.Push(JValue.I(1));f.Pc=67;continue;}
case 67:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
