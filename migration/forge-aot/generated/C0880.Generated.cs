// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C880{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityView","forge/trackable/TrackableObject",new string[]{"forge/game/card/IHasCardView"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JMethod(10109,"forge/game/staticability/StaticAbilityView","<init>","(Lforge/game/staticability/StaticAbility;)V",0,2,3,new JHandler[]{},M10109));
c.Add(new JMethod(10110,"forge/game/staticability/StaticAbilityView","<init>","(Lforge/game/staticability/StaticAbility;Lforge/trackable/Tracker;)V",0,3,3,new JHandler[]{},M10110));
c.Add(new JMethod(10111,"forge/game/staticability/StaticAbilityView","getCardView","()Lforge/game/card/CardView;",1,1,1,new JHandler[]{},M10111));
c.Add(new JMethod(10112,"forge/game/staticability/StaticAbilityView","getHostCard","()Lforge/game/card/CardView;",1,1,2,new JHandler[]{},M10112));
c.Add(new JMethod(10113,"forge/game/staticability/StaticAbilityView","updateHostCard","(Lforge/game/staticability/StaticAbility;)V",0,2,3,new JHandler[]{},M10113));
c.Add(new JMethod(10114,"forge/game/staticability/StaticAbilityView","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M10114));
c.Add(new JMethod(10115,"forge/game/staticability/StaticAbilityView","getDescription","()Ljava/lang/String;",1,1,2,new JHandler[]{},M10115));
c.Add(new JMethod(10116,"forge/game/staticability/StaticAbilityView","updateDescription","(Lforge/game/staticability/StaticAbility;)V",0,2,3,new JHandler[]{},M10116));
}

internal static JStep M10109(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Reference==null?19:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Reference!=null?23:19;continue;}
case 19:{f.Push(JValue.R(null));f.Pc=20;continue;}
case 20:{f.Pc=33;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",27);}
case 27:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",30);}
case 30:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",33);}
case 33:{return rt.Call(f,"forge/game/staticability/StaticAbilityView","<init>","(Lforge/game/staticability/StaticAbility;Lforge/trackable/Tracker;)V","invokespecial",36);}
case 36:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10110(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/trackable/TrackableObject","<init>","(ILforge/trackable/Tracker;)V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/staticability/StaticAbilityView","updateHostCard","(Lforge/game/staticability/StaticAbility;)V","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/staticability/StaticAbilityView","updateDescription","(Lforge/game/staticability/StaticAbility;)V","invokevirtual",19);}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10111(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/staticability/StaticAbilityView","getHostCard","()Lforge/game/card/CardView;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10112(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HostCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HostCard","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbilityView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10113(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HostCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HostCard","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/staticability/StaticAbilityView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10114(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/staticability/StaticAbilityView","getDescription","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10115(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Description","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Description","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbilityView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10116(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Description","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Description","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/staticability/StaticAbility","toString","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/staticability/StaticAbilityView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
