// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C673{
internal static JClass Build(){var c=new JClass("forge/game/keyword/Station","forge/game/keyword/SimpleKeyword",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("pattern","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JMethod(7663,"forge/game/keyword/Station","<init>","()V",1,1,1,new JHandler[]{},M7663));
c.Add(new JMethod(7664,"forge/game/keyword/Station","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;",4,7,5,new JHandler[]{},M7664));
c.Add(new JMethod(7665,"forge/game/keyword/Station","<clinit>","()V",8,0,1,new JHandler[]{},M7665));
}

internal static JStep M7663(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/SimpleKeyword","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7664(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/Station","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?23:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("Spacecraft")));f.Pc=18;continue;}
case 18:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",22);}
case 22:{return JStep.Return(f.Pop());}
case 23:{f.Push(JValue.R(rt.String("")));f.Pc=25;continue;}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",30);}
case 30:{f.Push(JValue.R(rt.String("Spacecraft")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?57:40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=45;continue;}
case 45:{f.StackOp("dup");f.Pc=46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("Spacecraft")));f.Pc=49;continue;}
case 49:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",53);}
case 53:{f.Locals[1]=f.Pop();f.Pc=54;continue;}
case 54:{f.Pc=71;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(JValue.I(1));f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("Planet")));f.Pc=66;continue;}
case 66:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",70);}
case 70:{f.Locals[1]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",75);}
case 75:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",80);}
case 80:{f.Locals[4]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",89);}
case 89:{f.Pc=f.Pop().Int==0?181:92;continue;}
case 92:{f.Push(f.Locals[4]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",99);}
case 99:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=102;continue;}
case 102:{f.Locals[5]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[5]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/staticability/StaticAbility","isIntrinsic","()Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int==0?82:112;continue;}
case 112:{f.Push(f.Locals[5]);f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("Affected")));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",119);}
case 119:{f.Pc=f.Pop().Int==0?82:122;continue;}
case 122:{f.Push(JValue.R(rt.String("Creature")));f.Pc=124;continue;}
case 124:{f.Push(f.Locals[5]);f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("AddType")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",131);}
case 131:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",134);}
case 134:{f.Pc=f.Pop().Int!=0?140:137;continue;}
case 137:{f.Pc=82;continue;}
case 140:{if(!rt.StaticReady(f,"forge/game/keyword/Station","pattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Station","pattern","Ljava/util/regex/Pattern;"));f.Pc=143;continue;}
case 143:{f.Push(f.Locals[5]);f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.String("Affected")));f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",150);}
case 150:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",153);}
case 153:{f.Locals[6]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[6]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",160);}
case 160:{f.Pc=f.Pop().Int!=0?166:163;continue;}
case 163:{f.Pc=82;continue;}
case 166:{f.Push(f.Locals[6]);f.Pc=168;continue;}
case 168:{f.Push(JValue.I(1));f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",172);}
case 172:{return rt.DynamicCall(f,"forge/game/keyword/Station:7664:172:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",177);}
case 177:{f.Locals[3]=f.Pop();f.Pc=178;continue;}
case 178:{f.Pc=181;continue;}
case 181:{f.Push(f.Locals[1]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[3]);f.Pc=183;continue;}
case 183:{return rt.DynamicCall(f,"forge/game/keyword/Station:7664:183:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",188);}
case 188:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7665(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("counters_GE(\\d+)_CHARGE")));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",5);}
case 5:{if(!rt.StaticReady(f,"forge/game/keyword/Station","pattern","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/game/keyword/Station","pattern","Ljava/util/regex/Pattern;",f.Pop());f.Pc=8;continue;}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
