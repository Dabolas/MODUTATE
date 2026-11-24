// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1121{
internal static JClass Build(){var c=new JClass("forge/util/FileSection","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("lines","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("DOLLAR_SIGN_KV_SEPARATOR","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("ARROW_KV_SEPARATOR","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("EQUALS_KV_SEPARATOR","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("COLON_KV_SEPARATOR","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("BAR_PAIR_SPLITTER","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("parseToMapCache","Lcom/google/common/collect/Table;",true,JValue.Default("Lcom/google/common/collect/Table;"),null));
c.Add(new JMethod(11732,"forge/util/FileSection","<init>","()V",4,1,4,new JHandler[]{},M11732));
c.Add(new JMethod(11733,"forge/util/FileSection","parseToMap","(Ljava/lang/String;Ljava/util/regex/Pattern;)Ljava/util/Map;",9,9,4,new JHandler[]{},M11733));
c.Add(new JMethod(11734,"forge/util/FileSection","parse","(Ljava/lang/Iterable;Ljava/util/regex/Pattern;)Lforge/util/FileSection;",9,6,4,new JHandler[]{},M11734));
c.Add(new JMethod(11735,"forge/util/FileSection","parseSections","(Ljava/util/List;)Ljava/util/Map;",9,6,4,new JHandler[]{},M11735));
c.Add(new JMethod(11736,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;",1,2,2,new JHandler[]{},M11736));
c.Add(new JMethod(11737,"forge/util/FileSection","get","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1,3,2,new JHandler[]{},M11737));
c.Add(new JMethod(11738,"forge/util/FileSection","contains","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M11738));
c.Add(new JMethod(11739,"forge/util/FileSection","getDouble","(Ljava/lang/String;D)D",1,7,2,new JHandler[]{new JHandler(15,37,38,"java/lang/NumberFormatException"),new JHandler(15,37,38,"java/text/ParseException")},M11739));
c.Add(new JMethod(11740,"forge/util/FileSection","getInt","(Ljava/lang/String;)I",1,2,3,new JHandler[]{},M11740));
c.Add(new JMethod(11741,"forge/util/FileSection","getInt","(Ljava/lang/String;I)I",1,4,2,new JHandler[]{new JHandler(0,8,9,"java/lang/NumberFormatException")},M11741));
c.Add(new JMethod(11742,"forge/util/FileSection","getBoolean","(Ljava/lang/String;)Z",1,2,3,new JHandler[]{},M11742));
c.Add(new JMethod(11743,"forge/util/FileSection","getBoolean","(Ljava/lang/String;Z)Z",1,4,2,new JHandler[]{},M11743));
c.Add(new JMethod(11744,"forge/util/FileSection","<clinit>","()V",8,0,1,new JHandler[]{},M11744));
}

internal static JStep M11732(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/TreeMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeMap")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/TreeMap","<init>","(Ljava/util/Comparator;)V","invokespecial",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/FileSection","lines","Ljava/util/Map;",value);f.Pc=18;continue;}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11733(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/FileSection","parseToMapCache","Lcom/google/common/collect/Table;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/FileSection","parseToMapCache","Lcom/google/common/collect/Table;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Table","get","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Reference==null?20:18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
case 20:{if(!rt.EnsureInitialized(f,"java/util/TreeMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeMap")));f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/TreeMap","<init>","(Ljava/util/Comparator;)V","invokespecial",30);}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",35);}
case 35:{f.Pc=f.Pop().Int!=0?117:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/util/FileSection","BAR_PAIR_SPLITTER","Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/FileSection","BAR_PAIR_SPLITTER","Ljava/lang/String;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Locals[4]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=50;continue;}
case 50:{f.Locals[5]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{f.Locals[6]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[6]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?117:62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[6]);f.Pc=66;continue;}
case 66:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=67;continue;}
case 67:{f.Locals[7]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[7]);f.Pc=72;continue;}
case 72:{f.Push(JValue.I(2));f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/regex/Pattern","split","(Ljava/lang/CharSequence;I)[Ljava/lang/String;","invokevirtual",76);}
case 76:{f.Locals[8]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[8]);f.Pc=81;continue;}
case 81:{f.Push(JValue.I(0));f.Pc=82;continue;}
case 82:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",86);}
case 86:{f.Push(f.Locals[8]);f.Pc=88;continue;}
case 88:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=89;continue;}
case 89:{f.Push(JValue.I(1));f.Pc=90;continue;}
case 90:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?103:93;continue;}
case 93:{f.Push(f.Locals[8]);f.Pc=95;continue;}
case 95:{f.Push(JValue.I(1));f.Pc=96;continue;}
case 96:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",100);}
case 100:{f.Pc=105;continue;}
case 103:{f.Push(JValue.R(rt.String("")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",110);}
case 110:{f.StackOp("pop");f.Pc=111;continue;}
case 111:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=114;continue;}
case 114:{f.Pc=55;continue;}
case 117:{f.Push(f.Locals[3]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/Collections","unmodifiableMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",121);}
case 121:{f.Locals[2]=f.Pop();f.Pc=122;continue;}
case 122:{if(!rt.StaticReady(f,"forge/util/FileSection","parseToMapCache","Lcom/google/common/collect/Table;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/FileSection","parseToMapCache","Lcom/google/common/collect/Table;"));f.Pc=125;continue;}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[1]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[2]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"com/google/common/collect/Table","put","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",133);}
case 133:{f.StackOp("pop");f.Pc=134;continue;}
case 134:{f.Push(f.Locals[2]);f.Pc=135;continue;}
case 135:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11734(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/FileSection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/FileSection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/FileSection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?83:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{f.Push(JValue.I(2));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/regex/Pattern","split","(Ljava/lang/CharSequence;I)[Ljava/lang/String;","invokevirtual",42);}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/util/FileSection","lines","Ljava/util/Map;"));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",55);}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(1));f.Pc=59;continue;}
case 59:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?72:62;continue;}
case 62:{f.Push(f.Locals[5]);f.Pc=64;continue;}
case 64:{f.Push(JValue.I(1));f.Pc=65;continue;}
case 65:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",69);}
case 69:{f.Pc=74;continue;}
case 72:{f.Push(JValue.R(rt.String("")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",79);}
case 79:{f.StackOp("pop");f.Pc=80;continue;}
case 80:{f.Pc=15;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11735(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/LinkedHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/LinkedHashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/LinkedHashMap","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?167:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int!=0?167:24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",30);}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?167:40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[4]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",56);}
case 56:{f.Locals[5]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("#")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?71:68;continue;}
case 68:{f.Pc=31;continue;}
case 71:{f.Push(f.Locals[5]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("[")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int==0?133:81;continue;}
case 81:{f.Push(f.Locals[5]);f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.String("]")));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",88);}
case 88:{f.Pc=f.Pop().Int==0?133:91;continue;}
case 91:{f.Push(f.Locals[5]);f.Pc=93;continue;}
case 93:{f.Push(JValue.I(1));f.Pc=94;continue;}
case 94:{f.Push(f.Locals[5]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",99);}
case 99:{f.Push(JValue.I(1));f.Pc=100;continue;}
case 100:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",104);}
case 104:{f.Locals[2]=f.Pop();f.Pc=105;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",112);}
case 112:{f.Pc=f.Pop().Int!=0?164:115;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[2]);f.Pc=117;continue;}
case 117:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=120;continue;}
case 120:{f.StackOp("dup");f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",124);}
case 124:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",129);}
case 129:{f.StackOp("pop");f.Pc=130;continue;}
case 130:{f.Pc=164;continue;}
case 133:{f.Push(JValue.R(null));f.Pc=134;continue;}
case 134:{f.Push(f.Locals[2]);f.Pc=135;continue;}
case 135:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?164:138;continue;}
case 138:{f.Push(f.Locals[5]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",143);}
case 143:{f.Pc=f.Pop().Int!=0?164:146;continue;}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[2]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",153);}
case 153:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[5]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",163);}
case 163:{f.StackOp("pop");f.Pc=164;continue;}
case 164:{f.Pc=31;continue;}
case 167:{f.Push(f.Locals[1]);f.Pc=168;continue;}
case 168:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11736(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/FileSection","lines","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11737(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/FileSection","lines","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?29:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/util/FileSection","lines","Ljava/util/Map;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{f.Pc=30;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11738(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/FileSection","lines","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11739(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5);}
case 5:{f.Locals[4]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[4]);f.Pc=10;continue;}
case 10:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?15:13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
case 15:{if(!rt.StaticReady(f,"java/util/Locale","US","Ljava/util/Locale;"))return JStep.Continue;f.Push(rt.GetStatic("java/util/Locale","US","Ljava/util/Locale;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/text/NumberFormat","getInstance","(Ljava/util/Locale;)Ljava/text/NumberFormat;","invokestatic",21);}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/text/NumberFormat","parse","(Ljava/lang/String;)Ljava/lang/Number;","invokevirtual",30);}
case 30:{f.Locals[6]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[6]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/Number","doubleValue","()D","invokevirtual",37);}
case 37:{return JStep.Return(f.Pop());}
case 38:{f.Locals[5]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11740(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/util/FileSection","getInt","(Ljava/lang/String;I)I","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11741(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11742(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/util/FileSection","getBoolean","(Ljava/lang/String;Z)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11743(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5);}
case 5:{f.Locals[3]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference!=null?12:10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(JValue.R(rt.String("true")));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",18);}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11744(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("$")));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/regex/Pattern","quote","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",5);}
case 5:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",8);}
case 8:{if(!rt.StaticReady(f,"forge/util/FileSection","DOLLAR_SIGN_KV_SEPARATOR","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/FileSection","DOLLAR_SIGN_KV_SEPARATOR","Ljava/util/regex/Pattern;",f.Pop());f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("->")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/regex/Pattern","quote","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",16);}
case 16:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",19);}
case 19:{if(!rt.StaticReady(f,"forge/util/FileSection","ARROW_KV_SEPARATOR","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/FileSection","ARROW_KV_SEPARATOR","Ljava/util/regex/Pattern;",f.Pop());f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("=")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/regex/Pattern","quote","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",27);}
case 27:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",30);}
case 30:{if(!rt.StaticReady(f,"forge/util/FileSection","EQUALS_KV_SEPARATOR","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/FileSection","EQUALS_KV_SEPARATOR","Ljava/util/regex/Pattern;",f.Pop());f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String(":")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/regex/Pattern","quote","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",38);}
case 38:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",41);}
case 41:{if(!rt.StaticReady(f,"forge/util/FileSection","COLON_KV_SEPARATOR","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/FileSection","COLON_KV_SEPARATOR","Ljava/util/regex/Pattern;",f.Pop());f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("|")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/regex/Pattern","quote","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",49);}
case 49:{if(!rt.StaticReady(f,"forge/util/FileSection","BAR_PAIR_SPLITTER","Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/util/FileSection","BAR_PAIR_SPLITTER","Ljava/lang/String;",f.Pop());f.Pc=52;continue;}
case 52:{return rt.Call(f,"com/google/common/collect/HashBasedTable","create","()Lcom/google/common/collect/HashBasedTable;","invokestatic",55);}
case 55:{if(!rt.StaticReady(f,"forge/util/FileSection","parseToMapCache","Lcom/google/common/collect/Table;"))return JStep.Continue;rt.PutStatic("forge/util/FileSection","parseToMapCache","Lcom/google/common/collect/Table;",f.Pop());f.Pc=58;continue;}
case 58:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
