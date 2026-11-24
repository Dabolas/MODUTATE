// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C642{
internal static JClass Build(){var c=new JClass("forge/game/keyword/Compleated","forge/game/keyword/SimpleKeyword",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(7398,"forge/game/keyword/Compleated","<init>","()V",1,1,1,new JHandler[]{},M7398));
c.Add(new JMethod(7399,"forge/game/keyword/Compleated","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;",4,8,3,new JHandler[]{},M7399));
}

internal static JStep M7398(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/SimpleKeyword","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7399(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/Compleated","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?11:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/card/mana/ManaCost","hasPhyrexian","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int!=0?25:23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/util/StreamUtil","stream","(Ljava/lang/Iterable;)Ljava/util/stream/Stream;","invokestatic",29);}
case 29:{return rt.DynamicCall(f,"forge/game/keyword/Compleated:7399:29:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",34);}
case 34:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",39);}
case 39:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",42);}
case 42:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{f.Locals[4]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",59);}
case 59:{f.Pc=f.Pop().Int==0?64:62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return JStep.Return(f.Pop());}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{f.Push(JValue.I(0));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",72);}
case 72:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=75;continue;}
case 75:{f.Locals[5]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/card/mana/ManaCostShard","toShortString","()Ljava/lang/String;","invokevirtual",82);}
case 82:{f.Push(JValue.R(rt.String("/")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",87);}
case 87:{f.Locals[6]=f.Pop();f.Pc=89;continue;}
case 89:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=92;continue;}
case 92:{f.StackOp("dup");f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",96);}
case 96:{f.Locals[7]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[7]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[5]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",105);}
case 105:{f.Push(JValue.R(rt.String(" can be paid with {")));f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",110);}
case 110:{f.Push(f.Locals[6]);f.Pc=112;continue;}
case 112:{f.Push(JValue.I(0));f.Pc=113;continue;}
case 113:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",117);}
case 117:{f.Push(JValue.R(rt.String("}")));f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",122);}
case 122:{f.StackOp("pop");f.Pc=123;continue;}
case 123:{f.Push(f.Locals[6]);f.Pc=125;continue;}
case 125:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=126;continue;}
case 126:{f.Push(JValue.I(2));f.Pc=127;continue;}
case 127:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?150:130;continue;}
case 130:{f.Push(f.Locals[7]);f.Pc=132;continue;}
case 132:{f.Push(JValue.R(rt.String(", {")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",137);}
case 137:{f.Push(f.Locals[6]);f.Pc=139;continue;}
case 139:{f.Push(JValue.I(1));f.Pc=140;continue;}
case 140:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",144);}
case 144:{f.Push(JValue.R(rt.String("},")));f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",149);}
case 149:{f.StackOp("pop");f.Pc=150;continue;}
case 150:{f.Push(f.Locals[7]);f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String(" or 2 life. ")));f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",157);}
case 157:{f.StackOp("pop");f.Pc=158;continue;}
case 158:{f.Push(f.Locals[3]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/card/mana/ManaCost","getPhyrexianCount","()I","invokevirtual",162);}
case 162:{f.Push(JValue.I(1));f.Pc=163;continue;}
case 163:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?187:166;continue;}
case 166:{f.Push(f.Locals[7]);f.Pc=168;continue;}
case 168:{f.Push(JValue.R(rt.String("For each ")));f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",173);}
case 173:{f.Push(f.Locals[5]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",178);}
case 178:{f.Push(JValue.R(rt.String(" paid with life,")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",183);}
case 183:{f.StackOp("pop");f.Pc=184;continue;}
case 184:{f.Pc=195;continue;}
case 187:{f.Push(f.Locals[7]);f.Pc=189;continue;}
case 189:{f.Push(JValue.R(rt.String("If life was paid,")));f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",194);}
case 194:{f.StackOp("pop");f.Pc=195;continue;}
case 195:{f.Push(f.Locals[7]);f.Pc=197;continue;}
case 197:{f.Push(JValue.R(rt.String(" this planeswalker enters with two fewer loyalty counters.")));f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",202);}
case 202:{f.StackOp("pop");f.Pc=203;continue;}
case 203:{f.Push(f.Locals[7]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",208);}
case 208:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
