// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C655{
internal static JClass Build(){var c=new JClass("forge/game/keyword/KeywordInterface","java/lang/Object",new string[]{"java/lang/Cloneable","forge/game/IHasSVars","forge/game/card/ICardTraitChanges"},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(7537,"forge/game/keyword/KeywordInterface","getHostCard","()Lforge/game/card/Card;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7538,"forge/game/keyword/KeywordInterface","setHostCard","(Lforge/game/card/Card;)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7539,"forge/game/keyword/KeywordInterface","isIntrinsic","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7540,"forge/game/keyword/KeywordInterface","setIntrinsic","(Z)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7541,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7542,"forge/game/keyword/KeywordInterface","getKeyword","()Lforge/game/keyword/Keyword;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7543,"forge/game/keyword/KeywordInterface","getTitle","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7544,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7545,"forge/game/keyword/KeywordInterface","getAmount","()I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7546,"forge/game/keyword/KeywordInterface","getAmountString","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7547,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7548,"forge/game/keyword/KeywordInterface","setStatic","(Lforge/game/staticability/StaticAbility;)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7549,"forge/game/keyword/KeywordInterface","getIdx","()J",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7550,"forge/game/keyword/KeywordInterface","setIdx","(J)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7551,"forge/game/keyword/KeywordInterface","createTraits","(Lforge/game/card/Card;Z)V",1,3,4,new JHandler[]{},M7551));
c.Add(new JMethod(7552,"forge/game/keyword/KeywordInterface","createTraits","(Lforge/game/card/Card;ZZ)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7553,"forge/game/keyword/KeywordInterface","createTraits","(Lforge/game/player/Player;)V",1,2,3,new JHandler[]{},M7553));
c.Add(new JMethod(7554,"forge/game/keyword/KeywordInterface","createTraits","(Lforge/game/player/Player;Z)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7555,"forge/game/keyword/KeywordInterface","hasTraits","()Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7556,"forge/game/keyword/KeywordInterface","addTrigger","(Lforge/game/trigger/Trigger;)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7557,"forge/game/keyword/KeywordInterface","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7558,"forge/game/keyword/KeywordInterface","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7559,"forge/game/keyword/KeywordInterface","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7560,"forge/game/keyword/KeywordInterface","getTriggers","()Ljava/util/Collection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7561,"forge/game/keyword/KeywordInterface","getReplacements","()Ljava/util/Collection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7562,"forge/game/keyword/KeywordInterface","getAbilities","()Ljava/util/Collection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7563,"forge/game/keyword/KeywordInterface","getStaticAbilities","()Ljava/util/Collection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7564,"forge/game/keyword/KeywordInterface","copy","(Lforge/game/card/Card;Z)Lforge/game/keyword/KeywordInterface;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7565,"forge/game/keyword/KeywordInterface","redundant","(Ljava/util/Collection;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(7566,"forge/game/keyword/KeywordInterface","getView","()Lforge/game/keyword/KeywordView;",1,1,6,new JHandler[]{},M7566));
c.Add(new JMethod(7567,"forge/game/keyword/KeywordInterface","copy","(Lforge/game/card/Card;Z)Lforge/game/card/ICardTraitChanges;",4161,3,3,new JHandler[]{},M7567));
}

internal static JStep M7551(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/keyword/KeywordInterface","createTraits","(Lforge/game/card/Card;ZZ)V","invokeinterface",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7553(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/keyword/KeywordInterface","createTraits","(Lforge/game/player/Player;Z)V","invokeinterface",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7566(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/keyword/DefaultKeywordView"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/keyword/DefaultKeywordView")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",10);}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getKeyword","()Lforge/game/keyword/Keyword;","invokeinterface",16);}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getTitle","()Ljava/lang/String;","invokeinterface",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getReminderText","()Ljava/lang/String;","invokeinterface",28);}
case 28:{return rt.Call(f,"forge/game/keyword/DefaultKeywordView","<init>","(Ljava/lang/String;Lforge/game/keyword/Keyword;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",31);}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7567(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/keyword/KeywordInterface","copy","(Lforge/game/card/Card;Z)Lforge/game/keyword/KeywordInterface;","invokeinterface",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
