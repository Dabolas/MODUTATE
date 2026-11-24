// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C428{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/VoteEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3826,"forge/game/ability/effects/VoteEffect","<init>","()V",1,1,1,new JHandler[]{},M3826));
c.Add(new JMethod(3827,"forge/game/ability/effects/VoteEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,3,3,new JHandler[]{},M3827));
c.Add(new JMethod(3828,"forge/game/ability/effects/VoteEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,22,8,new JHandler[]{},M3828));
c.Add(new JMethod(3829,"forge/game/ability/effects/VoteEffect","getMostVotes","(Lcom/google/common/collect/ListMultimap;)Ljava/util/List;",10,6,2,new JHandler[]{},M3829));
}

internal static JStep M3826(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3827(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/effects/VoteEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",16);}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.Push(JValue.R(rt.String(" vote ")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",24);}
case 24:{f.StackOp("pop");f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("Choices")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?58:34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("for ")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",40);}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("Choices")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbilityList","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",46);}
case 46:{f.Push(JValue.R(rt.String(" or ")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",51);}
case 51:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{f.Pc=78;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("VoteMessage")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int==0?78:67;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("VoteMessage")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",74);}
case 74:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",77);}
case 77:{f.StackOp("pop");f.Pc=78;continue;}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String(".")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",84);}
case 84:{f.StackOp("pop");f.Pc=85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",89);}
case 89:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3828(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/VoteEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",13);}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",20);}
case 20:{f.Locals[5]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",26);}
case 26:{f.Locals[6]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("Secretly")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",34);}
case 34:{f.Locals[7]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("VotePlayer")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?63:45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("VotePlayer")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",51);}
case 51:{f.Push(JValue.R(rt.String("Other")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?63:59;continue;}
case 59:{f.Push(JValue.I(1));f.Pc=60;continue;}
case 60:{f.Pc=64;continue;}
case 63:{f.Push(JValue.I(0));f.Pc=64;continue;}
case 64:{f.Locals[8]=f.Pop();f.Pc=66;continue;}
case 66:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",73);}
case 73:{f.Locals[9]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("Choices")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int==0?100:84;continue;}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.String("Choices")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbilityList","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",91);}
case 91:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",96);}
case 96:{f.StackOp("pop");f.Pc=97;continue;}
case 97:{f.Pc=208;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("VoteCard")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?166:109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("Zone")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",115);}
case 115:{f.Pc=f.Pop().Int==0?130:118;continue;}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("Zone")));f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",124);}
case 124:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",127);}
case 127:{f.Pc=133;continue;}
case 130:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=133;continue;}
case 133:{f.Locals[10]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[3]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[5]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[10]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",143);}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{f.Push(JValue.R(rt.String("VoteCard")));f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",149);}
case 149:{f.Push(f.Locals[6]);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[4]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",157);}
case 157:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",162);}
case 162:{f.StackOp("pop");f.Pc=163;continue;}
case 163:{f.Pc=208;continue;}
case 166:{f.Push(f.Locals[1]);f.Pc=167;continue;}
case 167:{f.Push(JValue.R(rt.String("VotePlayer")));f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",172);}
case 172:{f.Pc=f.Pop().Int==0?208:175;continue;}
case 175:{f.Push(f.Locals[8]);f.Pc=177;continue;}
case 177:{f.Pc=f.Pop().Int==0?185:180;continue;}
case 180:{f.Push(JValue.R(rt.String("Player")));f.Pc=182;continue;}
case 182:{f.Pc=191;continue;}
case 185:{f.Push(f.Locals[1]);f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.String("VotePlayer")));f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",191);}
case 191:{f.Locals[10]=f.Pop();f.Pc=193;continue;}
case 193:{f.Push(f.Locals[3]);f.Pc=194;continue;}
case 194:{f.Push(f.Locals[4]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[10]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[1]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",202);}
case 202:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",207);}
case 207:{f.StackOp("pop");f.Pc=208;continue;}
case 208:{f.Push(f.Locals[3]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",214);}
case 214:{f.Pc=f.Pop().Int==0?218:217;continue;}
case 217:{return JStep.ReturnVoid;}
case 218:{f.Push(f.Locals[2]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[6]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"java/util/List","indexOf","(Ljava/lang/Object;)I","invokeinterface",226);}
case 226:{f.Locals[10]=f.Pop();f.Pc=228;continue;}
case 228:{f.Push(f.Locals[10]);f.Pc=230;continue;}
case 230:{f.Push(JValue.I(-1));f.Pc=231;continue;}
case 231:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?241:234;continue;}
case 234:{f.Push(f.Locals[2]);f.Pc=235;continue;}
case 235:{f.Push(f.Locals[10]);f.Pc=237;continue;}
case 237:{f.Push(JNumbers.Unary("ineg",f.Pop()));f.Pc=238;continue;}
case 238:{return rt.Call(f,"java/util/Collections","rotate","(Ljava/util/List;I)V","invokestatic",241);}
case 241:{return rt.Call(f,"com/google/common/collect/ArrayListMultimap","create","()Lcom/google/common/collect/ArrayListMultimap;","invokestatic",244);}
case 244:{f.Locals[11]=f.Pop();f.Pc=246;continue;}
case 246:{f.Push(f.Locals[5]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/Game","getControlVote","()Lforge/game/player/Player;","invokevirtual",251);}
case 251:{f.Locals[12]=f.Pop();f.Pc=253;continue;}
case 253:{f.Push(f.Locals[2]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",259);}
case 259:{f.Locals[13]=f.Pop();f.Pc=261;continue;}
case 261:{f.Push(f.Locals[13]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",268);}
case 268:{f.Pc=f.Pop().Int==0?584:271;continue;}
case 271:{f.Push(f.Locals[13]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",278);}
case 278:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=281;continue;}
case 281:{f.Locals[14]=f.Pop();f.Pc=283;continue;}
case 283:{f.Push(f.Locals[14]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",288);}
case 288:{f.Pc=f.Pop().Int!=0?294:291;continue;}
case 291:{f.Pc=261;continue;}
case 294:{f.Push(f.Locals[3]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",298);}
case 298:{f.Locals[15]=f.Pop();f.Pc=300;continue;}
case 300:{f.Push(f.Locals[14]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/game/player/Player","getAdditionalVotesAmount","()I","invokevirtual",305);}
case 305:{f.Push(JValue.I(1));f.Pc=306;continue;}
case 306:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=307;continue;}
case 307:{f.Locals[16]=f.Pop();f.Pc=309;continue;}
case 309:{f.Push(f.Locals[14]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/player/Player","getAdditionalOptionalVotesAmount","()I","invokevirtual",314);}
case 314:{f.Locals[17]=f.Pop();f.Pc=316;continue;}
case 316:{f.Push(f.Locals[12]);f.Pc=318;continue;}
case 318:{f.Pc=f.Pop().Reference!=null?326:321;continue;}
case 321:{f.Push(f.Locals[14]);f.Pc=323;continue;}
case 323:{f.Pc=328;continue;}
case 326:{f.Push(f.Locals[12]);f.Pc=328;continue;}
case 328:{f.Locals[18]=f.Pop();f.Pc=330;continue;}
case 330:{f.Push(f.Locals[8]);f.Pc=332;continue;}
case 332:{f.Pc=f.Pop().Int==0?358:335;continue;}
case 335:{f.Push(f.Locals[15]);f.Pc=337;continue;}
case 337:{f.Push(f.Locals[14]);f.Pc=339;continue;}
case 339:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",344);}
case 344:{f.StackOp("pop");f.Pc=345;continue;}
case 345:{f.Push(f.Locals[15]);f.Pc=347;continue;}
case 347:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",352);}
case 352:{f.Pc=f.Pop().Int==0?358:355;continue;}
case 355:{f.Pc=261;continue;}
case 358:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",361);}
case 361:{f.Locals[19]=f.Pop();f.Pc=363;continue;}
case 363:{f.Push(f.Locals[19]);f.Pc=365;continue;}
case 365:{f.Push(JValue.R(rt.String("Voter")));f.Pc=367;continue;}
case 367:{f.Push(f.Locals[18]);f.Pc=369;continue;}
case 369:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",374);}
case 374:{f.StackOp("pop");f.Pc=375;continue;}
case 375:{f.Push(f.Locals[16]);f.Pc=377;continue;}
case 377:{f.Push(f.Locals[14]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",382);}
case 382:{f.Push(f.Locals[1]);f.Pc=383;continue;}
case 383:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",386);}
case 386:{f.Push(JValue.R(rt.String("lblHowManyAdditionalVotesDoYouWant")));f.Pc=388;continue;}
case 388:{f.Push(JValue.I(0));f.Pc=389;continue;}
case 389:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",395);}
case 395:{f.Push(JValue.I(0));f.Pc=396;continue;}
case 396:{f.Push(f.Locals[17]);f.Pc=398;continue;}
case 398:{f.Push(f.Locals[19]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;IILjava/util/Map;)I","invokevirtual",403);}
case 403:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=404;continue;}
case 404:{f.Locals[16]=f.Pop();f.Pc=406;continue;}
case 406:{f.Push(JValue.I(0));f.Pc=407;continue;}
case 407:{f.Locals[20]=f.Pop();f.Pc=409;continue;}
case 409:{f.Push(f.Locals[20]);f.Pc=411;continue;}
case 411:{f.Push(f.Locals[16]);f.Pc=413;continue;}
case 413:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?581:416;continue;}
case 416:{f.Push(f.Locals[18]);f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",421);}
case 421:{f.Push(f.Locals[1]);f.Pc=422;continue;}
case 422:{f.Push(f.Locals[4]);f.Pc=424;continue;}
case 424:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",427);}
case 427:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",430);}
case 430:{f.Push(JValue.R(rt.String("lblVote")));f.Pc=432;continue;}
case 432:{f.Push(JValue.I(0));f.Pc=433;continue;}
case 433:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",439);}
case 439:{return rt.DynamicCall(f,"forge/game/ability/effects/VoteEffect:3828:439:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",444);}
case 444:{f.Push(f.Locals[15]);f.Pc=446;continue;}
case 446:{f.Push(f.Locals[11]);f.Pc=448;continue;}
case 448:{f.Push(f.Locals[14]);f.Pc=450;continue;}
case 450:{f.Push(f.Locals[1]);f.Pc=451;continue;}
case 451:{f.Push(JValue.R(rt.String("UpTo")));f.Pc=453;continue;}
case 453:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",456);}
case 456:{return rt.Call(f,"forge/game/player/PlayerController","vote","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/List;Lcom/google/common/collect/ListMultimap;Lforge/game/player/Player;Z)Ljava/lang/Object;","invokevirtual",459);}
case 459:{f.Locals[21]=f.Pop();f.Pc=461;continue;}
case 461:{f.Push(f.Locals[21]);f.Pc=463;continue;}
case 463:{f.Pc=f.Pop().Reference==null?575:466;continue;}
case 466:{f.Push(f.Locals[11]);f.Pc=468;continue;}
case 468:{f.Push(f.Locals[21]);f.Pc=470;continue;}
case 470:{f.Push(f.Locals[14]);f.Pc=472;continue;}
case 472:{return rt.Call(f,"com/google/common/collect/ListMultimap","put","(Ljava/lang/Object;Ljava/lang/Object;)Z","invokeinterface",477);}
case 477:{f.StackOp("pop");f.Pc=478;continue;}
case 478:{f.Push(f.Locals[7]);f.Pc=480;continue;}
case 480:{f.Pc=f.Pop().Int!=0?523:483;continue;}
case 483:{f.Push(f.Locals[5]);f.Pc=485;continue;}
case 485:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",488);}
case 488:{f.Push(f.Locals[1]);f.Pc=489;continue;}
case 489:{f.Push(f.Locals[14]);f.Pc=491;continue;}
case 491:{f.Push(f.Locals[21]);f.Pc=493;continue;}
case 493:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",496);}
case 496:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",499);}
case 499:{f.Push(JValue.R(rt.String("lblCurrentVote")));f.Pc=501;continue;}
case 501:{f.Push(JValue.I(0));f.Pc=502;continue;}
case 502:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=505;continue;}
case 505:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",508);}
case 508:{f.Push(f.Locals[11]);f.Pc=510;continue;}
case 510:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",513);}
case 513:{return rt.DynamicCall(f,"forge/game/ability/effects/VoteEffect:3828:513:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",518);}
case 518:{f.Push(f.Locals[14]);f.Pc=520;continue;}
case 520:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",523);}
case 523:{f.Push(f.Locals[9]);f.Pc=525;continue;}
case 525:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",528);}
case 528:{f.Pc=f.Pop().Int<=0?540:531;continue;}
case 531:{f.Push(f.Locals[9]);f.Pc=533;continue;}
case 533:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=536;continue;}
case 536:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",539);}
case 539:{f.StackOp("pop");f.Pc=540;continue;}
case 540:{f.Push(f.Locals[9]);f.Pc=542;continue;}
case 542:{f.Push(f.Locals[14]);f.Pc=544;continue;}
case 544:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",547);}
case 547:{f.Push(JValue.R(rt.String(" ")));f.Pc=550;continue;}
case 550:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",553);}
case 553:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",556);}
case 556:{f.Push(JValue.R(rt.String("lblVotedFor")));f.Pc=559;continue;}
case 559:{f.Push(JValue.I(1));f.Pc=560;continue;}
case 560:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=563;continue;}
case 563:{f.StackOp("dup");f.Pc=564;continue;}
case 564:{f.Push(JValue.I(0));f.Pc=565;continue;}
case 565:{f.Push(f.Locals[21]);f.Pc=567;continue;}
case 567:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=568;continue;}
case 568:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",571);}
case 571:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",574);}
case 574:{f.StackOp("pop");f.Pc=575;continue;}
case 575:{f.Locals[20]=JValue.I(unchecked(f.Locals[20].Int+(1)));f.Pc=578;continue;}
case 578:{f.Pc=409;continue;}
case 581:{f.Pc=261;continue;}
case 584:{f.Push(f.Locals[9]);f.Pc=586;continue;}
case 586:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",589);}
case 589:{f.Locals[13]=f.Pop();f.Pc=591;continue;}
case 591:{f.Push(f.Locals[7]);f.Pc=593;continue;}
case 593:{f.Pc=f.Pop().Int==0?610:596;continue;}
case 596:{f.Push(f.Locals[5]);f.Pc=598;continue;}
case 598:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",601);}
case 601:{f.Push(f.Locals[1]);f.Pc=602;continue;}
case 602:{f.Push(f.Locals[4]);f.Pc=604;continue;}
case 604:{f.Push(f.Locals[13]);f.Pc=606;continue;}
case 606:{f.Push(JValue.R(null));f.Pc=607;continue;}
case 607:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",610);}
case 610:{f.Push(f.Locals[5]);f.Pc=612;continue;}
case 612:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventRandomLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventRandomLog")));f.Pc=615;continue;}
case 615:{f.StackOp("dup");f.Pc=616;continue;}
case 616:{f.Push(f.Locals[13]);f.Pc=618;continue;}
case 618:{return rt.Call(f,"forge/game/event/GameEventRandomLog","<init>","(Ljava/lang/String;)V","invokespecial",621);}
case 621:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",624);}
case 624:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",627);}
case 627:{f.Locals[14]=f.Pop();f.Pc=629;continue;}
case 629:{f.Push(f.Locals[14]);f.Pc=631;continue;}
case 631:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AllVotes","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AllVotes","Lforge/game/ability/AbilityKey;"));f.Pc=634;continue;}
case 634:{f.Push(f.Locals[11]);f.Pc=636;continue;}
case 636:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",641);}
case 641:{f.StackOp("pop");f.Pc=642;continue;}
case 642:{f.Push(f.Locals[5]);f.Pc=644;continue;}
case 644:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",647);}
case 647:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Vote","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Vote","Lforge/game/trigger/TriggerType;"));f.Pc=650;continue;}
case 650:{f.Push(f.Locals[14]);f.Pc=652;continue;}
case 652:{f.Push(JValue.I(0));f.Pc=653;continue;}
case 653:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",656);}
case 656:{f.Push(f.Locals[1]);f.Pc=657;continue;}
case 657:{f.Push(JValue.R(rt.String("EachVote")));f.Pc=660;continue;}
case 660:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",663);}
case 663:{f.Pc=f.Pop().Int==0?804:666;continue;}
case 666:{f.Push(f.Locals[11]);f.Pc=668;continue;}
case 668:{return rt.Call(f,"com/google/common/collect/ListMultimap","asMap","()Ljava/util/Map;","invokeinterface",673);}
case 673:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",678);}
case 678:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",683);}
case 683:{f.Locals[15]=f.Pop();f.Pc=685;continue;}
case 685:{f.Push(f.Locals[15]);f.Pc=687;continue;}
case 687:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",692);}
case 692:{f.Pc=f.Pop().Int==0?801:695;continue;}
case 695:{f.Push(f.Locals[15]);f.Pc=697;continue;}
case 697:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",702);}
case 702:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=705;continue;}
case 705:{f.Locals[16]=f.Pop();f.Pc=707;continue;}
case 707:{f.Push(f.Locals[16]);f.Pc=709;continue;}
case 709:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",714);}
case 714:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=717;continue;}
case 717:{f.Locals[17]=f.Pop();f.Pc=719;continue;}
case 719:{f.Push(f.Locals[17]);f.Pc=721;continue;}
case 721:{f.Push(f.Locals[1]);f.Pc=722;continue;}
case 722:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",725);}
case 725:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",728);}
case 728:{f.Push(f.Locals[17]);f.Pc=730;continue;}
case 730:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=733;continue;}
case 733:{f.Push(f.Locals[1]);f.Pc=734;continue;}
case 734:{return rt.Call(f,"forge/game/spellability/AbilitySub","setParent","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",737);}
case 737:{f.Push(f.Locals[16]);f.Pc=739;continue;}
case 739:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",744);}
case 744:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=747;continue;}
case 747:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",752);}
case 752:{f.Locals[18]=f.Pop();f.Pc=754;continue;}
case 754:{f.Push(f.Locals[18]);f.Pc=756;continue;}
case 756:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",761);}
case 761:{f.Pc=f.Pop().Int==0?798:764;continue;}
case 764:{f.Push(f.Locals[18]);f.Pc=766;continue;}
case 766:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",771);}
case 771:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=774;continue;}
case 774:{f.Locals[19]=f.Pop();f.Pc=776;continue;}
case 776:{f.Push(f.Locals[4]);f.Pc=778;continue;}
case 778:{f.Push(f.Locals[19]);f.Pc=780;continue;}
case 780:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",783);}
case 783:{f.Push(f.Locals[17]);f.Pc=785;continue;}
case 785:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",788);}
case 788:{f.Push(f.Locals[4]);f.Pc=790;continue;}
case 790:{f.Push(f.Locals[19]);f.Pc=792;continue;}
case 792:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",795);}
case 795:{f.Pc=754;continue;}
case 798:{f.Pc=685;continue;}
case 801:{f.Pc=1221;continue;}
case 804:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",807);}
case 807:{f.Locals[15]=f.Pop();f.Pc=809;continue;}
case 809:{f.Push(f.Locals[1]);f.Pc=810;continue;}
case 810:{f.Push(JValue.R(rt.String("StoreVoteNum")));f.Pc=813;continue;}
case 813:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",816);}
case 816:{f.Pc=f.Pop().Int==0?908:819;continue;}
case 819:{f.Push(f.Locals[1]);f.Pc=820;continue;}
case 820:{f.Push(JValue.R(rt.String("Choices")));f.Pc=822;continue;}
case 822:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",825);}
case 825:{f.Pc=f.Pop().Int==0?908:828;continue;}
case 828:{f.Push(f.Locals[3]);f.Pc=829;continue;}
case 829:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",834);}
case 834:{f.Locals[16]=f.Pop();f.Pc=836;continue;}
case 836:{f.Push(f.Locals[16]);f.Pc=838;continue;}
case 838:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",843);}
case 843:{f.Pc=f.Pop().Int==0?905:846;continue;}
case 846:{f.Push(f.Locals[16]);f.Pc=848;continue;}
case 848:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",853);}
case 853:{f.Locals[17]=f.Pop();f.Pc=855;continue;}
case 855:{f.Push(f.Locals[17]);f.Pc=857;continue;}
case 857:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=860;continue;}
case 860:{f.Locals[18]=f.Pop();f.Pc=862;continue;}
case 862:{f.Push(f.Locals[18]);f.Pc=864;continue;}
case 864:{f.Push(JValue.R(rt.String("VoteNum")));f.Pc=867;continue;}
case 867:{f.Push(f.Locals[11]);f.Pc=869;continue;}
case 869:{f.Push(f.Locals[17]);f.Pc=871;continue;}
case 871:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",876);}
case 876:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",881);}
case 881:{return rt.DynamicCall(f,"forge/game/ability/effects/VoteEffect:3828:881:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",886);}
case 886:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",889);}
case 889:{f.Push(f.Locals[15]);f.Pc=891;continue;}
case 891:{f.Push(f.Locals[17]);f.Pc=893;continue;}
case 893:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=896;continue;}
case 896:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",901);}
case 901:{f.StackOp("pop");f.Pc=902;continue;}
case 902:{f.Pc=836;continue;}
case 905:{f.Pc=1042;continue;}
case 908:{f.Push(f.Locals[11]);f.Pc=910;continue;}
case 910:{return rt.Call(f,"forge/game/ability/effects/VoteEffect","getMostVotes","(Lcom/google/common/collect/ListMultimap;)Ljava/util/List;","invokestatic",913);}
case 913:{f.Locals[16]=f.Pop();f.Pc=915;continue;}
case 915:{f.Push(f.Locals[1]);f.Pc=916;continue;}
case 916:{f.Push(JValue.R(rt.String("VoteTiedAbility")));f.Pc=919;continue;}
case 919:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasAdditionalAbility","(Ljava/lang/String;)Z","invokevirtual",922);}
case 922:{f.Pc=f.Pop().Int==0?954:925;continue;}
case 925:{f.Push(f.Locals[16]);f.Pc=927;continue;}
case 927:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",932);}
case 932:{f.Push(JValue.I(1));f.Pc=933;continue;}
case 933:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?954:936;continue;}
case 936:{f.Push(f.Locals[15]);f.Pc=938;continue;}
case 938:{f.Push(f.Locals[1]);f.Pc=939;continue;}
case 939:{f.Push(JValue.R(rt.String("VoteTiedAbility")));f.Pc=942;continue;}
case 942:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",945);}
case 945:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",950);}
case 950:{f.StackOp("pop");f.Pc=951;continue;}
case 951:{f.Pc=1042;continue;}
case 954:{f.Push(f.Locals[1]);f.Pc=955;continue;}
case 955:{f.Push(JValue.R(rt.String("VoteSubAbility")));f.Pc=958;continue;}
case 958:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasAdditionalAbility","(Ljava/lang/String;)Z","invokevirtual",961);}
case 961:{f.Pc=f.Pop().Int==0?989:964;continue;}
case 964:{f.Push(f.Locals[4]);f.Pc=966;continue;}
case 966:{f.Push(f.Locals[16]);f.Pc=968;continue;}
case 968:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",971);}
case 971:{f.Push(f.Locals[15]);f.Pc=973;continue;}
case 973:{f.Push(f.Locals[1]);f.Pc=974;continue;}
case 974:{f.Push(JValue.R(rt.String("VoteSubAbility")));f.Pc=977;continue;}
case 977:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",980);}
case 980:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",985);}
case 985:{f.StackOp("pop");f.Pc=986;continue;}
case 986:{f.Pc=1042;continue;}
case 989:{f.Push(f.Locals[1]);f.Pc=990;continue;}
case 990:{f.Push(JValue.R(rt.String("Choices")));f.Pc=992;continue;}
case 992:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",995);}
case 995:{f.Pc=f.Pop().Int==0?1042:998;continue;}
case 998:{f.Push(f.Locals[16]);f.Pc=1000;continue;}
case 1000:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1005);}
case 1005:{f.Locals[17]=f.Pop();f.Pc=1007;continue;}
case 1007:{f.Push(f.Locals[17]);f.Pc=1009;continue;}
case 1009:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1014);}
case 1014:{f.Pc=f.Pop().Int==0?1042:1017;continue;}
case 1017:{f.Push(f.Locals[17]);f.Pc=1019;continue;}
case 1019:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1024);}
case 1024:{f.Locals[18]=f.Pop();f.Pc=1026;continue;}
case 1026:{f.Push(f.Locals[15]);f.Pc=1028;continue;}
case 1028:{f.Push(f.Locals[18]);f.Pc=1030;continue;}
case 1030:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1033;continue;}
case 1033:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1038);}
case 1038:{f.StackOp("pop");f.Pc=1039;continue;}
case 1039:{f.Pc=1007;continue;}
case 1042:{f.Push(f.Locals[1]);f.Pc=1043;continue;}
case 1043:{f.Push(JValue.R(rt.String("StoreVoteNum")));f.Pc=1046;continue;}
case 1046:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1049);}
case 1049:{f.Pc=f.Pop().Int==0?1127:1052;continue;}
case 1052:{f.Push(f.Locals[1]);f.Pc=1053;continue;}
case 1053:{f.Push(JValue.R(rt.String("Choices")));f.Pc=1055;continue;}
case 1055:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1058);}
case 1058:{f.Pc=f.Pop().Int!=0?1127:1061;continue;}
case 1061:{f.Push(f.Locals[3]);f.Pc=1062;continue;}
case 1062:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1067);}
case 1067:{f.Locals[16]=f.Pop();f.Pc=1069;continue;}
case 1069:{f.Push(f.Locals[16]);f.Pc=1071;continue;}
case 1071:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1076);}
case 1076:{f.Pc=f.Pop().Int==0?1124:1079;continue;}
case 1079:{f.Push(f.Locals[16]);f.Pc=1081;continue;}
case 1081:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1086);}
case 1086:{f.Locals[17]=f.Pop();f.Pc=1088;continue;}
case 1088:{f.Push(f.Locals[1]);f.Pc=1089;continue;}
case 1089:{f.Push(f.Locals[17]);f.Pc=1091;continue;}
case 1091:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",1094);}
case 1094:{return rt.DynamicCall(f,"forge/game/ability/effects/VoteEffect:3828:1094:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1099);}
case 1099:{f.Push(f.Locals[11]);f.Pc=1101;continue;}
case 1101:{f.Push(f.Locals[17]);f.Pc=1103;continue;}
case 1103:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",1108);}
case 1108:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1113);}
case 1113:{return rt.DynamicCall(f,"forge/game/ability/effects/VoteEffect:3828:1113:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",1118);}
case 1118:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1121);}
case 1121:{f.Pc=1069;continue;}
case 1124:{f.Pc=1184;continue;}
case 1127:{f.Push(f.Locals[15]);f.Pc=1129;continue;}
case 1129:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1134);}
case 1134:{f.Locals[16]=f.Pop();f.Pc=1136;continue;}
case 1136:{f.Push(f.Locals[16]);f.Pc=1138;continue;}
case 1138:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1143);}
case 1143:{f.Pc=f.Pop().Int==0?1184:1146;continue;}
case 1146:{f.Push(f.Locals[16]);f.Pc=1148;continue;}
case 1148:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1153);}
case 1153:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1156;continue;}
case 1156:{f.Locals[17]=f.Pop();f.Pc=1158;continue;}
case 1158:{f.Push(f.Locals[17]);f.Pc=1160;continue;}
case 1160:{f.Push(f.Locals[1]);f.Pc=1161;continue;}
case 1161:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",1164);}
case 1164:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",1167);}
case 1167:{f.Push(f.Locals[17]);f.Pc=1169;continue;}
case 1169:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1172;continue;}
case 1172:{f.Push(f.Locals[1]);f.Pc=1173;continue;}
case 1173:{return rt.Call(f,"forge/game/spellability/AbilitySub","setParent","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",1176);}
case 1176:{f.Push(f.Locals[17]);f.Pc=1178;continue;}
case 1178:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",1181);}
case 1181:{f.Pc=1136;continue;}
case 1184:{f.Push(f.Locals[1]);f.Pc=1185;continue;}
case 1185:{f.Push(JValue.R(rt.String("VoteSubAbility")));f.Pc=1188;continue;}
case 1188:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1191);}
case 1191:{f.Pc=f.Pop().Int==0?1199:1194;continue;}
case 1194:{f.Push(f.Locals[4]);f.Pc=1196;continue;}
case 1196:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",1199);}
case 1199:{f.Push(f.Locals[1]);f.Pc=1200;continue;}
case 1200:{f.Push(JValue.R(rt.String("RememberVotedObjects")));f.Pc=1203;continue;}
case 1203:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1206);}
case 1206:{f.Pc=f.Pop().Int==0?1221:1209;continue;}
case 1209:{f.Push(f.Locals[4]);f.Pc=1211;continue;}
case 1211:{f.Push(f.Locals[11]);f.Pc=1213;continue;}
case 1213:{return rt.Call(f,"com/google/common/collect/ListMultimap","keySet","()Ljava/util/Set;","invokeinterface",1218);}
case 1218:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",1221);}
case 1221:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3829(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{f.Locals[2]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"com/google/common/collect/ListMultimap","keySet","()Ljava/util/Set;","invokeinterface",12);}
case 12:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?95:27;continue;}
case 27:{f.Push(f.Locals[3]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",43);}
case 43:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",48);}
case 48:{f.Locals[5]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?68:56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{f.Pc=92;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?92:74;continue;}
case 74:{f.Push(f.Locals[5]);f.Pc=76;continue;}
case 76:{f.Locals[2]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",83);}
case 83:{f.Push(f.Locals[1]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[4]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",91);}
case 91:{f.StackOp("pop");f.Pc=92;continue;}
case 92:{f.Pc=18;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
