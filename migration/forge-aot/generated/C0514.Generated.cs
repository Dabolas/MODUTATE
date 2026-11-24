// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C514{
internal static JClass Build(){var c=new JClass("forge/game/combat/CombatLki","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("relatedBands","Lforge/util/collect/FCollectionView;",false,JValue.Default("Lforge/util/collect/FCollectionView;"),null));
c.Add(new JField("isAttacker","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(6092,"forge/game/combat/CombatLki","<init>","(ZLforge/util/collect/FCollectionView;)V",1,3,4,new JHandler[]{},M6092));
c.Add(new JMethod(6093,"forge/game/combat/CombatLki","getFirstBand","()Lforge/game/combat/AttackingBand;",1,1,2,new JHandler[]{},M6093));
}

internal static JStep M6092(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/CombatLki","isAttacker","Z",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",18);}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/CombatLki","relatedBands","Lforge/util/collect/FCollectionView;",value);f.Pc=21;continue;}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6093(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/CombatLki","relatedBands","Lforge/util/collect/FCollectionView;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FCollectionView","isEmpty","()Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int==0?16:12;continue;}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{f.Pc=29;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/CombatLki","relatedBands","Lforge/util/collect/FCollectionView;"));f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/util/collect/FCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackingBand"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
