// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C350{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/PlayEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3544,"forge/game/ability/effects/PlayEffect","<init>","()V",1,1,1,new JHandler[]{},M3544));
c.Add(new JMethod(3545,"forge/game/ability/effects/PlayEffect","movesCardToOrFromLibrary","(Lforge/game/spellability/SpellAbility;)Z",1,2,2,new JHandler[]{},M3545));
c.Add(new JMethod(3546,"forge/game/ability/effects/PlayEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,3,new JHandler[]{},M3546));
c.Add(new JMethod(3547,"forge/game/ability/effects/PlayEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,35,10,new JHandler[]{},M3547));
c.Add(new JMethod(3548,"forge/game/ability/effects/PlayEffect","addReplaceGraveyardEffect","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Ljava/lang/String;)V",9,13,4,new JHandler[]{},M3548));
c.Add(new JMethod(3549,"forge/game/ability/effects/PlayEffect","addIllusionaryMaskReplace","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V",4,16,4,new JHandler[]{},M3549));
c.Add(new JMethod(3550,"forge/game/ability/effects/PlayEffect","$deserializeLambda$","(Ljava/lang/invoke/SerializedLambda;)Ljava/lang/Object;",4106,3,3,new JHandler[]{},M3550));
c.Add(new JMethod(3551,"forge/game/ability/effects/PlayEffect","lambda$addReplaceGraveyardEffect$800dc4e0$1","(Lforge/game/Game;Lforge/game/card/Card;)V",4106,2,2,new JHandler[]{},M3551));
c.Add(new JMethod(3552,"forge/game/ability/effects/PlayEffect","lambda$resolve$4","(Lforge/game/spellability/SpellAbility;)Z",4106,1,2,new JHandler[]{},M3552));
c.Add(new JMethod(3553,"forge/game/ability/effects/PlayEffect","lambda$resolve$3","(Lforge/game/spellability/SpellAbility;)Z",4106,1,1,new JHandler[]{},M3553));
c.Add(new JMethod(3554,"forge/game/ability/effects/PlayEffect","lambda$resolve$2","(Lforge/game/player/Player;[Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;)Z",4106,4,5,new JHandler[]{},M3554));
c.Add(new JMethod(3555,"forge/game/ability/effects/PlayEffect","lambda$resolve$1","(Lforge/game/player/Player;Ljava/util/function/Predicate;Lforge/game/card/Card;)Z",4106,3,5,new JHandler[]{},M3555));
c.Add(new JMethod(3556,"forge/game/ability/effects/PlayEffect","lambda$resolve$0","(Ljava/lang/String;)Ljava/lang/String;",4106,1,3,new JHandler[]{},M3556));
}

internal static JStep M3544(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3545(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidZone")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/ability/effects/PlayEffect","zoneParamIsLibrary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z","invokestatic",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3546(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/player/Player","toString","()Ljava/lang/String;","invokevirtual",16);}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.Push(JValue.R(rt.String(" ")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("ValidSA")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?58:34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("Optional")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?49:44;continue;}
case 44:{f.Push(JValue.R(rt.String("may cast ")));f.Pc=46;continue;}
case 46:{f.Pc=51;continue;}
case 49:{f.Push(JValue.R(rt.String("cast ")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{f.Pc=79;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("Optional")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?73:68;continue;}
case 68:{f.Push(JValue.R(rt.String("may play ")));f.Pc=70;continue;}
case 70:{f.Pc=75;continue;}
case 73:{f.Push(JValue.R(rt.String("plays ")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/ability/effects/PlayEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",83);}
case 83:{f.Locals[3]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("Valid")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?103:93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("cards")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",99);}
case 99:{f.StackOp("pop");f.Pc=100;continue;}
case 100:{f.Pc=135;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("DefinedDesc")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int==0?126:112;continue;}
case 112:{f.Push(f.Locals[2]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("DefinedDesc")));f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",119);}
case 119:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",122);}
case 122:{f.StackOp("pop");f.Pc=123;continue;}
case 123:{f.Pc=135;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[3]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",131);}
case 131:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",134);}
case 134:{f.StackOp("pop");f.Pc=135;continue;}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{f.Push(JValue.R(rt.String("WithoutManaCost")));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",141);}
case 141:{f.Pc=f.Pop().Int==0?176:144;continue;}
case 144:{f.Push(f.Locals[2]);f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.String(" without paying ")));f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",150);}
case 150:{f.Push(f.Locals[3]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",156);}
case 156:{f.Push(JValue.I(1));f.Pc=157;continue;}
case 157:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?165:160;continue;}
case 160:{f.Push(JValue.R(rt.String("its")));f.Pc=162;continue;}
case 162:{f.Pc=167;continue;}
case 165:{f.Push(JValue.R(rt.String("their")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",170);}
case 170:{f.Push(JValue.R(rt.String(" mana cost")));f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",175);}
case 175:{f.StackOp("pop");f.Pc=176;continue;}
case 176:{f.Push(f.Locals[1]);f.Pc=177;continue;}
case 177:{f.Push(JValue.R(rt.String("IfDesc")));f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",182);}
case 182:{f.Pc=f.Pop().Int==0?201:185;continue;}
case 185:{f.Push(f.Locals[2]);f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.String(" ")));f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",191);}
case 191:{f.Push(f.Locals[1]);f.Pc=192;continue;}
case 192:{f.Push(JValue.R(rt.String("IfDesc")));f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",197);}
case 197:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",200);}
case 200:{f.StackOp("pop");f.Pc=201;continue;}
case 201:{f.Push(f.Locals[2]);f.Pc=202;continue;}
case 202:{f.Push(JValue.R(rt.String(".")));f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",207);}
case 207:{f.StackOp("pop");f.Pc=208;continue;}
case 208:{f.Push(f.Locals[2]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",212);}
case 212:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3547(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Optional")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("RememberPlayed")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",24);}
case 24:{f.Locals[5]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("ImprintPlayed")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",32);}
case 32:{f.Locals[6]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("ForgetPlayed")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",40);}
case 40:{f.Locals[7]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("WithTotalCMC")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",48);}
case 48:{f.Locals[8]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("WithoutManaCost")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int!=0?68:59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("PlayCost")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?72:68;continue;}
case 68:{f.Push(JValue.I(1));f.Pc=69;continue;}
case 69:{f.Pc=73;continue;}
case 72:{f.Push(JValue.I(0));f.Pc=73;continue;}
case 73:{f.Locals[9]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("ManaCost")));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("PlayCost")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",83);}
case 83:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",86);}
case 86:{f.Locals[10]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(JValue.I(2147483647));f.Pc=90;continue;}
case 90:{f.Locals[11]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("Controller")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?124:101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("Controller")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",108);}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",112);}
case 112:{f.Push(JValue.I(0));f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",116);}
case 116:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=119;continue;}
case 119:{f.Locals[12]=f.Pop();f.Pc=121;continue;}
case 121:{f.Pc=130;continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",128);}
case 128:{f.Locals[12]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(JValue.L(-1L));f.Pc=133;continue;}
case 133:{f.Locals[13]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(JValue.R(null));f.Pc=136;continue;}
case 136:{f.Locals[15]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String("ControlledByPlayer")));f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",144);}
case 144:{f.Pc=f.Pop().Int==0?173:147;continue;}
case 147:{f.Push(f.Locals[3]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",151);}
case 151:{f.Locals[13]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[2]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[1]);f.Pc=155;continue;}
case 155:{f.Push(JValue.R(rt.String("ControlledByPlayer")));f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",160);}
case 160:{f.Push(f.Locals[1]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",164);}
case 164:{f.Push(JValue.I(0));f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",168);}
case 168:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=171;continue;}
case 171:{f.Locals[15]=f.Pop();f.Pc=173;continue;}
case 173:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=176;continue;}
case 176:{f.StackOp("dup");f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",180);}
case 180:{f.Locals[17]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{f.Push(JValue.R(rt.String("Valid")));f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",188);}
case 188:{f.Pc=f.Pop().Int==0?275:191;continue;}
case 191:{f.Push(f.Locals[1]);f.Pc=192;continue;}
case 192:{f.Push(JValue.R(rt.String("ValidZone")));f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",197);}
case 197:{f.Pc=f.Pop().Int==0?212:200;continue;}
case 200:{f.Push(f.Locals[1]);f.Pc=201;continue;}
case 201:{f.Push(JValue.R(rt.String("ValidZone")));f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",206);}
case 206:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",209);}
case 209:{f.Pc=218;continue;}
case 212:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;)Ljava/util/List;","invokestatic",218);}
case 218:{f.Locals[18]=f.Pop();f.Pc=220;continue;}
case 220:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=223;continue;}
case 223:{f.StackOp("dup");f.Pc=224;continue;}
case 224:{f.Push(f.Locals[3]);f.Pc=225;continue;}
case 225:{f.Push(f.Locals[18]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",230);}
case 230:{f.Push(f.Locals[1]);f.Pc=231;continue;}
case 231:{f.Push(JValue.R(rt.String("Valid")));f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",236);}
case 236:{f.Push(f.Locals[1]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",240);}
case 240:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",243);}
case 243:{f.Locals[16]=f.Pop();f.Pc=245;continue;}
case 245:{f.Push(f.Locals[1]);f.Pc=246;continue;}
case 246:{f.Push(JValue.R(rt.String("ShowCards")));f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",251);}
case 251:{f.Pc=f.Pop().Int==0?272:254;continue;}
case 254:{f.Push(f.Locals[3]);f.Pc=255;continue;}
case 255:{f.Push(f.Locals[18]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",260);}
case 260:{f.Push(f.Locals[1]);f.Pc=261;continue;}
case 261:{f.Push(JValue.R(rt.String("ShowCards")));f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",266);}
case 266:{f.Push(f.Locals[1]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",270);}
case 270:{f.Locals[17]=f.Pop();f.Pc=272;continue;}
case 272:{f.Pc=919;continue;}
case 275:{f.Push(f.Locals[1]);f.Pc=276;continue;}
case 276:{f.Push(JValue.R(rt.String("AnySupportedCard")));f.Pc=278;continue;}
case 278:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",281);}
case 281:{f.Pc=f.Pop().Int==0?722:284;continue;}
case 284:{f.Push(f.Locals[1]);f.Pc=285;continue;}
case 285:{f.Push(JValue.R(rt.String("AnySupportedCard")));f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",290);}
case 290:{f.Locals[18]=f.Pop();f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",295);}
case 295:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",298);}
case 298:{f.Locals[20]=f.Pop();f.Pc=300;continue;}
case 300:{f.Push(f.Locals[18]);f.Pc=302;continue;}
case 302:{f.Push(JValue.R(rt.String("Names:")));f.Pc=304;continue;}
case 304:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",307);}
case 307:{f.Pc=f.Pop().Int==0?357:310;continue;}
case 310:{f.Push(f.Locals[18]);f.Pc=312;continue;}
case 312:{f.Push(JValue.I(6));f.Pc=314;continue;}
case 314:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",317);}
case 317:{f.Push(JValue.R(rt.String(",")));f.Pc=319;continue;}
case 319:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",322);}
case 322:{return rt.Call(f,"java/util/Arrays","stream","([Ljava/lang/Object;)Ljava/util/stream/Stream;","invokestatic",325);}
case 325:{return rt.DynamicCall(f,"forge/game/ability/effects/PlayEffect:3547:325:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",330);}
case 330:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",335);}
case 335:{f.Push(f.Locals[20]);f.Pc=337;continue;}
case 337:{f.StackOp("dup");f.Pc=338;continue;}
case 338:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",341);}
case 341:{f.StackOp("pop");f.Pc=342;continue;}
case 342:{return rt.DynamicCall(f,"forge/game/ability/effects/PlayEffect:3547:342:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardDb;)Ljava/util/function/Function;",347);}
case 347:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",352);}
case 352:{f.Locals[19]=f.Pop();f.Pc=354;continue;}
case 354:{f.Pc=447;continue;}
case 357:{f.Push(f.Locals[18]);f.Pc=359;continue;}
case 359:{f.Push(JValue.R(rt.String("sorcery")));f.Pc=361;continue;}
case 361:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",364);}
case 364:{f.Pc=f.Pop().Int==0?394:367;continue;}
case 367:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",370);}
case 370:{return rt.Call(f,"forge/StaticData","ensureAllCardsLoaded","()V","invokevirtual",373);}
case 373:{f.Push(f.Locals[20]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"forge/card/CardDb","streamUniqueCards","()Ljava/util/stream/Stream;","invokevirtual",378);}
case 378:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_SORCERY","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_SORCERY","Ljava/util/function/Predicate;"));f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",384);}
case 384:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",389);}
case 389:{f.Locals[19]=f.Pop();f.Pc=391;continue;}
case 391:{f.Pc=447;continue;}
case 394:{f.Push(f.Locals[18]);f.Pc=396;continue;}
case 396:{f.Push(JValue.R(rt.String("instant")));f.Pc=399;continue;}
case 399:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",402);}
case 402:{f.Pc=f.Pop().Int==0?432:405;continue;}
case 405:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",408);}
case 408:{return rt.Call(f,"forge/StaticData","ensureAllCardsLoaded","()V","invokevirtual",411);}
case 411:{f.Push(f.Locals[20]);f.Pc=413;continue;}
case 413:{return rt.Call(f,"forge/card/CardDb","streamUniqueCards","()Ljava/util/stream/Stream;","invokevirtual",416);}
case 416:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_INSTANT","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_INSTANT","Ljava/util/function/Predicate;"));f.Pc=419;continue;}
case 419:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",422);}
case 422:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",427);}
case 427:{f.Locals[19]=f.Pop();f.Pc=429;continue;}
case 429:{f.Pc=447;continue;}
case 432:{if(!rt.EnsureInitialized(f,"java/lang/UnsupportedOperationException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/UnsupportedOperationException")));f.Pc=435;continue;}
case 435:{f.StackOp("dup");f.Pc=436;continue;}
case 436:{f.Push(f.Locals[18]);f.Pc=438;continue;}
case 438:{return rt.DynamicCall(f,"forge/game/ability/effects/PlayEffect:3547:438:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",443);}
case 443:{return rt.Call(f,"java/lang/UnsupportedOperationException","<init>","(Ljava/lang/String;)V","invokespecial",446);}
case 446:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 447:{f.Push(f.Locals[1]);f.Pc=448;continue;}
case 448:{f.Push(JValue.R(rt.String("RandomCopied")));f.Pc=451;continue;}
case 451:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",454);}
case 454:{f.Pc=f.Pop().Int==0?718:457;continue;}
case 457:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=460;continue;}
case 460:{f.StackOp("dup");f.Pc=461;continue;}
case 461:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",464);}
case 464:{f.Locals[21]=f.Pop();f.Pc=466;continue;}
case 466:{f.Push(f.Locals[1]);f.Pc=467;continue;}
case 467:{f.Push(JValue.R(rt.String("RandomNum")));f.Pc=470;continue;}
case 470:{f.Push(JValue.R(rt.String("1")));f.Pc=473;continue;}
case 473:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",476);}
case 476:{f.Locals[22]=f.Pop();f.Pc=478;continue;}
case 478:{f.Push(f.Locals[2]);f.Pc=479;continue;}
case 479:{f.Push(f.Locals[22]);f.Pc=481;continue;}
case 481:{f.Push(f.Locals[1]);f.Pc=482;continue;}
case 482:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",485);}
case 485:{f.Locals[23]=f.Pop();f.Pc=487;continue;}
case 487:{f.Push(f.Locals[19]);f.Pc=489;continue;}
case 489:{f.Push(f.Locals[23]);f.Pc=491;continue;}
case 491:{return rt.Call(f,"forge/util/StreamUtil","random","(I)Ljava/util/stream/Collector;","invokestatic",494);}
case 494:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",499);}
case 499:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=502;continue;}
case 502:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",507);}
case 507:{f.Locals[24]=f.Pop();f.Pc=509;continue;}
case 509:{f.Push(f.Locals[24]);f.Pc=511;continue;}
case 511:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",516);}
case 516:{f.Pc=f.Pop().Int==0?597:519;continue;}
case 519:{f.Push(f.Locals[24]);f.Pc=521;continue;}
case 521:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",526);}
case 526:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=529;continue;}
case 529:{f.Locals[25]=f.Pop();f.Pc=531;continue;}
case 531:{f.Push(f.Locals[25]);f.Pc=533;continue;}
case 533:{f.Push(f.Locals[1]);f.Pc=534;continue;}
case 534:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",537);}
case 537:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",540);}
case 540:{f.Locals[26]=f.Pop();f.Pc=542;continue;}
case 542:{f.Push(f.Locals[1]);f.Pc=543;continue;}
case 543:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",546);}
case 546:{return rt.Call(f,"forge/game/player/Player","isAI","()Z","invokevirtual",549);}
case 549:{f.Pc=f.Pop().Int==0?577:552;continue;}
case 552:{f.Push(f.Locals[26]);f.Pc=554;continue;}
case 554:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",557);}
case 557:{f.Pc=f.Pop().Reference==null?577:560;continue;}
case 560:{f.Push(f.Locals[26]);f.Pc=562;continue;}
case 562:{return rt.Call(f,"forge/game/card/Card","getRules","()Lforge/card/CardRules;","invokevirtual",565);}
case 565:{return rt.Call(f,"forge/card/CardRules","getAiHints","()Lforge/card/CardAiHints;","invokevirtual",568);}
case 568:{return rt.Call(f,"forge/card/CardAiHints","getRemAIDecks","()Z","invokevirtual",571);}
case 571:{f.Pc=f.Pop().Int==0?577:574;continue;}
case 574:{f.Pc=509;continue;}
case 577:{f.Push(f.Locals[26]);f.Pc=579;continue;}
case 579:{f.Push(f.Locals[1]);f.Pc=580;continue;}
case 580:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",583);}
case 583:{return rt.Call(f,"forge/game/card/Card","setOwner","(Lforge/game/player/Player;)V","invokevirtual",586);}
case 586:{f.Push(f.Locals[21]);f.Pc=588;continue;}
case 588:{f.Push(f.Locals[26]);f.Pc=590;continue;}
case 590:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",593);}
case 593:{f.StackOp("pop");f.Pc=594;continue;}
case 594:{f.Pc=509;continue;}
case 597:{f.Push(f.Locals[1]);f.Pc=598;continue;}
case 598:{f.Push(JValue.R(rt.String("ChoiceNum")));f.Pc=601;continue;}
case 601:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",604);}
case 604:{f.Pc=f.Pop().Int==0?695:607;continue;}
case 607:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=610;continue;}
case 610:{f.Push(f.Locals[21]);f.Pc=612;continue;}
case 612:{return rt.Call(f,"forge/game/card/CardCollection","toString","()Ljava/lang/String;","invokevirtual",615);}
case 615:{return rt.DynamicCall(f,"forge/game/ability/effects/PlayEffect:3547:615:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",620);}
case 620:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",623);}
case 623:{f.Push(f.Locals[2]);f.Pc=624;continue;}
case 624:{f.Push(f.Locals[1]);f.Pc=625;continue;}
case 625:{f.Push(JValue.R(rt.String("ChoiceNum")));f.Pc=628;continue;}
case 628:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",631);}
case 631:{f.Push(f.Locals[1]);f.Pc=632;continue;}
case 632:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",635);}
case 635:{f.Locals[24]=f.Pop();f.Pc=637;continue;}
case 637:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=640;continue;}
case 640:{f.StackOp("dup");f.Pc=641;continue;}
case 641:{f.Push(f.Locals[12]);f.Pc=643;continue;}
case 643:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",646);}
case 646:{f.Push(f.Locals[21]);f.Pc=648;continue;}
case 648:{f.Push(f.Locals[1]);f.Pc=649;continue;}
case 649:{f.Push(f.Locals[2]);f.Pc=650;continue;}
case 650:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",653);}
case 653:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",656);}
case 656:{f.Push(JValue.R(rt.String("lblChooseUpTo")));f.Pc=659;continue;}
case 659:{f.Push(JValue.I(0));f.Pc=660;continue;}
case 660:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=663;continue;}
case 663:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",666);}
case 666:{f.Push(f.Locals[24]);f.Pc=668;continue;}
case 668:{f.Push(JValue.R(rt.String("card")));f.Pc=671;continue;}
case 671:{return rt.Call(f,"forge/util/Lang","nounWithNumeral","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",674);}
case 674:{return rt.DynamicCall(f,"forge/game/ability/effects/PlayEffect:3547:674:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",679);}
case 679:{f.Push(JValue.I(0));f.Pc=680;continue;}
case 680:{f.Push(f.Locals[24]);f.Pc=682;continue;}
case 682:{f.Push(JValue.I(1));f.Pc=683;continue;}
case 683:{f.Push(JValue.R(null));f.Pc=684;continue;}
case 684:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",687);}
case 687:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",690);}
case 690:{f.Locals[16]=f.Pop();f.Pc=692;continue;}
case 692:{f.Pc=699;continue;}
case 695:{f.Push(f.Locals[21]);f.Pc=697;continue;}
case 697:{f.Locals[16]=f.Pop();f.Pc=699;continue;}
case 699:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=702;continue;}
case 702:{f.Push(f.Locals[16]);f.Pc=704;continue;}
case 704:{return rt.Call(f,"forge/game/card/CardCollection","toString","()Ljava/lang/String;","invokevirtual",707);}
case 707:{return rt.DynamicCall(f,"forge/game/ability/effects/PlayEffect:3547:707:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",712);}
case 712:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",715);}
case 715:{f.Pc=719;continue;}
case 718:{return JStep.ReturnVoid;}
case 719:{f.Pc=919;continue;}
case 722:{f.Push(f.Locals[1]);f.Pc=723;continue;}
case 723:{f.Push(JValue.R(rt.String("CopyFromChosenName")));f.Pc=726;continue;}
case 726:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",729);}
case 729:{f.Pc=f.Pop().Int==0?828:732;continue;}
case 732:{f.Push(f.Locals[2]);f.Pc=733;continue;}
case 733:{return rt.Call(f,"forge/game/card/Card","getNamedCard","()Ljava/lang/String;","invokevirtual",736);}
case 736:{f.Locals[18]=f.Pop();f.Pc=738;continue;}
case 738:{f.Push(f.Locals[18]);f.Pc=740;continue;}
case 740:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",743);}
case 743:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",746);}
case 746:{f.Pc=f.Pop().Int==0?768:749;continue;}
case 749:{f.Push(f.Locals[12]);f.Pc=751;continue;}
case 751:{return rt.Call(f,"forge/game/player/Player","getNamedCard","()Ljava/lang/String;","invokevirtual",754);}
case 754:{f.Locals[18]=f.Pop();f.Pc=756;continue;}
case 756:{f.Push(f.Locals[18]);f.Pc=758;continue;}
case 758:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",761);}
case 761:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",764);}
case 764:{f.Pc=f.Pop().Int==0?768:767;continue;}
case 767:{return JStep.ReturnVoid;}
case 768:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",771);}
case 771:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",774);}
case 774:{f.Push(f.Locals[18]);f.Pc=776;continue;}
case 776:{return rt.Call(f,"forge/card/CardDb","getUniqueByName","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",779);}
case 779:{f.Push(f.Locals[12]);f.Pc=781;continue;}
case 781:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",784);}
case 784:{f.Locals[19]=f.Pop();f.Pc=786;continue;}
case 786:{f.Push(f.Locals[19]);f.Pc=788;continue;}
case 788:{f.Push(f.Locals[19]);f.Pc=790;continue;}
case 790:{return rt.Call(f,"forge/game/card/Card","setCopiedPermanent","(Lforge/game/card/Card;)V","invokevirtual",793);}
case 793:{f.Push(f.Locals[19]);f.Pc=795;continue;}
case 795:{if(!rt.StaticReady(f,"forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"));f.Pc=798;continue;}
case 798:{return rt.Call(f,"forge/game/card/Card","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",801);}
case 801:{f.Push(f.Locals[19]);f.Pc=803;continue;}
case 803:{f.Push(f.Locals[12]);f.Pc=805;continue;}
case 805:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=808;continue;}
case 808:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",811);}
case 811:{return rt.Call(f,"forge/game/card/Card","setZone","(Lforge/game/zone/Zone;)V","invokevirtual",814);}
case 814:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=817;continue;}
case 817:{f.StackOp("dup");f.Pc=818;continue;}
case 818:{f.Push(f.Locals[19]);f.Pc=820;continue;}
case 820:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",823);}
case 823:{f.Locals[16]=f.Pop();f.Pc=825;continue;}
case 825:{f.Pc=919;continue;}
case 828:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=831;continue;}
case 831:{f.StackOp("dup");f.Pc=832;continue;}
case 832:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",835);}
case 835:{f.Locals[16]=f.Pop();f.Pc=837;continue;}
case 837:{f.Push(f.Locals[1]);f.Pc=838;continue;}
case 838:{return rt.Call(f,"forge/game/ability/effects/PlayEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",841);}
case 841:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",844);}
case 844:{f.Locals[18]=f.Pop();f.Pc=846;continue;}
case 846:{f.Push(f.Locals[18]);f.Pc=848;continue;}
case 848:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",853);}
case 853:{f.Pc=f.Pop().Int==0?919:856;continue;}
case 856:{f.Push(f.Locals[18]);f.Pc=858;continue;}
case 858:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",863);}
case 863:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=866;continue;}
case 866:{f.Locals[19]=f.Pop();f.Pc=868;continue;}
case 868:{f.Push(f.Locals[3]);f.Pc=869;continue;}
case 869:{f.Push(f.Locals[19]);f.Pc=871;continue;}
case 871:{f.Push(JValue.R(null));f.Pc=872;continue;}
case 872:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",875);}
case 875:{f.Locals[20]=f.Pop();f.Pc=877;continue;}
case 877:{f.Push(f.Locals[19]);f.Pc=879;continue;}
case 879:{f.Push(f.Locals[20]);f.Pc=881;continue;}
case 881:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",884);}
case 884:{f.Pc=f.Pop().Int==0?898:887;continue;}
case 887:{f.Push(f.Locals[16]);f.Pc=889;continue;}
case 889:{f.Push(f.Locals[20]);f.Pc=891;continue;}
case 891:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",894);}
case 894:{f.StackOp("pop");f.Pc=895;continue;}
case 895:{f.Pc=916;continue;}
case 898:{f.Push(f.Locals[1]);f.Pc=899;continue;}
case 899:{f.Push(JValue.R(rt.String("ZoneRegardless")));f.Pc=902;continue;}
case 902:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",905);}
case 905:{f.Pc=f.Pop().Int==0?916:908;continue;}
case 908:{f.Push(f.Locals[16]);f.Pc=910;continue;}
case 910:{f.Push(f.Locals[19]);f.Pc=912;continue;}
case 912:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",915);}
case 915:{f.StackOp("pop");f.Pc=916;continue;}
case 916:{f.Pc=846;continue;}
case 919:{f.Push(f.Locals[16]);f.Pc=921;continue;}
case 921:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",924);}
case 924:{f.Pc=f.Pop().Int==0?928:927;continue;}
case 927:{return JStep.ReturnVoid;}
case 928:{f.Push(f.Locals[1]);f.Pc=929;continue;}
case 929:{f.Push(JValue.R(rt.String("ValidSA")));f.Pc=931;continue;}
case 931:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",934);}
case 934:{f.Pc=f.Pop().Int==0?981:937;continue;}
case 937:{f.Push(f.Locals[1]);f.Pc=938;continue;}
case 938:{f.Push(JValue.R(rt.String("ValidSA")));f.Pc=940;continue;}
case 940:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",943);}
case 943:{f.Push(JValue.R(rt.String(",")));f.Pc=945;continue;}
case 945:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",948);}
case 948:{f.Push(f.Locals[12]);f.Pc=950;continue;}
case 950:{f.Push(f.Locals[2]);f.Pc=951;continue;}
case 951:{f.Push(f.Locals[1]);f.Pc=952;continue;}
case 952:{return rt.Call(f,"forge/game/spellability/SpellAbilityPredicates","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",955);}
case 955:{f.Locals[18]=f.Pop();f.Pc=957;continue;}
case 957:{f.Push(f.Locals[16]);f.Pc=959;continue;}
case 959:{f.Push(f.Locals[12]);f.Pc=961;continue;}
case 961:{f.Push(f.Locals[18]);f.Pc=963;continue;}
case 963:{return rt.DynamicCall(f,"forge/game/ability/effects/PlayEffect:3547:963:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/Player;Ljava/util/function/Predicate;)Ljava/util/function/Predicate;",968);}
case 968:{return rt.Call(f,"forge/game/card/CardCollection","removeIf","(Ljava/util/function/Predicate;)Z","invokevirtual",971);}
case 971:{f.StackOp("pop");f.Pc=972;continue;}
case 972:{f.Push(f.Locals[16]);f.Pc=974;continue;}
case 974:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",977);}
case 977:{f.Pc=f.Pop().Int==0?984:980;continue;}
case 980:{return JStep.ReturnVoid;}
case 981:{f.Push(JValue.R(null));f.Pc=982;continue;}
case 982:{f.Locals[18]=f.Pop();f.Pc=984;continue;}
case 984:{f.Push(JValue.I(1));f.Pc=985;continue;}
case 985:{f.Locals[19]=f.Pop();f.Pc=987;continue;}
case 987:{f.Push(f.Locals[1]);f.Pc=988;continue;}
case 988:{f.Push(JValue.R(rt.String("Amount")));f.Pc=991;continue;}
case 991:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",994);}
case 994:{f.Pc=f.Pop().Int==0?1037:997;continue;}
case 997:{f.Push(f.Locals[1]);f.Pc=998;continue;}
case 998:{f.Push(JValue.R(rt.String("Amount")));f.Pc=1001;continue;}
case 1001:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1004);}
case 1004:{f.Push(JValue.R(rt.String("All")));f.Pc=1007;continue;}
case 1007:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1010);}
case 1010:{f.Pc=f.Pop().Int==0?1023:1013;continue;}
case 1013:{f.Push(f.Locals[16]);f.Pc=1015;continue;}
case 1015:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1018);}
case 1018:{f.Locals[19]=f.Pop();f.Pc=1020;continue;}
case 1020:{f.Pc=1037;continue;}
case 1023:{f.Push(f.Locals[2]);f.Pc=1024;continue;}
case 1024:{f.Push(f.Locals[1]);f.Pc=1025;continue;}
case 1025:{f.Push(JValue.R(rt.String("Amount")));f.Pc=1028;continue;}
case 1028:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1031);}
case 1031:{f.Push(f.Locals[1]);f.Pc=1032;continue;}
case 1032:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1035);}
case 1035:{f.Locals[19]=f.Pop();f.Pc=1037;continue;}
case 1037:{f.Push(f.Locals[8]);f.Pc=1039;continue;}
case 1039:{f.Pc=f.Pop().Int==0?1055:1042;continue;}
case 1042:{f.Push(f.Locals[2]);f.Pc=1043;continue;}
case 1043:{f.Push(f.Locals[1]);f.Pc=1044;continue;}
case 1044:{f.Push(JValue.R(rt.String("WithTotalCMC")));f.Pc=1046;continue;}
case 1046:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1049);}
case 1049:{f.Push(f.Locals[1]);f.Pc=1050;continue;}
case 1050:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",1053);}
case 1053:{f.Locals[11]=f.Pop();f.Pc=1055;continue;}
case 1055:{f.Push(f.Locals[15]);f.Pc=1057;continue;}
case 1057:{f.Pc=f.Pop().Reference==null?1069:1060;continue;}
case 1060:{f.Push(f.Locals[12]);f.Pc=1062;continue;}
case 1062:{f.Push(f.Locals[13]);f.Pc=1064;continue;}
case 1064:{f.Push(f.Locals[15]);f.Pc=1066;continue;}
case 1066:{return rt.Call(f,"forge/game/player/Player","addController","(JLforge/game/player/Player;)V","invokevirtual",1069);}
case 1069:{f.Push(f.Locals[16]);f.Pc=1071;continue;}
case 1071:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",1074);}
case 1074:{f.Push(JValue.I(1));f.Pc=1075;continue;}
case 1075:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1093:1078;continue;}
case 1078:{f.Push(f.Locals[19]);f.Pc=1080;continue;}
case 1080:{f.Push(JValue.I(1));f.Pc=1081;continue;}
case 1081:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1093:1084;continue;}
case 1084:{f.Push(f.Locals[4]);f.Pc=1086;continue;}
case 1086:{f.Pc=f.Pop().Int==0?1093:1089;continue;}
case 1089:{f.Push(JValue.I(1));f.Pc=1090;continue;}
case 1090:{f.Pc=1094;continue;}
case 1093:{f.Push(JValue.I(0));f.Pc=1094;continue;}
case 1094:{f.Locals[20]=f.Pop();f.Pc=1096;continue;}
case 1096:{f.Push(f.Locals[8]);f.Pc=1098;continue;}
case 1098:{f.Pc=f.Pop().Int==0?1111:1101;continue;}
case 1101:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=1104;continue;}
case 1104:{f.StackOp("dup");f.Pc=1105;continue;}
case 1105:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",1108);}
case 1108:{f.Pc=1112;continue;}
case 1111:{f.Push(JValue.R(null));f.Pc=1112;continue;}
case 1112:{f.Locals[21]=f.Pop();f.Pc=1114;continue;}
case 1114:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",1117);}
case 1117:{f.Locals[22]=f.Pop();f.Pc=1119;continue;}
case 1119:{f.Push(f.Locals[22]);f.Pc=1121;continue;}
case 1121:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=1124;continue;}
case 1124:{f.Push(f.Locals[1]);f.Pc=1125;continue;}
case 1125:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateBattlefield","()Lforge/game/card/CardCollection;","invokevirtual",1128);}
case 1128:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1133);}
case 1133:{f.StackOp("pop");f.Pc=1134;continue;}
case 1134:{f.Push(f.Locals[22]);f.Pc=1136;continue;}
case 1136:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateGraveyard","Lforge/game/ability/AbilityKey;"));f.Pc=1139;continue;}
case 1139:{f.Push(f.Locals[1]);f.Pc=1140;continue;}
case 1140:{return rt.Call(f,"forge/game/spellability/SpellAbility","getLastStateGraveyard","()Lforge/game/card/CardCollection;","invokevirtual",1143);}
case 1143:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1148);}
case 1148:{f.StackOp("pop");f.Pc=1149;continue;}
case 1149:{f.Push(f.Locals[16]);f.Pc=1151;continue;}
case 1151:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1154);}
case 1154:{f.Pc=f.Pop().Int!=0?2702:1157;continue;}
case 1157:{f.Push(f.Locals[19]);f.Pc=1159;continue;}
case 1159:{f.Pc=f.Pop().Int<=0?2702:1162;continue;}
case 1162:{f.Push(f.Locals[11]);f.Pc=1164;continue;}
case 1164:{f.Pc=f.Pop().Int<0?2702:1167;continue;}
case 1167:{f.Push(f.Locals[8]);f.Pc=1169;continue;}
case 1169:{f.Pc=f.Pop().Int==0?1266:1172;continue;}
case 1172:{f.Push(JValue.I(1));f.Pc=1173;continue;}
case 1173:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=1176;continue;}
case 1176:{f.StackOp("dup");f.Pc=1177;continue;}
case 1177:{f.Push(JValue.I(0));f.Pc=1178;continue;}
case 1178:{f.Push(f.Locals[11]);f.Pc=1180;continue;}
case 1180:{return rt.DynamicCall(f,"forge/game/ability/effects/PlayEffect:3547:1180:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",1185);}
case 1185:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1186;continue;}
case 1186:{f.Locals[23]=f.Pop();f.Pc=1188;continue;}
case 1188:{f.Push(f.Locals[16]);f.Pc=1190;continue;}
case 1190:{return rt.Call(f,"forge/game/card/CardCollection","stream","()Ljava/util/stream/Stream;","invokevirtual",1193);}
case 1193:{f.Push(f.Locals[12]);f.Pc=1195;continue;}
case 1195:{f.Push(f.Locals[23]);f.Pc=1197;continue;}
case 1197:{f.Push(f.Locals[1]);f.Pc=1198;continue;}
case 1198:{return rt.DynamicCall(f,"forge/game/ability/effects/PlayEffect:3547:1198:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/Player;[Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/util/function/Predicate;",1203);}
case 1203:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",1208);}
case 1208:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",1211);}
case 1211:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",1216);}
case 1216:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1219;continue;}
case 1219:{f.Locals[24]=f.Pop();f.Pc=1221;continue;}
case 1221:{f.Push(f.Locals[24]);f.Pc=1223;continue;}
case 1223:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1228);}
case 1228:{f.Pc=f.Pop().Int!=0?1239:1231;continue;}
case 1231:{f.Push(f.Locals[16]);f.Pc=1233;continue;}
case 1233:{f.Push(f.Locals[24]);f.Pc=1235;continue;}
case 1235:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",1238);}
case 1238:{f.StackOp("pop");f.Pc=1239;continue;}
case 1239:{f.Push(f.Locals[16]);f.Pc=1241;continue;}
case 1241:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1244);}
case 1244:{f.Pc=f.Pop().Int==0?1250:1247;continue;}
case 1247:{f.Pc=2702;continue;}
case 1250:{f.Push(f.Locals[21]);f.Pc=1252;continue;}
case 1252:{f.Push(JValue.R(rt.String("CMCLimit")));f.Pc=1255;continue;}
case 1255:{f.Push(f.Locals[11]);f.Pc=1257;continue;}
case 1257:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1260);}
case 1260:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1265);}
case 1265:{f.StackOp("pop");f.Pc=1266;continue;}
case 1266:{f.Push(f.Locals[12]);f.Pc=1268;continue;}
case 1268:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1271);}
case 1271:{f.Push(f.Locals[17]);f.Pc=1273;continue;}
case 1273:{return rt.Call(f,"forge/game/player/PlayerController","tempShowCards","(Ljava/lang/Iterable;)V","invokevirtual",1276);}
case 1276:{f.Push(f.Locals[12]);f.Pc=1278;continue;}
case 1278:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1281);}
case 1281:{f.Push(f.Locals[16]);f.Pc=1283;continue;}
case 1283:{f.Push(f.Locals[1]);f.Pc=1284;continue;}
case 1284:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1287);}
case 1287:{f.Push(JValue.R(rt.String("lblSelectCardToPlay")));f.Pc=1290;continue;}
case 1290:{f.Push(JValue.I(0));f.Pc=1291;continue;}
case 1291:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1294;continue;}
case 1294:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1297);}
case 1297:{f.Push(f.Locals[20]);f.Pc=1299;continue;}
case 1299:{f.Pc=f.Pop().Int!=0?1311:1302;continue;}
case 1302:{f.Push(f.Locals[4]);f.Pc=1304;continue;}
case 1304:{f.Pc=f.Pop().Int==0?1311:1307;continue;}
case 1307:{f.Push(JValue.I(1));f.Pc=1308;continue;}
case 1308:{f.Pc=1312;continue;}
case 1311:{f.Push(JValue.I(0));f.Pc=1312;continue;}
case 1312:{f.Push(f.Locals[21]);f.Pc=1314;continue;}
case 1314:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",1317);}
case 1317:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1320;continue;}
case 1320:{f.Locals[23]=f.Pop();f.Pc=1322;continue;}
case 1322:{f.Push(f.Locals[12]);f.Pc=1324;continue;}
case 1324:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1327);}
case 1327:{return rt.Call(f,"forge/game/player/PlayerController","endTempShowCards","()V","invokevirtual",1330);}
case 1330:{f.Push(f.Locals[23]);f.Pc=1332;continue;}
case 1332:{f.Pc=f.Pop().Reference!=null?1338:1335;continue;}
case 1335:{f.Pc=2702;continue;}
case 1338:{f.Push(JValue.I(0));f.Pc=1339;continue;}
case 1339:{f.Locals[24]=f.Pop();f.Pc=1341;continue;}
case 1341:{f.Push(f.Locals[23]);f.Pc=1343;continue;}
case 1343:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",1346);}
case 1346:{f.Pc=f.Pop().Int==0?1357:1349;continue;}
case 1349:{f.Push(f.Locals[23]);f.Pc=1351;continue;}
case 1351:{return rt.Call(f,"forge/game/card/Card","forceTurnFaceUp","()V","invokevirtual",1354);}
case 1354:{f.Push(JValue.I(1));f.Pc=1355;continue;}
case 1355:{f.Locals[24]=f.Pop();f.Pc=1357;continue;}
case 1357:{f.Push(f.Locals[1]);f.Pc=1358;continue;}
case 1358:{f.Push(JValue.R(rt.String("ShowCardToActivator")));f.Pc=1361;continue;}
case 1361:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1364);}
case 1364:{f.Pc=f.Pop().Int==0?1378:1367;continue;}
case 1367:{f.Push(f.Locals[3]);f.Pc=1368;continue;}
case 1368:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1371);}
case 1371:{f.Push(f.Locals[23]);f.Pc=1373;continue;}
case 1373:{f.Push(f.Locals[12]);f.Pc=1375;continue;}
case 1375:{return rt.Call(f,"forge/game/GameAction","revealTo","(Lforge/game/card/Card;Lforge/game/player/Player;)V","invokevirtual",1378);}
case 1378:{f.Push(f.Locals[1]);f.Pc=1379;continue;}
case 1379:{f.Push(JValue.R(rt.String("CastTransformed")));f.Pc=1382;continue;}
case 1382:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1385);}
case 1385:{f.Pc=f.Pop().Int==0?1394:1388;continue;}
case 1388:{f.Push(JValue.R(rt.String("lblDoYouWantPlayCardTransformed")));f.Pc=1391;continue;}
case 1391:{f.Pc=1397;continue;}
case 1394:{f.Push(JValue.R(rt.String("lblDoYouWantPlayCard")));f.Pc=1397;continue;}
case 1397:{f.Locals[25]=f.Pop();f.Pc=1399;continue;}
case 1399:{f.Push(f.Locals[20]);f.Pc=1401;continue;}
case 1401:{f.Pc=f.Pop().Int==0?1459:1404;continue;}
case 1404:{f.Push(f.Locals[12]);f.Pc=1406;continue;}
case 1406:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1409);}
case 1409:{f.Push(f.Locals[1]);f.Pc=1410;continue;}
case 1410:{f.Push(JValue.R(null));f.Pc=1411;continue;}
case 1411:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1414);}
case 1414:{f.Push(f.Locals[25]);f.Pc=1416;continue;}
case 1416:{f.Push(JValue.I(1));f.Pc=1417;continue;}
case 1417:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1420;continue;}
case 1420:{f.StackOp("dup");f.Pc=1421;continue;}
case 1421:{f.Push(JValue.I(0));f.Pc=1422;continue;}
case 1422:{f.Push(f.Locals[23]);f.Pc=1424;continue;}
case 1424:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",1427);}
case 1427:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1428;continue;}
case 1428:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1431);}
case 1431:{f.Push(f.Locals[23]);f.Pc=1433;continue;}
case 1433:{f.Push(JValue.R(null));f.Pc=1434;continue;}
case 1434:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",1437);}
case 1437:{f.Pc=f.Pop().Int!=0?1459:1440;continue;}
case 1440:{f.Push(f.Locals[24]);f.Pc=1442;continue;}
case 1442:{f.Pc=f.Pop().Int==0?2702:1445;continue;}
case 1445:{f.Push(f.Locals[23]);f.Pc=1447;continue;}
case 1447:{return rt.Call(f,"forge/game/card/Card","turnFaceDownNoUpdate","()Z","invokevirtual",1450);}
case 1450:{f.StackOp("pop");f.Pc=1451;continue;}
case 1451:{f.Push(f.Locals[23]);f.Pc=1453;continue;}
case 1453:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",1456);}
case 1456:{f.Pc=2702;continue;}
case 1459:{f.Push(f.Locals[1]);f.Pc=1460;continue;}
case 1460:{f.Push(JValue.R(rt.String("AllowRepeats")));f.Pc=1463;continue;}
case 1463:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1466);}
case 1466:{f.Pc=f.Pop().Int!=0?1477:1469;continue;}
case 1469:{f.Push(f.Locals[16]);f.Pc=1471;continue;}
case 1471:{f.Push(f.Locals[23]);f.Pc=1473;continue;}
case 1473:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",1476);}
case 1476:{f.StackOp("pop");f.Pc=1477;continue;}
case 1477:{f.Push(f.Locals[1]);f.Pc=1478;continue;}
case 1478:{f.Push(JValue.R(rt.String("CopyCard")));f.Pc=1481;continue;}
case 1481:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1484);}
case 1484:{f.Pc=f.Pop().Int==0?1544:1487;continue;}
case 1487:{f.Push(f.Locals[23]);f.Pc=1489;continue;}
case 1489:{f.Locals[26]=f.Pop();f.Pc=1491;continue;}
case 1491:{f.Push(f.Locals[23]);f.Pc=1493;continue;}
case 1493:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",1496);}
case 1496:{f.Locals[27]=f.Pop();f.Pc=1498;continue;}
case 1498:{f.Push(f.Locals[23]);f.Pc=1500;continue;}
case 1500:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",1503);}
case 1503:{f.Push(f.Locals[12]);f.Pc=1505;continue;}
case 1505:{return rt.Call(f,"forge/game/card/Card","fromPaperCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;)Lforge/game/card/Card;","invokestatic",1508);}
case 1508:{f.Locals[23]=f.Pop();f.Pc=1510;continue;}
case 1510:{f.Push(f.Locals[23]);f.Pc=1512;continue;}
case 1512:{if(!rt.StaticReady(f,"forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"));f.Pc=1515;continue;}
case 1515:{return rt.Call(f,"forge/game/card/Card","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",1518);}
case 1518:{f.Push(f.Locals[23]);f.Pc=1520;continue;}
case 1520:{f.Push(f.Locals[27]);f.Pc=1522;continue;}
case 1522:{return rt.Call(f,"forge/game/card/Card","setZone","(Lforge/game/zone/Zone;)V","invokevirtual",1525);}
case 1525:{f.Push(f.Locals[23]);f.Pc=1527;continue;}
case 1527:{f.Push(f.Locals[26]);f.Pc=1529;continue;}
case 1529:{return rt.Call(f,"forge/game/card/Card","setCopiedPermanent","(Lforge/game/card/Card;)V","invokevirtual",1532);}
case 1532:{f.Push(f.Locals[27]);f.Pc=1534;continue;}
case 1534:{f.Pc=f.Pop().Reference==null?1544:1537;continue;}
case 1537:{f.Push(f.Locals[27]);f.Pc=1539;continue;}
case 1539:{f.Push(f.Locals[23]);f.Pc=1541;continue;}
case 1541:{return rt.Call(f,"forge/game/zone/Zone","add","(Lforge/game/card/Card;)V","invokevirtual",1544);}
case 1544:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=1547;continue;}
case 1547:{f.Locals[26]=f.Pop();f.Pc=1549;continue;}
case 1549:{f.Push(f.Locals[1]);f.Pc=1550;continue;}
case 1550:{f.Push(JValue.R(rt.String("CastTransformed")));f.Pc=1553;continue;}
case 1553:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1556);}
case 1556:{f.Pc=f.Pop().Int==0?1597:1559;continue;}
case 1559:{f.Push(f.Locals[23]);f.Pc=1561;continue;}
case 1561:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;"));f.Pc=1564;continue;}
case 1564:{return rt.Call(f,"forge/game/card/Card","changeToState","(Lforge/card/CardStateName;)Z","invokevirtual",1567);}
case 1567:{f.Pc=f.Pop().Int!=0?1592:1570;continue;}
case 1570:{f.Locals[19]=JValue.I(unchecked(f.Locals[19].Int+(-1)));f.Pc=1573;continue;}
case 1573:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=1576;continue;}
case 1576:{f.Push(f.Locals[23]);f.Pc=1578;continue;}
case 1578:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1581);}
case 1581:{return rt.DynamicCall(f,"forge/game/ability/effects/PlayEffect:3547:1581:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1586);}
case 1586:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",1589);}
case 1589:{f.Pc=1149;continue;}
case 1592:{if(!rt.StaticReady(f,"forge/card/CardStateName","Backside","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Backside","Lforge/card/CardStateName;"));f.Pc=1595;continue;}
case 1595:{f.Locals[26]=f.Pop();f.Pc=1597;continue;}
case 1597:{f.Push(f.Locals[23]);f.Pc=1599;continue;}
case 1599:{f.Push(f.Locals[12]);f.Pc=1601;continue;}
case 1601:{f.Push(f.Locals[26]);f.Pc=1603;continue;}
case 1603:{f.Push(f.Locals[9]);f.Pc=1605;continue;}
case 1605:{f.Pc=f.Pop().Int!=0?1612:1608;continue;}
case 1608:{f.Push(JValue.I(1));f.Pc=1609;continue;}
case 1609:{f.Pc=1613;continue;}
case 1612:{f.Push(JValue.I(0));f.Pc=1613;continue;}
case 1613:{f.Push(f.Locals[18]);f.Pc=1615;continue;}
case 1615:{return rt.Call(f,"forge/game/ability/AbilityUtils","getSpellsFromPlayEffect","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/card/CardStateName;ZLjava/util/function/Predicate;)Ljava/util/List;","invokestatic",1618);}
case 1618:{f.Locals[27]=f.Pop();f.Pc=1620;continue;}
case 1620:{f.Push(f.Locals[10]);f.Pc=1622;continue;}
case 1622:{f.Pc=f.Pop().Int==0?1638:1625;continue;}
case 1625:{f.Push(f.Locals[27]);f.Pc=1627;continue;}
case 1627:{return rt.DynamicCall(f,"forge/game/ability/effects/PlayEffect:3547:1627:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",1632);}
case 1632:{return rt.Call(f,"java/util/List","removeIf","(Ljava/util/function/Predicate;)Z","invokeinterface",1637);}
case 1637:{f.StackOp("pop");f.Pc=1638;continue;}
case 1638:{f.Push(f.Locals[8]);f.Pc=1640;continue;}
case 1640:{f.Pc=f.Pop().Int==0?1700:1643;continue;}
case 1643:{f.Push(f.Locals[27]);f.Pc=1645;continue;}
case 1645:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1650);}
case 1650:{f.Locals[28]=f.Pop();f.Pc=1652;continue;}
case 1652:{f.Push(f.Locals[28]);f.Pc=1654;continue;}
case 1654:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1659);}
case 1659:{f.Pc=f.Pop().Int==0?1700:1662;continue;}
case 1662:{f.Push(f.Locals[28]);f.Pc=1664;continue;}
case 1664:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1669);}
case 1669:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1672;continue;}
case 1672:{f.Locals[29]=f.Pop();f.Pc=1674;continue;}
case 1674:{f.Push(f.Locals[29]);f.Pc=1676;continue;}
case 1676:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",1679);}
case 1679:{return rt.Call(f,"forge/game/cost/Cost","getTotalMana","()Lforge/card/mana/ManaCost;","invokevirtual",1682);}
case 1682:{return rt.Call(f,"forge/card/mana/ManaCost","getCMC","()I","invokevirtual",1685);}
case 1685:{f.Push(f.Locals[11]);f.Pc=1687;continue;}
case 1687:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1697:1690;continue;}
case 1690:{f.Push(f.Locals[28]);f.Pc=1692;continue;}
case 1692:{return rt.Call(f,"java/util/Iterator","remove","()V","invokeinterface",1697);}
case 1697:{f.Pc=1652;continue;}
case 1700:{f.Push(f.Locals[27]);f.Pc=1702;continue;}
case 1702:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1707);}
case 1707:{f.Pc=f.Pop().Int==0?1713:1710;continue;}
case 1710:{f.Pc=1149;continue;}
case 1713:{f.Push(f.Locals[1]);f.Pc=1714;continue;}
case 1714:{f.Push(JValue.R(rt.String("CastFaceDown")));f.Pc=1717;continue;}
case 1717:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1720);}
case 1720:{f.Pc=f.Pop().Int==0?1746:1723;continue;}
case 1723:{f.Push(f.Locals[23]);f.Pc=1725;continue;}
case 1725:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",1728);}
case 1728:{f.Push(JValue.I(0));f.Pc=1729;continue;}
case 1729:{f.Push(JValue.R(rt.String("Morph")));f.Pc=1732;continue;}
case 1732:{return rt.Call(f,"forge/game/card/CardFactoryUtil","abilityCastFaceDown","(Lforge/game/card/CardState;ZLjava/lang/String;)Lforge/game/spellability/SpellAbility;","invokestatic",1735);}
case 1735:{f.Locals[28]=f.Pop();f.Pc=1737;continue;}
case 1737:{f.Push(f.Locals[28]);f.Pc=1739;continue;}
case 1739:{f.Push(JValue.I(1));f.Pc=1740;continue;}
case 1740:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCastFromPlayEffect","(Z)V","invokevirtual",1743);}
case 1743:{f.Pc=1760;continue;}
case 1746:{f.Push(f.Locals[12]);f.Pc=1748;continue;}
case 1748:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",1751);}
case 1751:{f.Push(f.Locals[23]);f.Pc=1753;continue;}
case 1753:{f.Push(f.Locals[27]);f.Pc=1755;continue;}
case 1755:{return rt.Call(f,"forge/game/player/PlayerController","getAbilityToPlay","(Lforge/game/card/Card;Ljava/util/List;)Lforge/game/spellability/SpellAbility;","invokevirtual",1758);}
case 1758:{f.Locals[28]=f.Pop();f.Pc=1760;continue;}
case 1760:{f.Push(f.Locals[28]);f.Pc=1762;continue;}
case 1762:{f.Pc=f.Pop().Reference!=null?1784:1765;continue;}
case 1765:{f.Push(f.Locals[24]);f.Pc=1767;continue;}
case 1767:{f.Pc=f.Pop().Int==0?1149:1770;continue;}
case 1770:{f.Push(f.Locals[23]);f.Pc=1772;continue;}
case 1772:{return rt.Call(f,"forge/game/card/Card","turnFaceDownNoUpdate","()Z","invokevirtual",1775);}
case 1775:{f.StackOp("pop");f.Pc=1776;continue;}
case 1776:{f.Push(f.Locals[23]);f.Pc=1778;continue;}
case 1778:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",1781);}
case 1781:{f.Pc=1149;continue;}
case 1784:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=1787;continue;}
case 1787:{f.StackOp("dup");f.Pc=1788;continue;}
case 1788:{f.Push(f.Locals[3]);f.Pc=1789;continue;}
case 1789:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",1792);}
case 1792:{f.Push(f.Locals[3]);f.Pc=1793;continue;}
case 1793:{return rt.Call(f,"forge/game/Game","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",1796);}
case 1796:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;)V","invokespecial",1799);}
case 1799:{f.Locals[29]=f.Pop();f.Pc=1801;continue;}
case 1801:{f.Push(f.Locals[23]);f.Pc=1803;continue;}
case 1803:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",1806);}
case 1806:{f.Locals[30]=f.Pop();f.Pc=1808;continue;}
case 1808:{f.Push(f.Locals[28]);f.Pc=1810;continue;}
case 1810:{return rt.Call(f,"forge/game/spellability/SpellAbility","isLandAbility","()Z","invokevirtual",1813);}
case 1813:{f.Pc=f.Pop().Int==0?1910:1816;continue;}
case 1816:{f.Push(f.Locals[28]);f.Pc=1818;continue;}
case 1818:{return rt.Call(f,"forge/game/spellability/SpellAbility","resolve","()V","invokevirtual",1821);}
case 1821:{f.Locals[19]=JValue.I(unchecked(f.Locals[19].Int+(-1)));f.Pc=1824;continue;}
case 1824:{f.Push(f.Locals[5]);f.Pc=1826;continue;}
case 1826:{f.Pc=f.Pop().Int==0?1835:1829;continue;}
case 1829:{f.Push(f.Locals[2]);f.Pc=1830;continue;}
case 1830:{f.Push(f.Locals[23]);f.Pc=1832;continue;}
case 1832:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",1835);}
case 1835:{f.Push(f.Locals[6]);f.Pc=1837;continue;}
case 1837:{f.Pc=f.Pop().Int==0?1846:1840;continue;}
case 1840:{f.Push(f.Locals[2]);f.Pc=1841;continue;}
case 1841:{f.Push(f.Locals[23]);f.Pc=1843;continue;}
case 1843:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",1846);}
case 1846:{f.Push(f.Locals[7]);f.Pc=1848;continue;}
case 1848:{f.Pc=f.Pop().Int==0?1857:1851;continue;}
case 1851:{f.Push(f.Locals[2]);f.Pc=1852;continue;}
case 1852:{f.Push(f.Locals[23]);f.Pc=1854;continue;}
case 1854:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",1857);}
case 1857:{f.Push(f.Locals[3]);f.Pc=1858;continue;}
case 1858:{f.Push(f.Locals[23]);f.Pc=1860;continue;}
case 1860:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",1863);}
case 1863:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",1866);}
case 1866:{f.Locals[31]=f.Pop();f.Pc=1868;continue;}
case 1868:{f.Push(f.Locals[30]);f.Pc=1870;continue;}
case 1870:{f.Push(f.Locals[31]);f.Pc=1872;continue;}
case 1872:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",1875);}
case 1875:{f.Pc=f.Pop().Int!=0?1900:1878;continue;}
case 1878:{f.Push(f.Locals[29]);f.Pc=1880;continue;}
case 1880:{f.Push(f.Locals[30]);f.Pc=1882;continue;}
case 1882:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1885);}
case 1885:{f.Push(f.Locals[31]);f.Pc=1887;continue;}
case 1887:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",1890);}
case 1890:{f.Push(f.Locals[3]);f.Pc=1891;continue;}
case 1891:{f.Push(f.Locals[23]);f.Pc=1893;continue;}
case 1893:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",1896);}
case 1896:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",1899);}
case 1899:{f.StackOp("pop");f.Pc=1900;continue;}
case 1900:{f.Push(f.Locals[29]);f.Pc=1902;continue;}
case 1902:{f.Push(f.Locals[3]);f.Pc=1903;continue;}
case 1903:{f.Push(f.Locals[1]);f.Pc=1904;continue;}
case 1904:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1907);}
case 1907:{f.Pc=1149;continue;}
case 1910:{f.Push(f.Locals[28]);f.Pc=1912;continue;}
case 1912:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",1915);}
case 1915:{return rt.Call(f,"forge/game/cost/Cost","getTotalMana","()Lforge/card/mana/ManaCost;","invokevirtual",1918);}
case 1918:{return rt.Call(f,"forge/card/mana/ManaCost","getCMC","()I","invokevirtual",1921);}
case 1921:{f.Locals[31]=f.Pop();f.Pc=1923;continue;}
case 1923:{f.Push(f.Locals[9]);f.Pc=1925;continue;}
case 1925:{f.Pc=f.Pop().Int==0?1953:1928;continue;}
case 1928:{f.Push(f.Locals[28]);f.Pc=1930;continue;}
case 1930:{return rt.Call(f,"forge/game/spellability/SpellAbility","costHasManaX","()Z","invokevirtual",1933);}
case 1933:{f.Pc=f.Pop().Int==0?1953:1936;continue;}
case 1936:{f.Push(f.Locals[28]);f.Pc=1938;continue;}
case 1938:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",1941);}
case 1941:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",1944);}
case 1944:{return rt.Call(f,"forge/game/cost/CostPartMana","getXMin","()I","invokevirtual",1947);}
case 1947:{f.Pc=f.Pop().Int<=0?1953:1950;continue;}
case 1950:{f.Pc=1149;continue;}
case 1953:{f.Push(f.Locals[1]);f.Pc=1954;continue;}
case 1954:{f.Push(JValue.R(rt.String("WithoutManaCost")));f.Pc=1956;continue;}
case 1956:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1959);}
case 1959:{f.Pc=f.Pop().Int==0?1972:1962;continue;}
case 1962:{f.Push(f.Locals[28]);f.Pc=1964;continue;}
case 1964:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithNoManaCost","()Lforge/game/spellability/SpellAbility;","invokevirtual",1967);}
case 1967:{f.Locals[28]=f.Pop();f.Pc=1969;continue;}
case 1969:{f.Pc=2143;continue;}
case 1972:{f.Push(f.Locals[1]);f.Pc=1973;continue;}
case 1973:{f.Push(JValue.R(rt.String("PlayCost")));f.Pc=1975;continue;}
case 1975:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1978);}
case 1978:{f.Pc=f.Pop().Int==0?2112:1981;continue;}
case 1981:{f.Push(f.Locals[1]);f.Pc=1982;continue;}
case 1982:{f.Push(JValue.R(rt.String("PlayCost")));f.Pc=1984;continue;}
case 1984:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1987);}
case 1987:{f.Locals[33]=f.Pop();f.Pc=1989;continue;}
case 1989:{f.Push(f.Locals[10]);f.Pc=1991;continue;}
case 1991:{f.Pc=f.Pop().Int==0?2015:1994;continue;}
case 1994:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=1997;continue;}
case 1997:{f.StackOp("dup");f.Pc=1998;continue;}
case 1998:{f.Push(f.Locals[28]);f.Pc=2000;continue;}
case 2000:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCardState","()Lforge/game/card/CardState;","invokevirtual",2003);}
case 2003:{return rt.Call(f,"forge/game/card/CardState","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",2006);}
case 2006:{f.Push(JValue.I(0));f.Pc=2007;continue;}
case 2007:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Lforge/card/mana/ManaCost;Z)V","invokespecial",2010);}
case 2010:{f.Locals[32]=f.Pop();f.Pc=2012;continue;}
case 2012:{f.Pc=2095;continue;}
case 2015:{f.Push(f.Locals[33]);f.Pc=2017;continue;}
case 2017:{f.Push(JValue.R(rt.String("SuspendCost")));f.Pc=2020;continue;}
case 2020:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2023);}
case 2023:{f.Pc=f.Pop().Int==0?2050:2026;continue;}
case 2026:{f.Push(f.Locals[23]);f.Pc=2028;continue;}
case 2028:{return rt.Call(f,"forge/game/card/Card","getNonManaAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",2031);}
case 2031:{return rt.DynamicCall(f,"forge/game/ability/effects/PlayEffect:3547:2031:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",2036);}
case 2036:{return rt.Call(f,"forge/util/IterableUtil","find","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Object;","invokestatic",2039);}
case 2039:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2042;continue;}
case 2042:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",2045);}
case 2045:{f.Locals[32]=f.Pop();f.Pc=2047;continue;}
case 2047:{f.Pc=2095;continue;}
case 2050:{f.Push(f.Locals[33]);f.Pc=2052;continue;}
case 2052:{f.Push(JValue.R(rt.String("ConvertedManaCost")));f.Pc=2055;continue;}
case 2055:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",2058);}
case 2058:{f.Pc=f.Pop().Int==0?2083:2061;continue;}
case 2061:{f.Push(f.Locals[23]);f.Pc=2063;continue;}
case 2063:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",2066);}
case 2066:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",2069);}
case 2069:{f.Locals[34]=f.Pop();f.Pc=2071;continue;}
case 2071:{f.Push(f.Locals[33]);f.Pc=2073;continue;}
case 2073:{f.Push(JValue.R(rt.String("ConvertedManaCost")));f.Pc=2076;continue;}
case 2076:{f.Push(f.Locals[34]);f.Pc=2078;continue;}
case 2078:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",2081);}
case 2081:{f.Locals[33]=f.Pop();f.Pc=2083;continue;}
case 2083:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=2086;continue;}
case 2086:{f.StackOp("dup");f.Pc=2087;continue;}
case 2087:{f.Push(f.Locals[33]);f.Pc=2089;continue;}
case 2089:{f.Push(JValue.I(0));f.Pc=2090;continue;}
case 2090:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",2093);}
case 2093:{f.Locals[32]=f.Pop();f.Pc=2095;continue;}
case 2095:{f.Push(f.Locals[28]);f.Pc=2097;continue;}
case 2097:{f.Push(f.Locals[28]);f.Pc=2099;continue;}
case 2099:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",2102);}
case 2102:{f.Push(f.Locals[32]);f.Pc=2104;continue;}
case 2104:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithManaCostReplaced","(Lforge/game/player/Player;Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",2107);}
case 2107:{f.Locals[28]=f.Pop();f.Pc=2109;continue;}
case 2109:{f.Pc=2143;continue;}
case 2112:{f.Push(f.Locals[28]);f.Pc=2114;continue;}
case 2114:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",2117);}
case 2117:{return rt.Call(f,"forge/game/cost/Cost","hasManaCost","()Z","invokevirtual",2120);}
case 2120:{f.Pc=f.Pop().Int==0?2143:2123;continue;}
case 2123:{f.Push(f.Locals[28]);f.Pc=2125;continue;}
case 2125:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",2128);}
case 2128:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",2131);}
case 2131:{return rt.Call(f,"forge/game/cost/CostPartMana","getMana","()Lforge/card/mana/ManaCost;","invokevirtual",2134);}
case 2134:{return rt.Call(f,"forge/card/mana/ManaCost","isNoCost","()Z","invokevirtual",2137);}
case 2137:{f.Pc=f.Pop().Int==0?2143:2140;continue;}
case 2140:{f.Pc=1149;continue;}
case 2143:{f.Push(f.Locals[4]);f.Pc=2145;continue;}
case 2145:{f.Pc=f.Pop().Int!=0?2252:2148;continue;}
case 2148:{f.Push(f.Locals[28]);f.Pc=2150;continue;}
case 2150:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",2153);}
case 2153:{return rt.Call(f,"forge/game/cost/Cost","getCostParts","()Ljava/util/List;","invokevirtual",2156);}
case 2156:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",2161);}
case 2161:{f.Locals[32]=f.Pop();f.Pc=2163;continue;}
case 2163:{f.Push(f.Locals[32]);f.Pc=2165;continue;}
case 2165:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",2170);}
case 2170:{f.Pc=f.Pop().Int==0?2238:2173;continue;}
case 2173:{f.Push(f.Locals[32]);f.Pc=2175;continue;}
case 2175:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",2180);}
case 2180:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=2183;continue;}
case 2183:{f.Locals[33]=f.Pop();f.Pc=2185;continue;}
case 2185:{f.Push(f.Locals[33]);f.Pc=2187;continue;}
case 2187:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostDiscard")?1:0));f.Pc=2190;continue;}
case 2190:{f.Pc=f.Pop().Int!=0?2201:2193;continue;}
case 2193:{f.Push(f.Locals[33]);f.Pc=2195;continue;}
case 2195:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/cost/CostReveal")?1:0));f.Pc=2198;continue;}
case 2198:{f.Pc=f.Pop().Int==0?2235:2201;continue;}
case 2201:{f.Push(f.Locals[33]);f.Pc=2203;continue;}
case 2203:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",2206);}
case 2206:{f.Push(JValue.R(rt.String("Card")));f.Pc=2209;continue;}
case 2209:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2212);}
case 2212:{f.Pc=f.Pop().Int!=0?2235:2215;continue;}
case 2215:{f.Push(f.Locals[33]);f.Pc=2217;continue;}
case 2217:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",2220);}
case 2220:{f.Push(JValue.R(rt.String("Random")));f.Pc=2223;continue;}
case 2223:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2226);}
case 2226:{f.Pc=f.Pop().Int!=0?2235:2229;continue;}
case 2229:{f.Push(JValue.I(1));f.Pc=2230;continue;}
case 2230:{f.Locals[4]=f.Pop();f.Pc=2232;continue;}
case 2232:{f.Pc=2238;continue;}
case 2235:{f.Pc=2163;continue;}
case 2238:{f.Push(f.Locals[4]);f.Pc=2240;continue;}
case 2240:{f.Pc=f.Pop().Int!=0?2252:2243;continue;}
case 2243:{f.Push(f.Locals[28]);f.Pc=2245;continue;}
case 2245:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",2248);}
case 2248:{f.Push(JValue.I(1));f.Pc=2249;continue;}
case 2249:{return rt.Call(f,"forge/game/cost/Cost","setMandatory","(Z)V","invokevirtual",2252);}
case 2252:{f.Push(f.Locals[1]);f.Pc=2253;continue;}
case 2253:{f.Push(JValue.R(rt.String("PlayReduceCost")));f.Pc=2256;continue;}
case 2256:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2259);}
case 2259:{f.Pc=f.Pop().Int==0?2303:2262;continue;}
case 2262:{f.Push(f.Locals[1]);f.Pc=2263;continue;}
case 2263:{f.Push(JValue.R(rt.String("PlayReduceCost")));f.Pc=2266;continue;}
case 2266:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2269);}
case 2269:{f.Locals[32]=f.Pop();f.Pc=2271;continue;}
case 2271:{f.Push(f.Locals[28]);f.Pc=2273;continue;}
case 2273:{f.Push(JValue.R(rt.String("ReduceCost")));f.Pc=2276;continue;}
case 2276:{f.Push(f.Locals[32]);f.Pc=2278;continue;}
case 2278:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2281);}
case 2281:{f.StackOp("pop");f.Pc=2282;continue;}
case 2282:{f.Push(f.Locals[32]);f.Pc=2284;continue;}
case 2284:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",2287);}
case 2287:{f.Pc=f.Pop().Int!=0?2303:2290;continue;}
case 2290:{f.Push(f.Locals[28]);f.Pc=2292;continue;}
case 2292:{f.Push(f.Locals[32]);f.Pc=2294;continue;}
case 2294:{f.Push(f.Locals[1]);f.Pc=2295;continue;}
case 2295:{f.Push(f.Locals[32]);f.Pc=2297;continue;}
case 2297:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2300);}
case 2300:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",2303);}
case 2303:{f.Push(f.Locals[1]);f.Pc=2304;continue;}
case 2304:{f.Push(JValue.R(rt.String("PlayRaiseCost")));f.Pc=2307;continue;}
case 2307:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2310);}
case 2310:{f.Pc=f.Pop().Int==0?2333:2313;continue;}
case 2313:{f.Push(f.Locals[1]);f.Pc=2314;continue;}
case 2314:{f.Push(JValue.R(rt.String("PlayRaiseCost")));f.Pc=2317;continue;}
case 2317:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2320);}
case 2320:{f.Locals[32]=f.Pop();f.Pc=2322;continue;}
case 2322:{f.Push(f.Locals[28]);f.Pc=2324;continue;}
case 2324:{f.Push(JValue.R(rt.String("RaiseCost")));f.Pc=2327;continue;}
case 2327:{f.Push(f.Locals[32]);f.Pc=2329;continue;}
case 2329:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2332);}
case 2332:{f.StackOp("pop");f.Pc=2333;continue;}
case 2333:{f.Push(f.Locals[1]);f.Pc=2334;continue;}
case 2334:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","MADNESS","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","MADNESS","Lforge/game/keyword/Keyword;"));f.Pc=2337;continue;}
case 2337:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",2340);}
case 2340:{f.Pc=f.Pop().Int==0?2351:2343;continue;}
case 2343:{f.Push(f.Locals[28]);f.Pc=2345;continue;}
case 2345:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Madness","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Madness","Lforge/game/spellability/AlternativeCost;"));f.Pc=2348;continue;}
case 2348:{return rt.Call(f,"forge/game/spellability/SpellAbility","setAlternativeCost","(Lforge/game/spellability/AlternativeCost;)V","invokevirtual",2351);}
case 2351:{f.Push(f.Locals[1]);f.Pc=2352;continue;}
case 2352:{f.Push(JValue.R(rt.String("CastTransformed")));f.Pc=2355;continue;}
case 2355:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2358);}
case 2358:{f.Pc=f.Pop().Int==0?2373:2361;continue;}
case 2361:{f.Push(f.Locals[28]);f.Pc=2363;continue;}
case 2363:{f.Push(JValue.R(rt.String("CastTransformed")));f.Pc=2366;continue;}
case 2366:{f.Push(JValue.R(rt.String("True")));f.Pc=2369;continue;}
case 2369:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2372);}
case 2372:{f.StackOp("pop");f.Pc=2373;continue;}
case 2373:{f.Push(f.Locals[1]);f.Pc=2374;continue;}
case 2374:{f.Push(JValue.R(rt.String("ManaConversion")));f.Pc=2377;continue;}
case 2377:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2380);}
case 2380:{f.Pc=f.Pop().Int==0?2399:2383;continue;}
case 2383:{f.Push(f.Locals[28]);f.Pc=2385;continue;}
case 2385:{f.Push(JValue.R(rt.String("ManaConversion")));f.Pc=2388;continue;}
case 2388:{f.Push(f.Locals[1]);f.Pc=2389;continue;}
case 2389:{f.Push(JValue.R(rt.String("ManaConversion")));f.Pc=2392;continue;}
case 2392:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2395);}
case 2395:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2398);}
case 2398:{f.StackOp("pop");f.Pc=2399;continue;}
case 2399:{f.Push(f.Locals[28]);f.Pc=2401;continue;}
case 2401:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",2404);}
case 2404:{f.Pc=f.Pop().Int==0?2421:2407;continue;}
case 2407:{f.Push(f.Locals[4]);f.Pc=2409;continue;}
case 2409:{f.Pc=f.Pop().Int!=0?2421:2412;continue;}
case 2412:{f.Push(f.Locals[28]);f.Pc=2414;continue;}
case 2414:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",2417);}
case 2417:{f.Push(JValue.I(1));f.Pc=2418;continue;}
case 2418:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setMandatory","(Z)V","invokevirtual",2421);}
case 2421:{f.Push(f.Locals[1]);f.Pc=2422;continue;}
case 2422:{f.Push(JValue.R(rt.String("Named")));f.Pc=2425;continue;}
case 2425:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2428);}
case 2428:{f.Pc=f.Pop().Int==0?2440:2431;continue;}
case 2431:{f.Push(f.Locals[28]);f.Pc=2433;continue;}
case 2433:{f.Push(f.Locals[1]);f.Pc=2434;continue;}
case 2434:{return rt.Call(f,"forge/game/spellability/SpellAbility","getName","()Ljava/lang/String;","invokevirtual",2437);}
case 2437:{return rt.Call(f,"forge/game/spellability/SpellAbility","setName","(Ljava/lang/String;)V","invokevirtual",2440);}
case 2440:{f.Push(f.Locals[1]);f.Pc=2441;continue;}
case 2441:{f.Push(JValue.R(rt.String("ReplaceGraveyard")));f.Pc=2444;continue;}
case 2444:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2447);}
case 2447:{f.Pc=f.Pop().Int==0?2500:2450;continue;}
case 2450:{f.Push(f.Locals[1]);f.Pc=2451;continue;}
case 2451:{f.Push(JValue.R(rt.String("ReplaceGraveyardValid")));f.Pc=2454;continue;}
case 2454:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2457);}
case 2457:{f.Pc=f.Pop().Int==0?2484:2460;continue;}
case 2460:{f.Push(f.Locals[28]);f.Pc=2462;continue;}
case 2462:{f.Push(f.Locals[1]);f.Pc=2463;continue;}
case 2463:{f.Push(JValue.R(rt.String("ReplaceGraveyardValid")));f.Pc=2466;continue;}
case 2466:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2469);}
case 2469:{f.Push(JValue.R(rt.String(",")));f.Pc=2471;continue;}
case 2471:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",2474);}
case 2474:{f.Push(f.Locals[12]);f.Pc=2476;continue;}
case 2476:{f.Push(f.Locals[2]);f.Pc=2477;continue;}
case 2477:{f.Push(f.Locals[1]);f.Pc=2478;continue;}
case 2478:{return rt.Call(f,"forge/game/spellability/SpellAbility","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",2481);}
case 2481:{f.Pc=f.Pop().Int==0?2500:2484;continue;}
case 2484:{f.Push(f.Locals[23]);f.Pc=2486;continue;}
case 2486:{f.Push(f.Locals[2]);f.Pc=2487;continue;}
case 2487:{f.Push(f.Locals[1]);f.Pc=2488;continue;}
case 2488:{f.Push(f.Locals[28]);f.Pc=2490;continue;}
case 2490:{f.Push(f.Locals[1]);f.Pc=2491;continue;}
case 2491:{f.Push(JValue.R(rt.String("ReplaceGraveyard")));f.Pc=2494;continue;}
case 2494:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",2497);}
case 2497:{return rt.Call(f,"forge/game/ability/effects/PlayEffect","addReplaceGraveyardEffect","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Ljava/lang/String;)V","invokestatic",2500);}
case 2500:{f.Push(f.Locals[1]);f.Pc=2501;continue;}
case 2501:{f.Push(JValue.R(rt.String("ReplaceIlluMask")));f.Pc=2504;continue;}
case 2504:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2507);}
case 2507:{f.Pc=f.Pop().Int==0?2517:2510;continue;}
case 2510:{f.Push(f.Locals[0]);f.Pc=2511;continue;}
case 2511:{f.Push(f.Locals[23]);f.Pc=2513;continue;}
case 2513:{f.Push(f.Locals[1]);f.Pc=2514;continue;}
case 2514:{return rt.Call(f,"forge/game/ability/effects/PlayEffect","addIllusionaryMaskReplace","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",2517);}
case 2517:{f.Push(f.Locals[15]);f.Pc=2519;continue;}
case 2519:{f.Pc=f.Pop().Reference==null?2563:2522;continue;}
case 2522:{f.Push(f.Locals[28]);f.Pc=2524;continue;}
case 2524:{f.Push(f.Locals[13]);f.Pc=2526;continue;}
case 2526:{f.Push(f.Locals[15]);f.Pc=2528;continue;}
case 2528:{return rt.Call(f,"forge/game/spellability/SpellAbility","setControlledByPlayer","(JLforge/game/player/Player;)V","invokevirtual",2531);}
case 2531:{f.Push(f.Locals[12]);f.Pc=2533;continue;}
case 2533:{f.Push(f.Locals[28]);f.Pc=2535;continue;}
case 2535:{return rt.Call(f,"forge/game/player/Player","pushPaidForSA","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",2538);}
case 2538:{f.Push(f.Locals[28]);f.Pc=2540;continue;}
case 2540:{if(!rt.EnsureInitialized(f,"forge/game/mana/ManaCostBeingPaid"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/ManaCostBeingPaid")));f.Pc=2543;continue;}
case 2543:{f.StackOp("dup");f.Pc=2544;continue;}
case 2544:{f.Push(f.Locals[28]);f.Pc=2546;continue;}
case 2546:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",2549);}
case 2549:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",2552);}
case 2552:{f.Push(f.Locals[28]);f.Pc=2554;continue;}
case 2554:{return rt.Call(f,"forge/game/cost/CostPartMana","getManaCostFor","(Lforge/game/spellability/SpellAbility;)Lforge/card/mana/ManaCost;","invokevirtual",2557);}
case 2557:{return rt.Call(f,"forge/game/mana/ManaCostBeingPaid","<init>","(Lforge/card/mana/ManaCost;)V","invokespecial",2560);}
case 2560:{return rt.Call(f,"forge/game/spellability/SpellAbility","setManaCostBeingPaid","(Lforge/game/mana/ManaCostBeingPaid;)V","invokevirtual",2563);}
case 2563:{f.Push(f.Locals[12]);f.Pc=2565;continue;}
case 2565:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",2568);}
case 2568:{f.Push(f.Locals[28]);f.Pc=2570;continue;}
case 2570:{return rt.Call(f,"forge/game/player/PlayerController","playSaFromPlayEffect","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",2573);}
case 2573:{f.Pc=f.Pop().Int==0?2689:2576;continue;}
case 2576:{f.Push(f.Locals[28]);f.Pc=2578;continue;}
case 2578:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",2581);}
case 2581:{f.Locals[32]=f.Pop();f.Pc=2583;continue;}
case 2583:{f.Push(f.Locals[5]);f.Pc=2585;continue;}
case 2585:{f.Pc=f.Pop().Int==0?2594:2588;continue;}
case 2588:{f.Push(f.Locals[2]);f.Pc=2589;continue;}
case 2589:{f.Push(f.Locals[32]);f.Pc=2591;continue;}
case 2591:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",2594);}
case 2594:{f.Push(f.Locals[6]);f.Pc=2596;continue;}
case 2596:{f.Pc=f.Pop().Int==0?2605:2599;continue;}
case 2599:{f.Push(f.Locals[2]);f.Pc=2600;continue;}
case 2600:{f.Push(f.Locals[32]);f.Pc=2602;continue;}
case 2602:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",2605);}
case 2605:{f.Push(f.Locals[1]);f.Pc=2606;continue;}
case 2606:{f.Push(JValue.R(rt.String("ForgetRemembered")));f.Pc=2609;continue;}
case 2609:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",2612);}
case 2612:{f.Pc=f.Pop().Int==0?2619:2615;continue;}
case 2615:{f.Push(f.Locals[2]);f.Pc=2616;continue;}
case 2616:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",2619);}
case 2619:{f.Push(f.Locals[7]);f.Pc=2621;continue;}
case 2621:{f.Pc=f.Pop().Int==0?2630:2624;continue;}
case 2624:{f.Push(f.Locals[2]);f.Pc=2625;continue;}
case 2625:{f.Push(f.Locals[23]);f.Pc=2627;continue;}
case 2627:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",2630);}
case 2630:{f.Push(f.Locals[3]);f.Pc=2631;continue;}
case 2631:{f.Push(f.Locals[23]);f.Pc=2633;continue;}
case 2633:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",2636);}
case 2636:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",2639);}
case 2639:{f.Locals[33]=f.Pop();f.Pc=2641;continue;}
case 2641:{f.Push(f.Locals[33]);f.Pc=2643;continue;}
case 2643:{f.Push(f.Locals[30]);f.Pc=2645;continue;}
case 2645:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",2648);}
case 2648:{f.Pc=f.Pop().Int!=0?2682:2651;continue;}
case 2651:{f.Push(f.Locals[29]);f.Pc=2653;continue;}
case 2653:{f.Push(f.Locals[30]);f.Pc=2655;continue;}
case 2655:{f.Pc=f.Pop().Reference!=null?2662:2658;continue;}
case 2658:{f.Push(JValue.R(null));f.Pc=2659;continue;}
case 2659:{f.Pc=2667;continue;}
case 2662:{f.Push(f.Locals[30]);f.Pc=2664;continue;}
case 2664:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",2667);}
case 2667:{f.Push(f.Locals[33]);f.Pc=2669;continue;}
case 2669:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",2672);}
case 2672:{f.Push(f.Locals[3]);f.Pc=2673;continue;}
case 2673:{f.Push(f.Locals[23]);f.Pc=2675;continue;}
case 2675:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",2678);}
case 2678:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",2681);}
case 2681:{f.StackOp("pop");f.Pc=2682;continue;}
case 2682:{f.Push(f.Locals[29]);f.Pc=2684;continue;}
case 2684:{f.Push(f.Locals[3]);f.Pc=2685;continue;}
case 2685:{f.Push(f.Locals[1]);f.Pc=2686;continue;}
case 2686:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",2689);}
case 2689:{f.Locals[19]=JValue.I(unchecked(f.Locals[19].Int+(-1)));f.Pc=2692;continue;}
case 2692:{f.Push(f.Locals[11]);f.Pc=2694;continue;}
case 2694:{f.Push(f.Locals[31]);f.Pc=2696;continue;}
case 2696:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=2697;continue;}
case 2697:{f.Locals[11]=f.Pop();f.Pc=2699;continue;}
case 2699:{f.Pc=1149;continue;}
case 2702:{f.Push(f.Locals[15]);f.Pc=2704;continue;}
case 2704:{f.Pc=f.Pop().Reference==null?2719:2707;continue;}
case 2707:{f.Push(f.Locals[12]);f.Pc=2709;continue;}
case 2709:{f.Push(f.Locals[13]);f.Pc=2711;continue;}
case 2711:{return rt.Call(f,"forge/game/player/Player","removeController","(J)V","invokevirtual",2714);}
case 2714:{f.Push(f.Locals[12]);f.Pc=2716;continue;}
case 2716:{return rt.Call(f,"forge/game/player/Player","popPaidForSA","()V","invokevirtual",2719);}
case 2719:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3548(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",10);}
case 10:{f.Locals[6]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",16);}
case 16:{return rt.DynamicCall(f,"forge/game/ability/effects/PlayEffect:3548:16:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",21);}
case 21:{f.Locals[7]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Locals[8]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[6]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[7]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[8]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/ability/effects/PlayEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Lforge/game/card/Card;","invokestatic",39);}
case 39:{f.Locals[9]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[9]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",47);}
case 47:{f.Push(JValue.R(rt.String("Event$ Moved | ValidCard$ Card.IsRemembered | Origin$ Stack | Destination$ Graveyard | Description$ If that card would be put into your graveyard this turn, exile it instead.")));f.Pc=50;continue;}
case 50:{f.Locals[10]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{return rt.DynamicCall(f,"forge/game/ability/effects/PlayEffect:3548:54:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",59);}
case 59:{f.Locals[11]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[10]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[9]);f.Pc=65;continue;}
case 65:{f.Push(JValue.I(1));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",69);}
case 69:{f.Locals[12]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[12]);f.Pc=73;continue;}
case 73:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setLayer","(Lforge/game/replacement/ReplacementLayer;)V","invokevirtual",79);}
case 79:{f.Push(f.Locals[12]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[11]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[9]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",88);}
case 88:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",91);}
case 91:{f.Push(f.Locals[9]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[12]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/card/Card","addReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)Lforge/game/replacement/ReplacementEffect;","invokevirtual",98);}
case 98:{f.StackOp("pop");f.Pc=99;continue;}
case 99:{f.Push(f.Locals[9]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("Stack")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/ability/effects/PlayEffect","addExileOnMovedTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",107);}
case 107:{f.Push(f.Locals[2]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",111);}
case 111:{f.Pc=f.Pop().Int==0?120:114;continue;}
case 114:{f.Push(f.Locals[9]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[1]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/game/card/Card","copyChangedTextFrom","(Lforge/game/card/Card;)V","invokevirtual",120);}
case 120:{f.Push(f.Locals[5]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",125);}
case 125:{f.Push(f.Locals[5]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[9]);f.Pc=129;continue;}
case 129:{return rt.DynamicCall(f,"forge/game/ability/effects/PlayEffect:3548:129:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/GameCommand;",134);}
case 134:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",137);}
case 137:{f.Push(f.Locals[3]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[9]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/spellability/SpellAbility","addRollbackEffect","(Lforge/game/card/Card;)V","invokevirtual",143);}
case 143:{f.Push(f.Locals[5]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",148);}
case 148:{f.Push(f.Locals[9]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[2]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",154);}
case 154:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3549(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[3]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[4]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",15);}
case 15:{f.Locals[5]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",21);}
case 21:{return rt.DynamicCall(f,"forge/game/ability/effects/PlayEffect:3549:21:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",26);}
case 26:{f.Locals[6]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Locals[7]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[5]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[6]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[7]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/ability/effects/PlayEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Lforge/game/card/Card;","invokestatic",44);}
case 44:{f.Locals[8]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[8]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",52);}
case 52:{f.Push(JValue.I(3));f.Pc=53;continue;}
case 53:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("Event$ AssignDealDamage | ValidCard$ Card.IsRemembered+faceDown | Description$ If the creature that spell becomes as it resolves has not been turned face up and would assign or deal damage, be dealt damage, or become tapped, instead it's turned face up and assigns or deals damage, is dealt damage, or becomes tapped.")));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(1));f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("Event$ DealtDamage | ValidCard$ Card.IsRemembered+faceDown")));f.Pc=67;continue;}
case 67:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(JValue.I(2));f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("Event$ Tap | ValidCard$ Card.IsRemembered+faceDown")));f.Pc=73;continue;}
case 73:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=74;continue;}
case 74:{f.Locals[9]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("DB$ SetState | Defined$ ReplacedCard | Mode$ TurnFaceUp")));f.Pc=79;continue;}
case 79:{f.Locals[10]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[9]);f.Pc=83;continue;}
case 83:{f.Locals[11]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[11]);f.Pc=87;continue;}
case 87:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=88;continue;}
case 88:{f.Locals[12]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(JValue.I(0));f.Pc=91;continue;}
case 91:{f.Locals[13]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[13]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[12]);f.Pc=97;continue;}
case 97:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?163:100;continue;}
case 100:{f.Push(f.Locals[11]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[13]);f.Pc=104;continue;}
case 104:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=105;continue;}
case 105:{f.Locals[14]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[14]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[8]);f.Pc=111;continue;}
case 111:{f.Push(JValue.I(1));f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",115);}
case 115:{f.Locals[15]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[15]);f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("ReplacementResult")));f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("Updated")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",128);}
case 128:{f.StackOp("pop");f.Pc=129;continue;}
case 129:{f.Push(f.Locals[15]);f.Pc=131;continue;}
case 131:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setLayer","(Lforge/game/replacement/ReplacementLayer;)V","invokevirtual",137);}
case 137:{f.Push(f.Locals[15]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[10]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[8]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",146);}
case 146:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",149);}
case 149:{f.Push(f.Locals[8]);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[15]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/card/Card","addReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)Lforge/game/replacement/ReplacementEffect;","invokevirtual",156);}
case 156:{f.StackOp("pop");f.Pc=157;continue;}
case 157:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(1)));f.Pc=160;continue;}
case 160:{f.Pc=93;continue;}
case 163:{f.Push(f.Locals[8]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/ability/effects/PlayEffect","addExileOnMovedTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",171);}
case 171:{f.Push(f.Locals[8]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/ability/effects/PlayEffect","addExileOnCounteredTrigger","(Lforge/game/card/Card;)V","invokestatic",176);}
case 176:{f.Push(f.Locals[4]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",181);}
case 181:{f.Push(f.Locals[8]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[2]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",187);}
case 187:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3550(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(-1));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",11);}
case 11:{switch(f.Pop().Int){case 1451181049:f.Pc=28;break;default:f.Pc=40;break;}continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("lambda$addReplaceGraveyardEffect$800dc4e0$1")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?40:38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{f.Locals[2]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{switch(f.Pop().Int){case 0:f.Pc=60;break;default:f.Pc=156;break;}continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodKind","()I","invokevirtual",64);}
case 64:{f.Push(JValue.I(6));f.Pc=66;continue;}
case 66:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?156:69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceClass","()Ljava/lang/String;","invokevirtual",73);}
case 73:{f.Push(JValue.R(rt.String("forge/GameCommand")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int==0?156:82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodName","()Ljava/lang/String;","invokevirtual",86);}
case 86:{f.Push(JValue.R(rt.String("run")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int==0?156:95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodSignature","()Ljava/lang/String;","invokevirtual",99);}
case 99:{f.Push(JValue.R(rt.String("()V")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int==0?156:108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplClass","()Ljava/lang/String;","invokevirtual",112);}
case 112:{f.Push(JValue.R(rt.String("forge/game/ability/effects/PlayEffect")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int==0?156:121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodSignature","()Ljava/lang/String;","invokevirtual",125);}
case 125:{f.Push(JValue.R(rt.String("(Lforge/game/Game;Lforge/game/card/Card;)V")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int==0?156:134;continue;}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",139);}
case 139:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/Game"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{f.Push(JValue.I(1));f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",147);}
case 147:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=150;continue;}
case 150:{return rt.DynamicCall(f,"forge/game/ability/effects/PlayEffect:3550:150:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/GameCommand;",155);}
case 155:{return JStep.Return(f.Pop());}
case 156:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=159;continue;}
case 159:{f.StackOp("dup");f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("Invalid lambda deserialization")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",166);}
case 166:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3551(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameAction","exileEffect","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",8);}
case 8:{f.StackOp("pop");f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3552(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","SUSPEND","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","SUSPEND","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/SpellAbility","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3553(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/cost/CostPartMana","getMana","()Lforge/card/mana/ManaCost;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/card/mana/ManaCost","isNoCost","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3554(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/ability/AbilityUtils","getBasicSpellsFromPlayEffect","(Lforge/game/card/Card;Lforge/game/player/Player;)Ljava/util/List;","invokestatic",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbilityPredicates","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Ljava/util/function/Predicate;","invokestatic",12);}
case 12:{return rt.Call(f,"forge/util/IterableUtil","any","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Z","invokestatic",15);}
case 15:{f.Pc=f.Pop().Int!=0?22:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Pc=23;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3555(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/ability/AbilityUtils","getSpellsFromPlayEffect","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/card/CardStateName;ZLjava/util/function/Predicate;)Ljava/util/List;","invokestatic",10);}
case 10:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",15);}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3556(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String(";")));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String(",")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
