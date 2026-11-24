// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C782{
internal static JClass Build(){var c=new JClass("forge/game/replacement/ReplacementHandler$1","java/lang/Object",new string[]{"forge/util/Visitor"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("val$o","Lforge/game/GameEntity;",false,JValue.Default("Lforge/game/GameEntity;"),null));
c.Add(new JField("val$list","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("this$0","Lforge/game/replacement/ReplacementHandler;",false,JValue.Default("Lforge/game/replacement/ReplacementHandler;"),null));
c.Add(new JMethod(9046,"forge/game/replacement/ReplacementHandler$1","<init>","(Lforge/game/replacement/ReplacementHandler;Lforge/game/GameEntity;Ljava/util/List;)V",0,4,2,new JHandler[]{},M9046));
c.Add(new JMethod(9047,"forge/game/replacement/ReplacementHandler$1","visit","(Lforge/game/card/Card;)Z",1,4,3,new JHandler[]{},M9047));
c.Add(new JMethod(9048,"forge/game/replacement/ReplacementHandler$1","visit","(Ljava/lang/Object;)Z",4161,2,2,new JHandler[]{},M9048));
}

internal static JStep M9046(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/replacement/ReplacementHandler$1","this$0","Lforge/game/replacement/ReplacementHandler;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/replacement/ReplacementHandler$1","val$o","Lforge/game/GameEntity;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/replacement/ReplacementHandler$1","val$list","Ljava/util/List;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",19);}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9047(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getReplacementEffects","()Lforge/util/collect/FCollectionView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?123:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getMode","()Lforge/game/replacement/ReplacementType;","invokevirtual",33);}
case 33:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","DamageDone","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","DamageDone","Lforge/game/replacement/ReplacementType;"));f.Pc=36;continue;}
case 36:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?120:39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getLayer","()Lforge/game/replacement/ReplacementLayer;","invokevirtual",43);}
case 43:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=46;continue;}
case 46:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?120:49;continue;}
case 49:{f.Push(f.Locals[3]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("PreventionEffect")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","hasParam","(Ljava/lang/String;)Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int==0?120:58;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler$1","this$0","Lforge/game/replacement/ReplacementHandler;"));f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler","game","Lforge/game/Game;"));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",70);}
case 70:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","zonesCheck","(Lforge/game/zone/Zone;)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int==0?120:76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Reference==null?120:83;continue;}
case 83:{f.Push(f.Locals[3]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",87);}
case 87:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",90);}
case 90:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ReplaceDamage","Lforge/game/ability/ApiType;"));f.Pc=93;continue;}
case 93:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?120:96;continue;}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{f.Push(JValue.R(rt.String("ValidTarget")));f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler$1","val$o","Lforge/game/GameEntity;"));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?120:109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(rt.GetField(f.Pop(),"forge/game/replacement/ReplacementHandler$1","val$list","Ljava/util/List;"));f.Pc=113;continue;}
case 113:{f.Push(f.Locals[3]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",119);}
case 119:{f.StackOp("pop");f.Pc=120;continue;}
case 120:{f.Pc=10;continue;}
case 123:{f.Push(JValue.I(1));f.Pc=124;continue;}
case 124:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9048(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/replacement/ReplacementHandler$1","visit","(Lforge/game/card/Card;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
