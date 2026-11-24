// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C882{
internal static JClass Build(){var c=new JClass("forge/game/trigger/Trigger","forge/game/TriggerReplacementBase",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("maxId","I",true,JValue.Default("I"),null));
c.Add(new JField("id","I",false,JValue.Default("I"),null));
c.Add(new JField("mode","Lforge/game/trigger/TriggerType;",false,JValue.Default("Lforge/game/trigger/TriggerType;"),null));
c.Add(new JField("triggerRemembered","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("validPhases","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("spawningAbility","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JField("checkedEvent","Lforge/game/trigger/TriggerWaiting;",false,JValue.Default("Lforge/game/trigger/TriggerWaiting;"),null));
c.Add(new JField("checkedObjects","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(10120,"forge/game/trigger/Trigger","nextId","()I",10,0,2,new JHandler[]{},M10120));
c.Add(new JMethod(10121,"forge/game/trigger/Trigger","resetIDs","()V",9,0,1,new JHandler[]{},M10121));
c.Add(new JMethod(10122,"forge/game/trigger/Trigger","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,6,2,new JHandler[]{},M10122));
c.Add(new JMethod(10123,"forge/game/trigger/Trigger","toString","()Ljava/lang/String;",17,1,2,new JHandler[]{},M10123));
c.Add(new JMethod(10124,"forge/game/trigger/Trigger","toString","(Z)Ljava/lang/String;",1,6,4,new JHandler[]{},M10124));
c.Add(new JMethod(10125,"forge/game/trigger/Trigger","replaceAbilityText","(Ljava/lang/String;Lforge/game/card/CardState;)Ljava/lang/String;",17,4,3,new JHandler[]{},M10125));
c.Add(new JMethod(10126,"forge/game/trigger/Trigger","replaceAbilityText","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",17,3,4,new JHandler[]{},M10126));
c.Add(new JMethod(10127,"forge/game/trigger/Trigger","replaceAbilityText","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Z)Ljava/lang/String;",17,9,4,new JHandler[]{},M10127));
c.Add(new JMethod(10128,"forge/game/trigger/Trigger","phasesCheck","(Lforge/game/Game;)Z",17,4,2,new JHandler[]{},M10128));
c.Add(new JMethod(10129,"forge/game/trigger/Trigger","refersToTriggering","(Lforge/game/ability/AbilityKey;)Z",20,5,2,new JHandler[]{},M10129));
c.Add(new JMethod(10130,"forge/game/trigger/Trigger","requirementsCheck","(Lforge/game/Game;)Z",17,6,2,new JHandler[]{},M10130));
c.Add(new JMethod(10131,"forge/game/trigger/Trigger","checkResolvedLimit","(Lforge/game/player/Player;)Z",1,2,3,new JHandler[]{},M10131));
c.Add(new JMethod(10132,"forge/game/trigger/Trigger","limitByActivations","(I)I",1,2,3,new JHandler[]{},M10132));
c.Add(new JMethod(10133,"forge/game/trigger/Trigger","meetsRequirementsOnTriggeredObjects","(Lforge/game/Game;Ljava/util/Map;)Z",1,7,2,new JHandler[]{},M10133));
c.Add(new JMethod(10134,"forge/game/trigger/Trigger","paramsWithoutEvent","()Ljava/util/Map;",2,5,3,new JHandler[]{},M10134));
c.Add(new JMethod(10135,"forge/game/trigger/Trigger","checkWith","(Lforge/game/trigger/TriggerWaiting;Ljava/util/function/BooleanSupplier;)Z",17,5,2,new JHandler[]{new JHandler(5,12,19,""),new JHandler(19,21,19,"")},M10135));
c.Add(new JMethod(10136,"forge/game/trigger/Trigger","checkWith","(Lforge/game/spellability/SpellAbility;Ljava/util/function/BooleanSupplier;)Z",17,5,2,new JHandler[]{new JHandler(8,15,22,""),new JHandler(22,24,22,"")},M10136));
c.Add(new JMethod(10137,"forge/game/trigger/Trigger","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M10137));
c.Add(new JMethod(10138,"forge/game/trigger/Trigger","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M10138));
c.Add(new JMethod(10139,"forge/game/trigger/Trigger","hashCode","()I",1,1,4,new JHandler[]{},M10139));
c.Add(new JMethod(10140,"forge/game/trigger/Trigger","performTest","(Ljava/util/Map;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(10141,"forge/game/trigger/Trigger","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(10142,"forge/game/trigger/Trigger","buildTriggeringObjects","(Ljava/util/Map;)Ljava/util/Map;",17,3,3,new JHandler[]{},M10142));
c.Add(new JMethod(10143,"forge/game/trigger/Trigger","getId","()I",1,1,1,new JHandler[]{},M10143));
c.Add(new JMethod(10144,"forge/game/trigger/Trigger","setId","(I)V",17,2,2,new JHandler[]{},M10144));
c.Add(new JMethod(10145,"forge/game/trigger/Trigger","addRemembered","(Ljava/lang/Object;)V",1,2,2,new JHandler[]{},M10145));
c.Add(new JMethod(10146,"forge/game/trigger/Trigger","addRemembered","(Ljava/util/Collection;)V",1,2,2,new JHandler[]{},M10146));
c.Add(new JMethod(10147,"forge/game/trigger/Trigger","getTriggerRemembered","()Ljava/util/List;",1,1,1,new JHandler[]{},M10147));
c.Add(new JMethod(10148,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;",1,1,1,new JHandler[]{},M10148));
c.Add(new JMethod(10149,"forge/game/trigger/Trigger","setMode","(Lforge/game/trigger/TriggerType;)V",0,2,2,new JHandler[]{},M10149));
c.Add(new JMethod(10150,"forge/game/trigger/Trigger","copy","(Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;",17,3,5,new JHandler[]{},M10150));
c.Add(new JMethod(10151,"forge/game/trigger/Trigger","copy","(Lforge/game/card/Card;ZZ)Lforge/game/trigger/Trigger;",17,4,5,new JHandler[]{},M10151));
c.Add(new JMethod(10152,"forge/game/trigger/Trigger","copy","(Lforge/game/card/Card;ZZLforge/game/spellability/SpellAbility;)Lforge/game/trigger/Trigger;",17,6,4,new JHandler[]{},M10152));
c.Add(new JMethod(10153,"forge/game/trigger/Trigger","isStatic","()Z",1,1,2,new JHandler[]{},M10153));
c.Add(new JMethod(10154,"forge/game/trigger/Trigger","setTriggerPhases","(Ljava/util/Set;)V",1,2,2,new JHandler[]{},M10154));
c.Add(new JMethod(10155,"forge/game/trigger/Trigger","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(10156,"forge/game/trigger/Trigger","getSpawningAbility","()Lforge/game/spellability/SpellAbility;",1,1,1,new JHandler[]{},M10156));
c.Add(new JMethod(10157,"forge/game/trigger/Trigger","setSpawningAbility","(Lforge/game/spellability/SpellAbility;)V",1,2,2,new JHandler[]{},M10157));
c.Add(new JMethod(10158,"forge/game/trigger/Trigger","getActivationsThisTurn","()I",1,1,2,new JHandler[]{},M10158));
c.Add(new JMethod(10159,"forge/game/trigger/Trigger","getActivationsThisGame","()I",1,1,2,new JHandler[]{},M10159));
c.Add(new JMethod(10160,"forge/game/trigger/Trigger","triggerRun","()V",1,1,2,new JHandler[]{},M10160));
c.Add(new JMethod(10161,"forge/game/trigger/Trigger","clone","()Ljava/lang/Object;",17,2,3,new JHandler[]{new JHandler(0,4,5,"java/lang/Exception")},M10161));
c.Add(new JMethod(10162,"forge/game/trigger/Trigger","ensureAbility","(Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;",1,4,3,new JHandler[]{},M10162));
c.Add(new JMethod(10163,"forge/game/trigger/Trigger","ensureAbility","()Lforge/game/spellability/SpellAbility;",1,1,2,new JHandler[]{},M10163));
c.Add(new JMethod(10164,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V",1,2,2,new JHandler[]{},M10164));
c.Add(new JMethod(10165,"forge/game/trigger/Trigger","whileKeywordCheck","(Ljava/lang/String;Ljava/util/Map;)Z",0,7,3,new JHandler[]{},M10165));
c.Add(new JMethod(10166,"forge/game/trigger/Trigger","isChapter","()Z",1,1,2,new JHandler[]{},M10166));
c.Add(new JMethod(10167,"forge/game/trigger/Trigger","getChapter","()Ljava/lang/Integer;",1,1,2,new JHandler[]{},M10167));
c.Add(new JMethod(10168,"forge/game/trigger/Trigger","isLastChapter","()Z",1,1,2,new JHandler[]{},M10168));
c.Add(new JMethod(10169,"forge/game/trigger/Trigger","isManaAbility","()Z",1,1,2,new JHandler[]{},M10169));
c.Add(new JMethod(10170,"forge/game/trigger/Trigger","looksBackInTime","()Z",1,1,6,new JHandler[]{},M10170));
c.Add(new JMethod(10171,"forge/game/trigger/Trigger","lambda$meetsRequirementsOnTriggeredObjects$1","(Lforge/game/player/Player;Lforge/game/mana/Mana;)Z",4106,2,2,new JHandler[]{},M10171));
c.Add(new JMethod(10172,"forge/game/trigger/Trigger","lambda$refersToTriggering$0","(Ljava/lang/String;Ljava/lang/String;)Z",4098,3,2,new JHandler[]{},M10172));
c.Add(new JMethod(10173,"forge/game/trigger/Trigger","<clinit>","()V",8,0,1,new JHandler[]{},M10173));
}

internal static JStep M10120(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/trigger/Trigger","maxId","I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/Trigger","maxId","I"));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/trigger/Trigger","maxId","I"))return JStep.Continue;rt.PutStatic("forge/game/trigger/Trigger","maxId","I",f.Pop());f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10121(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(50000));f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/game/trigger/Trigger","maxId","I"))return JStep.Continue;rt.PutStatic("forge/game/trigger/Trigger","maxId","I",f.Pop());f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10122(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/TriggerReplacementBase","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/Trigger","triggerRemembered","Ljava/util/List;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/trigger/Trigger","nextId","()I","invokestatic",15);}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/Trigger","id","I",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/Trigger","intrinsic","Z",value);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","originalMapParams","Ljava/util/Map;"));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",33);}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","mapParams","Ljava/util/Map;"));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Map","putAll","(Ljava/util/Map;)V","invokeinterface",43);}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/trigger/Trigger","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",48);}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("TriggerZones")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",54);}
case 54:{f.Locals[4]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(JValue.R(null));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?74:62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",68);}
case 68:{return rt.Call(f,"java/util/EnumSet","copyOf","(Ljava/util/Collection;)Ljava/util/EnumSet;","invokestatic",71);}
case 71:{return rt.Call(f,"forge/game/trigger/Trigger","setActiveZone","(Ljava/util/EnumSet;)V","invokevirtual",74);}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("Phase")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",80);}
case 80:{f.Locals[5]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(JValue.R(null));f.Pc=83;continue;}
case 83:{f.Push(f.Locals[5]);f.Pc=85;continue;}
case 85:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?97:88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[5]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/phase/PhaseType","parseRange","(Ljava/lang/String;)Ljava/util/Set;","invokestatic",94);}
case 94:{return rt.Call(f,"forge/game/trigger/Trigger","setTriggerPhases","(Ljava/util/Set;)V","invokevirtual",97);}
case 97:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10123(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(0));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/trigger/Trigger","toString","(Z)Ljava/lang/String;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10124(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("TriggerDescription")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?16:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/trigger/Trigger","isSuppressed","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?19:16;continue;}
case 16:{f.Push(JValue.R(rt.String("")));f.Pc=18;continue;}
case 18:{return JStep.Return(f.Pop());}
case 19:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/trigger/Trigger","getHostName","(Lforge/game/CardTraitBase;)Lforge/util/ITranslatable;","invokevirtual",32);}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("TriggerDescription")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",39);}
case 39:{f.Locals[4]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("ABILITY")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int!=0?132:51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("TriggerDescription")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",57);}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/util/CardTranslation","translateSingleDescriptionText","(Ljava/lang/String;Lforge/util/ITranslatable;)Ljava/lang/String;","invokestatic",61);}
case 61:{f.Locals[4]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/util/ITranslatable","getTranslatedName","()Ljava/lang/String;","invokeinterface",69);}
case 69:{f.Locals[5]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=75;continue;}
case 75:{f.Push(f.Locals[5]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",80);}
case 80:{f.Locals[4]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("NICKNAME")));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",89);}
case 89:{f.Push(f.Locals[5]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/util/Lang","getNickName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",94);}
case 94:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",97);}
case 97:{f.Locals[4]=f.Pop();f.Pc=99;continue;}
case 99:{f.Push(f.Locals[4]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("ORIGINALHOST")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?132:109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/trigger/Trigger","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Reference==null?132:116;continue;}
case 116:{f.Push(f.Locals[4]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("ORIGINALHOST")));f.Pc=120;continue;}
case 120:{f.Push(f.Locals[0]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/trigger/Trigger","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",124);}
case 124:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",127);}
case 127:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",130);}
case 130:{f.Locals[4]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",136);}
case 136:{return rt.Call(f,"forge/game/card/Card","getEffectSource","()Lforge/game/card/Card;","invokevirtual",139);}
case 139:{f.Pc=f.Pop().Reference==null?187:142;continue;}
case 142:{f.Push(f.Locals[1]);f.Pc=143;continue;}
case 143:{f.Pc=f.Pop().Int==0?168:146;continue;}
case 146:{f.Push(f.Locals[4]);f.Pc=148;continue;}
case 148:{f.Push(JValue.R(rt.String("EFFECTSOURCE")));f.Pc=150;continue;}
case 150:{f.Push(f.Locals[0]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",154);}
case 154:{return rt.Call(f,"forge/game/card/Card","getEffectSource","()Lforge/game/card/Card;","invokevirtual",157);}
case 157:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",160);}
case 160:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",163);}
case 163:{f.Locals[4]=f.Pop();f.Pc=165;continue;}
case 165:{f.Pc=187;continue;}
case 168:{f.Push(f.Locals[4]);f.Pc=170;continue;}
case 170:{f.Push(JValue.R(rt.String("EFFECTSOURCE")));f.Pc=172;continue;}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",176);}
case 176:{return rt.Call(f,"forge/game/card/Card","getEffectSource","()Lforge/game/card/Card;","invokevirtual",179);}
case 179:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",182);}
case 182:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",185);}
case 185:{f.Locals[4]=f.Pop();f.Pc=187;continue;}
case 187:{f.Push(f.Locals[2]);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[4]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",193);}
case 193:{f.StackOp("pop");f.Pc=194;continue;}
case 194:{f.Push(f.Locals[2]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",198);}
case 198:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10125(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ABILITY")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int!=0?11:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return JStep.Return(f.Pop());}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/trigger/Trigger","ensureAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/trigger/Trigger","replaceAbilityText","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Ljava/lang/String;","invokevirtual",22);}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10126(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","replaceAbilityText","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Z)Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10127(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Locals[4]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[4]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("ABILITY")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int!=0?16:13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Reference!=null?25:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/trigger/Trigger","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",24);}
case 24:{f.Locals[2]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Pc=f.Pop().Reference==null?342:29;continue;}
case 29:{f.Push(JValue.R(rt.String("")));f.Pc=31;continue;}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{f.Locals[6]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","isWrapper","()Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?77:43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/WrappedAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{f.Locals[7]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[7]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/trigger/WrappedAbility","getWrappedAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",54);}
case 54:{f.Locals[2]=f.Pop();f.Pc=55;continue;}
case 55:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"));f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",62);}
case 62:{return rt.Call(f,"forge/game/ability/ApiType","equals","(Ljava/lang/Object;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?77:68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/spellability/SpellAbility","getStackDescription","()Ljava/lang/String;","invokevirtual",72);}
case 72:{f.Locals[5]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(JValue.I(0));f.Pc=75;continue;}
case 75:{f.Locals[6]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[6]);f.Pc=79;continue;}
case 79:{f.Pc=f.Pop().Int==0?171:82;continue;}
case 82:{f.Push(f.Locals[2]);f.Pc=83;continue;}
case 83:{f.Locals[7]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[7]);f.Pc=87;continue;}
case 87:{f.Pc=f.Pop().Reference==null?171:90;continue;}
case 90:{f.Push(f.Locals[7]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/spellability/SpellAbility","getApi","()Lforge/game/ability/ApiType;","invokevirtual",95);}
case 95:{f.Locals[8]=f.Pop();f.Pc=97;continue;}
case 97:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Charm","Lforge/game/ability/ApiType;"));f.Pc=100;continue;}
case 100:{f.Push(f.Locals[8]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/ability/ApiType","equals","(Ljava/lang/Object;)Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int==0?127:108;continue;}
case 108:{f.Push(f.Locals[7]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[3]);f.Pc=111;continue;}
case 111:{f.Pc=f.Pop().Int!=0?118:114;continue;}
case 114:{f.Push(JValue.I(1));f.Pc=115;continue;}
case 115:{f.Pc=119;continue;}
case 118:{f.Push(JValue.I(0));f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/ability/effects/CharmEffect","makeFormatedDescription","(Lforge/game/spellability/SpellAbility;Z)Ljava/lang/String;","invokestatic",122);}
case 122:{f.Locals[5]=f.Pop();f.Pc=124;continue;}
case 124:{f.Pc=171;continue;}
case 127:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ImmediateTrigger","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ImmediateTrigger","Lforge/game/ability/ApiType;"));f.Pc=130;continue;}
case 130:{f.Push(f.Locals[8]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/ability/ApiType","equals","(Ljava/lang/Object;)Z","invokevirtual",135);}
case 135:{f.Pc=f.Pop().Int!=0?149:138;continue;}
case 138:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","DelayedTrigger","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","DelayedTrigger","Lforge/game/ability/ApiType;"));f.Pc=141;continue;}
case 141:{f.Push(f.Locals[8]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/ability/ApiType","equals","(Ljava/lang/Object;)Z","invokevirtual",146);}
case 146:{f.Pc=f.Pop().Int==0?161:149;continue;}
case 149:{f.Push(f.Locals[7]);f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String("Execute")));f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",156);}
case 156:{f.Locals[7]=f.Pop();f.Pc=158;continue;}
case 158:{f.Pc=168;continue;}
case 161:{f.Push(f.Locals[7]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",166);}
case 166:{f.Locals[7]=f.Pop();f.Pc=168;continue;}
case 168:{f.Pc=85;continue;}
case 171:{f.Push(f.Locals[5]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",176);}
case 176:{f.Pc=f.Pop().Int==0?185:179;continue;}
case 179:{f.Push(f.Locals[2]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/spellability/SpellAbility","toString","()Ljava/lang/String;","invokevirtual",183);}
case 183:{f.Locals[5]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[5]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",190);}
case 190:{f.Locals[5]=f.Pop();f.Pc=192;continue;}
case 192:{f.Push(f.Locals[5]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",197);}
case 197:{f.Pc=f.Pop().Int!=0?274:200;continue;}
case 200:{f.Push(f.Locals[5]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[2]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",206);}
case 206:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",209);}
case 209:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",212);}
case 212:{f.Pc=f.Pop().Int!=0?238:215;continue;}
case 215:{f.Push(f.Locals[5]);f.Pc=217;continue;}
case 217:{f.Push(JValue.I(0));f.Pc=218;continue;}
case 218:{f.Push(JValue.I(1));f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",222);}
case 222:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",225);}
case 225:{f.Push(f.Locals[5]);f.Pc=227;continue;}
case 227:{f.Push(JValue.I(1));f.Pc=228;continue;}
case 228:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",231);}
case 231:{return rt.DynamicCall(f,"forge/game/trigger/Trigger:10127:231:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",236);}
case 236:{f.Locals[5]=f.Pop();f.Pc=238;continue;}
case 238:{f.Push(f.Locals[5]);f.Pc=240;continue;}
case 240:{f.Push(JValue.R(rt.String("ORIGINALHOST")));f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",245);}
case 245:{f.Pc=f.Pop().Int==0?279:248;continue;}
case 248:{f.Push(f.Locals[2]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",252);}
case 252:{f.Pc=f.Pop().Reference==null?279:255;continue;}
case 255:{f.Push(f.Locals[5]);f.Pc=257;continue;}
case 257:{f.Push(JValue.R(rt.String("ORIGINALHOST")));f.Pc=259;continue;}
case 259:{f.Push(f.Locals[2]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",263);}
case 263:{return rt.Call(f,"forge/game/card/Card","getDisplayName","()Ljava/lang/String;","invokevirtual",266);}
case 266:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",269);}
case 269:{f.Locals[5]=f.Pop();f.Pc=271;continue;}
case 271:{f.Pc=279;continue;}
case 274:{f.Push(JValue.R(rt.String("<take no action>")));f.Pc=277;continue;}
case 277:{f.Locals[5]=f.Pop();f.Pc=279;continue;}
case 279:{f.Push(f.Locals[4]);f.Pc=281;continue;}
case 281:{f.Push(JValue.R(rt.String("ABILITY")));f.Pc=283;continue;}
case 283:{f.Push(f.Locals[5]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",288);}
case 288:{f.Push(JValue.I(1));f.Pc=289;continue;}
case 289:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","tidyDescription","(Ljava/lang/String;Z)Ljava/lang/String;","invokestatic",292);}
case 292:{f.Locals[4]=f.Pop();f.Pc=294;continue;}
case 294:{f.Push(f.Locals[4]);f.Pc=296;continue;}
case 296:{f.Push(f.Locals[2]);f.Pc=297;continue;}
case 297:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",300);}
case 300:{return rt.Call(f,"forge/util/CardTranslation","translateMultipleDescriptionText","(Ljava/lang/String;Lforge/util/ITranslatable;)Ljava/lang/String;","invokestatic",303);}
case 303:{f.Locals[4]=f.Pop();f.Pc=305;continue;}
case 305:{f.Push(f.Locals[2]);f.Pc=306;continue;}
case 306:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",309);}
case 309:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",312);}
case 312:{f.Locals[7]=f.Pop();f.Pc=314;continue;}
case 314:{f.Push(f.Locals[4]);f.Pc=316;continue;}
case 316:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=318;continue;}
case 318:{f.Push(f.Locals[7]);f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",323);}
case 323:{f.Locals[4]=f.Pop();f.Pc=325;continue;}
case 325:{f.Push(f.Locals[4]);f.Pc=327;continue;}
case 327:{f.Push(JValue.R(rt.String("NICKNAME")));f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",332);}
case 332:{f.Push(f.Locals[7]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"forge/util/Lang","getNickName","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",337);}
case 337:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",340);}
case 340:{f.Locals[4]=f.Pop();f.Pc=342;continue;}
case 342:{f.Push(f.Locals[4]);f.Pc=344;continue;}
case 344:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10128(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","validPhases","Ljava/util/Set;"));f.Pc=10;continue;}
case 10:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?53:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","validPhases","Ljava/util/Set;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPhase","()Lforge/game/phase/PhaseType;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int!=0?31:29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("PhaseCount")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?53:41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/phase/PhaseHandler","getNumMain","()I","invokevirtual",45);}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=47;continue;}
case 47:{f.Push(JValue.I(2));f.Pc=48;continue;}
case 48:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?53:51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("PlayerTurn")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Int==0?79:63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",68);}
case 68:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",71);}
case 71:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int!=0?79:77;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("NotPlayerTurn")));f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int==0?105:89;continue;}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",94);}
case 94:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",97);}
case 97:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int==0?105:103;continue;}
case 103:{f.Push(JValue.I(0));f.Pc=104;continue;}
case 104:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("OpponentTurn")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Int==0?134:115;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",119);}
case 119:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",122);}
case 122:{f.Push(f.Locals[2]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPlayerTurn","()Lforge/game/player/Player;","invokevirtual",126);}
case 126:{return rt.Call(f,"forge/game/player/Player","isOpponentOf","(Lforge/game/player/Player;)Z","invokevirtual",129);}
case 129:{f.Pc=f.Pop().Int!=0?134:132;continue;}
case 132:{f.Push(JValue.I(0));f.Pc=133;continue;}
case 133:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{f.Push(JValue.R(rt.String("FirstUpkeep")));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",141);}
case 141:{f.Pc=f.Pop().Int==0?153:144;continue;}
case 144:{f.Push(f.Locals[2]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/phase/PhaseHandler","isFirstUpkeep","()Z","invokevirtual",148);}
case 148:{f.Pc=f.Pop().Int!=0?153:151;continue;}
case 151:{f.Push(JValue.I(0));f.Pc=152;continue;}
case 152:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("FirstUpkeepThisGame")));f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",160);}
case 160:{f.Pc=f.Pop().Int==0?172:163;continue;}
case 163:{f.Push(f.Locals[2]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/phase/PhaseHandler","isFirstUpkeepThisGame","()Z","invokevirtual",167);}
case 167:{f.Pc=f.Pop().Int!=0?172:170;continue;}
case 170:{f.Push(JValue.I(0));f.Pc=171;continue;}
case 171:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{f.Push(JValue.R(rt.String("FirstCombat")));f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",179);}
case 179:{f.Pc=f.Pop().Int==0?191:182;continue;}
case 182:{f.Push(f.Locals[2]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/phase/PhaseHandler","isFirstCombat","()Z","invokevirtual",186);}
case 186:{f.Pc=f.Pop().Int!=0?191:189;continue;}
case 189:{f.Push(JValue.I(0));f.Pc=190;continue;}
case 190:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 191:{f.Push(f.Locals[0]);f.Pc=192;continue;}
case 192:{f.Push(JValue.R(rt.String("TurnCount")));f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",198);}
case 198:{f.Pc=f.Pop().Int==0?222:201;continue;}
case 201:{f.Push(f.Locals[0]);f.Pc=202;continue;}
case 202:{f.Push(JValue.R(rt.String("TurnCount")));f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",208);}
case 208:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",211);}
case 211:{f.Locals[3]=f.Pop();f.Pc=212;continue;}
case 212:{f.Push(f.Locals[2]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/phase/PhaseHandler","getTurn","()I","invokevirtual",216);}
case 216:{f.Push(f.Locals[3]);f.Pc=217;continue;}
case 217:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?222:220;continue;}
case 220:{f.Push(JValue.I(0));f.Pc=221;continue;}
case 221:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 222:{f.Push(JValue.I(1));f.Pc=223;continue;}
case 223:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10129(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",4);}
case 4:{return rt.DynamicCall(f,"forge/game/trigger/Trigger:10129:4:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",9);}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.DynamicCall(f,"forge/game/trigger/Trigger:10129:12:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/trigger/Trigger;Ljava/lang/String;)Ljava/util/function/Predicate;",17);}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/trigger/Trigger","getMapParams","()Ljava/util/Map;","invokevirtual",22);}
case 22:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",27);}
case 27:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",32);}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",38);}
case 38:{f.Pc=f.Pop().Int==0?43:41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/trigger/Trigger","ensureAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",47);}
case 47:{f.Locals[4]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{f.Pc=f.Pop().Reference==null?90:54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/spellability/SpellAbility","getMapParams","()Ljava/util/Map;","invokevirtual",59);}
case 59:{return rt.Call(f,"java/util/Map","values","()Ljava/util/Collection;","invokeinterface",64);}
case 64:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",69);}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",75);}
case 75:{f.Pc=f.Pop().Int==0?80:78;continue;}
case 78:{f.Push(JValue.I(1));f.Pc=79;continue;}
case 79:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 80:{f.Push(f.Locals[4]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/spellability/SpellAbility","getSubAbility","()Lforge/game/spellability/AbilitySub;","invokevirtual",85);}
case 85:{f.Locals[4]=f.Pop();f.Pc=87;continue;}
case 87:{f.Pc=49;continue;}
case 90:{f.Push(JValue.I(0));f.Pc=91;continue;}
case 91:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10130(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("APlayerHasMoreLifeThanEachOther")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?125:10;continue;}
case 10:{f.Push(JValue.I(int.MinValue));f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",21);}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",29);}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",38);}
case 38:{f.Pc=f.Pop().Int==0?113:41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{f.Locals[5]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[5]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",58);}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?86:62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",68);}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",73);}
case 73:{f.Locals[2]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[5]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Pc=110;continue;}
case 86:{f.Push(f.Locals[5]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",91);}
case 91:{f.Push(f.Locals[2]);f.Pc=92;continue;}
case 92:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?110:95;continue;}
case 95:{f.Push(f.Locals[5]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",100);}
case 100:{f.Locals[2]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[3]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[5]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",109);}
case 109:{f.StackOp("pop");f.Pc=110;continue;}
case 110:{f.Pc=31;continue;}
case 113:{f.Push(f.Locals[3]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",119);}
case 119:{f.Push(JValue.I(1));f.Pc=120;continue;}
case 120:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?125:123;continue;}
case 123:{f.Push(JValue.I(0));f.Pc=124;continue;}
case 124:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("APlayerHasMostCardsInHand")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",132);}
case 132:{f.Pc=f.Pop().Int==0?280:135;continue;}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{f.Locals[2]=f.Pop();f.Pc=137;continue;}
case 137:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=140;continue;}
case 140:{f.StackOp("dup");f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",144);}
case 144:{f.Locals[3]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[1]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",149);}
case 149:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",152);}
case 152:{f.Locals[4]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[4]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",161);}
case 161:{f.Pc=f.Pop().Int==0?268:164;continue;}
case 164:{f.Push(f.Locals[4]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",171);}
case 171:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=174;continue;}
case 174:{f.Locals[5]=f.Pop();f.Pc=176;continue;}
case 176:{f.Push(f.Locals[5]);f.Pc=178;continue;}
case 178:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",184);}
case 184:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",189);}
case 189:{f.Push(f.Locals[2]);f.Pc=190;continue;}
case 190:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?225:193;continue;}
case 193:{f.Push(f.Locals[3]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",199);}
case 199:{f.Push(f.Locals[5]);f.Pc=201;continue;}
case 201:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",207);}
case 207:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",212);}
case 212:{f.Locals[2]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[3]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[5]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",221);}
case 221:{f.StackOp("pop");f.Pc=222;continue;}
case 222:{f.Pc=265;continue;}
case 225:{f.Push(f.Locals[5]);f.Pc=227;continue;}
case 227:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",233);}
case 233:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",238);}
case 238:{f.Push(f.Locals[2]);f.Pc=239;continue;}
case 239:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?265:242;continue;}
case 242:{f.Push(f.Locals[5]);f.Pc=244;continue;}
case 244:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",250);}
case 250:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",255);}
case 255:{f.Locals[2]=f.Pop();f.Pc=256;continue;}
case 256:{f.Push(f.Locals[3]);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[5]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",264);}
case 264:{f.StackOp("pop");f.Pc=265;continue;}
case 265:{f.Pc=154;continue;}
case 268:{f.Push(f.Locals[3]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",274);}
case 274:{f.Push(JValue.I(1));f.Pc=275;continue;}
case 275:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?280:278;continue;}
case 278:{f.Push(JValue.I(0));f.Pc=279;continue;}
case 279:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 280:{f.Push(f.Locals[0]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",284);}
case 284:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",287);}
case 287:{f.Pc=f.Pop().Reference==null?342:290;continue;}
case 290:{f.Push(f.Locals[1]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/game/Game","getAge","()Lforge/game/GameStage;","invokevirtual",294);}
case 294:{if(!rt.StaticReady(f,"forge/game/GameStage","Play","Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","Play","Lforge/game/GameStage;"));f.Pc=297;continue;}
case 297:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?310:300;continue;}
case 300:{f.Push(f.Locals[1]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/game/Game","getAge","()Lforge/game/GameStage;","invokevirtual",304);}
case 304:{if(!rt.StaticReady(f,"forge/game/GameStage","RestartedByKarn","Lforge/game/GameStage;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameStage","RestartedByKarn","Lforge/game/GameStage;"));f.Pc=307;continue;}
case 307:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?342:310;continue;}
case 310:{f.Push(f.Locals[0]);f.Pc=311;continue;}
case 311:{f.Push(f.Locals[0]);f.Pc=312;continue;}
case 312:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","checkedEvent","Lforge/game/trigger/TriggerWaiting;"));f.Pc=315;continue;}
case 315:{f.Pc=f.Pop().Reference!=null?332:318;continue;}
case 318:{f.Push(f.Locals[0]);f.Pc=319;continue;}
case 319:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","checkedObjects","Ljava/util/Map;"));f.Pc=322;continue;}
case 322:{f.Pc=f.Pop().Reference!=null?332:325;continue;}
case 325:{f.Push(f.Locals[0]);f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/game/trigger/Trigger","paramsWithoutEvent","()Ljava/util/Map;","invokevirtual",329);}
case 329:{f.Pc=336;continue;}
case 332:{f.Push(f.Locals[0]);f.Pc=333;continue;}
case 333:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","mapParams","Ljava/util/Map;"));f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/trigger/Trigger","meetsCommonRequirements","(Ljava/util/Map;)Z","invokevirtual",339);}
case 339:{f.Pc=f.Pop().Int!=0?344:342;continue;}
case 342:{f.Push(JValue.I(0));f.Pc=343;continue;}
case 343:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 344:{f.Push(f.Locals[0]);f.Pc=345;continue;}
case 345:{f.Push(f.Locals[0]);f.Pc=346;continue;}
case 346:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",349);}
case 349:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",352);}
case 352:{return rt.Call(f,"forge/game/trigger/Trigger","checkResolvedLimit","(Lforge/game/player/Player;)Z","invokevirtual",355);}
case 355:{f.Pc=f.Pop().Int!=0?360:358;continue;}
case 358:{f.Push(JValue.I(0));f.Pc=359;continue;}
case 359:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 360:{f.Push(JValue.I(1));f.Pc=361;continue;}
case 361:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10131(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("ResolvedLimit")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?42:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/trigger/Trigger","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/game/card/Card","getAbilityResolvedThisTurnActivators","(Lforge/game/spellability/SpellAbility;)Lcom/google/common/collect/Multiset;","invokevirtual",21);}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"com/google/common/collect/Multiset","count","(Ljava/lang/Object;)I","invokeinterface",27);}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("ResolvedLimit")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",34);}
case 34:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",37);}
case 37:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?42:40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10132(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("GameActivationLimit")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?30:10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("GameActivationLimit")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",18);}
case 18:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",21);}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/trigger/Trigger","getActivationsThisGame","()I","invokevirtual",25);}
case 25:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",29);}
case 29:{f.Locals[1]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("ActivationLimit")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?60:40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("ActivationLimit")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",48);}
case 48:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",51);}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/trigger/Trigger","getActivationsThisTurn","()I","invokevirtual",55);}
case 55:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",59);}
case 59:{f.Locals[1]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",65);}
case 65:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10133(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Condition")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","EVOLVE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","EVOLVE","Lforge/game/keyword/Keyword;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/trigger/Trigger","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int!=0?28:18;continue;}
case 18:{f.Push(JValue.R(rt.String("Evolve")));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?101:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[4]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[4]);f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Reference!=null?49:47;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int==0?67:57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",61);}
case 61:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int!=0?69:67;continue;}
case 67:{f.Push(JValue.I(0));f.Pc=68;continue;}
case 68:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",74);}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",78);}
case 78:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",81);}
case 81:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?101:84;continue;}
case 84:{f.Push(f.Locals[4]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",89);}
case 89:{f.Push(f.Locals[0]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",93);}
case 93:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",96);}
case 96:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?101:99;continue;}
case 99:{f.Push(JValue.I(0));f.Pc=100;continue;}
case 100:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","INCREMENT","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","INCREMENT","Lforge/game/keyword/Keyword;"));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/trigger/Trigger","isKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",108);}
case 108:{f.Pc=f.Pop().Int==0?202:111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",115);}
case 115:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int!=0?123:121;continue;}
case 121:{f.Push(JValue.I(0));f.Pc=122;continue;}
case 122:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SpellAbility","Lforge/game/ability/AbilityKey;"));f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",132);}
case 132:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=135;continue;}
case 135:{f.Locals[4]=f.Pop();f.Pc=137;continue;}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",141);}
case 141:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",144);}
case 144:{f.Locals[5]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[4]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingMana","()Ljava/util/List;","invokevirtual",151);}
case 151:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",156);}
case 156:{f.Push(f.Locals[5]);f.Pc=158;continue;}
case 158:{return rt.DynamicCall(f,"forge/game/trigger/Trigger:10133:158:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",163);}
case 163:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",168);}
case 168:{return rt.Call(f,"java/util/stream/Stream","count","()J","invokeinterface",173);}
case 173:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=174;continue;}
case 174:{f.Locals[6]=f.Pop();f.Pc=176;continue;}
case 176:{f.Push(f.Locals[6]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[0]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",182);}
case 182:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",185);}
case 185:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?202:188;continue;}
case 188:{f.Push(f.Locals[6]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[0]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",194);}
case 194:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",197);}
case 197:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?202:200;continue;}
case 200:{f.Push(JValue.I(0));f.Pc=201;continue;}
case 201:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 202:{f.Push(JValue.I(1));f.Pc=203;continue;}
case 203:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10134(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","mapParams","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("CheckSVar")));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("CheckDefinedPlayer")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;","invokestatic",14);}
case 14:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?125:29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[3]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","mapParams","Ljava/util/Map;"));f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[4]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[4]);f.Pc=56;continue;}
case 56:{f.Pc=f.Pop().Reference==null?122:59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("Trigger")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Int!=0?94:70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/trigger/Trigger","hasSVar","(Ljava/lang/String;)Z","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int==0?122:79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[4]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/trigger/Trigger","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",85);}
case 85:{f.Push(JValue.R(rt.String("Trigger")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?122:94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","mapParams","Ljava/util/Map;"));f.Pc=99;continue;}
case 99:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?114:102;continue;}
case 102:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=105;continue;}
case 105:{f.StackOp("dup");f.Pc=106;continue;}
case 106:{f.Push(f.Locals[0]);f.Pc=107;continue;}
case 107:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","mapParams","Ljava/util/Map;"));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/HashMap","<init>","(Ljava/util/Map;)V","invokespecial",113);}
case 113:{f.Locals[1]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[1]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[3]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",121);}
case 121:{f.StackOp("pop");f.Pc=122;continue;}
case 122:{f.Pc=20;continue;}
case 125:{f.Push(f.Locals[1]);f.Pc=126;continue;}
case 126:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10135(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/Trigger","checkedEvent","Lforge/game/trigger/TriggerWaiting;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/function/BooleanSupplier","getAsBoolean","()Z","invokeinterface",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(null));f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/Trigger","checkedEvent","Lforge/game/trigger/TriggerWaiting;",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(null));f.Pc=23;continue;}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/Trigger","checkedEvent","Lforge/game/trigger/TriggerWaiting;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10136(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObjects","()Ljava/util/Map;","invokevirtual",5);}
case 5:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/Trigger","checkedObjects","Ljava/util/Map;",value);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/function/BooleanSupplier","getAsBoolean","()Z","invokeinterface",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/Trigger","checkedObjects","Ljava/util/Map;",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[3]);f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(null));f.Pc=26;continue;}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/Trigger","checkedObjects","Ljava/util/Map;",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10137(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","checkedObjects","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","checkedObjects","Ljava/util/Map;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",17);}
case 17:{return JStep.Return(f.Pop());}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","checkedEvent","Lforge/game/trigger/TriggerWaiting;"));f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Reference!=null?29:25;continue;}
case 25:{f.Push(JValue.R(null));f.Pc=26;continue;}
case 26:{f.Pc=43;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","checkedEvent","Lforge/game/trigger/TriggerWaiting;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/trigger/TriggerWaiting","getTriggeringObjects","(Lforge/game/trigger/Trigger;)Ljava/util/Map;","invokevirtual",37);}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",43);}
case 43:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10138(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/trigger/Trigger")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/trigger/Trigger","getId","()I","invokevirtual",13);}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/trigger/Trigger","getId","()I","invokevirtual",20);}
case 20:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?27:23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Pc=28;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10139(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(2));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.ClassObject("forge/game/trigger/Trigger")));f.Pc=8;continue;}
case 8:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/trigger/Trigger","getId","()I","invokevirtual",15);}
case 15:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",18);}
case 18:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Objects","hash","([Ljava/lang/Object;)I","invokestatic",22);}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10142(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/trigger/Trigger","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V","invokevirtual",10);}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10143(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","id","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10144(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/Trigger","id","I",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10145(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","triggerRemembered","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10146(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","triggerRemembered","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10147(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","triggerRemembered","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10148(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","mode","Lforge/game/trigger/TriggerType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10149(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/Trigger","mode","Lforge/game/trigger/TriggerType;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10150(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/trigger/Trigger","copy","(Lforge/game/card/Card;ZZLforge/game/spellability/SpellAbility;)Lforge/game/trigger/Trigger;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10151(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/trigger/Trigger","copy","(Lforge/game/card/Card;ZZLforge/game/spellability/SpellAbility;)Lforge/game/trigger/Trigger;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10152(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/trigger/Trigger","clone","()Ljava/lang/Object;","invokevirtual",4);}
case 4:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7;continue;}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[5]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Int!=0?21:17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Int==0?25:21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Pc=26;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/trigger/Trigger","copyHelper","(Lforge/game/CardTraitBase;Lforge/game/card/Card;Z)V","invokevirtual",29);}
case 29:{f.Push(f.Locals[4]);f.Pc=31;continue;}
case 31:{f.Pc=f.Pop().Reference==null?44:34;continue;}
case 34:{f.Push(f.Locals[5]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",41);}
case 41:{f.Pc=65;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/trigger/Trigger","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Reference==null?65:51;continue;}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/trigger/Trigger","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",57);}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",62);}
case 62:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",65);}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Int!=0?77:69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/trigger/Trigger","nextId","()I","invokestatic",74);}
case 74:{return rt.Call(f,"forge/game/trigger/Trigger","setId","(I)V","invokevirtual",77);}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","validPhases","Ljava/util/Set;"));f.Pc=81;continue;}
case 81:{f.Pc=f.Pop().Reference==null?98:84;continue;}
case 84:{f.Push(f.Locals[5]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","validPhases","Ljava/util/Set;"));f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.ClassObject("forge/game/phase/PhaseType")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"com/google/common/collect/Sets","newEnumSet","(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",95);}
case 95:{return rt.Call(f,"forge/game/trigger/Trigger","setTriggerPhases","(Ljava/util/Set;)V","invokevirtual",98);}
case 98:{f.Push(f.Locals[5]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","validHostZones","Ljava/util/EnumSet;"));f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/trigger/Trigger","setActiveZone","(Ljava/util/EnumSet;)V","invokevirtual",107);}
case 107:{f.Push(f.Locals[5]);f.Pc=109;continue;}
case 109:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10153(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Static")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10154(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/Trigger","validPhases","Ljava/util/Set;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10156(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","spawningAbility","Lforge/game/spellability/SpellAbility;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10157(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/trigger/Trigger","spawningAbility","Lforge/game/spellability/SpellAbility;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10158(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","hostCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/trigger/Trigger","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/Card","getAbilityActivatedThisTurn","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10159(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","hostCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/trigger/Trigger","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/game/card/Card","getAbilityActivatedThisGame","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10160(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/trigger/Trigger","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/trigger/Trigger","hostCard","Lforge/game/card/Card;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/trigger/Trigger","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/game/card/Card","addAbilityActivated","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",18);}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10161(JRuntime rt,JFrame f)
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
case 14:{return rt.DynamicCall(f,"forge/game/trigger/Trigger:10161:14:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",19);}
case 19:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",22);}
case 22:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10162(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/trigger/Trigger","getOverridingAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?71:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("Execute")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?71:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/trigger/Trigger","isIntrinsic","()Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?51:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/CardState")?1:0));f.Pc=29;continue;}
case 29:{f.Pc=f.Pop().Int==0?51:32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardState"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("Execute")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",44);}
case 44:{return rt.Call(f,"forge/game/card/CardState","getAbilityForTrigger","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",47);}
case 47:{f.Locals[2]=f.Pop();f.Pc=48;continue;}
case 48:{f.Pc=66;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",55);}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("Execute")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",61);}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokestatic",65);}
case 65:{f.Locals[2]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/trigger/Trigger","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",71);}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10163(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/trigger/Trigger","ensureAbility","(Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10164(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/TriggerReplacementBase","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","setTrigger","(Lforge/game/trigger/Trigger;)V","invokevirtual",10);}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10165(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IndividualCostPaymentInstance","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IndividualCostPaymentInstance","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/CostPaymentStack$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{f.Pc=f.Pop().Reference==null?34:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/zone/CostPaymentStack$Entry","payment","()Lforge/game/cost/CostPayment;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/game/cost/CostPayment","getAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/game/trigger/Trigger","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?34:32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","CostStack","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","CostStack","Lforge/game/ability/AbilityKey;"));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/CostPaymentStack"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{f.Locals[4]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/zone/CostPaymentStack","iterator","()Ljava/util/Iterator;","invokevirtual",53);}
case 53:{f.Locals[5]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",62);}
case 62:{f.Pc=f.Pop().Int==0?98:65;continue;}
case 65:{f.Push(f.Locals[5]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",72);}
case 72:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/CostPaymentStack$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=75;continue;}
case 75:{f.Locals[6]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/zone/CostPaymentStack$Entry","payment","()Lforge/game/cost/CostPayment;","invokevirtual",84);}
case 84:{return rt.Call(f,"forge/game/cost/CostPayment","getAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",87);}
case 87:{return rt.Call(f,"forge/game/trigger/Trigger","matchesValidParam","(Ljava/lang/String;Ljava/lang/Object;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?95:93;continue;}
case 93:{f.Push(JValue.I(1));f.Pc=94;continue;}
case 94:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 95:{f.Pc=55;continue;}
case 98:{f.Push(JValue.I(0));f.Pc=99;continue;}
case 99:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10166(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Chapter")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","hasParam","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10167(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/trigger/Trigger","isChapter","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("Chapter")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",16);}
case 16:{return rt.Call(f,"java/lang/Integer","valueOf","(Ljava/lang/String;)Ljava/lang/Integer;","invokestatic",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10168(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/trigger/Trigger","isChapter","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?28:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/trigger/Trigger","getChapter","()Ljava/lang/Integer;","invokevirtual",11);}
case 11:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/trigger/Trigger","getCardState","()Lforge/game/card/CardState;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/game/card/CardState","getFinalChapterNr","()I","invokevirtual",21);}
case 21:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10169(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","TapsForMana","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","TapsForMana","Lforge/game/trigger/TriggerType;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int!=0?28:13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ManaAdded","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ManaAdded","Lforge/game/trigger/TriggerType;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/game/trigger/TriggerType","equals","(Ljava/lang/Object;)Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?28:26;continue;}
case 26:{f.Push(JValue.I(0));f.Pc=27;continue;}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/trigger/Trigger","ensureAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",32);}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","isManaAbility","()Z","invokevirtual",35);}
case 35:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10170(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/trigger/Trigger$1","$SwitchMap$forge$game$trigger$TriggerType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/Trigger$1","$SwitchMap$forge$game$trigger$TriggerType","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/trigger/TriggerType","ordinal","()I","invokevirtual",10);}
case 10:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=11;continue;}
case 11:{switch(f.Pop().Int){case 1:f.Pc=48;break;case 2:f.Pc=48;break;case 3:f.Pc=48;break;case 4:f.Pc=48;break;case 5:f.Pc=50;break;case 6:f.Pc=50;break;default:f.Pc=138;break;}continue;}
case 48:{f.Push(JValue.I(1));f.Pc=49;continue;}
case 49:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 50:{if(!rt.StaticReady(f,"org/apache/commons/lang3/Strings","CS","Lorg/apache/commons/lang3/Strings;"))return JStep.Continue;f.Push(rt.GetStatic("org/apache/commons/lang3/Strings","CS","Lorg/apache/commons/lang3/Strings;"));f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("Origin")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",60);}
case 60:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"org/apache/commons/lang3/Strings","contains","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?71:69;continue;}
case 69:{f.Push(JValue.I(1));f.Pc=70;continue;}
case 70:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 71:{if(!rt.StaticReady(f,"org/apache/commons/lang3/Strings","CS","Lorg/apache/commons/lang3/Strings;"))return JStep.Continue;f.Push(rt.GetStatic("org/apache/commons/lang3/Strings","CS","Lorg/apache/commons/lang3/Strings;"));f.Pc=74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("Origin")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",81);}
case 81:{f.Push(JValue.R(rt.String("Graveyard")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"org/apache/commons/lang3/Strings","contains","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int==0?108:90;continue;}
case 90:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("Destination")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",100);}
case 100:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",103);}
case 103:{f.Pc=f.Pop().Int!=0?108:106;continue;}
case 106:{f.Push(JValue.I(1));f.Pc=107;continue;}
case 107:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 108:{if(!rt.StaticReady(f,"org/apache/commons/lang3/Strings","CS","Lorg/apache/commons/lang3/Strings;"))return JStep.Continue;f.Push(rt.GetStatic("org/apache/commons/lang3/Strings","CS","Lorg/apache/commons/lang3/Strings;"));f.Pc=111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("Destination")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/trigger/Trigger","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",118);}
case 118:{f.Push(JValue.I(2));f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.NewArray("Ljava/lang/CharSequence;",f.Pop().Int)));f.Pc=122;continue;}
case 122:{f.StackOp("dup");f.Pc=123;continue;}
case 123:{f.Push(JValue.I(0));f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("Library")));f.Pc=127;continue;}
case 127:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=128;continue;}
case 128:{f.StackOp("dup");f.Pc=129;continue;}
case 129:{f.Push(JValue.I(1));f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("Hand")));f.Pc=133;continue;}
case 133:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=134;continue;}
case 134:{return rt.Call(f,"org/apache/commons/lang3/Strings","containsAny","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z","invokevirtual",137);}
case 137:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 138:{f.Push(JValue.I(0));f.Pc=139;continue;}
case 139:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10171(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/mana/Mana","getPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10172(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int!=0?34:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",12);}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/card/Card","hasSVar","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?38:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/trigger/Trigger","getHostCard","()Lforge/game/card/Card;","invokevirtual",23);}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",27);}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?38:34;continue;}
case 34:{f.Push(JValue.I(1));f.Pc=35;continue;}
case 35:{f.Pc=39;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10173(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/trigger/Trigger","maxId","I"))return JStep.Continue;rt.PutStatic("forge/game/trigger/Trigger","maxId","I",f.Pop());f.Pc=4;continue;}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
