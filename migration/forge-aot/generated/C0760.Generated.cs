// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C760{
internal static JClass Build(){var c=new JClass("forge/game/replacement/ReplaceLifeReduced","forge/game/replacement/ReplacementEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(8934,"forge/game/replacement/ReplaceLifeReduced","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M8934));
c.Add(new JMethod(8935,"forge/game/replacement/ReplaceLifeReduced","canReplace","(Ljava/util/Map;)Z",1,8,3,new JHandler[]{},M8935));
c.Add(new JMethod(8936,"forge/game/replacement/ReplaceLifeReduced","setReplacingObjects","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)V",1,3,6,new JHandler[]{},M8936));
}

internal static JStep M8934(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8935(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Amount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Amount","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Pc=f.Pop().Int>0?35:33;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/replacement/ReplaceLifeReduced","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int!=0?47:45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("IsDamage")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/replacement/ReplaceLifeReduced","hasParam","(Ljava/lang/String;)Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int==0?87:56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String("IsDamage")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/replacement/ReplaceLifeReduced","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",62);}
case 62:{f.Push(JValue.R(rt.String("True")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",67);}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IsDamage","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IsDamage","Lforge/game/ability/AbilityKey;"));f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",76);}
case 76:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",82);}
case 82:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?87:85;continue;}
case 85:{f.Push(JValue.I(0));f.Pc=86;continue;}
case 86:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String("Result")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/replacement/ReplaceLifeReduced","hasParam","(Ljava/lang/String;)Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int==0?146:96;continue;}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",100);}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=102;continue;}
case 102:{f.Locals[4]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.String("Result")));f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/replacement/ReplaceLifeReduced","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",110);}
case 110:{f.Locals[5]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[5]);f.Pc=114;continue;}
case 114:{f.Push(JValue.I(0));f.Pc=115;continue;}
case 115:{f.Push(JValue.I(2));f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",119);}
case 119:{f.Locals[6]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[5]);f.Pc=123;continue;}
case 123:{f.Push(JValue.I(2));f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",127);}
case 127:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",130);}
case 130:{f.Locals[7]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[4]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[6]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[7]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",141);}
case 141:{f.Pc=f.Pop().Int!=0?146:144;continue;}
case 144:{f.Push(JValue.I(0));f.Pc=145;continue;}
case 145:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 146:{f.Push(JValue.I(1));f.Pc=147;continue;}
case 147:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8936(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.NewArray("Lforge/game/ability/AbilityKey;",f.Pop().Int)));f.Pc=6;continue;}
case 6:{f.StackOp("dup");f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Amount","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Amount","Lforge/game/ability/AbilityKey;"));f.Pc=11;continue;}
case 11:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObjectsFrom","(Ljava/util/Map;[Lforge/game/ability/AbilityKey;)V","invokevirtual",15);}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",28);}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",31);}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
