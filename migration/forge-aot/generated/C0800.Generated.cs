// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C800{
internal static JClass Build(){var c=new JClass("forge/game/spellability/SpellAbility$1","java/lang/Object",new string[]{"forge/GameCommand"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-8285169579025607693L),null));
c.Add(new JField("val$host","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("val$timestamp","J",false,JValue.Default("J"),null));
c.Add(new JField("this$0","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JMethod(9507,"forge/game/spellability/SpellAbility$1","<init>","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;J)V",0,5,3,new JHandler[]{},M9507));
c.Add(new JMethod(9508,"forge/game/spellability/SpellAbility$1","run","()V",1,1,5,new JHandler[]{},M9508));
}

internal static JStep M9507(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility$1","this$0","Lforge/game/spellability/SpellAbility;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility$1","val$host","Lforge/game/card/Card;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/SpellAbility$1","val$timestamp","J",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",19);}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9508(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility$1","val$host","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility$1","val$timestamp","J"));f.Pc=8;continue;}
case 8:{f.Push(JValue.L(0));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","removeChangedCardKeywords","(JJ)Z","invokevirtual",12);}
case 12:{f.StackOp("pop");f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility$1","val$host","Lforge/game/card/Card;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",20);}
case 20:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/SpellAbility$1","val$host","Lforge/game/card/Card;"));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",31);}
case 31:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",34);}
case 34:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
