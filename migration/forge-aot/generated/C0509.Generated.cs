// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C509{
internal static JClass Build(){var c=new JClass("forge/game/combat/AttackRestriction","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("attacker","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("restrictions","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("cantAttack","Z",false,JValue.Default("Z"),null));
c.Add(new JField("cantAttackDefender","Lforge/util/collect/FCollectionView;",false,JValue.Default("Lforge/util/collect/FCollectionView;"),null));
c.Add(new JMethod(6001,"forge/game/combat/AttackRestriction","<init>","(Lforge/game/card/Card;Lforge/util/collect/FCollectionView;)V",1,6,2,new JHandler[]{},M6001));
c.Add(new JMethod(6002,"forge/game/combat/AttackRestriction","canAttack","(Lforge/game/GameEntity;)Z",1,2,2,new JHandler[]{},M6002));
c.Add(new JMethod(6003,"forge/game/combat/AttackRestriction","getViolation","(Ljava/util/Map;)Ljava/util/Set;",1,4,3,new JHandler[]{},M6003));
c.Add(new JMethod(6004,"forge/game/combat/AttackRestriction","canAttack","(Lforge/game/GameEntity;Ljava/util/Map;)Z",1,3,2,new JHandler[]{},M6004));
c.Add(new JMethod(6005,"forge/game/combat/AttackRestriction","getTypes","()Ljava/util/Set;",1,1,1,new JHandler[]{},M6005));
c.Add(new JMethod(6006,"forge/game/combat/AttackRestriction","setRestrictions","()V",2,1,2,new JHandler[]{},M6006));
}

internal static JStep M6001(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.ClassObject("forge/game/combat/AttackRestrictionType")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",10);}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackRestriction","restrictions","Ljava/util/Set;",value);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackRestriction","attacker","Lforge/game/card/Card;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/combat/AttackRestriction","setRestrictions","()V","invokevirtual",22);}
case 22:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",29);}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",36);}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",45);}
case 45:{f.Pc=f.Pop().Int==0?79:48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",55);}
case 55:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=58;continue;}
case 58:{f.Locals[5]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/combat/CombatUtil","canAttack","(Lforge/game/card/Card;Lforge/game/GameEntity;)Z","invokestatic",66);}
case 66:{f.Pc=f.Pop().Int!=0?76:69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[5]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Pc=38;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackRestriction","cantAttackDefender","Lforge/util/collect/FCollectionView;",value);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","restrictions","Ljava/util/Set;"));f.Pc=88;continue;}
case 88:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",96);}
case 96:{f.Pc=f.Pop().Int==0?159:99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","restrictions","Ljava/util/Set;"));f.Pc=103;continue;}
case 103:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",111);}
case 111:{f.Pc=f.Pop().Int!=0?187:114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","restrictions","Ljava/util/Set;"));f.Pc=118;continue;}
case 118:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"));f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",126);}
case 126:{f.Pc=f.Pop().Int!=0?187:129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","restrictions","Ljava/util/Set;"));f.Pc=133;continue;}
case 133:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NOT_ALONE","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NOT_ALONE","Lforge/game/combat/AttackRestrictionType;"));f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",141);}
case 141:{f.Pc=f.Pop().Int!=0?187:144;continue;}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","restrictions","Ljava/util/Set;"));f.Pc=148;continue;}
case 148:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_TWO_OTHERS","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_TWO_OTHERS","Lforge/game/combat/AttackRestrictionType;"));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",156);}
case 156:{f.Pc=f.Pop().Int!=0?187:159;continue;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","restrictions","Ljava/util/Set;"));f.Pc=163;continue;}
case 163:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEVER","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEVER","Lforge/game/combat/AttackRestrictionType;"));f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",171);}
case 171:{f.Pc=f.Pop().Int!=0?187:174;continue;}
case 174:{f.Push(f.Locals[3]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/util/collect/FCollection","size","()I","invokevirtual",178);}
case 178:{f.Push(f.Locals[2]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/util/collect/FCollectionView","size","()I","invokeinterface",184);}
case 184:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?192:187;continue;}
case 187:{f.Push(f.Locals[0]);f.Pc=188;continue;}
case 188:{f.Push(JValue.I(1));f.Pc=189;continue;}
case 189:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackRestriction","cantAttack","Z",value);f.Pc=192;continue;}
case 192:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6002(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","cantAttack","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?24:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","cantAttackDefender","Lforge/util/collect/FCollectionView;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/util/collect/FCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int!=0?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6003(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/combat/AttackRestrictionType")));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",5);}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","size","()I","invokeinterface",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","restrictions","Ljava/util/Set;"));f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?43:28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?43:33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","restrictions","Ljava/util/Set;"));f.Pc=47;continue;}
case 47:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int==0?97:58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",64);}
case 64:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",69);}
case 69:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"));f.Pc=72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","attacker","Lforge/game/card/Card;"));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/combat/AttackRestrictionType","getPredicate","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokevirtual",79);}
case 79:{return rt.Call(f,"java/util/stream/Stream","noneMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",84);}
case 84:{f.Pc=f.Pop().Int==0?97:87;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",96);}
case 96:{f.StackOp("pop");f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","restrictions","Ljava/util/Set;"));f.Pc=101;continue;}
case 101:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"));f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",109);}
case 109:{f.Pc=f.Pop().Int==0?151:112;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",118);}
case 118:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",123);}
case 123:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"));f.Pc=126;continue;}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","attacker","Lforge/game/card/Card;"));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/combat/AttackRestrictionType","getPredicate","(Lforge/game/card/Card;)Ljava/util/function/Predicate;","invokevirtual",133);}
case 133:{return rt.Call(f,"java/util/stream/Stream","noneMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",138);}
case 138:{f.Pc=f.Pop().Int==0?151:141;continue;}
case 141:{f.Push(f.Locals[2]);f.Pc=142;continue;}
case 142:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"));f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",150);}
case 150:{f.StackOp("pop");f.Pc=151;continue;}
case 151:{f.Push(f.Locals[0]);f.Pc=152;continue;}
case 152:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","restrictions","Ljava/util/Set;"));f.Pc=155;continue;}
case 155:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NOT_ALONE","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NOT_ALONE","Lforge/game/combat/AttackRestrictionType;"));f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",163);}
case 163:{f.Pc=f.Pop().Int==0?181:166;continue;}
case 166:{f.Push(f.Locals[3]);f.Pc=167;continue;}
case 167:{f.Push(JValue.I(1));f.Pc=168;continue;}
case 168:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?181:171;continue;}
case 171:{f.Push(f.Locals[2]);f.Pc=172;continue;}
case 172:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NOT_ALONE","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NOT_ALONE","Lforge/game/combat/AttackRestrictionType;"));f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",180);}
case 180:{f.StackOp("pop");f.Pc=181;continue;}
case 181:{f.Push(f.Locals[0]);f.Pc=182;continue;}
case 182:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","restrictions","Ljava/util/Set;"));f.Pc=185;continue;}
case 185:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_TWO_OTHERS","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_TWO_OTHERS","Lforge/game/combat/AttackRestrictionType;"));f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",193);}
case 193:{f.Pc=f.Pop().Int==0?211:196;continue;}
case 196:{f.Push(f.Locals[3]);f.Pc=197;continue;}
case 197:{f.Push(JValue.I(2));f.Pc=198;continue;}
case 198:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?211:201;continue;}
case 201:{f.Push(f.Locals[2]);f.Pc=202;continue;}
case 202:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_TWO_OTHERS","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_TWO_OTHERS","Lforge/game/combat/AttackRestrictionType;"));f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",210);}
case 210:{f.StackOp("pop");f.Pc=211;continue;}
case 211:{f.Push(f.Locals[2]);f.Pc=212;continue;}
case 212:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6004(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/combat/AttackRestriction","canAttack","(Lforge/game/GameEntity;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int!=0?10:8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/combat/AttackRestriction","getViolation","(Ljava/util/Map;)Ljava/util/Set;","invokevirtual",15);}
case 15:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",20);}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6005(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","restrictions","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Collections","unmodifiableSet","(Ljava/util/Set;)Ljava/util/Set;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6006(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","attacker","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("CARDNAME can only attack alone.")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?25:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","restrictions","Ljava/util/Set;"));f.Pc=16;continue;}
case 16:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","ONLY_ALONE","Lforge/game/combat/AttackRestrictionType;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","attacker","Lforge/game/card/Card;"));f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("CARDNAME can't attack unless a creature with greater power also attacks.")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?50:37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","restrictions","Ljava/util/Set;"));f.Pc=41;continue;}
case 41:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_GREATER_POWER","Lforge/game/combat/AttackRestrictionType;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",49);}
case 49:{f.StackOp("pop");f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","attacker","Lforge/game/card/Card;"));f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("CARDNAME can't attack unless a black or green creature also attacks.")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int==0?75:62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","restrictions","Ljava/util/Set;"));f.Pc=66;continue;}
case 66:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_BLACK_OR_GREEN","Lforge/game/combat/AttackRestrictionType;"));f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{f.Push(f.Locals[0]);f.Pc=76;continue;}
case 76:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","attacker","Lforge/game/card/Card;"));f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("CARDNAME can't attack or block alone.")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int!=0?99:87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","attacker","Lforge/game/card/Card;"));f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("CARDNAME can't attack alone.")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int==0?112:99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","restrictions","Ljava/util/Set;"));f.Pc=103;continue;}
case 103:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NOT_ALONE","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NOT_ALONE","Lforge/game/combat/AttackRestrictionType;"));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",111);}
case 111:{f.StackOp("pop");f.Pc=112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","attacker","Lforge/game/card/Card;"));f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("CARDNAME can't attack unless at least two other creatures attack.")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int==0?137:124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackRestriction","restrictions","Ljava/util/Set;"));f.Pc=128;continue;}
case 128:{if(!rt.StaticReady(f,"forge/game/combat/AttackRestrictionType","NEED_TWO_OTHERS","Lforge/game/combat/AttackRestrictionType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/combat/AttackRestrictionType","NEED_TWO_OTHERS","Lforge/game/combat/AttackRestrictionType;"));f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",136);}
case 136:{f.StackOp("pop");f.Pc=137;continue;}
case 137:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
