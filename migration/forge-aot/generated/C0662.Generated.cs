// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C662{
internal static JClass Build(){var c=new JClass("forge/game/keyword/KeywordWithType","forge/game/keyword/KeywordInstance",new string[]{"forge/game/keyword/KeywordWithTypeInterface"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("type","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("descType","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("reminderType","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(7609,"forge/game/keyword/KeywordWithType","<init>","()V",1,1,2,new JHandler[]{},M7609));
c.Add(new JMethod(7610,"forge/game/keyword/KeywordWithType","getValidType","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7610));
c.Add(new JMethod(7611,"forge/game/keyword/KeywordWithType","getTypeDescription","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7611));
c.Add(new JMethod(7612,"forge/game/keyword/KeywordWithType","getTitle","()Ljava/lang/String;",1,2,2,new JHandler[]{},M7612));
c.Add(new JMethod(7613,"forge/game/keyword/KeywordWithType","parse","(Ljava/lang/String;)V",4,4,4,new JHandler[]{},M7613));
c.Add(new JMethod(7614,"forge/game/keyword/KeywordWithType","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;",4,2,5,new JHandler[]{},M7614));
}

internal static JStep M7609(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInstance","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithType","type","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithType","descType","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(null));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithType","reminderType","Ljava/lang/String;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7610(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithType","type","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7611(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithType","descType","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7612(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/keyword/KeywordWithType","getKeyword","()Lforge/game/keyword/Keyword;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",16);}
case 16:{f.Push(JValue.R(rt.String(" ")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",21);}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithType","descType","Ljava/lang/String;"));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",33);}
case 33:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7613(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String(":")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?33:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String(":")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=20;continue;}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithType","type","Ljava/lang/String;",value);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Push(JValue.I(1));f.Pc=26;continue;}
case 26:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=27;continue;}
case 27:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithType","descType","Ljava/lang/String;",value);f.Pc=30;continue;}
case 30:{f.Pc=120;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/card/MagicColor$Color","fromName","(Ljava/lang/String;)Lforge/card/MagicColor$Color;","invokestatic",37);}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Pc=f.Pop().Reference==null?69:42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/card/MagicColor$Color","getName","()Ljava/lang/String;","invokevirtual",47);}
case 47:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",50);}
case 50:{return rt.DynamicCall(f,"forge/game/keyword/KeywordWithType:7613:50:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",55);}
case 55:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithType","type","Ljava/lang/String;",value);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/card/MagicColor$Color","getName","()Ljava/lang/String;","invokevirtual",63);}
case 63:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithType","descType","Ljava/lang/String;",value);f.Pc=66;continue;}
case 66:{f.Pc=120;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/keyword/KeywordWithType","getKeyword","()Lforge/game/keyword/Keyword;","invokevirtual",73);}
case 73:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","PARTNER_WITH","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","PARTNER_WITH","Lforge/game/keyword/Keyword;"));f.Pc=76;continue;}
case 76:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?92:79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithType","type","Ljava/lang/String;",value);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithType","descType","Ljava/lang/String;",value);f.Pc=89;continue;}
case 89:{f.Pc=120;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithType","type","Ljava/lang/String;",value);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",101);}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithType","type","Ljava/lang/String;"));f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.String(",")));f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",110);}
case 110:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",113);}
case 113:{f.Push(JValue.I(0));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/util/Lang","buildValidDesc","(Ljava/util/Collection;Z)Ljava/lang/String;","invokevirtual",117);}
case 117:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithType","descType","Ljava/lang/String;",value);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithType","descType","Ljava/lang/String;"));f.Pc=125;continue;}
case 125:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordWithType","reminderType","Ljava/lang/String;",value);f.Pc=128;continue;}
case 128:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7614(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordWithType","reminderType","Ljava/lang/String;"));f.Pc=11;continue;}
case 11:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
