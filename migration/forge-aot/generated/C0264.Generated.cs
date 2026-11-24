// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C264{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/CountersMultiplyEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3248,"forge/game/ability/effects/CountersMultiplyEffect","<init>","()V",1,1,1,new JHandler[]{},M3248));
c.Add(new JMethod(3249,"forge/game/ability/effects/CountersMultiplyEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,2,new JHandler[]{},M3249));
c.Add(new JMethod(3250,"forge/game/ability/effects/CountersMultiplyEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,12,5,new JHandler[]{},M3250));
c.Add(new JMethod(3251,"forge/game/ability/effects/CountersMultiplyEffect","getCounterType","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CounterType;",2,3,2,new JHandler[]{new JHandler(9,18,19,"java/lang/Exception")},M3251));
}

internal static JStep M3248(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3249(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/effects/CountersMultiplyEffect","getCounterType","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CounterType;","invokevirtual",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("Double the number of ")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",20);}
case 20:{f.StackOp("pop");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Reference==null?46:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",32);}
case 32:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String(" counters")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{f.Pc=53;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("each kind of counter")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String(" on ")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/ability/effects/CountersMultiplyEffect","getTargetEntities","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",65);}
case 65:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",68);}
case 68:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",71);}
case 71:{f.StackOp("pop");f.Pc=72;continue;}
case 72:{f.Push(f.Locals[2]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String(".")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",83);}
case 83:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3250(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/ability/effects/CountersMultiplyEffect","getCounterType","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CounterType;","invokevirtual",21);}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Multiplier")));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("2")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",31);}
case 31:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",34);}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=36;continue;}
case 36:{f.Locals[6]=f.Pop();f.Pc=38;continue;}
case 38:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",45);}
case 45:{f.Locals[7]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/ability/effects/CountersMultiplyEffect","getTargetEntities","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",51);}
case 51:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",56);}
case 56:{f.Locals[8]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[8]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int==0?228:68;continue;}
case 68:{f.Push(f.Locals[8]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",75);}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{f.Locals[9]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[9]);f.Pc=82;continue;}
case 82:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=85;continue;}
case 85:{f.Pc=f.Pop().Int==0?125:88;continue;}
case 88:{f.Push(f.Locals[3]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[9]);f.Pc=91;continue;}
case 91:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(null));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",98);}
case 98:{f.Locals[10]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[10]);f.Pc=102;continue;}
case 102:{f.Pc=f.Pop().Reference==null?58:105;continue;}
case 105:{f.Push(f.Locals[9]);f.Pc=107;continue;}
case 107:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[10]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",115);}
case 115:{f.Pc=f.Pop().Int!=0?121:118;continue;}
case 118:{f.Pc=58;continue;}
case 121:{f.Push(f.Locals[10]);f.Pc=123;continue;}
case 123:{f.Locals[9]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[5]);f.Pc=127;continue;}
case 127:{f.Pc=f.Pop().Reference==null?154:130;continue;}
case 130:{f.Push(f.Locals[9]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[5]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[9]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[5]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/GameEntity","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",141);}
case 141:{f.Push(f.Locals[6]);f.Pc=143;continue;}
case 143:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=144;continue;}
case 144:{f.Push(f.Locals[4]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[7]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/GameEntity","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",151);}
case 151:{f.Pc=225;continue;}
case 154:{f.Push(f.Locals[9]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/GameEntity","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",159);}
case 159:{return rt.Call(f,"com/google/common/collect/Multiset","entrySet","()Ljava/util/Set;","invokeinterface",164);}
case 164:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",169);}
case 169:{f.Locals[10]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[10]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",178);}
case 178:{f.Pc=f.Pop().Int==0?225:181;continue;}
case 181:{f.Push(f.Locals[10]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",188);}
case 188:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=191;continue;}
case 191:{f.Locals[11]=f.Pop();f.Pc=193;continue;}
case 193:{f.Push(f.Locals[9]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[11]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;","invokeinterface",202);}
case 202:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=205;continue;}
case 205:{f.Push(f.Locals[11]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getCount","()I","invokeinterface",212);}
case 212:{f.Push(f.Locals[6]);f.Pc=214;continue;}
case 214:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=215;continue;}
case 215:{f.Push(f.Locals[4]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[7]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/GameEntity","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",222);}
case 222:{f.Pc=171;continue;}
case 225:{f.Pc=58;continue;}
case 228:{f.Push(f.Locals[7]);f.Pc=230;continue;}
case 230:{f.Push(f.Locals[3]);f.Pc=231;continue;}
case 231:{f.Push(f.Locals[1]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",235);}
case 235:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3251(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?30:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",18);}
case 18:{return JStep.Return(f.Pop());}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("Counter type doesn't match, nor does an SVar exist with the type name.")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",28);}
case 28:{f.Push(JValue.R(null));f.Pc=29;continue;}
case 29:{return JStep.Return(f.Pop());}
case 30:{f.Push(JValue.R(null));f.Pc=31;continue;}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
