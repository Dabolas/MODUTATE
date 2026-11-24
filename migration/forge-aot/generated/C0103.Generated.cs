// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C103{
internal static JClass Build(){var c=new JClass("forge/deck/DeckRule","java/lang/Object",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("activeSection","Lforge/deck/DeckSection;",false,JValue.Default("Lforge/deck/DeckSection;"),null));
c.Add(new JField("description","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(1608,"forge/deck/DeckRule","<init>","(Ljava/util/Map;)V",4,5,4,new JHandler[]{new JHandler(22,27,30,"java/lang/IllegalArgumentException")},M1608));
c.Add(new JMethod(1609,"forge/deck/DeckRule","getActiveSection","()Lforge/deck/DeckSection;",17,1,1,new JHandler[]{},M1609));
c.Add(new JMethod(1610,"forge/deck/DeckRule","isActiveFor","(Lforge/deck/DeckSection;)Z",17,2,2,new JHandler[]{},M1610));
c.Add(new JMethod(1611,"forge/deck/DeckRule","getDescription","()Ljava/lang/String;",17,1,1,new JHandler[]{},M1611));
c.Add(new JMethod(1612,"forge/deck/DeckRule","parseAll","(Lforge/item/PaperCard;)Ljava/util/List;",9,3,2,new JHandler[]{},M1612));
c.Add(new JMethod(1613,"forge/deck/DeckRule","parseAll","(Ljava/lang/Iterable;)Ljava/util/List;",9,1,2,new JHandler[]{},M1613));
c.Add(new JMethod(1614,"forge/deck/DeckRule","parseAll","(Ljava/lang/Iterable;B)Ljava/util/List;",10,11,5,new JHandler[]{},M1614));
c.Add(new JMethod(1615,"forge/deck/DeckRule","parseParams","(Ljava/lang/String;)Ljava/util/Map;",12,10,3,new JHandler[]{},M1615));
}

internal static JStep M1608(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("ActiveSection")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",14);}
case 14:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=17;continue;}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Reference==null?32:22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/deck/DeckSection","valueOf","(Ljava/lang/String;)Lforge/deck/DeckSection;","invokestatic",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Pc=32;continue;}
case 30:{f.Locals[4]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRule","activeSection","Lforge/deck/DeckSection;",value);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("Description")));f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRule","description","Ljava/lang/String;",value);f.Pc=54;continue;}
case 54:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1609(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRule","activeSection","Lforge/deck/DeckSection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1610(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRule","activeSection","Lforge/deck/DeckSection;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?15:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRule","activeSection","Lforge/deck/DeckSection;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?19:15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{f.Pc=20;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1611(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRule","description","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1612(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?17:9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",16);}
case 16:{return JStep.Return(f.Pop());}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/item/PaperCard","getMarkedColors","()Lforge/card/ColorSet;","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Reference==null?34:24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/item/PaperCard","getMarkedColors","()Lforge/card/ColorSet;","invokevirtual",28);}
case 28:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",31);}
case 31:{f.Pc=35;continue;}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{f.Locals[2]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/card/CardRules","getDeckRules","()Ljava/lang/Iterable;","invokevirtual",40);}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/deck/DeckRule","parseAll","(Ljava/lang/Iterable;B)Ljava/util/List;","invokestatic",44);}
case 44:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1613(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/DeckRule","parseAll","(Ljava/lang/Iterable;B)Ljava/util/List;","invokestatic",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1614(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?230:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{f.Push(JValue.I(58));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",42);}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{f.Pc=f.Pop().Int<=0?60:49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{f.Push(f.Locals[5]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",57);}
case 57:{f.Pc=62;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{f.Locals[6]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[5]);f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Int<=0?81:69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[5]);f.Pc=73;continue;}
case 73:{f.Push(JValue.I(1));f.Pc=74;continue;}
case 74:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",78);}
case 78:{f.Pc=83;continue;}
case 81:{f.Push(JValue.R(rt.String("")));f.Pc=83;continue;}
case 83:{f.Locals[7]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[7]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/deck/DeckRule","parseParams","(Ljava/lang/String;)Ljava/util/Map;","invokestatic",90);}
case 90:{f.Locals[8]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[6]);f.Pc=94;continue;}
case 94:{f.Locals[9]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(JValue.I(-1));f.Pc=97;continue;}
case 97:{f.Locals[10]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[9]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",104);}
case 104:{switch(f.Pop().Int){case -2132729567:f.Pc=132;break;case 2577441:f.Pc=148;break;default:f.Pc=161;break;}continue;}
case 132:{f.Push(f.Locals[9]);f.Pc=134;continue;}
case 134:{f.Push(JValue.R(rt.String("ColorIdentity")));f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",139);}
case 139:{f.Pc=f.Pop().Int==0?161:142;continue;}
case 142:{f.Push(JValue.I(0));f.Pc=143;continue;}
case 143:{f.Locals[10]=f.Pop();f.Pc=145;continue;}
case 145:{f.Pc=161;continue;}
case 148:{f.Push(f.Locals[9]);f.Pc=150;continue;}
case 150:{f.Push(JValue.R(rt.String("Size")));f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",155);}
case 155:{f.Pc=f.Pop().Int==0?161:158;continue;}
case 158:{f.Push(JValue.I(1));f.Pc=159;continue;}
case 159:{f.Locals[10]=f.Pop();f.Pc=161;continue;}
case 161:{f.Push(f.Locals[10]);f.Pc=163;continue;}
case 163:{switch(f.Pop().Int){case 0:f.Pc=188;break;case 1:f.Pc=208;break;default:f.Pc=227;break;}continue;}
case 188:{f.Push(f.Locals[2]);f.Pc=189;continue;}
case 189:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRuleColorIdentity"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRuleColorIdentity")));f.Pc=192;continue;}
case 192:{f.StackOp("dup");f.Pc=193;continue;}
case 193:{f.Push(f.Locals[8]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[1]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/deck/DeckRuleColorIdentity","<init>","(Ljava/util/Map;B)V","invokespecial",199);}
case 199:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",204);}
case 204:{f.StackOp("pop");f.Pc=205;continue;}
case 205:{f.Pc=227;continue;}
case 208:{f.Push(f.Locals[2]);f.Pc=209;continue;}
case 209:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRuleSize"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRuleSize")));f.Pc=212;continue;}
case 212:{f.StackOp("dup");f.Pc=213;continue;}
case 213:{f.Push(f.Locals[8]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/deck/DeckRuleSize","<init>","(Ljava/util/Map;)V","invokespecial",218);}
case 218:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",223);}
case 223:{f.StackOp("pop");f.Pc=224;continue;}
case 224:{f.Pc=227;continue;}
case 227:{f.Pc=15;continue;}
case 230:{f.Push(f.Locals[2]);f.Pc=231;continue;}
case 231:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1615(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/LinkedHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/LinkedHashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/LinkedHashMap","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("\\|")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=17;continue;}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?112:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=31;continue;}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",38);}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?51:48;continue;}
case 48:{f.Pc=106;continue;}
case 51:{f.Push(f.Locals[6]);f.Pc=53;continue;}
case 53:{f.Push(JValue.I(36));f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",58);}
case 58:{f.Locals[7]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[7]);f.Pc=62;continue;}
case 62:{f.Pc=f.Pop().Int>=0?68:65;continue;}
case 65:{f.Pc=106;continue;}
case 68:{f.Push(f.Locals[6]);f.Pc=70;continue;}
case 70:{f.Push(JValue.I(0));f.Pc=71;continue;}
case 71:{f.Push(f.Locals[7]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",76);}
case 76:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",79);}
case 79:{f.Locals[8]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[6]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[7]);f.Pc=85;continue;}
case 85:{f.Push(JValue.I(1));f.Pc=86;continue;}
case 86:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",90);}
case 90:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",93);}
case 93:{f.Locals[9]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[8]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[9]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",105);}
case 105:{f.StackOp("pop");f.Pc=106;continue;}
case 106:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=109;continue;}
case 109:{f.Pc=21;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
