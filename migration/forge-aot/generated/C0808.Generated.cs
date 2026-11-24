// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C808{
internal static JClass Build(){var c=new JClass("forge/game/spellability/SpellAbilityView","forge/trackable/TrackableObject",new string[]{"forge/game/card/IHasCardView"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(2514234930798754769L),null));
c.Add(new JMethod(9662,"forge/game/spellability/SpellAbilityView","get","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbilityView;",9,1,1,new JHandler[]{},M9662));
c.Add(new JMethod(9663,"forge/game/spellability/SpellAbilityView","getMap","(Ljava/lang/Iterable;)Ljava/util/Map;",9,4,3,new JHandler[]{},M9663));
c.Add(new JMethod(9664,"forge/game/spellability/SpellAbilityView","<init>","(Lforge/game/spellability/SpellAbility;)V",0,2,3,new JHandler[]{},M9664));
c.Add(new JMethod(9665,"forge/game/spellability/SpellAbilityView","<init>","(Lforge/game/spellability/SpellAbility;Lforge/trackable/Tracker;)V",0,3,3,new JHandler[]{},M9665));
c.Add(new JMethod(9666,"forge/game/spellability/SpellAbilityView","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9666));
c.Add(new JMethod(9667,"forge/game/spellability/SpellAbilityView","getHostCard","()Lforge/game/card/CardView;",1,1,2,new JHandler[]{},M9667));
c.Add(new JMethod(9668,"forge/game/spellability/SpellAbilityView","updateHostCard","(Lforge/game/spellability/SpellAbility;)V",0,2,3,new JHandler[]{},M9668));
c.Add(new JMethod(9669,"forge/game/spellability/SpellAbilityView","getDescription","()Ljava/lang/String;",1,1,2,new JHandler[]{},M9669));
c.Add(new JMethod(9670,"forge/game/spellability/SpellAbilityView","updateDescription","(Lforge/game/spellability/SpellAbility;)V",0,2,3,new JHandler[]{},M9670));
c.Add(new JMethod(9671,"forge/game/spellability/SpellAbilityView","canPlay","()Z",1,1,2,new JHandler[]{},M9671));
c.Add(new JMethod(9672,"forge/game/spellability/SpellAbilityView","updateCanPlay","(Lforge/game/spellability/SpellAbility;)V",1,2,4,new JHandler[]{},M9672));
c.Add(new JMethod(9673,"forge/game/spellability/SpellAbilityView","promptIfOnlyPossibleAbility","()Z",1,1,2,new JHandler[]{},M9673));
c.Add(new JMethod(9674,"forge/game/spellability/SpellAbilityView","updatePromptIfOnlyPossibleAbility","(Lforge/game/spellability/SpellAbility;)V",0,2,3,new JHandler[]{},M9674));
c.Add(new JMethod(9675,"forge/game/spellability/SpellAbilityView","isSpell","()Z",1,1,2,new JHandler[]{},M9675));
c.Add(new JMethod(9676,"forge/game/spellability/SpellAbilityView","updateIsSpell","(Lforge/game/spellability/SpellAbility;)V",0,2,3,new JHandler[]{},M9676));
c.Add(new JMethod(9677,"forge/game/spellability/SpellAbilityView","getCardView","()Lforge/game/card/CardView;",1,1,1,new JHandler[]{},M9677));
}

internal static JStep M9662(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?8:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Pc=12;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getView","()Lforge/game/spellability/SpellAbilityView;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9663(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Maps","newLinkedHashMap","()Ljava/util/LinkedHashMap;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?45:20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",26);}
case 26:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=29;continue;}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","getView","()Lforge/game/spellability/SpellAbilityView;","invokevirtual",35);}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",41);}
case 41:{f.StackOp("pop");f.Pc=42;continue;}
case 42:{f.Pc=11;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9664(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Reference==null?19:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Reference!=null?23:19;continue;}
case 19:{f.Push(JValue.R(null));f.Pc=20;continue;}
case 20:{f.Pc=33;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",27);}
case 27:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",30);}
case 30:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",33);}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","<init>","(Lforge/game/spellability/SpellAbility;Lforge/trackable/Tracker;)V","invokespecial",36);}
case 36:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9665(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","getId","()I","invokevirtual",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/trackable/TrackableObject","<init>","(ILforge/trackable/Tracker;)V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","updateHostCard","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","updateDescription","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","updatePromptIfOnlyPossibleAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",24);}
case 24:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9666(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","getDescription","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9667(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HostCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HostCard","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9668(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HostCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HostCard","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9669(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Description","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Description","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9670(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Description","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Description","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","toUnsuppressedString","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9671(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CanPlay","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CanPlay","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9672(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","CanPlay","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","CanPlay","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","canPlay","(Z)Z","invokevirtual",9);}
case 9:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",12);}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",15);}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9673(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PromptIfOnlyPossibleAbility","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PromptIfOnlyPossibleAbility","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9674(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PromptIfOnlyPossibleAbility","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PromptIfOnlyPossibleAbility","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","promptIfOnlyPossibleAbility","()Z","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9675(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SA_IsSpell","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SA_IsSpell","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9676(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SA_IsSpell","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SA_IsSpell","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9677(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbilityView","getHostCard","()Lforge/game/card/CardView;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
