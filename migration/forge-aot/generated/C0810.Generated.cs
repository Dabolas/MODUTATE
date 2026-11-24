// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C810{
internal static JClass Build(){var c=new JClass("forge/game/spellability/StackItemView","forge/trackable/TrackableObject",new string[]{"forge/game/card/IHasCardView"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(6733415646691356052L),null));
c.Add(new JMethod(9681,"forge/game/spellability/StackItemView","get","(Lforge/game/spellability/SpellAbilityStackInstance;)Lforge/game/spellability/StackItemView;",9,1,1,new JHandler[]{},M9681));
c.Add(new JMethod(9682,"forge/game/spellability/StackItemView","getCollection","(Ljava/lang/Iterable;)Lforge/trackable/TrackableCollection;",9,4,2,new JHandler[]{},M9682));
c.Add(new JMethod(9683,"forge/game/spellability/StackItemView","<init>","(Lforge/game/spellability/SpellAbilityStackInstance;)V",1,2,3,new JHandler[]{},M9683));
c.Add(new JMethod(9684,"forge/game/spellability/StackItemView","<init>","(ILforge/trackable/Tracker;)V",1,3,3,new JHandler[]{},M9684));
c.Add(new JMethod(9685,"forge/game/spellability/StackItemView","getKey","()Ljava/lang/String;",1,1,2,new JHandler[]{},M9685));
c.Add(new JMethod(9686,"forge/game/spellability/StackItemView","updateKey","(Lforge/game/spellability/SpellAbilityStackInstance;)V",0,2,3,new JHandler[]{},M9686));
c.Add(new JMethod(9687,"forge/game/spellability/StackItemView","getOptionalCostString","()Ljava/lang/String;",1,1,2,new JHandler[]{},M9687));
c.Add(new JMethod(9688,"forge/game/spellability/StackItemView","updateOptionalCost","(Lforge/game/spellability/SpellAbilityStackInstance;)V",0,13,3,new JHandler[]{},M9688));
c.Add(new JMethod(9689,"forge/game/spellability/StackItemView","isTrigger","()Z",1,1,1,new JHandler[]{},M9689));
c.Add(new JMethod(9690,"forge/game/spellability/StackItemView","getSourceTrigger","()I",1,1,2,new JHandler[]{},M9690));
c.Add(new JMethod(9691,"forge/game/spellability/StackItemView","updateSourceTrigger","(Lforge/game/spellability/SpellAbilityStackInstance;)V",0,2,3,new JHandler[]{},M9691));
c.Add(new JMethod(9692,"forge/game/spellability/StackItemView","getText","()Ljava/lang/String;",1,1,2,new JHandler[]{},M9692));
c.Add(new JMethod(9693,"forge/game/spellability/StackItemView","updateText","(Lforge/game/spellability/SpellAbilityStackInstance;)V",0,2,3,new JHandler[]{},M9693));
c.Add(new JMethod(9694,"forge/game/spellability/StackItemView","getSourceCard","()Lforge/game/card/CardView;",1,1,2,new JHandler[]{},M9694));
c.Add(new JMethod(9695,"forge/game/spellability/StackItemView","updateSourceCard","(Lforge/game/spellability/SpellAbilityStackInstance;)V",0,2,3,new JHandler[]{},M9695));
c.Add(new JMethod(9696,"forge/game/spellability/StackItemView","getActivatingPlayer","()Lforge/game/player/PlayerView;",1,1,2,new JHandler[]{},M9696));
c.Add(new JMethod(9697,"forge/game/spellability/StackItemView","updateActivatingPlayer","(Lforge/game/spellability/SpellAbilityStackInstance;)V",0,2,3,new JHandler[]{},M9697));
c.Add(new JMethod(9698,"forge/game/spellability/StackItemView","getTargetCards","()Lforge/util/collect/FCollectionView;",1,1,2,new JHandler[]{},M9698));
c.Add(new JMethod(9699,"forge/game/spellability/StackItemView","updateTargetCards","(Lforge/game/spellability/SpellAbilityStackInstance;)V",0,2,3,new JHandler[]{},M9699));
c.Add(new JMethod(9700,"forge/game/spellability/StackItemView","getTargetPlayers","()Lforge/util/collect/FCollectionView;",1,1,2,new JHandler[]{},M9700));
c.Add(new JMethod(9701,"forge/game/spellability/StackItemView","updateTargetPlayers","(Lforge/game/spellability/SpellAbilityStackInstance;)V",0,2,3,new JHandler[]{},M9701));
c.Add(new JMethod(9702,"forge/game/spellability/StackItemView","getTargetStackItems","()Lforge/util/collect/FCollectionView;",1,1,2,new JHandler[]{},M9702));
c.Add(new JMethod(9703,"forge/game/spellability/StackItemView","updateTargetStackItems","(Lforge/game/spellability/SpellAbilityStackInstance;)V",0,7,3,new JHandler[]{},M9703));
c.Add(new JMethod(9704,"forge/game/spellability/StackItemView","isAbility","()Z",1,1,2,new JHandler[]{},M9704));
c.Add(new JMethod(9705,"forge/game/spellability/StackItemView","updateAbility","(Lforge/game/spellability/SpellAbilityStackInstance;)V",0,2,3,new JHandler[]{},M9705));
c.Add(new JMethod(9706,"forge/game/spellability/StackItemView","isOptionalTrigger","()Z",1,1,2,new JHandler[]{},M9706));
c.Add(new JMethod(9707,"forge/game/spellability/StackItemView","updateOptionalTrigger","(Lforge/game/spellability/SpellAbilityStackInstance;)V",0,2,3,new JHandler[]{},M9707));
c.Add(new JMethod(9708,"forge/game/spellability/StackItemView","getSubInstance","()Lforge/game/spellability/StackItemView;",1,1,2,new JHandler[]{},M9708));
c.Add(new JMethod(9709,"forge/game/spellability/StackItemView","updateSubInstance","(Lforge/game/spellability/SpellAbilityStackInstance;)V",0,2,5,new JHandler[]{},M9709));
c.Add(new JMethod(9710,"forge/game/spellability/StackItemView","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9710));
c.Add(new JMethod(9711,"forge/game/spellability/StackItemView","getCardView","()Lforge/game/card/CardView;",1,1,1,new JHandler[]{},M9711));
}

internal static JStep M9681(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?8:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Pc=12;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getView","()Lforge/game/spellability/StackItemView;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9682(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableCollection")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/trackable/TrackableCollection","<init>","()V","invokespecial",13);}
case 13:{f.Locals[1]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int==0?52:30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",36);}
case 36:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=39;continue;}
case 39:{f.Locals[3]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getView","()Lforge/game/spellability/StackItemView;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/trackable/TrackableCollection","add","(Ljava/lang/Object;)Z","invokevirtual",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Pc=21;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9683(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getId","()I","invokevirtual",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSourceCard","()Lforge/game/card/Card;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/Game","getTracker","()Lforge/trackable/Tracker;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/trackable/TrackableObject","<init>","(ILforge/trackable/Tracker;)V","invokespecial",18);}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/StackItemView","updateKey","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",23);}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/StackItemView","updateSourceTrigger","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",28);}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/StackItemView","updateText","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",33);}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/spellability/StackItemView","updateSourceCard","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",38);}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/StackItemView","updateActivatingPlayer","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",43);}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/StackItemView","updateTargetCards","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",48);}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/StackItemView","updateTargetPlayers","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",53);}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/spellability/StackItemView","updateTargetStackItems","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",58);}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/spellability/StackItemView","updateAbility","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",63);}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/spellability/StackItemView","updateOptionalTrigger","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",68);}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/StackItemView","updateSubInstance","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",73);}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/spellability/StackItemView","updateOptionalCost","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",78);}
case 78:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9684(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/trackable/TrackableObject","<init>","(ILforge/trackable/Tracker;)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9685(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Key","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Key","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/StackItemView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9686(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Key","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Key","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","yieldKey","()Ljava/lang/String;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/spellability/StackItemView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9687(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OptionalCosts","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OptionalCosts","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/StackItemView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9688(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("")));f.Pc=2;continue;}
case 2:{f.Locals[2]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Locals[4]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Locals[5]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{f.Locals[6]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Locals[7]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{f.Locals[8]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{f.Locals[9]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{f.Locals[10]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",30);}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOptionalCosts","()Ljava/lang/Iterable;","invokevirtual",33);}
case 33:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",38);}
case 38:{f.Locals[11]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[11]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",47);}
case 47:{f.Pc=f.Pop().Int==0?160:50;continue;}
case 50:{f.Push(f.Locals[11]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",57);}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/OptionalCost"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{f.Locals[12]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[12]);f.Pc=64;continue;}
case 64:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Kicker1","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Kicker1","Lforge/game/spellability/OptionalCost;"));f.Pc=67;continue;}
case 67:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?78:70;continue;}
case 70:{f.Push(f.Locals[12]);f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Kicker2","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Kicker2","Lforge/game/spellability/OptionalCost;"));f.Pc=75;continue;}
case 75:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?80:78;continue;}
case 78:{f.Push(JValue.I(1));f.Pc=79;continue;}
case 79:{f.Locals[3]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[12]);f.Pc=82;continue;}
case 82:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Entwine","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Entwine","Lforge/game/spellability/OptionalCost;"));f.Pc=85;continue;}
case 85:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?91:88;continue;}
case 88:{f.Push(JValue.I(1));f.Pc=89;continue;}
case 89:{f.Locals[4]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[12]);f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Buyback","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Buyback","Lforge/game/spellability/OptionalCost;"));f.Pc=96;continue;}
case 96:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?102:99;continue;}
case 99:{f.Push(JValue.I(1));f.Pc=100;continue;}
case 100:{f.Locals[5]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[12]);f.Pc=104;continue;}
case 104:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Retrace","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Retrace","Lforge/game/spellability/OptionalCost;"));f.Pc=107;continue;}
case 107:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?113:110;continue;}
case 110:{f.Push(JValue.I(1));f.Pc=111;continue;}
case 111:{f.Locals[6]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[12]);f.Pc=115;continue;}
case 115:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Jumpstart","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Jumpstart","Lforge/game/spellability/OptionalCost;"));f.Pc=118;continue;}
case 118:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?124:121;continue;}
case 121:{f.Push(JValue.I(1));f.Pc=122;continue;}
case 122:{f.Locals[7]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[12]);f.Pc=126;continue;}
case 126:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Flash","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Flash","Lforge/game/spellability/OptionalCost;"));f.Pc=129;continue;}
case 129:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?135:132;continue;}
case 132:{f.Push(JValue.I(1));f.Pc=133;continue;}
case 133:{f.Locals[8]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[12]);f.Pc=137;continue;}
case 137:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","Generic","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","Generic","Lforge/game/spellability/OptionalCost;"));f.Pc=140;continue;}
case 140:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?146:143;continue;}
case 143:{f.Push(JValue.I(1));f.Pc=144;continue;}
case 144:{f.Locals[10]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[12]);f.Pc=148;continue;}
case 148:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","AltCost","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","AltCost","Lforge/game/spellability/OptionalCost;"));f.Pc=151;continue;}
case 151:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?157:154;continue;}
case 154:{f.Push(JValue.I(1));f.Pc=155;continue;}
case 155:{f.Locals[9]=f.Pop();f.Pc=157;continue;}
case 157:{f.Pc=40;continue;}
case 160:{f.Push(f.Locals[9]);f.Pc=162;continue;}
case 162:{f.Pc=f.Pop().Int!=0?316:165;continue;}
case 165:{f.Push(f.Locals[3]);f.Pc=166;continue;}
case 166:{f.Pc=f.Pop().Int==0?181:169;continue;}
case 169:{f.Push(f.Locals[10]);f.Pc=171;continue;}
case 171:{f.Pc=f.Pop().Int!=0?181:174;continue;}
case 174:{f.Push(f.Locals[2]);f.Pc=175;continue;}
case 175:{return rt.DynamicCall(f,"forge/game/spellability/StackItemView:9688:175:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",180);}
case 180:{f.Locals[2]=f.Pop();f.Pc=181;continue;}
case 181:{f.Push(f.Locals[4]);f.Pc=183;continue;}
case 183:{f.Pc=f.Pop().Int==0?207:186;continue;}
case 186:{f.Push(f.Locals[2]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[2]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",191);}
case 191:{f.Pc=f.Pop().Int==0?199:194;continue;}
case 194:{f.Push(JValue.R(rt.String("Entwined")));f.Pc=196;continue;}
case 196:{f.Pc=201;continue;}
case 199:{f.Push(JValue.R(rt.String(", Entwined")));f.Pc=201;continue;}
case 201:{return rt.DynamicCall(f,"forge/game/spellability/StackItemView:9688:201:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",206);}
case 206:{f.Locals[2]=f.Pop();f.Pc=207;continue;}
case 207:{f.Push(f.Locals[5]);f.Pc=209;continue;}
case 209:{f.Pc=f.Pop().Int==0?233:212;continue;}
case 212:{f.Push(f.Locals[2]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[2]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",217);}
case 217:{f.Pc=f.Pop().Int==0?225:220;continue;}
case 220:{f.Push(JValue.R(rt.String("Buyback")));f.Pc=222;continue;}
case 222:{f.Pc=227;continue;}
case 225:{f.Push(JValue.R(rt.String(", Buyback")));f.Pc=227;continue;}
case 227:{return rt.DynamicCall(f,"forge/game/spellability/StackItemView:9688:227:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",232);}
case 232:{f.Locals[2]=f.Pop();f.Pc=233;continue;}
case 233:{f.Push(f.Locals[6]);f.Pc=235;continue;}
case 235:{f.Pc=f.Pop().Int==0?259:238;continue;}
case 238:{f.Push(f.Locals[2]);f.Pc=239;continue;}
case 239:{f.Push(f.Locals[2]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",243);}
case 243:{f.Pc=f.Pop().Int==0?251:246;continue;}
case 246:{f.Push(JValue.R(rt.String("Retraced")));f.Pc=248;continue;}
case 248:{f.Pc=253;continue;}
case 251:{f.Push(JValue.R(rt.String(", Retraced")));f.Pc=253;continue;}
case 253:{return rt.DynamicCall(f,"forge/game/spellability/StackItemView:9688:253:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",258);}
case 258:{f.Locals[2]=f.Pop();f.Pc=259;continue;}
case 259:{f.Push(f.Locals[7]);f.Pc=261;continue;}
case 261:{f.Pc=f.Pop().Int==0?285:264;continue;}
case 264:{f.Push(f.Locals[2]);f.Pc=265;continue;}
case 265:{f.Push(f.Locals[2]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",269);}
case 269:{f.Pc=f.Pop().Int==0?277:272;continue;}
case 272:{f.Push(JValue.R(rt.String("Jumpstart")));f.Pc=274;continue;}
case 274:{f.Pc=279;continue;}
case 277:{f.Push(JValue.R(rt.String(", Jumpstart")));f.Pc=279;continue;}
case 279:{return rt.DynamicCall(f,"forge/game/spellability/StackItemView:9688:279:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",284);}
case 284:{f.Locals[2]=f.Pop();f.Pc=285;continue;}
case 285:{f.Push(f.Locals[8]);f.Pc=287;continue;}
case 287:{f.Pc=f.Pop().Int!=0?295:290;continue;}
case 290:{f.Push(f.Locals[10]);f.Pc=292;continue;}
case 292:{f.Pc=f.Pop().Int==0?316:295;continue;}
case 295:{f.Push(f.Locals[2]);f.Pc=296;continue;}
case 296:{f.Push(f.Locals[2]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",300);}
case 300:{f.Pc=f.Pop().Int==0?308:303;continue;}
case 303:{f.Push(JValue.R(rt.String("Additional")));f.Pc=305;continue;}
case 305:{f.Pc=310;continue;}
case 308:{f.Push(JValue.R(rt.String(", Additional")));f.Pc=310;continue;}
case 310:{return rt.DynamicCall(f,"forge/game/spellability/StackItemView:9688:310:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",315);}
case 315:{f.Locals[2]=f.Pop();f.Pc=316;continue;}
case 316:{f.Push(f.Locals[0]);f.Pc=317;continue;}
case 317:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OptionalCosts","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OptionalCosts","Lforge/trackable/TrackableProperty;"));f.Pc=320;continue;}
case 320:{f.Push(f.Locals[2]);f.Pc=321;continue;}
case 321:{return rt.Call(f,"forge/game/spellability/StackItemView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",324);}
case 324:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9689(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/StackItemView","getSourceTrigger","()I","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int<=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9690(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SourceTrigger","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SourceTrigger","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/StackItemView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9691(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SourceTrigger","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SourceTrigger","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSourceTrigger","()I","invokevirtual",11);}
case 11:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",14);}
case 14:{return rt.Call(f,"forge/game/spellability/StackItemView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",17);}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9692(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Description","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Description","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/StackItemView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9693(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Description","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Description","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getStackDescription","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/spellability/StackItemView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9694(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SourceCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SourceCard","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/StackItemView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9695(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SourceCard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SourceCard","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSourceCard","()Lforge/game/card/Card;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView","get","(Lforge/game/card/Card;)Lforge/game/card/CardView;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/spellability/StackItemView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9696(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ActivatingPlayer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ActivatingPlayer","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/StackItemView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/PlayerView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9697(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ActivatingPlayer","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ActivatingPlayer","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/player/PlayerView","get","(Lforge/game/player/Player;)Lforge/game/player/PlayerView;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/spellability/StackItemView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9698(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","TargetCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","TargetCards","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/StackItemView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9699(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","TargetCards","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","TargetCards","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getTargetChoices","()Lforge/game/spellability/TargetChoices;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView","getCollection","(Ljava/lang/Iterable;)Lforge/trackable/TrackableCollection;","invokestatic",14);}
case 14:{return rt.Call(f,"forge/game/spellability/StackItemView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",17);}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9700(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","TargetPlayers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","TargetPlayers","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/StackItemView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9701(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","TargetPlayers","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","TargetPlayers","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getTargetChoices","()Lforge/game/spellability/TargetChoices;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetPlayers","()Ljava/lang/Iterable;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/player/PlayerView","getCollection","(Ljava/lang/Iterable;)Lforge/trackable/TrackableCollection;","invokestatic",14);}
case 14:{return rt.Call(f,"forge/game/spellability/StackItemView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",17);}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9702(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","TargetStackItems","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","TargetStackItems","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/StackItemView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/collect/FCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9703(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getTargetChoices","()Lforge/game/spellability/TargetChoices;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/spellability/TargetChoices","isTargetingAnySpell","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?19:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","TargetStackItems","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","TargetStackItems","Lforge/trackable/TrackableProperty;"));f.Pc=14;continue;}
case 14:{f.Push(JValue.R(null));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/StackItemView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",18);}
case 18:{return JStep.ReturnVoid;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSourceCard","()Lforge/game/card/Card;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",29);}
case 29:{f.Locals[2]=f.Pop();f.Pc=30;continue;}
case 30:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",37);}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getTargetChoices","()Lforge/game/spellability/TargetChoices;","invokevirtual",42);}
case 42:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetSpells","()Ljava/lang/Iterable;","invokevirtual",45);}
case 45:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",50);}
case 50:{f.Locals[4]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",59);}
case 59:{f.Pc=f.Pop().Int==0?105:62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",69);}
case 69:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=72;continue;}
case 72:{f.Locals[5]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[5]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/zone/MagicStack","getInstanceMatchingSpellAbilityID","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbilityStackInstance;","invokevirtual",80);}
case 80:{f.Locals[6]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[6]);f.Pc=84;continue;}
case 84:{f.Pc=f.Pop().Reference==null?102:87;continue;}
case 87:{f.Push(f.Locals[6]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?102:93;continue;}
case 93:{f.Push(f.Locals[3]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[6]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",101);}
case 101:{f.StackOp("pop");f.Pc=102;continue;}
case 102:{f.Pc=52;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","TargetStackItems","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","TargetStackItems","Lforge/trackable/TrackableProperty;"));f.Pc=109;continue;}
case 109:{f.Push(f.Locals[3]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/spellability/StackItemView","getCollection","(Ljava/lang/Iterable;)Lforge/trackable/TrackableCollection;","invokestatic",113);}
case 113:{return rt.Call(f,"forge/game/spellability/StackItemView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",116);}
case 116:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9704(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Ability","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Ability","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/StackItemView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9705(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Ability","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Ability","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","isAbility","()Z","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/spellability/StackItemView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9706(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OptionalTrigger","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OptionalTrigger","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/StackItemView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9707(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OptionalTrigger","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OptionalTrigger","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","isOptionalTrigger","()Z","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/spellability/StackItemView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9708(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SubInstance","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SubInstance","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/StackItemView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/StackItemView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9709(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SubInstance","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SubInstance","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSubInstance","()Lforge/game/spellability/SpellAbilityStackInstance;","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Reference!=null?15:11;continue;}
case 11:{f.Push(JValue.R(null));f.Pc=12;continue;}
case 12:{f.Pc=26;continue;}
case 15:{if(!rt.EnsureInitialized(f,"forge/game/spellability/StackItemView"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/StackItemView")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSubInstance","()Lforge/game/spellability/SpellAbilityStackInstance;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/spellability/StackItemView","<init>","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokespecial",26);}
case 26:{return rt.Call(f,"forge/game/spellability/StackItemView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",29);}
case 29:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9710(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/StackItemView","getText","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9711(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/StackItemView","getSourceCard","()Lforge/game/card/CardView;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
