// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C635{
internal static JClass Build(){var c=new JClass("forge/game/event/GameEventZone","java/lang/Record",new string[]{"forge/game/event/GameEvent"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("zoneType","Lforge/game/zone/ZoneType;",false,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("player","Lforge/game/player/PlayerView;",false,JValue.Default("Lforge/game/player/PlayerView;"),null));
c.Add(new JField("mode","Lforge/game/event/EventValueChangeType;",false,JValue.Default("Lforge/game/event/EventValueChangeType;"),null));
c.Add(new JField("card","Lforge/game/card/CardView;",false,JValue.Default("Lforge/game/card/CardView;"),null));
c.Add(new JField("sa","Lforge/game/spellability/SpellAbilityView;",false,JValue.Default("Lforge/game/spellability/SpellAbilityView;"),null));
c.Add(new JMethod(7250,"forge/game/event/GameEventZone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/player/Player;Lforge/game/event/EventValueChangeType;Lforge/game/card/Card;)V",1,5,6,new JHandler[]{},M7250));
c.Add(new JMethod(7251,"forge/game/event/GameEventZone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;Lforge/game/event/EventValueChangeType;)V",1,4,6,new JHandler[]{},M7251));
c.Add(new JMethod(7252,"forge/game/event/GameEventZone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/player/PlayerView;Lforge/game/event/EventValueChangeType;Lforge/game/card/CardView;Lforge/game/spellability/SpellAbilityView;)V",1,6,2,new JHandler[]{},M7252));
c.Add(new JMethod(7253,"forge/game/event/GameEventZone","isRedrawHint","()Z",1,1,1,new JHandler[]{},M7253));
c.Add(new JMethod(7254,"forge/game/event/GameEventZone","visit","(Lforge/game/event/IGameEventVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M7254));
c.Add(new JMethod(7255,"forge/game/event/GameEventZone","toString","()Ljava/lang/String;",1,2,4,new JHandler[]{},M7255));
c.Add(new JMethod(7256,"forge/game/event/GameEventZone","hashCode","()I",17,1,1,new JHandler[]{},M7256));
c.Add(new JMethod(7257,"forge/game/event/GameEventZone","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M7257));
c.Add(new JMethod(7258,"forge/game/event/GameEventZone","zoneType","()Lforge/game/zone/ZoneType;",1,1,1,new JHandler[]{},M7258));
c.Add(new JMethod(7259,"forge/game/event/GameEventZone","player","()Lforge/game/player/PlayerView;",1,1,1,new JHandler[]{},M7259));
c.Add(new JMethod(7260,"forge/game/event/GameEventZone","mode","()Lforge/game/event/EventValueChangeType;",1,1,1,new JHandler[]{},M7260));
c.Add(new JMethod(7261,"forge/game/event/GameEventZone","card","()Lforge/game/card/CardView;",1,1,1,new JHandler[]{},M7261));
c.Add(new JMethod(7262,"forge/game/event/GameEventZone","sa","()Lforge/game/spellability/SpellAbilityView;",1,1,1,new JHandler[]{},M7262));
}

internal static JStep M7250(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",6);}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[4]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",12);}
case 12:{f.Push(JValue.R(null));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/event/GameEventZone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/player/PlayerView;Lforge/game/event/EventValueChangeType;Lforge/game/card/CardView;Lforge/game/spellability/SpellAbilityView;)V","invokespecial",16);}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7251(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",9);}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",17);}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","get","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbilityView;","invokestatic",21);}
case 21:{return rt.Call(f,"forge/game/event/GameEventZone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/player/PlayerView;Lforge/game/event/EventValueChangeType;Lforge/game/card/CardView;Lforge/game/spellability/SpellAbilityView;)V","invokespecial",24);}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7252(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventZone","zoneType","Lforge/game/zone/ZoneType;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventZone","player","Lforge/game/player/PlayerView;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventZone","mode","Lforge/game/event/EventValueChangeType;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventZone","card","Lforge/game/card/CardView;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/event/GameEventZone","sa","Lforge/game/spellability/SpellAbilityView;",value);f.Pc=31;continue;}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7253(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7254(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/event/IGameEventVisitor","visit","(Lforge/game/event/GameEventZone;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7255(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventZone","player","Lforge/game/player/PlayerView;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?12:7;continue;}
case 7:{f.Push(JValue.R(rt.String("Game")));f.Pc=9;continue;}
case 9:{f.Pc=25;continue;}
case 12:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",15);}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventZone","player","Lforge/game/player/PlayerView;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/player/PlayerView","getName","()Ljava/lang/String;","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/util/Lang","getPossesive","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",25);}
case 25:{f.Locals[1]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventZone","card","Lforge/game/card/CardView;"));f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Reference!=null?79:33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventZone","sa","Lforge/game/spellability/SpellAbilityView;"));f.Pc=37;continue;}
case 37:{f.Pc=f.Pop().Reference!=null?79:40;continue;}
case 40:{f.Push(JValue.I(4));f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=44;continue;}
case 44:{f.StackOp("dup");f.Pc=45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventZone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/zone/ZoneType","toString","()Ljava/lang/String;","invokevirtual",57);}
case 57:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{f.Push(JValue.I(2));f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String(":")));f.Pc=62;continue;}
case 62:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=63;continue;}
case 63:{f.StackOp("dup");f.Pc=64;continue;}
case 64:{f.Push(JValue.I(3));f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventZone","mode","Lforge/game/event/EventValueChangeType;"));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/event/EventValueChangeType","toString","()Ljava/lang/String;","invokevirtual",72);}
case 72:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",76);}
case 76:{f.Pc=144;continue;}
case 79:{f.Push(JValue.I(5));f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(0));f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=87;continue;}
case 87:{f.StackOp("dup");f.Pc=88;continue;}
case 88:{f.Push(JValue.I(1));f.Pc=89;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventZone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/zone/ZoneType","toString","()Ljava/lang/String;","invokevirtual",96);}
case 96:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(JValue.I(2));f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String(":")));f.Pc=101;continue;}
case 101:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=102;continue;}
case 102:{f.StackOp("dup");f.Pc=103;continue;}
case 103:{f.Push(JValue.I(3));f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventZone","mode","Lforge/game/event/EventValueChangeType;"));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/event/EventValueChangeType","toString","()Ljava/lang/String;","invokevirtual",111);}
case 111:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=112;continue;}
case 112:{f.StackOp("dup");f.Pc=113;continue;}
case 113:{f.Push(JValue.I(4));f.Pc=114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventZone","sa","Lforge/game/spellability/SpellAbilityView;"));f.Pc=118;continue;}
case 118:{f.Pc=f.Pop().Reference!=null?128:121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventZone","card","Lforge/game/card/CardView;"));f.Pc=125;continue;}
case 125:{f.Pc=132;continue;}
case 128:{f.Push(f.Locals[0]);f.Pc=129;continue;}
case 129:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventZone","sa","Lforge/game/spellability/SpellAbilityView;"));f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",135);}
case 135:{return rt.DynamicCall(f,"forge/game/event/GameEventZone:7255:135:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",140);}
case 140:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",144);}
case 144:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7256(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/event/GameEventZone:7256:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventZone;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7257(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/event/GameEventZone:7257:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/event/GameEventZone;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7258(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventZone","zoneType","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7259(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventZone","player","Lforge/game/player/PlayerView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7260(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventZone","mode","Lforge/game/event/EventValueChangeType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7261(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventZone","card","Lforge/game/card/CardView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7262(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/event/GameEventZone","sa","Lforge/game/spellability/SpellAbilityView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
