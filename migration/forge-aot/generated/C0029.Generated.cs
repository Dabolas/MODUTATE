// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C29{
internal static JClass Build(){var c=new JClass("forge/card/CardFace","java/lang/Object",new string[]{"forge/card/ICardFace","java/lang/Cloneable"},48);Add0(c);Add1(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("emptyList","Ljava/util/List;",true,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("emptyMap","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("emptySet","Ljava/util/Set;",true,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("flavorName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("type","Lforge/card/CardType;",false,JValue.Default("Lforge/card/CardType;"),null));
c.Add(new JField("manaCost","Lforge/card/mana/ManaCost;",false,JValue.Default("Lforge/card/mana/ManaCost;"),null));
c.Add(new JField("color","Lforge/card/ColorSet;",false,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("oracleText","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("iPower","I",false,JValue.Default("I"),null));
c.Add(new JField("iToughness","I",false,JValue.Default("I"),null));
c.Add(new JField("power","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("toughness","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("initialLoyalty","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("defense","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("attractionLights","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("nonAbilityText","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("keywords","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("deckRules","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("abilities","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("staticAbilities","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("triggers","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("draftActions","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("replacements","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("variables","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("functionalVariants","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(511,"forge/card/CardFace","getOracleText","()Ljava/lang/String;",1,1,1,new JHandler[]{},M511));
c.Add(new JMethod(512,"forge/card/CardFace","getIntPower","()I",1,1,1,new JHandler[]{},M512));
c.Add(new JMethod(513,"forge/card/CardFace","getIntToughness","()I",1,1,1,new JHandler[]{},M513));
c.Add(new JMethod(514,"forge/card/CardFace","getPower","()Ljava/lang/String;",1,1,1,new JHandler[]{},M514));
c.Add(new JMethod(515,"forge/card/CardFace","getToughness","()Ljava/lang/String;",1,1,1,new JHandler[]{},M515));
c.Add(new JMethod(516,"forge/card/CardFace","getInitialLoyalty","()Ljava/lang/String;",1,1,1,new JHandler[]{},M516));
c.Add(new JMethod(517,"forge/card/CardFace","getDefense","()Ljava/lang/String;",1,1,1,new JHandler[]{},M517));
c.Add(new JMethod(518,"forge/card/CardFace","getAttractionLights","()Ljava/util/Set;",1,1,1,new JHandler[]{},M518));
c.Add(new JMethod(519,"forge/card/CardFace","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M519));
c.Add(new JMethod(520,"forge/card/CardFace","getType","()Lforge/card/CardType;",1,1,1,new JHandler[]{},M520));
c.Add(new JMethod(521,"forge/card/CardFace","getManaCost","()Lforge/card/mana/ManaCost;",1,1,1,new JHandler[]{},M521));
c.Add(new JMethod(522,"forge/card/CardFace","getColor","()Lforge/card/ColorSet;",1,1,1,new JHandler[]{},M522));
c.Add(new JMethod(523,"forge/card/CardFace","getKeywords","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M523));
c.Add(new JMethod(524,"forge/card/CardFace","getDeckRules","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M524));
c.Add(new JMethod(525,"forge/card/CardFace","getAbilities","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M525));
c.Add(new JMethod(526,"forge/card/CardFace","getStaticAbilities","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M526));
c.Add(new JMethod(527,"forge/card/CardFace","getTriggers","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M527));
c.Add(new JMethod(528,"forge/card/CardFace","getDraftActions","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M528));
c.Add(new JMethod(529,"forge/card/CardFace","getReplacements","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M529));
c.Add(new JMethod(530,"forge/card/CardFace","getNonAbilityText","()Ljava/lang/String;",1,1,1,new JHandler[]{},M530));
c.Add(new JMethod(531,"forge/card/CardFace","getVariables","()Ljava/lang/Iterable;",1,1,1,new JHandler[]{},M531));
c.Add(new JMethod(532,"forge/card/CardFace","getFlavorName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M532));
c.Add(new JMethod(533,"forge/card/CardFace","<init>","(Ljava/lang/String;)V",1,2,3,new JHandler[]{},M533));
c.Add(new JMethod(534,"forge/card/CardFace","setName","(Ljava/lang/String;)V",0,2,2,new JHandler[]{},M534));
c.Add(new JMethod(535,"forge/card/CardFace","setFlavorName","(Ljava/lang/String;)V",0,2,2,new JHandler[]{},M535));
c.Add(new JMethod(536,"forge/card/CardFace","setType","(Lforge/card/CardType;)V",0,2,2,new JHandler[]{},M536));
c.Add(new JMethod(537,"forge/card/CardFace","setManaCost","(Lforge/card/mana/ManaCost;)V",0,2,2,new JHandler[]{},M537));
c.Add(new JMethod(538,"forge/card/CardFace","setColor","(Lforge/card/ColorSet;)V",0,2,2,new JHandler[]{},M538));
c.Add(new JMethod(539,"forge/card/CardFace","setOracleText","(Ljava/lang/String;)V",0,2,2,new JHandler[]{},M539));
c.Add(new JMethod(540,"forge/card/CardFace","setInitialLoyalty","(Ljava/lang/String;)V",0,2,2,new JHandler[]{},M540));
c.Add(new JMethod(541,"forge/card/CardFace","setDefense","(Ljava/lang/String;)V",0,2,2,new JHandler[]{},M541));
c.Add(new JMethod(542,"forge/card/CardFace","setAttractionLights","(Ljava/lang/String;)V",0,2,3,new JHandler[]{},M542));
c.Add(new JMethod(543,"forge/card/CardFace","setPtText","(Ljava/lang/String;)V",0,3,3,new JHandler[]{},M543));
c.Add(new JMethod(544,"forge/card/CardFace","parsePT","(Ljava/lang/String;)I",8,1,3,new JHandler[]{},M544));
c.Add(new JMethod(545,"forge/card/CardFace","setNonAbilityText","(Ljava/lang/String;)V",0,2,2,new JHandler[]{},M545));
c.Add(new JMethod(546,"forge/card/CardFace","addKeyword","(Ljava/lang/String;)V",0,2,3,new JHandler[]{},M546));
c.Add(new JMethod(547,"forge/card/CardFace","addDeckRule","(Ljava/lang/String;)V",0,2,3,new JHandler[]{},M547));
c.Add(new JMethod(548,"forge/card/CardFace","addAbility","(Ljava/lang/String;)V",0,2,3,new JHandler[]{},M548));
}

private static void Add1(JClass c){
c.Add(new JMethod(549,"forge/card/CardFace","addTrigger","(Ljava/lang/String;)V",0,2,3,new JHandler[]{},M549));
c.Add(new JMethod(550,"forge/card/CardFace","addDraftAction","(Ljava/lang/String;)V",0,2,3,new JHandler[]{},M550));
c.Add(new JMethod(551,"forge/card/CardFace","addStaticAbility","(Ljava/lang/String;)V",0,2,3,new JHandler[]{},M551));
c.Add(new JMethod(552,"forge/card/CardFace","addReplacementEffect","(Ljava/lang/String;)V",0,2,3,new JHandler[]{},M552));
c.Add(new JMethod(553,"forge/card/CardFace","addSVar","(Ljava/lang/String;Ljava/lang/String;)V",0,3,4,new JHandler[]{},M553));
c.Add(new JMethod(554,"forge/card/CardFace","hasFunctionalVariants","()Z",1,1,1,new JHandler[]{},M554));
c.Add(new JMethod(555,"forge/card/CardFace","getFunctionalVariant","(Ljava/lang/String;)Lforge/card/ICardFace;",1,2,2,new JHandler[]{},M555));
c.Add(new JMethod(556,"forge/card/CardFace","getFunctionalVariants","()Ljava/util/Map;",1,1,1,new JHandler[]{},M556));
c.Add(new JMethod(557,"forge/card/CardFace","getOrCreateFunctionalVariant","(Ljava/lang/String;)Lforge/card/CardFace;",0,2,5,new JHandler[]{},M557));
c.Add(new JMethod(558,"forge/card/CardFace","assignMissingFields","()V",0,3,2,new JHandler[]{},M558));
c.Add(new JMethod(559,"forge/card/CardFace","assignMissingFieldsToVariant","(Lforge/card/CardFace;)V",0,4,4,new JHandler[]{new JHandler(21,77,80,"java/util/regex/PatternSyntaxException")},M559));
c.Add(new JMethod(560,"forge/card/CardFace","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M560));
c.Add(new JMethod(561,"forge/card/CardFace","compareTo","(Lforge/card/ICardFace;)I",1,2,2,new JHandler[]{},M561));
c.Add(new JMethod(562,"forge/card/CardFace","clone","()Ljava/lang/Object;",1,2,3,new JHandler[]{new JHandler(0,4,5,"java/lang/Exception")},M562));
c.Add(new JMethod(563,"forge/card/CardFace","compareTo","(Ljava/lang/Object;)I",4161,2,2,new JHandler[]{},M563));
c.Add(new JMethod(564,"forge/card/CardFace","lambda$assignMissingFieldsToVariant$0","(Lforge/card/CardFace;Ljava/lang/String;Ljava/lang/String;)V",4106,3,3,new JHandler[]{},M564));
c.Add(new JMethod(565,"forge/card/CardFace","<clinit>","()V",8,0,2,new JHandler[]{},M565));
}

internal static JStep M511(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","oracleText","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M512(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","iPower","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M513(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","iToughness","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M514(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","power","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M515(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","toughness","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M516(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","initialLoyalty","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M517(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","defense","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M518(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","attractionLights","Ljava/util/Set;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M519(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M520(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","type","Lforge/card/CardType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M521(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","manaCost","Lforge/card/mana/ManaCost;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M522(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","color","Lforge/card/ColorSet;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M523(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","keywords","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M524(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","deckRules","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M525(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","abilities","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M526(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","staticAbilities","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M527(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","triggers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M528(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","draftActions","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M529(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","replacements","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M530(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","nonAbilityText","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M531(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","variables","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","variables","Ljava/util/Map;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",18);}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M532(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","flavorName","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M533(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","flavorName","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","type","Lforge/card/CardType;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(null));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","manaCost","Lforge/card/mana/ManaCost;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(null));f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","color","Lforge/card/ColorSet;",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(null));f.Pc=26;continue;}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","oracleText","Ljava/lang/String;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(JValue.I(2147483647));f.Pc=32;continue;}
case 32:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","iPower","I",value);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(JValue.I(2147483647));f.Pc=38;continue;}
case 38:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","iToughness","I",value);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(null));f.Pc=43;continue;}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","power","Ljava/lang/String;",value);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(null));f.Pc=48;continue;}
case 48:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","toughness","Ljava/lang/String;",value);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("")));f.Pc=54;continue;}
case 54:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","initialLoyalty","Ljava/lang/String;",value);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("")));f.Pc=60;continue;}
case 60:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","defense","Ljava/lang/String;",value);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(JValue.R(null));f.Pc=65;continue;}
case 65:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","attractionLights","Ljava/util/Set;",value);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(JValue.R(null));f.Pc=70;continue;}
case 70:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","nonAbilityText","Ljava/lang/String;",value);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(null));f.Pc=75;continue;}
case 75:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","keywords","Ljava/util/List;",value);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(null));f.Pc=80;continue;}
case 80:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","deckRules","Ljava/util/List;",value);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(JValue.R(null));f.Pc=85;continue;}
case 85:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","abilities","Ljava/util/List;",value);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(JValue.R(null));f.Pc=90;continue;}
case 90:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","staticAbilities","Ljava/util/List;",value);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(null));f.Pc=95;continue;}
case 95:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","triggers","Ljava/util/List;",value);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(null));f.Pc=100;continue;}
case 100:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","draftActions","Ljava/util/List;",value);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(null));f.Pc=105;continue;}
case 105:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","replacements","Ljava/util/List;",value);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{f.Push(JValue.R(null));f.Pc=110;continue;}
case 110:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","variables","Ljava/util/Map;",value);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(JValue.R(null));f.Pc=115;continue;}
case 115:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","functionalVariants","Ljava/util/Map;",value);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","name","Ljava/lang/String;",value);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",127);}
case 127:{f.Pc=f.Pop().Int==0?140:130;continue;}
case 130:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=133;continue;}
case 133:{f.StackOp("dup");f.Pc=134;continue;}
case 134:{f.Push(JValue.R(rt.String("Card name is empty")));f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",139);}
case 139:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 140:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M534(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","name","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M535(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","flavorName","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M536(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","type","Lforge/card/CardType;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M537(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","manaCost","Lforge/card/mana/ManaCost;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M538(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","color","Lforge/card/ColorSet;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M539(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","oracleText","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M540(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","initialLoyalty","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M541(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","defense","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M542(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?10:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","attractionLights","Ljava/util/Set;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String(" ")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",17);}
case 17:{return rt.Call(f,"java/util/Arrays","stream","([Ljava/lang/Object;)Ljava/util/stream/Stream;","invokestatic",20);}
case 20:{return rt.DynamicCall(f,"forge/card/CardFace:542:20:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",25);}
case 25:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",30);}
case 30:{return rt.Call(f,"java/util/stream/Collectors","toSet","()Ljava/util/stream/Collector;","invokestatic",33);}
case 33:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Set"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","attractionLights","Ljava/util/Set;",value);f.Pc=44;continue;}
case 44:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M543(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("/")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=9;continue;}
case 9:{f.Push(JValue.I(2));f.Pc=10;continue;}
case 10:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?30:13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/card/CardFace","getName","()Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.DynamicCall(f,"forge/card/CardFace:543:21:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",26);}
case 26:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",29);}
case 29:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=34;continue;}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","power","Ljava/lang/String;",value);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(JValue.I(1));f.Pc=40;continue;}
case 40:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=41;continue;}
case 41:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","toughness","Ljava/lang/String;",value);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/card/CardFace","parsePT","(Ljava/lang/String;)I","invokestatic",51);}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","iPower","I",value);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{f.Push(JValue.I(1));f.Pc=57;continue;}
case 57:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/card/CardFace","parsePT","(Ljava/lang/String;)I","invokestatic",61);}
case 61:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","iToughness","I",value);f.Pc=64;continue;}
case 64:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M544(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("*")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?45:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("+*")));f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Locals[0]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("-*")));f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Locals[0]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("*+")));f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",35);}
case 35:{f.Locals[0]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("*")));f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("0")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Locals[0]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",49);}
case 49:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M545(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","nonAbilityText","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M546(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","keywords","Ljava/util/List;"));f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?19:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","keywords","Ljava/util/List;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","keywords","Ljava/util/List;"));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M547(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","deckRules","Ljava/util/List;"));f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?19:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","deckRules","Ljava/util/List;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","deckRules","Ljava/util/List;"));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M548(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","abilities","Ljava/util/List;"));f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?19:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","abilities","Ljava/util/List;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","abilities","Ljava/util/List;"));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M549(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","triggers","Ljava/util/List;"));f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?19:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","triggers","Ljava/util/List;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","triggers","Ljava/util/List;"));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M550(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","draftActions","Ljava/util/List;"));f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?19:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","draftActions","Ljava/util/List;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","draftActions","Ljava/util/List;"));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M551(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","staticAbilities","Ljava/util/List;"));f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?19:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","staticAbilities","Ljava/util/List;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","staticAbilities","Ljava/util/List;"));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M552(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","replacements","Ljava/util/List;"));f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?19:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","replacements","Ljava/util/List;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","replacements","Ljava/util/List;"));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M553(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","variables","Ljava/util/Map;"));f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?22:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{if(!rt.EnsureInitialized(f,"java/util/TreeMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeMap")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/TreeMap","<init>","(Ljava/util/Comparator;)V","invokespecial",19);}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","variables","Ljava/util/Map;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","variables","Ljava/util/Map;"));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",33);}
case 33:{f.StackOp("pop");f.Pc=34;continue;}
case 34:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M554(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","functionalVariants","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M555(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","functionalVariants","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","functionalVariants","Ljava/util/Map;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",19);}
case 19:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=22;continue;}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M556(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","functionalVariants","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M557(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","functionalVariants","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","functionalVariants","Ljava/util/Map;",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","functionalVariants","Ljava/util/Map;"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int!=0?53:31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","functionalVariants","Ljava/util/Map;"));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{if(!rt.EnsureInitialized(f,"forge/card/CardFace"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardFace")));f.Pc=39;continue;}
case 39:{f.StackOp("dup");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","name","Ljava/lang/String;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/card/CardFace","<init>","(Ljava/lang/String;)V","invokespecial",47);}
case 47:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","functionalVariants","Ljava/util/Map;"));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M558(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","oracleText","Ljava/lang/String;"));f.Pc=5;continue;}
case 5:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?29:8;continue;}
case 8:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","name","Ljava/lang/String;"));f.Pc=15;continue;}
case 15:{return rt.DynamicCall(f,"forge/card/CardFace:558:15:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",20);}
case 20:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",23);}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("")));f.Pc=26;continue;}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","oracleText","Ljava/lang/String;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","manaCost","Lforge/card/mana/ManaCost;"));f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Reference!=null?58:36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","color","Lforge/card/ColorSet;"));f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Reference!=null?58:43;continue;}
case 43:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=46;continue;}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","name","Ljava/lang/String;"));f.Pc=50;continue;}
case 50:{return rt.DynamicCall(f,"forge/card/CardFace:558:50:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",55);}
case 55:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",58);}
case 58:{f.Push(f.Locals[0]);f.Pc=59;continue;}
case 59:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","manaCost","Lforge/card/mana/ManaCost;"));f.Pc=62;continue;}
case 62:{f.Pc=f.Pop().Reference!=null?72:65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{if(!rt.StaticReady(f,"forge/card/mana/ManaCost","NO_COST","Lforge/card/mana/ManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaCost","NO_COST","Lforge/card/mana/ManaCost;"));f.Pc=69;continue;}
case 69:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","manaCost","Lforge/card/mana/ManaCost;",value);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","color","Lforge/card/ColorSet;"));f.Pc=76;continue;}
case 76:{f.Pc=f.Pop().Reference!=null?90:79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","manaCost","Lforge/card/mana/ManaCost;"));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/card/ColorSet","fromManaCost","(Lforge/card/mana/ManaCost;)Lforge/card/ColorSet;","invokestatic",87);}
case 87:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","color","Lforge/card/ColorSet;",value);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","keywords","Ljava/util/List;"));f.Pc=94;continue;}
case 94:{f.Pc=f.Pop().Reference!=null?104:97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{if(!rt.StaticReady(f,"forge/card/CardFace","emptyList","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardFace","emptyList","Ljava/util/List;"));f.Pc=101;continue;}
case 101:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","keywords","Ljava/util/List;",value);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","deckRules","Ljava/util/List;"));f.Pc=108;continue;}
case 108:{f.Pc=f.Pop().Reference!=null?118:111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{if(!rt.StaticReady(f,"forge/card/CardFace","emptyList","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardFace","emptyList","Ljava/util/List;"));f.Pc=115;continue;}
case 115:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","deckRules","Ljava/util/List;",value);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","abilities","Ljava/util/List;"));f.Pc=122;continue;}
case 122:{f.Pc=f.Pop().Reference!=null?132:125;continue;}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{if(!rt.StaticReady(f,"forge/card/CardFace","emptyList","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardFace","emptyList","Ljava/util/List;"));f.Pc=129;continue;}
case 129:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","abilities","Ljava/util/List;",value);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","staticAbilities","Ljava/util/List;"));f.Pc=136;continue;}
case 136:{f.Pc=f.Pop().Reference!=null?146:139;continue;}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{if(!rt.StaticReady(f,"forge/card/CardFace","emptyList","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardFace","emptyList","Ljava/util/List;"));f.Pc=143;continue;}
case 143:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","staticAbilities","Ljava/util/List;",value);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[0]);f.Pc=147;continue;}
case 147:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","triggers","Ljava/util/List;"));f.Pc=150;continue;}
case 150:{f.Pc=f.Pop().Reference!=null?160:153;continue;}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{if(!rt.StaticReady(f,"forge/card/CardFace","emptyList","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardFace","emptyList","Ljava/util/List;"));f.Pc=157;continue;}
case 157:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","triggers","Ljava/util/List;",value);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","replacements","Ljava/util/List;"));f.Pc=164;continue;}
case 164:{f.Pc=f.Pop().Reference!=null?174:167;continue;}
case 167:{f.Push(f.Locals[0]);f.Pc=168;continue;}
case 168:{if(!rt.StaticReady(f,"forge/card/CardFace","emptyList","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardFace","emptyList","Ljava/util/List;"));f.Pc=171;continue;}
case 171:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","replacements","Ljava/util/List;",value);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[0]);f.Pc=175;continue;}
case 175:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","variables","Ljava/util/Map;"));f.Pc=178;continue;}
case 178:{f.Pc=f.Pop().Reference!=null?188:181;continue;}
case 181:{f.Push(f.Locals[0]);f.Pc=182;continue;}
case 182:{if(!rt.StaticReady(f,"forge/card/CardFace","emptyMap","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardFace","emptyMap","Ljava/util/Map;"));f.Pc=185;continue;}
case 185:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","variables","Ljava/util/Map;",value);f.Pc=188;continue;}
case 188:{f.Push(JValue.R(null));f.Pc=189;continue;}
case 189:{f.Push(f.Locals[0]);f.Pc=190;continue;}
case 190:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","nonAbilityText","Ljava/lang/String;"));f.Pc=193;continue;}
case 193:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?202:196;continue;}
case 196:{f.Push(f.Locals[0]);f.Pc=197;continue;}
case 197:{f.Push(JValue.R(rt.String("")));f.Pc=199;continue;}
case 199:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","nonAbilityText","Ljava/lang/String;",value);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[0]);f.Pc=203;continue;}
case 203:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","attractionLights","Ljava/util/Set;"));f.Pc=206;continue;}
case 206:{f.Pc=f.Pop().Reference!=null?216:209;continue;}
case 209:{f.Push(f.Locals[0]);f.Pc=210;continue;}
case 210:{if(!rt.StaticReady(f,"forge/card/CardFace","emptySet","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardFace","emptySet","Ljava/util/Set;"));f.Pc=213;continue;}
case 213:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","attractionLights","Ljava/util/Set;",value);f.Pc=216;continue;}
case 216:{f.Push(f.Locals[0]);f.Pc=217;continue;}
case 217:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","functionalVariants","Ljava/util/Map;"));f.Pc=220;continue;}
case 220:{f.Pc=f.Pop().Reference==null?265:223;continue;}
case 223:{f.Push(f.Locals[0]);f.Pc=224;continue;}
case 224:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","functionalVariants","Ljava/util/Map;"));f.Pc=227;continue;}
case 227:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",232);}
case 232:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",237);}
case 237:{f.Locals[1]=f.Pop();f.Pc=238;continue;}
case 238:{f.Push(f.Locals[1]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",244);}
case 244:{f.Pc=f.Pop().Int==0?265:247;continue;}
case 247:{f.Push(f.Locals[1]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",253);}
case 253:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=256;continue;}
case 256:{f.Locals[2]=f.Pop();f.Pc=257;continue;}
case 257:{f.Push(f.Locals[0]);f.Pc=258;continue;}
case 258:{f.Push(f.Locals[2]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/card/CardFace","assignMissingFieldsToVariant","(Lforge/card/CardFace;)V","invokevirtual",262);}
case 262:{f.Pc=238;continue;}
case 265:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M559(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","oracleText","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?100:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","flavorName","Ljava/lang/String;"));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Reference==null?92:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","oracleText","Ljava/lang/String;"));f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Reference==null?92:21;continue;}
case 21:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",24);}
case 24:{f.Locals[2]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","oracleText","Ljava/lang/String;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","name","Ljava/lang/String;"));f.Pc=33;continue;}
case 33:{return rt.DynamicCall(f,"forge/card/CardFace:559:33:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",38);}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","flavorName","Ljava/lang/String;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Locals[3]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","name","Ljava/lang/String;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/util/Lang","getNickName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",55);}
case 55:{return rt.DynamicCall(f,"forge/card/CardFace:559:55:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",60);}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","flavorName","Ljava/lang/String;"));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/util/Lang","getNickName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",68);}
case 68:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",71);}
case 71:{f.Locals[3]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[3]);f.Pc=74;continue;}
case 74:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","oracleText","Ljava/lang/String;",value);f.Pc=77;continue;}
case 77:{f.Pc=100;continue;}
case 80:{f.Locals[2]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","oracleText","Ljava/lang/String;"));f.Pc=86;continue;}
case 86:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","oracleText","Ljava/lang/String;",value);f.Pc=89;continue;}
case 89:{f.Pc=100;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","oracleText","Ljava/lang/String;"));f.Pc=97;continue;}
case 97:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","oracleText","Ljava/lang/String;",value);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","color","Lforge/card/ColorSet;"));f.Pc=104;continue;}
case 104:{f.Pc=f.Pop().Reference!=null?132:107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","manaCost","Lforge/card/mana/ManaCost;"));f.Pc=112;continue;}
case 112:{f.Pc=f.Pop().Reference!=null?122:115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","color","Lforge/card/ColorSet;"));f.Pc=119;continue;}
case 119:{f.Pc=129;continue;}
case 122:{f.Push(f.Locals[0]);f.Pc=123;continue;}
case 123:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","manaCost","Lforge/card/mana/ManaCost;"));f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/card/ColorSet","fromManaCost","(Lforge/card/mana/ManaCost;)Lforge/card/ColorSet;","invokestatic",129);}
case 129:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","color","Lforge/card/ColorSet;",value);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[1]);f.Pc=133;continue;}
case 133:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","manaCost","Lforge/card/mana/ManaCost;"));f.Pc=136;continue;}
case 136:{f.Pc=f.Pop().Reference!=null?147:139;continue;}
case 139:{f.Push(f.Locals[1]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[0]);f.Pc=141;continue;}
case 141:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","manaCost","Lforge/card/mana/ManaCost;"));f.Pc=144;continue;}
case 144:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","manaCost","Lforge/card/mana/ManaCost;",value);f.Pc=147;continue;}
case 147:{f.Push(f.Locals[1]);f.Pc=148;continue;}
case 148:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","type","Lforge/card/CardType;"));f.Pc=151;continue;}
case 151:{f.Pc=f.Pop().Reference!=null?162:154;continue;}
case 154:{f.Push(f.Locals[1]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","type","Lforge/card/CardType;"));f.Pc=159;continue;}
case 159:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","type","Lforge/card/CardType;",value);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[1]);f.Pc=163;continue;}
case 163:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","power","Ljava/lang/String;"));f.Pc=166;continue;}
case 166:{f.Pc=f.Pop().Reference!=null?185:169;continue;}
case 169:{f.Push(f.Locals[1]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","power","Ljava/lang/String;"));f.Pc=174;continue;}
case 174:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","power","Ljava/lang/String;",value);f.Pc=177;continue;}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[0]);f.Pc=179;continue;}
case 179:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","iPower","I"));f.Pc=182;continue;}
case 182:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","iPower","I",value);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[1]);f.Pc=186;continue;}
case 186:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","toughness","Ljava/lang/String;"));f.Pc=189;continue;}
case 189:{f.Pc=f.Pop().Reference!=null?208:192;continue;}
case 192:{f.Push(f.Locals[1]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[0]);f.Pc=194;continue;}
case 194:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","toughness","Ljava/lang/String;"));f.Pc=197;continue;}
case 197:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","toughness","Ljava/lang/String;",value);f.Pc=200;continue;}
case 200:{f.Push(f.Locals[1]);f.Pc=201;continue;}
case 201:{f.Push(f.Locals[0]);f.Pc=202;continue;}
case 202:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","iToughness","I"));f.Pc=205;continue;}
case 205:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","iToughness","I",value);f.Pc=208;continue;}
case 208:{f.Push(JValue.R(rt.String("")));f.Pc=210;continue;}
case 210:{f.Push(f.Locals[1]);f.Pc=211;continue;}
case 211:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","initialLoyalty","Ljava/lang/String;"));f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",217);}
case 217:{f.Pc=f.Pop().Int==0?228:220;continue;}
case 220:{f.Push(f.Locals[1]);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[0]);f.Pc=222;continue;}
case 222:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","initialLoyalty","Ljava/lang/String;"));f.Pc=225;continue;}
case 225:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","initialLoyalty","Ljava/lang/String;",value);f.Pc=228;continue;}
case 228:{f.Push(JValue.R(rt.String("")));f.Pc=230;continue;}
case 230:{f.Push(f.Locals[1]);f.Pc=231;continue;}
case 231:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","defense","Ljava/lang/String;"));f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",237);}
case 237:{f.Pc=f.Pop().Int==0?248:240;continue;}
case 240:{f.Push(f.Locals[1]);f.Pc=241;continue;}
case 241:{f.Push(f.Locals[0]);f.Pc=242;continue;}
case 242:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","defense","Ljava/lang/String;"));f.Pc=245;continue;}
case 245:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","defense","Ljava/lang/String;",value);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[1]);f.Pc=249;continue;}
case 249:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","keywords","Ljava/util/List;"));f.Pc=252;continue;}
case 252:{f.Pc=f.Pop().Reference!=null?266:255;continue;}
case 255:{f.Push(f.Locals[1]);f.Pc=256;continue;}
case 256:{f.Push(f.Locals[0]);f.Pc=257;continue;}
case 257:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","keywords","Ljava/util/List;"));f.Pc=260;continue;}
case 260:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","keywords","Ljava/util/List;",value);f.Pc=263;continue;}
case 263:{f.Pc=281;continue;}
case 266:{f.Push(f.Locals[1]);f.Pc=267;continue;}
case 267:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","keywords","Ljava/util/List;"));f.Pc=270;continue;}
case 270:{f.Push(JValue.I(0));f.Pc=271;continue;}
case 271:{f.Push(f.Locals[0]);f.Pc=272;continue;}
case 272:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","keywords","Ljava/util/List;"));f.Pc=275;continue;}
case 275:{return rt.Call(f,"java/util/List","addAll","(ILjava/util/Collection;)Z","invokeinterface",280);}
case 280:{f.StackOp("pop");f.Pc=281;continue;}
case 281:{f.Push(f.Locals[1]);f.Pc=282;continue;}
case 282:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","deckRules","Ljava/util/List;"));f.Pc=285;continue;}
case 285:{f.Pc=f.Pop().Reference!=null?299:288;continue;}
case 288:{f.Push(f.Locals[1]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[0]);f.Pc=290;continue;}
case 290:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","deckRules","Ljava/util/List;"));f.Pc=293;continue;}
case 293:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","deckRules","Ljava/util/List;",value);f.Pc=296;continue;}
case 296:{f.Pc=314;continue;}
case 299:{f.Push(f.Locals[1]);f.Pc=300;continue;}
case 300:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","deckRules","Ljava/util/List;"));f.Pc=303;continue;}
case 303:{f.Push(JValue.I(0));f.Pc=304;continue;}
case 304:{f.Push(f.Locals[0]);f.Pc=305;continue;}
case 305:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","deckRules","Ljava/util/List;"));f.Pc=308;continue;}
case 308:{return rt.Call(f,"java/util/List","addAll","(ILjava/util/Collection;)Z","invokeinterface",313);}
case 313:{f.StackOp("pop");f.Pc=314;continue;}
case 314:{f.Push(f.Locals[1]);f.Pc=315;continue;}
case 315:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","abilities","Ljava/util/List;"));f.Pc=318;continue;}
case 318:{f.Pc=f.Pop().Reference!=null?332:321;continue;}
case 321:{f.Push(f.Locals[1]);f.Pc=322;continue;}
case 322:{f.Push(f.Locals[0]);f.Pc=323;continue;}
case 323:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","abilities","Ljava/util/List;"));f.Pc=326;continue;}
case 326:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","abilities","Ljava/util/List;",value);f.Pc=329;continue;}
case 329:{f.Pc=347;continue;}
case 332:{f.Push(f.Locals[1]);f.Pc=333;continue;}
case 333:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","abilities","Ljava/util/List;"));f.Pc=336;continue;}
case 336:{f.Push(JValue.I(0));f.Pc=337;continue;}
case 337:{f.Push(f.Locals[0]);f.Pc=338;continue;}
case 338:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","abilities","Ljava/util/List;"));f.Pc=341;continue;}
case 341:{return rt.Call(f,"java/util/List","addAll","(ILjava/util/Collection;)Z","invokeinterface",346);}
case 346:{f.StackOp("pop");f.Pc=347;continue;}
case 347:{f.Push(f.Locals[1]);f.Pc=348;continue;}
case 348:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","staticAbilities","Ljava/util/List;"));f.Pc=351;continue;}
case 351:{f.Pc=f.Pop().Reference!=null?365:354;continue;}
case 354:{f.Push(f.Locals[1]);f.Pc=355;continue;}
case 355:{f.Push(f.Locals[0]);f.Pc=356;continue;}
case 356:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","staticAbilities","Ljava/util/List;"));f.Pc=359;continue;}
case 359:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","staticAbilities","Ljava/util/List;",value);f.Pc=362;continue;}
case 362:{f.Pc=380;continue;}
case 365:{f.Push(f.Locals[1]);f.Pc=366;continue;}
case 366:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","staticAbilities","Ljava/util/List;"));f.Pc=369;continue;}
case 369:{f.Push(JValue.I(0));f.Pc=370;continue;}
case 370:{f.Push(f.Locals[0]);f.Pc=371;continue;}
case 371:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","staticAbilities","Ljava/util/List;"));f.Pc=374;continue;}
case 374:{return rt.Call(f,"java/util/List","addAll","(ILjava/util/Collection;)Z","invokeinterface",379);}
case 379:{f.StackOp("pop");f.Pc=380;continue;}
case 380:{f.Push(f.Locals[1]);f.Pc=381;continue;}
case 381:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","triggers","Ljava/util/List;"));f.Pc=384;continue;}
case 384:{f.Pc=f.Pop().Reference!=null?398:387;continue;}
case 387:{f.Push(f.Locals[1]);f.Pc=388;continue;}
case 388:{f.Push(f.Locals[0]);f.Pc=389;continue;}
case 389:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","triggers","Ljava/util/List;"));f.Pc=392;continue;}
case 392:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","triggers","Ljava/util/List;",value);f.Pc=395;continue;}
case 395:{f.Pc=413;continue;}
case 398:{f.Push(f.Locals[1]);f.Pc=399;continue;}
case 399:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","triggers","Ljava/util/List;"));f.Pc=402;continue;}
case 402:{f.Push(JValue.I(0));f.Pc=403;continue;}
case 403:{f.Push(f.Locals[0]);f.Pc=404;continue;}
case 404:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","triggers","Ljava/util/List;"));f.Pc=407;continue;}
case 407:{return rt.Call(f,"java/util/List","addAll","(ILjava/util/Collection;)Z","invokeinterface",412);}
case 412:{f.StackOp("pop");f.Pc=413;continue;}
case 413:{f.Push(f.Locals[1]);f.Pc=414;continue;}
case 414:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","replacements","Ljava/util/List;"));f.Pc=417;continue;}
case 417:{f.Pc=f.Pop().Reference!=null?431:420;continue;}
case 420:{f.Push(f.Locals[1]);f.Pc=421;continue;}
case 421:{f.Push(f.Locals[0]);f.Pc=422;continue;}
case 422:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","replacements","Ljava/util/List;"));f.Pc=425;continue;}
case 425:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","replacements","Ljava/util/List;",value);f.Pc=428;continue;}
case 428:{f.Pc=446;continue;}
case 431:{f.Push(f.Locals[1]);f.Pc=432;continue;}
case 432:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","replacements","Ljava/util/List;"));f.Pc=435;continue;}
case 435:{f.Push(JValue.I(0));f.Pc=436;continue;}
case 436:{f.Push(f.Locals[0]);f.Pc=437;continue;}
case 437:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","replacements","Ljava/util/List;"));f.Pc=440;continue;}
case 440:{return rt.Call(f,"java/util/List","addAll","(ILjava/util/Collection;)Z","invokeinterface",445);}
case 445:{f.StackOp("pop");f.Pc=446;continue;}
case 446:{f.Push(f.Locals[1]);f.Pc=447;continue;}
case 447:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","variables","Ljava/util/Map;"));f.Pc=450;continue;}
case 450:{f.Pc=f.Pop().Reference!=null?464:453;continue;}
case 453:{f.Push(f.Locals[1]);f.Pc=454;continue;}
case 454:{f.Push(f.Locals[0]);f.Pc=455;continue;}
case 455:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","variables","Ljava/util/Map;"));f.Pc=458;continue;}
case 458:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","variables","Ljava/util/Map;",value);f.Pc=461;continue;}
case 461:{f.Pc=479;continue;}
case 464:{f.Push(f.Locals[0]);f.Pc=465;continue;}
case 465:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","variables","Ljava/util/Map;"));f.Pc=468;continue;}
case 468:{f.Push(f.Locals[1]);f.Pc=469;continue;}
case 469:{return rt.DynamicCall(f,"forge/card/CardFace:559:469:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/card/CardFace;)Ljava/util/function/BiConsumer;",474);}
case 474:{return rt.Call(f,"java/util/Map","forEach","(Ljava/util/function/BiConsumer;)V","invokeinterface",479);}
case 479:{f.Push(f.Locals[1]);f.Pc=480;continue;}
case 480:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","nonAbilityText","Ljava/lang/String;"));f.Pc=483;continue;}
case 483:{f.Pc=f.Pop().Reference!=null?494:486;continue;}
case 486:{f.Push(f.Locals[1]);f.Pc=487;continue;}
case 487:{f.Push(f.Locals[0]);f.Pc=488;continue;}
case 488:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","nonAbilityText","Ljava/lang/String;"));f.Pc=491;continue;}
case 491:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","nonAbilityText","Ljava/lang/String;",value);f.Pc=494;continue;}
case 494:{f.Push(f.Locals[1]);f.Pc=495;continue;}
case 495:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","draftActions","Ljava/util/List;"));f.Pc=498;continue;}
case 498:{f.Pc=f.Pop().Reference!=null?509:501;continue;}
case 501:{f.Push(f.Locals[1]);f.Pc=502;continue;}
case 502:{f.Push(f.Locals[0]);f.Pc=503;continue;}
case 503:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","draftActions","Ljava/util/List;"));f.Pc=506;continue;}
case 506:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","draftActions","Ljava/util/List;",value);f.Pc=509;continue;}
case 509:{f.Push(f.Locals[1]);f.Pc=510;continue;}
case 510:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","attractionLights","Ljava/util/Set;"));f.Pc=513;continue;}
case 513:{f.Pc=f.Pop().Reference!=null?524:516;continue;}
case 516:{f.Push(f.Locals[1]);f.Pc=517;continue;}
case 517:{f.Push(f.Locals[0]);f.Pc=518;continue;}
case 518:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","attractionLights","Ljava/util/Set;"));f.Pc=521;continue;}
case 521:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFace","attractionLights","Ljava/util/Set;",value);f.Pc=524;continue;}
case 524:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M560(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardFace","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M561(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardFace","getName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",10);}
case 10:{return rt.Call(f,"java/lang/String","compareTo","(Ljava/lang/String;)I","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M562(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","clone","()Ljava/lang/Object;","invokespecial",4);}
case 4:{return JStep.Return(f.Pop());}
case 5:{f.Locals[1]=f.Pop();f.Pc=6;continue;}
case 6:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",14);}
case 14:{return rt.DynamicCall(f,"forge/card/CardFace:562:14:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",19);}
case 19:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",22);}
case 22:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M563(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardFace","compareTo","(Lforge/card/ICardFace;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M564(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFace","variables","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/Map","putIfAbsent","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",11);}
case 11:{f.StackOp("pop");f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M565(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{return rt.Call(f,"java/util/Collections","unmodifiableList","(Ljava/util/List;)Ljava/util/List;","invokestatic",10);}
case 10:{if(!rt.StaticReady(f,"forge/card/CardFace","emptyList","Ljava/util/List;"))return JStep.Continue;rt.PutStatic("forge/card/CardFace","emptyList","Ljava/util/List;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"java/util/TreeMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeMap")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/TreeMap","<init>","()V","invokespecial",20);}
case 20:{return rt.Call(f,"java/util/Collections","unmodifiableMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",23);}
case 23:{if(!rt.StaticReady(f,"forge/card/CardFace","emptyMap","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/card/CardFace","emptyMap","Ljava/util/Map;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",33);}
case 33:{return rt.Call(f,"java/util/Collections","unmodifiableSet","(Ljava/util/Set;)Ljava/util/Set;","invokestatic",36);}
case 36:{if(!rt.StaticReady(f,"forge/card/CardFace","emptySet","Ljava/util/Set;"))return JStep.Continue;rt.PutStatic("forge/card/CardFace","emptySet","Ljava/util/Set;",f.Pop());f.Pc=39;continue;}
case 39:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
