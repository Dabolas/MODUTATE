// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C911{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerChangesZoneAll","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10285,"forge/game/trigger/TriggerChangesZoneAll","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10285));
c.Add(new JMethod(10286,"forge/game/trigger/TriggerChangesZoneAll","performTest","(Ljava/util/Map;)Z",1,4,6,new JHandler[]{},M10286));
c.Add(new JMethod(10287,"forge/game/trigger/TriggerChangesZoneAll","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",1,5,6,new JHandler[]{},M10287));
c.Add(new JMethod(10288,"forge/game/trigger/TriggerChangesZoneAll","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,3,4,new JHandler[]{},M10288));
c.Add(new JMethod(10289,"forge/game/trigger/TriggerChangesZoneAll","filterCards","(Lforge/game/card/CardZoneTable;)Lforge/game/card/CardCollection;",2,5,6,new JHandler[]{},M10289));
}

internal static JStep M10285(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10286(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardZoneTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","getActiveZone","()Ljava/util/Set;","invokevirtual",17);}
case 17:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?60:28;continue;}
case 28:{f.Push(JValue.R(rt.String("Graveyard")));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("Origin")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",36);}
case 36:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int==0?60:42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",46);}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","getHostCard","()Lforge/game/card/Card;","invokevirtual",50);}
case 50:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int!=0?60:58;continue;}
case 58:{f.Push(JValue.I(0));f.Pc=59;continue;}
case 59:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("FirstTime")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","hasParam","(Ljava/lang/String;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?124:69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("Destination")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",75);}
case 75:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",78);}
case 78:{f.Push(JValue.R(null));f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",85);}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","getHostCard","()Lforge/game/card/Card;","invokevirtual",89);}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","getHostCard","()Lforge/game/card/Card;","invokevirtual",94);}
case 94:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",97);}
case 97:{return rt.Call(f,"forge/game/card/CardUtil","getThisTurnEntered","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;Lforge/game/player/Player;)Ljava/util/List;","invokestatic",100);}
case 100:{f.Locals[3]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[3]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[2]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","filterCards","(Lforge/game/card/CardZoneTable;)Lforge/game/card/CardCollection;","invokevirtual",107);}
case 107:{return rt.Call(f,"java/util/List","removeAll","(Ljava/util/Collection;)Z","invokeinterface",112);}
case 112:{f.StackOp("pop");f.Pc=113;continue;}
case 113:{f.Push(f.Locals[3]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",119);}
case 119:{f.Pc=f.Pop().Int!=0?124:122;continue;}
case 122:{f.Push(JValue.I(0));f.Pc=123;continue;}
case 123:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String("ValidCause")));f.Pc=127;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",136);}
case 136:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",139);}
case 139:{f.Pc=f.Pop().Int!=0?144:142;continue;}
case 142:{f.Push(JValue.I(0));f.Pc=143;continue;}
case 143:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.String("ValidAmount")));f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","hasParam","(Ljava/lang/String;)Z","invokevirtual",150);}
case 150:{f.Pc=f.Pop().Int==0?200:153;continue;}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/TriggerChangesZoneAll","hostCard","Lforge/game/card/Card;"));f.Pc=157;continue;}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("ValidAmount")));f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",163);}
case 163:{f.Push(JValue.I(2));f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",167);}
case 167:{f.Push(f.Locals[0]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",171);}
case 171:{f.Locals[3]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[2]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","filterCards","(Lforge/game/card/CardZoneTable;)Lforge/game/card/CardCollection;","invokevirtual",177);}
case 177:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",180);}
case 180:{f.Push(f.Locals[0]);f.Pc=181;continue;}
case 181:{f.Push(JValue.R(rt.String("ValidAmount")));f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",186);}
case 186:{f.Push(JValue.I(0));f.Pc=187;continue;}
case 187:{f.Push(JValue.I(2));f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",191);}
case 191:{f.Push(f.Locals[3]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",195);}
case 195:{f.Pc=f.Pop().Int!=0?200:198;continue;}
case 198:{f.Push(JValue.I(0));f.Pc=199;continue;}
case 199:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 200:{f.Push(f.Locals[0]);f.Pc=201;continue;}
case 201:{f.Push(f.Locals[2]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","filterCards","(Lforge/game/card/CardZoneTable;)Lforge/game/card/CardCollection;","invokevirtual",205);}
case 205:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",208);}
case 208:{f.Pc=f.Pop().Int!=0?215:211;continue;}
case 211:{f.Push(JValue.I(1));f.Pc=212;continue;}
case 212:{f.Pc=216;continue;}
case 215:{f.Push(JValue.I(0));f.Pc=216;continue;}
case 216:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10287(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardZoneTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","filterCards","(Lforge/game/card/CardZoneTable;)Lforge/game/card/CardCollection;","invokevirtual",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",31);}
case 31:{f.StackOp("pop");f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Amount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Amount","Lforge/game/ability/AbilityKey;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",41);}
case 41:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",44);}
case 44:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",49);}
case 49:{f.StackOp("pop");f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{f.Push(JValue.R(rt.NewArray("Lforge/game/ability/AbilityKey;",f.Pop().Int)));f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/ability/AbilityKey","copyKeys","(Ljava/util/Map;Ljava/util/Map;[Lforge/game/ability/AbilityKey;)V","invokestatic",65);}
case 65:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10288(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",12);}
case 12:{f.Push(JValue.R(rt.String("lblAmount")));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",24);}
case 24:{f.Push(JValue.R(rt.String(": ")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",29);}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Amount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Amount","Lforge/game/ability/AbilityKey;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",36);}
case 36:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",44);}
case 44:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10289(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("Destination")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","hasParam","(Ljava/lang/String;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?37:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Destination")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Push(JValue.R(rt.String("Any")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int!=0?37:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("Destination")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",33);}
case 33:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",36);}
case 36:{f.Locals[2]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("Origin")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","hasParam","(Ljava/lang/String;)Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int==0?70:46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("Origin")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",52);}
case 52:{f.Push(JValue.R(rt.String("Any")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int!=0?70:60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("Origin")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",66);}
case 66:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",69);}
case 69:{f.Locals[3]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",76);}
case 76:{f.Locals[4]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[2]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[4]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/trigger/TriggerChangesZoneAll","getHostCard","()Lforge/game/card/Card;","invokevirtual",87);}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/card/CardZoneTable","filterCards","(Ljava/lang/Iterable;Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokevirtual",91);}
case 91:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
