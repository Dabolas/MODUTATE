// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C219{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/CamouflageEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3077,"forge/game/ability/effects/CamouflageEffect","<init>","()V",1,1,1,new JHandler[]{},M3077));
c.Add(new JMethod(3078,"forge/game/ability/effects/CamouflageEffect","randomizeBlockers","(Lforge/game/spellability/SpellAbility;Lforge/game/combat/Combat;Lforge/game/player/Player;Lforge/game/player/Player;Ljava/util/List;Ljava/util/List;)V",2,12,9,new JHandler[]{},M3078));
c.Add(new JMethod(3079,"forge/game/ability/effects/CamouflageEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,17,12,new JHandler[]{},M3079));
c.Add(new JMethod(3080,"forge/game/ability/effects/CamouflageEffect","lambda$resolve$0","(Lforge/game/card/Card;)Z",4106,1,1,new JHandler[]{},M3080));
}

internal static JStep M3077(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3078(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[5]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardLists","shuffle","(Ljava/util/List;)V","invokestatic",5);}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Locals[7]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[7]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[5]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",17);}
case 17:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?243:20;continue;}
case 20:{f.Push(f.Locals[5]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[7]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[8]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[6]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[7]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{f.Locals[9]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[9]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",53);}
case 53:{f.Push(JValue.I(1));f.Pc=54;continue;}
case 54:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=55;continue;}
case 55:{f.Locals[10]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[10]);f.Pc=59;continue;}
case 59:{f.Pc=f.Pop().Int<0?99:62;continue;}
case 62:{f.Push(f.Locals[9]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[10]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",69);}
case 69:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=72;continue;}
case 72:{f.Locals[11]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[8]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[11]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/combat/Combat;)Z","invokestatic",82);}
case 82:{f.Pc=f.Pop().Int!=0?93:85;continue;}
case 85:{f.Push(f.Locals[9]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[10]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/card/CardCollection","remove","(I)Ljava/lang/Object;","invokevirtual",92);}
case 92:{f.StackOp("pop");f.Pc=93;continue;}
case 93:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(-1)));f.Pc=96;continue;}
case 96:{f.Pc=57;continue;}
case 99:{f.Push(f.Locals[9]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",104);}
case 104:{f.Push(f.Locals[8]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[4]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/combat/CombatUtil","getMinNumBlockersForAttacker","(Lforge/game/card/Card;Lforge/game/player/Player;)I","invokestatic",111);}
case 111:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?117:114;continue;}
case 114:{f.Pc=237;continue;}
case 117:{f.Push(f.Locals[8]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[4]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantAttackBlock","getMinMaxBlocker","(Lforge/game/card/Card;Lforge/game/player/Player;)Lorg/apache/commons/lang3/tuple/Pair;","invokestatic",124);}
case 124:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",127);}
case 127:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",133);}
case 133:{f.Push(f.Locals[9]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",138);}
case 138:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?197:141;continue;}
case 141:{f.Push(f.Locals[3]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",145);}
case 145:{f.Push(f.Locals[9]);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[1]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",151);}
case 151:{f.Push(JValue.R(rt.String("lblChooseBlockerForAttacker")));f.Pc=153;continue;}
case 153:{f.Push(JValue.I(1));f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=157;continue;}
case 157:{f.StackOp("dup");f.Pc=158;continue;}
case 158:{f.Push(JValue.I(0));f.Pc=159;continue;}
case 159:{f.Push(f.Locals[8]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",164);}
case 164:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",168);}
case 168:{f.Push(JValue.I(1));f.Pc=169;continue;}
case 169:{f.Push(JValue.I(1));f.Pc=170;continue;}
case 170:{f.Push(JValue.I(0));f.Pc=171;continue;}
case 171:{f.Push(JValue.R(null));f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",175);}
case 175:{f.Push(JValue.I(0));f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",181);}
case 181:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=184;continue;}
case 184:{f.Locals[10]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(f.Locals[2]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[8]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[10]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/combat/Combat","addBlocker","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",194);}
case 194:{f.Pc=237;continue;}
case 197:{f.Push(f.Locals[9]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",202);}
case 202:{f.Locals[10]=f.Pop();f.Pc=204;continue;}
case 204:{f.Push(f.Locals[10]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",211);}
case 211:{f.Pc=f.Pop().Int==0?237:214;continue;}
case 214:{f.Push(f.Locals[10]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",221);}
case 221:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=224;continue;}
case 224:{f.Locals[11]=f.Pop();f.Pc=226;continue;}
case 226:{f.Push(f.Locals[2]);f.Pc=227;continue;}
case 227:{f.Push(f.Locals[8]);f.Pc=229;continue;}
case 229:{f.Push(f.Locals[11]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/combat/Combat","addBlocker","(Lforge/game/card/Card;Lforge/game/card/Card;)V","invokevirtual",234);}
case 234:{f.Pc=204;continue;}
case 237:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=240;continue;}
case 240:{f.Pc=8;continue;}
case 243:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3079(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/ability/effects/CamouflageEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",9);}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",13);}
case 13:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=16;continue;}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Defender")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",28);}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",32);}
case 32:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=35;continue;}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/game/Game","getCombat","()Lforge/game/combat/Combat;","invokevirtual",44);}
case 44:{f.Locals[5]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/combat/Combat","getAttackers","()Lforge/game/card/CardCollection;","invokevirtual",51);}
case 51:{f.Locals[6]=f.Pop();f.Pc=53;continue;}
case 53:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",60);}
case 60:{f.Locals[7]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/player/Player","isAI","()Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?175:69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",73);}
case 73:{f.Push(f.Locals[4]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[5]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/player/PlayerController","declareBlockers","(Lforge/game/player/Player;Lforge/game/combat/Combat;)V","invokevirtual",80);}
case 80:{f.Push(f.Locals[6]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",87);}
case 87:{f.Locals[8]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[8]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",96);}
case 96:{f.Pc=f.Pop().Int==0?172:99;continue;}
case 99:{f.Push(f.Locals[8]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",106);}
case 106:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=109;continue;}
case 109:{f.Locals[9]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[5]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[9]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/combat/Combat","getBlockers","(Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",118);}
case 118:{f.Locals[10]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[7]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[10]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",129);}
case 129:{f.StackOp("pop");f.Pc=130;continue;}
case 130:{f.Push(f.Locals[10]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",135);}
case 135:{f.Locals[11]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[11]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",144);}
case 144:{f.Pc=f.Pop().Int==0?169:147;continue;}
case 147:{f.Push(f.Locals[11]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",154);}
case 154:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=157;continue;}
case 157:{f.Locals[12]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[5]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[12]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/combat/Combat","removeFromCombat","(Lforge/game/card/Card;)V","invokevirtual",166);}
case 166:{f.Pc=137;continue;}
case 169:{f.Pc=89;continue;}
case 172:{f.Pc=419;continue;}
case 175:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=178;continue;}
case 178:{f.StackOp("dup");f.Pc=179;continue;}
case 179:{f.Push(f.Locals[4]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",184);}
case 184:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",187);}
case 187:{f.Locals[8]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[8]);f.Pc=191;continue;}
case 191:{return rt.DynamicCall(f,"forge/game/ability/effects/CamouflageEffect:3079:191:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",196);}
case 196:{return rt.Call(f,"forge/game/card/CardCollection","removeIf","(Ljava/util/function/Predicate;)Z","invokevirtual",199);}
case 199:{f.StackOp("pop");f.Pc=200;continue;}
case 200:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=203;continue;}
case 203:{f.StackOp("dup");f.Pc=204;continue;}
case 204:{f.Push(f.Locals[8]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",209);}
case 209:{f.Push(JValue.I(0));f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",213);}
case 213:{return rt.Call(f,"java/util/Collections","nCopies","(ILjava/lang/Object;)Ljava/util/List;","invokestatic",216);}
case 216:{return rt.Call(f,"java/util/ArrayList","<init>","(Ljava/util/Collection;)V","invokespecial",219);}
case 219:{f.Locals[9]=f.Pop();f.Pc=221;continue;}
case 221:{f.Push(JValue.I(0));f.Pc=222;continue;}
case 222:{f.Locals[10]=f.Pop();f.Pc=224;continue;}
case 224:{f.Push(f.Locals[10]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[6]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",233);}
case 233:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?419:236;continue;}
case 236:{f.Push(f.Locals[8]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",241);}
case 241:{f.Locals[11]=f.Pop();f.Pc=243;continue;}
case 243:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=246;continue;}
case 246:{f.StackOp("dup");f.Pc=247;continue;}
case 247:{f.Push(f.Locals[3]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",251);}
case 251:{f.Push(f.Locals[8]);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[1]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",257);}
case 257:{f.Push(JValue.R(rt.String("lblChooseBlockersForPile")));f.Pc=259;continue;}
case 259:{f.Push(JValue.I(1));f.Pc=260;continue;}
case 260:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=263;continue;}
case 263:{f.StackOp("dup");f.Pc=264;continue;}
case 264:{f.Push(JValue.I(0));f.Pc=265;continue;}
case 265:{f.Push(f.Locals[10]);f.Pc=267;continue;}
case 267:{f.Push(JValue.I(1));f.Pc=268;continue;}
case 268:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=269;continue;}
case 269:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",272);}
case 272:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",276);}
case 276:{f.Push(JValue.I(0));f.Pc=277;continue;}
case 277:{f.Push(f.Locals[11]);f.Pc=279;continue;}
case 279:{f.Push(JValue.I(0));f.Pc=280;continue;}
case 280:{f.Push(JValue.R(null));f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",284);}
case 284:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",287);}
case 287:{f.Locals[12]=f.Pop();f.Pc=289;continue;}
case 289:{f.Push(f.Locals[7]);f.Pc=291;continue;}
case 291:{f.Push(f.Locals[12]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",298);}
case 298:{f.StackOp("pop");f.Pc=299;continue;}
case 299:{f.Push(f.Locals[12]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",304);}
case 304:{f.Locals[13]=f.Pop();f.Pc=306;continue;}
case 306:{f.Push(f.Locals[13]);f.Pc=308;continue;}
case 308:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",313);}
case 313:{f.Pc=f.Pop().Int==0?413:316;continue;}
case 316:{f.Push(f.Locals[13]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",323);}
case 323:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=326;continue;}
case 326:{f.Locals[14]=f.Pop();f.Pc=328;continue;}
case 328:{f.Push(f.Locals[8]);f.Pc=330;continue;}
case 330:{f.Push(f.Locals[14]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/game/card/CardCollection","indexOf","(Ljava/lang/Object;)I","invokevirtual",335);}
case 335:{f.Locals[15]=f.Pop();f.Pc=337;continue;}
case 337:{f.Push(f.Locals[9]);f.Pc=339;continue;}
case 339:{f.Push(f.Locals[15]);f.Pc=341;continue;}
case 341:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",346);}
case 346:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=349;continue;}
case 349:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",352);}
case 352:{f.Push(JValue.I(1));f.Pc=353;continue;}
case 353:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=354;continue;}
case 354:{f.Locals[16]=f.Pop();f.Pc=356;continue;}
case 356:{f.Push(f.Locals[14]);f.Pc=358;continue;}
case 358:{return rt.Call(f,"forge/game/card/Card","canBlockAny","()Z","invokevirtual",361);}
case 361:{f.Pc=f.Pop().Int!=0?395:364;continue;}
case 364:{f.Push(f.Locals[14]);f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/game/card/Card","canBlockAdditional","()I","invokevirtual",369);}
case 369:{f.Push(f.Locals[16]);f.Pc=371;continue;}
case 371:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?395:374;continue;}
case 374:{f.Push(f.Locals[8]);f.Pc=376;continue;}
case 376:{f.Push(f.Locals[15]);f.Pc=378;continue;}
case 378:{return rt.Call(f,"forge/game/card/CardCollection","remove","(I)Ljava/lang/Object;","invokevirtual",381);}
case 381:{f.StackOp("pop");f.Pc=382;continue;}
case 382:{f.Push(f.Locals[9]);f.Pc=384;continue;}
case 384:{f.Push(f.Locals[15]);f.Pc=386;continue;}
case 386:{return rt.Call(f,"java/util/List","remove","(I)Ljava/lang/Object;","invokeinterface",391);}
case 391:{f.StackOp("pop");f.Pc=392;continue;}
case 392:{f.Pc=410;continue;}
case 395:{f.Push(f.Locals[9]);f.Pc=397;continue;}
case 397:{f.Push(f.Locals[15]);f.Pc=399;continue;}
case 399:{f.Push(f.Locals[16]);f.Pc=401;continue;}
case 401:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",404);}
case 404:{return rt.Call(f,"java/util/List","set","(ILjava/lang/Object;)Ljava/lang/Object;","invokeinterface",409);}
case 409:{f.StackOp("pop");f.Pc=410;continue;}
case 410:{f.Pc=306;continue;}
case 413:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=416;continue;}
case 416:{f.Pc=224;continue;}
case 419:{f.Push(f.Locals[0]);f.Pc=420;continue;}
case 420:{f.Push(f.Locals[1]);f.Pc=421;continue;}
case 421:{f.Push(f.Locals[5]);f.Pc=423;continue;}
case 423:{f.Push(f.Locals[3]);f.Pc=424;continue;}
case 424:{f.Push(f.Locals[4]);f.Pc=426;continue;}
case 426:{f.Push(f.Locals[6]);f.Pc=428;continue;}
case 428:{f.Push(f.Locals[7]);f.Pc=430;continue;}
case 430:{return rt.Call(f,"forge/game/ability/effects/CamouflageEffect","randomizeBlockers","(Lforge/game/spellability/SpellAbility;Lforge/game/combat/Combat;Lforge/game/player/Player;Lforge/game/player/Player;Ljava/util/List;Ljava/util/List;)V","invokevirtual",433);}
case 433:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3080(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/combat/CombatUtil","canBlock","(Lforge/game/card/Card;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
