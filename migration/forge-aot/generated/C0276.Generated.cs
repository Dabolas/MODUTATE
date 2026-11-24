// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C276{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DamageEachEffect","forge/game/ability/effects/DamageBaseEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3293,"forge/game/ability/effects/DamageEachEffect","<init>","()V",1,1,1,new JHandler[]{},M3293));
c.Add(new JMethod(3294,"forge/game/ability/effects/DamageEachEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,6,3,new JHandler[]{},M3294));
c.Add(new JMethod(3295,"forge/game/ability/effects/DamageEachEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,17,6,new JHandler[]{},M3295));
}

internal static JStep M3293(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/DamageBaseEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3294(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("NumDmg")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?47:32;continue;}
case 32:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",35);}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/util/Lang","describeValidList","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Pc=49;continue;}
case 47:{f.Push(JValue.R(rt.String("")));f.Pc=49;continue;}
case 49:{f.Locals[4]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("ValidDescription")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?68:60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("ValidDescription")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",66);}
case 66:{f.Locals[4]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("")));f.Pc=70;continue;}
case 70:{f.Locals[5]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("DamageDesc")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int==0?92:81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("DamageDesc")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",87);}
case 87:{f.Locals[5]=f.Pop();f.Pc=89;continue;}
case 89:{f.Pc=102;continue;}
case 92:{f.Push(f.Locals[5]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{return rt.DynamicCall(f,"forge/game/ability/effects/DamageEachEffect:3294:95:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;I)Ljava/lang/String;",100);}
case 100:{f.Locals[5]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[2]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("Each ")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",108);}
case 108:{f.Push(f.Locals[4]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",113);}
case 113:{f.Push(JValue.R(rt.String(" deals ")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",118);}
case 118:{f.Push(f.Locals[5]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",123);}
case 123:{f.Push(JValue.R(rt.String(" to ")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",128);}
case 128:{f.StackOp("pop");f.Pc=129;continue;}
case 129:{f.Push(f.Locals[2]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/ability/effects/DamageEachEffect","getTargetEntities","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",134);}
case 134:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",137);}
case 137:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",140);}
case 140:{f.Push(JValue.R(rt.String(".")));f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",145);}
case 145:{f.StackOp("pop");f.Pc=146;continue;}
case 146:{f.Push(f.Locals[2]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",150);}
case 150:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3295(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("NumDmg")));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("X")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("DefinedDamagers")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int==0?45:29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("DefinedDamagers")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",36);}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",40);}
case 40:{f.Locals[5]=f.Pop();f.Pc=42;continue;}
case 42:{f.Pc=82;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",52);}
case 52:{f.Locals[5]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int==0?82:63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",71);}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",75);}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",80);}
case 80:{f.Locals[5]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(JValue.I(1));f.Pc=83;continue;}
case 83:{f.Locals[6]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDamageMap","()Lforge/game/card/CardDamageTable;","invokevirtual",89);}
case 89:{f.Locals[7]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPreventMap","()Lforge/game/card/CardDamageTable;","invokevirtual",95);}
case 95:{f.Locals[8]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCounterTable","()Lforge/game/GameEntityCounterTable;","invokevirtual",101);}
case 101:{f.Locals[9]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[7]);f.Pc=105;continue;}
case 105:{f.Pc=f.Pop().Reference!=null?138:108;continue;}
case 108:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=111;continue;}
case 111:{f.StackOp("dup");f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","()V","invokespecial",115);}
case 115:{f.Locals[7]=f.Pop();f.Pc=117;continue;}
case 117:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=120;continue;}
case 120:{f.StackOp("dup");f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","()V","invokespecial",124);}
case 124:{f.Locals[8]=f.Pop();f.Pc=126;continue;}
case 126:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=129;continue;}
case 129:{f.StackOp("dup");f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",133);}
case 133:{f.Locals[9]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{f.Locals[6]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String("EachToItself")));f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",144);}
case 144:{f.Pc=f.Pop().Int==0?217:147;continue;}
case 147:{f.Push(f.Locals[5]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",154);}
case 154:{f.Locals[10]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[10]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",163);}
case 163:{f.Pc=f.Pop().Int==0?214:166;continue;}
case 166:{f.Push(f.Locals[10]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",173);}
case 173:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=176;continue;}
case 176:{f.Locals[11]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[3]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[11]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/Game","getChangeZoneLKIInfo","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",184);}
case 184:{f.Locals[12]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(f.Locals[11]);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[4]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[1]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",194);}
case 194:{f.Locals[13]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[7]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[12]);f.Pc=200;continue;}
case 200:{f.Push(f.Locals[11]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[13]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",207);}
case 207:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",210);}
case 210:{f.StackOp("pop");f.Pc=211;continue;}
case 211:{f.Pc=156;continue;}
case 214:{f.Pc=517;continue;}
case 217:{f.Push(f.Locals[1]);f.Pc=218;continue;}
case 218:{f.Push(JValue.R(rt.String("ToEachOther")));f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",223);}
case 223:{f.Pc=f.Pop().Int==0?349:226;continue;}
case 226:{f.Push(f.Locals[2]);f.Pc=227;continue;}
case 227:{f.Push(f.Locals[1]);f.Pc=228;continue;}
case 228:{f.Push(JValue.R(rt.String("ToEachOther")));f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",233);}
case 233:{f.Push(f.Locals[1]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",237);}
case 237:{f.Locals[10]=f.Pop();f.Pc=239;continue;}
case 239:{f.Push(f.Locals[10]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",244);}
case 244:{f.Locals[11]=f.Pop();f.Pc=246;continue;}
case 246:{f.Push(f.Locals[11]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",253);}
case 253:{f.Pc=f.Pop().Int==0?346:256;continue;}
case 256:{f.Push(f.Locals[11]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",263);}
case 263:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=266;continue;}
case 266:{f.Locals[12]=f.Pop();f.Pc=268;continue;}
case 268:{f.Push(f.Locals[10]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",273);}
case 273:{f.Locals[13]=f.Pop();f.Pc=275;continue;}
case 275:{f.Push(f.Locals[13]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",282);}
case 282:{f.Pc=f.Pop().Int==0?343:285;continue;}
case 285:{f.Push(f.Locals[13]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",292);}
case 292:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=295;continue;}
case 295:{f.Locals[14]=f.Pop();f.Pc=297;continue;}
case 297:{f.Push(f.Locals[14]);f.Pc=299;continue;}
case 299:{f.Push(f.Locals[12]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",304);}
case 304:{f.Pc=f.Pop().Int!=0?340:307;continue;}
case 307:{f.Push(f.Locals[3]);f.Pc=308;continue;}
case 308:{f.Push(f.Locals[12]);f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/Game","getChangeZoneLKIInfo","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",313);}
case 313:{f.Locals[15]=f.Pop();f.Pc=315;continue;}
case 315:{f.Push(f.Locals[12]);f.Pc=317;continue;}
case 317:{f.Push(f.Locals[4]);f.Pc=319;continue;}
case 319:{f.Push(f.Locals[1]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",323);}
case 323:{f.Locals[16]=f.Pop();f.Pc=325;continue;}
case 325:{f.Push(f.Locals[7]);f.Pc=327;continue;}
case 327:{f.Push(f.Locals[15]);f.Pc=329;continue;}
case 329:{f.Push(f.Locals[14]);f.Pc=331;continue;}
case 331:{f.Push(f.Locals[16]);f.Pc=333;continue;}
case 333:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",336);}
case 336:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",339);}
case 339:{f.StackOp("pop");f.Pc=340;continue;}
case 340:{f.Pc=275;continue;}
case 343:{f.Pc=246;continue;}
case 346:{f.Pc=517;continue;}
case 349:{f.Push(f.Locals[1]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/game/ability/effects/DamageEachEffect","getTargetEntities","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",353);}
case 353:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",358);}
case 358:{f.Locals[10]=f.Pop();f.Pc=360;continue;}
case 360:{f.Push(f.Locals[10]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",367);}
case 367:{f.Pc=f.Pop().Int==0?517:370;continue;}
case 370:{f.Push(f.Locals[10]);f.Pc=372;continue;}
case 372:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",377);}
case 377:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=380;continue;}
case 380:{f.Locals[11]=f.Pop();f.Pc=382;continue;}
case 382:{f.Push(f.Locals[11]);f.Pc=384;continue;}
case 384:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=387;continue;}
case 387:{f.Pc=f.Pop().Int==0?447:390;continue;}
case 390:{f.Push(f.Locals[11]);f.Pc=392;continue;}
case 392:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=395;continue;}
case 395:{f.Locals[12]=f.Pop();f.Pc=397;continue;}
case 397:{f.Push(f.Locals[12]);f.Pc=399;continue;}
case 399:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",402);}
case 402:{f.Pc=f.Pop().Int==0?360:405;continue;}
case 405:{f.Push(f.Locals[12]);f.Pc=407;continue;}
case 407:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",410);}
case 410:{f.Pc=f.Pop().Int==0?416:413;continue;}
case 413:{f.Pc=360;continue;}
case 416:{f.Push(f.Locals[3]);f.Pc=417;continue;}
case 417:{f.Push(f.Locals[12]);f.Pc=419;continue;}
case 419:{f.Push(JValue.R(null));f.Pc=420;continue;}
case 420:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",423);}
case 423:{f.Locals[13]=f.Pop();f.Pc=425;continue;}
case 425:{f.Push(f.Locals[13]);f.Pc=427;continue;}
case 427:{f.Pc=f.Pop().Reference==null?360:430;continue;}
case 430:{f.Push(f.Locals[12]);f.Pc=432;continue;}
case 432:{f.Push(f.Locals[13]);f.Pc=434;continue;}
case 434:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",437);}
case 437:{f.Pc=f.Pop().Int!=0?443:440;continue;}
case 440:{f.Pc=360;continue;}
case 443:{f.Push(f.Locals[13]);f.Pc=445;continue;}
case 445:{f.Locals[11]=f.Pop();f.Pc=447;continue;}
case 447:{f.Push(f.Locals[5]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",454);}
case 454:{f.Locals[12]=f.Pop();f.Pc=456;continue;}
case 456:{f.Push(f.Locals[12]);f.Pc=458;continue;}
case 458:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",463);}
case 463:{f.Pc=f.Pop().Int==0?514:466;continue;}
case 466:{f.Push(f.Locals[12]);f.Pc=468;continue;}
case 468:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",473);}
case 473:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=476;continue;}
case 476:{f.Locals[13]=f.Pop();f.Pc=478;continue;}
case 478:{f.Push(f.Locals[3]);f.Pc=479;continue;}
case 479:{f.Push(f.Locals[13]);f.Pc=481;continue;}
case 481:{return rt.Call(f,"forge/game/Game","getChangeZoneLKIInfo","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",484);}
case 484:{f.Locals[14]=f.Pop();f.Pc=486;continue;}
case 486:{f.Push(f.Locals[13]);f.Pc=488;continue;}
case 488:{f.Push(f.Locals[4]);f.Pc=490;continue;}
case 490:{f.Push(f.Locals[1]);f.Pc=491;continue;}
case 491:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",494);}
case 494:{f.Locals[15]=f.Pop();f.Pc=496;continue;}
case 496:{f.Push(f.Locals[7]);f.Pc=498;continue;}
case 498:{f.Push(f.Locals[14]);f.Pc=500;continue;}
case 500:{f.Push(f.Locals[11]);f.Pc=502;continue;}
case 502:{f.Push(f.Locals[15]);f.Pc=504;continue;}
case 504:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",507);}
case 507:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",510);}
case 510:{f.StackOp("pop");f.Pc=511;continue;}
case 511:{f.Pc=456;continue;}
case 514:{f.Pc=360;continue;}
case 517:{f.Push(f.Locals[6]);f.Pc=519;continue;}
case 519:{f.Pc=f.Pop().Int!=0?537:522;continue;}
case 522:{f.Push(f.Locals[3]);f.Pc=523;continue;}
case 523:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",526);}
case 526:{f.Push(JValue.I(0));f.Pc=527;continue;}
case 527:{f.Push(f.Locals[7]);f.Pc=529;continue;}
case 529:{f.Push(f.Locals[8]);f.Pc=531;continue;}
case 531:{f.Push(f.Locals[9]);f.Pc=533;continue;}
case 533:{f.Push(f.Locals[1]);f.Pc=534;continue;}
case 534:{return rt.Call(f,"forge/game/GameAction","dealDamage","(ZLforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;Lforge/game/GameEntityCounterTable;Lforge/game/spellability/SpellAbility;)V","invokevirtual",537);}
case 537:{f.Push(f.Locals[1]);f.Pc=538;continue;}
case 538:{return rt.Call(f,"forge/game/ability/effects/DamageEachEffect","replaceDying","(Lforge/game/spellability/SpellAbility;)V","invokestatic",541);}
case 541:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
