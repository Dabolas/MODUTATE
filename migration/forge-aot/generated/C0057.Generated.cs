// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C57{
internal static JClass Build(){var c=new JClass("forge/card/DeckHints","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("valid","Z",false,JValue.Default("Z"),null));
c.Add(new JField("tokens","Z",false,JValue.Default("Z"),null));
c.Add(new JField("filters","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("TOKEN_RULES_CACHE","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("tokenRulesCacheOwner","Lforge/token/TokenDb;",true,JValue.Default("Lforge/token/TokenDb;"),null));
c.Add(new JMethod(1016,"forge/card/DeckHints","<init>","(Ljava/lang/String;)V",1,8,3,new JHandler[]{},M1016));
c.Add(new JMethod(1017,"forge/card/DeckHints","isValid","()Z",1,1,1,new JHandler[]{},M1017));
c.Add(new JMethod(1018,"forge/card/DeckHints","contains","(Lforge/card/DeckHints$Type;Ljava/lang/String;)Z",1,5,2,new JHandler[]{},M1018));
c.Add(new JMethod(1019,"forge/card/DeckHints","is","(Lforge/card/DeckHints$Type;[Ljava/lang/String;)Z",1,10,2,new JHandler[]{},M1019));
c.Add(new JMethod(1020,"forge/card/DeckHints","filterByType","(Ljava/lang/Iterable;)Ljava/util/Map;",1,8,5,new JHandler[]{},M1020));
c.Add(new JMethod(1021,"forge/card/DeckHints","filter","(Ljava/lang/Iterable;)Ljava/lang/Iterable;",1,2,2,new JHandler[]{},M1021));
c.Add(new JMethod(1022,"forge/card/DeckHints","parseHint","(Ljava/lang/String;)Lorg/apache/commons/lang3/tuple/Pair;",2,9,3,new JHandler[]{new JHandler(15,78,81,"java/lang/IllegalArgumentException")},M1022));
c.Add(new JMethod(1023,"forge/card/DeckHints","getCardsForFilter","(Ljava/lang/Iterable;Lforge/card/DeckHints$Type;Ljava/lang/String;)Ljava/util/List;",2,12,4,new JHandler[]{},M1023));
c.Add(new JMethod(1024,"forge/card/DeckHints","getMatchingItems","(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Function;)Ljava/lang/Iterable;",2,5,3,new JHandler[]{},M1024));
c.Add(new JMethod(1025,"forge/card/DeckHints","rulesWithTokens","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;",9,2,2,new JHandler[]{},M1025));
c.Add(new JMethod(1026,"forge/card/DeckHints","getTokenRules","(Lforge/token/TokenDb;Ljava/lang/String;)Lforge/card/CardRules;",10,4,3,new JHandler[]{new JHandler(13,34,37,""),new JHandler(37,40,37,"")},M1026));
c.Add(new JMethod(1027,"forge/card/DeckHints","lambda$rulesWithTokens$1","(Ljava/util/function/Predicate;Lforge/token/TokenDb;Lforge/card/CardRules;)Z",4106,6,2,new JHandler[]{},M1027));
c.Add(new JMethod(1028,"forge/card/DeckHints","lambda$getMatchingItems$0","(Ljava/util/function/Predicate;Ljava/util/function/Function;Lforge/item/PaperCard;)Z",4106,3,3,new JHandler[]{},M1028));
c.Add(new JMethod(1029,"forge/card/DeckHints","<clinit>","()V",8,0,2,new JHandler[]{},M1029));
}

internal static JStep M1016(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/DeckHints","valid","Z",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/DeckHints","tokens","Z",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(null));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/DeckHints","filters","Ljava/util/List;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("\\&")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",25);}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=28;continue;}
case 28:{f.Pc=f.Pop().Int<=0?145:31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=35;continue;}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{f.Locals[5]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?145:47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=51;continue;}
case 51:{f.Locals[6]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[6]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",59);}
case 59:{return rt.Call(f,"forge/card/DeckHints","parseHint","(Ljava/lang/String;)Lorg/apache/commons/lang3/tuple/Pair;","invokevirtual",62);}
case 62:{f.Locals[7]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[7]);f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Reference==null?139:69;continue;}
case 69:{f.Push(f.Locals[7]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getKey","()Ljava/lang/Object;","invokevirtual",74);}
case 74:{if(!rt.StaticReady(f,"forge/card/DeckHints$Type","MODIFIER","Lforge/card/DeckHints$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DeckHints$Type","MODIFIER","Lforge/card/DeckHints$Type;"));f.Pc=77;continue;}
case 77:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?104:80;continue;}
case 80:{f.Push(f.Locals[7]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",85);}
case 85:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String("NoToken")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int==0?139:96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(JValue.I(0));f.Pc=98;continue;}
case 98:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/DeckHints","tokens","Z",value);f.Pc=101;continue;}
case 101:{f.Pc=139;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(rt.GetField(f.Pop(),"forge/card/DeckHints","filters","Ljava/util/List;"));f.Pc=108;continue;}
case 108:{f.Pc=f.Pop().Reference!=null?122:111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=115;continue;}
case 115:{f.StackOp("dup");f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",119);}
case 119:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/DeckHints","filters","Ljava/util/List;",value);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{f.Push(rt.GetField(f.Pop(),"forge/card/DeckHints","filters","Ljava/util/List;"));f.Pc=126;continue;}
case 126:{f.Push(f.Locals[7]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",133);}
case 133:{f.StackOp("pop");f.Pc=134;continue;}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{f.Push(JValue.I(1));f.Pc=136;continue;}
case 136:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/DeckHints","valid","Z",value);f.Pc=139;continue;}
case 139:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=142;continue;}
case 142:{f.Pc=40;continue;}
case 145:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1017(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/DeckHints","valid","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1018(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/DeckHints","filters","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/card/DeckHints","filters","Ljava/util/List;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",18);}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?68:28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[4]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",44);}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?65:48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",53);}
case 53:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int==0?65:63;continue;}
case 63:{f.Push(JValue.I(1));f.Pc=64;continue;}
case 64:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 65:{f.Pc=19;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1019(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/DeckHints","filters","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Locals[4]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[4]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=17;continue;}
case 17:{f.Locals[5]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Locals[6]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[6]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?114:29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[6]);f.Pc=33;continue;}
case 33:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=34;continue;}
case 34:{f.Locals[7]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/card/DeckHints","filters","Ljava/util/List;"));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",45);}
case 45:{f.Locals[8]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[8]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",54);}
case 54:{f.Pc=f.Pop().Int==0?108:57;continue;}
case 57:{f.Push(f.Locals[8]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",64);}
case 64:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=67;continue;}
case 67:{f.Locals[9]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[9]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",74);}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?105:78;continue;}
case 78:{f.Push(f.Locals[9]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",83);}
case 83:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[7]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?105:94;continue;}
case 94:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=100;continue;}
case 100:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?105:103;continue;}
case 103:{f.Push(JValue.I(1));f.Pc=104;continue;}
case 104:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 105:{f.Pc=47;continue;}
case 108:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=111;continue;}
case 111:{f.Pc=22;continue;}
case 114:{f.Push(JValue.I(0));f.Pc=115;continue;}
case 115:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1020(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/card/DeckHints","filters","Ljava/util/List;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?120:27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/DeckHints$Type"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{f.Locals[5]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",53);}
case 53:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=56;continue;}
case 56:{f.Locals[6]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[6]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/card/DeckHints","getCardsForFilter","(Ljava/lang/Iterable;Lforge/card/DeckHints$Type;Ljava/lang/String;)Ljava/util/List;","invokevirtual",67);}
case 67:{f.Locals[7]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[5]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",77);}
case 77:{f.Pc=f.Pop().Int==0?106:80;continue;}
case 80:{f.Push(f.Locals[7]);f.Pc=82;continue;}
case 82:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=85;continue;}
case 85:{f.StackOp("dup");f.Pc=86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",94);}
case 94:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",100);}
case 100:{return rt.Call(f,"java/util/List","retainAll","(Ljava/util/Collection;)Z","invokeinterface",105);}
case 105:{f.StackOp("pop");f.Pc=106;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[5]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[7]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",116);}
case 116:{f.StackOp("pop");f.Pc=117;continue;}
case 117:{f.Pc=18;continue;}
case 120:{f.Push(f.Locals[2]);f.Pc=121;continue;}
case 121:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1021(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/DeckHints","filterByType","(Ljava/lang/Iterable;)Ljava/util/Map;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",10);}
case 10:{return rt.Call(f,"com/google/common/collect/Iterables","concat","(Ljava/lang/Iterable;)Ljava/lang/Iterable;","invokestatic",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1022(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("\\$")));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=11;continue;}
case 11:{f.Push(JValue.I(2));f.Pc=12;continue;}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?83:15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","toUpperCase","()Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/card/DeckHints$Type","valueOf","(Ljava/lang/String;)Lforge/card/DeckHints$Type;","invokestatic",24);}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/card/DeckHints$Type","values","()[Lforge/card/DeckHints$Type;","invokestatic",29);}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=34;continue;}
case 34:{f.Locals[6]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{f.Locals[7]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[7]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[6]);f.Pc=43;continue;}
case 43:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?78:46;continue;}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[7]);f.Pc=50;continue;}
case 50:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=51;continue;}
case 51:{f.Locals[8]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[4]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[8]);f.Pc=57;continue;}
case 57:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?72:60;continue;}
case 60:{f.Push(f.Locals[8]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{f.Push(JValue.I(1));f.Pc=64;continue;}
case 64:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=65;continue;}
case 65:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","of","(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",68);}
case 68:{f.Locals[2]=f.Pop();f.Pc=69;continue;}
case 69:{f.Pc=78;continue;}
case 72:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=75;continue;}
case 75:{f.Pc=39;continue;}
case 78:{f.Pc=83;continue;}
case 81:{f.Locals[4]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1023(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[4]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("\\|")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Locals[5]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[5]);f.Pc=19;continue;}
case 19:{f.Locals[6]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[6]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=24;continue;}
case 24:{f.Locals[7]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{f.Locals[8]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[8]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[7]);f.Pc=33;continue;}
case 33:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?82:36;continue;}
case 36:{f.Push(f.Locals[6]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[8]);f.Pc=40;continue;}
case 40:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=41;continue;}
case 41:{f.Locals[9]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[9]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/card/CardRulesPredicates","deckHas","(Lforge/card/DeckHints$Type;Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",51);}
case 51:{return rt.DynamicCall(f,"forge/card/DeckHints:1023:51:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",56);}
case 56:{return rt.Call(f,"forge/card/DeckHints","getMatchingItems","(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Function;)Ljava/lang/Iterable;","invokevirtual",59);}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{f.StackOp("dup");f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{return rt.DynamicCall(f,"forge/card/DeckHints:1023:66:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/List;)Ljava/util/function/Consumer;",71);}
case 71:{return rt.Call(f,"java/lang/Iterable","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",76);}
case 76:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=79;continue;}
case 79:{f.Pc=29;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=85;continue;}
case 85:{f.Push(JValue.I(1));f.Pc=86;continue;}
case 86:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?122:89;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[5]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/card/CardRulesPredicates","deckHasExactly","(Lforge/card/DeckHints$Type;[Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",97);}
case 97:{return rt.DynamicCall(f,"forge/card/DeckHints:1023:97:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",102);}
case 102:{return rt.Call(f,"forge/card/DeckHints","getMatchingItems","(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Function;)Ljava/lang/Iterable;","invokevirtual",105);}
case 105:{f.Push(f.Locals[4]);f.Pc=107;continue;}
case 107:{f.StackOp("dup");f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",111);}
case 111:{f.StackOp("pop");f.Pc=112;continue;}
case 112:{return rt.DynamicCall(f,"forge/card/DeckHints:1023:112:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/List;)Ljava/util/function/Consumer;",117);}
case 117:{return rt.Call(f,"java/lang/Iterable","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",122);}
case 122:{f.Push(f.Locals[5]);f.Pc=124;continue;}
case 124:{f.Locals[6]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[6]);f.Pc=128;continue;}
case 128:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=129;continue;}
case 129:{f.Locals[7]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(JValue.I(0));f.Pc=132;continue;}
case 132:{f.Locals[8]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[8]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[7]);f.Pc=138;continue;}
case 138:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?432:141;continue;}
case 141:{f.Push(f.Locals[6]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[8]);f.Pc=145;continue;}
case 145:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=146;continue;}
case 146:{f.Locals[9]=f.Pop();f.Pc=148;continue;}
case 148:{if(!rt.StaticReady(f,"forge/card/DeckHints$1","$SwitchMap$forge$card$DeckHints$Type","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DeckHints$1","$SwitchMap$forge$card$DeckHints$Type","[I"));f.Pc=151;continue;}
case 151:{f.Push(f.Locals[2]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/card/DeckHints$Type","ordinal","()I","invokevirtual",155);}
case 155:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=156;continue;}
case 156:{switch(f.Pop().Int){case 1:f.Pc=196;break;case 2:f.Pc=289;break;case 3:f.Pc=324;break;case 4:f.Pc=362;break;case 5:f.Pc=426;break;case 6:f.Pc=426;break;default:f.Pc=426;break;}continue;}
case 196:{f.Push(JValue.I(1));f.Pc=197;continue;}
case 197:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=200;continue;}
case 200:{f.StackOp("dup");f.Pc=201;continue;}
case 201:{f.Push(JValue.I(0));f.Pc=202;continue;}
case 202:{f.Push(f.Locals[9]);f.Pc=204;continue;}
case 204:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/card/ColorSet","fromNames","([Ljava/lang/String;)Lforge/card/ColorSet;","invokestatic",208);}
case 208:{f.Locals[10]=f.Pop();f.Pc=210;continue;}
case 210:{f.Push(f.Locals[10]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/card/ColorSet","isColorless","()Z","invokevirtual",215);}
case 215:{f.Pc=f.Pop().Int==0?251:218;continue;}
case 218:{f.Push(f.Locals[0]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[1]);f.Pc=220;continue;}
case 220:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_COLORLESS","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_COLORLESS","Ljava/util/function/Predicate;"));f.Pc=223;continue;}
case 223:{return rt.DynamicCall(f,"forge/card/DeckHints:1023:223:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",228);}
case 228:{return rt.Call(f,"forge/card/DeckHints","getMatchingItems","(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Function;)Ljava/lang/Iterable;","invokevirtual",231);}
case 231:{f.Push(f.Locals[4]);f.Pc=233;continue;}
case 233:{f.StackOp("dup");f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",237);}
case 237:{f.StackOp("pop");f.Pc=238;continue;}
case 238:{return rt.DynamicCall(f,"forge/card/DeckHints:1023:238:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/List;)Ljava/util/function/Consumer;",243);}
case 243:{return rt.Call(f,"java/lang/Iterable","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",248);}
case 248:{f.Pc=426;continue;}
case 251:{f.Push(f.Locals[0]);f.Pc=252;continue;}
case 252:{f.Push(f.Locals[1]);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[10]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",258);}
case 258:{return rt.Call(f,"forge/card/CardRulesPredicates","isColor","(B)Ljava/util/function/Predicate;","invokestatic",261);}
case 261:{return rt.DynamicCall(f,"forge/card/DeckHints:1023:261:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",266);}
case 266:{return rt.Call(f,"forge/card/DeckHints","getMatchingItems","(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Function;)Ljava/lang/Iterable;","invokevirtual",269);}
case 269:{f.Push(f.Locals[4]);f.Pc=271;continue;}
case 271:{f.StackOp("dup");f.Pc=272;continue;}
case 272:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",275);}
case 275:{f.StackOp("pop");f.Pc=276;continue;}
case 276:{return rt.DynamicCall(f,"forge/card/DeckHints:1023:276:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/List;)Ljava/util/function/Consumer;",281);}
case 281:{return rt.Call(f,"java/lang/Iterable","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",286);}
case 286:{f.Pc=426;continue;}
case 289:{f.Push(f.Locals[0]);f.Pc=290;continue;}
case 290:{f.Push(f.Locals[1]);f.Pc=291;continue;}
case 291:{f.Push(f.Locals[9]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/card/CardRulesPredicates","hasKeyword","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",296);}
case 296:{return rt.DynamicCall(f,"forge/card/DeckHints:1023:296:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",301);}
case 301:{return rt.Call(f,"forge/card/DeckHints","getMatchingItems","(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Function;)Ljava/lang/Iterable;","invokevirtual",304);}
case 304:{f.Push(f.Locals[4]);f.Pc=306;continue;}
case 306:{f.StackOp("dup");f.Pc=307;continue;}
case 307:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",310);}
case 310:{f.StackOp("pop");f.Pc=311;continue;}
case 311:{return rt.DynamicCall(f,"forge/card/DeckHints:1023:311:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/List;)Ljava/util/function/Consumer;",316);}
case 316:{return rt.Call(f,"java/lang/Iterable","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",321);}
case 321:{f.Pc=426;continue;}
case 324:{f.Push(f.Locals[0]);f.Pc=325;continue;}
case 325:{f.Push(f.Locals[1]);f.Pc=326;continue;}
case 326:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","EQUALS","Lforge/util/PredicateString$StringOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/PredicateString$StringOp","EQUALS","Lforge/util/PredicateString$StringOp;"));f.Pc=329;continue;}
case 329:{f.Push(f.Locals[9]);f.Pc=331;continue;}
case 331:{return rt.Call(f,"forge/card/CardRulesPredicates","name","(Lforge/util/PredicateString$StringOp;Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",334);}
case 334:{return rt.DynamicCall(f,"forge/card/DeckHints:1023:334:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",339);}
case 339:{return rt.Call(f,"forge/card/DeckHints","getMatchingItems","(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Function;)Ljava/lang/Iterable;","invokevirtual",342);}
case 342:{f.Push(f.Locals[4]);f.Pc=344;continue;}
case 344:{f.StackOp("dup");f.Pc=345;continue;}
case 345:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",348);}
case 348:{f.StackOp("pop");f.Pc=349;continue;}
case 349:{return rt.DynamicCall(f,"forge/card/DeckHints:1023:349:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/List;)Ljava/util/function/Consumer;",354);}
case 354:{return rt.Call(f,"java/lang/Iterable","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",359);}
case 359:{f.Pc=426;continue;}
case 362:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","CONTAINS_IC","Lforge/util/PredicateString$StringOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/PredicateString$StringOp","CONTAINS_IC","Lforge/util/PredicateString$StringOp;"));f.Pc=365;continue;}
case 365:{f.Push(f.Locals[9]);f.Pc=367;continue;}
case 367:{return rt.Call(f,"forge/card/CardRulesPredicates","joinedType","(Lforge/util/PredicateString$StringOp;Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",370);}
case 370:{f.Locals[11]=f.Pop();f.Pc=372;continue;}
case 372:{f.Push(f.Locals[9]);f.Pc=374;continue;}
case 374:{return rt.Call(f,"forge/card/CardType","isACreatureType","(Ljava/lang/String;)Z","invokestatic",377);}
case 377:{f.Pc=f.Pop().Int==0?394:380;continue;}
case 380:{f.Push(f.Locals[11]);f.Pc=382;continue;}
case 382:{f.Push(JValue.R(rt.String("Changeling")));f.Pc=384;continue;}
case 384:{return rt.Call(f,"forge/card/CardRulesPredicates","hasKeyword","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",387);}
case 387:{return rt.Call(f,"java/util/function/Predicate","or","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",392);}
case 392:{f.Locals[11]=f.Pop();f.Pc=394;continue;}
case 394:{f.Push(f.Locals[0]);f.Pc=395;continue;}
case 395:{f.Push(f.Locals[1]);f.Pc=396;continue;}
case 396:{f.Push(f.Locals[11]);f.Pc=398;continue;}
case 398:{return rt.DynamicCall(f,"forge/card/DeckHints:1023:398:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",403);}
case 403:{return rt.Call(f,"forge/card/DeckHints","getMatchingItems","(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Function;)Ljava/lang/Iterable;","invokevirtual",406);}
case 406:{f.Push(f.Locals[4]);f.Pc=408;continue;}
case 408:{f.StackOp("dup");f.Pc=409;continue;}
case 409:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",412);}
case 412:{f.StackOp("pop");f.Pc=413;continue;}
case 413:{return rt.DynamicCall(f,"forge/card/DeckHints:1023:413:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/List;)Ljava/util/function/Consumer;",418);}
case 418:{return rt.Call(f,"java/lang/Iterable","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",423);}
case 423:{f.Pc=426;continue;}
case 426:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=429;continue;}
case 429:{f.Pc=134;continue;}
case 432:{f.Push(f.Locals[4]);f.Pc=434;continue;}
case 434:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1024(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/DeckHints","tokens","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?14:7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/DeckHints","rulesWithTokens","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",11);}
case 11:{f.Pc=15;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Locals[4]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return rt.DynamicCall(f,"forge/card/DeckHints:1024:21:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/function/Predicate;Ljava/util/function/Function;)Ljava/util/function/Predicate;",26);}
case 26:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",29);}
case 29:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1025(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{f.Pc=f.Pop().Reference==null?16:6;continue;}
case 6:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",9);}
case 9:{return rt.Call(f,"forge/StaticData","getAllTokens","()Lforge/token/TokenDb;","invokevirtual",12);}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Pc=18;continue;}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{f.Locals[1]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.DynamicCall(f,"forge/card/DeckHints:1025:20:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/function/Predicate;Lforge/token/TokenDb;)Ljava/util/function/Predicate;",25);}
case 25:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1026(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/DeckHints","tokenRulesCacheOwner","Lforge/token/TokenDb;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DeckHints","tokenRulesCacheOwner","Lforge/token/TokenDb;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?42:7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/card/DeckHints","TOKEN_RULES_CACHE","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DeckHints","TOKEN_RULES_CACHE","Ljava/util/Map;"));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{rt.EnterMonitor(rt.NonNull(f.Pop()));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/DeckHints","tokenRulesCacheOwner","Lforge/token/TokenDb;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DeckHints","tokenRulesCacheOwner","Lforge/token/TokenDb;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?32:20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/card/DeckHints","TOKEN_RULES_CACHE","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DeckHints","TOKEN_RULES_CACHE","Ljava/util/Map;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Map","clear","()V","invokeinterface",28);}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/card/DeckHints","tokenRulesCacheOwner","Lforge/token/TokenDb;"))return JStep.Continue;rt.PutStatic("forge/card/DeckHints","tokenRulesCacheOwner","Lforge/token/TokenDb;",f.Pop());f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=34;continue;}
case 34:{f.Pc=42;continue;}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{rt.ExitMonitor(rt.NonNull(f.Pop()));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 42:{if(!rt.StaticReady(f,"forge/card/DeckHints","TOKEN_RULES_CACHE","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DeckHints","TOKEN_RULES_CACHE","Ljava/util/Map;"));f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[2]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{f.Pc=f.Pop().Reference!=null?91:59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/token/TokenDb","getToken","(Ljava/lang/String;)Lforge/item/PaperToken;","invokevirtual",64);}
case 64:{f.Locals[3]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Reference!=null?71:69;continue;}
case 69:{f.Push(JValue.R(null));f.Pc=70;continue;}
case 70:{return JStep.Return(f.Pop());}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/item/PaperToken","getRules","()Lforge/card/CardRules;","invokevirtual",75);}
case 75:{f.Locals[2]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{f.Pc=f.Pop().Reference==null?91:80;continue;}
case 80:{if(!rt.StaticReady(f,"forge/card/DeckHints","TOKEN_RULES_CACHE","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DeckHints","TOKEN_RULES_CACHE","Ljava/util/Map;"));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",90);}
case 90:{f.StackOp("pop");f.Pc=91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1027(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",7);}
case 7:{f.Pc=f.Pop().Int==0?12:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/CardRules","getTokens","()Ljava/util/List;","invokevirtual",16);}
case 16:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",21);}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int==0?90:31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[4]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Pc=f.Pop().Reference==null?22:46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/token/TokenDb","containsRule","(Ljava/lang/String;)Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int!=0?58:55;continue;}
case 55:{f.Pc=22;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/card/DeckHints","getTokenRules","(Lforge/token/TokenDb;Ljava/lang/String;)Lforge/card/CardRules;","invokestatic",64);}
case 64:{f.Locals[5]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[5]);f.Pc=68;continue;}
case 68:{f.Pc=f.Pop().Reference==null?87:71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/card/DeckHints","rulesWithTokens","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",75);}
case 75:{f.Push(f.Locals[5]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",82);}
case 82:{f.Pc=f.Pop().Int==0?87:85;continue;}
case 85:{f.Push(JValue.I(1));f.Pc=86;continue;}
case 86:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 87:{f.Pc=22;continue;}
case 90:{f.Push(JValue.I(0));f.Pc=91;continue;}
case 91:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1028(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",16);}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1029(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentHashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","<init>","()V","invokespecial",7);}
case 7:{if(!rt.StaticReady(f,"forge/card/DeckHints","TOKEN_RULES_CACHE","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/card/DeckHints","TOKEN_RULES_CACHE","Ljava/util/Map;",f.Pop());f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/card/DeckHints","tokenRulesCacheOwner","Lforge/token/TokenDb;"))return JStep.Continue;rt.PutStatic("forge/card/DeckHints","tokenRulesCacheOwner","Lforge/token/TokenDb;",f.Pop());f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
