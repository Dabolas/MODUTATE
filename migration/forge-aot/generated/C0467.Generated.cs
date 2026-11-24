// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C467{
internal static JClass Build(){var c=new JClass("forge/game/card/CardProperty$1CheckCanPayManaCost","java/lang/Object",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("manaPaid","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("manaCost","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("val$spellAbility","Lforge/game/CardTraitBase;",false,JValue.Default("Lforge/game/CardTraitBase;"),null));
c.Add(new JField("val$card","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JMethod(5255,"forge/game/card/CardProperty$1CheckCanPayManaCost","<init>","(Lforge/game/CardTraitBase;Lforge/game/card/Card;)V",0,3,2,new JHandler[]{},M5255));
c.Add(new JMethod(5256,"forge/game/card/CardProperty$1CheckCanPayManaCost","checkShard","(I)Z",0,5,3,new JHandler[]{},M5256));
c.Add(new JMethod(5257,"forge/game/card/CardProperty$1CheckCanPayManaCost","check","()Z",0,2,2,new JHandler[]{},M5257));
}

internal static JStep M5255(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","val$spellAbility","Lforge/game/CardTraitBase;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","val$card","Lforge/game/card/Card;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5256(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","manaCost","Ljava/util/List;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",10);}
case 10:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?15:13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","manaCost","Ljava/util/List;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCostShard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","X","Lforge/card/mana/ManaCostShard;"));f.Pc=33;continue;}
case 33:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?44:36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/CardProperty$1CheckCanPayManaCost","checkShard","(I)Z","invokevirtual",43);}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{f.Locals[3]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","manaPaid","Ljava/util/List;"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",56);}
case 56:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?241:59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","manaPaid","Ljava/util/List;"));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",69);}
case 69:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=72;continue;}
case 72:{f.Locals[4]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/mana/Mana","getColor","()B","invokevirtual",80);}
case 80:{return rt.Call(f,"forge/card/mana/ManaCostShard","isColor","(B)Z","invokevirtual",83);}
case 83:{f.Pc=f.Pop().Int!=0?101:86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/card/mana/ManaCostShard","isSnow","()Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?136:93;continue;}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/mana/Mana","isSnow","()Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?136:101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","manaPaid","Ljava/util/List;"));f.Pc=105;continue;}
case 105:{f.Push(f.Locals[3]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/List","remove","(I)Ljava/lang/Object;","invokeinterface",111);}
case 111:{f.StackOp("pop");f.Pc=112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{f.Push(JValue.I(1));f.Pc=115;continue;}
case 115:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/card/CardProperty$1CheckCanPayManaCost","checkShard","(I)Z","invokevirtual",119);}
case 119:{f.Pc=f.Pop().Int==0?124:122;continue;}
case 122:{f.Push(JValue.I(1));f.Pc=123;continue;}
case 123:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","manaPaid","Ljava/util/List;"));f.Pc=128;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[4]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/List","add","(ILjava/lang/Object;)V","invokeinterface",136);}
case 136:{f.Push(f.Locals[2]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/card/mana/ManaCostShard","isGeneric","()Z","invokevirtual",140);}
case 140:{f.Pc=f.Pop().Int==0?235:143;continue;}
case 143:{f.Push(f.Locals[2]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/card/mana/ManaCostShard","isSnow","()Z","invokevirtual",147);}
case 147:{f.Pc=f.Pop().Int!=0?235:150;continue;}
case 150:{f.Push(f.Locals[2]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/card/mana/ManaCostShard","getCmc","()I","invokevirtual",154);}
case 154:{f.Push(JValue.I(2));f.Pc=155;continue;}
case 155:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?171:158;continue;}
case 158:{f.Push(f.Locals[0]);f.Pc=159;continue;}
case 159:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","manaCost","Ljava/util/List;"));f.Pc=162;continue;}
case 162:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"));f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",170);}
case 170:{f.StackOp("pop");f.Pc=171;continue;}
case 171:{f.Push(f.Locals[0]);f.Pc=172;continue;}
case 172:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","manaPaid","Ljava/util/List;"));f.Pc=175;continue;}
case 175:{f.Push(f.Locals[3]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/util/List","remove","(I)Ljava/lang/Object;","invokeinterface",181);}
case 181:{f.StackOp("pop");f.Pc=182;continue;}
case 182:{f.Push(f.Locals[0]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[1]);f.Pc=184;continue;}
case 184:{f.Push(JValue.I(1));f.Pc=185;continue;}
case 185:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/card/CardProperty$1CheckCanPayManaCost","checkShard","(I)Z","invokevirtual",189);}
case 189:{f.Pc=f.Pop().Int==0?194:192;continue;}
case 192:{f.Push(JValue.I(1));f.Pc=193;continue;}
case 193:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 194:{f.Push(f.Locals[0]);f.Pc=195;continue;}
case 195:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","manaPaid","Ljava/util/List;"));f.Pc=198;continue;}
case 198:{f.Push(f.Locals[3]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[4]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/util/List","add","(ILjava/lang/Object;)V","invokeinterface",206);}
case 206:{f.Push(f.Locals[2]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/card/mana/ManaCostShard","getCmc","()I","invokevirtual",210);}
case 210:{f.Push(JValue.I(2));f.Pc=211;continue;}
case 211:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?235:214;continue;}
case 214:{f.Push(f.Locals[0]);f.Pc=215;continue;}
case 215:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","manaCost","Ljava/util/List;"));f.Pc=218;continue;}
case 218:{f.Push(f.Locals[0]);f.Pc=219;continue;}
case 219:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","manaCost","Ljava/util/List;"));f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",227);}
case 227:{f.Push(JValue.I(1));f.Pc=228;continue;}
case 228:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/util/List","remove","(I)Ljava/lang/Object;","invokeinterface",234);}
case 234:{f.StackOp("pop");f.Pc=235;continue;}
case 235:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=238;continue;}
case 238:{f.Pc=46;continue;}
case 241:{f.Push(JValue.I(0));f.Pc=242;continue;}
case 242:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5257(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","val$spellAbility","Lforge/game/CardTraitBase;"));f.Pc=5;continue;}
case 5:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingMana","()Ljava/util/List;","invokevirtual",11);}
case 11:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",14);}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","manaPaid","Ljava/util/List;",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","val$card","Lforge/game/card/Card;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",25);}
case 25:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",28);}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","manaCost","Ljava/util/List;",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","manaCost","Ljava/util/List;"));f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Collections","sort","(Ljava/util/List;)V","invokestatic",38);}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","val$card","Lforge/game/card/Card;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/card/mana/ManaCost","getGenericCost","()I","invokevirtual",48);}
case 48:{f.Locals[1]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Locals[1]=JValue.I(unchecked(f.Locals[1].Int+(-1)));f.Pc=53;continue;}
case 53:{f.Pc=f.Pop().Int<=0?72:56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardProperty$1CheckCanPayManaCost","manaCost","Ljava/util/List;"));f.Pc=60;continue;}
case 60:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","GENERIC","Lforge/card/mana/ManaCostShard;"));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",68);}
case 68:{f.StackOp("pop");f.Pc=69;continue;}
case 69:{f.Pc=49;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{f.Push(JValue.I(0));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/card/CardProperty$1CheckCanPayManaCost","checkShard","(I)Z","invokevirtual",77);}
case 77:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
