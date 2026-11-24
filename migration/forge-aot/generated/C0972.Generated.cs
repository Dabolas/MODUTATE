// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C972{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerManaAdded","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10577,"forge/game/trigger/TriggerManaAdded","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10577));
c.Add(new JMethod(10578,"forge/game/trigger/TriggerManaAdded","performTest","(Ljava/util/Map;)Z",17,4,4,new JHandler[]{},M10578));
c.Add(new JMethod(10579,"forge/game/trigger/TriggerManaAdded","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",17,3,6,new JHandler[]{},M10579));
c.Add(new JMethod(10580,"forge/game/trigger/TriggerManaAdded","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,2,3,new JHandler[]{},M10580));
}

internal static JStep M10577(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10578(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidSource")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",12);}
case 12:{return rt.Call(f,"forge/game/trigger/TriggerManaAdded","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?20:18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("ValidSA")));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AbilityMana","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AbilityMana","Lforge/game/ability/AbilityKey;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",32);}
case 32:{return rt.Call(f,"forge/game/trigger/TriggerManaAdded","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int!=0?40:38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("Player")));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",52);}
case 52:{return rt.Call(f,"forge/game/trigger/TriggerManaAdded","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int!=0?60:58;continue;}
case 58:{f.Push(JValue.I(0));f.Pc=59;continue;}
case 59:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("Produced")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/trigger/TriggerManaAdded","hasParam","(Ljava/lang/String;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?154:69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"));f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",78);}
case 78:{f.Locals[2]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"java/lang/String")?1:0));f.Pc=83;continue;}
case 83:{f.Pc=f.Pop().Int!=0?88:86;continue;}
case 86:{f.Push(JValue.I(0));f.Pc=87;continue;}
case 87:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=92;continue;}
case 92:{f.Locals[3]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("Produced")));f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/trigger/TriggerManaAdded","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",101);}
case 101:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int==0?136:107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/trigger/TriggerManaAdded","getHostCard","()Lforge/game/card/Card;","invokevirtual",111);}
case 111:{return rt.Call(f,"forge/game/card/Card","hasChosenColor","()Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?134:117;continue;}
case 117:{f.Push(f.Locals[3]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/trigger/TriggerManaAdded","getHostCard","()Lforge/game/card/Card;","invokevirtual",122);}
case 122:{return rt.Call(f,"forge/game/card/Card","getChosenColor","()Ljava/lang/String;","invokevirtual",125);}
case 125:{return rt.Call(f,"forge/card/MagicColor","toShortString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",128);}
case 128:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int!=0?154:134;continue;}
case 134:{f.Push(JValue.I(0));f.Pc=135;continue;}
case 135:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 136:{f.Push(f.Locals[3]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("Produced")));f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/trigger/TriggerManaAdded","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",143);}
case 143:{return rt.Call(f,"forge/card/MagicColor","toShortString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",146);}
case 146:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",149);}
case 149:{f.Pc=f.Pop().Int!=0?154:152;continue;}
case 152:{f.Push(JValue.I(0));f.Pc=153;continue;}
case 153:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 154:{f.Push(JValue.I(1));f.Pc=155;continue;}
case 155:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10579(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(3));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.NewArray("Lforge/game/ability/AbilityKey;",f.Pop().Int)));f.Pc=6;continue;}
case 6:{f.StackOp("dup");f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=11;continue;}
case 11:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=17;continue;}
case 17:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.I(2));f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"));f.Pc=23;continue;}
case 23:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/ability/AbilityKey","copyKeys","(Ljava/util/Map;Ljava/util/Map;[Lforge/game/ability/AbilityKey;)V","invokestatic",27);}
case 27:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10580(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",3);}
case 3:{f.Push(JValue.R(rt.String("lblProduced")));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",19);}
case 19:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/util/TextUtil","toManaString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",25);}
case 25:{return rt.DynamicCall(f,"forge/game/trigger/TriggerManaAdded:10580:25:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",30);}
case 30:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
