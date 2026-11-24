// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1096{
internal static JClass Build(){var c=new JClass("forge/trackable/TrackableTypes","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("BooleanType","Lforge/trackable/TrackableTypes$TrackableType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JField("IntegerType","Lforge/trackable/TrackableTypes$TrackableType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JField("FloatType","Lforge/trackable/TrackableTypes$TrackableType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JField("StringType","Lforge/trackable/TrackableTypes$TrackableType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JField("ObjectType","Lforge/trackable/TrackableTypes$TrackableType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JField("enumTypes","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableObjectType;"),null));
c.Add(new JField("IPaperCardType","Lforge/trackable/TrackableTypes$TrackableType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JField("CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableCollectionType;"),null));
c.Add(new JField("CardStateViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableObjectType;"),null));
c.Add(new JField("CardTypeViewType","Lforge/trackable/TrackableTypes$TrackableType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JField("PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableObjectType;"),null));
c.Add(new JField("PlayerViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableCollectionType;"),null));
c.Add(new JField("GameEntityViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableObjectType;"),null));
c.Add(new JField("StackItemViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableObjectType;"),null));
c.Add(new JField("StackItemViewListType","Lforge/trackable/TrackableTypes$TrackableCollectionType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableCollectionType;"),null));
c.Add(new JField("CombatViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableObjectType;"),null));
c.Add(new JField("ManaCostType","Lforge/trackable/TrackableTypes$TrackableType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JField("ColorSetType","Lforge/trackable/TrackableTypes$TrackableType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JField("StringListType","Lforge/trackable/TrackableTypes$TrackableType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JField("StringSetType","Lforge/trackable/TrackableTypes$TrackableType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JField("StringMapType","Lforge/trackable/TrackableTypes$TrackableType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JField("IntegerSetType","Lforge/trackable/TrackableTypes$TrackableType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JField("IntegerMapType","Lforge/trackable/TrackableTypes$TrackableType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JField("ManaMapType","Lforge/trackable/TrackableTypes$TrackableType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JField("CounterMapType","Lforge/trackable/TrackableTypes$TrackableType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JField("GenericMapType","Lforge/trackable/TrackableTypes$TrackableType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JField("KeywordCollectionViewType","Lforge/trackable/TrackableTypes$TrackableType;",true,JValue.Default("Lforge/trackable/TrackableTypes$TrackableType;"),null));
c.Add(new JMethod(11578,"forge/trackable/TrackableTypes","<init>","()V",1,1,1,new JHandler[]{},M11578));
c.Add(new JMethod(11579,"forge/trackable/TrackableTypes","EnumType","(Ljava/lang/Class;)Lforge/trackable/TrackableTypes$TrackableType;",9,1,3,new JHandler[]{},M11579));
c.Add(new JMethod(11580,"forge/trackable/TrackableTypes","lambda$EnumType$0","(Ljava/lang/Class;)Lforge/trackable/TrackableTypes$TrackableType;",4106,1,3,new JHandler[]{},M11580));
c.Add(new JMethod(11581,"forge/trackable/TrackableTypes","<clinit>","()V",8,0,3,new JHandler[]{},M11581));
}

internal static JStep M11578(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11579(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","enumTypes","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","enumTypes","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.DynamicCall(f,"forge/trackable/TrackableTypes:11579:4:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",9);}
case 9:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",14);}
case 14:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/trackable/TrackableTypes$TrackableType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11580(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11581(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",11);}
case 11:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","BooleanType","Lforge/trackable/TrackableTypes$TrackableType;",f.Pop());f.Pc=14;continue;}
case 14:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",22);}
case 22:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",25);}
case 25:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","IntegerType","Lforge/trackable/TrackableTypes$TrackableType;",f.Pop());f.Pc=28;continue;}
case 28:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{f.Push(JValue.F(0));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/Float","valueOf","(F)Ljava/lang/Float;","invokestatic",36);}
case 36:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",39);}
case 39:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","FloatType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","FloatType","Lforge/trackable/TrackableTypes$TrackableType;",f.Pop());f.Pc=42;continue;}
case 42:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=45;continue;}
case 45:{f.StackOp("dup");f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",51);}
case 51:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","StringType","Lforge/trackable/TrackableTypes$TrackableType;",f.Pop());f.Pc=54;continue;}
case 54:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{f.Push(JValue.R(null));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",62);}
case 62:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","ObjectType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","ObjectType","Lforge/trackable/TrackableTypes$TrackableType;",f.Pop());f.Pc=65;continue;}
case 65:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",68);}
case 68:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","enumTypes","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","enumTypes","Ljava/util/Map;",f.Pop());f.Pc=71;continue;}
case 71:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableObjectType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableObjectType")));f.Pc=74;continue;}
case 74:{f.StackOp("dup");f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableObjectType","<init>","()V","invokespecial",78);}
case 78:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;",f.Pop());f.Pc=81;continue;}
case 81:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=84;continue;}
case 84:{f.StackOp("dup");f.Pc=85;continue;}
case 85:{f.Push(JValue.R(null));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",89);}
case 89:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IPaperCardType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","IPaperCardType","Lforge/trackable/TrackableTypes$TrackableType;",f.Pop());f.Pc=92;continue;}
case 92:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableCollectionType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableCollectionType")));f.Pc=95;continue;}
case 95:{f.StackOp("dup");f.Pc=96;continue;}
case 96:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","CardViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableCollectionType","<init>","(Lforge/trackable/TrackableTypes$TrackableObjectType;)V","invokespecial",102);}
case 102:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","CardViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;",f.Pop());f.Pc=105;continue;}
case 105:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableObjectType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableObjectType")));f.Pc=108;continue;}
case 108:{f.StackOp("dup");f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableObjectType","<init>","()V","invokespecial",112);}
case 112:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardStateViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","CardStateViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;",f.Pop());f.Pc=115;continue;}
case 115:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{if(!rt.StaticReady(f,"forge/card/CardType","EMPTY","Lforge/card/CardTypeView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType","EMPTY","Lforge/card/CardTypeView;"));f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",125);}
case 125:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CardTypeViewType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","CardTypeViewType","Lforge/trackable/TrackableTypes$TrackableType;",f.Pop());f.Pc=128;continue;}
case 128:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableObjectType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableObjectType")));f.Pc=131;continue;}
case 131:{f.StackOp("dup");f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableObjectType","<init>","()V","invokespecial",135);}
case 135:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;",f.Pop());f.Pc=138;continue;}
case 138:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableCollectionType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableCollectionType")));f.Pc=141;continue;}
case 141:{f.StackOp("dup");f.Pc=142;continue;}
case 142:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","PlayerViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableCollectionType","<init>","(Lforge/trackable/TrackableTypes$TrackableObjectType;)V","invokespecial",148);}
case 148:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","PlayerViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","PlayerViewCollectionType","Lforge/trackable/TrackableTypes$TrackableCollectionType;",f.Pop());f.Pc=151;continue;}
case 151:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableObjectType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableObjectType")));f.Pc=154;continue;}
case 154:{f.StackOp("dup");f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableObjectType","<init>","()V","invokespecial",158);}
case 158:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","GameEntityViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","GameEntityViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;",f.Pop());f.Pc=161;continue;}
case 161:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableObjectType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableObjectType")));f.Pc=164;continue;}
case 164:{f.StackOp("dup");f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableObjectType","<init>","()V","invokespecial",168);}
case 168:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StackItemViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","StackItemViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;",f.Pop());f.Pc=171;continue;}
case 171:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableCollectionType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableCollectionType")));f.Pc=174;continue;}
case 174:{f.StackOp("dup");f.Pc=175;continue;}
case 175:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StackItemViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableTypes","StackItemViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"));f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableCollectionType","<init>","(Lforge/trackable/TrackableTypes$TrackableObjectType;)V","invokespecial",181);}
case 181:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StackItemViewListType","Lforge/trackable/TrackableTypes$TrackableCollectionType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","StackItemViewListType","Lforge/trackable/TrackableTypes$TrackableCollectionType;",f.Pop());f.Pc=184;continue;}
case 184:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableObjectType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableObjectType")));f.Pc=187;continue;}
case 187:{f.StackOp("dup");f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableObjectType","<init>","()V","invokespecial",191);}
case 191:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CombatViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","CombatViewType","Lforge/trackable/TrackableTypes$TrackableObjectType;",f.Pop());f.Pc=194;continue;}
case 194:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=197;continue;}
case 197:{f.StackOp("dup");f.Pc=198;continue;}
case 198:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","NO_COST","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","NO_COST","Lforge/card/mana/ManaCost;"));f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",204);}
case 204:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","ManaCostType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","ManaCostType","Lforge/trackable/TrackableTypes$TrackableType;",f.Pop());f.Pc=207;continue;}
case 207:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=210;continue;}
case 210:{f.StackOp("dup");f.Pc=211;continue;}
case 211:{if(!rt.StaticReady(f,"forge/card/ColorSet","C","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","C","Lforge/card/ColorSet;"));f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",217);}
case 217:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","ColorSetType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","ColorSetType","Lforge/trackable/TrackableTypes$TrackableType;",f.Pop());f.Pc=220;continue;}
case 220:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=223;continue;}
case 223:{f.StackOp("dup");f.Pc=224;continue;}
case 224:{f.Push(JValue.R(null));f.Pc=225;continue;}
case 225:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",228);}
case 228:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringListType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","StringListType","Lforge/trackable/TrackableTypes$TrackableType;",f.Pop());f.Pc=231;continue;}
case 231:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=234;continue;}
case 234:{f.StackOp("dup");f.Pc=235;continue;}
case 235:{f.Push(JValue.R(null));f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",239);}
case 239:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringSetType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","StringSetType","Lforge/trackable/TrackableTypes$TrackableType;",f.Pop());f.Pc=242;continue;}
case 242:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=245;continue;}
case 245:{f.StackOp("dup");f.Pc=246;continue;}
case 246:{f.Push(JValue.R(null));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",250);}
case 250:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","StringMapType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","StringMapType","Lforge/trackable/TrackableTypes$TrackableType;",f.Pop());f.Pc=253;continue;}
case 253:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=256;continue;}
case 256:{f.StackOp("dup");f.Pc=257;continue;}
case 257:{f.Push(JValue.R(null));f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",261);}
case 261:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerSetType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","IntegerSetType","Lforge/trackable/TrackableTypes$TrackableType;",f.Pop());f.Pc=264;continue;}
case 264:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=267;continue;}
case 267:{f.StackOp("dup");f.Pc=268;continue;}
case 268:{f.Push(JValue.R(null));f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",272);}
case 272:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","IntegerMapType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","IntegerMapType","Lforge/trackable/TrackableTypes$TrackableType;",f.Pop());f.Pc=275;continue;}
case 275:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=278;continue;}
case 278:{f.StackOp("dup");f.Pc=279;continue;}
case 279:{f.Push(JValue.R(null));f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",283);}
case 283:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","ManaMapType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","ManaMapType","Lforge/trackable/TrackableTypes$TrackableType;",f.Pop());f.Pc=286;continue;}
case 286:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=289;continue;}
case 289:{f.StackOp("dup");f.Pc=290;continue;}
case 290:{f.Push(JValue.R(null));f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",294);}
case 294:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","CounterMapType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","CounterMapType","Lforge/trackable/TrackableTypes$TrackableType;",f.Pop());f.Pc=297;continue;}
case 297:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=300;continue;}
case 300:{f.StackOp("dup");f.Pc=301;continue;}
case 301:{f.Push(JValue.R(null));f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",305);}
case 305:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","GenericMapType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","GenericMapType","Lforge/trackable/TrackableTypes$TrackableType;",f.Pop());f.Pc=308;continue;}
case 308:{if(!rt.EnsureInitialized(f,"forge/trackable/TrackableTypes$TrackableType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/trackable/TrackableTypes$TrackableType")));f.Pc=311;continue;}
case 311:{f.StackOp("dup");f.Pc=312;continue;}
case 312:{if(!rt.StaticReady(f,"forge/game/keyword/KeywordCollectionView","EMPTY","Lforge/game/keyword/KeywordCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/KeywordCollectionView","EMPTY","Lforge/game/keyword/KeywordCollectionView;"));f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/trackable/TrackableTypes$TrackableType","<init>","(Ljava/lang/Object;)V","invokespecial",318);}
case 318:{if(!rt.StaticReady(f,"forge/trackable/TrackableTypes","KeywordCollectionViewType","Lforge/trackable/TrackableTypes$TrackableType;"))return JStep.Continue;rt.PutStatic("forge/trackable/TrackableTypes","KeywordCollectionViewType","Lforge/trackable/TrackableTypes$TrackableType;",f.Pop());f.Pc=321;continue;}
case 321:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
