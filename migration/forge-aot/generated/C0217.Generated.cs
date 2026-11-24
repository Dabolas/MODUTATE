// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C217{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/BookkeepingEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3071,"forge/game/ability/effects/BookkeepingEffect","<init>","()V",1,1,1,new JHandler[]{},M3071));
c.Add(new JMethod(3072,"forge/game/ability/effects/BookkeepingEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,3,new JHandler[]{},M3072));
c.Add(new JMethod(3073,"forge/game/ability/effects/BookkeepingEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,2,1,new JHandler[]{},M3073));
c.Add(new JMethod(3074,"forge/game/ability/effects/BookkeepingEffect","apply","(Lforge/game/spellability/SpellAbility;)V",9,8,4,new JHandler[]{},M3074));
}

internal static JStep M3071(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3072(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("StackDescription")));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("")));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3073(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/BookkeepingEffect","apply","(Lforge/game/spellability/SpellAbility;)V","invokestatic",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3074(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("RememberObjects")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?29:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("RememberObjects")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedObjects","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",26);}
case 26:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",29);}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("RememberAll")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?108:38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("RememberZone")));f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",46);}
case 46:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",49);}
case 49:{f.Locals[2]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",54);}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",58);}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("RememberAll")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",64);}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",68);}
case 68:{f.Locals[3]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",75);}
case 75:{f.Locals[4]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",84);}
case 84:{f.Pc=f.Pop().Int==0?108:87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",94);}
case 94:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=97;continue;}
case 97:{f.Locals[5]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[5]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",105);}
case 105:{f.Pc=77;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("NoteCardsFor")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?208:117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("NoteCards")));f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",124);}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",128);}
case 128:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",131);}
case 131:{f.Locals[2]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[2]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",138);}
case 138:{f.Pc=f.Pop().Int==0?208:141;continue;}
case 141:{f.Push(f.Locals[2]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",147);}
case 147:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=150;continue;}
case 150:{f.Locals[3]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(f.Locals[0]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/ability/effects/BookkeepingEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",155);}
case 155:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",158);}
case 158:{f.Locals[4]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[4]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",167);}
case 167:{f.Pc=f.Pop().Int==0?205:170;continue;}
case 170:{f.Push(f.Locals[4]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",177);}
case 177:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=180;continue;}
case 180:{f.Locals[5]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(f.Locals[5]);f.Pc=184;continue;}
case 184:{f.Push(f.Locals[0]);f.Pc=185;continue;}
case 185:{f.Push(JValue.R(rt.String("NoteCardsFor")));f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",190);}
case 190:{f.Push(f.Locals[3]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/card/Card","getId","()I","invokevirtual",194);}
case 194:{return rt.DynamicCall(f,"forge/game/ability/effects/BookkeepingEffect:3074:194:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",199);}
case 199:{return rt.Call(f,"forge/game/player/Player","addNoteForName","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",202);}
case 202:{f.Pc=160;continue;}
case 205:{f.Pc=132;continue;}
case 208:{f.Push(f.Locals[0]);f.Pc=209;continue;}
case 209:{f.Push(JValue.R(rt.String("ClearNotedCardsFor")));f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",214);}
case 214:{f.Pc=f.Pop().Int==0?294:217;continue;}
case 217:{f.Push(f.Locals[0]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/game/ability/effects/BookkeepingEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",221);}
case 221:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",224);}
case 224:{f.Locals[2]=f.Pop();f.Pc=225;continue;}
case 225:{f.Push(f.Locals[2]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",231);}
case 231:{f.Pc=f.Pop().Int==0?294:234;continue;}
case 234:{f.Push(f.Locals[2]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",240);}
case 240:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=243;continue;}
case 243:{f.Locals[3]=f.Pop();f.Pc=244;continue;}
case 244:{f.Push(f.Locals[0]);f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.String("ClearNotedCardsFor")));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",250);}
case 250:{f.Push(JValue.R(rt.String(",")));f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",255);}
case 255:{f.Locals[4]=f.Pop();f.Pc=257;continue;}
case 257:{f.Push(f.Locals[4]);f.Pc=259;continue;}
case 259:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=260;continue;}
case 260:{f.Locals[5]=f.Pop();f.Pc=262;continue;}
case 262:{f.Push(JValue.I(0));f.Pc=263;continue;}
case 263:{f.Locals[6]=f.Pop();f.Pc=265;continue;}
case 265:{f.Push(f.Locals[6]);f.Pc=267;continue;}
case 267:{f.Push(f.Locals[5]);f.Pc=269;continue;}
case 269:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?291:272;continue;}
case 272:{f.Push(f.Locals[4]);f.Pc=274;continue;}
case 274:{f.Push(f.Locals[6]);f.Pc=276;continue;}
case 276:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=277;continue;}
case 277:{f.Locals[7]=f.Pop();f.Pc=279;continue;}
case 279:{f.Push(f.Locals[3]);f.Pc=280;continue;}
case 280:{f.Push(f.Locals[7]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/player/Player","clearNotesForName","(Ljava/lang/String;)V","invokevirtual",285);}
case 285:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=288;continue;}
case 288:{f.Pc=265;continue;}
case 291:{f.Pc=225;continue;}
case 294:{f.Push(f.Locals[0]);f.Pc=295;continue;}
case 295:{f.Push(JValue.R(rt.String("NoteNumber")));f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",300);}
case 300:{f.Pc=f.Pop().Int==0?356:303;continue;}
case 303:{f.Push(f.Locals[1]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[0]);f.Pc=305;continue;}
case 305:{f.Push(JValue.R(rt.String("NoteNumber")));f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",310);}
case 310:{f.Push(f.Locals[0]);f.Pc=311;continue;}
case 311:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",314);}
case 314:{f.Locals[2]=f.Pop();f.Pc=315;continue;}
case 315:{f.Push(f.Locals[0]);f.Pc=316;continue;}
case 316:{return rt.Call(f,"forge/game/ability/effects/BookkeepingEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",319);}
case 319:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",322);}
case 322:{f.Locals[3]=f.Pop();f.Pc=323;continue;}
case 323:{f.Push(f.Locals[3]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",329);}
case 329:{f.Pc=f.Pop().Int==0?356:332;continue;}
case 332:{f.Push(f.Locals[3]);f.Pc=333;continue;}
case 333:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",338);}
case 338:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=341;continue;}
case 341:{f.Locals[4]=f.Pop();f.Pc=343;continue;}
case 343:{f.Push(f.Locals[4]);f.Pc=345;continue;}
case 345:{f.Push(f.Locals[1]);f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",349);}
case 349:{f.Push(f.Locals[2]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/game/player/Player","noteNumberForName","(Ljava/lang/String;I)V","invokevirtual",353);}
case 353:{f.Pc=323;continue;}
case 356:{f.Push(f.Locals[0]);f.Pc=357;continue;}
case 357:{f.Push(JValue.R(rt.String("ForgetObjects")));f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",362);}
case 362:{f.Pc=f.Pop().Int==0?380:365;continue;}
case 365:{f.Push(f.Locals[1]);f.Pc=366;continue;}
case 366:{f.Push(f.Locals[1]);f.Pc=367;continue;}
case 367:{f.Push(f.Locals[0]);f.Pc=368;continue;}
case 368:{f.Push(JValue.R(rt.String("ForgetObjects")));f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",373);}
case 373:{f.Push(f.Locals[0]);f.Pc=374;continue;}
case 374:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedObjects","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",377);}
case 377:{return rt.Call(f,"forge/game/card/Card","removeRemembered","(Ljava/lang/Iterable;)V","invokevirtual",380);}
case 380:{f.Push(f.Locals[0]);f.Pc=381;continue;}
case 381:{f.Push(JValue.R(rt.String("ImprintCards")));f.Pc=383;continue;}
case 383:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",386);}
case 386:{f.Pc=f.Pop().Int==0?404:389;continue;}
case 389:{f.Push(f.Locals[1]);f.Pc=390;continue;}
case 390:{f.Push(f.Locals[1]);f.Pc=391;continue;}
case 391:{f.Push(f.Locals[0]);f.Pc=392;continue;}
case 392:{f.Push(JValue.R(rt.String("ImprintCards")));f.Pc=394;continue;}
case 394:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",397);}
case 397:{f.Push(f.Locals[0]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",401);}
case 401:{return rt.Call(f,"forge/game/card/Card","addImprintedCards","(Ljava/lang/Iterable;)V","invokevirtual",404);}
case 404:{f.Push(f.Locals[0]);f.Pc=405;continue;}
case 405:{f.Push(JValue.R(rt.String("ForgetImprinted")));f.Pc=407;continue;}
case 407:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",410);}
case 410:{f.Pc=f.Pop().Int==0?428:413;continue;}
case 413:{f.Push(f.Locals[1]);f.Pc=414;continue;}
case 414:{f.Push(f.Locals[1]);f.Pc=415;continue;}
case 415:{f.Push(f.Locals[0]);f.Pc=416;continue;}
case 416:{f.Push(JValue.R(rt.String("ForgetImprinted")));f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",421);}
case 421:{f.Push(f.Locals[0]);f.Pc=422;continue;}
case 422:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",425);}
case 425:{return rt.Call(f,"forge/game/card/Card","removeImprintedCards","(Ljava/lang/Iterable;)V","invokevirtual",428);}
case 428:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
