// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C535{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostExiledMoveToGrave","forge/game/cost/CostPartWithList",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JMethod(6336,"forge/game/cost/CostExiledMoveToGrave","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",1,4,4,new JHandler[]{},M6336));
c.Add(new JMethod(6337,"forge/game/cost/CostExiledMoveToGrave","paymentOrder","()I",1,1,1,new JHandler[]{},M6337));
c.Add(new JMethod(6338,"forge/game/cost/CostExiledMoveToGrave","getMaxAmountX","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/lang/Integer;",1,6,5,new JHandler[]{},M6338));
c.Add(new JMethod(6339,"forge/game/cost/CostExiledMoveToGrave","toString","()Ljava/lang/String;",17,4,4,new JHandler[]{},M6339));
c.Add(new JMethod(6340,"forge/game/cost/CostExiledMoveToGrave","getHashForLKIList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6340));
c.Add(new JMethod(6341,"forge/game/cost/CostExiledMoveToGrave","getHashForCardList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6341));
c.Add(new JMethod(6342,"forge/game/cost/CostExiledMoveToGrave","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,5,4,new JHandler[]{},M6342));
c.Add(new JMethod(6343,"forge/game/cost/CostExiledMoveToGrave","doPayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Z)Lforge/game/card/Card;",4,6,4,new JHandler[]{},M6343));
c.Add(new JMethod(6344,"forge/game/cost/CostExiledMoveToGrave","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6344));
}

internal static JStep M6336(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/CostPartWithList","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6337(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(15));f.Pc=2;continue;}
case 2:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6338(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",10);}
case 10:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",16);}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/cost/CostExiledMoveToGrave","getType","()Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Push(JValue.R(rt.String(";")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",29);}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",36);}
case 36:{f.Locals[5]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",45);}
case 45:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",48);}
case 48:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6339(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/CostExiledMoveToGrave","convertAmount","()Ljava/lang/Integer;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Put ")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/cost/CostExiledMoveToGrave","getTypeDescription","()Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Reference!=null?34:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/cost/CostExiledMoveToGrave","getType","()Ljava/lang/String;","invokevirtual",31);}
case 31:{f.Pc=38;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/cost/CostExiledMoveToGrave","getTypeDescription","()Ljava/lang/String;","invokevirtual",38);}
case 38:{f.Locals[3]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/cost/CostExiledMoveToGrave","getAmount","()Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/cost/Cost","convertAmountTypeToWords","(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",49);}
case 49:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String(" from exile into that player's graveyard")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",64);}
case 64:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6340(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("MovedToGrave")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6341(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("MovedToGraveCards")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6342(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/CostExiledMoveToGrave","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",5);}
case 5:{f.Locals[4]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/cost/CostExiledMoveToGrave","getMaxAmountX","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/lang/Integer;","invokevirtual",14);}
case 14:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",17);}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?26:22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{f.Pc=27;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6343(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",3);}
case 3:{f.Locals[5]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[5]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostExiledMoveToGrave","table","Lforge/game/card/CardZoneTable;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",14);}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",21);}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(null));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/GameAction","moveToGraveyard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",28);}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6344(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostExiledMoveToGrave;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
