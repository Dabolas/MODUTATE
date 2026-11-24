// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C268{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/CountersPutAllEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3261,"forge/game/ability/effects/CountersPutAllEffect","<init>","()V",1,1,1,new JHandler[]{},M3261));
c.Add(new JMethod(3262,"forge/game/ability/effects/CountersPutAllEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,6,4,new JHandler[]{},M3262));
c.Add(new JMethod(3263,"forge/game/ability/effects/CountersPutAllEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,18,5,new JHandler[]{},M3263));
}

internal static JStep M3261(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3262(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",22);}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("CounterNum")));f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("1")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",30);}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",34);}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("ValidZone")));f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Locals[5]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("Put ")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",62);}
case 62:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",65);}
case 65:{return rt.DynamicCall(f,"forge/game/ability/effects/CountersPutAllEffect:3262:65:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",70);}
case 70:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",73);}
case 73:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",76);}
case 76:{f.StackOp("pop");f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String(" on each ")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",83);}
case 83:{f.StackOp("pop");f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("ValidCardsDesc")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?112:93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("ValidCardsDesc")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",100);}
case 100:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",103);}
case 103:{f.Push(JValue.R(rt.String(".")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",108);}
case 108:{f.StackOp("pop");f.Pc=109;continue;}
case 109:{f.Pc=156;continue;}
case 112:{f.Push(f.Locals[2]);f.Pc=113;continue;}
case 113:{f.Push(JValue.R(rt.String("valid ")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",118);}
case 118:{f.StackOp("pop");f.Pc=119;continue;}
case 119:{f.Push(f.Locals[5]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int==0?139:129;continue;}
case 129:{f.Push(f.Locals[2]);f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("permanent.")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",135);}
case 135:{f.StackOp("pop");f.Pc=136;continue;}
case 136:{f.Pc=156;continue;}
case 139:{f.Push(f.Locals[2]);f.Pc=140;continue;}
case 140:{f.Push(JValue.R(rt.String("card in ")));f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",145);}
case 145:{f.Push(f.Locals[5]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",150);}
case 150:{f.Push(JValue.R(rt.String(".")));f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",155);}
case 155:{f.StackOp("pop");f.Pc=156;continue;}
case 156:{f.Push(f.Locals[2]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",160);}
case 160:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3263(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("CounterType")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("CounterNum")));f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("1")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",30);}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",34);}
case 34:{f.Locals[5]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",42);}
case 42:{f.Locals[6]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("ValidZone")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?65:53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("ValidZone")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",59);}
case 59:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",62);}
case 62:{f.Pc=68;continue;}
case 65:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=68;continue;}
case 68:{f.Locals[7]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",74);}
case 74:{f.Locals[8]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{f.Pc=f.Pop().Int>0?82:81;continue;}
case 81:{return JStep.ReturnVoid;}
case 82:{f.Push(f.Locals[8]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[7]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",89);}
case 89:{f.Locals[9]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[9]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[6]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[3]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",101);}
case 101:{f.Locals[9]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int==0?128:110;continue;}
case 110:{f.Push(f.Locals[1]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",114);}
case 114:{return rt.Call(f,"forge/game/spellability/TargetChoices","getFirstTargetedPlayer","()Lforge/game/player/Player;","invokevirtual",117);}
case 117:{f.Locals[10]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(f.Locals[9]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[10]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",126);}
case 126:{f.Locals[9]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[3]);f.Pc=129;continue;}
case 129:{f.Locals[10]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(JValue.R(rt.String("")));f.Pc=133;continue;}
case 133:{f.Locals[11]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{f.Push(JValue.R(rt.String("Placer")));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",141);}
case 141:{f.Pc=f.Pop().Int==0?202:144;continue;}
case 144:{f.Push(f.Locals[1]);f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.String("Placer")));f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",150);}
case 150:{f.Locals[12]=f.Pop();f.Pc=152;continue;}
case 152:{f.Push(f.Locals[12]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("Controller")));f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",159);}
case 159:{f.Pc=f.Pop().Int==0?169:162;continue;}
case 162:{f.Push(JValue.R(rt.String("Controller")));f.Pc=164;continue;}
case 164:{f.Locals[11]=f.Pop();f.Pc=166;continue;}
case 166:{f.Pc=202;continue;}
case 169:{f.Push(f.Locals[12]);f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.String("Owner")));f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",176);}
case 176:{f.Pc=f.Pop().Int==0?186:179;continue;}
case 179:{f.Push(JValue.R(rt.String("Owner")));f.Pc=181;continue;}
case 181:{f.Locals[11]=f.Pop();f.Pc=183;continue;}
case 183:{f.Pc=202;continue;}
case 186:{f.Push(f.Locals[2]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[12]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[1]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",193);}
case 193:{f.Push(JValue.I(0));f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",197);}
case 197:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=200;continue;}
case 200:{f.Locals[10]=f.Pop();f.Pc=202;continue;}
case 202:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=205;continue;}
case 205:{f.StackOp("dup");f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",209);}
case 209:{f.Locals[12]=f.Pop();f.Pc=211;continue;}
case 211:{f.Push(f.Locals[9]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",218);}
case 218:{f.Locals[13]=f.Pop();f.Pc=220;continue;}
case 220:{f.Push(f.Locals[13]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",227);}
case 227:{f.Pc=f.Pop().Int==0?398:230;continue;}
case 230:{f.Push(f.Locals[13]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",237);}
case 237:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=240;continue;}
case 240:{f.Locals[14]=f.Pop();f.Pc=242;continue;}
case 242:{f.Push(f.Locals[11]);f.Pc=244;continue;}
case 244:{f.Push(JValue.R(rt.String("Controller")));f.Pc=246;continue;}
case 246:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",249);}
case 249:{f.Pc=f.Pop().Int==0?262:252;continue;}
case 252:{f.Push(f.Locals[14]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",257);}
case 257:{f.Locals[10]=f.Pop();f.Pc=259;continue;}
case 259:{f.Pc=279;continue;}
case 262:{f.Push(f.Locals[11]);f.Pc=264;continue;}
case 264:{f.Push(JValue.R(rt.String("Owner")));f.Pc=266;continue;}
case 266:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",269);}
case 269:{f.Pc=f.Pop().Int==0?279:272;continue;}
case 272:{f.Push(f.Locals[14]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",277);}
case 277:{f.Locals[10]=f.Pop();f.Pc=279;continue;}
case 279:{f.Push(f.Locals[1]);f.Pc=280;continue;}
case 280:{f.Push(JValue.R(rt.String("AmountByChosenMap")));f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",285);}
case 285:{f.Pc=f.Pop().Int==0?382:288;continue;}
case 288:{f.Push(f.Locals[1]);f.Pc=289;continue;}
case 289:{f.Push(JValue.R(rt.String("AmountByChosenMap")));f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",294);}
case 294:{f.Push(JValue.R(rt.String(" INDEX ")));f.Pc=296;continue;}
case 296:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",299);}
case 299:{f.Locals[15]=f.Pop();f.Pc=301;continue;}
case 301:{f.Push(f.Locals[15]);f.Pc=303;continue;}
case 303:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=304;continue;}
case 304:{f.Push(JValue.I(1));f.Pc=305;continue;}
case 305:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?318:308;continue;}
case 308:{f.Push(f.Locals[15]);f.Pc=310;continue;}
case 310:{f.Push(JValue.I(1));f.Pc=311;continue;}
case 311:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=312;continue;}
case 312:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",315);}
case 315:{f.Pc=319;continue;}
case 318:{f.Push(JValue.I(0));f.Pc=319;continue;}
case 319:{f.Locals[16]=f.Pop();f.Pc=321;continue;}
case 321:{f.Push(f.Locals[16]);f.Pc=323;continue;}
case 323:{f.Push(f.Locals[2]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/card/Card","getChosenMap","()Ljava/util/Map;","invokevirtual",327);}
case 327:{f.Push(f.Locals[10]);f.Pc=329;continue;}
case 329:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",334);}
case 334:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",340);}
case 340:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?346:343;continue;}
case 343:{f.Pc=220;continue;}
case 346:{f.Push(f.Locals[2]);f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/card/Card","getChosenMap","()Ljava/util/Map;","invokevirtual",350);}
case 350:{f.Push(f.Locals[10]);f.Pc=352;continue;}
case 352:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",357);}
case 357:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=360;continue;}
case 360:{f.Push(f.Locals[16]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",365);}
case 365:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=368;continue;}
case 368:{f.Locals[17]=f.Pop();f.Pc=370;continue;}
case 370:{f.Push(f.Locals[17]);f.Pc=372;continue;}
case 372:{f.Push(f.Locals[15]);f.Pc=374;continue;}
case 374:{f.Push(JValue.I(0));f.Pc=375;continue;}
case 375:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=376;continue;}
case 376:{f.Push(f.Locals[1]);f.Pc=377;continue;}
case 377:{return rt.Call(f,"forge/game/ability/AbilityUtils","xCount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",380);}
case 380:{f.Locals[5]=f.Pop();f.Pc=382;continue;}
case 382:{f.Push(f.Locals[14]);f.Pc=384;continue;}
case 384:{f.Push(f.Locals[4]);f.Pc=386;continue;}
case 386:{f.Push(f.Locals[5]);f.Pc=388;continue;}
case 388:{f.Push(f.Locals[10]);f.Pc=390;continue;}
case 390:{f.Push(f.Locals[12]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",395);}
case 395:{f.Pc=220;continue;}
case 398:{f.Push(f.Locals[1]);f.Pc=399;continue;}
case 399:{f.Push(JValue.R(rt.String("ValidCards2")));f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",404);}
case 404:{f.Pc=f.Pop().Int!=0?425:407;continue;}
case 407:{f.Push(f.Locals[1]);f.Pc=408;continue;}
case 408:{f.Push(JValue.R(rt.String("CounterType2")));f.Pc=410;continue;}
case 410:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",413);}
case 413:{f.Pc=f.Pop().Int!=0?425:416;continue;}
case 416:{f.Push(f.Locals[1]);f.Pc=417;continue;}
case 417:{f.Push(JValue.R(rt.String("CounterNum2")));f.Pc=419;continue;}
case 419:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",422);}
case 422:{f.Pc=f.Pop().Int==0?617:425;continue;}
case 425:{f.Push(f.Locals[1]);f.Pc=426;continue;}
case 426:{f.Push(JValue.R(rt.String("CounterType2")));f.Pc=428;continue;}
case 428:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",431);}
case 431:{f.Pc=f.Pop().Int==0?446:434;continue;}
case 434:{f.Push(f.Locals[1]);f.Pc=435;continue;}
case 435:{f.Push(JValue.R(rt.String("CounterType2")));f.Pc=437;continue;}
case 437:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",440);}
case 440:{return rt.Call(f,"forge/game/card/CounterType","getType","(Ljava/lang/String;)Lforge/game/card/CounterType;","invokestatic",443);}
case 443:{f.Pc=448;continue;}
case 446:{f.Push(f.Locals[4]);f.Pc=448;continue;}
case 448:{f.Locals[13]=f.Pop();f.Pc=450;continue;}
case 450:{f.Push(f.Locals[1]);f.Pc=451;continue;}
case 451:{f.Push(JValue.R(rt.String("ValidZone2")));f.Pc=453;continue;}
case 453:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",456);}
case 456:{f.Pc=f.Pop().Int==0?471:459;continue;}
case 459:{f.Push(f.Locals[1]);f.Pc=460;continue;}
case 460:{f.Push(JValue.R(rt.String("ValidZone2")));f.Pc=462;continue;}
case 462:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",465);}
case 465:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",468);}
case 468:{f.Pc=473;continue;}
case 471:{f.Push(f.Locals[7]);f.Pc=473;continue;}
case 473:{f.Locals[14]=f.Pop();f.Pc=475;continue;}
case 475:{f.Push(f.Locals[1]);f.Pc=476;continue;}
case 476:{f.Push(JValue.R(rt.String("ValidCards2")));f.Pc=478;continue;}
case 478:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",481);}
case 481:{f.Pc=f.Pop().Int==0?526:484;continue;}
case 484:{f.Push(f.Locals[8]);f.Pc=486;continue;}
case 486:{f.Push(f.Locals[14]);f.Pc=488;continue;}
case 488:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",491);}
case 491:{f.Push(f.Locals[1]);f.Pc=492;continue;}
case 492:{f.Push(JValue.R(rt.String("ValidCards2")));f.Pc=494;continue;}
case 494:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",497);}
case 497:{f.Push(f.Locals[3]);f.Pc=498;continue;}
case 498:{f.Push(f.Locals[2]);f.Pc=499;continue;}
case 499:{f.Push(f.Locals[1]);f.Pc=500;continue;}
case 500:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",503);}
case 503:{f.Locals[9]=f.Pop();f.Pc=505;continue;}
case 505:{f.Push(f.Locals[1]);f.Pc=506;continue;}
case 506:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",509);}
case 509:{f.Pc=f.Pop().Int==0?526:512;continue;}
case 512:{f.Push(f.Locals[9]);f.Pc=514;continue;}
case 514:{f.Push(f.Locals[1]);f.Pc=515;continue;}
case 515:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",518);}
case 518:{return rt.Call(f,"forge/game/spellability/TargetChoices","getFirstTargetedPlayer","()Lforge/game/player/Player;","invokevirtual",521);}
case 521:{return rt.Call(f,"forge/game/card/CardLists","filterControlledBy","(Ljava/lang/Iterable;Lforge/game/player/Player;)Lforge/game/card/CardCollection;","invokestatic",524);}
case 524:{f.Locals[9]=f.Pop();f.Pc=526;continue;}
case 526:{f.Push(f.Locals[1]);f.Pc=527;continue;}
case 527:{f.Push(JValue.R(rt.String("CounterNum2")));f.Pc=529;continue;}
case 529:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",532);}
case 532:{f.Pc=f.Pop().Int==0?549:535;continue;}
case 535:{f.Push(f.Locals[2]);f.Pc=536;continue;}
case 536:{f.Push(f.Locals[1]);f.Pc=537;continue;}
case 537:{f.Push(JValue.R(rt.String("CounterNum2")));f.Pc=539;continue;}
case 539:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",542);}
case 542:{f.Push(f.Locals[1]);f.Pc=543;continue;}
case 543:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",546);}
case 546:{f.Pc=551;continue;}
case 549:{f.Push(f.Locals[5]);f.Pc=551;continue;}
case 551:{f.Locals[15]=f.Pop();f.Pc=553;continue;}
case 553:{f.Push(f.Locals[9]);f.Pc=555;continue;}
case 555:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",560);}
case 560:{f.Locals[16]=f.Pop();f.Pc=562;continue;}
case 562:{f.Push(f.Locals[16]);f.Pc=564;continue;}
case 564:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",569);}
case 569:{f.Pc=f.Pop().Int==0?617:572;continue;}
case 572:{f.Push(f.Locals[16]);f.Pc=574;continue;}
case 574:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",579);}
case 579:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=582;continue;}
case 582:{f.Locals[17]=f.Pop();f.Pc=584;continue;}
case 584:{f.Push(f.Locals[11]);f.Pc=586;continue;}
case 586:{f.Push(JValue.R(rt.String("Controller")));f.Pc=588;continue;}
case 588:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",591);}
case 591:{f.Pc=f.Pop().Int==0?601:594;continue;}
case 594:{f.Push(f.Locals[17]);f.Pc=596;continue;}
case 596:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",599);}
case 599:{f.Locals[10]=f.Pop();f.Pc=601;continue;}
case 601:{f.Push(f.Locals[17]);f.Pc=603;continue;}
case 603:{f.Push(f.Locals[13]);f.Pc=605;continue;}
case 605:{f.Push(f.Locals[15]);f.Pc=607;continue;}
case 607:{f.Push(f.Locals[10]);f.Pc=609;continue;}
case 609:{f.Push(f.Locals[12]);f.Pc=611;continue;}
case 611:{return rt.Call(f,"forge/game/card/Card","addCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;Lforge/game/GameEntityCounterTable;)V","invokevirtual",614);}
case 614:{f.Pc=562;continue;}
case 617:{f.Push(f.Locals[12]);f.Pc=619;continue;}
case 619:{f.Push(f.Locals[8]);f.Pc=621;continue;}
case 621:{f.Push(f.Locals[1]);f.Pc=622;continue;}
case 622:{return rt.Call(f,"forge/game/GameEntityCounterTable","replaceCounterEffect","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",625);}
case 625:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
