// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C430{
internal static JClass Build(){var c=new JClass("forge/game/card/ActivationTable","com/google/common/collect/ForwardingTable",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("dataTable","Lcom/google/common/collect/Table;",false,JValue.Default("Lcom/google/common/collect/Table;"),null));
c.Add(new JMethod(3833,"forge/game/card/ActivationTable","<init>","()V",1,1,2,new JHandler[]{},M3833));
c.Add(new JMethod(3834,"forge/game/card/ActivationTable","delegate","()Lcom/google/common/collect/Table;",4,1,1,new JHandler[]{},M3834));
c.Add(new JMethod(3835,"forge/game/card/ActivationTable","getOriginal","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbility;",4,4,2,new JHandler[]{},M3835));
c.Add(new JMethod(3836,"forge/game/card/ActivationTable","add","(Lforge/game/spellability/SpellAbility;)V",1,6,4,new JHandler[]{},M3836));
c.Add(new JMethod(3837,"forge/game/card/ActivationTable","get","(Lforge/game/spellability/SpellAbility;)I",1,2,2,new JHandler[]{},M3837));
c.Add(new JMethod(3838,"forge/game/card/ActivationTable","getActivators","(Lforge/game/spellability/SpellAbility;)Lcom/google/common/collect/Multiset;",1,5,3,new JHandler[]{},M3838));
c.Add(new JMethod(3839,"forge/game/card/ActivationTable","delegate","()Ljava/lang/Object;",4164,1,1,new JHandler[]{},M3839));
}

internal static JStep M3833(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/ForwardingTable","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","()Lcom/google/common/collect/HashBasedTable;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/ActivationTable","dataTable","Lcom/google/common/collect/Table;",value);f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3834(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/ActivationTable","dataTable","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3835(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?25:14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTrigger","()Lforge/game/trigger/Trigger;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/game/trigger/Trigger","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Pc=37;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",29);}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[2]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3836(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/ActivationTable","getOriginal","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbility;","invokevirtual",10);}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference==null?74:15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getGrantorStatic","()Lforge/game/staticability/StaticAbility;","invokevirtual",19);}
case 19:{return rt.Call(f,"java/util/Optional","ofNullable","(Ljava/lang/Object;)Ljava/util/Optional;","invokestatic",22);}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/ActivationTable","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{return rt.DynamicCall(f,"forge/game/card/ActivationTable:3836:34:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Supplier;",39);}
case 39:{return rt.Call(f,"java/util/Objects","requireNonNullElseGet","(Ljava/lang/Object;Ljava/util/function/Supplier;)Ljava/lang/Object;","invokestatic",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[5]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",53);}
case 53:{return rt.Call(f,"com/google/common/collect/Multiset","add","(Ljava/lang/Object;)Z","invokeinterface",58);}
case 58:{f.StackOp("pop");f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/card/ActivationTable","delegate","()Lcom/google/common/collect/Table;","invokevirtual",63);}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"com/google/common/collect/Table","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",73);}
case 73:{f.StackOp("pop");f.Pc=74;continue;}
case 74:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3837(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/ActivationTable","getActivators","(Lforge/game/spellability/SpellAbility;)Lcom/google/common/collect/Multiset;","invokevirtual",5);}
case 5:{return rt.Call(f,"com/google/common/collect/Multiset","size","()I","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3838(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/ActivationTable","getOriginal","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbility;","invokevirtual",10);}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getGrantorStatic","()Lforge/game/staticability/StaticAbility;","invokevirtual",15);}
case 15:{return rt.Call(f,"java/util/Optional","ofNullable","(Ljava/lang/Object;)Ljava/util/Optional;","invokestatic",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/ActivationTable","contains","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?41:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/card/ActivationTable","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
case 41:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","()Lcom/google/common/collect/HashMultiset;","invokestatic",44);}
case 44:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3839(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/ActivationTable","delegate","()Lcom/google/common/collect/Table;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
