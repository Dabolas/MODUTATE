// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C518{
internal static JClass Build(){var c=new JClass("forge/game/cost/Cost","java/lang/Object",new string[]{"java/io/Serializable"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("isAbility","Z",false,JValue.Default("Z"),null));
c.Add(new JField("costParts","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("isMandatory","Z",false,JValue.Default("Z"),null));
c.Add(new JField("tapCost","Z",false,JValue.Default("Z"),null));
c.Add(new JField("NUM_NAMES","[Ljava/lang/String;",true,JValue.Default("[Ljava/lang/String;"),null));
c.Add(new JField("Zero","Lforge/game/cost/Cost;",true,JValue.Default("Lforge/game/cost/Cost;"),null));
c.Add(new JMethod(6165,"forge/game/cost/Cost","hasTapCost","()Z",17,1,1,new JHandler[]{},M6165));
c.Add(new JMethod(6166,"forge/game/cost/Cost","cacheTapCost","()V",2,1,3,new JHandler[]{},M6166));
c.Add(new JMethod(6167,"forge/game/cost/Cost","hasNoManaCost","()Z",17,1,1,new JHandler[]{},M6167));
c.Add(new JMethod(6168,"forge/game/cost/Cost","hasManaCost","()Z",17,1,1,new JHandler[]{},M6168));
c.Add(new JMethod(6169,"forge/game/cost/Cost","isFree","()Z",17,1,1,new JHandler[]{},M6169));
c.Add(new JMethod(6170,"forge/game/cost/Cost","movesCardToOrFromLibrary","()Z",17,1,1,new JHandler[]{},M6170));
c.Add(new JMethod(6171,"forge/game/cost/Cost","hasSpecificCostType","(Ljava/lang/Class;)Z",17,4,2,new JHandler[]{},M6171));
c.Add(new JMethod(6172,"forge/game/cost/Cost","hasOnlySpecificCostType","(Ljava/lang/Class;)Z",17,4,2,new JHandler[]{},M6172));
c.Add(new JMethod(6173,"forge/game/cost/Cost","getCostPartByType","(Ljava/lang/Class;)Lforge/game/cost/CostPart;",1,4,2,new JHandler[]{},M6173));
c.Add(new JMethod(6174,"forge/game/cost/Cost","getCostParts","()Ljava/util/List;",17,1,1,new JHandler[]{},M6174));
c.Add(new JMethod(6175,"forge/game/cost/Cost","sort","()V",1,1,2,new JHandler[]{},M6175));
c.Add(new JMethod(6176,"forge/game/cost/Cost","getCostPartsWithZeroMana","()Ljava/util/List;",17,2,5,new JHandler[]{},M6176));
c.Add(new JMethod(6177,"forge/game/cost/Cost","isOnlyManaCost","()Z",17,3,1,new JHandler[]{},M6177));
c.Add(new JMethod(6178,"forge/game/cost/Cost","getTotalMana","()Lforge/card/mana/ManaCost;",17,2,1,new JHandler[]{},M6178));
c.Add(new JMethod(6179,"forge/game/cost/Cost","isMandatory","()Z",17,1,1,new JHandler[]{},M6179));
c.Add(new JMethod(6180,"forge/game/cost/Cost","setMandatory","(Z)V",17,2,2,new JHandler[]{},M6180));
c.Add(new JMethod(6181,"forge/game/cost/Cost","isAbility","()Z",17,1,1,new JHandler[]{},M6181));
c.Add(new JMethod(6182,"forge/game/cost/Cost","getMaxWaterbend","()Ljava/lang/String;",17,3,1,new JHandler[]{},M6182));
c.Add(new JMethod(6183,"forge/game/cost/Cost","<init>","()V",2,1,2,new JHandler[]{},M6183));
c.Add(new JMethod(6184,"forge/game/cost/Cost","<init>","(I)V",2,2,5,new JHandler[]{},M6184));
c.Add(new JMethod(6185,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V",1,3,5,new JHandler[]{},M6185));
c.Add(new JMethod(6186,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V",1,3,4,new JHandler[]{},M6186));
c.Add(new JMethod(6187,"forge/game/cost/Cost","<init>","(Ljava/lang/String;ZZ)V",1,16,5,new JHandler[]{},M6187));
c.Add(new JMethod(6188,"forge/game/cost/Cost","parseCostPart","(Ljava/lang/String;ZZ)Lforge/game/cost/CostPart;",10,8,11,new JHandler[]{},M6188));
c.Add(new JMethod(6189,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;",10,6,3,new JHandler[]{},M6189));
c.Add(new JMethod(6190,"forge/game/cost/Cost","copy","()Lforge/game/cost/Cost;",17,4,2,new JHandler[]{},M6190));
c.Add(new JMethod(6191,"forge/game/cost/Cost","copyWithNoMana","()Lforge/game/cost/Cost;",17,4,3,new JHandler[]{},M6191));
c.Add(new JMethod(6192,"forge/game/cost/Cost","copyWithDefinedMana","(Ljava/lang/String;)Lforge/game/cost/Cost;",17,2,4,new JHandler[]{},M6192));
c.Add(new JMethod(6193,"forge/game/cost/Cost","copyWithDefinedMana","(Lforge/card/mana/ManaCost;)Lforge/game/cost/Cost;",17,3,5,new JHandler[]{},M6193));
c.Add(new JMethod(6194,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;",17,3,1,new JHandler[]{},M6194));
c.Add(new JMethod(6195,"forge/game/cost/Cost","getCostEnergy","()Lforge/game/cost/CostPayEnergy;",17,3,1,new JHandler[]{},M6195));
c.Add(new JMethod(6196,"forge/game/cost/Cost","refundPaidCost","(Lforge/game/card/Card;)V",17,4,2,new JHandler[]{},M6196));
c.Add(new JMethod(6197,"forge/game/cost/Cost","isUndoable","()Z",17,3,1,new JHandler[]{},M6197));
c.Add(new JMethod(6198,"forge/game/cost/Cost","isReusuableResource","()Z",17,3,1,new JHandler[]{},M6198));
c.Add(new JMethod(6199,"forge/game/cost/Cost","isRenewableResource","()Z",17,3,1,new JHandler[]{},M6199));
c.Add(new JMethod(6200,"forge/game/cost/Cost","toString","()Ljava/lang/String;",17,1,2,new JHandler[]{},M6200));
c.Add(new JMethod(6201,"forge/game/cost/Cost","toStringAlt","()Ljava/lang/String;",17,1,2,new JHandler[]{},M6201));
c.Add(new JMethod(6202,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;",17,5,2,new JHandler[]{},M6202));
c.Add(new JMethod(6203,"forge/game/cost/Cost","spellToString","(Z)Ljava/lang/String;",2,6,2,new JHandler[]{},M6203));
c.Add(new JMethod(6204,"forge/game/cost/Cost","abilityToString","()Ljava/lang/String;",2,6,3,new JHandler[]{},M6204));
c.Add(new JMethod(6205,"forge/game/cost/Cost","convertAmountTypeToWords","(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",9,3,2,new JHandler[]{},M6205));
c.Add(new JMethod(6206,"forge/game/cost/Cost","convertIntAndTypeToWords","(ILjava/lang/String;)Ljava/lang/String;",9,6,4,new JHandler[]{},M6206));
c.Add(new JMethod(6207,"forge/game/cost/Cost","convertAmountTypeToWords","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",9,3,2,new JHandler[]{},M6207));
c.Add(new JMethod(6208,"forge/game/cost/Cost","mergeTo","(Lforge/game/cost/Cost;ILforge/game/spellability/SpellAbility;)V",1,6,4,new JHandler[]{},M6208));
c.Add(new JMethod(6209,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;",1,2,3,new JHandler[]{},M6209));
c.Add(new JMethod(6210,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;Z)Lforge/game/cost/Cost;",1,3,4,new JHandler[]{},M6210));
c.Add(new JMethod(6211,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;ZLforge/game/spellability/SpellAbility;)Lforge/game/cost/Cost;",1,14,11,new JHandler[]{},M6211));
c.Add(new JMethod(6212,"forge/game/cost/Cost","applyTextChangeEffects","(Lforge/game/CardTraitBase;)V",17,4,2,new JHandler[]{},M6212));
c.Add(new JMethod(6213,"forge/game/cost/Cost","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",1,6,4,new JHandler[]{},M6213));
c.Add(new JMethod(6214,"forge/game/cost/Cost","hasXInAnyCostPart","()Z",1,4,2,new JHandler[]{},M6214));
c.Add(new JMethod(6215,"forge/game/cost/Cost","getMaxForNonManaX","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/lang/Integer;",1,7,7,new JHandler[]{},M6215));
c.Add(new JMethod(6216,"forge/game/cost/Cost","lambda$sort$0","(Lforge/game/cost/CostPart;Lforge/game/cost/CostPart;)I",4106,2,2,new JHandler[]{},M6216));
c.Add(new JMethod(6217,"forge/game/cost/Cost","<clinit>","()V",8,0,4,new JHandler[]{},M6217));
}

internal static JStep M6165(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","tapCost","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6166(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.ClassObject("forge/game/cost/CostTap")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/Cost","hasSpecificCostType","(Ljava/lang/Class;)Z","invokevirtual",7);}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","tapCost","Z",value);f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6167(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference!=null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6168(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6169(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/cost/Cost","getTotalMana","()Lforge/card/mana/ManaCost;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/card/mana/ManaCost","isZero","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6170(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/LibraryMovementCostVisitor","movesCardToOrFromLibrary","(Lforge/game/cost/Cost;)Z","invokestatic",4);}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6171(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/Cost","getCostParts","()Ljava/util/List;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?42:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/Class","isInstance","(Ljava/lang/Object;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?39:37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 39:{f.Pc=10;continue;}
case 42:{f.Push(JValue.I(0));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6172(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/Cost","getCostParts","()Ljava/util/List;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?42:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/Class","isInstance","(Ljava/lang/Object;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int!=0?39:37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 39:{f.Pc=10;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6173(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/Cost","getCostParts","()Ljava/util/List;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?42:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/Class","isInstance","(Ljava/lang/Object;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?39:37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return JStep.Return(f.Pop());}
case 39:{f.Pc=10;continue;}
case 42:{f.Push(JValue.R(null));f.Pc=43;continue;}
case 43:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6174(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6175(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.DynamicCall(f,"forge/game/cost/Cost:6175:4:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/Comparator;",9);}
case 9:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6176(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/Cost","hasManaCost","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?12:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",21);}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=23;continue;}
case 23:{return rt.Call(f,"com/google/common/collect/Lists","newArrayListWithCapacity","(I)Ljava/util/ArrayList;","invokestatic",26);}
case 26:{f.Locals[1]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPartMana"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPartMana")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"));f.Pc=46;continue;}
case 46:{f.Push(JValue.R(null));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/cost/CostPartMana","<init>","(Lforge/card/mana/ManaCost;Ljava/lang/String;)V","invokespecial",50);}
case 50:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6177(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?41:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPartMana")?1:0));f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Int!=0?38:36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 38:{f.Pc=10;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6178(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?15:9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","ZERO","Lforge/card/mana/ManaCost;"));f.Pc=12;continue;}
case 12:{f.Pc=19;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/cost/CostPartMana","getMana","()Lforge/card/mana/ManaCost;","invokevirtual",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6179(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","isMandatory","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6180(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","isMandatory","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6181(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","isAbility","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6182(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?47:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPartMana")?1:0));f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Int==0?44:36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPartMana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/cost/CostPartMana","getMaxWaterbend","()Ljava/lang/String;","invokevirtual",43);}
case 43:{return JStep.Return(f.Pop());}
case 44:{f.Pc=10;continue;}
case 47:{f.Push(JValue.R(null));f.Pc=48;continue;}
case 48:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6183(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","isAbility","Z",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","isMandatory","Z",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","tapCost","Z",value);f.Pc=26;continue;}
case 26:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6184(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","isAbility","Z",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","isMandatory","Z",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","tapCost","Z",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=30;continue;}
case 30:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPartMana"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPartMana")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/card/mana/ManaCost","get","(I)Lforge/card/mana/ManaCost;","invokestatic",38);}
case 38:{f.Push(JValue.R(null));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/cost/CostPartMana","<init>","(Lforge/card/mana/ManaCost;Ljava/lang/String;)V","invokespecial",42);}
case 42:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",47);}
case 47:{f.StackOp("pop");f.Pc=48;continue;}
case 48:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6185(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","isAbility","Z",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","isMandatory","Z",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","tapCost","Z",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","isAbility","Z",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=35;continue;}
case 35:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPartMana"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPartMana")));f.Pc=38;continue;}
case 38:{f.StackOp("dup");f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{f.Push(JValue.R(null));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/cost/CostPartMana","<init>","(Lforge/card/mana/ManaCost;Ljava/lang/String;)V","invokespecial",44);}
case 44:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",49);}
case 49:{f.StackOp("pop");f.Pc=50;continue;}
case 50:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6186(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;ZZ)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6187(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","isAbility","Z",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","isMandatory","Z",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","tapCost","Z",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","isAbility","Z",value);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("")));f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{f.Locals[5]=f.Pop();f.Pc=38;continue;}
case 38:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",45);}
case 45:{f.Locals[6]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(JValue.I(32));f.Pc=50;continue;}
case 50:{f.Push(JValue.I(60));f.Pc=52;continue;}
case 52:{f.Push(JValue.I(62));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;CCC)[Ljava/lang/String;","invokestatic",57);}
case 57:{f.Locals[7]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[7]);f.Pc=61;continue;}
case 61:{f.Locals[8]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[8]);f.Pc=65;continue;}
case 65:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=66;continue;}
case 66:{f.Locals[9]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{f.Locals[10]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[10]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[9]);f.Pc=75;continue;}
case 75:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?139:78;continue;}
case 78:{f.Push(f.Locals[8]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[10]);f.Pc=82;continue;}
case 82:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=83;continue;}
case 83:{f.Locals[11]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[11]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("T")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int!=0?105:95;continue;}
case 95:{f.Push(f.Locals[11]);f.Pc=97;continue;}
case 97:{f.Push(JValue.R(rt.String("Tap")));f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",102);}
case 102:{f.Pc=f.Pop().Int==0?110:105;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(JValue.I(1));f.Pc=107;continue;}
case 107:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","tapCost","Z",value);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[11]);f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("Q")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",117);}
case 117:{f.Pc=f.Pop().Int!=0?130:120;continue;}
case 120:{f.Push(f.Locals[11]);f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("Untap")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",127);}
case 127:{f.Pc=f.Pop().Int==0?133:130;continue;}
case 130:{f.Push(JValue.I(1));f.Pc=131;continue;}
case 131:{f.Locals[5]=f.Pop();f.Pc=133;continue;}
case 133:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=136;continue;}
case 136:{f.Pc=71;continue;}
case 139:{f.Push(JValue.R(null));f.Pc=140;continue;}
case 140:{f.Locals[8]=f.Pop();f.Pc=142;continue;}
case 142:{f.Push(f.Locals[7]);f.Pc=144;continue;}
case 144:{f.Locals[9]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[9]);f.Pc=148;continue;}
case 148:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=149;continue;}
case 149:{f.Locals[10]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(JValue.I(0));f.Pc=152;continue;}
case 152:{f.Locals[11]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[11]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[10]);f.Pc=158;continue;}
case 158:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?299:161;continue;}
case 161:{f.Push(f.Locals[9]);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[11]);f.Pc=165;continue;}
case 165:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=166;continue;}
case 166:{f.Locals[12]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[12]);f.Pc=170;continue;}
case 170:{f.Push(JValue.R(rt.String("XMin")));f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",175);}
case 175:{f.Pc=f.Pop().Int==0?185:178;continue;}
case 178:{f.Push(f.Locals[12]);f.Pc=180;continue;}
case 180:{f.Locals[4]=f.Pop();f.Pc=182;continue;}
case 182:{f.Pc=293;continue;}
case 185:{f.Push(JValue.R(rt.String("Mandatory")));f.Pc=187;continue;}
case 187:{f.Push(f.Locals[12]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",192);}
case 192:{f.Pc=f.Pop().Int==0?203:195;continue;}
case 195:{f.Push(f.Locals[0]);f.Pc=196;continue;}
case 196:{f.Push(JValue.I(1));f.Pc=197;continue;}
case 197:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","isMandatory","Z",value);f.Pc=200;continue;}
case 200:{f.Pc=293;continue;}
case 203:{f.Push(f.Locals[12]);f.Pc=205;continue;}
case 205:{f.Push(f.Locals[0]);f.Pc=206;continue;}
case 206:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","tapCost","Z"));f.Pc=209;continue;}
case 209:{f.Push(f.Locals[5]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/cost/Cost","parseCostPart","(Ljava/lang/String;ZZ)Lforge/game/cost/CostPart;","invokestatic",214);}
case 214:{f.Locals[13]=f.Pop();f.Pc=216;continue;}
case 216:{f.Push(JValue.R(null));f.Pc=217;continue;}
case 217:{f.Push(f.Locals[13]);f.Pc=219;continue;}
case 219:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?280:222;continue;}
case 222:{f.Push(f.Locals[13]);f.Pc=224;continue;}
case 224:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPartMana")?1:0));f.Pc=227;continue;}
case 227:{f.Pc=f.Pop().Int==0?244:230;continue;}
case 230:{f.Push(f.Locals[13]);f.Pc=232;continue;}
case 232:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPartMana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=235;continue;}
case 235:{f.Locals[14]=f.Pop();f.Pc=237;continue;}
case 237:{f.Push(f.Locals[14]);f.Pc=239;continue;}
case 239:{f.Locals[8]=f.Pop();f.Pc=241;continue;}
case 241:{f.Pc=293;continue;}
case 244:{f.Push(f.Locals[13]);f.Pc=246;continue;}
case 246:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPartWithList")?1:0));f.Pc=249;continue;}
case 249:{f.Pc=f.Pop().Int==0?265:252;continue;}
case 252:{f.Push(f.Locals[13]);f.Pc=254;continue;}
case 254:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPartWithList"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=257;continue;}
case 257:{f.Locals[15]=f.Pop();f.Pc=259;continue;}
case 259:{f.Push(f.Locals[15]);f.Pc=261;continue;}
case 261:{f.Push(f.Locals[3]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/cost/CostPartWithList","setIntrinsic","(Z)V","invokevirtual",265);}
case 265:{f.Push(f.Locals[0]);f.Pc=266;continue;}
case 266:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=269;continue;}
case 269:{f.Push(f.Locals[13]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",276);}
case 276:{f.StackOp("pop");f.Pc=277;continue;}
case 277:{f.Pc=293;continue;}
case 280:{f.Push(f.Locals[6]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[12]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",287);}
case 287:{f.Push(JValue.R(rt.String(" ")));f.Pc=289;continue;}
case 289:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",292);}
case 292:{f.StackOp("pop");f.Pc=293;continue;}
case 293:{f.Locals[11]=JValue.I(unchecked(f.Locals[11].Int+(1)));f.Pc=296;continue;}
case 296:{f.Pc=154;continue;}
case 299:{f.Push(f.Locals[8]);f.Pc=301;continue;}
case 301:{f.Pc=f.Pop().Reference!=null?355:304;continue;}
case 304:{f.Push(f.Locals[6]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",309);}
case 309:{f.Pc=f.Pop().Int>0?320:312;continue;}
case 312:{f.Push(f.Locals[4]);f.Pc=314;continue;}
case 314:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",317);}
case 317:{f.Pc=f.Pop().Int!=0?355:320;continue;}
case 320:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPartMana"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPartMana")));f.Pc=323;continue;}
case 323:{f.StackOp("dup");f.Pc=324;continue;}
case 324:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=327;continue;}
case 327:{f.StackOp("dup");f.Pc=328;continue;}
case 328:{f.Push(f.Locals[6]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",333);}
case 333:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(Ljava/lang/String;)V","invokespecial",336);}
case 336:{f.Push(f.Locals[4]);f.Pc=338;continue;}
case 338:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",341);}
case 341:{f.Pc=f.Pop().Int==0?348:344;continue;}
case 344:{f.Push(JValue.R(null));f.Pc=345;continue;}
case 345:{f.Pc=350;continue;}
case 348:{f.Push(f.Locals[4]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/game/cost/CostPartMana","<init>","(Lforge/card/mana/ManaCost;Ljava/lang/String;)V","invokespecial",353);}
case 353:{f.Locals[8]=f.Pop();f.Pc=355;continue;}
case 355:{f.Push(f.Locals[8]);f.Pc=357;continue;}
case 357:{f.Pc=f.Pop().Reference==null?372:360;continue;}
case 360:{f.Push(f.Locals[0]);f.Pc=361;continue;}
case 361:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=364;continue;}
case 364:{f.Push(f.Locals[8]);f.Pc=366;continue;}
case 366:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",371);}
case 371:{f.StackOp("pop");f.Pc=372;continue;}
case 372:{f.Push(f.Locals[0]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/game/cost/Cost","sort","()V","invokevirtual",376);}
case 376:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6188(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Mana<")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?57:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",14);}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=16;continue;}
case 16:{f.Push(JValue.I(92));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/TextUtil","split","(Ljava/lang/CharSequence;C)[Ljava/lang/String;","invokestatic",21);}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?34:28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=31;continue;}
case 31:{f.Pc=35;continue;}
case 34:{f.Push(JValue.R(null));f.Pc=35;continue;}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPartMana"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPartMana")));f.Pc=40;continue;}
case 40:{f.StackOp("dup");f.Pc=41;continue;}
case 41:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=44;continue;}
case 44:{f.StackOp("dup");f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(Ljava/lang/String;)V","invokespecial",51);}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/cost/CostPartMana","<init>","(Lforge/card/mana/ManaCost;Ljava/lang/String;)V","invokespecial",56);}
case 56:{return JStep.Return(f.Pop());}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("tapXType<")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?104:66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(JValue.I(3));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",71);}
case 71:{f.Locals[3]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=74;continue;}
case 74:{f.Push(JValue.I(2));f.Pc=75;continue;}
case 75:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?84:78;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{f.Push(JValue.I(2));f.Pc=80;continue;}
case 80:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=81;continue;}
case 81:{f.Pc=85;continue;}
case 84:{f.Push(JValue.R(null));f.Pc=85;continue;}
case 85:{f.Locals[4]=f.Pop();f.Pc=87;continue;}
case 87:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostTapType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostTapType")));f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(f.Locals[3]);f.Pc=92;continue;}
case 92:{f.Push(JValue.I(0));f.Pc=93;continue;}
case 93:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=94;continue;}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{f.Push(JValue.I(1));f.Pc=96;continue;}
case 96:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=97;continue;}
case 97:{f.Push(f.Locals[4]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/cost/CostTapType","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V","invokespecial",103);}
case 103:{return JStep.Return(f.Pop());}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.String("untapYType<")));f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",110);}
case 110:{f.Pc=f.Pop().Int==0?151:113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(JValue.I(3));f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",118);}
case 118:{f.Locals[3]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(f.Locals[3]);f.Pc=120;continue;}
case 120:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=121;continue;}
case 121:{f.Push(JValue.I(2));f.Pc=122;continue;}
case 122:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?131:125;continue;}
case 125:{f.Push(f.Locals[3]);f.Pc=126;continue;}
case 126:{f.Push(JValue.I(2));f.Pc=127;continue;}
case 127:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=128;continue;}
case 128:{f.Pc=132;continue;}
case 131:{f.Push(JValue.R(null));f.Pc=132;continue;}
case 132:{f.Locals[4]=f.Pop();f.Pc=134;continue;}
case 134:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostUntapType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostUntapType")));f.Pc=137;continue;}
case 137:{f.StackOp("dup");f.Pc=138;continue;}
case 138:{f.Push(f.Locals[3]);f.Pc=139;continue;}
case 139:{f.Push(JValue.I(0));f.Pc=140;continue;}
case 140:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=141;continue;}
case 141:{f.Push(f.Locals[3]);f.Pc=142;continue;}
case 142:{f.Push(JValue.I(1));f.Pc=143;continue;}
case 143:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=144;continue;}
case 144:{f.Push(f.Locals[4]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[2]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/cost/CostUntapType","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V","invokespecial",150);}
case 150:{return JStep.Return(f.Pop());}
case 151:{f.Push(f.Locals[0]);f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String("SubCounter<")));f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",157);}
case 157:{f.Pc=f.Pop().Int==0?274:160;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{f.Push(JValue.I(5));f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",165);}
case 165:{f.Locals[3]=f.Pop();f.Pc=166;continue;}
case 166:{f.Push(f.Locals[3]);f.Pc=167;continue;}
case 167:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=168;continue;}
case 168:{f.Push(JValue.I(2));f.Pc=169;continue;}
case 169:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?178:172;continue;}
case 172:{f.Push(f.Locals[3]);f.Pc=173;continue;}
case 173:{f.Push(JValue.I(2));f.Pc=174;continue;}
case 174:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=175;continue;}
case 175:{f.Pc=180;continue;}
case 178:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=180;continue;}
case 180:{f.Locals[4]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(f.Locals[3]);f.Pc=183;continue;}
case 183:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=184;continue;}
case 184:{f.Push(JValue.I(3));f.Pc=185;continue;}
case 185:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?194:188;continue;}
case 188:{f.Push(f.Locals[3]);f.Pc=189;continue;}
case 189:{f.Push(JValue.I(3));f.Pc=190;continue;}
case 190:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=191;continue;}
case 191:{f.Pc=195;continue;}
case 194:{f.Push(JValue.R(null));f.Pc=195;continue;}
case 195:{f.Locals[5]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(f.Locals[3]);f.Pc=198;continue;}
case 198:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=199;continue;}
case 199:{f.Push(JValue.I(4));f.Pc=200;continue;}
case 200:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?212:203;continue;}
case 203:{f.Push(f.Locals[3]);f.Pc=204;continue;}
case 204:{f.Push(JValue.I(4));f.Pc=205;continue;}
case 205:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",209);}
case 209:{f.Pc=225;continue;}
case 212:{f.Push(JValue.I(1));f.Pc=213;continue;}
case 213:{f.Push(JValue.R(rt.NewArray("Lforge/game/zone/ZoneType;",f.Pop().Int)));f.Pc=216;continue;}
case 216:{f.StackOp("dup");f.Pc=217;continue;}
case 217:{f.Push(JValue.I(0));f.Pc=218;continue;}
case 218:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=221;continue;}
case 221:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=222;continue;}
case 222:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",225);}
case 225:{f.Locals[6]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(JValue.I(0));f.Pc=228;continue;}
case 228:{f.Locals[7]=f.Pop();f.Pc=230;continue;}
case 230:{f.Push(f.Locals[3]);f.Pc=231;continue;}
case 231:{f.Push(JValue.I(0));f.Pc=232;continue;}
case 232:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=233;continue;}
case 233:{f.Push(JValue.R(rt.String("X1+")));f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",238);}
case 238:{f.Pc=f.Pop().Int==0?249:241;continue;}
case 241:{f.Push(JValue.I(1));f.Pc=242;continue;}
case 242:{f.Locals[7]=f.Pop();f.Pc=244;continue;}
case 244:{f.Push(f.Locals[3]);f.Pc=245;continue;}
case 245:{f.Push(JValue.I(0));f.Pc=246;continue;}
case 246:{f.Push(JValue.R(rt.String("X")));f.Pc=248;continue;}
case 248:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=249;continue;}
case 249:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostRemoveCounter"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostRemoveCounter")));f.Pc=252;continue;}
case 252:{f.StackOp("dup");f.Pc=253;continue;}
case 253:{f.Push(f.Locals[3]);f.Pc=254;continue;}
case 254:{f.Push(JValue.I(0));f.Pc=255;continue;}
case 255:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=256;continue;}
case 256:{f.Push(f.Locals[3]);f.Pc=257;continue;}
case 257:{f.Push(JValue.I(1));f.Pc=258;continue;}
case 258:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",262);}
case 262:{f.Push(f.Locals[4]);f.Pc=264;continue;}
case 264:{f.Push(f.Locals[5]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[6]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[7]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/cost/CostRemoveCounter","<init>","(Ljava/lang/String;Lforge/game/card/CounterType;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Z)V","invokespecial",273);}
case 273:{return JStep.Return(f.Pop());}
case 274:{f.Push(f.Locals[0]);f.Pc=275;continue;}
case 275:{f.Push(JValue.R(rt.String("AddCounter<")));f.Pc=277;continue;}
case 277:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",280);}
case 280:{f.Pc=f.Pop().Int==0?341:283;continue;}
case 283:{f.Push(f.Locals[0]);f.Pc=284;continue;}
case 284:{f.Push(JValue.I(4));f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",288);}
case 288:{f.Locals[3]=f.Pop();f.Pc=289;continue;}
case 289:{f.Push(f.Locals[3]);f.Pc=290;continue;}
case 290:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=291;continue;}
case 291:{f.Push(JValue.I(2));f.Pc=292;continue;}
case 292:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?301:295;continue;}
case 295:{f.Push(f.Locals[3]);f.Pc=296;continue;}
case 296:{f.Push(JValue.I(2));f.Pc=297;continue;}
case 297:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=298;continue;}
case 298:{f.Pc=303;continue;}
case 301:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=303;continue;}
case 303:{f.Locals[4]=f.Pop();f.Pc=305;continue;}
case 305:{f.Push(f.Locals[3]);f.Pc=306;continue;}
case 306:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=307;continue;}
case 307:{f.Push(JValue.I(3));f.Pc=308;continue;}
case 308:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?317:311;continue;}
case 311:{f.Push(f.Locals[3]);f.Pc=312;continue;}
case 312:{f.Push(JValue.I(3));f.Pc=313;continue;}
case 313:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=314;continue;}
case 314:{f.Pc=318;continue;}
case 317:{f.Push(JValue.R(null));f.Pc=318;continue;}
case 318:{f.Locals[5]=f.Pop();f.Pc=320;continue;}
case 320:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPutCounter"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPutCounter")));f.Pc=323;continue;}
case 323:{f.StackOp("dup");f.Pc=324;continue;}
case 324:{f.Push(f.Locals[3]);f.Pc=325;continue;}
case 325:{f.Push(JValue.I(0));f.Pc=326;continue;}
case 326:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=327;continue;}
case 327:{f.Push(f.Locals[3]);f.Pc=328;continue;}
case 328:{f.Push(JValue.I(1));f.Pc=329;continue;}
case 329:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",333);}
case 333:{f.Push(f.Locals[4]);f.Pc=335;continue;}
case 335:{f.Push(f.Locals[5]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/game/cost/CostPutCounter","<init>","(Ljava/lang/String;Lforge/game/card/CounterType;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",340);}
case 340:{return JStep.Return(f.Pop());}
case 341:{f.Push(f.Locals[0]);f.Pc=342;continue;}
case 342:{f.Push(JValue.R(rt.String("AddCounterYou<")));f.Pc=345;continue;}
case 345:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",348);}
case 348:{f.Pc=f.Pop().Int==0?374:351;continue;}
case 351:{f.Push(f.Locals[0]);f.Pc=352;continue;}
case 352:{f.Push(JValue.I(2));f.Pc=353;continue;}
case 353:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",356);}
case 356:{f.Locals[3]=f.Pop();f.Pc=357;continue;}
case 357:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPutCounterYou"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPutCounterYou")));f.Pc=360;continue;}
case 360:{f.StackOp("dup");f.Pc=361;continue;}
case 361:{f.Push(f.Locals[3]);f.Pc=362;continue;}
case 362:{f.Push(JValue.I(0));f.Pc=363;continue;}
case 363:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=364;continue;}
case 364:{f.Push(f.Locals[3]);f.Pc=365;continue;}
case 365:{f.Push(JValue.I(1));f.Pc=366;continue;}
case 366:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=367;continue;}
case 367:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",370);}
case 370:{return rt.Call(f,"forge/game/cost/CostPutCounterYou","<init>","(Ljava/lang/String;Lforge/game/card/CounterType;)V","invokespecial",373);}
case 373:{return JStep.Return(f.Pop());}
case 374:{f.Push(f.Locals[0]);f.Pc=375;continue;}
case 375:{f.Push(JValue.R(rt.String("PayLife<")));f.Pc=378;continue;}
case 378:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",381);}
case 381:{f.Pc=f.Pop().Int==0?418:384;continue;}
case 384:{f.Push(f.Locals[0]);f.Pc=385;continue;}
case 385:{f.Push(JValue.I(2));f.Pc=386;continue;}
case 386:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",389);}
case 389:{f.Locals[3]=f.Pop();f.Pc=390;continue;}
case 390:{f.Push(f.Locals[3]);f.Pc=391;continue;}
case 391:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=392;continue;}
case 392:{f.Push(JValue.I(1));f.Pc=393;continue;}
case 393:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?402:396;continue;}
case 396:{f.Push(f.Locals[3]);f.Pc=397;continue;}
case 397:{f.Push(JValue.I(1));f.Pc=398;continue;}
case 398:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=399;continue;}
case 399:{f.Pc=403;continue;}
case 402:{f.Push(JValue.R(null));f.Pc=403;continue;}
case 403:{f.Locals[4]=f.Pop();f.Pc=405;continue;}
case 405:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPayLife"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPayLife")));f.Pc=408;continue;}
case 408:{f.StackOp("dup");f.Pc=409;continue;}
case 409:{f.Push(f.Locals[3]);f.Pc=410;continue;}
case 410:{f.Push(JValue.I(0));f.Pc=411;continue;}
case 411:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=412;continue;}
case 412:{f.Push(f.Locals[4]);f.Pc=414;continue;}
case 414:{return rt.Call(f,"forge/game/cost/CostPayLife","<init>","(Ljava/lang/String;Ljava/lang/String;)V","invokespecial",417);}
case 417:{return JStep.Return(f.Pop());}
case 418:{f.Push(f.Locals[0]);f.Pc=419;continue;}
case 419:{f.Push(JValue.R(rt.String("PayEnergy<")));f.Pc=422;continue;}
case 422:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",425);}
case 425:{f.Pc=f.Pop().Int==0?445:428;continue;}
case 428:{f.Push(f.Locals[0]);f.Pc=429;continue;}
case 429:{f.Push(JValue.I(1));f.Pc=430;continue;}
case 430:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",433);}
case 433:{f.Locals[3]=f.Pop();f.Pc=434;continue;}
case 434:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPayEnergy"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPayEnergy")));f.Pc=437;continue;}
case 437:{f.StackOp("dup");f.Pc=438;continue;}
case 438:{f.Push(f.Locals[3]);f.Pc=439;continue;}
case 439:{f.Push(JValue.I(0));f.Pc=440;continue;}
case 440:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=441;continue;}
case 441:{return rt.Call(f,"forge/game/cost/CostPayEnergy","<init>","(Ljava/lang/String;)V","invokespecial",444);}
case 444:{return JStep.Return(f.Pop());}
case 445:{f.Push(f.Locals[0]);f.Pc=446;continue;}
case 446:{f.Push(JValue.R(rt.String("PayShards<")));f.Pc=449;continue;}
case 449:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",452);}
case 452:{f.Pc=f.Pop().Int==0?472:455;continue;}
case 455:{f.Push(f.Locals[0]);f.Pc=456;continue;}
case 456:{f.Push(JValue.I(1));f.Pc=457;continue;}
case 457:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",460);}
case 460:{f.Locals[3]=f.Pop();f.Pc=461;continue;}
case 461:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPayShards"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPayShards")));f.Pc=464;continue;}
case 464:{f.StackOp("dup");f.Pc=465;continue;}
case 465:{f.Push(f.Locals[3]);f.Pc=466;continue;}
case 466:{f.Push(JValue.I(0));f.Pc=467;continue;}
case 467:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=468;continue;}
case 468:{return rt.Call(f,"forge/game/cost/CostPayShards","<init>","(Ljava/lang/String;)V","invokespecial",471);}
case 471:{return JStep.Return(f.Pop());}
case 472:{f.Push(f.Locals[0]);f.Pc=473;continue;}
case 473:{f.Push(JValue.R(rt.String("GainLife<")));f.Pc=476;continue;}
case 476:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",479);}
case 479:{f.Pc=f.Pop().Int==0?540:482;continue;}
case 482:{f.Push(f.Locals[0]);f.Pc=483;continue;}
case 483:{f.Push(JValue.I(3));f.Pc=484;continue;}
case 484:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",487);}
case 487:{f.Locals[3]=f.Pop();f.Pc=488;continue;}
case 488:{f.Push(f.Locals[3]);f.Pc=489;continue;}
case 489:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=490;continue;}
case 490:{f.Push(JValue.I(2));f.Pc=491;continue;}
case 491:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?521:494;continue;}
case 494:{f.Push(JValue.R(rt.String("*")));f.Pc=497;continue;}
case 497:{f.Push(f.Locals[3]);f.Pc=498;continue;}
case 498:{f.Push(JValue.I(2));f.Pc=499;continue;}
case 499:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=500;continue;}
case 500:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",503);}
case 503:{f.Pc=f.Pop().Int==0?512:506;continue;}
case 506:{f.Push(JValue.I(2147483647));f.Pc=509;continue;}
case 509:{f.Pc=522;continue;}
case 512:{f.Push(f.Locals[3]);f.Pc=513;continue;}
case 513:{f.Push(JValue.I(2));f.Pc=514;continue;}
case 514:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=515;continue;}
case 515:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",518);}
case 518:{f.Pc=522;continue;}
case 521:{f.Push(JValue.I(1));f.Pc=522;continue;}
case 522:{f.Locals[4]=f.Pop();f.Pc=524;continue;}
case 524:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostGainLife"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostGainLife")));f.Pc=527;continue;}
case 527:{f.StackOp("dup");f.Pc=528;continue;}
case 528:{f.Push(f.Locals[3]);f.Pc=529;continue;}
case 529:{f.Push(JValue.I(0));f.Pc=530;continue;}
case 530:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=531;continue;}
case 531:{f.Push(f.Locals[3]);f.Pc=532;continue;}
case 532:{f.Push(JValue.I(1));f.Pc=533;continue;}
case 533:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=534;continue;}
case 534:{f.Push(f.Locals[4]);f.Pc=536;continue;}
case 536:{return rt.Call(f,"forge/game/cost/CostGainLife","<init>","(Ljava/lang/String;Ljava/lang/String;I)V","invokespecial",539);}
case 539:{return JStep.Return(f.Pop());}
case 540:{f.Push(f.Locals[0]);f.Pc=541;continue;}
case 541:{f.Push(JValue.R(rt.String("GainControl<")));f.Pc=544;continue;}
case 544:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",547);}
case 547:{f.Pc=f.Pop().Int==0?587:550;continue;}
case 550:{f.Push(f.Locals[0]);f.Pc=551;continue;}
case 551:{f.Push(JValue.I(3));f.Pc=552;continue;}
case 552:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",555);}
case 555:{f.Locals[3]=f.Pop();f.Pc=556;continue;}
case 556:{f.Push(f.Locals[3]);f.Pc=557;continue;}
case 557:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=558;continue;}
case 558:{f.Push(JValue.I(2));f.Pc=559;continue;}
case 559:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?568:562;continue;}
case 562:{f.Push(f.Locals[3]);f.Pc=563;continue;}
case 563:{f.Push(JValue.I(2));f.Pc=564;continue;}
case 564:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=565;continue;}
case 565:{f.Pc=569;continue;}
case 568:{f.Push(JValue.R(null));f.Pc=569;continue;}
case 569:{f.Locals[4]=f.Pop();f.Pc=571;continue;}
case 571:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostGainControl"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostGainControl")));f.Pc=574;continue;}
case 574:{f.StackOp("dup");f.Pc=575;continue;}
case 575:{f.Push(f.Locals[3]);f.Pc=576;continue;}
case 576:{f.Push(JValue.I(0));f.Pc=577;continue;}
case 577:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=578;continue;}
case 578:{f.Push(f.Locals[3]);f.Pc=579;continue;}
case 579:{f.Push(JValue.I(1));f.Pc=580;continue;}
case 580:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=581;continue;}
case 581:{f.Push(f.Locals[4]);f.Pc=583;continue;}
case 583:{return rt.Call(f,"forge/game/cost/CostGainControl","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",586);}
case 586:{return JStep.Return(f.Pop());}
case 587:{f.Push(f.Locals[0]);f.Pc=588;continue;}
case 588:{f.Push(JValue.R(rt.String("Unattach<")));f.Pc=591;continue;}
case 591:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",594);}
case 594:{f.Pc=f.Pop().Int==0?631:597;continue;}
case 597:{f.Push(f.Locals[0]);f.Pc=598;continue;}
case 598:{f.Push(JValue.I(2));f.Pc=599;continue;}
case 599:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",602);}
case 602:{f.Locals[3]=f.Pop();f.Pc=603;continue;}
case 603:{f.Push(f.Locals[3]);f.Pc=604;continue;}
case 604:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=605;continue;}
case 605:{f.Push(JValue.I(1));f.Pc=606;continue;}
case 606:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?615:609;continue;}
case 609:{f.Push(f.Locals[3]);f.Pc=610;continue;}
case 610:{f.Push(JValue.I(1));f.Pc=611;continue;}
case 611:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=612;continue;}
case 612:{f.Pc=616;continue;}
case 615:{f.Push(JValue.R(null));f.Pc=616;continue;}
case 616:{f.Locals[4]=f.Pop();f.Pc=618;continue;}
case 618:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostUnattach"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostUnattach")));f.Pc=621;continue;}
case 621:{f.StackOp("dup");f.Pc=622;continue;}
case 622:{f.Push(f.Locals[3]);f.Pc=623;continue;}
case 623:{f.Push(JValue.I(0));f.Pc=624;continue;}
case 624:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=625;continue;}
case 625:{f.Push(f.Locals[4]);f.Pc=627;continue;}
case 627:{return rt.Call(f,"forge/game/cost/CostUnattach","<init>","(Ljava/lang/String;Ljava/lang/String;)V","invokespecial",630);}
case 630:{return JStep.Return(f.Pop());}
case 631:{f.Push(f.Locals[0]);f.Pc=632;continue;}
case 632:{f.Push(JValue.R(rt.String("ChooseColor<")));f.Pc=635;continue;}
case 635:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",638);}
case 638:{f.Pc=f.Pop().Int==0?658:641;continue;}
case 641:{f.Push(f.Locals[0]);f.Pc=642;continue;}
case 642:{f.Push(JValue.I(1));f.Pc=643;continue;}
case 643:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",646);}
case 646:{f.Locals[3]=f.Pop();f.Pc=647;continue;}
case 647:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostChooseColor"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostChooseColor")));f.Pc=650;continue;}
case 650:{f.StackOp("dup");f.Pc=651;continue;}
case 651:{f.Push(f.Locals[3]);f.Pc=652;continue;}
case 652:{f.Push(JValue.I(0));f.Pc=653;continue;}
case 653:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=654;continue;}
case 654:{return rt.Call(f,"forge/game/cost/CostChooseColor","<init>","(Ljava/lang/String;)V","invokespecial",657);}
case 657:{return JStep.Return(f.Pop());}
case 658:{f.Push(f.Locals[0]);f.Pc=659;continue;}
case 659:{f.Push(JValue.R(rt.String("ChooseCreatureType<")));f.Pc=662;continue;}
case 662:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",665);}
case 665:{f.Pc=f.Pop().Int==0?685:668;continue;}
case 668:{f.Push(f.Locals[0]);f.Pc=669;continue;}
case 669:{f.Push(JValue.I(1));f.Pc=670;continue;}
case 670:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",673);}
case 673:{f.Locals[3]=f.Pop();f.Pc=674;continue;}
case 674:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostChooseCreatureType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostChooseCreatureType")));f.Pc=677;continue;}
case 677:{f.StackOp("dup");f.Pc=678;continue;}
case 678:{f.Push(f.Locals[3]);f.Pc=679;continue;}
case 679:{f.Push(JValue.I(0));f.Pc=680;continue;}
case 680:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=681;continue;}
case 681:{return rt.Call(f,"forge/game/cost/CostChooseCreatureType","<init>","(Ljava/lang/String;)V","invokespecial",684);}
case 684:{return JStep.Return(f.Pop());}
case 685:{f.Push(f.Locals[0]);f.Pc=686;continue;}
case 686:{f.Push(JValue.R(rt.String("DamageYou<")));f.Pc=689;continue;}
case 689:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",692);}
case 692:{f.Pc=f.Pop().Int==0?712:695;continue;}
case 695:{f.Push(f.Locals[0]);f.Pc=696;continue;}
case 696:{f.Push(JValue.I(1));f.Pc=697;continue;}
case 697:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",700);}
case 700:{f.Locals[3]=f.Pop();f.Pc=701;continue;}
case 701:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostDamage"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostDamage")));f.Pc=704;continue;}
case 704:{f.StackOp("dup");f.Pc=705;continue;}
case 705:{f.Push(f.Locals[3]);f.Pc=706;continue;}
case 706:{f.Push(JValue.I(0));f.Pc=707;continue;}
case 707:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=708;continue;}
case 708:{return rt.Call(f,"forge/game/cost/CostDamage","<init>","(Ljava/lang/String;)V","invokespecial",711);}
case 711:{return JStep.Return(f.Pop());}
case 712:{f.Push(f.Locals[0]);f.Pc=713;continue;}
case 713:{f.Push(JValue.R(rt.String("Mill<")));f.Pc=716;continue;}
case 716:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",719);}
case 719:{f.Pc=f.Pop().Int==0?739:722;continue;}
case 722:{f.Push(f.Locals[0]);f.Pc=723;continue;}
case 723:{f.Push(JValue.I(1));f.Pc=724;continue;}
case 724:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",727);}
case 727:{f.Locals[3]=f.Pop();f.Pc=728;continue;}
case 728:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostMill"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostMill")));f.Pc=731;continue;}
case 731:{f.StackOp("dup");f.Pc=732;continue;}
case 732:{f.Push(f.Locals[3]);f.Pc=733;continue;}
case 733:{f.Push(JValue.I(0));f.Pc=734;continue;}
case 734:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=735;continue;}
case 735:{return rt.Call(f,"forge/game/cost/CostMill","<init>","(Ljava/lang/String;)V","invokespecial",738);}
case 738:{return JStep.Return(f.Pop());}
case 739:{f.Push(f.Locals[0]);f.Pc=740;continue;}
case 740:{f.Push(JValue.R(rt.String("FlipCoin<")));f.Pc=743;continue;}
case 743:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",746);}
case 746:{f.Pc=f.Pop().Int==0?766:749;continue;}
case 749:{f.Push(f.Locals[0]);f.Pc=750;continue;}
case 750:{f.Push(JValue.I(1));f.Pc=751;continue;}
case 751:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",754);}
case 754:{f.Locals[3]=f.Pop();f.Pc=755;continue;}
case 755:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostFlipCoin"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostFlipCoin")));f.Pc=758;continue;}
case 758:{f.StackOp("dup");f.Pc=759;continue;}
case 759:{f.Push(f.Locals[3]);f.Pc=760;continue;}
case 760:{f.Push(JValue.I(0));f.Pc=761;continue;}
case 761:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=762;continue;}
case 762:{return rt.Call(f,"forge/game/cost/CostFlipCoin","<init>","(Ljava/lang/String;)V","invokespecial",765);}
case 765:{return JStep.Return(f.Pop());}
case 766:{f.Push(f.Locals[0]);f.Pc=767;continue;}
case 767:{f.Push(JValue.R(rt.String("RollDice<")));f.Pc=770;continue;}
case 770:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",773);}
case 773:{f.Pc=f.Pop().Int==0?816:776;continue;}
case 776:{f.Push(f.Locals[0]);f.Pc=777;continue;}
case 777:{f.Push(JValue.I(4));f.Pc=778;continue;}
case 778:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",781);}
case 781:{f.Locals[3]=f.Pop();f.Pc=782;continue;}
case 782:{f.Push(f.Locals[3]);f.Pc=783;continue;}
case 783:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=784;continue;}
case 784:{f.Push(JValue.I(3));f.Pc=785;continue;}
case 785:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?794:788;continue;}
case 788:{f.Push(f.Locals[3]);f.Pc=789;continue;}
case 789:{f.Push(JValue.I(3));f.Pc=790;continue;}
case 790:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=791;continue;}
case 791:{f.Pc=795;continue;}
case 794:{f.Push(JValue.R(null));f.Pc=795;continue;}
case 795:{f.Locals[4]=f.Pop();f.Pc=797;continue;}
case 797:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostRollDice"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostRollDice")));f.Pc=800;continue;}
case 800:{f.StackOp("dup");f.Pc=801;continue;}
case 801:{f.Push(f.Locals[3]);f.Pc=802;continue;}
case 802:{f.Push(JValue.I(0));f.Pc=803;continue;}
case 803:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=804;continue;}
case 804:{f.Push(f.Locals[3]);f.Pc=805;continue;}
case 805:{f.Push(JValue.I(1));f.Pc=806;continue;}
case 806:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=807;continue;}
case 807:{f.Push(f.Locals[3]);f.Pc=808;continue;}
case 808:{f.Push(JValue.I(2));f.Pc=809;continue;}
case 809:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=810;continue;}
case 810:{f.Push(f.Locals[4]);f.Pc=812;continue;}
case 812:{return rt.Call(f,"forge/game/cost/CostRollDice","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",815);}
case 815:{return JStep.Return(f.Pop());}
case 816:{f.Push(f.Locals[0]);f.Pc=817;continue;}
case 817:{f.Push(JValue.R(rt.String("Discard<")));f.Pc=820;continue;}
case 820:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",823);}
case 823:{f.Pc=f.Pop().Int==0?863:826;continue;}
case 826:{f.Push(f.Locals[0]);f.Pc=827;continue;}
case 827:{f.Push(JValue.I(3));f.Pc=828;continue;}
case 828:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",831);}
case 831:{f.Locals[3]=f.Pop();f.Pc=832;continue;}
case 832:{f.Push(f.Locals[3]);f.Pc=833;continue;}
case 833:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=834;continue;}
case 834:{f.Push(JValue.I(2));f.Pc=835;continue;}
case 835:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?844:838;continue;}
case 838:{f.Push(f.Locals[3]);f.Pc=839;continue;}
case 839:{f.Push(JValue.I(2));f.Pc=840;continue;}
case 840:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=841;continue;}
case 841:{f.Pc=845;continue;}
case 844:{f.Push(JValue.R(null));f.Pc=845;continue;}
case 845:{f.Locals[4]=f.Pop();f.Pc=847;continue;}
case 847:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostDiscard"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostDiscard")));f.Pc=850;continue;}
case 850:{f.StackOp("dup");f.Pc=851;continue;}
case 851:{f.Push(f.Locals[3]);f.Pc=852;continue;}
case 852:{f.Push(JValue.I(0));f.Pc=853;continue;}
case 853:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=854;continue;}
case 854:{f.Push(f.Locals[3]);f.Pc=855;continue;}
case 855:{f.Push(JValue.I(1));f.Pc=856;continue;}
case 856:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=857;continue;}
case 857:{f.Push(f.Locals[4]);f.Pc=859;continue;}
case 859:{return rt.Call(f,"forge/game/cost/CostDiscard","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",862);}
case 862:{return JStep.Return(f.Pop());}
case 863:{f.Push(f.Locals[0]);f.Pc=864;continue;}
case 864:{f.Push(JValue.R(rt.String("AddMana<")));f.Pc=867;continue;}
case 867:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",870);}
case 870:{f.Pc=f.Pop().Int==0?910:873;continue;}
case 873:{f.Push(f.Locals[0]);f.Pc=874;continue;}
case 874:{f.Push(JValue.I(3));f.Pc=875;continue;}
case 875:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",878);}
case 878:{f.Locals[3]=f.Pop();f.Pc=879;continue;}
case 879:{f.Push(f.Locals[3]);f.Pc=880;continue;}
case 880:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=881;continue;}
case 881:{f.Push(JValue.I(2));f.Pc=882;continue;}
case 882:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?891:885;continue;}
case 885:{f.Push(f.Locals[3]);f.Pc=886;continue;}
case 886:{f.Push(JValue.I(2));f.Pc=887;continue;}
case 887:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=888;continue;}
case 888:{f.Pc=892;continue;}
case 891:{f.Push(JValue.R(null));f.Pc=892;continue;}
case 892:{f.Locals[4]=f.Pop();f.Pc=894;continue;}
case 894:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostAddMana"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostAddMana")));f.Pc=897;continue;}
case 897:{f.StackOp("dup");f.Pc=898;continue;}
case 898:{f.Push(f.Locals[3]);f.Pc=899;continue;}
case 899:{f.Push(JValue.I(0));f.Pc=900;continue;}
case 900:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=901;continue;}
case 901:{f.Push(f.Locals[3]);f.Pc=902;continue;}
case 902:{f.Push(JValue.I(1));f.Pc=903;continue;}
case 903:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=904;continue;}
case 904:{f.Push(f.Locals[4]);f.Pc=906;continue;}
case 906:{return rt.Call(f,"forge/game/cost/CostAddMana","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",909);}
case 909:{return JStep.Return(f.Pop());}
case 910:{f.Push(f.Locals[0]);f.Pc=911;continue;}
case 911:{f.Push(JValue.R(rt.String("Sac<")));f.Pc=914;continue;}
case 914:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",917);}
case 917:{f.Pc=f.Pop().Int==0?957:920;continue;}
case 920:{f.Push(f.Locals[0]);f.Pc=921;continue;}
case 921:{f.Push(JValue.I(3));f.Pc=922;continue;}
case 922:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",925);}
case 925:{f.Locals[3]=f.Pop();f.Pc=926;continue;}
case 926:{f.Push(f.Locals[3]);f.Pc=927;continue;}
case 927:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=928;continue;}
case 928:{f.Push(JValue.I(2));f.Pc=929;continue;}
case 929:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?938:932;continue;}
case 932:{f.Push(f.Locals[3]);f.Pc=933;continue;}
case 933:{f.Push(JValue.I(2));f.Pc=934;continue;}
case 934:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=935;continue;}
case 935:{f.Pc=939;continue;}
case 938:{f.Push(JValue.R(null));f.Pc=939;continue;}
case 939:{f.Locals[4]=f.Pop();f.Pc=941;continue;}
case 941:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostSacrifice"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostSacrifice")));f.Pc=944;continue;}
case 944:{f.StackOp("dup");f.Pc=945;continue;}
case 945:{f.Push(f.Locals[3]);f.Pc=946;continue;}
case 946:{f.Push(JValue.I(0));f.Pc=947;continue;}
case 947:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=948;continue;}
case 948:{f.Push(f.Locals[3]);f.Pc=949;continue;}
case 949:{f.Push(JValue.I(1));f.Pc=950;continue;}
case 950:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=951;continue;}
case 951:{f.Push(f.Locals[4]);f.Pc=953;continue;}
case 953:{return rt.Call(f,"forge/game/cost/CostSacrifice","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",956);}
case 956:{return JStep.Return(f.Pop());}
case 957:{f.Push(f.Locals[0]);f.Pc=958;continue;}
case 958:{f.Push(JValue.R(rt.String("RemoveAnyCounter<")));f.Pc=961;continue;}
case 961:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",964);}
case 964:{f.Pc=f.Pop().Int==0?1034:967;continue;}
case 967:{f.Push(f.Locals[0]);f.Pc=968;continue;}
case 968:{f.Push(JValue.I(4));f.Pc=969;continue;}
case 969:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",972);}
case 972:{f.Locals[3]=f.Pop();f.Pc=973;continue;}
case 973:{f.Push(f.Locals[3]);f.Pc=974;continue;}
case 974:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=975;continue;}
case 975:{f.Push(JValue.I(3));f.Pc=976;continue;}
case 976:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?985:979;continue;}
case 979:{f.Push(f.Locals[3]);f.Pc=980;continue;}
case 980:{f.Push(JValue.I(3));f.Pc=981;continue;}
case 981:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=982;continue;}
case 982:{f.Pc=986;continue;}
case 985:{f.Push(JValue.R(null));f.Pc=986;continue;}
case 986:{f.Locals[4]=f.Pop();f.Pc=988;continue;}
case 988:{f.Push(JValue.I(0));f.Pc=989;continue;}
case 989:{f.Locals[5]=f.Pop();f.Pc=991;continue;}
case 991:{f.Push(f.Locals[3]);f.Pc=992;continue;}
case 992:{f.Push(JValue.I(0));f.Pc=993;continue;}
case 993:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=994;continue;}
case 994:{f.Push(JValue.R(rt.String("X1+")));f.Pc=996;continue;}
case 996:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",999);}
case 999:{f.Pc=f.Pop().Int==0?1010:1002;continue;}
case 1002:{f.Push(JValue.I(1));f.Pc=1003;continue;}
case 1003:{f.Locals[5]=f.Pop();f.Pc=1005;continue;}
case 1005:{f.Push(f.Locals[3]);f.Pc=1006;continue;}
case 1006:{f.Push(JValue.I(0));f.Pc=1007;continue;}
case 1007:{f.Push(JValue.R(rt.String("X")));f.Pc=1009;continue;}
case 1009:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1010;continue;}
case 1010:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostRemoveAnyCounter"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostRemoveAnyCounter")));f.Pc=1013;continue;}
case 1013:{f.StackOp("dup");f.Pc=1014;continue;}
case 1014:{f.Push(f.Locals[3]);f.Pc=1015;continue;}
case 1015:{f.Push(JValue.I(0));f.Pc=1016;continue;}
case 1016:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1017;continue;}
case 1017:{f.Push(f.Locals[3]);f.Pc=1018;continue;}
case 1018:{f.Push(JValue.I(1));f.Pc=1019;continue;}
case 1019:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1020;continue;}
case 1020:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",1023);}
case 1023:{f.Push(f.Locals[3]);f.Pc=1024;continue;}
case 1024:{f.Push(JValue.I(2));f.Pc=1025;continue;}
case 1025:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1026;continue;}
case 1026:{f.Push(f.Locals[4]);f.Pc=1028;continue;}
case 1028:{f.Push(f.Locals[5]);f.Pc=1030;continue;}
case 1030:{return rt.Call(f,"forge/game/cost/CostRemoveAnyCounter","<init>","(Ljava/lang/String;Lforge/game/card/CounterType;Ljava/lang/String;Ljava/lang/String;Z)V","invokespecial",1033);}
case 1033:{return JStep.Return(f.Pop());}
case 1034:{f.Push(f.Locals[0]);f.Pc=1035;continue;}
case 1035:{f.Push(JValue.R(rt.String("Exile<")));f.Pc=1038;continue;}
case 1038:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1041);}
case 1041:{f.Pc=f.Pop().Int==0?1084:1044;continue;}
case 1044:{f.Push(f.Locals[0]);f.Pc=1045;continue;}
case 1045:{f.Push(JValue.I(3));f.Pc=1046;continue;}
case 1046:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1049);}
case 1049:{f.Locals[3]=f.Pop();f.Pc=1050;continue;}
case 1050:{f.Push(f.Locals[3]);f.Pc=1051;continue;}
case 1051:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1052;continue;}
case 1052:{f.Push(JValue.I(2));f.Pc=1053;continue;}
case 1053:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1062:1056;continue;}
case 1056:{f.Push(f.Locals[3]);f.Pc=1057;continue;}
case 1057:{f.Push(JValue.I(2));f.Pc=1058;continue;}
case 1058:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1059;continue;}
case 1059:{f.Pc=1063;continue;}
case 1062:{f.Push(JValue.R(null));f.Pc=1063;continue;}
case 1063:{f.Locals[4]=f.Pop();f.Pc=1065;continue;}
case 1065:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostExile"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostExile")));f.Pc=1068;continue;}
case 1068:{f.StackOp("dup");f.Pc=1069;continue;}
case 1069:{f.Push(f.Locals[3]);f.Pc=1070;continue;}
case 1070:{f.Push(JValue.I(0));f.Pc=1071;continue;}
case 1071:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1072;continue;}
case 1072:{f.Push(f.Locals[3]);f.Pc=1073;continue;}
case 1073:{f.Push(JValue.I(1));f.Pc=1074;continue;}
case 1074:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1075;continue;}
case 1075:{f.Push(f.Locals[4]);f.Pc=1077;continue;}
case 1077:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1080;continue;}
case 1080:{return rt.Call(f,"forge/game/cost/CostExile","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;)V","invokespecial",1083);}
case 1083:{return JStep.Return(f.Pop());}
case 1084:{f.Push(f.Locals[0]);f.Pc=1085;continue;}
case 1085:{f.Push(JValue.R(rt.String("ExileFromHand<")));f.Pc=1088;continue;}
case 1088:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1091);}
case 1091:{f.Pc=f.Pop().Int==0?1134:1094;continue;}
case 1094:{f.Push(f.Locals[0]);f.Pc=1095;continue;}
case 1095:{f.Push(JValue.I(3));f.Pc=1096;continue;}
case 1096:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1099);}
case 1099:{f.Locals[3]=f.Pop();f.Pc=1100;continue;}
case 1100:{f.Push(f.Locals[3]);f.Pc=1101;continue;}
case 1101:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1102;continue;}
case 1102:{f.Push(JValue.I(2));f.Pc=1103;continue;}
case 1103:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1112:1106;continue;}
case 1106:{f.Push(f.Locals[3]);f.Pc=1107;continue;}
case 1107:{f.Push(JValue.I(2));f.Pc=1108;continue;}
case 1108:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1109;continue;}
case 1109:{f.Pc=1113;continue;}
case 1112:{f.Push(JValue.R(null));f.Pc=1113;continue;}
case 1113:{f.Locals[4]=f.Pop();f.Pc=1115;continue;}
case 1115:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostExile"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostExile")));f.Pc=1118;continue;}
case 1118:{f.StackOp("dup");f.Pc=1119;continue;}
case 1119:{f.Push(f.Locals[3]);f.Pc=1120;continue;}
case 1120:{f.Push(JValue.I(0));f.Pc=1121;continue;}
case 1121:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1122;continue;}
case 1122:{f.Push(f.Locals[3]);f.Pc=1123;continue;}
case 1123:{f.Push(JValue.I(1));f.Pc=1124;continue;}
case 1124:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1125;continue;}
case 1125:{f.Push(f.Locals[4]);f.Pc=1127;continue;}
case 1127:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=1130;continue;}
case 1130:{return rt.Call(f,"forge/game/cost/CostExile","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;)V","invokespecial",1133);}
case 1133:{return JStep.Return(f.Pop());}
case 1134:{f.Push(f.Locals[0]);f.Pc=1135;continue;}
case 1135:{f.Push(JValue.R(rt.String("ExileFromGrave<")));f.Pc=1138;continue;}
case 1138:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1141);}
case 1141:{f.Pc=f.Pop().Int==0?1184:1144;continue;}
case 1144:{f.Push(f.Locals[0]);f.Pc=1145;continue;}
case 1145:{f.Push(JValue.I(3));f.Pc=1146;continue;}
case 1146:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1149);}
case 1149:{f.Locals[3]=f.Pop();f.Pc=1150;continue;}
case 1150:{f.Push(f.Locals[3]);f.Pc=1151;continue;}
case 1151:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1152;continue;}
case 1152:{f.Push(JValue.I(2));f.Pc=1153;continue;}
case 1153:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1162:1156;continue;}
case 1156:{f.Push(f.Locals[3]);f.Pc=1157;continue;}
case 1157:{f.Push(JValue.I(2));f.Pc=1158;continue;}
case 1158:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1159;continue;}
case 1159:{f.Pc=1163;continue;}
case 1162:{f.Push(JValue.R(null));f.Pc=1163;continue;}
case 1163:{f.Locals[4]=f.Pop();f.Pc=1165;continue;}
case 1165:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostExile"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostExile")));f.Pc=1168;continue;}
case 1168:{f.StackOp("dup");f.Pc=1169;continue;}
case 1169:{f.Push(f.Locals[3]);f.Pc=1170;continue;}
case 1170:{f.Push(JValue.I(0));f.Pc=1171;continue;}
case 1171:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1172;continue;}
case 1172:{f.Push(f.Locals[3]);f.Pc=1173;continue;}
case 1173:{f.Push(JValue.I(1));f.Pc=1174;continue;}
case 1174:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1175;continue;}
case 1175:{f.Push(f.Locals[4]);f.Pc=1177;continue;}
case 1177:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=1180;continue;}
case 1180:{return rt.Call(f,"forge/game/cost/CostExile","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;)V","invokespecial",1183);}
case 1183:{return JStep.Return(f.Pop());}
case 1184:{f.Push(f.Locals[0]);f.Pc=1185;continue;}
case 1185:{f.Push(JValue.R(rt.String("ExileFromStack<")));f.Pc=1188;continue;}
case 1188:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1191);}
case 1191:{f.Pc=f.Pop().Int==0?1231:1194;continue;}
case 1194:{f.Push(f.Locals[0]);f.Pc=1195;continue;}
case 1195:{f.Push(JValue.I(3));f.Pc=1196;continue;}
case 1196:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1199);}
case 1199:{f.Locals[3]=f.Pop();f.Pc=1200;continue;}
case 1200:{f.Push(f.Locals[3]);f.Pc=1201;continue;}
case 1201:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1202;continue;}
case 1202:{f.Push(JValue.I(2));f.Pc=1203;continue;}
case 1203:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1212:1206;continue;}
case 1206:{f.Push(f.Locals[3]);f.Pc=1207;continue;}
case 1207:{f.Push(JValue.I(2));f.Pc=1208;continue;}
case 1208:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1209;continue;}
case 1209:{f.Pc=1213;continue;}
case 1212:{f.Push(JValue.R(null));f.Pc=1213;continue;}
case 1213:{f.Locals[4]=f.Pop();f.Pc=1215;continue;}
case 1215:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostExileFromStack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostExileFromStack")));f.Pc=1218;continue;}
case 1218:{f.StackOp("dup");f.Pc=1219;continue;}
case 1219:{f.Push(f.Locals[3]);f.Pc=1220;continue;}
case 1220:{f.Push(JValue.I(0));f.Pc=1221;continue;}
case 1221:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1222;continue;}
case 1222:{f.Push(f.Locals[3]);f.Pc=1223;continue;}
case 1223:{f.Push(JValue.I(1));f.Pc=1224;continue;}
case 1224:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1225;continue;}
case 1225:{f.Push(f.Locals[4]);f.Pc=1227;continue;}
case 1227:{return rt.Call(f,"forge/game/cost/CostExileFromStack","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",1230);}
case 1230:{return JStep.Return(f.Pop());}
case 1231:{f.Push(f.Locals[0]);f.Pc=1232;continue;}
case 1232:{f.Push(JValue.R(rt.String("ExileFromTop<")));f.Pc=1235;continue;}
case 1235:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1238);}
case 1238:{f.Pc=f.Pop().Int==0?1281:1241;continue;}
case 1241:{f.Push(f.Locals[0]);f.Pc=1242;continue;}
case 1242:{f.Push(JValue.I(3));f.Pc=1243;continue;}
case 1243:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1246);}
case 1246:{f.Locals[3]=f.Pop();f.Pc=1247;continue;}
case 1247:{f.Push(f.Locals[3]);f.Pc=1248;continue;}
case 1248:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1249;continue;}
case 1249:{f.Push(JValue.I(2));f.Pc=1250;continue;}
case 1250:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1259:1253;continue;}
case 1253:{f.Push(f.Locals[3]);f.Pc=1254;continue;}
case 1254:{f.Push(JValue.I(2));f.Pc=1255;continue;}
case 1255:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1256;continue;}
case 1256:{f.Pc=1260;continue;}
case 1259:{f.Push(JValue.R(null));f.Pc=1260;continue;}
case 1260:{f.Locals[4]=f.Pop();f.Pc=1262;continue;}
case 1262:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostExile"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostExile")));f.Pc=1265;continue;}
case 1265:{f.StackOp("dup");f.Pc=1266;continue;}
case 1266:{f.Push(f.Locals[3]);f.Pc=1267;continue;}
case 1267:{f.Push(JValue.I(0));f.Pc=1268;continue;}
case 1268:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1269;continue;}
case 1269:{f.Push(f.Locals[3]);f.Pc=1270;continue;}
case 1270:{f.Push(JValue.I(1));f.Pc=1271;continue;}
case 1271:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1272;continue;}
case 1272:{f.Push(f.Locals[4]);f.Pc=1274;continue;}
case 1274:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=1277;continue;}
case 1277:{return rt.Call(f,"forge/game/cost/CostExile","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;)V","invokespecial",1280);}
case 1280:{return JStep.Return(f.Pop());}
case 1281:{f.Push(f.Locals[0]);f.Pc=1282;continue;}
case 1282:{f.Push(JValue.R(rt.String("ExileAnyGrave<")));f.Pc=1285;continue;}
case 1285:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1288);}
case 1288:{f.Pc=f.Pop().Int==0?1332:1291;continue;}
case 1291:{f.Push(f.Locals[0]);f.Pc=1292;continue;}
case 1292:{f.Push(JValue.I(3));f.Pc=1293;continue;}
case 1293:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1296);}
case 1296:{f.Locals[3]=f.Pop();f.Pc=1297;continue;}
case 1297:{f.Push(f.Locals[3]);f.Pc=1298;continue;}
case 1298:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1299;continue;}
case 1299:{f.Push(JValue.I(2));f.Pc=1300;continue;}
case 1300:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1309:1303;continue;}
case 1303:{f.Push(f.Locals[3]);f.Pc=1304;continue;}
case 1304:{f.Push(JValue.I(2));f.Pc=1305;continue;}
case 1305:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1306;continue;}
case 1306:{f.Pc=1310;continue;}
case 1309:{f.Push(JValue.R(null));f.Pc=1310;continue;}
case 1310:{f.Locals[4]=f.Pop();f.Pc=1312;continue;}
case 1312:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostExile"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostExile")));f.Pc=1315;continue;}
case 1315:{f.StackOp("dup");f.Pc=1316;continue;}
case 1316:{f.Push(f.Locals[3]);f.Pc=1317;continue;}
case 1317:{f.Push(JValue.I(0));f.Pc=1318;continue;}
case 1318:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1319;continue;}
case 1319:{f.Push(f.Locals[3]);f.Pc=1320;continue;}
case 1320:{f.Push(JValue.I(1));f.Pc=1321;continue;}
case 1321:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1322;continue;}
case 1322:{f.Push(f.Locals[4]);f.Pc=1324;continue;}
case 1324:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=1327;continue;}
case 1327:{f.Push(JValue.I(-1));f.Pc=1328;continue;}
case 1328:{return rt.Call(f,"forge/game/cost/CostExile","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;I)V","invokespecial",1331);}
case 1331:{return JStep.Return(f.Pop());}
case 1332:{f.Push(f.Locals[0]);f.Pc=1333;continue;}
case 1333:{f.Push(JValue.R(rt.String("ExileSameGrave<")));f.Pc=1336;continue;}
case 1336:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1339);}
case 1339:{f.Pc=f.Pop().Int==0?1383:1342;continue;}
case 1342:{f.Push(f.Locals[0]);f.Pc=1343;continue;}
case 1343:{f.Push(JValue.I(3));f.Pc=1344;continue;}
case 1344:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1347);}
case 1347:{f.Locals[3]=f.Pop();f.Pc=1348;continue;}
case 1348:{f.Push(f.Locals[3]);f.Pc=1349;continue;}
case 1349:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1350;continue;}
case 1350:{f.Push(JValue.I(2));f.Pc=1351;continue;}
case 1351:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1360:1354;continue;}
case 1354:{f.Push(f.Locals[3]);f.Pc=1355;continue;}
case 1355:{f.Push(JValue.I(2));f.Pc=1356;continue;}
case 1356:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1357;continue;}
case 1357:{f.Pc=1361;continue;}
case 1360:{f.Push(JValue.R(null));f.Pc=1361;continue;}
case 1361:{f.Locals[4]=f.Pop();f.Pc=1363;continue;}
case 1363:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostExile"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostExile")));f.Pc=1366;continue;}
case 1366:{f.StackOp("dup");f.Pc=1367;continue;}
case 1367:{f.Push(f.Locals[3]);f.Pc=1368;continue;}
case 1368:{f.Push(JValue.I(0));f.Pc=1369;continue;}
case 1369:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1370;continue;}
case 1370:{f.Push(f.Locals[3]);f.Pc=1371;continue;}
case 1371:{f.Push(JValue.I(1));f.Pc=1372;continue;}
case 1372:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1373;continue;}
case 1373:{f.Push(f.Locals[4]);f.Pc=1375;continue;}
case 1375:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=1378;continue;}
case 1378:{f.Push(JValue.I(0));f.Pc=1379;continue;}
case 1379:{return rt.Call(f,"forge/game/cost/CostExile","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;I)V","invokespecial",1382);}
case 1382:{return JStep.Return(f.Pop());}
case 1383:{f.Push(f.Locals[0]);f.Pc=1384;continue;}
case 1384:{f.Push(JValue.R(rt.String("ExileCtrlOrGrave<")));f.Pc=1387;continue;}
case 1387:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1390);}
case 1390:{f.Pc=f.Pop().Int==0?1456:1393;continue;}
case 1393:{f.Push(f.Locals[0]);f.Pc=1394;continue;}
case 1394:{f.Push(JValue.I(3));f.Pc=1395;continue;}
case 1395:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1398);}
case 1398:{f.Locals[3]=f.Pop();f.Pc=1399;continue;}
case 1399:{f.Push(f.Locals[3]);f.Pc=1400;continue;}
case 1400:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1401;continue;}
case 1401:{f.Push(JValue.I(2));f.Pc=1402;continue;}
case 1402:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1411:1405;continue;}
case 1405:{f.Push(f.Locals[3]);f.Pc=1406;continue;}
case 1406:{f.Push(JValue.I(2));f.Pc=1407;continue;}
case 1407:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1408;continue;}
case 1408:{f.Pc=1412;continue;}
case 1411:{f.Push(JValue.R(null));f.Pc=1412;continue;}
case 1412:{f.Locals[4]=f.Pop();f.Pc=1414;continue;}
case 1414:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostExile"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostExile")));f.Pc=1417;continue;}
case 1417:{f.StackOp("dup");f.Pc=1418;continue;}
case 1418:{f.Push(f.Locals[3]);f.Pc=1419;continue;}
case 1419:{f.Push(JValue.I(0));f.Pc=1420;continue;}
case 1420:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1421;continue;}
case 1421:{f.Push(f.Locals[3]);f.Pc=1422;continue;}
case 1422:{f.Push(JValue.I(1));f.Pc=1423;continue;}
case 1423:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1424;continue;}
case 1424:{f.Push(f.Locals[4]);f.Pc=1426;continue;}
case 1426:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=1429;continue;}
case 1429:{f.StackOp("dup");f.Pc=1430;continue;}
case 1430:{f.Push(JValue.I(2));f.Pc=1431;continue;}
case 1431:{f.Push(JValue.R(rt.NewArray("Lforge/game/zone/ZoneType;",f.Pop().Int)));f.Pc=1434;continue;}
case 1434:{f.StackOp("dup");f.Pc=1435;continue;}
case 1435:{f.Push(JValue.I(0));f.Pc=1436;continue;}
case 1436:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=1439;continue;}
case 1439:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1440;continue;}
case 1440:{f.StackOp("dup");f.Pc=1441;continue;}
case 1441:{f.Push(JValue.I(1));f.Pc=1442;continue;}
case 1442:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=1445;continue;}
case 1445:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1446;continue;}
case 1446:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",1449);}
case 1449:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",1452);}
case 1452:{return rt.Call(f,"forge/game/cost/CostExile","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V","invokespecial",1455);}
case 1455:{return JStep.Return(f.Pop());}
case 1456:{f.Push(f.Locals[0]);f.Pc=1457;continue;}
case 1457:{f.Push(JValue.R(rt.String("PromiseGift")));f.Pc=1460;continue;}
case 1460:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1463);}
case 1463:{f.Pc=f.Pop().Int==0?1474:1466;continue;}
case 1466:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPromiseGift"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPromiseGift")));f.Pc=1469;continue;}
case 1469:{f.StackOp("dup");f.Pc=1470;continue;}
case 1470:{return rt.Call(f,"forge/game/cost/CostPromiseGift","<init>","()V","invokespecial",1473);}
case 1473:{return JStep.Return(f.Pop());}
case 1474:{f.Push(f.Locals[0]);f.Pc=1475;continue;}
case 1475:{f.Push(JValue.R(rt.String("Return<")));f.Pc=1478;continue;}
case 1478:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1481);}
case 1481:{f.Pc=f.Pop().Int==0?1521:1484;continue;}
case 1484:{f.Push(f.Locals[0]);f.Pc=1485;continue;}
case 1485:{f.Push(JValue.I(3));f.Pc=1486;continue;}
case 1486:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1489);}
case 1489:{f.Locals[3]=f.Pop();f.Pc=1490;continue;}
case 1490:{f.Push(f.Locals[3]);f.Pc=1491;continue;}
case 1491:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1492;continue;}
case 1492:{f.Push(JValue.I(2));f.Pc=1493;continue;}
case 1493:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1502:1496;continue;}
case 1496:{f.Push(f.Locals[3]);f.Pc=1497;continue;}
case 1497:{f.Push(JValue.I(2));f.Pc=1498;continue;}
case 1498:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1499;continue;}
case 1499:{f.Pc=1503;continue;}
case 1502:{f.Push(JValue.R(null));f.Pc=1503;continue;}
case 1503:{f.Locals[4]=f.Pop();f.Pc=1505;continue;}
case 1505:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostReturn"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostReturn")));f.Pc=1508;continue;}
case 1508:{f.StackOp("dup");f.Pc=1509;continue;}
case 1509:{f.Push(f.Locals[3]);f.Pc=1510;continue;}
case 1510:{f.Push(JValue.I(0));f.Pc=1511;continue;}
case 1511:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1512;continue;}
case 1512:{f.Push(f.Locals[3]);f.Pc=1513;continue;}
case 1513:{f.Push(JValue.I(1));f.Pc=1514;continue;}
case 1514:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1515;continue;}
case 1515:{f.Push(f.Locals[4]);f.Pc=1517;continue;}
case 1517:{return rt.Call(f,"forge/game/cost/CostReturn","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",1520);}
case 1520:{return JStep.Return(f.Pop());}
case 1521:{f.Push(f.Locals[0]);f.Pc=1522;continue;}
case 1522:{f.Push(JValue.R(rt.String("ChooseCard<")));f.Pc=1525;continue;}
case 1525:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1528);}
case 1528:{f.Pc=f.Pop().Int==0?1571:1531;continue;}
case 1531:{f.Push(f.Locals[0]);f.Pc=1532;continue;}
case 1532:{f.Push(JValue.I(3));f.Pc=1533;continue;}
case 1533:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1536);}
case 1536:{f.Locals[3]=f.Pop();f.Pc=1537;continue;}
case 1537:{f.Push(f.Locals[3]);f.Pc=1538;continue;}
case 1538:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1539;continue;}
case 1539:{f.Push(JValue.I(2));f.Pc=1540;continue;}
case 1540:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1549:1543;continue;}
case 1543:{f.Push(f.Locals[3]);f.Pc=1544;continue;}
case 1544:{f.Push(JValue.I(2));f.Pc=1545;continue;}
case 1545:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1546;continue;}
case 1546:{f.Pc=1550;continue;}
case 1549:{f.Push(JValue.R(null));f.Pc=1550;continue;}
case 1550:{f.Locals[4]=f.Pop();f.Pc=1552;continue;}
case 1552:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostReveal"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostReveal")));f.Pc=1555;continue;}
case 1555:{f.StackOp("dup");f.Pc=1556;continue;}
case 1556:{f.Push(f.Locals[3]);f.Pc=1557;continue;}
case 1557:{f.Push(JValue.I(0));f.Pc=1558;continue;}
case 1558:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1559;continue;}
case 1559:{f.Push(f.Locals[3]);f.Pc=1560;continue;}
case 1560:{f.Push(JValue.I(1));f.Pc=1561;continue;}
case 1561:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1562;continue;}
case 1562:{f.Push(f.Locals[4]);f.Pc=1564;continue;}
case 1564:{f.Push(JValue.R(rt.String("All")));f.Pc=1567;continue;}
case 1567:{return rt.Call(f,"forge/game/cost/CostReveal","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",1570);}
case 1570:{return JStep.Return(f.Pop());}
case 1571:{f.Push(f.Locals[0]);f.Pc=1572;continue;}
case 1572:{f.Push(JValue.R(rt.String("Reveal<")));f.Pc=1575;continue;}
case 1575:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1578);}
case 1578:{f.Pc=f.Pop().Int==0?1618:1581;continue;}
case 1581:{f.Push(f.Locals[0]);f.Pc=1582;continue;}
case 1582:{f.Push(JValue.I(3));f.Pc=1583;continue;}
case 1583:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1586);}
case 1586:{f.Locals[3]=f.Pop();f.Pc=1587;continue;}
case 1587:{f.Push(f.Locals[3]);f.Pc=1588;continue;}
case 1588:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1589;continue;}
case 1589:{f.Push(JValue.I(2));f.Pc=1590;continue;}
case 1590:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1599:1593;continue;}
case 1593:{f.Push(f.Locals[3]);f.Pc=1594;continue;}
case 1594:{f.Push(JValue.I(2));f.Pc=1595;continue;}
case 1595:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1596;continue;}
case 1596:{f.Pc=1600;continue;}
case 1599:{f.Push(JValue.R(null));f.Pc=1600;continue;}
case 1600:{f.Locals[4]=f.Pop();f.Pc=1602;continue;}
case 1602:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostReveal"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostReveal")));f.Pc=1605;continue;}
case 1605:{f.StackOp("dup");f.Pc=1606;continue;}
case 1606:{f.Push(f.Locals[3]);f.Pc=1607;continue;}
case 1607:{f.Push(JValue.I(0));f.Pc=1608;continue;}
case 1608:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1609;continue;}
case 1609:{f.Push(f.Locals[3]);f.Pc=1610;continue;}
case 1610:{f.Push(JValue.I(1));f.Pc=1611;continue;}
case 1611:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1612;continue;}
case 1612:{f.Push(f.Locals[4]);f.Pc=1614;continue;}
case 1614:{return rt.Call(f,"forge/game/cost/CostReveal","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",1617);}
case 1617:{return JStep.Return(f.Pop());}
case 1618:{f.Push(f.Locals[0]);f.Pc=1619;continue;}
case 1619:{f.Push(JValue.R(rt.String("RevealFromExile<")));f.Pc=1622;continue;}
case 1622:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1625);}
case 1625:{f.Pc=f.Pop().Int==0?1668:1628;continue;}
case 1628:{f.Push(f.Locals[0]);f.Pc=1629;continue;}
case 1629:{f.Push(JValue.I(3));f.Pc=1630;continue;}
case 1630:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1633);}
case 1633:{f.Locals[3]=f.Pop();f.Pc=1634;continue;}
case 1634:{f.Push(f.Locals[3]);f.Pc=1635;continue;}
case 1635:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1636;continue;}
case 1636:{f.Push(JValue.I(2));f.Pc=1637;continue;}
case 1637:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1646:1640;continue;}
case 1640:{f.Push(f.Locals[3]);f.Pc=1641;continue;}
case 1641:{f.Push(JValue.I(2));f.Pc=1642;continue;}
case 1642:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1643;continue;}
case 1643:{f.Pc=1647;continue;}
case 1646:{f.Push(JValue.R(null));f.Pc=1647;continue;}
case 1647:{f.Locals[4]=f.Pop();f.Pc=1649;continue;}
case 1649:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostReveal"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostReveal")));f.Pc=1652;continue;}
case 1652:{f.StackOp("dup");f.Pc=1653;continue;}
case 1653:{f.Push(f.Locals[3]);f.Pc=1654;continue;}
case 1654:{f.Push(JValue.I(0));f.Pc=1655;continue;}
case 1655:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1656;continue;}
case 1656:{f.Push(f.Locals[3]);f.Pc=1657;continue;}
case 1657:{f.Push(JValue.I(1));f.Pc=1658;continue;}
case 1658:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1659;continue;}
case 1659:{f.Push(f.Locals[4]);f.Pc=1661;continue;}
case 1661:{f.Push(JValue.R(rt.String("Exile")));f.Pc=1664;continue;}
case 1664:{return rt.Call(f,"forge/game/cost/CostReveal","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",1667);}
case 1667:{return JStep.Return(f.Pop());}
case 1668:{f.Push(f.Locals[0]);f.Pc=1669;continue;}
case 1669:{f.Push(JValue.R(rt.String("RevealOrChoose<")));f.Pc=1672;continue;}
case 1672:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1675);}
case 1675:{f.Pc=f.Pop().Int==0?1718:1678;continue;}
case 1678:{f.Push(f.Locals[0]);f.Pc=1679;continue;}
case 1679:{f.Push(JValue.I(3));f.Pc=1680;continue;}
case 1680:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1683);}
case 1683:{f.Locals[3]=f.Pop();f.Pc=1684;continue;}
case 1684:{f.Push(f.Locals[3]);f.Pc=1685;continue;}
case 1685:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1686;continue;}
case 1686:{f.Push(JValue.I(2));f.Pc=1687;continue;}
case 1687:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1696:1690;continue;}
case 1690:{f.Push(f.Locals[3]);f.Pc=1691;continue;}
case 1691:{f.Push(JValue.I(2));f.Pc=1692;continue;}
case 1692:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1693;continue;}
case 1693:{f.Pc=1697;continue;}
case 1696:{f.Push(JValue.R(null));f.Pc=1697;continue;}
case 1697:{f.Locals[4]=f.Pop();f.Pc=1699;continue;}
case 1699:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostReveal"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostReveal")));f.Pc=1702;continue;}
case 1702:{f.StackOp("dup");f.Pc=1703;continue;}
case 1703:{f.Push(f.Locals[3]);f.Pc=1704;continue;}
case 1704:{f.Push(JValue.I(0));f.Pc=1705;continue;}
case 1705:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1706;continue;}
case 1706:{f.Push(f.Locals[3]);f.Pc=1707;continue;}
case 1707:{f.Push(JValue.I(1));f.Pc=1708;continue;}
case 1708:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1709;continue;}
case 1709:{f.Push(f.Locals[4]);f.Pc=1711;continue;}
case 1711:{f.Push(JValue.R(rt.String("Hand,Battlefield")));f.Pc=1714;continue;}
case 1714:{return rt.Call(f,"forge/game/cost/CostReveal","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",1717);}
case 1717:{return JStep.Return(f.Pop());}
case 1718:{f.Push(f.Locals[0]);f.Pc=1719;continue;}
case 1719:{f.Push(JValue.R(rt.String("Behold<")));f.Pc=1722;continue;}
case 1722:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1725);}
case 1725:{f.Pc=f.Pop().Int==0?1765:1728;continue;}
case 1728:{f.Push(f.Locals[0]);f.Pc=1729;continue;}
case 1729:{f.Push(JValue.I(3));f.Pc=1730;continue;}
case 1730:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1733);}
case 1733:{f.Locals[3]=f.Pop();f.Pc=1734;continue;}
case 1734:{f.Push(f.Locals[3]);f.Pc=1735;continue;}
case 1735:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1736;continue;}
case 1736:{f.Push(JValue.I(2));f.Pc=1737;continue;}
case 1737:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1746:1740;continue;}
case 1740:{f.Push(f.Locals[3]);f.Pc=1741;continue;}
case 1741:{f.Push(JValue.I(2));f.Pc=1742;continue;}
case 1742:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1743;continue;}
case 1743:{f.Pc=1747;continue;}
case 1746:{f.Push(JValue.R(null));f.Pc=1747;continue;}
case 1747:{f.Locals[4]=f.Pop();f.Pc=1749;continue;}
case 1749:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostBehold"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostBehold")));f.Pc=1752;continue;}
case 1752:{f.StackOp("dup");f.Pc=1753;continue;}
case 1753:{f.Push(f.Locals[3]);f.Pc=1754;continue;}
case 1754:{f.Push(JValue.I(0));f.Pc=1755;continue;}
case 1755:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1756;continue;}
case 1756:{f.Push(f.Locals[3]);f.Pc=1757;continue;}
case 1757:{f.Push(JValue.I(1));f.Pc=1758;continue;}
case 1758:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1759;continue;}
case 1759:{f.Push(f.Locals[4]);f.Pc=1761;continue;}
case 1761:{return rt.Call(f,"forge/game/cost/CostBehold","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",1764);}
case 1764:{return JStep.Return(f.Pop());}
case 1765:{f.Push(f.Locals[0]);f.Pc=1766;continue;}
case 1766:{f.Push(JValue.R(rt.String("BeholdExile<")));f.Pc=1769;continue;}
case 1769:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1772);}
case 1772:{f.Pc=f.Pop().Int==0?1812:1775;continue;}
case 1775:{f.Push(f.Locals[0]);f.Pc=1776;continue;}
case 1776:{f.Push(JValue.I(3));f.Pc=1777;continue;}
case 1777:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1780);}
case 1780:{f.Locals[3]=f.Pop();f.Pc=1781;continue;}
case 1781:{f.Push(f.Locals[3]);f.Pc=1782;continue;}
case 1782:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1783;continue;}
case 1783:{f.Push(JValue.I(2));f.Pc=1784;continue;}
case 1784:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1793:1787;continue;}
case 1787:{f.Push(f.Locals[3]);f.Pc=1788;continue;}
case 1788:{f.Push(JValue.I(2));f.Pc=1789;continue;}
case 1789:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1790;continue;}
case 1790:{f.Pc=1794;continue;}
case 1793:{f.Push(JValue.R(null));f.Pc=1794;continue;}
case 1794:{f.Locals[4]=f.Pop();f.Pc=1796;continue;}
case 1796:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostBeholdExile"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostBeholdExile")));f.Pc=1799;continue;}
case 1799:{f.StackOp("dup");f.Pc=1800;continue;}
case 1800:{f.Push(f.Locals[3]);f.Pc=1801;continue;}
case 1801:{f.Push(JValue.I(0));f.Pc=1802;continue;}
case 1802:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1803;continue;}
case 1803:{f.Push(f.Locals[3]);f.Pc=1804;continue;}
case 1804:{f.Push(JValue.I(1));f.Pc=1805;continue;}
case 1805:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1806;continue;}
case 1806:{f.Push(f.Locals[4]);f.Pc=1808;continue;}
case 1808:{return rt.Call(f,"forge/game/cost/CostBeholdExile","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",1811);}
case 1811:{return JStep.Return(f.Pop());}
case 1812:{f.Push(f.Locals[0]);f.Pc=1813;continue;}
case 1813:{f.Push(JValue.R(rt.String("ExiledMoveToGrave<")));f.Pc=1816;continue;}
case 1816:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1819);}
case 1819:{f.Pc=f.Pop().Int==0?1859:1822;continue;}
case 1822:{f.Push(f.Locals[0]);f.Pc=1823;continue;}
case 1823:{f.Push(JValue.I(3));f.Pc=1824;continue;}
case 1824:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1827);}
case 1827:{f.Locals[3]=f.Pop();f.Pc=1828;continue;}
case 1828:{f.Push(f.Locals[3]);f.Pc=1829;continue;}
case 1829:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1830;continue;}
case 1830:{f.Push(JValue.I(2));f.Pc=1831;continue;}
case 1831:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1840:1834;continue;}
case 1834:{f.Push(f.Locals[3]);f.Pc=1835;continue;}
case 1835:{f.Push(JValue.I(2));f.Pc=1836;continue;}
case 1836:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1837;continue;}
case 1837:{f.Pc=1841;continue;}
case 1840:{f.Push(JValue.R(null));f.Pc=1841;continue;}
case 1841:{f.Locals[4]=f.Pop();f.Pc=1843;continue;}
case 1843:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostExiledMoveToGrave"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostExiledMoveToGrave")));f.Pc=1846;continue;}
case 1846:{f.StackOp("dup");f.Pc=1847;continue;}
case 1847:{f.Push(f.Locals[3]);f.Pc=1848;continue;}
case 1848:{f.Push(JValue.I(0));f.Pc=1849;continue;}
case 1849:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1850;continue;}
case 1850:{f.Push(f.Locals[3]);f.Pc=1851;continue;}
case 1851:{f.Push(JValue.I(1));f.Pc=1852;continue;}
case 1852:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1853;continue;}
case 1853:{f.Push(f.Locals[4]);f.Pc=1855;continue;}
case 1855:{return rt.Call(f,"forge/game/cost/CostExiledMoveToGrave","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",1858);}
case 1858:{return JStep.Return(f.Pop());}
case 1859:{f.Push(f.Locals[0]);f.Pc=1860;continue;}
case 1860:{f.Push(JValue.R(rt.String("Draw<")));f.Pc=1863;continue;}
case 1863:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1866);}
case 1866:{f.Pc=f.Pop().Int==0?1889:1869;continue;}
case 1869:{f.Push(f.Locals[0]);f.Pc=1870;continue;}
case 1870:{f.Push(JValue.I(2));f.Pc=1871;continue;}
case 1871:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1874);}
case 1874:{f.Locals[3]=f.Pop();f.Pc=1875;continue;}
case 1875:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostDraw"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostDraw")));f.Pc=1878;continue;}
case 1878:{f.StackOp("dup");f.Pc=1879;continue;}
case 1879:{f.Push(f.Locals[3]);f.Pc=1880;continue;}
case 1880:{f.Push(JValue.I(0));f.Pc=1881;continue;}
case 1881:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1882;continue;}
case 1882:{f.Push(f.Locals[3]);f.Pc=1883;continue;}
case 1883:{f.Push(JValue.I(1));f.Pc=1884;continue;}
case 1884:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1885;continue;}
case 1885:{return rt.Call(f,"forge/game/cost/CostDraw","<init>","(Ljava/lang/String;Ljava/lang/String;)V","invokespecial",1888);}
case 1888:{return JStep.Return(f.Pop());}
case 1889:{f.Push(f.Locals[0]);f.Pc=1890;continue;}
case 1890:{f.Push(JValue.R(rt.String("PutCardToLibFromHand<")));f.Pc=1893;continue;}
case 1893:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1896);}
case 1896:{f.Pc=f.Pop().Int==0?1942:1899;continue;}
case 1899:{f.Push(f.Locals[0]);f.Pc=1900;continue;}
case 1900:{f.Push(JValue.I(4));f.Pc=1901;continue;}
case 1901:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1904);}
case 1904:{f.Locals[3]=f.Pop();f.Pc=1905;continue;}
case 1905:{f.Push(f.Locals[3]);f.Pc=1906;continue;}
case 1906:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1907;continue;}
case 1907:{f.Push(JValue.I(3));f.Pc=1908;continue;}
case 1908:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1917:1911;continue;}
case 1911:{f.Push(f.Locals[3]);f.Pc=1912;continue;}
case 1912:{f.Push(JValue.I(3));f.Pc=1913;continue;}
case 1913:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1914;continue;}
case 1914:{f.Pc=1918;continue;}
case 1917:{f.Push(JValue.R(null));f.Pc=1918;continue;}
case 1918:{f.Locals[4]=f.Pop();f.Pc=1920;continue;}
case 1920:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPutCardToLib"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPutCardToLib")));f.Pc=1923;continue;}
case 1923:{f.StackOp("dup");f.Pc=1924;continue;}
case 1924:{f.Push(f.Locals[3]);f.Pc=1925;continue;}
case 1925:{f.Push(JValue.I(0));f.Pc=1926;continue;}
case 1926:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1927;continue;}
case 1927:{f.Push(f.Locals[3]);f.Pc=1928;continue;}
case 1928:{f.Push(JValue.I(1));f.Pc=1929;continue;}
case 1929:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1930;continue;}
case 1930:{f.Push(f.Locals[3]);f.Pc=1931;continue;}
case 1931:{f.Push(JValue.I(2));f.Pc=1932;continue;}
case 1932:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1933;continue;}
case 1933:{f.Push(f.Locals[4]);f.Pc=1935;continue;}
case 1935:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=1938;continue;}
case 1938:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;)V","invokespecial",1941);}
case 1941:{return JStep.Return(f.Pop());}
case 1942:{f.Push(f.Locals[0]);f.Pc=1943;continue;}
case 1943:{f.Push(JValue.R(rt.String("PutCardToLibFromGrave<")));f.Pc=1946;continue;}
case 1946:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1949);}
case 1949:{f.Pc=f.Pop().Int==0?1995:1952;continue;}
case 1952:{f.Push(f.Locals[0]);f.Pc=1953;continue;}
case 1953:{f.Push(JValue.I(4));f.Pc=1954;continue;}
case 1954:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",1957);}
case 1957:{f.Locals[3]=f.Pop();f.Pc=1958;continue;}
case 1958:{f.Push(f.Locals[3]);f.Pc=1959;continue;}
case 1959:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=1960;continue;}
case 1960:{f.Push(JValue.I(3));f.Pc=1961;continue;}
case 1961:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1970:1964;continue;}
case 1964:{f.Push(f.Locals[3]);f.Pc=1965;continue;}
case 1965:{f.Push(JValue.I(3));f.Pc=1966;continue;}
case 1966:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1967;continue;}
case 1967:{f.Pc=1971;continue;}
case 1970:{f.Push(JValue.R(null));f.Pc=1971;continue;}
case 1971:{f.Locals[4]=f.Pop();f.Pc=1973;continue;}
case 1973:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPutCardToLib"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPutCardToLib")));f.Pc=1976;continue;}
case 1976:{f.StackOp("dup");f.Pc=1977;continue;}
case 1977:{f.Push(f.Locals[3]);f.Pc=1978;continue;}
case 1978:{f.Push(JValue.I(0));f.Pc=1979;continue;}
case 1979:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1980;continue;}
case 1980:{f.Push(f.Locals[3]);f.Pc=1981;continue;}
case 1981:{f.Push(JValue.I(1));f.Pc=1982;continue;}
case 1982:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1983;continue;}
case 1983:{f.Push(f.Locals[3]);f.Pc=1984;continue;}
case 1984:{f.Push(JValue.I(2));f.Pc=1985;continue;}
case 1985:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1986;continue;}
case 1986:{f.Push(f.Locals[4]);f.Pc=1988;continue;}
case 1988:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=1991;continue;}
case 1991:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;)V","invokespecial",1994);}
case 1994:{return JStep.Return(f.Pop());}
case 1995:{f.Push(f.Locals[0]);f.Pc=1996;continue;}
case 1996:{f.Push(JValue.R(rt.String("PutCardToLibFromSameGrave<")));f.Pc=1999;continue;}
case 1999:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2002);}
case 2002:{f.Pc=f.Pop().Int==0?2049:2005;continue;}
case 2005:{f.Push(f.Locals[0]);f.Pc=2006;continue;}
case 2006:{f.Push(JValue.I(4));f.Pc=2007;continue;}
case 2007:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",2010);}
case 2010:{f.Locals[3]=f.Pop();f.Pc=2011;continue;}
case 2011:{f.Push(f.Locals[3]);f.Pc=2012;continue;}
case 2012:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2013;continue;}
case 2013:{f.Push(JValue.I(3));f.Pc=2014;continue;}
case 2014:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2023:2017;continue;}
case 2017:{f.Push(f.Locals[3]);f.Pc=2018;continue;}
case 2018:{f.Push(JValue.I(3));f.Pc=2019;continue;}
case 2019:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2020;continue;}
case 2020:{f.Pc=2024;continue;}
case 2023:{f.Push(JValue.R(null));f.Pc=2024;continue;}
case 2024:{f.Locals[4]=f.Pop();f.Pc=2026;continue;}
case 2026:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPutCardToLib"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPutCardToLib")));f.Pc=2029;continue;}
case 2029:{f.StackOp("dup");f.Pc=2030;continue;}
case 2030:{f.Push(f.Locals[3]);f.Pc=2031;continue;}
case 2031:{f.Push(JValue.I(0));f.Pc=2032;continue;}
case 2032:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2033;continue;}
case 2033:{f.Push(f.Locals[3]);f.Pc=2034;continue;}
case 2034:{f.Push(JValue.I(1));f.Pc=2035;continue;}
case 2035:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2036;continue;}
case 2036:{f.Push(f.Locals[3]);f.Pc=2037;continue;}
case 2037:{f.Push(JValue.I(2));f.Pc=2038;continue;}
case 2038:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2039;continue;}
case 2039:{f.Push(f.Locals[4]);f.Pc=2041;continue;}
case 2041:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=2044;continue;}
case 2044:{f.Push(JValue.I(1));f.Pc=2045;continue;}
case 2045:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;Z)V","invokespecial",2048);}
case 2048:{return JStep.Return(f.Pop());}
case 2049:{f.Push(f.Locals[0]);f.Pc=2050;continue;}
case 2050:{f.Push(JValue.R(rt.String("PutCardToLibFromBattlefield<")));f.Pc=2053;continue;}
case 2053:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2056);}
case 2056:{f.Pc=f.Pop().Int==0?2102:2059;continue;}
case 2059:{f.Push(f.Locals[0]);f.Pc=2060;continue;}
case 2060:{f.Push(JValue.I(4));f.Pc=2061;continue;}
case 2061:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",2064);}
case 2064:{f.Locals[3]=f.Pop();f.Pc=2065;continue;}
case 2065:{f.Push(f.Locals[3]);f.Pc=2066;continue;}
case 2066:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2067;continue;}
case 2067:{f.Push(JValue.I(3));f.Pc=2068;continue;}
case 2068:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2077:2071;continue;}
case 2071:{f.Push(f.Locals[3]);f.Pc=2072;continue;}
case 2072:{f.Push(JValue.I(3));f.Pc=2073;continue;}
case 2073:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2074;continue;}
case 2074:{f.Pc=2078;continue;}
case 2077:{f.Push(JValue.R(null));f.Pc=2078;continue;}
case 2078:{f.Locals[4]=f.Pop();f.Pc=2080;continue;}
case 2080:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPutCardToLib"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPutCardToLib")));f.Pc=2083;continue;}
case 2083:{f.StackOp("dup");f.Pc=2084;continue;}
case 2084:{f.Push(f.Locals[3]);f.Pc=2085;continue;}
case 2085:{f.Push(JValue.I(0));f.Pc=2086;continue;}
case 2086:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2087;continue;}
case 2087:{f.Push(f.Locals[3]);f.Pc=2088;continue;}
case 2088:{f.Push(JValue.I(1));f.Pc=2089;continue;}
case 2089:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2090;continue;}
case 2090:{f.Push(f.Locals[3]);f.Pc=2091;continue;}
case 2091:{f.Push(JValue.I(2));f.Pc=2092;continue;}
case 2092:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2093;continue;}
case 2093:{f.Push(f.Locals[4]);f.Pc=2095;continue;}
case 2095:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=2098;continue;}
case 2098:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;)V","invokespecial",2101);}
case 2101:{return JStep.Return(f.Pop());}
case 2102:{f.Push(f.Locals[0]);f.Pc=2103;continue;}
case 2103:{f.Push(JValue.R(rt.String("Exert<")));f.Pc=2106;continue;}
case 2106:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2109);}
case 2109:{f.Pc=f.Pop().Int==0?2149:2112;continue;}
case 2112:{f.Push(f.Locals[0]);f.Pc=2113;continue;}
case 2113:{f.Push(JValue.I(3));f.Pc=2114;continue;}
case 2114:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",2117);}
case 2117:{f.Locals[3]=f.Pop();f.Pc=2118;continue;}
case 2118:{f.Push(f.Locals[3]);f.Pc=2119;continue;}
case 2119:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2120;continue;}
case 2120:{f.Push(JValue.I(2));f.Pc=2121;continue;}
case 2121:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2130:2124;continue;}
case 2124:{f.Push(f.Locals[3]);f.Pc=2125;continue;}
case 2125:{f.Push(JValue.I(2));f.Pc=2126;continue;}
case 2126:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2127;continue;}
case 2127:{f.Pc=2131;continue;}
case 2130:{f.Push(JValue.R(null));f.Pc=2131;continue;}
case 2131:{f.Locals[4]=f.Pop();f.Pc=2133;continue;}
case 2133:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostExert"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostExert")));f.Pc=2136;continue;}
case 2136:{f.StackOp("dup");f.Pc=2137;continue;}
case 2137:{f.Push(f.Locals[3]);f.Pc=2138;continue;}
case 2138:{f.Push(JValue.I(0));f.Pc=2139;continue;}
case 2139:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2140;continue;}
case 2140:{f.Push(f.Locals[3]);f.Pc=2141;continue;}
case 2141:{f.Push(JValue.I(1));f.Pc=2142;continue;}
case 2142:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2143;continue;}
case 2143:{f.Push(f.Locals[4]);f.Pc=2145;continue;}
case 2145:{return rt.Call(f,"forge/game/cost/CostExert","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",2148);}
case 2148:{return JStep.Return(f.Pop());}
case 2149:{f.Push(f.Locals[0]);f.Pc=2150;continue;}
case 2150:{f.Push(JValue.R(rt.String("Enlist<")));f.Pc=2153;continue;}
case 2153:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2156);}
case 2156:{f.Pc=f.Pop().Int==0?2196:2159;continue;}
case 2159:{f.Push(f.Locals[0]);f.Pc=2160;continue;}
case 2160:{f.Push(JValue.I(3));f.Pc=2161;continue;}
case 2161:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",2164);}
case 2164:{f.Locals[3]=f.Pop();f.Pc=2165;continue;}
case 2165:{f.Push(f.Locals[3]);f.Pc=2166;continue;}
case 2166:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2167;continue;}
case 2167:{f.Push(JValue.I(2));f.Pc=2168;continue;}
case 2168:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2177:2171;continue;}
case 2171:{f.Push(f.Locals[3]);f.Pc=2172;continue;}
case 2172:{f.Push(JValue.I(2));f.Pc=2173;continue;}
case 2173:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2174;continue;}
case 2174:{f.Pc=2178;continue;}
case 2177:{f.Push(JValue.R(null));f.Pc=2178;continue;}
case 2178:{f.Locals[4]=f.Pop();f.Pc=2180;continue;}
case 2180:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostEnlist"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostEnlist")));f.Pc=2183;continue;}
case 2183:{f.StackOp("dup");f.Pc=2184;continue;}
case 2184:{f.Push(f.Locals[3]);f.Pc=2185;continue;}
case 2185:{f.Push(JValue.I(0));f.Pc=2186;continue;}
case 2186:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2187;continue;}
case 2187:{f.Push(f.Locals[3]);f.Pc=2188;continue;}
case 2188:{f.Push(JValue.I(1));f.Pc=2189;continue;}
case 2189:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2190;continue;}
case 2190:{f.Push(f.Locals[4]);f.Pc=2192;continue;}
case 2192:{return rt.Call(f,"forge/game/cost/CostEnlist","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",2195);}
case 2195:{return JStep.Return(f.Pop());}
case 2196:{f.Push(f.Locals[0]);f.Pc=2197;continue;}
case 2197:{f.Push(JValue.R(rt.String("CollectEvidence<")));f.Pc=2200;continue;}
case 2200:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2203);}
case 2203:{f.Pc=f.Pop().Int==0?2223:2206;continue;}
case 2206:{f.Push(f.Locals[0]);f.Pc=2207;continue;}
case 2207:{f.Push(JValue.I(1));f.Pc=2208;continue;}
case 2208:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",2211);}
case 2211:{f.Locals[3]=f.Pop();f.Pc=2212;continue;}
case 2212:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostCollectEvidence"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostCollectEvidence")));f.Pc=2215;continue;}
case 2215:{f.StackOp("dup");f.Pc=2216;continue;}
case 2216:{f.Push(f.Locals[3]);f.Pc=2217;continue;}
case 2217:{f.Push(JValue.I(0));f.Pc=2218;continue;}
case 2218:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2219;continue;}
case 2219:{return rt.Call(f,"forge/game/cost/CostCollectEvidence","<init>","(Ljava/lang/String;)V","invokespecial",2222);}
case 2222:{return JStep.Return(f.Pop());}
case 2223:{f.Push(f.Locals[0]);f.Pc=2224;continue;}
case 2224:{f.Push(JValue.R(rt.String("RevealChosen<")));f.Pc=2227;continue;}
case 2227:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2230);}
case 2230:{f.Pc=f.Pop().Int==0?2263:2233;continue;}
case 2233:{f.Push(f.Locals[0]);f.Pc=2234;continue;}
case 2234:{f.Push(JValue.I(2));f.Pc=2235;continue;}
case 2235:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",2238);}
case 2238:{f.Locals[3]=f.Pop();f.Pc=2239;continue;}
case 2239:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostRevealChosen"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostRevealChosen")));f.Pc=2242;continue;}
case 2242:{f.StackOp("dup");f.Pc=2243;continue;}
case 2243:{f.Push(f.Locals[3]);f.Pc=2244;continue;}
case 2244:{f.Push(JValue.I(0));f.Pc=2245;continue;}
case 2245:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2246;continue;}
case 2246:{f.Push(f.Locals[3]);f.Pc=2247;continue;}
case 2247:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=2248;continue;}
case 2248:{f.Push(JValue.I(1));f.Pc=2249;continue;}
case 2249:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?2258:2252;continue;}
case 2252:{f.Push(f.Locals[3]);f.Pc=2253;continue;}
case 2253:{f.Push(JValue.I(1));f.Pc=2254;continue;}
case 2254:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2255;continue;}
case 2255:{f.Pc=2259;continue;}
case 2258:{f.Push(JValue.R(null));f.Pc=2259;continue;}
case 2259:{return rt.Call(f,"forge/game/cost/CostRevealChosen","<init>","(Ljava/lang/String;Ljava/lang/String;)V","invokespecial",2262);}
case 2262:{return JStep.Return(f.Pop());}
case 2263:{f.Push(f.Locals[0]);f.Pc=2264;continue;}
case 2264:{f.Push(JValue.R(rt.String("Waterbend<")));f.Pc=2267;continue;}
case 2267:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2270);}
case 2270:{f.Pc=f.Pop().Int==0?2290:2273;continue;}
case 2273:{f.Push(f.Locals[0]);f.Pc=2274;continue;}
case 2274:{f.Push(JValue.I(1));f.Pc=2275;continue;}
case 2275:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",2278);}
case 2278:{f.Locals[3]=f.Pop();f.Pc=2279;continue;}
case 2279:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostWaterbend"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostWaterbend")));f.Pc=2282;continue;}
case 2282:{f.StackOp("dup");f.Pc=2283;continue;}
case 2283:{f.Push(f.Locals[3]);f.Pc=2284;continue;}
case 2284:{f.Push(JValue.I(0));f.Pc=2285;continue;}
case 2285:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2286;continue;}
case 2286:{return rt.Call(f,"forge/game/cost/CostWaterbend","<init>","(Ljava/lang/String;)V","invokespecial",2289);}
case 2289:{return JStep.Return(f.Pop());}
case 2290:{f.Push(f.Locals[0]);f.Pc=2291;continue;}
case 2291:{f.Push(JValue.R(rt.String("Blight<")));f.Pc=2294;continue;}
case 2294:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2297);}
case 2297:{f.Pc=f.Pop().Int==0?2317:2300;continue;}
case 2300:{f.Push(f.Locals[0]);f.Pc=2301;continue;}
case 2301:{f.Push(JValue.I(1));f.Pc=2302;continue;}
case 2302:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",2305);}
case 2305:{f.Locals[3]=f.Pop();f.Pc=2306;continue;}
case 2306:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostBlight"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostBlight")));f.Pc=2309;continue;}
case 2309:{f.StackOp("dup");f.Pc=2310;continue;}
case 2310:{f.Push(f.Locals[3]);f.Pc=2311;continue;}
case 2311:{f.Push(JValue.I(0));f.Pc=2312;continue;}
case 2312:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2313;continue;}
case 2313:{return rt.Call(f,"forge/game/cost/CostBlight","<init>","(Ljava/lang/String;)V","invokespecial",2316);}
case 2316:{return JStep.Return(f.Pop());}
case 2317:{f.Push(f.Locals[0]);f.Pc=2318;continue;}
case 2318:{f.Push(JValue.R(rt.String("Teamwork<")));f.Pc=2321;continue;}
case 2321:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",2324);}
case 2324:{f.Pc=f.Pop().Int==0?2344:2327;continue;}
case 2327:{f.Push(f.Locals[0]);f.Pc=2328;continue;}
case 2328:{f.Push(JValue.I(1));f.Pc=2329;continue;}
case 2329:{return rt.Call(f,"forge/game/cost/Cost","abCostParse","(Ljava/lang/String;I)[Ljava/lang/String;","invokestatic",2332);}
case 2332:{f.Locals[3]=f.Pop();f.Pc=2333;continue;}
case 2333:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostTeamwork"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostTeamwork")));f.Pc=2336;continue;}
case 2336:{f.StackOp("dup");f.Pc=2337;continue;}
case 2337:{f.Push(f.Locals[3]);f.Pc=2338;continue;}
case 2338:{f.Push(JValue.I(0));f.Pc=2339;continue;}
case 2339:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=2340;continue;}
case 2340:{return rt.Call(f,"forge/game/cost/CostTeamwork","<init>","(Ljava/lang/String;)V","invokespecial",2343);}
case 2343:{return JStep.Return(f.Pop());}
case 2344:{f.Push(f.Locals[0]);f.Pc=2345;continue;}
case 2345:{f.Push(JValue.R(rt.String("Forage")));f.Pc=2348;continue;}
case 2348:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2351);}
case 2351:{f.Pc=f.Pop().Int==0?2362:2354;continue;}
case 2354:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostForage"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostForage")));f.Pc=2357;continue;}
case 2357:{f.StackOp("dup");f.Pc=2358;continue;}
case 2358:{return rt.Call(f,"forge/game/cost/CostForage","<init>","()V","invokespecial",2361);}
case 2361:{return JStep.Return(f.Pop());}
case 2362:{f.Push(f.Locals[0]);f.Pc=2363;continue;}
case 2363:{f.Push(JValue.R(rt.String("Untap")));f.Pc=2365;continue;}
case 2365:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2368);}
case 2368:{f.Pc=f.Pop().Int!=0?2380:2371;continue;}
case 2371:{f.Push(f.Locals[0]);f.Pc=2372;continue;}
case 2372:{f.Push(JValue.R(rt.String("Q")));f.Pc=2374;continue;}
case 2374:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2377);}
case 2377:{f.Pc=f.Pop().Int==0?2388:2380;continue;}
case 2380:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostUntap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostUntap")));f.Pc=2383;continue;}
case 2383:{f.StackOp("dup");f.Pc=2384;continue;}
case 2384:{return rt.Call(f,"forge/game/cost/CostUntap","<init>","()V","invokespecial",2387);}
case 2387:{return JStep.Return(f.Pop());}
case 2388:{f.Push(f.Locals[0]);f.Pc=2389;continue;}
case 2389:{f.Push(JValue.R(rt.String("T")));f.Pc=2391;continue;}
case 2391:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2394);}
case 2394:{f.Pc=f.Pop().Int==0?2405:2397;continue;}
case 2397:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostTap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostTap")));f.Pc=2400;continue;}
case 2400:{f.StackOp("dup");f.Pc=2401;continue;}
case 2401:{return rt.Call(f,"forge/game/cost/CostTap","<init>","()V","invokespecial",2404);}
case 2404:{return JStep.Return(f.Pop());}
case 2405:{f.Push(JValue.R(null));f.Pc=2406;continue;}
case 2406:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6189(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String("<")));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",8);}
case 8:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String(">")));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;I)I","invokevirtual",18);}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",25);}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(47));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/util/TextUtil","split","(Ljava/lang/CharSequence;CI)[Ljava/lang/String;","invokestatic",35);}
case 35:{f.Locals[5]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[5]);f.Pc=39;continue;}
case 39:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6190(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/Cost","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","isAbility","Z"));f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","isAbility","Z",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","isMandatory","Z"));f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","isMandatory","Z",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",33);}
case 33:{f.Locals[2]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Int==0?70:43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[3]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/cost/CostPart","copy","()Lforge/game/cost/CostPart;","invokevirtual",61);}
case 61:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",66);}
case 66:{f.StackOp("pop");f.Pc=67;continue;}
case 67:{f.Pc=34;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/cost/Cost","cacheTapCost","()V","invokevirtual",74);}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6191(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/cost/Cost","<init>","(I)V","invokespecial",8);}
case 8:{f.Locals[1]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","isAbility","Z"));f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/Cost","isAbility","Z",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",33);}
case 33:{f.Pc=f.Pop().Int==0?70:36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[3]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPartMana")?1:0));f.Pc=50;continue;}
case 50:{f.Pc=f.Pop().Int!=0?67:53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/cost/CostPart","copy","()Lforge/game/cost/CostPart;","invokevirtual",61);}
case 61:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",66);}
case 66:{f.StackOp("pop");f.Pc=67;continue;}
case 67:{f.Pc=27;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/cost/Cost","cacheTapCost","()V","invokevirtual",74);}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6192(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(Ljava/lang/String;)V","invokespecial",9);}
case 9:{return rt.Call(f,"forge/game/cost/Cost","copyWithDefinedMana","(Lforge/card/mana/ManaCost;)Lforge/game/cost/Cost;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6193(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/Cost","copyWithNoMana","()Lforge/game/cost/Cost;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPartMana"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPartMana")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(null));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/cost/CostPartMana","<init>","(Lforge/card/mana/ManaCost;Ljava/lang/String;)V","invokespecial",18);}
case 18:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/cost/Cost","cacheTapCost","()V","invokevirtual",28);}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6194(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?44:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPartMana")?1:0));f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Int==0?41:36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPartMana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
case 41:{f.Pc=10;continue;}
case 44:{f.Push(JValue.R(null));f.Pc=45;continue;}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6195(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?44:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPayEnergy")?1:0));f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Int==0?41:36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPayEnergy"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
case 41:{f.Pc=10;continue;}
case 44:{f.Push(JValue.R(null));f.Pc=45;continue;}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6196(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?37:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/cost/CostPart","refund","(Lforge/game/card/Card;)V","invokevirtual",34);}
case 34:{f.Pc=10;continue;}
case 37:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6197(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?41:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/cost/CostPart","isUndoable","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int!=0?38:36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 38:{f.Pc=10;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6198(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?41:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/cost/CostPart","isReusable","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int!=0?38:36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 38:{f.Pc=10;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","isAbility","Z"));f.Pc=45;continue;}
case 45:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6199(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?41:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/cost/CostPart","isRenewable","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int!=0?38:36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 38:{f.Pc=10;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","isAbility","Z"));f.Pc=45;continue;}
case 45:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6200(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","isAbility","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?12:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/cost/Cost","abilityToString","()Ljava/lang/String;","invokevirtual",11);}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/cost/Cost","spellToString","(Z)Ljava/lang/String;","invokevirtual",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6201(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/Cost","spellToString","(Z)Ljava/lang/String;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6202(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",19);}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?67:29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Pc=f.Pop().Int!=0?52:44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String(", ")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",51);}
case 51:{f.StackOp("pop");f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[4]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/cost/CostPart","toString","()Ljava/lang/String;","invokevirtual",58);}
case 58:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Push(JValue.I(0));f.Pc=63;continue;}
case 63:{f.Locals[2]=f.Pop();f.Pc=64;continue;}
case 64:{f.Pc=20;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",71);}
case 71:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6203(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int==0?22:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("As an additional cost to cast this spell, ")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[4]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Int==0?113:43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Locals[5]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPartMana")?1:0));f.Pc=60;continue;}
case 60:{f.Pc=f.Pop().Int==0?66:63;continue;}
case 63:{f.Pc=33;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{f.Pc=f.Pop().Int!=0?78:70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.String(" and ")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",77);}
case 77:{f.StackOp("pop");f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{f.Pc=f.Pop().Int==0?98:82;continue;}
case 82:{f.Push(f.Locals[2]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[5]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/cost/CostPart","toString","()Ljava/lang/String;","invokevirtual",88);}
case 88:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","uncapitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",91);}
case 91:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",94);}
case 94:{f.StackOp("pop");f.Pc=95;continue;}
case 95:{f.Pc=108;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[5]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/cost/CostPart","toString","()Ljava/lang/String;","invokevirtual",104);}
case 104:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",107);}
case 107:{f.StackOp("pop");f.Pc=108;continue;}
case 108:{f.Push(JValue.I(0));f.Pc=109;continue;}
case 109:{f.Locals[3]=f.Pop();f.Pc=110;continue;}
case 110:{f.Pc=33;continue;}
case 113:{f.Push(f.Locals[3]);f.Pc=114;continue;}
case 114:{f.Pc=f.Pop().Int==0?120:117;continue;}
case 117:{f.Push(JValue.R(rt.String("")));f.Pc=119;continue;}
case 119:{return JStep.Return(f.Pop());}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{f.Pc=f.Pop().Int==0?138:124;continue;}
case 124:{f.Push(f.Locals[2]);f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String(".")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",131);}
case 131:{f.Push(JValue.R(rt.String("\n")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",137);}
case 137:{f.StackOp("pop");f.Pc=138;continue;}
case 138:{f.Push(f.Locals[2]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",142);}
case 142:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6204(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",19);}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?101:29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{f.Locals[5]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Int!=0?84:47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPartMana")?1:0));f.Pc=52;continue;}
case 52:{f.Pc=f.Pop().Int==0?76:55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String(", ")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/StringBuilder","insert","(ILjava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",63);}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/StringBuilder","insert","(ILjava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",69);}
case 69:{f.StackOp("pop");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(0));f.Pc=71;continue;}
case 71:{f.Locals[5]=f.Pop();f.Pc=73;continue;}
case 73:{f.Pc=84;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String(", ")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",83);}
case 83:{f.StackOp("pop");f.Pc=84;continue;}
case 84:{f.Push(f.Locals[5]);f.Pc=86;continue;}
case 86:{f.Pc=f.Pop().Int==0?96:89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",95);}
case 95:{f.StackOp("pop");f.Pc=96;continue;}
case 96:{f.Push(JValue.I(0));f.Pc=97;continue;}
case 97:{f.Locals[2]=f.Pop();f.Pc=98;continue;}
case 98:{f.Pc=20;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{f.Pc=f.Pop().Int==0?113:105;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("0")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",112);}
case 112:{f.StackOp("pop");f.Pc=113;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",117);}
case 117:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6205(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?10:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/cost/Cost","convertAmountTypeToWords","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",9);}
case 9:{return JStep.Return(f.Pop());}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",14);}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/cost/Cost","convertIntAndTypeToWords","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6206(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?17:5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("another")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?17:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
case 17:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",24);}
case 24:{f.Locals[2]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{if(!rt.StaticReady(f,"forge/game/cost/Cost","NUM_NAMES","[Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/cost/Cost","NUM_NAMES","[Ljava/lang/String;"));f.Pc=29;continue;}
case 29:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=30;continue;}
case 30:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?42:33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",38);}
case 38:{f.StackOp("pop");f.Pc=39;continue;}
case 39:{f.Pc=75;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?65:47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/util/Lang","startsWithVowel","(Ljava/lang/String;)Z","invokestatic",51);}
case 51:{f.Pc=f.Pop().Int==0?65:54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("an")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Pc=75;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{if(!rt.StaticReady(f,"forge/game/cost/Cost","NUM_NAMES","[Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/cost/Cost","NUM_NAMES","[Ljava/lang/String;"));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String(" ")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",81);}
case 81:{f.StackOp("pop");f.Pc=82;continue;}
case 82:{f.Push(JValue.I(1));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?195:87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String(" ")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",93);}
case 93:{f.Locals[3]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[3]);f.Pc=96;continue;}
case 96:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=97;continue;}
case 97:{f.Push(JValue.I(1));f.Pc=98;continue;}
case 98:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=99;continue;}
case 99:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=100;continue;}
case 100:{f.Locals[4]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[4]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("s")));f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",110);}
case 110:{f.Pc=f.Pop().Int==0?147:113;continue;}
case 113:{f.Push(f.Locals[4]);f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String("us")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int!=0?147:124;continue;}
case 124:{f.Push(f.Locals[4]);f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("ss")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",132);}
case 132:{f.Pc=f.Pop().Int!=0?147:135;continue;}
case 135:{f.Push(f.Locals[4]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/card/CardType","isASubType","(Ljava/lang/String;)Z","invokestatic",140);}
case 140:{f.Pc=f.Pop().Int!=0?147:143;continue;}
case 143:{f.Push(JValue.I(1));f.Pc=144;continue;}
case 144:{f.Pc=148;continue;}
case 147:{f.Push(JValue.I(0));f.Pc=148;continue;}
case 148:{f.Locals[5]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[2]);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[5]);f.Pc=153;continue;}
case 153:{f.Pc=f.Pop().Int==0?160:156;continue;}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{f.Pc=188;continue;}
case 160:{f.Push(f.Locals[4]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/card/CardType","isASubType","(Ljava/lang/String;)Z","invokestatic",165);}
case 165:{f.Pc=f.Pop().Int==0?182:168;continue;}
case 168:{f.Push(f.Locals[1]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[4]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[4]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/card/CardType","getPluralType","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",176);}
case 176:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",179);}
case 179:{f.Pc=188;continue;}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{return rt.DynamicCall(f,"forge/game/cost/Cost:6206:183:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",188);}
case 188:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",191);}
case 191:{f.StackOp("pop");f.Pc=192;continue;}
case 192:{f.Pc=201;continue;}
case 195:{f.Push(f.Locals[2]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[1]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",200);}
case 200:{f.StackOp("pop");f.Pc=201;continue;}
case 201:{f.Push(f.Locals[2]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",205);}
case 205:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6207(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",13);}
case 13:{f.StackOp("pop");f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String(" ")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",20);}
case 20:{f.StackOp("pop");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",31);}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6208(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?33:5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/cost/Cost","copy","()Lforge/game/cost/Cost;","invokevirtual",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{f.Locals[5]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[5]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?33:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;)Lforge/game/cost/Cost;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=30;continue;}
case 30:{f.Pc=14;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;ZLforge/game/spellability/SpellAbility;)Lforge/game/cost/Cost;","invokevirtual",40);}
case 40:{f.StackOp("pop");f.Pc=41;continue;}
case 41:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6209(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;Z)Lforge/game/cost/Cost;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6210(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/Cost","add","(Lforge/game/cost/Cost;ZLforge/game/spellability/SpellAbility;)Lforge/game/cost/Cost;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6211(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",9);}
case 9:{f.Locals[5]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/cost/Cost","getCostParts","()Ljava/util/List;","invokevirtual",15);}
case 15:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",20);}
case 20:{f.Locals[6]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[6]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?1060:32;continue;}
case 32:{f.Push(f.Locals[6]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{f.Locals[7]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[7]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPartMana")?1:0));f.Pc=49;continue;}
case 49:{f.Pc=f.Pop().Int==0?69:52;continue;}
case 52:{f.Push(f.Locals[7]);f.Pc=54;continue;}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPartMana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/cost/CostPartMana","getMana","()Lforge/card/mana/ManaCost;","invokevirtual",60);}
case 60:{return rt.Call(f,"forge/card/mana/ManaCost","isZero","()Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?69:66;continue;}
case 66:{f.Pc=22;continue;}
case 69:{f.Push(f.Locals[7]);f.Pc=71;continue;}
case 71:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPartMana")?1:0));f.Pc=74;continue;}
case 74:{f.Pc=f.Pop().Int==0?252:77;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{f.Pc=f.Pop().Reference==null?252:82;continue;}
case 82:{f.Push(f.Locals[7]);f.Pc=84;continue;}
case 84:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPartMana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=87;continue;}
case 87:{f.Locals[8]=f.Pop();f.Pc=89;continue;}
case 89:{if(!rt.EnsureInitialized(f,"forge/game/mana/ManaCostBeingPaid"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/ManaCostBeingPaid")));f.Pc=92;continue;}
case 92:{f.StackOp("dup");f.Pc=93;continue;}
case 93:{f.Push(f.Locals[8]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/cost/CostPartMana","getMana","()Lforge/card/mana/ManaCost;","invokevirtual",98);}
case 98:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","<init>","(Lforge/card/mana/ManaCost;)V","invokespecial",101);}
case 101:{f.Locals[9]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=107;continue;}
case 107:{f.Push(f.Locals[4]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",114);}
case 114:{f.StackOp("pop");f.Pc=115;continue;}
case 115:{f.Push(f.Locals[8]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/cost/CostPartMana","getXMin","()I","invokevirtual",120);}
case 120:{f.Push(f.Locals[4]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/cost/CostPartMana","getXMin","()I","invokevirtual",125);}
case 125:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",128);}
case 128:{f.Locals[10]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[9]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[4]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/cost/CostPartMana","getMana","()Lforge/card/mana/ManaCost;","invokevirtual",137);}
case 137:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","addManaCost","(Lforge/card/mana/ManaCost;)V","invokevirtual",140);}
case 140:{f.Push(f.Locals[4]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/cost/CostPartMana","isExiledCreatureCost","()Z","invokevirtual",145);}
case 145:{f.Pc=f.Pop().Int!=0?161:148;continue;}
case 148:{f.Push(f.Locals[4]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/cost/CostPartMana","isEnchantedCreatureCost","()Z","invokevirtual",153);}
case 153:{f.Pc=f.Pop().Int!=0?161:156;continue;}
case 156:{f.Push(f.Locals[10]);f.Pc=158;continue;}
case 158:{f.Pc=f.Pop().Int<=0?198:161;continue;}
case 161:{f.Push(f.Locals[0]);f.Pc=162;continue;}
case 162:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=165;continue;}
case 165:{f.Push(JValue.I(0));f.Pc=166;continue;}
case 166:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPartMana"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPartMana")));f.Pc=169;continue;}
case 169:{f.StackOp("dup");f.Pc=170;continue;}
case 170:{f.Push(f.Locals[9]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","toManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",175);}
case 175:{f.Push(f.Locals[4]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/cost/CostPartMana","isExiledCreatureCost","()Z","invokevirtual",180);}
case 180:{f.Push(f.Locals[4]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/cost/CostPartMana","isEnchantedCreatureCost","()Z","invokevirtual",185);}
case 185:{f.Push(f.Locals[10]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/cost/CostPartMana","<init>","(Lforge/card/mana/ManaCost;ZZI)V","invokespecial",190);}
case 190:{return rt.Call(f,"java/util/List","add","(ILjava/lang/Object;)V","invokeinterface",195);}
case 195:{f.Pc=221;continue;}
case 198:{f.Push(f.Locals[0]);f.Pc=199;continue;}
case 199:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=202;continue;}
case 202:{f.Push(JValue.I(0));f.Pc=203;continue;}
case 203:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPartMana"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPartMana")));f.Pc=206;continue;}
case 206:{f.StackOp("dup");f.Pc=207;continue;}
case 207:{f.Push(f.Locals[9]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","toManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",212);}
case 212:{f.Push(JValue.R(null));f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/cost/CostPartMana","<init>","(Lforge/card/mana/ManaCost;Ljava/lang/String;)V","invokespecial",216);}
case 216:{return rt.Call(f,"java/util/List","add","(ILjava/lang/Object;)V","invokeinterface",221);}
case 221:{f.Push(f.Locals[0]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",225);}
case 225:{f.Push(f.Locals[8]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/cost/CostPartMana","getMaxWaterbend","()Ljava/lang/String;","invokevirtual",230);}
case 230:{f.Pc=f.Pop().Reference==null?241:233;continue;}
case 233:{f.Push(f.Locals[8]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/cost/CostPartMana","getMaxWaterbend","()Ljava/lang/String;","invokevirtual",238);}
case 238:{f.Pc=246;continue;}
case 241:{f.Push(f.Locals[4]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/cost/CostPartMana","getMaxWaterbend","()Ljava/lang/String;","invokevirtual",246);}
case 246:{return rt.Call(f,"forge/game/cost/CostPartMana","setMaxWaterbend","(Ljava/lang/String;)V","invokevirtual",249);}
case 249:{f.Pc=1057;continue;}
case 252:{f.Push(f.Locals[7]);f.Pc=254;continue;}
case 254:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPutCounter")?1:0));f.Pc=257;continue;}
case 257:{f.Pc=f.Pop().Int!=0?320:260;continue;}
case 260:{f.Push(f.Locals[2]);f.Pc=261;continue;}
case 261:{f.Pc=f.Pop().Int==0?1045:264;continue;}
case 264:{f.Push(f.Locals[7]);f.Pc=266;continue;}
case 266:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostDiscard")?1:0));f.Pc=269;continue;}
case 269:{f.Pc=f.Pop().Int!=0?320:272;continue;}
case 272:{f.Push(f.Locals[7]);f.Pc=274;continue;}
case 274:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostDraw")?1:0));f.Pc=277;continue;}
case 277:{f.Pc=f.Pop().Int!=0?320:280;continue;}
case 280:{f.Push(f.Locals[7]);f.Pc=282;continue;}
case 282:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostAddMana")?1:0));f.Pc=285;continue;}
case 285:{f.Pc=f.Pop().Int!=0?320:288;continue;}
case 288:{f.Push(f.Locals[7]);f.Pc=290;continue;}
case 290:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPayLife")?1:0));f.Pc=293;continue;}
case 293:{f.Pc=f.Pop().Int!=0?320:296;continue;}
case 296:{f.Push(f.Locals[7]);f.Pc=298;continue;}
case 298:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostSacrifice")?1:0));f.Pc=301;continue;}
case 301:{f.Pc=f.Pop().Int!=0?320:304;continue;}
case 304:{f.Push(f.Locals[7]);f.Pc=306;continue;}
case 306:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostTapType")?1:0));f.Pc=309;continue;}
case 309:{f.Pc=f.Pop().Int!=0?320:312;continue;}
case 312:{f.Push(f.Locals[7]);f.Pc=314;continue;}
case 314:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostExile")?1:0));f.Pc=317;continue;}
case 317:{f.Pc=f.Pop().Int==0?1045:320;continue;}
case 320:{f.Push(JValue.I(0));f.Pc=321;continue;}
case 321:{f.Locals[8]=f.Pop();f.Pc=323;continue;}
case 323:{f.Push(f.Locals[0]);f.Pc=324;continue;}
case 324:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=327;continue;}
case 327:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",332);}
case 332:{f.Locals[9]=f.Pop();f.Pc=334;continue;}
case 334:{f.Push(f.Locals[9]);f.Pc=336;continue;}
case 336:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",341);}
case 341:{f.Pc=f.Pop().Int==0?1025:344;continue;}
case 344:{f.Push(f.Locals[9]);f.Pc=346;continue;}
case 346:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",351);}
case 351:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=354;continue;}
case 354:{f.Locals[10]=f.Pop();f.Pc=356;continue;}
case 356:{f.Push(f.Locals[10]);f.Pc=358;continue;}
case 358:{return rt.Call(f,"forge/game/cost/CostPart","convertAmount","()Ljava/lang/Integer;","invokevirtual",361);}
case 361:{f.Locals[11]=f.Pop();f.Pc=363;continue;}
case 363:{f.Push(f.Locals[11]);f.Pc=365;continue;}
case 365:{f.Pc=f.Pop().Reference!=null?390:368;continue;}
case 368:{f.Push(f.Locals[3]);f.Pc=369;continue;}
case 369:{f.Pc=f.Pop().Reference==null?390:372;continue;}
case 372:{f.Push(f.Locals[3]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/game/spellability/SpellAbility","isPwAbility","()Z","invokevirtual",376);}
case 376:{f.Pc=f.Pop().Int==0?390:379;continue;}
case 379:{f.Push(f.Locals[10]);f.Pc=381;continue;}
case 381:{f.Push(f.Locals[3]);f.Pc=382;continue;}
case 382:{return rt.Call(f,"forge/game/cost/CostPart","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",385);}
case 385:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",388);}
case 388:{f.Locals[11]=f.Pop();f.Pc=390;continue;}
case 390:{f.Push(f.Locals[10]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",395);}
case 395:{f.Push(f.Locals[7]);f.Pc=397;continue;}
case 397:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",400);}
case 400:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",403);}
case 403:{f.Pc=f.Pop().Int!=0?433:406;continue;}
case 406:{f.Push(f.Locals[7]);f.Pc=408;continue;}
case 408:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPutCounter")?1:0));f.Pc=411;continue;}
case 411:{f.Pc=f.Pop().Int==0?1022:414;continue;}
case 414:{f.Push(f.Locals[7]);f.Pc=416;continue;}
case 416:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPutCounter"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=419;continue;}
case 419:{return rt.Call(f,"forge/game/cost/CostPutCounter","getCounter","()Lforge/game/card/CounterType;","invokevirtual",422);}
case 422:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"));f.Pc=425;continue;}
case 425:{return rt.Call(f,"forge/game/card/CounterType","is","(Lforge/game/card/CounterEnumType;)Z","invokeinterface",430);}
case 430:{f.Pc=f.Pop().Int==0?1022:433;continue;}
case 433:{f.Push(f.Locals[7]);f.Pc=435;continue;}
case 435:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",438);}
case 438:{f.Push(f.Locals[10]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",443);}
case 443:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",446);}
case 446:{f.Pc=f.Pop().Int==0?1022:449;continue;}
case 449:{f.Push(f.Locals[7]);f.Pc=451;continue;}
case 451:{return rt.Call(f,"forge/game/cost/CostPart","getAmount","()Ljava/lang/String;","invokevirtual",454);}
case 454:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",457);}
case 457:{f.Pc=f.Pop().Int==0?1022:460;continue;}
case 460:{f.Push(f.Locals[11]);f.Pc=462;continue;}
case 462:{f.Pc=f.Pop().Reference==null?1022:465;continue;}
case 465:{f.Push(f.Locals[7]);f.Pc=467;continue;}
case 467:{return rt.Call(f,"forge/game/cost/CostPart","convertAmount","()Ljava/lang/Integer;","invokevirtual",470);}
case 470:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",473);}
case 473:{f.Push(f.Locals[11]);f.Pc=475;continue;}
case 475:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",478);}
case 478:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=479;continue;}
case 479:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",482);}
case 482:{f.Locals[12]=f.Pop();f.Pc=484;continue;}
case 484:{f.Push(f.Locals[7]);f.Pc=486;continue;}
case 486:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPutCounter")?1:0));f.Pc=489;continue;}
case 489:{f.Pc=f.Pop().Int==0?711:492;continue;}
case 492:{f.Push(f.Locals[10]);f.Pc=494;continue;}
case 494:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPutCounter")?1:0));f.Pc=497;continue;}
case 497:{f.Pc=f.Pop().Int==0?562:500;continue;}
case 500:{f.Push(f.Locals[10]);f.Pc=502;continue;}
case 502:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPutCounter"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=505;continue;}
case 505:{return rt.Call(f,"forge/game/cost/CostPutCounter","getCounter","()Lforge/game/card/CounterType;","invokevirtual",508);}
case 508:{f.Push(f.Locals[7]);f.Pc=510;continue;}
case 510:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPutCounter"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=513;continue;}
case 513:{return rt.Call(f,"forge/game/cost/CostPutCounter","getCounter","()Lforge/game/card/CounterType;","invokevirtual",516);}
case 516:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",519);}
case 519:{f.Pc=f.Pop().Int==0?562:522;continue;}
case 522:{f.Push(f.Locals[0]);f.Pc=523;continue;}
case 523:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=526;continue;}
case 526:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPutCounter"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPutCounter")));f.Pc=529;continue;}
case 529:{f.StackOp("dup");f.Pc=530;continue;}
case 530:{f.Push(f.Locals[12]);f.Pc=532;continue;}
case 532:{f.Push(f.Locals[7]);f.Pc=534;continue;}
case 534:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPutCounter"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=537;continue;}
case 537:{return rt.Call(f,"forge/game/cost/CostPutCounter","getCounter","()Lforge/game/card/CounterType;","invokevirtual",540);}
case 540:{f.Push(f.Locals[7]);f.Pc=542;continue;}
case 542:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",545);}
case 545:{f.Push(f.Locals[7]);f.Pc=547;continue;}
case 547:{return rt.Call(f,"forge/game/cost/CostPart","getTypeDescription","()Ljava/lang/String;","invokevirtual",550);}
case 550:{return rt.Call(f,"forge/game/cost/CostPutCounter","<init>","(Ljava/lang/String;Lforge/game/card/CounterType;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",553);}
case 553:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",558);}
case 558:{f.StackOp("pop");f.Pc=559;continue;}
case 559:{f.Pc=1006;continue;}
case 562:{f.Push(f.Locals[10]);f.Pc=564;continue;}
case 564:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostRemoveCounter")?1:0));f.Pc=567;continue;}
case 567:{f.Pc=f.Pop().Int==0?334:570;continue;}
case 570:{f.Push(f.Locals[10]);f.Pc=572;continue;}
case 572:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostRemoveCounter"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=575;continue;}
case 575:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostRemoveCounter","counter","Lforge/game/card/CounterType;"));f.Pc=578;continue;}
case 578:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"));f.Pc=581;continue;}
case 581:{return rt.Call(f,"forge/game/card/CounterType","is","(Lforge/game/card/CounterEnumType;)Z","invokeinterface",586);}
case 586:{f.Pc=f.Pop().Int==0?334:589;continue;}
case 589:{f.Push(f.Locals[11]);f.Pc=591;continue;}
case 591:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",594);}
case 594:{f.Push(f.Locals[7]);f.Pc=596;continue;}
case 596:{return rt.Call(f,"forge/game/cost/CostPart","convertAmount","()Ljava/lang/Integer;","invokevirtual",599);}
case 599:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",602);}
case 602:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=603;continue;}
case 603:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",606);}
case 606:{f.Locals[13]=f.Pop();f.Pc=608;continue;}
case 608:{f.Push(f.Locals[13]);f.Pc=610;continue;}
case 610:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",613);}
case 613:{f.Pc=f.Pop().Int>=0?659:616;continue;}
case 616:{f.Push(f.Locals[0]);f.Pc=617;continue;}
case 617:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=620;continue;}
case 620:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPutCounter"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPutCounter")));f.Pc=623;continue;}
case 623:{f.StackOp("dup");f.Pc=624;continue;}
case 624:{f.Push(f.Locals[13]);f.Pc=626;continue;}
case 626:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",629);}
case 629:{f.Push(JValue.I(-1));f.Pc=630;continue;}
case 630:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=631;continue;}
case 631:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",634);}
case 634:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"));f.Pc=637;continue;}
case 637:{f.Push(f.Locals[7]);f.Pc=639;continue;}
case 639:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",642);}
case 642:{f.Push(f.Locals[7]);f.Pc=644;continue;}
case 644:{return rt.Call(f,"forge/game/cost/CostPart","getTypeDescription","()Ljava/lang/String;","invokevirtual",647);}
case 647:{return rt.Call(f,"forge/game/cost/CostPutCounter","<init>","(Ljava/lang/String;Lforge/game/card/CounterType;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",650);}
case 650:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",655);}
case 655:{f.StackOp("pop");f.Pc=656;continue;}
case 656:{f.Pc=708;continue;}
case 659:{f.Push(f.Locals[0]);f.Pc=660;continue;}
case 660:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=663;continue;}
case 663:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostRemoveCounter"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostRemoveCounter")));f.Pc=666;continue;}
case 666:{f.StackOp("dup");f.Pc=667;continue;}
case 667:{f.Push(f.Locals[13]);f.Pc=669;continue;}
case 669:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",672);}
case 672:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"));f.Pc=675;continue;}
case 675:{f.Push(f.Locals[7]);f.Pc=677;continue;}
case 677:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",680);}
case 680:{f.Push(f.Locals[7]);f.Pc=682;continue;}
case 682:{return rt.Call(f,"forge/game/cost/CostPart","getTypeDescription","()Ljava/lang/String;","invokevirtual",685);}
case 685:{f.Push(JValue.I(1));f.Pc=686;continue;}
case 686:{f.Push(JValue.R(rt.NewArray("Lforge/game/zone/ZoneType;",f.Pop().Int)));f.Pc=689;continue;}
case 689:{f.StackOp("dup");f.Pc=690;continue;}
case 690:{f.Push(JValue.I(0));f.Pc=691;continue;}
case 691:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=694;continue;}
case 694:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=695;continue;}
case 695:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",698);}
case 698:{f.Push(JValue.I(0));f.Pc=699;continue;}
case 699:{return rt.Call(f,"forge/game/cost/CostRemoveCounter","<init>","(Ljava/lang/String;Lforge/game/card/CounterType;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Z)V","invokespecial",702);}
case 702:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",707);}
case 707:{f.StackOp("pop");f.Pc=708;continue;}
case 708:{f.Pc=1006;continue;}
case 711:{f.Push(f.Locals[7]);f.Pc=713;continue;}
case 713:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostSacrifice")?1:0));f.Pc=716;continue;}
case 716:{f.Pc=f.Pop().Int==0?751:719;continue;}
case 719:{f.Push(f.Locals[0]);f.Pc=720;continue;}
case 720:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=723;continue;}
case 723:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostSacrifice"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostSacrifice")));f.Pc=726;continue;}
case 726:{f.StackOp("dup");f.Pc=727;continue;}
case 727:{f.Push(f.Locals[12]);f.Pc=729;continue;}
case 729:{f.Push(f.Locals[7]);f.Pc=731;continue;}
case 731:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",734);}
case 734:{f.Push(f.Locals[7]);f.Pc=736;continue;}
case 736:{return rt.Call(f,"forge/game/cost/CostPart","getTypeDescription","()Ljava/lang/String;","invokevirtual",739);}
case 739:{return rt.Call(f,"forge/game/cost/CostSacrifice","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",742);}
case 742:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",747);}
case 747:{f.StackOp("pop");f.Pc=748;continue;}
case 748:{f.Pc=1006;continue;}
case 751:{f.Push(f.Locals[7]);f.Pc=753;continue;}
case 753:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostDiscard")?1:0));f.Pc=756;continue;}
case 756:{f.Pc=f.Pop().Int==0?791:759;continue;}
case 759:{f.Push(f.Locals[0]);f.Pc=760;continue;}
case 760:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=763;continue;}
case 763:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostDiscard"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostDiscard")));f.Pc=766;continue;}
case 766:{f.StackOp("dup");f.Pc=767;continue;}
case 767:{f.Push(f.Locals[12]);f.Pc=769;continue;}
case 769:{f.Push(f.Locals[7]);f.Pc=771;continue;}
case 771:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",774);}
case 774:{f.Push(f.Locals[7]);f.Pc=776;continue;}
case 776:{return rt.Call(f,"forge/game/cost/CostPart","getTypeDescription","()Ljava/lang/String;","invokevirtual",779);}
case 779:{return rt.Call(f,"forge/game/cost/CostDiscard","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",782);}
case 782:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",787);}
case 787:{f.StackOp("pop");f.Pc=788;continue;}
case 788:{f.Pc=1006;continue;}
case 791:{f.Push(f.Locals[7]);f.Pc=793;continue;}
case 793:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostDraw")?1:0));f.Pc=796;continue;}
case 796:{f.Pc=f.Pop().Int==0?826:799;continue;}
case 799:{f.Push(f.Locals[0]);f.Pc=800;continue;}
case 800:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=803;continue;}
case 803:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostDraw"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostDraw")));f.Pc=806;continue;}
case 806:{f.StackOp("dup");f.Pc=807;continue;}
case 807:{f.Push(f.Locals[12]);f.Pc=809;continue;}
case 809:{f.Push(f.Locals[7]);f.Pc=811;continue;}
case 811:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",814);}
case 814:{return rt.Call(f,"forge/game/cost/CostDraw","<init>","(Ljava/lang/String;Ljava/lang/String;)V","invokespecial",817);}
case 817:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",822);}
case 822:{f.StackOp("pop");f.Pc=823;continue;}
case 823:{f.Pc=1006;continue;}
case 826:{f.Push(f.Locals[7]);f.Pc=828;continue;}
case 828:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostTapType")?1:0));f.Pc=831;continue;}
case 831:{f.Pc=f.Pop().Int==0?886:834;continue;}
case 834:{f.Push(f.Locals[7]);f.Pc=836;continue;}
case 836:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostTapType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=839;continue;}
case 839:{f.Locals[13]=f.Pop();f.Pc=841;continue;}
case 841:{f.Push(f.Locals[0]);f.Pc=842;continue;}
case 842:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=845;continue;}
case 845:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostTapType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostTapType")));f.Pc=848;continue;}
case 848:{f.StackOp("dup");f.Pc=849;continue;}
case 849:{f.Push(f.Locals[12]);f.Pc=851;continue;}
case 851:{f.Push(f.Locals[7]);f.Pc=853;continue;}
case 853:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",856);}
case 856:{f.Push(f.Locals[7]);f.Pc=858;continue;}
case 858:{return rt.Call(f,"forge/game/cost/CostPart","getTypeDescription","()Ljava/lang/String;","invokevirtual",861);}
case 861:{f.Push(f.Locals[13]);f.Pc=863;continue;}
case 863:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostTapType","canTapSource","Z"));f.Pc=866;continue;}
case 866:{f.Pc=f.Pop().Int!=0?873:869;continue;}
case 869:{f.Push(JValue.I(1));f.Pc=870;continue;}
case 870:{f.Pc=874;continue;}
case 873:{f.Push(JValue.I(0));f.Pc=874;continue;}
case 874:{return rt.Call(f,"forge/game/cost/CostTapType","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V","invokespecial",877);}
case 877:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",882);}
case 882:{f.StackOp("pop");f.Pc=883;continue;}
case 883:{f.Pc=1006;continue;}
case 886:{f.Push(f.Locals[7]);f.Pc=888;continue;}
case 888:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostAddMana")?1:0));f.Pc=891;continue;}
case 891:{f.Pc=f.Pop().Int==0?926:894;continue;}
case 894:{f.Push(f.Locals[0]);f.Pc=895;continue;}
case 895:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=898;continue;}
case 898:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostAddMana"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostAddMana")));f.Pc=901;continue;}
case 901:{f.StackOp("dup");f.Pc=902;continue;}
case 902:{f.Push(f.Locals[12]);f.Pc=904;continue;}
case 904:{f.Push(f.Locals[7]);f.Pc=906;continue;}
case 906:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",909);}
case 909:{f.Push(f.Locals[7]);f.Pc=911;continue;}
case 911:{return rt.Call(f,"forge/game/cost/CostPart","getTypeDescription","()Ljava/lang/String;","invokevirtual",914);}
case 914:{return rt.Call(f,"forge/game/cost/CostAddMana","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",917);}
case 917:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",922);}
case 922:{f.StackOp("pop");f.Pc=923;continue;}
case 923:{f.Pc=1006;continue;}
case 926:{f.Push(f.Locals[7]);f.Pc=928;continue;}
case 928:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPayLife")?1:0));f.Pc=931;continue;}
case 931:{f.Pc=f.Pop().Int==0?961:934;continue;}
case 934:{f.Push(f.Locals[0]);f.Pc=935;continue;}
case 935:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=938;continue;}
case 938:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostPayLife"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostPayLife")));f.Pc=941;continue;}
case 941:{f.StackOp("dup");f.Pc=942;continue;}
case 942:{f.Push(f.Locals[12]);f.Pc=944;continue;}
case 944:{f.Push(f.Locals[7]);f.Pc=946;continue;}
case 946:{return rt.Call(f,"forge/game/cost/CostPart","getTypeDescription","()Ljava/lang/String;","invokevirtual",949);}
case 949:{return rt.Call(f,"forge/game/cost/CostPayLife","<init>","(Ljava/lang/String;Ljava/lang/String;)V","invokespecial",952);}
case 952:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",957);}
case 957:{f.StackOp("pop");f.Pc=958;continue;}
case 958:{f.Pc=1006;continue;}
case 961:{f.Push(f.Locals[7]);f.Pc=963;continue;}
case 963:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostExile")?1:0));f.Pc=966;continue;}
case 966:{f.Pc=f.Pop().Int==0?1006:969;continue;}
case 969:{f.Push(f.Locals[0]);f.Pc=970;continue;}
case 970:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=973;continue;}
case 973:{if(!rt.EnsureInitialized(f,"forge/game/cost/CostExile"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/CostExile")));f.Pc=976;continue;}
case 976:{f.StackOp("dup");f.Pc=977;continue;}
case 977:{f.Push(f.Locals[12]);f.Pc=979;continue;}
case 979:{f.Push(f.Locals[7]);f.Pc=981;continue;}
case 981:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",984);}
case 984:{f.Push(f.Locals[7]);f.Pc=986;continue;}
case 986:{return rt.Call(f,"forge/game/cost/CostPart","getTypeDescription","()Ljava/lang/String;","invokevirtual",989);}
case 989:{f.Push(f.Locals[7]);f.Pc=991;continue;}
case 991:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostExile"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=994;continue;}
case 994:{return rt.Call(f,"forge/game/cost/CostExile","getFrom","()Ljava/util/List;","invokevirtual",997);}
case 997:{return rt.Call(f,"forge/game/cost/CostExile","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V","invokespecial",1000);}
case 1000:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1005);}
case 1005:{f.StackOp("pop");f.Pc=1006;continue;}
case 1006:{f.Push(f.Locals[5]);f.Pc=1008;continue;}
case 1008:{f.Push(f.Locals[10]);f.Pc=1010;continue;}
case 1010:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1015);}
case 1015:{f.StackOp("pop");f.Pc=1016;continue;}
case 1016:{f.Push(JValue.I(1));f.Pc=1017;continue;}
case 1017:{f.Locals[8]=f.Pop();f.Pc=1019;continue;}
case 1019:{f.Pc=1025;continue;}
case 1022:{f.Pc=334;continue;}
case 1025:{f.Push(f.Locals[8]);f.Pc=1027;continue;}
case 1027:{f.Pc=f.Pop().Int!=0?1042:1030;continue;}
case 1030:{f.Push(f.Locals[0]);f.Pc=1031;continue;}
case 1031:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=1034;continue;}
case 1034:{f.Push(f.Locals[7]);f.Pc=1036;continue;}
case 1036:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1041);}
case 1041:{f.StackOp("pop");f.Pc=1042;continue;}
case 1042:{f.Pc=1057;continue;}
case 1045:{f.Push(f.Locals[0]);f.Pc=1046;continue;}
case 1046:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=1049;continue;}
case 1049:{f.Push(f.Locals[7]);f.Pc=1051;continue;}
case 1051:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1056);}
case 1056:{f.StackOp("pop");f.Pc=1057;continue;}
case 1057:{f.Pc=22;continue;}
case 1060:{f.Push(f.Locals[0]);f.Pc=1061;continue;}
case 1061:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/Cost","costParts","Ljava/util/List;"));f.Pc=1064;continue;}
case 1064:{f.Push(f.Locals[5]);f.Pc=1066;continue;}
case 1066:{return rt.Call(f,"java/util/List","removeAll","(Ljava/util/Collection;)Z","invokeinterface",1071);}
case 1071:{f.StackOp("pop");f.Pc=1072;continue;}
case 1072:{f.Push(f.Locals[0]);f.Pc=1073;continue;}
case 1073:{return rt.Call(f,"forge/game/cost/Cost","sort","()V","invokevirtual",1076);}
case 1076:{f.Push(f.Locals[0]);f.Pc=1077;continue;}
case 1077:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6212(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/Cost","getCostParts","()Ljava/util/List;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?37:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/cost/CostPart","applyTextChangeEffects","(Lforge/game/CardTraitBase;)V","invokevirtual",34);}
case 34:{f.Pc=10;continue;}
case 37:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6213(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/Cost","getCostParts","()Ljava/util/List;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[4]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?49:21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/cost/CostPart","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int!=0?46:44;continue;}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 46:{f.Pc=11;continue;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6214(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/cost/Cost","getCostParts","()Ljava/util/List;","invokevirtual",6);}
case 6:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?73:21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostPartMana")?1:0));f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Int==0?53:38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPartMana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/cost/CostPartMana","getAmountOfX","()I","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int<=0?70:48;continue;}
case 48:{f.Push(JValue.I(1));f.Pc=49;continue;}
case 49:{f.Locals[1]=f.Pop();f.Pc=50;continue;}
case 50:{f.Pc=73;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/cost/CostPart","getAmount","()Ljava/lang/String;","invokevirtual",57);}
case 57:{f.Push(JValue.R(rt.String("X")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int==0?70:65;continue;}
case 65:{f.Push(JValue.I(1));f.Pc=66;continue;}
case 66:{f.Locals[1]=f.Pop();f.Pc=67;continue;}
case 67:{f.Pc=73;continue;}
case 70:{f.Pc=12;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6215(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[4]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/Cost","getCostParts","()Ljava/util/List;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",12);}
case 12:{f.Locals[5]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[5]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?83:24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[6]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[6]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/cost/CostPart","getAmount","()Ljava/lang/String;","invokevirtual",41);}
case 41:{f.Push(JValue.R(rt.String("X")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int!=0?52:49;continue;}
case 49:{f.Pc=14;continue;}
case 52:{f.Push(JValue.I(2));f.Pc=53;continue;}
case 53:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Integer;",f.Pop().Int)));f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=61;continue;}
case 61:{f.StackOp("dup");f.Pc=62;continue;}
case 62:{f.Push(JValue.I(1));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[6]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[3]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/cost/CostPart","getMaxAmountX","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/lang/Integer;","invokevirtual",71);}
case 71:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=72;continue;}
case 72:{return rt.Call(f,"org/apache/commons/lang3/ObjectUtils","min","([Ljava/lang/Comparable;)Ljava/lang/Comparable;","invokestatic",75);}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{f.Locals[4]=f.Pop();f.Pc=80;continue;}
case 80:{f.Pc=14;continue;}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{f.Pc=f.Pop().Reference==null?116:88;continue;}
case 88:{f.Push(f.Locals[4]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int>0?116:96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/cost/Cost","hasManaCost","()Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int==0?116:103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",107);}
case 107:{return rt.Call(f,"forge/game/cost/CostPartMana","getXMin","()I","invokevirtual",110);}
case 110:{f.Pc=f.Pop().Int<=0?116:113;continue;}
case 113:{f.Push(JValue.R(null));f.Pc=114;continue;}
case 114:{f.Locals[4]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[4]);f.Pc=118;continue;}
case 118:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6216(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostPart","paymentOrder","()I","invokevirtual",4);}
case 4:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",7);}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/cost/CostPart","paymentOrder","()I","invokevirtual",11);}
case 11:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",14);}
case 14:{return rt.Call(f,"org/apache/commons/lang3/ObjectUtils","compare","(Ljava/lang/Comparable;Ljava/lang/Comparable;)I","invokestatic",17);}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6217(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(11));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("zero")));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("a")));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("two")));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("three")));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("four")));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("five")));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("six")));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("seven")));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("eight")));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("nine")));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("ten")));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{if(!rt.StaticReady(f,"forge/game/cost/Cost","NUM_NAMES","[Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/game/cost/Cost","NUM_NAMES","[Ljava/lang/String;",f.Pop());f.Pc=79;continue;}
case 79:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=82;continue;}
case 82:{f.StackOp("dup");f.Pc=83;continue;}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/cost/Cost","<init>","(I)V","invokespecial",87);}
case 87:{if(!rt.StaticReady(f,"forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;"))return JStep.Continue;rt.PutStatic("forge/game/cost/Cost","Zero","Lforge/game/cost/Cost;",f.Pop());f.Pc=90;continue;}
case 90:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
