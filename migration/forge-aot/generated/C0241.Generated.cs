// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C241{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ChooseSourceEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3164,"forge/game/ability/effects/ChooseSourceEffect","<init>","()V",1,1,1,new JHandler[]{},M3164));
c.Add(new JMethod(3165,"forge/game/ability/effects/ChooseSourceEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,3,2,new JHandler[]{},M3165));
c.Add(new JMethod(3166,"forge/game/ability/effects/ChooseSourceEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,21,5,new JHandler[]{},M3166));
c.Add(new JMethod(3167,"forge/game/ability/effects/ChooseSourceEffect","hasSourceLeft","(Lforge/game/card/CardCollectionView;)Z",10,3,2,new JHandler[]{},M3167));
}

internal static JStep M3164(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3165(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/effects/ChooseSourceEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",16);}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String(" chooses a source.")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",31);}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3166(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/ability/effects/ChooseSourceEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",26);}
case 26:{f.Locals[5]=f.Pop();f.Pc=28;continue;}
case 28:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",35);}
case 35:{f.Locals[6]=f.Pop();f.Pc=37;continue;}
case 37:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=40;continue;}
case 40:{f.StackOp("dup");f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",44);}
case 44:{f.Locals[7]=f.Pop();f.Pc=46;continue;}
case 46:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=49;continue;}
case 49:{f.StackOp("dup");f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",53);}
case 53:{f.Locals[8]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",62);}
case 62:{f.Locals[9]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",71);}
case 71:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",76);}
case 76:{f.Locals[10]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[10]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",85);}
case 85:{f.Pc=f.Pop().Int==0?119:88;continue;}
case 88:{f.Push(f.Locals[10]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",95);}
case 95:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=98;continue;}
case 98:{f.Locals[11]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[11]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int!=0?116:108;continue;}
case 108:{f.Push(f.Locals[7]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[11]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",115);}
case 115:{f.StackOp("pop");f.Pc=116;continue;}
case 116:{f.Pc=78;continue;}
case 119:{f.Push(f.Locals[3]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",123);}
case 123:{return rt.Call(f,"forge/game/zone/MagicStack","iterator","()Ljava/util/Iterator;","invokevirtual",126);}
case 126:{f.Locals[10]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[10]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",135);}
case 135:{f.Pc=f.Pop().Int==0?326:138;continue;}
case 138:{f.Push(f.Locals[10]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",145);}
case 145:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=148;continue;}
case 148:{f.Locals[11]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[5]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[11]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSourceCard","()Lforge/game/card/Card;","invokevirtual",157);}
case 157:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",160);}
case 160:{f.StackOp("pop");f.Pc=161;continue;}
case 161:{f.Push(f.Locals[11]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",166);}
case 166:{f.Locals[12]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[12]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObjects","()Ljava/util/Map;","invokevirtual",173);}
case 173:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",178);}
case 178:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",183);}
case 183:{f.Locals[13]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[13]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",192);}
case 192:{f.Pc=f.Pop().Int==0?236:195;continue;}
case 195:{f.Push(f.Locals[13]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",202);}
case 202:{f.Locals[14]=f.Pop();f.Pc=204;continue;}
case 204:{f.Push(f.Locals[14]);f.Pc=206;continue;}
case 206:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=209;continue;}
case 209:{f.Pc=f.Pop().Int==0?233:212;continue;}
case 212:{f.Push(f.Locals[5]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[14]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",219);}
case 219:{f.Pc=f.Pop().Int!=0?233:222;continue;}
case 222:{f.Push(f.Locals[6]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[14]);f.Pc=226;continue;}
case 226:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",232);}
case 232:{f.StackOp("pop");f.Pc=233;continue;}
case 233:{f.Pc=185;continue;}
case 236:{f.Push(f.Locals[12]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetCard","()Lforge/game/card/Card;","invokevirtual",241);}
case 241:{f.Pc=f.Pop().Reference==null?255:244;continue;}
case 244:{f.Push(f.Locals[6]);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[12]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetCard","()Lforge/game/card/Card;","invokevirtual",251);}
case 251:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",254);}
case 254:{f.StackOp("pop");f.Pc=255;continue;}
case 255:{f.Push(f.Locals[12]);f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/game/spellability/SpellAbility","getReplacingObjects","()Ljava/util/Map;","invokevirtual",260);}
case 260:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",265);}
case 265:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",270);}
case 270:{f.Locals[13]=f.Pop();f.Pc=272;continue;}
case 272:{f.Push(f.Locals[13]);f.Pc=274;continue;}
case 274:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",279);}
case 279:{f.Pc=f.Pop().Int==0?323:282;continue;}
case 282:{f.Push(f.Locals[13]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",289);}
case 289:{f.Locals[14]=f.Pop();f.Pc=291;continue;}
case 291:{f.Push(f.Locals[14]);f.Pc=293;continue;}
case 293:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=296;continue;}
case 296:{f.Pc=f.Pop().Int==0?320:299;continue;}
case 299:{f.Push(f.Locals[5]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[14]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",306);}
case 306:{f.Pc=f.Pop().Int!=0?320:309;continue;}
case 309:{f.Push(f.Locals[6]);f.Pc=311;continue;}
case 311:{f.Push(f.Locals[14]);f.Pc=313;continue;}
case 313:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",319);}
case 319:{f.StackOp("pop");f.Pc=320;continue;}
case 320:{f.Pc=272;continue;}
case 323:{f.Pc=128;continue;}
case 326:{f.Push(f.Locals[1]);f.Pc=327;continue;}
case 327:{f.Push(JValue.R(rt.String("Choices")));f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",332);}
case 332:{f.Pc=f.Pop().Int==0?411:335;continue;}
case 335:{f.Push(f.Locals[9]);f.Pc=337;continue;}
case 337:{f.Push(f.Locals[1]);f.Pc=338;continue;}
case 338:{f.Push(JValue.R(rt.String("Choices")));f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",343);}
case 343:{f.Push(f.Locals[2]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",347);}
case 347:{f.Push(f.Locals[2]);f.Pc=348;continue;}
case 348:{f.Push(f.Locals[1]);f.Pc=349;continue;}
case 349:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",352);}
case 352:{f.Locals[9]=f.Pop();f.Pc=354;continue;}
case 354:{f.Push(f.Locals[5]);f.Pc=356;continue;}
case 356:{f.Push(f.Locals[1]);f.Pc=357;continue;}
case 357:{f.Push(JValue.R(rt.String("Choices")));f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",362);}
case 362:{f.Push(f.Locals[2]);f.Pc=363;continue;}
case 363:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",366);}
case 366:{f.Push(f.Locals[2]);f.Pc=367;continue;}
case 367:{f.Push(f.Locals[1]);f.Pc=368;continue;}
case 368:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",371);}
case 371:{f.Locals[5]=f.Pop();f.Pc=373;continue;}
case 373:{f.Push(f.Locals[6]);f.Pc=375;continue;}
case 375:{f.Push(f.Locals[1]);f.Pc=376;continue;}
case 376:{f.Push(JValue.R(rt.String("Choices")));f.Pc=378;continue;}
case 378:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",381);}
case 381:{f.Push(f.Locals[2]);f.Pc=382;continue;}
case 382:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",385);}
case 385:{f.Push(f.Locals[2]);f.Pc=386;continue;}
case 386:{f.Push(f.Locals[1]);f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",390);}
case 390:{f.Locals[6]=f.Pop();f.Pc=392;continue;}
case 392:{f.Push(f.Locals[7]);f.Pc=394;continue;}
case 394:{f.Push(f.Locals[1]);f.Pc=395;continue;}
case 395:{f.Push(JValue.R(rt.String("Choices")));f.Pc=397;continue;}
case 397:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",400);}
case 400:{f.Push(f.Locals[2]);f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",404);}
case 404:{f.Push(f.Locals[2]);f.Pc=405;continue;}
case 405:{f.Push(f.Locals[1]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",409);}
case 409:{f.Locals[7]=f.Pop();f.Pc=411;continue;}
case 411:{if(!rt.EnsureInitialized(f,"forge/game/card/Card"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/Card")));f.Pc=414;continue;}
case 414:{f.StackOp("dup");f.Pc=415;continue;}
case 415:{f.Push(JValue.I(-1));f.Pc=416;continue;}
case 416:{f.Push(f.Locals[3]);f.Pc=417;continue;}
case 417:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/game/Game;)V","invokespecial",420);}
case 420:{f.Locals[10]=f.Pop();f.Pc=422;continue;}
case 422:{f.Push(f.Locals[10]);f.Pc=424;continue;}
case 424:{f.Push(JValue.R(rt.String("--PERMANENTS:--")));f.Pc=426;continue;}
case 426:{return rt.Call(f,"forge/game/card/Card","setName","(Ljava/lang/String;)V","invokevirtual",429);}
case 429:{if(!rt.EnsureInitialized(f,"forge/game/card/Card"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/Card")));f.Pc=432;continue;}
case 432:{f.StackOp("dup");f.Pc=433;continue;}
case 433:{f.Push(JValue.I(-2));f.Pc=435;continue;}
case 435:{f.Push(f.Locals[3]);f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/game/Game;)V","invokespecial",439);}
case 439:{f.Locals[11]=f.Pop();f.Pc=441;continue;}
case 441:{f.Push(f.Locals[11]);f.Pc=443;continue;}
case 443:{f.Push(JValue.R(rt.String("--SPELLS ON THE STACK:--")));f.Pc=445;continue;}
case 445:{return rt.Call(f,"forge/game/card/Card","setName","(Ljava/lang/String;)V","invokevirtual",448);}
case 448:{if(!rt.EnsureInitialized(f,"forge/game/card/Card"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/Card")));f.Pc=451;continue;}
case 451:{f.StackOp("dup");f.Pc=452;continue;}
case 452:{f.Push(JValue.I(-3));f.Pc=454;continue;}
case 454:{f.Push(f.Locals[3]);f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/game/Game;)V","invokespecial",458);}
case 458:{f.Locals[12]=f.Pop();f.Pc=460;continue;}
case 460:{f.Push(f.Locals[12]);f.Pc=462;continue;}
case 462:{f.Push(JValue.R(rt.String("--OBJECTS REFERRED TO ON THE STACK:--")));f.Pc=464;continue;}
case 464:{return rt.Call(f,"forge/game/card/Card","setName","(Ljava/lang/String;)V","invokevirtual",467);}
case 467:{if(!rt.EnsureInitialized(f,"forge/game/card/Card"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/Card")));f.Pc=470;continue;}
case 470:{f.StackOp("dup");f.Pc=471;continue;}
case 471:{f.Push(JValue.I(-4));f.Pc=473;continue;}
case 473:{f.Push(f.Locals[3]);f.Pc=474;continue;}
case 474:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/game/Game;)V","invokespecial",477);}
case 477:{f.Locals[13]=f.Pop();f.Pc=479;continue;}
case 479:{f.Push(f.Locals[13]);f.Pc=481;continue;}
case 481:{f.Push(JValue.R(rt.String("--CARDS IN THE COMMAND ZONE:--")));f.Pc=483;continue;}
case 483:{return rt.Call(f,"forge/game/card/Card","setName","(Ljava/lang/String;)V","invokevirtual",486);}
case 486:{f.Push(f.Locals[9]);f.Pc=488;continue;}
case 488:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",493);}
case 493:{f.Pc=f.Pop().Int!=0?512:496;continue;}
case 496:{f.Push(f.Locals[8]);f.Pc=498;continue;}
case 498:{f.Push(f.Locals[10]);f.Pc=500;continue;}
case 500:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",503);}
case 503:{f.StackOp("pop");f.Pc=504;continue;}
case 504:{f.Push(f.Locals[8]);f.Pc=506;continue;}
case 506:{f.Push(f.Locals[9]);f.Pc=508;continue;}
case 508:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",511);}
case 511:{f.StackOp("pop");f.Pc=512;continue;}
case 512:{f.Push(f.Locals[5]);f.Pc=514;continue;}
case 514:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",517);}
case 517:{f.Pc=f.Pop().Int!=0?536:520;continue;}
case 520:{f.Push(f.Locals[8]);f.Pc=522;continue;}
case 522:{f.Push(f.Locals[11]);f.Pc=524;continue;}
case 524:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",527);}
case 527:{f.StackOp("pop");f.Pc=528;continue;}
case 528:{f.Push(f.Locals[8]);f.Pc=530;continue;}
case 530:{f.Push(f.Locals[5]);f.Pc=532;continue;}
case 532:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",535);}
case 535:{f.StackOp("pop");f.Pc=536;continue;}
case 536:{f.Push(f.Locals[6]);f.Pc=538;continue;}
case 538:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",541);}
case 541:{f.Pc=f.Pop().Int!=0?560:544;continue;}
case 544:{f.Push(f.Locals[8]);f.Pc=546;continue;}
case 546:{f.Push(f.Locals[12]);f.Pc=548;continue;}
case 548:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",551);}
case 551:{f.StackOp("pop");f.Pc=552;continue;}
case 552:{f.Push(f.Locals[8]);f.Pc=554;continue;}
case 554:{f.Push(f.Locals[6]);f.Pc=556;continue;}
case 556:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",559);}
case 559:{f.StackOp("pop");f.Pc=560;continue;}
case 560:{f.Push(f.Locals[7]);f.Pc=562;continue;}
case 562:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",565);}
case 565:{f.Pc=f.Pop().Int!=0?584:568;continue;}
case 568:{f.Push(f.Locals[8]);f.Pc=570;continue;}
case 570:{f.Push(f.Locals[13]);f.Pc=572;continue;}
case 572:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",575);}
case 575:{f.StackOp("pop");f.Pc=576;continue;}
case 576:{f.Push(f.Locals[8]);f.Pc=578;continue;}
case 578:{f.Push(f.Locals[7]);f.Pc=580;continue;}
case 580:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",583);}
case 583:{f.StackOp("pop");f.Pc=584;continue;}
case 584:{f.Push(f.Locals[8]);f.Pc=586;continue;}
case 586:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",589);}
case 589:{f.Pc=f.Pop().Int==0?593:592;continue;}
case 592:{return JStep.ReturnVoid;}
case 593:{f.Push(f.Locals[2]);f.Pc=594;continue;}
case 594:{f.Push(f.Locals[1]);f.Pc=595;continue;}
case 595:{f.Push(JValue.R(rt.String("Amount")));f.Pc=597;continue;}
case 597:{f.Push(JValue.R(rt.String("1")));f.Pc=599;continue;}
case 599:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",602);}
case 602:{f.Push(f.Locals[1]);f.Pc=603;continue;}
case 603:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",606);}
case 606:{f.Locals[14]=f.Pop();f.Pc=608;continue;}
case 608:{f.Push(f.Locals[4]);f.Pc=610;continue;}
case 610:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",615);}
case 615:{f.Locals[15]=f.Pop();f.Pc=617;continue;}
case 617:{f.Push(f.Locals[15]);f.Pc=619;continue;}
case 619:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",624);}
case 624:{f.Pc=f.Pop().Int==0?803:627;continue;}
case 627:{f.Push(f.Locals[15]);f.Pc=629;continue;}
case 629:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",634);}
case 634:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=637;continue;}
case 637:{f.Locals[16]=f.Pop();f.Pc=639;continue;}
case 639:{f.Push(f.Locals[16]);f.Pc=641;continue;}
case 641:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",644);}
case 644:{f.Pc=f.Pop().Int!=0?650:647;continue;}
case 647:{f.Pc=617;continue;}
case 650:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=653;continue;}
case 653:{f.StackOp("dup");f.Pc=654;continue;}
case 654:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",657);}
case 657:{f.Locals[17]=f.Pop();f.Pc=659;continue;}
case 659:{f.Push(JValue.I(0));f.Pc=660;continue;}
case 660:{f.Locals[18]=f.Pop();f.Pc=662;continue;}
case 662:{f.Push(f.Locals[18]);f.Pc=664;continue;}
case 664:{f.Push(f.Locals[14]);f.Pc=666;continue;}
case 666:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?779:669;continue;}
case 669:{f.Push(f.Locals[8]);f.Pc=671;continue;}
case 671:{return rt.Call(f,"forge/game/ability/effects/ChooseSourceEffect","hasSourceLeft","(Lforge/game/card/CardCollectionView;)Z","invokestatic",674);}
case 674:{f.Pc=f.Pop().Int!=0?680:677;continue;}
case 677:{f.Pc=779;continue;}
case 680:{f.Push(f.Locals[1]);f.Pc=681;continue;}
case 681:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=683;continue;}
case 683:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",686);}
case 686:{f.Pc=f.Pop().Int==0?698:689;continue;}
case 689:{f.Push(f.Locals[1]);f.Pc=690;continue;}
case 690:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=692;continue;}
case 692:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",695);}
case 695:{f.Pc=715;continue;}
case 698:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",701);}
case 701:{f.Push(JValue.R(rt.String("lblChooseSource")));f.Pc=703;continue;}
case 703:{f.Push(JValue.I(0));f.Pc=704;continue;}
case 704:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=707;continue;}
case 707:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",710);}
case 710:{return rt.DynamicCall(f,"forge/game/ability/effects/ChooseSourceEffect:3166:710:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",715);}
case 715:{f.Locals[19]=f.Pop();f.Pc=717;continue;}
case 717:{f.Push(JValue.R(null));f.Pc=718;continue;}
case 718:{f.Locals[20]=f.Pop();f.Pc=720;continue;}
case 720:{f.Push(f.Locals[16]);f.Pc=722;continue;}
case 722:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",725);}
case 725:{f.Push(f.Locals[8]);f.Pc=727;continue;}
case 727:{f.Push(f.Locals[1]);f.Pc=728;continue;}
case 728:{f.Push(f.Locals[19]);f.Pc=730;continue;}
case 730:{f.Push(JValue.R(null));f.Pc=731;continue;}
case 731:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",734);}
case 734:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=737;continue;}
case 737:{f.Locals[20]=f.Pop();f.Pc=739;continue;}
case 739:{f.Push(f.Locals[20]);f.Pc=741;continue;}
case 741:{f.Pc=f.Pop().Reference==null?720:744;continue;}
case 744:{f.Push(f.Locals[20]);f.Pc=746;continue;}
case 746:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",749);}
case 749:{f.Push(JValue.R(rt.String("--")));f.Pc=751;continue;}
case 751:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",754);}
case 754:{f.Pc=f.Pop().Int!=0?720:757;continue;}
case 757:{f.Push(f.Locals[17]);f.Pc=759;continue;}
case 759:{f.Push(f.Locals[20]);f.Pc=761;continue;}
case 761:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",764);}
case 764:{f.StackOp("pop");f.Pc=765;continue;}
case 765:{f.Push(f.Locals[8]);f.Pc=767;continue;}
case 767:{f.Push(f.Locals[20]);f.Pc=769;continue;}
case 769:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",772);}
case 772:{f.StackOp("pop");f.Pc=773;continue;}
case 773:{f.Locals[18]=JValue.I(unchecked(f.Locals[18].Int+(1)));f.Pc=776;continue;}
case 776:{f.Pc=662;continue;}
case 779:{f.Push(f.Locals[2]);f.Pc=780;continue;}
case 780:{f.Push(f.Locals[17]);f.Pc=782;continue;}
case 782:{return rt.Call(f,"forge/game/card/Card","setChosenCards","(Ljava/lang/Iterable;)V","invokevirtual",785);}
case 785:{f.Push(f.Locals[1]);f.Pc=786;continue;}
case 786:{f.Push(JValue.R(rt.String("RememberChosen")));f.Pc=788;continue;}
case 788:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",791);}
case 791:{f.Pc=f.Pop().Int==0?800:794;continue;}
case 794:{f.Push(f.Locals[2]);f.Pc=795;continue;}
case 795:{f.Push(f.Locals[17]);f.Pc=797;continue;}
case 797:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",800);}
case 800:{f.Pc=617;continue;}
case 803:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3167(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",6);}
case 6:{f.Locals[1]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?43:16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",30);}
case 30:{f.Push(JValue.R(rt.String("--")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int!=0?40:38;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 40:{f.Pc=7;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
