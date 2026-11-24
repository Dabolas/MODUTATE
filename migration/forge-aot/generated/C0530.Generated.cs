// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C530{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostDraw","forge/game/cost/CostPart",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JMethod(6292,"forge/game/cost/CostDraw","<init>","(Ljava/lang/String;Ljava/lang/String;)V",1,3,4,new JHandler[]{},M6292));
c.Add(new JMethod(6293,"forge/game/cost/CostDraw","paymentOrder","()I",1,1,1,new JHandler[]{},M6293));
c.Add(new JMethod(6294,"forge/game/cost/CostDraw","toString","()Ljava/lang/String;",17,3,4,new JHandler[]{},M6294));
c.Add(new JMethod(6295,"forge/game/cost/CostDraw","getPotentialPlayers","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;",1,9,5,new JHandler[]{},M6295));
c.Add(new JMethod(6296,"forge/game/cost/CostDraw","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,4,3,new JHandler[]{},M6296));
c.Add(new JMethod(6297,"forge/game/cost/CostDraw","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",17,9,4,new JHandler[]{},M6297));
c.Add(new JMethod(6298,"forge/game/cost/CostDraw","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6298));
}

internal static JStep M6292(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/CostPart","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6293(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(20));f.Pc=2;continue;}
case 2:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6294(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/CostDraw","convertAmount","()Ljava/lang/Integer;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Draw ")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/cost/CostDraw","getAmount","()Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Push(JValue.R(rt.String("Card")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/cost/Cost","convertAmountTypeToWords","(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",29);}
case 29:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",32);}
case 32:{f.StackOp("pop");f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",37);}
case 37:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6295(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/CostDraw","getType","()Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Locals[4]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",18);}
case 18:{f.Locals[5]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/cost/CostDraw","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",25);}
case 25:{f.Locals[6]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",34);}
case 34:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",37);}
case 37:{f.Locals[7]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[7]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",46);}
case 46:{f.Pc=f.Pop().Int==0?95:49;continue;}
case 49:{f.Push(f.Locals[7]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{f.Locals[8]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[8]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/player/Player","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?92:75;continue;}
case 75:{f.Push(f.Locals[8]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[6]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/player/Player","canDraw","(I)Z","invokevirtual",82);}
case 82:{f.Pc=f.Pop().Int==0?92:85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[8]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/player/PlayerCollection","add","(Ljava/lang/Object;)Z","invokevirtual",91);}
case 91:{f.StackOp("pop");f.Pc=92;continue;}
case 92:{f.Pc=39;continue;}
case 95:{f.Push(f.Locals[3]);f.Pc=96;continue;}
case 96:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6296(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/cost/CostDraw","getPotentialPlayers","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/game/player/PlayerCollection","isEmpty","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int!=0?16:12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Pc=17;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6297(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",9);}
case 9:{f.Locals[6]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[6]);f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[6]);f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/Game","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",37);}
case 37:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/PaymentDecision","players","Ljava/util/List;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",52);}
case 52:{f.Locals[7]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[7]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",61);}
case 61:{f.Pc=f.Pop().Int==0?92:64;continue;}
case 64:{f.Push(f.Locals[7]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",71);}
case 71:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=74;continue;}
case 74:{f.Locals[8]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[8]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/PaymentDecision","c","I"));f.Pc=82;continue;}
case 82:{f.Push(f.Locals[3]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/player/Player","drawCards","(ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",88);}
case 88:{f.StackOp("pop");f.Pc=89;continue;}
case 89:{f.Pc=54;continue;}
case 92:{f.Push(JValue.I(1));f.Pc=93;continue;}
case 93:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6298(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostDraw;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
