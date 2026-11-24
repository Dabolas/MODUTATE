// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C654{
internal static JClass Build(){var c=new JClass("forge/game/keyword/KeywordInstance","java/lang/Object",new string[]{"forge/game/keyword/KeywordInterface"},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("hostCard","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("intrinsic","Z",false,JValue.Default("Z"),null));
c.Add(new JField("keyword","Lforge/game/keyword/Keyword;",false,JValue.Default("Lforge/game/keyword/Keyword;"),null));
c.Add(new JField("original","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("st","Lforge/game/staticability/StaticAbility;",false,JValue.Default("Lforge/game/staticability/StaticAbility;"),null));
c.Add(new JField("idx","J",false,JValue.Default("J"),null));
c.Add(new JField("triggers","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("replacements","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("abilities","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("staticAbilities","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(7494,"forge/game/keyword/KeywordInstance","<init>","()V",1,1,3,new JHandler[]{},M7494));
c.Add(new JMethod(7495,"forge/game/keyword/KeywordInstance","getOriginal","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7495));
c.Add(new JMethod(7496,"forge/game/keyword/KeywordInstance","getKeyword","()Lforge/game/keyword/Keyword;",1,1,1,new JHandler[]{},M7496));
c.Add(new JMethod(7497,"forge/game/keyword/KeywordInstance","getReminderText","()Ljava/lang/String;",1,4,5,new JHandler[]{},M7497));
c.Add(new JMethod(7498,"forge/game/keyword/KeywordInstance","getAmount","()I",1,1,1,new JHandler[]{},M7498));
c.Add(new JMethod(7499,"forge/game/keyword/KeywordInstance","getAmountString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7499));
c.Add(new JMethod(7500,"forge/game/keyword/KeywordInstance","initialize","(Ljava/lang/String;Lforge/game/keyword/Keyword;Ljava/lang/String;)V",4,4,2,new JHandler[]{},M7500));
c.Add(new JMethod(7501,"forge/game/keyword/KeywordInstance","parse","(Ljava/lang/String;)V",1028,0,0,new JHandler[]{},null));
c.Add(new JMethod(7502,"forge/game/keyword/KeywordInstance","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;",1028,0,0,new JHandler[]{},null));
c.Add(new JMethod(7503,"forge/game/keyword/KeywordInstance","createTraits","(Lforge/game/card/Card;ZZ)V",17,8,4,new JHandler[]{new JHandler(50,143,156,"java/lang/Exception"),new JHandler(50,143,223,""),new JHandler(156,225,223,"")},M7503));
c.Add(new JMethod(7504,"forge/game/keyword/KeywordInstance","createTraits","(Lforge/game/player/Player;Z)V",1,7,4,new JHandler[]{new JHandler(40,118,131,"java/lang/Exception"),new JHandler(40,118,196,""),new JHandler(131,198,196,"")},M7504));
c.Add(new JMethod(7505,"forge/game/keyword/KeywordInstance","addTrigger","(Lforge/game/trigger/Trigger;)V",17,2,2,new JHandler[]{},M7505));
c.Add(new JMethod(7506,"forge/game/keyword/KeywordInstance","addReplacement","(Lforge/game/replacement/ReplacementEffect;)V",17,2,2,new JHandler[]{},M7506));
c.Add(new JMethod(7507,"forge/game/keyword/KeywordInstance","addSpellAbility","(Lforge/game/spellability/SpellAbility;)V",17,2,2,new JHandler[]{},M7507));
c.Add(new JMethod(7508,"forge/game/keyword/KeywordInstance","addStaticAbility","(Lforge/game/staticability/StaticAbility;)V",17,2,2,new JHandler[]{},M7508));
c.Add(new JMethod(7509,"forge/game/keyword/KeywordInstance","hasTraits","()Z",1,1,1,new JHandler[]{},M7509));
c.Add(new JMethod(7510,"forge/game/keyword/KeywordInstance","getTriggers","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M7510));
c.Add(new JMethod(7511,"forge/game/keyword/KeywordInstance","getReplacements","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M7511));
c.Add(new JMethod(7512,"forge/game/keyword/KeywordInstance","getAbilities","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M7512));
c.Add(new JMethod(7513,"forge/game/keyword/KeywordInstance","getStaticAbilities","()Ljava/util/Collection;",1,1,1,new JHandler[]{},M7513));
c.Add(new JMethod(7514,"forge/game/keyword/KeywordInstance","applySpellAbility","(Ljava/util/List;)Ljava/util/List;",1,2,2,new JHandler[]{},M7514));
c.Add(new JMethod(7515,"forge/game/keyword/KeywordInstance","applyTrigger","(Ljava/util/List;)Ljava/util/List;",1,2,2,new JHandler[]{},M7515));
c.Add(new JMethod(7516,"forge/game/keyword/KeywordInstance","applyReplacementEffect","(Ljava/util/List;)Ljava/util/List;",1,2,2,new JHandler[]{},M7516));
c.Add(new JMethod(7517,"forge/game/keyword/KeywordInstance","applyStaticAbility","(Ljava/util/List;)Ljava/util/List;",1,2,2,new JHandler[]{},M7517));
c.Add(new JMethod(7518,"forge/game/keyword/KeywordInstance","copy","(Lforge/game/card/Card;Z)Lforge/game/keyword/KeywordInterface;",1,7,4,new JHandler[]{new JHandler(0,294,295,"java/lang/Exception")},M7518));
c.Add(new JMethod(7519,"forge/game/keyword/KeywordInstance","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7519));
c.Add(new JMethod(7520,"forge/game/keyword/KeywordInstance","redundant","(Ljava/util/Collection;)Z",1,4,2,new JHandler[]{},M7520));
c.Add(new JMethod(7521,"forge/game/keyword/KeywordInstance","getHostCard","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M7521));
c.Add(new JMethod(7522,"forge/game/keyword/KeywordInstance","setHostCard","(Lforge/game/card/Card;)V",1,4,2,new JHandler[]{},M7522));
c.Add(new JMethod(7523,"forge/game/keyword/KeywordInstance","isIntrinsic","()Z",1,1,1,new JHandler[]{},M7523));
c.Add(new JMethod(7524,"forge/game/keyword/KeywordInstance","setIntrinsic","(Z)V",1,4,2,new JHandler[]{},M7524));
c.Add(new JMethod(7525,"forge/game/keyword/KeywordInstance","getStatic","()Lforge/game/staticability/StaticAbility;",1,1,1,new JHandler[]{},M7525));
c.Add(new JMethod(7526,"forge/game/keyword/KeywordInstance","setStatic","(Lforge/game/staticability/StaticAbility;)V",1,2,2,new JHandler[]{},M7526));
c.Add(new JMethod(7527,"forge/game/keyword/KeywordInstance","getIdx","()J",1,1,2,new JHandler[]{},M7527));
c.Add(new JMethod(7528,"forge/game/keyword/KeywordInstance","setIdx","(J)V",1,3,3,new JHandler[]{},M7528));
c.Add(new JMethod(7529,"forge/game/keyword/KeywordInstance","getSVarFallback","()Lforge/game/IHasSVars;",4,1,1,new JHandler[]{},M7529));
c.Add(new JMethod(7530,"forge/game/keyword/KeywordInstance","getSVar","(Ljava/lang/String;)Ljava/lang/String;",1,2,2,new JHandler[]{},M7530));
c.Add(new JMethod(7531,"forge/game/keyword/KeywordInstance","hasSVar","(Ljava/lang/String;)Z",1,2,2,new JHandler[]{},M7531));
c.Add(new JMethod(7532,"forge/game/keyword/KeywordInstance","setSVar","(Ljava/lang/String;Ljava/lang/String;)V",17,3,0,new JHandler[]{},M7532));
c.Add(new JMethod(7533,"forge/game/keyword/KeywordInstance","getSVars","()Ljava/util/Map;",1,1,1,new JHandler[]{},M7533));
c.Add(new JMethod(7534,"forge/game/keyword/KeywordInstance","setSVars","(Ljava/util/Map;)V",1,2,0,new JHandler[]{},M7534));
c.Add(new JMethod(7535,"forge/game/keyword/KeywordInstance","removeSVar","(Ljava/lang/String;)V",1,2,0,new JHandler[]{},M7535));
c.Add(new JMethod(7536,"forge/game/keyword/KeywordInstance","copy","(Lforge/game/card/Card;Z)Lforge/game/card/ICardTraitChanges;",4161,3,3,new JHandler[]{},M7536));
}

internal static JStep M7494(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","hostCard","Lforge/game/card/Card;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","intrinsic","Z",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(null));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","st","Lforge/game/staticability/StaticAbility;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.L(-1L));f.Pc=23;continue;}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","idx","J",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",30);}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","triggers","Ljava/util/List;",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",37);}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","replacements","Ljava/util/List;",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",44);}
case 44:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","abilities","Ljava/util/List;",value);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",51);}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","staticAbilities","Ljava/util/List;",value);f.Pc=54;continue;}
case 54:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7495(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","original","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7496(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","keyword","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7497(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","keyword","Lforge/game/keyword/Keyword;"));f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Keyword","reminderText","Ljava/lang/String;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/keyword/KeywordInstance","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("\\{(\\w+):(.+?)\\}")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",17);}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{if(!rt.EnsureInitialized(f,"java/lang/StringBuffer"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuffer")));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/StringBuffer","<init>","()V","invokespecial",29);}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?59:37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",44);}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{f.Push(JValue.I(2));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",49);}
case 49:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",52);}
case 52:{return rt.Call(f,"java/util/regex/Matcher","appendReplacement","(Ljava/lang/StringBuffer;Ljava/lang/String;)Ljava/util/regex/Matcher;","invokevirtual",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Pc=30;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/regex/Matcher","appendTail","(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;","invokevirtual",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/StringBuffer","toString","()Ljava/lang/String;","invokevirtual",69);}
case 69:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7498(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7499(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInstance","getAmount","()I","invokevirtual",4);}
case 4:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7500(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","original","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","keyword","Lforge/game/keyword/Keyword;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/keyword/KeywordInstance","parse","(Ljava/lang/String;)V","invokevirtual",15);}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7503(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","hostCard","Lforge/game/card/Card;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","intrinsic","Z",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int==0?50:14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","triggers","Ljava/util/List;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",23);}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","replacements","Ljava/util/List;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",32);}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","abilities","Ljava/util/List;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",41);}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","staticAbilities","Ljava/util/List;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",50);}
case 50:{f.Push(JValue.R(rt.String("KeywordInstance:createTraits: make Traits for Keyword")));f.Pc=52;continue;}
case 52:{f.Locals[4]=f.Pop();f.Pc=54;continue;}
case 54:{if(!rt.EnsureInitialized(f,"io/sentry/Breadcrumb"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("io/sentry/Breadcrumb")));f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"io/sentry/Breadcrumb","<init>","(Ljava/lang/String;)V","invokespecial",63);}
case 63:{f.Locals[5]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[5]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("Card")));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",73);}
case 73:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",76);}
case 76:{f.Push(f.Locals[5]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("Keyword")));f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","original","Ljava/lang/String;"));f.Pc=84;continue;}
case 84:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",87);}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"io/sentry/Sentry","addBreadcrumb","(Lio/sentry/Breadcrumb;)V","invokestatic",92);}
case 92:{f.Push(JValue.R(rt.String("Card")));f.Pc=94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",98);}
case 98:{return rt.Call(f,"io/sentry/Sentry","setExtra","(Ljava/lang/String;Ljava/lang/String;)V","invokestatic",101);}
case 101:{f.Push(JValue.R(rt.String("Keyword")));f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","original","Ljava/lang/String;"));f.Pc=107;continue;}
case 107:{return rt.Call(f,"io/sentry/Sentry","setExtra","(Ljava/lang/String;Ljava/lang/String;)V","invokestatic",110);}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[2]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/card/CardFactoryUtil","addTriggerAbility","(Lforge/game/keyword/KeywordInterface;Lforge/game/card/Card;Z)V","invokestatic",116);}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",121);}
case 121:{f.Push(f.Locals[2]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/card/CardFactoryUtil","addReplacementEffect","(Lforge/game/keyword/KeywordInterface;Lforge/game/card/CardState;Z)V","invokestatic",125);}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[1]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",130);}
case 130:{f.Push(f.Locals[2]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/card/CardFactoryUtil","addSpellAbility","(Lforge/game/keyword/KeywordInterface;Lforge/game/card/CardState;Z)V","invokestatic",134);}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",139);}
case 139:{f.Push(f.Locals[2]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/game/card/CardFactoryUtil","addStaticAbility","(Lforge/game/keyword/KeywordInterface;Lforge/game/card/CardState;Z)V","invokestatic",143);}
case 143:{f.Push(JValue.R(rt.String("Card")));f.Pc=145;continue;}
case 145:{return rt.Call(f,"io/sentry/Sentry","removeExtra","(Ljava/lang/String;)V","invokestatic",148);}
case 148:{f.Push(JValue.R(rt.String("Keyword")));f.Pc=150;continue;}
case 150:{return rt.Call(f,"io/sentry/Sentry","removeExtra","(Ljava/lang/String;)V","invokestatic",153);}
case 153:{f.Pc=238;continue;}
case 156:{f.Locals[4]=f.Pop();f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("KeywordInstance:createTraits: failed Traits for Keyword")));f.Pc=160;continue;}
case 160:{f.Locals[5]=f.Pop();f.Pc=162;continue;}
case 162:{if(!rt.EnsureInitialized(f,"io/sentry/Breadcrumb"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("io/sentry/Breadcrumb")));f.Pc=165;continue;}
case 165:{f.StackOp("dup");f.Pc=166;continue;}
case 166:{f.Push(f.Locals[5]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"io/sentry/Breadcrumb","<init>","(Ljava/lang/String;)V","invokespecial",171);}
case 171:{f.Locals[6]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[6]);f.Pc=175;continue;}
case 175:{f.Push(JValue.R(rt.String("Card")));f.Pc=177;continue;}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",181);}
case 181:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",184);}
case 184:{f.Push(f.Locals[6]);f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.String("Keyword")));f.Pc=188;continue;}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","original","Ljava/lang/String;"));f.Pc=192;continue;}
case 192:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",195);}
case 195:{f.Push(f.Locals[6]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"io/sentry/Sentry","addBreadcrumb","(Lio/sentry/Breadcrumb;)V","invokestatic",200);}
case 200:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=203;continue;}
case 203:{f.StackOp("dup");f.Pc=204;continue;}
case 204:{f.Push(f.Locals[0]);f.Pc=205;continue;}
case 205:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","original","Ljava/lang/String;"));f.Pc=208;continue;}
case 208:{f.Push(f.Locals[1]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",212);}
case 212:{return rt.DynamicCall(f,"forge/game/keyword/KeywordInstance:7503:212:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",217);}
case 217:{f.Push(f.Locals[4]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;Ljava/lang/Throwable;)V","invokespecial",222);}
case 222:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 223:{f.Locals[7]=f.Pop();f.Pc=225;continue;}
case 225:{f.Push(JValue.R(rt.String("Card")));f.Pc=227;continue;}
case 227:{return rt.Call(f,"io/sentry/Sentry","removeExtra","(Ljava/lang/String;)V","invokestatic",230);}
case 230:{f.Push(JValue.R(rt.String("Keyword")));f.Pc=232;continue;}
case 232:{return rt.Call(f,"io/sentry/Sentry","removeExtra","(Ljava/lang/String;)V","invokestatic",235);}
case 235:{f.Push(f.Locals[7]);f.Pc=237;continue;}
case 237:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 238:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7504(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int==0?40:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","triggers","Ljava/util/List;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",13);}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","replacements","Ljava/util/List;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","abilities","Ljava/util/List;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",31);}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","staticAbilities","Ljava/util/List;"));f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",40);}
case 40:{f.Push(JValue.R(rt.String("KeywordInstance:createTraits: make Traits for Keyword")));f.Pc=42;continue;}
case 42:{f.Locals[3]=f.Pop();f.Pc=43;continue;}
case 43:{if(!rt.EnsureInitialized(f,"io/sentry/Breadcrumb"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("io/sentry/Breadcrumb")));f.Pc=46;continue;}
case 46:{f.StackOp("dup");f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"io/sentry/Breadcrumb","<init>","(Ljava/lang/String;)V","invokespecial",51);}
case 51:{f.Locals[4]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[4]);f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("Player")));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",61);}
case 61:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",64);}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("Keyword")));f.Pc=68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","original","Ljava/lang/String;"));f.Pc=72;continue;}
case 72:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",75);}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"io/sentry/Sentry","addBreadcrumb","(Lio/sentry/Breadcrumb;)V","invokestatic",80);}
case 80:{f.Push(JValue.R(rt.String("Player")));f.Pc=82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",86);}
case 86:{return rt.Call(f,"io/sentry/Sentry","setExtra","(Ljava/lang/String;Ljava/lang/String;)V","invokestatic",89);}
case 89:{f.Push(JValue.R(rt.String("Keyword")));f.Pc=91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","original","Ljava/lang/String;"));f.Pc=95;continue;}
case 95:{return rt.Call(f,"io/sentry/Sentry","setExtra","(Ljava/lang/String;Ljava/lang/String;)V","invokestatic",98);}
case 98:{f.Push(f.Locals[0]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[1]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/player/PlayerFactoryUtil","addTriggerAbility","(Lforge/game/keyword/KeywordInterface;Lforge/game/player/Player;)V","invokestatic",103);}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/player/PlayerFactoryUtil","addReplacementEffect","(Lforge/game/keyword/KeywordInterface;Lforge/game/player/Player;)V","invokestatic",108);}
case 108:{f.Push(f.Locals[0]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/player/PlayerFactoryUtil","addSpellAbility","(Lforge/game/keyword/KeywordInterface;Lforge/game/player/Player;)V","invokestatic",113);}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[1]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/player/PlayerFactoryUtil","addStaticAbility","(Lforge/game/keyword/KeywordInterface;Lforge/game/player/Player;)V","invokestatic",118);}
case 118:{f.Push(JValue.R(rt.String("Player")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"io/sentry/Sentry","removeExtra","(Ljava/lang/String;)V","invokestatic",123);}
case 123:{f.Push(JValue.R(rt.String("Keyword")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"io/sentry/Sentry","removeExtra","(Ljava/lang/String;)V","invokestatic",128);}
case 128:{f.Pc=211;continue;}
case 131:{f.Locals[3]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(JValue.R(rt.String("KeywordInstance:createTraits: failed Traits for Keyword")));f.Pc=134;continue;}
case 134:{f.Locals[4]=f.Pop();f.Pc=136;continue;}
case 136:{if(!rt.EnsureInitialized(f,"io/sentry/Breadcrumb"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("io/sentry/Breadcrumb")));f.Pc=139;continue;}
case 139:{f.StackOp("dup");f.Pc=140;continue;}
case 140:{f.Push(f.Locals[4]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"io/sentry/Breadcrumb","<init>","(Ljava/lang/String;)V","invokespecial",145);}
case 145:{f.Locals[5]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[5]);f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.String("Player")));f.Pc=151;continue;}
case 151:{f.Push(f.Locals[1]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",155);}
case 155:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",158);}
case 158:{f.Push(f.Locals[5]);f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("Keyword")));f.Pc=162;continue;}
case 162:{f.Push(f.Locals[0]);f.Pc=163;continue;}
case 163:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","original","Ljava/lang/String;"));f.Pc=166;continue;}
case 166:{return rt.Call(f,"io/sentry/Breadcrumb","setData","(Ljava/lang/String;Ljava/lang/Object;)V","invokevirtual",169);}
case 169:{f.Push(f.Locals[5]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"io/sentry/Sentry","addBreadcrumb","(Lio/sentry/Breadcrumb;)V","invokestatic",174);}
case 174:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=177;continue;}
case 177:{f.StackOp("dup");f.Pc=178;continue;}
case 178:{f.Push(f.Locals[0]);f.Pc=179;continue;}
case 179:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","original","Ljava/lang/String;"));f.Pc=182;continue;}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/player/Player","getName","()Ljava/lang/String;","invokevirtual",186);}
case 186:{return rt.DynamicCall(f,"forge/game/keyword/KeywordInstance:7504:186:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",191);}
case 191:{f.Push(f.Locals[3]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;Ljava/lang/Throwable;)V","invokespecial",195);}
case 195:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 196:{f.Locals[6]=f.Pop();f.Pc=198;continue;}
case 198:{f.Push(JValue.R(rt.String("Player")));f.Pc=200;continue;}
case 200:{return rt.Call(f,"io/sentry/Sentry","removeExtra","(Ljava/lang/String;)V","invokestatic",203);}
case 203:{f.Push(JValue.R(rt.String("Keyword")));f.Pc=205;continue;}
case 205:{return rt.Call(f,"io/sentry/Sentry","removeExtra","(Ljava/lang/String;)V","invokestatic",208);}
case 208:{f.Push(f.Locals[6]);f.Pc=210;continue;}
case 210:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 211:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7505(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/trigger/Trigger","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","triggers","Ljava/util/List;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",15);}
case 15:{f.StackOp("pop");f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7506(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","replacements","Ljava/util/List;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",15);}
case 15:{f.StackOp("pop");f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7507(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","abilities","Ljava/util/List;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",15);}
case 15:{f.StackOp("pop");f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7508(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/staticability/StaticAbility","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","staticAbilities","Ljava/util/List;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",15);}
case 15:{f.StackOp("pop");f.Pc=16;continue;}
case 16:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7509(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInstance","getAbilities","()Ljava/util/Collection;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int!=0?14:12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/keyword/KeywordInstance","getTriggers","()Ljava/util/Collection;","invokevirtual",18);}
case 18:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int!=0?28:26;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/keyword/KeywordInstance","getReplacements","()Ljava/util/Collection;","invokevirtual",32);}
case 32:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int!=0?42:40;continue;}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/keyword/KeywordInstance","getStaticAbilities","()Ljava/util/Collection;","invokevirtual",46);}
case 46:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",51);}
case 51:{f.Pc=f.Pop().Int!=0?56:54;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7510(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","triggers","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7511(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","replacements","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7512(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","abilities","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7513(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","staticAbilities","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7514(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/keyword/KeywordInstance","getAbilities","()Ljava/util/Collection;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7515(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/keyword/KeywordInstance","getTriggers","()Ljava/util/Collection;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7516(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/keyword/KeywordInstance","getReplacements","()Ljava/util/Collection;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7517(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/keyword/KeywordInstance","getStaticAbilities","()Ljava/util/Collection;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",10);}
case 10:{f.StackOp("pop");f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7518(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","clone","()Ljava/lang/Object;","invokespecial",4);}
case 4:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInstance"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7;continue;}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","hostCard","Lforge/game/card/Card;",value);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",17);}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","abilities","Ljava/util/List;",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","abilities","Ljava/util/List;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",29);}
case 29:{f.Locals[4]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",38);}
case 38:{f.Pc=f.Pop().Int==0?83:41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{f.Locals[5]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[5]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",60);}
case 60:{f.Locals[6]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[6]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/spellability/SpellAbility","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",68);}
case 68:{f.Push(f.Locals[3]);f.Pc=69;continue;}
case 69:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","abilities","Ljava/util/List;"));f.Pc=72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",79);}
case 79:{f.StackOp("pop");f.Pc=80;continue;}
case 80:{f.Pc=31;continue;}
case 83:{f.Push(f.Locals[3]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",87);}
case 87:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","triggers","Ljava/util/List;",value);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","triggers","Ljava/util/List;"));f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",99);}
case 99:{f.Locals[4]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[4]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",108);}
case 108:{f.Pc=f.Pop().Int==0?153:111;continue;}
case 111:{f.Push(f.Locals[4]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",118);}
case 118:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=121;continue;}
case 121:{f.Locals[5]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[5]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[1]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/trigger/Trigger","copy","(Lforge/game/card/Card;Z)Lforge/game/trigger/Trigger;","invokevirtual",130);}
case 130:{f.Locals[6]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[6]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[3]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/trigger/Trigger","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",138);}
case 138:{f.Push(f.Locals[3]);f.Pc=139;continue;}
case 139:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","triggers","Ljava/util/List;"));f.Pc=142;continue;}
case 142:{f.Push(f.Locals[6]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",149);}
case 149:{f.StackOp("pop");f.Pc=150;continue;}
case 150:{f.Pc=101;continue;}
case 153:{f.Push(f.Locals[3]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",157);}
case 157:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","replacements","Ljava/util/List;",value);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[0]);f.Pc=161;continue;}
case 161:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","replacements","Ljava/util/List;"));f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",169);}
case 169:{f.Locals[4]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[4]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",178);}
case 178:{f.Pc=f.Pop().Int==0?223:181;continue;}
case 181:{f.Push(f.Locals[4]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",188);}
case 188:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=191;continue;}
case 191:{f.Locals[5]=f.Pop();f.Pc=193;continue;}
case 193:{f.Push(f.Locals[5]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[1]);f.Pc=196;continue;}
case 196:{f.Push(f.Locals[2]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","copy","(Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokevirtual",200);}
case 200:{f.Locals[6]=f.Pop();f.Pc=202;continue;}
case 202:{f.Push(f.Locals[6]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[3]);f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",208);}
case 208:{f.Push(f.Locals[3]);f.Pc=209;continue;}
case 209:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","replacements","Ljava/util/List;"));f.Pc=212;continue;}
case 212:{f.Push(f.Locals[6]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",219);}
case 219:{f.StackOp("pop");f.Pc=220;continue;}
case 220:{f.Pc=171;continue;}
case 223:{f.Push(f.Locals[3]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",227);}
case 227:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","staticAbilities","Ljava/util/List;",value);f.Pc=230;continue;}
case 230:{f.Push(f.Locals[0]);f.Pc=231;continue;}
case 231:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","staticAbilities","Ljava/util/List;"));f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",239);}
case 239:{f.Locals[4]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(f.Locals[4]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",248);}
case 248:{f.Pc=f.Pop().Int==0?293:251;continue;}
case 251:{f.Push(f.Locals[4]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",258);}
case 258:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=261;continue;}
case 261:{f.Locals[5]=f.Pop();f.Pc=263;continue;}
case 263:{f.Push(f.Locals[5]);f.Pc=265;continue;}
case 265:{f.Push(f.Locals[1]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[2]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/game/staticability/StaticAbility","copy","(Lforge/game/card/Card;Z)Lforge/game/staticability/StaticAbility;","invokevirtual",270);}
case 270:{f.Locals[6]=f.Pop();f.Pc=272;continue;}
case 272:{f.Push(f.Locals[6]);f.Pc=274;continue;}
case 274:{f.Push(f.Locals[3]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/staticability/StaticAbility","setKeyword","(Lforge/game/keyword/KeywordInterface;)V","invokevirtual",278);}
case 278:{f.Push(f.Locals[3]);f.Pc=279;continue;}
case 279:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","staticAbilities","Ljava/util/List;"));f.Pc=282;continue;}
case 282:{f.Push(f.Locals[6]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",289);}
case 289:{f.StackOp("pop");f.Pc=290;continue;}
case 290:{f.Pc=241;continue;}
case 293:{f.Push(f.Locals[3]);f.Pc=294;continue;}
case 294:{return JStep.Return(f.Pop());}
case 295:{f.Locals[3]=f.Pop();f.Pc=296;continue;}
case 296:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=299;continue;}
case 299:{f.StackOp("dup");f.Pc=300;continue;}
case 300:{f.Push(JValue.R(rt.String("KeywordInstance : clone() error")));f.Pc=303;continue;}
case 303:{f.Push(f.Locals[3]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;Ljava/lang/Throwable;)V","invokespecial",307);}
case 307:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7519(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInstance","getOriginal","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7520(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","keyword","Lforge/game/keyword/Keyword;"));f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Keyword","isMultipleRedundant","Z"));f.Pc=7;continue;}
case 7:{f.Pc=f.Pop().Int!=0?12:10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?59:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",44);}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/keyword/KeywordInstance","getOriginal","()Ljava/lang/String;","invokevirtual",48);}
case 48:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int==0?56:54;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 56:{f.Pc=19;continue;}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7521(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","hostCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7522(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","hostCard","Lforge/game/card/Card;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","abilities","Ljava/util/List;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?42:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",39);}
case 39:{f.Pc=15;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","triggers","Ljava/util/List;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",51);}
case 51:{f.Locals[2]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",58);}
case 58:{f.Pc=f.Pop().Int==0?79:61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",67);}
case 67:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=70;continue;}
case 70:{f.Locals[3]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/trigger/Trigger","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",76);}
case 76:{f.Pc=52;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","replacements","Ljava/util/List;"));f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",88);}
case 88:{f.Locals[2]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",95);}
case 95:{f.Pc=f.Pop().Int==0?116:98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",104);}
case 104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=107;continue;}
case 107:{f.Locals[3]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",113);}
case 113:{f.Pc=89;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","staticAbilities","Ljava/util/List;"));f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",125);}
case 125:{f.Locals[2]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",132);}
case 132:{f.Pc=f.Pop().Int==0?153:135;continue;}
case 135:{f.Push(f.Locals[2]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",141);}
case 141:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=144;continue;}
case 144:{f.Locals[3]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[3]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/staticability/StaticAbility","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",150);}
case 150:{f.Pc=126;continue;}
case 153:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7523(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","intrinsic","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7524(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","intrinsic","Z",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","abilities","Ljava/util/List;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?42:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/spellability/SpellAbility","setIntrinsic","(Z)V","invokevirtual",39);}
case 39:{f.Pc=15;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","triggers","Ljava/util/List;"));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",51);}
case 51:{f.Locals[2]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",58);}
case 58:{f.Pc=f.Pop().Int==0?79:61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",67);}
case 67:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=70;continue;}
case 70:{f.Locals[3]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/trigger/Trigger","setIntrinsic","(Z)V","invokevirtual",76);}
case 76:{f.Pc=52;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","replacements","Ljava/util/List;"));f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",88);}
case 88:{f.Locals[2]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",95);}
case 95:{f.Pc=f.Pop().Int==0?116:98;continue;}
case 98:{f.Push(f.Locals[2]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",104);}
case 104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=107;continue;}
case 107:{f.Locals[3]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setIntrinsic","(Z)V","invokevirtual",113);}
case 113:{f.Pc=89;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","staticAbilities","Ljava/util/List;"));f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",125);}
case 125:{f.Locals[2]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",132);}
case 132:{f.Pc=f.Pop().Int==0?153:135;continue;}
case 135:{f.Push(f.Locals[2]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",141);}
case 141:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=144;continue;}
case 144:{f.Locals[3]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[3]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/staticability/StaticAbility","setIntrinsic","(Z)V","invokevirtual",150);}
case 150:{f.Pc=126;continue;}
case 153:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7525(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","st","Lforge/game/staticability/StaticAbility;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7526(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","st","Lforge/game/staticability/StaticAbility;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7527(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordInstance","idx","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7528(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordInstance","idx","J",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7529(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInstance","getStatic","()Lforge/game/staticability/StaticAbility;","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Reference==null?12:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/keyword/KeywordInstance","getStatic","()Lforge/game/staticability/StaticAbility;","invokevirtual",11);}
case 11:{return JStep.Return(f.Pop());}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/keyword/KeywordInstance","getHostCard","()Lforge/game/card/Card;","invokevirtual",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7530(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInstance","getSVarFallback","()Lforge/game/IHasSVars;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/IHasSVars","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokeinterface",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7531(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInstance","getSVarFallback","()Lforge/game/IHasSVars;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/IHasSVars","hasSVar","(Ljava/lang/String;)Z","invokeinterface",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7532(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7533(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordInstance","getSVarFallback","()Lforge/game/IHasSVars;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/IHasSVars","getSVars","()Ljava/util/Map;","invokeinterface",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7534(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7535(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7536(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/keyword/KeywordInstance","copy","(Lforge/game/card/Card;Z)Lforge/game/keyword/KeywordInterface;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
