// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C178{
internal static JClass Build(){var c=new JClass("forge/game/TriggerReplacementBase","forge/game/CardTraitBase",new string[]{"forge/game/IIdentifiable","java/lang/Cloneable"},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("validHostZones","Ljava/util/EnumSet;",false,JValue.Default("Ljava/util/EnumSet;"),null));
c.Add(new JField("overridingAbility","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JMethod(2765,"forge/game/TriggerReplacementBase","<init>","()V",1,1,2,new JHandler[]{},M2765));
c.Add(new JMethod(2766,"forge/game/TriggerReplacementBase","setHostCard","(Lforge/game/card/Card;)V",1,2,2,new JHandler[]{},M2766));
c.Add(new JMethod(2767,"forge/game/TriggerReplacementBase","setKeyword","(Lforge/game/keyword/KeywordInterface;)V",1,2,2,new JHandler[]{},M2767));
c.Add(new JMethod(2768,"forge/game/TriggerReplacementBase","setCardState","(Lforge/game/card/CardState;)V",1,2,2,new JHandler[]{},M2768));
c.Add(new JMethod(2769,"forge/game/TriggerReplacementBase","getActiveZone","()Ljava/util/Set;",1,1,1,new JHandler[]{},M2769));
c.Add(new JMethod(2770,"forge/game/TriggerReplacementBase","setActiveZone","(Ljava/util/EnumSet;)V",1,2,2,new JHandler[]{},M2770));
c.Add(new JMethod(2771,"forge/game/TriggerReplacementBase","zonesCheck","(Lforge/game/zone/Zone;)Z",17,2,2,new JHandler[]{},M2771));
c.Add(new JMethod(2772,"forge/game/TriggerReplacementBase","getOverridingAbility","()Lforge/game/spellability/SpellAbility;",1,1,1,new JHandler[]{},M2772));
c.Add(new JMethod(2773,"forge/game/TriggerReplacementBase","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V",1,2,2,new JHandler[]{},M2773));
c.Add(new JMethod(2774,"forge/game/TriggerReplacementBase","ensureAbility","()Lforge/game/spellability/SpellAbility;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(2775,"forge/game/TriggerReplacementBase","changeText","()V",1,2,1,new JHandler[]{},M2775));
c.Add(new JMethod(2776,"forge/game/TriggerReplacementBase","changeTextIntrinsic","(Ljava/util/Map;Ljava/util/Map;)V",1,4,3,new JHandler[]{},M2776));
}

internal static JStep M2765(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/CardTraitBase","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/TriggerReplacementBase","overridingAbility","Lforge/game/spellability/SpellAbility;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2766(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/CardTraitBase","setHostCard","(Lforge/game/card/Card;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/TriggerReplacementBase","overridingAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference==null?20:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/TriggerReplacementBase","overridingAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",20);}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2767(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/CardTraitBase","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/TriggerReplacementBase","overridingAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference==null?20:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/TriggerReplacementBase","overridingAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",20);}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2768(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/CardTraitBase","setCardState","(Lforge/game/card/CardState;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/TriggerReplacementBase","overridingAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference==null?20:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/TriggerReplacementBase","overridingAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",20);}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2769(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/TriggerReplacementBase","validHostZones","Ljava/util/EnumSet;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2770(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/TriggerReplacementBase","validHostZones","Ljava/util/EnumSet;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2771(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/TriggerReplacementBase","hostCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?49:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/TriggerReplacementBase","validHostZones","Ljava/util/EnumSet;"));f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Reference==null?45:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/TriggerReplacementBase","validHostZones","Ljava/util/EnumSet;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/EnumSet","isEmpty","()Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int!=0?45:27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Pc=f.Pop().Reference==null?49:31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/TriggerReplacementBase","validHostZones","Ljava/util/EnumSet;"));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",39);}
case 39:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?49:45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{f.Pc=50;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2772(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/TriggerReplacementBase","overridingAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2773(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/TriggerReplacementBase","overridingAbility","Lforge/game/spellability/SpellAbility;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/TriggerReplacementBase","intrinsic","Z"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2775(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/TriggerReplacementBase","isIntrinsic","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/CardTraitBase","changeText","()V","invokespecial",12);}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/TriggerReplacementBase","ensureAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",16);}
case 16:{f.Locals[1]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Reference==null?25:21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","changeText","()V","invokevirtual",25);}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2776(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/CardTraitBase","changeTextIntrinsic","(Ljava/util/Map;Ljava/util/Map;)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/TriggerReplacementBase","ensureAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",10);}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference==null?21:15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","changeTextIntrinsic","(Ljava/util/Map;Ljava/util/Map;)V","invokevirtual",21);}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
