// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C508{
internal static JClass Build(){var c=new JClass("forge/game/combat/AttackRequirement","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("defenderSpecific","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("causesToAttack","Lcom/google/common/collect/Multimap;",false,JValue.Default("Lcom/google/common/collect/Multimap;"),null));
c.Add(new JField("attacker","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JMethod(5994,"forge/game/combat/AttackRequirement","<init>","(Lforge/game/card/Card;Lcom/google/common/collect/Multimap;Lforge/util/collect/FCollectionView;)V",1,13,4,new JHandler[]{},M5994));
c.Add(new JMethod(5995,"forge/game/combat/AttackRequirement","getAttacker","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M5995));
c.Add(new JMethod(5996,"forge/game/combat/AttackRequirement","hasRequirement","()Z",1,1,2,new JHandler[]{},M5996));
c.Add(new JMethod(5997,"forge/game/combat/AttackRequirement","getCausesToAttack","()Lcom/google/common/collect/Multimap;",17,1,1,new JHandler[]{},M5997));
c.Add(new JMethod(5998,"forge/game/combat/AttackRequirement","countViolations","(Lforge/game/GameEntity;Ljava/util/Map;)I",1,10,4,new JHandler[]{},M5998));
c.Add(new JMethod(5999,"forge/game/combat/AttackRequirement","getSortedRequirements","()Ljava/util/List;",1,4,3,new JHandler[]{},M5999));
c.Add(new JMethod(6000,"forge/game/combat/AttackRequirement","lambda$hasRequirement$0","(Ljava/lang/Integer;)Z",4106,1,1,new JHandler[]{},M6000));
}

internal static JStep M5994(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/LinkedHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/LinkedHashMap")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/LinkedHashMap","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackRequirement","defenderSpecific","Ljava/util/Map;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackRequirement","attacker","Lforge/game/card/Card;",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackRequirement","causesToAttack","Lcom/google/common/collect/Multimap;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",29);}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{f.Locals[5]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/Card","isGoaded","()Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?53:41;continue;}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/Card","getGoaded","()Lforge/game/player/PlayerCollection;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",50);}
case 50:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=51;continue;}
case 51:{f.Locals[5]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/staticability/StaticAbilityMustAttack","entitiesMustAttack","(Lforge/game/card/Card;)Ljava/util/List;","invokestatic",57);}
case 57:{f.Locals[6]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[6]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",66);}
case 66:{f.Locals[7]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[7]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",75);}
case 75:{f.Pc=f.Pop().Int==0?129:78;continue;}
case 78:{f.Push(f.Locals[7]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",85);}
case 85:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=88;continue;}
case 88:{f.Locals[8]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[8]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/GameEntity","equals","(Ljava/lang/Object;)Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int==0?105:99;continue;}
case 99:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=102;continue;}
case 102:{f.Pc=126;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRequirement","defenderSpecific","Ljava/util/Map;"));f.Pc=109;continue;}
case 109:{f.Push(f.Locals[8]);f.Pc=111;continue;}
case 111:{f.Push(JValue.I(1));f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",115);}
case 115:{return rt.DynamicCall(f,"forge/game/combat/AttackRequirement:5994:115:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BiFunction;",120);}
case 120:{return rt.Call(f,"java/util/Map","merge","(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;","invokeinterface",125);}
case 125:{f.StackOp("pop");f.Pc=126;continue;}
case 126:{f.Pc=68;continue;}
case 129:{f.Push(f.Locals[3]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",135);}
case 135:{f.Locals[7]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[7]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",144);}
case 144:{f.Pc=f.Pop().Int==0?184:147;continue;}
case 147:{f.Push(f.Locals[7]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",154);}
case 154:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=157;continue;}
case 157:{f.Locals[8]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRequirement","defenderSpecific","Ljava/util/Map;"));f.Pc=163;continue;}
case 163:{f.Push(f.Locals[8]);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[5]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",170);}
case 170:{return rt.DynamicCall(f,"forge/game/combat/AttackRequirement:5994:170:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BiFunction;",175);}
case 175:{return rt.Call(f,"java/util/Map","merge","(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;","invokeinterface",180);}
case 180:{f.StackOp("pop");f.Pc=181;continue;}
case 181:{f.Pc=137;continue;}
case 184:{f.Push(f.Locals[0]);f.Pc=185;continue;}
case 185:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRequirement","defenderSpecific","Ljava/util/Map;"));f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/util/Map","size","()I","invokeinterface",193);}
case 193:{return rt.Call(f,"com/google/common/collect/Lists","newArrayListWithCapacity","(I)Ljava/util/ArrayList;","invokestatic",196);}
case 196:{f.Locals[7]=f.Pop();f.Pc=198;continue;}
case 198:{f.Push(f.Locals[0]);f.Pc=199;continue;}
case 199:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRequirement","defenderSpecific","Ljava/util/Map;"));f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",207);}
case 207:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",212);}
case 212:{f.Locals[8]=f.Pop();f.Pc=214;continue;}
case 214:{f.Push(f.Locals[8]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",221);}
case 221:{f.Pc=f.Pop().Int==0?359:224;continue;}
case 224:{f.Push(f.Locals[8]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",231);}
case 231:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=234;continue;}
case 234:{f.Locals[9]=f.Pop();f.Pc=236;continue;}
case 236:{f.Push(JValue.I(0));f.Pc=237;continue;}
case 237:{f.Locals[10]=f.Pop();f.Pc=239;continue;}
case 239:{f.Push(f.Locals[9]);f.Pc=241;continue;}
case 241:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=244;continue;}
case 244:{f.Pc=f.Pop().Int==0?264:247;continue;}
case 247:{f.Push(f.Locals[9]);f.Pc=249;continue;}
case 249:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",255);}
case 255:{f.Pc=f.Pop().Int!=0?341:258;continue;}
case 258:{f.Push(JValue.I(1));f.Pc=259;continue;}
case 259:{f.Locals[10]=f.Pop();f.Pc=261;continue;}
case 261:{f.Pc=341;continue;}
case 264:{f.Push(f.Locals[9]);f.Pc=266;continue;}
case 266:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=269;continue;}
case 269:{f.Pc=f.Pop().Int==0?341:272;continue;}
case 272:{f.Push(f.Locals[9]);f.Pc=274;continue;}
case 274:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=277;continue;}
case 277:{f.Locals[11]=f.Pop();f.Pc=279;continue;}
case 279:{f.Push(f.Locals[4]);f.Pc=281;continue;}
case 281:{f.Push(f.Locals[11]);f.Pc=283;continue;}
case 283:{f.Push(JValue.R(null));f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",287);}
case 287:{f.Locals[12]=f.Pop();f.Pc=289;continue;}
case 289:{f.Push(f.Locals[12]);f.Pc=291;continue;}
case 291:{f.Pc=f.Pop().Reference==null?338:294;continue;}
case 294:{f.Push(f.Locals[12]);f.Pc=296;continue;}
case 296:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",299);}
case 299:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",302);}
case 302:{f.Pc=f.Pop().Int==0?338:305;continue;}
case 305:{f.Push(f.Locals[12]);f.Pc=307;continue;}
case 307:{f.Push(f.Locals[11]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",312);}
case 312:{f.Pc=f.Pop().Int==0?338:315;continue;}
case 315:{f.Push(f.Locals[12]);f.Pc=317;continue;}
case 317:{return rt.Call(f,"forge/game/card/Card","isBattle","()Z","invokevirtual",320);}
case 320:{f.Pc=f.Pop().Int!=0?341:323;continue;}
case 323:{f.Push(f.Locals[12]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",328);}
case 328:{f.Push(f.Locals[1]);f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",332);}
case 332:{return rt.Call(f,"forge/game/player/Player","isOpponentOf","(Lforge/game/player/Player;)Z","invokevirtual",335);}
case 335:{f.Pc=f.Pop().Int!=0?341:338;continue;}
case 338:{f.Push(JValue.I(1));f.Pc=339;continue;}
case 339:{f.Locals[10]=f.Pop();f.Pc=341;continue;}
case 341:{f.Push(f.Locals[10]);f.Pc=343;continue;}
case 343:{f.Pc=f.Pop().Int==0?356:346;continue;}
case 346:{f.Push(f.Locals[7]);f.Pc=348;continue;}
case 348:{f.Push(f.Locals[9]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",355);}
case 355:{f.StackOp("pop");f.Pc=356;continue;}
case 356:{f.Pc=214;continue;}
case 359:{f.Push(f.Locals[0]);f.Pc=360;continue;}
case 360:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRequirement","defenderSpecific","Ljava/util/Map;"));f.Pc=363;continue;}
case 363:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",368);}
case 368:{f.Push(f.Locals[7]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"java/util/Set","removeAll","(Ljava/util/Collection;)Z","invokeinterface",375);}
case 375:{f.StackOp("pop");f.Pc=376;continue;}
case 376:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5995(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRequirement","attacker","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5996(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRequirement","defenderSpecific","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",14);}
case 14:{return rt.DynamicCall(f,"forge/game/combat/AttackRequirement:5996:14:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",19);}
case 19:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int!=0?39:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRequirement","causesToAttack","Lcom/google/common/collect/Multimap;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"com/google/common/collect/Multimap","isEmpty","()Z","invokeinterface",36);}
case 36:{f.Pc=f.Pop().Int!=0?43:39;continue;}
case 39:{f.Push(JValue.I(1));f.Pc=40;continue;}
case 40:{f.Pc=44;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5997(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRequirement","causesToAttack","Lcom/google/common/collect/Multimap;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5998(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/combat/AttackRequirement","hasRequirement","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Reference==null?17:13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Pc=18;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRequirement","defenderSpecific","Ljava/util/Map;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",28);}
case 28:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",33);}
case 33:{return rt.DynamicCall(f,"forge/game/combat/AttackRequirement:5998:33:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",38);}
case 38:{return rt.Call(f,"java/util/stream/Stream","mapToInt","(Ljava/util/function/ToIntFunction;)Ljava/util/stream/IntStream;","invokeinterface",43);}
case 43:{return rt.Call(f,"java/util/stream/IntStream","sum","()I","invokeinterface",48);}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Pc=f.Pop().Int==0?75:52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRequirement","defenderSpecific","Ljava/util/Map;"));f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",61);}
case 61:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",66);}
case 66:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",72);}
case 72:{f.Pc=76;continue;}
case 75:{f.Push(JValue.I(0));f.Pc=76;continue;}
case 76:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=77;continue;}
case 77:{f.Locals[4]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{f.Pc=f.Pop().Int==0?364:83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/GameEntity","getGame","()Lforge/game/Game;","invokevirtual",87);}
case 87:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",90);}
case 90:{f.Locals[5]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[5]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/combat/Combat","getAttackConstraints","()Lforge/game/combat/AttackConstraints;","invokevirtual",97);}
case 97:{return rt.Call(f,"forge/game/combat/AttackConstraints","getRestrictions","()Ljava/util/Map;","invokevirtual",100);}
case 100:{f.Locals[6]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[2]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/util/Map","size","()I","invokeinterface",108);}
case 108:{f.Push(JValue.I(1));f.Pc=109;continue;}
case 109:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?160:112;continue;}
case 112:{f.Push(f.Locals[6]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",120);}
case 120:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",125);}
case 125:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",130);}
case 130:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",138);}
case 138:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",143);}
case 143:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackRestriction"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/combat/AttackRestriction","getTypes","()Ljava/util/Set;","invokevirtual",149);}
case 149:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;"));f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",157);}
case 157:{f.Pc=f.Pop().Int!=0?364:160;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRequirement","causesToAttack","Lcom/google/common/collect/Multimap;"));f.Pc=164;continue;}
case 164:{return rt.Call(f,"com/google/common/collect/Multimap","asMap","()Ljava/util/Map;","invokeinterface",169);}
case 169:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",174);}
case 174:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",179);}
case 179:{f.Locals[7]=f.Pop();f.Pc=181;continue;}
case 181:{f.Push(f.Locals[7]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",188);}
case 188:{f.Pc=f.Pop().Int==0?364:191;continue;}
case 191:{f.Push(f.Locals[7]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",198);}
case 198:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=201;continue;}
case 201:{f.Locals[8]=f.Pop();f.Pc=203;continue;}
case 203:{f.Push(f.Locals[6]);f.Pc=205;continue;}
case 205:{f.Push(f.Locals[8]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",212);}
case 212:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",217);}
case 217:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackRestriction"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/combat/AttackRestriction","getTypes","()Ljava/util/Set;","invokevirtual",223);}
case 223:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;"));f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",231);}
case 231:{f.Pc=f.Pop().Int==0?237:234;continue;}
case 234:{f.Pc=181;continue;}
case 237:{f.Push(f.Locals[8]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",244);}
case 244:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",250);}
case 250:{f.Push(f.Locals[5]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/combat/Combat","getDefenders","()Lforge/util/collect/FCollectionView;","invokevirtual",255);}
case 255:{return rt.Call(f,"forge/game/combat/GlobalAttackRestrictions","getGlobalRestrictions","(Lforge/game/player/Player;Lforge/util/collect/FCollectionView;)Lforge/game/combat/GlobalAttackRestrictions;","invokestatic",258);}
case 258:{return rt.Call(f,"forge/game/combat/GlobalAttackRestrictions","getMax","()Ljava/lang/Integer;","invokevirtual",261);}
case 261:{f.Push(JValue.I(2147483647));f.Pc=263;continue;}
case 263:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",266);}
case 266:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",269);}
case 269:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=272;continue;}
case 272:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",275);}
case 275:{f.Locals[9]=f.Pop();f.Pc=277;continue;}
case 277:{f.Push(f.Locals[2]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"java/util/Map","size","()I","invokeinterface",283);}
case 283:{f.Push(f.Locals[9]);f.Pc=285;continue;}
case 285:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?361:288;continue;}
case 288:{f.Push(f.Locals[2]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[8]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",296);}
case 296:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",301);}
case 301:{f.Pc=f.Pop().Int!=0?361:304;continue;}
case 304:{f.Push(f.Locals[8]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",311);}
case 311:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/combat/CombatUtil","canAttack","(Lforge/game/card/Card;)Z","invokestatic",317);}
case 317:{f.Pc=f.Pop().Int==0?361:320;continue;}
case 320:{f.Push(f.Locals[1]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/GameEntity","getGame","()Lforge/game/Game;","invokevirtual",324);}
case 324:{f.Push(f.Locals[8]);f.Pc=326;continue;}
case 326:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",331);}
case 331:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=334;continue;}
case 334:{f.Push(f.Locals[1]);f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/combat/CombatUtil","getAttackCost","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/GameEntity;)Lforge/game/cost/Cost;","invokestatic",338);}
case 338:{f.Pc=f.Pop().Reference!=null?361:341;continue;}
case 341:{f.Push(f.Locals[4]);f.Pc=343;continue;}
case 343:{f.Push(f.Locals[8]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",350);}
case 350:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=353;continue;}
case 353:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",358);}
case 358:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=359;continue;}
case 359:{f.Locals[4]=f.Pop();f.Pc=361;continue;}
case 361:{f.Pc=181;continue;}
case 364:{f.Push(f.Locals[4]);f.Pc=366;continue;}
case 366:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5999(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRequirement","defenderSpecific","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","size","()I","invokeinterface",9);}
case 9:{return rt.Call(f,"com/google/common/collect/Lists","newArrayListWithCapacity","(I)Ljava/util/ArrayList;","invokestatic",12);}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRequirement","defenderSpecific","Ljava/util/Map;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",22);}
case 22:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",27);}
case 27:{f.Locals[2]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",34);}
case 34:{f.Pc=f.Pop().Int==0?78:37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{f.Locals[3]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",54);}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",69);}
case 69:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{f.Pc=28;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Map$Entry","comparingByValue","()Ljava/util/Comparator;","invokestatic",82);}
case 82:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",87);}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6000(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int<=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
