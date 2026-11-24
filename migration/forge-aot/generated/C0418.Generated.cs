// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C418{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/TokenEffectBase","forge/game/ability/SpellAbilityEffect",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3786,"forge/game/ability/effects/TokenEffectBase","<init>","()V",1,1,1,new JHandler[]{},M3786));
c.Add(new JMethod(3787,"forge/game/ability/effects/TokenEffectBase","createTokenTable","(Ljava/lang/Iterable;[Ljava/lang/String;ILforge/game/spellability/SpellAbility;)Lforge/game/card/TokenCreateTable;",4,13,4,new JHandler[]{},M3787));
c.Add(new JMethod(3788,"forge/game/ability/effects/TokenEffectBase","makeTokenTableInternal","(Lforge/game/player/Player;Ljava/lang/String;ILforge/game/spellability/SpellAbility;)Lforge/game/card/TokenCreateTable;",4,6,4,new JHandler[]{},M3788));
c.Add(new JMethod(3789,"forge/game/ability/effects/TokenEffectBase","makeTokenTableInternal","(Lforge/game/player/Player;Lforge/game/card/Card;I)Lforge/game/card/TokenCreateTable;",4,5,4,new JHandler[]{},M3789));
c.Add(new JMethod(3790,"forge/game/ability/effects/TokenEffectBase","makeTokenTable","(Ljava/lang/Iterable;[Ljava/lang/String;IZLforge/game/card/CardZoneTable;Lorg/apache/commons/lang3/mutable/MutableBoolean;Lforge/game/spellability/SpellAbility;)Lforge/game/card/TokenCreateTable;",4,8,6,new JHandler[]{},M3790));
c.Add(new JMethod(3791,"forge/game/ability/effects/TokenEffectBase","makeTokenTable","(Lforge/game/card/TokenCreateTable;ZLforge/game/card/CardZoneTable;Lorg/apache/commons/lang3/mutable/MutableBoolean;Lforge/game/spellability/SpellAbility;)Lforge/game/card/TokenCreateTable;",4,28,7,new JHandler[]{},M3791));
c.Add(new JMethod(3792,"forge/game/ability/effects/TokenEffectBase","attachTokenTo","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z",2,9,6,new JHandler[]{},M3792));
c.Add(new JMethod(3793,"forge/game/ability/effects/TokenEffectBase","addPumpUntil","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;J)V",9,8,6,new JHandler[]{},M3793));
c.Add(new JMethod(3794,"forge/game/ability/effects/TokenEffectBase","lambda$makeTokenTable$0","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/card/CardStateName;)V",4106,3,2,new JHandler[]{},M3794));
}

internal static JStep M3786(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3787(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/TokenCreateTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/TokenCreateTable")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/TokenCreateTable","<init>","()V","invokespecial",7);}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",15);}
case 15:{f.Locals[6]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[6]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?136:27;continue;}
case 27:{f.Push(f.Locals[6]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[7]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[7]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int!=0?50:47;continue;}
case 47:{f.Pc=17;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Locals[8]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[8]);f.Pc=55;continue;}
case 55:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=56;continue;}
case 56:{f.Locals[9]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(JValue.I(0));f.Pc=59;continue;}
case 59:{f.Locals[10]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[10]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[9]);f.Pc=65;continue;}
case 65:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?133:68;continue;}
case 68:{f.Push(f.Locals[8]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[10]);f.Pc=72;continue;}
case 72:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=73;continue;}
case 73:{f.Locals[11]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[11]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[7]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/token/TokenInfo","getProtoType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",84);}
case 84:{f.Locals[12]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[12]);f.Pc=88;continue;}
case 88:{f.Pc=f.Pop().Reference!=null?106:91;continue;}
case 91:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=94;continue;}
case 94:{f.StackOp("dup");f.Pc=95;continue;}
case 95:{f.Push(f.Locals[11]);f.Pc=97;continue;}
case 97:{return rt.DynamicCall(f,"forge/game/ability/effects/TokenEffectBase:3787:97:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",102);}
case 102:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",105);}
case 105:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 106:{f.Push(f.Locals[12]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[4]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/card/Card","setTokenSpawningAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",113);}
case 113:{f.Push(f.Locals[5]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[7]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[12]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[3]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",123);}
case 123:{return rt.Call(f,"forge/game/card/TokenCreateTable","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",126);}
case 126:{f.StackOp("pop");f.Pc=127;continue;}
case 127:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=130;continue;}
case 130:{f.Pc=61;continue;}
case 133:{f.Pc=17;continue;}
case 136:{f.Push(f.Locals[5]);f.Pc=138;continue;}
case 138:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3788(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[4]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/token/TokenInfo","getProtoType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Lforge/game/card/Card;","invokestatic",8);}
case 8:{f.Locals[5]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[5]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference!=null?29:15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.DynamicCall(f,"forge/game/ability/effects/TokenEffectBase:3788:20:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",25);}
case 25:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",28);}
case 28:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 29:{f.Push(f.Locals[5]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/Card","setTokenSpawningAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","makeTokenTableInternal","(Lforge/game/player/Player;Lforge/game/card/Card;I)Lforge/game/card/TokenCreateTable;","invokevirtual",44);}
case 44:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3789(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/TokenCreateTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/TokenCreateTable")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/TokenCreateTable","<init>","()V","invokespecial",7);}
case 7:{f.Locals[4]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[4]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",17);}
case 17:{return rt.Call(f,"forge/game/card/TokenCreateTable","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",20);}
case 20:{f.StackOp("pop");f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3790(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[7]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","createTokenTable","(Ljava/lang/Iterable;[Ljava/lang/String;ILforge/game/spellability/SpellAbility;)Lforge/game/card/TokenCreateTable;","invokevirtual",10);}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[5]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[6]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[7]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","makeTokenTable","(Lforge/game/card/TokenCreateTable;ZLforge/game/card/CardZoneTable;Lorg/apache/commons/lang3/mutable/MutableBoolean;Lforge/game/spellability/SpellAbility;)Lforge/game/card/TokenCreateTable;","invokevirtual",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3791(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[5]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",5);}
case 5:{f.Locals[6]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[6]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",12);}
case 12:{f.Locals[7]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[7]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",19);}
case 19:{f.Locals[8]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/TokenCreateTable","columnKeySet","()Ljava/util/Set;","invokevirtual",25);}
case 25:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","(Ljava/lang/Iterable;)Ljava/util/HashSet;","invokestatic",28);}
case 28:{f.Locals[10]=f.Pop();f.Pc=30;continue;}
case 30:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",33);}
case 33:{f.Locals[11]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/TokenCreateTable","rowKeySet","()Ljava/util/Set;","invokevirtual",39);}
case 39:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",42);}
case 42:{return rt.Call(f,"java/util/ArrayList","iterator","()Ljava/util/Iterator;","invokevirtual",45);}
case 45:{f.Locals[12]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[12]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",54);}
case 54:{f.Pc=f.Pop().Int==0?197:57;continue;}
case 57:{f.Push(f.Locals[12]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",64);}
case 64:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=67;continue;}
case 67:{f.Locals[13]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[13]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",74);}
case 74:{f.Locals[14]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[14]);f.Pc=78;continue;}
case 78:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Token","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Token","Lforge/game/ability/AbilityKey;"));f.Pc=81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",87);}
case 87:{f.StackOp("pop");f.Pc=88;continue;}
case 88:{f.Push(f.Locals[14]);f.Pc=90;continue;}
case 90:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=93;continue;}
case 93:{f.Push(f.Locals[5]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",100);}
case 100:{f.StackOp("pop");f.Pc=101;continue;}
case 101:{f.Push(f.Locals[14]);f.Pc=103;continue;}
case 103:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","EffectOnly","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","EffectOnly","Lforge/game/ability/AbilityKey;"));f.Pc=106;continue;}
case 106:{f.Push(JValue.I(1));f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",110);}
case 110:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",115);}
case 115:{f.StackOp("pop");f.Pc=116;continue;}
case 116:{if(!rt.StaticReady(f,"forge/game/ability/effects/TokenEffectBase$2","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/effects/TokenEffectBase$2","$SwitchMap$forge$game$replacement$ReplacementResult","[I"));f.Pc=119;continue;}
case 119:{f.Push(f.Locals[7]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",124);}
case 124:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","CreateToken","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","CreateToken","Lforge/game/replacement/ReplacementType;"));f.Pc=127;continue;}
case 127:{f.Push(f.Locals[14]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",132);}
case 132:{return rt.Call(f,"forge/game/replacement/ReplacementResult","ordinal","()I","invokevirtual",135);}
case 135:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=136;continue;}
case 136:{switch(f.Pop().Int){case 1:f.Pc=164;break;case 2:f.Pc=167;break;default:f.Pc=184;break;}continue;}
case 164:{f.Pc=194;continue;}
case 167:{f.Push(f.Locals[14]);f.Pc=169;continue;}
case 169:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Token","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Token","Lforge/game/ability/AbilityKey;"));f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",177);}
case 177:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/TokenCreateTable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=180;continue;}
case 180:{f.Locals[1]=f.Pop();f.Pc=181;continue;}
case 181:{f.Pc=194;continue;}
case 184:{f.Push(f.Locals[11]);f.Pc=186;continue;}
case 186:{f.Push(f.Locals[13]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",193);}
case 193:{f.StackOp("pop");f.Pc=194;continue;}
case 194:{f.Pc=47;continue;}
case 197:{f.Push(f.Locals[1]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/card/TokenCreateTable","rowKeySet","()Ljava/util/Set;","invokevirtual",201);}
case 201:{f.Push(f.Locals[11]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/util/Set","removeAll","(Ljava/util/Collection;)Z","invokeinterface",208);}
case 208:{f.StackOp("pop");f.Pc=209;continue;}
case 209:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",212);}
case 212:{f.Locals[12]=f.Pop();f.Pc=214;continue;}
case 214:{f.Push(f.Locals[5]);f.Pc=216;continue;}
case 216:{f.Push(JValue.R(rt.String("PumpKeywords")));f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",221);}
case 221:{f.Pc=f.Pop().Int==0?247:224;continue;}
case 224:{f.Push(f.Locals[12]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[5]);f.Pc=228;continue;}
case 228:{f.Push(JValue.R(rt.String("PumpKeywords")));f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",233);}
case 233:{f.Push(JValue.R(rt.String(" & ")));f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",238);}
case 238:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",241);}
case 241:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",246);}
case 246:{f.StackOp("pop");f.Pc=247;continue;}
case 247:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",250);}
case 250:{f.Locals[13]=f.Pop();f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",255);}
case 255:{f.Locals[14]=f.Pop();f.Pc=257;continue;}
case 257:{f.Push(f.Locals[14]);f.Pc=259;continue;}
case 259:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=262;continue;}
case 262:{f.Push(f.Locals[7]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/Game","copyLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",267);}
case 267:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",272);}
case 272:{f.StackOp("pop");f.Pc=273;continue;}
case 273:{f.Push(f.Locals[14]);f.Pc=275;continue;}
case 275:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=278;continue;}
case 278:{f.Push(f.Locals[7]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/Game","copyLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",283);}
case 283:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",288);}
case 288:{f.StackOp("pop");f.Pc=289;continue;}
case 289:{f.Push(f.Locals[1]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/card/TokenCreateTable","cellSet","()Ljava/util/Set;","invokevirtual",293);}
case 293:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",298);}
case 298:{f.Locals[15]=f.Pop();f.Pc=300;continue;}
case 300:{f.Push(f.Locals[15]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",307);}
case 307:{f.Pc=f.Pop().Int==0?1114:310;continue;}
case 310:{f.Push(f.Locals[15]);f.Pc=312;continue;}
case 312:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",317);}
case 317:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Table$Cell"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=320;continue;}
case 320:{f.Locals[16]=f.Pop();f.Pc=322;continue;}
case 322:{f.Push(f.Locals[16]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"com/google/common/collect/Table$Cell","getColumnKey","()Ljava/lang/Object;","invokeinterface",329);}
case 329:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=332;continue;}
case 332:{f.Locals[17]=f.Pop();f.Pc=334;continue;}
case 334:{f.Push(f.Locals[16]);f.Pc=336;continue;}
case 336:{return rt.Call(f,"com/google/common/collect/Table$Cell","getRowKey","()Ljava/lang/Object;","invokeinterface",341);}
case 341:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=344;continue;}
case 344:{f.Locals[18]=f.Pop();f.Pc=346;continue;}
case 346:{f.Push(f.Locals[17]);f.Pc=348;continue;}
case 348:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",351);}
case 351:{f.Locals[19]=f.Pop();f.Pc=353;continue;}
case 353:{f.Push(f.Locals[16]);f.Pc=355;continue;}
case 355:{return rt.Call(f,"com/google/common/collect/Table$Cell","getValue","()Ljava/lang/Object;","invokeinterface",360);}
case 360:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=363;continue;}
case 363:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",366);}
case 366:{f.Locals[20]=f.Pop();f.Pc=368;continue;}
case 368:{f.Push(JValue.I(0));f.Pc=369;continue;}
case 369:{f.Locals[21]=f.Pop();f.Pc=371;continue;}
case 371:{f.Push(f.Locals[21]);f.Pc=373;continue;}
case 373:{f.Push(f.Locals[20]);f.Pc=375;continue;}
case 375:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1111:378;continue;}
case 378:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCopyService"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCopyService")));f.Pc=381;continue;}
case 381:{f.StackOp("dup");f.Pc=382;continue;}
case 382:{f.Push(f.Locals[17]);f.Pc=384;continue;}
case 384:{return rt.Call(f,"forge/game/card/CardCopyService","<init>","(Lforge/game/card/Card;)V","invokespecial",387);}
case 387:{f.Push(JValue.I(1));f.Pc=388;continue;}
case 388:{return rt.Call(f,"forge/game/card/CardCopyService","copyCard","(Z)Lforge/game/card/Card;","invokevirtual",391);}
case 391:{f.Locals[22]=f.Pop();f.Pc=393;continue;}
case 393:{f.Push(f.Locals[22]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/game/card/Card","getStates","()Ljava/util/Set;","invokevirtual",398);}
case 398:{f.Push(f.Locals[22]);f.Pc=400;continue;}
case 400:{f.Push(f.Locals[17]);f.Pc=402;continue;}
case 402:{return rt.DynamicCall(f,"forge/game/ability/effects/TokenEffectBase:3791:402:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;Lforge/game/card/Card;)Ljava/util/function/Consumer;",407);}
case 407:{return rt.Call(f,"java/util/Set","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",412);}
case 412:{f.Push(f.Locals[22]);f.Pc=414;continue;}
case 414:{f.Push(f.Locals[18]);f.Pc=416;continue;}
case 416:{return rt.Call(f,"forge/game/card/Card","setOwner","(Lforge/game/player/Player;)V","invokevirtual",419);}
case 419:{f.Push(f.Locals[18]);f.Pc=421;continue;}
case 421:{f.Push(f.Locals[19]);f.Pc=423;continue;}
case 423:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?435:426;continue;}
case 426:{f.Push(f.Locals[22]);f.Pc=428;continue;}
case 428:{f.Push(f.Locals[19]);f.Pc=430;continue;}
case 430:{f.Push(f.Locals[8]);f.Pc=432;continue;}
case 432:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",435);}
case 435:{f.Push(f.Locals[22]);f.Pc=437;continue;}
case 437:{f.Push(f.Locals[8]);f.Pc=439;continue;}
case 439:{return rt.Call(f,"forge/game/card/Card","setGameTimestamp","(J)V","invokevirtual",442);}
case 442:{f.Push(f.Locals[22]);f.Pc=444;continue;}
case 444:{if(!rt.StaticReady(f,"forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"));f.Pc=447;continue;}
case 447:{return rt.Call(f,"forge/game/card/Card","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",450);}
case 450:{f.Push(f.Locals[5]);f.Pc=452;continue;}
case 452:{f.Push(JValue.R(rt.String("TokenTapped")));f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",458);}
case 458:{f.Pc=f.Pop().Int==0?467:461;continue;}
case 461:{f.Push(f.Locals[22]);f.Pc=463;continue;}
case 463:{f.Push(JValue.I(1));f.Pc=464;continue;}
case 464:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",467);}
case 467:{f.Push(f.Locals[5]);f.Pc=469;continue;}
case 469:{f.Push(JValue.R(rt.String("AttachAfter")));f.Pc=472;continue;}
case 472:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",475);}
case 475:{f.Pc=f.Pop().Int!=0?511:478;continue;}
case 478:{f.Push(f.Locals[5]);f.Pc=480;continue;}
case 480:{f.Push(JValue.R(rt.String("AttachedTo")));f.Pc=483;continue;}
case 483:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",486);}
case 486:{f.Pc=f.Pop().Int==0?511:489;continue;}
case 489:{f.Push(f.Locals[0]);f.Pc=490;continue;}
case 490:{f.Push(f.Locals[22]);f.Pc=492;continue;}
case 492:{f.Push(f.Locals[5]);f.Pc=494;continue;}
case 494:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","attachTokenTo","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",497);}
case 497:{f.Pc=f.Pop().Int!=0?511:500;continue;}
case 500:{f.Push(f.Locals[22]);f.Pc=502;continue;}
case 502:{return rt.Call(f,"forge/game/card/Card","isAura","()Z","invokevirtual",505);}
case 505:{f.Pc=f.Pop().Int==0?511:508;continue;}
case 508:{f.Pc=1105;continue;}
case 511:{f.Push(f.Locals[5]);f.Pc=513;continue;}
case 513:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=516;continue;}
case 516:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",519);}
case 519:{f.Pc=f.Pop().Int==0?591:522;continue;}
case 522:{f.Push(f.Locals[5]);f.Pc=524;continue;}
case 524:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=527;continue;}
case 527:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",530);}
case 530:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",533);}
case 533:{f.Locals[23]=f.Pop();f.Pc=535;continue;}
case 535:{f.Push(f.Locals[6]);f.Pc=537;continue;}
case 537:{f.Push(f.Locals[5]);f.Pc=539;continue;}
case 539:{f.Push(JValue.R(rt.String("WithCountersAmount")));f.Pc=542;continue;}
case 542:{f.Push(JValue.R(rt.String("1")));f.Pc=545;continue;}
case 545:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",548);}
case 548:{f.Push(f.Locals[5]);f.Pc=550;continue;}
case 550:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",553);}
case 553:{f.Locals[24]=f.Pop();f.Pc=555;continue;}
case 555:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=558;continue;}
case 558:{f.StackOp("dup");f.Pc=559;continue;}
case 559:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",562);}
case 562:{f.Locals[25]=f.Pop();f.Pc=564;continue;}
case 564:{f.Push(f.Locals[25]);f.Pc=566;continue;}
case 566:{f.Push(f.Locals[18]);f.Pc=568;continue;}
case 568:{f.Push(f.Locals[22]);f.Pc=570;continue;}
case 570:{f.Push(f.Locals[23]);f.Pc=572;continue;}
case 572:{f.Push(f.Locals[24]);f.Pc=574;continue;}
case 574:{return rt.Call(f,"forge/game/GameEntityCounterTable","put","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)I","invokevirtual",577);}
case 577:{f.StackOp("pop");f.Pc=578;continue;}
case 578:{f.Push(f.Locals[14]);f.Pc=580;continue;}
case 580:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"));f.Pc=583;continue;}
case 583:{f.Push(f.Locals[25]);f.Pc=585;continue;}
case 585:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",590);}
case 590:{f.StackOp("pop");f.Pc=591;continue;}
case 591:{f.Push(f.Locals[5]);f.Pc=593;continue;}
case 593:{f.Push(JValue.R(rt.String("AddTriggersFrom")));f.Pc=596;continue;}
case 596:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",599);}
case 599:{f.Pc=f.Pop().Int==0?704:602;continue;}
case 602:{f.Push(f.Locals[6]);f.Pc=604;continue;}
case 604:{f.Push(f.Locals[5]);f.Pc=606;continue;}
case 606:{f.Push(JValue.R(rt.String("AddTriggersFrom")));f.Pc=609;continue;}
case 609:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",612);}
case 612:{f.Push(f.Locals[5]);f.Pc=614;continue;}
case 614:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",617);}
case 617:{f.Locals[23]=f.Pop();f.Pc=619;continue;}
case 619:{f.Push(f.Locals[23]);f.Pc=621;continue;}
case 621:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",626);}
case 626:{f.Locals[24]=f.Pop();f.Pc=628;continue;}
case 628:{f.Push(f.Locals[24]);f.Pc=630;continue;}
case 630:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",635);}
case 635:{f.Pc=f.Pop().Int==0?704:638;continue;}
case 638:{f.Push(f.Locals[24]);f.Pc=640;continue;}
case 640:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",645);}
case 645:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=648;continue;}
case 648:{f.Locals[25]=f.Pop();f.Pc=650;continue;}
case 650:{f.Push(f.Locals[25]);f.Pc=652;continue;}
case 652:{return rt.Call(f,"forge/game/card/Card","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",655);}
case 655:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",660);}
case 660:{f.Locals[26]=f.Pop();f.Pc=662;continue;}
case 662:{f.Push(f.Locals[26]);f.Pc=664;continue;}
case 664:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",669);}
case 669:{f.Pc=f.Pop().Int==0?701:672;continue;}
case 672:{f.Push(f.Locals[26]);f.Pc=674;continue;}
case 674:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",679);}
case 679:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=682;continue;}
case 682:{f.Locals[27]=f.Pop();f.Pc=684;continue;}
case 684:{f.Push(f.Locals[22]);f.Pc=686;continue;}
case 686:{f.Push(f.Locals[27]);f.Pc=688;continue;}
case 688:{f.Push(f.Locals[22]);f.Pc=690;continue;}
case 690:{f.Push(JValue.I(0));f.Pc=691;continue;}
case 691:{return rt.Call(f,"forge/game/trigger/Trigger","copy","(Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokevirtual",694);}
case 694:{return rt.Call(f,"forge/game/card/Card","addTrigger","(Lforge/game/trigger/Trigger;)Lforge/game/trigger/Trigger;","invokevirtual",697);}
case 697:{f.StackOp("pop");f.Pc=698;continue;}
case 698:{f.Pc=662;continue;}
case 701:{f.Pc=628;continue;}
case 704:{f.Push(f.Locals[2]);f.Pc=705;continue;}
case 705:{f.Pc=f.Pop().Int!=0?716:708;continue;}
case 708:{f.Push(f.Locals[17]);f.Pc=710;continue;}
case 710:{return rt.Call(f,"forge/game/card/Card","getCopiedPermanent","()Lforge/game/card/Card;","invokevirtual",713);}
case 713:{f.Pc=f.Pop().Reference==null?723:716;continue;}
case 716:{f.Push(f.Locals[22]);f.Pc=718;continue;}
case 718:{f.Push(f.Locals[17]);f.Pc=720;continue;}
case 720:{return rt.Call(f,"forge/game/card/Card","setCopiedPermanent","(Lforge/game/card/Card;)V","invokevirtual",723);}
case 723:{f.Push(f.Locals[22]);f.Pc=725;continue;}
case 725:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",728);}
case 728:{f.Locals[23]=f.Pop();f.Pc=730;continue;}
case 730:{f.Push(f.Locals[14]);f.Pc=732;continue;}
case 732:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CardLKI","Lforge/game/ability/AbilityKey;"));f.Pc=735;continue;}
case 735:{f.Push(f.Locals[23]);f.Pc=737;continue;}
case 737:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",742);}
case 742:{f.StackOp("pop");f.Pc=743;continue;}
case 743:{f.Push(f.Locals[7]);f.Pc=745;continue;}
case 745:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",748);}
case 748:{f.Push(f.Locals[22]);f.Pc=750;continue;}
case 750:{f.Push(f.Locals[5]);f.Pc=752;continue;}
case 752:{f.Push(f.Locals[14]);f.Pc=754;continue;}
case 754:{return rt.Call(f,"forge/game/GameAction","moveToPlay","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",757);}
case 757:{f.Locals[24]=f.Pop();f.Pc=759;continue;}
case 759:{f.Push(f.Locals[24]);f.Pc=761;continue;}
case 761:{f.Pc=f.Pop().Reference==null?772:764;continue;}
case 764:{f.Push(f.Locals[24]);f.Pc=766;continue;}
case 766:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",769);}
case 769:{f.Pc=f.Pop().Reference!=null?788:772;continue;}
case 772:{f.Push(f.Locals[3]);f.Pc=773;continue;}
case 773:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=776;continue;}
case 776:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=779;continue;}
case 779:{f.Push(f.Locals[24]);f.Pc=781;continue;}
case 781:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",784);}
case 784:{f.StackOp("pop");f.Pc=785;continue;}
case 785:{f.Pc=1105;continue;}
case 788:{f.Push(f.Locals[3]);f.Pc=789;continue;}
case 789:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=792;continue;}
case 792:{f.Push(f.Locals[24]);f.Pc=794;continue;}
case 794:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",797);}
case 797:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",800);}
case 800:{f.Push(f.Locals[24]);f.Pc=802;continue;}
case 802:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",805);}
case 805:{f.StackOp("pop");f.Pc=806;continue;}
case 806:{f.Push(f.Locals[3]);f.Pc=807;continue;}
case 807:{f.Push(f.Locals[23]);f.Pc=809;continue;}
case 809:{f.Push(f.Locals[18]);f.Pc=811;continue;}
case 811:{return rt.Call(f,"forge/game/player/Player","getNumTokenCreatedThisTurn","()I","invokevirtual",814);}
case 814:{f.Pc=f.Pop().Int!=0?821:817;continue;}
case 817:{f.Push(JValue.I(1));f.Pc=818;continue;}
case 818:{f.Pc=822;continue;}
case 821:{f.Push(JValue.I(0));f.Pc=822;continue;}
case 822:{return rt.Call(f,"forge/game/card/CardZoneTable","addToken","(Lforge/game/card/Card;Z)V","invokevirtual",825);}
case 825:{f.Push(f.Locals[18]);f.Pc=827;continue;}
case 827:{f.Push(f.Locals[23]);f.Pc=829;continue;}
case 829:{return rt.Call(f,"forge/game/player/Player","addTokensCreatedThisTurn","(Lforge/game/card/Card;)V","invokevirtual",832);}
case 832:{f.Push(f.Locals[2]);f.Pc=833;continue;}
case 833:{f.Pc=f.Pop().Int==0?843:836;continue;}
case 836:{f.Push(f.Locals[24]);f.Pc=838;continue;}
case 838:{f.Push(f.Locals[6]);f.Pc=840;continue;}
case 840:{return rt.Call(f,"forge/game/card/Card","setCloneOrigin","(Lforge/game/card/Card;)V","invokevirtual",843);}
case 843:{f.Push(f.Locals[12]);f.Pc=845;continue;}
case 845:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",850);}
case 850:{f.Pc=f.Pop().Int!=0?876:853;continue;}
case 853:{f.Push(f.Locals[24]);f.Pc=855;continue;}
case 855:{f.Push(f.Locals[12]);f.Pc=857;continue;}
case 857:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",860);}
case 860:{f.Push(JValue.I(0));f.Pc=861;continue;}
case 861:{f.Push(f.Locals[8]);f.Pc=863;continue;}
case 863:{f.Push(JValue.R(null));f.Pc=864;continue;}
case 864:{return rt.Call(f,"forge/game/card/Card","addChangedCardKeywords","(Ljava/util/List;Ljava/util/List;ZJLforge/game/staticability/StaticAbility;)V","invokevirtual",867);}
case 867:{f.Push(f.Locals[5]);f.Pc=869;continue;}
case 869:{f.Push(f.Locals[24]);f.Pc=871;continue;}
case 871:{f.Push(f.Locals[8]);f.Pc=873;continue;}
case 873:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","addPumpUntil","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;J)V","invokestatic",876);}
case 876:{f.Push(f.Locals[5]);f.Pc=878;continue;}
case 878:{f.Push(JValue.R(rt.String("AtEOTTrig")));f.Pc=881;continue;}
case 881:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",884);}
case 884:{f.Pc=f.Pop().Int==0?902:887;continue;}
case 887:{f.Push(f.Locals[5]);f.Pc=889;continue;}
case 889:{f.Push(f.Locals[5]);f.Pc=891;continue;}
case 891:{f.Push(JValue.R(rt.String("AtEOTTrig")));f.Pc=894;continue;}
case 894:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",897);}
case 897:{f.Push(f.Locals[24]);f.Pc=899;continue;}
case 899:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","addSelfTrigger","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/card/Card;)V","invokestatic",902);}
case 902:{f.Push(f.Locals[24]);f.Pc=904;continue;}
case 904:{f.Push(f.Locals[5]);f.Pc=906;continue;}
case 906:{f.Push(JValue.R(rt.String("TokenAttacking")));f.Pc=909;continue;}
case 909:{f.Push(JValue.R(rt.String("TokenBlocking")));f.Pc=912;continue;}
case 912:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","addToCombat","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/String;)Z","invokestatic",915);}
case 915:{f.Pc=f.Pop().Int==0?923:918;continue;}
case 918:{f.Push(f.Locals[4]);f.Pc=920;continue;}
case 920:{return rt.Call(f,"org/apache/commons/lang3/mutable/MutableBoolean","setTrue","()V","invokevirtual",923);}
case 923:{f.Push(f.Locals[5]);f.Pc=925;continue;}
case 925:{f.Push(JValue.R(rt.String("AttachAfter")));f.Pc=928;continue;}
case 928:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",931);}
case 931:{f.Pc=f.Pop().Int==0?954:934;continue;}
case 934:{f.Push(f.Locals[5]);f.Pc=936;continue;}
case 936:{f.Push(JValue.R(rt.String("AttachedTo")));f.Pc=939;continue;}
case 939:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",942);}
case 942:{f.Pc=f.Pop().Int==0?954:945;continue;}
case 945:{f.Push(f.Locals[0]);f.Pc=946;continue;}
case 946:{f.Push(f.Locals[22]);f.Pc=948;continue;}
case 948:{f.Push(f.Locals[5]);f.Pc=950;continue;}
case 950:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","attachTokenTo","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",953);}
case 953:{f.StackOp("pop");f.Pc=954;continue;}
case 954:{f.Push(f.Locals[24]);f.Pc=956;continue;}
case 956:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",959);}
case 959:{f.Push(f.Locals[5]);f.Pc=961;continue;}
case 961:{f.Push(JValue.R(rt.String("RememberTokens")));f.Pc=964;continue;}
case 964:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",967);}
case 967:{f.Pc=f.Pop().Int==0?977:970;continue;}
case 970:{f.Push(f.Locals[6]);f.Pc=972;continue;}
case 972:{f.Push(f.Locals[24]);f.Pc=974;continue;}
case 974:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",977);}
case 977:{f.Push(f.Locals[5]);f.Pc=979;continue;}
case 979:{f.Push(JValue.R(rt.String("RememberOriginalTokens")));f.Pc=982;continue;}
case 982:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",985);}
case 985:{f.Pc=f.Pop().Int==0?1007:988;continue;}
case 988:{f.Push(f.Locals[10]);f.Pc=990;continue;}
case 990:{f.Push(f.Locals[17]);f.Pc=992;continue;}
case 992:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",997);}
case 997:{f.Pc=f.Pop().Int==0?1007:1000;continue;}
case 1000:{f.Push(f.Locals[6]);f.Pc=1002;continue;}
case 1002:{f.Push(f.Locals[24]);f.Pc=1004;continue;}
case 1004:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1007);}
case 1007:{f.Push(f.Locals[5]);f.Pc=1009;continue;}
case 1009:{f.Push(JValue.R(rt.String("ImprintTokens")));f.Pc=1012;continue;}
case 1012:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1015);}
case 1015:{f.Pc=f.Pop().Int==0?1025:1018;continue;}
case 1018:{f.Push(f.Locals[6]);f.Pc=1020;continue;}
case 1020:{f.Push(f.Locals[24]);f.Pc=1022;continue;}
case 1022:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",1025);}
case 1025:{f.Push(f.Locals[5]);f.Pc=1027;continue;}
case 1027:{f.Push(JValue.R(rt.String("RememberSource")));f.Pc=1030;continue;}
case 1030:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1033);}
case 1033:{f.Pc=f.Pop().Int==0?1043:1036;continue;}
case 1036:{f.Push(f.Locals[24]);f.Pc=1038;continue;}
case 1038:{f.Push(f.Locals[6]);f.Pc=1040;continue;}
case 1040:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1043);}
case 1043:{f.Push(f.Locals[5]);f.Pc=1045;continue;}
case 1045:{f.Push(JValue.R(rt.String("TokenRemembered")));f.Pc=1048;continue;}
case 1048:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1051);}
case 1051:{f.Pc=f.Pop().Int==0?1074:1054;continue;}
case 1054:{f.Push(f.Locals[24]);f.Pc=1056;continue;}
case 1056:{f.Push(f.Locals[6]);f.Pc=1058;continue;}
case 1058:{f.Push(f.Locals[5]);f.Pc=1060;continue;}
case 1060:{f.Push(JValue.R(rt.String("TokenRemembered")));f.Pc=1063;continue;}
case 1063:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1066);}
case 1066:{f.Push(f.Locals[5]);f.Pc=1068;continue;}
case 1068:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedObjects","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",1071);}
case 1071:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1074);}
case 1074:{f.Push(f.Locals[13]);f.Pc=1076;continue;}
case 1076:{f.Push(f.Locals[24]);f.Pc=1078;continue;}
case 1078:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1083);}
case 1083:{f.StackOp("pop");f.Pc=1084;continue;}
case 1084:{f.Push(f.Locals[5]);f.Pc=1086;continue;}
case 1086:{f.Push(JValue.R(rt.String("CleanupForEach")));f.Pc=1089;continue;}
case 1089:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1092);}
case 1092:{f.Pc=f.Pop().Int==0?1105:1095;continue;}
case 1095:{f.Push(f.Locals[24]);f.Pc=1097;continue;}
case 1097:{f.Push(f.Locals[17]);f.Pc=1099;continue;}
case 1099:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",1102);}
case 1102:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1105);}
case 1105:{f.Locals[21]=JValue.I(unchecked(f.Locals[21].Int+(1)));f.Pc=1108;continue;}
case 1108:{f.Pc=371;continue;}
case 1111:{f.Pc=300;continue;}
case 1114:{f.Push(f.Locals[5]);f.Pc=1116;continue;}
case 1116:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=1119;continue;}
case 1119:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1122);}
case 1122:{f.Pc=f.Pop().Int==0?1140:1125;continue;}
case 1125:{f.Push(f.Locals[5]);f.Pc=1127;continue;}
case 1127:{f.Push(f.Locals[5]);f.Pc=1129;continue;}
case 1129:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=1132;continue;}
case 1132:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1135);}
case 1135:{f.Push(f.Locals[13]);f.Pc=1137;continue;}
case 1137:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","registerDelayedTrigger","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/Iterable;)V","invokestatic",1140);}
case 1140:{f.Push(f.Locals[1]);f.Pc=1141;continue;}
case 1141:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3792(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("AttachedTo")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedEntities","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",23);}
case 23:{f.Push(JValue.R(null));f.Pc=24;continue;}
case 24:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[5]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{f.Pc=f.Pop().Reference==null?167:37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",41);}
case 41:{f.Locals[6]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[6]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",49);}
case 49:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",55);}
case 55:{return rt.Call(f,"forge/game/card/Card","setLastKnownZone","(Lforge/game/zone/Zone;)V","invokevirtual",58);}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",63);}
case 63:{return rt.Call(f,"forge/trackable/Tracker","freeze","()V","invokevirtual",66);}
case 66:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(f.Locals[6]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",75);}
case 75:{f.Locals[7]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",82);}
case 82:{f.Push(JValue.I(0));f.Pc=83;continue;}
case 83:{f.Push(JValue.I(1));f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=87;continue;}
case 87:{f.StackOp("dup");f.Pc=88;continue;}
case 88:{f.Push(JValue.I(0));f.Pc=89;continue;}
case 89:{f.Push(f.Locals[6]);f.Pc=91;continue;}
case 91:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=92;continue;}
case 92:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","([Ljava/lang/Object;)Ljava/util/HashSet;","invokestatic",95);}
case 95:{f.Push(f.Locals[7]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(ZLjava/util/Set;Lforge/game/card/CardCollectionView;)V","invokevirtual",100);}
case 100:{f.Push(f.Locals[6]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/card/Card","isAttachment","()Z","invokevirtual",105);}
case 105:{f.Locals[8]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[8]);f.Pc=109;continue;}
case 109:{f.Pc=f.Pop().Int==0?126:112;continue;}
case 112:{f.Push(f.Locals[5]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[6]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[2]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/GameEntity","canBeAttached","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int!=0?126:123;continue;}
case 123:{f.Push(JValue.I(0));f.Pc=124;continue;}
case 124:{f.Locals[8]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[4]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",131);}
case 131:{f.Push(JValue.I(0));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","(Z)V","invokevirtual",135);}
case 135:{f.Push(f.Locals[4]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",140);}
case 140:{return rt.Call(f,"forge/trackable/Tracker","clearDelayed","()V","invokevirtual",143);}
case 143:{f.Push(f.Locals[4]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",148);}
case 148:{return rt.Call(f,"forge/trackable/Tracker","unfreeze","()V","invokevirtual",151);}
case 151:{f.Push(f.Locals[8]);f.Pc=153;continue;}
case 153:{f.Pc=f.Pop().Int!=0?158:156;continue;}
case 156:{f.Push(JValue.I(0));f.Pc=157;continue;}
case 157:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 158:{f.Push(f.Locals[1]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[5]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[2]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/card/Card","attachToEntity","(Lforge/game/GameEntity;Lforge/game/spellability/SpellAbility;)V","invokevirtual",165);}
case 165:{f.Push(JValue.I(1));f.Pc=166;continue;}
case 166:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 167:{f.Push(JValue.I(0));f.Pc=168;continue;}
case 168:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3793(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("PumpDuration")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?11:10;continue;}
case 10:{return JStep.ReturnVoid;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("PumpDuration")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",24);}
case 24:{f.Locals[5]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",31);}
case 31:{f.Locals[6]=f.Pop();f.Pc=33;continue;}
case 33:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/TokenEffectBase$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/TokenEffectBase$1")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[6]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase$1","<init>","(Lforge/game/card/Card;JLforge/game/Game;)V","invokespecial",44);}
case 44:{f.Locals[7]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("UntilYourNextTurn")));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int==0?74:57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/Game","getCleanup","()Lforge/game/phase/Phase;","invokevirtual",62);}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",66);}
case 66:{f.Push(f.Locals[7]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/game/player/Player;Lforge/GameCommand;)V","invokevirtual",71);}
case 71:{f.Pc=84;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",79);}
case 79:{f.Push(f.Locals[7]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",84);}
case 84:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3794(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","getState","(Lforge/card/CardStateName;)Lforge/game/card/CardState;","invokevirtual",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardState","resetOriginalHost","(Lforge/game/card/Card;)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
