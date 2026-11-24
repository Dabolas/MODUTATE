// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C767{
internal static JClass Build(){var c=new JClass("forge/game/replacement/ReplaceProduceMana","forge/game/replacement/ReplacementEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(8955,"forge/game/replacement/ReplaceProduceMana","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M8955));
c.Add(new JMethod(8956,"forge/game/replacement/ReplaceProduceMana","canReplace","(Ljava/util/Map;)Z",1,7,5,new JHandler[]{},M8956));
c.Add(new JMethod(8957,"forge/game/replacement/ReplaceProduceMana","setReplacingObjects","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)V",1,3,4,new JHandler[]{},M8957));
}

internal static JStep M8955(JRuntime rt,JFrame f)
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

internal static JStep M8956(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{return rt.Call(f,"forge/game/replacement/ReplaceProduceMana","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?20:18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",32);}
case 32:{return rt.Call(f,"forge/game/replacement/ReplaceProduceMana","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int!=0?40:38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("ValidActivator")));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",52);}
case 52:{return rt.Call(f,"forge/game/replacement/ReplaceProduceMana","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int!=0?60:58;continue;}
case 58:{f.Push(JValue.I(0));f.Pc=59;continue;}
case 59:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AbilityMana","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AbilityMana","Lforge/game/ability/AbilityKey;"));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",70);}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.String("ValidSA")));f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("Activated.hasTapCost+ManaAbility")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/replacement/ReplaceProduceMana","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",78);}
case 78:{f.Push(JValue.R(rt.String(",")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",83);}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/replacement/ReplaceProduceMana","getHostCard","()Lforge/game/card/Card;","invokevirtual",87);}
case 87:{return rt.Call(f,"forge/game/replacement/ReplaceProduceMana","matchesValid","(Ljava/lang/Object;[Ljava/lang/String;Lforge/game/card/Card;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int!=0?95:93;continue;}
case 93:{f.Push(JValue.I(0));f.Pc=94;continue;}
case 94:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("ManaAmount")));f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/replacement/ReplaceProduceMana","hasParam","(Ljava/lang/String;)Z","invokevirtual",101);}
case 101:{f.Pc=f.Pop().Int==0?171:104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.String("ManaAmount")));f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/replacement/ReplaceProduceMana","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",110);}
case 110:{f.Locals[2]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[2]);f.Pc=112;continue;}
case 112:{f.Push(JValue.I(0));f.Pc=113;continue;}
case 113:{f.Push(JValue.I(2));f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",117);}
case 117:{f.Locals[3]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[2]);f.Pc=119;continue;}
case 119:{f.Push(JValue.I(2));f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",123);}
case 123:{f.Locals[4]=f.Pop();f.Pc=125;continue;}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/replacement/ReplaceProduceMana","getHostCard","()Lforge/game/card/Card;","invokevirtual",129);}
case 129:{f.Push(f.Locals[4]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",135);}
case 135:{f.Locals[5]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[1]);f.Pc=138;continue;}
case 138:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"));f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",146);}
case 146:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.String(" ")));f.Pc=151;continue;}
case 151:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","countMatches","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I","invokestatic",154);}
case 154:{f.Push(JValue.I(1));f.Pc=155;continue;}
case 155:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=156;continue;}
case 156:{f.Locals[6]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[6]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[3]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[5]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",166);}
case 166:{f.Pc=f.Pop().Int!=0?171:169;continue;}
case 169:{f.Push(JValue.I(0));f.Pc=170;continue;}
case 170:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 171:{f.Push(JValue.I(1));f.Pc=172;continue;}
case 172:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8957(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",13);}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",16);}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
