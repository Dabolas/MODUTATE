// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C277{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DamagePreventEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3296,"forge/game/ability/effects/DamagePreventEffect","<init>","()V",1,1,1,new JHandler[]{},M3296));
c.Add(new JMethod(3297,"forge/game/ability/effects/DamagePreventEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,7,4,new JHandler[]{},M3297));
c.Add(new JMethod(3298,"forge/game/ability/effects/DamagePreventEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,9,6,new JHandler[]{},M3298));
c.Add(new JMethod(3299,"forge/game/ability/effects/DamagePreventEffect","addPreventNextDamage","(Lforge/game/spellability/SpellAbility;Lforge/game/GameEntity;I)V",10,17,6,new JHandler[]{},M3299));
}

internal static JStep M3296(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3297(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/DamagePreventEffect","getTargetEntities","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Prevent the next ")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("Amount")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",27);}
case 27:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",30);}
case 30:{f.StackOp("pop");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String(" damage that would be dealt ")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDividedAsYouChoose","()Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?55:45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("between ")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",51);}
case 51:{f.StackOp("pop");f.Pc=52;continue;}
case 52:{f.Pc=62;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("to ")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Push(JValue.I(0));f.Pc=63;continue;}
case 63:{f.Locals[4]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[4]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[3]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",73);}
case 73:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?165:76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{f.Pc=f.Pop().Int==0?88:81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String(" ")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",87);}
case 87:{f.StackOp("pop");f.Pc=88;continue;}
case 88:{f.Push(f.Locals[3]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",96);}
case 96:{f.Locals[5]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[5]);f.Pc=100;continue;}
case 100:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=103;continue;}
case 103:{f.Pc=f.Pop().Int==0?141:106;continue;}
case 106:{f.Push(f.Locals[5]);f.Pc=108;continue;}
case 108:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=111;continue;}
case 111:{f.Locals[6]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[6]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int==0?131:121;continue;}
case 121:{f.Push(f.Locals[2]);f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("Morph")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",127);}
case 127:{f.StackOp("pop");f.Pc=128;continue;}
case 128:{f.Pc=159;continue;}
case 131:{f.Push(f.Locals[2]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[6]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",137);}
case 137:{f.StackOp("pop");f.Pc=138;continue;}
case 138:{f.Pc=159;continue;}
case 141:{f.Push(f.Locals[5]);f.Pc=143;continue;}
case 143:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=146;continue;}
case 146:{f.Pc=f.Pop().Int==0?159:149;continue;}
case 149:{f.Push(f.Locals[2]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[5]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",155);}
case 155:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",158);}
case 158:{f.StackOp("pop");f.Pc=159;continue;}
case 159:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=162;continue;}
case 162:{f.Pc=65;continue;}
case 165:{f.Push(f.Locals[1]);f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("Radiance")));f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",171);}
case 171:{f.Pc=f.Pop().Int==0?235:174;continue;}
case 174:{f.Push(f.Locals[1]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",178);}
case 178:{f.Pc=f.Pop().Int==0?235:181;continue;}
case 181:{f.Push(f.Locals[2]);f.Pc=182;continue;}
case 182:{f.Push(JValue.R(rt.String(" and each other ")));f.Pc=184;continue;}
case 184:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",187);}
case 187:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",190);}
case 190:{f.Push(f.Locals[1]);f.Pc=191;continue;}
case 191:{f.Push(JValue.R(rt.String("ValidTgts")));f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",196);}
case 196:{return rt.Call(f,"forge/util/Lang","describeValidList","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",199);}
case 199:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",202);}
case 202:{f.Push(JValue.R(rt.String(" that shares a color with ")));f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",207);}
case 207:{f.StackOp("pop");f.Pc=208;continue;}
case 208:{f.Push(f.Locals[3]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",214);}
case 214:{f.Push(JValue.I(1));f.Pc=215;continue;}
case 215:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?228:218;continue;}
case 218:{f.Push(f.Locals[2]);f.Pc=219;continue;}
case 219:{f.Push(JValue.R(rt.String("them")));f.Pc=221;continue;}
case 221:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",224);}
case 224:{f.StackOp("pop");f.Pc=225;continue;}
case 225:{f.Pc=235;continue;}
case 228:{f.Push(f.Locals[2]);f.Pc=229;continue;}
case 229:{f.Push(JValue.R(rt.String("it")));f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",234);}
case 234:{f.StackOp("pop");f.Pc=235;continue;}
case 235:{f.Push(f.Locals[2]);f.Pc=236;continue;}
case 236:{f.Push(JValue.R(rt.String(" this turn.")));f.Pc=238;continue;}
case 238:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",241);}
case 241:{f.StackOp("pop");f.Pc=242;continue;}
case 242:{f.Push(f.Locals[2]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",246);}
case 246:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3298(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("Amount")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",20);}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("CardChoices")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int!=0?40:31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("PlayerChoices")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?153:40;continue;}
case 40:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=43;continue;}
case 43:{f.StackOp("dup");f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",47);}
case 47:{f.Locals[5]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("CardChoices")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int==0?89:58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",64);}
case 64:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",70);}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.String("CardChoices")));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",76);}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",80);}
case 80:{f.Push(f.Locals[2]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",85);}
case 85:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",88);}
case 88:{f.StackOp("pop");f.Pc=89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("PlayerChoices")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",95);}
case 95:{f.Pc=f.Pop().Int==0?115:98;continue;}
case 98:{f.Push(f.Locals[5]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("PlayerChoices")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",107);}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",111);}
case 111:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",114);}
case 114:{f.StackOp("pop");f.Pc=115;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("Random")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int==0?150:124;continue;}
case 124:{f.Push(f.Locals[5]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",129);}
case 129:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=132;continue;}
case 132:{f.Locals[6]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[4]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[6]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",143);}
case 143:{f.StackOp("pop");f.Pc=144;continue;}
case 144:{f.Push(f.Locals[2]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[6]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",150);}
case 150:{f.Pc=159;continue;}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/ability/effects/DamagePreventEffect","getTargetEntities","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",157);}
case 157:{f.Locals[4]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/card/CardUtil","getRadiance","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",163);}
case 163:{f.Locals[5]=f.Pop();f.Pc=165;continue;}
case 165:{f.Push(f.Locals[4]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",172);}
case 172:{f.Locals[6]=f.Pop();f.Pc=174;continue;}
case 174:{f.Push(f.Locals[6]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",181);}
case 181:{f.Pc=f.Pop().Int==0?275:184;continue;}
case 184:{f.Push(f.Locals[6]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",191);}
case 191:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=194;continue;}
case 194:{f.Locals[7]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[1]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",200);}
case 200:{f.Pc=f.Pop().Int==0?222:203;continue;}
case 203:{f.Push(f.Locals[1]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDividedAsYouChoose","()Z","invokevirtual",207);}
case 207:{f.Pc=f.Pop().Int==0?222:210;continue;}
case 210:{f.Push(f.Locals[1]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[7]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDividedValue","(Lforge/game/GameObject;)Ljava/lang/Integer;","invokevirtual",216);}
case 216:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",219);}
case 219:{f.Pc=223;continue;}
case 222:{f.Push(f.Locals[3]);f.Pc=223;continue;}
case 223:{f.Locals[3]=f.Pop();f.Pc=224;continue;}
case 224:{f.Push(f.Locals[7]);f.Pc=226;continue;}
case 226:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=229;continue;}
case 229:{f.Pc=f.Pop().Int==0?257:232;continue;}
case 232:{f.Push(f.Locals[7]);f.Pc=234;continue;}
case 234:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=237;continue;}
case 237:{f.Locals[8]=f.Pop();f.Pc=239;continue;}
case 239:{f.Push(f.Locals[8]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",244);}
case 244:{f.Pc=f.Pop().Int==0?272:247;continue;}
case 247:{f.Push(f.Locals[1]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[7]);f.Pc=250;continue;}
case 250:{f.Push(f.Locals[3]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/ability/effects/DamagePreventEffect","addPreventNextDamage","(Lforge/game/spellability/SpellAbility;Lforge/game/GameEntity;I)V","invokestatic",254);}
case 254:{f.Pc=272;continue;}
case 257:{f.Push(f.Locals[7]);f.Pc=259;continue;}
case 259:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=262;continue;}
case 262:{f.Pc=f.Pop().Int==0?272:265;continue;}
case 265:{f.Push(f.Locals[1]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[7]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[3]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/ability/effects/DamagePreventEffect","addPreventNextDamage","(Lforge/game/spellability/SpellAbility;Lforge/game/GameEntity;I)V","invokestatic",272);}
case 272:{f.Pc=174;continue;}
case 275:{f.Push(f.Locals[5]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",280);}
case 280:{f.Locals[6]=f.Pop();f.Pc=282;continue;}
case 282:{f.Push(f.Locals[6]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",289);}
case 289:{f.Pc=f.Pop().Int==0?322:292;continue;}
case 292:{f.Push(f.Locals[6]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",299);}
case 299:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=302;continue;}
case 302:{f.Locals[7]=f.Pop();f.Pc=304;continue;}
case 304:{f.Push(f.Locals[7]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",309);}
case 309:{f.Pc=f.Pop().Int==0?319:312;continue;}
case 312:{f.Push(f.Locals[1]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[7]);f.Pc=315;continue;}
case 315:{f.Push(f.Locals[3]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/ability/effects/DamagePreventEffect","addPreventNextDamage","(Lforge/game/spellability/SpellAbility;Lforge/game/GameEntity;I)V","invokestatic",319);}
case 319:{f.Pc=282;continue;}
case 322:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3299(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",15);}
case 15:{f.Locals[5]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",21);}
case 21:{return rt.DynamicCall(f,"forge/game/ability/effects/DamagePreventEffect:3299:21:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",26);}
case 26:{f.Locals[6]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Locals[7]=f.Pop();f.Pc=34;continue;}
case 34:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("Event$ DamageDone | ActiveZones$ Command | ValidTarget$ ")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",43);}
case 43:{f.Locals[8]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[8]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=51;continue;}
case 51:{f.Pc=f.Pop().Int==0?59:54;continue;}
case 54:{f.Push(JValue.R(rt.String("Card.IsRemembered")));f.Pc=56;continue;}
case 56:{f.Pc=61;continue;}
case 59:{f.Push(JValue.R(rt.String("Player.IsRemembered")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{f.Push(f.Locals[8]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String(" | PreventionEffect$ NextN | Description$ Prevent the next ")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",72);}
case 72:{f.Push(f.Locals[2]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",76);}
case 76:{f.Push(JValue.R(rt.String(" damage.")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",81);}
case 81:{f.StackOp("pop");f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("DB$ ReplaceDamage | Amount$ ShieldAmount")));f.Pc=84;continue;}
case 84:{f.Locals[9]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[6]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/ability/effects/DamagePreventEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Lforge/game/card/Card;","invokestatic",96);}
case 96:{f.Locals[10]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[10]);f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.String("ShieldAmount")));f.Pc=102;continue;}
case 102:{f.Push(f.Locals[2]);f.Pc=103;continue;}
case 103:{return rt.DynamicCall(f,"forge/game/ability/effects/DamagePreventEffect:3299:103:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",108);}
case 108:{return rt.Call(f,"forge/game/card/Card","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",111);}
case 111:{f.Push(f.Locals[10]);f.Pc=113;continue;}
case 113:{f.Push(JValue.R(rt.String("PreventedDamage")));f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("Number$0")));f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/card/Card","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",122);}
case 122:{f.Push(f.Locals[10]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",128);}
case 128:{f.Push(f.Locals[9]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[10]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",135);}
case 135:{f.Locals[11]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("PreventionSubAbility")));f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",144);}
case 144:{f.Pc=f.Pop().Int==0?325:147;continue;}
case 147:{f.Push(f.Locals[0]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[0]);f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.String("PreventionSubAbility")));f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",155);}
case 155:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",158);}
case 158:{f.Locals[12]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{f.Push(JValue.R(rt.String("ShieldEffectTarget")));f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",167);}
case 167:{f.Pc=f.Pop().Int==0?287:170;continue;}
case 170:{f.Push(f.Locals[3]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[0]);f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.String("ShieldEffectTarget")));f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",178);}
case 178:{f.Push(f.Locals[0]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedEntities","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",182);}
case 182:{f.Locals[13]=f.Pop();f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("")));f.Pc=187;continue;}
case 187:{f.Locals[14]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[13]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",196);}
case 196:{f.Locals[15]=f.Pop();f.Pc=198;continue;}
case 198:{f.Push(f.Locals[15]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",205);}
case 205:{f.Pc=f.Pop().Int==0?275:208;continue;}
case 208:{f.Push(f.Locals[15]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",215);}
case 215:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=218;continue;}
case 218:{f.Locals[16]=f.Pop();f.Pc=220;continue;}
case 220:{f.Push(f.Locals[16]);f.Pc=222;continue;}
case 222:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=225;continue;}
case 225:{f.Pc=f.Pop().Int==0?249:228;continue;}
case 228:{f.Push(f.Locals[16]);f.Pc=230;continue;}
case 230:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",236);}
case 236:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",239);}
case 239:{return rt.DynamicCall(f,"forge/game/ability/effects/DamagePreventEffect:3299:239:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",244);}
case 244:{f.Locals[14]=f.Pop();f.Pc=246;continue;}
case 246:{f.Pc=272;continue;}
case 249:{f.Push(f.Locals[16]);f.Pc=251;continue;}
case 251:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=254;continue;}
case 254:{f.Pc=f.Pop().Int==0?272:257;continue;}
case 257:{f.Push(f.Locals[16]);f.Pc=259;continue;}
case 259:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",265);}
case 265:{return rt.DynamicCall(f,"forge/game/ability/effects/DamagePreventEffect:3299:265:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",270);}
case 270:{f.Locals[14]=f.Pop();f.Pc=272;continue;}
case 272:{f.Pc=198;continue;}
case 275:{f.Push(f.Locals[12]);f.Pc=277;continue;}
case 277:{f.Push(JValue.R(rt.String("ShieldEffectTarget")));f.Pc=280;continue;}
case 280:{f.Push(f.Locals[14]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",285);}
case 285:{f.Locals[12]=f.Pop();f.Pc=287;continue;}
case 287:{f.Push(f.Locals[12]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[10]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",294);}
case 294:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=297;continue;}
case 297:{f.Locals[13]=f.Pop();f.Pc=299;continue;}
case 299:{f.Push(f.Locals[11]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[13]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",306);}
case 306:{f.Push(f.Locals[8]);f.Pc=308;continue;}
case 308:{f.Push(JValue.R(rt.String(" ")));f.Pc=310;continue;}
case 310:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",313);}
case 313:{f.Push(f.Locals[13]);f.Pc=315;continue;}
case 315:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/spellability/AbilitySub","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",321);}
case 321:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",324);}
case 324:{f.StackOp("pop");f.Pc=325;continue;}
case 325:{f.Push(f.Locals[8]);f.Pc=327;continue;}
case 327:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",330);}
case 330:{f.Locals[12]=f.Pop();f.Pc=332;continue;}
case 332:{f.Push(f.Locals[12]);f.Pc=334;continue;}
case 334:{f.Push(f.Locals[10]);f.Pc=336;continue;}
case 336:{f.Push(JValue.I(1));f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",340);}
case 340:{f.Locals[13]=f.Pop();f.Pc=342;continue;}
case 342:{f.Push(f.Locals[13]);f.Pc=344;continue;}
case 344:{f.Push(f.Locals[11]);f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",349);}
case 349:{f.Push(f.Locals[10]);f.Pc=351;continue;}
case 351:{f.Push(f.Locals[13]);f.Pc=353;continue;}
case 353:{return rt.Call(f,"forge/game/card/Card","addReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)Lforge/game/replacement/ReplacementEffect;","invokevirtual",356);}
case 356:{f.StackOp("pop");f.Pc=357;continue;}
case 357:{f.Push(f.Locals[1]);f.Pc=358;continue;}
case 358:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=361;continue;}
case 361:{f.Pc=f.Pop().Int==0?372:364;continue;}
case 364:{f.Push(f.Locals[10]);f.Pc=366;continue;}
case 366:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=369;continue;}
case 369:{return rt.Call(f,"forge/game/ability/effects/DamagePreventEffect","addForgetOnMovedTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",372);}
case 372:{f.Push(f.Locals[4]);f.Pc=374;continue;}
case 374:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",377);}
case 377:{f.Push(f.Locals[10]);f.Pc=379;continue;}
case 379:{f.Push(f.Locals[0]);f.Pc=380;continue;}
case 380:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",383);}
case 383:{f.Push(f.Locals[1]);f.Pc=384;continue;}
case 384:{return rt.Call(f,"forge/game/GameEntity","getView","()Lforge/game/GameEntityView;","invokevirtual",387);}
case 387:{f.Push(f.Locals[1]);f.Pc=388;continue;}
case 388:{return rt.Call(f,"forge/game/GameEntityView","updatePreventNextDamage","(Lforge/game/GameEntity;)V","invokevirtual",391);}
case 391:{f.Push(f.Locals[1]);f.Pc=392;continue;}
case 392:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=395;continue;}
case 395:{f.Pc=f.Pop().Int==0?414:398;continue;}
case 398:{f.Push(f.Locals[4]);f.Pc=400;continue;}
case 400:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventPlayerStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventPlayerStatsChanged")));f.Pc=403;continue;}
case 403:{f.StackOp("dup");f.Pc=404;continue;}
case 404:{f.Push(f.Locals[1]);f.Pc=405;continue;}
case 405:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=408;continue;}
case 408:{return rt.Call(f,"forge/game/event/GameEventPlayerStatsChanged","<init>","(Lforge/game/player/Player;)V","invokespecial",411);}
case 411:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",414);}
case 414:{f.Push(f.Locals[4]);f.Pc=416;continue;}
case 416:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",419);}
case 419:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/DamagePreventEffect$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/DamagePreventEffect$1")));f.Pc=422;continue;}
case 422:{f.StackOp("dup");f.Pc=423;continue;}
case 423:{f.Push(f.Locals[4]);f.Pc=425;continue;}
case 425:{f.Push(f.Locals[10]);f.Pc=427;continue;}
case 427:{f.Push(f.Locals[1]);f.Pc=428;continue;}
case 428:{return rt.Call(f,"forge/game/ability/effects/DamagePreventEffect$1","<init>","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/GameEntity;)V","invokespecial",431);}
case 431:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",434);}
case 434:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
