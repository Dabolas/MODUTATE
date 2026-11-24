// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C295{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DrawEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3363,"forge/game/ability/effects/DrawEffect","<init>","()V",1,1,1,new JHandler[]{},M3363));
c.Add(new JMethod(3364,"forge/game/ability/effects/DrawEffect","movesCardToOrFromLibrary","(Lforge/game/spellability/SpellAbility;)Z",1,2,1,new JHandler[]{},M3364));
c.Add(new JMethod(3365,"forge/game/ability/effects/DrawEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,6,5,new JHandler[]{},M3365));
c.Add(new JMethod(3366,"forge/game/ability/effects/DrawEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,12,10,new JHandler[]{},M3366));
}

internal static JStep M3363(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3364(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3365(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("IfDesc")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?83:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("IfDesc")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",23);}
case 23:{f.Push(JValue.R(rt.String("True")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?65:31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?65:40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",46);}
case 46:{f.Locals[3]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String(",")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",56);}
case 56:{f.Push(JValue.I(1));f.Pc=57;continue;}
case 57:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;","invokevirtual",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Pc=76;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("IfDesc")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",72);}
case 72:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String(" ")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/ability/effects/DrawEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",87);}
case 87:{f.Locals[3]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[3]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",94);}
case 94:{f.Pc=f.Pop().Int!=0?263:97;continue;}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",103);}
case 103:{f.Pc=f.Pop().Int==0?123:106;continue;}
case 106:{f.Push(f.Locals[1]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",110);}
case 110:{f.Push(f.Locals[1]);f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",116);}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",120);}
case 120:{f.Pc=124;continue;}
case 123:{f.Push(JValue.I(1));f.Pc=124;continue;}
case 124:{f.Locals[4]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[3]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",131);}
case 131:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",134);}
case 134:{f.StackOp("pop");f.Pc=135;continue;}
case 135:{f.Push(f.Locals[3]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",141);}
case 141:{f.Push(JValue.I(1));f.Pc=142;continue;}
case 142:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?152:145;continue;}
case 145:{f.Push(f.Locals[2]);f.Pc=146;continue;}
case 146:{f.Push(JValue.R(rt.String(" each")));f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",151);}
case 151:{f.StackOp("pop");f.Pc=152;continue;}
case 152:{f.Push(f.Locals[2]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[3]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String(" draw")));f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/util/Lang","joinVerb","(Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;","invokestatic",159);}
case 159:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",162);}
case 162:{f.Push(JValue.R(rt.String(" ")));f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",167);}
case 167:{f.StackOp("pop");f.Pc=168;continue;}
case 168:{f.Push(f.Locals[1]);f.Pc=169;continue;}
case 169:{f.Push(JValue.R(rt.String("NumCardsDesc")));f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",174);}
case 174:{f.Pc=f.Pop().Int!=0?199:177;continue;}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[1]);f.Pc=179;continue;}
case 179:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",184);}
case 184:{return rt.Call(f,"forge/game/ability/effects/DrawEffect","isAmountDeferred","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z","invokestatic",187);}
case 187:{f.Pc=f.Pop().Int==0?199:190;continue;}
case 190:{f.Push(f.Locals[1]);f.Pc=191;continue;}
case 191:{f.Push(JValue.R(rt.String("draws? ((?:a|an|\\w+) cards? (?:for each|equal to)[^.]*)")));f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/ability/effects/DrawEffect","amountTextFromCard","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/lang/String;","invokestatic",196);}
case 196:{f.Pc=200;continue;}
case 199:{f.Push(JValue.R(null));f.Pc=200;continue;}
case 200:{f.Locals[5]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[2]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[1]);f.Pc=204;continue;}
case 204:{f.Push(JValue.R(rt.String("NumCardsDesc")));f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",209);}
case 209:{f.Pc=f.Pop().Int==0?221:212;continue;}
case 212:{f.Push(f.Locals[1]);f.Pc=213;continue;}
case 213:{f.Push(JValue.R(rt.String("NumCardsDesc")));f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",218);}
case 218:{f.Pc=252;continue;}
case 221:{f.Push(f.Locals[5]);f.Pc=223;continue;}
case 223:{f.Pc=f.Pop().Reference==null?231:226;continue;}
case 226:{f.Push(f.Locals[5]);f.Pc=228;continue;}
case 228:{f.Pc=252;continue;}
case 231:{f.Push(f.Locals[4]);f.Pc=233;continue;}
case 233:{f.Push(JValue.I(1));f.Pc=234;continue;}
case 234:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?242:237;continue;}
case 237:{f.Push(JValue.R(rt.String("a card")));f.Pc=239;continue;}
case 239:{f.Pc=252;continue;}
case 242:{f.Push(f.Locals[4]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",247);}
case 247:{return rt.DynamicCall(f,"forge/game/ability/effects/DrawEffect:3365:247:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",252);}
case 252:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",255);}
case 255:{f.StackOp("pop");f.Pc=256;continue;}
case 256:{f.Push(f.Locals[2]);f.Pc=257;continue;}
case 257:{f.Push(JValue.R(rt.String(".")));f.Pc=259;continue;}
case 259:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",262);}
case 262:{f.StackOp("pop");f.Pc=263;continue;}
case 263:{f.Push(f.Locals[2]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",267);}
case 267:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3366(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?31:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",18);}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("NumCards")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",28);}
case 28:{f.Pc=32;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("Upto")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",39);}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("OptionalDecider")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int!=0?55:50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{f.Pc=f.Pop().Int==0?59:55;continue;}
case 55:{f.Push(JValue.I(1));f.Pc=56;continue;}
case 56:{f.Pc=60;continue;}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{f.Locals[5]=f.Pop();f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",65);}
case 65:{f.Locals[6]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateBattlefield","()Lforge/game/card/CardCollection;","invokevirtual",76);}
case 76:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",81);}
case 81:{f.StackOp("pop");f.Pc=82;continue;}
case 82:{f.Push(f.Locals[6]);f.Pc=84;continue;}
case 84:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateGraveyard","()Lforge/game/card/CardCollection;","invokevirtual",91);}
case 91:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",96);}
case 96:{f.StackOp("pop");f.Pc=97;continue;}
case 97:{f.Push(JValue.I(1));f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("Defined")));f.Pc=100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/ability/effects/DrawEffect","getTargetPlayersWithDuplicates","(ZLjava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",104);}
case 104:{f.Locals[7]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[7]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"com/google/common/collect/Sets","newLinkedHashSet","(Ljava/lang/Iterable;)Ljava/util/LinkedHashSet;","invokestatic",111);}
case 111:{return rt.Call(f,"java/util/LinkedHashSet","iterator","()Ljava/util/Iterator;","invokevirtual",114);}
case 114:{f.Locals[8]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[8]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",123);}
case 123:{f.Pc=f.Pop().Int==0?353:126;continue;}
case 126:{f.Push(f.Locals[8]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",133);}
case 133:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=136;continue;}
case 136:{f.Locals[9]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[9]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",143);}
case 143:{f.Pc=f.Pop().Int!=0?149:146;continue;}
case 146:{f.Pc=116;continue;}
case 149:{f.Push(f.Locals[3]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[7]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[9]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/util/Collections","frequency","(Ljava/util/Collection;Ljava/lang/Object;)I","invokestatic",157);}
case 157:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=158;continue;}
case 158:{f.Locals[10]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[5]);f.Pc=162;continue;}
case 162:{f.Pc=f.Pop().Int==0?183:165;continue;}
case 165:{f.Push(f.Locals[4]);f.Pc=167;continue;}
case 167:{f.Pc=f.Pop().Int!=0?183:170;continue;}
case 170:{f.Push(f.Locals[9]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[10]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/player/Player","canDraw","(I)Z","invokevirtual",177);}
case 177:{f.Pc=f.Pop().Int!=0?183:180;continue;}
case 180:{f.Pc=116;continue;}
case 183:{f.Push(f.Locals[5]);f.Pc=185;continue;}
case 185:{f.Pc=f.Pop().Int==0?227:188;continue;}
case 188:{f.Push(f.Locals[9]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",193);}
case 193:{f.Push(f.Locals[1]);f.Pc=194;continue;}
case 194:{f.Push(JValue.R(null));f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",198);}
case 198:{f.Push(JValue.R(rt.String("lblDoYouWantDrawCards")));f.Pc=200;continue;}
case 200:{f.Push(JValue.I(1));f.Pc=201;continue;}
case 201:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=204;continue;}
case 204:{f.StackOp("dup");f.Pc=205;continue;}
case 205:{f.Push(JValue.I(0));f.Pc=206;continue;}
case 206:{f.Push(f.Locals[10]);f.Pc=208;continue;}
case 208:{f.Push(JValue.R(rt.String(" card")));f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/util/Lang","nounWithAmount","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",213);}
case 213:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",217);}
case 217:{f.Push(JValue.R(null));f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",221);}
case 221:{f.Pc=f.Pop().Int!=0?227:224;continue;}
case 224:{f.Pc=116;continue;}
case 227:{f.Push(f.Locals[4]);f.Pc=229;continue;}
case 229:{f.Pc=f.Pop().Int==0?241:232;continue;}
case 232:{f.Push(f.Locals[9]);f.Pc=234;continue;}
case 234:{f.Push(f.Locals[10]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantDraw","canDrawAmount","(Lforge/game/player/Player;I)I","invokestatic",239);}
case 239:{f.Locals[10]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(f.Locals[10]);f.Pc=243;continue;}
case 243:{f.Pc=f.Pop().Int>0?249:246;continue;}
case 246:{f.Pc=116;continue;}
case 249:{f.Push(f.Locals[4]);f.Pc=251;continue;}
case 251:{f.Pc=f.Pop().Int==0?280:254;continue;}
case 254:{f.Push(f.Locals[9]);f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",259);}
case 259:{f.Push(f.Locals[1]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",263);}
case 263:{f.Push(JValue.R(rt.String("lblHowManyCardDoYouWantDraw")));f.Pc=265;continue;}
case 265:{f.Push(JValue.I(0));f.Pc=266;continue;}
case 266:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",272);}
case 272:{f.Push(JValue.I(0));f.Pc=273;continue;}
case 273:{f.Push(f.Locals[10]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;II)I","invokevirtual",278);}
case 278:{f.Locals[10]=f.Pop();f.Pc=280;continue;}
case 280:{f.Push(f.Locals[9]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[10]);f.Pc=284;continue;}
case 284:{f.Push(f.Locals[1]);f.Pc=285;continue;}
case 285:{f.Push(f.Locals[6]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/player/Player","drawCards","(ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",290);}
case 290:{f.Locals[11]=f.Pop();f.Pc=292;continue;}
case 292:{f.Push(f.Locals[1]);f.Pc=293;continue;}
case 293:{f.Push(JValue.R(rt.String("Reveal")));f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",298);}
case 298:{f.Pc=f.Pop().Int==0?335:301;continue;}
case 301:{f.Push(f.Locals[9]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",306);}
case 306:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",309);}
case 309:{f.Push(f.Locals[11]);f.Pc=311;continue;}
case 311:{f.Push(f.Locals[9]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[1]);f.Pc=314;continue;}
case 314:{f.Push(JValue.R(rt.String("Reveal")));f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",319);}
case 319:{f.Push(JValue.R(rt.String("All")));f.Pc=321;continue;}
case 321:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",324);}
case 324:{f.Pc=f.Pop().Int!=0?331:327;continue;}
case 327:{f.Push(JValue.I(1));f.Pc=328;continue;}
case 328:{f.Pc=332;continue;}
case 331:{f.Push(JValue.I(0));f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/player/Player;Z)V","invokevirtual",335);}
case 335:{f.Push(f.Locals[1]);f.Pc=336;continue;}
case 336:{f.Push(JValue.R(rt.String("RememberDrawn")));f.Pc=338;continue;}
case 338:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",341);}
case 341:{f.Pc=f.Pop().Int==0?350:344;continue;}
case 344:{f.Push(f.Locals[2]);f.Pc=345;continue;}
case 345:{f.Push(f.Locals[11]);f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",350);}
case 350:{f.Pc=116;continue;}
case 353:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
