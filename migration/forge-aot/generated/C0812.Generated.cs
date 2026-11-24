// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C812{
internal static JClass Build(){var c=new JClass("forge/game/spellability/TargetRestrictions","java/lang/Object",new string[]{},33);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("originalValidTgts","[Ljava/lang/String;",false,JValue.Default("[Ljava/lang/String;"),null));
c.Add(new JField("validTgts","[Ljava/lang/String;",false,JValue.Default("[Ljava/lang/String;"),null));
c.Add(new JField("uiPrompt","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("validTgtsDesc","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("tgtZone","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("saValidTargeting","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("uniqueTargets","Z",false,JValue.Default("Z"),null));
c.Add(new JField("forEachPlayer","Z",false,JValue.Default("Z"),null));
c.Add(new JField("differentControllers","Z",false,JValue.Default("Z"),null));
c.Add(new JField("differentCMC","Z",false,JValue.Default("Z"),null));
c.Add(new JField("differentNames","Z",false,JValue.Default("Z"),null));
c.Add(new JField("equalToughness","Z",false,JValue.Default("Z"),null));
c.Add(new JField("sameController","Z",false,JValue.Default("Z"),null));
c.Add(new JField("withoutSameCreatureType","Z",false,JValue.Default("Z"),null));
c.Add(new JField("withSameCreatureType","Z",false,JValue.Default("Z"),null));
c.Add(new JField("withSameCardType","Z",false,JValue.Default("Z"),null));
c.Add(new JField("randomTarget","Z",false,JValue.Default("Z"),null));
c.Add(new JField("randomNumTargets","Z",false,JValue.Default("Z"),null));
c.Add(new JField("minTargets","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("maxTargets","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("maxTotalCMC","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("maxTotalPower","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("bMandatory","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(9740,"forge/game/spellability/TargetRestrictions","<init>","(Lforge/game/spellability/TargetRestrictions;)V",1,2,5,new JHandler[]{},M9740));
c.Add(new JMethod(9741,"forge/game/spellability/TargetRestrictions","<init>","(Ljava/util/Map;)V",1,2,5,new JHandler[]{},M9741));
c.Add(new JMethod(9742,"forge/game/spellability/TargetRestrictions","getMandatory","()Z",17,1,1,new JHandler[]{},M9742));
c.Add(new JMethod(9743,"forge/game/spellability/TargetRestrictions","setMandatory","(Z)V",17,2,2,new JHandler[]{},M9743));
c.Add(new JMethod(9744,"forge/game/spellability/TargetRestrictions","setMaxTotalCMC","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9744));
c.Add(new JMethod(9745,"forge/game/spellability/TargetRestrictions","setMaxTotalPower","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9745));
c.Add(new JMethod(9746,"forge/game/spellability/TargetRestrictions","getValidTgts","()[Ljava/lang/String;",17,1,1,new JHandler[]{},M9746));
c.Add(new JMethod(9747,"forge/game/spellability/TargetRestrictions","getValidDesc","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9747));
c.Add(new JMethod(9748,"forge/game/spellability/TargetRestrictions","getVTSelection","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9748));
c.Add(new JMethod(9749,"forge/game/spellability/TargetRestrictions","getMinTargets","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9749));
c.Add(new JMethod(9750,"forge/game/spellability/TargetRestrictions","getMaxTargets","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9750));
c.Add(new JMethod(9751,"forge/game/spellability/TargetRestrictions","getMaxTotalCMC","()Ljava/lang/String;",2,1,1,new JHandler[]{},M9751));
c.Add(new JMethod(9752,"forge/game/spellability/TargetRestrictions","getMaxTotalCMC","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)I",17,3,3,new JHandler[]{},M9752));
c.Add(new JMethod(9753,"forge/game/spellability/TargetRestrictions","getMaxTotalPower","()Ljava/lang/String;",2,1,1,new JHandler[]{},M9753));
c.Add(new JMethod(9754,"forge/game/spellability/TargetRestrictions","getMaxTotalPower","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)I",17,3,3,new JHandler[]{},M9754));
c.Add(new JMethod(9755,"forge/game/spellability/TargetRestrictions","getMinTargets","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)I",17,3,3,new JHandler[]{},M9755));
c.Add(new JMethod(9756,"forge/game/spellability/TargetRestrictions","getMaxTargets","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)I",17,3,3,new JHandler[]{},M9756));
c.Add(new JMethod(9757,"forge/game/spellability/TargetRestrictions","isMaxTargetsChosen","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z",17,3,3,new JHandler[]{},M9757));
c.Add(new JMethod(9758,"forge/game/spellability/TargetRestrictions","isMinTargetsChosen","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z",17,4,3,new JHandler[]{},M9758));
c.Add(new JMethod(9759,"forge/game/spellability/TargetRestrictions","setZone","(Lforge/game/zone/ZoneType;)V",17,2,5,new JHandler[]{},M9759));
c.Add(new JMethod(9760,"forge/game/spellability/TargetRestrictions","setZone","(Ljava/util/List;)V",17,2,2,new JHandler[]{},M9760));
c.Add(new JMethod(9761,"forge/game/spellability/TargetRestrictions","getZone","()Ljava/util/List;",17,1,1,new JHandler[]{},M9761));
c.Add(new JMethod(9762,"forge/game/spellability/TargetRestrictions","setSAValidTargeting","(Ljava/lang/String;)V",17,2,2,new JHandler[]{},M9762));
c.Add(new JMethod(9763,"forge/game/spellability/TargetRestrictions","getSAValidTargeting","()Ljava/lang/String;",17,1,1,new JHandler[]{},M9763));
c.Add(new JMethod(9764,"forge/game/spellability/TargetRestrictions","canOnlyTgtOpponent","()Z",17,7,2,new JHandler[]{},M9764));
c.Add(new JMethod(9765,"forge/game/spellability/TargetRestrictions","canTgtPlayer","()Z",17,5,2,new JHandler[]{},M9765));
c.Add(new JMethod(9766,"forge/game/spellability/TargetRestrictions","canTgtPermanent","()Z",17,5,2,new JHandler[]{},M9766));
c.Add(new JMethod(9767,"forge/game/spellability/TargetRestrictions","canTgtCreature","()Z",17,10,2,new JHandler[]{},M9767));
c.Add(new JMethod(9768,"forge/game/spellability/TargetRestrictions","canTgtPlaneswalker","()Z",17,5,2,new JHandler[]{},M9768));
c.Add(new JMethod(9769,"forge/game/spellability/TargetRestrictions","hasCandidates","(Lforge/game/spellability/SpellAbility;)Z",17,6,5,new JHandler[]{},M9769));
c.Add(new JMethod(9770,"forge/game/spellability/TargetRestrictions","getNumCandidates","(Lforge/game/spellability/SpellAbility;)I",17,6,3,new JHandler[]{},M9770));
c.Add(new JMethod(9771,"forge/game/spellability/TargetRestrictions","getAllCandidates","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",17,2,3,new JHandler[]{},M9771));
c.Add(new JMethod(9772,"forge/game/spellability/TargetRestrictions","getAllCandidates","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/List;",17,7,2,new JHandler[]{},M9772));
c.Add(new JMethod(9773,"forge/game/spellability/TargetRestrictions","isUniqueTargets","()Z",17,1,1,new JHandler[]{},M9773));
c.Add(new JMethod(9774,"forge/game/spellability/TargetRestrictions","setUniqueTargets","(Z)V",17,2,2,new JHandler[]{},M9774));
c.Add(new JMethod(9775,"forge/game/spellability/TargetRestrictions","isWithoutSameCreatureType","()Z",1,1,1,new JHandler[]{},M9775));
c.Add(new JMethod(9776,"forge/game/spellability/TargetRestrictions","setWithoutSameCreatureType","(Z)V",1,2,2,new JHandler[]{},M9776));
c.Add(new JMethod(9777,"forge/game/spellability/TargetRestrictions","isWithSameCreatureType","()Z",1,1,1,new JHandler[]{},M9777));
c.Add(new JMethod(9778,"forge/game/spellability/TargetRestrictions","setWithSameCreatureType","(Z)V",1,2,2,new JHandler[]{},M9778));
c.Add(new JMethod(9779,"forge/game/spellability/TargetRestrictions","isWithSameCardType","()Z",1,1,1,new JHandler[]{},M9779));
c.Add(new JMethod(9780,"forge/game/spellability/TargetRestrictions","setWithSameCardType","(Z)V",1,2,2,new JHandler[]{},M9780));
}

private static void Add1(JClass c){
c.Add(new JMethod(9781,"forge/game/spellability/TargetRestrictions","copy","()Lforge/game/spellability/TargetRestrictions;",1,3,2,new JHandler[]{new JHandler(2,10,13,"java/lang/CloneNotSupportedException")},M9781));
c.Add(new JMethod(9782,"forge/game/spellability/TargetRestrictions","isRandomTarget","()Z",1,1,1,new JHandler[]{},M9782));
c.Add(new JMethod(9783,"forge/game/spellability/TargetRestrictions","setRandomTarget","(Z)V",1,2,2,new JHandler[]{},M9783));
c.Add(new JMethod(9784,"forge/game/spellability/TargetRestrictions","isRandomNumTargets","()Z",1,1,1,new JHandler[]{},M9784));
c.Add(new JMethod(9785,"forge/game/spellability/TargetRestrictions","setRandomNumTargets","(Z)V",1,2,2,new JHandler[]{},M9785));
c.Add(new JMethod(9786,"forge/game/spellability/TargetRestrictions","isDifferentCMC","()Z",1,1,1,new JHandler[]{},M9786));
c.Add(new JMethod(9787,"forge/game/spellability/TargetRestrictions","setDifferentCMC","(Z)V",1,2,2,new JHandler[]{},M9787));
c.Add(new JMethod(9788,"forge/game/spellability/TargetRestrictions","isDifferentNames","()Z",1,1,1,new JHandler[]{},M9788));
c.Add(new JMethod(9789,"forge/game/spellability/TargetRestrictions","setDifferentNames","(Z)V",1,2,2,new JHandler[]{},M9789));
c.Add(new JMethod(9790,"forge/game/spellability/TargetRestrictions","isEqualToughness","()Z",1,1,1,new JHandler[]{},M9790));
c.Add(new JMethod(9791,"forge/game/spellability/TargetRestrictions","setEqualToughness","(Z)V",1,2,2,new JHandler[]{},M9791));
c.Add(new JMethod(9792,"forge/game/spellability/TargetRestrictions","isDifferentControllers","()Z",1,1,1,new JHandler[]{},M9792));
c.Add(new JMethod(9793,"forge/game/spellability/TargetRestrictions","setDifferentControllers","(Z)V",1,2,2,new JHandler[]{},M9793));
c.Add(new JMethod(9794,"forge/game/spellability/TargetRestrictions","isForEachPlayer","()Z",1,1,1,new JHandler[]{},M9794));
c.Add(new JMethod(9795,"forge/game/spellability/TargetRestrictions","setForEachPlayer","(Z)V",1,2,2,new JHandler[]{},M9795));
c.Add(new JMethod(9796,"forge/game/spellability/TargetRestrictions","isSameController","()Z",17,1,1,new JHandler[]{},M9796));
c.Add(new JMethod(9797,"forge/game/spellability/TargetRestrictions","setSameController","(Z)V",17,2,2,new JHandler[]{},M9797));
c.Add(new JMethod(9798,"forge/game/spellability/TargetRestrictions","applyTargetTextChanges","(Lforge/game/spellability/SpellAbility;)V",17,3,4,new JHandler[]{},M9798));
}

internal static JStep M9740(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("")));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","uiPrompt","Ljava/lang/String;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("")));f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgtsDesc","Ljava/lang/String;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.NewArray("Lforge/game/zone/ZoneType;",f.Pop().Int)));f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=26;continue;}
case 26:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",30);}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","tgtZone","Ljava/util/List;",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(null));f.Pc=35;continue;}
case 35:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","saValidTargeting","Ljava/lang/String;",value);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","uniqueTargets","Z",value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","forEachPlayer","Z",value);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","differentControllers","Z",value);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","differentCMC","Z",value);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","differentNames","Z",value);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","equalToughness","Z",value);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(JValue.I(0));f.Pc=70;continue;}
case 70:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","sameController","Z",value);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(JValue.I(0));f.Pc=75;continue;}
case 75:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","withoutSameCreatureType","Z",value);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(JValue.I(0));f.Pc=80;continue;}
case 80:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","withSameCreatureType","Z",value);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(JValue.I(0));f.Pc=85;continue;}
case 85:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","withSameCardType","Z",value);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(JValue.I(0));f.Pc=90;continue;}
case 90:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","randomTarget","Z",value);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(JValue.I(0));f.Pc=95;continue;}
case 95:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","randomNumTargets","Z",value);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(JValue.I(0));f.Pc=100;continue;}
case 100:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","bMandatory","Z",value);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getVTSelection","()Ljava/lang/String;","invokevirtual",108);}
case 108:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","uiPrompt","Ljava/lang/String;",value);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getValidTgts","()[Ljava/lang/String;","invokevirtual",116);}
case 116:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","originalValidTgts","[Ljava/lang/String;",value);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[0]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","originalValidTgts","[Ljava/lang/String;"));f.Pc=124;continue;}
case 124:{return rt.Call(f,"[Ljava/lang/String;","clone","()Ljava/lang/Object;","invokevirtual",127);}
case 127:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Ljava/lang/String;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=130;continue;}
case 130:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgts","[Ljava/lang/String;",value);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[0]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getMinTargets","()Ljava/lang/String;","invokevirtual",138);}
case 138:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","minTargets","Ljava/lang/String;",value);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[1]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getMaxTargets","()Ljava/lang/String;","invokevirtual",146);}
case 146:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","maxTargets","Ljava/lang/String;",value);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[1]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getMaxTotalCMC","()Ljava/lang/String;","invokevirtual",154);}
case 154:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","maxTotalCMC","Ljava/lang/String;",value);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[1]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getMaxTotalPower","()Ljava/lang/String;","invokevirtual",162);}
case 162:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","maxTotalPower","Ljava/lang/String;",value);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[0]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[1]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getZone","()Ljava/util/List;","invokevirtual",170);}
case 170:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","tgtZone","Ljava/util/List;",value);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[0]);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[1]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getSAValidTargeting","()Ljava/lang/String;","invokevirtual",178);}
case 178:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","saValidTargeting","Ljava/lang/String;",value);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[0]);f.Pc=182;continue;}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isUniqueTargets","()Z","invokevirtual",186);}
case 186:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","uniqueTargets","Z",value);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[0]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[1]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isForEachPlayer","()Z","invokevirtual",194);}
case 194:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","forEachPlayer","Z",value);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[0]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[1]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isDifferentControllers","()Z","invokevirtual",202);}
case 202:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","differentControllers","Z",value);f.Pc=205;continue;}
case 205:{f.Push(f.Locals[0]);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[1]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isDifferentCMC","()Z","invokevirtual",210);}
case 210:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","differentCMC","Z",value);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[0]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[1]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isEqualToughness","()Z","invokevirtual",218);}
case 218:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","equalToughness","Z",value);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[0]);f.Pc=222;continue;}
case 222:{f.Push(f.Locals[1]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isSameController","()Z","invokevirtual",226);}
case 226:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","sameController","Z",value);f.Pc=229;continue;}
case 229:{f.Push(f.Locals[0]);f.Pc=230;continue;}
case 230:{f.Push(f.Locals[1]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isWithoutSameCreatureType","()Z","invokevirtual",234);}
case 234:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","withoutSameCreatureType","Z",value);f.Pc=237;continue;}
case 237:{f.Push(f.Locals[0]);f.Pc=238;continue;}
case 238:{f.Push(f.Locals[1]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isWithSameCreatureType","()Z","invokevirtual",242);}
case 242:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","withSameCreatureType","Z",value);f.Pc=245;continue;}
case 245:{f.Push(f.Locals[0]);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[1]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isWithSameCardType","()Z","invokevirtual",250);}
case 250:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","withSameCardType","Z",value);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[0]);f.Pc=254;continue;}
case 254:{f.Push(f.Locals[1]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isRandomTarget","()Z","invokevirtual",258);}
case 258:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","randomTarget","Z",value);f.Pc=261;continue;}
case 261:{f.Push(f.Locals[0]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[1]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","isRandomNumTargets","()Z","invokevirtual",266);}
case 266:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","randomNumTargets","Z",value);f.Pc=269;continue;}
case 269:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9741(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("")));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","uiPrompt","Ljava/lang/String;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("")));f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgtsDesc","Ljava/lang/String;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.NewArray("Lforge/game/zone/ZoneType;",f.Pop().Int)));f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=26;continue;}
case 26:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",30);}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","tgtZone","Ljava/util/List;",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(null));f.Pc=35;continue;}
case 35:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","saValidTargeting","Ljava/lang/String;",value);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","uniqueTargets","Z",value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","forEachPlayer","Z",value);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","differentControllers","Z",value);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","differentCMC","Z",value);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","differentNames","Z",value);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","equalToughness","Z",value);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(JValue.I(0));f.Pc=70;continue;}
case 70:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","sameController","Z",value);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(JValue.I(0));f.Pc=75;continue;}
case 75:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","withoutSameCreatureType","Z",value);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(JValue.I(0));f.Pc=80;continue;}
case 80:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","withSameCreatureType","Z",value);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(JValue.I(0));f.Pc=85;continue;}
case 85:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","withSameCardType","Z",value);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(JValue.I(0));f.Pc=90;continue;}
case 90:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","randomTarget","Z",value);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(JValue.I(0));f.Pc=95;continue;}
case 95:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","randomNumTargets","Z",value);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(JValue.I(0));f.Pc=100;continue;}
case 100:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","bMandatory","Z",value);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.String("ValidTgts")));f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",112);}
case 112:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String(",")));f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",120);}
case 120:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","originalValidTgts","[Ljava/lang/String;",value);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","originalValidTgts","[Ljava/lang/String;"));f.Pc=128;continue;}
case 128:{return rt.Call(f,"[Ljava/lang/String;","clone","()Ljava/lang/Object;","invokevirtual",131);}
case 131:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Ljava/lang/String;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=134;continue;}
case 134:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgts","[Ljava/lang/String;",value);f.Pc=137;continue;}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String("TargetMin")));f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.String("1")));f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",148);}
case 148:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=151;continue;}
case 151:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","minTargets","Ljava/lang/String;",value);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[0]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.String("TargetMax")));f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("1")));f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",165);}
case 165:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=168;continue;}
case 168:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","maxTargets","Ljava/lang/String;",value);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[1]);f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.String("ValidTgtsDesc")));f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",179);}
case 179:{f.Pc=f.Pop().Int==0?200:182;continue;}
case 182:{f.Push(f.Locals[0]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[1]);f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("ValidTgtsDesc")));f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",191);}
case 191:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=194;continue;}
case 194:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgtsDesc","Ljava/lang/String;",value);f.Pc=197;continue;}
case 197:{f.Pc=256;continue;}
case 200:{f.Push(JValue.R(rt.String("Any")));f.Pc=202;continue;}
case 202:{f.Push(f.Locals[1]);f.Pc=203;continue;}
case 203:{f.Push(JValue.R(rt.String("ValidTgts")));f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",210);}
case 210:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",213);}
case 213:{f.Pc=f.Pop().Int==0?225:216;continue;}
case 216:{f.Push(f.Locals[0]);f.Pc=217;continue;}
case 217:{f.Push(JValue.R(rt.String("damage target")));f.Pc=219;continue;}
case 219:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgtsDesc","Ljava/lang/String;",value);f.Pc=222;continue;}
case 222:{f.Pc=256;continue;}
case 225:{f.Push(f.Locals[0]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",229);}
case 229:{f.Push(f.Locals[0]);f.Pc=230;continue;}
case 230:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgts","[Ljava/lang/String;"));f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",236);}
case 236:{f.Push(f.Locals[0]);f.Pc=237;continue;}
case 237:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","maxTargets","Ljava/lang/String;"));f.Pc=240;continue;}
case 240:{f.Push(JValue.R(rt.String("1")));f.Pc=242;continue;}
case 242:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?249:245;continue;}
case 245:{f.Push(JValue.I(1));f.Pc=246;continue;}
case 246:{f.Pc=250;continue;}
case 249:{f.Push(JValue.I(0));f.Pc=250;continue;}
case 250:{return rt.Call(f,"forge/util/Lang","buildValidDesc","(Ljava/util/Collection;Z)Ljava/lang/String;","invokevirtual",253);}
case 253:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgtsDesc","Ljava/lang/String;",value);f.Pc=256;continue;}
case 256:{f.Push(f.Locals[1]);f.Pc=257;continue;}
case 257:{f.Push(JValue.R(rt.String("TgtPrompt")));f.Pc=259;continue;}
case 259:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",264);}
case 264:{f.Pc=f.Pop().Int==0?285:267;continue;}
case 267:{f.Push(f.Locals[0]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[1]);f.Pc=269;continue;}
case 269:{f.Push(JValue.R(rt.String("TgtPrompt")));f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",276);}
case 276:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=279;continue;}
case 279:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","uiPrompt","Ljava/lang/String;",value);f.Pc=282;continue;}
case 282:{f.Pc=323;continue;}
case 285:{f.Push(JValue.R(rt.String("Any")));f.Pc=287;continue;}
case 287:{f.Push(f.Locals[1]);f.Pc=288;continue;}
case 288:{f.Push(JValue.R(rt.String("ValidTgts")));f.Pc=290;continue;}
case 290:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",295);}
case 295:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",298);}
case 298:{f.Pc=f.Pop().Int==0?310:301;continue;}
case 301:{f.Push(f.Locals[0]);f.Pc=302;continue;}
case 302:{f.Push(JValue.R(rt.String("Select any target")));f.Pc=304;continue;}
case 304:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","uiPrompt","Ljava/lang/String;",value);f.Pc=307;continue;}
case 307:{f.Pc=323;continue;}
case 310:{f.Push(f.Locals[0]);f.Pc=311;continue;}
case 311:{f.Push(f.Locals[0]);f.Pc=312;continue;}
case 312:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgtsDesc","Ljava/lang/String;"));f.Pc=315;continue;}
case 315:{return rt.DynamicCall(f,"forge/game/spellability/TargetRestrictions:9741:315:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",320);}
case 320:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","uiPrompt","Ljava/lang/String;",value);f.Pc=323;continue;}
case 323:{f.Push(f.Locals[1]);f.Pc=324;continue;}
case 324:{f.Push(JValue.R(rt.String("TgtZone")));f.Pc=326;continue;}
case 326:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",331);}
case 331:{f.Pc=f.Pop().Int==0?352:334;continue;}
case 334:{f.Push(f.Locals[0]);f.Pc=335;continue;}
case 335:{f.Push(f.Locals[1]);f.Pc=336;continue;}
case 336:{f.Push(JValue.R(rt.String("TgtZone")));f.Pc=338;continue;}
case 338:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",343);}
case 343:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",349);}
case 349:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setZone","(Ljava/util/List;)V","invokevirtual",352);}
case 352:{f.Push(f.Locals[1]);f.Pc=353;continue;}
case 353:{f.Push(JValue.R(rt.String("MaxTotalTargetCMC")));f.Pc=355;continue;}
case 355:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",360);}
case 360:{f.Pc=f.Pop().Int==0?378:363;continue;}
case 363:{f.Push(f.Locals[0]);f.Pc=364;continue;}
case 364:{f.Push(f.Locals[1]);f.Pc=365;continue;}
case 365:{f.Push(JValue.R(rt.String("MaxTotalTargetCMC")));f.Pc=367;continue;}
case 367:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",372);}
case 372:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=375;continue;}
case 375:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setMaxTotalCMC","(Ljava/lang/String;)V","invokevirtual",378);}
case 378:{f.Push(f.Locals[1]);f.Pc=379;continue;}
case 379:{f.Push(JValue.R(rt.String("MaxTotalTargetPower")));f.Pc=381;continue;}
case 381:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",386);}
case 386:{f.Pc=f.Pop().Int==0?404:389;continue;}
case 389:{f.Push(f.Locals[0]);f.Pc=390;continue;}
case 390:{f.Push(f.Locals[1]);f.Pc=391;continue;}
case 391:{f.Push(JValue.R(rt.String("MaxTotalTargetPower")));f.Pc=393;continue;}
case 393:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",398);}
case 398:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=401;continue;}
case 401:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setMaxTotalPower","(Ljava/lang/String;)V","invokevirtual",404);}
case 404:{f.Push(f.Locals[1]);f.Pc=405;continue;}
case 405:{f.Push(JValue.R(rt.String("TargetValidTargeting")));f.Pc=407;continue;}
case 407:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",412);}
case 412:{f.Pc=f.Pop().Int==0?430:415;continue;}
case 415:{f.Push(f.Locals[0]);f.Pc=416;continue;}
case 416:{f.Push(f.Locals[1]);f.Pc=417;continue;}
case 417:{f.Push(JValue.R(rt.String("TargetValidTargeting")));f.Pc=419;continue;}
case 419:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",424);}
case 424:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=427;continue;}
case 427:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setSAValidTargeting","(Ljava/lang/String;)V","invokevirtual",430);}
case 430:{f.Push(f.Locals[1]);f.Pc=431;continue;}
case 431:{f.Push(JValue.R(rt.String("TargetUnique")));f.Pc=433;continue;}
case 433:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",438);}
case 438:{f.Pc=f.Pop().Int==0?446:441;continue;}
case 441:{f.Push(f.Locals[0]);f.Pc=442;continue;}
case 442:{f.Push(JValue.I(1));f.Pc=443;continue;}
case 443:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setUniqueTargets","(Z)V","invokevirtual",446);}
case 446:{f.Push(f.Locals[1]);f.Pc=447;continue;}
case 447:{f.Push(JValue.R(rt.String("TargetsWithoutSameCreatureType")));f.Pc=449;continue;}
case 449:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",454);}
case 454:{f.Pc=f.Pop().Int==0?462:457;continue;}
case 457:{f.Push(f.Locals[0]);f.Pc=458;continue;}
case 458:{f.Push(JValue.I(1));f.Pc=459;continue;}
case 459:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setWithoutSameCreatureType","(Z)V","invokevirtual",462);}
case 462:{f.Push(f.Locals[1]);f.Pc=463;continue;}
case 463:{f.Push(JValue.R(rt.String("TargetsWithSameCreatureType")));f.Pc=466;continue;}
case 466:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",471);}
case 471:{f.Pc=f.Pop().Int==0?479:474;continue;}
case 474:{f.Push(f.Locals[0]);f.Pc=475;continue;}
case 475:{f.Push(JValue.I(1));f.Pc=476;continue;}
case 476:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setWithSameCreatureType","(Z)V","invokevirtual",479);}
case 479:{f.Push(f.Locals[1]);f.Pc=480;continue;}
case 480:{f.Push(JValue.R(rt.String("TargetsWithSameCardType")));f.Pc=483;continue;}
case 483:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",488);}
case 488:{f.Pc=f.Pop().Int==0?496:491;continue;}
case 491:{f.Push(f.Locals[0]);f.Pc=492;continue;}
case 492:{f.Push(JValue.I(1));f.Pc=493;continue;}
case 493:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setWithSameCardType","(Z)V","invokevirtual",496);}
case 496:{f.Push(f.Locals[1]);f.Pc=497;continue;}
case 497:{f.Push(JValue.R(rt.String("TargetsWithSameController")));f.Pc=500;continue;}
case 500:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",505);}
case 505:{f.Pc=f.Pop().Int==0?513:508;continue;}
case 508:{f.Push(f.Locals[0]);f.Pc=509;continue;}
case 509:{f.Push(JValue.I(1));f.Pc=510;continue;}
case 510:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setSameController","(Z)V","invokevirtual",513);}
case 513:{f.Push(f.Locals[1]);f.Pc=514;continue;}
case 514:{f.Push(JValue.R(rt.String("TargetsWithDifferentControllers")));f.Pc=517;continue;}
case 517:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",522);}
case 522:{f.Pc=f.Pop().Int==0?530:525;continue;}
case 525:{f.Push(f.Locals[0]);f.Pc=526;continue;}
case 526:{f.Push(JValue.I(1));f.Pc=527;continue;}
case 527:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setDifferentControllers","(Z)V","invokevirtual",530);}
case 530:{f.Push(f.Locals[1]);f.Pc=531;continue;}
case 531:{f.Push(JValue.R(rt.String("TargetsForEachPlayer")));f.Pc=534;continue;}
case 534:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",539);}
case 539:{f.Pc=f.Pop().Int==0?547:542;continue;}
case 542:{f.Push(f.Locals[0]);f.Pc=543;continue;}
case 543:{f.Push(JValue.I(1));f.Pc=544;continue;}
case 544:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setForEachPlayer","(Z)V","invokevirtual",547);}
case 547:{f.Push(f.Locals[1]);f.Pc=548;continue;}
case 548:{f.Push(JValue.R(rt.String("TargetsWithDifferentCMC")));f.Pc=551;continue;}
case 551:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",556);}
case 556:{f.Pc=f.Pop().Int==0?564:559;continue;}
case 559:{f.Push(f.Locals[0]);f.Pc=560;continue;}
case 560:{f.Push(JValue.I(1));f.Pc=561;continue;}
case 561:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setDifferentCMC","(Z)V","invokevirtual",564);}
case 564:{f.Push(f.Locals[1]);f.Pc=565;continue;}
case 565:{f.Push(JValue.R(rt.String("TargetsWithDifferentNames")));f.Pc=568;continue;}
case 568:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",573);}
case 573:{f.Pc=f.Pop().Int==0?581:576;continue;}
case 576:{f.Push(f.Locals[0]);f.Pc=577;continue;}
case 577:{f.Push(JValue.I(1));f.Pc=578;continue;}
case 578:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setDifferentNames","(Z)V","invokevirtual",581);}
case 581:{f.Push(f.Locals[1]);f.Pc=582;continue;}
case 582:{f.Push(JValue.R(rt.String("TargetsWithEqualToughness")));f.Pc=585;continue;}
case 585:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",590);}
case 590:{f.Pc=f.Pop().Int==0?598:593;continue;}
case 593:{f.Push(f.Locals[0]);f.Pc=594;continue;}
case 594:{f.Push(JValue.I(1));f.Pc=595;continue;}
case 595:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setEqualToughness","(Z)V","invokevirtual",598);}
case 598:{f.Push(f.Locals[1]);f.Pc=599;continue;}
case 599:{f.Push(JValue.R(rt.String("TargetsAtRandom")));f.Pc=602;continue;}
case 602:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",607);}
case 607:{f.Pc=f.Pop().Int==0?615:610;continue;}
case 610:{f.Push(f.Locals[0]);f.Pc=611;continue;}
case 611:{f.Push(JValue.I(1));f.Pc=612;continue;}
case 612:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setRandomTarget","(Z)V","invokevirtual",615);}
case 615:{f.Push(f.Locals[1]);f.Pc=616;continue;}
case 616:{f.Push(JValue.R(rt.String("RandomNumTargets")));f.Pc=619;continue;}
case 619:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",624);}
case 624:{f.Pc=f.Pop().Int==0?632:627;continue;}
case 627:{f.Push(f.Locals[0]);f.Pc=628;continue;}
case 628:{f.Push(JValue.I(1));f.Pc=629;continue;}
case 629:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setRandomNumTargets","(Z)V","invokevirtual",632);}
case 632:{f.Push(f.Locals[1]);f.Pc=633;continue;}
case 633:{f.Push(JValue.R(rt.String("TargetingPlayer")));f.Pc=636;continue;}
case 636:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",641);}
case 641:{f.Pc=f.Pop().Int==0?649:644;continue;}
case 644:{f.Push(f.Locals[0]);f.Pc=645;continue;}
case 645:{f.Push(JValue.I(1));f.Pc=646;continue;}
case 646:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setMandatory","(Z)V","invokevirtual",649);}
case 649:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9742(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","bMandatory","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9743(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","bMandatory","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9744(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","maxTotalCMC","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9745(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","maxTotalPower","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9746(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgts","[Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9747(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgtsDesc","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9748(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","uiPrompt","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9749(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","minTargets","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9750(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","maxTargets","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9751(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","maxTotalCMC","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9752(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","maxTotalCMC","Ljava/lang/String;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9753(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","maxTotalPower","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9754(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","maxTotalPower","Ljava/lang/String;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9755(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","minTargets","Ljava/lang/String;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9756(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","maxTargets","Ljava/lang/String;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9757(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getMaxTargets","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)I","invokevirtual",6);}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/game/spellability/TargetChoices","size","()I","invokevirtual",13);}
case 13:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?20:16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{f.Pc=21;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9758(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getMinTargets","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)I","invokevirtual",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int==0?38:11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDividedAsYouChoose","()Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?40:18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDividedValue","()Ljava/lang/Integer;","invokevirtual",22);}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",26);}
case 26:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int!=0?40:38;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",45);}
case 45:{return rt.Call(f,"forge/game/spellability/TargetChoices","size","()I","invokevirtual",48);}
case 48:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?55:51;continue;}
case 51:{f.Push(JValue.I(1));f.Pc=52;continue;}
case 52:{f.Pc=56;continue;}
case 55:{f.Push(JValue.I(0));f.Pc=56;continue;}
case 56:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9759(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/game/zone/ZoneType;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","tgtZone","Ljava/util/List;",value);f.Pc=15;continue;}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9760(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","tgtZone","Ljava/util/List;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9761(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","tgtZone","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9762(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","saValidTargeting","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9763(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","saValidTargeting","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9764(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgts","[Ljava/lang/String;"));f.Pc=8;continue;}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=11;continue;}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?64:23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=27;continue;}
case 27:{f.Locals[6]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[6]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("Opponent")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?45:40;continue;}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{f.Locals[2]=f.Pop();f.Pc=42;continue;}
case 42:{f.Pc=58;continue;}
case 45:{f.Push(f.Locals[6]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("Player")));f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int==0?58:56;continue;}
case 56:{f.Push(JValue.I(1));f.Pc=57;continue;}
case 57:{f.Locals[1]=f.Pop();f.Pc=58;continue;}
case 58:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=61;continue;}
case 61:{f.Pc=16;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Pc=f.Pop().Int==0?76:68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Pc=f.Pop().Int!=0?76:72;continue;}
case 72:{f.Push(JValue.I(1));f.Pc=73;continue;}
case 73:{f.Pc=77;continue;}
case 76:{f.Push(JValue.I(0));f.Pc=77;continue;}
case 77:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9765(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgts","[Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=7;continue;}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?60:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=18;continue;}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("Player")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int!=0?52:31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("Opponent")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int!=0?52:42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("Any")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int==0?54:52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 54:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=57;continue;}
case 57:{f.Pc=10;continue;}
case 60:{f.Push(JValue.I(0));f.Pc=61;continue;}
case 61:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9766(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgts","[Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=7;continue;}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?39:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=18;continue;}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?33:31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 33:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=36;continue;}
case 36:{f.Pc=10;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9767(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgts","[Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=7;continue;}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?122:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=18;continue;}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("Creature")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int!=0?52:31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int!=0?52:42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("Any")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int==0?65:52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("nonCreature")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int!=0?65:63;continue;}
case 63:{f.Push(JValue.I(1));f.Pc=64;continue;}
case 64:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 65:{f.Push(f.Locals[4]);f.Pc=67;continue;}
case 67:{f.Push(JValue.I(46));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/util/TextUtil","split","(Ljava/lang/CharSequence;C)[Ljava/lang/String;","invokestatic",72);}
case 72:{f.Locals[5]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[5]);f.Pc=76;continue;}
case 76:{f.Locals[6]=f.Pop();f.Pc=78;continue;}
case 78:{f.Push(f.Locals[6]);f.Pc=80;continue;}
case 80:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=81;continue;}
case 81:{f.Locals[7]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{f.Locals[8]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[8]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[7]);f.Pc=90;continue;}
case 90:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?116:93;continue;}
case 93:{f.Push(f.Locals[6]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[8]);f.Pc=97;continue;}
case 97:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=98;continue;}
case 98:{f.Locals[9]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[9]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/card/CardType","isACreatureType","(Ljava/lang/String;)Z","invokestatic",105);}
case 105:{f.Pc=f.Pop().Int==0?110:108;continue;}
case 108:{f.Push(JValue.I(1));f.Pc=109;continue;}
case 109:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 110:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=113;continue;}
case 113:{f.Pc=86;continue;}
case 116:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=119;continue;}
case 119:{f.Pc=10;continue;}
case 122:{f.Push(JValue.I(0));f.Pc=123;continue;}
case 123:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9768(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgts","[Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=7;continue;}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?49:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=18;continue;}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("Planeswalker")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int!=0?41:31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("Any")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?43:41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 43:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=46;continue;}
case 46:{f.Pc=10;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9769(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","applyTargetTextChanges","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",15);}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",19);}
case 19:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",22);}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",31);}
case 31:{f.Pc=f.Pop().Int==0?96:34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=44;continue;}
case 44:{f.Locals[5]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgts","[Ljava/lang/String;"));f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",56);}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/player/Player","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int!=0?67:64;continue;}
case 64:{f.Pc=24;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","canTarget","(Lforge/game/GameObject;)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int!=0?79:76;continue;}
case 76:{f.Pc=24;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",83);}
case 83:{f.Push(f.Locals[5]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/spellability/TargetChoices","contains","(Ljava/lang/Object;)Z","invokevirtual",88);}
case 88:{f.Pc=f.Pop().Int==0?94:91;continue;}
case 91:{f.Pc=24;continue;}
case 94:{f.Push(JValue.I(1));f.Pc=95;continue;}
case 95:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","tgtZone","Ljava/util/List;"));f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",108);}
case 108:{f.Pc=f.Pop().Int==0?113:111;continue;}
case 111:{f.Push(JValue.I(1));f.Pc=112;continue;}
case 112:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 113:{f.Push(f.Locals[3]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","tgtZone","Ljava/util/List;"));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",121);}
case 121:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",126);}
case 126:{f.Locals[4]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[4]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",135);}
case 135:{f.Pc=f.Pop().Int==0?200:138;continue;}
case 138:{f.Push(f.Locals[4]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",145);}
case 145:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=148;continue;}
case 148:{f.Locals[5]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[5]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[0]);f.Pc=153;continue;}
case 153:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgts","[Ljava/lang/String;"));f.Pc=156;continue;}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",160);}
case 160:{f.Push(f.Locals[2]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[1]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/card/Card","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",165);}
case 165:{f.Pc=f.Pop().Int!=0?171:168;continue;}
case 168:{f.Pc=128;continue;}
case 171:{f.Push(f.Locals[1]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[5]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/spellability/SpellAbility","canTarget","(Lforge/game/GameObject;)Z","invokevirtual",177);}
case 177:{f.Pc=f.Pop().Int!=0?183:180;continue;}
case 180:{f.Pc=128;continue;}
case 183:{f.Push(f.Locals[1]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargets","()Lforge/game/spellability/TargetChoices;","invokevirtual",187);}
case 187:{f.Push(f.Locals[5]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/spellability/TargetChoices","contains","(Ljava/lang/Object;)Z","invokevirtual",192);}
case 192:{f.Pc=f.Pop().Int==0?198:195;continue;}
case 195:{f.Pc=128;continue;}
case 198:{f.Push(JValue.I(1));f.Pc=199;continue;}
case 199:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 200:{f.Push(JValue.I(0));f.Pc=201;continue;}
case 201:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9770(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","tgtZone","Ljava/util/List;"));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",14);}
case 14:{f.Pc=f.Pop().Int==0?73:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",21);}
case 21:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",27);}
case 27:{return rt.Call(f,"forge/game/zone/MagicStack","iterator","()Ljava/util/Iterator;","invokevirtual",30);}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?73:40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",46);}
case 46:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbilityStackInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=49;continue;}
case 49:{f.Locals[4]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",56);}
case 56:{f.Locals[5]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[5]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","canTargetSpellAbility","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int==0?70:67;continue;}
case 67:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=70;continue;}
case 70:{f.Pc=31;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getAllCandidates","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokevirtual",79);}
case 79:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",84);}
case 84:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=85;continue;}
case 85:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9771(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","getAllCandidates","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/List;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9772(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",11);}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",20);}
case 20:{f.Locals[5]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[5]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?66:32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=42;continue;}
case 42:{f.Locals[6]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[6]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/SpellAbility","canTarget","(Lforge/game/GameObject;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?63:53;continue;}
case 53:{f.Push(f.Locals[4]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[6]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",62);}
case 62:{f.StackOp("pop");f.Pc=63;continue;}
case 63:{f.Pc=22;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","applyTargetTextChanges","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",71);}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{f.Pc=f.Pop().Int==0?78:75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return JStep.Return(f.Pop());}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","tgtZone","Ljava/util/List;"));f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/Game","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",86);}
case 86:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",91);}
case 91:{f.Locals[5]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[5]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",100);}
case 100:{f.Pc=f.Pop().Int==0?137:103;continue;}
case 103:{f.Push(f.Locals[5]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",110);}
case 110:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=113;continue;}
case 113:{f.Locals[6]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[6]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","canTarget","(Lforge/game/GameObject;)Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int==0?134:124;continue;}
case 124:{f.Push(f.Locals[4]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[6]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",133);}
case 133:{f.StackOp("pop");f.Pc=134;continue;}
case 134:{f.Pc=93;continue;}
case 137:{f.Push(f.Locals[4]);f.Pc=139;continue;}
case 139:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9773(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","uniqueTargets","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9774(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","uniqueTargets","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9775(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","withoutSameCreatureType","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9776(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","withoutSameCreatureType","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9777(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","withSameCreatureType","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9778(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","withSameCreatureType","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9779(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","withSameCardType","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9780(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","withSameCardType","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9781(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Object","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/TargetRestrictions"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Pc=21;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/Object;)V","invokevirtual",21);}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9782(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","randomTarget","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9783(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","randomTarget","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9784(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","randomNumTargets","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9785(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","randomNumTargets","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9786(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","differentCMC","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9787(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","differentCMC","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9788(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","differentNames","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9789(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","differentNames","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9790(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","equalToughness","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9791(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","equalToughness","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9792(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","differentControllers","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9793(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","differentControllers","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9794(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","forEachPlayer","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9795(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","forEachPlayer","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9796(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","sameController","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9797(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/TargetRestrictions","sameController","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9798(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgts","[Ljava/lang/String;"));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=8;continue;}
case 8:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?33:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","validTgts","[Ljava/lang/String;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/TargetRestrictions","originalValidTgts","[Ljava/lang/String;"));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/ability/AbilityUtils","applyAbilityTextChangeEffects","(Ljava/lang/String;Lforge/game/CardTraitBase;)Ljava/lang/String;","invokestatic",26);}
case 26:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=27;continue;}
case 27:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=30;continue;}
case 30:{f.Pc=2;continue;}
case 33:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
