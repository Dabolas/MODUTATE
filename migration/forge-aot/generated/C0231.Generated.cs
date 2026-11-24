// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C231{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/CharmEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3125,"forge/game/ability/effects/CharmEffect","<init>","()V",1,1,1,new JHandler[]{},M3125));
c.Add(new JMethod(3126,"forge/game/ability/effects/CharmEffect","makePossibleOptions","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",9,7,4,new JHandler[]{},M3126));
c.Add(new JMethod(3127,"forge/game/ability/effects/CharmEffect","makeFormatedDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",9,1,2,new JHandler[]{},M3127));
c.Add(new JMethod(3128,"forge/game/ability/effects/CharmEffect","makeFormatedDescription","(Lforge/game/spellability/SpellAbility;Z)Ljava/lang/String;",9,20,5,new JHandler[]{},M3128));
c.Add(new JMethod(3129,"forge/game/ability/effects/CharmEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,2,0,new JHandler[]{},M3129));
c.Add(new JMethod(3130,"forge/game/ability/effects/CharmEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,1,new JHandler[]{},M3130));
c.Add(new JMethod(3131,"forge/game/ability/effects/CharmEffect","faceDilemma","(Lforge/game/player/Player;Z)V",10,3,4,new JHandler[]{},M3131));
c.Add(new JMethod(3132,"forge/game/ability/effects/CharmEffect","makeChoices","(Lforge/game/spellability/SpellAbility;)Z",9,11,9,new JHandler[]{},M3132));
c.Add(new JMethod(3133,"forge/game/ability/effects/CharmEffect","chainAbilities","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)V",9,6,3,new JHandler[]{},M3133));
c.Add(new JMethod(3134,"forge/game/ability/effects/CharmEffect","lambda$chainAbilities$0","(Lforge/game/spellability/AbilitySub;)I",4106,1,2,new JHandler[]{},M3134));
}

internal static JStep M3125(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3126(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("ChoiceRestriction")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?28:16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("ChoiceRestriction")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/card/Card","getChosenModes","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/util/List;","invokevirtual",27);}
case 27:{f.Locals[2]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("Choices")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbilityList","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",34);}
case 34:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",37);}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Reference==null?149:45;continue;}
case 45:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",48);}
case 48:{f.Locals[4]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",56);}
case 56:{f.Locals[5]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int==0?140:68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",75);}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{f.Locals[6]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[6]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/spellability/AbilitySub","usesTargeting","()Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int==0?109:88;continue;}
case 88:{f.Push(f.Locals[6]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/spellability/AbilitySub","getMinTargets","()I","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int<=0?109:96;continue;}
case 96:{f.Push(f.Locals[6]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/spellability/AbilitySub","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",101);}
case 101:{f.Push(f.Locals[6]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getNumCandidates","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?127:109;continue;}
case 109:{f.Push(f.Locals[2]);f.Pc=110;continue;}
case 110:{f.Pc=f.Pop().Reference==null?137:113;continue;}
case 113:{f.Push(f.Locals[2]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[6]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/spellability/AbilitySub","getDescription","()Ljava/lang/String;","invokevirtual",119);}
case 119:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",124);}
case 124:{f.Pc=f.Pop().Int==0?137:127;continue;}
case 127:{f.Push(f.Locals[4]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[6]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",136);}
case 136:{f.StackOp("pop");f.Pc=137;continue;}
case 137:{f.Pc=58;continue;}
case 140:{f.Push(f.Locals[3]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[4]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/List","removeAll","(Ljava/util/Collection;)Z","invokeinterface",148);}
case 148:{f.StackOp("pop");f.Pc=149;continue;}
case 149:{f.Push(JValue.I(1));f.Pc=150;continue;}
case 150:{f.Locals[4]=f.Pop();f.Pc=152;continue;}
case 152:{f.Push(f.Locals[3]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",158);}
case 158:{f.Locals[5]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[5]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",167);}
case 167:{f.Pc=f.Pop().Int==0?200:170;continue;}
case 170:{f.Push(f.Locals[5]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",177);}
case 177:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=180;continue;}
case 180:{f.Locals[6]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(f.Locals[6]);f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("CharmOrder")));f.Pc=186;continue;}
case 186:{f.Push(f.Locals[4]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",191);}
case 191:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",194);}
case 194:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=197;continue;}
case 197:{f.Pc=160;continue;}
case 200:{f.Push(f.Locals[3]);f.Pc=201;continue;}
case 201:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3127(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/ability/effects/CharmEffect","makeFormatedDescription","(Lforge/game/spellability/SpellAbility;Z)Ljava/lang/String;","invokestatic",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3128(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/ability/effects/CharmEffect","makePossibleOptions","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("CharmNum")));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("1")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("X")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",27);}
case 27:{f.Locals[5]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("CanRepeatModes")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",35);}
case 35:{f.Locals[6]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{f.Locals[7]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("AdditionalDescription")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",46);}
case 46:{f.Locals[8]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("Optional")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",54);}
case 54:{f.Locals[9]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Reference!=null?88:63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",68);}
case 68:{f.Pc=f.Pop().Int!=0?88:71;continue;}
case 71:{f.Push(f.Locals[8]);f.Pc=73;continue;}
case 73:{f.Pc=f.Pop().Int==0?88:76;continue;}
case 76:{f.Push(f.Locals[9]);f.Pc=78;continue;}
case 78:{f.Pc=f.Pop().Int!=0?88:81;continue;}
case 81:{f.Push(JValue.I(2147483647));f.Pc=83;continue;}
case 83:{f.Locals[7]=f.Pop();f.Pc=85;continue;}
case 85:{f.Pc=135;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Reference!=null?103:95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",100);}
case 100:{return rt.Call(f,"forge/game/spellability/SpellAbility","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",103);}
case 103:{f.Push(f.Locals[5]);f.Pc=105;continue;}
case 105:{f.Pc=f.Pop().Int!=0?135:108;continue;}
case 108:{f.Push(f.Locals[2]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[4]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",115);}
case 115:{f.Locals[7]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[6]);f.Pc=119;continue;}
case 119:{f.Pc=f.Pop().Int!=0?135:122;continue;}
case 122:{f.Push(f.Locals[7]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[3]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",130);}
case 130:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",133);}
case 133:{f.Locals[7]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{f.Push(JValue.R(rt.String("MinCharmNum")));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",141);}
case 141:{f.Pc=f.Pop().Int==0?158:144;continue;}
case 144:{f.Push(f.Locals[2]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[0]);f.Pc=146;continue;}
case 146:{f.Push(JValue.R(rt.String("MinCharmNum")));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",151);}
case 151:{f.Push(f.Locals[0]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",155);}
case 155:{f.Pc=160;continue;}
case 158:{f.Push(f.Locals[7]);f.Pc=160;continue;}
case 160:{f.Locals[10]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[0]);f.Pc=163;continue;}
case 163:{f.Push(JValue.R(rt.String("Random")));f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",168);}
case 168:{f.Locals[11]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.String("ActivationLimit")));f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",176);}
case 176:{f.Locals[12]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[0]);f.Pc=179;continue;}
case 179:{f.Push(JValue.R(rt.String("GameActivationLimit")));f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",184);}
case 184:{f.Locals[13]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.String("Opponent")));f.Pc=188;continue;}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",194);}
case 194:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",197);}
case 197:{f.Locals[14]=f.Pop();f.Pc=199;continue;}
case 199:{f.Push(f.Locals[2]);f.Pc=200;continue;}
case 200:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","SPREE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","SPREE","Lforge/game/keyword/Keyword;"));f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",206);}
case 206:{f.Locals[15]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[2]);f.Pc=209;continue;}
case 209:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","TIERED","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","TIERED","Lforge/game/keyword/Keyword;"));f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",215);}
case 215:{f.Locals[16]=f.Pop();f.Pc=217;continue;}
case 217:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=220;continue;}
case 220:{f.StackOp("dup");f.Pc=221;continue;}
case 221:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",224);}
case 224:{f.Locals[17]=f.Pop();f.Pc=226;continue;}
case 226:{f.Push(f.Locals[17]);f.Pc=228;continue;}
case 228:{f.Push(f.Locals[0]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCostDescription","()Ljava/lang/String;","invokevirtual",232);}
case 232:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",235);}
case 235:{f.StackOp("pop");f.Pc=236;continue;}
case 236:{f.Push(f.Locals[15]);f.Pc=238;continue;}
case 238:{f.Pc=f.Pop().Int!=0?435:241;continue;}
case 241:{f.Push(f.Locals[16]);f.Pc=243;continue;}
case 243:{f.Pc=f.Pop().Int!=0?435:246;continue;}
case 246:{f.Push(f.Locals[17]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[14]);f.Pc=250;continue;}
case 250:{f.Pc=f.Pop().Int==0?258:253;continue;}
case 253:{f.Push(JValue.R(rt.String("An opponent chooses ")));f.Pc=255;continue;}
case 255:{f.Pc=260;continue;}
case 258:{f.Push(JValue.R(rt.String("Choose ")));f.Pc=260;continue;}
case 260:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",263);}
case 263:{f.StackOp("pop");f.Pc=264;continue;}
case 264:{f.Push(f.Locals[5]);f.Pc=266;continue;}
case 266:{f.Pc=f.Pop().Int==0?304:269;continue;}
case 269:{f.Push(f.Locals[17]);f.Pc=271;continue;}
case 271:{f.Push(f.Locals[0]);f.Pc=272;continue;}
case 272:{f.Push(JValue.R(rt.String("MinCharmNum")));f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",277);}
case 277:{f.Pc=f.Pop().Int==0?290:280;continue;}
case 280:{f.Push(f.Locals[10]);f.Pc=282;continue;}
case 282:{f.Pc=f.Pop().Int!=0?290:285;continue;}
case 285:{f.Push(JValue.R(rt.String("up to ")));f.Pc=287;continue;}
case 287:{f.Pc=292;continue;}
case 290:{f.Push(JValue.R(rt.String("")));f.Pc=292;continue;}
case 292:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",295);}
case 295:{f.Push(JValue.R(rt.String("X")));f.Pc=297;continue;}
case 297:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",300);}
case 300:{f.StackOp("pop");f.Pc=301;continue;}
case 301:{f.Pc=435;continue;}
case 304:{f.Push(f.Locals[7]);f.Pc=306;continue;}
case 306:{f.Push(f.Locals[10]);f.Pc=308;continue;}
case 308:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?318:311;continue;}
case 311:{f.Push(f.Locals[7]);f.Pc=313;continue;}
case 313:{f.Push(JValue.I(2147483647));f.Pc=315;continue;}
case 315:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?342:318;continue;}
case 318:{f.Push(f.Locals[17]);f.Pc=320;continue;}
case 320:{f.Push(f.Locals[7]);f.Pc=322;continue;}
case 322:{f.Pc=f.Pop().Int!=0?330:325;continue;}
case 325:{f.Push(JValue.R(rt.String("up to that many")));f.Pc=327;continue;}
case 327:{f.Pc=335;continue;}
case 330:{f.Push(f.Locals[10]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",335);}
case 335:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",338);}
case 338:{f.StackOp("pop");f.Pc=339;continue;}
case 339:{f.Pc=435;continue;}
case 342:{f.Push(f.Locals[10]);f.Pc=344;continue;}
case 344:{f.Pc=f.Pop().Int!=0?375:347;continue;}
case 347:{f.Push(f.Locals[7]);f.Pc=349;continue;}
case 349:{f.Push(f.Locals[0]);f.Pc=350;continue;}
case 350:{f.Push(JValue.R(rt.String("Choices")));f.Pc=352;continue;}
case 352:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",355);}
case 355:{f.Push(JValue.R(rt.String(",")));f.Pc=357;continue;}
case 357:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",360);}
case 360:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=361;continue;}
case 361:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?375:364;continue;}
case 364:{f.Push(f.Locals[17]);f.Pc=366;continue;}
case 366:{f.Push(JValue.R(rt.String("any number ")));f.Pc=368;continue;}
case 368:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",371);}
case 371:{f.StackOp("pop");f.Pc=372;continue;}
case 372:{f.Pc=435;continue;}
case 375:{f.Push(f.Locals[10]);f.Pc=377;continue;}
case 377:{f.Pc=f.Pop().Int!=0?399:380;continue;}
case 380:{f.Push(f.Locals[17]);f.Pc=382;continue;}
case 382:{f.Push(JValue.R(rt.String("up to ")));f.Pc=384;continue;}
case 384:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",387);}
case 387:{f.Push(f.Locals[7]);f.Pc=389;continue;}
case 389:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",392);}
case 392:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",395);}
case 395:{f.StackOp("pop");f.Pc=396;continue;}
case 396:{f.Pc=435;continue;}
case 399:{f.Push(f.Locals[17]);f.Pc=401;continue;}
case 401:{f.Push(f.Locals[10]);f.Pc=403;continue;}
case 403:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",406);}
case 406:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",409);}
case 409:{f.Push(JValue.R(rt.String(" or ")));f.Pc=411;continue;}
case 411:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",414);}
case 414:{f.Push(f.Locals[3]);f.Pc=415;continue;}
case 415:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",420);}
case 420:{f.Push(JValue.I(2));f.Pc=421;continue;}
case 421:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?429:424;continue;}
case 424:{f.Push(JValue.R(rt.String("both")));f.Pc=426;continue;}
case 426:{f.Pc=431;continue;}
case 429:{f.Push(JValue.R(rt.String("more")));f.Pc=431;continue;}
case 431:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",434);}
case 434:{f.StackOp("pop");f.Pc=435;continue;}
case 435:{f.Push(f.Locals[0]);f.Pc=436;continue;}
case 436:{f.Push(JValue.R(rt.String("Pawprint")));f.Pc=438;continue;}
case 438:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",441);}
case 441:{f.Pc=f.Pop().Int==0?452:444;continue;}
case 444:{f.Push(f.Locals[17]);f.Pc=446;continue;}
case 446:{f.Push(JValue.R(rt.String("{P} worth of modes")));f.Pc=448;continue;}
case 448:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",451);}
case 451:{f.StackOp("pop");f.Pc=452;continue;}
case 452:{f.Push(f.Locals[0]);f.Pc=453;continue;}
case 453:{f.Push(JValue.R(rt.String("ChoiceRestriction")));f.Pc=455;continue;}
case 455:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",458);}
case 458:{f.Pc=f.Pop().Int==0?529:461;continue;}
case 461:{f.Push(f.Locals[0]);f.Pc=462;continue;}
case 462:{f.Push(JValue.R(rt.String("ChoiceRestriction")));f.Pc=464;continue;}
case 464:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",467);}
case 467:{f.Locals[18]=f.Pop();f.Pc=469;continue;}
case 469:{f.Push(f.Locals[18]);f.Pc=471;continue;}
case 471:{f.Push(JValue.R(rt.String("ThisGame")));f.Pc=473;continue;}
case 473:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",476);}
case 476:{f.Pc=f.Pop().Int==0?490:479;continue;}
case 479:{f.Push(f.Locals[17]);f.Pc=481;continue;}
case 481:{f.Push(JValue.R(rt.String(" that hasn't been chosen")));f.Pc=483;continue;}
case 483:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",486);}
case 486:{f.StackOp("pop");f.Pc=487;continue;}
case 487:{f.Pc=529;continue;}
case 490:{f.Push(f.Locals[18]);f.Pc=492;continue;}
case 492:{f.Push(JValue.R(rt.String("ThisTurn")));f.Pc=494;continue;}
case 494:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",497);}
case 497:{f.Pc=f.Pop().Int==0?511:500;continue;}
case 500:{f.Push(f.Locals[17]);f.Pc=502;continue;}
case 502:{f.Push(JValue.R(rt.String(" that hasn't been chosen this turn")));f.Pc=504;continue;}
case 504:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",507);}
case 507:{f.StackOp("pop");f.Pc=508;continue;}
case 508:{f.Pc=529;continue;}
case 511:{f.Push(f.Locals[18]);f.Pc=513;continue;}
case 513:{f.Push(JValue.R(rt.String("YourLastCombat")));f.Pc=515;continue;}
case 515:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",518);}
case 518:{f.Pc=f.Pop().Int==0?529:521;continue;}
case 521:{f.Push(f.Locals[17]);f.Pc=523;continue;}
case 523:{f.Push(JValue.R(rt.String(" that wasn't chosen during your last combat")));f.Pc=525;continue;}
case 525:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",528);}
case 528:{f.StackOp("pop");f.Pc=529;continue;}
case 529:{f.Push(f.Locals[11]);f.Pc=531;continue;}
case 531:{f.Pc=f.Pop().Int==0?542:534;continue;}
case 534:{f.Push(f.Locals[17]);f.Pc=536;continue;}
case 536:{f.Push(JValue.R(rt.String(" at random.")));f.Pc=538;continue;}
case 538:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",541);}
case 541:{f.StackOp("pop");f.Pc=542;continue;}
case 542:{f.Push(f.Locals[6]);f.Pc=544;continue;}
case 544:{f.Pc=f.Pop().Int==0?556:547;continue;}
case 547:{f.Push(f.Locals[17]);f.Pc=549;continue;}
case 549:{f.Push(JValue.R(rt.String(". You may choose the same mode more than once.")));f.Pc=552;continue;}
case 552:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",555);}
case 555:{f.StackOp("pop");f.Pc=556;continue;}
case 556:{f.Push(f.Locals[12]);f.Pc=558;continue;}
case 558:{f.Pc=f.Pop().Int==0?601:561;continue;}
case 561:{f.Push(f.Locals[2]);f.Pc=562;continue;}
case 562:{f.Push(f.Locals[0]);f.Pc=563;continue;}
case 563:{f.Push(JValue.R(rt.String("ActivationLimit")));f.Pc=565;continue;}
case 565:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",568);}
case 568:{f.Push(f.Locals[0]);f.Pc=569;continue;}
case 569:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",572);}
case 572:{f.Locals[18]=f.Pop();f.Pc=574;continue;}
case 574:{f.Push(f.Locals[18]);f.Pc=576;continue;}
case 576:{f.Push(JValue.I(1));f.Pc=577;continue;}
case 577:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?592:580;continue;}
case 580:{f.Push(f.Locals[17]);f.Pc=582;continue;}
case 582:{f.Push(JValue.R(rt.String(". Activate only once each turn.")));f.Pc=585;continue;}
case 585:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",588);}
case 588:{f.StackOp("pop");f.Pc=589;continue;}
case 589:{f.Pc=601;continue;}
case 592:{f.Push(f.Locals[17]);f.Pc=594;continue;}
case 594:{f.Push(JValue.R(rt.String(". Additional code needed in CharmEffect.")));f.Pc=597;continue;}
case 597:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",600);}
case 600:{f.StackOp("pop");f.Pc=601;continue;}
case 601:{f.Push(f.Locals[13]);f.Pc=603;continue;}
case 603:{f.Pc=f.Pop().Int==0?646:606;continue;}
case 606:{f.Push(f.Locals[2]);f.Pc=607;continue;}
case 607:{f.Push(f.Locals[0]);f.Pc=608;continue;}
case 608:{f.Push(JValue.R(rt.String("GameActivationLimit")));f.Pc=610;continue;}
case 610:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",613);}
case 613:{f.Push(f.Locals[0]);f.Pc=614;continue;}
case 614:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",617);}
case 617:{f.Locals[18]=f.Pop();f.Pc=619;continue;}
case 619:{f.Push(f.Locals[18]);f.Pc=621;continue;}
case 621:{f.Push(JValue.I(1));f.Pc=622;continue;}
case 622:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?637:625;continue;}
case 625:{f.Push(f.Locals[17]);f.Pc=627;continue;}
case 627:{f.Push(JValue.R(rt.String(". Activate only once.")));f.Pc=630;continue;}
case 630:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",633);}
case 633:{f.StackOp("pop");f.Pc=634;continue;}
case 634:{f.Pc=646;continue;}
case 637:{f.Push(f.Locals[17]);f.Pc=639;continue;}
case 639:{f.Push(JValue.R(rt.String(". Additional code needed in CharmEffect.")));f.Pc=642;continue;}
case 642:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",645);}
case 645:{f.StackOp("pop");f.Pc=646;continue;}
case 646:{f.Push(f.Locals[8]);f.Pc=648;continue;}
case 648:{f.Pc=f.Pop().Int==0?763:651;continue;}
case 651:{f.Push(f.Locals[0]);f.Pc=652;continue;}
case 652:{f.Push(JValue.R(rt.String("AdditionalDescription")));f.Pc=654;continue;}
case 654:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",657);}
case 657:{f.Locals[18]=f.Pop();f.Pc=659;continue;}
case 659:{f.Push(f.Locals[9]);f.Pc=661;continue;}
case 661:{f.Pc=f.Pop().Int==0?684:664;continue;}
case 664:{f.Push(f.Locals[17]);f.Pc=666;continue;}
case 666:{f.Push(JValue.R(rt.String(". ")));f.Pc=669;continue;}
case 669:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",672);}
case 672:{f.Push(f.Locals[18]);f.Pc=674;continue;}
case 674:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",677);}
case 677:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",680);}
case 680:{f.StackOp("pop");f.Pc=681;continue;}
case 681:{f.Pc=763;continue;}
case 684:{f.Push(f.Locals[18]);f.Pc=686;continue;}
case 686:{f.Push(JValue.R(rt.String(".")));f.Pc=689;continue;}
case 689:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",692);}
case 692:{f.Pc=f.Pop().Int==0?709:695;continue;}
case 695:{f.Push(f.Locals[17]);f.Pc=697;continue;}
case 697:{f.Push(f.Locals[18]);f.Pc=699;continue;}
case 699:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",702);}
case 702:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",705);}
case 705:{f.StackOp("pop");f.Pc=706;continue;}
case 706:{f.Pc=763;continue;}
case 709:{f.Push(f.Locals[18]);f.Pc=711;continue;}
case 711:{f.Push(JValue.R(rt.String("where X")));f.Pc=714;continue;}
case 714:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",717);}
case 717:{f.Pc=f.Pop().Int==0?746:720;continue;}
case 720:{f.Push(f.Locals[17]);f.Pc=722;continue;}
case 722:{f.Push(JValue.R(rt.String(", ")));f.Pc=725;continue;}
case 725:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",728);}
case 728:{f.Push(f.Locals[18]);f.Pc=730;continue;}
case 730:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",733);}
case 733:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",736);}
case 736:{f.Push(JValue.R(rt.String(" \u2014")));f.Pc=739;continue;}
case 739:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",742);}
case 742:{f.StackOp("pop");f.Pc=743;continue;}
case 743:{f.Pc=763;continue;}
case 746:{f.Push(f.Locals[17]);f.Pc=748;continue;}
case 748:{f.Push(JValue.R(rt.String(" ")));f.Pc=751;continue;}
case 751:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",754);}
case 754:{f.Push(f.Locals[18]);f.Pc=756;continue;}
case 756:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",759);}
case 759:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",762);}
case 762:{f.StackOp("pop");f.Pc=763;continue;}
case 763:{f.Push(f.Locals[1]);f.Pc=764;continue;}
case 764:{f.Pc=f.Pop().Int!=0?791:767;continue;}
case 767:{f.Push(f.Locals[17]);f.Pc=769;continue;}
case 769:{f.Push(f.Locals[7]);f.Pc=771;continue;}
case 771:{f.Push(JValue.I(1));f.Pc=772;continue;}
case 772:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?781:775;continue;}
case 775:{f.Push(JValue.R(rt.String(" mode.")));f.Pc=778;continue;}
case 778:{f.Pc=784;continue;}
case 781:{f.Push(JValue.R(rt.String(" modes.")));f.Pc=784;continue;}
case 784:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",787);}
case 787:{f.StackOp("pop");f.Pc=788;continue;}
case 788:{f.Pc=1064;continue;}
case 791:{f.Push(f.Locals[3]);f.Pc=792;continue;}
case 792:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",797);}
case 797:{f.Pc=f.Pop().Int!=0?1064:800;continue;}
case 800:{f.Push(f.Locals[15]);f.Pc=802;continue;}
case 802:{f.Pc=f.Pop().Int!=0?848:805;continue;}
case 805:{f.Push(f.Locals[16]);f.Pc=807;continue;}
case 807:{f.Pc=f.Pop().Int!=0?848:810;continue;}
case 810:{f.Push(f.Locals[6]);f.Pc=812;continue;}
case 812:{f.Pc=f.Pop().Int!=0?839:815;continue;}
case 815:{f.Push(f.Locals[8]);f.Pc=817;continue;}
case 817:{f.Pc=f.Pop().Int!=0?839:820;continue;}
case 820:{f.Push(f.Locals[12]);f.Pc=822;continue;}
case 822:{f.Pc=f.Pop().Int!=0?839:825;continue;}
case 825:{f.Push(f.Locals[13]);f.Pc=827;continue;}
case 827:{f.Pc=f.Pop().Int!=0?839:830;continue;}
case 830:{f.Push(f.Locals[17]);f.Pc=832;continue;}
case 832:{f.Push(JValue.R(rt.String(" \u2014")));f.Pc=835;continue;}
case 835:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",838);}
case 838:{f.StackOp("pop");f.Pc=839;continue;}
case 839:{f.Push(f.Locals[17]);f.Pc=841;continue;}
case 841:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=844;continue;}
case 844:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",847);}
case 847:{f.StackOp("pop");f.Pc=848;continue;}
case 848:{f.Push(f.Locals[3]);f.Pc=849;continue;}
case 849:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",854);}
case 854:{f.Locals[18]=f.Pop();f.Pc=856;continue;}
case 856:{f.Push(f.Locals[18]);f.Pc=858;continue;}
case 858:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",863);}
case 863:{f.Pc=f.Pop().Int==0?1055:866;continue;}
case 866:{f.Push(f.Locals[18]);f.Pc=868;continue;}
case 868:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",873);}
case 873:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=876;continue;}
case 876:{f.Locals[19]=f.Pop();f.Pc=878;continue;}
case 878:{f.Push(f.Locals[15]);f.Pc=880;continue;}
case 880:{f.Pc=f.Pop().Int==0?916:883;continue;}
case 883:{f.Push(f.Locals[17]);f.Pc=885;continue;}
case 885:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=888;continue;}
case 888:{f.StackOp("dup");f.Pc=889;continue;}
case 889:{f.Push(f.Locals[19]);f.Pc=891;continue;}
case 891:{f.Push(JValue.R(rt.String("ModeCost")));f.Pc=894;continue;}
case 894:{return rt.Call(f,"forge/game/spellability/AbilitySub","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",897);}
case 897:{f.Push(JValue.I(0));f.Pc=898;continue;}
case 898:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",901);}
case 901:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",904);}
case 904:{return rt.DynamicCall(f,"forge/game/ability/effects/CharmEffect:3128:904:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",909);}
case 909:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",912);}
case 912:{f.StackOp("pop");f.Pc=913;continue;}
case 913:{f.Pc=1029;continue;}
case 916:{f.Push(f.Locals[16]);f.Pc=918;continue;}
case 918:{f.Pc=f.Pop().Int==0?980:921;continue;}
case 921:{f.Push(f.Locals[17]);f.Pc=923;continue;}
case 923:{f.Push(JValue.R(rt.String("\u2022 ")));f.Pc=926;continue;}
case 926:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",929);}
case 929:{f.Push(f.Locals[19]);f.Pc=931;continue;}
case 931:{f.Push(JValue.R(rt.String("PrecostDesc")));f.Pc=934;continue;}
case 934:{return rt.Call(f,"forge/game/spellability/AbilitySub","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",937);}
case 937:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",940);}
case 940:{f.Push(JValue.R(rt.String(" \u2014 ")));f.Pc=943;continue;}
case 943:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",946);}
case 946:{f.StackOp("pop");f.Pc=947;continue;}
case 947:{f.Push(f.Locals[17]);f.Pc=949;continue;}
case 949:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=952;continue;}
case 952:{f.StackOp("dup");f.Pc=953;continue;}
case 953:{f.Push(f.Locals[19]);f.Pc=955;continue;}
case 955:{f.Push(JValue.R(rt.String("ModeCost")));f.Pc=958;continue;}
case 958:{return rt.Call(f,"forge/game/spellability/AbilitySub","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",961);}
case 961:{f.Push(JValue.I(0));f.Pc=962;continue;}
case 962:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",965);}
case 965:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",968);}
case 968:{return rt.DynamicCall(f,"forge/game/ability/effects/CharmEffect:3128:968:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",973);}
case 973:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",976);}
case 976:{f.StackOp("pop");f.Pc=977;continue;}
case 977:{f.Pc=1029;continue;}
case 980:{f.Push(f.Locals[19]);f.Pc=982;continue;}
case 982:{f.Push(JValue.R(rt.String("Pawprint")));f.Pc=984;continue;}
case 984:{return rt.Call(f,"forge/game/spellability/AbilitySub","hasParam","(Ljava/lang/String;)Z","invokevirtual",987);}
case 987:{f.Pc=f.Pop().Int==0?1020:990;continue;}
case 990:{f.Push(f.Locals[17]);f.Pc=992;continue;}
case 992:{f.Push(JValue.R(rt.String("{P}")));f.Pc=995;continue;}
case 995:{f.Push(f.Locals[19]);f.Pc=997;continue;}
case 997:{f.Push(JValue.R(rt.String("Pawprint")));f.Pc=999;continue;}
case 999:{return rt.Call(f,"forge/game/spellability/AbilitySub","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1002);}
case 1002:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",1005);}
case 1005:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","repeat","(Ljava/lang/String;I)Ljava/lang/String;","invokestatic",1008);}
case 1008:{return rt.DynamicCall(f,"forge/game/ability/effects/CharmEffect:3128:1008:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1013);}
case 1013:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1016);}
case 1016:{f.StackOp("pop");f.Pc=1017;continue;}
case 1017:{f.Pc=1029;continue;}
case 1020:{f.Push(f.Locals[17]);f.Pc=1022;continue;}
case 1022:{f.Push(JValue.R(rt.String("\u2022 ")));f.Pc=1025;continue;}
case 1025:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1028);}
case 1028:{f.StackOp("pop");f.Pc=1029;continue;}
case 1029:{f.Push(f.Locals[17]);f.Pc=1031;continue;}
case 1031:{f.Push(f.Locals[19]);f.Pc=1033;continue;}
case 1033:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=1036;continue;}
case 1036:{return rt.Call(f,"forge/game/spellability/AbilitySub","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",1039);}
case 1039:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1042);}
case 1042:{f.StackOp("pop");f.Pc=1043;continue;}
case 1043:{f.Push(f.Locals[17]);f.Pc=1045;continue;}
case 1045:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=1048;continue;}
case 1048:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1051);}
case 1051:{f.StackOp("pop");f.Pc=1052;continue;}
case 1052:{f.Pc=856;continue;}
case 1055:{f.Push(f.Locals[17]);f.Pc=1057;continue;}
case 1057:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=1060;continue;}
case 1060:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1063);}
case 1063:{f.StackOp("pop");f.Pc=1064;continue;}
case 1064:{f.Push(f.Locals[17]);f.Pc=1066;continue;}
case 1066:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1069);}
case 1069:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3129(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3130(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3131(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","incDilemmasFacedThisTurn","()V","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Int==0?27:13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Random","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Random","Lforge/game/ability/AbilityKey;"));f.Pc=17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",21);}
case 21:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",34);}
case 34:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","FacesDilemma","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","FacesDilemma","Lforge/game/trigger/TriggerType;"));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",42);}
case 42:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3132(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCopied","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/ability/effects/CharmEffect","makePossibleOptions","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",18);}
case 18:{f.Locals[1]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","isEntwine","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int==0?33:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/ability/effects/CharmEffect","chainAbilities","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)V","invokestatic",31);}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",37);}
case 37:{f.Locals[2]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",42);}
case 42:{f.Locals[3]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("CanRepeatModes")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",49);}
case 49:{f.Locals[4]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(JValue.R(rt.String("CharmNum")));f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("1")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",60);}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",64);}
case 64:{f.Locals[5]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("MinCharmNum")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?89:75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("MinCharmNum")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",82);}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",86);}
case 86:{f.Pc=91;continue;}
case 89:{f.Push(f.Locals[5]);f.Pc=91;continue;}
case 91:{f.Locals[6]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[4]);f.Pc=95;continue;}
case 95:{f.Pc=f.Pop().Int!=0?124:98;continue;}
case 98:{f.Push(f.Locals[6]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",106);}
case 106:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?111:109;continue;}
case 109:{f.Push(JValue.I(0));f.Pc=110;continue;}
case 110:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 111:{f.Push(f.Locals[5]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",119);}
case 119:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",122);}
case 122:{f.Locals[5]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String("Optional")));f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",130);}
case 130:{f.Locals[7]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[7]);f.Pc=134;continue;}
case 134:{f.Pc=f.Pop().Int==0?172:137;continue;}
case 137:{f.Push(f.Locals[3]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",141);}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(JValue.R(null));f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",146);}
case 146:{f.Push(JValue.R(rt.String("lblWouldYouLikeCharm")));f.Pc=149;continue;}
case 149:{f.Push(JValue.I(1));f.Pc=150;continue;}
case 150:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=153;continue;}
case 153:{f.StackOp("dup");f.Pc=154;continue;}
case 154:{f.Push(JValue.I(0));f.Pc=155;continue;}
case 155:{f.Push(f.Locals[2]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",159);}
case 159:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",163);}
case 163:{f.Push(JValue.R(null));f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",167);}
case 167:{f.Pc=f.Pop().Int!=0?172:170;continue;}
case 170:{f.Push(JValue.I(0));f.Pc=171;continue;}
case 171:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{f.Push(JValue.R(rt.String("Random")));f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",178);}
case 178:{f.Pc=f.Pop().Int==0?281:181;continue;}
case 181:{f.Push(JValue.I(1));f.Pc=182;continue;}
case 182:{f.Locals[8]=f.Pop();f.Pc=184;continue;}
case 184:{f.Push(f.Locals[0]);f.Pc=185;continue;}
case 185:{f.Push(JValue.R(rt.String("Random")));f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",190);}
case 190:{f.Push(JValue.R(rt.String("Compare")));f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",196);}
case 196:{f.Pc=f.Pop().Int==0?245:199;continue;}
case 199:{f.Push(f.Locals[0]);f.Pc=200;continue;}
case 200:{f.Push(JValue.R(rt.String("RandomCompare")));f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",206);}
case 206:{f.Locals[9]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[2]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[0]);f.Pc=210;continue;}
case 210:{f.Push(JValue.R(rt.String("RandomCompareSVar")));f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",216);}
case 216:{f.Push(f.Locals[0]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",220);}
case 220:{f.Locals[10]=f.Pop();f.Pc=222;continue;}
case 222:{f.Push(f.Locals[10]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[9]);f.Pc=226;continue;}
case 226:{f.Push(JValue.I(0));f.Pc=227;continue;}
case 227:{f.Push(JValue.I(2));f.Pc=228;continue;}
case 228:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",231);}
case 231:{f.Push(f.Locals[9]);f.Pc=233;continue;}
case 233:{f.Push(JValue.I(2));f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",237);}
case 237:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",240);}
case 240:{return rt.Call(f,"forge/util/Expressions","compare","(ILjava/lang/String;I)Z","invokestatic",243);}
case 243:{f.Locals[8]=f.Pop();f.Pc=245;continue;}
case 245:{f.Push(f.Locals[8]);f.Pc=247;continue;}
case 247:{f.Pc=f.Pop().Int==0?281:250;continue;}
case 250:{f.Push(f.Locals[1]);f.Pc=251;continue;}
case 251:{f.Push(f.Locals[5]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",256);}
case 256:{f.Locals[9]=f.Pop();f.Pc=258;continue;}
case 258:{f.Push(f.Locals[0]);f.Pc=259;continue;}
case 259:{f.Push(f.Locals[9]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/ability/effects/CharmEffect","chainAbilities","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)V","invokestatic",264);}
case 264:{f.Push(f.Locals[9]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",271);}
case 271:{f.Pc=f.Pop().Int!=0?279:274;continue;}
case 274:{f.Push(f.Locals[3]);f.Pc=275;continue;}
case 275:{f.Push(JValue.I(1));f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/ability/effects/CharmEffect","faceDilemma","(Lforge/game/player/Player;Z)V","invokestatic",279);}
case 279:{f.Push(JValue.I(1));f.Pc=280;continue;}
case 280:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 281:{f.Push(f.Locals[0]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",285);}
case 285:{f.Locals[8]=f.Pop();f.Pc=287;continue;}
case 287:{f.Push(f.Locals[0]);f.Pc=288;continue;}
case 288:{f.Push(JValue.R(rt.String("Chooser")));f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",293);}
case 293:{f.Pc=f.Pop().Int==0?327:296;continue;}
case 296:{f.Push(f.Locals[3]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/player/Player","getOpponents","()Lforge/game/player/PlayerCollection;","invokevirtual",300);}
case 300:{f.Locals[9]=f.Pop();f.Pc=302;continue;}
case 302:{f.Push(f.Locals[3]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",306);}
case 306:{f.Push(f.Locals[9]);f.Pc=308;continue;}
case 308:{f.Push(f.Locals[0]);f.Pc=309;continue;}
case 309:{f.Push(JValue.R(rt.String("Choose an opponent")));f.Pc=312;continue;}
case 312:{f.Push(JValue.R(null));f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",316);}
case 316:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=319;continue;}
case 319:{f.Locals[8]=f.Pop();f.Pc=321;continue;}
case 321:{f.Push(f.Locals[0]);f.Pc=322;continue;}
case 322:{f.Push(f.Locals[8]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/spellability/SpellAbility","setChoosingPlayer","(Lforge/game/player/Player;)V","invokevirtual",327);}
case 327:{f.Push(f.Locals[8]);f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",332);}
case 332:{f.Push(f.Locals[0]);f.Pc=333;continue;}
case 333:{f.Push(f.Locals[1]);f.Pc=334;continue;}
case 334:{f.Push(f.Locals[6]);f.Pc=336;continue;}
case 336:{f.Push(f.Locals[5]);f.Pc=338;continue;}
case 338:{f.Push(f.Locals[4]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/game/player/PlayerController","chooseModeForAbility","(Lforge/game/spellability/SpellAbility;Ljava/util/List;IIZ)Ljava/util/List;","invokevirtual",343);}
case 343:{f.Locals[9]=f.Pop();f.Pc=345;continue;}
case 345:{f.Push(f.Locals[0]);f.Pc=346;continue;}
case 346:{f.Push(f.Locals[9]);f.Pc=348;continue;}
case 348:{return rt.Call(f,"forge/game/ability/effects/CharmEffect","chainAbilities","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)V","invokestatic",351);}
case 351:{f.Push(f.Locals[9]);f.Pc=353;continue;}
case 353:{f.Pc=f.Pop().Reference==null?372:356;continue;}
case 356:{f.Push(f.Locals[9]);f.Pc=358;continue;}
case 358:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",363);}
case 363:{f.Pc=f.Pop().Int!=0?372:366;continue;}
case 366:{f.Push(f.Locals[8]);f.Pc=368;continue;}
case 368:{f.Push(JValue.I(0));f.Pc=369;continue;}
case 369:{return rt.Call(f,"forge/game/ability/effects/CharmEffect","faceDilemma","(Lforge/game/player/Player;Z)V","invokestatic",372);}
case 372:{f.Push(f.Locals[0]);f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/game/spellability/SpellAbility","isTrigger","()Z","invokevirtual",376);}
case 376:{f.Pc=f.Pop().Int==0?400:379;continue;}
case 379:{f.Push(f.Locals[9]);f.Pc=381;continue;}
case 381:{f.Pc=f.Pop().Reference==null?398:384;continue;}
case 384:{f.Push(f.Locals[9]);f.Pc=386;continue;}
case 386:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",391);}
case 391:{f.Pc=f.Pop().Int!=0?398:394;continue;}
case 394:{f.Push(JValue.I(1));f.Pc=395;continue;}
case 395:{f.Pc=399;continue;}
case 398:{f.Push(JValue.I(0));f.Pc=399;continue;}
case 399:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 400:{f.Push(JValue.I(1));f.Pc=401;continue;}
case 401:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3133(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?5:4;continue;}
case 4:{return JStep.ReturnVoid;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.DynamicCall(f,"forge/game/ability/effects/CharmEffect:3133:6:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/ToIntFunction;",11);}
case 11:{return rt.Call(f,"java/util/Comparator","comparingInt","(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;","invokestatic",14);}
case 14:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",19);}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",27);}
case 27:{f.Locals[3]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",34);}
case 34:{f.Pc=f.Pop().Int==0?108:37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{f.Locals[4]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",54);}
case 54:{return rt.Call(f,"forge/game/spellability/AbilitySub","copy","(Lforge/game/player/Player;)Lforge/game/spellability/SpellAbility;","invokevirtual",57);}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{f.Locals[5]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[5]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("CharmOrder")));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",70);}
case 70:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",73);}
case 73:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=76;continue;}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("StackDescription")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/spellability/AbilitySub","hasParam","(Ljava/lang/String;)Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int!=0?99:87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("StackDescription")));f.Pc=92;continue;}
case 92:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/spellability/AbilitySub","putParam","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",98);}
case 98:{f.StackOp("pop");f.Pc=99;continue;}
case 99:{f.Push(f.Locals[0]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[5]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/spellability/SpellAbility","appendSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",105);}
case 105:{f.Pc=28;continue;}
case 108:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3134(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("CharmOrder")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/AbilitySub","getSVarInt","(Ljava/lang/String;)Ljava/lang/Integer;","invokevirtual",6);}
case 6:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
