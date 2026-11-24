// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C414{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/TextBoxExchangeEffect$1","java/lang/Object",new string[]{"forge/GameCommand"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(5331255714437747836L),null));
c.Add(new JField("val$game","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JField("val$c1","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("val$c2","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("val$ts","J",false,JValue.Default("J"),null));
c.Add(new JField("this$0","Lforge/game/ability/effects/TextBoxExchangeEffect;",false,JValue.Default("Lforge/game/ability/effects/TextBoxExchangeEffect;"),null));
c.Add(new JMethod(3776,"forge/game/ability/effects/TextBoxExchangeEffect$1","<init>","(Lforge/game/ability/effects/TextBoxExchangeEffect;Lforge/game/Game;Lforge/game/card/Card;Lforge/game/card/Card;J)V",0,7,3,new JHandler[]{},M3776));
c.Add(new JMethod(3777,"forge/game/ability/effects/TextBoxExchangeEffect$1","run","()V",1,3,6,new JHandler[]{},M3777));
}

internal static JStep M3776(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$1","this$0","Lforge/game/ability/effects/TextBoxExchangeEffect;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$1","val$game","Lforge/game/Game;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$1","val$c1","Lforge/game/card/Card;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$1","val$c2","Lforge/game/card/Card;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[5]);f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$1","val$ts","J",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",31);}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3777(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$1","val$game","Lforge/game/Game;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$1","val$c1","Lforge/game/card/Card;"));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",12);}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$1","val$game","Lforge/game/Game;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$1","val$c2","Lforge/game/card/Card;"));f.Pc=21;continue;}
case 21:{f.Push(JValue.R(null));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",25);}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Reference==null?85:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$1","val$c1","Lforge/game/card/Card;"));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?85:41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$1","val$ts","J"));f.Pc=46;continue;}
case 46:{f.Push(JValue.L(0));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/Card","removeChangedCardTraitsByText","(JJ)Z","invokevirtual",50);}
case 50:{f.StackOp("pop");f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$1","val$ts","J"));f.Pc=56;continue;}
case 56:{f.Push(JValue.L(0));f.Pc=57;continue;}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/Card","removeChangedCardKeywords","(JJZ)Z","invokevirtual",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/Card","updateChangedText","()V","invokevirtual",66);}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",70);}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$1","val$game","Lforge/game/Game;"));f.Pc=74;continue;}
case 74:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=77;continue;}
case 77:{f.StackOp("dup");f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",82);}
case 82:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",85);}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Pc=f.Pop().Reference==null?144:89;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$1","val$c2","Lforge/game/card/Card;"));f.Pc=93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",97);}
case 97:{f.Pc=f.Pop().Int==0?144:100;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$1","val$ts","J"));f.Pc=105;continue;}
case 105:{f.Push(JValue.L(0));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/card/Card","removeChangedCardTraitsByText","(JJ)Z","invokevirtual",109);}
case 109:{f.StackOp("pop");f.Pc=110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$1","val$ts","J"));f.Pc=115;continue;}
case 115:{f.Push(JValue.L(0));f.Pc=116;continue;}
case 116:{f.Push(JValue.I(0));f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/card/Card","removeChangedCardKeywords","(JJZ)Z","invokevirtual",120);}
case 120:{f.StackOp("pop");f.Pc=121;continue;}
case 121:{f.Push(f.Locals[2]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/card/Card","updateChangedText","()V","invokevirtual",125);}
case 125:{f.Push(f.Locals[2]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",129);}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$1","val$game","Lforge/game/Game;"));f.Pc=133;continue;}
case 133:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=136;continue;}
case 136:{f.StackOp("dup");f.Pc=137;continue;}
case 137:{f.Push(f.Locals[2]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",141);}
case 141:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",144);}
case 144:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
