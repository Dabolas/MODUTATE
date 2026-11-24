// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C806{
internal static JClass Build(){var c=new JClass("forge/game/spellability/SpellAbilityStackInstance","java/lang/Object",new string[]{"forge/game/IIdentifiable","forge/game/card/IHasCardView"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("maxId","I",true,JValue.Default("I"),null));
c.Add(new JField("id","I",false,JValue.Default("I"),null));
c.Add(new JField("ability","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JField("subInstance","Lforge/game/spellability/SpellAbilityStackInstance;",false,JValue.Default("Lforge/game/spellability/SpellAbilityStackInstance;"),null));
c.Add(new JField("stackDescription","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("view","Lforge/game/spellability/StackItemView;",false,JValue.Default("Lforge/game/spellability/StackItemView;"),null));
c.Add(new JMethod(9538,"forge/game/spellability/SpellAbilityStackInstance","nextId","()I",9,0,2,new JHandler[]{},M9538));
c.Add(new JMethod(9539,"forge/game/spellability/SpellAbilityStackInstance","<init>","(Lforge/game/spellability/SpellAbility;)V",1,2,3,new JHandler[]{},M9539));
c.Add(new JMethod(9540,"forge/game/spellability/SpellAbilityStackInstance","<init>","(Lforge/game/spellability/SpellAbility;I)V",1,3,4,new JHandler[]{},M9540));
c.Add(new JMethod(9541,"forge/game/spellability/SpellAbilityStackInstance","getId","()I",1,1,1,new JHandler[]{},M9541));
c.Add(new JMethod(9542,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;",17,1,1,new JHandler[]{},M9542));
c.Add(new JMethod(9543,"forge/game/spellability/SpellAbilityStackInstance","getStackDescription","()Ljava/lang/String;",17,1,3,new JHandler[]{},M9543));
c.Add(new JMethod(9544,"forge/game/spellability/SpellAbilityStackInstance","getSourceCard","()Lforge/game/card/Card;",17,1,1,new JHandler[]{},M9544));
c.Add(new JMethod(9545,"forge/game/spellability/SpellAbilityStackInstance","isSpell","()Z",17,1,1,new JHandler[]{},M9545));
c.Add(new JMethod(9546,"forge/game/spellability/SpellAbilityStackInstance","isAbility","()Z",17,1,1,new JHandler[]{},M9546));
c.Add(new JMethod(9547,"forge/game/spellability/SpellAbilityStackInstance","isTrigger","()Z",17,1,1,new JHandler[]{},M9547));
c.Add(new JMethod(9548,"forge/game/spellability/SpellAbilityStackInstance","isStateTrigger","(I)Z",17,2,2,new JHandler[]{},M9548));
c.Add(new JMethod(9549,"forge/game/spellability/SpellAbilityStackInstance","isOptionalTrigger","()Z",17,1,1,new JHandler[]{},M9549));
c.Add(new JMethod(9550,"forge/game/spellability/SpellAbilityStackInstance","getSubInstance","()Lforge/game/spellability/SpellAbilityStackInstance;",17,1,1,new JHandler[]{},M9550));
c.Add(new JMethod(9551,"forge/game/spellability/SpellAbilityStackInstance","getTargetChoices","()Lforge/game/spellability/TargetChoices;",17,1,1,new JHandler[]{},M9551));
c.Add(new JMethod(9552,"forge/game/spellability/SpellAbilityStackInstance","updateTarget","(Lforge/game/spellability/TargetChoices;Ljava/util/Set;)V",1,5,2,new JHandler[]{},M9552));
c.Add(new JMethod(9553,"forge/game/spellability/SpellAbilityStackInstance","addTriggeringObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)Z",1,3,3,new JHandler[]{},M9553));
c.Add(new JMethod(9554,"forge/game/spellability/SpellAbilityStackInstance","updateTriggeringObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)Z",1,3,3,new JHandler[]{},M9554));
c.Add(new JMethod(9555,"forge/game/spellability/SpellAbilityStackInstance","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M9555));
c.Add(new JMethod(9556,"forge/game/spellability/SpellAbilityStackInstance","getActivatingPlayer","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M9556));
c.Add(new JMethod(9557,"forge/game/spellability/SpellAbilityStackInstance","setActivatingPlayer","(Lforge/game/player/Player;)V",1,2,2,new JHandler[]{},M9557));
c.Add(new JMethod(9558,"forge/game/spellability/SpellAbilityStackInstance","toString","()Ljava/lang/String;",1,1,4,new JHandler[]{},M9558));
c.Add(new JMethod(9559,"forge/game/spellability/SpellAbilityStackInstance","getView","()Lforge/game/spellability/StackItemView;",1,1,1,new JHandler[]{},M9559));
c.Add(new JMethod(9560,"forge/game/spellability/SpellAbilityStackInstance","getCardView","()Lforge/game/card/CardView;",1,1,1,new JHandler[]{},M9560));
c.Add(new JMethod(9561,"forge/game/spellability/SpellAbilityStackInstance","<clinit>","()V",8,0,1,new JHandler[]{},M9561));
}

internal static JStep M9538(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/spellability/SpellAbilityStackInstance","maxId","I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/SpellAbilityStackInstance","maxId","I"));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/spellability/SpellAbilityStackInstance","maxId","I"))return JStep.Continue;rt.PutStatic("forge/game/spellability/SpellAbilityStackInstance","maxId","I",f.Pop());f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9539(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","nextId","()I","invokestatic",5);}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","<init>","(Lforge/game/spellability/SpellAbility;I)V","invokespecial",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9540(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","stackDescription","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","id","I",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getStackDescription","()Ljava/lang/String;","invokevirtual",24);}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","stackDescription","Ljava/lang/String;",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Reference!=null?42:38;continue;}
case 38:{f.Push(JValue.R(null));f.Pc=39;continue;}
case 39:{f.Pc=56;continue;}
case 42:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbilityStackInstance"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbilityStackInstance")));f.Pc=45;continue;}
case 45:{f.StackOp("dup");f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",53);}
case 53:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","<init>","(Lforge/game/spellability/SpellAbility;)V","invokespecial",56);}
case 56:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","subInstance","Lforge/game/spellability/SpellAbilityStackInstance;",value);f.Pc=59;continue;}
case 59:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","SetState","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","SetState","Lforge/game/ability/ApiType;"));f.Pc=62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",66);}
case 66:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?103:69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("StoredTransform")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasSVar","(Ljava/lang/String;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int!=0?103:81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("StoredTransform")));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",94);}
case 94:{return rt.Call(f,"forge/game/card/Card","getTransformedTimestamp","()J","invokevirtual",97);}
case 97:{return rt.Call(f,"java/lang/String","valueOf","(J)Ljava/lang/String;","invokestatic",100);}
case 100:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",103);}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",107);}
case 107:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"));f.Pc=110;continue;}
case 110:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?150:113;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("ChoiceRestriction")));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",119);}
case 119:{f.Pc=f.Pop().Int==0?150:122;continue;}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",126);}
case 126:{f.Push(f.Locals[1]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",131);}
case 131:{return rt.Call(f,"forge/game/spellability/AbilitySub","getDescription","()Ljava/lang/String;","invokevirtual",134);}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",138);}
case 138:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",141);}
case 141:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",144);}
case 144:{return rt.Call(f,"forge/game/phase/PhaseHandler","inCombat","()Z","invokevirtual",147);}
case 147:{return rt.Call(f,"forge/game/card/Card","addChosenModes","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Z)V","invokevirtual",150);}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{if(!rt.EnsureInitialized(f,"forge/game/spellability/StackItemView"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/StackItemView")));f.Pc=154;continue;}
case 154:{f.StackOp("dup");f.Pc=155;continue;}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/spellability/StackItemView","<init>","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokespecial",159);}
case 159:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","view","Lforge/game/spellability/StackItemView;",value);f.Pc=162;continue;}
case 162:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9541(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","id","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9542(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9543(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","stackDescription","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("\\\\r\\\\n")));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Push(JValue.R(rt.String("\\.\u2022")));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String(";")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Push(JValue.R(rt.String("\u2022")));f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",25);}
case 25:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9544(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9545(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9546(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9547(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9548(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSourceTrigger","()I","invokevirtual",7);}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?15:11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{f.Pc=16;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9549(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isOptionalTrigger","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9550(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","subInstance","Lforge/game/spellability/SpellAbilityStackInstance;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9551(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9552(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?102:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getStackDescription","()Ljava/lang/String;","invokevirtual",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","stackDescription","Ljava/lang/String;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","view","Lforge/game/spellability/StackItemView;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/StackItemView","updateTargetCards","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",23);}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","view","Lforge/game/spellability/StackItemView;"));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/StackItemView","updateTargetPlayers","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",31);}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","view","Lforge/game/spellability/StackItemView;"));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/StackItemView","updateTargetStackItems","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",39);}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","view","Lforge/game/spellability/StackItemView;"));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/spellability/StackItemView","updateText","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",47);}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",54);}
case 54:{return rt.Call(f,"forge/game/spellability/TargetChoices","iterator","()Ljava/util/Iterator;","invokevirtual",57);}
case 57:{f.Locals[3]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",64);}
case 64:{f.Pc=f.Pop().Int==0?102:67;continue;}
case 67:{f.Push(f.Locals[3]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",73);}
case 73:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=76;continue;}
case 76:{f.Locals[4]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/spellability/TargetChoices","contains","(Ljava/lang/Object;)Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int==0?90:87;continue;}
case 87:{f.Pc=58;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[4]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",98);}
case 98:{f.StackOp("pop");f.Pc=99;continue;}
case 99:{f.Pc=58;continue;}
case 102:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9553(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasTriggeringObject","(Lforge/game/ability/AbilityKey;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int!=0?22:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","setTriggeringObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",20);}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9554(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasTriggeringObject","(Lforge/game/ability/AbilityKey;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?22:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","setTriggeringObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",20);}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9555(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9556(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9557(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","ability","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","view","Lforge/game/spellability/StackItemView;"));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/StackItemView","updateActivatingPlayer","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","subInstance","Lforge/game/spellability/SpellAbilityStackInstance;"));f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Reference==null?31:23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","subInstance","Lforge/game/spellability/SpellAbilityStackInstance;"));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",31);}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9558(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(3));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSourceCard","()Lforge/game/card/Card;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",13);}
case 13:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("->")));f.Pc=18;continue;}
case 18:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{f.Push(JValue.I(2));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getStackDescription","()Ljava/lang/String;","invokevirtual",25);}
case 25:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/util/TextUtil","concatNoSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",29);}
case 29:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9559(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbilityStackInstance","view","Lforge/game/spellability/StackItemView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9560(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSourceCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9561(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/spellability/SpellAbilityStackInstance","maxId","I"))return JStep.Continue;rt.PutStatic("forge/game/spellability/SpellAbilityStackInstance","maxId","I",f.Pop());f.Pc=4;continue;}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
