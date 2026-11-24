// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1022{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerVote","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10784,"forge/game/trigger/TriggerVote","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10784));
c.Add(new JMethod(10785,"forge/game/trigger/TriggerVote","performTest","(Ljava/util/Map;)Z",17,2,1,new JHandler[]{},M10785));
c.Add(new JMethod(10786,"forge/game/trigger/TriggerVote","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",17,5,4,new JHandler[]{},M10786));
c.Add(new JMethod(10787,"forge/game/trigger/TriggerVote","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,5,5,new JHandler[]{},M10787));
c.Add(new JMethod(10788,"forge/game/trigger/TriggerVote","getVoters","(Lforge/game/player/Player;Lcom/google/common/collect/ListMultimap;ZZ)Lforge/util/collect/FCollection;",10,8,3,new JHandler[]{},M10788));
}

internal static JStep M10784(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10785(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10786(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/trigger/TriggerVote","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",7);}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AllVotes","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AllVotes","Lforge/game/ability/AbilityKey;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/ListMultimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/trigger/TriggerVote","getVoters","(Lforge/game/player/Player;Lcom/google/common/collect/ListMultimap;ZZ)Lforge/util/collect/FCollection;","invokestatic",24);}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OpponentVotedDiff","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OpponentVotedDiff","Lforge/game/ability/AbilityKey;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/trigger/TriggerVote","getHostCard","()Lforge/game/card/Card;","invokevirtual",40);}
case 40:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",43);}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","AllVotes","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","AllVotes","Lforge/game/ability/AbilityKey;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/ListMultimap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Push(JValue.I(1));f.Pc=56;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/trigger/TriggerVote","getVoters","(Lforge/game/player/Player;Lcom/google/common/collect/ListMultimap;ZZ)Lforge/util/collect/FCollection;","invokestatic",60);}
case 60:{f.Locals[4]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OpponentVotedSame","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OpponentVotedSame","Lforge/game/ability/AbilityKey;"));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",73);}
case 73:{f.StackOp("pop");f.Pc=74;continue;}
case 74:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10787(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("List")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/trigger/TriggerVote","hasParam","(Ljava/lang/String;)Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?210:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("List")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/trigger/TriggerVote","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",23);}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("OppVotedSame")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int==0?110:33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OpponentVotedSame","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OpponentVotedSame","Lforge/game/ability/AbilityKey;"));f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",40);}
case 40:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",43);}
case 43:{f.Locals[4]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",49);}
case 49:{f.Push(JValue.R(rt.String("lblOppVotedSame")));f.Pc=51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",58);}
case 58:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",61);}
case 61:{f.Push(JValue.R(rt.String(": ")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",66);}
case 66:{f.StackOp("pop");f.Pc=67;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("[]")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",75);}
case 75:{f.Pc=f.Pop().Int!=0?94:78;continue;}
case 78:{f.Push(f.Locals[4]);f.Pc=80;continue;}
case 80:{f.Push(JValue.I(1));f.Pc=81;continue;}
case 81:{f.Push(f.Locals[4]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",86);}
case 86:{f.Push(JValue.I(1));f.Pc=87;continue;}
case 87:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",91);}
case 91:{f.Pc=106;continue;}
case 94:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",97);}
case 97:{f.Push(JValue.R(rt.String("lblNone")));f.Pc=99;continue;}
case 99:{f.Push(JValue.I(0));f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",106);}
case 106:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",109);}
case 109:{f.StackOp("pop");f.Pc=110;continue;}
case 110:{f.Push(f.Locals[3]);f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.String("OppVotedDiff")));f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",116);}
case 116:{f.Pc=f.Pop().Int==0?210:119;continue;}
case 119:{f.Push(f.Locals[2]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/StringBuilder","length","()I","invokevirtual",123);}
case 123:{f.Pc=f.Pop().Int<=0?133:126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String("] [")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",132);}
case 132:{f.StackOp("pop");f.Pc=133;continue;}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","OpponentVotedDiff","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","OpponentVotedDiff","Lforge/game/ability/AbilityKey;"));f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",140);}
case 140:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",143);}
case 143:{f.Locals[4]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[2]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",149);}
case 149:{f.Push(JValue.R(rt.String("lblOppVotedDiff")));f.Pc=151;continue;}
case 151:{f.Push(JValue.I(0));f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",158);}
case 158:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",161);}
case 161:{f.Push(JValue.R(rt.String(": ")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",166);}
case 166:{f.StackOp("pop");f.Pc=167;continue;}
case 167:{f.Push(f.Locals[2]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[4]);f.Pc=170;continue;}
case 170:{f.Push(JValue.R(rt.String("[]")));f.Pc=172;continue;}
case 172:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",175);}
case 175:{f.Pc=f.Pop().Int!=0?194:178;continue;}
case 178:{f.Push(f.Locals[4]);f.Pc=180;continue;}
case 180:{f.Push(JValue.I(1));f.Pc=181;continue;}
case 181:{f.Push(f.Locals[4]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",186);}
case 186:{f.Push(JValue.I(1));f.Pc=187;continue;}
case 187:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",191);}
case 191:{f.Pc=206;continue;}
case 194:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",197);}
case 197:{f.Push(JValue.R(rt.String("lblNone")));f.Pc=199;continue;}
case 199:{f.Push(JValue.I(0));f.Pc=200;continue;}
case 200:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=203;continue;}
case 203:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",206);}
case 206:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",209);}
case 209:{f.StackOp("pop");f.Pc=210;continue;}
case 210:{f.Push(f.Locals[2]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",214);}
case 214:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10788(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[4]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/collect/ListMultimap","keySet","()Ljava/util/Set;","invokeinterface",15);}
case 15:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",20);}
case 20:{f.Locals[5]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[5]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?75:32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",39);}
case 39:{f.Locals[6]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[6]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"com/google/common/collect/ListMultimap","get","(Ljava/lang/Object;)Ljava/util/List;","invokeinterface",49);}
case 49:{f.Locals[7]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[7]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",60);}
case 60:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ixor",a,b));f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Int==0?72:64;continue;}
case 64:{f.Push(f.Locals[4]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[7]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",71);}
case 71:{f.StackOp("pop");f.Pc=72;continue;}
case 72:{f.Pc=22;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Pc=f.Pop().Int==0?89:79;continue;}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/player/Player","getOpponents","()Lforge/game/player/PlayerCollection;","invokevirtual",85);}
case 85:{return rt.Call(f,"forge/util/collect/FCollection","retainAll","(Ljava/util/Collection;)Z","invokevirtual",88);}
case 88:{f.StackOp("pop");f.Pc=89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
