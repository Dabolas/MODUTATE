// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C896{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerAttacks","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10224,"forge/game/trigger/TriggerAttacks","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10224));
c.Add(new JMethod(10225,"forge/game/trigger/TriggerAttacks","performTest","(Ljava/util/Map;)Z",17,7,4,new JHandler[]{},M10225));
c.Add(new JMethod(10226,"forge/game/trigger/TriggerAttacks","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",17,3,6,new JHandler[]{},M10226));
c.Add(new JMethod(10227,"forge/game/trigger/TriggerAttacks","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,3,4,new JHandler[]{},M10227));
}

internal static JStep M10224(JRuntime rt,JFrame f)
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

internal static JStep M10225(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{return rt.Call(f,"forge/game/trigger/TriggerAttacks","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?20:18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("Attacked")));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacked","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacked","Lforge/game/ability/AbilityKey;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",32);}
case 32:{return rt.Call(f,"forge/game/trigger/TriggerAttacks","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int!=0?40:38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("Alone")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/trigger/TriggerAttacks","hasParam","(Ljava/lang/String;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?104:49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OtherAttackers","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OtherAttackers","Lforge/game/ability/AbilityKey;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{f.Locals[2]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{f.Pc=f.Pop().Reference!=null?68:66;continue;}
case 66:{f.Push(JValue.I(0));f.Pc=67;continue;}
case 67:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("Alone")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/trigger/TriggerAttacks","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",74);}
case 74:{f.Push(JValue.R(rt.String("True")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int==0?93:82;continue;}
case 82:{f.Push(f.Locals[2]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",88);}
case 88:{f.Pc=f.Pop().Int==0?104:91;continue;}
case 91:{f.Push(JValue.I(0));f.Pc=92;continue;}
case 92:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",99);}
case 99:{f.Pc=f.Pop().Int!=0?104:102;continue;}
case 102:{f.Push(JValue.I(0));f.Pc=103;continue;}
case 103:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.String("FirstAttack")));f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/trigger/TriggerAttacks","hasParam","(Ljava/lang/String;)Z","invokevirtual",110);}
case 110:{f.Pc=f.Pop().Int==0?139:113;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",122);}
case 122:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=125;continue;}
case 125:{f.Locals[2]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/card/Card","getDamageHistory","()Lforge/game/card/CardDamageHistory;","invokevirtual",130);}
case 130:{return rt.Call(f,"forge/game/card/CardDamageHistory","getCreatureAttacksThisTurn","()I","invokevirtual",133);}
case 133:{f.Push(JValue.I(1));f.Pc=134;continue;}
case 134:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?139:137;continue;}
case 137:{f.Push(JValue.I(0));f.Pc=138;continue;}
case 138:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{f.Push(JValue.R(rt.String("DefendingPlayerPoisoned")));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/trigger/TriggerAttacks","hasParam","(Ljava/lang/String;)Z","invokevirtual",145);}
case 145:{f.Pc=f.Pop().Int==0?170:148;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"));f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",157);}
case 157:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=160;continue;}
case 160:{f.Locals[2]=f.Pop();f.Pc=161;continue;}
case 161:{f.Push(f.Locals[2]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/player/Player","getPoisonCounters","()I","invokevirtual",165);}
case 165:{f.Pc=f.Pop().Int!=0?170:168;continue;}
case 168:{f.Push(JValue.I(0));f.Pc=169;continue;}
case 169:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.String("AttackDifferentPlayers")));f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/trigger/TriggerAttacks","hasParam","(Ljava/lang/String;)Z","invokevirtual",176);}
case 176:{f.Pc=f.Pop().Int==0?277:179;continue;}
case 179:{f.Push(f.Locals[1]);f.Pc=180;continue;}
case 180:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacked","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacked","Lforge/game/ability/AbilityKey;"));f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",188);}
case 188:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=191;continue;}
case 191:{f.Locals[2]=f.Pop();f.Pc=192;continue;}
case 192:{f.Push(JValue.I(0));f.Pc=193;continue;}
case 193:{f.Locals[3]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(f.Locals[2]);f.Pc=195;continue;}
case 195:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=198;continue;}
case 198:{f.Pc=f.Pop().Int==0?271:201;continue;}
case 201:{f.Push(f.Locals[1]);f.Pc=202;continue;}
case 202:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Defenders","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Defenders","Lforge/game/ability/AbilityKey;"));f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",210);}
case 210:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=213;continue;}
case 213:{f.Locals[4]=f.Pop();f.Pc=215;continue;}
case 215:{f.Push(f.Locals[4]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",222);}
case 222:{f.Locals[5]=f.Pop();f.Pc=224;continue;}
case 224:{f.Push(f.Locals[5]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",231);}
case 231:{f.Pc=f.Pop().Int==0?271:234;continue;}
case 234:{f.Push(f.Locals[5]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",241);}
case 241:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=244;continue;}
case 244:{f.Locals[6]=f.Pop();f.Pc=246;continue;}
case 246:{f.Push(f.Locals[6]);f.Pc=248;continue;}
case 248:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=251;continue;}
case 251:{f.Pc=f.Pop().Int==0?268:254;continue;}
case 254:{f.Push(f.Locals[6]);f.Pc=256;continue;}
case 256:{f.Push(f.Locals[2]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/GameEntity","equals","(Ljava/lang/Object;)Z","invokevirtual",260);}
case 260:{f.Pc=f.Pop().Int!=0?268:263;continue;}
case 263:{f.Push(JValue.I(1));f.Pc=264;continue;}
case 264:{f.Locals[3]=f.Pop();f.Pc=265;continue;}
case 265:{f.Pc=271;continue;}
case 268:{f.Pc=224;continue;}
case 271:{f.Push(f.Locals[3]);f.Pc=272;continue;}
case 272:{f.Pc=f.Pop().Int!=0?277:275;continue;}
case 275:{f.Push(JValue.I(0));f.Pc=276;continue;}
case 276:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 277:{f.Push(JValue.I(1));f.Pc=278;continue;}
case 278:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10226(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Defender","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Defender","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacked","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacked","Lforge/game/ability/AbilityKey;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",13);}
case 13:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",18);}
case 18:{f.StackOp("pop");f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(3));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.NewArray("Lforge/game/ability/AbilityKey;",f.Pop().Int)));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=30;continue;}
case 30:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Defenders","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Defenders","Lforge/game/ability/AbilityKey;"));f.Pc=36;continue;}
case 36:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{f.Push(JValue.I(2));f.Pc=39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DefendingPlayer","Lforge/game/ability/AbilityKey;"));f.Pc=42;continue;}
case 42:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/ability/AbilityKey","copyKeys","(Ljava/util/Map;Ljava/util/Map;[Lforge/game/ability/AbilityKey;)V","invokestatic",46);}
case 46:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10227(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",12);}
case 12:{f.Push(JValue.R(rt.String("lblAttacker")));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",24);}
case 24:{f.Push(JValue.R(rt.String(": ")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",29);}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",36);}
case 36:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",44);}
case 44:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
