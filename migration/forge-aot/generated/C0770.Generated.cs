// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C770{
internal static JClass Build(){var c=new JClass("forge/game/replacement/ReplaceRollDice","forge/game/replacement/ReplacementEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(8964,"forge/game/replacement/ReplaceRollDice","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M8964));
c.Add(new JMethod(8965,"forge/game/replacement/ReplaceRollDice","canReplace","(Ljava/util/Map;)Z",1,2,4,new JHandler[]{},M8965));
c.Add(new JMethod(8966,"forge/game/replacement/ReplaceRollDice","setReplacingObjects","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)V",1,3,4,new JHandler[]{},M8966));
}

internal static JStep M8964(JRuntime rt,JFrame f)
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

internal static JStep M8965(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{return rt.Call(f,"forge/game/replacement/ReplaceRollDice","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?20:18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("ValidSides")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/replacement/ReplaceRollDice","hasParam","(Ljava/lang/String;)Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int==0?58:29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Sides","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Sides","Lforge/game/ability/AbilityKey;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",44);}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("ValidSides")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/replacement/ReplaceRollDice","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",50);}
case 50:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",53);}
case 53:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?58:56;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 58:{f.Push(JValue.I(1));f.Pc=59;continue;}
case 59:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8966(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",13);}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",16);}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Ignore","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Ignore","Lforge/game/ability/AbilityKey;"));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Ignore","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Ignore","Lforge/game/ability/AbilityKey;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",32);}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IgnoreChosen","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IgnoreChosen","Lforge/game/ability/AbilityKey;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IgnoreChosen","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IgnoreChosen","Lforge/game/ability/AbilityKey;"));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",45);}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",48);}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DicePTExchanges","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DicePTExchanges","Lforge/game/ability/AbilityKey;"));f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DicePTExchanges","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DicePTExchanges","Lforge/game/ability/AbilityKey;"));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",61);}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",64);}
case 64:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
