// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C873{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityPanharmonicon","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10083,"forge/game/staticability/StaticAbilityPanharmonicon","<init>","()V",1,1,1,new JHandler[]{},M10083));
c.Add(new JMethod(10084,"forge/game/staticability/StaticAbilityPanharmonicon","handlePanharmonicon","(Lforge/game/Game;Lforge/game/trigger/Trigger;Ljava/util/Map;)I",9,3,4,new JHandler[]{},M10084));
c.Add(new JMethod(10085,"forge/game/staticability/StaticAbilityPanharmonicon","countPanharmonicon","(Lforge/game/Game;Lforge/game/trigger/Trigger;Ljava/util/Map;)I",9,9,3,new JHandler[]{},M10085));
c.Add(new JMethod(10086,"forge/game/staticability/StaticAbilityPanharmonicon","applyPanharmoniconAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/trigger/Trigger;Ljava/util/Map;)Z",9,13,6,new JHandler[]{},M10086));
}

internal static JStep M10083(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10084(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbilityPanharmonicon","countPanharmonicon","(Lforge/game/Game;Lforge/game/trigger/Trigger;Ljava/util/Map;)I","invokestatic",7);}
case 7:{return rt.Call(f,"forge/game/trigger/Trigger","limitByActivations","(I)I","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10085(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[3]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(2));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","limitByActivations","(I)I","invokevirtual",7);}
case 7:{f.Push(JValue.I(2));f.Pc=8;continue;}
case 8:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?13:11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/trigger/Trigger","isStatic","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?42:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",24);}
case 24:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TapsForMana","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TapsForMana","Lforge/game/trigger/TriggerType;"));f.Pc=27;continue;}
case 27:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?42:30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",34);}
case 34:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ManaAdded","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ManaAdded","Lforge/game/trigger/TriggerType;"));f.Pc=37;continue;}
case 37:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?42:40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/trigger/Trigger","getSpawningAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Reference==null?51:49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 51:{f.Push(JValue.R(null));f.Pc=52;continue;}
case 52:{f.Locals[4]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/trigger/Trigger","looksBackInTime","()Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int==0?101:61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",70);}
case 70:{f.Pc=f.Pop().Int==0?87:73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",82);}
case 82:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=85;continue;}
case 85:{f.Locals[4]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{f.Pc=f.Pop().Reference!=null?110:92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",96);}
case 96:{f.Locals[4]=f.Pop();f.Pc=98;continue;}
case 98:{f.Pc=110;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",108);}
case 108:{f.Locals[4]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[4]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",117);}
case 117:{f.Locals[5]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(f.Locals[5]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",126);}
case 126:{f.Pc=f.Pop().Int==0?208:129;continue;}
case 129:{f.Push(f.Locals[5]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",136);}
case 136:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=139;continue;}
case 139:{f.Locals[6]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[6]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",146);}
case 146:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",151);}
case 151:{f.Locals[7]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[7]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",160);}
case 160:{f.Pc=f.Pop().Int==0?205:163;continue;}
case 163:{f.Push(f.Locals[7]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",170);}
case 170:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=173;continue;}
case 173:{f.Locals[8]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[8]);f.Pc=177;continue;}
case 177:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","Panharmonicon","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","Panharmonicon","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",183);}
case 183:{f.Pc=f.Pop().Int!=0?189:186;continue;}
case 186:{f.Pc=153;continue;}
case 189:{f.Push(f.Locals[8]);f.Pc=191;continue;}
case 191:{f.Push(f.Locals[1]);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[2]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/staticability/StaticAbilityPanharmonicon","applyPanharmoniconAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/trigger/Trigger;Ljava/util/Map;)Z","invokestatic",196);}
case 196:{f.Pc=f.Pop().Int==0?202:199;continue;}
case 199:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=202;continue;}
case 202:{f.Pc=153;continue;}
case 205:{f.Pc=119;continue;}
case 208:{f.Push(f.Locals[3]);f.Pc=209;continue;}
case 209:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10086(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int!=0?26:24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("ValidMode")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?59:35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("ValidMode")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",41);}
case 41:{f.Push(JValue.R(rt.String(",")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",46);}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/trigger/TriggerType","toString","()Ljava/lang/String;","invokevirtual",51);}
case 51:{return rt.Call(f,"org/apache/commons/lang3/ArrayUtils","contains","([Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",54);}
case 54:{f.Pc=f.Pop().Int!=0?59:57;continue;}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("ValidZone")));f.Pc=62;continue;}
case 62:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",67);}
case 67:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",70);}
case 70:{f.Locals[5]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",78);}
case 78:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",81);}
case 81:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",84);}
case 84:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",89);}
case 89:{f.Pc=f.Pop().Int!=0?94:92;continue;}
case 92:{f.Push(JValue.I(0));f.Pc=93;continue;}
case 93:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 94:{f.Push(f.Locals[4]);f.Pc=96;continue;}
case 96:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",102);}
case 102:{f.Pc=f.Pop().Int==0?203:105;continue;}
case 105:{f.Push(f.Locals[2]);f.Pc=106;continue;}
case 106:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",114);}
case 114:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=117;continue;}
case 117:{f.Locals[6]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=121;continue;}
case 121:{f.Push(f.Locals[1]);f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("Origin")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",127);}
case 127:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",130);}
case 130:{f.Pc=f.Pop().Int==0?147:133;continue;}
case 133:{f.Push(f.Locals[2]);f.Pc=134;continue;}
case 134:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",142);}
case 142:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=145;continue;}
case 145:{f.Locals[6]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{f.Push(JValue.R(rt.String("ValidCause")));f.Pc=150;continue;}
case 150:{f.Push(f.Locals[6]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",155);}
case 155:{f.Pc=f.Pop().Int!=0?160:158;continue;}
case 158:{f.Push(JValue.I(0));f.Pc=159;continue;}
case 159:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{f.Push(JValue.R(rt.String("Origin")));f.Pc=163;continue;}
case 163:{f.Push(f.Locals[2]);f.Pc=164;continue;}
case 164:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"));f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",172);}
case 172:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",175);}
case 175:{f.Pc=f.Pop().Int!=0?180:178;continue;}
case 178:{f.Push(JValue.I(0));f.Pc=179;continue;}
case 179:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 180:{f.Push(f.Locals[0]);f.Pc=181;continue;}
case 181:{f.Push(JValue.R(rt.String("Destination")));f.Pc=183;continue;}
case 183:{f.Push(f.Locals[2]);f.Pc=184;continue;}
case 184:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=187;continue;}
case 187:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",192);}
case 192:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",195);}
case 195:{f.Pc=f.Pop().Int!=0?200:198;continue;}
case 198:{f.Push(JValue.I(0));f.Pc=199;continue;}
case 199:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 200:{f.Pc=1105;continue;}
case 203:{f.Push(f.Locals[4]);f.Pc=205;continue;}
case 205:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesZoneAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesZoneAll","Lforge/game/trigger/TriggerType;"));f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",211);}
case 211:{f.Pc=f.Pop().Int==0?420:214;continue;}
case 214:{f.Push(f.Locals[0]);f.Pc=215;continue;}
case 215:{f.Push(JValue.R(rt.String("Origin")));f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",220);}
case 220:{f.Locals[6]=f.Pop();f.Pc=222;continue;}
case 222:{f.Push(f.Locals[0]);f.Pc=223;continue;}
case 223:{f.Push(JValue.R(rt.String("Destination")));f.Pc=225;continue;}
case 225:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",228);}
case 228:{f.Locals[7]=f.Pop();f.Pc=230;continue;}
case 230:{f.Push(f.Locals[2]);f.Pc=231;continue;}
case 231:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardsFiltered","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardsFiltered","Lforge/game/ability/AbilityKey;"));f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",239);}
case 239:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardZoneTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=242;continue;}
case 242:{f.Locals[8]=f.Pop();f.Pc=244;continue;}
case 244:{f.Push(f.Locals[8]);f.Pc=246;continue;}
case 246:{f.Pc=f.Pop().Reference!=null?263:249;continue;}
case 249:{f.Push(f.Locals[2]);f.Pc=250;continue;}
case 250:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=253;continue;}
case 253:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",258);}
case 258:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardZoneTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=261;continue;}
case 261:{f.Locals[8]=f.Pop();f.Pc=263;continue;}
case 263:{f.Push(JValue.R(null));f.Pc=264;continue;}
case 264:{f.Locals[9]=f.Pop();f.Pc=266;continue;}
case 266:{f.Push(JValue.R(null));f.Pc=267;continue;}
case 267:{f.Locals[10]=f.Pop();f.Pc=269;continue;}
case 269:{f.Push(f.Locals[1]);f.Pc=270;continue;}
case 270:{f.Push(JValue.R(rt.String("Destination")));f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",275);}
case 275:{f.Pc=f.Pop().Int==0?303:278;continue;}
case 278:{f.Push(f.Locals[1]);f.Pc=279;continue;}
case 279:{f.Push(JValue.R(rt.String("Destination")));f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",284);}
case 284:{f.Push(JValue.R(rt.String("Any")));f.Pc=286;continue;}
case 286:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",289);}
case 289:{f.Pc=f.Pop().Int!=0?303:292;continue;}
case 292:{f.Push(f.Locals[1]);f.Pc=293;continue;}
case 293:{f.Push(JValue.R(rt.String("Destination")));f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",298);}
case 298:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",301);}
case 301:{f.Locals[10]=f.Pop();f.Pc=303;continue;}
case 303:{f.Push(f.Locals[1]);f.Pc=304;continue;}
case 304:{f.Push(JValue.R(rt.String("Origin")));f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",309);}
case 309:{f.Pc=f.Pop().Int==0?337:312;continue;}
case 312:{f.Push(f.Locals[1]);f.Pc=313;continue;}
case 313:{f.Push(JValue.R(rt.String("Origin")));f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",318);}
case 318:{f.Push(JValue.R(rt.String("Any")));f.Pc=320;continue;}
case 320:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",323);}
case 323:{f.Pc=f.Pop().Int!=0?337:326;continue;}
case 326:{f.Push(f.Locals[1]);f.Pc=327;continue;}
case 327:{f.Push(JValue.R(rt.String("Origin")));f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",332);}
case 332:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",335);}
case 335:{f.Locals[9]=f.Pop();f.Pc=337;continue;}
case 337:{f.Push(f.Locals[8]);f.Pc=339;continue;}
case 339:{f.Push(f.Locals[9]);f.Pc=341;continue;}
case 341:{f.Push(f.Locals[10]);f.Pc=343;continue;}
case 343:{f.Push(f.Locals[1]);f.Pc=344;continue;}
case 344:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",349);}
case 349:{f.Push(f.Locals[1]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",353);}
case 353:{f.Push(f.Locals[1]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/card/CardZoneTable","filterCards","(Ljava/lang/Iterable;Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokevirtual",357);}
case 357:{f.Locals[11]=f.Pop();f.Pc=359;continue;}
case 359:{f.Push(f.Locals[8]);f.Pc=361;continue;}
case 361:{f.Push(f.Locals[6]);f.Pc=363;continue;}
case 363:{f.Pc=f.Pop().Reference!=null?370:366;continue;}
case 366:{f.Push(JValue.R(null));f.Pc=367;continue;}
case 367:{f.Pc=378;continue;}
case 370:{f.Push(f.Locals[6]);f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",375);}
case 375:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",378);}
case 378:{f.Push(f.Locals[7]);f.Pc=380;continue;}
case 380:{f.Pc=f.Pop().Reference!=null?387:383;continue;}
case 383:{f.Push(JValue.R(null));f.Pc=384;continue;}
case 384:{f.Pc=392;continue;}
case 387:{f.Push(f.Locals[7]);f.Pc=389;continue;}
case 389:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",392);}
case 392:{f.Push(f.Locals[0]);f.Pc=393;continue;}
case 393:{f.Push(JValue.R(rt.String("ValidCause")));f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",398);}
case 398:{f.Push(f.Locals[3]);f.Pc=399;continue;}
case 399:{f.Push(f.Locals[0]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"forge/game/card/CardZoneTable","filterCards","(Ljava/lang/Iterable;Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokevirtual",403);}
case 403:{f.Locals[12]=f.Pop();f.Pc=405;continue;}
case 405:{f.Push(f.Locals[11]);f.Pc=407;continue;}
case 407:{f.Push(f.Locals[12]);f.Pc=409;continue;}
case 409:{return rt.Call(f,"java/util/Collections","disjoint","(Ljava/util/Collection;Ljava/util/Collection;)Z","invokestatic",412);}
case 412:{f.Pc=f.Pop().Int==0?417:415;continue;}
case 415:{f.Push(JValue.I(0));f.Pc=416;continue;}
case 416:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 417:{f.Pc=1105;continue;}
case 420:{f.Push(f.Locals[4]);f.Pc=422;continue;}
case 422:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Attacks","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Attacks","Lforge/game/trigger/TriggerType;"));f.Pc=425;continue;}
case 425:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",428);}
case 428:{f.Pc=f.Pop().Int==0?451:431;continue;}
case 431:{f.Push(f.Locals[0]);f.Pc=432;continue;}
case 432:{f.Push(JValue.R(rt.String("ValidCause")));f.Pc=434;continue;}
case 434:{f.Push(f.Locals[2]);f.Pc=435;continue;}
case 435:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=438;continue;}
case 438:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",443);}
case 443:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",446);}
case 446:{f.Pc=f.Pop().Int!=0?1105:449;continue;}
case 449:{f.Push(JValue.I(0));f.Pc=450;continue;}
case 450:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 451:{f.Push(f.Locals[4]);f.Pc=453;continue;}
case 453:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AttackersDeclared","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AttackersDeclared","Lforge/game/trigger/TriggerType;"));f.Pc=456;continue;}
case 456:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",459);}
case 459:{f.Pc=f.Pop().Int!=0?473:462;continue;}
case 462:{f.Push(f.Locals[4]);f.Pc=464;continue;}
case 464:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","AttackersDeclaredOneTarget","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","AttackersDeclaredOneTarget","Lforge/game/trigger/TriggerType;"));f.Pc=467;continue;}
case 467:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",470);}
case 470:{f.Pc=f.Pop().Int==0?493:473;continue;}
case 473:{f.Push(f.Locals[0]);f.Pc=474;continue;}
case 474:{f.Push(JValue.R(rt.String("ValidCause")));f.Pc=476;continue;}
case 476:{f.Push(f.Locals[2]);f.Pc=477;continue;}
case 477:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attackers","Lforge/game/ability/AbilityKey;"));f.Pc=480;continue;}
case 480:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",485);}
case 485:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",488);}
case 488:{f.Pc=f.Pop().Int!=0?1105:491;continue;}
case 491:{f.Push(JValue.I(0));f.Pc=492;continue;}
case 492:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 493:{f.Push(f.Locals[4]);f.Pc=495;continue;}
case 495:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","SpellCastOrCopy","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","SpellCastOrCopy","Lforge/game/trigger/TriggerType;"));f.Pc=498;continue;}
case 498:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",501);}
case 501:{f.Pc=f.Pop().Int!=0?526:504;continue;}
case 504:{f.Push(f.Locals[4]);f.Pc=506;continue;}
case 506:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","SpellCast","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","SpellCast","Lforge/game/trigger/TriggerType;"));f.Pc=509;continue;}
case 509:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",512);}
case 512:{f.Pc=f.Pop().Int!=0?526:515;continue;}
case 515:{f.Push(f.Locals[4]);f.Pc=517;continue;}
case 517:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","SpellCopy","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","SpellCopy","Lforge/game/trigger/TriggerType;"));f.Pc=520;continue;}
case 520:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",523);}
case 523:{f.Pc=f.Pop().Int==0?576:526;continue;}
case 526:{f.Push(f.Locals[2]);f.Pc=527;continue;}
case 527:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"));f.Pc=530;continue;}
case 530:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",535);}
case 535:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=538;continue;}
case 538:{f.Locals[6]=f.Pop();f.Pc=540;continue;}
case 540:{f.Push(f.Locals[0]);f.Pc=541;continue;}
case 541:{f.Push(JValue.R(rt.String("ValidCause")));f.Pc=543;continue;}
case 543:{f.Push(f.Locals[6]);f.Pc=545;continue;}
case 545:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",548);}
case 548:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",551);}
case 551:{f.Pc=f.Pop().Int!=0?556:554;continue;}
case 554:{f.Push(JValue.I(0));f.Pc=555;continue;}
case 555:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 556:{f.Push(f.Locals[0]);f.Pc=557;continue;}
case 557:{f.Push(JValue.R(rt.String("ValidActivator")));f.Pc=560;continue;}
case 560:{f.Push(f.Locals[6]);f.Pc=562;continue;}
case 562:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",565);}
case 565:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",568);}
case 568:{f.Pc=f.Pop().Int!=0?573:571;continue;}
case 571:{f.Push(JValue.I(0));f.Pc=572;continue;}
case 572:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 573:{f.Pc=1105;continue;}
case 576:{f.Push(f.Locals[4]);f.Pc=578;continue;}
case 578:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","BecomesTarget","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","BecomesTarget","Lforge/game/trigger/TriggerType;"));f.Pc=581;continue;}
case 581:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",584);}
case 584:{f.Pc=f.Pop().Int==0?608:587;continue;}
case 587:{f.Push(f.Locals[0]);f.Pc=588;continue;}
case 588:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=591;continue;}
case 591:{f.Push(f.Locals[2]);f.Pc=592;continue;}
case 592:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Target","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Target","Lforge/game/ability/AbilityKey;"));f.Pc=595;continue;}
case 595:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",600);}
case 600:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",603);}
case 603:{f.Pc=f.Pop().Int!=0?1105:606;continue;}
case 606:{f.Push(JValue.I(0));f.Pc=607;continue;}
case 607:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 608:{f.Push(f.Locals[4]);f.Pc=610;continue;}
case 610:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","BecomesTargetOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","BecomesTargetOnce","Lforge/game/trigger/TriggerType;"));f.Pc=613;continue;}
case 613:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",616);}
case 616:{f.Pc=f.Pop().Int==0?640:619;continue;}
case 619:{f.Push(f.Locals[0]);f.Pc=620;continue;}
case 620:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=623;continue;}
case 623:{f.Push(f.Locals[2]);f.Pc=624;continue;}
case 624:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Targets","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Targets","Lforge/game/ability/AbilityKey;"));f.Pc=627;continue;}
case 627:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",632);}
case 632:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",635);}
case 635:{f.Pc=f.Pop().Int!=0?1105:638;continue;}
case 638:{f.Push(JValue.I(0));f.Pc=639;continue;}
case 639:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 640:{f.Push(f.Locals[4]);f.Pc=642;continue;}
case 642:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","DamageDone","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","DamageDone","Lforge/game/trigger/TriggerType;"));f.Pc=645;continue;}
case 645:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",648);}
case 648:{f.Pc=f.Pop().Int!=0?684:651;continue;}
case 651:{f.Push(f.Locals[4]);f.Pc=653;continue;}
case 653:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","DamageDoneOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","DamageDoneOnce","Lforge/game/trigger/TriggerType;"));f.Pc=656;continue;}
case 656:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",659);}
case 659:{f.Pc=f.Pop().Int!=0?684:662;continue;}
case 662:{f.Push(f.Locals[4]);f.Pc=664;continue;}
case 664:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","DamageAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","DamageAll","Lforge/game/trigger/TriggerType;"));f.Pc=667;continue;}
case 667:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",670);}
case 670:{f.Pc=f.Pop().Int!=0?684:673;continue;}
case 673:{f.Push(f.Locals[4]);f.Pc=675;continue;}
case 675:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","DamageDealtOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","DamageDealtOnce","Lforge/game/trigger/TriggerType;"));f.Pc=678;continue;}
case 678:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",681);}
case 681:{f.Pc=f.Pop().Int==0?1041:684;continue;}
case 684:{f.Push(f.Locals[0]);f.Pc=685;continue;}
case 685:{f.Push(JValue.R(rt.String("CombatDamage")));f.Pc=688;continue;}
case 688:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",691);}
case 691:{f.Pc=f.Pop().Int==0?727:694;continue;}
case 694:{f.Push(f.Locals[0]);f.Pc=695;continue;}
case 695:{f.Push(JValue.R(rt.String("CombatDamage")));f.Pc=698;continue;}
case 698:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",701);}
case 701:{f.Push(JValue.R(rt.String("True")));f.Pc=704;continue;}
case 704:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",707);}
case 707:{f.Push(f.Locals[2]);f.Pc=708;continue;}
case 708:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IsCombatDamage","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IsCombatDamage","Lforge/game/ability/AbilityKey;"));f.Pc=711;continue;}
case 711:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",716);}
case 716:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=719;continue;}
case 719:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",722);}
case 722:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?727:725;continue;}
case 725:{f.Push(JValue.I(0));f.Pc=726;continue;}
case 726:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 727:{f.Push(f.Locals[4]);f.Pc=729;continue;}
case 729:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","DamageDone","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","DamageDone","Lforge/game/trigger/TriggerType;"));f.Pc=732;continue;}
case 732:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",735);}
case 735:{f.Pc=f.Pop().Int==0?780:738;continue;}
case 738:{f.Push(f.Locals[0]);f.Pc=739;continue;}
case 739:{f.Push(JValue.R(rt.String("ValidSource")));f.Pc=742;continue;}
case 742:{f.Push(f.Locals[2]);f.Pc=743;continue;}
case 743:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=746;continue;}
case 746:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",751);}
case 751:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",754);}
case 754:{f.Pc=f.Pop().Int!=0?759:757;continue;}
case 757:{f.Push(JValue.I(0));f.Pc=758;continue;}
case 758:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 759:{f.Push(f.Locals[0]);f.Pc=760;continue;}
case 760:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=763;continue;}
case 763:{f.Push(f.Locals[2]);f.Pc=764;continue;}
case 764:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageTarget","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageTarget","Lforge/game/ability/AbilityKey;"));f.Pc=767;continue;}
case 767:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",772);}
case 772:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",775);}
case 775:{f.Pc=f.Pop().Int!=0?780:778;continue;}
case 778:{f.Push(JValue.I(0));f.Pc=779;continue;}
case 779:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 780:{f.Push(f.Locals[4]);f.Pc=782;continue;}
case 782:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","DamageDoneOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","DamageDoneOnce","Lforge/game/trigger/TriggerType;"));f.Pc=785;continue;}
case 785:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",788);}
case 788:{f.Pc=f.Pop().Int==0?867:791;continue;}
case 791:{f.Push(f.Locals[0]);f.Pc=792;continue;}
case 792:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=795;continue;}
case 795:{f.Push(f.Locals[2]);f.Pc=796;continue;}
case 796:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageTarget","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageTarget","Lforge/game/ability/AbilityKey;"));f.Pc=799;continue;}
case 799:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",804);}
case 804:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",807);}
case 807:{f.Pc=f.Pop().Int!=0?812:810;continue;}
case 810:{f.Push(JValue.I(0));f.Pc=811;continue;}
case 811:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 812:{f.Push(f.Locals[2]);f.Pc=813;continue;}
case 813:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"));f.Pc=816;continue;}
case 816:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",821);}
case 821:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=824;continue;}
case 824:{f.Locals[6]=f.Pop();f.Pc=826;continue;}
case 826:{f.Push(f.Locals[6]);f.Pc=828;continue;}
case 828:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",833);}
case 833:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",838);}
case 838:{f.Push(f.Locals[0]);f.Pc=839;continue;}
case 839:{f.Push(JValue.R(rt.String("ValidSource")));f.Pc=842;continue;}
case 842:{return rt.Call(f,"forge/game/GameObjectPredicates","matchesValidParam","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",845);}
case 845:{f.Push(f.Locals[1]);f.Pc=846;continue;}
case 846:{f.Push(JValue.R(rt.String("ValidSource")));f.Pc=849;continue;}
case 849:{return rt.Call(f,"forge/game/GameObjectPredicates","matchesValidParam","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",852);}
case 852:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",857);}
case 857:{return rt.Call(f,"java/util/stream/Stream","noneMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",862);}
case 862:{f.Pc=f.Pop().Int==0?867:865;continue;}
case 865:{f.Push(JValue.I(0));f.Pc=866;continue;}
case 866:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 867:{f.Push(f.Locals[4]);f.Pc=869;continue;}
case 869:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","DamageDealtOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","DamageDealtOnce","Lforge/game/trigger/TriggerType;"));f.Pc=872;continue;}
case 872:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",875);}
case 875:{f.Pc=f.Pop().Int==0?954:878;continue;}
case 878:{f.Push(f.Locals[0]);f.Pc=879;continue;}
case 879:{f.Push(JValue.R(rt.String("ValidSource")));f.Pc=882;continue;}
case 882:{f.Push(f.Locals[2]);f.Pc=883;continue;}
case 883:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=886;continue;}
case 886:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",891);}
case 891:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",894);}
case 894:{f.Pc=f.Pop().Int!=0?899:897;continue;}
case 897:{f.Push(JValue.I(0));f.Pc=898;continue;}
case 898:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 899:{f.Push(f.Locals[2]);f.Pc=900;continue;}
case 900:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"));f.Pc=903;continue;}
case 903:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",908);}
case 908:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=911;continue;}
case 911:{f.Locals[6]=f.Pop();f.Pc=913;continue;}
case 913:{f.Push(f.Locals[6]);f.Pc=915;continue;}
case 915:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",920);}
case 920:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",925);}
case 925:{f.Push(f.Locals[0]);f.Pc=926;continue;}
case 926:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=929;continue;}
case 929:{return rt.Call(f,"forge/game/GameObjectPredicates","matchesValidParam","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",932);}
case 932:{f.Push(f.Locals[1]);f.Pc=933;continue;}
case 933:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=936;continue;}
case 936:{return rt.Call(f,"forge/game/GameObjectPredicates","matchesValidParam","(Lforge/game/CardTraitBase;Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",939);}
case 939:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",944);}
case 944:{return rt.Call(f,"java/util/stream/Stream","noneMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",949);}
case 949:{f.Pc=f.Pop().Int==0?954:952;continue;}
case 952:{f.Push(JValue.I(0));f.Pc=953;continue;}
case 953:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 954:{f.Push(f.Locals[4]);f.Pc=956;continue;}
case 956:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","DamageAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","DamageAll","Lforge/game/trigger/TriggerType;"));f.Pc=959;continue;}
case 959:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",962);}
case 962:{f.Pc=f.Pop().Int==0?1105:965;continue;}
case 965:{f.Push(f.Locals[2]);f.Pc=966;continue;}
case 966:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"));f.Pc=969;continue;}
case 969:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",974);}
case 974:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardDamageTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=977;continue;}
case 977:{f.Locals[6]=f.Pop();f.Pc=979;continue;}
case 979:{f.Push(f.Locals[6]);f.Pc=981;continue;}
case 981:{f.Push(f.Locals[1]);f.Pc=982;continue;}
case 982:{f.Push(JValue.R(rt.String("ValidSource")));f.Pc=985;continue;}
case 985:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",988);}
case 988:{f.Push(f.Locals[1]);f.Pc=989;continue;}
case 989:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=992;continue;}
case 992:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",995);}
case 995:{f.Push(f.Locals[1]);f.Pc=996;continue;}
case 996:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",999);}
case 999:{f.Push(f.Locals[1]);f.Pc=1000;continue;}
case 1000:{return rt.Call(f,"forge/game/card/CardDamageTable","filteredMap","(Ljava/lang/String;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardDamageTable;","invokevirtual",1003);}
case 1003:{f.Locals[6]=f.Pop();f.Pc=1005;continue;}
case 1005:{f.Push(f.Locals[6]);f.Pc=1007;continue;}
case 1007:{f.Push(f.Locals[0]);f.Pc=1008;continue;}
case 1008:{f.Push(JValue.R(rt.String("ValidSource")));f.Pc=1011;continue;}
case 1011:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1014);}
case 1014:{f.Push(f.Locals[0]);f.Pc=1015;continue;}
case 1015:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=1018;continue;}
case 1018:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1021);}
case 1021:{f.Push(f.Locals[3]);f.Pc=1022;continue;}
case 1022:{f.Push(f.Locals[0]);f.Pc=1023;continue;}
case 1023:{return rt.Call(f,"forge/game/card/CardDamageTable","filteredMap","(Ljava/lang/String;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardDamageTable;","invokevirtual",1026);}
case 1026:{f.Locals[6]=f.Pop();f.Pc=1028;continue;}
case 1028:{f.Push(f.Locals[6]);f.Pc=1030;continue;}
case 1030:{return rt.Call(f,"forge/game/card/CardDamageTable","isEmpty","()Z","invokevirtual",1033);}
case 1033:{f.Pc=f.Pop().Int==0?1038:1036;continue;}
case 1036:{f.Push(JValue.I(0));f.Pc=1037;continue;}
case 1037:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1038:{f.Pc=1105;continue;}
case 1041:{f.Push(f.Locals[4]);f.Pc=1043;continue;}
case 1043:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TurnFaceUp","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TurnFaceUp","Lforge/game/trigger/TriggerType;"));f.Pc=1046;continue;}
case 1046:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",1049);}
case 1049:{f.Pc=f.Pop().Int==0?1073:1052;continue;}
case 1052:{f.Push(f.Locals[0]);f.Pc=1053;continue;}
case 1053:{f.Push(JValue.R(rt.String("ValidTurned")));f.Pc=1056;continue;}
case 1056:{f.Push(f.Locals[2]);f.Pc=1057;continue;}
case 1057:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=1060;continue;}
case 1060:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1065);}
case 1065:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",1068);}
case 1068:{f.Pc=f.Pop().Int!=0?1105:1071;continue;}
case 1071:{f.Push(JValue.I(0));f.Pc=1072;continue;}
case 1072:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1073:{f.Push(f.Locals[4]);f.Pc=1075;continue;}
case 1075:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","LifeGained","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","LifeGained","Lforge/game/trigger/TriggerType;"));f.Pc=1078;continue;}
case 1078:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",1081);}
case 1081:{f.Pc=f.Pop().Int==0?1105:1084;continue;}
case 1084:{f.Push(f.Locals[0]);f.Pc=1085;continue;}
case 1085:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=1088;continue;}
case 1088:{f.Push(f.Locals[2]);f.Pc=1089;continue;}
case 1089:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=1092;continue;}
case 1092:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1097);}
case 1097:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",1100);}
case 1100:{f.Pc=f.Pop().Int!=0?1105:1103;continue;}
case 1103:{f.Push(JValue.I(0));f.Pc=1104;continue;}
case 1104:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1105:{f.Push(JValue.I(1));f.Pc=1106;continue;}
case 1106:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
