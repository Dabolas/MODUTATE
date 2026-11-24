// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C701{
internal static JClass Build(){var c=new JClass("forge/game/player/AchievementTracker","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("activatedUltimates","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("activatedNonPWUltimates","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("challengesCompleted","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("mulliganTo","I",false,JValue.Default("I"),null));
c.Add(new JField("spellsCast","I",false,JValue.Default("I"),null));
c.Add(new JField("maxStormCount","I",false,JValue.Default("I"),null));
c.Add(new JField("landsPlayed","I",false,JValue.Default("I"),null));
c.Add(new JMethod(7961,"forge/game/player/AchievementTracker","<init>","()V",1,1,3,new JHandler[]{},M7961));
c.Add(new JMethod(7962,"forge/game/player/AchievementTracker","onSpellAbilityPlayed","(Lforge/game/spellability/SpellAbility;)V",1,3,2,new JHandler[]{},M7962));
c.Add(new JMethod(7963,"forge/game/player/AchievementTracker","onSpellResolve","(Lforge/game/spellability/SpellAbility;)V",1,3,2,new JHandler[]{},M7963));
}

internal static JStep M7961(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/AchievementTracker","activatedUltimates","Ljava/util/Set;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",23);}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/AchievementTracker","activatedNonPWUltimates","Ljava/util/Set;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",34);}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/AchievementTracker","challengesCompleted","Ljava/util/Set;",value);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(JValue.I(7));f.Pc=40;continue;}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/AchievementTracker","mulliganTo","I",value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(JValue.I(0));f.Pc=45;continue;}
case 45:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/AchievementTracker","spellsCast","I",value);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/AchievementTracker","maxStormCount","I",value);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/AchievementTracker","landsPlayed","I",value);f.Pc=58;continue;}
case 58:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7962(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Ultimate")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?52:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","isPwAbility","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?38:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(rt.GetField(f.Pop(),"forge/game/player/AchievementTracker","activatedUltimates","Ljava/util/Set;"));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",29);}
case 29:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",34);}
case 34:{f.StackOp("pop");f.Pc=35;continue;}
case 35:{f.Pc=52;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(rt.GetField(f.Pop(),"forge/game/player/AchievementTracker","activatedNonPWUltimates","Ljava/util/Set;"));f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",46);}
case 46:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",51);}
case 51:{f.StackOp("pop");f.Pc=52;continue;}
case 52:{f.Push(f.Locals[2]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",56);}
case 56:{if(!rt.StaticReady(f,"forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/ColorSet","WUBRG","Lforge/card/ColorSet;"));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/card/ColorSet","equals","(Ljava/lang/Object;)Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int==0?77:65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(rt.GetField(f.Pop(),"forge/game/player/AchievementTracker","challengesCompleted","Ljava/util/Set;"));f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("Chromatic")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",76);}
case 76:{f.StackOp("pop");f.Pc=77;continue;}
case 77:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7963(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","EPIC","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","EPIC","Lforge/game/keyword/Keyword;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?27:15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/player/AchievementTracker","challengesCompleted","Ljava/util/Set;"));f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Epic")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
