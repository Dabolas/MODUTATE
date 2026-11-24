// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C331{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ManaReflectedEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3490,"forge/game/ability/effects/ManaReflectedEffect","<init>","()V",1,1,1,new JHandler[]{},M3490));
c.Add(new JMethod(3491,"forge/game/ability/effects/ManaReflectedEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V",1,2,5,new JHandler[]{},M3491));
c.Add(new JMethod(3492,"forge/game/ability/effects/ManaReflectedEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,8,5,new JHandler[]{},M3492));
c.Add(new JMethod(3493,"forge/game/ability/effects/ManaReflectedEffect","generatedReflectedMana","(Lforge/game/spellability/SpellAbility;Ljava/util/Collection;Lforge/game/player/Player;)Ljava/lang/String;",10,11,5,new JHandler[]{},M3493));
}

internal static JStep M3490(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3491(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AbilityManaPart"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AbilityManaPart")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","<init>","(Lforge/game/spellability/SpellAbility;Ljava/util/Map;)V","invokespecial",18);}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","setManaPart","(Lforge/game/spellability/AbilityManaPart;)V","invokevirtual",21);}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParent","()Lforge/game/spellability/SpellAbility;","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Reference!=null?33:28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","setUndoable","(Z)V","invokevirtual",33);}
case 33:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3492(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardUtil","getReflectableManaColors","(Lforge/game/spellability/SpellAbility;)Ljava/util/Set;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getManaPart","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?36:18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","isUndoable","()Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?36:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Reference!=null?36:32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{f.Pc=37;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","setUndoable","(Z)V","invokevirtual",40);}
case 40:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=43;continue;}
case 43:{f.StackOp("dup");f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",47);}
case 47:{f.Locals[4]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/ability/effects/ManaReflectedEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",53);}
case 53:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",56);}
case 56:{f.Locals[5]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int==0?107:68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",75);}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{f.Locals[6]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[6]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/ability/effects/ManaReflectedEffect","generatedReflectedMana","(Lforge/game/spellability/SpellAbility;Ljava/util/Collection;Lforge/game/player/Player;)Ljava/lang/String;","invokestatic",87);}
case 87:{f.Locals[7]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[3]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[7]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[6]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","produceMana","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",100);}
case 100:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",103);}
case 103:{f.StackOp("pop");f.Pc=104;continue;}
case 104:{f.Pc=58;continue;}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",112);}
case 112:{f.Push(f.Locals[4]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",117);}
case 117:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","tapsForMana","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)V","invokevirtual",120);}
case 120:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3493(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Amount")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?26:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",13);}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Amount")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",23);}
case 23:{f.Pc=27;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{f.Locals[3]=f.Pop();f.Pc=28;continue;}
case 28:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",35);}
case 35:{f.Locals[4]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","getManaPart","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",41);}
case 41:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isComboMana","()Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int==0?189:47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",51);}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/card/ColorSet","fromNames","(Ljava/lang/Iterable;)Lforge/card/ColorSet;","invokestatic",56);}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/player/PlayerController","specifyManaCombo","(Lforge/game/spellability/SpellAbility;Lforge/card/ColorSet;IZ)Ljava/util/Map;","invokevirtual",61);}
case 61:{f.Locals[5]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",70);}
case 70:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",75);}
case 75:{f.Locals[6]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[6]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",84);}
case 84:{f.Pc=f.Pop().Int==0?183:87;continue;}
case 87:{f.Push(f.Locals[6]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",94);}
case 94:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=97;continue;}
case 97:{f.Locals[7]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[7]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",106);}
case 106:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Byte"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=109;continue;}
case 109:{f.Locals[8]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(f.Locals[8]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/lang/Byte","byteValue","()B","invokevirtual",116);}
case 116:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",119);}
case 119:{f.Locals[9]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[7]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",128);}
case 128:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=131;continue;}
case 131:{f.Locals[10]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[10]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",138);}
case 138:{f.Pc=f.Pop().Int<=0?180:141;continue;}
case 141:{f.Push(f.Locals[4]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",146);}
case 146:{f.Pc=f.Pop().Int<=0?157:149;continue;}
case 149:{f.Push(f.Locals[4]);f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String(" ")));f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",156);}
case 156:{f.StackOp("pop");f.Pc=157;continue;}
case 157:{f.Push(f.Locals[4]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[9]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",164);}
case 164:{f.StackOp("pop");f.Pc=165;continue;}
case 165:{f.Push(f.Locals[10]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",170);}
case 170:{f.Push(JValue.I(1));f.Pc=171;continue;}
case 171:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",175);}
case 175:{f.Locals[10]=f.Pop();f.Pc=177;continue;}
case 177:{f.Pc=133;continue;}
case 180:{f.Pc=77;continue;}
case 183:{f.Push(f.Locals[4]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",188);}
case 188:{return JStep.Return(f.Pop());}
case 189:{f.Push(f.Locals[0]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/spellability/SpellAbility","getManaPart","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",193);}
case 193:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getExpressChoice","()Ljava/lang/String;","invokevirtual",196);}
case 196:{f.Locals[6]=f.Pop();f.Pc=198;continue;}
case 198:{f.Push(JValue.R(null));f.Pc=199;continue;}
case 199:{f.Locals[7]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(JValue.I(0));f.Pc=202;continue;}
case 202:{f.Locals[8]=f.Pop();f.Pc=204;continue;}
case 204:{f.Push(JValue.I(0));f.Pc=205;continue;}
case 205:{f.Locals[9]=f.Pop();f.Pc=207;continue;}
case 207:{f.Push(f.Locals[9]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[6]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",214);}
case 214:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?239:217;continue;}
case 217:{f.Push(f.Locals[8]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[6]);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[9]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",226);}
case 226:{return rt.Call(f,"forge/card/MagicColor","fromName","(C)B","invokestatic",229);}
case 229:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=230;continue;}
case 230:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=231;continue;}
case 231:{f.Locals[8]=f.Pop();f.Pc=233;continue;}
case 233:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=236;continue;}
case 236:{f.Pc=207;continue;}
case 239:{f.Push(f.Locals[8]);f.Pc=241;continue;}
case 241:{f.Pc=f.Pop().Int!=0?299:244;continue;}
case 244:{f.Push(f.Locals[6]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",249);}
case 249:{f.Pc=f.Pop().Int!=0?299:252;continue;}
case 252:{f.Push(f.Locals[1]);f.Pc=253;continue;}
case 253:{f.Push(JValue.R(rt.String("colorless")));f.Pc=255;continue;}
case 255:{return rt.Call(f,"java/util/Collection","contains","(Ljava/lang/Object;)Z","invokeinterface",260);}
case 260:{f.Pc=f.Pop().Int==0?299:263;continue;}
case 263:{f.Push(f.Locals[2]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",267);}
case 267:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",270);}
case 270:{f.Push(JValue.R(rt.String("lblSelectManaProduce")));f.Pc=272;continue;}
case 272:{f.Push(JValue.I(0));f.Pc=273;continue;}
case 273:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",279);}
case 279:{f.Push(f.Locals[0]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",283);}
case 283:{f.Push(f.Locals[8]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",288);}
case 288:{return rt.Call(f,"forge/game/player/PlayerController","chooseColorAllowColorless","(Ljava/lang/String;Lforge/game/card/Card;Lforge/card/ColorSet;)B","invokevirtual",291);}
case 291:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",294);}
case 294:{f.Locals[5]=f.Pop();f.Pc=296;continue;}
case 296:{f.Pc=497;continue;}
case 299:{f.Push(f.Locals[8]);f.Pc=301;continue;}
case 301:{f.Pc=f.Pop().Int!=0?426:304;continue;}
case 304:{f.Push(f.Locals[1]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",310);}
case 310:{f.Pc=f.Pop().Int==0?316:313;continue;}
case 313:{f.Push(JValue.R(rt.String("0")));f.Pc=315;continue;}
case 315:{return JStep.Return(f.Pop());}
case 316:{f.Push(f.Locals[1]);f.Pc=317;continue;}
case 317:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",322);}
case 322:{f.Push(JValue.I(1));f.Pc=323;continue;}
case 323:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?348:326;continue;}
case 326:{f.Push(f.Locals[1]);f.Pc=327;continue;}
case 327:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",332);}
case 332:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",337);}
case 337:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/card/MagicColor","toShortString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",343);}
case 343:{f.Locals[5]=f.Pop();f.Pc=345;continue;}
case 345:{f.Pc=497;continue;}
case 348:{f.Push(f.Locals[1]);f.Pc=349;continue;}
case 349:{f.Push(JValue.R(rt.String("colorless")));f.Pc=351;continue;}
case 351:{return rt.Call(f,"java/util/Collection","contains","(Ljava/lang/Object;)Z","invokeinterface",356);}
case 356:{f.Pc=f.Pop().Int==0?394:359;continue;}
case 359:{f.Push(f.Locals[2]);f.Pc=360;continue;}
case 360:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",363);}
case 363:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",366);}
case 366:{f.Push(JValue.R(rt.String("lblSelectManaProduce")));f.Pc=368;continue;}
case 368:{f.Push(JValue.I(0));f.Pc=369;continue;}
case 369:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",375);}
case 375:{f.Push(f.Locals[0]);f.Pc=376;continue;}
case 376:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",379);}
case 379:{f.Push(f.Locals[1]);f.Pc=380;continue;}
case 380:{return rt.Call(f,"forge/card/ColorSet","fromNames","(Ljava/lang/Iterable;)Lforge/card/ColorSet;","invokestatic",383);}
case 383:{return rt.Call(f,"forge/game/player/PlayerController","chooseColorAllowColorless","(Ljava/lang/String;Lforge/game/card/Card;Lforge/card/ColorSet;)B","invokevirtual",386);}
case 386:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",389);}
case 389:{f.Locals[5]=f.Pop();f.Pc=391;continue;}
case 391:{f.Pc=497;continue;}
case 394:{f.Push(f.Locals[2]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",398);}
case 398:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",401);}
case 401:{f.Push(JValue.R(rt.String("lblSelectManaProduce")));f.Pc=403;continue;}
case 403:{f.Push(JValue.I(0));f.Pc=404;continue;}
case 404:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=407;continue;}
case 407:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",410);}
case 410:{f.Push(f.Locals[0]);f.Pc=411;continue;}
case 411:{f.Push(f.Locals[1]);f.Pc=412;continue;}
case 412:{return rt.Call(f,"forge/card/ColorSet","fromNames","(Ljava/lang/Iterable;)Lforge/card/ColorSet;","invokestatic",415);}
case 415:{return rt.Call(f,"forge/game/player/PlayerController","chooseColor","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/card/ColorSet;)B","invokevirtual",418);}
case 418:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",421);}
case 421:{f.Locals[5]=f.Pop();f.Pc=423;continue;}
case 423:{f.Pc=497;continue;}
case 426:{f.Push(f.Locals[8]);f.Pc=428;continue;}
case 428:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",431);}
case 431:{f.Locals[7]=f.Pop();f.Pc=433;continue;}
case 433:{f.Push(f.Locals[0]);f.Pc=434;continue;}
case 434:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",437);}
case 437:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",440);}
case 440:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",443);}
case 443:{f.Push(JValue.R(rt.String("lblSelectManaProduce")));f.Pc=445;continue;}
case 445:{f.Push(JValue.I(0));f.Pc=446;continue;}
case 446:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=449;continue;}
case 449:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",452);}
case 452:{f.Push(f.Locals[0]);f.Pc=453;continue;}
case 453:{f.Push(f.Locals[7]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/player/PlayerController","chooseColor","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/card/ColorSet;)B","invokevirtual",458);}
case 458:{f.Locals[9]=f.Pop();f.Pc=460;continue;}
case 460:{f.Push(f.Locals[9]);f.Pc=462;continue;}
case 462:{f.Pc=f.Pop().Int!=0?490:465;continue;}
case 465:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=468;continue;}
case 468:{f.Push(f.Locals[0]);f.Pc=469;continue;}
case 469:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",472);}
case 472:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",475);}
case 475:{f.Push(f.Locals[0]);f.Pc=476;continue;}
case 476:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",479);}
case 479:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",482);}
case 482:{return rt.DynamicCall(f,"forge/game/ability/effects/ManaReflectedEffect:3493:482:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",487);}
case 487:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",490);}
case 490:{f.Push(f.Locals[9]);f.Pc=492;continue;}
case 492:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",495);}
case 495:{f.Locals[5]=f.Pop();f.Pc=497;continue;}
case 497:{f.Push(f.Locals[3]);f.Pc=498;continue;}
case 498:{f.Pc=f.Pop().Int!=0?512:501;continue;}
case 501:{f.Push(f.Locals[4]);f.Pc=503;continue;}
case 503:{f.Push(JValue.R(rt.String("0")));f.Pc=505;continue;}
case 505:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",508);}
case 508:{f.StackOp("pop");f.Pc=509;continue;}
case 509:{f.Pc=576;continue;}
case 512:{f.Push(f.Locals[5]);f.Pc=514;continue;}
case 514:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",517);}
case 517:{f.Pc=f.Pop().Int==0?540:520;continue;}
case 520:{f.Push(f.Locals[5]);f.Pc=522;continue;}
case 522:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",525);}
case 525:{f.Locals[9]=f.Pop();f.Pc=527;continue;}
case 527:{f.Push(f.Locals[4]);f.Pc=529;continue;}
case 529:{f.Push(f.Locals[9]);f.Pc=531;continue;}
case 531:{f.Push(f.Locals[3]);f.Pc=532;continue;}
case 532:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=533;continue;}
case 533:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",536);}
case 536:{f.StackOp("pop");f.Pc=537;continue;}
case 537:{f.Pc=576;continue;}
case 540:{f.Push(JValue.I(0));f.Pc=541;continue;}
case 541:{f.Locals[9]=f.Pop();f.Pc=543;continue;}
case 543:{f.Push(f.Locals[9]);f.Pc=545;continue;}
case 545:{f.Push(f.Locals[3]);f.Pc=546;continue;}
case 546:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?576:549;continue;}
case 549:{f.Push(f.Locals[9]);f.Pc=551;continue;}
case 551:{f.Pc=f.Pop().Int==0?562:554;continue;}
case 554:{f.Push(f.Locals[4]);f.Pc=556;continue;}
case 556:{f.Push(JValue.R(rt.String(" ")));f.Pc=558;continue;}
case 558:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",561);}
case 561:{f.StackOp("pop");f.Pc=562;continue;}
case 562:{f.Push(f.Locals[4]);f.Pc=564;continue;}
case 564:{f.Push(f.Locals[5]);f.Pc=566;continue;}
case 566:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",569);}
case 569:{f.StackOp("pop");f.Pc=570;continue;}
case 570:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=573;continue;}
case 573:{f.Pc=543;continue;}
case 576:{f.Push(f.Locals[4]);f.Pc=578;continue;}
case 578:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",581);}
case 581:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
