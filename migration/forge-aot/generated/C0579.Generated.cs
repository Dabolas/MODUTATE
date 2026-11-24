// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C579{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventCardChangeZone","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("card","Lforge/game/card/CardView;",false,JValue.Default("Lforge/game/card/CardView;"),null));
c.Add(new JField("from","Lforge/game/zone/ZoneView;",false,JValue.Default("Lforge/game/zone/ZoneView;"),null));
c.Add(new JField("to","Lforge/game/zone/ZoneView;",false,JValue.Default("Lforge/game/zone/ZoneView;"),null));
c.Add(new JMethod(6810,"forge/game/event/GameEventCardChangeZone","<init>","(Lforge/game/card/Card;Lforge/game/zone/Zone;Lforge/game/zone/Zone;)V",1,4,4,new JHandler[]{},M6810));
c.Add(new JMethod(6811,"forge/game/event/GameEventCardChangeZone","<init>","(Lforge/game/card/CardView;Lforge/game/zone/ZoneView;Lforge/game/zone/ZoneView;)V",1,4,2,new JHandler[]{},M6811));
c.Add(new JMethod(6812,"forge/game/event/GameEventCardChangeZone","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6812));
c.Add(new JMethod(6813,"forge/game/event/GameEventCardChangeZone","toString","()Ljava/lang/String;",1,3,4,new JHandler[]{},M6813));
c.Add(new JMethod(6814,"forge/game/event/GameEventCardChangeZone","hashCode","()I",17,1,1,new JHandler[]{},M6814));
c.Add(new JMethod(6815,"forge/game/event/GameEventCardChangeZone","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M6815));
c.Add(new JMethod(6816,"forge/game/event/GameEventCardChangeZone","card","()Lforge/game/card/CardView;",1,1,1,new JHandler[]{},M6816));
c.Add(new JMethod(6817,"forge/game/event/GameEventCardChangeZone","from","()Lforge/game/zone/ZoneView;",1,1,1,new JHandler[]{},M6817));
c.Add(new JMethod(6818,"forge/game/event/GameEventCardChangeZone","to","()Lforge/game/zone/ZoneView;",1,1,1,new JHandler[]{},M6818));
}

internal static JStep M6810(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?13:9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{f.Pc=17;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/zone/Zone","getView","()Lforge/game/zone/ZoneView;","invokevirtual",17);}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Reference!=null?25:21;continue;}
case 21:{f.Push(JValue.R(null));f.Pc=22;continue;}
case 22:{f.Pc=29;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/zone/Zone","getView","()Lforge/game/zone/ZoneView;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/game/event/GameEventCardChangeZone","<init>","(Lforge/game/card/CardView;Lforge/game/zone/ZoneView;Lforge/game/zone/ZoneView;)V","invokespecial",32);}
case 32:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6811(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventCardChangeZone","card","Lforge/game/card/CardView;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventCardChangeZone","from","Lforge/game/zone/ZoneView;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventCardChangeZone","to","Lforge/game/zone/ZoneView;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6812(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventCardChangeZone;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6813(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardChangeZone","from","Lforge/game/zone/ZoneView;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?25:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardChangeZone","from","Lforge/game/zone/ZoneView;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/zone/ZoneView","zoneType","()Lforge/game/zone/ZoneType;","invokevirtual",14);}
case 14:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",17);}
case 17:{return rt.DynamicCall(f,"forge/game/event/GameEventCardChangeZone:6813:17:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",22);}
case 22:{f.Pc=27;continue;}
case 25:{f.Push(JValue.R(rt.String("null")));f.Pc=27;continue;}
case 27:{f.Locals[1]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardChangeZone","to","Lforge/game/zone/ZoneView;"));f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Reference==null?53:35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardChangeZone","to","Lforge/game/zone/ZoneView;"));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/zone/ZoneView","zoneType","()Lforge/game/zone/ZoneType;","invokevirtual",42);}
case 42:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",45);}
case 45:{return rt.DynamicCall(f,"forge/game/event/GameEventCardChangeZone:6813:45:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",50);}
case 50:{f.Pc=55;continue;}
case 53:{f.Push(JValue.R(rt.String("null")));f.Pc=55;continue;}
case 55:{f.Locals[2]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(JValue.I(5));f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=60;continue;}
case 60:{f.StackOp("dup");f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardChangeZone","card","Lforge/game/card/CardView;"));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",69);}
case 69:{return rt.DynamicCall(f,"forge/game/event/GameEventCardChangeZone:6813:69:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",74);}
case 74:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=75;continue;}
case 75:{f.StackOp("dup");f.Pc=76;continue;}
case 76:{f.Push(JValue.I(1));f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String(":")));f.Pc=79;continue;}
case 79:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=80;continue;}
case 80:{f.StackOp("dup");f.Pc=81;continue;}
case 81:{f.Push(JValue.I(2));f.Pc=82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/util/TextUtil","enclosedBracket","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",86);}
case 86:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=87;continue;}
case 87:{f.StackOp("dup");f.Pc=88;continue;}
case 88:{f.Push(JValue.I(3));f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("->")));f.Pc=91;continue;}
case 91:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=92;continue;}
case 92:{f.StackOp("dup");f.Pc=93;continue;}
case 93:{f.Push(JValue.I(4));f.Pc=94;continue;}
case 94:{f.Push(f.Locals[2]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/util/TextUtil","enclosedBracket","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",98);}
case 98:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",102);}
case 102:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6814(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventCardChangeZone:6814:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventCardChangeZone;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6815(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventCardChangeZone:6815:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventCardChangeZone;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6816(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardChangeZone","card","Lforge/game/card/CardView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6817(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardChangeZone","from","Lforge/game/zone/ZoneView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6818(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventCardChangeZone","to","Lforge/game/zone/ZoneView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
