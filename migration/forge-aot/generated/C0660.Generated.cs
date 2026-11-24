// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C660{
internal static JClass Build(){var c=new JClass("forge/game/keyword/KeywordWithCostAndType","forge/game/keyword/KeywordInstance",new string[]{"forge/game/keyword/KeywordWithCostInterface","forge/game/keyword/KeywordWithTypeInterface"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("cost","Lforge/game/cost/Cost;",false,JValue.Default("Lforge/game/cost/Cost;"),null));
c.Add(new JField("costString","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("type","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("descType","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("reminderType","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(7593,"forge/game/keyword/KeywordWithCostAndType","<init>","()V",1,1,2,new JHandler[]{},M7593));
c.Add(new JMethod(7594,"forge/game/keyword/KeywordWithCostAndType","getValidType","()Ljava/lang/String;",1,1,2,new JHandler[]{},M7594));
c.Add(new JMethod(7595,"forge/game/keyword/KeywordWithCostAndType","getTypeDescription","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7595));
c.Add(new JMethod(7596,"forge/game/keyword/KeywordWithCostAndType","getCost","()Lforge/game/cost/Cost;",1,1,1,new JHandler[]{},M7596));
c.Add(new JMethod(7597,"forge/game/keyword/KeywordWithCostAndType","getCostString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7597));
c.Add(new JMethod(7598,"forge/game/keyword/KeywordWithCostAndType","getTitle","()Ljava/lang/String;",1,2,2,new JHandler[]{},M7598));
c.Add(new JMethod(7599,"forge/game/keyword/KeywordWithCostAndType","getTitleWithoutCost","()Ljava/lang/String;",1,1,2,new JHandler[]{},M7599));
c.Add(new JMethod(7600,"forge/game/keyword/KeywordWithCostAndType","parse","(Ljava/lang/String;)V",4,5,5,new JHandler[]{},M7600));
c.Add(new JMethod(7601,"forge/game/keyword/KeywordWithCostAndType","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;",4,3,5,new JHandler[]{},M7601));
}

internal static JStep M7593(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInstance","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","descType","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","reminderType","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7594(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Affinity")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","type","Ljava/lang/String;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?17:12;continue;}
case 12:{f.Push(JValue.R(rt.String("Card.withAffinity")));f.Pc=14;continue;}
case 14:{f.Pc=21;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","type","Ljava/lang/String;"));f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7595(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","descType","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7596(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","cost","Lforge/game/cost/Cost;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7597(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","costString","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7598(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndType","getTitleWithoutCost","()Ljava/lang/String;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",16);}
case 16:{f.StackOp("pop");f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","cost","Lforge/game/cost/Cost;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/cost/Cost","isOnlyManaCost","()Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int!=0?37:27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("\u2014")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",33);}
case 33:{f.StackOp("pop");f.Pc=34;continue;}
case 34:{f.Pc=44;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String(" ")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",43);}
case 43:{f.StackOp("pop");f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","cost","Lforge/game/cost/Cost;"));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",52);}
case 52:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",60);}
case 60:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7599(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndType","getKeyword","()Lforge/game/keyword/Keyword;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","SPLICE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","SPLICE","Lforge/game/keyword/Keyword;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/keyword/Keyword","equals","(Ljava/lang/Object;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?23:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","descType","Ljava/lang/String;"));f.Pc=17;continue;}
case 17:{return rt.DynamicCall(f,"forge/game/keyword/KeywordWithCostAndType:7599:17:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",22);}
case 22:{return JStep.Return(f.Pop());}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","descType","Ljava/lang/String;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",30);}
case 30:{return rt.DynamicCall(f,"forge/game/keyword/KeywordWithCostAndType:7599:30:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",35);}
case 35:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7600(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String(":")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","type","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","costString","Ljava/lang/String;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","costString","Ljava/lang/String;"));f.Pc=30;continue;}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",34);}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","cost","Lforge/game/cost/Cost;",value);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=39;continue;}
case 39:{f.Push(JValue.I(2));f.Pc=40;continue;}
case 40:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?58:43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(2));f.Pc=47;continue;}
case 47:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=48;continue;}
case 48:{f.StackOp("dup_x1");f.Pc=49;continue;}
case 49:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","descType","Ljava/lang/String;",value);f.Pc=52;continue;}
case 52:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","reminderType","Ljava/lang/String;",value);f.Pc=55;continue;}
case 55:{f.Pc=173;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","type","Ljava/lang/String;"));f.Pc=63;continue;}
case 63:{f.Locals[3]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(JValue.I(-1));f.Pc=65;continue;}
case 65:{f.Locals[4]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[3]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",71);}
case 71:{switch(f.Pop().Int){case 63955982:f.Pc=88;break;default:f.Pc=100;break;}continue;}
case 88:{f.Push(f.Locals[3]);f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("Basic")));f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?100:97;continue;}
case 97:{f.Push(JValue.I(0));f.Pc=98;continue;}
case 98:{f.Locals[4]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[4]);f.Pc=102;continue;}
case 102:{switch(f.Pop().Int){case 0:f.Pc=120;break;default:f.Pc=125;break;}continue;}
case 120:{f.Push(JValue.R(rt.String("basic land")));f.Pc=122;continue;}
case 122:{f.Pc=144;continue;}
case 125:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",128);}
case 128:{f.Push(f.Locals[0]);f.Pc=129;continue;}
case 129:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","type","Ljava/lang/String;"));f.Pc=132;continue;}
case 132:{f.Push(JValue.R(rt.String(",")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",137);}
case 137:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",140);}
case 140:{f.Push(JValue.I(0));f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/util/Lang","buildValidDesc","(Ljava/util/Collection;Z)Ljava/lang/String;","invokevirtual",144);}
case 144:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","descType","Ljava/lang/String;",value);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[0]);f.Pc=149;continue;}
case 149:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","descType","Ljava/lang/String;"));f.Pc=152;continue;}
case 152:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","reminderType","Ljava/lang/String;",value);f.Pc=155;continue;}
case 155:{f.Push(JValue.R(rt.String("Affinity")));f.Pc=157;continue;}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","type","Ljava/lang/String;"));f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Int==0?173:167;continue;}
case 167:{f.Push(f.Locals[0]);f.Pc=168;continue;}
case 168:{f.Push(JValue.R(rt.String("card with affinity")));f.Pc=170;continue;}
case 170:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","reminderType","Ljava/lang/String;",value);f.Pc=173;continue;}
case 173:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7601(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","reminderType","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/keyword/KeywordWithCostAndType","getKeyword","()Lforge/game/keyword/Keyword;","invokevirtual",9);}
case 9:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","TYPECYCLING","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","TYPECYCLING","Lforge/game/keyword/Keyword;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/keyword/Keyword","equals","(Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?50:18;continue;}
case 18:{f.Push(JValue.R(rt.String("Affinity")));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","type","Ljava/lang/String;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?36:30;continue;}
case 30:{f.Push(JValue.R(rt.String("a card with affinity")));f.Pc=32;continue;}
case 32:{f.Locals[2]=f.Pop();f.Pc=33;continue;}
case 33:{f.Pc=50;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","reminderType","Ljava/lang/String;"));f.Pc=41;continue;}
case 41:{return rt.DynamicCall(f,"forge/game/keyword/KeywordWithCostAndType:7601:41:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",46);}
case 46:{return rt.Call(f,"forge/util/Lang","nounWithAmount","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",49);}
case 49:{f.Locals[2]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(JValue.I(2));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithCostAndType","cost","Lforge/game/cost/Cost;"));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",64);}
case 64:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=65;continue;}
case 65:{f.StackOp("dup");f.Pc=66;continue;}
case 66:{f.Push(JValue.I(1));f.Pc=67;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",72);}
case 72:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
