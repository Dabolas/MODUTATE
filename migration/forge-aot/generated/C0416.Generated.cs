// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C416{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/TimeTravelEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3779,"forge/game/ability/effects/TimeTravelEffect","<init>","()V",1,1,1,new JHandler[]{},M3779));
c.Add(new JMethod(3780,"forge/game/ability/effects/TimeTravelEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,1,new JHandler[]{},M3780));
c.Add(new JMethod(3781,"forge/game/ability/effects/TimeTravelEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,16,9,new JHandler[]{},M3781));
}

internal static JStep M3779(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3780(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Time travel. (For each suspended card you own and each permanent you control with a time counter on it, you may add or remove a time counter.)")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3781(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Amount")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?39:25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("Amount")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",36);}
case 36:{f.Pc=40;continue;}
case 39:{f.Push(JValue.I(1));f.Pc=40;continue;}
case 40:{f.Locals[5]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",46);}
case 46:{f.Locals[6]=f.Pop();f.Pc=48;continue;}
case 48:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","TIME","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","TIME","Lforge/game/card/CounterEnumType;"));f.Pc=51;continue;}
case 51:{f.Locals[7]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{f.Locals[8]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[8]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?299:63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",70);}
case 70:{return rt.DynamicCall(f,"forge/game/ability/effects/TimeTravelEffect:3781:70:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",75);}
case 75:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",78);}
case 78:{f.Locals[9]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[9]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[2]);f.Pc=83;continue;}
case 83:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",89);}
case 89:{f.Push(f.Locals[7]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/card/CardPredicates","hasCounter","(Lforge/game/card/CounterType;)Ljava/util/function/Predicate;","invokestatic",94);}
case 94:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",97);}
case 97:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",100);}
case 100:{f.StackOp("pop");f.Pc=101;continue;}
case 101:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=104;continue;}
case 104:{f.StackOp("dup");f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",108);}
case 108:{f.Locals[10]=f.Pop();f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",113);}
case 113:{f.Push(JValue.R(rt.String("lblChooseaCard")));f.Pc=115;continue;}
case 115:{f.Push(JValue.I(0));f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",122);}
case 122:{f.Locals[11]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[6]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[9]);f.Pc=128;continue;}
case 128:{f.Push(JValue.I(0));f.Pc=129;continue;}
case 129:{f.Push(f.Locals[9]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",134);}
case 134:{f.Push(JValue.R(null));f.Pc=135;continue;}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[11]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[2]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(null));f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/player/PlayerController","chooseEntitiesForEffect","(Lforge/util/collect/FCollectionView;IILforge/game/player/DelayedReveal;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/Player;Ljava/util/Map;)Ljava/util/List;","invokevirtual",143);}
case 143:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",148);}
case 148:{f.Locals[12]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[12]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",157);}
case 157:{f.Pc=f.Pop().Int==0?285:160;continue;}
case 160:{f.Push(f.Locals[12]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",167);}
case 167:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=170;continue;}
case 170:{f.Locals[13]=f.Pop();f.Pc=172;continue;}
case 172:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",175);}
case 175:{f.Locals[14]=f.Pop();f.Pc=177;continue;}
case 177:{f.Push(f.Locals[14]);f.Pc=179;continue;}
case 179:{f.Push(JValue.R(rt.String("Target")));f.Pc=181;continue;}
case 181:{f.Push(f.Locals[13]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",188);}
case 188:{f.StackOp("pop");f.Pc=189;continue;}
case 189:{f.Push(f.Locals[14]);f.Pc=191;continue;}
case 191:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=193;continue;}
case 193:{f.Push(f.Locals[7]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",200);}
case 200:{f.StackOp("pop");f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",204);}
case 204:{f.Push(JValue.R(rt.String("lblWhatToDoWithTargetCounter")));f.Pc=206;continue;}
case 206:{f.Push(JValue.I(2));f.Pc=207;continue;}
case 207:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=210;continue;}
case 210:{f.StackOp("dup");f.Pc=211;continue;}
case 211:{f.Push(JValue.I(0));f.Pc=212;continue;}
case 212:{f.Push(f.Locals[7]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",219);}
case 219:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=220;continue;}
case 220:{f.StackOp("dup");f.Pc=221;continue;}
case 221:{f.Push(JValue.I(1));f.Pc=222;continue;}
case 222:{f.Push(f.Locals[13]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",227);}
case 227:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",231);}
case 231:{return rt.DynamicCall(f,"forge/game/ability/effects/TimeTravelEffect:3781:231:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",236);}
case 236:{f.Locals[11]=f.Pop();f.Pc=238;continue;}
case 238:{f.Push(f.Locals[6]);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[1]);f.Pc=241;continue;}
case 241:{f.Push(f.Locals[11]);f.Pc=243;continue;}
case 243:{if(!rt.StaticReady(f,"forge/game/player/PlayerController$BinaryChoiceType","AddOrRemove","Lforge/game/player/PlayerController$BinaryChoiceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerController$BinaryChoiceType","AddOrRemove","Lforge/game/player/PlayerController$BinaryChoiceType;"));f.Pc=246;continue;}
case 246:{f.Push(f.Locals[14]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/player/PlayerController","chooseBinary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/PlayerController$BinaryChoiceType;Ljava/util/Map;)Z","invokevirtual",251);}
case 251:{f.Locals[15]=f.Pop();f.Pc=253;continue;}
case 253:{f.Push(f.Locals[15]);f.Pc=255;continue;}
case 255:{f.Pc=f.Pop().Int==0?272:258;continue;}
case 258:{f.Push(f.Locals[13]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[7]);f.Pc=262;continue;}
case 262:{f.Push(JValue.I(1));f.Pc=263;continue;}
case 263:{f.Push(f.Locals[2]);f.Pc=264;continue;}
case 264:{f.Push(f.Locals[10]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",269);}
case 269:{f.Pc=282;continue;}
case 272:{f.Push(f.Locals[13]);f.Pc=274;continue;}
case 274:{f.Push(f.Locals[7]);f.Pc=276;continue;}
case 276:{f.Push(JValue.I(1));f.Pc=277;continue;}
case 277:{f.Push(f.Locals[2]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"forge/game/card/Card","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",281);}
case 281:{f.StackOp("pop");f.Pc=282;continue;}
case 282:{f.Pc=150;continue;}
case 285:{f.Push(f.Locals[10]);f.Pc=287;continue;}
case 287:{f.Push(f.Locals[4]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[1]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",293);}
case 293:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=296;continue;}
case 296:{f.Pc=56;continue;}
case 299:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
