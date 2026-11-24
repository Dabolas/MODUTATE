// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C853{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityDisableTriggers","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10010,"forge/game/staticability/StaticAbilityDisableTriggers","<init>","()V",1,1,1,new JHandler[]{},M10010));
c.Add(new JMethod(10011,"forge/game/staticability/StaticAbilityDisableTriggers","disabled","(Lforge/game/Game;Lforge/game/trigger/Trigger;Ljava/util/Map;)Z",9,8,3,new JHandler[]{},M10011));
c.Add(new JMethod(10012,"forge/game/staticability/StaticAbilityDisableTriggers","isDisabled","(Lforge/game/staticability/StaticAbility;Lforge/game/trigger/Trigger;Ljava/util/Map;)Z",9,13,4,new JHandler[]{},M10012));
}

internal static JStep M10010(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10011(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[3]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/trigger/Trigger","looksBackInTime","()Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?46:9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?34:21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Reference!=null?54:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",42);}
case 42:{f.Locals[3]=f.Pop();f.Pc=43;continue;}
case 43:{f.Pc=54;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",53);}
case 53:{f.Locals[3]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",60);}
case 60:{f.Locals[4]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",69);}
case 69:{f.Pc=f.Pop().Int==0?150:72;continue;}
case 72:{f.Push(f.Locals[4]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",79);}
case 79:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=82;continue;}
case 82:{f.Locals[5]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[5]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",89);}
case 89:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",94);}
case 94:{f.Locals[6]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[6]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",103);}
case 103:{f.Pc=f.Pop().Int==0?147:106;continue;}
case 106:{f.Push(f.Locals[6]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",113);}
case 113:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=116;continue;}
case 116:{f.Locals[7]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[7]);f.Pc=120;continue;}
case 120:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","DisableTriggers","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","DisableTriggers","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int!=0?132:129;continue;}
case 129:{f.Pc=96;continue;}
case 132:{f.Push(f.Locals[7]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[2]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/staticability/StaticAbilityDisableTriggers","isDisabled","(Lforge/game/staticability/StaticAbility;Lforge/game/trigger/Trigger;Ljava/util/Map;)Z","invokestatic",139);}
case 139:{f.Pc=f.Pop().Int==0?144:142;continue;}
case 142:{f.Push(JValue.I(1));f.Pc=143;continue;}
case 143:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 144:{f.Pc=96;continue;}
case 147:{f.Pc=62;continue;}
case 150:{f.Push(JValue.I(0));f.Pc=151;continue;}
case 151:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10012(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?23:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/trigger/Trigger","getSpawningAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Reference==null?23:21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",30);}
case 30:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int!=0?38:36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("ValidTrigger")));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/trigger/Trigger","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int!=0?53:51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("ValidMode")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int==0?85:62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("ValidMode")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",68);}
case 68:{f.Push(JValue.R(rt.String(",")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",73);}
case 73:{f.Push(f.Locals[3]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/trigger/TriggerType","toString","()Ljava/lang/String;","invokevirtual",77);}
case 77:{return rt.Call(f,"org/apache/commons/lang3/ArrayUtils","contains","([Ljava/lang/Object;Ljava/lang/Object;)Z","invokestatic",80);}
case 80:{f.Pc=f.Pop().Int!=0?85:83;continue;}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesZone","Lforge/game/trigger/TriggerType;"));f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int==0?266:95;continue;}
case 95:{f.Push(f.Locals[2]);f.Pc=96;continue;}
case 96:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",104);}
case 104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=107;continue;}
case 107:{f.Locals[4]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=111;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("Origin")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",117);}
case 117:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int==0?137:123;continue;}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",132);}
case 132:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=135;continue;}
case 135:{f.Locals[4]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("ValidCause")));f.Pc=140;continue;}
case 140:{f.Push(f.Locals[4]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",145);}
case 145:{f.Pc=f.Pop().Int!=0?150:148;continue;}
case 148:{f.Push(JValue.I(0));f.Pc=149;continue;}
case 149:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String("Destination")));f.Pc=153;continue;}
case 153:{f.Push(f.Locals[2]);f.Pc=154;continue;}
case 154:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",162);}
case 162:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",165);}
case 165:{f.Pc=f.Pop().Int!=0?170:168;continue;}
case 168:{f.Push(JValue.I(0));f.Pc=169;continue;}
case 169:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.String("Origin")));f.Pc=173;continue;}
case 173:{f.Push(f.Locals[2]);f.Pc=174;continue;}
case 174:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"));f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",182);}
case 182:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",185);}
case 185:{f.Pc=f.Pop().Int!=0?190:188;continue;}
case 188:{f.Push(JValue.I(0));f.Pc=189;continue;}
case 189:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 190:{f.Push(JValue.R(rt.String("Graveyard")));f.Pc=192;continue;}
case 192:{f.Push(f.Locals[2]);f.Pc=193;continue;}
case 193:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Destination","Lforge/game/ability/AbilityKey;"));f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",201);}
case 201:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",204);}
case 204:{f.Pc=f.Pop().Int==0?263:207;continue;}
case 207:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=209;continue;}
case 209:{f.Push(f.Locals[2]);f.Pc=210;continue;}
case 210:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Origin","Lforge/game/ability/AbilityKey;"));f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",218);}
case 218:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",221);}
case 221:{f.Pc=f.Pop().Int==0?263:224;continue;}
case 224:{f.Push(JValue.R(rt.String("Card.Self")));f.Pc=226;continue;}
case 226:{f.Push(f.Locals[1]);f.Pc=227;continue;}
case 227:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",232);}
case 232:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",235);}
case 235:{f.Pc=f.Pop().Int==0?263:238;continue;}
case 238:{f.Push(f.Locals[1]);f.Pc=239;continue;}
case 239:{f.Push(JValue.R(rt.String("Origin")));f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",244);}
case 244:{f.Pc=f.Pop().Int==0?261:247;continue;}
case 247:{f.Push(JValue.R(rt.String("Any")));f.Pc=249;continue;}
case 249:{f.Push(f.Locals[1]);f.Pc=250;continue;}
case 250:{f.Push(JValue.R(rt.String("Origin")));f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",255);}
case 255:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",258);}
case 258:{f.Pc=f.Pop().Int==0?263:261;continue;}
case 261:{f.Push(JValue.I(0));f.Pc=262;continue;}
case 262:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 263:{f.Pc=579;continue;}
case 266:{f.Push(f.Locals[3]);f.Pc=267;continue;}
case 267:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChangesZoneAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChangesZoneAll","Lforge/game/trigger/TriggerType;"));f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",273);}
case 273:{f.Pc=f.Pop().Int==0?579:276;continue;}
case 276:{f.Push(f.Locals[0]);f.Pc=277;continue;}
case 277:{f.Push(JValue.R(rt.String("Origin")));f.Pc=279;continue;}
case 279:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",282);}
case 282:{f.Locals[4]=f.Pop();f.Pc=284;continue;}
case 284:{f.Push(f.Locals[0]);f.Pc=285;continue;}
case 285:{f.Push(JValue.R(rt.String("Destination")));f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",290);}
case 290:{f.Locals[5]=f.Pop();f.Pc=292;continue;}
case 292:{f.Push(f.Locals[2]);f.Pc=293;continue;}
case 293:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardsFiltered","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardsFiltered","Lforge/game/ability/AbilityKey;"));f.Pc=296;continue;}
case 296:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",301);}
case 301:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardZoneTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=304;continue;}
case 304:{f.Locals[6]=f.Pop();f.Pc=306;continue;}
case 306:{f.Push(f.Locals[6]);f.Pc=308;continue;}
case 308:{f.Pc=f.Pop().Reference!=null?325:311;continue;}
case 311:{f.Push(f.Locals[2]);f.Pc=312;continue;}
case 312:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=315;continue;}
case 315:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",320);}
case 320:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardZoneTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=323;continue;}
case 323:{f.Locals[6]=f.Pop();f.Pc=325;continue;}
case 325:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=328;continue;}
case 328:{f.StackOp("dup");f.Pc=329;continue;}
case 329:{f.Push(f.Locals[6]);f.Pc=331;continue;}
case 331:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",334);}
case 334:{f.Push(f.Locals[6]);f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/card/CardZoneTable","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",339);}
case 339:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;)V","invokespecial",342);}
case 342:{f.Locals[7]=f.Pop();f.Pc=344;continue;}
case 344:{f.Push(JValue.I(0));f.Pc=345;continue;}
case 345:{f.Locals[8]=f.Pop();f.Pc=347;continue;}
case 347:{f.Push(f.Locals[6]);f.Pc=349;continue;}
case 349:{return rt.Call(f,"forge/game/card/CardZoneTable","cellSet","()Ljava/util/Set;","invokevirtual",352);}
case 352:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",357);}
case 357:{f.Locals[9]=f.Pop();f.Pc=359;continue;}
case 359:{f.Push(f.Locals[9]);f.Pc=361;continue;}
case 361:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",366);}
case 366:{f.Pc=f.Pop().Int==0?530:369;continue;}
case 369:{f.Push(f.Locals[9]);f.Pc=371;continue;}
case 371:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",376);}
case 376:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Table$Cell"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=379;continue;}
case 379:{f.Locals[10]=f.Pop();f.Pc=381;continue;}
case 381:{f.Push(f.Locals[10]);f.Pc=383;continue;}
case 383:{return rt.Call(f,"com/google/common/collect/Table$Cell","getValue","()Ljava/lang/Object;","invokeinterface",388);}
case 388:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=391;continue;}
case 391:{f.Locals[11]=f.Pop();f.Pc=393;continue;}
case 393:{f.Push(f.Locals[4]);f.Pc=395;continue;}
case 395:{f.Pc=f.Pop().Reference==null?413:398;continue;}
case 398:{f.Push(f.Locals[10]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"com/google/common/collect/Table$Cell","getRowKey","()Ljava/lang/Object;","invokeinterface",405);}
case 405:{f.Push(f.Locals[4]);f.Pc=407;continue;}
case 407:{return rt.Call(f,"forge/game/zone/ZoneType","valueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",410);}
case 410:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?499:413;continue;}
case 413:{f.Push(f.Locals[5]);f.Pc=415;continue;}
case 415:{f.Pc=f.Pop().Reference==null?433:418;continue;}
case 418:{f.Push(f.Locals[10]);f.Pc=420;continue;}
case 420:{return rt.Call(f,"com/google/common/collect/Table$Cell","getColumnKey","()Ljava/lang/Object;","invokeinterface",425);}
case 425:{f.Push(f.Locals[5]);f.Pc=427;continue;}
case 427:{return rt.Call(f,"forge/game/zone/ZoneType","valueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",430);}
case 430:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?499:433;continue;}
case 433:{f.Push(f.Locals[0]);f.Pc=434;continue;}
case 434:{f.Push(JValue.R(rt.String("ValidCause")));f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",439);}
case 439:{f.Push(JValue.R(rt.String(",")));f.Pc=441;continue;}
case 441:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",444);}
case 444:{f.Push(f.Locals[0]);f.Pc=445;continue;}
case 445:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",448);}
case 448:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",451);}
case 451:{f.Push(f.Locals[0]);f.Pc=452;continue;}
case 452:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",455);}
case 455:{f.Push(f.Locals[0]);f.Pc=456;continue;}
case 456:{return rt.Call(f,"forge/game/card/CardPredicates","restriction","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",459);}
case 459:{f.Locals[12]=f.Pop();f.Pc=461;continue;}
case 461:{f.Push(f.Locals[11]);f.Pc=463;continue;}
case 463:{f.Push(f.Locals[12]);f.Pc=465;continue;}
case 465:{return rt.Call(f,"java/util/function/Predicate","negate","()Ljava/util/function/Predicate;","invokeinterface",470);}
case 470:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",473);}
case 473:{f.Locals[11]=f.Pop();f.Pc=475;continue;}
case 475:{f.Push(f.Locals[11]);f.Pc=477;continue;}
case 477:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",480);}
case 480:{f.Push(f.Locals[10]);f.Pc=482;continue;}
case 482:{return rt.Call(f,"com/google/common/collect/Table$Cell","getValue","()Ljava/lang/Object;","invokeinterface",487);}
case 487:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=490;continue;}
case 490:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",493);}
case 493:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?499:496;continue;}
case 496:{f.Push(JValue.I(1));f.Pc=497;continue;}
case 497:{f.Locals[8]=f.Pop();f.Pc=499;continue;}
case 499:{f.Push(f.Locals[7]);f.Pc=501;continue;}
case 501:{f.Push(f.Locals[10]);f.Pc=503;continue;}
case 503:{return rt.Call(f,"com/google/common/collect/Table$Cell","getRowKey","()Ljava/lang/Object;","invokeinterface",508);}
case 508:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=511;continue;}
case 511:{f.Push(f.Locals[10]);f.Pc=513;continue;}
case 513:{return rt.Call(f,"com/google/common/collect/Table$Cell","getColumnKey","()Ljava/lang/Object;","invokeinterface",518);}
case 518:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=521;continue;}
case 521:{f.Push(f.Locals[11]);f.Pc=523;continue;}
case 523:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",526);}
case 526:{f.StackOp("pop");f.Pc=527;continue;}
case 527:{f.Pc=359;continue;}
case 530:{f.Push(f.Locals[8]);f.Pc=532;continue;}
case 532:{f.Pc=f.Pop().Int!=0?537:535;continue;}
case 535:{f.Push(JValue.I(0));f.Pc=536;continue;}
case 536:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 537:{f.Push(f.Locals[2]);f.Pc=538;continue;}
case 538:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","(Ljava/util/Map;)Ljava/util/EnumMap;","invokestatic",541);}
case 541:{f.Locals[9]=f.Pop();f.Pc=543;continue;}
case 543:{f.Push(f.Locals[9]);f.Pc=545;continue;}
case 545:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=548;continue;}
case 548:{f.Push(f.Locals[7]);f.Pc=550;continue;}
case 550:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",555);}
case 555:{f.StackOp("pop");f.Pc=556;continue;}
case 556:{f.Push(f.Locals[1]);f.Pc=557;continue;}
case 557:{f.Push(f.Locals[9]);f.Pc=559;continue;}
case 559:{return rt.Call(f,"forge/game/trigger/Trigger","performTest","(Ljava/util/Map;)Z","invokevirtual",562);}
case 562:{f.Pc=f.Pop().Int==0?579:565;continue;}
case 565:{f.Push(f.Locals[2]);f.Pc=566;continue;}
case 566:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardsFiltered","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardsFiltered","Lforge/game/ability/AbilityKey;"));f.Pc=569;continue;}
case 569:{f.Push(f.Locals[7]);f.Pc=571;continue;}
case 571:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",576);}
case 576:{f.StackOp("pop");f.Pc=577;continue;}
case 577:{f.Push(JValue.I(0));f.Pc=578;continue;}
case 578:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 579:{f.Push(JValue.I(1));f.Pc=580;continue;}
case 580:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
