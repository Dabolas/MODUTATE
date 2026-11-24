// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C351{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/PlayLandVariantEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3557,"forge/game/ability/effects/PlayLandVariantEffect","<init>","()V",1,1,1,new JHandler[]{},M3557));
c.Add(new JMethod(3558,"forge/game/ability/effects/PlayLandVariantEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,12,4,new JHandler[]{},M3558));
c.Add(new JMethod(3559,"forge/game/ability/effects/PlayLandVariantEffect","lambda$resolve$0","(Ljava/util/List;Lforge/item/PaperCard;)Z",4106,2,2,new JHandler[]{},M3559));
}

internal static JStep M3557(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3558(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Clone")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Locals[5]=f.Pop();f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",27);}
case 27:{return rt.Call(f,"forge/StaticData","ensureAllCardsLoaded","()V","invokevirtual",30);}
case 30:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",33);}
case 33:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",36);}
case 36:{return rt.Call(f,"forge/card/CardDb","streamUniqueCards","()Ljava/util/stream/Stream;","invokevirtual",39);}
case 39:{f.Locals[6]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("BasicLand")));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[5]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?63:51;continue;}
case 51:{f.Push(f.Locals[6]);f.Pc=53;continue;}
case 53:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_BASIC_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_BASIC_LAND","Ljava/util/function/Predicate;"));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",61);}
case 61:{f.Locals[6]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",67);}
case 67:{f.Locals[7]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[7]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/card/ColorSet","isColorless","()Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int==0?78:77;continue;}
case 77:{return JStep.ReturnVoid;}
case 78:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",81);}
case 81:{f.Locals[8]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{f.Locals[9]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[9]);f.Pc=88;continue;}
case 88:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=91;continue;}
case 91:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=92;continue;}
case 92:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?157:95;continue;}
case 95:{f.Push(f.Locals[7]);f.Pc=97;continue;}
case 97:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=100;continue;}
case 100:{f.Push(f.Locals[9]);f.Pc=102;continue;}
case 102:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?147:109;continue;}
case 109:{f.Push(f.Locals[8]);f.Pc=111;continue;}
case 111:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"));f.Pc=114;continue;}
case 114:{f.Push(f.Locals[9]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"com/google/common/collect/ImmutableList","get","(I)Ljava/lang/Object;","invokevirtual",119);}
case 119:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",127);}
case 127:{f.StackOp("pop");f.Pc=128;continue;}
case 128:{f.Push(f.Locals[8]);f.Pc=130;continue;}
case 130:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","SNOW_LANDS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","SNOW_LANDS","Lcom/google/common/collect/ImmutableList;"));f.Pc=133;continue;}
case 133:{f.Push(f.Locals[9]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"com/google/common/collect/ImmutableList","get","(I)Ljava/lang/Object;","invokevirtual",138);}
case 138:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",146);}
case 146:{f.StackOp("pop");f.Pc=147;continue;}
case 147:{f.Push(f.Locals[9]);f.Pc=149;continue;}
case 149:{f.Push(JValue.I(1));f.Pc=150;continue;}
case 150:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=151;continue;}
case 151:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=152;continue;}
case 152:{f.Locals[9]=f.Pop();f.Pc=154;continue;}
case 154:{f.Pc=86;continue;}
case 157:{f.Push(f.Locals[6]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[8]);f.Pc=161;continue;}
case 161:{return rt.DynamicCall(f,"forge/game/ability/effects/PlayLandVariantEffect:3558:161:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/List;)Ljava/util/function/Predicate;",166);}
case 166:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",171);}
case 171:{f.Locals[6]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[6]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",178);}
case 178:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",183);}
case 183:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=186;continue;}
case 186:{f.Locals[9]=f.Pop();f.Pc=188;continue;}
case 188:{f.Push(f.Locals[9]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",195);}
case 195:{f.Pc=f.Pop().Int==0?199:198;continue;}
case 198:{return JStep.ReturnVoid;}
case 199:{f.Push(f.Locals[9]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",204);}
case 204:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=207;continue;}
case 207:{f.Locals[11]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[11]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[3]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[4]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/card/CardFactory","getCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;Lforge/game/Game;)Lforge/game/card/Card;","invokestatic",217);}
case 217:{f.Locals[10]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[9]);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[11]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",228);}
case 228:{f.StackOp("pop");f.Pc=229;continue;}
case 229:{f.Push(f.Locals[3]);f.Pc=230;continue;}
case 230:{f.Push(f.Locals[10]);f.Pc=232;continue;}
case 232:{f.Push(JValue.I(0));f.Pc=233;continue;}
case 233:{f.Push(f.Locals[10]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/card/Card","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",238);}
case 238:{return rt.Call(f,"forge/game/player/Player","canPlayLand","(Lforge/game/card/Card;ZLforge/game/spellability/SpellAbility;)Z","invokevirtual",241);}
case 241:{f.Pc=f.Pop().Int==0?188:244;continue;}
case 244:{f.Push(f.Locals[2]);f.Pc=245;continue;}
case 245:{f.Push(f.Locals[10]);f.Pc=247;continue;}
case 247:{f.Push(f.Locals[2]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[1]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/card/CardFactory","getCloneStates","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCloneStates;","invokestatic",252);}
case 252:{f.Push(f.Locals[4]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",257);}
case 257:{return rt.Call(f,"forge/game/card/Card","addCloneState","(Lforge/game/card/CardCloneStates;J)V","invokevirtual",260);}
case 260:{f.Push(f.Locals[2]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",264);}
case 264:{f.Push(f.Locals[3]);f.Pc=265;continue;}
case 265:{f.Push(f.Locals[2]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[1]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/game/player/Player","playLand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",270);}
case 270:{f.StackOp("pop");f.Pc=271;continue;}
case 271:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3559(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
