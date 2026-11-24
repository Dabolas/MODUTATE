// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C363{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/PumpEffect$1","java/lang/Object",new string[]{"forge/GameCommand"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-42244224L),null));
c.Add(new JField("val$host","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("val$gameCard","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("val$timestamp","J",false,JValue.Default("J"),null));
c.Add(new JField("val$keywords","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("val$game","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JMethod(3596,"forge/game/ability/effects/PumpEffect$1","<init>","(Lforge/game/card/Card;Lforge/game/card/Card;JLjava/util/List;Lforge/game/Game;)V",0,7,3,new JHandler[]{},M3596));
c.Add(new JMethod(3597,"forge/game/ability/effects/PumpEffect$1","run","()V",1,2,5,new JHandler[]{},M3597));
}

internal static JStep M3596(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$host","Lforge/game/card/Card;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$gameCard","Lforge/game/card/Card;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$timestamp","J",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$keywords","Ljava/util/List;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[6]);f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$game","Lforge/game/Game;",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",31);}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3597(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$host","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$gameCard","Lforge/game/card/Card;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","removeGainControlTargets","(Lforge/game/card/Card;)V","invokevirtual",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$gameCard","Lforge/game/card/Card;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$timestamp","J"));f.Pc=19;continue;}
case 19:{f.Push(JValue.L(0));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/Card","removePTBoost","(JJ)Z","invokevirtual",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$gameCard","Lforge/game/card/Card;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$timestamp","J"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/Card","removeCanBlockAny","(J)Z","invokevirtual",35);}
case 35:{f.Locals[1]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$gameCard","Lforge/game/card/Card;"));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$timestamp","J"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card","removeCanBlockAdditional","(J)Z","invokevirtual",48);}
case 48:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=49;continue;}
case 49:{f.Locals[1]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$keywords","Ljava/util/List;"));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",59);}
case 59:{f.Pc=f.Pop().Int<=0?87:62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$gameCard","Lforge/game/card/Card;"));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$timestamp","J"));f.Pc=70;continue;}
case 70:{f.Push(JValue.L(0));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/Card","removeHiddenExtrinsicKeywords","(JJ)V","invokevirtual",74);}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$gameCard","Lforge/game/card/Card;"));f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$timestamp","J"));f.Pc=82;continue;}
case 82:{f.Push(JValue.L(0));f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/card/Card","removeChangedCardKeywords","(JJ)Z","invokevirtual",86);}
case 86:{f.StackOp("pop");f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$gameCard","Lforge/game/card/Card;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/card/Card","updatePTforView","()V","invokevirtual",94);}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{f.Pc=f.Pop().Int==0?105:98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$gameCard","Lforge/game/card/Card;"));f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/card/Card","updateAbilityTextForView","()V","invokevirtual",105);}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$game","Lforge/game/Game;"));f.Pc=109;continue;}
case 109:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=112;continue;}
case 112:{f.StackOp("dup");f.Pc=113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/PumpEffect$1","val$gameCard","Lforge/game/card/Card;"));f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",120);}
case 120:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",123);}
case 123:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
