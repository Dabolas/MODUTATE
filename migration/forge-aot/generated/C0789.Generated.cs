// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C789{
internal static JClass Build(){var c=new JClass("forge/game/spellability/AbilityManaPart","java/lang/Object",new string[]{"java/io/Serializable"},33);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(-6816356991224950520L),null));
c.Add(new JField("origProduced","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("lastExpressChoice","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("manaRestrictions","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("extraManaRestrictions","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("cannotCounterSpell","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("addsKeywords","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("addsKeywordsType","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("addsKeywordsUntil","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("addsCounters","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("triggersWhenSpent","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("persistentMana","Z",false,JValue.Default("Z"),null));
c.Add(new JField("combatMana","Z",false,JValue.Default("Z"),null));
c.Add(new JField("lastManaProduced","Lcom/google/common/collect/Multiset;",false,JValue.Default("Lcom/google/common/collect/Multiset;"),null));
c.Add(new JField("sourceCard","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("sVarHolder","Lforge/game/IHasSVars;",false,JValue.Default("Lforge/game/IHasSVars;"),null));
c.Add(new JMethod(9082,"forge/game/spellability/AbilityManaPart","<init>","(Lforge/game/spellability/SpellAbility;Ljava/util/Map;)V",1,3,3,new JHandler[]{},M9082));
c.Add(new JMethod(9083,"forge/game/spellability/AbilityManaPart","<init>","(Lforge/game/card/Card;Ljava/util/Map;)V",1,3,4,new JHandler[]{},M9083));
c.Add(new JMethod(9084,"forge/game/spellability/AbilityManaPart","<init>","(Lforge/game/card/Card;Lforge/game/spellability/AbilityManaPart;)V",1,3,2,new JHandler[]{},M9084));
c.Add(new JMethod(9085,"forge/game/spellability/AbilityManaPart","produceMana","(Lforge/game/spellability/SpellAbility;)V",17,2,4,new JHandler[]{},M9085));
c.Add(new JMethod(9086,"forge/game/spellability/AbilityManaPart","produceMana","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",17,15,6,new JHandler[]{},M9086));
c.Add(new JMethod(9087,"forge/game/spellability/AbilityManaPart","tapsForMana","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)V",1,4,4,new JHandler[]{},M9087));
c.Add(new JMethod(9088,"forge/game/spellability/AbilityManaPart","cannotCounterPaidWith","(Lforge/game/spellability/SpellAbility;)Z",1,3,5,new JHandler[]{},M9088));
c.Add(new JMethod(9089,"forge/game/spellability/AbilityManaPart","isCannotCounterPaidWith","()Z",1,1,2,new JHandler[]{},M9089));
c.Add(new JMethod(9090,"forge/game/spellability/AbilityManaPart","addNoCounterEffect","(Lforge/game/spellability/SpellAbility;)V",1,6,4,new JHandler[]{},M9090));
c.Add(new JMethod(9091,"forge/game/spellability/AbilityManaPart","addKeywords","(Lforge/game/spellability/SpellAbility;)Z",1,2,1,new JHandler[]{},M9091));
c.Add(new JMethod(9092,"forge/game/spellability/AbilityManaPart","getAddsKeywordsType","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9092));
c.Add(new JMethod(9093,"forge/game/spellability/AbilityManaPart","getAddsKeywordsUntil","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9093));
c.Add(new JMethod(9094,"forge/game/spellability/AbilityManaPart","getKeywords","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9094));
c.Add(new JMethod(9095,"forge/game/spellability/AbilityManaPart","addsCounters","(Lforge/game/spellability/SpellAbility;)Z",1,2,1,new JHandler[]{},M9095));
c.Add(new JMethod(9096,"forge/game/spellability/AbilityManaPart","createETBCounters","(Lforge/game/card/Card;Lforge/game/player/Player;)V",1,4,6,new JHandler[]{},M9096));
c.Add(new JMethod(9097,"forge/game/spellability/AbilityManaPart","getTriggersWhenSpent","()Z",1,1,1,new JHandler[]{},M9097));
c.Add(new JMethod(9098,"forge/game/spellability/AbilityManaPart","addTriggersWhenSpent","(Lforge/game/spellability/SpellAbility;)V",1,3,4,new JHandler[]{},M9098));
c.Add(new JMethod(9099,"forge/game/spellability/AbilityManaPart","getSourceSA","()Lforge/game/spellability/SpellAbility;",1,1,1,new JHandler[]{},M9099));
c.Add(new JMethod(9100,"forge/game/spellability/AbilityManaPart","getManaRestrictions","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9100));
c.Add(new JMethod(9101,"forge/game/spellability/AbilityManaPart","setExtraManaRestriction","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M9101));
c.Add(new JMethod(9102,"forge/game/spellability/AbilityManaPart","getExtraManaRestriction","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9102));
c.Add(new JMethod(9103,"forge/game/spellability/AbilityManaPart","meetsManaRestrictions","(Lforge/game/spellability/SpellAbility;)Z",1,2,3,new JHandler[]{},M9103));
c.Add(new JMethod(9104,"forge/game/spellability/AbilityManaPart","meetsManaRestrictions","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z",1,11,5,new JHandler[]{},M9104));
c.Add(new JMethod(9105,"forge/game/spellability/AbilityManaPart","meetsManaShardRestrictions","(Lforge/card/mana/ManaCostShard;B)Z",1,7,2,new JHandler[]{},M9105));
c.Add(new JMethod(9106,"forge/game/spellability/AbilityManaPart","meetsSpellAndShardRestrictions","(Lforge/game/spellability/SpellAbility;Lforge/card/mana/ManaCostShard;B)Z",1,4,3,new JHandler[]{},M9106));
c.Add(new JMethod(9107,"forge/game/spellability/AbilityManaPart","mana","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",17,3,4,new JHandler[]{},M9107));
c.Add(new JMethod(9108,"forge/game/spellability/AbilityManaPart","setExpressChoice","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M9108));
c.Add(new JMethod(9109,"forge/game/spellability/AbilityManaPart","setExpressChoice","(Lforge/card/ColorSet;)V",1,3,2,new JHandler[]{},M9109));
c.Add(new JMethod(9110,"forge/game/spellability/AbilityManaPart","getExpressChoice","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9110));
c.Add(new JMethod(9111,"forge/game/spellability/AbilityManaPart","clearExpressChoice","()V",1,1,2,new JHandler[]{},M9111));
c.Add(new JMethod(9112,"forge/game/spellability/AbilityManaPart","getLastManaProduced","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M9112));
c.Add(new JMethod(9113,"forge/game/spellability/AbilityManaPart","isSnow","()Z",17,1,1,new JHandler[]{},M9113));
c.Add(new JMethod(9114,"forge/game/spellability/AbilityManaPart","isAnyMana","()Z",1,1,2,new JHandler[]{},M9114));
c.Add(new JMethod(9115,"forge/game/spellability/AbilityManaPart","isComboMana","()Z",1,1,2,new JHandler[]{},M9115));
c.Add(new JMethod(9116,"forge/game/spellability/AbilityManaPart","isSpecialMana","()Z",1,1,2,new JHandler[]{},M9116));
c.Add(new JMethod(9117,"forge/game/spellability/AbilityManaPart","canProduce","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z",17,3,2,new JHandler[]{},M9117));
c.Add(new JMethod(9118,"forge/game/spellability/AbilityManaPart","equals","(Ljava/lang/Object;)Z",17,3,2,new JHandler[]{},M9118));
c.Add(new JMethod(9119,"forge/game/spellability/AbilityManaPart","hashCode","()I",1,1,3,new JHandler[]{},M9119));
c.Add(new JMethod(9120,"forge/game/spellability/AbilityManaPart","getOrigProduced","()Ljava/lang/String;",1,1,1,new JHandler[]{},M9120));
c.Add(new JMethod(9121,"forge/game/spellability/AbilityManaPart","getComboColors","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,10,4,new JHandler[]{},M9121));
c.Add(new JMethod(9122,"forge/game/spellability/AbilityManaPart","getChosenColor","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,6,2,new JHandler[]{},M9122));
c.Add(new JMethod(9123,"forge/game/spellability/AbilityManaPart","getSourceCard","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M9123));
c.Add(new JMethod(9124,"forge/game/spellability/AbilityManaPart","setSourceCard","(Lforge/game/card/Card;)V",1,2,2,new JHandler[]{},M9124));
c.Add(new JMethod(9125,"forge/game/spellability/AbilityManaPart","isPersistentMana","()Z",1,1,1,new JHandler[]{},M9125));
c.Add(new JMethod(9126,"forge/game/spellability/AbilityManaPart","isCombatMana","()Z",1,1,1,new JHandler[]{},M9126));
c.Add(new JMethod(9127,"forge/game/spellability/AbilityManaPart","abilityProducesManaColor","(Lforge/game/spellability/SpellAbility;B)Z",0,11,4,new JHandler[]{},M9127));
c.Add(new JMethod(9128,"forge/game/spellability/AbilityManaPart","lambda$getComboColors$2","(Lforge/card/MagicColor$Color;)Ljava/lang/String;",4106,1,1,new JHandler[]{},M9128));
c.Add(new JMethod(9129,"forge/game/spellability/AbilityManaPart","lambda$produceMana$1","(Lforge/game/card/Card;Lforge/game/player/Player;Ljava/lang/Byte;)Lforge/game/mana/Mana;",4098,4,6,new JHandler[]{},M9129));
}

private static void Add1(JClass c){
c.Add(new JMethod(9130,"forge/game/spellability/AbilityManaPart","lambda$produceMana$0","(Lforge/game/card/Card;Lforge/game/player/Player;Ljava/lang/Byte;)Lforge/game/mana/Mana;",4098,4,6,new JHandler[]{},M9130));
}

internal static JStep M9082(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","<init>","(Lforge/game/card/Card;Ljava/util/Map;)V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","sVarHolder","Lforge/game/IHasSVars;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9083(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("")));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","lastExpressChoice","Ljava/lang/String;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("")));f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","extraManaRestrictions","Ljava/lang/String;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","()Lcom/google/common/collect/HashMultiset;","invokestatic",20);}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","lastManaProduced","Lcom/google/common/collect/Multiset;",value);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","sourceCard","Lforge/game/card/Card;",value);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","sVarHolder","Lforge/game/IHasSVars;",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("Produced")));f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("1")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","origProduced","Ljava/lang/String;",value);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("RestrictValid")));f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Map","getOrDefault","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",61);}
case 61:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=64;continue;}
case 64:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","manaRestrictions","Ljava/lang/String;",value);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("AddsNoCounter")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",76);}
case 76:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=79;continue;}
case 79:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","cannotCounterSpell","Ljava/lang/String;",value);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("AddsKeywords")));f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",91);}
case 91:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=94;continue;}
case 94:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","addsKeywords","Ljava/lang/String;",value);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("AddsKeywordsValid")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",106);}
case 106:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=109;continue;}
case 109:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","addsKeywordsType","Ljava/lang/String;",value);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[0]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[2]);f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("AddsKeywordsUntil")));f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",121);}
case 121:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=124;continue;}
case 124:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","addsKeywordsUntil","Ljava/lang/String;",value);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[2]);f.Pc=129;continue;}
case 129:{f.Push(JValue.R(rt.String("AddsCounters")));f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",136);}
case 136:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=139;continue;}
case 139:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","addsCounters","Ljava/lang/String;",value);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[2]);f.Pc=144;continue;}
case 144:{f.Push(JValue.R(rt.String("TriggersWhenSpent")));f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",151);}
case 151:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=154;continue;}
case 154:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","triggersWhenSpent","Ljava/lang/String;",value);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[2]);f.Pc=159;continue;}
case 159:{f.Push(JValue.R(rt.String("PersistentMana")));f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",166);}
case 166:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","persistentMana","Z",value);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[0]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[2]);f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.String("CombatMana")));f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",178);}
case 178:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","combatMana","Z",value);f.Pc=181;continue;}
case 181:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9084(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("")));f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","lastExpressChoice","Ljava/lang/String;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("")));f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","extraManaRestrictions","Ljava/lang/String;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"com/google/common/collect/HashMultiset","create","()Lcom/google/common/collect/HashMultiset;","invokestatic",20);}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","lastManaProduced","Lcom/google/common/collect/Multiset;",value);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","sourceCard","Lforge/game/card/Card;",value);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","origProduced","Ljava/lang/String;"));f.Pc=33;continue;}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","origProduced","Ljava/lang/String;",value);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","manaRestrictions","Ljava/lang/String;"));f.Pc=41;continue;}
case 41:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","manaRestrictions","Ljava/lang/String;",value);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","cannotCounterSpell","Ljava/lang/String;"));f.Pc=49;continue;}
case 49:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","cannotCounterSpell","Ljava/lang/String;",value);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","addsKeywords","Ljava/lang/String;"));f.Pc=57;continue;}
case 57:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","addsKeywords","Ljava/lang/String;",value);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","addsKeywordsType","Ljava/lang/String;"));f.Pc=65;continue;}
case 65:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","addsKeywordsType","Ljava/lang/String;",value);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","addsKeywordsUntil","Ljava/lang/String;"));f.Pc=73;continue;}
case 73:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","addsKeywordsUntil","Ljava/lang/String;",value);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","addsCounters","Ljava/lang/String;"));f.Pc=81;continue;}
case 81:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","addsCounters","Ljava/lang/String;",value);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","triggersWhenSpent","Ljava/lang/String;"));f.Pc=89;continue;}
case 89:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","triggersWhenSpent","Ljava/lang/String;",value);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","persistentMana","Z"));f.Pc=97;continue;}
case 97:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","persistentMana","Z",value);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","combatMana","Z"));f.Pc=105;continue;}
case 105:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","combatMana","Z",value);f.Pc=108;continue;}
case 108:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9085(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getOrigProduced","()Ljava/lang/String;","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceCard","()Lforge/game/card/Card;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",12);}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","produceMana","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",16);}
case 16:{f.StackOp("pop");f.Pc=17;continue;}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9086(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",10);}
case 10:{f.Locals[5]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",16);}
case 16:{f.Locals[6]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Locals[7]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Reference!=null?29:25;continue;}
case 25:{f.Push(JValue.R(null));f.Pc=26;continue;}
case 26:{f.Pc=33;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",33);}
case 33:{f.Locals[8]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[8]);f.Pc=37;continue;}
case 37:{f.Pc=f.Pop().Reference==null?172:40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",45);}
case 45:{f.Locals[9]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[9]);f.Pc=49;continue;}
case 49:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"));f.Pc=52;continue;}
case 52:{f.Push(f.Locals[7]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{f.Push(f.Locals[9]);f.Pc=62;continue;}
case 62:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=65;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",71);}
case 71:{f.StackOp("pop");f.Pc=72;continue;}
case 72:{f.Push(f.Locals[9]);f.Pc=74;continue;}
case 74:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AbilityMana","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AbilityMana","Lforge/game/ability/AbilityKey;"));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[8]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",84);}
case 84:{f.StackOp("pop");f.Pc=85;continue;}
case 85:{f.Push(f.Locals[9]);f.Pc=87;continue;}
case 87:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"));f.Pc=90;continue;}
case 90:{f.Push(f.Locals[8]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",95);}
case 95:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",100);}
case 100:{f.StackOp("pop");f.Pc=101;continue;}
case 101:{if(!rt.StaticReady(f,"forge/game/spellability/AbilityManaPart$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AbilityManaPart$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"));f.Pc=104;continue;}
case 104:{f.Push(f.Locals[6]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",109);}
case 109:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","ProduceMana","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","ProduceMana","Lforge/game/replacement/ReplacementType;"));f.Pc=112;continue;}
case 112:{f.Push(f.Locals[9]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",117);}
case 117:{return rt.Call(f,"forge/game/replacement/ReplacementResult","ordinal","()I","invokevirtual",120);}
case 120:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=121;continue;}
case 121:{switch(f.Pop().Int){case 1:f.Pc=148;break;case 2:f.Pc=151;break;default:f.Pc=169;break;}continue;}
case 148:{f.Pc=172;continue;}
case 151:{f.Push(f.Locals[9]);f.Pc=153;continue;}
case 153:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"));f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",161);}
case 161:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=164;continue;}
case 164:{f.Locals[7]=f.Pop();f.Pc=166;continue;}
case 166:{f.Pc=172;continue;}
case 169:{f.Push(JValue.R(rt.String("")));f.Pc=171;continue;}
case 171:{return JStep.Return(f.Pop());}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","lastManaProduced","Lcom/google/common/collect/Multiset;"));f.Pc=176;continue;}
case 176:{return rt.Call(f,"com/google/common/collect/Multiset","clear","()V","invokeinterface",181);}
case 181:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",184);}
case 184:{f.Locals[9]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(f.Locals[7]);f.Pc=188;continue;}
case 188:{f.Push(JValue.R(rt.String(" ")));f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",193);}
case 193:{f.Locals[10]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[10]);f.Pc=197;continue;}
case 197:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=198;continue;}
case 198:{f.Locals[11]=f.Pop();f.Pc=200;continue;}
case 200:{f.Push(JValue.I(0));f.Pc=201;continue;}
case 201:{f.Locals[12]=f.Pop();f.Pc=203;continue;}
case 203:{f.Push(f.Locals[12]);f.Pc=205;continue;}
case 205:{f.Push(f.Locals[11]);f.Pc=207;continue;}
case 207:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?323:210;continue;}
case 210:{f.Push(f.Locals[10]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[12]);f.Pc=214;continue;}
case 214:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=215;continue;}
case 215:{f.Locals[13]=f.Pop();f.Pc=217;continue;}
case 217:{f.Push(f.Locals[13]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",222);}
case 222:{f.Pc=f.Pop().Int==0?267:225;continue;}
case 225:{f.Push(f.Locals[0]);f.Pc=226;continue;}
case 226:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","lastManaProduced","Lcom/google/common/collect/Multiset;"));f.Pc=229;continue;}
case 229:{f.Push(f.Locals[9]);f.Pc=231;continue;}
case 231:{f.Push(JValue.I(32));f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/lang/Byte","valueOf","(B)Ljava/lang/Byte;","invokestatic",236);}
case 236:{f.Push(f.Locals[0]);f.Pc=237;continue;}
case 237:{f.Push(f.Locals[4]);f.Pc=239;continue;}
case 239:{f.Push(f.Locals[2]);f.Pc=240;continue;}
case 240:{return rt.DynamicCall(f,"forge/game/spellability/AbilityManaPart:9086:240:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/spellability/AbilityManaPart;Lforge/game/card/Card;Lforge/game/player/Player;)Ljava/util/function/Function;",245);}
case 245:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",250);}
case 250:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[13]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",258);}
case 258:{return rt.Call(f,"com/google/common/collect/Multiset","add","(Ljava/lang/Object;I)I","invokeinterface",263);}
case 263:{f.StackOp("pop");f.Pc=264;continue;}
case 264:{f.Pc=317;continue;}
case 267:{f.Push(f.Locals[13]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",272);}
case 272:{f.Locals[14]=f.Pop();f.Pc=274;continue;}
case 274:{f.Push(f.Locals[14]);f.Pc=276;continue;}
case 276:{f.Pc=f.Pop().Int!=0?283:279;continue;}
case 279:{f.Push(JValue.I(32));f.Pc=281;continue;}
case 281:{f.Locals[14]=f.Pop();f.Pc=283;continue;}
case 283:{f.Push(f.Locals[0]);f.Pc=284;continue;}
case 284:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","lastManaProduced","Lcom/google/common/collect/Multiset;"));f.Pc=287;continue;}
case 287:{f.Push(f.Locals[9]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[14]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"java/lang/Byte","valueOf","(B)Ljava/lang/Byte;","invokestatic",294);}
case 294:{f.Push(f.Locals[0]);f.Pc=295;continue;}
case 295:{f.Push(f.Locals[4]);f.Pc=297;continue;}
case 297:{f.Push(f.Locals[2]);f.Pc=298;continue;}
case 298:{return rt.DynamicCall(f,"forge/game/spellability/AbilityManaPart:9086:298:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/spellability/AbilityManaPart;Lforge/game/card/Card;Lforge/game/player/Player;)Ljava/util/function/Function;",303);}
case 303:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",308);}
case 308:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=311;continue;}
case 311:{return rt.Call(f,"com/google/common/collect/Multiset","add","(Ljava/lang/Object;)Z","invokeinterface",316);}
case 316:{f.StackOp("pop");f.Pc=317;continue;}
case 317:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=320;continue;}
case 320:{f.Pc=203;continue;}
case 323:{f.Push(f.Locals[5]);f.Pc=325;continue;}
case 325:{f.Push(f.Locals[0]);f.Pc=326;continue;}
case 326:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","lastManaProduced","Lcom/google/common/collect/Multiset;"));f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/game/mana/ManaPool","addMana","(Ljava/lang/Iterable;)V","invokevirtual",332);}
case 332:{f.Push(f.Locals[4]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",337);}
case 337:{f.Locals[10]=f.Pop();f.Pc=339;continue;}
case 339:{f.Push(f.Locals[10]);f.Pc=341;continue;}
case 341:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=344;continue;}
case 344:{f.Push(f.Locals[2]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",350);}
case 350:{f.StackOp("pop");f.Pc=351;continue;}
case 351:{f.Push(f.Locals[10]);f.Pc=353;continue;}
case 353:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"));f.Pc=356;continue;}
case 356:{f.Push(f.Locals[7]);f.Pc=358;continue;}
case 358:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",363);}
case 363:{f.StackOp("pop");f.Pc=364;continue;}
case 364:{f.Push(f.Locals[10]);f.Pc=366;continue;}
case 366:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AbilityMana","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AbilityMana","Lforge/game/ability/AbilityKey;"));f.Pc=369;continue;}
case 369:{f.Push(f.Locals[8]);f.Pc=371;continue;}
case 371:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",376);}
case 376:{f.StackOp("pop");f.Pc=377;continue;}
case 377:{f.Push(f.Locals[10]);f.Pc=379;continue;}
case 379:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"));f.Pc=382;continue;}
case 382:{f.Push(f.Locals[8]);f.Pc=384;continue;}
case 384:{f.Pc=f.Pop().Reference!=null?391:387;continue;}
case 387:{f.Push(JValue.R(null));f.Pc=388;continue;}
case 388:{f.Pc=396;continue;}
case 391:{f.Push(f.Locals[8]);f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",396);}
case 396:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",401);}
case 401:{f.StackOp("pop");f.Pc=402;continue;}
case 402:{f.Push(f.Locals[6]);f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",407);}
case 407:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ManaAdded","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ManaAdded","Lforge/game/trigger/TriggerType;"));f.Pc=410;continue;}
case 410:{f.Push(f.Locals[10]);f.Pc=412;continue;}
case 412:{f.Push(JValue.I(0));f.Pc=413;continue;}
case 413:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",416);}
case 416:{f.Push(f.Locals[7]);f.Pc=418;continue;}
case 418:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9087(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","isManaAbility","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?24:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Reference==null?24:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/game/cost/Cost","hasTapCost","()Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int!=0?25:24;continue;}
case 24:{return JStep.ReturnVoid;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceCard","()Lforge/game/card/Card;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/game/card/Card","isLand","()Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?43:35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",39);}
case 39:{f.Push(JValue.I(1));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/player/Player","setTappedLandForManaThisTurn","(Z)V","invokevirtual",43);}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceCard","()Lforge/game/card/Card;","invokevirtual",47);}
case 47:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromCard","(Lforge/game/card/Card;)Ljava/util/Map;","invokestatic",50);}
case 50:{f.Locals[3]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Produced","Lforge/game/ability/AbilityKey;"));f.Pc=55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",61);}
case 61:{f.StackOp("pop");f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AbilityMana","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AbilityMana","Lforge/game/ability/AbilityKey;"));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",72);}
case 72:{f.StackOp("pop");f.Pc=73;continue;}
case 73:{f.Push(f.Locals[3]);f.Pc=74;continue;}
case 74:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",81);}
case 81:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",86);}
case 86:{f.StackOp("pop");f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceCard","()Lforge/game/card/Card;","invokevirtual",91);}
case 91:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",94);}
case 94:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",97);}
case 97:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TapsForMana","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TapsForMana","Lforge/game/trigger/TriggerType;"));f.Pc=100;continue;}
case 100:{f.Push(f.Locals[3]);f.Pc=101;continue;}
case 101:{f.Push(JValue.I(0));f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",105);}
case 105:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9088(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","cannotCounterSpell","Ljava/lang/String;"));f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?10:8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10:{f.Push(JValue.R(rt.String("True")));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","cannotCounterSpell","Ljava/lang/String;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?25:23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",29);}
case 29:{f.Locals[2]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Pc=f.Pop().Reference!=null?36:34;continue;}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","cannotCounterSpell","Ljava/lang/String;"));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","sourceCard","Lforge/game/card/Card;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",48);}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","sourceCard","Lforge/game/card/Card;"));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(null));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/Card","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",56);}
case 56:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9089(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","cannotCounterSpell","Ljava/lang/String;"));f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?12:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Pc=13;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9090(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","sourceCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"forge/game/card/Card"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/Card")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/Game","nextCardId","()I","invokevirtual",16);}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/game/Game;)V","invokespecial",20);}
case 20:{f.Locals[3]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/game/card/Card","setGameTimestamp","(J)V","invokevirtual",29);}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","sourceCard","Lforge/game/card/Card;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",37);}
case 37:{return rt.DynamicCall(f,"forge/game/spellability/AbilityManaPart:9090:37:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",42);}
case 42:{return rt.Call(f,"forge/game/card/Card","setName","(Ljava/lang/String;)V","invokevirtual",45);}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","sourceCard","Lforge/game/card/Card;"));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",53);}
case 53:{return rt.Call(f,"forge/game/card/Card","setOwner","(Lforge/game/player/Player;)V","invokevirtual",56);}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","sourceCard","Lforge/game/card/Card;"));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",64);}
case 64:{return rt.Call(f,"forge/game/card/Card","setImageKey","(Ljava/lang/String;)V","invokevirtual",67);}
case 67:{f.Push(f.Locals[3]);f.Pc=68;continue;}
case 68:{if(!rt.StaticReady(f,"forge/card/ColorSet","C","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","C","Lforge/card/ColorSet;"));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/Card","setColor","(Lforge/card/ColorSet;)V","invokevirtual",74);}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{if(!rt.StaticReady(f,"forge/card/GamePieceType","EFFECT","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","EFFECT","Lforge/card/GamePieceType;"));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/card/Card","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",81);}
case 81:{f.Push(JValue.R(rt.String("Event$ Counter | ValidSA$ Spell.IsRemembered | Description$ That spell can't be countered.")));f.Pc=84;continue;}
case 84:{f.Locals[4]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[4]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[3]);f.Pc=89;continue;}
case 89:{f.Push(JValue.I(1));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",93);}
case 93:{f.Locals[5]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[5]);f.Pc=97;continue;}
case 97:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","CantHappen","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","CantHappen","Lforge/game/replacement/ReplacementLayer;"));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setLayer","(Lforge/game/replacement/ReplacementLayer;)V","invokevirtual",103);}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[5]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/card/Card","addReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)Lforge/game/replacement/ReplacementEffect;","invokevirtual",109);}
case 109:{f.StackOp("pop");f.Pc=110;continue;}
case 110:{f.Push(f.Locals[3]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",115);}
case 115:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",118);}
case 118:{f.Push(f.Locals[3]);f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("Stack")));f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","addForgetOnMovedTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",125);}
case 125:{f.Push(f.Locals[2]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",129);}
case 129:{f.Push(f.Locals[3]);f.Pc=130;continue;}
case 130:{f.Push(JValue.R(null));f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",134);}
case 134:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9091(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","addsKeywords","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9092(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","addsKeywordsType","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9093(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","addsKeywordsUntil","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9094(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","addsKeywords","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9095(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","addsCounters","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9096(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","addsCounters","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("_")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[3]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",19);}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(null));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/Card","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?43:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","sourceCard","Lforge/game/card/Card;"));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[3]);f.Pc=34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{f.Push(JValue.I(2));f.Pc=38;continue;}
case 38:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/GameActionUtil","createETBCountersEffect","(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Lforge/game/card/Card;","invokestatic",42);}
case 42:{f.StackOp("pop");f.Pc=43;continue;}
case 43:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9097(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","triggersWhenSpent","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9098(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","sVarHolder","Lforge/game/IHasSVars;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","triggersWhenSpent","Ljava/lang/String;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/IHasSVars","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokeinterface",13);}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","sourceCard","Lforge/game/card/Card;"));f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","sVarHolder","Lforge/game/IHasSVars;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/trigger/Trigger;","invokestatic",25);}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/trigger/Trigger","addRemembered","(Ljava/lang/Object;)V","invokevirtual",31);}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Reference==null?46:38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",43);}
case 43:{return rt.Call(f,"forge/game/trigger/Trigger","setSpawningAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",46);}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",50);}
case 50:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",53);}
case 53:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",56);}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/trigger/TriggerHandler","registerThisTurnDelayedTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",60);}
case 60:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9099(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","sVarHolder","Lforge/game/IHasSVars;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/SpellAbility")?1:0));f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Int==0?20:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","sVarHolder","Lforge/game/IHasSVars;"));f.Pc=14;continue;}
case 14:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=17;continue;}
case 17:{f.Pc=21;continue;}
case 20:{f.Push(JValue.R(null));f.Pc=21;continue;}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9100(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","manaRestrictions","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9101(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","extraManaRestrictions","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9102(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","extraManaRestrictions","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9103(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","manaRestrictions","Ljava/lang/String;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","meetsManaRestrictions","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?28:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","extraManaRestrictions","Ljava/lang/String;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","meetsManaRestrictions","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9104(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String(",")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=19;continue;}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{f.Locals[5]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?385:31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=35;continue;}
case 35:{f.Locals[6]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[6]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("nonSpell")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?61:48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int!=0?59:55;continue;}
case 55:{f.Push(JValue.I(1));f.Pc=56;continue;}
case 56:{f.Pc=60;continue;}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 61:{f.Push(f.Locals[6]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("CumulativeUpkeep")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int==0?81:72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCumulativeUpkeep","()Z","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int==0?379:79;continue;}
case 79:{f.Push(JValue.I(1));f.Pc=80;continue;}
case 80:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 81:{f.Push(f.Locals[6]);f.Pc=83;continue;}
case 83:{f.Push(JValue.R(rt.String("CostContains")));f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int==0?207:92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",96);}
case 96:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",99);}
case 99:{f.Locals[7]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayCosts","()Lforge/game/cost/Cost;","invokevirtual",105);}
case 105:{f.Locals[8]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[7]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",112);}
case 112:{return rt.Call(f,"forge/game/zone/MagicStack","isResolving","()Z","invokevirtual",115);}
case 115:{f.Pc=f.Pop().Int==0?142:118;continue;}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("UnlessCost")));f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",125);}
case 125:{f.Pc=f.Pop().Int==0?142:128;continue;}
case 128:{f.Push(f.Locals[1]);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("UnlessCost")));f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",136);}
case 136:{f.Push(JValue.I(0));f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateUnlessCost","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Z)Lforge/game/cost/Cost;","invokestatic",140);}
case 140:{f.Locals[8]=f.Pop();f.Pc=142;continue;}
case 142:{f.Push(f.Locals[8]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/cost/Cost","hasNoManaCost","()Z","invokevirtual",147);}
case 147:{f.Pc=f.Pop().Int==0?153:150;continue;}
case 150:{f.Pc=379;continue;}
case 153:{f.Push(f.Locals[6]);f.Pc=155;continue;}
case 155:{f.Push(JValue.R(rt.String("X")));f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",161);}
case 161:{f.Pc=f.Pop().Int==0?177:164;continue;}
case 164:{f.Push(f.Locals[8]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",169);}
case 169:{return rt.Call(f,"forge/game/cost/CostPartMana","getAmountOfX","()I","invokevirtual",172);}
case 172:{f.Pc=f.Pop().Int<=0?177:175;continue;}
case 175:{f.Push(JValue.I(1));f.Pc=176;continue;}
case 176:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 177:{f.Push(f.Locals[6]);f.Pc=179;continue;}
case 179:{f.Push(JValue.R(rt.String("C")));f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",185);}
case 185:{f.Pc=f.Pop().Int==0?379:188;continue;}
case 188:{f.Push(f.Locals[8]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",193);}
case 193:{return rt.Call(f,"forge/game/cost/CostPartMana","getMana","()Lforge/card/mana/ManaCost;","invokevirtual",196);}
case 196:{if(!rt.StaticReady(f,"forge/card/mana/ManaCostShard","COLORLESS","Lforge/card/mana/ManaCostShard;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCostShard","COLORLESS","Lforge/card/mana/ManaCostShard;"));f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/card/mana/ManaCost","getShardCount","(Lforge/card/mana/ManaCostShard;)I","invokevirtual",202);}
case 202:{f.Pc=f.Pop().Int<=0?379:205;continue;}
case 205:{f.Push(JValue.I(1));f.Pc=206;continue;}
case 206:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 207:{f.Push(f.Locals[6]);f.Pc=209;continue;}
case 209:{f.Push(JValue.R(rt.String("CantPayGenericCosts")));f.Pc=212;continue;}
case 212:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",215);}
case 215:{f.Pc=f.Pop().Int==0?220:218;continue;}
case 218:{f.Push(JValue.I(1));f.Pc=219;continue;}
case 219:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 220:{f.Push(f.Locals[6]);f.Pc=222;continue;}
case 222:{f.Push(JValue.R(rt.String("CantCastSpellFrom")));f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",228);}
case 228:{f.Pc=f.Pop().Int==0?300:231;continue;}
case 231:{f.Push(f.Locals[1]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",235);}
case 235:{f.Pc=f.Pop().Int!=0?240:238;continue;}
case 238:{f.Push(JValue.I(1));f.Pc=239;continue;}
case 239:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 240:{f.Push(f.Locals[6]);f.Pc=242;continue;}
case 242:{f.Push(JValue.I(17));f.Pc=244;continue;}
case 244:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",247);}
case 247:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",250);}
case 250:{f.Locals[7]=f.Pop();f.Pc=252;continue;}
case 252:{f.Push(f.Locals[1]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",256);}
case 256:{f.Locals[8]=f.Pop();f.Pc=258;continue;}
case 258:{f.Push(f.Locals[8]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/card/Card","getCastFrom","()Lforge/game/zone/Zone;","invokevirtual",263);}
case 263:{f.Locals[9]=f.Pop();f.Pc=265;continue;}
case 265:{f.Push(f.Locals[9]);f.Pc=267;continue;}
case 267:{f.Pc=f.Pop().Reference!=null?281:270;continue;}
case 270:{f.Push(f.Locals[8]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",275);}
case 275:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",278);}
case 278:{f.Pc=286;continue;}
case 281:{f.Push(f.Locals[9]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",286);}
case 286:{f.Locals[10]=f.Pop();f.Pc=288;continue;}
case 288:{f.Push(f.Locals[7]);f.Pc=290;continue;}
case 290:{f.Push(f.Locals[10]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/zone/ZoneType","equals","(Ljava/lang/Object;)Z","invokevirtual",295);}
case 295:{f.Pc=f.Pop().Int!=0?300:298;continue;}
case 298:{f.Push(JValue.I(1));f.Pc=299;continue;}
case 299:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 300:{f.Push(f.Locals[6]);f.Pc=302;continue;}
case 302:{f.Push(JValue.R(rt.String("CantCastNonArtifactSpells")));f.Pc=305;continue;}
case 305:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",308);}
case 308:{f.Pc=f.Pop().Int==0?334:311;continue;}
case 311:{f.Push(f.Locals[1]);f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/spellability/SpellAbility","isSpell","()Z","invokevirtual",315);}
case 315:{f.Pc=f.Pop().Int==0?328:318;continue;}
case 318:{f.Push(f.Locals[1]);f.Pc=319;continue;}
case 319:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",322);}
case 322:{return rt.Call(f,"forge/game/card/Card","isArtifact","()Z","invokevirtual",325);}
case 325:{f.Pc=f.Pop().Int==0?332:328;continue;}
case 328:{f.Push(JValue.I(1));f.Pc=329;continue;}
case 329:{f.Pc=333;continue;}
case 332:{f.Push(JValue.I(0));f.Pc=333;continue;}
case 333:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 334:{f.Push(f.Locals[0]);f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceCard","()Lforge/game/card/Card;","invokevirtual",338);}
case 338:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",341);}
case 341:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",344);}
case 344:{f.Push(f.Locals[1]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",348);}
case 348:{return rt.Call(f,"forge/game/zone/MagicStack","getInstanceMatchingSpellAbilityID","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbilityStackInstance;","invokevirtual",351);}
case 351:{f.Pc=f.Pop().Reference==null?356:354;continue;}
case 354:{f.Push(JValue.I(0));f.Pc=355;continue;}
case 355:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 356:{f.Push(f.Locals[1]);f.Pc=357;continue;}
case 357:{f.Push(f.Locals[6]);f.Pc=359;continue;}
case 359:{f.Push(f.Locals[0]);f.Pc=360;continue;}
case 360:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceCard","()Lforge/game/card/Card;","invokevirtual",363);}
case 363:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",366);}
case 366:{f.Push(f.Locals[0]);f.Pc=367;continue;}
case 367:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceCard","()Lforge/game/card/Card;","invokevirtual",370);}
case 370:{f.Push(JValue.R(null));f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/game/spellability/SpellAbility","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",374);}
case 374:{f.Pc=f.Pop().Int==0?379:377;continue;}
case 377:{f.Push(JValue.I(1));f.Pc=378;continue;}
case 378:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 379:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=382;continue;}
case 382:{f.Pc=24;continue;}
case 385:{f.Push(JValue.I(0));f.Pc=386;continue;}
case 386:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9105(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","manaRestrictions","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?12:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","manaRestrictions","Ljava/lang/String;"));f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String(",")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=25;continue;}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{f.Locals[5]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[5]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?87:37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=41;continue;}
case 41:{f.Locals[6]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[6]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("CantPayGenericCosts")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int==0?81:54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/card/mana/ManaCostShard","isGeneric","()Z","invokevirtual",58);}
case 58:{f.Pc=f.Pop().Int==0?81:61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/card/mana/ManaCostShard","isOr2Generic","()Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?79:68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/card/mana/ManaCostShard","isColor","(B)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int==0?79:76;continue;}
case 76:{f.Pc=81;continue;}
case 79:{f.Push(JValue.I(0));f.Pc=80;continue;}
case 80:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 81:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=84;continue;}
case 84:{f.Pc=30;continue;}
case 87:{f.Push(JValue.I(1));f.Pc=88;continue;}
case 88:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9106(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","meetsManaRestrictions","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?21:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","meetsManaShardRestrictions","(Lforge/card/mana/ManaCostShard;B)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9107(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isComboMana","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?13:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getComboColors","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getOrigProduced","()Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Chosen")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?41:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("Chosen")));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getChosenColor","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",37);}
case 37:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",40);}
case 40:{f.Locals[2]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isSpecialMana","()Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?63:48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",52);}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/ability/effects/ManaEffect","handleSpecialMana","(Lforge/game/player/Player;Lforge/game/spellability/AbilityManaPart;Lforge/game/spellability/SpellAbility;Z)V","invokestatic",58);}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getExpressChoice","()Ljava/lang/String;","invokevirtual",62);}
case 62:{f.Locals[2]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9108(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","lastExpressChoice","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9109(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/ColorSet","hasBlack","()Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?23:15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("B ")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",22);}
case 22:{f.StackOp("pop");f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/card/ColorSet","hasBlue","()Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?38:30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("U ")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/card/ColorSet","hasWhite","()Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?53:45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("W ")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/card/ColorSet","hasRed","()Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?68:60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("R ")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",67);}
case 67:{f.StackOp("pop");f.Pc=68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/card/ColorSet","hasGreen","()Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?83:75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("G ")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[2]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",88);}
case 88:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",91);}
case 91:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","lastExpressChoice","Ljava/lang/String;",value);f.Pc=94;continue;}
case 94:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9110(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","lastExpressChoice","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9111(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("")));f.Pc=3;continue;}
case 3:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","lastExpressChoice","Ljava/lang/String;",value);f.Pc=6;continue;}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9112(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","lastManaProduced","Lcom/google/common/collect/Multiset;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9113(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","isSnow","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9114(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getOrigProduced","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String("Any")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9115(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getOrigProduced","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String("Combo")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9116(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getOrigProduced","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String("Special")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9117(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isAnyMana","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?19:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("C")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int!=0?19:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","mana","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",28);}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9118(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/spellability/AbilityManaPart")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilityManaPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","sourceCard","Lforge/game/card/Card;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","sourceCard","Lforge/game/card/Card;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?46:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","origProduced","Ljava/lang/String;"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getOrigProduced","()Ljava/lang/String;","invokevirtual",36);}
case 36:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int==0?46:42;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{f.Pc=47;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9119(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(41));f.Pc=2;continue;}
case 2:{f.Push(JValue.I(41));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceCard","()Lforge/game/card/Card;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/Card","hashCode","()I","invokevirtual",11);}
case 11:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=12;continue;}
case 12:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9120(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","origProduced","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9121(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isComboMana","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?10:7;continue;}
case 7:{f.Push(JValue.R(rt.String("")));f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isAnyMana","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.R(rt.String("W U B R G")));f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getOrigProduced","()Ljava/lang/String;","invokevirtual",25);}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("Chosen")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?49:36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("Chosen")));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getChosenColor","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",45);}
case 45:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",48);}
case 48:{f.Locals[2]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("ColorID")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?102:59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",63);}
case 63:{return rt.Call(f,"forge/game/card/Card","getMarkedColors","()Lforge/card/ColorSet;","invokevirtual",66);}
case 66:{return rt.Call(f,"forge/card/ColorSet","stream","()Ljava/util/stream/Stream;","invokevirtual",69);}
case 69:{return rt.DynamicCall(f,"forge/game/spellability/AbilityManaPart:9121:69:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",74);}
case 74:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",79);}
case 79:{f.Push(JValue.R(rt.String(" ")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/stream/Collectors","joining","(Ljava/lang/CharSequence;)Ljava/util/stream/Collector;","invokestatic",84);}
case 84:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",89);}
case 89:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=92;continue;}
case 92:{f.Locals[3]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("ColorID")));f.Pc=97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",101);}
case 101:{f.Locals[2]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[2]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("NotedColors")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int==0?241:112;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",116);}
case 116:{f.Pc=f.Pop().Reference!=null?122:119;continue;}
case 119:{f.Push(JValue.R(rt.String("")));f.Pc=121;continue;}
case 121:{return JStep.Return(f.Pop());}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",126);}
case 126:{return rt.Call(f,"forge/game/player/Player","getDraftNotes","()Ljava/util/Map;","invokevirtual",129);}
case 129:{f.Push(JValue.R(rt.String("Paliano, the High City")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",137);}
case 137:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=140;continue;}
case 140:{f.Locals[3]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[3]);f.Pc=142;continue;}
case 142:{f.Pc=f.Pop().Reference!=null?148:145;continue;}
case 145:{f.Push(JValue.R(rt.String("")));f.Pc=147;continue;}
case 147:{return JStep.Return(f.Pop());}
case 148:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=151;continue;}
case 151:{f.StackOp("dup");f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",155);}
case 155:{f.Locals[4]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[3]);f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String(",")));f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",164);}
case 164:{f.Locals[5]=f.Pop();f.Pc=166;continue;}
case 166:{f.Push(f.Locals[5]);f.Pc=168;continue;}
case 168:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=169;continue;}
case 169:{f.Locals[6]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(JValue.I(0));f.Pc=172;continue;}
case 172:{f.Locals[7]=f.Pop();f.Pc=174;continue;}
case 174:{f.Push(f.Locals[7]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[6]);f.Pc=178;continue;}
case 178:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?225:181;continue;}
case 181:{f.Push(f.Locals[5]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[7]);f.Pc=185;continue;}
case 185:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=186;continue;}
case 186:{f.Locals[8]=f.Pop();f.Pc=188;continue;}
case 188:{f.Push(f.Locals[8]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/card/MagicColor","toShortString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",193);}
case 193:{f.Locals[9]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[4]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[9]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/lang/StringBuilder","indexOf","(Ljava/lang/String;)I","invokevirtual",202);}
case 202:{f.Push(JValue.I(-1));f.Pc=203;continue;}
case 203:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?219:206;continue;}
case 206:{f.Push(f.Locals[4]);f.Pc=208;continue;}
case 208:{f.Push(f.Locals[9]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",213);}
case 213:{f.Push(JValue.R(rt.String(" ")));f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",218);}
case 218:{f.StackOp("pop");f.Pc=219;continue;}
case 219:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=222;continue;}
case 222:{f.Pc=174;continue;}
case 225:{f.Push(f.Locals[2]);f.Pc=226;continue;}
case 226:{f.Push(JValue.R(rt.String("NotedColors")));f.Pc=229;continue;}
case 229:{f.Push(f.Locals[4]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",234);}
case 234:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",237);}
case 237:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",240);}
case 240:{f.Locals[2]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(f.Locals[2]);f.Pc=242;continue;}
case 242:{f.Push(JValue.R(rt.String("ColorIdentity")));f.Pc=245;continue;}
case 245:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",248);}
case 248:{f.Pc=f.Pop().Int!=0?261:251;continue;}
case 251:{f.Push(f.Locals[2]);f.Pc=252;continue;}
case 252:{f.Push(JValue.R(rt.String("Combo ")));f.Pc=255;continue;}
case 255:{f.Push(JValue.R(rt.String("")));f.Pc=257;continue;}
case 257:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",260);}
case 260:{return JStep.Return(f.Pop());}
case 261:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=264;continue;}
case 264:{f.StackOp("dup");f.Pc=265;continue;}
case 265:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",268);}
case 268:{f.Locals[3]=f.Pop();f.Pc=269;continue;}
case 269:{f.Push(f.Locals[0]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceCard","()Lforge/game/card/Card;","invokevirtual",273);}
case 273:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",276);}
case 276:{f.Pc=f.Pop().Reference==null?396:279;continue;}
case 279:{f.Push(f.Locals[0]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceCard","()Lforge/game/card/Card;","invokevirtual",283);}
case 283:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",286);}
case 286:{return rt.Call(f,"forge/game/player/Player","getCommanders","()Ljava/util/List;","invokevirtual",289);}
case 289:{f.Locals[4]=f.Pop();f.Pc=291;continue;}
case 291:{f.Push(f.Locals[4]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",298);}
case 298:{f.Pc=f.Pop().Int==0?304:301;continue;}
case 301:{f.Push(JValue.R(rt.String("")));f.Pc=303;continue;}
case 303:{return JStep.Return(f.Pop());}
case 304:{f.Push(f.Locals[0]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceCard","()Lforge/game/card/Card;","invokevirtual",308);}
case 308:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",311);}
case 311:{return rt.Call(f,"forge/game/player/Player","getCommanderColorID","()Lforge/card/ColorSet;","invokevirtual",314);}
case 314:{f.Locals[5]=f.Pop();f.Pc=316;continue;}
case 316:{f.Push(f.Locals[5]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/card/ColorSet","hasWhite","()Z","invokevirtual",321);}
case 321:{f.Pc=f.Pop().Int==0?332:324;continue;}
case 324:{f.Push(f.Locals[3]);f.Pc=325;continue;}
case 325:{f.Push(JValue.R(rt.String("W ")));f.Pc=328;continue;}
case 328:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",331);}
case 331:{f.StackOp("pop");f.Pc=332;continue;}
case 332:{f.Push(f.Locals[5]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/card/ColorSet","hasBlue","()Z","invokevirtual",337);}
case 337:{f.Pc=f.Pop().Int==0?348:340;continue;}
case 340:{f.Push(f.Locals[3]);f.Pc=341;continue;}
case 341:{f.Push(JValue.R(rt.String("U ")));f.Pc=344;continue;}
case 344:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",347);}
case 347:{f.StackOp("pop");f.Pc=348;continue;}
case 348:{f.Push(f.Locals[5]);f.Pc=350;continue;}
case 350:{return rt.Call(f,"forge/card/ColorSet","hasBlack","()Z","invokevirtual",353);}
case 353:{f.Pc=f.Pop().Int==0?364:356;continue;}
case 356:{f.Push(f.Locals[3]);f.Pc=357;continue;}
case 357:{f.Push(JValue.R(rt.String("B ")));f.Pc=360;continue;}
case 360:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",363);}
case 363:{f.StackOp("pop");f.Pc=364;continue;}
case 364:{f.Push(f.Locals[5]);f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/card/ColorSet","hasRed","()Z","invokevirtual",369);}
case 369:{f.Pc=f.Pop().Int==0?380:372;continue;}
case 372:{f.Push(f.Locals[3]);f.Pc=373;continue;}
case 373:{f.Push(JValue.R(rt.String("R ")));f.Pc=376;continue;}
case 376:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",379);}
case 379:{f.StackOp("pop");f.Pc=380;continue;}
case 380:{f.Push(f.Locals[5]);f.Pc=382;continue;}
case 382:{return rt.Call(f,"forge/card/ColorSet","hasGreen","()Z","invokevirtual",385);}
case 385:{f.Pc=f.Pop().Int==0?396:388;continue;}
case 388:{f.Push(f.Locals[3]);f.Pc=389;continue;}
case 389:{f.Push(JValue.R(rt.String("G ")));f.Pc=392;continue;}
case 392:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",395);}
case 395:{f.StackOp("pop");f.Pc=396;continue;}
case 396:{f.Push(f.Locals[3]);f.Pc=397;continue;}
case 397:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",400);}
case 400:{f.Pc=f.Pop().Int!=0?408:403;continue;}
case 403:{f.Push(JValue.R(rt.String("")));f.Pc=405;continue;}
case 405:{f.Pc=419;continue;}
case 408:{f.Push(f.Locals[3]);f.Pc=409;continue;}
case 409:{f.Push(JValue.I(0));f.Pc=410;continue;}
case 410:{f.Push(f.Locals[3]);f.Pc=411;continue;}
case 411:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",414);}
case 414:{f.Push(JValue.I(1));f.Pc=415;continue;}
case 415:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=416;continue;}
case 416:{return rt.Call(f,"java/lang/StringBuilder","substring","(II)Ljava/lang/String;","invokevirtual",419);}
case 419:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9122(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?7:4;continue;}
case 4:{f.Push(JValue.R(rt.String("")));f.Pc=6;continue;}
case 6:{return JStep.Return(f.Pop());}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Reference==null?83:16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",23);}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/Card","getChosenColors","()Ljava/lang/Iterable;","invokevirtual",28);}
case 28:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",33);}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",42);}
case 42:{f.Pc=f.Pop().Int==0?75:45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Locals[5]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/card/MagicColor","toShortString","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",63);}
case 63:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",66);}
case 66:{f.Push(JValue.R(rt.String(" ")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",71);}
case 71:{f.StackOp("pop");f.Pc=72;continue;}
case 72:{f.Pc=35;continue;}
case 75:{f.Push(f.Locals[3]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",79);}
case 79:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",82);}
case 82:{return JStep.Return(f.Pop());}
case 83:{f.Push(JValue.R(rt.String("")));f.Pc=85;continue;}
case 85:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9123(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","sourceCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9124(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/spellability/AbilityManaPart","sourceCard","Lforge/game/card/Card;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9125(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","persistentMana","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9126(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/spellability/AbilityManaPart","combatMana","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9127(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(64));f.Pc=4;continue;}
case 4:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=5;continue;}
case 5:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?10:8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isAnyMana","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?19:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",23);}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",28);}
case 28:{f.Locals[4]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",34);}
case 34:{f.Locals[5]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[5]);f.Pc=38;continue;}
case 38:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Mana","Lforge/game/ability/AbilityKey;"));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getOrigProduced","()Ljava/lang/String;","invokevirtual",45);}
case 45:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",50);}
case 50:{f.StackOp("pop");f.Pc=51;continue;}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Activator","Lforge/game/ability/AbilityKey;"));f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",63);}
case 63:{f.StackOp("pop");f.Pc=64;continue;}
case 64:{f.Push(f.Locals[5]);f.Pc=66;continue;}
case 66:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AbilityMana","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AbilityMana","Lforge/game/ability/AbilityKey;"));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",73);}
case 73:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",83);}
case 83:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",86);}
case 86:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","ProduceMana","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","ProduceMana","Lforge/game/replacement/ReplacementType;"));f.Pc=89;continue;}
case 89:{f.Push(f.Locals[5]);f.Pc=91;continue;}
case 91:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Other","Lforge/game/replacement/ReplacementLayer;"));f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","getReplacementList","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;Lforge/game/replacement/ReplacementLayer;)Ljava/util/List;","invokevirtual",97);}
case 97:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",102);}
case 102:{f.Pc=f.Pop().Int!=0?107:105;continue;}
case 105:{f.Push(JValue.I(1));f.Pc=106;continue;}
case 106:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",111);}
case 111:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ManaReflected","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ManaReflected","Lforge/game/ability/ApiType;"));f.Pc=114;continue;}
case 114:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?173:117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/card/CardUtil","getReflectableManaColors","(Lforge/game/spellability/SpellAbility;)Ljava/util/Set;","invokestatic",121);}
case 121:{f.Locals[6]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[6]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",130);}
case 130:{f.Locals[7]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[7]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",139);}
case 139:{f.Pc=f.Pop().Int==0?170:142;continue;}
case 142:{f.Push(f.Locals[7]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",149);}
case 149:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=152;continue;}
case 152:{f.Locals[8]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(JValue.I(0));f.Pc=155;continue;}
case 155:{f.Push(f.Locals[2]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[8]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/card/mana/ManaAtom","fromName","(Ljava/lang/String;)B","invokestatic",161);}
case 161:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=162;continue;}
case 162:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?167:165;continue;}
case 165:{f.Push(JValue.I(1));f.Pc=166;continue;}
case 166:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 167:{f.Pc=132;continue;}
case 170:{f.Pc=239;continue;}
case 173:{f.Push(f.Locals[0]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isSpecialMana","()Z","invokevirtual",177);}
case 177:{f.Pc=f.Pop().Int==0?182:180;continue;}
case 180:{f.Push(JValue.I(1));f.Pc=181;continue;}
case 181:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 182:{f.Push(f.Locals[0]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[1]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","mana","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",187);}
case 187:{f.Locals[6]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[6]);f.Pc=191;continue;}
case 191:{f.Push(JValue.R(rt.String(" ")));f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",196);}
case 196:{f.Locals[7]=f.Pop();f.Pc=198;continue;}
case 198:{f.Push(f.Locals[7]);f.Pc=200;continue;}
case 200:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=201;continue;}
case 201:{f.Locals[8]=f.Pop();f.Pc=203;continue;}
case 203:{f.Push(JValue.I(0));f.Pc=204;continue;}
case 204:{f.Locals[9]=f.Pop();f.Pc=206;continue;}
case 206:{f.Push(f.Locals[9]);f.Pc=208;continue;}
case 208:{f.Push(f.Locals[8]);f.Pc=210;continue;}
case 210:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?239:213;continue;}
case 213:{f.Push(f.Locals[7]);f.Pc=215;continue;}
case 215:{f.Push(f.Locals[9]);f.Pc=217;continue;}
case 217:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=218;continue;}
case 218:{f.Locals[10]=f.Pop();f.Pc=220;continue;}
case 220:{f.Push(JValue.I(0));f.Pc=221;continue;}
case 221:{f.Push(f.Locals[2]);f.Pc=222;continue;}
case 222:{f.Push(f.Locals[10]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/card/mana/ManaAtom","fromName","(Ljava/lang/String;)B","invokestatic",227);}
case 227:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=228;continue;}
case 228:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?233:231;continue;}
case 231:{f.Push(JValue.I(1));f.Pc=232;continue;}
case 232:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 233:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=236;continue;}
case 236:{f.Pc=206;continue;}
case 239:{f.Push(JValue.I(0));f.Pc=240;continue;}
case 240:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9128(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/MagicColor$Color","getShortName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9129(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/mana/Mana"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/Mana")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Byte","byteValue","()B","invokevirtual",8);}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/mana/Mana","<init>","(BLforge/game/card/Card;Lforge/game/spellability/AbilityManaPart;Lforge/game/player/Player;)V","invokespecial",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9130(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/mana/Mana"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/Mana")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[3]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/Byte","byteValue","()B","invokevirtual",8);}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/mana/Mana","<init>","(BLforge/game/card/Card;Lforge/game/spellability/AbilityManaPart;Lforge/game/player/Player;)V","invokespecial",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
