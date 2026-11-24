// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C542{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostPartMana","forge/game/cost/CostPart",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("cost","Lforge/card/mana/ManaCost;",false,JValue.Default("Lforge/card/mana/ManaCost;"),null));
c.Add(new JField("xMin","I",false,JValue.Default("I"),null));
c.Add(new JField("isExiledCreatureCost","Z",false,JValue.Default("Z"),null));
c.Add(new JField("isEnchantedCreatureCost","Z",false,JValue.Default("Z"),null));
c.Add(new JField("isCostPayAnyNumberOfTimes","Z",false,JValue.Default("Z"),null));
c.Add(new JField("maxWaterbend","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(6409,"forge/game/cost/CostPartMana","paymentOrder","()I",1,1,1,new JHandler[]{},M6409));
c.Add(new JMethod(6410,"forge/game/cost/CostPartMana","shouldPayLast","()Z",1,1,1,new JHandler[]{},M6410));
c.Add(new JMethod(6411,"forge/game/cost/CostPartMana","<init>","(Lforge/card/mana/ManaCost;Ljava/lang/String;)V",1,3,3,new JHandler[]{},M6411));
c.Add(new JMethod(6412,"forge/game/cost/CostPartMana","<init>","(Lforge/card/mana/ManaCost;ZZI)V",1,5,2,new JHandler[]{},M6412));
c.Add(new JMethod(6413,"forge/game/cost/CostPartMana","getMaxWaterbend","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6413));
c.Add(new JMethod(6414,"forge/game/cost/CostPartMana","setMaxWaterbend","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M6414));
c.Add(new JMethod(6415,"forge/game/cost/CostPartMana","getMana","()Lforge/card/mana/ManaCost;",17,1,1,new JHandler[]{},M6415));
c.Add(new JMethod(6416,"forge/game/cost/CostPartMana","getAmountOfX","()I",17,1,1,new JHandler[]{},M6416));
c.Add(new JMethod(6417,"forge/game/cost/CostPartMana","getXMin","()I",1,1,1,new JHandler[]{},M6417));
c.Add(new JMethod(6418,"forge/game/cost/CostPartMana","isExiledCreatureCost","()Z",1,1,1,new JHandler[]{},M6418));
c.Add(new JMethod(6419,"forge/game/cost/CostPartMana","isEnchantedCreatureCost","()Z",1,1,1,new JHandler[]{},M6419));
c.Add(new JMethod(6420,"forge/game/cost/CostPartMana","isReusable","()Z",1,1,1,new JHandler[]{},M6420));
c.Add(new JMethod(6421,"forge/game/cost/CostPartMana","isUndoable","()Z",1,1,1,new JHandler[]{},M6421));
c.Add(new JMethod(6422,"forge/game/cost/CostPartMana","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6422));
c.Add(new JMethod(6423,"forge/game/cost/CostPartMana","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,4,1,new JHandler[]{},M6423));
c.Add(new JMethod(6424,"forge/game/cost/CostPartMana","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6424));
c.Add(new JMethod(6425,"forge/game/cost/CostPartMana","getManaCostFor","(Lforge/game/spellability/SpellAbility;)Lforge/card/mana/ManaCost;",1,5,3,new JHandler[]{},M6425));
c.Add(new JMethod(6426,"forge/game/cost/CostPartMana","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",1,7,6,new JHandler[]{},M6426));
}

internal static JStep M6409(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostPartMana","shouldPayLast","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?13:7;continue;}
case 7:{f.Push(JValue.I(200));f.Pc=10;continue;}
case 10:{f.Pc=14;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6410(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartMana","isExiledCreatureCost","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6411(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostPart","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartMana","xMin","I",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartMana","isExiledCreatureCost","Z",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartMana","isEnchantedCreatureCost","Z",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartMana","isCostPayAnyNumberOfTimes","Z",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartMana","cost","Lforge/card/mana/ManaCost;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Reference==null?54:33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("XMin")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int==0?54:42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(JValue.I(4));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",48);}
case 48:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",51);}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartMana","xMin","I",value);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("Exiled")));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",61);}
case 61:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartMana","isExiledCreatureCost","Z",value);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("EnchantedCost")));f.Pc=67;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",71);}
case 71:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartMana","isEnchantedCreatureCost","Z",value);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("NumTimes")));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",81);}
case 81:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartMana","isCostPayAnyNumberOfTimes","Z",value);f.Pc=84;continue;}
case 84:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6412(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostPart","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartMana","xMin","I",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartMana","isExiledCreatureCost","Z",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartMana","isEnchantedCreatureCost","Z",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartMana","isCostPayAnyNumberOfTimes","Z",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartMana","cost","Lforge/card/mana/ManaCost;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartMana","xMin","I",value);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartMana","isExiledCreatureCost","Z",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartMana","isEnchantedCreatureCost","Z",value);f.Pc=45;continue;}
case 45:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6413(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartMana","maxWaterbend","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6414(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPartMana","maxWaterbend","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6415(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartMana","cost","Lforge/card/mana/ManaCost;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6416(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartMana","cost","Lforge/card/mana/ManaCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/mana/ManaCost","countX","()I","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6417(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartMana","xMin","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6418(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartMana","isExiledCreatureCost","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6419(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartMana","isEnchantedCreatureCost","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6420(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6421(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6422(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartMana","cost","Lforge/card/mana/ManaCost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/mana/ManaCost","toString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6423(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6424(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostPartMana;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6425(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostPartMana","isExiledCreatureCost","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?79:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("Exiled")));f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPaidList","(Ljava/lang/String;Z)Lforge/game/card/CardCollection;","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Reference==null?79:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("Exiled")));f.Pc=20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPaidList","(Ljava/lang/String;Z)Lforge/game/card/CardCollection;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int!=0?79:30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("Exiled")));f.Pc=33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPaidList","(Ljava/lang/String;Z)Lforge/game/card/CardCollection;","invokevirtual",37);}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",47);}
case 47:{f.Locals[2]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/card/mana/ManaCost","isNoCost","()Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int==0?57:55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{return JStep.Return(f.Pop());}
case 57:{if(!rt.EnsureInitialized(f,"forge/game/mana/ManaCostBeingPaid"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/ManaCostBeingPaid")));f.Pc=60;continue;}
case 60:{f.StackOp("dup");f.Pc=61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/cost/CostPartMana","getMana","()Lforge/card/mana/ManaCost;","invokevirtual",65);}
case 65:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","<init>","(Lforge/card/mana/ManaCost;)V","invokespecial",68);}
case 68:{f.Locals[3]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","addManaCost","(Lforge/card/mana/ManaCost;)V","invokevirtual",74);}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","toManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",78);}
case 78:{return JStep.Return(f.Pop());}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/cost/CostPartMana","isEnchantedCreatureCost","()Z","invokevirtual",83);}
case 83:{f.Pc=f.Pop().Int==0?138:86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",90);}
case 90:{return rt.Call(f,"forge/game/card/Card","isEnchantingCard","()Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int==0?138:96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",100);}
case 100:{return rt.Call(f,"forge/game/card/Card","getEnchantingCard","()Lforge/game/card/Card;","invokevirtual",103);}
case 103:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",106);}
case 106:{f.Locals[2]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[2]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/card/mana/ManaCost","isNoCost","()Z","invokevirtual",111);}
case 111:{f.Pc=f.Pop().Int==0?116:114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{return JStep.Return(f.Pop());}
case 116:{if(!rt.EnsureInitialized(f,"forge/game/mana/ManaCostBeingPaid"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/ManaCostBeingPaid")));f.Pc=119;continue;}
case 119:{f.StackOp("dup");f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/cost/CostPartMana","getMana","()Lforge/card/mana/ManaCost;","invokevirtual",124);}
case 124:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","<init>","(Lforge/card/mana/ManaCost;)V","invokespecial",127);}
case 127:{f.Locals[3]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[2]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","addManaCost","(Lforge/card/mana/ManaCost;)V","invokevirtual",133);}
case 133:{f.Push(f.Locals[3]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","toManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",137);}
case 137:{return JStep.Return(f.Pop());}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPartMana","isCostPayAnyNumberOfTimes","Z"));f.Pc=142;continue;}
case 142:{f.Pc=f.Pop().Int==0?208:145;continue;}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",149);}
case 149:{f.Push(f.Locals[1]);f.Pc=150;continue;}
case 150:{f.Push(JValue.R(rt.String("NumTimes")));f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",155);}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",159);}
case 159:{f.Locals[2]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[2]);f.Pc=161;continue;}
case 161:{f.Pc=f.Pop().Int!=0?168:164;continue;}
case 164:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"));f.Pc=167;continue;}
case 167:{return JStep.Return(f.Pop());}
case 168:{if(!rt.EnsureInitialized(f,"forge/game/mana/ManaCostBeingPaid"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/ManaCostBeingPaid")));f.Pc=171;continue;}
case 171:{f.StackOp("dup");f.Pc=172;continue;}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/cost/CostPartMana","getMana","()Lforge/card/mana/ManaCost;","invokevirtual",176);}
case 176:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","<init>","(Lforge/card/mana/ManaCost;)V","invokespecial",179);}
case 179:{f.Locals[3]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(JValue.I(1));f.Pc=181;continue;}
case 181:{f.Locals[4]=f.Pop();f.Pc=183;continue;}
case 183:{f.Push(f.Locals[4]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[2]);f.Pc=186;continue;}
case 186:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?203:189;continue;}
case 189:{f.Push(f.Locals[3]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[0]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/cost/CostPartMana","getMana","()Lforge/card/mana/ManaCost;","invokevirtual",194);}
case 194:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","addManaCost","(Lforge/card/mana/ManaCost;)V","invokevirtual",197);}
case 197:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=200;continue;}
case 200:{f.Pc=183;continue;}
case 203:{f.Push(f.Locals[3]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","toManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",207);}
case 207:{return JStep.Return(f.Pop());}
case 208:{f.Push(f.Locals[0]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/cost/CostPartMana","getMana","()Lforge/card/mana/ManaCost;","invokevirtual",212);}
case 212:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6426(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","clearManaPaid","()V","invokevirtual",4);}
case 4:{if(!rt.EnsureInitialized(f,"forge/game/mana/ManaConversionMatrix"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/ManaConversionMatrix")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/mana/ManaConversionMatrix","<init>","()V","invokespecial",11);}
case 11:{f.Locals[5]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[5]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/mana/ManaConversionMatrix","restoreColorReplacements","()V","invokevirtual",18);}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/mana/ManaConversionMatrix","applyCardMatrix","(Lforge/game/mana/ManaConversionMatrix;)V","invokevirtual",27);}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",31);}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(null));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/PaymentDecision","matrix","Lforge/game/mana/ManaConversionMatrix;"));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/player/PlayerController","payManaCost","(Lforge/game/cost/CostPartMana;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/mana/ManaConversionMatrix;Z)Z","invokevirtual",43);}
case 43:{f.Locals[6]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",49);}
case 49:{return rt.Call(f,"forge/game/mana/ManaPool","restoreColorReplacements","()V","invokevirtual",52);}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",56);}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/mana/ManaPool","applyCardMatrix","(Lforge/game/mana/ManaConversionMatrix;)V","invokevirtual",61);}
case 61:{f.Push(f.Locals[6]);f.Pc=63;continue;}
case 63:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
