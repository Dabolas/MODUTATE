// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C12{
internal static JClass Build(){var c=new JClass("forge/card/CardChangedType","java/lang/Record",new string[]{"forge/card/ICardChangedType"},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("addType","Lforge/card/CardTypeView;",false,JValue.Default("Lforge/card/CardTypeView;"),null));
c.Add(new JField("removeType","Lforge/card/CardTypeView;",false,JValue.Default("Lforge/card/CardTypeView;"),null));
c.Add(new JField("addAllCreatureTypes","Z",false,JValue.Default("Z"),null));
c.Add(new JField("remove","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JMethod(192,"forge/card/CardChangedType","<init>","(Lforge/card/CardTypeView;Lforge/card/CardTypeView;ZLjava/util/Set;)V",1,5,2,new JHandler[]{},M192));
c.Add(new JMethod(193,"forge/card/CardChangedType","isRemoveSuperTypes","()Z",1,1,2,new JHandler[]{},M193));
c.Add(new JMethod(194,"forge/card/CardChangedType","isRemoveCardTypes","()Z",1,1,2,new JHandler[]{},M194));
c.Add(new JMethod(195,"forge/card/CardChangedType","isRemoveSubTypes","()Z",1,1,2,new JHandler[]{},M195));
c.Add(new JMethod(196,"forge/card/CardChangedType","isRemoveLandTypes","()Z",1,1,2,new JHandler[]{},M196));
c.Add(new JMethod(197,"forge/card/CardChangedType","isRemoveCreatureTypes","()Z",1,1,2,new JHandler[]{},M197));
c.Add(new JMethod(198,"forge/card/CardChangedType","isRemoveArtifactTypes","()Z",1,1,2,new JHandler[]{},M198));
c.Add(new JMethod(199,"forge/card/CardChangedType","isRemoveEnchantmentTypes","()Z",1,1,2,new JHandler[]{},M199));
c.Add(new JMethod(200,"forge/card/CardChangedType","applyChanges","(Lforge/card/CardType;)Lforge/card/CardType;",1,2,3,new JHandler[]{},M200));
c.Add(new JMethod(201,"forge/card/CardChangedType","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M201));
c.Add(new JMethod(202,"forge/card/CardChangedType","hashCode","()I",17,1,1,new JHandler[]{},M202));
c.Add(new JMethod(203,"forge/card/CardChangedType","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M203));
c.Add(new JMethod(204,"forge/card/CardChangedType","addType","()Lforge/card/CardTypeView;",1,1,1,new JHandler[]{},M204));
c.Add(new JMethod(205,"forge/card/CardChangedType","removeType","()Lforge/card/CardTypeView;",1,1,1,new JHandler[]{},M205));
c.Add(new JMethod(206,"forge/card/CardChangedType","addAllCreatureTypes","()Z",1,1,1,new JHandler[]{},M206));
c.Add(new JMethod(207,"forge/card/CardChangedType","remove","()Ljava/util/Set;",1,1,1,new JHandler[]{},M207));
}

internal static JStep M192(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardChangedType","addType","Lforge/card/CardTypeView;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardChangedType","removeType","Lforge/card/CardTypeView;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardChangedType","addAllCreatureTypes","Z",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardChangedType","remove","Ljava/util/Set;",value);f.Pc=25;continue;}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M193(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardChangedType","remove","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/RemoveType","SuperTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","SuperTypes","Lforge/card/RemoveType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M194(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardChangedType","remove","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/RemoveType","CardTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","CardTypes","Lforge/card/RemoveType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M195(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardChangedType","remove","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/RemoveType","SubTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","SubTypes","Lforge/card/RemoveType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M196(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardChangedType","remove","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/RemoveType","LandTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","LandTypes","Lforge/card/RemoveType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M197(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardChangedType","remove","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/RemoveType","CreatureTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","CreatureTypes","Lforge/card/RemoveType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M198(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardChangedType","remove","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/RemoveType","ArtifactTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","ArtifactTypes","Lforge/card/RemoveType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M199(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardChangedType","remove","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/card/RemoveType","EnchantmentTypes","Lforge/card/RemoveType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/RemoveType","EnchantmentTypes","Lforge/card/RemoveType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M200(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardChangedType","isRemoveCardTypes","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?20:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","coreTypes","Ljava/util/Set;"));f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","spellTypes","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","spellTypes","Ljava/util/Set;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Set","retainAll","(Ljava/util/Collection;)Z","invokeinterface",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/card/CardChangedType","isRemoveSuperTypes","()Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?36:27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","supertypes","Ljava/util/Set;"));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Set","clear","()V","invokeinterface",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/card/CardChangedType","isRemoveSubTypes","()Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?55:43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Set","clear","()V","invokeinterface",52);}
case 52:{f.Pc=160;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Set","isEmpty","()Z","invokeinterface",64);}
case 64:{f.Pc=f.Pop().Int!=0?160:67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/card/CardChangedType","isRemoveLandTypes","()Z","invokevirtual",71);}
case 71:{f.Pc=f.Pop().Int==0?89:74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=78;continue;}
case 78:{return rt.DynamicCall(f,"forge/card/CardChangedType:200:78:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",83);}
case 83:{return rt.Call(f,"java/util/Set","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",88);}
case 88:{f.StackOp("pop");f.Pc=89;continue;}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/card/CardChangedType","isRemoveCreatureTypes","()Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int==0?116:96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=100;continue;}
case 100:{return rt.DynamicCall(f,"forge/card/CardChangedType:200:100:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",105);}
case 105:{return rt.Call(f,"java/util/Set","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",110);}
case 110:{f.StackOp("pop");f.Pc=111;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{f.Push(JValue.I(0));f.Pc=113;continue;}
case 113:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","allCreatureTypes","Z",value);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/card/CardChangedType","isRemoveArtifactTypes","()Z","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int==0?138:123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=127;continue;}
case 127:{return rt.DynamicCall(f,"forge/card/CardChangedType:200:127:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",132);}
case 132:{return rt.Call(f,"java/util/Set","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",137);}
case 137:{f.StackOp("pop");f.Pc=138;continue;}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/card/CardChangedType","isRemoveEnchantmentTypes","()Z","invokevirtual",142);}
case 142:{f.Pc=f.Pop().Int==0?160:145;continue;}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","subtypes","Ljava/util/Set;"));f.Pc=149;continue;}
case 149:{return rt.DynamicCall(f,"forge/card/CardChangedType:200:149:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",154);}
case 154:{return rt.Call(f,"java/util/Set","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",159);}
case 159:{f.StackOp("pop");f.Pc=160;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/card/CardChangedType","removeType","()Lforge/card/CardTypeView;","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Reference==null?176:167;continue;}
case 167:{f.Push(f.Locals[1]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[0]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/card/CardChangedType","removeType","()Lforge/card/CardTypeView;","invokevirtual",172);}
case 172:{return rt.Call(f,"forge/card/CardType","removeAll","(Lforge/card/CardTypeView;)Z","invokevirtual",175);}
case 175:{f.StackOp("pop");f.Pc=176;continue;}
case 176:{f.Push(f.Locals[0]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/card/CardChangedType","addType","()Lforge/card/CardTypeView;","invokevirtual",180);}
case 180:{f.Pc=f.Pop().Reference==null?209:183;continue;}
case 183:{f.Push(f.Locals[1]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[0]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/card/CardChangedType","addType","()Lforge/card/CardTypeView;","invokevirtual",188);}
case 188:{return rt.Call(f,"forge/card/CardType","addAll","(Lforge/card/CardTypeView;)Z","invokevirtual",191);}
case 191:{f.StackOp("pop");f.Pc=192;continue;}
case 192:{f.Push(f.Locals[0]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/card/CardChangedType","addType","()Lforge/card/CardTypeView;","invokevirtual",196);}
case 196:{return rt.Call(f,"forge/card/CardTypeView","hasAllCreatureTypes","()Z","invokeinterface",201);}
case 201:{f.Pc=f.Pop().Int==0?209:204;continue;}
case 204:{f.Push(f.Locals[1]);f.Pc=205;continue;}
case 205:{f.Push(JValue.I(1));f.Pc=206;continue;}
case 206:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","allCreatureTypes","Z",value);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[0]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/card/CardChangedType","addAllCreatureTypes","()Z","invokevirtual",213);}
case 213:{f.Pc=f.Pop().Int==0?221:216;continue;}
case 216:{f.Push(f.Locals[1]);f.Pc=217;continue;}
case 217:{f.Push(JValue.I(1));f.Pc=218;continue;}
case 218:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType","allCreatureTypes","Z",value);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[0]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/card/CardChangedType","removeType","()Lforge/card/CardTypeView;","invokevirtual",225);}
case 225:{f.Pc=f.Pop().Reference==null?265:228;continue;}
case 228:{f.Push(f.Locals[1]);f.Pc=229;continue;}
case 229:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","allCreatureTypes","Z"));f.Pc=232;continue;}
case 232:{f.Pc=f.Pop().Int==0?265:235;continue;}
case 235:{f.Push(f.Locals[1]);f.Pc=236;continue;}
case 236:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType","excludedCreatureSubtypes","Ljava/util/Set;"));f.Pc=239;continue;}
case 239:{f.Push(f.Locals[0]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/card/CardChangedType","removeType","()Lforge/card/CardTypeView;","invokevirtual",243);}
case 243:{return rt.Call(f,"forge/card/CardTypeView","getSubtypes","()Ljava/util/Collection;","invokeinterface",248);}
case 248:{return rt.DynamicCall(f,"forge/card/CardChangedType:200:248:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",253);}
case 253:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/util/Collection;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",256);}
case 256:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",259);}
case 259:{return rt.Call(f,"java/util/Set","addAll","(Ljava/util/Collection;)Z","invokeinterface",264);}
case 264:{f.StackOp("pop");f.Pc=265;continue;}
case 265:{f.Push(f.Locals[1]);f.Pc=266;continue;}
case 266:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M201(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/card/CardChangedType:201:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/card/CardChangedType;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M202(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/card/CardChangedType:202:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/card/CardChangedType;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M203(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/card/CardChangedType:203:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/card/CardChangedType;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M204(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardChangedType","addType","Lforge/card/CardTypeView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M205(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardChangedType","removeType","Lforge/card/CardTypeView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M206(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardChangedType","addAllCreatureTypes","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M207(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardChangedType","remove","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
