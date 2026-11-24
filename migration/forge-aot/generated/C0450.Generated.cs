// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C450{
internal static JClass Build(){var c=new JClass("forge/game/card/CardDamageTable","com/google/common/collect/ForwardingTable",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("dataMap","Lcom/google/common/collect/Table;",false,JValue.Default("Lcom/google/common/collect/Table;"),null));
c.Add(new JMethod(4968,"forge/game/card/CardDamageTable","<init>","(Lcom/google/common/collect/Table;)V",1,2,2,new JHandler[]{},M4968));
c.Add(new JMethod(4969,"forge/game/card/CardDamageTable","<init>","()V",1,1,2,new JHandler[]{},M4969));
c.Add(new JMethod(4970,"forge/game/card/CardDamageTable","triggerPreventDamage","(Z)V",1,8,4,new JHandler[]{},M4970));
c.Add(new JMethod(4971,"forge/game/card/CardDamageTable","triggerDamageDoneOnce","(ZLforge/game/Game;)V",1,11,6,new JHandler[]{},M4971));
c.Add(new JMethod(4972,"forge/game/card/CardDamageTable","triggerExcessDamage","(ZLjava/util/Map;Lforge/game/Game;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)V",1,13,5,new JHandler[]{},M4972));
c.Add(new JMethod(4973,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;",1,5,5,new JHandler[]{},M4973));
c.Add(new JMethod(4974,"forge/game/card/CardDamageTable","delegate","()Lcom/google/common/collect/Table;",4,1,1,new JHandler[]{},M4974));
c.Add(new JMethod(4975,"forge/game/card/CardDamageTable","totalAmount","()I",1,4,2,new JHandler[]{},M4975));
c.Add(new JMethod(4976,"forge/game/card/CardDamageTable","filteredMap","(Ljava/lang/String;Ljava/lang/String;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardDamageTable;",1,10,5,new JHandler[]{},M4976));
c.Add(new JMethod(4977,"forge/game/card/CardDamageTable","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;",4161,4,4,new JHandler[]{},M4977));
c.Add(new JMethod(4978,"forge/game/card/CardDamageTable","delegate","()Ljava/lang/Object;",4164,1,1,new JHandler[]{},M4978));
}

internal static JStep M4968(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/ForwardingTable","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","()Lcom/google/common/collect/HashBasedTable;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageTable","dataMap","Lcom/google/common/collect/Table;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/CardDamageTable","putAll","(Lcom/google/common/collect/Table;)V","invokevirtual",16);}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4969(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/ForwardingTable","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","()Lcom/google/common/collect/HashBasedTable;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardDamageTable","dataMap","Lcom/google/common/collect/Table;",value);f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4970(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardDamageTable","columnMap","()Ljava/util/Map;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?220:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",51);}
case 51:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",56);}
case 56:{f.Locals[5]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int==0?93:68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",75);}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",81);}
case 81:{f.Locals[6]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[6]);f.Pc=87;continue;}
case 87:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=88;continue;}
case 88:{f.Locals[4]=f.Pop();f.Pc=90;continue;}
case 90:{f.Pc=58;continue;}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{f.Pc=f.Pop().Int<=0?217:98;continue;}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",104);}
case 104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=107;continue;}
case 107:{f.Locals[5]=f.Pop();f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",112);}
case 112:{f.Locals[6]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[6]);f.Pc=116;continue;}
case 116:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageTarget","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageTarget","Lforge/game/ability/AbilityKey;"));f.Pc=119;continue;}
case 119:{f.Push(f.Locals[5]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",126);}
case 126:{f.StackOp("pop");f.Pc=127;continue;}
case 127:{f.Push(f.Locals[6]);f.Pc=129;continue;}
case 129:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=132;continue;}
case 132:{f.Push(f.Locals[4]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",137);}
case 137:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",142);}
case 142:{f.StackOp("pop");f.Pc=143;continue;}
case 143:{f.Push(f.Locals[6]);f.Pc=145;continue;}
case 145:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IsCombatDamage","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IsCombatDamage","Lforge/game/ability/AbilityKey;"));f.Pc=148;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",152);}
case 152:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",157);}
case 157:{f.StackOp("pop");f.Pc=158;continue;}
case 158:{f.Push(f.Locals[5]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/GameEntity","getGame","()Lforge/game/Game;","invokevirtual",163);}
case 163:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",166);}
case 166:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","DamagePreventedOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","DamagePreventedOnce","Lforge/game/trigger/TriggerType;"));f.Pc=169;continue;}
case 169:{f.Push(f.Locals[6]);f.Pc=171;continue;}
case 171:{f.Push(JValue.I(0));f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",175);}
case 175:{f.Push(f.Locals[5]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/GameEntity","getView","()Lforge/game/GameEntityView;","invokevirtual",180);}
case 180:{f.Push(f.Locals[5]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/GameEntityView","updatePreventNextDamage","(Lforge/game/GameEntity;)V","invokevirtual",185);}
case 185:{f.Push(f.Locals[5]);f.Pc=187;continue;}
case 187:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=190;continue;}
case 190:{f.Pc=f.Pop().Int==0?217:193;continue;}
case 193:{f.Push(f.Locals[5]);f.Pc=195;continue;}
case 195:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=198;continue;}
case 198:{f.Locals[7]=f.Pop();f.Pc=200;continue;}
case 200:{f.Push(f.Locals[5]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/GameEntity","getGame","()Lforge/game/Game;","invokevirtual",205);}
case 205:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventPlayerStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventPlayerStatsChanged")));f.Pc=208;continue;}
case 208:{f.StackOp("dup");f.Pc=209;continue;}
case 209:{f.Push(f.Locals[7]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/event/GameEventPlayerStatsChanged","<init>","(Lforge/game/player/Player;)V","invokespecial",214);}
case 214:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",217);}
case 217:{f.Pc=15;continue;}
case 220:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4971(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardDamageTable","rowMap","()Ljava/util/Map;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?185:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[5]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{f.Locals[6]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",57);}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",65);}
case 65:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",70);}
case 70:{f.Locals[7]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[7]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",79);}
case 79:{f.Pc=f.Pop().Int==0?107:82;continue;}
case 82:{f.Push(f.Locals[7]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",89);}
case 89:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=92;continue;}
case 92:{f.Locals[8]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[6]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[8]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",101);}
case 101:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=102;continue;}
case 102:{f.Locals[6]=f.Pop();f.Pc=104;continue;}
case 104:{f.Pc=72;continue;}
case 107:{f.Push(f.Locals[6]);f.Pc=109;continue;}
case 109:{f.Pc=f.Pop().Int<=0?182:112;continue;}
case 112:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",115);}
case 115:{f.Locals[7]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[7]);f.Pc=119;continue;}
case 119:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=122;continue;}
case 122:{f.Push(f.Locals[5]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",129);}
case 129:{f.StackOp("pop");f.Pc=130;continue;}
case 130:{f.Push(f.Locals[7]);f.Pc=132;continue;}
case 132:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"));f.Pc=135;continue;}
case 135:{f.Push(f.Locals[4]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",142);}
case 142:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=145;continue;}
case 145:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","(Ljava/util/Map;)Ljava/util/HashMap;","invokestatic",148);}
case 148:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",153);}
case 153:{f.StackOp("pop");f.Pc=154;continue;}
case 154:{f.Push(f.Locals[7]);f.Pc=156;continue;}
case 156:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IsCombatDamage","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IsCombatDamage","Lforge/game/ability/AbilityKey;"));f.Pc=159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",163);}
case 163:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",168);}
case 168:{f.StackOp("pop");f.Pc=169;continue;}
case 169:{f.Push(f.Locals[2]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",173);}
case 173:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","DamageDealtOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","DamageDealtOnce","Lforge/game/trigger/TriggerType;"));f.Pc=176;continue;}
case 176:{f.Push(f.Locals[7]);f.Pc=178;continue;}
case 178:{f.Push(JValue.I(0));f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",182);}
case 182:{f.Pc=15;continue;}
case 185:{f.Push(f.Locals[0]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/card/CardDamageTable","columnMap","()Ljava/util/Map;","invokevirtual",189);}
case 189:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",194);}
case 194:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",199);}
case 199:{f.Locals[3]=f.Pop();f.Pc=200;continue;}
case 200:{f.Push(f.Locals[3]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",206);}
case 206:{f.Pc=f.Pop().Int==0?543:209;continue;}
case 209:{f.Push(f.Locals[3]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",215);}
case 215:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=218;continue;}
case 218:{f.Locals[4]=f.Pop();f.Pc=220;continue;}
case 220:{f.Push(JValue.I(0));f.Pc=221;continue;}
case 221:{f.Locals[5]=f.Pop();f.Pc=223;continue;}
case 223:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=226;continue;}
case 226:{f.StackOp("dup");f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","()V","invokespecial",230);}
case 230:{f.Locals[6]=f.Pop();f.Pc=232;continue;}
case 232:{f.Push(f.Locals[4]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",239);}
case 239:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",247);}
case 247:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",252);}
case 252:{f.Locals[7]=f.Pop();f.Pc=254;continue;}
case 254:{f.Push(f.Locals[7]);f.Pc=256;continue;}
case 256:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",261);}
case 261:{f.Pc=f.Pop().Int==0?316:264;continue;}
case 264:{f.Push(f.Locals[7]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",271);}
case 271:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=274;continue;}
case 274:{f.Locals[8]=f.Pop();f.Pc=276;continue;}
case 276:{f.Push(f.Locals[5]);f.Pc=278;continue;}
case 278:{f.Push(f.Locals[8]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",285);}
case 285:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=288;continue;}
case 288:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",291);}
case 291:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=292;continue;}
case 292:{f.Locals[5]=f.Pop();f.Pc=294;continue;}
case 294:{f.Push(f.Locals[6]);f.Pc=296;continue;}
case 296:{f.Push(f.Locals[8]);f.Pc=298;continue;}
case 298:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",303);}
case 303:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",309);}
case 309:{return rt.Call(f,"forge/game/player/PlayerCollection","add","(Ljava/lang/Object;)Z","invokevirtual",312);}
case 312:{f.StackOp("pop");f.Pc=313;continue;}
case 313:{f.Pc=254;continue;}
case 316:{f.Push(f.Locals[5]);f.Pc=318;continue;}
case 318:{f.Pc=f.Pop().Int<=0?437:321;continue;}
case 321:{f.Push(f.Locals[4]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",328);}
case 328:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=331;continue;}
case 331:{f.Locals[7]=f.Pop();f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",336);}
case 336:{f.Locals[8]=f.Pop();f.Pc=338;continue;}
case 338:{f.Push(f.Locals[8]);f.Pc=340;continue;}
case 340:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageTarget","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageTarget","Lforge/game/ability/AbilityKey;"));f.Pc=343;continue;}
case 343:{f.Push(f.Locals[7]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",350);}
case 350:{f.StackOp("pop");f.Pc=351;continue;}
case 351:{f.Push(f.Locals[8]);f.Pc=353;continue;}
case 353:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"));f.Pc=356;continue;}
case 356:{f.Push(f.Locals[4]);f.Pc=358;continue;}
case 358:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",363);}
case 363:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=366;continue;}
case 366:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","(Ljava/util/Map;)Ljava/util/HashMap;","invokestatic",369);}
case 369:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",374);}
case 374:{f.StackOp("pop");f.Pc=375;continue;}
case 375:{f.Push(f.Locals[8]);f.Pc=377;continue;}
case 377:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IsCombatDamage","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IsCombatDamage","Lforge/game/ability/AbilityKey;"));f.Pc=380;continue;}
case 380:{f.Push(f.Locals[1]);f.Pc=381;continue;}
case 381:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",384);}
case 384:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",389);}
case 389:{f.StackOp("pop");f.Pc=390;continue;}
case 390:{f.Push(f.Locals[8]);f.Pc=392;continue;}
case 392:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","FirstTime","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","FirstTime","Lforge/game/ability/AbilityKey;"));f.Pc=395;continue;}
case 395:{f.Push(f.Locals[5]);f.Pc=397;continue;}
case 397:{f.Push(f.Locals[7]);f.Pc=399;continue;}
case 399:{f.Push(f.Locals[1]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",403);}
case 403:{f.Push(JValue.R(null));f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/game/GameEntity","getAssignedDamage","(Ljava/lang/Boolean;Lforge/game/card/Card;)I","invokevirtual",407);}
case 407:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?414:410;continue;}
case 410:{f.Push(JValue.I(1));f.Pc=411;continue;}
case 411:{f.Pc=415;continue;}
case 414:{f.Push(JValue.I(0));f.Pc=415;continue;}
case 415:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",418);}
case 418:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",423);}
case 423:{f.StackOp("pop");f.Pc=424;continue;}
case 424:{f.Push(f.Locals[2]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",428);}
case 428:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","DamageDoneOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","DamageDoneOnce","Lforge/game/trigger/TriggerType;"));f.Pc=431;continue;}
case 431:{f.Push(f.Locals[8]);f.Pc=433;continue;}
case 433:{f.Push(JValue.I(0));f.Pc=434;continue;}
case 434:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",437);}
case 437:{f.Push(f.Locals[6]);f.Pc=439;continue;}
case 439:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",442);}
case 442:{f.Locals[7]=f.Pop();f.Pc=444;continue;}
case 444:{f.Push(f.Locals[7]);f.Pc=446;continue;}
case 446:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",451);}
case 451:{f.Pc=f.Pop().Int==0?540:454;continue;}
case 454:{f.Push(f.Locals[7]);f.Pc=456;continue;}
case 456:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",461);}
case 461:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=464;continue;}
case 464:{f.Locals[8]=f.Pop();f.Pc=466;continue;}
case 466:{f.Push(f.Locals[4]);f.Pc=468;continue;}
case 468:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",473);}
case 473:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=476;continue;}
case 476:{f.Locals[9]=f.Pop();f.Pc=478;continue;}
case 478:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",481);}
case 481:{f.Locals[10]=f.Pop();f.Pc=483;continue;}
case 483:{f.Push(f.Locals[10]);f.Pc=485;continue;}
case 485:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageTarget","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageTarget","Lforge/game/ability/AbilityKey;"));f.Pc=488;continue;}
case 488:{f.Push(f.Locals[9]);f.Pc=490;continue;}
case 490:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",495);}
case 495:{f.StackOp("pop");f.Pc=496;continue;}
case 496:{f.Push(f.Locals[10]);f.Pc=498;continue;}
case 498:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageSource","Lforge/game/ability/AbilityKey;"));f.Pc=501;continue;}
case 501:{f.Push(f.Locals[8]);f.Pc=503;continue;}
case 503:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",508);}
case 508:{f.StackOp("pop");f.Pc=509;continue;}
case 509:{f.Push(f.Locals[10]);f.Pc=511;continue;}
case 511:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IsCombatDamage","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IsCombatDamage","Lforge/game/ability/AbilityKey;"));f.Pc=514;continue;}
case 514:{f.Push(f.Locals[1]);f.Pc=515;continue;}
case 515:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",518);}
case 518:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",523);}
case 523:{f.StackOp("pop");f.Pc=524;continue;}
case 524:{f.Push(f.Locals[2]);f.Pc=525;continue;}
case 525:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",528);}
case 528:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","DamageDoneOnceByController","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","DamageDoneOnceByController","Lforge/game/trigger/TriggerType;"));f.Pc=531;continue;}
case 531:{f.Push(f.Locals[10]);f.Pc=533;continue;}
case 533:{f.Push(JValue.I(0));f.Pc=534;continue;}
case 534:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",537);}
case 537:{f.Pc=444;continue;}
case 540:{f.Pc=200;continue;}
case 543:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",546);}
case 546:{f.Locals[3]=f.Pop();f.Pc=547;continue;}
case 547:{f.Push(f.Locals[3]);f.Pc=548;continue;}
case 548:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageMap","Lforge/game/ability/AbilityKey;"));f.Pc=551;continue;}
case 551:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=554;continue;}
case 554:{f.StackOp("dup");f.Pc=555;continue;}
case 555:{f.Push(f.Locals[0]);f.Pc=556;continue;}
case 556:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","(Lcom/google/common/collect/Table;)V","invokespecial",559);}
case 559:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",564);}
case 564:{f.StackOp("pop");f.Pc=565;continue;}
case 565:{f.Push(f.Locals[3]);f.Pc=566;continue;}
case 566:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IsCombatDamage","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IsCombatDamage","Lforge/game/ability/AbilityKey;"));f.Pc=569;continue;}
case 569:{f.Push(f.Locals[1]);f.Pc=570;continue;}
case 570:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",573);}
case 573:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",578);}
case 578:{f.StackOp("pop");f.Pc=579;continue;}
case 579:{f.Push(f.Locals[2]);f.Pc=580;continue;}
case 580:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",583);}
case 583:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","DamageAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","DamageAll","Lforge/game/trigger/TriggerType;"));f.Pc=586;continue;}
case 586:{f.Push(f.Locals[3]);f.Pc=587;continue;}
case 587:{f.Push(JValue.I(0));f.Pc=588;continue;}
case 588:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",591);}
case 591:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4972(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[6]=f.Pop();f.Pc=3;continue;}
case 3:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=6;continue;}
case 6:{f.StackOp("dup");f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",10);}
case 10:{f.Locals[7]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",18);}
case 18:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",23);}
case 23:{f.Locals[8]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[8]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?386:35;continue;}
case 35:{f.Push(f.Locals[8]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[9]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{f.Locals[10]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[9]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/card/CardDamageTable","column","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",64);}
case 64:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",69);}
case 69:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",74);}
case 74:{f.Locals[11]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[11]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",83);}
case 83:{f.Pc=f.Pop().Int==0?111:86;continue;}
case 86:{f.Push(f.Locals[11]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",93);}
case 93:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=96;continue;}
case 96:{f.Locals[12]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[10]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[12]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",105);}
case 105:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=106;continue;}
case 106:{f.Locals[10]=f.Pop();f.Pc=108;continue;}
case 108:{f.Pc=76;continue;}
case 111:{f.Push(f.Locals[10]);f.Pc=113;continue;}
case 113:{f.Pc=f.Pop().Int!=0?119:116;continue;}
case 116:{f.Pc=25;continue;}
case 119:{f.Push(f.Locals[10]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[9]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",128);}
case 128:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/card/Card","hasBeenDealtDeathtouchDamage","()Z","invokevirtual",134);}
case 134:{f.Pc=f.Pop().Int==0?141:137;continue;}
case 137:{f.Push(JValue.I(1));f.Pc=138;continue;}
case 138:{f.Pc=154;continue;}
case 141:{f.Push(f.Locals[9]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",148);}
case 148:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",154);}
case 154:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=155;continue;}
case 155:{f.Locals[11]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[5]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[9]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",166);}
case 166:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",172);}
case 172:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",175);}
case 175:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",180);}
case 180:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[11]);f.Pc=185;continue;}
case 185:{f.Pc=f.Pop().Int<=0?192:188;continue;}
case 188:{f.Push(JValue.I(1));f.Pc=189;continue;}
case 189:{f.Pc=193;continue;}
case 192:{f.Push(JValue.I(0));f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/card/Card","setHasBeenDealtExcessDamageThisTurn","(Z)V","invokevirtual",196);}
case 196:{f.Push(f.Locals[11]);f.Pc=198;continue;}
case 198:{f.Pc=f.Pop().Int>0?204:201;continue;}
case 201:{f.Pc=25;continue;}
case 204:{f.Push(f.Locals[4]);f.Pc=206;continue;}
case 206:{f.Pc=f.Pop().Reference==null?271:209;continue;}
case 209:{f.Push(f.Locals[4]);f.Pc=211;continue;}
case 211:{f.Push(JValue.R(rt.String("ExcessSVar")));f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",216);}
case 216:{f.Pc=f.Pop().Int==0?271:219;continue;}
case 219:{f.Push(f.Locals[4]);f.Pc=221;continue;}
case 221:{f.Push(JValue.R(rt.String("ExcessSVarCondition")));f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",226);}
case 226:{f.Pc=f.Pop().Int==0?264:229;continue;}
case 229:{f.Push(f.Locals[9]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",236);}
case 236:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=239;continue;}
case 239:{f.Push(f.Locals[4]);f.Pc=241;continue;}
case 241:{f.Push(JValue.R(rt.String("ExcessSVarCondition")));f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",246);}
case 246:{f.Push(f.Locals[4]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",251);}
case 251:{f.Push(f.Locals[4]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",256);}
case 256:{f.Push(f.Locals[4]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/card/Card","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",261);}
case 261:{f.Pc=f.Pop().Int==0?271:264;continue;}
case 264:{f.Push(f.Locals[6]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[11]);f.Pc=268;continue;}
case 268:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=269;continue;}
case 269:{f.Locals[6]=f.Pop();f.Pc=271;continue;}
case 271:{f.Push(f.Locals[9]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",278);}
case 278:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=281;continue;}
case 281:{f.Push(JValue.I(1));f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/card/Card","setHasBeenDealtExcessDamageThisTurn","(Z)V","invokevirtual",285);}
case 285:{f.Push(f.Locals[9]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",292);}
case 292:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[11]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/card/Card","logExcessDamage","(I)V","invokevirtual",300);}
case 300:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",303);}
case 303:{f.Locals[12]=f.Pop();f.Pc=305;continue;}
case 305:{f.Push(f.Locals[12]);f.Pc=307;continue;}
case 307:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageTarget","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageTarget","Lforge/game/ability/AbilityKey;"));f.Pc=310;continue;}
case 310:{f.Push(f.Locals[9]);f.Pc=312;continue;}
case 312:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",317);}
case 317:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",322);}
case 322:{f.StackOp("pop");f.Pc=323;continue;}
case 323:{f.Push(f.Locals[12]);f.Pc=325;continue;}
case 325:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageAmount","Lforge/game/ability/AbilityKey;"));f.Pc=328;continue;}
case 328:{f.Push(f.Locals[11]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",333);}
case 333:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",338);}
case 338:{f.StackOp("pop");f.Pc=339;continue;}
case 339:{f.Push(f.Locals[12]);f.Pc=341;continue;}
case 341:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IsCombatDamage","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IsCombatDamage","Lforge/game/ability/AbilityKey;"));f.Pc=344;continue;}
case 344:{f.Push(f.Locals[1]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",348);}
case 348:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",353);}
case 353:{f.StackOp("pop");f.Pc=354;continue;}
case 354:{f.Push(f.Locals[3]);f.Pc=355;continue;}
case 355:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",358);}
case 358:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ExcessDamage","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ExcessDamage","Lforge/game/trigger/TriggerType;"));f.Pc=361;continue;}
case 361:{f.Push(f.Locals[12]);f.Pc=363;continue;}
case 363:{f.Push(JValue.I(0));f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",367);}
case 367:{f.Push(f.Locals[7]);f.Pc=369;continue;}
case 369:{f.Push(f.Locals[9]);f.Pc=371;continue;}
case 371:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",376);}
case 376:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",382);}
case 382:{f.StackOp("pop");f.Pc=383;continue;}
case 383:{f.Pc=25;continue;}
case 386:{f.Push(f.Locals[4]);f.Pc=388;continue;}
case 388:{f.Pc=f.Pop().Reference==null?418:391;continue;}
case 391:{f.Push(f.Locals[4]);f.Pc=393;continue;}
case 393:{f.Push(JValue.R(rt.String("ExcessSVar")));f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",398);}
case 398:{f.Pc=f.Pop().Int==0?418:401;continue;}
case 401:{f.Push(f.Locals[4]);f.Pc=403;continue;}
case 403:{f.Push(f.Locals[4]);f.Pc=405;continue;}
case 405:{f.Push(JValue.R(rt.String("ExcessSVar")));f.Pc=407;continue;}
case 407:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",410);}
case 410:{f.Push(f.Locals[6]);f.Pc=412;continue;}
case 412:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",415);}
case 415:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",418);}
case 418:{f.Push(f.Locals[7]);f.Pc=420;continue;}
case 420:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",423);}
case 423:{f.Pc=f.Pop().Int!=0?472:426;continue;}
case 426:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",429);}
case 429:{f.Locals[8]=f.Pop();f.Pc=431;continue;}
case 431:{f.Push(f.Locals[8]);f.Pc=433;continue;}
case 433:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DamageTargets","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DamageTargets","Lforge/game/ability/AbilityKey;"));f.Pc=436;continue;}
case 436:{f.Push(f.Locals[7]);f.Pc=438;continue;}
case 438:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",443);}
case 443:{f.StackOp("pop");f.Pc=444;continue;}
case 444:{f.Push(f.Locals[8]);f.Pc=446;continue;}
case 446:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IsCombatDamage","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IsCombatDamage","Lforge/game/ability/AbilityKey;"));f.Pc=449;continue;}
case 449:{f.Push(f.Locals[1]);f.Pc=450;continue;}
case 450:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",453);}
case 453:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",458);}
case 458:{f.StackOp("pop");f.Pc=459;continue;}
case 459:{f.Push(f.Locals[3]);f.Pc=460;continue;}
case 460:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",463);}
case 463:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ExcessDamageAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ExcessDamageAll","Lforge/game/trigger/TriggerType;"));f.Pc=466;continue;}
case 466:{f.Push(f.Locals[8]);f.Pc=468;continue;}
case 468:{f.Push(JValue.I(0));f.Pc=469;continue;}
case 469:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",472);}
case 472:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4973(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/CardDamageTable","contains","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?24:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardDamageTable","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",21);}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",28);}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageTable","dataMap","Lcom/google/common/collect/Table;"));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",40);}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",45);}
case 45:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",49);}
case 49:{return rt.Call(f,"com/google/common/collect/Table","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",54);}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4974(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardDamageTable","dataMap","Lcom/google/common/collect/Table;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4975(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/CardDamageTable","values","()Ljava/util/Collection;","invokevirtual",6);}
case 6:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",18);}
case 18:{f.Pc=f.Pop().Int==0?41:21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",33);}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=37;continue;}
case 37:{f.Locals[1]=f.Pop();f.Pc=38;continue;}
case 38:{f.Pc=12;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4976(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","()V","invokespecial",7);}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{f.Locals[6]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{f.Locals[7]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Pc=f.Pop().Reference==null?63:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardDamageTable","rowKeySet","()Ljava/util/Set;","invokevirtual",23);}
case 23:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",28);}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String(",")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",35);}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",39);}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/GameObjectPredicates","restriction","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",45);}
case 45:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",50);}
case 50:{return rt.Call(f,"java/util/stream/Collectors","toSet","()Ljava/util/stream/Collector;","invokestatic",53);}
case 53:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{f.Locals[6]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{f.Pc=f.Pop().Reference==null?111:67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/card/CardDamageTable","columnKeySet","()Ljava/util/Set;","invokevirtual",71);}
case 71:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",76);}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String(",")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",83);}
case 83:{f.Push(f.Locals[3]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",87);}
case 87:{f.Push(f.Locals[3]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[4]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/GameObjectPredicates","restriction","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",93);}
case 93:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",98);}
case 98:{return rt.Call(f,"java/util/stream/Collectors","toSet","()Ljava/util/stream/Collector;","invokestatic",101);}
case 101:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",106);}
case 106:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=109;continue;}
case 109:{f.Locals[7]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/CardDamageTable","cellSet","()Ljava/util/Set;","invokevirtual",115);}
case 115:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",120);}
case 120:{f.Locals[8]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[8]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",129);}
case 129:{f.Pc=f.Pop().Int==0?233:132;continue;}
case 132:{f.Push(f.Locals[8]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",139);}
case 139:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Table$Cell"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=142;continue;}
case 142:{f.Locals[9]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[6]);f.Pc=146;continue;}
case 146:{f.Pc=f.Pop().Reference==null?169:149;continue;}
case 149:{f.Push(f.Locals[6]);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[9]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"com/google/common/collect/Table$Cell","getRowKey","()Ljava/lang/Object;","invokeinterface",158);}
case 158:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",163);}
case 163:{f.Pc=f.Pop().Int!=0?169:166;continue;}
case 166:{f.Pc=122;continue;}
case 169:{f.Push(f.Locals[7]);f.Pc=171;continue;}
case 171:{f.Pc=f.Pop().Reference==null?194:174;continue;}
case 174:{f.Push(f.Locals[7]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[9]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"com/google/common/collect/Table$Cell","getColumnKey","()Ljava/lang/Object;","invokeinterface",183);}
case 183:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",188);}
case 188:{f.Pc=f.Pop().Int!=0?194:191;continue;}
case 191:{f.Pc=122;continue;}
case 194:{f.Push(f.Locals[5]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[9]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"com/google/common/collect/Table$Cell","getRowKey","()Ljava/lang/Object;","invokeinterface",203);}
case 203:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[9]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"com/google/common/collect/Table$Cell","getColumnKey","()Ljava/lang/Object;","invokeinterface",213);}
case 213:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=216;continue;}
case 216:{f.Push(f.Locals[9]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"com/google/common/collect/Table$Cell","getValue","()Ljava/lang/Object;","invokeinterface",223);}
case 223:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",229);}
case 229:{f.StackOp("pop");f.Pc=230;continue;}
case 230:{f.Pc=122;continue;}
case 233:{f.Push(f.Locals[5]);f.Pc=235;continue;}
case 235:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4977(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4978(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardDamageTable","delegate","()Lcom/google/common/collect/Table;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
