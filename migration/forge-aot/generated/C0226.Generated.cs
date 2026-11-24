// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C226{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChangeZoneAllEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3097,"forge/game/ability/effects/ChangeZoneAllEffect","<init>","()V",1,1,1,new JHandler[]{},M3097));
c.Add(new JMethod(3098,"forge/game/ability/effects/ChangeZoneAllEffect","movesCardToOrFromLibrary","(Lforge/game/spellability/SpellAbility;)Z",1,2,2,new JHandler[]{},M3098));
c.Add(new JMethod(3099,"forge/game/ability/effects/ChangeZoneAllEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V",1,2,2,new JHandler[]{},M3099));
c.Add(new JMethod(3100,"forge/game/ability/effects/ChangeZoneAllEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,5,4,new JHandler[]{},M3100));
c.Add(new JMethod(3101,"forge/game/ability/effects/ChangeZoneAllEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,23,7,new JHandler[]{},M3101));
}

internal static JStep M3097(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3098(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Origin")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneAllEffect","zoneParamIsLibrary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z","invokestatic",6);}
case 6:{f.Pc=f.Pop().Int!=0?18:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("Destination")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneAllEffect","zoneParamIsLibrary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z","invokestatic",15);}
case 15:{f.Pc=f.Pop().Int==0?22:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Pc=23;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3099(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",9);}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/AbilityFactory","adjustChangeZoneTarget","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)V","invokestatic",13);}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3100(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String(":")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?22:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=19;continue;}
case 19:{f.Pc=25;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=25;continue;}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Reference==null?56:33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String(". ")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",39);}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{f.Pc=f.Pop().Int<=0?56:46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",55);}
case 55:{f.Locals[3]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3101(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Duration")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneAllEffect","checkValidDuration","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokestatic",10);}
case 10:{f.Pc=f.Pop().Int!=0?14:13;continue;}
case 13:{return JStep.ReturnVoid;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("Destination")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",25);}
case 25:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",28);}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("Origin")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",35);}
case 35:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",38);}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneAllEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",44);}
case 44:{f.Locals[6]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",50);}
case 50:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",53);}
case 53:{f.Locals[7]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int!=0?71:62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("Defined")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int==0?80:71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("UseAllOriginZones")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Int==0?106:80;continue;}
case 80:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(f.Locals[7]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[4]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",91);}
case 91:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",94);}
case 94:{f.Locals[5]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[7]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",101);}
case 101:{f.Locals[6]=f.Pop();f.Pc=103;continue;}
case 103:{f.Pc=115;continue;}
case 106:{f.Push(f.Locals[6]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[4]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/player/PlayerCollection","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollection;","invokevirtual",113);}
case 113:{f.Locals[5]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("Optional")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int==0?242:124;continue;}
case 124:{f.Push(f.Locals[5]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",129);}
case 129:{f.Locals[8]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{f.Push(JValue.R(rt.String("OptionQuestion")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",137);}
case 137:{f.Pc=f.Pop().Int==0?158:140;continue;}
case 140:{f.Push(f.Locals[1]);f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.String("OptionQuestion")));f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",146);}
case 146:{f.Push(JValue.R(rt.String("TARGETS")));f.Pc=148;continue;}
case 148:{f.Push(f.Locals[8]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",153);}
case 153:{f.Locals[9]=f.Pop();f.Pc=155;continue;}
case 155:{f.Pc=197;continue;}
case 158:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",161);}
case 161:{f.Push(JValue.R(rt.String("lblMoveTargetFromOriginToDestination")));f.Pc=163;continue;}
case 163:{f.Push(JValue.I(3));f.Pc=164;continue;}
case 164:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=167;continue;}
case 167:{f.StackOp("dup");f.Pc=168;continue;}
case 168:{f.Push(JValue.I(0));f.Pc=169;continue;}
case 169:{f.Push(f.Locals[8]);f.Pc=171;continue;}
case 171:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=172;continue;}
case 172:{f.StackOp("dup");f.Pc=173;continue;}
case 173:{f.Push(JValue.I(1));f.Pc=174;continue;}
case 174:{f.Push(f.Locals[4]);f.Pc=176;continue;}
case 176:{return rt.DynamicCall(f,"forge/game/ability/effects/ChangeZoneAllEffect:3101:176:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",181);}
case 181:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;)Ljava/lang/String;","invokestatic",184);}
case 184:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=185;continue;}
case 185:{f.StackOp("dup");f.Pc=186;continue;}
case 186:{f.Push(JValue.I(2));f.Pc=187;continue;}
case 187:{f.Push(f.Locals[3]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/zone/ZoneType","getTranslatedName","()Ljava/lang/String;","invokevirtual",191);}
case 191:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",195);}
case 195:{f.Locals[9]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(f.Locals[5]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",202);}
case 202:{f.Push(JValue.I(1));f.Pc=203;continue;}
case 203:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?218:206;continue;}
case 206:{f.Push(f.Locals[5]);f.Pc=208;continue;}
case 208:{f.Push(JValue.I(0));f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",212);}
case 212:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=215;continue;}
case 215:{f.Pc=219;continue;}
case 218:{f.Push(JValue.R(null));f.Pc=219;continue;}
case 219:{f.Locals[10]=f.Pop();f.Pc=221;continue;}
case 221:{f.Push(f.Locals[1]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",225);}
case 225:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",228);}
case 228:{f.Push(f.Locals[1]);f.Pc=229;continue;}
case 229:{f.Push(JValue.R(null));f.Pc=230;continue;}
case 230:{f.Push(f.Locals[9]);f.Pc=232;continue;}
case 232:{f.Push(f.Locals[10]);f.Pc=234;continue;}
case 234:{f.Push(JValue.R(null));f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",238);}
case 238:{f.Pc=f.Pop().Int!=0?242:241;continue;}
case 241:{return JStep.ReturnVoid;}
case 242:{f.Push(f.Locals[5]);f.Pc=244;continue;}
case 244:{f.Push(f.Locals[1]);f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.String("ChangeType")));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",250);}
case 250:{f.Push(f.Locals[1]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",254);}
case 254:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=257;continue;}
case 257:{f.Locals[5]=f.Pop();f.Pc=259;continue;}
case 259:{f.Push(f.Locals[1]);f.Pc=260;continue;}
case 260:{f.Push(JValue.R(rt.String("TypeLimit")));f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",265);}
case 265:{f.Pc=f.Pop().Int==0?293:268;continue;}
case 268:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=271;continue;}
case 271:{f.StackOp("dup");f.Pc=272;continue;}
case 272:{f.Push(f.Locals[5]);f.Pc=274;continue;}
case 274:{f.Push(f.Locals[2]);f.Pc=275;continue;}
case 275:{f.Push(f.Locals[1]);f.Pc=276;continue;}
case 276:{f.Push(JValue.R(rt.String("TypeLimit")));f.Pc=278;continue;}
case 278:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",281);}
case 281:{f.Push(f.Locals[1]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",285);}
case 285:{return rt.Call(f,"com/google/common/collect/Iterables","limit","(Ljava/lang/Iterable;I)Ljava/lang/Iterable;","invokestatic",288);}
case 288:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",291);}
case 291:{f.Locals[5]=f.Pop();f.Pc=293;continue;}
case 293:{f.Push(f.Locals[1]);f.Pc=294;continue;}
case 294:{f.Push(JValue.R(rt.String("ForgetOtherRemembered")));f.Pc=296;continue;}
case 296:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",299);}
case 299:{f.Pc=f.Pop().Int==0?306:302;continue;}
case 302:{f.Push(f.Locals[2]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",306);}
case 306:{f.Push(f.Locals[1]);f.Pc=307;continue;}
case 307:{f.Push(JValue.R(rt.String("RememberChanged")));f.Pc=309;continue;}
case 309:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",312);}
case 312:{f.Locals[8]=f.Pop();f.Pc=314;continue;}
case 314:{f.Push(f.Locals[1]);f.Pc=315;continue;}
case 315:{f.Push(JValue.R(rt.String("ForgetChanged")));f.Pc=317;continue;}
case 317:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",320);}
case 320:{f.Locals[9]=f.Pop();f.Pc=322;continue;}
case 322:{f.Push(f.Locals[1]);f.Pc=323;continue;}
case 323:{f.Push(JValue.R(rt.String("Imprint")));f.Pc=325;continue;}
case 325:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",328);}
case 328:{f.Locals[10]=f.Pop();f.Pc=330;continue;}
case 330:{f.Push(f.Locals[1]);f.Pc=331;continue;}
case 331:{f.Push(JValue.R(rt.String("RandomOrder")));f.Pc=333;continue;}
case 333:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",336);}
case 336:{f.Locals[11]=f.Pop();f.Pc=338;continue;}
case 338:{f.Push(f.Locals[1]);f.Pc=339;continue;}
case 339:{f.Push(JValue.R(rt.String("RememberLKI")));f.Pc=341;continue;}
case 341:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",344);}
case 344:{f.Locals[12]=f.Pop();f.Pc=346;continue;}
case 346:{f.Push(f.Locals[3]);f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/zone/ZoneType","isDeck","()Z","invokevirtual",350);}
case 350:{f.Locals[13]=f.Pop();f.Pc=352;continue;}
case 352:{f.Push(f.Locals[1]);f.Pc=353;continue;}
case 353:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=355;continue;}
case 355:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",358);}
case 358:{f.Pc=f.Pop().Int==0?373:361;continue;}
case 361:{f.Push(f.Locals[1]);f.Pc=362;continue;}
case 362:{f.Push(JValue.R(rt.String("LibraryPosition")));f.Pc=364;continue;}
case 364:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",367);}
case 367:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",370);}
case 370:{f.Pc=374;continue;}
case 373:{f.Push(JValue.I(0));f.Pc=374;continue;}
case 374:{f.Locals[14]=f.Pop();f.Pc=376;continue;}
case 376:{f.Push(f.Locals[11]);f.Pc=378;continue;}
case 378:{f.Pc=f.Pop().Int!=0?458:381;continue;}
case 381:{f.Push(f.Locals[1]);f.Pc=382;continue;}
case 382:{f.Push(JValue.R(rt.String("Shuffle")));f.Pc=384;continue;}
case 384:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",387);}
case 387:{f.Pc=f.Pop().Int!=0?458:390;continue;}
case 390:{f.Push(f.Locals[13]);f.Pc=392;continue;}
case 392:{f.Pc=f.Pop().Int==0?444:395;continue;}
case 395:{f.Push(f.Locals[5]);f.Pc=397;continue;}
case 397:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",400);}
case 400:{f.Push(JValue.I(2));f.Pc=401;continue;}
case 401:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?444:404;continue;}
case 404:{f.Push(f.Locals[2]);f.Pc=405;continue;}
case 405:{f.Push(f.Locals[1]);f.Pc=406;continue;}
case 406:{f.Push(JValue.R(rt.String("DefinedPlayer")));f.Pc=408;continue;}
case 408:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",411);}
case 411:{f.Push(f.Locals[1]);f.Pc=412;continue;}
case 412:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",415);}
case 415:{f.Push(JValue.I(0));f.Pc=416;continue;}
case 416:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",419);}
case 419:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=422;continue;}
case 422:{f.Locals[15]=f.Pop();f.Pc=424;continue;}
case 424:{f.Push(f.Locals[15]);f.Pc=426;continue;}
case 426:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",429);}
case 429:{f.Push(f.Locals[5]);f.Pc=431;continue;}
case 431:{f.Push(f.Locals[3]);f.Pc=432;continue;}
case 432:{f.Push(f.Locals[1]);f.Pc=433;continue;}
case 433:{return rt.Call(f,"forge/game/player/PlayerController","orderMoveToZoneList","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokevirtual",436);}
case 436:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=439;continue;}
case 439:{f.Locals[5]=f.Pop();f.Pc=441;continue;}
case 441:{f.Pc=458;continue;}
case 444:{f.Push(f.Locals[7]);f.Pc=446;continue;}
case 446:{f.Push(f.Locals[5]);f.Pc=448;continue;}
case 448:{f.Push(f.Locals[3]);f.Pc=449;continue;}
case 449:{f.Push(f.Locals[1]);f.Pc=450;continue;}
case 450:{return rt.Call(f,"forge/game/GameActionUtil","orderCardsByTheirOwners","(Lforge/game/Game;Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",453);}
case 453:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=456;continue;}
case 456:{f.Locals[5]=f.Pop();f.Pc=458;continue;}
case 458:{f.Push(f.Locals[13]);f.Pc=460;continue;}
case 460:{f.Pc=f.Pop().Int==0?473:463;continue;}
case 463:{f.Push(f.Locals[11]);f.Pc=465;continue;}
case 465:{f.Pc=f.Pop().Int==0?473:468;continue;}
case 468:{f.Push(f.Locals[5]);f.Pc=470;continue;}
case 470:{return rt.Call(f,"forge/game/card/CardLists","shuffle","(Ljava/util/List;)V","invokestatic",473);}
case 473:{f.Push(f.Locals[1]);f.Pc=474;continue;}
case 474:{return rt.Call(f,"forge/game/card/CardZoneTable","getSimultaneousInstance","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",477);}
case 477:{f.Locals[15]=f.Pop();f.Pc=479;continue;}
case 479:{f.Push(f.Locals[5]);f.Pc=481;continue;}
case 481:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",484);}
case 484:{f.Locals[16]=f.Pop();f.Pc=486;continue;}
case 486:{f.Push(f.Locals[16]);f.Pc=488;continue;}
case 488:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",493);}
case 493:{f.Pc=f.Pop().Int==0?1014:496;continue;}
case 496:{f.Push(f.Locals[16]);f.Pc=498;continue;}
case 498:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",503);}
case 503:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=506;continue;}
case 506:{f.Locals[17]=f.Pop();f.Pc=508;continue;}
case 508:{f.Push(f.Locals[7]);f.Pc=510;continue;}
case 510:{f.Push(f.Locals[17]);f.Pc=512;continue;}
case 512:{return rt.Call(f,"forge/game/Game","getZoneOf","(Lforge/game/card/Card;)Lforge/game/zone/Zone;","invokevirtual",515);}
case 515:{f.Locals[18]=f.Pop();f.Pc=517;continue;}
case 517:{f.Push(f.Locals[18]);f.Pc=519;continue;}
case 519:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=522;continue;}
case 522:{return rt.Call(f,"forge/game/zone/Zone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",525);}
case 525:{f.Pc=f.Pop().Int==0?538:528;continue;}
case 528:{f.Push(f.Locals[7]);f.Pc=530;continue;}
case 530:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",533);}
case 533:{f.Push(f.Locals[17]);f.Pc=535;continue;}
case 535:{return rt.Call(f,"forge/game/zone/MagicStack","remove","(Lforge/game/card/Card;)V","invokevirtual",538);}
case 538:{f.Push(f.Locals[12]);f.Pc=540;continue;}
case 540:{f.Pc=f.Pop().Int==0?552:543;continue;}
case 543:{f.Push(f.Locals[2]);f.Pc=544;continue;}
case 544:{f.Push(f.Locals[17]);f.Pc=546;continue;}
case 546:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",549);}
case 549:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",552);}
case 552:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",555);}
case 555:{f.Locals[19]=f.Pop();f.Pc=557;continue;}
case 557:{f.Push(f.Locals[19]);f.Pc=559;continue;}
case 559:{f.Push(f.Locals[15]);f.Pc=561;continue;}
case 561:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",564);}
case 564:{f.Push(f.Locals[3]);f.Pc=565;continue;}
case 565:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=568;continue;}
case 568:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?701:571;continue;}
case 571:{f.Push(f.Locals[19]);f.Pc=573;continue;}
case 573:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SimultaneousETB","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SimultaneousETB","Lforge/game/ability/AbilityKey;"));f.Pc=576;continue;}
case 576:{f.Push(f.Locals[5]);f.Pc=578;continue;}
case 578:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",583);}
case 583:{f.StackOp("pop");f.Pc=584;continue;}
case 584:{f.Push(f.Locals[1]);f.Pc=585;continue;}
case 585:{f.Push(JValue.R(rt.String("Tapped")));f.Pc=588;continue;}
case 588:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",591);}
case 591:{f.Pc=f.Pop().Int==0?600:594;continue;}
case 594:{f.Push(f.Locals[17]);f.Pc=596;continue;}
case 596:{f.Push(JValue.I(1));f.Pc=597;continue;}
case 597:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",600);}
case 600:{f.Push(f.Locals[1]);f.Pc=601;continue;}
case 601:{f.Push(JValue.R(rt.String("FaceDown")));f.Pc=604;continue;}
case 604:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",607);}
case 607:{f.Pc=f.Pop().Int==0?623:610;continue;}
case 610:{f.Push(f.Locals[17]);f.Pc=612;continue;}
case 612:{f.Push(JValue.I(1));f.Pc=613;continue;}
case 613:{return rt.Call(f,"forge/game/card/Card","turnFaceDown","(Z)Z","invokevirtual",616);}
case 616:{f.StackOp("pop");f.Pc=617;continue;}
case 617:{f.Push(f.Locals[17]);f.Pc=619;continue;}
case 619:{f.Push(f.Locals[1]);f.Pc=620;continue;}
case 620:{return rt.Call(f,"forge/game/card/CardFactoryUtil","setFaceDownState","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",623);}
case 623:{f.Push(f.Locals[1]);f.Pc=624;continue;}
case 624:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=627;continue;}
case 627:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",630);}
case 630:{f.Pc=f.Pop().Int==0?701:633;continue;}
case 633:{f.Push(f.Locals[1]);f.Pc=634;continue;}
case 634:{f.Push(JValue.R(rt.String("WithCountersType")));f.Pc=637;continue;}
case 637:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",640);}
case 640:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",643);}
case 643:{f.Locals[20]=f.Pop();f.Pc=645;continue;}
case 645:{f.Push(f.Locals[17]);f.Pc=647;continue;}
case 647:{f.Push(f.Locals[1]);f.Pc=648;continue;}
case 648:{f.Push(JValue.R(rt.String("WithCountersAmount")));f.Pc=651;continue;}
case 651:{f.Push(JValue.R(rt.String("1")));f.Pc=654;continue;}
case 654:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",657);}
case 657:{f.Push(f.Locals[1]);f.Pc=658;continue;}
case 658:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",661);}
case 661:{f.Locals[21]=f.Pop();f.Pc=663;continue;}
case 663:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=666;continue;}
case 666:{f.StackOp("dup");f.Pc=667;continue;}
case 667:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",670);}
case 670:{f.Locals[22]=f.Pop();f.Pc=672;continue;}
case 672:{f.Push(f.Locals[22]);f.Pc=674;continue;}
case 674:{f.Push(f.Locals[1]);f.Pc=675;continue;}
case 675:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",678);}
case 678:{f.Push(f.Locals[17]);f.Pc=680;continue;}
case 680:{f.Push(f.Locals[20]);f.Pc=682;continue;}
case 682:{f.Push(f.Locals[21]);f.Pc=684;continue;}
case 684:{return rt.Call(f,"forge/game/GameEntityCounterTable","put","(Lforge/game/player/Player;Lforge/game/GameEntity;Lforge/game/card/CounterType;I)I","invokevirtual",687);}
case 687:{f.StackOp("pop");f.Pc=688;continue;}
case 688:{f.Push(f.Locals[19]);f.Pc=690;continue;}
case 690:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CounterTable","Lforge/game/ability/AbilityKey;"));f.Pc=693;continue;}
case 693:{f.Push(f.Locals[22]);f.Pc=695;continue;}
case 695:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",700);}
case 700:{f.StackOp("pop");f.Pc=701;continue;}
case 701:{f.Push(JValue.R(null));f.Pc=702;continue;}
case 702:{f.Locals[20]=f.Pop();f.Pc=704;continue;}
case 704:{f.Push(f.Locals[1]);f.Pc=705;continue;}
case 705:{f.Push(JValue.R(rt.String("GainControl")));f.Pc=708;continue;}
case 708:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",711);}
case 711:{f.Pc=f.Pop().Int==0?750:714;continue;}
case 714:{f.Push(f.Locals[17]);f.Pc=716;continue;}
case 716:{f.Push(f.Locals[1]);f.Pc=717;continue;}
case 717:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",720);}
case 720:{f.Push(f.Locals[7]);f.Pc=722;continue;}
case 722:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",725);}
case 725:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",728);}
case 728:{f.Push(f.Locals[7]);f.Pc=730;continue;}
case 730:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",733);}
case 733:{f.Push(f.Locals[17]);f.Pc=735;continue;}
case 735:{f.Push(f.Locals[1]);f.Pc=736;continue;}
case 736:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",739);}
case 739:{f.Push(f.Locals[1]);f.Pc=740;continue;}
case 740:{f.Push(f.Locals[19]);f.Pc=742;continue;}
case 742:{return rt.Call(f,"forge/game/GameAction","moveToPlay","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",745);}
case 745:{f.Locals[20]=f.Pop();f.Pc=747;continue;}
case 747:{f.Pc=818;continue;}
case 750:{f.Push(f.Locals[3]);f.Pc=751;continue;}
case 751:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=754;continue;}
case 754:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?770:757;continue;}
case 757:{f.Push(f.Locals[17]);f.Pc=759;continue;}
case 759:{f.Push(f.Locals[1]);f.Pc=760;continue;}
case 760:{f.Push(JValue.I(1));f.Pc=761;continue;}
case 761:{return rt.Call(f,"forge/game/card/Card","canExiledBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",764);}
case 764:{f.Pc=f.Pop().Int!=0?770:767;continue;}
case 767:{f.Pc=486;continue;}
case 770:{f.Push(f.Locals[7]);f.Pc=772;continue;}
case 772:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",775);}
case 775:{f.Push(f.Locals[3]);f.Pc=776;continue;}
case 776:{f.Push(f.Locals[17]);f.Pc=778;continue;}
case 778:{f.Push(f.Locals[14]);f.Pc=780;continue;}
case 780:{f.Push(f.Locals[1]);f.Pc=781;continue;}
case 781:{f.Push(f.Locals[19]);f.Pc=783;continue;}
case 783:{return rt.Call(f,"forge/game/GameAction","moveTo","(Lforge/game/zone/ZoneType;Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",786);}
case 786:{f.Locals[20]=f.Pop();f.Pc=788;continue;}
case 788:{f.Push(f.Locals[3]);f.Pc=789;continue;}
case 789:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=792;continue;}
case 792:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?801:795;continue;}
case 795:{f.Push(f.Locals[20]);f.Pc=797;continue;}
case 797:{f.Push(f.Locals[1]);f.Pc=798;continue;}
case 798:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneAllEffect","handleExiledWith","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",801);}
case 801:{f.Push(f.Locals[1]);f.Pc=802;continue;}
case 802:{f.Push(JValue.R(rt.String("ExileFaceDown")));f.Pc=805;continue;}
case 805:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",808);}
case 808:{f.Pc=f.Pop().Int==0?818:811;continue;}
case 811:{f.Push(f.Locals[20]);f.Pc=813;continue;}
case 813:{f.Push(JValue.I(1));f.Pc=814;continue;}
case 814:{return rt.Call(f,"forge/game/card/Card","turnFaceDown","(Z)Z","invokevirtual",817);}
case 817:{f.StackOp("pop");f.Pc=818;continue;}
case 818:{f.Push(f.Locals[20]);f.Pc=820;continue;}
case 820:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",823);}
case 823:{f.Push(f.Locals[18]);f.Pc=825;continue;}
case 825:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",828);}
case 828:{f.Pc=f.Pop().Int!=0?1011:831;continue;}
case 831:{f.Push(f.Locals[8]);f.Pc=833;continue;}
case 833:{f.Pc=f.Pop().Reference==null?989:836;continue;}
case 836:{f.Push(f.Locals[8]);f.Pc=838;continue;}
case 838:{f.Push(JValue.R(rt.String("True")));f.Pc=841;continue;}
case 841:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",844);}
case 844:{f.Pc=f.Pop().Int!=0?863:847;continue;}
case 847:{f.Push(f.Locals[20]);f.Pc=849;continue;}
case 849:{f.Push(f.Locals[8]);f.Pc=851;continue;}
case 851:{f.Push(f.Locals[1]);f.Pc=852;continue;}
case 852:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",855);}
case 855:{f.Push(f.Locals[2]);f.Pc=856;continue;}
case 856:{f.Push(f.Locals[1]);f.Pc=857;continue;}
case 857:{return rt.Call(f,"forge/game/card/Card","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",860);}
case 860:{f.Pc=f.Pop().Int==0?989:863;continue;}
case 863:{f.Push(f.Locals[2]);f.Pc=864;continue;}
case 864:{f.Push(f.Locals[20]);f.Pc=866;continue;}
case 866:{return rt.Call(f,"forge/game/card/Card","isRemembered","(Ljava/lang/Object;)Z","invokevirtual",869);}
case 869:{f.Pc=f.Pop().Int!=0?878:872;continue;}
case 872:{f.Push(f.Locals[2]);f.Pc=873;continue;}
case 873:{f.Push(f.Locals[20]);f.Pc=875;continue;}
case 875:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",878);}
case 878:{f.Push(f.Locals[17]);f.Pc=880;continue;}
case 880:{return rt.Call(f,"forge/game/card/Card","getMeldedWith","()Lforge/game/card/Card;","invokevirtual",883);}
case 883:{f.Pc=f.Pop().Reference==null?919:886;continue;}
case 886:{f.Push(f.Locals[7]);f.Pc=888;continue;}
case 888:{f.Push(f.Locals[17]);f.Pc=890;continue;}
case 890:{return rt.Call(f,"forge/game/card/Card","getMeldedWith","()Lforge/game/card/Card;","invokevirtual",893);}
case 893:{f.Push(JValue.R(null));f.Pc=894;continue;}
case 894:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",897);}
case 897:{f.Locals[21]=f.Pop();f.Pc=899;continue;}
case 899:{f.Push(f.Locals[21]);f.Pc=901;continue;}
case 901:{f.Pc=f.Pop().Reference==null?919:904;continue;}
case 904:{f.Push(f.Locals[2]);f.Pc=905;continue;}
case 905:{f.Push(f.Locals[21]);f.Pc=907;continue;}
case 907:{return rt.Call(f,"forge/game/card/Card","isRemembered","(Ljava/lang/Object;)Z","invokevirtual",910);}
case 910:{f.Pc=f.Pop().Int!=0?919:913;continue;}
case 913:{f.Push(f.Locals[2]);f.Pc=914;continue;}
case 914:{f.Push(f.Locals[21]);f.Pc=916;continue;}
case 916:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",919);}
case 919:{f.Push(f.Locals[17]);f.Pc=921;continue;}
case 921:{return rt.Call(f,"forge/game/card/Card","hasMergedCard","()Z","invokevirtual",924);}
case 924:{f.Pc=f.Pop().Int==0?989:927;continue;}
case 927:{f.Push(f.Locals[17]);f.Pc=929;continue;}
case 929:{return rt.Call(f,"forge/game/card/Card","getMergedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",932);}
case 932:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",937);}
case 937:{f.Locals[21]=f.Pop();f.Pc=939;continue;}
case 939:{f.Push(f.Locals[21]);f.Pc=941;continue;}
case 941:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",946);}
case 946:{f.Pc=f.Pop().Int==0?989:949;continue;}
case 949:{f.Push(f.Locals[21]);f.Pc=951;continue;}
case 951:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",956);}
case 956:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=959;continue;}
case 959:{f.Locals[22]=f.Pop();f.Pc=961;continue;}
case 961:{f.Push(f.Locals[22]);f.Pc=963;continue;}
case 963:{f.Push(f.Locals[17]);f.Pc=965;continue;}
case 965:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?971:968;continue;}
case 968:{f.Pc=939;continue;}
case 971:{f.Push(f.Locals[2]);f.Pc=972;continue;}
case 972:{f.Push(f.Locals[22]);f.Pc=974;continue;}
case 974:{return rt.Call(f,"forge/game/card/Card","isRemembered","(Ljava/lang/Object;)Z","invokevirtual",977);}
case 977:{f.Pc=f.Pop().Int!=0?986:980;continue;}
case 980:{f.Push(f.Locals[2]);f.Pc=981;continue;}
case 981:{f.Push(f.Locals[22]);f.Pc=983;continue;}
case 983:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",986);}
case 986:{f.Pc=939;continue;}
case 989:{f.Push(f.Locals[9]);f.Pc=991;continue;}
case 991:{f.Pc=f.Pop().Reference==null?1000:994;continue;}
case 994:{f.Push(f.Locals[2]);f.Pc=995;continue;}
case 995:{f.Push(f.Locals[17]);f.Pc=997;continue;}
case 997:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",1000);}
case 1000:{f.Push(f.Locals[10]);f.Pc=1002;continue;}
case 1002:{f.Pc=f.Pop().Reference==null?1011:1005;continue;}
case 1005:{f.Push(f.Locals[2]);f.Pc=1006;continue;}
case 1006:{f.Push(f.Locals[20]);f.Pc=1008;continue;}
case 1008:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",1011);}
case 1011:{f.Pc=486;continue;}
case 1014:{f.Push(f.Locals[15]);f.Pc=1016;continue;}
case 1016:{f.Push(f.Locals[7]);f.Pc=1018;continue;}
case 1018:{f.Push(f.Locals[1]);f.Pc=1019;continue;}
case 1019:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1022);}
case 1022:{f.Push(f.Locals[1]);f.Pc=1023;continue;}
case 1023:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=1026;continue;}
case 1026:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1029);}
case 1029:{f.Pc=f.Pop().Int==0?1056:1032;continue;}
case 1032:{f.Push(f.Locals[15]);f.Pc=1034;continue;}
case 1034:{return rt.Call(f,"forge/game/card/CardZoneTable","isEmpty","()Z","invokevirtual",1037);}
case 1037:{f.Pc=f.Pop().Int!=0?1056:1040;continue;}
case 1040:{f.Push(f.Locals[1]);f.Pc=1041;continue;}
case 1041:{f.Push(f.Locals[1]);f.Pc=1042;continue;}
case 1042:{f.Push(JValue.R(rt.String("AtEOT")));f.Pc=1045;continue;}
case 1045:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1048);}
case 1048:{f.Push(f.Locals[15]);f.Pc=1050;continue;}
case 1050:{return rt.Call(f,"forge/game/card/CardZoneTable","allCards","()Ljava/lang/Iterable;","invokevirtual",1053);}
case 1053:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneAllEffect","registerDelayedTrigger","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/lang/Iterable;)V","invokestatic",1056);}
case 1056:{f.Push(f.Locals[15]);f.Pc=1058;continue;}
case 1058:{f.Push(f.Locals[1]);f.Pc=1059;continue;}
case 1059:{return rt.Call(f,"forge/game/ability/effects/ChangeZoneAllEffect","changeZoneUntilCommand","(Lforge/game/card/CardZoneTable;Lforge/game/spellability/SpellAbility;)V","invokestatic",1062);}
case 1062:{f.Push(f.Locals[1]);f.Pc=1063;continue;}
case 1063:{f.Push(JValue.R(rt.String("Shuffle")));f.Pc=1065;continue;}
case 1065:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1068);}
case 1068:{f.Pc=f.Pop().Int==0?1109:1071;continue;}
case 1071:{f.Push(f.Locals[6]);f.Pc=1073;continue;}
case 1073:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1076);}
case 1076:{f.Locals[16]=f.Pop();f.Pc=1078;continue;}
case 1078:{f.Push(f.Locals[16]);f.Pc=1080;continue;}
case 1080:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1085);}
case 1085:{f.Pc=f.Pop().Int==0?1109:1088;continue;}
case 1088:{f.Push(f.Locals[16]);f.Pc=1090;continue;}
case 1090:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1095);}
case 1095:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1098;continue;}
case 1098:{f.Locals[17]=f.Pop();f.Pc=1100;continue;}
case 1100:{f.Push(f.Locals[17]);f.Pc=1102;continue;}
case 1102:{f.Push(f.Locals[1]);f.Pc=1103;continue;}
case 1103:{return rt.Call(f,"forge/game/player/Player","shuffle","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1106);}
case 1106:{f.Pc=1078;continue;}
case 1109:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
