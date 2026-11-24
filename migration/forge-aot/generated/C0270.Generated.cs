// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C270{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/CountersPutOrRemoveEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3272,"forge/game/ability/effects/CountersPutOrRemoveEffect","<init>","()V",1,1,1,new JHandler[]{},M3272));
c.Add(new JMethod(3273,"forge/game/ability/effects/CountersPutOrRemoveEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,5,3,new JHandler[]{},M3273));
c.Add(new JMethod(3274,"forge/game/ability/effects/CountersPutOrRemoveEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,14,9,new JHandler[]{},M3274));
c.Add(new JMethod(3275,"forge/game/ability/effects/CountersPutOrRemoveEffect","addOrRemoveCounter","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/card/CounterType;ILforge/game/GameEntityCounterTable;Lforge/game/player/Player;)V",2,19,6,new JHandler[]{},M3275));
}

internal static JStep M3272(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3273(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("AddConditionSVar")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?12:9;continue;}
case 9:{f.Push(JValue.R(rt.String("Add StackDescription for AddOrRemoveCounter line with condition!")));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
case 12:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("DefinedPlayer")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int==0?52:29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",33);}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("DefinedPlayer")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",39);}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",43);}
case 43:{return rt.Call(f,"forge/game/player/PlayerCollection","getFirst","()Ljava/lang/Object;","invokevirtual",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Pc=56;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",56);}
case 56:{f.Locals[3]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",62);}
case 62:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?128:75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",81);}
case 81:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",84);}
case 84:{f.Locals[4]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String(" puts a ")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",92);}
case 92:{f.Push(f.Locals[4]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",99);}
case 99:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",102);}
case 102:{f.StackOp("pop");f.Pc=103;continue;}
case 103:{f.Push(f.Locals[2]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String(" counter on or removes a ")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",109);}
case 109:{f.Push(f.Locals[4]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",116);}
case 116:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",119);}
case 119:{f.Push(JValue.R(rt.String(" counter from ")));f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",124);}
case 124:{f.StackOp("pop");f.Pc=125;continue;}
case 125:{f.Pc=135;continue;}
case 128:{f.Push(f.Locals[2]);f.Pc=129;continue;}
case 129:{f.Push(JValue.R(rt.String(" removes a counter from or puts another of those counters on ")));f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",134);}
case 134:{f.StackOp("pop");f.Pc=135;continue;}
case 135:{f.Push(f.Locals[2]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/ability/effects/CountersPutOrRemoveEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",140);}
case 140:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",143);}
case 143:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",146);}
case 146:{f.Push(JValue.R(rt.String(".")));f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",151);}
case 151:{f.StackOp("pop");f.Pc=152;continue;}
case 152:{f.Push(f.Locals[2]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",156);}
case 156:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3274(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("CounterNum")));f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("1")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Int>0?31:30;continue;}
case 30:{return JStep.ReturnVoid;}
case 31:{f.Push(JValue.R(null));f.Pc=32;continue;}
case 32:{f.Locals[5]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?54:43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",49);}
case 49:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",52);}
case 52:{f.Locals[5]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("DefinedPlayer")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",61);}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",65);}
case 65:{return rt.Call(f,"forge/game/player/PlayerCollection","getFirst","()Ljava/lang/Object;","invokevirtual",68);}
case 68:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=71;continue;}
case 71:{f.Locals[6]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("EachExistingCounter")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",79);}
case 79:{f.Locals[7]=f.Pop();f.Pc=81;continue;}
case 81:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=84;continue;}
case 84:{f.StackOp("dup");f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",88);}
case 88:{f.Locals[8]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/ability/effects/CountersPutOrRemoveEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",94);}
case 94:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",97);}
case 97:{f.Locals[9]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[9]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",106);}
case 106:{f.Pc=f.Pop().Int==0?324:109;continue;}
case 109:{f.Push(f.Locals[9]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",116);}
case 116:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=119;continue;}
case 119:{f.Locals[10]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[3]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[10]);f.Pc=124;continue;}
case 124:{f.Push(JValue.R(null));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",128);}
case 128:{f.Locals[11]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[11]);f.Pc=132;continue;}
case 132:{f.Pc=f.Pop().Reference==null?99:135;continue;}
case 135:{f.Push(f.Locals[10]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[11]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",142);}
case 142:{f.Pc=f.Pop().Int!=0?148:145;continue;}
case 145:{f.Pc=99;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.String("Optional")));f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",154);}
case 154:{f.Pc=f.Pop().Int==0?206:157;continue;}
case 157:{f.Push(f.Locals[6]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",162);}
case 162:{f.Push(f.Locals[1]);f.Pc=163;continue;}
case 163:{f.Push(JValue.R(null));f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",167);}
case 167:{f.Push(JValue.R(rt.String("lblWouldYouLikePutRemoveCounters")));f.Pc=169;continue;}
case 169:{f.Push(JValue.I(2));f.Pc=170;continue;}
case 170:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=173;continue;}
case 173:{f.StackOp("dup");f.Pc=174;continue;}
case 174:{f.Push(JValue.I(0));f.Pc=175;continue;}
case 175:{f.Push(f.Locals[5]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",182);}
case 182:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=183;continue;}
case 183:{f.StackOp("dup");f.Pc=184;continue;}
case 184:{f.Push(JValue.I(1));f.Pc=185;continue;}
case 185:{f.Push(f.Locals[11]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",190);}
case 190:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",194);}
case 194:{f.Push(f.Locals[11]);f.Pc=196;continue;}
case 196:{f.Push(JValue.R(null));f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",200);}
case 200:{f.Pc=f.Pop().Int!=0?206:203;continue;}
case 203:{f.Pc=99;continue;}
case 206:{f.Push(f.Locals[11]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/card/Card","hasCounters","()Z","invokevirtual",211);}
case 211:{f.Pc=f.Pop().Int==0?298:214;continue;}
case 214:{f.Push(f.Locals[7]);f.Pc=216;continue;}
case 216:{f.Pc=f.Pop().Int==0?280:219;continue;}
case 219:{f.Push(f.Locals[11]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"forge/game/card/Card","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",224);}
case 224:{return rt.Call(f,"com/google/common/collect/Multiset","elementSet","()Ljava/util/Set;","invokeinterface",229);}
case 229:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",232);}
case 232:{return rt.Call(f,"java/util/ArrayList","iterator","()Ljava/util/Iterator;","invokevirtual",235);}
case 235:{f.Locals[12]=f.Pop();f.Pc=237;continue;}
case 237:{f.Push(f.Locals[12]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",244);}
case 244:{f.Pc=f.Pop().Int==0?277:247;continue;}
case 247:{f.Push(f.Locals[12]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",254);}
case 254:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=257;continue;}
case 257:{f.Locals[13]=f.Pop();f.Pc=259;continue;}
case 259:{f.Push(f.Locals[0]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[1]);f.Pc=261;continue;}
case 261:{f.Push(f.Locals[11]);f.Pc=263;continue;}
case 263:{f.Push(f.Locals[13]);f.Pc=265;continue;}
case 265:{f.Push(f.Locals[4]);f.Pc=267;continue;}
case 267:{f.Push(f.Locals[8]);f.Pc=269;continue;}
case 269:{f.Push(f.Locals[6]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/game/ability/effects/CountersPutOrRemoveEffect","addOrRemoveCounter","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/card/CounterType;ILforge/game/GameEntityCounterTable;Lforge/game/player/Player;)V","invokevirtual",274);}
case 274:{f.Pc=237;continue;}
case 277:{f.Pc=321;continue;}
case 280:{f.Push(f.Locals[0]);f.Pc=281;continue;}
case 281:{f.Push(f.Locals[1]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[11]);f.Pc=284;continue;}
case 284:{f.Push(f.Locals[5]);f.Pc=286;continue;}
case 286:{f.Push(f.Locals[4]);f.Pc=288;continue;}
case 288:{f.Push(f.Locals[8]);f.Pc=290;continue;}
case 290:{f.Push(f.Locals[6]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/ability/effects/CountersPutOrRemoveEffect","addOrRemoveCounter","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/card/CounterType;ILforge/game/GameEntityCounterTable;Lforge/game/player/Player;)V","invokevirtual",295);}
case 295:{f.Pc=321;continue;}
case 298:{f.Push(f.Locals[7]);f.Pc=300;continue;}
case 300:{f.Pc=f.Pop().Int!=0?321:303;continue;}
case 303:{f.Push(f.Locals[5]);f.Pc=305;continue;}
case 305:{f.Pc=f.Pop().Reference==null?321:308;continue;}
case 308:{f.Push(f.Locals[11]);f.Pc=310;continue;}
case 310:{f.Push(f.Locals[5]);f.Pc=312;continue;}
case 312:{f.Push(f.Locals[4]);f.Pc=314;continue;}
case 314:{f.Push(f.Locals[6]);f.Pc=316;continue;}
case 316:{f.Push(f.Locals[8]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",321);}
case 321:{f.Pc=99;continue;}
case 324:{f.Push(f.Locals[8]);f.Pc=326;continue;}
case 326:{f.Push(f.Locals[3]);f.Pc=327;continue;}
case 327:{f.Push(f.Locals[1]);f.Pc=328;continue;}
case 328:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",331);}
case 331:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3275(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[6]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",5);}
case 5:{f.Locals[7]=f.Pop();f.Pc=7;continue;}
case 7:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",10);}
case 10:{f.Locals[8]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[8]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Target")));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",22);}
case 22:{f.StackOp("pop");f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/Card","getCounters","()Lcom/google/common/collect/Multiset;","invokevirtual",27);}
case 27:{return rt.Call(f,"com/google/common/collect/Multiset","elementSet","()Ljava/util/Set;","invokeinterface",32);}
case 32:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",35);}
case 35:{f.Locals[9]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Pc=f.Pop().Reference==null?54:41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/CounterType;",f.Pop().Int)));f.Pc=45;continue;}
case 45:{f.StackOp("dup");f.Pc=46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=49;continue;}
case 49:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",52);}
case 52:{f.Locals[9]=f.Pop();f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",57);}
case 57:{f.Push(JValue.R(rt.String("lblSelectCounterTypeToAddOrRemove")));f.Pc=59;continue;}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",66);}
case 66:{f.Locals[10]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[7]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[9]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[10]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[8]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/player/PlayerController","chooseCounterType","(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/card/CounterType;","invokevirtual",80);}
case 80:{f.Locals[11]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.String("RemoveConditionSVar")));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",88);}
case 88:{f.Pc=f.Pop().Int==0?170:91;continue;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",95);}
case 95:{f.Locals[13]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[13]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.String("RemoveConditionSVar")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",105);}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",109);}
case 109:{f.Locals[14]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("RemoveConditionSVarCompare")));f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("GE1")));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",119);}
case 119:{f.Locals[15]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[15]);f.Pc=123;continue;}
case 123:{f.Push(JValue.I(0));f.Pc=124;continue;}
case 124:{f.Push(JValue.I(2));f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",128);}
case 128:{f.Locals[16]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[15]);f.Pc=132;continue;}
case 132:{f.Push(JValue.I(2));f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",136);}
case 136:{f.Locals[17]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[13]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[17]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[1]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",146);}
case 146:{f.Locals[18]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[14]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[16]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[18]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",157);}
case 157:{f.Pc=f.Pop().Int!=0?164:160;continue;}
case 160:{f.Push(JValue.I(1));f.Pc=161;continue;}
case 161:{f.Pc=165;continue;}
case 164:{f.Push(JValue.I(0));f.Pc=165;continue;}
case 165:{f.Locals[12]=f.Pop();f.Pc=167;continue;}
case 167:{f.Pc=290;continue;}
case 170:{f.Push(f.Locals[2]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[3]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/card/Card","canReceiveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",175);}
case 175:{f.Locals[13]=f.Pop();f.Pc=177;continue;}
case 177:{f.Push(f.Locals[2]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[3]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/card/Card","canRemoveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",182);}
case 182:{f.Locals[14]=f.Pop();f.Pc=184;continue;}
case 184:{f.Push(f.Locals[13]);f.Pc=186;continue;}
case 186:{f.Pc=f.Pop().Int!=0?195:189;continue;}
case 189:{f.Push(f.Locals[14]);f.Pc=191;continue;}
case 191:{f.Pc=f.Pop().Int!=0?195:194;continue;}
case 194:{return JStep.ReturnVoid;}
case 195:{f.Push(f.Locals[13]);f.Pc=197;continue;}
case 197:{f.Pc=f.Pop().Int==0?211:200;continue;}
case 200:{f.Push(f.Locals[14]);f.Pc=202;continue;}
case 202:{f.Pc=f.Pop().Int!=0?211:205;continue;}
case 205:{f.Push(JValue.I(1));f.Pc=206;continue;}
case 206:{f.Locals[12]=f.Pop();f.Pc=208;continue;}
case 208:{f.Pc=290;continue;}
case 211:{f.Push(f.Locals[13]);f.Pc=213;continue;}
case 213:{f.Pc=f.Pop().Int!=0?227:216;continue;}
case 216:{f.Push(f.Locals[14]);f.Pc=218;continue;}
case 218:{f.Pc=f.Pop().Int==0?227:221;continue;}
case 221:{f.Push(JValue.I(0));f.Pc=222;continue;}
case 222:{f.Locals[12]=f.Pop();f.Pc=224;continue;}
case 224:{f.Pc=290;continue;}
case 227:{f.Push(f.Locals[8]);f.Pc=229;continue;}
case 229:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=231;continue;}
case 231:{f.Push(f.Locals[11]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",238);}
case 238:{f.StackOp("pop");f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",242);}
case 242:{f.Push(JValue.R(rt.String("lblWhatToDoWithTargetCounter")));f.Pc=244;continue;}
case 244:{f.Push(JValue.I(2));f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=248;continue;}
case 248:{f.StackOp("dup");f.Pc=249;continue;}
case 249:{f.Push(JValue.I(0));f.Pc=250;continue;}
case 250:{f.Push(f.Locals[11]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",257);}
case 257:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=258;continue;}
case 258:{f.StackOp("dup");f.Pc=259;continue;}
case 259:{f.Push(JValue.I(1));f.Pc=260;continue;}
case 260:{f.Push(f.Locals[2]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",264);}
case 264:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",268);}
case 268:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersPutOrRemoveEffect:3275:268:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",273);}
case 273:{f.Locals[10]=f.Pop();f.Pc=275;continue;}
case 275:{f.Push(f.Locals[7]);f.Pc=277;continue;}
case 277:{f.Push(f.Locals[1]);f.Pc=278;continue;}
case 278:{f.Push(f.Locals[10]);f.Pc=280;continue;}
case 280:{if(!rt.StaticReady(f,"forge/game/player/PlayerController$BinaryChoiceType","AddOrRemove","Lforge/game/player/PlayerController$BinaryChoiceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerController$BinaryChoiceType","AddOrRemove","Lforge/game/player/PlayerController$BinaryChoiceType;"));f.Pc=283;continue;}
case 283:{f.Push(f.Locals[8]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/game/player/PlayerController","chooseBinary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/PlayerController$BinaryChoiceType;Ljava/util/Map;)Z","invokevirtual",288);}
case 288:{f.Locals[12]=f.Pop();f.Pc=290;continue;}
case 290:{f.Push(f.Locals[12]);f.Pc=292;continue;}
case 292:{f.Pc=f.Pop().Int==0?310:295;continue;}
case 295:{f.Push(f.Locals[2]);f.Pc=296;continue;}
case 296:{f.Push(f.Locals[11]);f.Pc=298;continue;}
case 298:{f.Push(f.Locals[4]);f.Pc=300;continue;}
case 300:{f.Push(f.Locals[6]);f.Pc=302;continue;}
case 302:{f.Push(f.Locals[5]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",307);}
case 307:{f.Pc=339;continue;}
case 310:{f.Push(f.Locals[2]);f.Pc=311;continue;}
case 311:{f.Push(f.Locals[11]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[4]);f.Pc=315;continue;}
case 315:{f.Push(f.Locals[6]);f.Pc=317;continue;}
case 317:{return rt.Call(f,"forge/game/card/Card","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",320);}
case 320:{f.StackOp("pop");f.Pc=321;continue;}
case 321:{f.Push(f.Locals[1]);f.Pc=322;continue;}
case 322:{f.Push(JValue.R(rt.String("RememberRemovedCards")));f.Pc=325;continue;}
case 325:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",328);}
case 328:{f.Pc=f.Pop().Int==0?339:331;continue;}
case 331:{f.Push(f.Locals[1]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",335);}
case 335:{f.Push(f.Locals[2]);f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",339);}
case 339:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
