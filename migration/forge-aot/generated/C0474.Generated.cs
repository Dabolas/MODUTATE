// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C474{
internal static JClass Build(){var c=new JClass("forge/game/card/CardTraitChanges","java/lang/Record",new string[]{"forge/game/card/ICardTraitChanges"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("abilities","Ljava/util/Collection;",false,JValue.Default("Ljava/util/Collection;"),null));
c.Add(new JField("triggers","Ljava/util/Collection;",false,JValue.Default("Ljava/util/Collection;"),null));
c.Add(new JField("replacements","Ljava/util/Collection;",false,JValue.Default("Ljava/util/Collection;"),null));
c.Add(new JField("staticAbilities","Ljava/util/Collection;",false,JValue.Default("Ljava/util/Collection;"),null));
c.Add(new JField("remove","Ljava/util/function/Predicate;",false,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JMethod(5408,"forge/game/card/CardTraitChanges","<init>","(Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/function/Predicate;)V",1,6,2,new JHandler[]{},M5408));
c.Add(new JMethod(5409,"forge/game/card/CardTraitChanges","getAbilities","()Ljava/util/Collection;",1,1,2,new JHandler[]{},M5409));
c.Add(new JMethod(5410,"forge/game/card/CardTraitChanges","getTriggers","()Ljava/util/Collection;",1,1,2,new JHandler[]{},M5410));
c.Add(new JMethod(5411,"forge/game/card/CardTraitChanges","getReplacements","()Ljava/util/Collection;",1,1,2,new JHandler[]{},M5411));
c.Add(new JMethod(5412,"forge/game/card/CardTraitChanges","getStaticAbilities","()Ljava/util/Collection;",1,1,2,new JHandler[]{},M5412));
c.Add(new JMethod(5413,"forge/game/card/CardTraitChanges","containsCostChange","()Z",1,3,2,new JHandler[]{},M5413));
c.Add(new JMethod(5414,"forge/game/card/CardTraitChanges","copy","(Lforge/game/card/Card;Z)Lforge/game/card/CardTraitChanges;",1,3,8,new JHandler[]{},M5414));
c.Add(new JMethod(5415,"forge/game/card/CardTraitChanges","changeText","()V",1,3,1,new JHandler[]{},M5415));
c.Add(new JMethod(5416,"forge/game/card/CardTraitChanges","applySpellAbility","(Ljava/util/List;)Ljava/util/List;",1,2,2,new JHandler[]{},M5416));
c.Add(new JMethod(5417,"forge/game/card/CardTraitChanges","applyTrigger","(Ljava/util/List;)Ljava/util/List;",1,2,2,new JHandler[]{},M5417));
c.Add(new JMethod(5418,"forge/game/card/CardTraitChanges","applyReplacementEffect","(Ljava/util/List;)Ljava/util/List;",1,2,2,new JHandler[]{},M5418));
c.Add(new JMethod(5419,"forge/game/card/CardTraitChanges","applyStaticAbility","(Ljava/util/List;)Ljava/util/List;",1,2,2,new JHandler[]{},M5419));
c.Add(new JMethod(5420,"forge/game/card/CardTraitChanges","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M5420));
c.Add(new JMethod(5421,"forge/game/card/CardTraitChanges","hashCode","()I",17,1,1,new JHandler[]{},M5421));
c.Add(new JMethod(5422,"forge/game/card/CardTraitChanges","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M5422));
c.Add(new JMethod(5423,"forge/game/card/CardTraitChanges","abilities","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M5423));
c.Add(new JMethod(5424,"forge/game/card/CardTraitChanges","triggers","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M5424));
c.Add(new JMethod(5425,"forge/game/card/CardTraitChanges","replacements","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M5425));
c.Add(new JMethod(5426,"forge/game/card/CardTraitChanges","staticAbilities","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M5426));
c.Add(new JMethod(5427,"forge/game/card/CardTraitChanges","remove","()Ljava/util/function/Predicate;",1,1,1,new JHandler[]{},M5427));
c.Add(new JMethod(5428,"forge/game/card/CardTraitChanges","copy","(Lforge/game/card/Card;Z)Lforge/game/card/ICardTraitChanges;",4161,3,3,new JHandler[]{},M5428));
c.Add(new JMethod(5429,"forge/game/card/CardTraitChanges","lambda$copy$3","(Lforge/game/card/Card;ZLforge/game/staticability/StaticAbility;)Lforge/game/staticability/StaticAbility;",4106,3,3,new JHandler[]{},M5429));
c.Add(new JMethod(5430,"forge/game/card/CardTraitChanges","lambda$copy$2","(Lforge/game/card/Card;ZLforge/game/replacement/ReplacementEffect;)Lforge/game/replacement/ReplacementEffect;",4106,3,3,new JHandler[]{},M5430));
c.Add(new JMethod(5431,"forge/game/card/CardTraitChanges","lambda$copy$1","(Lforge/game/card/Card;ZLforge/game/trigger/Trigger;)Lforge/game/trigger/Trigger;",4106,3,3,new JHandler[]{},M5431));
c.Add(new JMethod(5432,"forge/game/card/CardTraitChanges","lambda$copy$0","(Lforge/game/card/Card;ZLforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbility;",4106,3,3,new JHandler[]{},M5432));
}

internal static JStep M5408(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardTraitChanges","abilities","Ljava/util/Collection;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardTraitChanges","triggers","Ljava/util/Collection;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardTraitChanges","replacements","Ljava/util/Collection;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardTraitChanges","staticAbilities","Ljava/util/Collection;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardTraitChanges","remove","Ljava/util/function/Predicate;",value);f.Pc=31;continue;}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5409(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardTraitChanges","abilities","Ljava/util/Collection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",7);}
case 7:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5410(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardTraitChanges","triggers","Ljava/util/Collection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",7);}
case 7:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5411(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardTraitChanges","replacements","Ljava/util/Collection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",7);}
case 7:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5412(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardTraitChanges","staticAbilities","Ljava/util/Collection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",7);}
case 7:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5413(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardTraitChanges","getStaticAbilities","()Ljava/util/Collection;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?54:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","ReduceCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","ReduceCost","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int!=0?49:39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","RaiseCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","RaiseCost","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?51:49;continue;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 51:{f.Pc=10;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5414(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardTraitChanges"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardTraitChanges")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardTraitChanges","getAbilities","()Ljava/util/Collection;","invokevirtual",8);}
case 8:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",13);}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.DynamicCall(f,"forge/game/card/CardTraitChanges:5414:15:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;Z)Ljava/util/function/Function;",20);}
case 20:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",25);}
case 25:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",28);}
case 28:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/CardTraitChanges","getTriggers","()Ljava/util/Collection;","invokevirtual",40);}
case 40:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",45);}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{return rt.DynamicCall(f,"forge/game/card/CardTraitChanges:5414:47:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;Z)Ljava/util/function/Function;",52);}
case 52:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",57);}
case 57:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",60);}
case 60:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/card/CardTraitChanges","getReplacements","()Ljava/util/Collection;","invokevirtual",72);}
case 72:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",77);}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{return rt.DynamicCall(f,"forge/game/card/CardTraitChanges:5414:79:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;Z)Ljava/util/function/Function;",84);}
case 84:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",89);}
case 89:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",92);}
case 92:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",97);}
case 97:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/card/CardTraitChanges","getStaticAbilities","()Ljava/util/Collection;","invokevirtual",104);}
case 104:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",109);}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{return rt.DynamicCall(f,"forge/game/card/CardTraitChanges:5414:111:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/card/Card;Z)Ljava/util/function/Function;",116);}
case 116:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",121);}
case 121:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",124);}
case 124:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",129);}
case 129:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardTraitChanges","remove","Ljava/util/function/Predicate;"));f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/card/CardTraitChanges","<init>","(Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/function/Predicate;)V","invokespecial",139);}
case 139:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5415(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardTraitChanges","getAbilities","()Ljava/util/Collection;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int==0?36:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{f.Locals[2]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","changeText","()V","invokevirtual",33);}
case 33:{f.Pc=10;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/CardTraitChanges","getTriggers","()Ljava/util/Collection;","invokevirtual",40);}
case 40:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",45);}
case 45:{f.Locals[1]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",52);}
case 52:{f.Pc=f.Pop().Int==0?72:55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",61);}
case 61:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=64;continue;}
case 64:{f.Locals[2]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/trigger/Trigger","changeText","()V","invokevirtual",69);}
case 69:{f.Pc=46;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/card/CardTraitChanges","getReplacements","()Ljava/util/Collection;","invokevirtual",76);}
case 76:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",81);}
case 81:{f.Locals[1]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",88);}
case 88:{f.Pc=f.Pop().Int==0?108:91;continue;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",97);}
case 97:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=100;continue;}
case 100:{f.Locals[2]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","changeText","()V","invokevirtual",105);}
case 105:{f.Pc=82;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/card/CardTraitChanges","getStaticAbilities","()Ljava/util/Collection;","invokevirtual",112);}
case 112:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",117);}
case 117:{f.Locals[1]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",124);}
case 124:{f.Pc=f.Pop().Int==0?144:127;continue;}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",133);}
case 133:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=136;continue;}
case 136:{f.Locals[2]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[2]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/staticability/StaticAbility","changeText","()V","invokevirtual",141);}
case 141:{f.Pc=118;continue;}
case 144:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5416(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardTraitChanges","remove","Ljava/util/function/Predicate;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?18:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardTraitChanges","remove","Ljava/util/function/Predicate;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",17);}
case 17:{f.StackOp("pop");f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardTraitChanges","getAbilities","()Ljava/util/Collection;","invokevirtual",23);}
case 23:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5417(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardTraitChanges","remove","Ljava/util/function/Predicate;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?18:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardTraitChanges","remove","Ljava/util/function/Predicate;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",17);}
case 17:{f.StackOp("pop");f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardTraitChanges","getTriggers","()Ljava/util/Collection;","invokevirtual",23);}
case 23:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5418(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardTraitChanges","remove","Ljava/util/function/Predicate;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?18:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardTraitChanges","remove","Ljava/util/function/Predicate;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",17);}
case 17:{f.StackOp("pop");f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardTraitChanges","getReplacements","()Ljava/util/Collection;","invokevirtual",23);}
case 23:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5419(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardTraitChanges","remove","Ljava/util/function/Predicate;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?18:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardTraitChanges","remove","Ljava/util/function/Predicate;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",17);}
case 17:{f.StackOp("pop");f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardTraitChanges","getStaticAbilities","()Ljava/util/Collection;","invokevirtual",23);}
case 23:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5420(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardTraitChanges:5420:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/CardTraitChanges;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5421(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardTraitChanges:5421:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/CardTraitChanges;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5422(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/CardTraitChanges:5422:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/CardTraitChanges;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5423(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardTraitChanges","abilities","Ljava/util/Collection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5424(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardTraitChanges","triggers","Ljava/util/Collection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5425(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardTraitChanges","replacements","Ljava/util/Collection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5426(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardTraitChanges","staticAbilities","Ljava/util/Collection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5427(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardTraitChanges","remove","Ljava/util/function/Predicate;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5428(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/CardTraitChanges","copy","(Lforge/game/card/Card;Z)Lforge/game/card/CardTraitChanges;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5429(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/staticability/StaticAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/staticability/StaticAbility;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5430(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","copy","(Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5431(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/trigger/Trigger","copy","(Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5432(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
