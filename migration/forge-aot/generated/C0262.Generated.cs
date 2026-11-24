// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C262{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/CounterEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3237,"forge/game/ability/effects/CounterEffect","<init>","()V",1,1,1,new JHandler[]{},M3237));
c.Add(new JMethod(3238,"forge/game/ability/effects/CounterEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V",1,2,2,new JHandler[]{},M3238));
c.Add(new JMethod(3239,"forge/game/ability/effects/CounterEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,7,3,new JHandler[]{},M3239));
c.Add(new JMethod(3240,"forge/game/ability/effects/CounterEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,9,6,new JHandler[]{},M3240));
c.Add(new JMethod(3241,"forge/game/ability/effects/CounterEffect","checkForConditionWouldDestroy","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;)Z",9,6,2,new JHandler[]{},M3241));
c.Add(new JMethod(3242,"forge/game/ability/effects/CounterEffect","checkSingleSAForConditionWouldDestroy","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;)Z",10,17,6,new JHandler[]{},M3242));
c.Add(new JMethod(3243,"forge/game/ability/effects/CounterEffect","removeFromStack","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbilityStackInstance;Ljava/util/Map;)Z",10,10,5,new JHandler[]{},M3243));
}

internal static JStep M3237(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3238(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?22:12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",16);}
case 16:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",22);}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3239(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Counter")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/ability/effects/CounterEffect","getTargetSpells","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",30);}
case 30:{f.Locals[5]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",39);}
case 39:{f.Pc=f.Pop().Int==0?63:42;continue;}
case 42:{f.Push(f.Locals[5]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[6]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[6]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",59);}
case 59:{f.Locals[3]=f.Pop();f.Pc=60;continue;}
case 60:{f.Pc=32;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String(" ")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",69);}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/ability/effects/CounterEffect","joinNamed","(Ljava/lang/Iterable;)Ljava/lang/String;","invokestatic",74);}
case 74:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",77);}
case 77:{f.StackOp("pop");f.Pc=78;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{f.Pc=f.Pop().Int==0?98:82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.String("DestroyPermanent")));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",88);}
case 88:{f.Pc=f.Pop().Int==0?98:91;continue;}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{f.Push(JValue.R(rt.String(" and destroy it")));f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",97);}
case 97:{f.StackOp("pop");f.Pc=98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("UnlessCost")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",104);}
case 104:{f.Pc=f.Pop().Int==0?123:107;continue;}
case 107:{f.Push(f.Locals[2]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("UnlessCost")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",114);}
case 114:{return rt.DynamicCall(f,"forge/game/ability/effects/CounterEffect:3239:114:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",119);}
case 119:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",122);}
case 122:{f.StackOp("pop");f.Pc=123;continue;}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String(".")));f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",129);}
case 129:{f.StackOp("pop");f.Pc=130;continue;}
case 130:{f.Push(f.Locals[2]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",134);}
case 134:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3240(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/ability/effects/CounterEffect","getTargetSpells","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",23);}
case 23:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",28);}
case 28:{f.Locals[5]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[5]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?326:40;continue;}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{f.Locals[6]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[6]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",57);}
case 57:{f.Locals[7]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("Optional")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?111:68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",72);}
case 72:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",75);}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(null));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",80);}
case 80:{f.Push(JValue.R(rt.String("lblWouldYouLikeProceedWithOptionalAbility")));f.Pc=82;continue;}
case 82:{f.Push(JValue.I(0));f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",89);}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",93);}
case 93:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",96);}
case 96:{return rt.DynamicCall(f,"forge/game/ability/effects/CounterEffect:3240:96:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",101);}
case 101:{f.Push(f.Locals[7]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(null));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int!=0?111:110;continue;}
case 110:{return JStep.ReturnVoid;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("RememberCounteredCMC")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",117);}
case 117:{f.Pc=f.Pop().Int==0?135:120;continue;}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",124);}
case 124:{f.Push(f.Locals[7]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/card/Card","getCMC","()I","invokevirtual",129);}
case 129:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",132);}
case 132:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",135);}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{f.Push(JValue.R(rt.String("RememberForCounter")));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",141);}
case 141:{f.Pc=f.Pop().Int==0?153:144;continue;}
case 144:{f.Push(f.Locals[1]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",148);}
case 148:{f.Push(f.Locals[7]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",153);}
case 153:{f.Push(f.Locals[6]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",158);}
case 158:{f.Pc=f.Pop().Int==0?173:161;continue;}
case 161:{f.Push(f.Locals[6]);f.Pc=163;continue;}
case 163:{f.Push(f.Locals[1]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCounterableBy","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",167);}
case 167:{f.Pc=f.Pop().Int!=0?173:170;continue;}
case 170:{f.Pc=30;continue;}
case 173:{f.Push(f.Locals[2]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",177);}
case 177:{f.Push(f.Locals[6]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/zone/MagicStack","getInstanceMatchingSpellAbilityID","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbilityStackInstance;","invokevirtual",182);}
case 182:{f.Locals[8]=f.Pop();f.Pc=184;continue;}
case 184:{f.Push(f.Locals[8]);f.Pc=186;continue;}
case 186:{f.Pc=f.Pop().Reference!=null?192:189;continue;}
case 189:{f.Pc=30;continue;}
case 192:{f.Push(f.Locals[1]);f.Pc=193;continue;}
case 193:{f.Push(JValue.R(rt.String("ConditionWouldDestroy")));f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",198);}
case 198:{f.Pc=f.Pop().Int==0?213:201;continue;}
case 201:{f.Push(f.Locals[1]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[6]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/ability/effects/CounterEffect","checkForConditionWouldDestroy","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;)Z","invokestatic",207);}
case 207:{f.Pc=f.Pop().Int!=0?213:210;continue;}
case 210:{f.Pc=30;continue;}
case 213:{f.Push(f.Locals[1]);f.Pc=214;continue;}
case 214:{f.Push(JValue.R(rt.String("RememberSplicedOntoCounteredSpell")));f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",219);}
case 219:{f.Pc=f.Pop().Int==0?242:222;continue;}
case 222:{f.Push(f.Locals[6]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSplicedCards","()Lforge/game/card/CardCollection;","invokevirtual",227);}
case 227:{f.Pc=f.Pop().Reference==null?242:230;continue;}
case 230:{f.Push(f.Locals[1]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",234);}
case 234:{f.Push(f.Locals[6]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSplicedCards","()Lforge/game/card/CardCollection;","invokevirtual",239);}
case 239:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",242);}
case 242:{f.Push(f.Locals[6]);f.Pc=244;continue;}
case 244:{f.Push(f.Locals[1]);f.Pc=245;continue;}
case 245:{f.Push(f.Locals[8]);f.Pc=247;continue;}
case 247:{f.Push(f.Locals[3]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/ability/effects/CounterEffect","removeFromStack","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbilityStackInstance;Ljava/util/Map;)Z","invokestatic",251);}
case 251:{f.Pc=f.Pop().Int!=0?257:254;continue;}
case 254:{f.Pc=30;continue;}
case 257:{f.Push(f.Locals[6]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",262);}
case 262:{f.Pc=f.Pop().Int==0?287:265;continue;}
case 265:{f.Push(f.Locals[1]);f.Pc=266;continue;}
case 266:{f.Push(JValue.R(rt.String("DestroyPermanent")));f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",271);}
case 271:{f.Pc=f.Pop().Int==0?287:274;continue;}
case 274:{f.Push(f.Locals[2]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",278);}
case 278:{f.Push(f.Locals[7]);f.Pc=280;continue;}
case 280:{f.Push(f.Locals[1]);f.Pc=281;continue;}
case 281:{f.Push(JValue.I(1));f.Pc=282;continue;}
case 282:{f.Push(f.Locals[3]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/GameAction","destroy","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Z","invokevirtual",286);}
case 286:{f.StackOp("pop");f.Pc=287;continue;}
case 287:{f.Push(f.Locals[1]);f.Pc=288;continue;}
case 288:{f.Push(JValue.R(rt.String("RememberCountered")));f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",293);}
case 293:{f.Pc=f.Pop().Int==0?305:296;continue;}
case 296:{f.Push(f.Locals[1]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",300);}
case 300:{f.Push(f.Locals[7]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",305);}
case 305:{f.Push(f.Locals[1]);f.Pc=306;continue;}
case 306:{f.Push(JValue.R(rt.String("RememberCounteredSA")));f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",311);}
case 311:{f.Pc=f.Pop().Int==0?323:314;continue;}
case 314:{f.Push(f.Locals[1]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",318);}
case 318:{f.Push(f.Locals[6]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",323);}
case 323:{f.Pc=30;continue;}
case 326:{f.Push(f.Locals[4]);f.Pc=328;continue;}
case 328:{f.Push(f.Locals[2]);f.Pc=329;continue;}
case 329:{f.Push(f.Locals[1]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",333);}
case 333:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3241(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Locals[3]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Reference==null?26:10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",17);}
case 17:{f.StackOp("pop");f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Pc=6;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",32);}
case 32:{f.Locals[4]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",41);}
case 41:{f.Pc=f.Pop().Int==0?70:44;continue;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",51);}
case 51:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=54;continue;}
case 54:{f.Locals[5]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/ability/effects/CounterEffect","checkSingleSAForConditionWouldDestroy","(Lforge/game/spellability/SpellAbility;Lforge/game/spellability/SpellAbility;)Z","invokestatic",62);}
case 62:{f.Pc=f.Pop().Int==0?67:65;continue;}
case 65:{f.Push(JValue.I(1));f.Pc=66;continue;}
case 66:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 67:{f.Pc=34;continue;}
case 70:{f.Push(JValue.I(0));f.Pc=71;continue;}
case 71:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3242(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",12);}
case 12:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Destroy","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Destroy","Lforge/game/ability/ApiType;"));f.Pc=15;continue;}
case 15:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?30:18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",22);}
case 22:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","DestroyAll","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","DestroyAll","Lforge/game/ability/ApiType;"));f.Pc=25;continue;}
case 25:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?30:28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("ConditionWouldDestroy")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",36);}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",44);}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[4]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",53);}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",57);}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",61);}
case 61:{f.Locals[5]=f.Pop();f.Pc=63;continue;}
case 63:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=66;continue;}
case 66:{f.StackOp("dup");f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",70);}
case 70:{f.Locals[6]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("ValidTgts")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int!=0?92:82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.String("Defined")));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int==0?105:92;continue;}
case 92:{f.Push(f.Locals[6]);f.Pc=94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/ability/effects/CounterEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",98);}
case 98:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",101);}
case 101:{f.StackOp("pop");f.Pc=102;continue;}
case 102:{f.Pc=142;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Int==0?142:115;continue;}
case 115:{f.Push(f.Locals[6]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[4]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{f.Push(JValue.R(rt.String("ValidCards")));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",126);}
case 126:{f.Push(f.Locals[1]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",130);}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",134);}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",138);}
case 138:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",141);}
case 141:{f.StackOp("pop");f.Pc=142;continue;}
case 142:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=145;continue;}
case 145:{f.StackOp("dup");f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",149);}
case 149:{f.Locals[7]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(f.Locals[5]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",156);}
case 156:{f.Locals[8]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(f.Locals[8]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",165);}
case 165:{f.Pc=f.Pop().Int==0?201:168;continue;}
case 168:{f.Push(f.Locals[8]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",175);}
case 175:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=178;continue;}
case 178:{f.Locals[9]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[6]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[9]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",187);}
case 187:{f.Pc=f.Pop().Int==0?198:190;continue;}
case 190:{f.Push(f.Locals[7]);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[9]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",197);}
case 197:{f.StackOp("pop");f.Pc=198;continue;}
case 198:{f.Pc=158;continue;}
case 201:{f.Push(JValue.I(0));f.Pc=202;continue;}
case 202:{f.Locals[8]=f.Pop();f.Pc=204;continue;}
case 204:{f.Push(f.Locals[7]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",209);}
case 209:{f.Pc=f.Pop().Int==0?434:212;continue;}
case 212:{f.Push(f.Locals[1]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",216);}
case 216:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",219);}
case 219:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Pump","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Pump","Lforge/game/ability/ApiType;"));f.Pc=222;continue;}
case 222:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?434:225;continue;}
case 225:{f.Push(f.Locals[1]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",229);}
case 229:{f.Push(JValue.R(rt.String("TargetMax")));f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",235);}
case 235:{f.Pc=f.Pop().Int==0?434:238;continue;}
case 238:{f.Push(f.Locals[1]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",242);}
case 242:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",245);}
case 245:{f.Pc=f.Pop().Reference==null?434:248;continue;}
case 248:{f.Push(f.Locals[1]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",252);}
case 252:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",255);}
case 255:{return rt.Call(f,"forge/game/spellability/AbilitySub","getApi","()Lforge/game/ability/ApiType;","invokevirtual",258);}
case 258:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ChooseCard","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ChooseCard","Lforge/game/ability/ApiType;"));f.Pc=261;continue;}
case 261:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?434:264;continue;}
case 264:{f.Push(f.Locals[1]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",268);}
case 268:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",271);}
case 271:{f.Push(JValue.R(rt.String("AtRandom")));f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/spellability/AbilitySub","hasParam","(Ljava/lang/String;)Z","invokevirtual",277);}
case 277:{f.Pc=f.Pop().Int==0?434:280;continue;}
case 280:{f.Push(JValue.R(rt.String("ChosenCard")));f.Pc=283;continue;}
case 283:{f.Push(f.Locals[1]);f.Pc=284;continue;}
case 284:{f.Push(JValue.R(rt.String("Defined")));f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",290);}
case 290:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",293);}
case 293:{f.Pc=f.Pop().Int==0?434:296;continue;}
case 296:{f.Push(JValue.I(1));f.Pc=297;continue;}
case 297:{f.Locals[8]=f.Pop();f.Pc=299;continue;}
case 299:{f.Push(JValue.I(1));f.Pc=300;continue;}
case 300:{f.Locals[9]=f.Pop();f.Pc=302;continue;}
case 302:{f.Push(f.Locals[6]);f.Pc=304;continue;}
case 304:{f.Push(f.Locals[1]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",308);}
case 308:{return rt.Call(f,"forge/game/ability/effects/CounterEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",311);}
case 311:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",314);}
case 314:{f.StackOp("pop");f.Pc=315;continue;}
case 315:{f.Push(f.Locals[5]);f.Pc=317;continue;}
case 317:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",320);}
case 320:{f.Locals[10]=f.Pop();f.Pc=322;continue;}
case 322:{f.Push(f.Locals[10]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",329);}
case 329:{f.Pc=f.Pop().Int==0?365:332;continue;}
case 332:{f.Push(f.Locals[10]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",339);}
case 339:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=342;continue;}
case 342:{f.Locals[11]=f.Pop();f.Pc=344;continue;}
case 344:{f.Push(f.Locals[6]);f.Pc=346;continue;}
case 346:{f.Push(f.Locals[11]);f.Pc=348;continue;}
case 348:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",351);}
case 351:{f.Pc=f.Pop().Int==0?362:354;continue;}
case 354:{f.Push(f.Locals[7]);f.Pc=356;continue;}
case 356:{f.Push(f.Locals[11]);f.Pc=358;continue;}
case 358:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",361);}
case 361:{f.StackOp("pop");f.Pc=362;continue;}
case 362:{f.Pc=322;continue;}
case 365:{f.Push(f.Locals[1]);f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",369);}
case 369:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",372);}
case 372:{return rt.Call(f,"forge/game/spellability/TargetChoices","getTargetCards","()Lforge/game/card/CardCollectionView;","invokevirtual",375);}
case 375:{f.Locals[10]=f.Pop();f.Pc=377;continue;}
case 377:{f.Push(f.Locals[10]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",384);}
case 384:{f.Locals[11]=f.Pop();f.Pc=386;continue;}
case 386:{f.Push(f.Locals[11]);f.Pc=388;continue;}
case 388:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",393);}
case 393:{f.Pc=f.Pop().Int==0?427:396;continue;}
case 396:{f.Push(f.Locals[11]);f.Pc=398;continue;}
case 398:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",403);}
case 403:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=406;continue;}
case 406:{f.Locals[12]=f.Pop();f.Pc=408;continue;}
case 408:{f.Push(f.Locals[7]);f.Pc=410;continue;}
case 410:{f.Push(f.Locals[12]);f.Pc=412;continue;}
case 412:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",415);}
case 415:{f.Pc=f.Pop().Int!=0?424:418;continue;}
case 418:{f.Push(JValue.I(0));f.Pc=419;continue;}
case 419:{f.Locals[9]=f.Pop();f.Pc=421;continue;}
case 421:{f.Pc=427;continue;}
case 424:{f.Pc=386;continue;}
case 427:{f.Push(f.Locals[9]);f.Pc=429;continue;}
case 429:{f.Pc=f.Pop().Int!=0?434:432;continue;}
case 432:{f.Push(JValue.I(0));f.Pc=433;continue;}
case 433:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 434:{f.Push(f.Locals[7]);f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",439);}
case 439:{f.Pc=f.Pop().Int==0?444:442;continue;}
case 442:{f.Push(JValue.I(0));f.Pc=443;continue;}
case 443:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 444:{f.Push(f.Locals[1]);f.Pc=445;continue;}
case 445:{f.Push(JValue.R(rt.String("Sacrifice")));f.Pc=448;continue;}
case 448:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",451);}
case 451:{f.Pc=f.Pop().Int==0?456:454;continue;}
case 454:{f.Push(JValue.I(0));f.Pc=455;continue;}
case 455:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 456:{f.Push(JValue.I(0));f.Pc=457;continue;}
case 457:{f.Locals[9]=f.Pop();f.Pc=459;continue;}
case 459:{f.Push(f.Locals[1]);f.Pc=460;continue;}
case 460:{f.Push(JValue.R(rt.String("NoRegen")));f.Pc=463;continue;}
case 463:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",466);}
case 466:{f.Locals[10]=f.Pop();f.Pc=468;continue;}
case 468:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",471);}
case 471:{f.Locals[11]=f.Pop();f.Pc=473;continue;}
case 473:{f.Push(f.Locals[11]);f.Pc=475;continue;}
case 475:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","LastStateBattlefield","Lforge/game/ability/AbilityKey;"));f.Pc=478;continue;}
case 478:{f.Push(f.Locals[2]);f.Pc=479;continue;}
case 479:{return rt.Call(f,"forge/game/Game","copyLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",482);}
case 482:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",487);}
case 487:{f.StackOp("pop");f.Pc=488;continue;}
case 488:{f.Push(JValue.I(1));f.Pc=489;continue;}
case 489:{f.Locals[12]=f.Pop();f.Pc=491;continue;}
case 491:{f.Push(f.Locals[7]);f.Pc=493;continue;}
case 493:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",496);}
case 496:{f.Locals[13]=f.Pop();f.Pc=498;continue;}
case 498:{f.Push(f.Locals[13]);f.Pc=500;continue;}
case 500:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",505);}
case 505:{f.Pc=f.Pop().Int==0?619:508;continue;}
case 508:{f.Push(f.Locals[13]);f.Pc=510;continue;}
case 510:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",515);}
case 515:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=518;continue;}
case 518:{f.Locals[14]=f.Pop();f.Pc=520;continue;}
case 520:{f.Push(f.Locals[1]);f.Pc=521;continue;}
case 521:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",524);}
case 524:{f.Pc=f.Pop().Int==0?542:527;continue;}
case 527:{f.Push(f.Locals[14]);f.Pc=529;continue;}
case 529:{f.Push(f.Locals[1]);f.Pc=530;continue;}
case 530:{return rt.Call(f,"forge/game/card/Card","canBeTargetedBy","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",533);}
case 533:{f.Pc=f.Pop().Int!=0?542:536;continue;}
case 536:{f.Push(JValue.I(0));f.Pc=537;continue;}
case 537:{f.Locals[12]=f.Pop();f.Pc=539;continue;}
case 539:{f.Pc=498;continue;}
case 542:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCopyService"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCopyService")));f.Pc=545;continue;}
case 545:{f.StackOp("dup");f.Pc=546;continue;}
case 546:{f.Push(f.Locals[14]);f.Pc=548;continue;}
case 548:{return rt.Call(f,"forge/game/card/CardCopyService","<init>","(Lforge/game/card/Card;)V","invokespecial",551);}
case 551:{f.Push(JValue.I(1));f.Pc=552;continue;}
case 552:{return rt.Call(f,"forge/game/card/CardCopyService","copyCard","(Z)Lforge/game/card/Card;","invokevirtual",555);}
case 555:{f.Locals[15]=f.Pop();f.Pc=557;continue;}
case 557:{f.Push(f.Locals[2]);f.Pc=558;continue;}
case 558:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",561);}
case 561:{f.Push(JValue.I(1));f.Pc=562;continue;}
case 562:{return rt.Call(f,"forge/game/trigger/TriggerHandler","setSuppressAllTriggers","(Z)V","invokevirtual",565);}
case 565:{f.Push(f.Locals[2]);f.Pc=566;continue;}
case 566:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",569);}
case 569:{f.Push(f.Locals[15]);f.Pc=571;continue;}
case 571:{f.Push(f.Locals[1]);f.Pc=572;continue;}
case 572:{f.Push(f.Locals[10]);f.Pc=574;continue;}
case 574:{f.Pc=f.Pop().Int!=0?581:577;continue;}
case 577:{f.Push(JValue.I(1));f.Pc=578;continue;}
case 578:{f.Pc=582;continue;}
case 581:{f.Push(JValue.I(0));f.Pc=582;continue;}
case 582:{f.Push(f.Locals[11]);f.Pc=584;continue;}
case 584:{return rt.Call(f,"forge/game/GameAction","destroy","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Z","invokevirtual",587);}
case 587:{f.Locals[16]=f.Pop();f.Pc=589;continue;}
case 589:{f.Push(f.Locals[2]);f.Pc=590;continue;}
case 590:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",593);}
case 593:{f.Push(JValue.I(0));f.Pc=594;continue;}
case 594:{return rt.Call(f,"forge/game/trigger/TriggerHandler","setSuppressAllTriggers","(Z)V","invokevirtual",597);}
case 597:{f.Push(f.Locals[16]);f.Pc=599;continue;}
case 599:{f.Pc=f.Pop().Int==0?613:602;continue;}
case 602:{f.Push(JValue.I(1));f.Pc=603;continue;}
case 603:{f.Locals[9]=f.Pop();f.Pc=605;continue;}
case 605:{f.Push(f.Locals[8]);f.Pc=607;continue;}
case 607:{f.Pc=f.Pop().Int!=0?616:610;continue;}
case 610:{f.Pc=619;continue;}
case 613:{f.Push(JValue.I(0));f.Pc=614;continue;}
case 614:{f.Locals[12]=f.Pop();f.Pc=616;continue;}
case 616:{f.Pc=498;continue;}
case 619:{f.Push(f.Locals[8]);f.Pc=621;continue;}
case 621:{f.Pc=f.Pop().Int==0?629:624;continue;}
case 624:{f.Push(f.Locals[12]);f.Pc=626;continue;}
case 626:{f.Pc=631;continue;}
case 629:{f.Push(f.Locals[9]);f.Pc=631;continue;}
case 631:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3243(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[4]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(JValue.R(null));f.Pc=10;continue;}
case 10:{f.Locals[5]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",16);}
case 16:{f.Locals[6]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[6]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",23);}
case 23:{f.Locals[7]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[7]);f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",36);}
case 36:{f.StackOp("pop");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[7]);f.Pc=39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",54);}
case 54:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","Counter","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","Counter","Lforge/game/replacement/ReplacementType;"));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[7]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",62);}
case 62:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=65;continue;}
case 65:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?70:68;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",75);}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/zone/MagicStack","remove","(Lforge/game/spellability/SpellAbilityStackInstance;)V","invokevirtual",79);}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/Card","unanimateBestow","()V","invokevirtual",84);}
case 84:{f.Push(f.Locals[3]);f.Pc=85;continue;}
case 85:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","StackSa","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","StackSa","Lforge/game/ability/AbilityKey;"));f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",94);}
case 94:{f.StackOp("pop");f.Pc=95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("Destination")));f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("Graveyard")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",105);}
case 105:{f.Locals[8]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("DestinationChoice")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?163:117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("DestinationChoice")));f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",124);}
case 124:{f.Push(JValue.R(rt.String(",")));f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",130);}
case 130:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",133);}
case 133:{f.Locals[9]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",139);}
case 139:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",142);}
case 142:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",145);}
case 145:{f.Push(JValue.R(rt.String("lblRemoveDestination")));f.Pc=148;continue;}
case 148:{f.Push(JValue.I(0));f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",155);}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[9]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/player/PlayerController","chooseSomeType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Ljava/util/Collection;)Ljava/lang/String;","invokevirtual",161);}
case 161:{f.Locals[8]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(f.Locals[0]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",167);}
case 167:{f.Pc=f.Pop().Int==0?173:170;continue;}
case 170:{f.Pc=408;continue;}
case 173:{f.Push(f.Locals[8]);f.Pc=175;continue;}
case 175:{f.Push(JValue.R(rt.String("Graveyard")));f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",181);}
case 181:{f.Pc=f.Pop().Int==0?201:184;continue;}
case 184:{f.Push(f.Locals[4]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",189);}
case 189:{f.Push(f.Locals[6]);f.Pc=191;continue;}
case 191:{f.Push(f.Locals[1]);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[3]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/GameAction","moveToGraveyard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",196);}
case 196:{f.Locals[5]=f.Pop();f.Pc=198;continue;}
case 198:{f.Pc=408;continue;}
case 201:{f.Push(f.Locals[8]);f.Pc=203;continue;}
case 203:{f.Push(JValue.R(rt.String("Exile")));f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",209);}
case 209:{f.Pc=f.Pop().Int==0?241:212;continue;}
case 212:{f.Push(f.Locals[6]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[1]);f.Pc=215;continue;}
case 215:{f.Push(JValue.I(1));f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/card/Card","canExiledBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",219);}
case 219:{f.Pc=f.Pop().Int!=0?224:222;continue;}
case 222:{f.Push(JValue.I(0));f.Pc=223;continue;}
case 223:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 224:{f.Push(f.Locals[4]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",229);}
case 229:{f.Push(f.Locals[6]);f.Pc=231;continue;}
case 231:{f.Push(f.Locals[1]);f.Pc=232;continue;}
case 232:{f.Push(f.Locals[3]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/GameAction","exile","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",236);}
case 236:{f.Locals[5]=f.Pop();f.Pc=238;continue;}
case 238:{f.Pc=408;continue;}
case 241:{f.Push(f.Locals[8]);f.Pc=243;continue;}
case 243:{f.Push(JValue.R(rt.String("Hand")));f.Pc=246;continue;}
case 246:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",249);}
case 249:{f.Pc=f.Pop().Int==0?269:252;continue;}
case 252:{f.Push(f.Locals[4]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",257);}
case 257:{f.Push(f.Locals[6]);f.Pc=259;continue;}
case 259:{f.Push(f.Locals[1]);f.Pc=260;continue;}
case 260:{f.Push(f.Locals[3]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/GameAction","moveToHand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",264);}
case 264:{f.Locals[5]=f.Pop();f.Pc=266;continue;}
case 266:{f.Pc=408;continue;}
case 269:{f.Push(f.Locals[8]);f.Pc=271;continue;}
case 271:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=274;continue;}
case 274:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",277);}
case 277:{f.Pc=f.Pop().Int==0?332:280;continue;}
case 280:{f.Push(f.Locals[6]);f.Pc=282;continue;}
case 282:{f.Push(JValue.R(null));f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/card/Card","setCastSA","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",286);}
case 286:{f.Push(f.Locals[6]);f.Pc=288;continue;}
case 288:{f.Push(JValue.R(null));f.Pc=289;continue;}
case 289:{return rt.Call(f,"forge/game/card/Card","setCastFrom","(Lforge/game/zone/Zone;)V","invokevirtual",292);}
case 292:{f.Push(f.Locals[6]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/game/card/Card","forceTurnFaceUp","()V","invokevirtual",297);}
case 297:{f.Push(f.Locals[6]);f.Pc=299;continue;}
case 299:{f.Push(f.Locals[1]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",303);}
case 303:{f.Push(f.Locals[4]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",308);}
case 308:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",311);}
case 311:{f.Push(f.Locals[4]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",316);}
case 316:{f.Push(f.Locals[6]);f.Pc=318;continue;}
case 318:{f.Push(f.Locals[1]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",322);}
case 322:{f.Push(f.Locals[1]);f.Pc=323;continue;}
case 323:{f.Push(f.Locals[3]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/GameAction","moveToPlay","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",327);}
case 327:{f.Locals[5]=f.Pop();f.Pc=329;continue;}
case 329:{f.Pc=408;continue;}
case 332:{f.Push(f.Locals[8]);f.Pc=334;continue;}
case 334:{f.Push(JValue.R(rt.String("TopOfLibrary")));f.Pc=337;continue;}
case 337:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",340);}
case 340:{f.Pc=f.Pop().Int==0?360:343;continue;}
case 343:{f.Push(f.Locals[4]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",348);}
case 348:{f.Push(f.Locals[6]);f.Pc=350;continue;}
case 350:{f.Push(f.Locals[1]);f.Pc=351;continue;}
case 351:{f.Push(f.Locals[3]);f.Pc=352;continue;}
case 352:{return rt.Call(f,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",355);}
case 355:{f.Locals[5]=f.Pop();f.Pc=357;continue;}
case 357:{f.Pc=408;continue;}
case 360:{f.Push(f.Locals[8]);f.Pc=362;continue;}
case 362:{f.Push(JValue.R(rt.String("BottomOfLibrary")));f.Pc=365;continue;}
case 365:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",368);}
case 368:{f.Pc=f.Pop().Int==0?388:371;continue;}
case 371:{f.Push(f.Locals[4]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",376);}
case 376:{f.Push(f.Locals[6]);f.Pc=378;continue;}
case 378:{f.Push(f.Locals[1]);f.Pc=379;continue;}
case 379:{f.Push(f.Locals[3]);f.Pc=380;continue;}
case 380:{return rt.Call(f,"forge/game/GameAction","moveToBottomOfLibrary","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",383);}
case 383:{f.Locals[5]=f.Pop();f.Pc=385;continue;}
case 385:{f.Pc=408;continue;}
case 388:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=391;continue;}
case 391:{f.StackOp("dup");f.Pc=392;continue;}
case 392:{f.Push(f.Locals[1]);f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",396);}
case 396:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",399);}
case 399:{return rt.DynamicCall(f,"forge/game/ability/effects/CounterEffect:3243:399:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",404);}
case 404:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",407);}
case 407:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 408:{f.Push(f.Locals[6]);f.Pc=410;continue;}
case 410:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",413);}
case 413:{f.Locals[9]=f.Pop();f.Pc=415;continue;}
case 415:{f.Push(f.Locals[9]);f.Pc=417;continue;}
case 417:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=420;continue;}
case 420:{f.Push(f.Locals[1]);f.Pc=421;continue;}
case 421:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",426);}
case 426:{f.StackOp("pop");f.Pc=427;continue;}
case 427:{f.Push(f.Locals[9]);f.Pc=429;continue;}
case 429:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"));f.Pc=432;continue;}
case 432:{f.Push(f.Locals[0]);f.Pc=433;continue;}
case 433:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",438);}
case 438:{f.StackOp("pop");f.Pc=439;continue;}
case 439:{f.Push(f.Locals[4]);f.Pc=441;continue;}
case 441:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",444);}
case 444:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Countered","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Countered","Lforge/game/trigger/TriggerType;"));f.Pc=447;continue;}
case 447:{f.Push(f.Locals[9]);f.Pc=449;continue;}
case 449:{f.Push(JValue.I(0));f.Pc=450;continue;}
case 450:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",453);}
case 453:{f.Push(f.Locals[0]);f.Pc=454;continue;}
case 454:{return rt.Call(f,"forge/game/spellability/SpellAbility","isAbility","()Z","invokevirtual",457);}
case 457:{f.Pc=f.Pop().Int!=0?482:460;continue;}
case 460:{f.Push(f.Locals[4]);f.Pc=462;continue;}
case 462:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=465;continue;}
case 465:{f.StackOp("dup");f.Pc=466;continue;}
case 466:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","ZONE_CHANGE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","ZONE_CHANGE","Lforge/game/GameLogEntryType;"));f.Pc=469;continue;}
case 469:{f.Push(f.Locals[8]);f.Pc=471;continue;}
case 471:{return rt.DynamicCall(f,"forge/game/ability/effects/CounterEffect:3243:471:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",476);}
case 476:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",479);}
case 479:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",482);}
case 482:{f.Push(JValue.I(1));f.Pc=483;continue;}
case 483:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
