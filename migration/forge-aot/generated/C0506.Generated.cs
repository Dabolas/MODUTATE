// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C506{
internal static JClass Build(){var c=new JClass("forge/game/combat/AttackConstraints","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("possibleAttackers","Lforge/game/card/CardCollection;",false,JValue.Default("Lforge/game/card/CardCollection;"),null));
c.Add(new JField("possibleDefenders","Lforge/util/collect/FCollectionView;",false,JValue.Default("Lforge/util/collect/FCollectionView;"),null));
c.Add(new JField("globalRestrictions","Lforge/game/combat/GlobalAttackRestrictions;",false,JValue.Default("Lforge/game/combat/GlobalAttackRestrictions;"),null));
c.Add(new JField("restrictions","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("requirements","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("playerRequirements","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(5970,"forge/game/combat/AttackConstraints","<init>","(Lforge/game/combat/Combat;)V",1,8,6,new JHandler[]{},M5970));
c.Add(new JMethod(5971,"forge/game/combat/AttackConstraints","getRestrictions","()Ljava/util/Map;",1,1,1,new JHandler[]{},M5971));
c.Add(new JMethod(5972,"forge/game/combat/AttackConstraints","getGlobalRestrictions","()Lforge/game/combat/GlobalAttackRestrictions;",1,1,1,new JHandler[]{},M5972));
c.Add(new JMethod(5973,"forge/game/combat/AttackConstraints","getRequirements","()Ljava/util/Map;",1,1,1,new JHandler[]{},M5973));
c.Add(new JMethod(5974,"forge/game/combat/AttackConstraints","getLegalAttackers","()Lorg/apache/commons/lang3/tuple/Pair;",1,11,4,new JHandler[]{},M5974));
c.Add(new JMethod(5975,"forge/game/combat/AttackConstraints","collectLegalAttackers","(Ljava/util/List;I)Lforge/util/collect/FCollection;",2,3,7,new JHandler[]{},M5975));
c.Add(new JMethod(5976,"forge/game/combat/AttackConstraints","collectLegalAttackers","(Ljava/util/Map;Ljava/util/List;Lforge/game/card/CardCollection;I)Ljava/util/List;",2,25,6,new JHandler[]{},M5976));
c.Add(new JMethod(5977,"forge/game/combat/AttackConstraints","getSortedFilteredRequirements","()Ljava/util/List;",2,9,6,new JHandler[]{},M5977));
c.Add(new JMethod(5978,"forge/game/combat/AttackConstraints","deepClone","(Ljava/util/List;)Ljava/util/List;",10,4,4,new JHandler[]{},M5978));
c.Add(new JMethod(5979,"forge/game/combat/AttackConstraints","findFirst","(Ljava/util/List;Ljava/util/function/Predicate;)Lforge/game/combat/AttackConstraints$Attack;",10,4,2,new JHandler[]{},M5979));
c.Add(new JMethod(5980,"forge/game/combat/AttackConstraints","findFirst","(Ljava/util/List;Lforge/game/card/Card;)Lforge/game/combat/AttackConstraints$Attack;",10,2,3,new JHandler[]{},M5980));
c.Add(new JMethod(5981,"forge/game/combat/AttackConstraints","findAll","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",10,1,1,new JHandler[]{},M5981));
c.Add(new JMethod(5982,"forge/game/combat/AttackConstraints","countViolations","(Ljava/util/Map;)I",17,9,4,new JHandler[]{},M5982));
c.Add(new JMethod(5983,"forge/game/combat/AttackConstraints","lambda$countViolations$5","(Ljava/util/Map$Entry;Ljava/util/Map$Entry;)Z",4106,2,2,new JHandler[]{},M5983));
c.Add(new JMethod(5984,"forge/game/combat/AttackConstraints","lambda$findAll$4","(Lforge/game/card/Card;Lforge/game/combat/AttackConstraints$Attack;)Z",4106,2,2,new JHandler[]{},M5984));
c.Add(new JMethod(5985,"forge/game/combat/AttackConstraints","lambda$getSortedFilteredRequirements$3","(Lforge/game/card/CardCollection;Ljava/util/Map$Entry;Ljava/util/Map$Entry;Lforge/game/combat/AttackConstraints$Attack;)Z",4106,4,3,new JHandler[]{},M5985));
c.Add(new JMethod(5986,"forge/game/combat/AttackConstraints","lambda$getSortedFilteredRequirements$2","(Ljava/util/Map$Entry;)Ljava/lang/Integer;",4106,1,1,new JHandler[]{},M5986));
c.Add(new JMethod(5987,"forge/game/combat/AttackConstraints","lambda$getLegalAttackers$1","(Ljava/util/Map$Entry;)Lorg/apache/commons/lang3/tuple/Pair;",4106,1,2,new JHandler[]{},M5987));
c.Add(new JMethod(5988,"forge/game/combat/AttackConstraints","lambda$new$0","(Lforge/game/card/Card;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M5988));
}

internal static JStep M5970(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackConstraints","restrictions","Ljava/util/Map;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackConstraints","requirements","Ljava/util/Map;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",22);}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackConstraints","playerRequirements","Ljava/util/Map;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/combat/Combat","getAttackingPlayer","()Lforge/game/player/Player;","invokevirtual",29);}
case 29:{f.Locals[2]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/player/Player","getSharedTeam","()Lforge/game/player/PlayerCollection;","invokevirtual",34);}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/player/PlayerCollection","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",40);}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackConstraints","possibleAttackers","Lforge/game/card/CardCollection;",value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/combat/Combat","getDefenders","()Lforge/util/collect/FCollectionView;","invokevirtual",48);}
case 48:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackConstraints","possibleDefenders","Lforge/util/collect/FCollectionView;",value);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","possibleDefenders","Lforge/util/collect/FCollectionView;"));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/combat/GlobalAttackRestrictions","getGlobalRestrictions","(Lforge/game/player/Player;Lforge/util/collect/FCollectionView;)Lforge/game/combat/GlobalAttackRestrictions;","invokestatic",60);}
case 60:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackConstraints","globalRestrictions","Lforge/game/combat/GlobalAttackRestrictions;",value);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",67);}
case 67:{f.Locals[4]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",76);}
case 76:{f.Pc=f.Pop().Int==0?115:79;continue;}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",86);}
case 86:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=89;continue;}
case 89:{f.Locals[5]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","playerRequirements","Ljava/util/Map;"));f.Pc=95;continue;}
case 95:{f.Push(f.Locals[5]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[5]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","possibleDefenders","Lforge/util/collect/FCollectionView;"));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/staticability/StaticAbilityMustAttack","mustAttackSpecific","(Lforge/game/player/Player;Lforge/util/collect/FCollectionView;)Lcom/google/common/collect/Multimap;","invokestatic",106);}
case 106:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",111);}
case 111:{f.StackOp("pop");f.Pc=112;continue;}
case 112:{f.Pc=69;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","possibleAttackers","Lforge/game/card/CardCollection;"));f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",122);}
case 122:{f.Locals[4]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[4]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",131);}
case 131:{f.Pc=f.Pop().Int==0?242:134;continue;}
case 134:{f.Push(f.Locals[4]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",141);}
case 141:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=144;continue;}
case 144:{f.Locals[5]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","restrictions","Ljava/util/Map;"));f.Pc=150;continue;}
case 150:{f.Push(f.Locals[5]);f.Pc=152;continue;}
case 152:{if(!rt.EnsureInitialized(f,"forge/game/combat/AttackRestriction"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/AttackRestriction")));f.Pc=155;continue;}
case 155:{f.StackOp("dup");f.Pc=156;continue;}
case 156:{f.Push(f.Locals[5]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[0]);f.Pc=159;continue;}
case 159:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","possibleDefenders","Lforge/util/collect/FCollectionView;"));f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/combat/AttackRestriction","<init>","(Lforge/game/card/Card;Lforge/util/collect/FCollectionView;)V","invokespecial",165);}
case 165:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",170);}
case 170:{f.StackOp("pop");f.Pc=171;continue;}
case 171:{f.Push(f.Locals[5]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[0]);f.Pc=174;continue;}
case 174:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","possibleAttackers","Lforge/game/card/CardCollection;"));f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/card/CardCollection","stream","()Ljava/util/stream/Stream;","invokevirtual",180);}
case 180:{f.Push(f.Locals[5]);f.Pc=182;continue;}
case 182:{return rt.DynamicCall(f,"forge/game/combat/AttackConstraints:5970:182:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",187);}
case 187:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",192);}
case 192:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",195);}
case 195:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",200);}
case 200:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/staticability/StaticAbilityMustAttack","getAttackRequirements","(Lforge/game/card/Card;Ljava/lang/Iterable;)Lcom/google/common/collect/Multimap;","invokestatic",206);}
case 206:{f.Locals[6]=f.Pop();f.Pc=208;continue;}
case 208:{if(!rt.EnsureInitialized(f,"forge/game/combat/AttackRequirement"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/AttackRequirement")));f.Pc=211;continue;}
case 211:{f.StackOp("dup");f.Pc=212;continue;}
case 212:{f.Push(f.Locals[5]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[6]);f.Pc=216;continue;}
case 216:{f.Push(f.Locals[0]);f.Pc=217;continue;}
case 217:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","possibleDefenders","Lforge/util/collect/FCollectionView;"));f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/combat/AttackRequirement","<init>","(Lforge/game/card/Card;Lcom/google/common/collect/Multimap;Lforge/util/collect/FCollectionView;)V","invokespecial",223);}
case 223:{f.Locals[7]=f.Pop();f.Pc=225;continue;}
case 225:{f.Push(f.Locals[0]);f.Pc=226;continue;}
case 226:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","requirements","Ljava/util/Map;"));f.Pc=229;continue;}
case 229:{f.Push(f.Locals[5]);f.Pc=231;continue;}
case 231:{f.Push(f.Locals[7]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",238);}
case 238:{f.StackOp("pop");f.Pc=239;continue;}
case 239:{f.Pc=124;continue;}
case 242:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5971(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","restrictions","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5972(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","globalRestrictions","Lforge/game/combat/GlobalAttackRestrictions;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5973(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","requirements","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5974(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","globalRestrictions","Lforge/game/combat/GlobalAttackRestrictions;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/combat/GlobalAttackRestrictions","getMax","()Ljava/lang/Integer;","invokevirtual",7);}
case 7:{f.Push(JValue.I(2147483647));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",12);}
case 12:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",21);}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","possibleAttackers","Lforge/game/card/CardCollection;"));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",28);}
case 28:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",31);}
case 31:{f.Locals[1]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Int!=0?47:36;continue;}
case 36:{return rt.Call(f,"java/util/Collections","emptyMap","()Ljava/util/Map;","invokestatic",39);}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",43);}
case 43:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",46);}
case 46:{return JStep.Return(f.Pop());}
case 47:{if(!rt.EnsureInitialized(f,"java/util/LinkedHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/LinkedHashMap")));f.Pc=50;continue;}
case 50:{f.StackOp("dup");f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/LinkedHashMap","<init>","()V","invokespecial",54);}
case 54:{f.Locals[2]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/combat/AttackConstraints","getSortedFilteredRequirements","()Ljava/util/List;","invokevirtual",59);}
case 59:{f.Locals[3]=f.Pop();f.Pc=60;continue;}
case 60:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=63;continue;}
case 63:{f.StackOp("dup");f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","possibleAttackers","Lforge/game/card/CardCollection;"));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",71);}
case 71:{f.Locals[4]=f.Pop();f.Pc=73;continue;}
case 73:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",80);}
case 80:{f.Locals[5]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",87);}
case 87:{f.Locals[6]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[6]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",96);}
case 96:{f.Pc=f.Pop().Int==0?225:99;continue;}
case 99:{f.Push(f.Locals[6]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",106);}
case 106:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=109;continue;}
case 109:{f.Locals[7]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","restrictions","Ljava/util/Map;"));f.Pc=115;continue;}
case 115:{f.Push(f.Locals[7]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",122);}
case 122:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackRestriction"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/combat/AttackRestriction","getTypes","()Ljava/util/Set;","invokevirtual",128);}
case 128:{f.Locals[8]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[8]);f.Pc=132;continue;}
case 132:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_TWO_OTHERS","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_TWO_OTHERS","Lforge/game/combat/AttackRestrictionType;"));f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",140);}
case 140:{f.Pc=f.Pop().Int==0?148:143;continue;}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{f.Push(JValue.I(2));f.Pc=145;continue;}
case 145:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?202:148;continue;}
case 148:{f.Push(f.Locals[8]);f.Pc=150;continue;}
case 150:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NOT_ALONE","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NOT_ALONE","Lforge/game/combat/AttackRestrictionType;"));f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",158);}
case 158:{f.Pc=f.Pop().Int==0?166:161;continue;}
case 161:{f.Push(f.Locals[1]);f.Pc=162;continue;}
case 162:{f.Push(JValue.I(1));f.Pc=163;continue;}
case 163:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?202:166;continue;}
case 166:{f.Push(f.Locals[8]);f.Pc=168;continue;}
case 168:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"));f.Pc=171;continue;}
case 171:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",176);}
case 176:{f.Pc=f.Pop().Int==0?184:179;continue;}
case 179:{f.Push(f.Locals[1]);f.Pc=180;continue;}
case 180:{f.Push(JValue.I(1));f.Pc=181;continue;}
case 181:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?202:184;continue;}
case 184:{f.Push(f.Locals[8]);f.Pc=186;continue;}
case 186:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"));f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",194);}
case 194:{f.Pc=f.Pop().Int==0?222:197;continue;}
case 197:{f.Push(f.Locals[1]);f.Pc=198;continue;}
case 198:{f.Push(JValue.I(1));f.Pc=199;continue;}
case 199:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?222:202;continue;}
case 202:{f.Push(f.Locals[3]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[7]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/combat/AttackConstraints","findAll","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",208);}
case 208:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",213);}
case 213:{f.StackOp("pop");f.Pc=214;continue;}
case 214:{f.Push(f.Locals[5]);f.Pc=216;continue;}
case 216:{f.Push(f.Locals[7]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",221);}
case 221:{f.StackOp("pop");f.Pc=222;continue;}
case 222:{f.Pc=89;continue;}
case 225:{f.Push(f.Locals[4]);f.Pc=227;continue;}
case 227:{f.Push(f.Locals[5]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",232);}
case 232:{f.StackOp("pop");f.Pc=233;continue;}
case 233:{f.Push(f.Locals[5]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/card/CardCollection","clear","()V","invokevirtual",238);}
case 238:{f.Push(f.Locals[4]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",243);}
case 243:{f.Locals[6]=f.Pop();f.Pc=245;continue;}
case 245:{f.Push(f.Locals[6]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",252);}
case 252:{f.Pc=f.Pop().Int==0?366:255;continue;}
case 255:{f.Push(f.Locals[6]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",262);}
case 262:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=265;continue;}
case 265:{f.Locals[7]=f.Pop();f.Pc=267;continue;}
case 267:{f.Push(f.Locals[0]);f.Pc=268;continue;}
case 268:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","restrictions","Ljava/util/Map;"));f.Pc=271;continue;}
case 271:{f.Push(f.Locals[7]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",278);}
case 278:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackRestriction"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/combat/AttackRestriction","getTypes","()Ljava/util/Set;","invokevirtual",284);}
case 284:{f.Locals[8]=f.Pop();f.Pc=286;continue;}
case 286:{f.Push(f.Locals[8]);f.Pc=288;continue;}
case 288:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"));f.Pc=291;continue;}
case 291:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",296);}
case 296:{f.Pc=f.Pop().Int==0?326:299;continue;}
case 299:{f.Push(f.Locals[4]);f.Pc=301;continue;}
case 301:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"));f.Pc=304;continue;}
case 304:{f.Push(f.Locals[7]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/combat/AttackRestrictionType","getPredicate","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokevirtual",309);}
case 309:{return rt.Call(f,"forge/game/card/CardCollection","anyMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",312);}
case 312:{f.Pc=f.Pop().Int!=0?363:315;continue;}
case 315:{f.Push(f.Locals[5]);f.Pc=317;continue;}
case 317:{f.Push(f.Locals[7]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",322);}
case 322:{f.StackOp("pop");f.Pc=323;continue;}
case 323:{f.Pc=363;continue;}
case 326:{f.Push(f.Locals[8]);f.Pc=328;continue;}
case 328:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"));f.Pc=331;continue;}
case 331:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",336);}
case 336:{f.Pc=f.Pop().Int==0?363:339;continue;}
case 339:{f.Push(f.Locals[4]);f.Pc=341;continue;}
case 341:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"));f.Pc=344;continue;}
case 344:{f.Push(f.Locals[7]);f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/game/combat/AttackRestrictionType","getPredicate","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokevirtual",349);}
case 349:{return rt.Call(f,"forge/game/card/CardCollection","anyMatch","(Ljava/util/function/Predicate;)Z","invokevirtual",352);}
case 352:{f.Pc=f.Pop().Int!=0?363:355;continue;}
case 355:{f.Push(f.Locals[5]);f.Pc=357;continue;}
case 357:{f.Push(f.Locals[7]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",362);}
case 362:{f.StackOp("pop");f.Pc=363;continue;}
case 363:{f.Pc=245;continue;}
case 366:{f.Push(f.Locals[4]);f.Pc=368;continue;}
case 368:{f.Push(f.Locals[5]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",373);}
case 373:{f.StackOp("pop");f.Pc=374;continue;}
case 374:{f.Push(f.Locals[5]);f.Pc=376;continue;}
case 376:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",379);}
case 379:{f.Locals[6]=f.Pop();f.Pc=381;continue;}
case 381:{f.Push(f.Locals[6]);f.Pc=383;continue;}
case 383:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",388);}
case 388:{f.Pc=f.Pop().Int==0?418:391;continue;}
case 391:{f.Push(f.Locals[6]);f.Pc=393;continue;}
case 393:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",398);}
case 398:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=401;continue;}
case 401:{f.Locals[7]=f.Pop();f.Pc=403;continue;}
case 403:{f.Push(f.Locals[3]);f.Pc=404;continue;}
case 404:{f.Push(f.Locals[7]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/game/combat/AttackConstraints","findAll","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",409);}
case 409:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",414);}
case 414:{f.StackOp("pop");f.Pc=415;continue;}
case 415:{f.Pc=381;continue;}
case 418:{f.Push(f.Locals[4]);f.Pc=420;continue;}
case 420:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",423);}
case 423:{f.Locals[6]=f.Pop();f.Pc=425;continue;}
case 425:{f.Push(f.Locals[6]);f.Pc=427;continue;}
case 427:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",432);}
case 432:{f.Pc=f.Pop().Int==0?549:435;continue;}
case 435:{f.Push(f.Locals[6]);f.Pc=437;continue;}
case 437:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",442);}
case 442:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=445;continue;}
case 445:{f.Locals[7]=f.Pop();f.Pc=447;continue;}
case 447:{f.Push(f.Locals[0]);f.Pc=448;continue;}
case 448:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","restrictions","Ljava/util/Map;"));f.Pc=451;continue;}
case 451:{f.Push(f.Locals[7]);f.Pc=453;continue;}
case 453:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",458);}
case 458:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackRestriction"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=461;continue;}
case 461:{return rt.Call(f,"forge/game/combat/AttackRestriction","getTypes","()Ljava/util/Set;","invokevirtual",464);}
case 464:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;"));f.Pc=467;continue;}
case 467:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",472);}
case 472:{f.Pc=f.Pop().Int==0?546:475;continue;}
case 475:{f.Push(f.Locals[3]);f.Pc=476;continue;}
case 476:{f.Push(f.Locals[7]);f.Pc=478;continue;}
case 478:{return rt.Call(f,"forge/game/combat/AttackConstraints","findFirst","(Ljava/util/List;Lforge/game/card/Card;)Lforge/game/combat/AttackConstraints$Attack;","invokestatic",481);}
case 481:{f.Locals[8]=f.Pop();f.Pc=483;continue;}
case 483:{f.Push(f.Locals[8]);f.Pc=485;continue;}
case 485:{f.Pc=f.Pop().Reference!=null?491:488;continue;}
case 488:{f.Pc=425;continue;}
case 491:{f.Push(f.Locals[8]);f.Pc=493;continue;}
case 493:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=496;continue;}
case 496:{f.Push(f.Locals[8]);f.Pc=498;continue;}
case 498:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","defender","Lforge/game/GameEntity;"));f.Pc=501;continue;}
case 501:{return rt.Call(f,"com/google/common/collect/ImmutableMap","of","(Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableMap;","invokestatic",504);}
case 504:{f.Locals[9]=f.Pop();f.Pc=506;continue;}
case 506:{f.Push(f.Locals[0]);f.Pc=507;continue;}
case 507:{f.Push(f.Locals[9]);f.Pc=509;continue;}
case 509:{return rt.Call(f,"forge/game/combat/AttackConstraints","countViolations","(Ljava/util/Map;)I","invokevirtual",512);}
case 512:{f.Locals[10]=f.Pop();f.Pc=514;continue;}
case 514:{f.Push(f.Locals[10]);f.Pc=516;continue;}
case 516:{f.Push(JValue.I(-1));f.Pc=517;continue;}
case 517:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?534:520;continue;}
case 520:{f.Push(f.Locals[2]);f.Pc=521;continue;}
case 521:{f.Push(f.Locals[9]);f.Pc=523;continue;}
case 523:{f.Push(f.Locals[10]);f.Pc=525;continue;}
case 525:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",528);}
case 528:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",533);}
case 533:{f.StackOp("pop");f.Pc=534;continue;}
case 534:{f.Push(f.Locals[3]);f.Pc=535;continue;}
case 535:{f.Push(f.Locals[7]);f.Pc=537;continue;}
case 537:{return rt.Call(f,"forge/game/combat/AttackConstraints","findAll","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",540);}
case 540:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",545);}
case 545:{f.StackOp("pop");f.Pc=546;continue;}
case 546:{f.Pc=425;continue;}
case 549:{f.Push(f.Locals[0]);f.Pc=550;continue;}
case 550:{f.Push(f.Locals[3]);f.Pc=551;continue;}
case 551:{f.Push(f.Locals[1]);f.Pc=552;continue;}
case 552:{return rt.Call(f,"forge/game/combat/AttackConstraints","collectLegalAttackers","(Ljava/util/List;I)Lforge/util/collect/FCollection;","invokevirtual",555);}
case 555:{f.Locals[6]=f.Pop();f.Pc=557;continue;}
case 557:{f.Push(f.Locals[6]);f.Pc=559;continue;}
case 559:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",562);}
case 562:{f.Locals[7]=f.Pop();f.Pc=564;continue;}
case 564:{f.Push(f.Locals[7]);f.Pc=566;continue;}
case 566:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",571);}
case 571:{f.Pc=f.Pop().Int==0?607:574;continue;}
case 574:{f.Push(f.Locals[7]);f.Pc=576;continue;}
case 576:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",581);}
case 581:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=584;continue;}
case 584:{f.Locals[8]=f.Pop();f.Pc=586;continue;}
case 586:{f.Push(f.Locals[2]);f.Pc=587;continue;}
case 587:{f.Push(f.Locals[8]);f.Pc=589;continue;}
case 589:{f.Push(f.Locals[0]);f.Pc=590;continue;}
case 590:{f.Push(f.Locals[8]);f.Pc=592;continue;}
case 592:{return rt.Call(f,"forge/game/combat/AttackConstraints","countViolations","(Ljava/util/Map;)I","invokevirtual",595);}
case 595:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",598);}
case 598:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",603);}
case 603:{f.StackOp("pop");f.Pc=604;continue;}
case 604:{f.Pc=564;continue;}
case 607:{f.Push(f.Locals[0]);f.Pc=608;continue;}
case 608:{return rt.Call(f,"java/util/Collections","emptyMap","()Ljava/util/Map;","invokestatic",611);}
case 611:{return rt.Call(f,"forge/game/combat/AttackConstraints","countViolations","(Ljava/util/Map;)I","invokevirtual",614);}
case 614:{f.Locals[7]=f.Pop();f.Pc=616;continue;}
case 616:{f.Push(f.Locals[7]);f.Pc=618;continue;}
case 618:{f.Push(JValue.I(-1));f.Pc=619;continue;}
case 619:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?637:622;continue;}
case 622:{f.Push(f.Locals[2]);f.Pc=623;continue;}
case 623:{return rt.Call(f,"java/util/Collections","emptyMap","()Ljava/util/Map;","invokestatic",626);}
case 626:{f.Push(f.Locals[7]);f.Pc=628;continue;}
case 628:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",631);}
case 631:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",636);}
case 636:{f.StackOp("pop");f.Pc=637;continue;}
case 637:{f.Push(f.Locals[2]);f.Pc=638;continue;}
case 638:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",643);}
case 643:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",648);}
case 648:{return rt.DynamicCall(f,"forge/game/combat/AttackConstraints:5974:648:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",653);}
case 653:{return rt.Call(f,"java/util/Comparator","comparingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;","invokestatic",656);}
case 656:{return rt.Call(f,"java/util/stream/Stream","min","(Ljava/util/Comparator;)Ljava/util/Optional;","invokeinterface",661);}
case 661:{return rt.DynamicCall(f,"forge/game/combat/AttackConstraints:5974:661:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",666);}
case 666:{return rt.Call(f,"java/util/Optional","map","(Ljava/util/function/Function;)Ljava/util/Optional;","invokevirtual",669);}
case 669:{return rt.DynamicCall(f,"forge/game/combat/AttackConstraints:5974:669:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Supplier;",674);}
case 674:{return rt.Call(f,"java/util/Optional","orElseThrow","(Ljava/util/function/Supplier;)Ljava/lang/Object;","invokevirtual",677);}
case 677:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=680;continue;}
case 680:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5975(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Collections","emptyMap","()Ljava/util/Map;","invokestatic",8);}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/combat/AttackConstraints","deepClone","(Ljava/util/List;)Ljava/util/List;","invokestatic",12);}
case 12:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",19);}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/combat/AttackConstraints","collectLegalAttackers","(Ljava/util/Map;Ljava/util/List;Lforge/game/card/CardCollection;I)Ljava/util/List;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",26);}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5976(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newLinkedList","()Ljava/util/LinkedList;","invokestatic",3);}
case 3:{f.Locals[5]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[4]);f.Pc=7;continue;}
case 7:{f.Locals[6]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","globalRestrictions","Lforge/game/combat/GlobalAttackRestrictions;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/combat/GlobalAttackRestrictions","getMax","()Ljava/lang/Integer;","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Reference==null?23:19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{f.Locals[7]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","(Ljava/util/Map;)Ljava/util/HashMap;","invokestatic",30);}
case 30:{f.Locals[8]=f.Pop();f.Pc=32;continue;}
case 32:{if(!rt.EnsureInitialized(f,"java/util/LinkedHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/LinkedHashMap")));f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/LinkedHashMap","<init>","()V","invokespecial",39);}
case 39:{f.Locals[9]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{f.Locals[10]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",50);}
case 50:{f.Pc=f.Pop().Int!=0?903:53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",59);}
case 59:{f.Locals[11]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[11]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",68);}
case 68:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackConstraints$Attack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=71;continue;}
case 71:{f.Locals[12]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[3]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[12]);f.Pc=76;continue;}
case 76:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",82);}
case 82:{f.Locals[13]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(JValue.I(0));f.Pc=85;continue;}
case 85:{f.Locals[14]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[13]);f.Pc=89;continue;}
case 89:{f.Pc=f.Pop().Int!=0?126:92;continue;}
case 92:{f.Push(f.Locals[6]);f.Pc=94;continue;}
case 94:{f.Pc=f.Pop().Int>0?103:97;continue;}
case 97:{f.Push(JValue.I(1));f.Pc=98;continue;}
case 98:{f.Locals[14]=f.Pop();f.Pc=100;continue;}
case 100:{f.Pc=126;continue;}
case 103:{f.Push(f.Locals[12]);f.Pc=105;continue;}
case 105:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","requirements","I"));f.Pc=108;continue;}
case 108:{f.Pc=f.Pop().Int!=0?126:111;continue;}
case 111:{f.Push(f.Locals[10]);f.Pc=113;continue;}
case 113:{f.Pc=f.Pop().Int!=0?126:116;continue;}
case 116:{f.Push(f.Locals[3]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int==0?126:123;continue;}
case 123:{f.Push(JValue.I(1));f.Pc=124;continue;}
case 124:{f.Locals[14]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","globalRestrictions","Lforge/game/combat/GlobalAttackRestrictions;"));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/combat/GlobalAttackRestrictions","getDefenderMax","()Ljava/util/Map;","invokevirtual",133);}
case 133:{f.Push(f.Locals[12]);f.Pc=135;continue;}
case 135:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","defender","Lforge/game/GameEntity;"));f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",143);}
case 143:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=146;continue;}
case 146:{f.Locals[15]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[15]);f.Pc=150;continue;}
case 150:{f.Pc=f.Pop().Reference==null?189:153;continue;}
case 153:{f.Push(f.Locals[9]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[12]);f.Pc=157;continue;}
case 157:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","defender","Lforge/game/GameEntity;"));f.Pc=160;continue;}
case 160:{f.Push(JValue.I(0));f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",164);}
case 164:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",169);}
case 169:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",175);}
case 175:{f.Push(f.Locals[15]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",180);}
case 180:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?189:183;continue;}
case 183:{f.Push(JValue.I(1));f.Pc=184;continue;}
case 184:{f.Locals[14]=f.Pop();f.Pc=186;continue;}
case 186:{f.Pc=217;continue;}
case 189:{f.Push(JValue.R(null));f.Pc=190;continue;}
case 190:{f.Push(f.Locals[12]);f.Pc=192;continue;}
case 192:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",198);}
case 198:{f.Push(f.Locals[12]);f.Pc=200;continue;}
case 200:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=203;continue;}
case 203:{f.Push(f.Locals[12]);f.Pc=205;continue;}
case 205:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","defender","Lforge/game/GameEntity;"));f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/combat/CombatUtil","getAttackCost","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/GameEntity;)Lforge/game/cost/Cost;","invokestatic",211);}
case 211:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?217:214;continue;}
case 214:{f.Push(JValue.I(1));f.Pc=215;continue;}
case 215:{f.Locals[14]=f.Pop();f.Pc=217;continue;}
case 217:{f.Push(f.Locals[14]);f.Pc=219;continue;}
case 219:{f.Pc=f.Pop().Int==0?232:222;continue;}
case 222:{f.Push(f.Locals[11]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"java/util/Iterator","remove","()V","invokeinterface",229);}
case 229:{f.Pc=44;continue;}
case 232:{f.Push(JValue.I(0));f.Pc=233;continue;}
case 233:{f.Locals[16]=f.Pop();f.Pc=235;continue;}
case 235:{f.Push(f.Locals[0]);f.Pc=236;continue;}
case 236:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","restrictions","Ljava/util/Map;"));f.Pc=239;continue;}
case 239:{f.Push(f.Locals[12]);f.Pc=241;continue;}
case 241:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=244;continue;}
case 244:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",249);}
case 249:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackRestriction"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=252;continue;}
case 252:{f.Locals[17]=f.Pop();f.Pc=254;continue;}
case 254:{f.Push(f.Locals[0]);f.Pc=255;continue;}
case 255:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","requirements","Ljava/util/Map;"));f.Pc=258;continue;}
case 258:{f.Push(f.Locals[12]);f.Pc=260;continue;}
case 260:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=263;continue;}
case 263:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",268);}
case 268:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackRequirement"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=271;continue;}
case 271:{f.Locals[18]=f.Pop();f.Pc=273;continue;}
case 273:{return rt.Call(f,"com/google/common/collect/Lists","newLinkedList","()Ljava/util/LinkedList;","invokestatic",276);}
case 276:{f.Locals[19]=f.Pop();f.Pc=278;continue;}
case 278:{f.Push(f.Locals[17]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/combat/AttackRestriction","getTypes","()Ljava/util/Set;","invokevirtual",283);}
case 283:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",288);}
case 288:{f.Locals[20]=f.Pop();f.Pc=290;continue;}
case 290:{f.Push(f.Locals[20]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",297);}
case 297:{f.Pc=f.Pop().Int==0?342:300;continue;}
case 300:{f.Push(f.Locals[20]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",307);}
case 307:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackRestrictionType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=310;continue;}
case 310:{f.Locals[21]=f.Pop();f.Pc=312;continue;}
case 312:{f.Push(f.Locals[21]);f.Pc=314;continue;}
case 314:{f.Push(f.Locals[12]);f.Pc=316;continue;}
case 316:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/combat/AttackRestrictionType","getPredicate","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokevirtual",322);}
case 322:{f.Locals[22]=f.Pop();f.Pc=324;continue;}
case 324:{f.Push(f.Locals[22]);f.Pc=326;continue;}
case 326:{f.Pc=f.Pop().Reference==null?339:329;continue;}
case 329:{f.Push(f.Locals[19]);f.Pc=331;continue;}
case 331:{f.Push(f.Locals[22]);f.Pc=333;continue;}
case 333:{return rt.Call(f,"java/util/Collection","add","(Ljava/lang/Object;)Z","invokeinterface",338);}
case 338:{f.StackOp("pop");f.Pc=339;continue;}
case 339:{f.Pc=290;continue;}
case 342:{f.Push(f.Locals[18]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/combat/AttackRequirement","getCausesToAttack","()Lcom/google/common/collect/Multimap;","invokevirtual",347);}
case 347:{return rt.Call(f,"com/google/common/collect/Multimap","isEmpty","()Z","invokeinterface",352);}
case 352:{f.Pc=f.Pop().Int!=0?536:355;continue;}
case 355:{f.Push(f.Locals[2]);f.Pc=356;continue;}
case 356:{return rt.Call(f,"forge/game/combat/AttackConstraints","deepClone","(Ljava/util/List;)Ljava/util/List;","invokestatic",359);}
case 359:{f.Locals[20]=f.Pop();f.Pc=361;continue;}
case 361:{f.Push(f.Locals[18]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/game/combat/AttackRequirement","getCausesToAttack","()Lcom/google/common/collect/Multimap;","invokevirtual",366);}
case 366:{return rt.Call(f,"com/google/common/collect/Multimap","asMap","()Ljava/util/Map;","invokeinterface",371);}
case 371:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",376);}
case 376:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",381);}
case 381:{f.Locals[21]=f.Pop();f.Pc=383;continue;}
case 383:{f.Push(f.Locals[21]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",390);}
case 390:{f.Pc=f.Pop().Int==0?482:393;continue;}
case 393:{f.Push(f.Locals[21]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",400);}
case 400:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=403;continue;}
case 403:{f.Locals[22]=f.Pop();f.Pc=405;continue;}
case 405:{f.Push(f.Locals[2]);f.Pc=406;continue;}
case 406:{f.Push(f.Locals[22]);f.Pc=408;continue;}
case 408:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",413);}
case 413:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=416;continue;}
case 416:{return rt.Call(f,"forge/game/combat/AttackConstraints","findAll","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",419);}
case 419:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/util/Collection;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",422);}
case 422:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",427);}
case 427:{f.Locals[23]=f.Pop();f.Pc=429;continue;}
case 429:{f.Push(f.Locals[23]);f.Pc=431;continue;}
case 431:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",436);}
case 436:{f.Pc=f.Pop().Int==0?479:439;continue;}
case 439:{f.Push(f.Locals[23]);f.Pc=441;continue;}
case 441:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",446);}
case 446:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackConstraints$Attack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=449;continue;}
case 449:{f.Locals[24]=f.Pop();f.Pc=451;continue;}
case 451:{f.Push(f.Locals[24]);f.Pc=453;continue;}
case 453:{f.StackOp("dup");f.Pc=454;continue;}
case 454:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","requirements","I"));f.Pc=457;continue;}
case 457:{f.Push(f.Locals[22]);f.Pc=459;continue;}
case 459:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",464);}
case 464:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=467;continue;}
case 467:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",472);}
case 472:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=473;continue;}
case 473:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","requirements","I",value);f.Pc=476;continue;}
case 476:{f.Pc=429;continue;}
case 479:{f.Pc=383;continue;}
case 482:{f.Push(f.Locals[7]);f.Pc=484;continue;}
case 484:{f.Pc=f.Pop().Int==0?536:487;continue;}
case 487:{f.Push(f.Locals[20]);f.Pc=489;continue;}
case 489:{f.Push(f.Locals[12]);f.Pc=491;continue;}
case 491:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=494;continue;}
case 494:{return rt.Call(f,"forge/game/combat/AttackConstraints","findAll","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",497);}
case 497:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",502);}
case 502:{f.StackOp("pop");f.Pc=503;continue;}
case 503:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=506;continue;}
case 506:{f.StackOp("dup");f.Pc=507;continue;}
case 507:{f.Push(f.Locals[3]);f.Pc=508;continue;}
case 508:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",511);}
case 511:{f.Locals[21]=f.Pop();f.Pc=513;continue;}
case 513:{f.Push(f.Locals[5]);f.Pc=515;continue;}
case 515:{f.Push(f.Locals[0]);f.Pc=516;continue;}
case 516:{f.Push(f.Locals[8]);f.Pc=518;continue;}
case 518:{f.Push(f.Locals[20]);f.Pc=520;continue;}
case 520:{f.Push(f.Locals[21]);f.Pc=522;continue;}
case 522:{f.Push(f.Locals[6]);f.Pc=524;continue;}
case 524:{return rt.Call(f,"forge/game/combat/AttackConstraints","collectLegalAttackers","(Ljava/util/Map;Ljava/util/List;Lforge/game/card/CardCollection;I)Ljava/util/List;","invokevirtual",527);}
case 527:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",532);}
case 532:{f.StackOp("pop");f.Pc=533;continue;}
case 533:{f.Push(JValue.I(1));f.Pc=534;continue;}
case 534:{f.Locals[16]=f.Pop();f.Pc=536;continue;}
case 536:{f.Push(f.Locals[19]);f.Pc=538;continue;}
case 538:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",543);}
case 543:{f.Locals[20]=f.Pop();f.Pc=545;continue;}
case 545:{f.Push(f.Locals[20]);f.Pc=547;continue;}
case 547:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",552);}
case 552:{f.Pc=f.Pop().Int==0?709:555;continue;}
case 555:{f.Push(f.Locals[20]);f.Pc=557;continue;}
case 557:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",562);}
case 562:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/function/Predicate"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=565;continue;}
case 565:{f.Locals[21]=f.Pop();f.Pc=567;continue;}
case 567:{f.Push(f.Locals[8]);f.Pc=569;continue;}
case 569:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",574);}
case 574:{f.Push(f.Locals[3]);f.Pc=575;continue;}
case 575:{return rt.Call(f,"forge/game/card/CardCollection","asSet","()Ljava/util/Set;","invokevirtual",578);}
case 578:{return rt.Call(f,"com/google/common/collect/Sets","union","(Ljava/util/Set;Ljava/util/Set;)Lcom/google/common/collect/Sets$SetView;","invokestatic",581);}
case 581:{return rt.Call(f,"com/google/common/collect/Sets$SetView","stream","()Ljava/util/stream/Stream;","invokevirtual",584);}
case 584:{f.Push(f.Locals[21]);f.Pc=586;continue;}
case 586:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",591);}
case 591:{f.Pc=f.Pop().Int==0?597:594;continue;}
case 594:{f.Pc=545;continue;}
case 597:{f.Push(f.Locals[2]);f.Pc=598;continue;}
case 598:{f.Push(f.Locals[21]);f.Pc=600;continue;}
case 600:{return rt.Call(f,"forge/game/combat/AttackConstraints","findFirst","(Ljava/util/List;Ljava/util/function/Predicate;)Lforge/game/combat/AttackConstraints$Attack;","invokestatic",603);}
case 603:{f.Locals[22]=f.Pop();f.Pc=605;continue;}
case 605:{f.Push(f.Locals[22]);f.Pc=607;continue;}
case 607:{f.Pc=f.Pop().Reference!=null?628:610;continue;}
case 610:{f.Push(f.Locals[2]);f.Pc=611;continue;}
case 611:{f.Push(f.Locals[12]);f.Pc=613;continue;}
case 613:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=616;continue;}
case 616:{return rt.Call(f,"forge/game/combat/AttackConstraints","findAll","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",619);}
case 619:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",624);}
case 624:{f.StackOp("pop");f.Pc=625;continue;}
case 625:{f.Pc=44;continue;}
case 628:{f.Push(f.Locals[3]);f.Pc=629;continue;}
case 629:{f.Push(f.Locals[22]);f.Pc=631;continue;}
case 631:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=634;continue;}
case 634:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",637);}
case 637:{f.StackOp("pop");f.Pc=638;continue;}
case 638:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(-1)));f.Pc=641;continue;}
case 641:{f.Push(f.Locals[16]);f.Pc=643;continue;}
case 643:{f.Pc=f.Pop().Int!=0?706:646;continue;}
case 646:{f.Push(f.Locals[7]);f.Pc=648;continue;}
case 648:{f.Pc=f.Pop().Int==0?706:651;continue;}
case 651:{f.Push(f.Locals[2]);f.Pc=652;continue;}
case 652:{return rt.Call(f,"forge/game/combat/AttackConstraints","deepClone","(Ljava/util/List;)Ljava/util/List;","invokestatic",655);}
case 655:{f.Locals[23]=f.Pop();f.Pc=657;continue;}
case 657:{f.Push(f.Locals[23]);f.Pc=659;continue;}
case 659:{f.Push(f.Locals[12]);f.Pc=661;continue;}
case 661:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=664;continue;}
case 664:{return rt.Call(f,"forge/game/combat/AttackConstraints","findAll","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",667);}
case 667:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",672);}
case 672:{f.StackOp("pop");f.Pc=673;continue;}
case 673:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=676;continue;}
case 676:{f.StackOp("dup");f.Pc=677;continue;}
case 677:{f.Push(f.Locals[3]);f.Pc=678;continue;}
case 678:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",681);}
case 681:{f.Locals[24]=f.Pop();f.Pc=683;continue;}
case 683:{f.Push(f.Locals[5]);f.Pc=685;continue;}
case 685:{f.Push(f.Locals[0]);f.Pc=686;continue;}
case 686:{f.Push(f.Locals[8]);f.Pc=688;continue;}
case 688:{f.Push(f.Locals[23]);f.Pc=690;continue;}
case 690:{f.Push(f.Locals[24]);f.Pc=692;continue;}
case 692:{f.Push(f.Locals[6]);f.Pc=694;continue;}
case 694:{return rt.Call(f,"forge/game/combat/AttackConstraints","collectLegalAttackers","(Ljava/util/Map;Ljava/util/List;Lforge/game/card/CardCollection;I)Ljava/util/List;","invokevirtual",697);}
case 697:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",702);}
case 702:{f.StackOp("pop");f.Pc=703;continue;}
case 703:{f.Push(JValue.I(1));f.Pc=704;continue;}
case 704:{f.Locals[16]=f.Pop();f.Pc=706;continue;}
case 706:{f.Pc=545;continue;}
case 709:{f.Push(f.Locals[8]);f.Pc=711;continue;}
case 711:{f.Push(f.Locals[12]);f.Pc=713;continue;}
case 713:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=716;continue;}
case 716:{f.Push(f.Locals[12]);f.Pc=718;continue;}
case 718:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","defender","Lforge/game/GameEntity;"));f.Pc=721;continue;}
case 721:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",726);}
case 726:{f.StackOp("pop");f.Pc=727;continue;}
case 727:{f.Push(f.Locals[9]);f.Pc=729;continue;}
case 729:{f.Push(f.Locals[12]);f.Pc=731;continue;}
case 731:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","defender","Lforge/game/GameEntity;"));f.Pc=734;continue;}
case 734:{f.Push(JValue.I(1));f.Pc=735;continue;}
case 735:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",738);}
case 738:{return rt.DynamicCall(f,"forge/game/combat/AttackConstraints:5976:738:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BiFunction;",743);}
case 743:{return rt.Call(f,"java/util/Map","merge","(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;","invokeinterface",748);}
case 748:{f.StackOp("pop");f.Pc=749;continue;}
case 749:{f.Push(f.Locals[2]);f.Pc=750;continue;}
case 750:{f.Push(f.Locals[12]);f.Pc=752;continue;}
case 752:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=755;continue;}
case 755:{return rt.Call(f,"forge/game/combat/AttackConstraints","findAll","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokestatic",758);}
case 758:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",763);}
case 763:{f.StackOp("pop");f.Pc=764;continue;}
case 764:{f.Push(f.Locals[3]);f.Pc=765;continue;}
case 765:{f.Push(f.Locals[12]);f.Pc=767;continue;}
case 767:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=770;continue;}
case 770:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",773);}
case 773:{f.StackOp("pop");f.Pc=774;continue;}
case 774:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(-1)));f.Pc=777;continue;}
case 777:{f.Push(f.Locals[0]);f.Pc=778;continue;}
case 778:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","restrictions","Ljava/util/Map;"));f.Pc=781;continue;}
case 781:{f.Push(f.Locals[12]);f.Pc=783;continue;}
case 783:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=786;continue;}
case 786:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",791);}
case 791:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackRestriction"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=794;continue;}
case 794:{return rt.Call(f,"forge/game/combat/AttackRestriction","getTypes","()Ljava/util/Set;","invokevirtual",797);}
case 797:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_TWO_OTHERS","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_TWO_OTHERS","Lforge/game/combat/AttackRestrictionType;"));f.Pc=800;continue;}
case 800:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",805);}
case 805:{f.Pc=f.Pop().Int==0?849:808;continue;}
case 808:{f.Push(f.Locals[10]);f.Pc=810;continue;}
case 810:{f.Locals[20]=f.Pop();f.Pc=812;continue;}
case 812:{f.Push(JValue.I(3));f.Pc=813;continue;}
case 813:{f.Push(f.Locals[8]);f.Pc=815;continue;}
case 815:{return rt.Call(f,"java/util/Map","size","()I","invokeinterface",820);}
case 820:{f.Push(f.Locals[3]);f.Pc=821;continue;}
case 821:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",824);}
case 824:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=825;continue;}
case 825:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=826;continue;}
case 826:{f.Push(JValue.I(0));f.Pc=827;continue;}
case 827:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",830);}
case 830:{f.Locals[10]=f.Pop();f.Pc=832;continue;}
case 832:{f.Push(f.Locals[6]);f.Pc=834;continue;}
case 834:{f.Push(f.Locals[10]);f.Pc=836;continue;}
case 836:{f.Push(f.Locals[20]);f.Pc=838;continue;}
case 838:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=839;continue;}
case 839:{f.Push(JValue.I(0));f.Pc=840;continue;}
case 840:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",843);}
case 843:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=844;continue;}
case 844:{f.Locals[6]=f.Pop();f.Pc=846;continue;}
case 846:{f.Pc=900;continue;}
case 849:{f.Push(f.Locals[0]);f.Pc=850;continue;}
case 850:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","restrictions","Ljava/util/Map;"));f.Pc=853;continue;}
case 853:{f.Push(f.Locals[12]);f.Pc=855;continue;}
case 855:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=858;continue;}
case 858:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",863);}
case 863:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackRestriction"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=866;continue;}
case 866:{return rt.Call(f,"forge/game/combat/AttackRestriction","getTypes","()Ljava/util/Set;","invokevirtual",869);}
case 869:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NOT_ALONE","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NOT_ALONE","Lforge/game/combat/AttackRestrictionType;"));f.Pc=872;continue;}
case 872:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",877);}
case 877:{f.Pc=f.Pop().Int==0?900:880;continue;}
case 880:{f.Push(JValue.I(2));f.Pc=881;continue;}
case 881:{f.Push(f.Locals[8]);f.Pc=883;continue;}
case 883:{return rt.Call(f,"java/util/Map","size","()I","invokeinterface",888);}
case 888:{f.Push(f.Locals[3]);f.Pc=889;continue;}
case 889:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",892);}
case 892:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=893;continue;}
case 893:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=894;continue;}
case 894:{f.Push(JValue.I(0));f.Pc=895;continue;}
case 895:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",898);}
case 898:{f.Locals[10]=f.Pop();f.Pc=900;continue;}
case 900:{f.Pc=44;continue;}
case 903:{f.Push(f.Locals[3]);f.Pc=904;continue;}
case 904:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",907);}
case 907:{f.Pc=f.Pop().Int==0?925:910;continue;}
case 910:{f.Push(f.Locals[10]);f.Pc=912;continue;}
case 912:{f.Pc=f.Pop().Int!=0?925:915;continue;}
case 915:{f.Push(f.Locals[5]);f.Pc=917;continue;}
case 917:{f.Push(f.Locals[8]);f.Pc=919;continue;}
case 919:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",924);}
case 924:{f.StackOp("pop");f.Pc=925;continue;}
case 925:{f.Push(f.Locals[5]);f.Pc=927;continue;}
case 927:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5977(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","requirements","Ljava/util/Map;"));f.Pc=8;continue;}
case 8:{return rt.DynamicCall(f,"forge/game/combat/AttackConstraints:5977:8:java/lang/invoke/LambdaMetafactory.metafactory","()Lcom/google/common/base/Function;",13);}
case 13:{return rt.Call(f,"com/google/common/collect/Maps","transformValues","(Ljava/util/Map;Lcom/google/common/base/Function;)Ljava/util/Map;","invokestatic",16);}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",23);}
case 23:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",28);}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int==0?178:38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{f.Locals[4]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","restrictions","Ljava/util/Map;"));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[4]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",60);}
case 60:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackRestriction"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{f.Locals[5]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",77);}
case 77:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=80;continue;}
case 80:{f.Locals[6]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[6]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",89);}
case 89:{f.Locals[7]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",98);}
case 98:{f.Pc=f.Pop().Int==0?175:101;continue;}
case 101:{f.Push(f.Locals[7]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",108);}
case 108:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=111;continue;}
case 111:{f.Locals[8]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[5]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[8]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",120);}
case 120:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/combat/AttackRestriction","canAttack","(Lforge/game/GameEntity;)Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int==0?172:129;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{if(!rt.EnsureInitialized(f,"forge/game/combat/AttackConstraints$Attack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/AttackConstraints$Attack")));f.Pc=133;continue;}
case 133:{f.StackOp("dup");f.Pc=134;continue;}
case 134:{f.Push(f.Locals[4]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",141);}
case 141:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[8]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",149);}
case 149:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[8]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",157);}
case 157:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",163);}
case 163:{return rt.Call(f,"forge/game/combat/AttackConstraints$Attack","<init>","(Lforge/game/card/Card;Lforge/game/GameEntity;I)V","invokespecial",166);}
case 166:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",171);}
case 171:{f.StackOp("pop");f.Pc=172;continue;}
case 172:{f.Pc=91;continue;}
case 175:{f.Pc=29;continue;}
case 178:{f.Push(f.Locals[1]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/util/Comparator","reverseOrder","()Ljava/util/Comparator;","invokestatic",182);}
case 182:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",187);}
case 187:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=190;continue;}
case 190:{f.StackOp("dup");f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",194);}
case 194:{f.Locals[3]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[0]);f.Pc=196;continue;}
case 196:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","playerRequirements","Ljava/util/Map;"));f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",204);}
case 204:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",209);}
case 209:{f.Locals[4]=f.Pop();f.Pc=211;continue;}
case 211:{f.Push(f.Locals[4]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",218);}
case 218:{f.Pc=f.Pop().Int==0?425:221;continue;}
case 221:{f.Push(f.Locals[4]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",228);}
case 228:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=231;continue;}
case 231:{f.Locals[5]=f.Pop();f.Pc=233;continue;}
case 233:{return rt.Call(f,"com/google/common/collect/MultimapBuilder","hashKeys","()Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys;","invokestatic",236);}
case 236:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys","arrayListValues","()Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder;","invokevirtual",239);}
case 239:{f.Push(f.Locals[5]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",246);}
case 246:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=249;continue;}
case 249:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$ListMultimapBuilder","build","(Lcom/google/common/collect/Multimap;)Lcom/google/common/collect/ListMultimap;","invokevirtual",252);}
case 252:{f.Locals[6]=f.Pop();f.Pc=254;continue;}
case 254:{f.Push(f.Locals[6]);f.Pc=256;continue;}
case 256:{return rt.Call(f,"com/google/common/collect/Multimap","isEmpty","()Z","invokeinterface",261);}
case 261:{f.Pc=f.Pop().Int!=0?422:264;continue;}
case 264:{f.Push(f.Locals[6]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"com/google/common/collect/Multimap","asMap","()Ljava/util/Map;","invokeinterface",271);}
case 271:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",276);}
case 276:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",281);}
case 281:{return rt.DynamicCall(f,"forge/game/combat/AttackConstraints:5977:281:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",286);}
case 286:{return rt.Call(f,"java/util/Comparator","comparing","(Ljava/util/function/Function;)Ljava/util/Comparator;","invokestatic",289);}
case 289:{return rt.Call(f,"java/util/stream/Stream","max","(Ljava/util/Comparator;)Ljava/util/Optional;","invokeinterface",294);}
case 294:{f.Push(JValue.R(null));f.Pc=295;continue;}
case 295:{return rt.Call(f,"java/util/Optional","orElse","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",298);}
case 298:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=301;continue;}
case 301:{f.Locals[7]=f.Pop();f.Pc=303;continue;}
case 303:{f.Push(f.Locals[1]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",309);}
case 309:{f.Push(f.Locals[3]);f.Pc=310;continue;}
case 310:{f.Push(f.Locals[7]);f.Pc=312;continue;}
case 312:{f.Push(f.Locals[5]);f.Pc=314;continue;}
case 314:{return rt.DynamicCall(f,"forge/game/combat/AttackConstraints:5977:314:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/CardCollection;Ljava/util/Map$Entry;Ljava/util/Map$Entry;)Ljava/util/function/Predicate;",319);}
case 319:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",324);}
case 324:{return rt.Call(f,"java/util/stream/Stream","findFirst","()Ljava/util/Optional;","invokeinterface",329);}
case 329:{f.Push(JValue.R(null));f.Pc=330;continue;}
case 330:{return rt.Call(f,"java/util/Optional","orElse","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",333);}
case 333:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackConstraints$Attack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=336;continue;}
case 336:{f.Locals[8]=f.Pop();f.Pc=338;continue;}
case 338:{f.Push(f.Locals[8]);f.Pc=340;continue;}
case 340:{f.Pc=f.Pop().Reference==null?404:343;continue;}
case 343:{f.Push(f.Locals[8]);f.Pc=345;continue;}
case 345:{f.StackOp("dup");f.Pc=346;continue;}
case 346:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","requirements","I"));f.Pc=349;continue;}
case 349:{f.Push(f.Locals[7]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",356);}
case 356:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=359;continue;}
case 359:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",364);}
case 364:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=365;continue;}
case 365:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","requirements","I",value);f.Pc=368;continue;}
case 368:{f.Push(f.Locals[3]);f.Pc=369;continue;}
case 369:{f.Push(f.Locals[8]);f.Pc=371;continue;}
case 371:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=374;continue;}
case 374:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",377);}
case 377:{f.StackOp("pop");f.Pc=378;continue;}
case 378:{f.Push(f.Locals[6]);f.Pc=380;continue;}
case 380:{return rt.Call(f,"com/google/common/collect/Multimap","values","()Ljava/util/Collection;","invokeinterface",385);}
case 385:{f.Push(f.Locals[7]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",392);}
case 392:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=395;continue;}
case 395:{return rt.Call(f,"java/util/Collection","removeAll","(Ljava/util/Collection;)Z","invokeinterface",400);}
case 400:{f.StackOp("pop");f.Pc=401;continue;}
case 401:{f.Pc=419;continue;}
case 404:{f.Push(f.Locals[6]);f.Pc=406;continue;}
case 406:{f.Push(f.Locals[7]);f.Pc=408;continue;}
case 408:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",413);}
case 413:{return rt.Call(f,"com/google/common/collect/Multimap","removeAll","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",418);}
case 418:{f.StackOp("pop");f.Pc=419;continue;}
case 419:{f.Pc=254;continue;}
case 422:{f.Pc=211;continue;}
case 425:{f.Push(f.Locals[3]);f.Pc=426;continue;}
case 426:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",429);}
case 429:{f.Pc=f.Pop().Int!=0?441:432;continue;}
case 432:{f.Push(f.Locals[1]);f.Pc=433;continue;}
case 433:{return rt.Call(f,"java/util/Comparator","reverseOrder","()Ljava/util/Comparator;","invokestatic",436);}
case 436:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",441);}
case 441:{f.Push(f.Locals[1]);f.Pc=442;continue;}
case 442:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5978(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newLinkedList","()Ljava/util/LinkedList;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?48:20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackConstraints$Attack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{if(!rt.EnsureInitialized(f,"forge/game/combat/AttackConstraints$Attack"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/combat/AttackConstraints$Attack")));f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/combat/AttackConstraints$Attack","<init>","(Lforge/game/combat/AttackConstraints$Attack;)V","invokespecial",39);}
case 39:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",44);}
case 44:{f.StackOp("pop");f.Pc=45;continue;}
case 45:{f.Pc=11;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5979(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?44:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackConstraints$Attack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",36);}
case 36:{f.Pc=f.Pop().Int==0?41:39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
case 41:{f.Pc=7;continue;}
case 44:{f.Push(JValue.R(null));f.Pc=45;continue;}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5980(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.StackOp("dup");f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",6);}
case 6:{f.StackOp("pop");f.Pc=7;continue;}
case 7:{return rt.DynamicCall(f,"forge/game/combat/AttackConstraints:5980:7:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",12);}
case 12:{return rt.Call(f,"forge/game/combat/AttackConstraints","findFirst","(Ljava/util/List;Ljava/util/function/Predicate;)Lforge/game/combat/AttackConstraints$Attack;","invokestatic",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5981(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/combat/AttackConstraints:5981:1:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;)Ljava/util/function/Predicate;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5982(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","globalRestrictions","Lforge/game/combat/GlobalAttackRestrictions;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/combat/GlobalAttackRestrictions","isLegal","(Ljava/util/Map;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int!=0?13:11;continue;}
case 11:{f.Push(JValue.I(-1));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",19);}
case 19:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",24);}
case 24:{f.Locals[2]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",31);}
case 31:{f.Pc=f.Pop().Int==0?92:34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","restrictions","Ljava/util/Map;"));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",54);}
case 54:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",59);}
case 59:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackRestriction"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=62;continue;}
case 62:{f.Locals[4]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Reference==null?89:69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",77);}
case 77:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/combat/AttackRestriction","canAttack","(Lforge/game/GameEntity;Ljava/util/Map;)Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int!=0?89:87;continue;}
case 87:{f.Push(JValue.I(-1));f.Pc=88;continue;}
case 88:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 89:{f.Pc=25;continue;}
case 92:{f.Push(JValue.I(0));f.Pc=93;continue;}
case 93:{f.Locals[2]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","possibleAttackers","Lforge/game/card/CardCollection;"));f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",101);}
case 101:{f.Locals[3]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[3]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",108);}
case 108:{f.Pc=f.Pop().Int==0?166:111;continue;}
case 111:{f.Push(f.Locals[3]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",117);}
case 117:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=120;continue;}
case 120:{f.Locals[4]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","requirements","Ljava/util/Map;"));f.Pc=126;continue;}
case 126:{f.Push(f.Locals[4]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",133);}
case 133:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/combat/AttackRequirement"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=136;continue;}
case 136:{f.Locals[5]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[5]);f.Pc=140;continue;}
case 140:{f.Pc=f.Pop().Reference==null?163:143;continue;}
case 143:{f.Push(f.Locals[2]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[5]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[4]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",154);}
case 154:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[1]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/combat/AttackRequirement","countViolations","(Lforge/game/GameEntity;Ljava/util/Map;)I","invokevirtual",161);}
case 161:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=162;continue;}
case 162:{f.Locals[2]=f.Pop();f.Pc=163;continue;}
case 163:{f.Pc=102;continue;}
case 166:{f.Push(f.Locals[0]);f.Pc=167;continue;}
case 167:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints","playerRequirements","Ljava/util/Map;"));f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",175);}
case 175:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",180);}
case 180:{f.Locals[3]=f.Pop();f.Pc=181;continue;}
case 181:{f.Push(f.Locals[3]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",187);}
case 187:{f.Pc=f.Pop().Int==0?331:190;continue;}
case 190:{f.Push(f.Locals[3]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",196);}
case 196:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=199;continue;}
case 199:{f.Locals[4]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(f.Locals[1]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",207);}
case 207:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",212);}
case 212:{f.Push(f.Locals[4]);f.Pc=214;continue;}
case 214:{return rt.DynamicCall(f,"forge/game/combat/AttackConstraints:5982:214:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Map$Entry;)Ljava/util/function/Predicate;",219);}
case 219:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",224);}
case 224:{return rt.DynamicCall(f,"forge/game/combat/AttackConstraints:5982:224:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",229);}
case 229:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",234);}
case 234:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",237);}
case 237:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",242);}
case 242:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=245;continue;}
case 245:{f.Locals[5]=f.Pop();f.Pc=247;continue;}
case 247:{return rt.Call(f,"com/google/common/collect/MultimapBuilder","hashKeys","()Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys;","invokestatic",250);}
case 250:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys","arrayListValues","()Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder;","invokevirtual",253);}
case 253:{return rt.Call(f,"com/google/common/collect/MultimapBuilder$ListMultimapBuilder","build","()Lcom/google/common/collect/ListMultimap;","invokevirtual",256);}
case 256:{f.Locals[6]=f.Pop();f.Pc=258;continue;}
case 258:{f.Push(f.Locals[4]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",265);}
case 265:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[6]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"com/google/common/collect/Multimaps","invertFrom","(Lcom/google/common/collect/Multimap;Lcom/google/common/collect/Multimap;)Lcom/google/common/collect/Multimap;","invokestatic",273);}
case 273:{return rt.Call(f,"com/google/common/collect/Multimap","asMap","()Ljava/util/Map;","invokeinterface",278);}
case 278:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",283);}
case 283:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",288);}
case 288:{f.Locals[7]=f.Pop();f.Pc=290;continue;}
case 290:{f.Push(f.Locals[7]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",297);}
case 297:{f.Pc=f.Pop().Int==0?328:300;continue;}
case 300:{f.Push(f.Locals[7]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",307);}
case 307:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=310;continue;}
case 310:{f.Locals[8]=f.Pop();f.Pc=312;continue;}
case 312:{f.Push(f.Locals[8]);f.Pc=314;continue;}
case 314:{f.Push(f.Locals[5]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"java/util/Collections","disjoint","(Ljava/util/Collection;Ljava/util/Collection;)Z","invokestatic",319);}
case 319:{f.Pc=f.Pop().Int==0?325:322;continue;}
case 322:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=325;continue;}
case 325:{f.Pc=290;continue;}
case 328:{f.Pc=181;continue;}
case 331:{f.Push(f.Locals[2]);f.Pc=332;continue;}
case 332:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5983(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",12);}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",18);}
case 18:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",21);}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5984(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5985(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[3]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int!=0?71:11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","defender","Lforge/game/GameEntity;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",21);}
case 21:{return rt.Call(f,"forge/game/GameEntity","equals","(Ljava/lang/Object;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?71:27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",34);}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",40);}
case 40:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int==0?71:46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",53);}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","attacker","Lforge/game/card/Card;"));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackConstraints$Attack","defender","Lforge/game/GameEntity;"));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/combat/CombatUtil","getAttackCost","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/GameEntity;)Lforge/game/cost/Cost;","invokestatic",64);}
case 64:{f.Pc=f.Pop().Reference!=null?71:67;continue;}
case 67:{f.Push(JValue.I(1));f.Pc=68;continue;}
case 68:{f.Pc=72;continue;}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5986(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",14);}
case 14:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5987(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",15);}
case 15:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=18;continue;}
case 18:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5988(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int!=0?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
