// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C154{
internal static JClass Build(){var c=new JClass("forge/game/GameLogFormatter","forge/game/event/IGameEventVisitor$Base",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("localizer","Lforge/util/Localizer;",false,JValue.Default("Lforge/util/Localizer;"),null));
c.Add(new JField("log","Lforge/game/GameLog;",false,JValue.Default("Lforge/game/GameLog;"),null));
c.Add(new JMethod(2411,"forge/game/GameLogFormatter","<init>","(Lforge/game/GameLog;)V",1,2,2,new JHandler[]{},M2411));
c.Add(new JMethod(2412,"forge/game/GameLogFormatter","formatDuration","(J)Ljava/lang/String;",2,11,6,new JHandler[]{},M2412));
c.Add(new JMethod(2413,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventGameOutcome;)Lforge/game/GameLogEntry;",1,5,6,new JHandler[]{},M2413));
c.Add(new JMethod(2414,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventScry;)Lforge/game/GameLogEntry;",1,3,4,new JHandler[]{},M2414));
c.Add(new JMethod(2415,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventSurveil;)Lforge/game/GameLogEntry;",1,3,6,new JHandler[]{},M2415));
c.Add(new JMethod(2416,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventSpellResolved;)Lforge/game/GameLogEntry;",1,3,6,new JHandler[]{},M2416));
c.Add(new JMethod(2417,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventSpellAbilityCast;)Lforge/game/GameLogEntry;",1,7,6,new JHandler[]{},M2417));
c.Add(new JMethod(2418,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventCardModeChosen;)Lforge/game/GameLogEntry;",1,4,6,new JHandler[]{},M2418));
c.Add(new JMethod(2419,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventRandomLog;)Lforge/game/GameLogEntry;",1,2,4,new JHandler[]{},M2419));
c.Add(new JMethod(2420,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventPlayerControl;)Lforge/game/GameLogEntry;",1,5,6,new JHandler[]{},M2420));
c.Add(new JMethod(2421,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventTurnPhase;)Lforge/game/GameLogEntry;",1,3,7,new JHandler[]{},M2421));
c.Add(new JMethod(2422,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventCardDamaged;)Lforge/game/GameLogEntry;",1,4,6,new JHandler[]{},M2422));
c.Add(new JMethod(2423,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventLandPlayed;)Lforge/game/GameLogEntry;",1,3,6,new JHandler[]{},M2423));
c.Add(new JMethod(2424,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventTurnBegan;)Lforge/game/GameLogEntry;",1,3,6,new JHandler[]{},M2424));
c.Add(new JMethod(2425,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventPlayerDamaged;)Lforge/game/GameLogEntry;",1,5,6,new JHandler[]{},M2425));
c.Add(new JMethod(2426,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventPlayerLivesChanged;)Lforge/game/GameLogEntry;",1,3,6,new JHandler[]{},M2426));
c.Add(new JMethod(2427,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventPlayerPoisoned;)Lforge/game/GameLogEntry;",1,3,6,new JHandler[]{},M2427));
c.Add(new JMethod(2428,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventPlayerRadiation;)Lforge/game/GameLogEntry;",1,5,7,new JHandler[]{},M2428));
c.Add(new JMethod(2429,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventAttackersDeclared;)Lforge/game/GameLogEntry;",1,6,7,new JHandler[]{},M2429));
c.Add(new JMethod(2430,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventBlockersDeclared;)Lforge/game/GameLogEntry;",1,12,7,new JHandler[]{},M2430));
c.Add(new JMethod(2431,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventMulligan;)Lforge/game/GameLogEntry;",1,3,4,new JHandler[]{},M2431));
c.Add(new JMethod(2432,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventCardForetold;)Lforge/game/GameLogEntry;",1,2,4,new JHandler[]{},M2432));
c.Add(new JMethod(2433,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventCardPlotted;)Lforge/game/GameLogEntry;",1,2,5,new JHandler[]{},M2433));
c.Add(new JMethod(2434,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventDoorChanged;)Lforge/game/GameLogEntry;",1,2,4,new JHandler[]{},M2434));
c.Add(new JMethod(2435,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventCardChangeZone;)Lforge/game/GameLogEntry;",1,6,6,new JHandler[]{},M2435));
c.Add(new JMethod(2436,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventAddLog;)Lforge/game/GameLogEntry;",1,2,5,new JHandler[]{},M2436));
c.Add(new JMethod(2437,"forge/game/GameLogFormatter","recieve","(Lforge/game/event/GameEvent;)V",1,3,2,new JHandler[]{},M2437));
c.Add(new JMethod(2438,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventAddLog;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2438));
c.Add(new JMethod(2439,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventDoorChanged;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2439));
c.Add(new JMethod(2440,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventCardPlotted;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2440));
c.Add(new JMethod(2441,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventCardForetold;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2441));
c.Add(new JMethod(2442,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventPlayerDamaged;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2442));
c.Add(new JMethod(2443,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventTurnPhase;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2443));
c.Add(new JMethod(2444,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventTurnBegan;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2444));
c.Add(new JMethod(2445,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventSurveil;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2445));
c.Add(new JMethod(2446,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventSpellAbilityCast;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2446));
c.Add(new JMethod(2447,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventSpellResolved;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2447));
c.Add(new JMethod(2448,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventScry;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2448));
c.Add(new JMethod(2449,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventRandomLog;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2449));
c.Add(new JMethod(2450,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventPlayerRadiation;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2450));
c.Add(new JMethod(2451,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventPlayerPoisoned;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2451));
c.Add(new JMethod(2452,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventPlayerControl;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2452));
c.Add(new JMethod(2453,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventMulligan;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2453));
c.Add(new JMethod(2454,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventPlayerLivesChanged;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2454));
c.Add(new JMethod(2455,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventLandPlayed;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2455));
c.Add(new JMethod(2456,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventGameOutcome;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2456));
c.Add(new JMethod(2457,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventCardModeChosen;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2457));
c.Add(new JMethod(2458,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventCardChangeZone;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2458));
c.Add(new JMethod(2459,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventCardDamaged;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2459));
c.Add(new JMethod(2460,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventBlockersDeclared;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2460));
c.Add(new JMethod(2461,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventAttackersDeclared;)Ljava/lang/Object;",4161,2,2,new JHandler[]{},M2461));
}

internal static JStep M2411(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/event/IGameEventVisitor$Base","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameLogFormatter","log","Lforge/game/GameLog;",value);f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2412(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.L(1000L));f.Pc=4;continue;}
case 4:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=5;continue;}
case 5:{f.Locals[3]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{f.Push(JValue.L(3600L));f.Pc=10;continue;}
case 10:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=11;continue;}
case 11:{f.Locals[5]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{f.Push(JValue.L(3600L));f.Pc=17;continue;}
case 17:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lrem",a,b));f.Pc=18;continue;}
case 18:{f.Push(JValue.L(60L));f.Pc=21;continue;}
case 21:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ldiv",a,b));f.Pc=22;continue;}
case 22:{f.Locals[7]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Push(JValue.L(60L));f.Pc=28;continue;}
case 28:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lrem",a,b));f.Pc=29;continue;}
case 29:{f.Locals[9]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{f.Push(JValue.L(0));f.Pc=34;continue;}
case 34:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=35;continue;}
case 35:{f.Pc=f.Pop().Int<=0?74:38;continue;}
case 38:{f.Push(JValue.R(rt.String("%dh : %02dm : %02ds")));f.Pc=40;continue;}
case 40:{f.Push(JValue.I(3));f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=44;continue;}
case 44:{f.StackOp("dup");f.Pc=45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",51);}
case 51:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=52;continue;}
case 52:{f.StackOp("dup");f.Pc=53;continue;}
case 53:{f.Push(JValue.I(1));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[7]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",59);}
case 59:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=60;continue;}
case 60:{f.StackOp("dup");f.Pc=61;continue;}
case 61:{f.Push(JValue.I(2));f.Pc=62;continue;}
case 62:{f.Push(f.Locals[9]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",67);}
case 67:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",71);}
case 71:{f.Pc=99;continue;}
case 74:{f.Push(JValue.R(rt.String("%dm : %02ds")));f.Pc=76;continue;}
case 76:{f.Push(JValue.I(2));f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=80;continue;}
case 80:{f.StackOp("dup");f.Pc=81;continue;}
case 81:{f.Push(JValue.I(0));f.Pc=82;continue;}
case 82:{f.Push(f.Locals[7]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",87);}
case 87:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=88;continue;}
case 88:{f.StackOp("dup");f.Pc=89;continue;}
case 89:{f.Push(JValue.I(1));f.Pc=90;continue;}
case 90:{f.Push(f.Locals[9]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/Long","valueOf","(J)Ljava/lang/Long;","invokestatic",95);}
case 95:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",99);}
case 99:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2413(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","log","Lforge/game/GameLog;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameLog","getMatchStartMillis","()J","invokevirtual",7);}
case 7:{f.Push(JValue.L(0));f.Pc=8;continue;}
case 8:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Int<0?57:12;continue;}
case 12:{return rt.Call(f,"java/lang/System","currentTimeMillis","()J","invokestatic",15);}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","log","Lforge/game/GameLog;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/GameLog","getMatchStartMillis","()J","invokevirtual",22);}
case 22:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=23;continue;}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","log","Lforge/game/GameLog;"));f.Pc=28;continue;}
case 28:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","GAME_OUTCOME","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","GAME_OUTCOME","Lforge/game/GameLogEntryType;"));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("lblMatchDuration")));f.Pc=37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/GameLogFormatter","formatDuration","(J)Ljava/lang/String;","invokevirtual",49);}
case 49:{return rt.DynamicCall(f,"forge/game/GameLogFormatter:2413:49:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",54);}
case 54:{return rt.Call(f,"forge/game/GameLog","add","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokevirtual",57);}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/event/GameEventGameOutcome","lastTurnNumber","()I","invokevirtual",61);}
case 61:{f.Push(JNumbers.Unary("i2f",f.Pop()));f.Pc=62;continue;}
case 62:{f.Push(JNumbers.Unary("f2d",f.Pop()));f.Pc=63;continue;}
case 63:{f.Push(JValue.D(2.0d));f.Pc=66;continue;}
case 66:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ddiv",a,b));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/Math","ceil","(D)D","invokestatic",70);}
case 70:{f.Push(JNumbers.Unary("d2i",f.Pop()));f.Pc=71;continue;}
case 71:{f.Locals[2]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","log","Lforge/game/GameLog;"));f.Pc=76;continue;}
case 76:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","GAME_OUTCOME","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","GAME_OUTCOME","Lforge/game/GameLogEntryType;"));f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.String("lblTurn")));f.Pc=85;continue;}
case 85:{f.Push(JValue.I(0));f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",92);}
case 92:{f.Push(f.Locals[2]);f.Pc=93;continue;}
case 93:{return rt.DynamicCall(f,"forge/game/GameLogFormatter:2413:93:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;I)Ljava/lang/String;",98);}
case 98:{return rt.Call(f,"forge/game/GameLog","add","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokevirtual",101);}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/event/GameEventGameOutcome","outcomeStrings","()Ljava/util/List;","invokevirtual",105);}
case 105:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",110);}
case 110:{f.Locals[3]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[3]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",117);}
case 117:{f.Pc=f.Pop().Int==0?146:120;continue;}
case 120:{f.Push(f.Locals[3]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",126);}
case 126:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=129;continue;}
case 129:{f.Locals[4]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","log","Lforge/game/GameLog;"));f.Pc=135;continue;}
case 135:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","GAME_OUTCOME","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","GAME_OUTCOME","Lforge/game/GameLogEntryType;"));f.Pc=138;continue;}
case 138:{f.Push(f.Locals[4]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/GameLog","add","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokevirtual",143);}
case 143:{f.Pc=111;continue;}
case 146:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=149;continue;}
case 149:{f.StackOp("dup");f.Pc=150;continue;}
case 150:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","MATCH_RESULTS","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","MATCH_RESULTS","Lforge/game/GameLogEntryType;"));f.Pc=153;continue;}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/event/GameEventGameOutcome","matchSummary","()Ljava/lang/String;","invokevirtual",157);}
case 157:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",160);}
case 160:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2414(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/event/GameEventScry","toTop","()I","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int<=0?67:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/event/GameEventScry","toBottom","()I","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int<=0?67:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("lblLogScryTopBottomLibrary")));f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Push(JValue.R(rt.String("%s")));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/event/GameEventScry","player","()Lforge/game/player/PlayerView;","invokevirtual",33);}
case 33:{return rt.Call(f,"forge/game/player/PlayerView","toString","()Ljava/lang/String;","invokevirtual",36);}
case 36:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",39);}
case 39:{f.Push(JValue.R(rt.String("%top")));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/event/GameEventScry","toTop","()I","invokevirtual",45);}
case 45:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",48);}
case 48:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",51);}
case 51:{f.Push(JValue.R(rt.String("%bottom")));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/event/GameEventScry","toBottom","()I","invokevirtual",57);}
case 57:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",60);}
case 60:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",63);}
case 63:{f.Locals[2]=f.Pop();f.Pc=64;continue;}
case 64:{f.Pc=153;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/event/GameEventScry","toBottom","()I","invokevirtual",71);}
case 71:{f.Pc=f.Pop().Int!=0?115:74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("lblLogScryTopLibrary")));f.Pc=80;continue;}
case 80:{f.Push(JValue.I(0));f.Pc=81;continue;}
case 81:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",87);}
case 87:{f.Push(JValue.R(rt.String("%s")));f.Pc=89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/event/GameEventScry","player","()Lforge/game/player/PlayerView;","invokevirtual",93);}
case 93:{return rt.Call(f,"forge/game/player/PlayerView","toString","()Ljava/lang/String;","invokevirtual",96);}
case 96:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",99);}
case 99:{f.Push(JValue.R(rt.String("%top")));f.Pc=101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/event/GameEventScry","toTop","()I","invokevirtual",105);}
case 105:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",108);}
case 108:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",111);}
case 111:{f.Locals[2]=f.Pop();f.Pc=112;continue;}
case 112:{f.Pc=153;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("lblLogScryBottomLibrary")));f.Pc=121;continue;}
case 121:{f.Push(JValue.I(0));f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",128);}
case 128:{f.Push(JValue.R(rt.String("%s")));f.Pc=130;continue;}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/event/GameEventScry","player","()Lforge/game/player/PlayerView;","invokevirtual",134);}
case 134:{return rt.Call(f,"forge/game/player/PlayerView","toString","()Ljava/lang/String;","invokevirtual",137);}
case 137:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",140);}
case 140:{f.Push(JValue.R(rt.String("%bottom")));f.Pc=142;continue;}
case 142:{f.Push(f.Locals[1]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/event/GameEventScry","toBottom","()I","invokevirtual",146);}
case 146:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",149);}
case 149:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",152);}
case 152:{f.Locals[2]=f.Pop();f.Pc=153;continue;}
case 153:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=156;continue;}
case 156:{f.StackOp("dup");f.Pc=157;continue;}
case 157:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=160;continue;}
case 160:{f.Push(f.Locals[2]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",164);}
case 164:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2415(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/event/GameEventSurveil","toLibrary","()I","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int<=0?58:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/event/GameEventSurveil","toGraveyard","()I","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int<=0?58:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("lblLogSurveiledToLibraryGraveyard")));f.Pc=20;continue;}
case 20:{f.Push(JValue.I(3));f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/event/GameEventSurveil","player","()Lforge/game/player/PlayerView;","invokevirtual",30);}
case 30:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/event/GameEventSurveil","toLibrary","()I","invokevirtual",37);}
case 37:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",40);}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(2));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/event/GameEventSurveil","toGraveyard","()I","invokevirtual",47);}
case 47:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",50);}
case 50:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",54);}
case 54:{f.Locals[2]=f.Pop();f.Pc=55;continue;}
case 55:{f.Pc=130;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/event/GameEventSurveil","toGraveyard","()I","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int!=0?99:65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("lblLogSurveiledToLibrary")));f.Pc=71;continue;}
case 71:{f.Push(JValue.I(2));f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=75;continue;}
case 75:{f.StackOp("dup");f.Pc=76;continue;}
case 76:{f.Push(JValue.I(0));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/event/GameEventSurveil","player","()Lforge/game/player/PlayerView;","invokevirtual",81);}
case 81:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=82;continue;}
case 82:{f.StackOp("dup");f.Pc=83;continue;}
case 83:{f.Push(JValue.I(1));f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/event/GameEventSurveil","toLibrary","()I","invokevirtual",88);}
case 88:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",91);}
case 91:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",95);}
case 95:{f.Locals[2]=f.Pop();f.Pc=96;continue;}
case 96:{f.Pc=130;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("lblLogSurveiledToGraveyard")));f.Pc=105;continue;}
case 105:{f.Push(JValue.I(2));f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=109;continue;}
case 109:{f.StackOp("dup");f.Pc=110;continue;}
case 110:{f.Push(JValue.I(0));f.Pc=111;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/event/GameEventSurveil","player","()Lforge/game/player/PlayerView;","invokevirtual",115);}
case 115:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=116;continue;}
case 116:{f.StackOp("dup");f.Pc=117;continue;}
case 117:{f.Push(JValue.I(1));f.Pc=118;continue;}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/event/GameEventSurveil","toGraveyard","()I","invokevirtual",122);}
case 122:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",125);}
case 125:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",129);}
case 129:{f.Locals[2]=f.Pop();f.Pc=130;continue;}
case 130:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=133;continue;}
case 133:{f.StackOp("dup");f.Pc=134;continue;}
case 134:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=137;continue;}
case 137:{f.Push(f.Locals[2]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",141);}
case 141:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2416(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/event/GameEventSpellResolved","hasFizzled","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?36:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("lblLogCardAbilityFizzles")));f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/event/GameEventSpellResolved","spell","()Lforge/game/spellability/SpellAbilityView;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","getHostCard","()Lforge/game/card/CardView;","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/game/card/CardView","getName","()Ljava/lang/String;","invokevirtual",29);}
case 29:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",33);}
case 33:{f.Pc=40;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/event/GameEventSpellResolved","stackDescription","()Ljava/lang/String;","invokevirtual",40);}
case 40:{f.Locals[2]=f.Pop();f.Pc=41;continue;}
case 41:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=44;continue;}
case 44:{f.StackOp("dup");f.Pc=45;continue;}
case 45:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/event/GameEventSpellResolved","spell","()Lforge/game/spellability/SpellAbilityView;","invokevirtual",53);}
case 53:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","getHostCard","()Lforge/game/card/CardView;","invokevirtual",56);}
case 56:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;Lforge/game/card/CardView;)V","invokespecial",59);}
case 59:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2417(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/event/GameEventSpellAbilityCast","si","()Lforge/game/spellability/StackItemView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/spellability/StackItemView","getActivatingPlayer","()Lforge/game/player/PlayerView;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/player/PlayerView","getName","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/event/GameEventSpellAbilityCast","sa","()Lforge/game/spellability/SpellAbilityView;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","isSpell","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?37:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("lblCast")));f.Pc=27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Pc=76;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/event/GameEventSpellAbilityCast","si","()Lforge/game/spellability/StackItemView;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/game/spellability/StackItemView","isTrigger","()Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int==0?63:47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("lblTriggered")));f.Pc=53;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",60);}
case 60:{f.Pc=76;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("lblActivated")));f.Pc=69;continue;}
case 69:{f.Push(JValue.I(0));f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",76);}
case 76:{f.Locals[3]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/event/GameEventSpellAbilityCast","si","()Lforge/game/spellability/StackItemView;","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Reference==null?94:84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/event/GameEventSpellAbilityCast","si","()Lforge/game/spellability/StackItemView;","invokevirtual",88);}
case 88:{return rt.Call(f,"forge/game/spellability/StackItemView","getText","()Ljava/lang/String;","invokevirtual",91);}
case 91:{f.Pc=96;continue;}
case 94:{f.Push(JValue.R(rt.String("")));f.Pc=96;continue;}
case 96:{f.Locals[4]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[4]);f.Pc=100;continue;}
case 100:{f.Pc=f.Pop().Reference==null?130:103;continue;}
case 103:{f.Push(f.Locals[4]);f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.String("Morph ")));f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",110);}
case 110:{f.Pc=f.Pop().Int==0?130:113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=117;continue;}
case 117:{f.Push(JValue.R(rt.String("lblMorph")));f.Pc=120;continue;}
case 120:{f.Push(JValue.I(0));f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",127);}
case 127:{f.Pc=140;continue;}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/event/GameEventSpellAbilityCast","sa","()Lforge/game/spellability/SpellAbilityView;","invokevirtual",134);}
case 134:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","getHostCard","()Lforge/game/card/CardView;","invokevirtual",137);}
case 137:{return rt.Call(f,"forge/game/card/CardView","getName","()Ljava/lang/String;","invokevirtual",140);}
case 140:{f.Locals[5]=f.Pop();f.Pc=142;continue;}
case 142:{f.Push(f.Locals[1]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/event/GameEventSpellAbilityCast","targetDescription","()Ljava/lang/String;","invokevirtual",146);}
case 146:{f.Pc=f.Pop().Reference==null?188:149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=153;continue;}
case 153:{f.Push(JValue.R(rt.String("lblLogPlayerActionObjectWitchTarget")));f.Pc=156;continue;}
case 156:{f.Push(JValue.I(4));f.Pc=157;continue;}
case 157:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=160;continue;}
case 160:{f.StackOp("dup");f.Pc=161;continue;}
case 161:{f.Push(JValue.I(0));f.Pc=162;continue;}
case 162:{f.Push(f.Locals[2]);f.Pc=163;continue;}
case 163:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=164;continue;}
case 164:{f.StackOp("dup");f.Pc=165;continue;}
case 165:{f.Push(JValue.I(1));f.Pc=166;continue;}
case 166:{f.Push(f.Locals[3]);f.Pc=167;continue;}
case 167:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=168;continue;}
case 168:{f.StackOp("dup");f.Pc=169;continue;}
case 169:{f.Push(JValue.I(2));f.Pc=170;continue;}
case 170:{f.Push(f.Locals[5]);f.Pc=172;continue;}
case 172:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=173;continue;}
case 173:{f.StackOp("dup");f.Pc=174;continue;}
case 174:{f.Push(JValue.I(3));f.Pc=175;continue;}
case 175:{f.Push(f.Locals[1]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/event/GameEventSpellAbilityCast","targetDescription","()Ljava/lang/String;","invokevirtual",179);}
case 179:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",183);}
case 183:{f.Locals[6]=f.Pop();f.Pc=185;continue;}
case 185:{f.Pc=217;continue;}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=192;continue;}
case 192:{f.Push(JValue.R(rt.String("lblLogPlayerActionObject")));f.Pc=195;continue;}
case 195:{f.Push(JValue.I(3));f.Pc=196;continue;}
case 196:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=199;continue;}
case 199:{f.StackOp("dup");f.Pc=200;continue;}
case 200:{f.Push(JValue.I(0));f.Pc=201;continue;}
case 201:{f.Push(f.Locals[2]);f.Pc=202;continue;}
case 202:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=203;continue;}
case 203:{f.StackOp("dup");f.Pc=204;continue;}
case 204:{f.Push(JValue.I(1));f.Pc=205;continue;}
case 205:{f.Push(f.Locals[3]);f.Pc=206;continue;}
case 206:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=207;continue;}
case 207:{f.StackOp("dup");f.Pc=208;continue;}
case 208:{f.Push(JValue.I(2));f.Pc=209;continue;}
case 209:{f.Push(f.Locals[5]);f.Pc=211;continue;}
case 211:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",215);}
case 215:{f.Locals[6]=f.Pop();f.Pc=217;continue;}
case 217:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=220;continue;}
case 220:{f.StackOp("dup");f.Pc=221;continue;}
case 221:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_ADD","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_ADD","Lforge/game/GameLogEntryType;"));f.Pc=224;continue;}
case 224:{f.Push(f.Locals[6]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[1]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/event/GameEventSpellAbilityCast","sa","()Lforge/game/spellability/SpellAbilityView;","invokevirtual",230);}
case 230:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","getHostCard","()Lforge/game/card/CardView;","invokevirtual",233);}
case 233:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;Lforge/game/card/CardView;)V","invokespecial",236);}
case 236:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2418(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/event/GameEventCardModeChosen","log","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/event/GameEventCardModeChosen","random","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?48:16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("lblLogRandomMode")));f.Pc=23;continue;}
case 23:{f.Push(JValue.I(2));f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=27;continue;}
case 27:{f.StackOp("dup");f.Pc=28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/event/GameEventCardModeChosen","cardName","()Ljava/lang/String;","invokevirtual",33);}
case 33:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{f.Push(JValue.I(1));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/event/GameEventCardModeChosen","mode","()Ljava/lang/String;","invokevirtual",40);}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Locals[2]=f.Pop();f.Pc=45;continue;}
case 45:{f.Pc=87;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("lblLogPlayerChosenModeForCard")));f.Pc=55;continue;}
case 55:{f.Push(JValue.I(3));f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=59;continue;}
case 59:{f.StackOp("dup");f.Pc=60;continue;}
case 60:{f.Push(JValue.I(0));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/event/GameEventCardModeChosen","player","()Lforge/game/player/PlayerView;","invokevirtual",65);}
case 65:{return rt.Call(f,"forge/game/player/PlayerView","toString","()Ljava/lang/String;","invokevirtual",68);}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(1));f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/event/GameEventCardModeChosen","mode","()Ljava/lang/String;","invokevirtual",75);}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(2));f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/event/GameEventCardModeChosen","cardName","()Ljava/lang/String;","invokevirtual",82);}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",86);}
case 86:{f.Locals[2]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/event/GameEventCardModeChosen","cardName","()Ljava/lang/String;","invokevirtual",91);}
case 91:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",94);}
case 94:{f.Locals[3]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[2]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=99;continue;}
case 99:{f.Push(f.Locals[3]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",103);}
case 103:{f.Locals[2]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[2]);f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.String("NICKNAME")));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",111);}
case 111:{f.Push(f.Locals[3]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/util/Lang","getNickName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",115);}
case 115:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",118);}
case 118:{f.Locals[2]=f.Pop();f.Pc=119;continue;}
case 119:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=122;continue;}
case 122:{f.StackOp("dup");f.Pc=123;continue;}
case 123:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",130);}
case 130:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2419(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/event/GameEventRandomLog","message","()Ljava/lang/String;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2420(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/event/GameEventPlayerControl","newLobbyPlayerName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/event/GameEventPlayerControl","player","()Lforge/game/player/PlayerView;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference!=null?40:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("lblLogPlayerHasRestoredControlThemself")));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/player/PlayerView","getName","()Ljava/lang/String;","invokevirtual",31);}
case 31:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",35);}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{f.Pc=80;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/player/PlayerView","getName","()Ljava/lang/String;","invokevirtual",45);}
case 45:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?53:51;continue;}
case 51:{f.Push(JValue.R(null));f.Pc=52;continue;}
case 52:{return JStep.Return(f.Pop());}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String("lblLogPlayerControlledTargetPlayer")));f.Pc=60;continue;}
case 60:{f.Push(JValue.I(2));f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=64;continue;}
case 64:{f.StackOp("dup");f.Pc=65;continue;}
case 65:{f.Push(JValue.I(0));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/player/PlayerView","getName","()Ljava/lang/String;","invokevirtual",70);}
case 70:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=71;continue;}
case 71:{f.StackOp("dup");f.Pc=72;continue;}
case 72:{f.Push(JValue.I(1));f.Pc=73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",78);}
case 78:{f.Locals[4]=f.Pop();f.Pc=80;continue;}
case 80:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","PLAYER_CONTROL","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","PLAYER_CONTROL","Lforge/game/GameLogEntryType;"));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",92);}
case 92:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2421(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/event/GameEventTurnPhase","playerTurn","()Lforge/game/player/PlayerView;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","PHASE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","PHASE","Lforge/game/GameLogEntryType;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/event/GameEventTurnPhase","phaseDesc","()Ljava/lang/String;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",19);}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/player/PlayerView","getName","()Ljava/lang/String;","invokevirtual",23);}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/event/GameEventTurnPhase","phase","()Lforge/game/phase/PhaseType;","invokevirtual",27);}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseType","nameForUi","Ljava/lang/String;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/util/Lang","getPossessedObject","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",33);}
case 33:{return rt.DynamicCall(f,"forge/game/GameLogFormatter:2421:33:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",38);}
case 38:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",41);}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2422(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("")));f.Pc=2;continue;}
case 2:{f.Locals[2]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/event/GameEventCardDamaged","type","()Lforge/game/event/GameEventCardDamaged$DamageType;","invokevirtual",7);}
case 7:{if(!rt.StaticReady(f,"forge/game/event/GameEventCardDamaged$DamageType","Deathtouch","Lforge/game/event/GameEventCardDamaged$DamageType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/event/GameEventCardDamaged$DamageType","Deathtouch","Lforge/game/event/GameEventCardDamaged$DamageType;"));f.Pc=10;continue;}
case 10:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?28:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("lblDeathtouch")));f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Locals[2]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/event/GameEventCardDamaged","type","()Lforge/game/event/GameEventCardDamaged$DamageType;","invokevirtual",32);}
case 32:{if(!rt.StaticReady(f,"forge/game/event/GameEventCardDamaged$DamageType","M1M1Counters","Lforge/game/event/GameEventCardDamaged$DamageType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/event/GameEventCardDamaged$DamageType","M1M1Counters","Lforge/game/event/GameEventCardDamaged$DamageType;"));f.Pc=35;continue;}
case 35:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?53:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("lblAsM1M1Counters")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",52);}
case 52:{f.Locals[2]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/event/GameEventCardDamaged","type","()Lforge/game/event/GameEventCardDamaged$DamageType;","invokevirtual",57);}
case 57:{if(!rt.StaticReady(f,"forge/game/event/GameEventCardDamaged$DamageType","LoyaltyLoss","Lforge/game/event/GameEventCardDamaged$DamageType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/event/GameEventCardDamaged$DamageType","LoyaltyLoss","Lforge/game/event/GameEventCardDamaged$DamageType;"));f.Pc=60;continue;}
case 60:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?88:63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("lblRemovingNLoyaltyCounter")));f.Pc=70;continue;}
case 70:{f.Push(JValue.I(1));f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=74;continue;}
case 74:{f.StackOp("dup");f.Pc=75;continue;}
case 75:{f.Push(JValue.I(0));f.Pc=76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/event/GameEventCardDamaged","amount","()I","invokevirtual",80);}
case 80:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",83);}
case 83:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",87);}
case 87:{f.Locals[2]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=92;continue;}
case 92:{f.Push(JValue.R(rt.String("lblSourceDealsNDamageToDest")));f.Pc=95;continue;}
case 95:{f.Push(JValue.I(4));f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=99;continue;}
case 99:{f.StackOp("dup");f.Pc=100;continue;}
case 100:{f.Push(JValue.I(0));f.Pc=101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/event/GameEventCardDamaged","source","()Lforge/game/card/CardView;","invokevirtual",105);}
case 105:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=106;continue;}
case 106:{f.StackOp("dup");f.Pc=107;continue;}
case 107:{f.Push(JValue.I(1));f.Pc=108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/event/GameEventCardDamaged","amount","()I","invokevirtual",112);}
case 112:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",115);}
case 115:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=116;continue;}
case 116:{f.StackOp("dup");f.Pc=117;continue;}
case 117:{f.Push(JValue.I(2));f.Pc=118;continue;}
case 118:{f.Push(f.Locals[2]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",122);}
case 122:{f.Pc=f.Pop().Int==0?130:125;continue;}
case 125:{f.Push(JValue.R(rt.String("")));f.Pc=127;continue;}
case 127:{f.Pc=136;continue;}
case 130:{f.Push(f.Locals[2]);f.Pc=131;continue;}
case 131:{return rt.DynamicCall(f,"forge/game/GameLogFormatter:2422:131:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",136);}
case 136:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=137;continue;}
case 137:{f.StackOp("dup");f.Pc=138;continue;}
case 138:{f.Push(JValue.I(3));f.Pc=139;continue;}
case 139:{f.Push(f.Locals[1]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/event/GameEventCardDamaged","card","()Lforge/game/card/CardView;","invokevirtual",143);}
case 143:{return rt.Call(f,"forge/game/card/CardView","toString","()Ljava/lang/String;","invokevirtual",146);}
case 146:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",150);}
case 150:{f.Locals[3]=f.Pop();f.Pc=151;continue;}
case 151:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=154;continue;}
case 154:{f.StackOp("dup");f.Pc=155;continue;}
case 155:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","DAMAGE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","DAMAGE","Lforge/game/GameLogEntryType;"));f.Pc=158;continue;}
case 158:{f.Push(f.Locals[3]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/event/GameEventCardDamaged","source","()Lforge/game/card/CardView;","invokevirtual",163);}
case 163:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;Lforge/game/card/CardView;)V","invokespecial",166);}
case 166:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2423(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("lblLogPlayerPlayedLand")));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(2));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/event/GameEventLandPlayed","player","()Lforge/game/player/PlayerView;","invokevirtual",17);}
case 17:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/event/GameEventLandPlayed","land","()Lforge/game/card/CardView;","invokevirtual",24);}
case 24:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",28);}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","LAND","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","LAND","Lforge/game/GameLogEntryType;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/event/GameEventLandPlayed","land","()Lforge/game/card/CardView;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;Lforge/game/card/CardView;)V","invokespecial",44);}
case 44:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2424(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","log","Lforge/game/GameLog;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/GameLog","markMatchStartIfNeeded","()V","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("lblLogTurnNOwnerByPlayer")));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(2));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/event/GameEventTurnBegan","turnNumber","()I","invokevirtual",24);}
case 24:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",27);}
case 27:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/event/GameEventTurnBegan","turnOwner","()Lforge/game/player/PlayerView;","invokevirtual",34);}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",38);}
case 38:{f.Locals[2]=f.Pop();f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","TURN","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","TURN","Lforge/game/GameLogEntryType;"));f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",50);}
case 50:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2425(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/event/GameEventPlayerDamaged","infect","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?24:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("lblLogAsPoisonCounters")));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Pc=26;continue;}
case 24:{f.Push(JValue.R(rt.String("")));f.Pc=26;continue;}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/event/GameEventPlayerDamaged","combat","()Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?51:34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("lblCombat")));f.Pc=41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",48);}
case 48:{f.Pc=65;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("lblNonCombat")));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(0));f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",65);}
case 65:{f.Locals[3]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("lblLogSourceDealsNDamageOfTypeToDest")));f.Pc=73;continue;}
case 73:{f.Push(JValue.I(5));f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=77;continue;}
case 77:{f.StackOp("dup");f.Pc=78;continue;}
case 78:{f.Push(JValue.I(0));f.Pc=79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/event/GameEventPlayerDamaged","source","()Lforge/game/card/CardView;","invokevirtual",83);}
case 83:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=84;continue;}
case 84:{f.StackOp("dup");f.Pc=85;continue;}
case 85:{f.Push(JValue.I(1));f.Pc=86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/event/GameEventPlayerDamaged","amount","()I","invokevirtual",90);}
case 90:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",93);}
case 93:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=94;continue;}
case 94:{f.StackOp("dup");f.Pc=95;continue;}
case 95:{f.Push(JValue.I(2));f.Pc=96;continue;}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=98;continue;}
case 98:{f.StackOp("dup");f.Pc=99;continue;}
case 99:{f.Push(JValue.I(3));f.Pc=100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/event/GameEventPlayerDamaged","target","()Lforge/game/player/PlayerView;","invokevirtual",104);}
case 104:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=105;continue;}
case 105:{f.StackOp("dup");f.Pc=106;continue;}
case 106:{f.Push(JValue.I(4));f.Pc=107;continue;}
case 107:{f.Push(f.Locals[2]);f.Pc=108;continue;}
case 108:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",112);}
case 112:{f.Locals[4]=f.Pop();f.Pc=114;continue;}
case 114:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=117;continue;}
case 117:{f.StackOp("dup");f.Pc=118;continue;}
case 118:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","DAMAGE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","DAMAGE","Lforge/game/GameLogEntryType;"));f.Pc=121;continue;}
case 121:{f.Push(f.Locals[4]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/event/GameEventPlayerDamaged","source","()Lforge/game/card/CardView;","invokevirtual",127);}
case 127:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;Lforge/game/card/CardView;)V","invokespecial",130);}
case 130:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2426(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("lblLogPlayerLifeChange")));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(3));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/event/GameEventPlayerLivesChanged","player","()Lforge/game/player/PlayerView;","invokevirtual",17);}
case 17:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/event/GameEventPlayerLivesChanged","oldLives","()I","invokevirtual",24);}
case 24:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",27);}
case 27:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{f.Push(JValue.I(2));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/event/GameEventPlayerLivesChanged","newLives","()I","invokevirtual",34);}
case 34:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",37);}
case 37:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",41);}
case 41:{f.Locals[2]=f.Pop();f.Pc=42;continue;}
case 42:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=45;continue;}
case 45:{f.StackOp("dup");f.Pc=46;continue;}
case 46:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","LIFE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","LIFE","Lforge/game/GameLogEntryType;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",53);}
case 53:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2427(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("lblLogPlayerReceivesNPosionCounterFrom")));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(3));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/event/GameEventPlayerPoisoned","receiver","()Lforge/game/player/PlayerView;","invokevirtual",17);}
case 17:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/event/GameEventPlayerPoisoned","amount","()I","invokevirtual",24);}
case 24:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",27);}
case 27:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{f.Push(JValue.I(2));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/event/GameEventPlayerPoisoned","source","()Lforge/game/player/PlayerView;","invokevirtual",34);}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",38);}
case 38:{f.Locals[2]=f.Pop();f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","DAMAGE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","DAMAGE","Lforge/game/GameLogEntryType;"));f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",50);}
case 50:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2428(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/event/GameEventPlayerRadiation","change","()I","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","RAD","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","RAD","Lforge/game/card/CounterEnumType;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CounterEnumType","getName","()Ljava/lang/String;","invokevirtual",11);}
case 11:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",17);}
case 17:{f.Push(JValue.R(rt.String("lblCounter")));f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",27);}
case 27:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",30);}
case 30:{return rt.DynamicCall(f,"forge/game/GameLogFormatter:2428:30:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",35);}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Pc=f.Pop().Int<0?91:41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("lblLogPlayerRadiation")));f.Pc=48;continue;}
case 48:{f.Push(JValue.I(3));f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=52;continue;}
case 52:{f.StackOp("dup");f.Pc=53;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/event/GameEventPlayerRadiation","receiver","()Lforge/game/player/PlayerView;","invokevirtual",58);}
case 58:{return rt.Call(f,"forge/game/player/PlayerView","toString","()Ljava/lang/String;","invokevirtual",61);}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(1));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",68);}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",73);}
case 73:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=74;continue;}
case 74:{f.StackOp("dup");f.Pc=75;continue;}
case 75:{f.Push(JValue.I(2));f.Pc=76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/event/GameEventPlayerRadiation","source","()Lforge/game/player/PlayerView;","invokevirtual",80);}
case 80:{return rt.Call(f,"forge/game/player/PlayerView","toString","()Ljava/lang/String;","invokevirtual",83);}
case 83:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",87);}
case 87:{f.Locals[2]=f.Pop();f.Pc=88;continue;}
case 88:{f.Pc=131;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("lblLogPlayerRadRemove")));f.Pc=98;continue;}
case 98:{f.Push(JValue.I(2));f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=102;continue;}
case 102:{f.StackOp("dup");f.Pc=103;continue;}
case 103:{f.Push(JValue.I(0));f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/event/GameEventPlayerRadiation","receiver","()Lforge/game/player/PlayerView;","invokevirtual",108);}
case 108:{return rt.Call(f,"forge/game/player/PlayerView","toString","()Ljava/lang/String;","invokevirtual",111);}
case 111:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=112;continue;}
case 112:{f.StackOp("dup");f.Pc=113;continue;}
case 113:{f.Push(JValue.I(1));f.Pc=114;continue;}
case 114:{f.Push(f.Locals[3]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/Math","abs","(I)I","invokestatic",118);}
case 118:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",121);}
case 121:{f.Push(f.Locals[4]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",126);}
case 126:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",130);}
case 130:{f.Locals[2]=f.Pop();f.Pc=131;continue;}
case 131:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=134;continue;}
case 134:{f.StackOp("dup");f.Pc=135;continue;}
case 135:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","DAMAGE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","DAMAGE","Lforge/game/GameLogEntryType;"));f.Pc=138;continue;}
case 138:{f.Push(f.Locals[2]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",142);}
case 142:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2429(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/event/GameEventAttackersDeclared","attackersMap","()Lcom/google/common/collect/Multimap;","invokevirtual",12);}
case 12:{return rt.Call(f,"com/google/common/collect/Multimap","keySet","()Ljava/util/Set;","invokeinterface",17);}
case 17:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?131:32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntityView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/event/GameEventAttackersDeclared","attackersMap","()Lcom/google/common/collect/Multimap;","invokevirtual",47);}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",54);}
case 54:{f.Locals[5]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{f.Pc=f.Pop().Reference==null?23:61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",68);}
case 68:{f.Pc=f.Pop().Int==0?74:71;continue;}
case 71:{f.Pc=23;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int<=0?89:81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("\n")));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",88);}
case 88:{f.StackOp("pop");f.Pc=89;continue;}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("lblLogPlayerAssignedAttackerToAttackTarget")));f.Pc=97;continue;}
case 97:{f.Push(JValue.I(3));f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=101;continue;}
case 101:{f.StackOp("dup");f.Pc=102;continue;}
case 102:{f.Push(JValue.I(0));f.Pc=103;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/event/GameEventAttackersDeclared","player","()Lforge/game/player/PlayerView;","invokevirtual",107);}
case 107:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=108;continue;}
case 108:{f.StackOp("dup");f.Pc=109;continue;}
case 109:{f.Push(JValue.I(1));f.Pc=110;continue;}
case 110:{f.Push(f.Locals[5]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",115);}
case 115:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=116;continue;}
case 116:{f.StackOp("dup");f.Pc=117;continue;}
case 117:{f.Push(JValue.I(2));f.Pc=118;continue;}
case 118:{f.Push(f.Locals[4]);f.Pc=120;continue;}
case 120:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",124);}
case 124:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",127);}
case 127:{f.StackOp("pop");f.Pc=128;continue;}
case 128:{f.Pc=23;continue;}
case 131:{f.Push(f.Locals[2]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",135);}
case 135:{f.Pc=f.Pop().Int!=0?140:138;continue;}
case 138:{f.Push(JValue.R(null));f.Pc=139;continue;}
case 139:{return JStep.Return(f.Pop());}
case 140:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=143;continue;}
case 143:{f.StackOp("dup");f.Pc=144;continue;}
case 144:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","COMBAT","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","COMBAT","Lforge/game/GameLogEntryType;"));f.Pc=147;continue;}
case 147:{f.Push(f.Locals[2]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",151);}
case 151:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",154);}
case 154:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2430(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/event/GameEventBlockersDeclared","blockers","()Ljava/util/Map;","invokevirtual",12);}
case 12:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",17);}
case 17:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?348:32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntityView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{f.Locals[5]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",62);}
case 62:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=65;continue;}
case 65:{f.Locals[6]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{f.Pc=f.Pop().Reference==null?23:72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"com/google/common/collect/Multimap","isEmpty","()Z","invokeinterface",79);}
case 79:{f.Pc=f.Pop().Int==0?85:82;continue;}
case 82:{f.Pc=23;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int<=0?100:92;continue;}
case 92:{f.Push(f.Locals[2]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("\n")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",99);}
case 99:{f.StackOp("pop");f.Pc=100;continue;}
case 100:{f.Push(f.Locals[5]);f.Pc=102;continue;}
case 102:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/CardView")?1:0));f.Pc=105;continue;}
case 105:{f.Pc=f.Pop().Int==0?158:108;continue;}
case 108:{f.Push(f.Locals[5]);f.Pc=110;continue;}
case 110:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=113;continue;}
case 113:{f.Locals[8]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[8]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/card/CardView","getController","()Lforge/game/player/PlayerView;","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Reference==null?158:123;continue;}
case 123:{f.Push(f.Locals[8]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",128);}
case 128:{return rt.Call(f,"forge/game/card/CardView$CardStateView","isBattle","()Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int==0?145:134;continue;}
case 134:{f.Push(f.Locals[8]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/card/CardView","getProtectingPlayer","()Lforge/game/player/PlayerView;","invokevirtual",139);}
case 139:{return rt.Call(f,"forge/game/player/PlayerView","getName","()Ljava/lang/String;","invokevirtual",142);}
case 142:{f.Pc=153;continue;}
case 145:{f.Push(f.Locals[8]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/card/CardView","getController","()Lforge/game/player/PlayerView;","invokevirtual",150);}
case 150:{return rt.Call(f,"forge/game/player/PlayerView","getName","()Ljava/lang/String;","invokevirtual",153);}
case 153:{f.Locals[7]=f.Pop();f.Pc=155;continue;}
case 155:{f.Pc=165;continue;}
case 158:{f.Push(f.Locals[5]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/GameEntityView","getName","()Ljava/lang/String;","invokevirtual",163);}
case 163:{f.Locals[7]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(JValue.I(1));f.Pc=166;continue;}
case 166:{f.Locals[8]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[6]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"com/google/common/collect/Multimap","asMap","()Ljava/util/Map;","invokeinterface",175);}
case 175:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",180);}
case 180:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",185);}
case 185:{f.Locals[9]=f.Pop();f.Pc=187;continue;}
case 187:{f.Push(f.Locals[9]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",194);}
case 194:{f.Pc=f.Pop().Int==0?345:197;continue;}
case 197:{f.Push(f.Locals[9]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",204);}
case 204:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=207;continue;}
case 207:{f.Locals[10]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[8]);f.Pc=211;continue;}
case 211:{f.Pc=f.Pop().Int!=0?222:214;continue;}
case 214:{f.Push(f.Locals[2]);f.Pc=215;continue;}
case 215:{f.Push(JValue.R(rt.String("\n")));f.Pc=218;continue;}
case 218:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",221);}
case 221:{f.StackOp("pop");f.Pc=222;continue;}
case 222:{f.Push(f.Locals[10]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",229);}
case 229:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=232;continue;}
case 232:{f.Locals[11]=f.Pop();f.Pc=234;continue;}
case 234:{f.Push(f.Locals[11]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",241);}
case 241:{f.Pc=f.Pop().Int!=0?260:244;continue;}
case 244:{f.Push(f.Locals[11]);f.Pc=246;continue;}
case 246:{f.Push(JValue.I(0));f.Pc=247;continue;}
case 247:{return rt.Call(f,"com/google/common/collect/Iterables","get","(Ljava/lang/Iterable;I)Ljava/lang/Object;","invokestatic",250);}
case 250:{f.Push(f.Locals[10]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",257);}
case 257:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?297:260;continue;}
case 260:{f.Push(f.Locals[2]);f.Pc=261;continue;}
case 261:{f.Push(f.Locals[0]);f.Pc=262;continue;}
case 262:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=265;continue;}
case 265:{f.Push(JValue.R(rt.String("lblLogPlayerDidntBlockAttacker")));f.Pc=268;continue;}
case 268:{f.Push(JValue.I(2));f.Pc=269;continue;}
case 269:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=272;continue;}
case 272:{f.StackOp("dup");f.Pc=273;continue;}
case 273:{f.Push(JValue.I(0));f.Pc=274;continue;}
case 274:{f.Push(f.Locals[7]);f.Pc=276;continue;}
case 276:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=277;continue;}
case 277:{f.StackOp("dup");f.Pc=278;continue;}
case 278:{f.Push(JValue.I(1));f.Pc=279;continue;}
case 279:{f.Push(f.Locals[10]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",286);}
case 286:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",290);}
case 290:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",293);}
case 293:{f.StackOp("pop");f.Pc=294;continue;}
case 294:{f.Pc=339;continue;}
case 297:{f.Push(f.Locals[2]);f.Pc=298;continue;}
case 298:{f.Push(f.Locals[0]);f.Pc=299;continue;}
case 299:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=302;continue;}
case 302:{f.Push(JValue.R(rt.String("lblLogPlayerAssignedBlockerToBlockAttacker")));f.Pc=305;continue;}
case 305:{f.Push(JValue.I(3));f.Pc=306;continue;}
case 306:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=309;continue;}
case 309:{f.StackOp("dup");f.Pc=310;continue;}
case 310:{f.Push(JValue.I(0));f.Pc=311;continue;}
case 311:{f.Push(f.Locals[7]);f.Pc=313;continue;}
case 313:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=314;continue;}
case 314:{f.StackOp("dup");f.Pc=315;continue;}
case 315:{f.Push(JValue.I(1));f.Pc=316;continue;}
case 316:{f.Push(f.Locals[11]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",321);}
case 321:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=322;continue;}
case 322:{f.StackOp("dup");f.Pc=323;continue;}
case 323:{f.Push(JValue.I(2));f.Pc=324;continue;}
case 324:{f.Push(f.Locals[10]);f.Pc=326;continue;}
case 326:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",331);}
case 331:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",335);}
case 335:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",338);}
case 338:{f.StackOp("pop");f.Pc=339;continue;}
case 339:{f.Push(JValue.I(0));f.Pc=340;continue;}
case 340:{f.Locals[8]=f.Pop();f.Pc=342;continue;}
case 342:{f.Pc=187;continue;}
case 345:{f.Pc=23;continue;}
case 348:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=351;continue;}
case 351:{f.StackOp("dup");f.Pc=352;continue;}
case 352:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","COMBAT","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","COMBAT","Lforge/game/GameLogEntryType;"));f.Pc=355;continue;}
case 355:{f.Push(f.Locals[2]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",359);}
case 359:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",362);}
case 362:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2431(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("lblPlayerHasMulliganedDownToNCards")));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Push(JValue.R(rt.String("%d")));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/event/GameEventMulligan","player","()Lforge/game/player/PlayerView;","invokevirtual",21);}
case 21:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/player/PlayerView","getZoneSize","(Lforge/game/zone/ZoneType;)I","invokevirtual",27);}
case 27:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",30);}
case 30:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",33);}
case 33:{f.Push(JValue.R(rt.String("%s")));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/event/GameEventMulligan","player","()Lforge/game/player/PlayerView;","invokevirtual",39);}
case 39:{return rt.Call(f,"forge/game/player/PlayerView","toString","()Ljava/lang/String;","invokevirtual",42);}
case 42:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Locals[2]=f.Pop();f.Pc=46;continue;}
case 46:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=49;continue;}
case 49:{f.StackOp("dup");f.Pc=50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","MULLIGAN","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","MULLIGAN","Lforge/game/GameLogEntryType;"));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",57);}
case 57:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2432(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/event/GameEventCardForetold","toString","()Ljava/lang/String;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2433(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/event/GameEventCardPlotted","toString","()Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/event/GameEventCardPlotted","card","()Lforge/game/card/CardView;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;Lforge/game/card/CardView;)V","invokespecial",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2434(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/event/GameEventDoorChanged","toString","()Ljava/lang/String;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2435(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/event/GameEventCardChangeZone","from","()Lforge/game/zone/ZoneView;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?14:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/event/GameEventCardChangeZone","to","()Lforge/game/zone/ZoneView;","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Reference!=null?16:14;continue;}
case 14:{f.Push(JValue.R(null));f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/event/GameEventCardChangeZone","from","()Lforge/game/zone/ZoneView;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/game/zone/ZoneView","zoneType","()Lforge/game/zone/ZoneType;","invokevirtual",23);}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/event/GameEventCardChangeZone","to","()Lforge/game/zone/ZoneView;","invokevirtual",28);}
case 28:{return rt.Call(f,"forge/game/zone/ZoneView","zoneType","()Lforge/game/zone/ZoneType;","invokevirtual",31);}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Ante","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Ante","Lforge/game/zone/ZoneType;"));f.Pc=36;continue;}
case 36:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?92:39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Ante","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Ante","Lforge/game/zone/ZoneType;"));f.Pc=43;continue;}
case 43:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?92:46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/event/GameEventCardChangeZone","card","()Lforge/game/card/CardView;","invokevirtual",50);}
case 50:{f.Locals[4]=f.Pop();f.Pc=52;continue;}
case 52:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","ANTE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","ANTE","Lforge/game/GameLogEntryType;"));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Reference==null?85:64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/card/CardView","getOwner","()Lforge/game/player/PlayerView;","invokevirtual",69);}
case 69:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",72);}
case 72:{f.Push(f.Locals[4]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",77);}
case 77:{return rt.DynamicCall(f,"forge/game/GameLogFormatter:2435:77:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",82);}
case 82:{f.Pc=88;continue;}
case 85:{f.Push(JValue.R(rt.String("a card was anted")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",91);}
case 91:{return JStep.Return(f.Pop());}
case 92:{f.Push(f.Locals[2]);f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=96;continue;}
case 96:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?113:99;continue;}
case 99:{f.Push(f.Locals[3]);f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=103;continue;}
case 103:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?115:106;continue;}
case 106:{f.Push(f.Locals[3]);f.Pc=107;continue;}
case 107:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=110;continue;}
case 110:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?115:113;continue;}
case 113:{f.Push(JValue.R(null));f.Pc=114;continue;}
case 114:{return JStep.Return(f.Pop());}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/event/GameEventCardChangeZone","card","()Lforge/game/card/CardView;","invokevirtual",119);}
case 119:{f.Pc=f.Pop().Reference==null?132:122;continue;}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/event/GameEventCardChangeZone","card","()Lforge/game/card/CardView;","invokevirtual",126);}
case 126:{return rt.Call(f,"forge/game/card/CardView","toString","()Ljava/lang/String;","invokevirtual",129);}
case 129:{f.Pc=135;continue;}
case 132:{f.Push(JValue.R(rt.String("a card")));f.Pc=135;continue;}
case 135:{f.Locals[4]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","localizer","Lforge/util/Localizer;"));f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.String("lblLogZoneChange")));f.Pc=144;continue;}
case 144:{f.Push(JValue.I(3));f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=148;continue;}
case 148:{f.StackOp("dup");f.Pc=149;continue;}
case 149:{f.Push(JValue.I(0));f.Pc=150;continue;}
case 150:{f.Push(f.Locals[4]);f.Pc=152;continue;}
case 152:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=153;continue;}
case 153:{f.StackOp("dup");f.Pc=154;continue;}
case 154:{f.Push(JValue.I(1));f.Pc=155;continue;}
case 155:{f.Push(f.Locals[3]);f.Pc=156;continue;}
case 156:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=157;continue;}
case 157:{f.StackOp("dup");f.Pc=158;continue;}
case 158:{f.Push(JValue.I(2));f.Pc=159;continue;}
case 159:{f.Push(f.Locals[2]);f.Pc=160;continue;}
case 160:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",164);}
case 164:{f.Locals[5]=f.Pop();f.Pc=166;continue;}
case 166:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=169;continue;}
case 169:{f.StackOp("dup");f.Pc=170;continue;}
case 170:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","ZONE_CHANGE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","ZONE_CHANGE","Lforge/game/GameLogEntryType;"));f.Pc=173;continue;}
case 173:{f.Push(f.Locals[5]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[1]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/event/GameEventCardChangeZone","card","()Lforge/game/card/CardView;","invokevirtual",179);}
case 179:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;Lforge/game/card/CardView;)V","invokespecial",182);}
case 182:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2436(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/GameLogEntry"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameLogEntry")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/event/GameEventAddLog","type","()Lforge/game/GameLogEntryType;","invokevirtual",8);}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/event/GameEventAddLog","message","()Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/event/GameEventAddLog","sourceCard","()Lforge/game/card/CardView;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/GameLogEntry","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;Lforge/game/card/CardView;)V","invokespecial",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2437(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/GameEvent","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameLogEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference==null?23:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/GameLogFormatter","log","Lforge/game/GameLog;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/GameLog","add","(Lforge/game/GameLogEntry;)V","invokevirtual",23);}
case 23:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2438(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventAddLog;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2439(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventDoorChanged;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2440(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventCardPlotted;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2441(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventCardForetold;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2442(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventPlayerDamaged;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2443(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventTurnPhase;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2444(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventTurnBegan;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2445(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventSurveil;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2446(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventSpellAbilityCast;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2447(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventSpellResolved;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2448(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventScry;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2449(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventRandomLog;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2450(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventPlayerRadiation;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2451(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventPlayerPoisoned;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2452(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventPlayerControl;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2453(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventMulligan;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2454(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventPlayerLivesChanged;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2455(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventLandPlayed;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2456(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventGameOutcome;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2457(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventCardModeChosen;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2458(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventCardChangeZone;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2459(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventCardDamaged;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2460(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventBlockersDeclared;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2461(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/GameLogFormatter","visit","(Lforge/game/event/GameEventAttackersDeclared;)Lforge/game/GameLogEntry;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
