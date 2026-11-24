// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C344{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/PeekAndRevealEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3529,"forge/game/ability/effects/PeekAndRevealEffect","<init>","()V",1,1,1,new JHandler[]{},M3529));
c.Add(new JMethod(3530,"forge/game/ability/effects/PeekAndRevealEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,11,3,new JHandler[]{},M3530));
c.Add(new JMethod(3531,"forge/game/ability/effects/PeekAndRevealEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,22,9,new JHandler[]{},M3531));
}

internal static JStep M3529(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3530(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("PeekAmount")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?31:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",18);}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("PeekAmount")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",28);}
case 28:{f.Pc=32;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("NoReveal")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int!=0?51:42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("RevealOptional")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?56:51;continue;}
case 51:{f.Push(JValue.R(rt.String(" looks at ")));f.Pc=53;continue;}
case 53:{f.Pc=58;continue;}
case 56:{f.Push(JValue.R(rt.String(" reveals ")));f.Pc=58;continue;}
case 58:{f.Locals[4]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("Defined")));f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",68);}
case 68:{f.Locals[5]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/ability/effects/PeekAndRevealEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",74);}
case 74:{f.Locals[6]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[6]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",81);}
case 81:{f.Locals[7]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[5]);f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("Player")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?108:93;continue;}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String(" reveals ")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int==0?108:103;continue;}
case 103:{f.Push(JValue.R(rt.String("Each player")));f.Pc=105;continue;}
case 105:{f.Pc=134;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("NoPeek")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?132:117;continue;}
case 117:{f.Push(f.Locals[4]);f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String(" reveals ")));f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",124);}
case 124:{f.Pc=f.Pop().Int==0?132:127;continue;}
case 127:{f.Push(f.Locals[7]);f.Pc=129;continue;}
case 129:{f.Pc=134;continue;}
case 132:{f.Push(JValue.R(rt.String("")));f.Pc=134;continue;}
case 134:{f.Locals[8]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[5]);f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("Player")));f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",143);}
case 143:{f.Pc=f.Pop().Int==0?161:146;continue;}
case 146:{f.Push(f.Locals[4]);f.Pc=148;continue;}
case 148:{f.Push(JValue.R(rt.String(" looks at ")));f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",153);}
case 153:{f.Pc=f.Pop().Int==0?161:156;continue;}
case 156:{f.Push(JValue.R(rt.String("each player's")));f.Pc=158;continue;}
case 158:{f.Pc=196;continue;}
case 161:{f.Push(f.Locals[6]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",168);}
case 168:{f.Push(JValue.I(1));f.Pc=169;continue;}
case 169:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?189:172;continue;}
case 172:{f.Push(f.Locals[6]);f.Pc=174;continue;}
case 174:{f.Push(JValue.I(0));f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",180);}
case 180:{f.Push(f.Locals[2]);f.Pc=181;continue;}
case 181:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?189:184;continue;}
case 184:{f.Push(JValue.R(rt.String("their")));f.Pc=186;continue;}
case 186:{f.Pc=196;continue;}
case 189:{f.Push(f.Locals[7]);f.Pc=191;continue;}
case 191:{return rt.DynamicCall(f,"forge/game/ability/effects/PeekAndRevealEffect:3530:191:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",196);}
case 196:{f.Locals[9]=f.Pop();f.Pc=198;continue;}
case 198:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=201;continue;}
case 201:{f.StackOp("dup");f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",205);}
case 205:{f.Locals[10]=f.Pop();f.Pc=207;continue;}
case 207:{f.Push(f.Locals[10]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[8]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",214);}
case 214:{f.Pc=f.Pop().Int==0?221:217;continue;}
case 217:{f.Push(f.Locals[2]);f.Pc=218;continue;}
case 218:{f.Pc=223;continue;}
case 221:{f.Push(f.Locals[8]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",226);}
case 226:{f.StackOp("pop");f.Pc=227;continue;}
case 227:{f.Push(f.Locals[10]);f.Pc=229;continue;}
case 229:{f.Push(f.Locals[4]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",234);}
case 234:{f.Push(JValue.R(rt.String("the top ")));f.Pc=236;continue;}
case 236:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",239);}
case 239:{f.StackOp("pop");f.Pc=240;continue;}
case 240:{f.Push(f.Locals[10]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[3]);f.Pc=243;continue;}
case 243:{f.Push(JValue.I(1));f.Pc=244;continue;}
case 244:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?259:247;continue;}
case 247:{f.Push(f.Locals[3]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",251);}
case 251:{return rt.DynamicCall(f,"forge/game/ability/effects/PeekAndRevealEffect:3530:251:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",256);}
case 256:{f.Pc=261;continue;}
case 259:{f.Push(JValue.R(rt.String("card ")));f.Pc=261;continue;}
case 261:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",264);}
case 264:{f.Push(JValue.R(rt.String("of ")));f.Pc=266;continue;}
case 266:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",269);}
case 269:{f.Push(f.Locals[9]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",274);}
case 274:{f.StackOp("pop");f.Pc=275;continue;}
case 275:{f.Push(f.Locals[10]);f.Pc=277;continue;}
case 277:{f.Push(JValue.R(rt.String(" library.")));f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",282);}
case 282:{f.StackOp("pop");f.Pc=283;continue;}
case 283:{f.Push(f.Locals[10]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",288);}
case 288:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3531(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("RememberRevealed")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("ImprintRevealed")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("NoPeek")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",26);}
case 26:{f.Locals[5]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("RevealValid")));f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("Card")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",36);}
case 36:{f.Locals[6]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("PeekAmount")));f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("1")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",46);}
case 46:{f.Locals[7]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[7]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",55);}
case 55:{f.Locals[8]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("SourceZone")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?78:66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("SourceZone")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",72);}
case 72:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",75);}
case 75:{f.Pc=81;continue;}
case 78:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=81;continue;}
case 81:{f.Locals[9]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/ability/effects/PeekAndRevealEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",87);}
case 87:{f.Locals[10]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",93);}
case 93:{f.Locals[11]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[10]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",102);}
case 102:{f.Locals[12]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[12]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",111);}
case 111:{f.Pc=f.Pop().Int==0?583:114;continue;}
case 114:{f.Push(f.Locals[12]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",121);}
case 121:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=124;continue;}
case 124:{f.Locals[13]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[13]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[9]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",133);}
case 133:{f.Locals[14]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[8]);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[14]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/zone/PlayerZone","size","()I","invokevirtual",142);}
case 142:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",145);}
case 145:{f.Locals[8]=f.Pop();f.Pc=147;continue;}
case 147:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=150;continue;}
case 150:{f.StackOp("dup");f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",154);}
case 154:{f.Locals[15]=f.Pop();f.Pc=156;continue;}
case 156:{f.Push(JValue.I(0));f.Pc=157;continue;}
case 157:{f.Locals[16]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[16]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[8]);f.Pc=163;continue;}
case 163:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?185:166;continue;}
case 166:{f.Push(f.Locals[15]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[14]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[16]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/zone/PlayerZone","get","(I)Lforge/game/card/Card;","invokevirtual",175);}
case 175:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",178);}
case 178:{f.StackOp("pop");f.Pc=179;continue;}
case 179:{f.Locals[16]=JValue.I(unchecked(f.Locals[16].Int+(1)));f.Pc=182;continue;}
case 182:{f.Pc=159;continue;}
case 185:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=188;continue;}
case 188:{f.StackOp("dup");f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",192);}
case 192:{f.Locals[16]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(f.Locals[16]);f.Pc=196;continue;}
case 196:{f.Push(JValue.R(rt.String("Revealed")));f.Pc=198;continue;}
case 198:{f.Push(f.Locals[15]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",205);}
case 205:{f.StackOp("pop");f.Pc=206;continue;}
case 206:{f.Push(f.Locals[15]);f.Pc=208;continue;}
case 208:{f.Push(f.Locals[6]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[11]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[2]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[1]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",217);}
case 217:{f.Locals[17]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[1]);f.Pc=220;continue;}
case 220:{f.Push(JValue.R(rt.String("NoReveal")));f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",225);}
case 225:{f.Pc=f.Pop().Int!=0?242:228;continue;}
case 228:{f.Push(f.Locals[17]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",235);}
case 235:{f.Pc=f.Pop().Int!=0?242:238;continue;}
case 238:{f.Push(JValue.I(1));f.Pc=239;continue;}
case 239:{f.Pc=243;continue;}
case 242:{f.Push(JValue.I(0));f.Pc=243;continue;}
case 243:{f.Locals[18]=f.Pop();f.Pc=245;continue;}
case 245:{f.Push(f.Locals[5]);f.Pc=247;continue;}
case 247:{f.Pc=f.Pop().Int!=0?285:250;continue;}
case 250:{f.Push(f.Locals[11]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",255);}
case 255:{f.Push(f.Locals[15]);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[9]);f.Pc=259;continue;}
case 259:{f.Push(f.Locals[13]);f.Pc=261;continue;}
case 261:{f.Push(f.Locals[2]);f.Pc=262;continue;}
case 262:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",265);}
case 265:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",268);}
case 268:{f.Push(JValue.R(rt.String("lblLookingCardFrom")));f.Pc=270;continue;}
case 270:{f.Push(JValue.I(0));f.Pc=271;continue;}
case 271:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",277);}
case 277:{return rt.DynamicCall(f,"forge/game/ability/effects/PeekAndRevealEffect:3531:277:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",282);}
case 282:{return rt.Call(f,"forge/game/player/PlayerController","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;Ljava/lang/String;)V","invokevirtual",285);}
case 285:{f.Push(f.Locals[18]);f.Pc=287;continue;}
case 287:{f.Pc=f.Pop().Int==0?355:290;continue;}
case 290:{f.Push(f.Locals[1]);f.Pc=291;continue;}
case 291:{f.Push(JValue.R(rt.String("RevealOptional")));f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",296);}
case 296:{f.Pc=f.Pop().Int==0?355:299;continue;}
case 299:{f.Push(f.Locals[17]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",306);}
case 306:{f.Push(JValue.I(1));f.Pc=307;continue;}
case 307:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?324:310;continue;}
case 310:{f.Push(f.Locals[17]);f.Pc=312;continue;}
case 312:{f.Push(JValue.I(0));f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/game/card/CardCollectionView","get","(I)Ljava/lang/Object;","invokeinterface",318);}
case 318:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=321;continue;}
case 321:{f.Pc=325;continue;}
case 324:{f.Push(JValue.R(null));f.Pc=325;continue;}
case 325:{f.Locals[19]=f.Pop();f.Pc=327;continue;}
case 327:{f.Push(f.Locals[11]);f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",332);}
case 332:{f.Push(f.Locals[1]);f.Pc=333;continue;}
case 333:{f.Push(JValue.R(null));f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",337);}
case 337:{f.Push(JValue.R(rt.String("lblRevealCardToOtherPlayers")));f.Pc=339;continue;}
case 339:{f.Push(JValue.I(0));f.Pc=340;continue;}
case 340:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=343;continue;}
case 343:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",346);}
case 346:{f.Push(f.Locals[19]);f.Pc=348;continue;}
case 348:{f.Push(f.Locals[16]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",353);}
case 353:{f.Locals[18]=f.Pop();f.Pc=355;continue;}
case 355:{f.Push(f.Locals[18]);f.Pc=357;continue;}
case 357:{f.Pc=f.Pop().Int==0?520:360;continue;}
case 360:{f.Push(f.Locals[11]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",365);}
case 365:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",368);}
case 368:{f.Push(f.Locals[17]);f.Pc=370;continue;}
case 370:{f.Push(f.Locals[9]);f.Pc=372;continue;}
case 372:{f.Push(f.Locals[13]);f.Pc=374;continue;}
case 374:{f.Push(f.Locals[5]);f.Pc=376;continue;}
case 376:{f.Pc=f.Pop().Int!=0?383:379;continue;}
case 379:{f.Push(JValue.I(1));f.Pc=380;continue;}
case 380:{f.Pc=384;continue;}
case 383:{f.Push(JValue.I(0));f.Pc=384;continue;}
case 384:{f.Push(f.Locals[2]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",388);}
case 388:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",391);}
case 391:{f.Push(JValue.R(rt.String("lblRevealingCardFrom")));f.Pc=393;continue;}
case 393:{f.Push(JValue.I(0));f.Pc=394;continue;}
case 394:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=397;continue;}
case 397:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",400);}
case 400:{return rt.DynamicCall(f,"forge/game/ability/effects/PeekAndRevealEffect:3531:400:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",405);}
case 405:{return rt.Call(f,"forge/game/GameAction","reveal","(Lforge/game/card/CardCollectionView;Lforge/game/zone/ZoneType;Lforge/game/player/Player;ZLjava/lang/String;)V","invokevirtual",408);}
case 408:{f.Push(f.Locals[3]);f.Pc=409;continue;}
case 409:{f.Pc=f.Pop().Int==0?462:412;continue;}
case 412:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",415);}
case 415:{f.Locals[19]=f.Pop();f.Pc=417;continue;}
case 417:{f.Push(f.Locals[17]);f.Pc=419;continue;}
case 419:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",424);}
case 424:{f.Locals[20]=f.Pop();f.Pc=426;continue;}
case 426:{f.Push(f.Locals[20]);f.Pc=428;continue;}
case 428:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",433);}
case 433:{f.Pc=f.Pop().Int==0?462:436;continue;}
case 436:{f.Push(f.Locals[20]);f.Pc=438;continue;}
case 438:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",443);}
case 443:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=446;continue;}
case 446:{f.Locals[21]=f.Pop();f.Pc=448;continue;}
case 448:{f.Push(f.Locals[2]);f.Pc=449;continue;}
case 449:{f.Push(f.Locals[21]);f.Pc=451;continue;}
case 451:{f.Push(f.Locals[19]);f.Pc=453;continue;}
case 453:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;Ljava/util/Map;)Lforge/game/card/Card;","invokestatic",456);}
case 456:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",459);}
case 459:{f.Pc=426;continue;}
case 462:{f.Push(f.Locals[4]);f.Pc=464;continue;}
case 464:{f.Pc=f.Pop().Int==0?580:467;continue;}
case 467:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",470);}
case 470:{f.Locals[19]=f.Pop();f.Pc=472;continue;}
case 472:{f.Push(f.Locals[17]);f.Pc=474;continue;}
case 474:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",479);}
case 479:{f.Locals[20]=f.Pop();f.Pc=481;continue;}
case 481:{f.Push(f.Locals[20]);f.Pc=483;continue;}
case 483:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",488);}
case 488:{f.Pc=f.Pop().Int==0?517:491;continue;}
case 491:{f.Push(f.Locals[20]);f.Pc=493;continue;}
case 493:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",498);}
case 498:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=501;continue;}
case 501:{f.Locals[21]=f.Pop();f.Pc=503;continue;}
case 503:{f.Push(f.Locals[2]);f.Pc=504;continue;}
case 504:{f.Push(f.Locals[21]);f.Pc=506;continue;}
case 506:{f.Push(f.Locals[19]);f.Pc=508;continue;}
case 508:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;Ljava/util/Map;)Lforge/game/card/Card;","invokestatic",511);}
case 511:{return rt.Call(f,"forge/game/card/Card","addImprintedCard","(Lforge/game/card/Card;)V","invokevirtual",514);}
case 514:{f.Pc=481;continue;}
case 517:{f.Pc=580;continue;}
case 520:{f.Push(f.Locals[1]);f.Pc=521;continue;}
case 521:{f.Push(JValue.R(rt.String("RememberPeeked")));f.Pc=524;continue;}
case 524:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",527);}
case 527:{f.Pc=f.Pop().Int==0?580:530;continue;}
case 530:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",533);}
case 533:{f.Locals[19]=f.Pop();f.Pc=535;continue;}
case 535:{f.Push(f.Locals[17]);f.Pc=537;continue;}
case 537:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",542);}
case 542:{f.Locals[20]=f.Pop();f.Pc=544;continue;}
case 544:{f.Push(f.Locals[20]);f.Pc=546;continue;}
case 546:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",551);}
case 551:{f.Pc=f.Pop().Int==0?580:554;continue;}
case 554:{f.Push(f.Locals[20]);f.Pc=556;continue;}
case 556:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",561);}
case 561:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=564;continue;}
case 564:{f.Locals[21]=f.Pop();f.Pc=566;continue;}
case 566:{f.Push(f.Locals[2]);f.Pc=567;continue;}
case 567:{f.Push(f.Locals[21]);f.Pc=569;continue;}
case 569:{f.Push(f.Locals[19]);f.Pc=571;continue;}
case 571:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;Ljava/util/Map;)Lforge/game/card/Card;","invokestatic",574);}
case 574:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",577);}
case 577:{f.Pc=544;continue;}
case 580:{f.Pc=104;continue;}
case 583:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
