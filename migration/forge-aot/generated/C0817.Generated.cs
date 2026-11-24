// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C817{
internal static JClass Build(){var c=new JClass("forge/game/staticability/StaticAbilityAlternativeCost","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(9853,"forge/game/staticability/StaticAbilityAlternativeCost","<init>","()V",1,1,1,new JHandler[]{},M9853));
c.Add(new JMethod(9854,"forge/game/staticability/StaticAbilityAlternativeCost","alternativeCosts","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Ljava/util/List;",9,13,4,new JHandler[]{},M9854));
c.Add(new JMethod(9855,"forge/game/staticability/StaticAbilityAlternativeCost","apply","(Lforge/game/staticability/StaticAbility;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z",10,4,3,new JHandler[]{},M9855));
}

internal static JStep M9853(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9854(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Lforge/game/card/Card;)V","invokespecial",12);}
case 12:{f.Locals[4]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[4]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",20);}
case 20:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",35);}
case 35:{f.Locals[5]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[5]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",44);}
case 44:{f.Pc=f.Pop().Int==0?553:47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",54);}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{f.Locals[6]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[6]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/card/Card","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",64);}
case 64:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",69);}
case 69:{f.Locals[7]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[7]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",78);}
case 78:{f.Pc=f.Pop().Int==0?550:81;continue;}
case 81:{f.Push(f.Locals[7]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",88);}
case 88:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=91;continue;}
case 91:{f.Locals[8]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[8]);f.Pc=95;continue;}
case 95:{if(!rt.StaticReady(f,"forge/game/staticability/StaticAbilityMode","AlternativeCost","Lforge/game/staticability/StaticAbilityMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/staticability/StaticAbilityMode","AlternativeCost","Lforge/game/staticability/StaticAbilityMode;"));f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkMode","(Lforge/game/staticability/StaticAbilityMode;)Z","invokevirtual",101);}
case 101:{f.Pc=f.Pop().Int!=0?107:104;continue;}
case 104:{f.Pc=71;continue;}
case 107:{f.Push(f.Locals[8]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[1]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[2]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/staticability/StaticAbilityAlternativeCost","apply","(Lforge/game/staticability/StaticAbility;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokestatic",115);}
case 115:{f.Pc=f.Pop().Int!=0?121:118;continue;}
case 118:{f.Pc=71;continue;}
case 121:{f.Push(f.Locals[8]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/staticability/StaticAbility","checkConditions","()Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int!=0?132:129;continue;}
case 129:{f.Pc=71;continue;}
case 132:{f.Push(f.Locals[8]);f.Pc=134;continue;}
case 134:{f.Push(JValue.R(rt.String("Cost")));f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",139);}
case 139:{f.Locals[9]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[9]);f.Pc=143;continue;}
case 143:{f.Push(JValue.R(rt.String("ConvertedManaCost")));f.Pc=145;continue;}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",149);}
case 149:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",152);}
case 152:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",155);}
case 155:{f.Locals[9]=f.Pop();f.Pc=157;continue;}
case 157:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=160;continue;}
case 160:{f.StackOp("dup");f.Pc=161;continue;}
case 161:{f.Push(f.Locals[9]);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[0]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",167);}
case 167:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",170);}
case 170:{f.Locals[10]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",176);}
case 176:{f.Pc=f.Pop().Int==0?188:179;continue;}
case 179:{f.Push(f.Locals[0]);f.Pc=180;continue;}
case 180:{f.Push(f.Locals[10]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithDefinedCost","(Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",185);}
case 185:{f.Pc=195;continue;}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[2]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[10]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/game/spellability/SpellAbility","copyWithManaCostReplaced","(Lforge/game/player/Player;Lforge/game/cost/Cost;)Lforge/game/spellability/SpellAbility;","invokevirtual",195);}
case 195:{f.Locals[11]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(f.Locals[11]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[2]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",203);}
case 203:{f.Push(f.Locals[11]);f.Pc=205;continue;}
case 205:{f.Push(JValue.I(0));f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/spellability/SpellAbility","setBasicSpell","(Z)V","invokevirtual",209);}
case 209:{f.Push(f.Locals[8]);f.Pc=211;continue;}
case 211:{f.Push(JValue.R(rt.String("XAlternative")));f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",216);}
case 216:{f.Pc=f.Pop().Int==0?234:219;continue;}
case 219:{f.Push(f.Locals[11]);f.Pc=221;continue;}
case 221:{f.Push(JValue.R(rt.String("XAlternative")));f.Pc=223;continue;}
case 223:{f.Push(f.Locals[8]);f.Pc=225;continue;}
case 225:{f.Push(JValue.R(rt.String("XAlternative")));f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",230);}
case 230:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",233);}
case 233:{f.StackOp("pop");f.Pc=234;continue;}
case 234:{f.Push(f.Locals[8]);f.Pc=236;continue;}
case 236:{f.Push(JValue.R(rt.String("Announce")));f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",241);}
case 241:{f.Pc=f.Pop().Int==0?259:244;continue;}
case 244:{f.Push(f.Locals[11]);f.Pc=246;continue;}
case 246:{f.Push(JValue.R(rt.String("Announce")));f.Pc=248;continue;}
case 248:{f.Push(f.Locals[8]);f.Pc=250;continue;}
case 250:{f.Push(JValue.R(rt.String("Announce")));f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",255);}
case 255:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",258);}
case 258:{f.StackOp("pop");f.Pc=259;continue;}
case 259:{f.Push(f.Locals[8]);f.Pc=261;continue;}
case 261:{f.Push(JValue.R(rt.String("ManaRestriction")));f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",266);}
case 266:{f.Pc=f.Pop().Int==0?284:269;continue;}
case 269:{f.Push(f.Locals[11]);f.Pc=271;continue;}
case 271:{f.Push(JValue.R(rt.String("ManaRestriction")));f.Pc=273;continue;}
case 273:{f.Push(f.Locals[8]);f.Pc=275;continue;}
case 275:{f.Push(JValue.R(rt.String("ManaRestriction")));f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",280);}
case 280:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",283);}
case 283:{f.StackOp("pop");f.Pc=284;continue;}
case 284:{f.Push(f.Locals[8]);f.Pc=286;continue;}
case 286:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",289);}
case 289:{return rt.Call(f,"forge/game/card/Card","isImmutable","()Z","invokevirtual",292);}
case 292:{f.Pc=f.Pop().Int!=0?344:295;continue;}
case 295:{f.Push(f.Locals[8]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/staticability/StaticAbility","getActiveZone","()Ljava/util/Set;","invokevirtual",300);}
case 300:{f.Locals[12]=f.Pop();f.Pc=302;continue;}
case 302:{f.Push(f.Locals[12]);f.Pc=304;continue;}
case 304:{f.Pc=f.Pop().Reference==null?344:307;continue;}
case 307:{f.Push(f.Locals[12]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"java/util/Set","size","()I","invokeinterface",314);}
case 314:{f.Push(JValue.I(1));f.Pc=315;continue;}
case 315:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?344:318;continue;}
case 318:{f.Push(f.Locals[11]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",323);}
case 323:{f.Push(f.Locals[12]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"java/util/Set","stream","()Ljava/util/stream/Stream;","invokeinterface",330);}
case 330:{return rt.Call(f,"java/util/stream/Stream","findFirst","()Ljava/util/Optional;","invokeinterface",335);}
case 335:{return rt.Call(f,"java/util/Optional","get","()Ljava/lang/Object;","invokevirtual",338);}
case 338:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=341;continue;}
case 341:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",344);}
case 344:{f.Push(f.Locals[8]);f.Pc=346;continue;}
case 346:{f.Push(JValue.R(rt.String("StackDescription")));f.Pc=348;continue;}
case 348:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",351);}
case 351:{f.Pc=f.Pop().Int==0?369:354;continue;}
case 354:{f.Push(f.Locals[11]);f.Pc=356;continue;}
case 356:{f.Push(JValue.R(rt.String("StackDescription")));f.Pc=358;continue;}
case 358:{f.Push(f.Locals[8]);f.Pc=360;continue;}
case 360:{f.Push(JValue.R(rt.String("StackDescription")));f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",365);}
case 365:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",368);}
case 368:{f.StackOp("pop");f.Pc=369;continue;}
case 369:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=372;continue;}
case 372:{f.StackOp("dup");f.Pc=373;continue;}
case 373:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",376);}
case 376:{f.Locals[12]=f.Pop();f.Pc=378;continue;}
case 378:{f.Push(f.Locals[0]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",382);}
case 382:{f.Pc=f.Pop().Int==0?432:385;continue;}
case 385:{f.Push(f.Locals[11]);f.Pc=387;continue;}
case 387:{f.Push(JValue.R(rt.String("CostDesc")));f.Pc=389;continue;}
case 389:{f.Push(f.Locals[8]);f.Pc=391;continue;}
case 391:{f.Push(JValue.R(rt.String("CostDesc")));f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",396);}
case 396:{f.Pc=f.Pop().Int==0?412:399;continue;}
case 399:{f.Push(f.Locals[8]);f.Pc=401;continue;}
case 401:{f.Push(JValue.R(rt.String("CostDesc")));f.Pc=403;continue;}
case 403:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",406);}
case 406:{return rt.Call(f,"forge/card/mana/ManaCostParser","parse","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",409);}
case 409:{f.Pc=417;continue;}
case 412:{f.Push(f.Locals[10]);f.Pc=414;continue;}
case 414:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",417);}
case 417:{return rt.Call(f,"forge/game/spellability/SpellAbility","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",420);}
case 420:{f.StackOp("pop");f.Pc=421;continue;}
case 421:{f.Push(f.Locals[12]);f.Pc=423;continue;}
case 423:{f.Push(f.Locals[11]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCostDescription","()Ljava/lang/String;","invokevirtual",428);}
case 428:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",431);}
case 431:{f.StackOp("pop");f.Pc=432;continue;}
case 432:{f.Push(f.Locals[0]);f.Pc=433;continue;}
case 433:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",436);}
case 436:{f.Pc=f.Pop().Int==0?506:439;continue;}
case 439:{f.Push(f.Locals[12]);f.Pc=441;continue;}
case 441:{f.Push(f.Locals[0]);f.Pc=442;continue;}
case 442:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",445);}
case 445:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",448);}
case 448:{f.StackOp("pop");f.Pc=449;continue;}
case 449:{f.Push(f.Locals[1]);f.Pc=450;continue;}
case 450:{f.Push(f.Locals[8]);f.Pc=452;continue;}
case 452:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",455);}
case 455:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",458);}
case 458:{f.Pc=f.Pop().Int==0?490:461;continue;}
case 461:{f.Push(f.Locals[11]);f.Pc=463;continue;}
case 463:{if(!rt.StaticReady(f,"forge/game/spellability/OptionalCost","AltCost","Lforge/game/spellability/OptionalCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/OptionalCost","AltCost","Lforge/game/spellability/OptionalCost;"));f.Pc=466;continue;}
case 466:{return rt.Call(f,"forge/game/spellability/SpellAbility","addOptionalCost","(Lforge/game/spellability/OptionalCost;)V","invokevirtual",469);}
case 469:{f.Push(f.Locals[12]);f.Pc=471;continue;}
case 471:{f.Push(f.Locals[8]);f.Pc=473;continue;}
case 473:{f.Push(JValue.R(rt.String("Description")));f.Pc=475;continue;}
case 475:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",478);}
case 478:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityAlternativeCost:9854:478:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",483);}
case 483:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",486);}
case 486:{f.StackOp("pop");f.Pc=487;continue;}
case 487:{f.Pc=506;continue;}
case 490:{f.Push(f.Locals[12]);f.Pc=492;continue;}
case 492:{f.Push(f.Locals[10]);f.Pc=494;continue;}
case 494:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",497);}
case 497:{return rt.DynamicCall(f,"forge/game/staticability/StaticAbilityAlternativeCost:9854:497:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",502);}
case 502:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",505);}
case 505:{f.StackOp("pop");f.Pc=506;continue;}
case 506:{f.Push(f.Locals[11]);f.Pc=508;continue;}
case 508:{f.Push(f.Locals[12]);f.Pc=510;continue;}
case 510:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",513);}
case 513:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDescription","(Ljava/lang/String;)V","invokevirtual",516);}
case 516:{f.Push(f.Locals[8]);f.Pc=518;continue;}
case 518:{f.Push(JValue.R(rt.String("Named")));f.Pc=520;continue;}
case 520:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",523);}
case 523:{f.Pc=f.Pop().Int==0?538:526;continue;}
case 526:{f.Push(f.Locals[11]);f.Pc=528;continue;}
case 528:{f.Push(f.Locals[8]);f.Pc=530;continue;}
case 530:{f.Push(JValue.R(rt.String("Named")));f.Pc=532;continue;}
case 532:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",535);}
case 535:{return rt.Call(f,"forge/game/spellability/SpellAbility","setName","(Ljava/lang/String;)V","invokevirtual",538);}
case 538:{f.Push(f.Locals[3]);f.Pc=539;continue;}
case 539:{f.Push(f.Locals[11]);f.Pc=541;continue;}
case 541:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",546);}
case 546:{f.StackOp("pop");f.Pc=547;continue;}
case 547:{f.Pc=71;continue;}
case 550:{f.Pc=37;continue;}
case 553:{f.Push(f.Locals[3]);f.Pc=554;continue;}
case 554:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9855(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ValidSA")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int!=0?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int!=0?25:23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("ValidPlayer")));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/staticability/StaticAbility","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int!=0?38:36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
