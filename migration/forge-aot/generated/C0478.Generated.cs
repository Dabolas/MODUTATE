// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C478{
internal static JClass Build(){var c=new JClass("forge/game/card/CardView$CardStateView","forge/trackable/TrackableObject",new string[]{"forge/util/ITranslatable"},33);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(6673944200513430607L),null));
c.Add(new JField("state","Lforge/card/CardStateName;",false,JValue.Default("Lforge/card/CardStateName;"),null));
c.Add(new JField("foilIndexOverride","I",false,JValue.Default("I"),null));
c.Add(new JField("this$0","Lforge/game/card/CardView;",false,JValue.Default("Lforge/game/card/CardView;"),null));
c.Add(new JMethod(5640,"forge/game/card/CardView$CardStateView","<init>","(Lforge/game/card/CardView;ILforge/card/CardStateName;Lforge/trackable/Tracker;)V",1,5,3,new JHandler[]{},M5640));
c.Add(new JMethod(5641,"forge/game/card/CardView$CardStateView","getDisplayId","()Ljava/lang/String;",1,2,2,new JHandler[]{},M5641));
c.Add(new JMethod(5642,"forge/game/card/CardView$CardStateView","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M5642));
c.Add(new JMethod(5643,"forge/game/card/CardView$CardStateView","hashCode","()I",1,1,4,new JHandler[]{},M5643));
c.Add(new JMethod(5644,"forge/game/card/CardView$CardStateView","toString","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5644));
c.Add(new JMethod(5645,"forge/game/card/CardView$CardStateView","getCard","()Lforge/game/card/CardView;",1,1,1,new JHandler[]{},M5645));
c.Add(new JMethod(5646,"forge/game/card/CardView$CardStateView","getState","()Lforge/card/CardStateName;",1,1,1,new JHandler[]{},M5646));
c.Add(new JMethod(5647,"forge/game/card/CardView$CardStateView","getName","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5647));
c.Add(new JMethod(5648,"forge/game/card/CardView$CardStateView","updateName","(Lforge/game/card/CardState;)V",0,3,3,new JHandler[]{},M5648));
c.Add(new JMethod(5649,"forge/game/card/CardView$CardStateView","setName","(Ljava/lang/String;)V",2,2,3,new JHandler[]{},M5649));
c.Add(new JMethod(5650,"forge/game/card/CardView$CardStateView","getOracleName","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5650));
c.Add(new JMethod(5651,"forge/game/card/CardView$CardStateView","setOracleName","(Ljava/lang/String;)V",2,2,3,new JHandler[]{},M5651));
c.Add(new JMethod(5652,"forge/game/card/CardView$CardStateView","getColors","()Lforge/card/ColorSet;",1,1,2,new JHandler[]{},M5652));
c.Add(new JMethod(5653,"forge/game/card/CardView$CardStateView","getOriginalColors","()Lforge/card/ColorSet;",1,1,2,new JHandler[]{},M5653));
c.Add(new JMethod(5654,"forge/game/card/CardView$CardStateView","updateColors","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5654));
c.Add(new JMethod(5655,"forge/game/card/CardView$CardStateView","updateColors","(Lforge/game/card/CardState;)V",0,2,3,new JHandler[]{},M5655));
c.Add(new JMethod(5656,"forge/game/card/CardView$CardStateView","setOriginalColors","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5656));
c.Add(new JMethod(5657,"forge/game/card/CardView$CardStateView","updateHasChangeColors","(Z)V",0,2,3,new JHandler[]{},M5657));
c.Add(new JMethod(5658,"forge/game/card/CardView$CardStateView","hasChangeColors","()Z",1,1,2,new JHandler[]{},M5658));
c.Add(new JMethod(5659,"forge/game/card/CardView$CardStateView","getImageKey","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5659));
c.Add(new JMethod(5660,"forge/game/card/CardView$CardStateView","getImageKey","(Ljava/lang/Iterable;)Ljava/lang/String;",1,2,2,new JHandler[]{},M5660));
c.Add(new JMethod(5661,"forge/game/card/CardView$CardStateView","getTrackableImageKey","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5661));
c.Add(new JMethod(5662,"forge/game/card/CardView$CardStateView","updateImageKey","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5662));
c.Add(new JMethod(5663,"forge/game/card/CardView$CardStateView","updateImageKey","(Lforge/game/card/CardState;)V",0,2,3,new JHandler[]{},M5663));
c.Add(new JMethod(5664,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;",1,1,3,new JHandler[]{},M5664));
c.Add(new JMethod(5665,"forge/game/card/CardView$CardStateView","updateType","(Lforge/game/card/CardState;)V",0,2,3,new JHandler[]{},M5665));
c.Add(new JMethod(5666,"forge/game/card/CardView$CardStateView","getManaCost","()Lforge/card/mana/ManaCost;",1,1,2,new JHandler[]{},M5666));
c.Add(new JMethod(5667,"forge/game/card/CardView$CardStateView","getOriginalManaCost","()Lforge/card/mana/ManaCost;",1,1,2,new JHandler[]{},M5667));
c.Add(new JMethod(5668,"forge/game/card/CardView$CardStateView","updateManaCost","(Lforge/game/card/CardState;)V",0,2,3,new JHandler[]{},M5668));
c.Add(new JMethod(5669,"forge/game/card/CardView$CardStateView","updateManaCost","(Lforge/game/card/Card;)V",0,2,3,new JHandler[]{},M5669));
c.Add(new JMethod(5670,"forge/game/card/CardView$CardStateView","getOracleText","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5670));
c.Add(new JMethod(5671,"forge/game/card/CardView$CardStateView","setOracleText","(Ljava/lang/String;)V",0,2,5,new JHandler[]{},M5671));
c.Add(new JMethod(5672,"forge/game/card/CardView$CardStateView","getFunctionalVariantName","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5672));
c.Add(new JMethod(5673,"forge/game/card/CardView$CardStateView","setFunctionalVariantName","(Ljava/lang/String;)V",0,2,3,new JHandler[]{},M5673));
c.Add(new JMethod(5674,"forge/game/card/CardView$CardStateView","getRulesText","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5674));
c.Add(new JMethod(5675,"forge/game/card/CardView$CardStateView","updateRulesText","(Lforge/card/CardRules;)V",0,7,4,new JHandler[]{},M5675));
c.Add(new JMethod(5676,"forge/game/card/CardView$CardStateView","getPower","()I",1,1,2,new JHandler[]{},M5676));
c.Add(new JMethod(5677,"forge/game/card/CardView$CardStateView","updatePower","(Lforge/game/card/Card;)V",0,3,3,new JHandler[]{},M5677));
c.Add(new JMethod(5678,"forge/game/card/CardView$CardStateView","updatePower","(Lforge/game/card/CardState;)V",0,3,3,new JHandler[]{},M5678));
c.Add(new JMethod(5679,"forge/game/card/CardView$CardStateView","getToughness","()I",1,1,2,new JHandler[]{},M5679));
c.Add(new JMethod(5680,"forge/game/card/CardView$CardStateView","updateToughness","(Lforge/game/card/Card;)V",0,3,3,new JHandler[]{},M5680));
c.Add(new JMethod(5681,"forge/game/card/CardView$CardStateView","updateToughness","(Lforge/game/card/CardState;)V",0,3,3,new JHandler[]{},M5681));
c.Add(new JMethod(5682,"forge/game/card/CardView$CardStateView","getLoyalty","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5682));
c.Add(new JMethod(5683,"forge/game/card/CardView$CardStateView","updateLoyalty","(Lforge/game/card/Card;)V",0,2,2,new JHandler[]{},M5683));
c.Add(new JMethod(5684,"forge/game/card/CardView$CardStateView","updateLoyalty","(Ljava/lang/String;)V",0,2,3,new JHandler[]{},M5684));
c.Add(new JMethod(5685,"forge/game/card/CardView$CardStateView","updateLoyalty","(Lforge/game/card/CardState;)V",0,3,3,new JHandler[]{},M5685));
c.Add(new JMethod(5686,"forge/game/card/CardView$CardStateView","getDefense","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5686));
c.Add(new JMethod(5687,"forge/game/card/CardView$CardStateView","updateDefense","(Lforge/game/card/Card;)V",0,2,2,new JHandler[]{},M5687));
c.Add(new JMethod(5688,"forge/game/card/CardView$CardStateView","updateDefense","(Ljava/lang/String;)V",0,2,3,new JHandler[]{},M5688));
c.Add(new JMethod(5689,"forge/game/card/CardView$CardStateView","updateDefense","(Lforge/game/card/CardState;)V",0,3,2,new JHandler[]{},M5689));
c.Add(new JMethod(5690,"forge/game/card/CardView$CardStateView","getAttractionLights","()Ljava/util/Set;",1,1,2,new JHandler[]{},M5690));
c.Add(new JMethod(5691,"forge/game/card/CardView$CardStateView","updateAttractionLights","(Lforge/game/card/CardState;)V",0,2,3,new JHandler[]{},M5691));
c.Add(new JMethod(5692,"forge/game/card/CardView$CardStateView","hasPrintedPT","()Z",1,1,2,new JHandler[]{},M5692));
c.Add(new JMethod(5693,"forge/game/card/CardView$CardStateView","updateHasPrintedPT","(Z)V",0,2,3,new JHandler[]{},M5693));
c.Add(new JMethod(5694,"forge/game/card/CardView$CardStateView","getSetCode","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5694));
c.Add(new JMethod(5695,"forge/game/card/CardView$CardStateView","updateSetCode","(Lforge/game/card/CardState;)V",0,2,3,new JHandler[]{},M5695));
c.Add(new JMethod(5696,"forge/game/card/CardView$CardStateView","getRarity","()Lforge/card/CardRarity;",1,1,2,new JHandler[]{},M5696));
c.Add(new JMethod(5697,"forge/game/card/CardView$CardStateView","updateRarity","(Lforge/game/card/CardState;)V",0,2,3,new JHandler[]{},M5697));
c.Add(new JMethod(5698,"forge/game/card/CardView$CardStateView","getFoilIndex","()I",1,1,2,new JHandler[]{},M5698));
c.Add(new JMethod(5699,"forge/game/card/CardView$CardStateView","updateFoilIndex","(Lforge/game/card/Card;)V",0,2,2,new JHandler[]{},M5699));
}

private static void Add1(JClass c){
c.Add(new JMethod(5700,"forge/game/card/CardView$CardStateView","updateFoilIndex","(Lforge/game/card/CardState;)V",0,2,3,new JHandler[]{},M5700));
c.Add(new JMethod(5701,"forge/game/card/CardView$CardStateView","setFoilIndexOverride","(I)V",1,2,3,new JHandler[]{},M5701));
c.Add(new JMethod(5702,"forge/game/card/CardView$CardStateView","getKeywords","()Lforge/game/keyword/KeywordCollectionView;",1,1,2,new JHandler[]{},M5702));
c.Add(new JMethod(5703,"forge/game/card/CardView$CardStateView","hasKeyword","(Lforge/game/keyword/Keyword;)Z",1,2,2,new JHandler[]{},M5703));
c.Add(new JMethod(5704,"forge/game/card/CardView$CardStateView","hasAnnihilator","()Z",1,1,2,new JHandler[]{},M5704));
c.Add(new JMethod(5705,"forge/game/card/CardView$CardStateView","hasWard","()Z",1,1,2,new JHandler[]{},M5705));
c.Add(new JMethod(5706,"forge/game/card/CardView$CardStateView","hasDeathtouch","()Z",1,1,2,new JHandler[]{},M5706));
c.Add(new JMethod(5707,"forge/game/card/CardView$CardStateView","hasDevoid","()Z",1,1,2,new JHandler[]{},M5707));
c.Add(new JMethod(5708,"forge/game/card/CardView$CardStateView","hasTrample","()Z",1,1,2,new JHandler[]{},M5708));
c.Add(new JMethod(5709,"forge/game/card/CardView$CardStateView","hasHaste","()Z",1,1,2,new JHandler[]{},M5709));
c.Add(new JMethod(5710,"forge/game/card/CardView$CardStateView","hasInfect","()Z",1,1,2,new JHandler[]{},M5710));
c.Add(new JMethod(5711,"forge/game/card/CardView$CardStateView","hasStorm","()Z",1,1,2,new JHandler[]{},M5711));
c.Add(new JMethod(5712,"forge/game/card/CardView$CardStateView","hasAftermath","()Z",1,1,2,new JHandler[]{},M5712));
c.Add(new JMethod(5713,"forge/game/card/CardView$CardStateView","hasDivideDamage","()Z",1,1,2,new JHandler[]{},M5713));
c.Add(new JMethod(5714,"forge/game/card/CardView$CardStateView","origProduceAnyMana","()Z",1,1,2,new JHandler[]{},M5714));
c.Add(new JMethod(5715,"forge/game/card/CardView$CardStateView","origProduceMana","()Lforge/card/ColorSet;",1,1,2,new JHandler[]{},M5715));
c.Add(new JMethod(5716,"forge/game/card/CardView$CardStateView","getAbilityText","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5716));
c.Add(new JMethod(5717,"forge/game/card/CardView$CardStateView","updateAbilityText","(Lforge/game/card/Card;Lforge/game/card/CardState;)V",0,3,4,new JHandler[]{},M5717));
c.Add(new JMethod(5718,"forge/game/card/CardView$CardStateView","updateKeywords","(Lforge/game/card/Card;Lforge/game/card/CardState;)V",0,3,5,new JHandler[]{},M5718));
c.Add(new JMethod(5719,"forge/game/card/CardView$CardStateView","updateManaColorBG","(Lforge/game/card/CardState;)V",0,16,3,new JHandler[]{},M5719));
c.Add(new JMethod(5720,"forge/game/card/CardView$CardStateView","isBasicLand","()Z",1,1,1,new JHandler[]{},M5720));
c.Add(new JMethod(5721,"forge/game/card/CardView$CardStateView","isCreature","()Z",1,1,1,new JHandler[]{},M5721));
c.Add(new JMethod(5722,"forge/game/card/CardView$CardStateView","isLand","()Z",1,1,1,new JHandler[]{},M5722));
c.Add(new JMethod(5723,"forge/game/card/CardView$CardStateView","isPlane","()Z",1,1,1,new JHandler[]{},M5723));
c.Add(new JMethod(5724,"forge/game/card/CardView$CardStateView","isPhenomenon","()Z",1,1,1,new JHandler[]{},M5724));
c.Add(new JMethod(5725,"forge/game/card/CardView$CardStateView","isPlaneswalker","()Z",1,1,1,new JHandler[]{},M5725));
c.Add(new JMethod(5726,"forge/game/card/CardView$CardStateView","isBattle","()Z",1,1,1,new JHandler[]{},M5726));
c.Add(new JMethod(5727,"forge/game/card/CardView$CardStateView","isVehicle","()Z",1,1,2,new JHandler[]{},M5727));
c.Add(new JMethod(5728,"forge/game/card/CardView$CardStateView","isArtifact","()Z",1,1,1,new JHandler[]{},M5728));
c.Add(new JMethod(5729,"forge/game/card/CardView$CardStateView","isEnchantment","()Z",1,1,1,new JHandler[]{},M5729));
c.Add(new JMethod(5730,"forge/game/card/CardView$CardStateView","isSpaceCraft","()Z",1,1,2,new JHandler[]{},M5730));
c.Add(new JMethod(5731,"forge/game/card/CardView$CardStateView","isAttraction","()Z",1,1,1,new JHandler[]{},M5731));
c.Add(new JMethod(5732,"forge/game/card/CardView$CardStateView","isContraption","()Z",1,1,1,new JHandler[]{},M5732));
c.Add(new JMethod(5733,"forge/game/card/CardView$CardStateView","isInstant","()Z",1,1,1,new JHandler[]{},M5733));
c.Add(new JMethod(5734,"forge/game/card/CardView$CardStateView","isSorcery","()Z",1,1,1,new JHandler[]{},M5734));
c.Add(new JMethod(5735,"forge/game/card/CardView$CardStateView","getTranslationKey","()Ljava/lang/String;",1,3,2,new JHandler[]{},M5735));
c.Add(new JMethod(5736,"forge/game/card/CardView$CardStateView","getUntranslatedType","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5736));
c.Add(new JMethod(5737,"forge/game/card/CardView$CardStateView","getTranslatedName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5737));
c.Add(new JMethod(5738,"forge/game/card/CardView$CardStateView","lambda$updateKeywords$1","(Lforge/game/trigger/Trigger;)Z",4106,1,2,new JHandler[]{},M5738));
c.Add(new JMethod(5739,"forge/game/card/CardView$CardStateView","lambda$updateKeywords$0","(Lforge/game/trigger/Trigger;)Z",4106,1,2,new JHandler[]{},M5739));
}

internal static JStep M5640(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardView$CardStateView","this$0","Lforge/game/card/CardView;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[4]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/trackable/TrackableObject","<init>","(ILforge/trackable/Tracker;)V","invokespecial",12);}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.I(-1));f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardView$CardStateView","foilIndexOverride","I",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardView$CardStateView","state","Lforge/card/CardStateName;",value);f.Pc=22;continue;}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5641(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getState","()Lforge/card/CardStateName;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/card/CardStateName","FaceDown","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","FaceDown","Lforge/card/CardStateName;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardStateName","equals","(Ljava/lang/Object;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?26:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView$CardStateView","this$0","Lforge/game/card/CardView;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/CardView","getHiddenId","()I","invokevirtual",20);}
case 20:{return rt.DynamicCall(f,"forge/game/card/CardView$CardStateView:5641:20:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",25);}
case 25:{return JStep.Return(f.Pop());}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getId","()I","invokevirtual",30);}
case 30:{f.Locals[1]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Pc=f.Pop().Int<=0?43:35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getId","()I","invokevirtual",39);}
case 39:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",42);}
case 42:{return JStep.Return(f.Pop());}
case 43:{f.Push(JValue.R(rt.String("")));f.Pc=45;continue;}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5642(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/Object","hashCode","()I","invokevirtual",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardView$CardStateView","hashCode","()I","invokevirtual",14);}
case 14:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?28:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/CardView$CardStateView")?1:0));f.Pc=21;continue;}
case 21:{f.Pc=f.Pop().Int==0?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5643(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(2));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getId","()I","invokevirtual",10);}
case 10:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",13);}
case 13:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView$CardStateView","state","Lforge/card/CardStateName;"));f.Pc=20;continue;}
case 20:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Objects","hash","([Ljava/lang/Object;)I","invokestatic",24);}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5644(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getDisplayId","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.DynamicCall(f,"forge/game/card/CardView$CardStateView:5644:8:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",13);}
case 13:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5645(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView$CardStateView","this$0","Lforge/game/card/CardView;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5646(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView$CardStateView","state","Lforge/card/CardStateName;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5647(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Name","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Name","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5648(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getDisplayName","(Lforge/game/card/CardState;)Ljava/lang/String;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView$CardStateView","setName","(Ljava/lang/String;)V","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","getName","(Lforge/game/card/CardState;)Ljava/lang/String;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/game/card/CardView$CardStateView","setOracleName","(Ljava/lang/String;)V","invokevirtual",23);}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView$CardStateView","this$0","Lforge/game/card/CardView;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",30);}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?42:34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView$CardStateView","this$0","Lforge/game/card/CardView;"));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/CardView","updateName","(Lforge/game/GameEntity;)V","invokevirtual",42);}
case 42:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5649(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Name","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Name","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5650(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OracleName","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OracleName","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5651(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OracleName","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OracleName","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5652(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Colors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Colors","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ColorSet"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5653(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OriginalColors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OriginalColors","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ColorSet"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5654(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Colors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Colors","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5655(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Colors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Colors","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardState","getColor","()Lforge/card/ColorSet;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5656(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OriginalColors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OriginalColors","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5657(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasChangedColors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasChangedColors","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5658(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasChangedColors","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasChangedColors","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5659(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getImageKey","(Ljava/lang/Iterable;)Ljava/lang/String;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5660(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getState","()Lforge/card/CardStateName;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/card/CardStateName","FaceDown","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","FaceDown","Lforge/card/CardStateName;"));f.Pc=7;continue;}
case 7:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?18:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getCard","()Lforge/game/card/CardView;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/card/CardView","getFacedownImageKey","()Ljava/lang/String;","invokevirtual",17);}
case 17:{return JStep.Return(f.Pop());}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView$CardStateView","this$0","Lforge/game/card/CardView;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/CardView","canBeShownToAny","(Ljava/lang/Iterable;)Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int==0?74:29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView$CardStateView","this$0","Lforge/game/card/CardView;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/CardView","isCloned","()Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int==0?63:39;continue;}
case 39:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",42);}
case 42:{return rt.Call(f,"forge/StaticData","useSourceImageForClone","()Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?63:48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView$CardStateView","this$0","Lforge/game/card/CardView;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/card/CardView","getBackup","()Lforge/game/card/CardView;","invokevirtual",55);}
case 55:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",58);}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getImageKey","(Ljava/lang/Iterable;)Ljava/lang/String;","invokevirtual",62);}
case 62:{return JStep.Return(f.Pop());}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ImageKey","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ImageKey","Lforge/trackable/TrackableProperty;"));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",70);}
case 70:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=73;continue;}
case 73:{return JStep.Return(f.Pop());}
case 74:{f.Push(JValue.R(rt.String("hidden")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/ImageKeys","getTokenKey","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",79);}
case 79:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5661(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ImageKey","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ImageKey","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5662(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ImageKey","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ImageKey","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5663(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ImageKey","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ImageKey","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardState","getImageKey","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5664(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getState","()Lforge/card/CardStateName;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/card/CardStateName","Original","Lforge/card/CardStateName;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardStateName","Original","Lforge/card/CardStateName;"));f.Pc=7;continue;}
case 7:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?43:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView$CardStateView","this$0","Lforge/game/card/CardView;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/CardView","isFaceDown","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?43:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView$CardStateView","this$0","Lforge/game/card/CardView;"));f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",33);}
case 33:{return rt.Call(f,"forge/game/card/CardView","isInZone","(Ljava/lang/Iterable;)Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int!=0?43:39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/card/CardType","EMPTY","Lforge/card/CardTypeView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType","EMPTY","Lforge/card/CardTypeView;"));f.Pc=42;continue;}
case 42:{return JStep.Return(f.Pop());}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Type","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Type","Lforge/trackable/TrackableProperty;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",50);}
case 50:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardTypeView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=53;continue;}
case 53:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5665(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Type","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Type","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardState","getTypeWithChanges","()Lforge/card/CardTypeView;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5666(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ManaCost","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ManaCost","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCost"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5667(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OriginalManaCost","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OriginalManaCost","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/mana/ManaCost"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5668(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ManaCost","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ManaCost","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardState","getPerpetualAdjustedManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OriginalManaCost","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OriginalManaCost","Lforge/trackable/TrackableProperty;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardState","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",19);}
case 19:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",22);}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5669(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ManaCost","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ManaCost","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardState","getPerpetualAdjustedManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OriginalManaCost","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OriginalManaCost","Lforge/trackable/TrackableProperty;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",22);}
case 22:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",25);}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5670(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OracleText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OracleText","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5671(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OracleText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OracleText","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("\\n")));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("\r\n\r\n")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",14);}
case 14:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",20);}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5672(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","FunctionalVariant","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","FunctionalVariant","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5673(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","FunctionalVariant","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","FunctionalVariant","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5674(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","RulesText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","RulesText","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5675(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Reference==null?134:6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/card/CardType","isVanguard","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?134:16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/card/CardRules","getHand","()I","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int>=0?27:23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Pc=28;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/CardRules","getLife","()I","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int>=0?40:36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{f.Pc=41;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",46);}
case 46:{f.Push(JValue.R(rt.String("lblHandSize")));f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("Hand Size")));f.Pc=52;continue;}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/util/Localizer","getMessageorUseDefault","(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",59);}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{f.Pc=f.Pop().Int!=0?69:63;continue;}
case 63:{f.Push(JValue.R(rt.String(": +")));f.Pc=66;continue;}
case 66:{f.Pc=72;continue;}
case 69:{f.Push(JValue.R(rt.String(": ")));f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/card/CardRules","getHand","()I","invokevirtual",76);}
case 76:{return rt.DynamicCall(f,"forge/game/card/CardView$CardStateView:5675:76:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;",81);}
case 81:{f.Locals[5]=f.Pop();f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",86);}
case 86:{f.Push(JValue.R(rt.String("lblStartingLife")));f.Pc=89;continue;}
case 89:{f.Push(JValue.R(rt.String("Starting Life")));f.Pc=92;continue;}
case 92:{f.Push(JValue.I(0));f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/util/Localizer","getMessageorUseDefault","(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",99);}
case 99:{f.Push(f.Locals[4]);f.Pc=101;continue;}
case 101:{f.Pc=f.Pop().Int!=0?110:104;continue;}
case 104:{f.Push(JValue.R(rt.String(": +")));f.Pc=107;continue;}
case 107:{f.Pc=113;continue;}
case 110:{f.Push(JValue.R(rt.String(": ")));f.Pc=113;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/card/CardRules","getLife","()I","invokevirtual",117);}
case 117:{return rt.DynamicCall(f,"forge/game/card/CardView$CardStateView:5675:117:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;",122);}
case 122:{f.Locals[6]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[5]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[6]);f.Pc=128;continue;}
case 128:{return rt.DynamicCall(f,"forge/game/card/CardView$CardStateView:5675:128:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",133);}
case 133:{f.Locals[2]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","RulesText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","RulesText","Lforge/trackable/TrackableProperty;"));f.Pc=138;continue;}
case 138:{f.Push(f.Locals[2]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",142);}
case 142:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5676(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Power","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Power","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5677(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","hasPrintedPT","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?22:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardView$CardStateView","isCreature","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?22:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","getCurrentPower","()I","invokevirtual",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Pc=27;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/card/CardState","getView","()Lforge/game/card/CardView$CardStateView;","invokevirtual",34);}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?60:38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/Card","getAlternateState","()Lforge/game/card/CardState;","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Reference==null?60:45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/Card","getBasePower","()I","invokevirtual",50);}
case 50:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/card/Card","getAlternateState","()Lforge/game/card/CardState;","invokevirtual",55);}
case 55:{return rt.Call(f,"forge/game/card/CardState","getBasePower","()I","invokevirtual",58);}
case 58:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=59;continue;}
case 59:{f.Locals[2]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Power","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Power","Lforge/trackable/TrackableProperty;"));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",68);}
case 68:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",71);}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView$CardStateView","this$0","Lforge/game/card/CardView;"));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/card/CardView","updateLethalDamage","(Lforge/game/card/Card;)V","invokevirtual",79);}
case 79:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5678(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?15:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updatePower","(Lforge/game/card/Card;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Power","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Power","Lforge/trackable/TrackableProperty;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardState","getBasePower","()I","invokevirtual",23);}
case 23:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",26);}
case 26:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",29);}
case 29:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5679(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Toughness","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Toughness","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5680(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","hasPrintedPT","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?22:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardView$CardStateView","isCreature","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int!=0?22:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","getCurrentToughness","()I","invokevirtual",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Pc=27;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/card/CardState","getView","()Lforge/game/card/CardView$CardStateView;","invokevirtual",34);}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?60:38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/Card","getAlternateState","()Lforge/game/card/CardState;","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Reference==null?60:45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/Card","getBaseToughness","()I","invokevirtual",50);}
case 50:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/card/Card","getAlternateState","()Lforge/game/card/CardState;","invokevirtual",55);}
case 55:{return rt.Call(f,"forge/game/card/CardState","getBaseToughness","()I","invokevirtual",58);}
case 58:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=59;continue;}
case 59:{f.Locals[2]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Toughness","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Toughness","Lforge/trackable/TrackableProperty;"));f.Pc=64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",68);}
case 68:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",71);}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView$CardStateView","this$0","Lforge/game/card/CardView;"));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/card/CardView","updateLethalDamage","(Lforge/game/card/Card;)V","invokevirtual",79);}
case 79:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5681(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference==null?15:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateToughness","(Lforge/game/card/Card;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Toughness","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Toughness","Lforge/trackable/TrackableProperty;"));f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardState","getBaseToughness","()I","invokevirtual",23);}
case 23:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",26);}
case 26:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",29);}
case 29:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5682(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Loyalty","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Loyalty","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5683(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?24:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/Card","getCurrentLoyalty","()I","invokevirtual",15);}
case 15:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",18);}
case 18:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateLoyalty","(Ljava/lang/String;)V","invokevirtual",21);}
case 21:{f.Pc=35;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/game/card/CardState","getBaseLoyalty","()Ljava/lang/String;","invokevirtual",32);}
case 32:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateLoyalty","(Ljava/lang/String;)V","invokevirtual",35);}
case 35:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5684(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Loyalty","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Loyalty","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5685(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView$CardStateView","this$0","Lforge/game/card/CardView;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?47:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Reference==null?47:20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?38:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateLoyalty","(Lforge/game/card/Card;)V","invokevirtual",35);}
case 35:{f.Pc=46;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/CardState","getBaseLoyalty","()Ljava/lang/String;","invokevirtual",43);}
case 43:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateLoyalty","(Ljava/lang/String;)V","invokevirtual",46);}
case 46:{return JStep.ReturnVoid;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Loyalty","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Loyalty","Lforge/trackable/TrackableProperty;"));f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("0")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",57);}
case 57:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5686(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Defense","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Defense","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5687(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?24:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/Card","getCurrentDefense","()I","invokevirtual",15);}
case 15:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",18);}
case 18:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateDefense","(Ljava/lang/String;)V","invokevirtual",21);}
case 21:{f.Pc=35;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/game/card/CardState","getBaseDefense","()Ljava/lang/String;","invokevirtual",32);}
case 32:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateDefense","(Ljava/lang/String;)V","invokevirtual",35);}
case 35:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5688(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Defense","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Defense","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5689(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView$CardStateView","this$0","Lforge/game/card/CardView;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView","getCurrentState","()Lforge/game/card/CardView$CardStateView;","invokevirtual",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?47:11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Reference==null?47:20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?38:30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateDefense","(Lforge/game/card/Card;)V","invokevirtual",35);}
case 35:{f.Pc=46;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/CardState","getBaseDefense","()Ljava/lang/String;","invokevirtual",43);}
case 43:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateDefense","(Ljava/lang/String;)V","invokevirtual",46);}
case 46:{return JStep.ReturnVoid;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(JValue.R(rt.String("0")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateDefense","(Ljava/lang/String;)V","invokevirtual",54);}
case 54:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5690(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttractionLights","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttractionLights","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5691(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttractionLights","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttractionLights","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardState","getAttractionLights","()Ljava/util/Set;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5692(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasPrintedPT","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasPrintedPT","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5693(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasPrintedPT","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasPrintedPT","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5694(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SetCode","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SetCode","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5695(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SetCode","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SetCode","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardState","getSetCode","()Ljava/lang/String;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5696(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Rarity","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Rarity","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRarity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5697(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Rarity","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Rarity","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardState","getRarity","()Lforge/card/CardRarity;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5698(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView$CardStateView","foilIndexOverride","I"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int<0?12:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardView$CardStateView","foilIndexOverride","I"));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","FoilIndex","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","FoilIndex","Lforge/trackable/TrackableProperty;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",19);}
case 19:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",25);}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5699(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateFoilIndex","(Lforge/game/card/CardState;)V","invokevirtual",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5700(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","FoilIndex","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","FoilIndex","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardState","getFoil","()I","invokevirtual",8);}
case 8:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",11);}
case 11:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",14);}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5701(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(-2));f.Pc=3;continue;}
case 3:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?21:6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",10);}
case 10:{f.Push(JValue.I(50));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",15);}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardView$CardStateView","foilIndexOverride","I",value);f.Pc=20;continue;}
case 20:{return JStep.ReturnVoid;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Int>=0?33:25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getSetCode","()Ljava/lang/String;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/card/CardEdition","getRandomFoil","(Ljava/lang/String;)I","invokestatic",32);}
case 32:{f.Locals[1]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardView$CardStateView","foilIndexOverride","I",value);f.Pc=38;continue;}
case 38:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5702(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Keywords","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Keywords","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordCollectionView"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5703(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getKeywords","()Lforge/game/keyword/KeywordCollectionView;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/keyword/KeywordCollectionView","contains","(Lforge/game/keyword/Keyword;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5704(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasAnnihilator","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasAnnihilator","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5705(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasWard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasWard","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5706(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","DEATHTOUCH","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","DEATHTOUCH","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5707(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","DEVOID","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","DEVOID","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5708(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","TRAMPLE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","TRAMPLE","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5709(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","HASTE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","HASTE","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5710(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","INFECT","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","INFECT","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5711(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","STORM","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","STORM","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5712(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","AFTERMATH","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","AFTERMATH","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5713(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasDivideDamage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasDivideDamage","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5714(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OrigProduceAnyMana","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OrigProduceAnyMana","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Boolean"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5715(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OrigProduceMana","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OrigProduceMana","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ColorSet"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5716(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AbilityText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AbilityText","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardView$CardStateView","get","(Lforge/trackable/TrackableProperty;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5717(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AbilityText","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AbilityText","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getAbilityText","(Lforge/game/card/CardState;)Ljava/lang/String;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",12);}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5718(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","updateKeywordsCache","(Lforge/game/card/CardState;)V","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Keywords","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Keywords","Lforge/trackable/TrackableProperty;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/card/CardState","getCachedKeywords","()Lforge/game/keyword/KeywordCollection;","invokevirtual",13);}
case 13:{return rt.Call(f,"forge/game/keyword/KeywordCollection","getView","()Lforge/game/keyword/KeywordCollectionView;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasAnnihilator","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasAnnihilator","Lforge/trackable/TrackableProperty;"));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","ANNIHILATOR","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","ANNIHILATOR","Lforge/game/keyword/Keyword;"));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;Lforge/game/card/CardState;)Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int!=0?51:34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/CardState","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",38);}
case 38:{return rt.DynamicCall(f,"forge/game/card/CardView$CardStateView:5718:38:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",43);}
case 43:{return rt.Call(f,"forge/util/collect/FCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",48);}
case 48:{f.Pc=f.Pop().Int==0?55:51;continue;}
case 51:{f.Push(JValue.I(1));f.Pc=52;continue;}
case 52:{f.Pc=56;continue;}
case 55:{f.Push(JValue.I(0));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",59);}
case 59:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",62);}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasWard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasWard","Lforge/trackable/TrackableProperty;"));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","WARD","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","WARD","Lforge/game/keyword/Keyword;"));f.Pc=70;continue;}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;Lforge/game/card/CardState;)Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int!=0?94:77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/card/CardState","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",81);}
case 81:{return rt.DynamicCall(f,"forge/game/card/CardView$CardStateView:5718:81:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",86);}
case 86:{return rt.Call(f,"forge/util/collect/FCollectionView","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",91);}
case 91:{f.Pc=f.Pop().Int==0?98:94;continue;}
case 94:{f.Push(JValue.I(1));f.Pc=95;continue;}
case 95:{f.Pc=99;continue;}
case 98:{f.Push(JValue.I(0));f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",102);}
case 102:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",105);}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[1]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[2]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateAbilityText","(Lforge/game/card/Card;Lforge/game/card/CardState;)V","invokevirtual",111);}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[2]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/card/CardView$CardStateView","updateManaColorBG","(Lforge/game/card/CardState;)V","invokevirtual",116);}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","HasDivideDamage","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","HasDivideDamage","Lforge/trackable/TrackableProperty;"));f.Pc=120;continue;}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("You may assign CARDNAME's combat damage divided as you choose among defending player and/or any number of creatures they control.")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",127);}
case 127:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",130);}
case 130:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",133);}
case 133:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5719(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{f.Locals[4]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardState","getManaAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",16);}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?414:28;continue;}
case 28:{f.Push(f.Locals[5]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{f.Pc=f.Pop().Reference!=null?48:45;continue;}
case 45:{f.Pc=18;continue;}
case 48:{f.Push(f.Locals[6]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAllManaParts","()Ljava/util/List;","invokevirtual",53);}
case 53:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",58);}
case 58:{f.Locals[7]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[7]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",67);}
case 67:{f.Pc=f.Pop().Int==0?411:70;continue;}
case 70:{f.Push(f.Locals[7]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",77);}
case 77:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilityManaPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=80;continue;}
case 80:{f.Locals[8]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[8]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isAnyMana","()Z","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int==0?95:90;continue;}
case 90:{f.Push(JValue.I(1));f.Pc=91;continue;}
case 91:{f.Locals[2]=f.Pop();f.Pc=92;continue;}
case 92:{f.Pc=60;continue;}
case 95:{f.Push(f.Locals[8]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[6]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","mana","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",102);}
case 102:{f.Push(JValue.R(rt.String(" ")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",108);}
case 108:{f.Locals[9]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[9]);f.Pc=112;continue;}
case 112:{f.Locals[10]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[10]);f.Pc=116;continue;}
case 116:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=117;continue;}
case 117:{f.Locals[11]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(JValue.I(0));f.Pc=120;continue;}
case 120:{f.Locals[12]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[12]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[11]);f.Pc=126;continue;}
case 126:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?408:129;continue;}
case 129:{f.Push(f.Locals[10]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[12]);f.Pc=133;continue;}
case 133:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=134;continue;}
case 134:{f.Locals[13]=f.Pop();f.Pc=136;continue;}
case 136:{f.Push(f.Locals[13]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/lang/String","toUpperCase","()Ljava/lang/String;","invokevirtual",141);}
case 141:{f.Locals[14]=f.Pop();f.Pc=143;continue;}
case 143:{f.Push(JValue.I(-1));f.Pc=144;continue;}
case 144:{f.Locals[15]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[14]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",151);}
case 151:{switch(f.Pop().Int){case 66:f.Pc=242;break;case 67:f.Pc=293;break;case 71:f.Pc=225;break;case 82:f.Pc=208;break;case 85:f.Pc=259;break;case 87:f.Pc=276;break;default:f.Pc=307;break;}continue;}
case 208:{f.Push(f.Locals[14]);f.Pc=210;continue;}
case 210:{f.Push(JValue.R(rt.String("R")));f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",216);}
case 216:{f.Pc=f.Pop().Int==0?307:219;continue;}
case 219:{f.Push(JValue.I(0));f.Pc=220;continue;}
case 220:{f.Locals[15]=f.Pop();f.Pc=222;continue;}
case 222:{f.Pc=307;continue;}
case 225:{f.Push(f.Locals[14]);f.Pc=227;continue;}
case 227:{f.Push(JValue.R(rt.String("G")));f.Pc=230;continue;}
case 230:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",233);}
case 233:{f.Pc=f.Pop().Int==0?307:236;continue;}
case 236:{f.Push(JValue.I(1));f.Pc=237;continue;}
case 237:{f.Locals[15]=f.Pop();f.Pc=239;continue;}
case 239:{f.Pc=307;continue;}
case 242:{f.Push(f.Locals[14]);f.Pc=244;continue;}
case 244:{f.Push(JValue.R(rt.String("B")));f.Pc=247;continue;}
case 247:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",250);}
case 250:{f.Pc=f.Pop().Int==0?307:253;continue;}
case 253:{f.Push(JValue.I(2));f.Pc=254;continue;}
case 254:{f.Locals[15]=f.Pop();f.Pc=256;continue;}
case 256:{f.Pc=307;continue;}
case 259:{f.Push(f.Locals[14]);f.Pc=261;continue;}
case 261:{f.Push(JValue.R(rt.String("U")));f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",267);}
case 267:{f.Pc=f.Pop().Int==0?307:270;continue;}
case 270:{f.Push(JValue.I(3));f.Pc=271;continue;}
case 271:{f.Locals[15]=f.Pop();f.Pc=273;continue;}
case 273:{f.Pc=307;continue;}
case 276:{f.Push(f.Locals[14]);f.Pc=278;continue;}
case 278:{f.Push(JValue.R(rt.String("W")));f.Pc=281;continue;}
case 281:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",284);}
case 284:{f.Pc=f.Pop().Int==0?307:287;continue;}
case 287:{f.Push(JValue.I(4));f.Pc=288;continue;}
case 288:{f.Locals[15]=f.Pop();f.Pc=290;continue;}
case 290:{f.Pc=307;continue;}
case 293:{f.Push(f.Locals[14]);f.Pc=295;continue;}
case 295:{f.Push(JValue.R(rt.String("C")));f.Pc=298;continue;}
case 298:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",301);}
case 301:{f.Pc=f.Pop().Int==0?307:304;continue;}
case 304:{f.Push(JValue.I(5));f.Pc=305;continue;}
case 305:{f.Locals[15]=f.Pop();f.Pc=307;continue;}
case 307:{f.Push(f.Locals[15]);f.Pc=309;continue;}
case 309:{switch(f.Pop().Int){case 0:f.Pc=348;break;case 1:f.Pc=359;break;case 2:f.Pc=370;break;case 3:f.Pc=380;break;case 4:f.Pc=390;break;case 5:f.Pc=400;break;default:f.Pc=402;break;}continue;}
case 348:{f.Push(f.Locals[4]);f.Pc=350;continue;}
case 350:{f.Push(JValue.I(8));f.Pc=352;continue;}
case 352:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=353;continue;}
case 353:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=354;continue;}
case 354:{f.Locals[4]=f.Pop();f.Pc=356;continue;}
case 356:{f.Pc=402;continue;}
case 359:{f.Push(f.Locals[4]);f.Pc=361;continue;}
case 361:{f.Push(JValue.I(16));f.Pc=363;continue;}
case 363:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=364;continue;}
case 364:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=365;continue;}
case 365:{f.Locals[4]=f.Pop();f.Pc=367;continue;}
case 367:{f.Pc=402;continue;}
case 370:{f.Push(f.Locals[4]);f.Pc=372;continue;}
case 372:{f.Push(JValue.I(4));f.Pc=373;continue;}
case 373:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=374;continue;}
case 374:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=375;continue;}
case 375:{f.Locals[4]=f.Pop();f.Pc=377;continue;}
case 377:{f.Pc=402;continue;}
case 380:{f.Push(f.Locals[4]);f.Pc=382;continue;}
case 382:{f.Push(JValue.I(2));f.Pc=383;continue;}
case 383:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=384;continue;}
case 384:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=385;continue;}
case 385:{f.Locals[4]=f.Pop();f.Pc=387;continue;}
case 387:{f.Pc=402;continue;}
case 390:{f.Push(f.Locals[4]);f.Pc=392;continue;}
case 392:{f.Push(JValue.I(1));f.Pc=393;continue;}
case 393:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=394;continue;}
case 394:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=395;continue;}
case 395:{f.Locals[4]=f.Pop();f.Pc=397;continue;}
case 397:{f.Pc=402;continue;}
case 400:{f.Push(JValue.I(1));f.Pc=401;continue;}
case 401:{f.Locals[3]=f.Pop();f.Pc=402;continue;}
case 402:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=405;continue;}
case 405:{f.Pc=122;continue;}
case 408:{f.Pc=60;continue;}
case 411:{f.Pc=18;continue;}
case 414:{f.Push(f.Locals[0]);f.Pc=415;continue;}
case 415:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OrigProduceMana","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OrigProduceMana","Lforge/trackable/TrackableProperty;"));f.Pc=418;continue;}
case 418:{f.Push(f.Locals[4]);f.Pc=420;continue;}
case 420:{f.Pc=f.Pop().Int<=0?431:423;continue;}
case 423:{f.Push(f.Locals[4]);f.Pc=425;continue;}
case 425:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",428);}
case 428:{f.Pc=442;continue;}
case 431:{f.Push(f.Locals[3]);f.Pc=432;continue;}
case 432:{f.Pc=f.Pop().Int==0?441:435;continue;}
case 435:{if(!rt.StaticReady(f,"forge/card/ColorSet","C","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","C","Lforge/card/ColorSet;"));f.Pc=438;continue;}
case 438:{f.Pc=442;continue;}
case 441:{f.Push(JValue.R(null));f.Pc=442;continue;}
case 442:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",445);}
case 445:{f.Push(f.Locals[0]);f.Pc=446;continue;}
case 446:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","OrigProduceAnyMana","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","OrigProduceAnyMana","Lforge/trackable/TrackableProperty;"));f.Pc=449;continue;}
case 449:{f.Push(f.Locals[2]);f.Pc=450;continue;}
case 450:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",453);}
case 453:{return rt.Call(f,"forge/game/card/CardView$CardStateView","set","(Lforge/trackable/TrackableProperty;Ljava/lang/Object;)V","invokevirtual",456);}
case 456:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5720(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardTypeView","isBasicLand","()Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5721(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardTypeView","isCreature","()Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5722(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardTypeView","isLand","()Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5723(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardTypeView","isPlane","()Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5724(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardTypeView","isPhenomenon","()Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5725(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardTypeView","isPlaneswalker","()Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5726(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardTypeView","isBattle","()Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5727(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String("Vehicle")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5728(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardTypeView","isArtifact","()Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5729(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardTypeView","isEnchantment","()Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5730(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String("Spacecraft")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5731(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardTypeView","isAttraction","()Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5732(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardTypeView","isContraption","()Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5733(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardTypeView","isInstant","()Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5734(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/CardTypeView","isSorcery","()Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5735(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getFunctionalVariantName","()Ljava/lang/String;","invokevirtual",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNotEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",14);}
case 14:{f.Pc=f.Pop().Int==0?25:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.DynamicCall(f,"forge/game/card/CardView$CardStateView:5735:19:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",24);}
case 24:{f.Locals[1]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5736(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardView$CardStateView","getType","()Lforge/card/CardTypeView;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5737(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedName","(Lforge/util/ITranslatable;)Ljava/lang/String;","invokestatic",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5738(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","WARD","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","WARD","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5739(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","ANNIHILATOR","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","ANNIHILATOR","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
