// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C866{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityMaxCounter","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10053,"forge/game/staticability/StaticAbilityMaxCounter","<init>","()V",1,1,1,new JHandler[]{},M10053));
c.Add(new JMethod(10054,"forge/game/staticability/StaticAbilityMaxCounter","maxCounter","(Lforge/game/card/Card;Lforge/game/card/CounterType;)Ljava/lang/Integer;",9,9,3,new JHandler[]{},M10054));
c.Add(new JMethod(10055,"forge/game/staticability/StaticAbilityMaxCounter","applyMaxCounter","(Lforge/game/staticability/StaticAbility;Lforge/game/card/Card;Lforge/game/card/CounterType;)Z",12,4,3,new JHandler[]{},M10055));
}

internal static JStep M10053(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10054(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int==0?145:31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[5]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[5]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",48);}
case 48:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",53);}
case 53:{f.Locals[6]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[6]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",62);}
case 62:{f.Pc=f.Pop().Int==0?142:65;continue;}
case 65:{f.Push(f.Locals[6]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",72);}
case 72:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=75;continue;}
case 75:{f.Locals[7]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[7]);f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","MaxCounter","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","MaxCounter","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int!=0?91:88;continue;}
case 88:{f.Pc=55;continue;}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/staticability/StaticAbilityMaxCounter","applyMaxCounter","(Lforge/game/staticability/StaticAbility;Lforge/game/card/Card;Lforge/game/card/CounterType;)Z","invokestatic",98);}
case 98:{f.Pc=f.Pop().Int==0?139:101;continue;}
case 101:{f.Push(f.Locals[7]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",106);}
case 106:{f.Push(f.Locals[7]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("MaxNum")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",113);}
case 113:{f.Push(f.Locals[7]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",118);}
case 118:{f.Locals[8]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[3]);f.Pc=121;continue;}
case 121:{f.Pc=f.Pop().Reference==null?133:124;continue;}
case 124:{f.Push(f.Locals[3]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",128);}
case 128:{f.Push(f.Locals[8]);f.Pc=130;continue;}
case 130:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?139:133;continue;}
case 133:{f.Push(f.Locals[8]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",138);}
case 138:{f.Locals[3]=f.Pop();f.Pc=139;continue;}
case 139:{f.Pc=55;continue;}
case 142:{f.Pc=21;continue;}
case 145:{f.Push(f.Locals[3]);f.Pc=146;continue;}
case 146:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10055(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?33:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",18);}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Reference==null?33:23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int!=0?33:31;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int!=0?45:43;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
