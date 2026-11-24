// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C851{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityCountersRemain","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10005,"forge/game/staticability/StaticAbilityCountersRemain","<init>","()V",1,1,1,new JHandler[]{},M10005));
c.Add(new JMethod(10006,"forge/game/staticability/StaticAbilityCountersRemain","countersRemain","(Lforge/game/card/Card;Lforge/game/zone/Zone;)Z",9,8,4,new JHandler[]{},M10006));
c.Add(new JMethod(10007,"forge/game/staticability/StaticAbilityCountersRemain","applyCountersRemainAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/card/Card;)Z",9,2,3,new JHandler[]{},M10007));
}

internal static JStep M10005(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10006(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?14:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/zone/ZoneType","isHidden","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?16:14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",32);}
case 32:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",35);}
case 35:{f.Locals[3]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",46);}
case 46:{f.Locals[4]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int==0?135:58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{f.Locals[5]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[5]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",75);}
case 75:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",80);}
case 80:{f.Locals[6]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[6]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",89);}
case 89:{f.Pc=f.Pop().Int==0?132:92;continue;}
case 92:{f.Push(f.Locals[6]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",99);}
case 99:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=102;continue;}
case 102:{f.Locals[7]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[7]);f.Pc=106;continue;}
case 106:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CountersRemain","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CountersRemain","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Int!=0?118:115;continue;}
case 115:{f.Pc=82;continue;}
case 118:{f.Push(f.Locals[7]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/staticability/StaticAbilityCountersRemain","applyCountersRemainAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/card/Card;)Z","invokestatic",124);}
case 124:{f.Pc=f.Pop().Int==0?129:127;continue;}
case 127:{f.Push(JValue.I(1));f.Pc=128;continue;}
case 128:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 129:{f.Pc=82;continue;}
case 132:{f.Pc=48;continue;}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10007(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
