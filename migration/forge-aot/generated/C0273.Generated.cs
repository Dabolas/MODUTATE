// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C273{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DamageAllEffect","forge/game/ability/effects/DamageBaseEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3284,"forge/game/ability/effects/DamageAllEffect","<init>","()V",1,1,1,new JHandler[]{},M3284));
c.Add(new JMethod(3285,"forge/game/ability/effects/DamageAllEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,8,3,new JHandler[]{},M3285));
c.Add(new JMethod(3286,"forge/game/ability/effects/DamageAllEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,17,6,new JHandler[]{},M3286));
c.Add(new JMethod(3287,"forge/game/ability/effects/DamageAllEffect","lambda$getStackDescription$0","(Ljava/lang/String;)Ljava/lang/String;",4106,1,2,new JHandler[]{},M3287));
}

internal static JStep M3284(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/DamageBaseEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3285(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("ValidDescription")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?26:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("ValidDescription")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",23);}
case 23:{f.Pc=69;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?67:35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",41);}
case 41:{f.Push(JValue.R(rt.String(",")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",46);}
case 46:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",49);}
case 49:{return rt.DynamicCall(f,"forge/game/ability/effects/DamageAllEffect:3285:49:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",54);}
case 54:{f.Push(JValue.R(rt.String("or")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;","invokestatic",59);}
case 59:{return rt.DynamicCall(f,"forge/game/ability/effects/DamageAllEffect:3285:59:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",64);}
case 64:{f.Pc=69;continue;}
case 67:{f.Push(JValue.R(rt.String("something")));f.Pc=69;continue;}
case 69:{f.Locals[3]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.String("NumDmg")));f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",76);}
case 76:{f.Locals[4]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",82);}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",88);}
case 88:{f.Locals[5]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("DamageSource")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",96);}
case 96:{f.Locals[6]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",102);}
case 102:{f.Push(f.Locals[6]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",108);}
case 108:{f.Locals[7]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[7]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",117);}
case 117:{f.Pc=f.Pop().Int!=0?169:120;continue;}
case 120:{f.Push(f.Locals[7]);f.Pc=122;continue;}
case 122:{f.Push(JValue.I(0));f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",128);}
case 128:{f.Push(f.Locals[1]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",132);}
case 132:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?142:135;continue;}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilitySub")?1:0));f.Pc=139;continue;}
case 139:{f.Pc=f.Pop().Int==0?169:142;continue;}
case 142:{f.Push(f.Locals[2]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[7]);f.Pc=145;continue;}
case 145:{f.Push(JValue.I(0));f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",151);}
case 151:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",157);}
case 157:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",160);}
case 160:{f.Push(JValue.R(rt.String(" deals")));f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",165);}
case 165:{f.StackOp("pop");f.Pc=166;continue;}
case 166:{f.Pc=196;continue;}
case 169:{f.Push(JValue.R(rt.String("ParentTarget")));f.Pc=171;continue;}
case 171:{f.Push(f.Locals[6]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",176);}
case 176:{f.Pc=f.Pop().Int==0?189:179;continue;}
case 179:{f.Push(f.Locals[2]);f.Pc=180;continue;}
case 180:{f.Push(JValue.R(rt.String("Target creature deals")));f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",185);}
case 185:{f.StackOp("pop");f.Pc=186;continue;}
case 186:{f.Pc=196;continue;}
case 189:{f.Push(f.Locals[2]);f.Pc=190;continue;}
case 190:{f.Push(JValue.R(rt.String("Deals")));f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",195);}
case 195:{f.StackOp("pop");f.Pc=196;continue;}
case 196:{f.Push(f.Locals[2]);f.Pc=197;continue;}
case 197:{f.Push(JValue.R(rt.String(" ")));f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",202);}
case 202:{f.Push(f.Locals[5]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",207);}
case 207:{f.Push(JValue.R(rt.String(" damage to ")));f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",212);}
case 212:{f.Push(f.Locals[3]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",216);}
case 216:{f.Push(f.Locals[3]);f.Pc=217;continue;}
case 217:{f.Push(JValue.R(rt.String(".")));f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",222);}
case 222:{f.Pc=f.Pop().Int==0?230:225;continue;}
case 225:{f.Push(JValue.R(rt.String("")));f.Pc=227;continue;}
case 227:{f.Pc=232;continue;}
case 230:{f.Push(JValue.R(rt.String(".")));f.Pc=232;continue;}
case 232:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",235);}
case 235:{f.StackOp("pop");f.Pc=236;continue;}
case 236:{f.Push(f.Locals[2]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",240);}
case 240:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3286(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("DamageSource")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",24);}
case 24:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=27;continue;}
case 27:{f.Locals[4]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",34);}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/Game","getChangeZoneLKIInfo","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",39);}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",48);}
case 48:{f.Locals[6]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("NumDmg")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",57);}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",61);}
case 61:{f.Locals[7]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",67);}
case 67:{return rt.Call(f,"forge/game/spellability/TargetChoices","getFirstTargetedPlayer","()Lforge/game/player/Player;","invokevirtual",70);}
case 70:{f.Locals[8]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("ValidPlayers")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",78);}
case 78:{f.Locals[9]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int==0?102:89;continue;}
case 89:{f.Push(f.Locals[6]);f.Pc=91;continue;}
case 91:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",97);}
case 97:{f.Locals[10]=f.Pop();f.Pc=99;continue;}
case 99:{f.Pc=107;continue;}
case 102:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=105;continue;}
case 105:{f.Locals[10]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[8]);f.Pc=109;continue;}
case 109:{f.Pc=f.Pop().Reference==null?121:112;continue;}
case 112:{f.Push(f.Locals[10]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[8]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",119);}
case 119:{f.Locals[10]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[10]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",129);}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",133);}
case 133:{f.Locals[10]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(JValue.I(1));f.Pc=136;continue;}
case 136:{f.Locals[11]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDamageMap","()Lforge/game/card/CardDamageTable;","invokevirtual",142);}
case 142:{f.Locals[12]=f.Pop();f.Pc=144;continue;}
case 144:{f.Push(f.Locals[1]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPreventMap","()Lforge/game/card/CardDamageTable;","invokevirtual",148);}
case 148:{f.Locals[13]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[1]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCounterTable","()Lforge/game/GameEntityCounterTable;","invokevirtual",154);}
case 154:{f.Locals[14]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(f.Locals[12]);f.Pc=158;continue;}
case 158:{f.Pc=f.Pop().Reference!=null?191:161;continue;}
case 161:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=164;continue;}
case 164:{f.StackOp("dup");f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","()V","invokespecial",168);}
case 168:{f.Locals[12]=f.Pop();f.Pc=170;continue;}
case 170:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=173;continue;}
case 173:{f.StackOp("dup");f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","()V","invokespecial",177);}
case 177:{f.Locals[13]=f.Pop();f.Pc=179;continue;}
case 179:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=182;continue;}
case 182:{f.StackOp("dup");f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",186);}
case 186:{f.Locals[14]=f.Pop();f.Pc=188;continue;}
case 188:{f.Push(JValue.I(0));f.Pc=189;continue;}
case 189:{f.Locals[11]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(f.Locals[10]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",198);}
case 198:{f.Locals[15]=f.Pop();f.Pc=200;continue;}
case 200:{f.Push(f.Locals[15]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",207);}
case 207:{f.Pc=f.Pop().Int==0?240:210;continue;}
case 210:{f.Push(f.Locals[15]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",217);}
case 217:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=220;continue;}
case 220:{f.Locals[16]=f.Pop();f.Pc=222;continue;}
case 222:{f.Push(f.Locals[12]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[5]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[16]);f.Pc=228;continue;}
case 228:{f.Push(f.Locals[7]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",233);}
case 233:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",236);}
case 236:{f.StackOp("pop");f.Pc=237;continue;}
case 237:{f.Pc=200;continue;}
case 240:{f.Push(f.Locals[9]);f.Pc=242;continue;}
case 242:{f.Pc=f.Pop().Reference==null?298:245;continue;}
case 245:{f.Push(f.Locals[4]);f.Pc=247;continue;}
case 247:{f.Push(f.Locals[9]);f.Pc=249;continue;}
case 249:{f.Push(f.Locals[1]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",253);}
case 253:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",256);}
case 256:{f.Locals[15]=f.Pop();f.Pc=258;continue;}
case 258:{f.Push(f.Locals[15]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",265);}
case 265:{f.Pc=f.Pop().Int==0?298:268;continue;}
case 268:{f.Push(f.Locals[15]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",275);}
case 275:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=278;continue;}
case 278:{f.Locals[16]=f.Pop();f.Pc=280;continue;}
case 280:{f.Push(f.Locals[12]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[5]);f.Pc=284;continue;}
case 284:{f.Push(f.Locals[16]);f.Pc=286;continue;}
case 286:{f.Push(f.Locals[7]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",291);}
case 291:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",294);}
case 294:{f.StackOp("pop");f.Pc=295;continue;}
case 295:{f.Pc=258;continue;}
case 298:{f.Push(f.Locals[11]);f.Pc=300;continue;}
case 300:{f.Pc=f.Pop().Int!=0?319:303;continue;}
case 303:{f.Push(f.Locals[6]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",308);}
case 308:{f.Push(JValue.I(0));f.Pc=309;continue;}
case 309:{f.Push(f.Locals[12]);f.Pc=311;continue;}
case 311:{f.Push(f.Locals[13]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[14]);f.Pc=315;continue;}
case 315:{f.Push(f.Locals[1]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/GameAction","dealDamage","(ZLforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;Lforge/game/GameEntityCounterTable;Lforge/game/spellability/SpellAbility;)V","invokevirtual",319);}
case 319:{f.Push(f.Locals[1]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/ability/effects/DamageAllEffect","replaceDying","(Lforge/game/spellability/SpellAbility;)V","invokestatic",323);}
case 323:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3287(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/Lang","formatValidDesc","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
