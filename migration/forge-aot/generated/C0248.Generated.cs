// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C248{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/CloneEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3187,"forge/game/ability/effects/CloneEffect","<init>","()V",1,1,1,new JHandler[]{},M3187));
c.Add(new JMethod(3188,"forge/game/ability/effects/CloneEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,9,3,new JHandler[]{},M3188));
c.Add(new JMethod(3189,"forge/game/ability/effects/CloneEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,17,9,new JHandler[]{},M3189));
}

internal static JStep M3187(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3188(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{f.Locals[5]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("Defined")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?67:28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("Defined")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",35);}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",39);}
case 39:{f.Locals[6]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[6]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",48);}
case 48:{f.Pc=f.Pop().Int!=0?64:51;continue;}
case 51:{f.Push(f.Locals[6]);f.Pc=53;continue;}
case 53:{f.Push(JValue.I(0));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",59);}
case 59:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=62;continue;}
case 62:{f.Locals[5]=f.Pop();f.Pc=64;continue;}
case 64:{f.Pc=80;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",71);}
case 71:{f.Pc=f.Pop().Int==0?80:74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetCard","()Lforge/game/card/Card;","invokevirtual",78);}
case 78:{f.Locals[5]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("CloneTarget")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",87);}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",91);}
case 91:{f.Locals[6]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[6]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",100);}
case 100:{f.Pc=f.Pop().Int!=0?116:103;continue;}
case 103:{f.Push(f.Locals[6]);f.Pc=105;continue;}
case 105:{f.Push(JValue.I(0));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",111);}
case 111:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=114;continue;}
case 114:{f.Locals[4]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[2]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[4]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",122);}
case 122:{f.StackOp("pop");f.Pc=123;continue;}
case 123:{f.Push(f.Locals[5]);f.Pc=125;continue;}
case 125:{f.Pc=f.Pop().Reference!=null?269:128;continue;}
case 128:{f.Push(f.Locals[1]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",132);}
case 132:{f.Pc=f.Pop().Int==0?145:135;continue;}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",139);}
case 139:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getValidTgts","()[Ljava/lang/String;","invokevirtual",142);}
case 142:{f.Pc=146;continue;}
case 145:{f.Push(JValue.R(null));f.Pc=146;continue;}
case 146:{f.Locals[7]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",154);}
case 154:{f.Pc=f.Pop().Int==0?176:157;continue;}
case 157:{f.Push(f.Locals[1]);f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",163);}
case 163:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",166);}
case 166:{f.Push(JValue.R(rt.String("^choose ")));f.Pc=168;continue;}
case 168:{f.Push(JValue.R(rt.String("")));f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/lang/String","replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",173);}
case 173:{f.Pc=229;continue;}
case 176:{f.Push(f.Locals[7]);f.Pc=178;continue;}
case 178:{f.Pc=f.Pop().Reference==null?203:181;continue;}
case 181:{f.Push(f.Locals[7]);f.Pc=183;continue;}
case 183:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=184;continue;}
case 184:{f.Pc=f.Pop().Int<=0?203:187;continue;}
case 187:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",190);}
case 190:{f.Push(JValue.R(rt.String(",")));f.Pc=192;continue;}
case 192:{f.Push(f.Locals[7]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/lang/String","join","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/String;","invokestatic",197);}
case 197:{return rt.Call(f,"forge/util/Lang","describeValidList","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",200);}
case 200:{f.Pc=229;continue;}
case 203:{f.Push(f.Locals[1]);f.Pc=204;continue;}
case 204:{f.Push(JValue.R(rt.String("Choices")));f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",209);}
case 209:{f.Pc=f.Pop().Int==0?227:212;continue;}
case 212:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",215);}
case 215:{f.Push(f.Locals[1]);f.Pc=216;continue;}
case 216:{f.Push(JValue.R(rt.String("Choices")));f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",221);}
case 221:{return rt.Call(f,"forge/util/Lang","describeValidList","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",224);}
case 224:{f.Pc=229;continue;}
case 227:{f.Push(JValue.R(rt.String("permanent")));f.Pc=229;continue;}
case 229:{f.Locals[8]=f.Pop();f.Pc=231;continue;}
case 231:{f.Push(f.Locals[2]);f.Pc=232;continue;}
case 232:{f.Push(JValue.R(rt.String(" becomes a copy of ")));f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",237);}
case 237:{f.Push(f.Locals[8]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/util/Lang","startsWithVowel","(Ljava/lang/String;)Z","invokestatic",242);}
case 242:{f.Pc=f.Pop().Int==0?250:245;continue;}
case 245:{f.Push(JValue.R(rt.String("an ")));f.Pc=247;continue;}
case 247:{f.Pc=252;continue;}
case 250:{f.Push(JValue.R(rt.String("a ")));f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",255);}
case 255:{f.Push(f.Locals[8]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",260);}
case 260:{f.Push(JValue.R(rt.String(".")));f.Pc=262;continue;}
case 262:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",265);}
case 265:{f.StackOp("pop");f.Pc=266;continue;}
case 266:{f.Pc=286;continue;}
case 269:{f.Push(f.Locals[2]);f.Pc=270;continue;}
case 270:{f.Push(JValue.R(rt.String(" becomes a copy of ")));f.Pc=272;continue;}
case 272:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",275);}
case 275:{f.Push(f.Locals[5]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",280);}
case 280:{f.Push(JValue.R(rt.String(".")));f.Pc=282;continue;}
case 282:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",285);}
case 285:{f.StackOp("pop");f.Pc=286;continue;}
case 286:{f.Push(f.Locals[2]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",290);}
case 290:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3189(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Duration")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/ability/effects/CloneEffect","checkValidDuration","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokestatic",10);}
case 10:{f.Pc=f.Pop().Int!=0?14:13;continue;}
case 13:{return JStep.ReturnVoid;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",23);}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=27;continue;}
case 27:{f.StackOp("dup");f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",37);}
case 37:{f.Locals[5]=f.Pop();f.Pc=39;continue;}
case 39:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",42);}
case 42:{f.Locals[6]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("PumpKeywords")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?75:53;continue;}
case 53:{f.Push(f.Locals[6]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("PumpKeywords")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",61);}
case 61:{f.Push(JValue.R(rt.String(" & ")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",66);}
case 66:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",69);}
case 69:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",74);}
case 74:{f.StackOp("pop");f.Pc=75;continue;}
case 75:{f.Push(JValue.R(null));f.Pc=76;continue;}
case 76:{f.Locals[7]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("Choices")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int==0?287:87;continue;}
case 87:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=90;continue;}
case 90:{f.Locals[8]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?112:101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",107);}
case 107:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",110);}
case 110:{f.Locals[8]=f.Pop();f.Pc=112;continue;}
case 112:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=115;continue;}
case 115:{f.StackOp("dup");f.Pc=116;continue;}
case 116:{f.Push(f.Locals[5]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[8]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",123);}
case 123:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",126);}
case 126:{f.Locals[9]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(JValue.R(null));f.Pc=129;continue;}
case 129:{f.Locals[10]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/spellability/SpellAbility","isReplacementAbility","()Z","invokevirtual",135);}
case 135:{f.Pc=f.Pop().Int==0?175:138;continue;}
case 138:{f.Push(f.Locals[8]);f.Pc=140;continue;}
case 140:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",146);}
case 146:{f.Pc=f.Pop().Int==0?158:149;continue;}
case 149:{f.Push(f.Locals[1]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateBattlefield","()Lforge/game/card/CardCollection;","invokevirtual",153);}
case 153:{f.Locals[10]=f.Pop();f.Pc=155;continue;}
case 155:{f.Pc=175;continue;}
case 158:{f.Push(f.Locals[8]);f.Pc=160;continue;}
case 160:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",166);}
case 166:{f.Pc=f.Pop().Int==0?175:169;continue;}
case 169:{f.Push(f.Locals[1]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateGraveyard","()Lforge/game/card/CardCollection;","invokevirtual",173);}
case 173:{f.Locals[10]=f.Pop();f.Pc=175;continue;}
case 175:{f.Push(f.Locals[10]);f.Pc=177;continue;}
case 177:{f.Pc=f.Pop().Reference!=null?199:180;continue;}
case 180:{f.Push(f.Locals[9]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{f.Push(JValue.R(rt.String("Choices")));f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",188);}
case 188:{f.Push(f.Locals[3]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[2]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[1]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",194);}
case 194:{f.Locals[9]=f.Pop();f.Pc=196;continue;}
case 196:{f.Pc=219;continue;}
case 199:{f.Push(f.Locals[9]);f.Pc=201;continue;}
case 201:{f.Push(f.Locals[10]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[1]);f.Pc=204;continue;}
case 204:{f.Push(JValue.R(rt.String("Choices")));f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",209);}
case 209:{f.Push(f.Locals[3]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[2]);f.Pc=211;continue;}
case 211:{f.Push(f.Locals[1]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",215);}
case 215:{return rt.Call(f,"forge/game/card/CardCollection","retainAll","(Ljava/util/Collection;)Z","invokevirtual",218);}
case 218:{f.StackOp("pop");f.Pc=219;continue;}
case 219:{f.Push(f.Locals[1]);f.Pc=220;continue;}
case 220:{f.Push(JValue.R(rt.String("ChoiceOptional")));f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",225);}
case 225:{f.Locals[11]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(f.Locals[1]);f.Pc=228;continue;}
case 228:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",233);}
case 233:{f.Pc=f.Pop().Int==0?245:236;continue;}
case 236:{f.Push(f.Locals[1]);f.Pc=237;continue;}
case 237:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",242);}
case 242:{f.Pc=262;continue;}
case 245:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",248);}
case 248:{f.Push(JValue.R(rt.String("lblChooseaCard")));f.Pc=250;continue;}
case 250:{f.Push(JValue.I(0));f.Pc=251;continue;}
case 251:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",257);}
case 257:{return rt.DynamicCall(f,"forge/game/ability/effects/CloneEffect:3189:257:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",262);}
case 262:{f.Locals[12]=f.Pop();f.Pc=264;continue;}
case 264:{f.Push(f.Locals[3]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",268);}
case 268:{f.Push(f.Locals[9]);f.Pc=270;continue;}
case 270:{f.Push(f.Locals[1]);f.Pc=271;continue;}
case 271:{f.Push(f.Locals[12]);f.Pc=273;continue;}
case 273:{f.Push(f.Locals[11]);f.Pc=275;continue;}
case 275:{f.Push(JValue.R(null));f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",279);}
case 279:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=282;continue;}
case 282:{f.Locals[7]=f.Pop();f.Pc=284;continue;}
case 284:{f.Pc=383;continue;}
case 287:{f.Push(f.Locals[1]);f.Pc=288;continue;}
case 288:{f.Push(JValue.R(rt.String("Defined")));f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",293);}
case 293:{f.Pc=f.Pop().Int==0?335:296;continue;}
case 296:{f.Push(f.Locals[2]);f.Pc=297;continue;}
case 297:{f.Push(f.Locals[1]);f.Pc=298;continue;}
case 298:{f.Push(JValue.R(rt.String("Defined")));f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",303);}
case 303:{f.Push(f.Locals[1]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",307);}
case 307:{f.Locals[8]=f.Pop();f.Pc=309;continue;}
case 309:{f.Push(f.Locals[8]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",316);}
case 316:{f.Pc=f.Pop().Int!=0?332:319;continue;}
case 319:{f.Push(f.Locals[8]);f.Pc=321;continue;}
case 321:{f.Push(JValue.I(0));f.Pc=322;continue;}
case 322:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",327);}
case 327:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=330;continue;}
case 330:{f.Locals[7]=f.Pop();f.Pc=332;continue;}
case 332:{f.Pc=383;continue;}
case 335:{f.Push(f.Locals[1]);f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",339);}
case 339:{f.Pc=f.Pop().Int==0?351:342;continue;}
case 342:{f.Push(f.Locals[1]);f.Pc=343;continue;}
case 343:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetCard","()Lforge/game/card/Card;","invokevirtual",346);}
case 346:{f.Locals[7]=f.Pop();f.Pc=348;continue;}
case 348:{f.Pc=383;continue;}
case 351:{f.Push(f.Locals[1]);f.Pc=352;continue;}
case 352:{f.Push(JValue.R(rt.String("CopyFromChosenName")));f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",357);}
case 357:{f.Pc=f.Pop().Int==0?383:360;continue;}
case 360:{f.Push(f.Locals[2]);f.Pc=361;continue;}
case 361:{return rt.Call(f,"forge/game/card/Card","getNamedCard","()Ljava/lang/String;","invokevirtual",364);}
case 364:{f.Locals[8]=f.Pop();f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",369);}
case 369:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",372);}
case 372:{f.Push(f.Locals[8]);f.Pc=374;continue;}
case 374:{return rt.Call(f,"forge/card/CardDb","getUniqueByName","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",377);}
case 377:{f.Push(f.Locals[3]);f.Pc=378;continue;}
case 378:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",381);}
case 381:{f.Locals[7]=f.Pop();f.Pc=383;continue;}
case 383:{f.Push(f.Locals[7]);f.Pc=385;continue;}
case 385:{f.Pc=f.Pop().Reference!=null?389:388;continue;}
case 388:{return JStep.ReturnVoid;}
case 389:{f.Push(f.Locals[1]);f.Pc=390;continue;}
case 390:{f.Push(JValue.R(rt.String("Optional")));f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",396);}
case 396:{f.Locals[8]=f.Pop();f.Pc=398;continue;}
case 398:{f.Push(f.Locals[8]);f.Pc=400;continue;}
case 400:{f.Pc=f.Pop().Int==0?443:403;continue;}
case 403:{f.Push(f.Locals[2]);f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",407);}
case 407:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",410);}
case 410:{f.Push(f.Locals[1]);f.Pc=411;continue;}
case 411:{f.Push(JValue.R(null));f.Pc=412;continue;}
case 412:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",415);}
case 415:{f.Push(JValue.R(rt.String("lblDoYouWantCopy")));f.Pc=418;continue;}
case 418:{f.Push(JValue.I(1));f.Pc=419;continue;}
case 419:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=422;continue;}
case 422:{f.StackOp("dup");f.Pc=423;continue;}
case 423:{f.Push(JValue.I(0));f.Pc=424;continue;}
case 424:{f.Push(f.Locals[7]);f.Pc=426;continue;}
case 426:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",429);}
case 429:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=430;continue;}
case 430:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",433);}
case 433:{f.Push(f.Locals[7]);f.Pc=435;continue;}
case 435:{f.Push(JValue.R(null));f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",439);}
case 439:{f.Pc=f.Pop().Int!=0?443:442;continue;}
case 442:{return JStep.ReturnVoid;}
case 443:{f.Push(f.Locals[1]);f.Pc=444;continue;}
case 444:{f.Push(JValue.R(rt.String("CloneTarget")));f.Pc=446;continue;}
case 446:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",449);}
case 449:{f.Pc=f.Pop().Int==0?476:452;continue;}
case 452:{f.Push(f.Locals[2]);f.Pc=453;continue;}
case 453:{f.Push(f.Locals[1]);f.Pc=454;continue;}
case 454:{f.Push(JValue.R(rt.String("CloneTarget")));f.Pc=456;continue;}
case 456:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",459);}
case 459:{f.Push(f.Locals[1]);f.Pc=460;continue;}
case 460:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",463);}
case 463:{f.Locals[4]=f.Pop();f.Pc=465;continue;}
case 465:{f.Push(f.Locals[4]);f.Pc=467;continue;}
case 467:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",472);}
case 472:{f.Pc=f.Pop().Int==0?516:475;continue;}
case 475:{return JStep.ReturnVoid;}
case 476:{f.Push(f.Locals[1]);f.Pc=477;continue;}
case 477:{f.Push(JValue.R(rt.String("Choices")));f.Pc=479;continue;}
case 479:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",482);}
case 482:{f.Pc=f.Pop().Int==0?507:485;continue;}
case 485:{f.Push(f.Locals[1]);f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",489);}
case 489:{f.Pc=f.Pop().Int==0?507:492;continue;}
case 492:{f.Push(f.Locals[4]);f.Pc=494;continue;}
case 494:{f.Push(f.Locals[1]);f.Pc=495;continue;}
case 495:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetCard","()Lforge/game/card/Card;","invokevirtual",498);}
case 498:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",503);}
case 503:{f.StackOp("pop");f.Pc=504;continue;}
case 504:{f.Pc=516;continue;}
case 507:{f.Push(f.Locals[4]);f.Pc=509;continue;}
case 509:{f.Push(f.Locals[2]);f.Pc=510;continue;}
case 510:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",515);}
case 515:{f.StackOp("pop");f.Pc=516;continue;}
case 516:{f.Push(f.Locals[4]);f.Pc=518;continue;}
case 518:{f.Push(f.Locals[7]);f.Pc=520;continue;}
case 520:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",525);}
case 525:{f.Pc=f.Pop().Int==0?548:528;continue;}
case 528:{f.Push(f.Locals[1]);f.Pc=529;continue;}
case 529:{f.Push(JValue.R(rt.String("ExcludeChosen")));f.Pc=532;continue;}
case 532:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",535);}
case 535:{f.Pc=f.Pop().Int==0?548:538;continue;}
case 538:{f.Push(f.Locals[4]);f.Pc=540;continue;}
case 540:{f.Push(f.Locals[7]);f.Pc=542;continue;}
case 542:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",547);}
case 547:{f.StackOp("pop");f.Pc=548;continue;}
case 548:{f.Push(f.Locals[5]);f.Pc=550;continue;}
case 550:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",553);}
case 553:{f.Locals[9]=f.Pop();f.Pc=555;continue;}
case 555:{f.Push(f.Locals[4]);f.Pc=557;continue;}
case 557:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",562);}
case 562:{f.Locals[11]=f.Pop();f.Pc=564;continue;}
case 564:{f.Push(f.Locals[11]);f.Pc=566;continue;}
case 566:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",571);}
case 571:{f.Pc=f.Pop().Int==0?862:574;continue;}
case 574:{f.Push(f.Locals[11]);f.Pc=576;continue;}
case 576:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",581);}
case 581:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=584;continue;}
case 584:{f.Locals[12]=f.Pop();f.Pc=586;continue;}
case 586:{f.Push(f.Locals[1]);f.Pc=587;continue;}
case 587:{f.Push(JValue.R(rt.String("CloneZone")));f.Pc=590;continue;}
case 590:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",593);}
case 593:{f.Pc=f.Pop().Int==0?617:596;continue;}
case 596:{f.Push(f.Locals[12]);f.Pc=598;continue;}
case 598:{f.Push(f.Locals[1]);f.Pc=599;continue;}
case 599:{f.Push(JValue.R(rt.String("CloneZone")));f.Pc=602;continue;}
case 602:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",605);}
case 605:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",608);}
case 608:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",611);}
case 611:{f.Pc=f.Pop().Int!=0?617:614;continue;}
case 614:{f.Pc=564;continue;}
case 617:{f.Push(f.Locals[12]);f.Pc=619;continue;}
case 619:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",622);}
case 622:{f.Pc=f.Pop().Int==0?628:625;continue;}
case 625:{f.Pc=564;continue;}
case 628:{f.Push(f.Locals[5]);f.Pc=630;continue;}
case 630:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",633);}
case 633:{f.Push(f.Locals[12]);f.Pc=635;continue;}
case 635:{f.Push(JValue.R(null));f.Pc=636;continue;}
case 636:{return rt.Call(f,"forge/game/trigger/TriggerHandler","clearActiveTriggers","(Lforge/game/card/Card;Lforge/game/zone/Zone;)V","invokevirtual",639);}
case 639:{f.Push(f.Locals[12]);f.Pc=641;continue;}
case 641:{f.Push(f.Locals[7]);f.Pc=643;continue;}
case 643:{f.Push(f.Locals[12]);f.Pc=645;continue;}
case 645:{f.Push(f.Locals[1]);f.Pc=646;continue;}
case 646:{return rt.Call(f,"forge/game/card/CardFactory","getCloneStates","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCloneStates;","invokestatic",649);}
case 649:{f.Push(f.Locals[9]);f.Pc=651;continue;}
case 651:{return rt.Call(f,"forge/game/card/Card","addCloneState","(Lforge/game/card/CardCloneStates;J)V","invokevirtual",654);}
case 654:{f.Push(f.Locals[12]);f.Pc=656;continue;}
case 656:{return rt.Call(f,"forge/game/card/Card","updateRooms","()V","invokevirtual",659);}
case 659:{f.Push(f.Locals[1]);f.Pc=660;continue;}
case 660:{f.Push(JValue.R(rt.String("IntoPlayTapped")));f.Pc=663;continue;}
case 663:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",666);}
case 666:{f.Pc=f.Pop().Int==0?675:669;continue;}
case 669:{f.Push(f.Locals[12]);f.Pc=671;continue;}
case 671:{f.Push(JValue.I(1));f.Pc=672;continue;}
case 672:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",675);}
case 675:{f.Push(f.Locals[6]);f.Pc=677;continue;}
case 677:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",682);}
case 682:{f.Pc=f.Pop().Int!=0?707:685;continue;}
case 685:{f.Push(f.Locals[12]);f.Pc=687;continue;}
case 687:{f.Push(f.Locals[6]);f.Pc=689;continue;}
case 689:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",692);}
case 692:{f.Push(JValue.I(0));f.Pc=693;continue;}
case 693:{f.Push(f.Locals[9]);f.Pc=695;continue;}
case 695:{f.Push(JValue.R(null));f.Pc=696;continue;}
case 696:{return rt.Call(f,"forge/game/card/Card","addChangedCardKeywords","(Ljava/util/List;Ljava/util/List;ZJLforge/game/staticability/StaticAbility;)V","invokevirtual",699);}
case 699:{f.Push(f.Locals[1]);f.Pc=700;continue;}
case 700:{f.Push(f.Locals[12]);f.Pc=702;continue;}
case 702:{f.Push(f.Locals[9]);f.Pc=704;continue;}
case 704:{return rt.Call(f,"forge/game/ability/effects/TokenEffectBase","addPumpUntil","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;J)V","invokestatic",707);}
case 707:{f.Push(f.Locals[12]);f.Pc=709;continue;}
case 709:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",712);}
case 712:{f.Push(f.Locals[2]);f.Pc=713;continue;}
case 713:{f.Push(f.Locals[12]);f.Pc=715;continue;}
case 715:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",718);}
case 718:{f.Pc=f.Pop().Int==0?741:721;continue;}
case 721:{f.Push(f.Locals[1]);f.Pc=722;continue;}
case 722:{f.Push(JValue.R(rt.String("ImprintRememberedNoCleanup")));f.Pc=725;continue;}
case 725:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",728);}
case 728:{f.Pc=f.Pop().Int!=0?741:731;continue;}
case 731:{f.Push(f.Locals[12]);f.Pc=733;continue;}
case 733:{return rt.Call(f,"forge/game/card/Card","clearImprintedCards","()V","invokevirtual",736);}
case 736:{f.Push(f.Locals[12]);f.Pc=738;continue;}
case 738:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",741);}
case 741:{f.Push(f.Locals[1]);f.Pc=742;continue;}
case 742:{f.Push(JValue.R(rt.String("Duration")));f.Pc=744;continue;}
case 744:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",747);}
case 747:{f.Pc=f.Pop().Int==0?808:750;continue;}
case 750:{f.Push(f.Locals[12]);f.Pc=752;continue;}
case 752:{f.Locals[13]=f.Pop();f.Pc=754;continue;}
case 754:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=757;continue;}
case 757:{f.StackOp("dup");f.Pc=758;continue;}
case 758:{f.Push(f.Locals[12]);f.Pc=760;continue;}
case 760:{return rt.Call(f,"forge/game/card/Card","getImprintedCards","()Lforge/game/card/CardCollectionView;","invokevirtual",763);}
case 763:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",766);}
case 766:{f.Locals[14]=f.Pop();f.Pc=768;continue;}
case 768:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=771;continue;}
case 771:{f.StackOp("dup");f.Pc=772;continue;}
case 772:{f.Push(f.Locals[12]);f.Pc=774;continue;}
case 774:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",777);}
case 777:{return rt.Call(f,"forge/util/collect/FCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",780);}
case 780:{f.Locals[15]=f.Pop();f.Pc=782;continue;}
case 782:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/CloneEffect$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/CloneEffect$1")));f.Pc=785;continue;}
case 785:{f.StackOp("dup");f.Pc=786;continue;}
case 786:{f.Push(f.Locals[0]);f.Pc=787;continue;}
case 787:{f.Push(f.Locals[13]);f.Pc=789;continue;}
case 789:{f.Push(f.Locals[9]);f.Pc=791;continue;}
case 791:{f.Push(f.Locals[14]);f.Pc=793;continue;}
case 793:{f.Push(f.Locals[15]);f.Pc=795;continue;}
case 795:{f.Push(f.Locals[5]);f.Pc=797;continue;}
case 797:{return rt.Call(f,"forge/game/ability/effects/CloneEffect$1","<init>","(Lforge/game/ability/effects/CloneEffect;Lforge/game/card/Card;JLjava/lang/Iterable;Ljava/lang/Iterable;Lforge/game/Game;)V","invokespecial",800);}
case 800:{f.Locals[16]=f.Pop();f.Pc=802;continue;}
case 802:{f.Push(f.Locals[1]);f.Pc=803;continue;}
case 803:{f.Push(f.Locals[16]);f.Pc=805;continue;}
case 805:{return rt.Call(f,"forge/game/ability/effects/CloneEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;)V","invokestatic",808);}
case 808:{f.Push(f.Locals[12]);f.Pc=810;continue;}
case 810:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",813);}
case 813:{f.Push(f.Locals[12]);f.Pc=815;continue;}
case 815:{return rt.Call(f,"forge/game/card/Card","clearImprintedCards","()V","invokevirtual",818);}
case 818:{f.Push(f.Locals[1]);f.Pc=819;continue;}
case 819:{f.Push(JValue.R(rt.String("RememberCloneOrigin")));f.Pc=822;continue;}
case 822:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",825);}
case 825:{f.Pc=f.Pop().Int==0?835:828;continue;}
case 828:{f.Push(f.Locals[12]);f.Pc=830;continue;}
case 830:{f.Push(f.Locals[7]);f.Pc=832;continue;}
case 832:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",835);}
case 835:{f.Push(f.Locals[12]);f.Pc=837;continue;}
case 837:{f.Push(f.Locals[7]);f.Pc=839;continue;}
case 839:{return rt.Call(f,"forge/game/card/Card","getMarkedColors","()Lforge/card/ColorSet;","invokevirtual",842);}
case 842:{return rt.Call(f,"forge/game/card/Card","setMarkedColors","(Lforge/card/ColorSet;)V","invokevirtual",845);}
case 845:{f.Push(f.Locals[5]);f.Pc=847;continue;}
case 847:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=850;continue;}
case 850:{f.StackOp("dup");f.Pc=851;continue;}
case 851:{f.Push(f.Locals[12]);f.Pc=853;continue;}
case 853:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",856);}
case 856:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",859);}
case 859:{f.Pc=564;continue;}
case 862:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
