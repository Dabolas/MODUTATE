// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C699{
internal static JClass Build(){var c=new JClass("forge/game/phase/PhaseType","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("UNTAP","Lforge/game/phase/PhaseType;",true,JValue.Default("Lforge/game/phase/PhaseType;"),null));
c.Add(new JField("UPKEEP","Lforge/game/phase/PhaseType;",true,JValue.Default("Lforge/game/phase/PhaseType;"),null));
c.Add(new JField("DRAW","Lforge/game/phase/PhaseType;",true,JValue.Default("Lforge/game/phase/PhaseType;"),null));
c.Add(new JField("MAIN1","Lforge/game/phase/PhaseType;",true,JValue.Default("Lforge/game/phase/PhaseType;"),null));
c.Add(new JField("COMBAT_BEGIN","Lforge/game/phase/PhaseType;",true,JValue.Default("Lforge/game/phase/PhaseType;"),null));
c.Add(new JField("COMBAT_DECLARE_ATTACKERS","Lforge/game/phase/PhaseType;",true,JValue.Default("Lforge/game/phase/PhaseType;"),null));
c.Add(new JField("COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;",true,JValue.Default("Lforge/game/phase/PhaseType;"),null));
c.Add(new JField("COMBAT_FIRST_STRIKE_DAMAGE","Lforge/game/phase/PhaseType;",true,JValue.Default("Lforge/game/phase/PhaseType;"),null));
c.Add(new JField("COMBAT_DAMAGE","Lforge/game/phase/PhaseType;",true,JValue.Default("Lforge/game/phase/PhaseType;"),null));
c.Add(new JField("COMBAT_END","Lforge/game/phase/PhaseType;",true,JValue.Default("Lforge/game/phase/PhaseType;"),null));
c.Add(new JField("MAIN2","Lforge/game/phase/PhaseType;",true,JValue.Default("Lforge/game/phase/PhaseType;"),null));
c.Add(new JField("END_OF_TURN","Lforge/game/phase/PhaseType;",true,JValue.Default("Lforge/game/phase/PhaseType;"),null));
c.Add(new JField("CLEANUP","Lforge/game/phase/PhaseType;",true,JValue.Default("Lforge/game/phase/PhaseType;"),null));
c.Add(new JField("PHASE_GROUPS","Ljava/util/List;",true,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("PHASE_INDEX","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("nameForUi","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("nameForScripts","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("$VALUES","[Lforge/game/phase/PhaseType;",true,JValue.Default("[Lforge/game/phase/PhaseType;"),null));
c.Add(new JMethod(7936,"forge/game/phase/PhaseType","values","()[Lforge/game/phase/PhaseType;",9,0,1,new JHandler[]{},M7936));
c.Add(new JMethod(7937,"forge/game/phase/PhaseType","valueOf","(Ljava/lang/String;)Lforge/game/phase/PhaseType;",9,1,2,new JHandler[]{},M7937));
c.Add(new JMethod(7938,"forge/game/phase/PhaseType","initializePhaseIndex","()Ljava/util/Map;",10,1,3,new JHandler[]{},M7938));
c.Add(new JMethod(7939,"forge/game/phase/PhaseType","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V",2,5,4,new JHandler[]{},M7939));
c.Add(new JMethod(7940,"forge/game/phase/PhaseType","isAfter","(Lforge/game/phase/PhaseType;)Z",17,2,3,new JHandler[]{},M7940));
c.Add(new JMethod(7941,"forge/game/phase/PhaseType","isMain","()Z",17,1,2,new JHandler[]{},M7941));
c.Add(new JMethod(7942,"forge/game/phase/PhaseType","isBefore","(Lforge/game/phase/PhaseType;)Z",17,2,3,new JHandler[]{},M7942));
c.Add(new JMethod(7943,"forge/game/phase/PhaseType","isBefore","(Lforge/game/phase/PhaseType;Z)Z",17,6,3,new JHandler[]{},M7943));
c.Add(new JMethod(7944,"forge/game/phase/PhaseType","smartValueOf","(Ljava/lang/String;)Lforge/game/phase/PhaseType;",9,6,3,new JHandler[]{},M7944));
c.Add(new JMethod(7945,"forge/game/phase/PhaseType","parseRange","(Ljava/lang/String;)Ljava/util/Set;",9,10,3,new JHandler[]{},M7945));
c.Add(new JMethod(7946,"forge/game/phase/PhaseType","isLast","(Lforge/game/phase/PhaseType;Z)Z",9,2,2,new JHandler[]{},M7946));
c.Add(new JMethod(7947,"forge/game/phase/PhaseType","getNext","(Lforge/game/phase/PhaseType;Z)Lforge/game/phase/PhaseType;",9,5,2,new JHandler[]{},M7947));
c.Add(new JMethod(7948,"forge/game/phase/PhaseType","$values","()[Lforge/game/phase/PhaseType;",4106,0,4,new JHandler[]{},M7948));
c.Add(new JMethod(7949,"forge/game/phase/PhaseType","<clinit>","()V",8,0,7,new JHandler[]{},M7949));
}

internal static JStep M7936(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","$VALUES","[Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","$VALUES","[Lforge/game/phase/PhaseType;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/game/phase/PhaseType;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/phase/PhaseType;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7937(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/phase/PhaseType")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/phase/PhaseType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7938(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/phase/PhaseType")));f.Pc=2;continue;}
case 2:{return rt.Call(f,"com/google/common/collect/Maps","newEnumMap","(Ljava/lang/Class;)Ljava/util/EnumMap;","invokestatic",5);}
case 5:{f.Locals[0]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","UNTAP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","UNTAP","Lforge/game/phase/PhaseType;"));f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",14);}
case 14:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","UPKEEP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","UPKEEP","Lforge/game/phase/PhaseType;"));f.Pc=24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",28);}
case 28:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",33);}
case 33:{f.StackOp("pop");f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","DRAW","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","DRAW","Lforge/game/phase/PhaseType;"));f.Pc=38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",42);}
case 42:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",47);}
case 47:{f.StackOp("pop");f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","MAIN1","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","MAIN1","Lforge/game/phase/PhaseType;"));f.Pc=52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",56);}
case 56:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_BEGIN","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_BEGIN","Lforge/game/phase/PhaseType;"));f.Pc=66;continue;}
case 66:{f.Push(JValue.I(2));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",70);}
case 70:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DECLARE_ATTACKERS","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DECLARE_ATTACKERS","Lforge/game/phase/PhaseType;"));f.Pc=80;continue;}
case 80:{f.Push(JValue.I(2));f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",84);}
case 84:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",89);}
case 89:{f.StackOp("pop");f.Pc=90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;"));f.Pc=94;continue;}
case 94:{f.Push(JValue.I(2));f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",98);}
case 98:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",103);}
case 103:{f.StackOp("pop");f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_FIRST_STRIKE_DAMAGE","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_FIRST_STRIKE_DAMAGE","Lforge/game/phase/PhaseType;"));f.Pc=108;continue;}
case 108:{f.Push(JValue.I(2));f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",112);}
case 112:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",117);}
case 117:{f.StackOp("pop");f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DAMAGE","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DAMAGE","Lforge/game/phase/PhaseType;"));f.Pc=122;continue;}
case 122:{f.Push(JValue.I(2));f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",126);}
case 126:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",131);}
case 131:{f.StackOp("pop");f.Pc=132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_END","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_END","Lforge/game/phase/PhaseType;"));f.Pc=136;continue;}
case 136:{f.Push(JValue.I(2));f.Pc=137;continue;}
case 137:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",140);}
case 140:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",145);}
case 145:{f.StackOp("pop");f.Pc=146;continue;}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","MAIN2","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","MAIN2","Lforge/game/phase/PhaseType;"));f.Pc=150;continue;}
case 150:{f.Push(JValue.I(3));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",154);}
case 154:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",159);}
case 159:{f.StackOp("pop");f.Pc=160;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","END_OF_TURN","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","END_OF_TURN","Lforge/game/phase/PhaseType;"));f.Pc=164;continue;}
case 164:{f.Push(JValue.I(4));f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",168);}
case 168:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",173);}
case 173:{f.StackOp("pop");f.Pc=174;continue;}
case 174:{f.Push(f.Locals[0]);f.Pc=175;continue;}
case 175:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"));f.Pc=178;continue;}
case 178:{f.Push(JValue.I(5));f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",182);}
case 182:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",187);}
case 187:{f.StackOp("pop");f.Pc=188;continue;}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7939(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",10);}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",18);}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseType","nameForUi","Ljava/lang/String;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/PhaseType","nameForScripts","Ljava/lang/String;",value);f.Pc=27;continue;}
case 27:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7940(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/phase/PhaseType","isBefore","(Lforge/game/phase/PhaseType;Z)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7941(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","MAIN1","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","MAIN1","Lforge/game/phase/PhaseType;"));f.Pc=4;continue;}
case 4:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?14:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","MAIN2","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","MAIN2","Lforge/game/phase/PhaseType;"));f.Pc=11;continue;}
case 11:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7942(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/phase/PhaseType","isBefore","(Lforge/game/phase/PhaseType;Z)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7943(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","PHASE_INDEX","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","PHASE_INDEX","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","PHASE_INDEX","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","PHASE_INDEX","Ljava/util/Map;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?109:39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","PHASE_GROUPS","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","PHASE_GROUPS","Ljava/util/List;"));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{f.Locals[5]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{f.Pc=f.Pop().Int==0?84:57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/List","indexOf","(Ljava/lang/Object;)I","invokeinterface",65);}
case 65:{f.Push(f.Locals[5]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/List","indexOf","(Ljava/lang/Object;)I","invokeinterface",73);}
case 73:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?80:76;continue;}
case 76:{f.Push(JValue.I(1));f.Pc=77;continue;}
case 77:{f.Pc=108;continue;}
case 80:{f.Push(JValue.I(0));f.Pc=81;continue;}
case 81:{f.Pc=108;continue;}
case 84:{f.Push(f.Locals[5]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/util/List","indexOf","(Ljava/lang/Object;)I","invokeinterface",92);}
case 92:{f.Push(f.Locals[5]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/List","indexOf","(Ljava/lang/Object;)I","invokeinterface",100);}
case 100:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?107:103;continue;}
case 103:{f.Push(JValue.I(1));f.Pc=104;continue;}
case 104:{f.Pc=108;continue;}
case 107:{f.Push(JValue.I(0));f.Pc=108;continue;}
case 108:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{f.Pc=f.Pop().Int==0?127:113;continue;}
case 113:{f.Push(f.Locals[3]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?123:119;continue;}
case 119:{f.Push(JValue.I(1));f.Pc=120;continue;}
case 120:{f.Pc=138;continue;}
case 123:{f.Push(JValue.I(0));f.Pc=124;continue;}
case 124:{f.Pc=138;continue;}
case 127:{f.Push(f.Locals[3]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[4]);f.Pc=130;continue;}
case 130:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?137:133;continue;}
case 133:{f.Push(JValue.I(1));f.Pc=134;continue;}
case 134:{f.Pc=138;continue;}
case 137:{f.Push(JValue.I(0));f.Pc=138;continue;}
case 138:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7944(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(JValue.R(rt.String("All")));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?17:15;continue;}
case 15:{f.Push(JValue.R(null));f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Locals[1]=f.Pop();f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/phase/PhaseType","values","()[Lforge/game/phase/PhaseType;","invokestatic",25);}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{f.Locals[4]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?77:38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=42;continue;}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/PhaseType","nameForScripts","Ljava/lang/String;"));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int!=0?68:56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/phase/PhaseType","name","()Ljava/lang/String;","invokevirtual",61);}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?71:68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{return JStep.Return(f.Pop());}
case 71:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=74;continue;}
case 74:{f.Pc=32;continue;}
case 77:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=80;continue;}
case 80:{f.StackOp("dup");f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{return rt.DynamicCall(f,"forge/game/phase/PhaseType:7944:82:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",87);}
case 87:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",90);}
case 90:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7945(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/phase/PhaseType")));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",5);}
case 5:{f.Locals[1]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String(",")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=15;continue;}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?158:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=29;continue;}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("->")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",38);}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{f.Pc=f.Pop().Int<0?107:45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[6]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",53);}
case 53:{return rt.Call(f,"forge/game/phase/PhaseType","smartValueOf","(Ljava/lang/String;)Lforge/game/phase/PhaseType;","invokestatic",56);}
case 56:{f.Locals[7]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[6]);f.Pc=62;continue;}
case 62:{f.Push(JValue.I(2));f.Pc=63;continue;}
case 63:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",67);}
case 67:{f.Locals[8]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[8]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",74);}
case 74:{f.Pc=f.Pop().Int==0?83:77;continue;}
case 77:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"));f.Pc=80;continue;}
case 80:{f.Pc=88;continue;}
case 83:{f.Push(f.Locals[8]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/phase/PhaseType","smartValueOf","(Ljava/lang/String;)Lforge/game/phase/PhaseType;","invokestatic",88);}
case 88:{f.Locals[9]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[9]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/EnumSet","range","(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",98);}
case 98:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",103);}
case 103:{f.StackOp("pop");f.Pc=104;continue;}
case 104:{f.Pc=152;continue;}
case 107:{f.Push(f.Locals[5]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("Main")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?140:117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","MAIN1","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","MAIN1","Lforge/game/phase/PhaseType;"));f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",126);}
case 126:{f.StackOp("pop");f.Pc=127;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","MAIN2","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","MAIN2","Lforge/game/phase/PhaseType;"));f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",136);}
case 136:{f.StackOp("pop");f.Pc=137;continue;}
case 137:{f.Pc=152;continue;}
case 140:{f.Push(f.Locals[1]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[5]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/phase/PhaseType","smartValueOf","(Ljava/lang/String;)Lforge/game/phase/PhaseType;","invokestatic",146);}
case 146:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",151);}
case 151:{f.StackOp("pop");f.Pc=152;continue;}
case 152:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=155;continue;}
case 155:{f.Pc=19;continue;}
case 158:{f.Push(f.Locals[1]);f.Pc=159;continue;}
case 159:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7946(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(1));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"));f.Pc=10;continue;}
case 10:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?17:13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Pc=18;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7947(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?26:4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","PHASE_GROUPS","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","PHASE_GROUPS","Ljava/util/List;"));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",13);}
case 13:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/phase/PhaseType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{return JStep.Return(f.Pop());}
case 26:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","PHASE_INDEX","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","PHASE_INDEX","Ljava/util/Map;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",41);}
case 41:{f.Locals[2]=f.Pop();f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","PHASE_GROUPS","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","PHASE_GROUPS","Ljava/util/List;"));f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[3]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/List","indexOf","(Ljava/lang/Object;)I","invokeinterface",62);}
case 62:{f.Push(JValue.I(1));f.Pc=63;continue;}
case 63:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=64;continue;}
case 64:{f.Locals[4]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",74);}
case 74:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?122:77;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{f.Locals[4]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{f.Pc=f.Pop().Int!=0?104:84;continue;}
case 84:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","PHASE_GROUPS","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","PHASE_GROUPS","Ljava/util/List;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",96);}
case 96:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?122:99;continue;}
case 99:{f.Push(JValue.I(0));f.Pc=100;continue;}
case 100:{f.Locals[2]=f.Pop();f.Pc=101;continue;}
case 101:{f.Pc=122;continue;}
case 104:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(-1)));f.Pc=107;continue;}
case 107:{f.Push(f.Locals[2]);f.Pc=108;continue;}
case 108:{f.Pc=f.Pop().Int>=0?122:111;continue;}
case 111:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","PHASE_GROUPS","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","PHASE_GROUPS","Ljava/util/List;"));f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",119);}
case 119:{f.Push(JValue.I(1));f.Pc=120;continue;}
case 120:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=121;continue;}
case 121:{f.Locals[2]=f.Pop();f.Pc=122;continue;}
case 122:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","PHASE_GROUPS","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","PHASE_GROUPS","Ljava/util/List;"));f.Pc=125;continue;}
case 125:{f.Push(f.Locals[2]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",131);}
case 131:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[4]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",141);}
case 141:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/phase/PhaseType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=144;continue;}
case 144:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7948(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(13));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/game/phase/PhaseType;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","UNTAP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","UNTAP","Lforge/game/phase/PhaseType;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","UPKEEP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","UPKEEP","Lforge/game/phase/PhaseType;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","DRAW","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","DRAW","Lforge/game/phase/PhaseType;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","MAIN1","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","MAIN1","Lforge/game/phase/PhaseType;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_BEGIN","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_BEGIN","Lforge/game/phase/PhaseType;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DECLARE_ATTACKERS","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DECLARE_ATTACKERS","Lforge/game/phase/PhaseType;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_FIRST_STRIKE_DAMAGE","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_FIRST_STRIKE_DAMAGE","Lforge/game/phase/PhaseType;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DAMAGE","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DAMAGE","Lforge/game/phase/PhaseType;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_END","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_END","Lforge/game/phase/PhaseType;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","MAIN2","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","MAIN2","Lforge/game/phase/PhaseType;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(11));f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","END_OF_TURN","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","END_OF_TURN","Lforge/game/phase/PhaseType;"));f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(12));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"));f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7949(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/phase/PhaseType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/PhaseType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("UNTAP")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("lblUntapStep")));f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Untap")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/phase/PhaseType","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",14);}
case 14:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","UNTAP","Lforge/game/phase/PhaseType;"))return JStep.Continue;rt.PutStatic("forge/game/phase/PhaseType","UNTAP","Lforge/game/phase/PhaseType;",f.Pop());f.Pc=17;continue;}
case 17:{if(!rt.EnsureInitialized(f,"forge/game/phase/PhaseType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/PhaseType")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("UPKEEP")));f.Pc=23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("lblUpkeepStep")));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("Upkeep")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/phase/PhaseType","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",31);}
case 31:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","UPKEEP","Lforge/game/phase/PhaseType;"))return JStep.Continue;rt.PutStatic("forge/game/phase/PhaseType","UPKEEP","Lforge/game/phase/PhaseType;",f.Pop());f.Pc=34;continue;}
case 34:{if(!rt.EnsureInitialized(f,"forge/game/phase/PhaseType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/PhaseType")));f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("DRAW")));f.Pc=40;continue;}
case 40:{f.Push(JValue.I(2));f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("lblDrawStep")));f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("Draw")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/phase/PhaseType","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",48);}
case 48:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","DRAW","Lforge/game/phase/PhaseType;"))return JStep.Continue;rt.PutStatic("forge/game/phase/PhaseType","DRAW","Lforge/game/phase/PhaseType;",f.Pop());f.Pc=51;continue;}
case 51:{if(!rt.EnsureInitialized(f,"forge/game/phase/PhaseType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/PhaseType")));f.Pc=54;continue;}
case 54:{f.StackOp("dup");f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("MAIN1")));f.Pc=57;continue;}
case 57:{f.Push(JValue.I(3));f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("lblMainPhase1")));f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("Main1")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/phase/PhaseType","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",65);}
case 65:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","MAIN1","Lforge/game/phase/PhaseType;"))return JStep.Continue;rt.PutStatic("forge/game/phase/PhaseType","MAIN1","Lforge/game/phase/PhaseType;",f.Pop());f.Pc=68;continue;}
case 68:{if(!rt.EnsureInitialized(f,"forge/game/phase/PhaseType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/PhaseType")));f.Pc=71;continue;}
case 71:{f.StackOp("dup");f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("COMBAT_BEGIN")));f.Pc=74;continue;}
case 74:{f.Push(JValue.I(4));f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("lblCombatBeginStep")));f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("BeginCombat")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/phase/PhaseType","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",82);}
case 82:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_BEGIN","Lforge/game/phase/PhaseType;"))return JStep.Continue;rt.PutStatic("forge/game/phase/PhaseType","COMBAT_BEGIN","Lforge/game/phase/PhaseType;",f.Pop());f.Pc=85;continue;}
case 85:{if(!rt.EnsureInitialized(f,"forge/game/phase/PhaseType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/PhaseType")));f.Pc=88;continue;}
case 88:{f.StackOp("dup");f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("COMBAT_DECLARE_ATTACKERS")));f.Pc=91;continue;}
case 91:{f.Push(JValue.I(5));f.Pc=92;continue;}
case 92:{f.Push(JValue.R(rt.String("lblCombatDeclareAttackersStep")));f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("Declare Attackers")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/phase/PhaseType","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",99);}
case 99:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DECLARE_ATTACKERS","Lforge/game/phase/PhaseType;"))return JStep.Continue;rt.PutStatic("forge/game/phase/PhaseType","COMBAT_DECLARE_ATTACKERS","Lforge/game/phase/PhaseType;",f.Pop());f.Pc=102;continue;}
case 102:{if(!rt.EnsureInitialized(f,"forge/game/phase/PhaseType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/PhaseType")));f.Pc=105;continue;}
case 105:{f.StackOp("dup");f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("COMBAT_DECLARE_BLOCKERS")));f.Pc=108;continue;}
case 108:{f.Push(JValue.I(6));f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("lblCombatDeclareBlockersStep")));f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("Declare Blockers")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/phase/PhaseType","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",117);}
case 117:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;"))return JStep.Continue;rt.PutStatic("forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;",f.Pop());f.Pc=120;continue;}
case 120:{if(!rt.EnsureInitialized(f,"forge/game/phase/PhaseType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/PhaseType")));f.Pc=123;continue;}
case 123:{f.StackOp("dup");f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("COMBAT_FIRST_STRIKE_DAMAGE")));f.Pc=126;continue;}
case 126:{f.Push(JValue.I(7));f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String("lblCombatFirstStrikeDamageStep")));f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("First Strike Damage")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/phase/PhaseType","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",135);}
case 135:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_FIRST_STRIKE_DAMAGE","Lforge/game/phase/PhaseType;"))return JStep.Continue;rt.PutStatic("forge/game/phase/PhaseType","COMBAT_FIRST_STRIKE_DAMAGE","Lforge/game/phase/PhaseType;",f.Pop());f.Pc=138;continue;}
case 138:{if(!rt.EnsureInitialized(f,"forge/game/phase/PhaseType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/PhaseType")));f.Pc=141;continue;}
case 141:{f.StackOp("dup");f.Pc=142;continue;}
case 142:{f.Push(JValue.R(rt.String("COMBAT_DAMAGE")));f.Pc=144;continue;}
case 144:{f.Push(JValue.I(8));f.Pc=146;continue;}
case 146:{f.Push(JValue.R(rt.String("lblCombatDamageStep")));f.Pc=148;continue;}
case 148:{f.Push(JValue.R(rt.String("Combat Damage")));f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/phase/PhaseType","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",154);}
case 154:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DAMAGE","Lforge/game/phase/PhaseType;"))return JStep.Continue;rt.PutStatic("forge/game/phase/PhaseType","COMBAT_DAMAGE","Lforge/game/phase/PhaseType;",f.Pop());f.Pc=157;continue;}
case 157:{if(!rt.EnsureInitialized(f,"forge/game/phase/PhaseType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/PhaseType")));f.Pc=160;continue;}
case 160:{f.StackOp("dup");f.Pc=161;continue;}
case 161:{f.Push(JValue.R(rt.String("COMBAT_END")));f.Pc=164;continue;}
case 164:{f.Push(JValue.I(9));f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("lblCombatEndStep")));f.Pc=169;continue;}
case 169:{f.Push(JValue.R(rt.String("EndCombat")));f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/phase/PhaseType","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",175);}
case 175:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_END","Lforge/game/phase/PhaseType;"))return JStep.Continue;rt.PutStatic("forge/game/phase/PhaseType","COMBAT_END","Lforge/game/phase/PhaseType;",f.Pop());f.Pc=178;continue;}
case 178:{if(!rt.EnsureInitialized(f,"forge/game/phase/PhaseType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/PhaseType")));f.Pc=181;continue;}
case 181:{f.StackOp("dup");f.Pc=182;continue;}
case 182:{f.Push(JValue.R(rt.String("MAIN2")));f.Pc=185;continue;}
case 185:{f.Push(JValue.I(10));f.Pc=187;continue;}
case 187:{f.Push(JValue.R(rt.String("lblMainPhase2")));f.Pc=190;continue;}
case 190:{f.Push(JValue.R(rt.String("Main2")));f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/phase/PhaseType","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",196);}
case 196:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","MAIN2","Lforge/game/phase/PhaseType;"))return JStep.Continue;rt.PutStatic("forge/game/phase/PhaseType","MAIN2","Lforge/game/phase/PhaseType;",f.Pop());f.Pc=199;continue;}
case 199:{if(!rt.EnsureInitialized(f,"forge/game/phase/PhaseType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/PhaseType")));f.Pc=202;continue;}
case 202:{f.StackOp("dup");f.Pc=203;continue;}
case 203:{f.Push(JValue.R(rt.String("END_OF_TURN")));f.Pc=206;continue;}
case 206:{f.Push(JValue.I(11));f.Pc=208;continue;}
case 208:{f.Push(JValue.R(rt.String("lblEndStep")));f.Pc=211;continue;}
case 211:{f.Push(JValue.R(rt.String("End of Turn")));f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/phase/PhaseType","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",217);}
case 217:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","END_OF_TURN","Lforge/game/phase/PhaseType;"))return JStep.Continue;rt.PutStatic("forge/game/phase/PhaseType","END_OF_TURN","Lforge/game/phase/PhaseType;",f.Pop());f.Pc=220;continue;}
case 220:{if(!rt.EnsureInitialized(f,"forge/game/phase/PhaseType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/phase/PhaseType")));f.Pc=223;continue;}
case 223:{f.StackOp("dup");f.Pc=224;continue;}
case 224:{f.Push(JValue.R(rt.String("CLEANUP")));f.Pc=227;continue;}
case 227:{f.Push(JValue.I(12));f.Pc=229;continue;}
case 229:{f.Push(JValue.R(rt.String("lblCleanupStep")));f.Pc=232;continue;}
case 232:{f.Push(JValue.R(rt.String("Cleanup")));f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/phase/PhaseType","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V","invokespecial",238);}
case 238:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"))return JStep.Continue;rt.PutStatic("forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;",f.Pop());f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/phase/PhaseType","$values","()[Lforge/game/phase/PhaseType;","invokestatic",244);}
case 244:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","$VALUES","[Lforge/game/phase/PhaseType;"))return JStep.Continue;rt.PutStatic("forge/game/phase/PhaseType","$VALUES","[Lforge/game/phase/PhaseType;",f.Pop());f.Pc=247;continue;}
case 247:{f.Push(JValue.I(6));f.Pc=249;continue;}
case 249:{f.Push(JValue.R(rt.NewArray("Ljava/util/List;",f.Pop().Int)));f.Pc=252;continue;}
case 252:{f.StackOp("dup");f.Pc=253;continue;}
case 253:{f.Push(JValue.I(0));f.Pc=254;continue;}
case 254:{f.Push(JValue.I(3));f.Pc=255;continue;}
case 255:{f.Push(JValue.R(rt.NewArray("Lforge/game/phase/PhaseType;",f.Pop().Int)));f.Pc=258;continue;}
case 258:{f.StackOp("dup");f.Pc=259;continue;}
case 259:{f.Push(JValue.I(0));f.Pc=260;continue;}
case 260:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","UNTAP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","UNTAP","Lforge/game/phase/PhaseType;"));f.Pc=263;continue;}
case 263:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=264;continue;}
case 264:{f.StackOp("dup");f.Pc=265;continue;}
case 265:{f.Push(JValue.I(1));f.Pc=266;continue;}
case 266:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","UPKEEP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","UPKEEP","Lforge/game/phase/PhaseType;"));f.Pc=269;continue;}
case 269:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=270;continue;}
case 270:{f.StackOp("dup");f.Pc=271;continue;}
case 271:{f.Push(JValue.I(2));f.Pc=272;continue;}
case 272:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","DRAW","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","DRAW","Lforge/game/phase/PhaseType;"));f.Pc=275;continue;}
case 275:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=276;continue;}
case 276:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",279);}
case 279:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=280;continue;}
case 280:{f.StackOp("dup");f.Pc=281;continue;}
case 281:{f.Push(JValue.I(1));f.Pc=282;continue;}
case 282:{f.Push(JValue.I(1));f.Pc=283;continue;}
case 283:{f.Push(JValue.R(rt.NewArray("Lforge/game/phase/PhaseType;",f.Pop().Int)));f.Pc=286;continue;}
case 286:{f.StackOp("dup");f.Pc=287;continue;}
case 287:{f.Push(JValue.I(0));f.Pc=288;continue;}
case 288:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","MAIN1","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","MAIN1","Lforge/game/phase/PhaseType;"));f.Pc=291;continue;}
case 291:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=292;continue;}
case 292:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",295);}
case 295:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=296;continue;}
case 296:{f.StackOp("dup");f.Pc=297;continue;}
case 297:{f.Push(JValue.I(2));f.Pc=298;continue;}
case 298:{f.Push(JValue.I(6));f.Pc=300;continue;}
case 300:{f.Push(JValue.R(rt.NewArray("Lforge/game/phase/PhaseType;",f.Pop().Int)));f.Pc=303;continue;}
case 303:{f.StackOp("dup");f.Pc=304;continue;}
case 304:{f.Push(JValue.I(0));f.Pc=305;continue;}
case 305:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_BEGIN","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_BEGIN","Lforge/game/phase/PhaseType;"));f.Pc=308;continue;}
case 308:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=309;continue;}
case 309:{f.StackOp("dup");f.Pc=310;continue;}
case 310:{f.Push(JValue.I(1));f.Pc=311;continue;}
case 311:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DECLARE_ATTACKERS","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DECLARE_ATTACKERS","Lforge/game/phase/PhaseType;"));f.Pc=314;continue;}
case 314:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=315;continue;}
case 315:{f.StackOp("dup");f.Pc=316;continue;}
case 316:{f.Push(JValue.I(2));f.Pc=317;continue;}
case 317:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DECLARE_BLOCKERS","Lforge/game/phase/PhaseType;"));f.Pc=320;continue;}
case 320:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=321;continue;}
case 321:{f.StackOp("dup");f.Pc=322;continue;}
case 322:{f.Push(JValue.I(3));f.Pc=323;continue;}
case 323:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_FIRST_STRIKE_DAMAGE","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_FIRST_STRIKE_DAMAGE","Lforge/game/phase/PhaseType;"));f.Pc=326;continue;}
case 326:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=327;continue;}
case 327:{f.StackOp("dup");f.Pc=328;continue;}
case 328:{f.Push(JValue.I(4));f.Pc=329;continue;}
case 329:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_DAMAGE","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_DAMAGE","Lforge/game/phase/PhaseType;"));f.Pc=332;continue;}
case 332:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=333;continue;}
case 333:{f.StackOp("dup");f.Pc=334;continue;}
case 334:{f.Push(JValue.I(5));f.Pc=335;continue;}
case 335:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","COMBAT_END","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","COMBAT_END","Lforge/game/phase/PhaseType;"));f.Pc=338;continue;}
case 338:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=339;continue;}
case 339:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",342);}
case 342:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=343;continue;}
case 343:{f.StackOp("dup");f.Pc=344;continue;}
case 344:{f.Push(JValue.I(3));f.Pc=345;continue;}
case 345:{f.Push(JValue.I(1));f.Pc=346;continue;}
case 346:{f.Push(JValue.R(rt.NewArray("Lforge/game/phase/PhaseType;",f.Pop().Int)));f.Pc=349;continue;}
case 349:{f.StackOp("dup");f.Pc=350;continue;}
case 350:{f.Push(JValue.I(0));f.Pc=351;continue;}
case 351:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","MAIN2","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","MAIN2","Lforge/game/phase/PhaseType;"));f.Pc=354;continue;}
case 354:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=355;continue;}
case 355:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",358);}
case 358:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=359;continue;}
case 359:{f.StackOp("dup");f.Pc=360;continue;}
case 360:{f.Push(JValue.I(4));f.Pc=361;continue;}
case 361:{f.Push(JValue.I(1));f.Pc=362;continue;}
case 362:{f.Push(JValue.R(rt.NewArray("Lforge/game/phase/PhaseType;",f.Pop().Int)));f.Pc=365;continue;}
case 365:{f.StackOp("dup");f.Pc=366;continue;}
case 366:{f.Push(JValue.I(0));f.Pc=367;continue;}
case 367:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","END_OF_TURN","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","END_OF_TURN","Lforge/game/phase/PhaseType;"));f.Pc=370;continue;}
case 370:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=371;continue;}
case 371:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",374);}
case 374:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=375;continue;}
case 375:{f.StackOp("dup");f.Pc=376;continue;}
case 376:{f.Push(JValue.I(5));f.Pc=377;continue;}
case 377:{f.Push(JValue.I(1));f.Pc=378;continue;}
case 378:{f.Push(JValue.R(rt.NewArray("Lforge/game/phase/PhaseType;",f.Pop().Int)));f.Pc=381;continue;}
case 381:{f.StackOp("dup");f.Pc=382;continue;}
case 382:{f.Push(JValue.I(0));f.Pc=383;continue;}
case 383:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","CLEANUP","Lforge/game/phase/PhaseType;"));f.Pc=386;continue;}
case 386:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=387;continue;}
case 387:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",390);}
case 390:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=391;continue;}
case 391:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",394);}
case 394:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","PHASE_GROUPS","Ljava/util/List;"))return JStep.Continue;rt.PutStatic("forge/game/phase/PhaseType","PHASE_GROUPS","Ljava/util/List;",f.Pop());f.Pc=397;continue;}
case 397:{return rt.Call(f,"forge/game/phase/PhaseType","initializePhaseIndex","()Ljava/util/Map;","invokestatic",400);}
case 400:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","PHASE_INDEX","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/game/phase/PhaseType","PHASE_INDEX","Ljava/util/Map;",f.Pop());f.Pc=403;continue;}
case 403:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
