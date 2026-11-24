// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C813{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbility","forge/game/CardTraitBase",new string[]{"forge/game/IIdentifiable","java/lang/Cloneable","java/lang/Comparable"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("maxId","I",true,JValue.Default("I"),null));
c.Add(new JField("id","I",false,JValue.Default("I"),null));
c.Add(new JField("validHostZones","Ljava/util/EnumSet;",false,JValue.Default("Ljava/util/EnumSet;"),null));
c.Add(new JField("modes","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("layers","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("ignoreEffectCards","Lforge/game/card/CardCollectionView;",false,JValue.Default("Lforge/game/card/CardCollectionView;"),null));
c.Add(new JField("ignoreEffectPlayers","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("mayPlayTurn","I",false,JValue.Default("I"),null));
c.Add(new JField("payingTrigSA","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JField("view","Lforge/game/staticability/StaticAbilityView;",false,JValue.Default("Lforge/game/staticability/StaticAbilityView;"),null));
c.Add(new JMethod(9799,"forge/game/staticability/StaticAbility","nextId","()I",10,0,2,new JHandler[]{},M9799));
c.Add(new JMethod(9800,"forge/game/staticability/StaticAbility","getId","()I",17,1,1,new JHandler[]{},M9800));
c.Add(new JMethod(9801,"forge/game/staticability/StaticAbility","hashCode","()I",1,1,4,new JHandler[]{},M9801));
c.Add(new JMethod(9802,"forge/game/staticability/StaticAbility","equals","(Ljava/lang/Object;)Z",1,2,2,new JHandler[]{},M9802));
c.Add(new JMethod(9803,"forge/game/staticability/StaticAbility","getActiveZone","()Ljava/util/Set;",1,1,1,new JHandler[]{},M9803));
c.Add(new JMethod(9804,"forge/game/staticability/StaticAbility","setActiveZone","(Ljava/util/EnumSet;)V",1,2,2,new JHandler[]{},M9804));
c.Add(new JMethod(9805,"forge/game/staticability/StaticAbility","getMode","()Ljava/util/Set;",1,1,1,new JHandler[]{},M9805));
c.Add(new JMethod(9806,"forge/game/staticability/StaticAbility","setMode","(Ljava/util/Set;)V",1,2,2,new JHandler[]{},M9806));
c.Add(new JMethod(9807,"forge/game/staticability/StaticAbility","getPayingTrigSA","()Lforge/game/spellability/SpellAbility;",1,1,4,new JHandler[]{},M9807));
c.Add(new JMethod(9808,"forge/game/staticability/StaticAbility","parseParams","(Ljava/lang/String;Lforge/game/card/Card;)Ljava/util/Map;",10,2,4,new JHandler[]{},M9808));
c.Add(new JMethod(9809,"forge/game/staticability/StaticAbility","generateLayer","()Ljava/util/Set;",2,2,2,new JHandler[]{},M9809));
c.Add(new JMethod(9810,"forge/game/staticability/StaticAbility","isCharacteristicDefining","()Z",1,1,2,new JHandler[]{},M9810));
c.Add(new JMethod(9811,"forge/game/staticability/StaticAbility","toString","()Ljava/lang/String;",17,4,4,new JHandler[]{},M9811));
c.Add(new JMethod(9812,"forge/game/staticability/StaticAbility","<init>","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;)V",1,4,4,new JHandler[]{},M9812));
c.Add(new JMethod(9813,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;",9,5,5,new JHandler[]{},M9813));
c.Add(new JMethod(9814,"forge/game/staticability/StaticAbility","<init>","(Ljava/util/Map;Lforge/game/card/Card;Lforge/game/card/CardState;)V",2,4,3,new JHandler[]{},M9814));
c.Add(new JMethod(9815,"forge/game/staticability/StaticAbility","getView","()Lforge/game/staticability/StaticAbilityView;",1,1,4,new JHandler[]{},M9815));
c.Add(new JMethod(9816,"forge/game/staticability/StaticAbility","applyContinuousAbilityBefore","(Lforge/game/staticability/StaticAbilityLayer;Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;",17,3,3,new JHandler[]{},M9816));
c.Add(new JMethod(9817,"forge/game/staticability/StaticAbility","applyContinuousAbility","(Lforge/game/staticability/StaticAbilityLayer;Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;",17,3,3,new JHandler[]{},M9817));
c.Add(new JMethod(9818,"forge/game/staticability/StaticAbility","shouldApplyContinuousAbility","(Lforge/game/staticability/StaticAbilityLayer;Z)Z",2,3,2,new JHandler[]{},M9818));
c.Add(new JMethod(9819,"forge/game/staticability/StaticAbility","getAttackCost","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/util/List;)Lforge/game/cost/Cost;",17,4,3,new JHandler[]{},M9819));
c.Add(new JMethod(9820,"forge/game/staticability/StaticAbility","hasAttackCost","(Lforge/game/card/Card;Ljava/lang/Class;)Z",17,3,3,new JHandler[]{},M9820));
c.Add(new JMethod(9821,"forge/game/staticability/StaticAbility","getBlockCost","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/cost/Cost;",17,3,3,new JHandler[]{},M9821));
c.Add(new JMethod(9822,"forge/game/staticability/StaticAbility","checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z",17,2,2,new JHandler[]{},M9822));
c.Add(new JMethod(9823,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z",17,2,2,new JHandler[]{},M9823));
c.Add(new JMethod(9824,"forge/game/staticability/StaticAbility","zonesCheck","()Z",17,2,2,new JHandler[]{},M9824));
c.Add(new JMethod(9825,"forge/game/staticability/StaticAbility","checkConditions","()Z",17,12,5,new JHandler[]{},M9825));
c.Add(new JMethod(9826,"forge/game/staticability/StaticAbility","getIgnoreEffectCards","()Lforge/game/card/CardCollectionView;",1,1,1,new JHandler[]{},M9826));
c.Add(new JMethod(9827,"forge/game/staticability/StaticAbility","setIgnoreEffectCards","(Lforge/game/card/CardCollectionView;)V",1,2,2,new JHandler[]{},M9827));
c.Add(new JMethod(9828,"forge/game/staticability/StaticAbility","getIgnoreEffectPlayers","()Ljava/util/List;",1,1,1,new JHandler[]{},M9828));
c.Add(new JMethod(9829,"forge/game/staticability/StaticAbility","addIgnoreEffectPlayers","(Lforge/game/player/Player;)V",1,2,2,new JHandler[]{},M9829));
c.Add(new JMethod(9830,"forge/game/staticability/StaticAbility","clearIgnoreEffects","()V",1,1,3,new JHandler[]{},M9830));
c.Add(new JMethod(9831,"forge/game/staticability/StaticAbility","getLayers","()Ljava/util/Set;",1,1,1,new JHandler[]{},M9831));
c.Add(new JMethod(9832,"forge/game/staticability/StaticAbility","getMayPlayTurn","()I",1,1,3,new JHandler[]{},M9832));
c.Add(new JMethod(9833,"forge/game/staticability/StaticAbility","incMayPlayTurn","()V",1,1,3,new JHandler[]{},M9833));
c.Add(new JMethod(9834,"forge/game/staticability/StaticAbility","resetMayPlayTurn","()V",1,1,2,new JHandler[]{},M9834));
c.Add(new JMethod(9835,"forge/game/staticability/StaticAbility","compareTo","(Lforge/game/staticability/StaticAbility;)I",1,2,3,new JHandler[]{},M9835));
c.Add(new JMethod(9836,"forge/game/staticability/StaticAbility","getTimestamp","()J",1,1,2,new JHandler[]{},M9836));
c.Add(new JMethod(9837,"forge/game/staticability/StaticAbility","setHostCard","(Lforge/game/card/Card;)V",1,2,2,new JHandler[]{},M9837));
c.Add(new JMethod(9838,"forge/game/staticability/StaticAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/staticability/StaticAbility;",17,3,4,new JHandler[]{},M9838));
c.Add(new JMethod(9839,"forge/game/staticability/StaticAbility","copy","(Lforge/game/card/Card;ZZ)Lforge/game/staticability/StaticAbility;",1,6,4,new JHandler[]{new JHandler(3,114,117,"java/lang/CloneNotSupportedException")},M9839));
c.Add(new JMethod(9840,"forge/game/staticability/StaticAbility","compareTo","(Ljava/lang/Object;)I",4161,2,2,new JHandler[]{},M9840));
c.Add(new JMethod(9841,"forge/game/staticability/StaticAbility","lambda$getMayPlayTurn$0","(Lforge/game/spellability/SpellAbility;)Z",4098,2,2,new JHandler[]{},M9841));
c.Add(new JMethod(9842,"forge/game/staticability/StaticAbility","<clinit>","()V",8,0,1,new JHandler[]{},M9842));
}

internal static JStep M9799(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbility","maxId","I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbility","maxId","I"));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbility","maxId","I"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbility","maxId","I",f.Pop());f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9800(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","id","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9801(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(2));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.ClassObject("forge/game/staticability/StaticAbility")));f.Pc=8;continue;}
case 8:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",15);}
case 15:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",18);}
case 18:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Objects","hash","([Ljava/lang/Object;)I","invokestatic",22);}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9802(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/staticability/StaticAbility")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?25:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","id","I"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","id","I"));f.Pc=18;continue;}
case 18:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?25:21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Pc=26;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9803(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","validHostZones","Ljava/util/EnumSet;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9804(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","validHostZones","Ljava/util/EnumSet;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9805(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","modes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9806(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","modes","Ljava/util/Set;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9807(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","payingTrigSA","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?45:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("Trigger")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?45:16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Trigger")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/staticability/StaticAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",34);}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","payingTrigSA","Lforge/game/spellability/SpellAbility;",value);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","payingTrigSA","Lforge/game/spellability/SpellAbility;"));f.Pc=41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",45);}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","payingTrigSA","Lforge/game/spellability/SpellAbility;"));f.Pc=49;continue;}
case 49:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9808(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int>0?25:7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbility:9808:16:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",21);}
case 21:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",24);}
case 24:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{if(!rt.StaticReady(f,"forge/util/FileSection","DOLLAR_SIGN_KV_SEPARATOR","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/FileSection","DOLLAR_SIGN_KV_SEPARATOR","Ljava/util/regex/Pattern;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/util/FileSection","parseToMap","(Ljava/lang/String;Ljava/util/regex/Pattern;)Ljava/util/Map;","invokestatic",32);}
case 32:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9809(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","Continuous","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","Continuous","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?16:10;continue;}
case 10:{f.Push(JValue.R(rt.ClassObject("forge/game/staticability/StaticAbilityLayer")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",15);}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Push(JValue.R(rt.ClassObject("forge/game/staticability/StaticAbilityLayer")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",21);}
case 21:{f.Locals[1]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("GainControl")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?41:31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CONTROL","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CONTROL","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",40);}
case 40:{f.StackOp("pop");f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("ChangeColorWordsTo")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int!=0?95:50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("GainTextOf")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int!=0?95:59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("AddNames")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int!=0?95:68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("SetName")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int!=0?95:77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("Incorporate")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",83);}
case 83:{f.Pc=f.Pop().Int!=0?95:86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("ManaCost")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int==0?105:95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TEXT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",104);}
case 104:{f.StackOp("pop");f.Pc=105;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("AddType")));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",111);}
case 111:{f.Pc=f.Pop().Int!=0?195:114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String("RemoveType")));f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int!=0?195:123;continue;}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("AddAllCreatureTypes")));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",129);}
case 129:{f.Pc=f.Pop().Int!=0?195:132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{f.Push(JValue.R(rt.String("RemoveCardTypes")));f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",138);}
case 138:{f.Pc=f.Pop().Int!=0?195:141;continue;}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(JValue.R(rt.String("RemoveSubTypes")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",147);}
case 147:{f.Pc=f.Pop().Int!=0?195:150;continue;}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String("RemoveSuperTypes")));f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",156);}
case 156:{f.Pc=f.Pop().Int!=0?195:159;continue;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("RemoveLandTypes")));f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",165);}
case 165:{f.Pc=f.Pop().Int!=0?195:168;continue;}
case 168:{f.Push(f.Locals[0]);f.Pc=169;continue;}
case 169:{f.Push(JValue.R(rt.String("RemoveCreatureTypes")));f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",174);}
case 174:{f.Pc=f.Pop().Int!=0?195:177;continue;}
case 177:{f.Push(f.Locals[0]);f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("RemoveArtifactTypes")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",183);}
case 183:{f.Pc=f.Pop().Int!=0?195:186;continue;}
case 186:{f.Push(f.Locals[0]);f.Pc=187;continue;}
case 187:{f.Push(JValue.R(rt.String("RemoveEnchantmentTypes")));f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",192);}
case 192:{f.Pc=f.Pop().Int==0?205:195;continue;}
case 195:{f.Push(f.Locals[1]);f.Pc=196;continue;}
case 196:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","TYPE","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",204);}
case 204:{f.StackOp("pop");f.Pc=205;continue;}
case 205:{f.Push(f.Locals[0]);f.Pc=206;continue;}
case 206:{f.Push(JValue.R(rt.String("AddColor")));f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",211);}
case 211:{f.Pc=f.Pop().Int!=0?232:214;continue;}
case 214:{f.Push(f.Locals[0]);f.Pc=215;continue;}
case 215:{f.Push(JValue.R(rt.String("RemoveColor")));f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",220);}
case 220:{f.Pc=f.Pop().Int!=0?232:223;continue;}
case 223:{f.Push(f.Locals[0]);f.Pc=224;continue;}
case 224:{f.Push(JValue.R(rt.String("SetColor")));f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",229);}
case 229:{f.Pc=f.Pop().Int==0?242:232;continue;}
case 232:{f.Push(f.Locals[1]);f.Pc=233;continue;}
case 233:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","COLOR","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","COLOR","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",241);}
case 241:{f.StackOp("pop");f.Pc=242;continue;}
case 242:{f.Push(f.Locals[0]);f.Pc=243;continue;}
case 243:{f.Push(JValue.R(rt.String("RemoveAllAbilities")));f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",248);}
case 248:{f.Pc=f.Pop().Int!=0?386:251;continue;}
case 251:{f.Push(f.Locals[0]);f.Pc=252;continue;}
case 252:{f.Push(JValue.R(rt.String("RemoveNonManaAbilities")));f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",257);}
case 257:{f.Pc=f.Pop().Int!=0?386:260;continue;}
case 260:{f.Push(f.Locals[0]);f.Pc=261;continue;}
case 261:{f.Push(JValue.R(rt.String("GainsAbilitiesOf")));f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",266);}
case 266:{f.Pc=f.Pop().Int!=0?386:269;continue;}
case 269:{f.Push(f.Locals[0]);f.Pc=270;continue;}
case 270:{f.Push(JValue.R(rt.String("GainsAbilitiesOfDefined")));f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",275);}
case 275:{f.Pc=f.Pop().Int!=0?386:278;continue;}
case 278:{f.Push(f.Locals[0]);f.Pc=279;continue;}
case 279:{f.Push(JValue.R(rt.String("GainsTriggerAbsOf")));f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",284);}
case 284:{f.Pc=f.Pop().Int!=0?386:287;continue;}
case 287:{f.Push(f.Locals[0]);f.Pc=288;continue;}
case 288:{f.Push(JValue.R(rt.String("GainsStickerAbilitiesOf")));f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",293);}
case 293:{f.Pc=f.Pop().Int!=0?386:296;continue;}
case 296:{f.Push(f.Locals[0]);f.Pc=297;continue;}
case 297:{f.Push(JValue.R(rt.String("GainsStickerAbilitiesOfDefined")));f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",302);}
case 302:{f.Pc=f.Pop().Int!=0?386:305;continue;}
case 305:{f.Push(f.Locals[0]);f.Pc=306;continue;}
case 306:{f.Push(JValue.R(rt.String("AddKeyword")));f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",311);}
case 311:{f.Pc=f.Pop().Int!=0?386:314;continue;}
case 314:{f.Push(f.Locals[0]);f.Pc=315;continue;}
case 315:{f.Push(JValue.R(rt.String("AddAbility")));f.Pc=317;continue;}
case 317:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",320);}
case 320:{f.Pc=f.Pop().Int!=0?386:323;continue;}
case 323:{f.Push(f.Locals[0]);f.Pc=324;continue;}
case 324:{f.Push(JValue.R(rt.String("AddTrigger")));f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",329);}
case 329:{f.Pc=f.Pop().Int!=0?386:332;continue;}
case 332:{f.Push(f.Locals[0]);f.Pc=333;continue;}
case 333:{f.Push(JValue.R(rt.String("AddReplacementEffect")));f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",338);}
case 338:{f.Pc=f.Pop().Int!=0?386:341;continue;}
case 341:{f.Push(f.Locals[0]);f.Pc=342;continue;}
case 342:{f.Push(JValue.R(rt.String("AddStaticAbility")));f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",347);}
case 347:{f.Pc=f.Pop().Int!=0?386:350;continue;}
case 350:{f.Push(f.Locals[0]);f.Pc=351;continue;}
case 351:{f.Push(JValue.R(rt.String("AddSVar")));f.Pc=353;continue;}
case 353:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",356);}
case 356:{f.Pc=f.Pop().Int!=0?386:359;continue;}
case 359:{f.Push(f.Locals[0]);f.Pc=360;continue;}
case 360:{f.Push(JValue.R(rt.String("CantHaveKeyword")));f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",365);}
case 365:{f.Pc=f.Pop().Int!=0?386:368;continue;}
case 368:{f.Push(f.Locals[0]);f.Pc=369;continue;}
case 369:{f.Push(JValue.R(rt.String("ShareRememberedKeywords")));f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",374);}
case 374:{f.Pc=f.Pop().Int!=0?386:377;continue;}
case 377:{f.Push(f.Locals[0]);f.Pc=378;continue;}
case 378:{f.Push(JValue.R(rt.String("RemoveKeyword")));f.Pc=380;continue;}
case 380:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",383);}
case 383:{f.Pc=f.Pop().Int==0?396:386;continue;}
case 386:{f.Push(f.Locals[1]);f.Pc=387;continue;}
case 387:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","ABILITIES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=390;continue;}
case 390:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",395);}
case 395:{f.StackOp("pop");f.Pc=396;continue;}
case 396:{f.Push(f.Locals[0]);f.Pc=397;continue;}
case 397:{f.Push(JValue.R(rt.String("SetPower")));f.Pc=399;continue;}
case 399:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",402);}
case 402:{f.Pc=f.Pop().Int!=0?414:405;continue;}
case 405:{f.Push(f.Locals[0]);f.Pc=406;continue;}
case 406:{f.Push(JValue.R(rt.String("SetToughness")));f.Pc=408;continue;}
case 408:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",411);}
case 411:{f.Pc=f.Pop().Int==0?437:414;continue;}
case 414:{f.Push(f.Locals[1]);f.Pc=415;continue;}
case 415:{f.Push(f.Locals[0]);f.Pc=416;continue;}
case 416:{return rt.Call(f,"forge/game/staticability/StaticAbility","isCharacteristicDefining","()Z","invokevirtual",419);}
case 419:{f.Pc=f.Pop().Int==0?428:422;continue;}
case 422:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","CHARACTERISTIC","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=425;continue;}
case 425:{f.Pc=431;continue;}
case 428:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","SETPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=431;continue;}
case 431:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",436);}
case 436:{f.StackOp("pop");f.Pc=437;continue;}
case 437:{f.Push(f.Locals[0]);f.Pc=438;continue;}
case 438:{f.Push(JValue.R(rt.String("AddPower")));f.Pc=440;continue;}
case 440:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",443);}
case 443:{f.Pc=f.Pop().Int!=0?455:446;continue;}
case 446:{f.Push(f.Locals[0]);f.Pc=447;continue;}
case 447:{f.Push(JValue.R(rt.String("AddToughness")));f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",452);}
case 452:{f.Pc=f.Pop().Int==0?465:455;continue;}
case 455:{f.Push(f.Locals[1]);f.Pc=456;continue;}
case 456:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","MODIFYPT","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=459;continue;}
case 459:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",464);}
case 464:{f.StackOp("pop");f.Pc=465;continue;}
case 465:{f.Push(f.Locals[0]);f.Pc=466;continue;}
case 466:{f.Push(JValue.R(rt.String("AddHiddenKeyword")));f.Pc=468;continue;}
case 468:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",471);}
case 471:{f.Pc=f.Pop().Int!=0?573:474;continue;}
case 474:{f.Push(f.Locals[0]);f.Pc=475;continue;}
case 475:{f.Push(JValue.R(rt.String("MayPlay")));f.Pc=477;continue;}
case 477:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",480);}
case 480:{f.Pc=f.Pop().Int!=0?573:483;continue;}
case 483:{f.Push(f.Locals[0]);f.Pc=484;continue;}
case 484:{f.Push(JValue.R(rt.String("IgnoreEffectCost")));f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",489);}
case 489:{f.Pc=f.Pop().Int!=0?573:492;continue;}
case 492:{f.Push(f.Locals[0]);f.Pc=493;continue;}
case 493:{f.Push(JValue.R(rt.String("Goad")));f.Pc=495;continue;}
case 495:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",498);}
case 498:{f.Pc=f.Pop().Int!=0?573:501;continue;}
case 501:{f.Push(f.Locals[0]);f.Pc=502;continue;}
case 502:{f.Push(JValue.R(rt.String("CanBlockAny")));f.Pc=504;continue;}
case 504:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",507);}
case 507:{f.Pc=f.Pop().Int!=0?573:510;continue;}
case 510:{f.Push(f.Locals[0]);f.Pc=511;continue;}
case 511:{f.Push(JValue.R(rt.String("CanBlockAmount")));f.Pc=513;continue;}
case 513:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",516);}
case 516:{f.Pc=f.Pop().Int!=0?573:519;continue;}
case 519:{f.Push(f.Locals[0]);f.Pc=520;continue;}
case 520:{f.Push(JValue.R(rt.String("AdjustLandPlays")));f.Pc=522;continue;}
case 522:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",525);}
case 525:{f.Pc=f.Pop().Int!=0?573:528;continue;}
case 528:{f.Push(f.Locals[0]);f.Pc=529;continue;}
case 529:{f.Push(JValue.R(rt.String("ControlVote")));f.Pc=531;continue;}
case 531:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",534);}
case 534:{f.Pc=f.Pop().Int!=0?573:537;continue;}
case 537:{f.Push(f.Locals[0]);f.Pc=538;continue;}
case 538:{f.Push(JValue.R(rt.String("AdditionalVote")));f.Pc=540;continue;}
case 540:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",543);}
case 543:{f.Pc=f.Pop().Int!=0?573:546;continue;}
case 546:{f.Push(f.Locals[0]);f.Pc=547;continue;}
case 547:{f.Push(JValue.R(rt.String("AdditionalOptionalVote")));f.Pc=549;continue;}
case 549:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",552);}
case 552:{f.Pc=f.Pop().Int!=0?573:555;continue;}
case 555:{f.Push(f.Locals[0]);f.Pc=556;continue;}
case 556:{f.Push(JValue.R(rt.String("DeclaresAttackers")));f.Pc=558;continue;}
case 558:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",561);}
case 561:{f.Pc=f.Pop().Int!=0?573:564;continue;}
case 564:{f.Push(f.Locals[0]);f.Pc=565;continue;}
case 565:{f.Push(JValue.R(rt.String("DeclaresBlockers")));f.Pc=567;continue;}
case 567:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",570);}
case 570:{f.Pc=f.Pop().Int==0?583:573;continue;}
case 573:{f.Push(f.Locals[1]);f.Pc=574;continue;}
case 574:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=577;continue;}
case 577:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",582);}
case 582:{f.StackOp("pop");f.Pc=583;continue;}
case 583:{f.Push(f.Locals[1]);f.Pc=584;continue;}
case 584:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",589);}
case 589:{f.Pc=f.Pop().Int==0?602:592;continue;}
case 592:{f.Push(f.Locals[1]);f.Pc=593;continue;}
case 593:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityLayer","RULES","Lforge/game/staticability/StaticAbilityLayer;"));f.Pc=596;continue;}
case 596:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",601);}
case 601:{f.StackOp("pop");f.Pc=602;continue;}
case 602:{f.Push(f.Locals[1]);f.Pc=603;continue;}
case 603:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9810(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("CharacteristicDefining")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9811(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Description")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?68:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/staticability/StaticAbility","isSuppressed","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int!=0?68:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostName","(Lforge/game/CardTraitBase;)Lforge/util/ITranslatable;","invokevirtual",22);}
case 22:{f.Locals[1]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Description")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",30);}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/util/CardTranslation","translateSingleDescriptionText","(Ljava/lang/String;Lforge/util/ITranslatable;)Ljava/lang/String;","invokestatic",34);}
case 34:{f.Locals[2]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/util/ITranslatable","getTranslatedName","()Ljava/lang/String;","invokeinterface",41);}
case 41:{f.Locals[3]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",50);}
case 50:{f.Locals[2]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("NICKNAME")));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",58);}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/util/Lang","getNickName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",62);}
case 62:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",65);}
case 65:{f.Locals[2]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{return JStep.Return(f.Pop());}
case 68:{f.Push(JValue.R(rt.String("")));f.Pc=71;continue;}
case 71:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9812(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/staticability/StaticAbility","parseParams","(Ljava/lang/String;Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",6);}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/staticability/StaticAbility","<init>","(Ljava/util/Map;Lforge/game/card/Card;Lforge/game/card/CardState;)V","invokespecial",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9813(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbility"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbility")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/staticability/StaticAbility","<init>","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;)V","invokespecial",10);}
case 10:{f.Locals[4]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/staticability/StaticAbility","setIntrinsic","(Z)V","invokevirtual",18);}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9814(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/CardTraitBase","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","ignoreEffectCards","Lforge/game/card/CardCollectionView;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","ignoreEffectPlayers","Ljava/util/List;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","mayPlayTurn","I",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(null));f.Pc=29;continue;}
case 29:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","view","Lforge/game/staticability/StaticAbilityView;",value);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/staticability/StaticAbility","nextId","()I","invokestatic",36);}
case 36:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","id","I",value);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","originalMapParams","Ljava/util/Map;"));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",49);}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","mapParams","Ljava/util/Map;"));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",59);}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","hostCard","Lforge/game/card/Card;",value);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/staticability/StaticAbility","setCardState","(Lforge/game/card/CardState;)V","invokevirtual",69);}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("EffectZone")));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int==0?96:79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(JValue.R(rt.String("EffectZone")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",87);}
case 87:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",90);}
case 90:{return rt.Call(f,"java/util/EnumSet","copyOf","(Ljava/util/Collection;)Ljava/util/EnumSet;","invokestatic",93);}
case 93:{return rt.Call(f,"forge/game/staticability/StaticAbility","setActiveZone","(Ljava/util/EnumSet;)V","invokevirtual",96);}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(JValue.R(rt.String("Mode")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",103);}
case 103:{f.Pc=f.Pop().Int==0?120:106;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("Mode")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",114);}
case 114:{return rt.Call(f,"forge/game/staticability/StaticAbilityMode","setValueOf","(Ljava/lang/String;)Ljava/util/Set;","invokestatic",117);}
case 117:{return rt.Call(f,"forge/game/staticability/StaticAbility","setMode","(Ljava/util/Set;)V","invokevirtual",120);}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/staticability/StaticAbility","generateLayer","()Ljava/util/Set;","invokevirtual",125);}
case 125:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","layers","Ljava/util/Set;",value);f.Pc=128;continue;}
case 128:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9815(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","view","Lforge/game/staticability/StaticAbilityView;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?22:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"forge/game/staticability/StaticAbilityView"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/staticability/StaticAbilityView")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/staticability/StaticAbilityView","<init>","(Lforge/game/staticability/StaticAbility;)V","invokespecial",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","view","Lforge/game/staticability/StaticAbilityView;",value);f.Pc=19;continue;}
case 19:{f.Pc=38;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","view","Lforge/game/staticability/StaticAbilityView;"));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/staticability/StaticAbilityView","updateHostCard","(Lforge/game/staticability/StaticAbility;)V","invokevirtual",30);}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","view","Lforge/game/staticability/StaticAbilityView;"));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/staticability/StaticAbilityView","updateDescription","(Lforge/game/staticability/StaticAbility;)V","invokevirtual",38);}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","view","Lforge/game/staticability/StaticAbilityView;"));f.Pc=42;continue;}
case 42:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9816(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/staticability/StaticAbility","shouldApplyContinuousAbility","(Lforge/game/staticability/StaticAbilityLayer;Z)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int!=0?11:9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/staticability/StaticAbilityContinuous","applyContinuousAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/staticability/StaticAbilityLayer;Lforge/game/card/CardCollectionView;)Lforge/game/card/CardCollectionView;","invokestatic",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9817(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/staticability/StaticAbility","shouldApplyContinuousAbility","(Lforge/game/staticability/StaticAbilityLayer;Z)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int!=0?11:9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/staticability/StaticAbilityContinuous","applyContinuousAbility","(Lforge/game/staticability/StaticAbility;Lforge/game/card/CardCollectionView;Lforge/game/staticability/StaticAbilityLayer;)Lforge/game/card/CardCollectionView;","invokestatic",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9818(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","layers","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?63:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","Continuous","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","Continuous","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?63:23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Int!=0?59:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",34);}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/util/collect/FCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Int!=0?59:43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/game/card/Card","getHiddenStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",50);}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/util/collect/FCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",56);}
case 56:{f.Pc=f.Pop().Int==0?63:59;continue;}
case 59:{f.Push(JValue.I(1));f.Pc=60;continue;}
case 60:{f.Pc=64;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9819(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantAttackUnless","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantAttackUnless","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?32:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","OptionalAttackCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","OptionalAttackCost","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?30:20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int!=0?32:30;continue;}
case 30:{f.Push(JValue.R(null));f.Pc=31;continue;}
case 31:{return JStep.Return(f.Pop());}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","()Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int!=0?41:39;continue;}
case 39:{f.Push(JValue.R(null));f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantAttackBlock","getAttackCost","(Lforge/game/staticability/StaticAbility;Lforge/game/card/Card;Lforge/game/GameEntity;)Lforge/game/cost/Cost;","invokestatic",47);}
case 47:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9820(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","OptionalAttackCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","OptionalAttackCost","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(null));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantAttackBlock","getAttackCost","(Lforge/game/staticability/StaticAbility;Lforge/game/card/Card;Lforge/game/GameEntity;)Lforge/game/cost/Cost;","invokestatic",18);}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/cost/Cost","hasSpecificCostType","(Ljava/lang/Class;)Z","invokevirtual",22);}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9821(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","CantBlockUnless","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","CantBlockUnless","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?12:10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantAttackBlock","getBlockCost","(Lforge/game/staticability/StaticAbility;Lforge/game/card/Card;Lforge/game/GameEntity;)Lforge/game/cost/Cost;","invokestatic",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9822(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","modes","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9823(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?19:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","()Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?19:15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{f.Pc=20;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9824(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/staticability/StaticAbility","isSuppressed","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?21:19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/staticability/StaticAbility","isCharacteristicDefining","()Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int!=0?85:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","validHostZones","Ljava/util/EnumSet;"));f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Reference==null?73:35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",39);}
case 39:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",42);}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",46);}
case 46:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",49);}
case 49:{f.Locals[1]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Pc=f.Pop().Reference==null?68:54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","validHostZones","Ljava/util/EnumSet;"));f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",62);}
case 62:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int!=0?70:68;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 70:{f.Pc=85;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",77);}
case 77:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int!=0?85:83;continue;}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 85:{f.Push(JValue.I(1));f.Pc=86;continue;}
case 86:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9825(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",12);}
case 12:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",20);}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/staticability/StaticAbility","zonesCheck","()Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int!=0?30:28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("Condition")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Locals[4]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(JValue.R(null));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?346:45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("Threshold")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int==0?65:56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/player/Player","hasThreshold","()Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int!=0?65:63;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 65:{f.Push(f.Locals[4]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("Hellbent")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int==0?85:76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/player/Player","hasHellbent","()Z","invokevirtual",80);}
case 80:{f.Pc=f.Pop().Int!=0?85:83;continue;}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 85:{f.Push(f.Locals[4]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String("Metalcraft")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int==0?105:96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/player/Player","hasMetalcraft","()Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int!=0?105:103;continue;}
case 103:{f.Push(JValue.I(0));f.Pc=104;continue;}
case 104:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 105:{f.Push(f.Locals[4]);f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String("Delirium")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int==0?125:116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/player/Player","hasDelirium","()Z","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int!=0?125:123;continue;}
case 123:{f.Push(JValue.I(0));f.Pc=124;continue;}
case 124:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 125:{f.Push(f.Locals[4]);f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String("Ferocious")));f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",133);}
case 133:{f.Pc=f.Pop().Int==0?145:136;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/player/Player","hasFerocious","()Z","invokevirtual",140);}
case 140:{f.Pc=f.Pop().Int!=0?145:143;continue;}
case 143:{f.Push(JValue.I(0));f.Pc=144;continue;}
case 144:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 145:{f.Push(f.Locals[4]);f.Pc=147;continue;}
case 147:{f.Push(JValue.R(rt.String("Blessing")));f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",153);}
case 153:{f.Pc=f.Pop().Int==0?165:156;continue;}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/player/Player","hasBlessing","()Z","invokevirtual",160);}
case 160:{f.Pc=f.Pop().Int!=0?165:163;continue;}
case 163:{f.Push(JValue.I(0));f.Pc=164;continue;}
case 164:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 165:{f.Push(f.Locals[4]);f.Pc=167;continue;}
case 167:{f.Push(JValue.R(rt.String("EnduringStory")));f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",173);}
case 173:{f.Pc=f.Pop().Int==0?185:176;continue;}
case 176:{f.Push(f.Locals[1]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/player/Player","hasEnduringStory","()Z","invokevirtual",180);}
case 180:{f.Pc=f.Pop().Int!=0?185:183;continue;}
case 183:{f.Push(JValue.I(0));f.Pc=184;continue;}
case 184:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 185:{f.Push(f.Locals[4]);f.Pc=187;continue;}
case 187:{f.Push(JValue.R(rt.String("Monarch")));f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",193);}
case 193:{f.Push(f.Locals[1]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/game/player/Player","isMonarch","()Z","invokevirtual",197);}
case 197:{f.Pc=f.Pop().Int!=0?204:200;continue;}
case 200:{f.Push(JValue.I(1));f.Pc=201;continue;}
case 201:{f.Pc=205;continue;}
case 204:{f.Push(JValue.I(0));f.Pc=205;continue;}
case 205:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=206;continue;}
case 206:{f.Pc=f.Pop().Int==0?211:209;continue;}
case 209:{f.Push(JValue.I(0));f.Pc=210;continue;}
case 210:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 211:{f.Push(f.Locals[4]);f.Pc=213;continue;}
case 213:{f.Push(JValue.R(rt.String("Night")));f.Pc=216;continue;}
case 216:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",219);}
case 219:{f.Push(f.Locals[2]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/Game","isNight","()Z","invokevirtual",223);}
case 223:{f.Pc=f.Pop().Int!=0?230:226;continue;}
case 226:{f.Push(JValue.I(1));f.Pc=227;continue;}
case 227:{f.Pc=231;continue;}
case 230:{f.Push(JValue.I(0));f.Pc=231;continue;}
case 231:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=232;continue;}
case 232:{f.Pc=f.Pop().Int==0?237:235;continue;}
case 235:{f.Push(JValue.I(0));f.Pc=236;continue;}
case 236:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 237:{f.Push(f.Locals[4]);f.Pc=239;continue;}
case 239:{f.Push(JValue.R(rt.String("MaxSpeed")));f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",245);}
case 245:{f.Pc=f.Pop().Int==0?257:248;continue;}
case 248:{f.Push(f.Locals[1]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/player/Player","maxSpeed","()Z","invokevirtual",252);}
case 252:{f.Pc=f.Pop().Int!=0?257:255;continue;}
case 255:{f.Push(JValue.I(0));f.Pc=256;continue;}
case 256:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 257:{f.Push(f.Locals[4]);f.Pc=259;continue;}
case 259:{f.Push(JValue.R(rt.String("PlayerTurn")));f.Pc=262;continue;}
case 262:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",265);}
case 265:{f.Pc=f.Pop().Int==0?278:268;continue;}
case 268:{f.Push(f.Locals[3]);f.Pc=269;continue;}
case 269:{f.Push(f.Locals[1]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",273);}
case 273:{f.Pc=f.Pop().Int!=0?346:276;continue;}
case 276:{f.Push(JValue.I(0));f.Pc=277;continue;}
case 277:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 278:{f.Push(f.Locals[4]);f.Pc=280;continue;}
case 280:{f.Push(JValue.R(rt.String("NotPlayerTurn")));f.Pc=283;continue;}
case 283:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",286);}
case 286:{f.Pc=f.Pop().Int==0?299:289;continue;}
case 289:{f.Push(f.Locals[3]);f.Pc=290;continue;}
case 290:{f.Push(f.Locals[1]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",294);}
case 294:{f.Pc=f.Pop().Int==0?346:297;continue;}
case 297:{f.Push(JValue.I(0));f.Pc=298;continue;}
case 298:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 299:{f.Push(f.Locals[4]);f.Pc=301;continue;}
case 301:{f.Push(JValue.R(rt.String("ExtraTurn")));f.Pc=304;continue;}
case 304:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",307);}
case 307:{f.Pc=f.Pop().Int==0?325:310;continue;}
case 310:{f.Push(f.Locals[2]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",314);}
case 314:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",317);}
case 317:{return rt.Call(f,"forge/game/player/Player","isExtraTurn","()Z","invokevirtual",320);}
case 320:{f.Pc=f.Pop().Int!=0?346:323;continue;}
case 323:{f.Push(JValue.I(0));f.Pc=324;continue;}
case 324:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 325:{f.Push(f.Locals[4]);f.Pc=327;continue;}
case 327:{f.Push(JValue.R(rt.String("FatefulHour")));f.Pc=330;continue;}
case 330:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",333);}
case 333:{f.Pc=f.Pop().Int==0?346:336;continue;}
case 336:{f.Push(f.Locals[1]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",340);}
case 340:{f.Push(JValue.I(5));f.Pc=341;continue;}
case 341:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?346:344;continue;}
case 344:{f.Push(JValue.I(0));f.Pc=345;continue;}
case 345:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 346:{f.Push(f.Locals[0]);f.Pc=347;continue;}
case 347:{f.Push(JValue.R(rt.String("Phases")));f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",353);}
case 353:{f.Pc=f.Pop().Int==0?380:356;continue;}
case 356:{f.Push(f.Locals[0]);f.Pc=357;continue;}
case 357:{f.Push(JValue.R(rt.String("Phases")));f.Pc=360;continue;}
case 360:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",363);}
case 363:{return rt.Call(f,"forge/game/phase/PhaseType","parseRange","(Ljava/lang/String;)Ljava/util/Set;","invokestatic",366);}
case 366:{f.Push(f.Locals[3]);f.Pc=367;continue;}
case 367:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPhase","()Lforge/game/phase/PhaseType;","invokevirtual",370);}
case 370:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",375);}
case 375:{f.Pc=f.Pop().Int!=0?380:378;continue;}
case 378:{f.Push(JValue.I(0));f.Pc=379;continue;}
case 379:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 380:{f.Push(f.Locals[0]);f.Pc=381;continue;}
case 381:{f.Push(JValue.R(rt.String("PlayerTurn")));f.Pc=384;continue;}
case 384:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",387);}
case 387:{f.Pc=f.Pop().Int==0?435:390;continue;}
case 390:{f.Push(f.Locals[0]);f.Pc=391;continue;}
case 391:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","hostCard","Lforge/game/card/Card;"));f.Pc=394;continue;}
case 394:{f.Push(f.Locals[0]);f.Pc=395;continue;}
case 395:{f.Push(JValue.R(rt.String("PlayerTurn")));f.Pc=398;continue;}
case 398:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",401);}
case 401:{f.Push(f.Locals[0]);f.Pc=402;continue;}
case 402:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",405);}
case 405:{f.Locals[5]=f.Pop();f.Pc=407;continue;}
case 407:{f.Push(f.Locals[5]);f.Pc=409;continue;}
case 409:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",414);}
case 414:{f.Push(f.Locals[3]);f.Pc=415;continue;}
case 415:{f.StackOp("dup");f.Pc=416;continue;}
case 416:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",419);}
case 419:{f.StackOp("pop");f.Pc=420;continue;}
case 420:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbility:9825:420:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/phase/PhaseHandler;)Ljava/util/function/Predicate;",425);}
case 425:{return rt.Call(f,"java/util/stream/Stream","noneMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",430);}
case 430:{f.Pc=f.Pop().Int==0?435:433;continue;}
case 433:{f.Push(JValue.I(0));f.Pc=434;continue;}
case 434:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 435:{f.Push(f.Locals[0]);f.Pc=436;continue;}
case 436:{f.Push(JValue.R(rt.String("TopCardOfLibraryIs")));f.Pc=439;continue;}
case 439:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",442);}
case 442:{f.Pc=f.Pop().Int==0?509:445;continue;}
case 445:{f.Push(f.Locals[1]);f.Pc=446;continue;}
case 446:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",452);}
case 452:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",457);}
case 457:{f.Pc=f.Pop().Int==0?462:460;continue;}
case 460:{f.Push(JValue.I(0));f.Pc=461;continue;}
case 461:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 462:{f.Push(f.Locals[1]);f.Pc=463;continue;}
case 463:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=466;continue;}
case 466:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",469);}
case 469:{f.Push(JValue.I(0));f.Pc=470;continue;}
case 470:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",475);}
case 475:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=478;continue;}
case 478:{f.Locals[5]=f.Pop();f.Pc=480;continue;}
case 480:{f.Push(f.Locals[5]);f.Pc=482;continue;}
case 482:{f.Push(f.Locals[0]);f.Pc=483;continue;}
case 483:{f.Push(JValue.R(rt.String("TopCardOfLibraryIs")));f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",489);}
case 489:{f.Push(JValue.R(rt.String(",")));f.Pc=492;continue;}
case 492:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",495);}
case 495:{f.Push(f.Locals[1]);f.Pc=496;continue;}
case 496:{f.Push(f.Locals[0]);f.Pc=497;continue;}
case 497:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","hostCard","Lforge/game/card/Card;"));f.Pc=500;continue;}
case 500:{f.Push(f.Locals[0]);f.Pc=501;continue;}
case 501:{return rt.Call(f,"forge/game/card/Card","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",504);}
case 504:{f.Pc=f.Pop().Int!=0?509:507;continue;}
case 507:{f.Push(JValue.I(0));f.Pc=508;continue;}
case 508:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 509:{f.Push(f.Locals[0]);f.Pc=510;continue;}
case 510:{f.Push(JValue.R(rt.String("IsPresent")));f.Pc=513;continue;}
case 513:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",516);}
case 516:{f.Pc=f.Pop().Int==0?640:519;continue;}
case 519:{f.Push(f.Locals[0]);f.Pc=520;continue;}
case 520:{f.Push(JValue.R(rt.String("PresentZone")));f.Pc=523;continue;}
case 523:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",526);}
case 526:{f.Pc=f.Pop().Int==0?542:529;continue;}
case 529:{f.Push(f.Locals[0]);f.Pc=530;continue;}
case 530:{f.Push(JValue.R(rt.String("PresentZone")));f.Pc=533;continue;}
case 533:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",536);}
case 536:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",539);}
case 539:{f.Pc=548;continue;}
case 542:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=545;continue;}
case 545:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",548);}
case 548:{f.Locals[5]=f.Pop();f.Pc=550;continue;}
case 550:{f.Push(f.Locals[0]);f.Pc=551;continue;}
case 551:{f.Push(JValue.R(rt.String("PresentCompare")));f.Pc=554;continue;}
case 554:{f.Push(JValue.R(rt.String("GE1")));f.Pc=557;continue;}
case 557:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",560);}
case 560:{f.Locals[6]=f.Pop();f.Pc=562;continue;}
case 562:{f.Push(f.Locals[2]);f.Pc=563;continue;}
case 563:{f.Push(f.Locals[5]);f.Pc=565;continue;}
case 565:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",568);}
case 568:{f.Locals[7]=f.Pop();f.Pc=570;continue;}
case 570:{f.Push(f.Locals[0]);f.Pc=571;continue;}
case 571:{f.Push(JValue.R(rt.String("IsPresent")));f.Pc=574;continue;}
case 574:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",577);}
case 577:{f.Locals[8]=f.Pop();f.Pc=579;continue;}
case 579:{f.Push(f.Locals[7]);f.Pc=581;continue;}
case 581:{f.Push(f.Locals[8]);f.Pc=583;continue;}
case 583:{f.Push(f.Locals[1]);f.Pc=584;continue;}
case 584:{f.Push(f.Locals[0]);f.Pc=585;continue;}
case 585:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","hostCard","Lforge/game/card/Card;"));f.Pc=588;continue;}
case 588:{f.Push(f.Locals[0]);f.Pc=589;continue;}
case 589:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",592);}
case 592:{f.Locals[7]=f.Pop();f.Pc=594;continue;}
case 594:{f.Push(JValue.I(1));f.Pc=595;continue;}
case 595:{f.Locals[9]=f.Pop();f.Pc=597;continue;}
case 597:{f.Push(f.Locals[6]);f.Pc=599;continue;}
case 599:{f.Push(JValue.I(2));f.Pc=600;continue;}
case 600:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",603);}
case 603:{f.Locals[10]=f.Pop();f.Pc=605;continue;}
case 605:{f.Push(f.Locals[0]);f.Pc=606;continue;}
case 606:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","hostCard","Lforge/game/card/Card;"));f.Pc=609;continue;}
case 609:{f.Push(f.Locals[10]);f.Pc=611;continue;}
case 611:{f.Push(f.Locals[0]);f.Pc=612;continue;}
case 612:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",615);}
case 615:{f.Locals[9]=f.Pop();f.Pc=617;continue;}
case 617:{f.Push(f.Locals[7]);f.Pc=619;continue;}
case 619:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",624);}
case 624:{f.Locals[11]=f.Pop();f.Pc=626;continue;}
case 626:{f.Push(f.Locals[11]);f.Pc=628;continue;}
case 628:{f.Push(f.Locals[6]);f.Pc=630;continue;}
case 630:{f.Push(f.Locals[9]);f.Pc=632;continue;}
case 632:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",635);}
case 635:{f.Pc=f.Pop().Int!=0?640:638;continue;}
case 638:{f.Push(JValue.I(0));f.Pc=639;continue;}
case 639:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 640:{f.Push(f.Locals[0]);f.Pc=641;continue;}
case 641:{f.Push(JValue.R(rt.String("GameStage")));f.Pc=644;continue;}
case 644:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",647);}
case 647:{f.Pc=f.Pop().Int==0?724:650;continue;}
case 650:{f.Push(f.Locals[0]);f.Pc=651;continue;}
case 651:{f.Push(JValue.R(rt.String("GameStage")));f.Pc=654;continue;}
case 654:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",657);}
case 657:{f.Push(JValue.I(44));f.Pc=659;continue;}
case 659:{return rt.Call(f,"forge/util/TextUtil","split","(Ljava/lang/CharSequence;C)[Ljava/lang/String;","invokestatic",662);}
case 662:{f.Locals[5]=f.Pop();f.Pc=664;continue;}
case 664:{f.Push(JValue.I(0));f.Pc=665;continue;}
case 665:{f.Locals[6]=f.Pop();f.Pc=667;continue;}
case 667:{f.Push(f.Locals[5]);f.Pc=669;continue;}
case 669:{f.Locals[7]=f.Pop();f.Pc=671;continue;}
case 671:{f.Push(f.Locals[7]);f.Pc=673;continue;}
case 673:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=674;continue;}
case 674:{f.Locals[8]=f.Pop();f.Pc=676;continue;}
case 676:{f.Push(JValue.I(0));f.Pc=677;continue;}
case 677:{f.Locals[9]=f.Pop();f.Pc=679;continue;}
case 679:{f.Push(f.Locals[9]);f.Pc=681;continue;}
case 681:{f.Push(f.Locals[8]);f.Pc=683;continue;}
case 683:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?721:686;continue;}
case 686:{f.Push(f.Locals[7]);f.Pc=688;continue;}
case 688:{f.Push(f.Locals[9]);f.Pc=690;continue;}
case 690:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=691;continue;}
case 691:{f.Locals[10]=f.Pop();f.Pc=693;continue;}
case 693:{f.Push(f.Locals[6]);f.Pc=695;continue;}
case 695:{f.Push(f.Locals[2]);f.Pc=696;continue;}
case 696:{return rt.Call(f,"forge/game/Game","getAge","()Lforge/game/GameStage;","invokevirtual",699);}
case 699:{f.Push(f.Locals[10]);f.Pc=701;continue;}
case 701:{return rt.Call(f,"forge/game/GameStage","valueOf","(Ljava/lang/String;)Lforge/game/GameStage;","invokestatic",704);}
case 704:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?711:707;continue;}
case 707:{f.Push(JValue.I(1));f.Pc=708;continue;}
case 708:{f.Pc=712;continue;}
case 711:{f.Push(JValue.I(0));f.Pc=712;continue;}
case 712:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=713;continue;}
case 713:{f.Locals[6]=f.Pop();f.Pc=715;continue;}
case 715:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=718;continue;}
case 718:{f.Pc=679;continue;}
case 721:{f.Push(f.Locals[6]);f.Pc=723;continue;}
case 723:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 724:{f.Push(f.Locals[0]);f.Pc=725;continue;}
case 725:{f.Push(JValue.R(rt.String("ClassLevel")));f.Pc=728;continue;}
case 728:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",731);}
case 731:{f.Pc=f.Pop().Int==0?764:734;continue;}
case 734:{f.Push(f.Locals[0]);f.Pc=735;continue;}
case 735:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","hostCard","Lforge/game/card/Card;"));f.Pc=738;continue;}
case 738:{return rt.Call(f,"forge/game/card/Card","getClassLevel","()I","invokevirtual",741);}
case 741:{f.Locals[5]=f.Pop();f.Pc=743;continue;}
case 743:{f.Push(f.Locals[0]);f.Pc=744;continue;}
case 744:{f.Push(JValue.R(rt.String("ClassLevel")));f.Pc=747;continue;}
case 747:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",750);}
case 750:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",753);}
case 753:{f.Locals[6]=f.Pop();f.Pc=755;continue;}
case 755:{f.Push(f.Locals[5]);f.Pc=757;continue;}
case 757:{f.Push(f.Locals[6]);f.Pc=759;continue;}
case 759:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?764:762;continue;}
case 762:{f.Push(JValue.I(0));f.Pc=763;continue;}
case 763:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 764:{f.Push(f.Locals[0]);f.Pc=765;continue;}
case 765:{f.Push(JValue.R(rt.String("CheckSVar")));f.Pc=768;continue;}
case 768:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",771);}
case 771:{f.Pc=f.Pop().Int==0?849:774;continue;}
case 774:{f.Push(f.Locals[0]);f.Pc=775;continue;}
case 775:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","hostCard","Lforge/game/card/Card;"));f.Pc=778;continue;}
case 778:{f.Push(f.Locals[0]);f.Pc=779;continue;}
case 779:{f.Push(JValue.R(rt.String("CheckSVar")));f.Pc=782;continue;}
case 782:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",785);}
case 785:{f.Push(f.Locals[0]);f.Pc=786;continue;}
case 786:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",789);}
case 789:{f.Locals[5]=f.Pop();f.Pc=791;continue;}
case 791:{f.Push(f.Locals[0]);f.Pc=792;continue;}
case 792:{f.Push(JValue.R(rt.String("SVarCompare")));f.Pc=795;continue;}
case 795:{f.Push(JValue.R(rt.String("GE1")));f.Pc=798;continue;}
case 798:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",801);}
case 801:{f.Locals[6]=f.Pop();f.Pc=803;continue;}
case 803:{f.Push(f.Locals[6]);f.Pc=805;continue;}
case 805:{f.Push(JValue.I(0));f.Pc=806;continue;}
case 806:{f.Push(JValue.I(2));f.Pc=807;continue;}
case 807:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",810);}
case 810:{f.Locals[7]=f.Pop();f.Pc=812;continue;}
case 812:{f.Push(f.Locals[6]);f.Pc=814;continue;}
case 814:{f.Push(JValue.I(2));f.Pc=815;continue;}
case 815:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",818);}
case 818:{f.Locals[8]=f.Pop();f.Pc=820;continue;}
case 820:{f.Push(f.Locals[0]);f.Pc=821;continue;}
case 821:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","hostCard","Lforge/game/card/Card;"));f.Pc=824;continue;}
case 824:{f.Push(f.Locals[8]);f.Pc=826;continue;}
case 826:{f.Push(f.Locals[0]);f.Pc=827;continue;}
case 827:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",830);}
case 830:{f.Locals[9]=f.Pop();f.Pc=832;continue;}
case 832:{f.Push(f.Locals[5]);f.Pc=834;continue;}
case 834:{f.Push(f.Locals[7]);f.Pc=836;continue;}
case 836:{f.Push(f.Locals[9]);f.Pc=838;continue;}
case 838:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",841);}
case 841:{f.Pc=f.Pop().Int!=0?846:844;continue;}
case 844:{f.Push(JValue.I(0));f.Pc=845;continue;}
case 845:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 846:{f.Pc=851;continue;}
case 849:{f.Push(JValue.I(1));f.Pc=850;continue;}
case 850:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 851:{f.Push(f.Locals[0]);f.Pc=852;continue;}
case 852:{f.Push(JValue.R(rt.String("CheckSecondSVar")));f.Pc=855;continue;}
case 855:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",858);}
case 858:{f.Pc=f.Pop().Int==0?936:861;continue;}
case 861:{f.Push(f.Locals[0]);f.Pc=862;continue;}
case 862:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","hostCard","Lforge/game/card/Card;"));f.Pc=865;continue;}
case 865:{f.Push(f.Locals[0]);f.Pc=866;continue;}
case 866:{f.Push(JValue.R(rt.String("CheckSecondSVar")));f.Pc=869;continue;}
case 869:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",872);}
case 872:{f.Push(f.Locals[0]);f.Pc=873;continue;}
case 873:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",876);}
case 876:{f.Locals[5]=f.Pop();f.Pc=878;continue;}
case 878:{f.Push(f.Locals[0]);f.Pc=879;continue;}
case 879:{f.Push(JValue.R(rt.String("SecondSVarCompare")));f.Pc=882;continue;}
case 882:{f.Push(JValue.R(rt.String("GE1")));f.Pc=885;continue;}
case 885:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",888);}
case 888:{f.Locals[6]=f.Pop();f.Pc=890;continue;}
case 890:{f.Push(f.Locals[6]);f.Pc=892;continue;}
case 892:{f.Push(JValue.I(0));f.Pc=893;continue;}
case 893:{f.Push(JValue.I(2));f.Pc=894;continue;}
case 894:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",897);}
case 897:{f.Locals[7]=f.Pop();f.Pc=899;continue;}
case 899:{f.Push(f.Locals[6]);f.Pc=901;continue;}
case 901:{f.Push(JValue.I(2));f.Pc=902;continue;}
case 902:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",905);}
case 905:{f.Locals[8]=f.Pop();f.Pc=907;continue;}
case 907:{f.Push(f.Locals[0]);f.Pc=908;continue;}
case 908:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","hostCard","Lforge/game/card/Card;"));f.Pc=911;continue;}
case 911:{f.Push(f.Locals[8]);f.Pc=913;continue;}
case 913:{f.Push(f.Locals[0]);f.Pc=914;continue;}
case 914:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",917);}
case 917:{f.Locals[9]=f.Pop();f.Pc=919;continue;}
case 919:{f.Push(f.Locals[5]);f.Pc=921;continue;}
case 921:{f.Push(f.Locals[7]);f.Pc=923;continue;}
case 923:{f.Push(f.Locals[9]);f.Pc=925;continue;}
case 925:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",928);}
case 928:{f.Pc=f.Pop().Int!=0?933:931;continue;}
case 931:{f.Push(JValue.I(0));f.Pc=932;continue;}
case 932:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 933:{f.Pc=938;continue;}
case 936:{f.Push(JValue.I(1));f.Pc=937;continue;}
case 937:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 938:{f.Push(f.Locals[0]);f.Pc=939;continue;}
case 939:{f.Push(JValue.R(rt.String("CheckThirdSVar")));f.Pc=942;continue;}
case 942:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",945);}
case 945:{f.Pc=f.Pop().Int==0?1023:948;continue;}
case 948:{f.Push(f.Locals[0]);f.Pc=949;continue;}
case 949:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","hostCard","Lforge/game/card/Card;"));f.Pc=952;continue;}
case 952:{f.Push(f.Locals[0]);f.Pc=953;continue;}
case 953:{f.Push(JValue.R(rt.String("CheckThirdSVar")));f.Pc=956;continue;}
case 956:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",959);}
case 959:{f.Push(f.Locals[0]);f.Pc=960;continue;}
case 960:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",963);}
case 963:{f.Locals[5]=f.Pop();f.Pc=965;continue;}
case 965:{f.Push(f.Locals[0]);f.Pc=966;continue;}
case 966:{f.Push(JValue.R(rt.String("ThirdSVarCompare")));f.Pc=969;continue;}
case 969:{f.Push(JValue.R(rt.String("GE1")));f.Pc=972;continue;}
case 972:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",975);}
case 975:{f.Locals[6]=f.Pop();f.Pc=977;continue;}
case 977:{f.Push(f.Locals[6]);f.Pc=979;continue;}
case 979:{f.Push(JValue.I(0));f.Pc=980;continue;}
case 980:{f.Push(JValue.I(2));f.Pc=981;continue;}
case 981:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",984);}
case 984:{f.Locals[7]=f.Pop();f.Pc=986;continue;}
case 986:{f.Push(f.Locals[6]);f.Pc=988;continue;}
case 988:{f.Push(JValue.I(2));f.Pc=989;continue;}
case 989:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",992);}
case 992:{f.Locals[8]=f.Pop();f.Pc=994;continue;}
case 994:{f.Push(f.Locals[0]);f.Pc=995;continue;}
case 995:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","hostCard","Lforge/game/card/Card;"));f.Pc=998;continue;}
case 998:{f.Push(f.Locals[8]);f.Pc=1000;continue;}
case 1000:{f.Push(f.Locals[0]);f.Pc=1001;continue;}
case 1001:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1004);}
case 1004:{f.Locals[9]=f.Pop();f.Pc=1006;continue;}
case 1006:{f.Push(f.Locals[5]);f.Pc=1008;continue;}
case 1008:{f.Push(f.Locals[7]);f.Pc=1010;continue;}
case 1010:{f.Push(f.Locals[9]);f.Pc=1012;continue;}
case 1012:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1015);}
case 1015:{f.Pc=f.Pop().Int!=0?1020:1018;continue;}
case 1018:{f.Push(JValue.I(0));f.Pc=1019;continue;}
case 1019:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1020:{f.Pc=1025;continue;}
case 1023:{f.Push(JValue.I(1));f.Pc=1024;continue;}
case 1024:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1025:{f.Push(f.Locals[0]);f.Pc=1026;continue;}
case 1026:{f.Push(JValue.R(rt.String("CheckFourthSVar")));f.Pc=1029;continue;}
case 1029:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1032);}
case 1032:{f.Pc=f.Pop().Int==0?1107:1035;continue;}
case 1035:{f.Push(f.Locals[0]);f.Pc=1036;continue;}
case 1036:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","hostCard","Lforge/game/card/Card;"));f.Pc=1039;continue;}
case 1039:{f.Push(f.Locals[0]);f.Pc=1040;continue;}
case 1040:{f.Push(JValue.R(rt.String("CheckFourthSVar")));f.Pc=1043;continue;}
case 1043:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1046);}
case 1046:{f.Push(f.Locals[0]);f.Pc=1047;continue;}
case 1047:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1050);}
case 1050:{f.Locals[5]=f.Pop();f.Pc=1052;continue;}
case 1052:{f.Push(f.Locals[0]);f.Pc=1053;continue;}
case 1053:{f.Push(JValue.R(rt.String("FourthSVarCompare")));f.Pc=1056;continue;}
case 1056:{f.Push(JValue.R(rt.String("GE1")));f.Pc=1059;continue;}
case 1059:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1062);}
case 1062:{f.Locals[6]=f.Pop();f.Pc=1064;continue;}
case 1064:{f.Push(f.Locals[6]);f.Pc=1066;continue;}
case 1066:{f.Push(JValue.I(0));f.Pc=1067;continue;}
case 1067:{f.Push(JValue.I(2));f.Pc=1068;continue;}
case 1068:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",1071);}
case 1071:{f.Locals[7]=f.Pop();f.Pc=1073;continue;}
case 1073:{f.Push(f.Locals[6]);f.Pc=1075;continue;}
case 1075:{f.Push(JValue.I(2));f.Pc=1076;continue;}
case 1076:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",1079);}
case 1079:{f.Locals[8]=f.Pop();f.Pc=1081;continue;}
case 1081:{f.Push(f.Locals[0]);f.Pc=1082;continue;}
case 1082:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","hostCard","Lforge/game/card/Card;"));f.Pc=1085;continue;}
case 1085:{f.Push(f.Locals[8]);f.Pc=1087;continue;}
case 1087:{f.Push(f.Locals[0]);f.Pc=1088;continue;}
case 1088:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1091);}
case 1091:{f.Locals[9]=f.Pop();f.Pc=1093;continue;}
case 1093:{f.Push(f.Locals[5]);f.Pc=1095;continue;}
case 1095:{f.Push(f.Locals[7]);f.Pc=1097;continue;}
case 1097:{f.Push(f.Locals[9]);f.Pc=1099;continue;}
case 1099:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",1102);}
case 1102:{f.Pc=f.Pop().Int!=0?1107:1105;continue;}
case 1105:{f.Push(JValue.I(0));f.Pc=1106;continue;}
case 1106:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 1107:{f.Push(JValue.I(1));f.Pc=1108;continue;}
case 1108:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9826(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","ignoreEffectCards","Lforge/game/card/CardCollectionView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9827(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","ignoreEffectCards","Lforge/game/card/CardCollectionView;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9828(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","ignoreEffectPlayers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9829(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","ignoreEffectPlayers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9830(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","ignoreEffectPlayers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",17);}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","ignoreEffectCards","Lforge/game/card/CardCollectionView;",value);f.Pc=20;continue;}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9831(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","layers","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9832(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","mayPlayTurn","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","hostCard","Lforge/game/card/Card;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/zone/MagicStack","getSpellsCastThisTurn","()Ljava/util/List;","invokevirtual",17);}
case 17:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbility:9832:23:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/staticability/StaticAbility;)Ljava/util/function/Predicate;",28);}
case 28:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",33);}
case 33:{return rt.Call(f,"java/util/stream/Stream","count","()J","invokeinterface",38);}
case 38:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=39;continue;}
case 39:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=40;continue;}
case 40:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9833(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","mayPlayTurn","I"));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","mayPlayTurn","I",value);f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9834(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","mayPlayTurn","I",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9835(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/ComparisonChain","start","()Lcom/google/common/collect/ComparisonChain;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",7);}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",11);}
case 11:{return rt.Call(f,"com/google/common/collect/ComparisonChain","compare","(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lcom/google/common/collect/ComparisonChain;","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",18);}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/staticability/StaticAbility","getId","()I","invokevirtual",22);}
case 22:{return rt.Call(f,"com/google/common/collect/ComparisonChain","compare","(II)Lcom/google/common/collect/ComparisonChain;","invokevirtual",25);}
case 25:{return rt.Call(f,"com/google/common/collect/ComparisonChain","result","()I","invokevirtual",28);}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9836(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Timestamp")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?24:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Timestamp")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",17);}
case 17:{return rt.Call(f,"java/lang/Long","valueOf","(Ljava/lang/String;)Ljava/lang/Long;","invokestatic",20);}
case 20:{return rt.Call(f,"java/lang/Long","longValue","()J","invokevirtual",23);}
case 23:{return JStep.Return(f.Pop());}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",28);}
case 28:{return rt.Call(f,"forge/game/card/Card","getLayerTimestamp","()J","invokevirtual",31);}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9837(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/CardTraitBase","setHostCard","(Lforge/game/card/Card;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","payingTrigSA","Lforge/game/spellability/SpellAbility;"));f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference==null?20:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","payingTrigSA","Lforge/game/spellability/SpellAbility;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",20);}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9838(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","copy","(Lforge/game/card/Card;ZZ)Lforge/game/staticability/StaticAbility;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9839(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[4]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/Object","clone","()Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{f.Locals[4]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Int==0?25:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","id","I"));f.Pc=22;continue;}
case 22:{f.Pc=28;continue;}
case 25:{return rt.Call(f,"forge/game/staticability/StaticAbility","nextId","()I","invokestatic",28);}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","id","I",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Pc=f.Pop().Int!=0?43:39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Int==0?47:43;continue;}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{f.Pc=48;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/staticability/StaticAbility","copyHelper","(Lforge/game/CardTraitBase;Lforge/game/card/Card;Z)V","invokevirtual",51);}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{f.Push(JValue.R(null));f.Pc=54;continue;}
case 54:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","payingTrigSA","Lforge/game/spellability/SpellAbility;",value);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Pc=f.Pop().Int!=0?67:61;continue;}
case 61:{f.Push(f.Locals[4]);f.Pc=63;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","mayPlayTurn","I",value);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/staticability/StaticAbility","generateLayer","()Ljava/util/Set;","invokevirtual",73);}
case 73:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/staticability/StaticAbility","layers","Ljava/util/Set;",value);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","validHostZones","Ljava/util/EnumSet;"));f.Pc=80;continue;}
case 80:{f.Pc=f.Pop().Reference==null?95:83;continue;}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","validHostZones","Ljava/util/EnumSet;"));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/EnumSet","copyOf","(Ljava/util/EnumSet;)Ljava/util/EnumSet;","invokestatic",92);}
case 92:{return rt.Call(f,"forge/game/staticability/StaticAbility","setActiveZone","(Ljava/util/EnumSet;)V","invokevirtual",95);}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","modes","Ljava/util/Set;"));f.Pc=99;continue;}
case 99:{f.Pc=f.Pop().Reference==null?114:102;continue;}
case 102:{f.Push(f.Locals[4]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(rt.GetField(f.Pop(),"forge/game/staticability/StaticAbility","modes","Ljava/util/Set;"));f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/EnumSet","copyOf","(Ljava/util/Collection;)Ljava/util/EnumSet;","invokestatic",111);}
case 111:{return rt.Call(f,"forge/game/staticability/StaticAbility","setMode","(Ljava/util/Set;)V","invokevirtual",114);}
case 114:{f.Pc=127;continue;}
case 117:{f.Locals[5]=f.Pop();f.Pc=119;continue;}
case 119:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=122;continue;}
case 122:{f.Push(f.Locals[5]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/Object;)V","invokevirtual",127);}
case 127:{f.Push(f.Locals[4]);f.Pc=129;continue;}
case 129:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9840(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/staticability/StaticAbility","compareTo","(Lforge/game/staticability/StaticAbility;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9841(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMayPlay","()Lforge/game/staticability/StaticAbility;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/staticability/StaticAbility","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9842(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbility","maxId","I"))return JStep.Continue;rt.PutStatic("forge/game/staticability/StaticAbility","maxId","I",f.Pop());f.Pc=4;continue;}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
