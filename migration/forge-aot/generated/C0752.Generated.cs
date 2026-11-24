// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C752{
internal static JClass Build(){var c=new JClass("forge/game/replacement/ReplaceDestroy","forge/game/replacement/ReplacementEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(8912,"forge/game/replacement/ReplaceDestroy","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M8912));
c.Add(new JMethod(8913,"forge/game/replacement/ReplaceDestroy","canReplace","(Ljava/util/Map;)Z",1,3,4,new JHandler[]{},M8913));
c.Add(new JMethod(8914,"forge/game/replacement/ReplaceDestroy","setReplacingObjects","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)V",1,3,6,new JHandler[]{},M8914));
}

internal static JStep M8912(JRuntime rt,JFrame f)
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

internal static JStep M8913(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{return rt.Call(f,"forge/game/replacement/ReplaceDestroy","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?20:18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("Regeneration")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/replacement/ReplaceDestroy","hasParam","(Ljava/lang/String;)Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int==0?99:29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[2]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Regeneration","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Regeneration","Lforge/game/ability/AbilityKey;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",51);}
case 51:{f.Pc=f.Pop().Int==0?72:54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Regeneration","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Regeneration","Lforge/game/ability/AbilityKey;"));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int!=0?74:72;continue;}
case 72:{f.Push(JValue.I(0));f.Pc=73;continue;}
case 73:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/card/Card","canBeShielded","()Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int!=0?83:81;continue;}
case 81:{f.Push(JValue.I(0));f.Pc=82;continue;}
case 82:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int==0?99:90;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int>0?99:97;continue;}
case 97:{f.Push(JValue.I(0));f.Pc=98;continue;}
case 98:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.String("ValidCause")));f.Pc=102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",111);}
case 111:{return rt.Call(f,"forge/game/replacement/ReplaceDestroy","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int!=0?119:117;continue;}
case 117:{f.Push(JValue.I(0));f.Pc=118;continue;}
case 118:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 119:{f.Push(JValue.I(1));f.Pc=120;continue;}
case 120:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8914(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Affected","Lforge/game/ability/AbilityKey;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",13);}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObject","(Lforge/game/ability/AbilityKey;Ljava/lang/Object;)V","invokevirtual",16);}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.NewArray("Lforge/game/ability/AbilityKey;",f.Pop().Int)));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=27;continue;}
case 27:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","setReplacingObjectsFrom","(Ljava/util/Map;[Lforge/game/ability/AbilityKey;)V","invokevirtual",31);}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
