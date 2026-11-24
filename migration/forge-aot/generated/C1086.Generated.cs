// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1086{
internal static JClass Build(){var c=new JClass("forge/item/generation/ChaosBoosterSupplier","java/lang/Object",new string[]{"forge/item/generation/IUnOpenedProduct"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("randomizer","Lforge/util/BagRandomizer;",false,JValue.Default("Lforge/util/BagRandomizer;"),null));
c.Add(new JMethod(11475,"forge/item/generation/ChaosBoosterSupplier","<init>","(Ljava/lang/Iterable;)V",1,2,4,new JHandler[]{},M11475));
c.Add(new JMethod(11476,"forge/item/generation/ChaosBoosterSupplier","get","()Ljava/util/List;",1,3,4,new JHandler[]{},M11476));
c.Add(new JMethod(11477,"forge/item/generation/ChaosBoosterSupplier","get","()Ljava/lang/Object;",4161,1,1,new JHandler[]{},M11477));
}

internal static JStep M11475(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/util/BagRandomizer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/BagRandomizer")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/BagRandomizer","<init>","(Ljava/lang/Iterable;)V","invokespecial",13);}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/generation/ChaosBoosterSupplier","randomizer","Lforge/util/BagRandomizer;",value);f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11476(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/item/generation/ChaosBoosterSupplier","randomizer","Lforge/util/BagRandomizer;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/BagRandomizer","getNextItem","()Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{if(!rt.EnsureInitialized(f,"forge/item/BoosterPack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/BoosterPack")));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/card/CardEdition","getBoosterTemplate","()Lforge/item/SealedTemplate;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/item/BoosterPack","<init>","(Ljava/lang/String;Lforge/item/SealedTemplate;)V","invokespecial",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/item/BoosterPack","getCards","()Ljava/util/List;","invokevirtual",31);}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11477(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/generation/ChaosBoosterSupplier","get","()Ljava/util/List;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
