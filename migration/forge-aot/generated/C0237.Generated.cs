// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C237{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChooseGenericEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3153,"forge/game/ability/effects/ChooseGenericEffect","<init>","()V",1,1,1,new JHandler[]{},M3153));
c.Add(new JMethod(3154,"forge/game/ability/effects/ChooseGenericEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,3,new JHandler[]{},M3154));
c.Add(new JMethod(3155,"forge/game/ability/effects/ChooseGenericEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,23,8,new JHandler[]{},M3155));
}

internal static JStep M3153(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3154(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/ChooseGenericEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",18);}
case 18:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",29);}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?38:33;continue;}
case 33:{f.Push(JValue.R(rt.String(" chooses")));f.Pc=35;continue;}
case 35:{f.Pc=40;continue;}
case 38:{f.Push(JValue.R(rt.String(" choose")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",43);}
case 43:{f.Push(JValue.R(rt.String(" from a list.")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",53);}
case 53:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3155(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Choices")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbilityList","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",16);}
case 16:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("NumRandomChoices")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?64:30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("NumRandomChoices")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",41);}
case 41:{f.Locals[5]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",50);}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?64:55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/util/Aggregates","removeRandom","(Ljava/util/List;)Ljava/lang/Object;","invokestatic",60);}
case 60:{f.StackOp("pop");f.Pc=61;continue;}
case 61:{f.Pc=43;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("FallbackAbility")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",70);}
case 70:{f.Locals[5]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[2]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("ChoiceAmount")));f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("1")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",81);}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",85);}
case 85:{f.Locals[6]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String("TempRemember")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",93);}
case 93:{f.Locals[7]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("Secretly")));f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",101);}
case 101:{f.Locals[8]=f.Pop();f.Pc=103;continue;}
case 103:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=106;continue;}
case 106:{f.StackOp("dup");f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",110);}
case 110:{f.Locals[9]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{f.Push(JValue.R(rt.String("ChangeZoneTable")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",118);}
case 118:{f.Locals[10]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("DamageMap")));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",126);}
case 126:{f.Locals[11]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[11]);f.Pc=130;continue;}
case 130:{f.Pc=f.Pop().Int==0?166:133;continue;}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=137;continue;}
case 137:{f.StackOp("dup");f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","()V","invokespecial",141);}
case 141:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDamageMap","(Lforge/game/card/CardDamageTable;)V","invokevirtual",144);}
case 144:{f.Push(f.Locals[1]);f.Pc=145;continue;}
case 145:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=148;continue;}
case 148:{f.StackOp("dup");f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","()V","invokespecial",152);}
case 152:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPreventMap","(Lforge/game/card/CardDamageTable;)V","invokevirtual",155);}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=159;continue;}
case 159:{f.StackOp("dup");f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",163);}
case 163:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCounterTable","(Lforge/game/GameEntityCounterTable;)V","invokevirtual",166);}
case 166:{f.Push(f.Locals[10]);f.Pc=168;continue;}
case 168:{f.Pc=f.Pop().Int==0?182:171;continue;}
case 171:{f.Push(f.Locals[1]);f.Pc=172;continue;}
case 172:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=175;continue;}
case 175:{f.StackOp("dup");f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","()V","invokespecial",179);}
case 179:{return rt.Call(f,"forge/game/spellability/SpellAbility","setChangeZoneTable","(Lforge/game/card/CardZoneTable;)V","invokevirtual",182);}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/ability/effects/ChooseGenericEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",186);}
case 186:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",189);}
case 189:{f.Locals[12]=f.Pop();f.Pc=191;continue;}
case 191:{f.Push(f.Locals[12]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",198);}
case 198:{f.Pc=f.Pop().Int==0?887:201;continue;}
case 201:{f.Push(f.Locals[12]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",208);}
case 208:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=211;continue;}
case 211:{f.Locals[13]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[13]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",218);}
case 218:{f.Pc=f.Pop().Int!=0?229:221;continue;}
case 221:{f.Push(f.Locals[1]);f.Pc=222;continue;}
case 222:{f.Push(f.Locals[13]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/ability/effects/ChooseGenericEffect","getNewChooser","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/player/Player;","invokestatic",227);}
case 227:{f.Locals[13]=f.Pop();f.Pc=229;continue;}
case 229:{f.Push(f.Locals[4]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",234);}
case 234:{f.Locals[14]=f.Pop();f.Pc=236;continue;}
case 236:{f.Push(f.Locals[4]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",243);}
case 243:{f.Locals[15]=f.Pop();f.Pc=245;continue;}
case 245:{f.Push(f.Locals[15]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",252);}
case 252:{f.Pc=f.Pop().Int==0?358:255;continue;}
case 255:{f.Push(f.Locals[15]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",262);}
case 262:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=265;continue;}
case 265:{f.Locals[16]=f.Pop();f.Pc=267;continue;}
case 267:{f.Push(f.Locals[16]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",272);}
case 272:{f.Pc=f.Pop().Reference==null?306:275;continue;}
case 275:{f.Push(f.Locals[16]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",280);}
case 280:{f.Push(f.Locals[2]);f.Pc=281;continue;}
case 281:{f.Push(f.Locals[16]);f.Pc=283;continue;}
case 283:{f.Push(f.Locals[1]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",287);}
case 287:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","checkOtherRestrictions","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Z","invokevirtual",290);}
case 290:{f.Pc=f.Pop().Int!=0?306:293;continue;}
case 293:{f.Push(f.Locals[14]);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[16]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",302);}
case 302:{f.StackOp("pop");f.Pc=303;continue;}
case 303:{f.Pc=355;continue;}
case 306:{f.Push(f.Locals[16]);f.Pc=308;continue;}
case 308:{f.Push(JValue.R(rt.String("UnlessCost")));f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",313);}
case 313:{f.Pc=f.Pop().Int==0?355:316;continue;}
case 316:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=319;continue;}
case 319:{f.StackOp("dup");f.Pc=320;continue;}
case 320:{f.Push(f.Locals[16]);f.Pc=322;continue;}
case 322:{f.Push(JValue.R(rt.String("UnlessCost")));f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",327);}
case 327:{f.Push(JValue.I(0));f.Pc=328;continue;}
case 328:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",331);}
case 331:{f.Locals[17]=f.Pop();f.Pc=333;continue;}
case 333:{f.Push(f.Locals[17]);f.Pc=335;continue;}
case 335:{f.Push(f.Locals[1]);f.Pc=336;continue;}
case 336:{f.Push(f.Locals[13]);f.Pc=338;continue;}
case 338:{f.Push(JValue.I(1));f.Pc=339;continue;}
case 339:{return rt.Call(f,"forge/game/cost/Cost","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z","invokevirtual",342);}
case 342:{f.Pc=f.Pop().Int!=0?355:345;continue;}
case 345:{f.Push(f.Locals[14]);f.Pc=347;continue;}
case 347:{f.Push(f.Locals[16]);f.Pc=349;continue;}
case 349:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",354);}
case 354:{f.StackOp("pop");f.Pc=355;continue;}
case 355:{f.Pc=245;continue;}
case 358:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",361);}
case 361:{f.Locals[15]=f.Pop();f.Pc=363;continue;}
case 363:{f.Push(f.Locals[1]);f.Pc=364;continue;}
case 364:{f.Push(JValue.R(rt.String("ChoicePrompt")));f.Pc=366;continue;}
case 366:{f.Push(JValue.R(rt.String("Choose")));f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",371);}
case 371:{f.Locals[16]=f.Pop();f.Pc=373;continue;}
case 373:{f.Push(JValue.I(0));f.Pc=374;continue;}
case 374:{f.Locals[17]=f.Pop();f.Pc=376;continue;}
case 376:{f.Push(f.Locals[1]);f.Pc=377;continue;}
case 377:{f.Push(JValue.R(rt.String("AtRandom")));f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",382);}
case 382:{f.Pc=f.Pop().Int==0?534:385;continue;}
case 385:{f.Push(JValue.I(1));f.Pc=386;continue;}
case 386:{f.Locals[17]=f.Pop();f.Pc=388;continue;}
case 388:{f.Push(f.Locals[14]);f.Pc=390;continue;}
case 390:{f.Push(f.Locals[6]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",395);}
case 395:{f.Locals[15]=f.Pop();f.Pc=397;continue;}
case 397:{f.Push(JValue.I(0));f.Pc=398;continue;}
case 398:{f.Locals[18]=f.Pop();f.Pc=400;continue;}
case 400:{f.Push(f.Locals[1]);f.Pc=401;continue;}
case 401:{f.Push(JValue.R(rt.String("AtRandom")));f.Pc=403;continue;}
case 403:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",406);}
case 406:{f.Push(JValue.R(rt.String("Urza")));f.Pc=408;continue;}
case 408:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",411);}
case 411:{f.Pc=f.Pop().Int==0?531:414;continue;}
case 414:{f.Push(f.Locals[18]);f.Pc=416;continue;}
case 416:{f.Push(f.Locals[15]);f.Pc=418;continue;}
case 418:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",423);}
case 423:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?531:426;continue;}
case 426:{f.Push(f.Locals[15]);f.Pc=428;continue;}
case 428:{f.Push(f.Locals[18]);f.Pc=430;continue;}
case 430:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",435);}
case 435:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=438;continue;}
case 438:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",441);}
case 441:{f.Pc=f.Pop().Int!=0?450:444;continue;}
case 444:{f.Locals[18]=JValue.I(unchecked(f.Locals[18].Int+(1)));f.Pc=447;continue;}
case 447:{f.Pc=400;continue;}
case 450:{f.Push(f.Locals[15]);f.Pc=452;continue;}
case 452:{f.Push(f.Locals[18]);f.Pc=454;continue;}
case 454:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",459);}
case 459:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=462;continue;}
case 462:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",465);}
case 465:{f.Push(f.Locals[15]);f.Pc=467;continue;}
case 467:{f.Push(f.Locals[18]);f.Pc=469;continue;}
case 469:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",474);}
case 474:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=477;continue;}
case 477:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","hasCandidates","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",480);}
case 480:{f.Pc=f.Pop().Int==0?510:483;continue;}
case 483:{f.Push(f.Locals[13]);f.Pc=485;continue;}
case 485:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",488);}
case 488:{f.Push(f.Locals[15]);f.Pc=490;continue;}
case 490:{f.Push(f.Locals[18]);f.Pc=492;continue;}
case 492:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",497);}
case 497:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=500;continue;}
case 500:{return rt.Call(f,"forge/game/player/PlayerController","chooseTargetsFor","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",503);}
case 503:{f.StackOp("pop");f.Pc=504;continue;}
case 504:{f.Locals[18]=JValue.I(unchecked(f.Locals[18].Int+(1)));f.Pc=507;continue;}
case 507:{f.Pc=400;continue;}
case 510:{f.Push(f.Locals[15]);f.Pc=512;continue;}
case 512:{f.Push(f.Locals[18]);f.Pc=514;continue;}
case 514:{f.Push(f.Locals[4]);f.Pc=516;continue;}
case 516:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",519);}
case 519:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=522;continue;}
case 522:{return rt.Call(f,"java/util/List","set","(ILjava/lang/Object;)Ljava/lang/Object;","invokeinterface",527);}
case 527:{f.StackOp("pop");f.Pc=528;continue;}
case 528:{f.Pc=400;continue;}
case 531:{f.Pc=564;continue;}
case 534:{f.Push(f.Locals[14]);f.Pc=536;continue;}
case 536:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",541);}
case 541:{f.Pc=f.Pop().Int!=0?564:544;continue;}
case 544:{f.Push(f.Locals[13]);f.Pc=546;continue;}
case 546:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",549);}
case 549:{f.Push(f.Locals[14]);f.Pc=551;continue;}
case 551:{f.Push(f.Locals[1]);f.Pc=552;continue;}
case 552:{f.Push(f.Locals[16]);f.Pc=554;continue;}
case 554:{f.Push(f.Locals[6]);f.Pc=556;continue;}
case 556:{return rt.Call(f,"com/google/common/collect/ImmutableMap","of","()Lcom/google/common/collect/ImmutableMap;","invokestatic",559);}
case 559:{return rt.Call(f,"forge/game/player/PlayerController","chooseSpellAbilitiesForEffect","(Ljava/util/List;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ILjava/util/Map;)Ljava/util/List;","invokevirtual",562);}
case 562:{f.Locals[15]=f.Pop();f.Pc=564;continue;}
case 564:{f.Push(f.Locals[2]);f.Pc=565;continue;}
case 565:{return rt.Call(f,"forge/game/card/Card","getRemembered","()Ljava/lang/Iterable;","invokevirtual",568);}
case 568:{f.Push(JValue.R(rt.ClassObject("forge/game/player/Player")));f.Pc=570;continue;}
case 570:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/lang/Iterable;","invokestatic",573);}
case 573:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",576);}
case 576:{f.Locals[18]=f.Pop();f.Pc=578;continue;}
case 578:{f.Push(f.Locals[7]);f.Pc=580;continue;}
case 580:{f.Pc=f.Pop().Int==0?595:583;continue;}
case 583:{f.Push(f.Locals[2]);f.Pc=584;continue;}
case 584:{f.Push(f.Locals[18]);f.Pc=586;continue;}
case 586:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Iterable;)V","invokevirtual",589);}
case 589:{f.Push(f.Locals[2]);f.Pc=590;continue;}
case 590:{f.Push(f.Locals[13]);f.Pc=592;continue;}
case 592:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",595);}
case 595:{f.Push(f.Locals[15]);f.Pc=597;continue;}
case 597:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",602);}
case 602:{f.Pc=f.Pop().Int!=0?803:605;continue;}
case 605:{f.Push(f.Locals[15]);f.Pc=607;continue;}
case 607:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",612);}
case 612:{f.Locals[19]=f.Pop();f.Pc=614;continue;}
case 614:{f.Push(f.Locals[19]);f.Pc=616;continue;}
case 616:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",621);}
case 621:{f.Pc=f.Pop().Int==0?800:624;continue;}
case 624:{f.Push(f.Locals[19]);f.Pc=626;continue;}
case 626:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",631);}
case 631:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=634;continue;}
case 634:{f.Locals[20]=f.Pop();f.Pc=636;continue;}
case 636:{f.Push(f.Locals[20]);f.Pc=638;continue;}
case 638:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",641);}
case 641:{f.Locals[21]=f.Pop();f.Pc=643;continue;}
case 643:{f.Push(f.Locals[1]);f.Pc=644;continue;}
case 644:{f.Push(JValue.R(rt.String("ShowChoice")));f.Pc=647;continue;}
case 647:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",650);}
case 650:{f.Pc=f.Pop().Int==0?694:653;continue;}
case 653:{f.Push(f.Locals[1]);f.Pc=654;continue;}
case 654:{f.Push(JValue.R(rt.String("ShowChoice")));f.Pc=657;continue;}
case 657:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",660);}
case 660:{f.Push(JValue.R(rt.String("ExceptSelf")));f.Pc=663;continue;}
case 663:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",666);}
case 666:{f.Locals[22]=f.Pop();f.Pc=668;continue;}
case 668:{f.Push(f.Locals[3]);f.Pc=669;continue;}
case 669:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",672);}
case 672:{f.Push(f.Locals[1]);f.Pc=673;continue;}
case 673:{f.Push(f.Locals[13]);f.Pc=675;continue;}
case 675:{f.Push(f.Locals[21]);f.Pc=677;continue;}
case 677:{f.Push(f.Locals[22]);f.Pc=679;continue;}
case 679:{f.Pc=f.Pop().Int==0?687:682;continue;}
case 682:{f.Push(f.Locals[13]);f.Pc=684;continue;}
case 684:{f.Pc=688;continue;}
case 687:{f.Push(JValue.R(null));f.Pc=688;continue;}
case 688:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",691);}
case 691:{f.Pc=745;continue;}
case 694:{f.Push(f.Locals[8]);f.Pc=696;continue;}
case 696:{f.Pc=f.Pop().Int==0?745:699;continue;}
case 699:{f.Push(f.Locals[9]);f.Pc=701;continue;}
case 701:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",704);}
case 704:{f.Pc=f.Pop().Int<=0?716:707;continue;}
case 707:{f.Push(f.Locals[9]);f.Pc=709;continue;}
case 709:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=712;continue;}
case 712:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",715);}
case 715:{f.StackOp("pop");f.Pc=716;continue;}
case 716:{f.Push(f.Locals[9]);f.Pc=718;continue;}
case 718:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",721);}
case 721:{f.Push(JValue.R(rt.String("lblPlayerChooseValue")));f.Pc=724;continue;}
case 724:{f.Push(JValue.I(2));f.Pc=725;continue;}
case 725:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=728;continue;}
case 728:{f.StackOp("dup");f.Pc=729;continue;}
case 729:{f.Push(JValue.I(0));f.Pc=730;continue;}
case 730:{f.Push(f.Locals[13]);f.Pc=732;continue;}
case 732:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=733;continue;}
case 733:{f.StackOp("dup");f.Pc=734;continue;}
case 734:{f.Push(JValue.I(1));f.Pc=735;continue;}
case 735:{f.Push(f.Locals[21]);f.Pc=737;continue;}
case 737:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=738;continue;}
case 738:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",741);}
case 741:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",744);}
case 744:{f.StackOp("pop");f.Pc=745;continue;}
case 745:{f.Push(f.Locals[1]);f.Pc=746;continue;}
case 746:{f.Push(JValue.R(rt.String("SetChosenMode")));f.Pc=749;continue;}
case 749:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",752);}
case 752:{f.Pc=f.Pop().Int==0?764:755;continue;}
case 755:{f.Push(f.Locals[1]);f.Pc=756;continue;}
case 756:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",759);}
case 759:{f.Push(f.Locals[21]);f.Pc=761;continue;}
case 761:{return rt.Call(f,"forge/game/card/Card","setChosenMode","(Ljava/lang/String;)V","invokevirtual",764);}
case 764:{f.Push(f.Locals[3]);f.Pc=765;continue;}
case 765:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardModeChosen"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardModeChosen")));f.Pc=768;continue;}
case 768:{f.StackOp("dup");f.Pc=769;continue;}
case 769:{f.Push(f.Locals[13]);f.Pc=771;continue;}
case 771:{f.Push(f.Locals[2]);f.Pc=772;continue;}
case 772:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",775);}
case 775:{f.Push(f.Locals[21]);f.Pc=777;continue;}
case 777:{f.Push(f.Locals[1]);f.Pc=778;continue;}
case 778:{f.Push(JValue.R(rt.String("ShowChoice")));f.Pc=781;continue;}
case 781:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",784);}
case 784:{f.Push(f.Locals[17]);f.Pc=786;continue;}
case 786:{return rt.Call(f,"forge/game/event/GameEventCardModeChosen","<init>","(Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;ZZ)V","invokespecial",789);}
case 789:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",792);}
case 792:{f.Push(f.Locals[20]);f.Pc=794;continue;}
case 794:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",797);}
case 797:{f.Pc=614;continue;}
case 800:{f.Pc=867;continue;}
case 803:{f.Push(f.Locals[5]);f.Pc=805;continue;}
case 805:{f.Pc=f.Pop().Reference==null?847:808;continue;}
case 808:{f.Push(f.Locals[3]);f.Pc=809;continue;}
case 809:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardModeChosen"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardModeChosen")));f.Pc=812;continue;}
case 812:{f.StackOp("dup");f.Pc=813;continue;}
case 813:{f.Push(f.Locals[13]);f.Pc=815;continue;}
case 815:{f.Push(f.Locals[2]);f.Pc=816;continue;}
case 816:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",819);}
case 819:{f.Push(f.Locals[5]);f.Pc=821;continue;}
case 821:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",824);}
case 824:{f.Push(f.Locals[1]);f.Pc=825;continue;}
case 825:{f.Push(JValue.R(rt.String("ShowChoice")));f.Pc=828;continue;}
case 828:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",831);}
case 831:{f.Push(f.Locals[17]);f.Pc=833;continue;}
case 833:{return rt.Call(f,"forge/game/event/GameEventCardModeChosen","<init>","(Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;ZZ)V","invokespecial",836);}
case 836:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",839);}
case 839:{f.Push(f.Locals[5]);f.Pc=841;continue;}
case 841:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",844);}
case 844:{f.Pc=867;continue;}
case 847:{f.Push(f.Locals[17]);f.Pc=849;continue;}
case 849:{f.Pc=f.Pop().Int!=0?867:852;continue;}
case 852:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=855;continue;}
case 855:{f.Push(f.Locals[2]);f.Pc=856;continue;}
case 856:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",859);}
case 859:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseGenericEffect:3155:859:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",864);}
case 864:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",867);}
case 867:{f.Push(f.Locals[7]);f.Pc=869;continue;}
case 869:{f.Pc=f.Pop().Int==0?884:872;continue;}
case 872:{f.Push(f.Locals[2]);f.Pc=873;continue;}
case 873:{f.Push(f.Locals[13]);f.Pc=875;continue;}
case 875:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Object;)V","invokevirtual",878);}
case 878:{f.Push(f.Locals[2]);f.Pc=879;continue;}
case 879:{f.Push(f.Locals[18]);f.Pc=881;continue;}
case 881:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",884);}
case 884:{f.Pc=191;continue;}
case 887:{f.Push(f.Locals[8]);f.Pc=889;continue;}
case 889:{f.Pc=f.Pop().Int==0?907:892;continue;}
case 892:{f.Push(f.Locals[3]);f.Pc=893;continue;}
case 893:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",896);}
case 896:{f.Push(f.Locals[1]);f.Pc=897;continue;}
case 897:{f.Push(f.Locals[2]);f.Pc=898;continue;}
case 898:{f.Push(f.Locals[9]);f.Pc=900;continue;}
case 900:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",903);}
case 903:{f.Push(JValue.R(null));f.Pc=904;continue;}
case 904:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",907);}
case 907:{f.Push(f.Locals[11]);f.Pc=909;continue;}
case 909:{f.Pc=f.Pop().Int==0?933:912;continue;}
case 912:{f.Push(f.Locals[3]);f.Pc=913;continue;}
case 913:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",916);}
case 916:{f.Push(JValue.I(0));f.Pc=917;continue;}
case 917:{f.Push(f.Locals[1]);f.Pc=918;continue;}
case 918:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDamageMap","()Lforge/game/card/CardDamageTable;","invokevirtual",921);}
case 921:{f.Push(f.Locals[1]);f.Pc=922;continue;}
case 922:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPreventMap","()Lforge/game/card/CardDamageTable;","invokevirtual",925);}
case 925:{f.Push(f.Locals[1]);f.Pc=926;continue;}
case 926:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCounterTable","()Lforge/game/GameEntityCounterTable;","invokevirtual",929);}
case 929:{f.Push(f.Locals[1]);f.Pc=930;continue;}
case 930:{return rt.Call(f,"forge/game/GameAction","dealDamage","(ZLforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;Lforge/game/GameEntityCounterTable;Lforge/game/spellability/SpellAbility;)V","invokevirtual",933);}
case 933:{f.Push(f.Locals[10]);f.Pc=935;continue;}
case 935:{f.Pc=f.Pop().Int==0?952:938;continue;}
case 938:{f.Push(f.Locals[1]);f.Pc=939;continue;}
case 939:{return rt.Call(f,"forge/game/spellability/SpellAbility","getChangeZoneTable","()Lforge/game/card/CardZoneTable;","invokevirtual",942);}
case 942:{f.Push(f.Locals[3]);f.Pc=943;continue;}
case 943:{f.Push(f.Locals[1]);f.Pc=944;continue;}
case 944:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",947);}
case 947:{f.Push(f.Locals[1]);f.Pc=948;continue;}
case 948:{f.Push(JValue.R(null));f.Pc=949;continue;}
case 949:{return rt.Call(f,"forge/game/spellability/SpellAbility","setChangeZoneTable","(Lforge/game/card/CardZoneTable;)V","invokevirtual",952);}
case 952:{f.Push(f.Locals[1]);f.Pc=953;continue;}
case 953:{f.Push(JValue.R(rt.String("Guess")));f.Pc=956;continue;}
case 956:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",959);}
case 959:{f.Pc=f.Pop().Int==0?966:962;continue;}
case 962:{f.Push(f.Locals[3]);f.Pc=963;continue;}
case 963:{return rt.Call(f,"forge/game/Game","incPiledGuessedSA","()V","invokevirtual",966);}
case 966:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
