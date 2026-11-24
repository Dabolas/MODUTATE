// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1090{
internal static JClass Build(){var c=new JClass("forge/token/TokenDb","java/lang/Object",new string[]{"forge/token/ITokenDatabase"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("allTokenByName","Lcom/google/common/collect/Multimap;",false,JValue.Default("Lcom/google/common/collect/Multimap;"),null));
c.Add(new JField("extraTokensByName","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("editions","Lforge/card/CardEdition$Collection;",false,JValue.Default("Lforge/card/CardEdition$Collection;"),null));
c.Add(new JField("rulesByName","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("missingEditions","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("defaultEditionFilter","Ljava/util/function/Predicate;",false,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("restrictedTokenEntries","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("preferEraMatchedArt","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(11506,"forge/token/TokenDb","<init>","(Ljava/util/Map;Lforge/card/CardEdition$Collection;)V",1,3,2,new JHandler[]{},M11506));
c.Add(new JMethod(11507,"forge/token/TokenDb","setDefaultEditionFilter","(Ljava/util/function/Predicate;)V",1,2,2,new JHandler[]{},M11507));
c.Add(new JMethod(11508,"forge/token/TokenDb","setRestrictedTokenEntries","(Ljava/util/Set;)V",1,2,2,new JHandler[]{},M11508));
c.Add(new JMethod(11509,"forge/token/TokenDb","setPreferEraMatchedArt","(Z)V",1,2,2,new JHandler[]{},M11509));
c.Add(new JMethod(11510,"forge/token/TokenDb","containsRule","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M11510));
c.Add(new JMethod(11511,"forge/token/TokenDb","preloadTokens","()V",1,9,6,new JHandler[]{},M11511));
c.Add(new JMethod(11512,"forge/token/TokenDb","loadTokenFromSet","(Lforge/card/CardEdition;Ljava/lang/String;)Z",4,6,6,new JHandler[]{},M11512));
c.Add(new JMethod(11513,"forge/token/TokenDb","addTokenInSet","(Lforge/card/CardEdition;Ljava/lang/String;Lforge/card/CardEdition$EditionEntry;)Lforge/item/PaperToken;",4,5,7,new JHandler[]{},M11513));
c.Add(new JMethod(11514,"forge/token/TokenDb","getTokenFromEditions","(Ljava/lang/String;Ljava/util/function/Predicate;Ljava/util/Date;)Lforge/item/PaperToken;",1,11,5,new JHandler[]{},M11514));
c.Add(new JMethod(11515,"forge/token/TokenDb","fallbackToken","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperToken;",4,5,4,new JHandler[]{},M11515));
c.Add(new JMethod(11516,"forge/token/TokenDb","getToken","(Ljava/lang/String;)Lforge/item/PaperToken;",1,2,3,new JHandler[]{},M11516));
c.Add(new JMethod(11517,"forge/token/TokenDb","getToken","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperToken;",1,3,4,new JHandler[]{},M11517));
c.Add(new JMethod(11518,"forge/token/TokenDb","getToken","(Ljava/lang/String;Ljava/lang/String;I)Lforge/item/PaperToken;",1,9,7,new JHandler[]{new JHandler(201,237,238,"java/lang/Exception")},M11518));
c.Add(new JMethod(11519,"forge/token/TokenDb","getTokenFromEditions","(Ljava/lang/String;Lforge/card/CardDb$CardArtPreference;)Lforge/item/PaperToken;",1,3,1,new JHandler[]{},M11519));
c.Add(new JMethod(11520,"forge/token/TokenDb","getTokenFromEditions","(Ljava/lang/String;Ljava/util/Date;Lforge/card/CardDb$CardArtPreference;)Lforge/item/PaperToken;",1,4,1,new JHandler[]{},M11520));
c.Add(new JMethod(11521,"forge/token/TokenDb","getTokenFromEditions","(Ljava/lang/String;Ljava/util/Date;Lforge/card/CardDb$CardArtPreference;I)Lforge/item/PaperToken;",1,5,1,new JHandler[]{},M11521));
c.Add(new JMethod(11522,"forge/token/TokenDb","getFoiled","(Lforge/item/PaperToken;)Lforge/item/PaperToken;",1,2,1,new JHandler[]{},M11522));
c.Add(new JMethod(11523,"forge/token/TokenDb","getPrintCount","(Ljava/lang/String;Ljava/lang/String;)I",1,3,1,new JHandler[]{},M11523));
c.Add(new JMethod(11524,"forge/token/TokenDb","getMaxPrintCount","(Ljava/lang/String;)I",1,2,1,new JHandler[]{},M11524));
c.Add(new JMethod(11525,"forge/token/TokenDb","getArtCount","(Ljava/lang/String;Ljava/lang/String;)I",1,3,1,new JHandler[]{},M11525));
c.Add(new JMethod(11526,"forge/token/TokenDb","getUniqueTokens","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M11526));
c.Add(new JMethod(11527,"forge/token/TokenDb","getAllTokens","()Ljava/util/List;",1,1,3,new JHandler[]{},M11527));
c.Add(new JMethod(11528,"forge/token/TokenDb","getAllTokens","(Ljava/lang/String;)Ljava/util/List;",1,2,1,new JHandler[]{},M11528));
c.Add(new JMethod(11529,"forge/token/TokenDb","getAllTokens","(Ljava/util/function/Predicate;)Ljava/util/List;",1,2,1,new JHandler[]{},M11529));
c.Add(new JMethod(11530,"forge/token/TokenDb","wasPrintedInSets","(Ljava/util/List;)Ljava/util/function/Predicate;",1,2,1,new JHandler[]{},M11530));
c.Add(new JMethod(11531,"forge/token/TokenDb","iterator","()Ljava/util/Iterator;",1,1,1,new JHandler[]{},M11531));
c.Add(new JMethod(11532,"forge/token/TokenDb","getRules","()Ljava/util/Map;",1,1,1,new JHandler[]{},M11532));
}

internal static JStep M11506(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/HashMultimap","create","()Lcom/google/common/collect/HashMultimap;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/token/TokenDb","allTokenByName","Lcom/google/common/collect/Multimap;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"com/google/common/collect/Maps","newTreeMap","(Ljava/util/Comparator;)Ljava/util/TreeMap;","invokestatic",18);}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/token/TokenDb","extraTokensByName","Ljava/util/Map;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"com/google/common/collect/Sets","newConcurrentHashSet","()Ljava/util/Set;","invokestatic",25);}
case 25:{var value=f.Pop();rt.PutField(f.Pop(),"forge/token/TokenDb","missingEditions","Ljava/util/Set;",value);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(null));f.Pc=30;continue;}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/token/TokenDb","defaultEditionFilter","Ljava/util/function/Predicate;",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Collections","emptySet","()Ljava/util/Set;","invokestatic",37);}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/token/TokenDb","restrictedTokenEntries","Ljava/util/Set;",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/token/TokenDb","preferEraMatchedArt","Z",value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{var value=f.Pop();rt.PutField(f.Pop(),"forge/token/TokenDb","rulesByName","Ljava/util/Map;",value);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{var value=f.Pop();rt.PutField(f.Pop(),"forge/token/TokenDb","editions","Lforge/card/CardEdition$Collection;",value);f.Pc=55;continue;}
case 55:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11507(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/token/TokenDb","defaultEditionFilter","Ljava/util/function/Predicate;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11508(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Pc=f.Pop().Reference==null?9:5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=12;continue;}
case 9:{return rt.Call(f,"java/util/Collections","emptySet","()Ljava/util/Set;","invokestatic",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/token/TokenDb","restrictedTokenEntries","Ljava/util/Set;",value);f.Pc=15;continue;}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11509(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/token/TokenDb","preferEraMatchedArt","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11510(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","rulesByName","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11511(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardEdition$Collection","iterator","()Ljava/util/Iterator;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int==0?174:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/card/CardEdition","getTokens","()Lcom/google/common/collect/Multimap;","invokevirtual",31);}
case 31:{return rt.Call(f,"com/google/common/collect/Multimap","asMap","()Ljava/util/Map;","invokeinterface",36);}
case 36:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",41);}
case 41:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",46);}
case 46:{f.Locals[3]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",53);}
case 53:{f.Pc=f.Pop().Int==0?171:56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",62);}
case 62:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=65;continue;}
case 65:{f.Locals[4]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",74);}
case 74:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=77;continue;}
case 77:{f.Locals[5]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("%s_%s")));f.Pc=81;continue;}
case 81:{f.Push(JValue.I(2));f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=85;continue;}
case 85:{f.StackOp("dup");f.Pc=86;continue;}
case 86:{f.Push(JValue.I(0));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(1));f.Pc=92;continue;}
case 92:{f.Push(f.Locals[2]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",96);}
case 96:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",99);}
case 99:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",103);}
case 103:{f.Locals[6]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[4]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",112);}
case 112:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",120);}
case 120:{f.Locals[7]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[7]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",129);}
case 129:{f.Pc=f.Pop().Int==0?168:132;continue;}
case 132:{f.Push(f.Locals[7]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",139);}
case 139:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=142;continue;}
case 142:{f.Locals[8]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","allTokenByName","Lcom/google/common/collect/Multimap;"));f.Pc=148;continue;}
case 148:{f.Push(f.Locals[6]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[2]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[5]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[8]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/token/TokenDb","addTokenInSet","(Lforge/card/CardEdition;Ljava/lang/String;Lforge/card/CardEdition$EditionEntry;)Lforge/item/PaperToken;","invokevirtual",159);}
case 159:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",164);}
case 164:{f.StackOp("pop");f.Pc=165;continue;}
case 165:{f.Pc=122;continue;}
case 168:{f.Pc=47;continue;}
case 171:{f.Pc=8;continue;}
case 174:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11512(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("%s_%s")));f.Pc=2;continue;}
case 2:{f.Push(JValue.I(2));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=6;continue;}
case 6:{f.StackOp("dup");f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",16);}
case 16:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",19);}
case 19:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",23);}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","allTokenByName","Lcom/google/common/collect/Multimap;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"com/google/common/collect/Multimap","containsKey","(Ljava/lang/Object;)Z","invokeinterface",34);}
case 34:{f.Pc=f.Pop().Int==0?39:37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/card/CardEdition","getTokens","()Lcom/google/common/collect/Multimap;","invokevirtual",43);}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"com/google/common/collect/Multimap","containsKey","(Ljava/lang/Object;)Z","invokeinterface",49);}
case 49:{f.Pc=f.Pop().Int!=0?54:52;continue;}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/card/CardEdition","getTokens","()Lcom/google/common/collect/Multimap;","invokevirtual",58);}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",64);}
case 64:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",69);}
case 69:{f.Locals[4]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",78);}
case 78:{f.Pc=f.Pop().Int==0?115:81;continue;}
case 81:{f.Push(f.Locals[4]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",88);}
case 88:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition$EditionEntry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=91;continue;}
case 91:{f.Locals[5]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","allTokenByName","Lcom/google/common/collect/Multimap;"));f.Pc=97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[5]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/token/TokenDb","addTokenInSet","(Lforge/card/CardEdition;Ljava/lang/String;Lforge/card/CardEdition$EditionEntry;)Lforge/item/PaperToken;","invokevirtual",106);}
case 106:{return rt.Call(f,"com/google/common/collect/Multimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",111);}
case 111:{f.StackOp("pop");f.Pc=112;continue;}
case 112:{f.Pc=71;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11513(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","rulesByName","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?31:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","rulesByName","Ljava/util/Map;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{f.Pc=82;continue;}
case 31:{f.Push(JValue.R(rt.String("w_2_2_spirit")));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int!=0?49:40;continue;}
case 40:{f.Push(JValue.R(rt.String("w_3_3_spirit")));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?68:49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","rulesByName","Ljava/util/Map;"));f.Pc=53;continue;}
case 53:{f.Push(JValue.R(rt.String("w_x_x_spirit")));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",60);}
case 60:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=63;continue;}
case 63:{f.Locals[4]=f.Pop();f.Pc=65;continue;}
case 65:{f.Pc=82;continue;}
case 68:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=71;continue;}
case 71:{f.StackOp("dup");f.Pc=72;continue;}
case 72:{f.Push(f.Locals[2]);f.Pc=73;continue;}
case 73:{return rt.DynamicCall(f,"forge/token/TokenDb:11513:73:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",78);}
case 78:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",81);}
case 81:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 82:{if(!rt.EnsureInitialized(f,"forge/item/PaperToken"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperToken")));f.Pc=85;continue;}
case 85:{f.StackOp("dup");f.Pc=86;continue;}
case 86:{f.Push(f.Locals[4]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[3]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","collectorNumber","()Ljava/lang/String;","invokevirtual",94);}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/card/CardEdition$EditionEntry","artistName","()Ljava/lang/String;","invokevirtual",98);}
case 98:{return rt.Call(f,"forge/item/PaperToken","<init>","(Lforge/card/CardRules;Lforge/card/CardEdition;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",101);}
case 101:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11514(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?120:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardEdition$Collection","iterator","()Ljava/util/Iterator;","invokevirtual",11);}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",20);}
case 20:{f.Pc=f.Pop().Int==0?118:23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[5]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","restrictedTokenEntries","Ljava/util/Set;"));f.Pc=39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.DynamicCall(f,"forge/token/TokenDb:11514:45:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",50);}
case 50:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int==0?61:58;continue;}
case 58:{f.Pc=13;continue;}
case 61:{f.Push(JValue.R(rt.String("%s_%s")));f.Pc=63;continue;}
case 63:{f.Push(JValue.I(2));f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=67;continue;}
case 67:{f.StackOp("dup");f.Pc=68;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=71;continue;}
case 71:{f.StackOp("dup");f.Pc=72;continue;}
case 72:{f.Push(JValue.I(1));f.Pc=73;continue;}
case 73:{f.Push(f.Locals[5]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",78);}
case 78:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",81);}
case 81:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",85);}
case 85:{f.Locals[6]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[5]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/token/TokenDb","loadTokenFromSet","(Lforge/card/CardEdition;Ljava/lang/String;)Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?115:97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","allTokenByName","Lcom/google/common/collect/Multimap;"));f.Pc=101;continue;}
case 101:{f.Push(f.Locals[6]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",108);}
case 108:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",111);}
case 111:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperToken"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=114;continue;}
case 114:{return JStep.Return(f.Pop());}
case 115:{f.Pc=13;continue;}
case 118:{f.Push(JValue.R(null));f.Pc=119;continue;}
case 119:{return JStep.Return(f.Pop());}
case 120:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=123;continue;}
case 123:{f.StackOp("dup");f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",127);}
case 127:{f.Locals[4]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/card/CardEdition$Collection","iterator","()Ljava/util/Iterator;","invokevirtual",136);}
case 136:{f.Locals[5]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[5]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",145);}
case 145:{f.Pc=f.Pop().Int==0?223:148;continue;}
case 148:{f.Push(f.Locals[5]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",155);}
case 155:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=158;continue;}
case 158:{f.Locals[6]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[6]);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[1]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/token/TokenDb","loadTokenFromSet","(Lforge/card/CardEdition;Ljava/lang/String;)Z","invokevirtual",167);}
case 167:{f.Pc=f.Pop().Int!=0?173:170;continue;}
case 170:{f.Pc=138;continue;}
case 173:{f.Push(f.Locals[0]);f.Pc=174;continue;}
case 174:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","restrictedTokenEntries","Ljava/util/Set;"));f.Pc=177;continue;}
case 177:{f.Push(f.Locals[6]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",182);}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{return rt.DynamicCall(f,"forge/token/TokenDb:11514:183:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",188);}
case 188:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",193);}
case 193:{f.Pc=f.Pop().Int==0?199:196;continue;}
case 196:{f.Pc=138;continue;}
case 199:{f.Push(f.Locals[2]);f.Pc=200;continue;}
case 200:{f.Push(f.Locals[6]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",207);}
case 207:{f.Pc=f.Pop().Int==0?220:210;continue;}
case 210:{f.Push(f.Locals[4]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[6]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",219);}
case 219:{f.StackOp("pop");f.Pc=220;continue;}
case 220:{f.Pc=138;continue;}
case 223:{f.Push(f.Locals[4]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",230);}
case 230:{f.Pc=f.Pop().Int==0?235:233;continue;}
case 233:{f.Push(JValue.R(null));f.Pc=234;continue;}
case 234:{return JStep.Return(f.Pop());}
case 235:{f.Push(f.Locals[0]);f.Pc=236;continue;}
case 236:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","preferEraMatchedArt","Z"));f.Pc=239;continue;}
case 239:{f.Pc=f.Pop().Int==0?355:242;continue;}
case 242:{f.Push(f.Locals[3]);f.Pc=243;continue;}
case 243:{f.Pc=f.Pop().Reference==null?355:246;continue;}
case 246:{f.Push(f.Locals[4]);f.Pc=248;continue;}
case 248:{f.Push(JValue.I(0));f.Pc=249;continue;}
case 249:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",254);}
case 254:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=257;continue;}
case 257:{f.Locals[5]=f.Pop();f.Pc=259;continue;}
case 259:{f.Push(f.Locals[5]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",264);}
case 264:{return rt.Call(f,"java/util/Date","getTime","()J","invokevirtual",267);}
case 267:{f.Push(f.Locals[3]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"java/util/Date","getTime","()J","invokevirtual",271);}
case 271:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=272;continue;}
case 272:{return rt.Call(f,"java/lang/Math","abs","(J)J","invokestatic",275);}
case 275:{f.Locals[6]=f.Pop();f.Pc=277;continue;}
case 277:{f.Push(JValue.I(1));f.Pc=278;continue;}
case 278:{f.Locals[8]=f.Pop();f.Pc=280;continue;}
case 280:{f.Push(f.Locals[8]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[4]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",289);}
case 289:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?352:292;continue;}
case 292:{f.Push(f.Locals[4]);f.Pc=294;continue;}
case 294:{f.Push(f.Locals[8]);f.Pc=296;continue;}
case 296:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",301);}
case 301:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",307);}
case 307:{return rt.Call(f,"java/util/Date","getTime","()J","invokevirtual",310);}
case 310:{f.Push(f.Locals[3]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"java/util/Date","getTime","()J","invokevirtual",314);}
case 314:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lsub",a,b));f.Pc=315;continue;}
case 315:{return rt.Call(f,"java/lang/Math","abs","(J)J","invokestatic",318);}
case 318:{f.Locals[9]=f.Pop();f.Pc=320;continue;}
case 320:{f.Push(f.Locals[9]);f.Pc=322;continue;}
case 322:{f.Push(f.Locals[6]);f.Pc=324;continue;}
case 324:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=325;continue;}
case 325:{f.Pc=f.Pop().Int>=0?346:328;continue;}
case 328:{f.Push(f.Locals[9]);f.Pc=330;continue;}
case 330:{f.Locals[6]=f.Pop();f.Pc=332;continue;}
case 332:{f.Push(f.Locals[4]);f.Pc=334;continue;}
case 334:{f.Push(f.Locals[8]);f.Pc=336;continue;}
case 336:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",341);}
case 341:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=344;continue;}
case 344:{f.Locals[5]=f.Pop();f.Pc=346;continue;}
case 346:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=349;continue;}
case 349:{f.Pc=280;continue;}
case 352:{f.Pc=365;continue;}
case 355:{f.Push(f.Locals[4]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",360);}
case 360:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=363;continue;}
case 363:{f.Locals[5]=f.Pop();f.Pc=365;continue;}
case 365:{f.Push(JValue.R(rt.String("%s_%s")));f.Pc=367;continue;}
case 367:{f.Push(JValue.I(2));f.Pc=368;continue;}
case 368:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=371;continue;}
case 371:{f.StackOp("dup");f.Pc=372;continue;}
case 372:{f.Push(JValue.I(0));f.Pc=373;continue;}
case 373:{f.Push(f.Locals[1]);f.Pc=374;continue;}
case 374:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=375;continue;}
case 375:{f.StackOp("dup");f.Pc=376;continue;}
case 376:{f.Push(JValue.I(1));f.Pc=377;continue;}
case 377:{f.Push(f.Locals[5]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",382);}
case 382:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",385);}
case 385:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=386;continue;}
case 386:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",389);}
case 389:{f.Locals[6]=f.Pop();f.Pc=391;continue;}
case 391:{f.Push(f.Locals[0]);f.Pc=392;continue;}
case 392:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","allTokenByName","Lcom/google/common/collect/Multimap;"));f.Pc=395;continue;}
case 395:{f.Push(f.Locals[6]);f.Pc=397;continue;}
case 397:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",402);}
case 402:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",405);}
case 405:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperToken"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=408;continue;}
case 408:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11515(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[3]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Reference==null?27:6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Reference==null?27:21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","defaultEditionFilter","Ljava/util/function/Predicate;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/token/TokenDb","getTokenFromEditions","(Ljava/lang/String;Ljava/util/function/Predicate;Ljava/util/Date;)Lforge/item/PaperToken;","invokevirtual",37);}
case 37:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11516(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/token/TokenDb","getToken","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperToken;","invokevirtual",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11517(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(-1));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/token/TokenDb","getToken","(Ljava/lang/String;Ljava/lang/String;I)Lforge/item/PaperToken;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11518(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","editions","Lforge/card/CardEdition$Collection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",8);}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference!=null?65:15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Pc=f.Pop().Reference==null?60:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?60:26;continue;}
case 26:{f.Push(JValue.R(rt.String("???")));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int!=0?60:35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","missingEditions","Ljava/util/Set;"));f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",45);}
case 45:{f.Pc=f.Pop().Int==0?60:48;continue;}
case 48:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.DynamicCall(f,"forge/token/TokenDb:11518:52:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",57);}
case 57:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",60);}
case 60:{if(!rt.StaticReady(f,"forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition","UNKNOWN","Lforge/card/CardEdition;"));f.Pc=63;continue;}
case 63:{f.Locals[4]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("%s_%s")));f.Pc=67;continue;}
case 67:{f.Push(JValue.I(2));f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=71;continue;}
case 71:{f.StackOp("dup");f.Pc=72;continue;}
case 72:{f.Push(JValue.I(0));f.Pc=73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=75;continue;}
case 75:{f.StackOp("dup");f.Pc=76;continue;}
case 76:{f.Push(JValue.I(1));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",82);}
case 82:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",85);}
case 85:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",89);}
case 89:{f.Locals[5]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[4]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/token/TokenDb","loadTokenFromSet","(Lforge/card/CardEdition;Ljava/lang/String;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?151:101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","allTokenByName","Lcom/google/common/collect/Multimap;"));f.Pc=105;continue;}
case 105:{f.Push(f.Locals[5]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"com/google/common/collect/Multimap","get","(Ljava/lang/Object;)Ljava/util/Collection;","invokeinterface",112);}
case 112:{f.Locals[6]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[3]);f.Pc=115;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?130:119;continue;}
case 119:{f.Push(f.Locals[3]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[6]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",127);}
case 127:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?139:130;continue;}
case 130:{f.Push(f.Locals[6]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",135);}
case 135:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperToken"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=138;continue;}
case 138:{return JStep.Return(f.Pop());}
case 139:{f.Push(f.Locals[6]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[3]);f.Pc=142;continue;}
case 142:{f.Push(JValue.I(1));f.Pc=143;continue;}
case 143:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=144;continue;}
case 144:{return rt.Call(f,"com/google/common/collect/Iterables","get","(Ljava/lang/Iterable;I)Ljava/lang/Object;","invokestatic",147);}
case 147:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperToken"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=150;continue;}
case 150:{return JStep.Return(f.Pop());}
case 151:{f.Push(f.Locals[0]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[1]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[2]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/token/TokenDb","fallbackToken","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperToken;","invokevirtual",157);}
case 157:{f.Locals[6]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[6]);f.Pc=161;continue;}
case 161:{f.Pc=f.Pop().Reference==null?167:164;continue;}
case 164:{f.Push(f.Locals[6]);f.Pc=166;continue;}
case 166:{return JStep.Return(f.Pop());}
case 167:{f.Push(f.Locals[0]);f.Pc=168;continue;}
case 168:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","rulesByName","Ljava/util/Map;"));f.Pc=171;continue;}
case 171:{f.Push(f.Locals[1]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",177);}
case 177:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=180;continue;}
case 180:{f.Locals[7]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(f.Locals[0]);f.Pc=183;continue;}
case 183:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","extraTokensByName","Ljava/util/Map;"));f.Pc=186;continue;}
case 186:{f.Push(f.Locals[5]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",193);}
case 193:{f.Pc=f.Pop().Int!=0?243:196;continue;}
case 196:{f.Push(f.Locals[7]);f.Pc=198;continue;}
case 198:{f.Pc=f.Pop().Reference==null?243:201;continue;}
case 201:{if(!rt.EnsureInitialized(f,"forge/item/PaperToken"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PaperToken")));f.Pc=204;continue;}
case 204:{f.StackOp("dup");f.Pc=205;continue;}
case 205:{f.Push(f.Locals[7]);f.Pc=207;continue;}
case 207:{f.Push(f.Locals[4]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[1]);f.Pc=210;continue;}
case 210:{f.Push(JValue.R(rt.String("")));f.Pc=213;continue;}
case 213:{f.Push(JValue.R(rt.String("")));f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/item/PaperToken","<init>","(Lforge/card/CardRules;Lforge/card/CardEdition;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",219);}
case 219:{f.Locals[8]=f.Pop();f.Pc=221;continue;}
case 221:{f.Push(f.Locals[0]);f.Pc=222;continue;}
case 222:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","extraTokensByName","Ljava/util/Map;"));f.Pc=225;continue;}
case 225:{f.Push(f.Locals[5]);f.Pc=227;continue;}
case 227:{f.Push(f.Locals[8]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",234);}
case 234:{f.StackOp("pop");f.Pc=235;continue;}
case 235:{f.Push(f.Locals[8]);f.Pc=237;continue;}
case 237:{return JStep.Return(f.Pop());}
case 238:{f.Locals[8]=f.Pop();f.Pc=240;continue;}
case 240:{f.Push(f.Locals[8]);f.Pc=242;continue;}
case 242:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 243:{f.Push(f.Locals[0]);f.Pc=244;continue;}
case 244:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","extraTokensByName","Ljava/util/Map;"));f.Pc=247;continue;}
case 247:{f.Push(f.Locals[5]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",254);}
case 254:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperToken"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=257;continue;}
case 257:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11519(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11520(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11521(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11522(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11523(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11524(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11525(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11526(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11527(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","allTokenByName","Lcom/google/common/collect/Multimap;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"com/google/common/collect/Multimap","values","()Ljava/util/Collection;","invokeinterface",13);}
case 13:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11528(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11529(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11530(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11531(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","allTokenByName","Lcom/google/common/collect/Multimap;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"com/google/common/collect/Multimap","values","()Ljava/util/Collection;","invokeinterface",9);}
case 9:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11532(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/token/TokenDb","rulesByName","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
