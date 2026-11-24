// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C470{
internal static JClass Build(){var c=new JClass("forge/game/card/CardState$LandTraitChanges","java/lang/Record",new string[]{"forge/game/card/ICardTraitChanges","forge/game/keyword/IKeywordsChange"},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("state","Lforge/game/card/CardState;",false,JValue.Default("Lforge/game/card/CardState;"),null));
c.Add(new JMethod(5391,"forge/game/card/CardState$LandTraitChanges","<init>","(Lforge/game/card/CardState;)V",0,2,2,new JHandler[]{},M5391));
c.Add(new JMethod(5392,"forge/game/card/CardState$LandTraitChanges","applySpellAbility","(Ljava/util/List;)Ljava/util/List;",1,7,3,new JHandler[]{},M5392));
c.Add(new JMethod(5393,"forge/game/card/CardState$LandTraitChanges","applyTrigger","(Ljava/util/List;)Ljava/util/List;",1,2,1,new JHandler[]{},M5393));
c.Add(new JMethod(5394,"forge/game/card/CardState$LandTraitChanges","applyReplacementEffect","(Ljava/util/List;)Ljava/util/List;",1,3,2,new JHandler[]{},M5394));
c.Add(new JMethod(5395,"forge/game/card/CardState$LandTraitChanges","applyStaticAbility","(Ljava/util/List;)Ljava/util/List;",1,2,1,new JHandler[]{},M5395));
c.Add(new JMethod(5396,"forge/game/card/CardState$LandTraitChanges","applyKeywords","(Lforge/game/keyword/KeywordCollection;)V",1,2,1,new JHandler[]{},M5396));
c.Add(new JMethod(5397,"forge/game/card/CardState$LandTraitChanges","copy","(Lforge/game/card/Card;Z)Lforge/game/card/CardState$LandTraitChanges;",1,3,1,new JHandler[]{},M5397));
c.Add(new JMethod(5398,"forge/game/card/CardState$LandTraitChanges","toString","()Ljava/lang/String;",17,1,1,new JHandler[]{},M5398));
c.Add(new JMethod(5399,"forge/game/card/CardState$LandTraitChanges","hashCode","()I",17,1,1,new JHandler[]{},M5399));
c.Add(new JMethod(5400,"forge/game/card/CardState$LandTraitChanges","equals","(Ljava/lang/Object;)Z",17,2,2,new JHandler[]{},M5400));
c.Add(new JMethod(5401,"forge/game/card/CardState$LandTraitChanges","state","()Lforge/game/card/CardState;",1,1,1,new JHandler[]{},M5401));
c.Add(new JMethod(5402,"forge/game/card/CardState$LandTraitChanges","copy","(Lforge/game/card/Card;Z)Lforge/game/card/ICardTraitChanges;",4161,3,3,new JHandler[]{},M5402));
c.Add(new JMethod(5403,"forge/game/card/CardState$LandTraitChanges","copy","(Lforge/game/card/Card;Z)Lforge/game/keyword/IKeywordsChange;",4161,3,3,new JHandler[]{},M5403));
}

internal static JStep M5391(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState$LandTraitChanges","state","Lforge/game/card/CardState;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5392(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$LandTraitChanges","state","Lforge/game/card/CardState;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/card/Card","hasRemoveIntrinsic","()Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?19:13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$LandTraitChanges","state","Lforge/game/card/CardState;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/CardState","getTypeWithChanges","()Lforge/card/CardTypeView;","invokevirtual",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/card/CardTypeView","isLand","()Z","invokeinterface",33);}
case 33:{f.Pc=f.Pop().Int!=0?38:36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return JStep.Return(f.Pop());}
case 38:{return rt.Call(f,"forge/card/MagicColor$Color","values","()[Lforge/card/MagicColor$Color;","invokestatic",41);}
case 41:{f.Locals[3]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=44;continue;}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{f.Locals[5]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[4]);f.Pc=53;continue;}
case 53:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?109:56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=60;continue;}
case 60:{f.Locals[6]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[6]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/card/MagicColor$Color","getBasicLandType","()Ljava/lang/String;","invokevirtual",67);}
case 67:{f.Pc=f.Pop().Reference!=null?73:70;continue;}
case 70:{f.Pc=103;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/card/MagicColor$Color","getBasicLandType","()Ljava/lang/String;","invokevirtual",79);}
case 79:{return rt.Call(f,"forge/card/CardTypeView","hasSubtype","(Ljava/lang/String;)Z","invokeinterface",84);}
case 84:{f.Pc=f.Pop().Int==0?103:87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$LandTraitChanges","state","Lforge/game/card/CardState;"));f.Pc=92;continue;}
case 92:{f.Push(f.Locals[6]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/card/CardState","getLandManaForColor","(Lforge/card/MagicColor$Color;)Lforge/game/spellability/SpellAbility;","invokevirtual",97);}
case 97:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",102);}
case 102:{f.StackOp("pop");f.Pc=103;continue;}
case 103:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=106;continue;}
case 106:{f.Pc=49;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5393(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$LandTraitChanges","state","Lforge/game/card/CardState;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/card/Card","hasRemoveIntrinsic","()Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?19:13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",19);}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5394(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$LandTraitChanges","state","Lforge/game/card/CardState;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/card/Card","hasRemoveIntrinsic","()Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?19:13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$LandTraitChanges","state","Lforge/game/card/CardState;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/CardState","getTypeWithChanges","()Lforge/card/CardTypeView;","invokevirtual",26);}
case 26:{f.Locals[2]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/card/CardTypeView","isPlaneswalker","()Z","invokeinterface",33);}
case 33:{f.Pc=f.Pop().Int==0?50:36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$LandTraitChanges","state","Lforge/game/card/CardState;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/card/CardState","getLoyaltyRep","()Lforge/game/replacement/ReplacementEffect;","invokevirtual",44);}
case 44:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",49);}
case 49:{f.StackOp("pop");f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/card/CardTypeView","isBattle","()Z","invokeinterface",56);}
case 56:{f.Pc=f.Pop().Int==0?73:59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$LandTraitChanges","state","Lforge/game/card/CardState;"));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/CardState","getDefenseRep","()Lforge/game/replacement/ReplacementEffect;","invokevirtual",67);}
case 67:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",72);}
case 72:{f.StackOp("pop");f.Pc=73;continue;}
case 73:{f.Push(f.Locals[2]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/card/CardTypeView","isSaga","()Z","invokeinterface",79);}
case 79:{f.Pc=f.Pop().Int==0?109:82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$LandTraitChanges","state","Lforge/game/card/CardState;"));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","READ_AHEAD","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","READ_AHEAD","Lforge/game/keyword/Keyword;"));f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/card/CardState","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int!=0?109:95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$LandTraitChanges","state","Lforge/game/card/CardState;"));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/card/CardState","getSagaRep","()Lforge/game/replacement/ReplacementEffect;","invokevirtual",103);}
case 103:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",108);}
case 108:{f.StackOp("pop");f.Pc=109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5395(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$LandTraitChanges","state","Lforge/game/card/CardState;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/card/Card","hasRemoveIntrinsic","()Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?19:13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",19);}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5396(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$LandTraitChanges","state","Lforge/game/card/CardState;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardState","getCard","()Lforge/game/card/Card;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/card/Card","hasRemoveIntrinsic","()Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?17:13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/keyword/KeywordCollection","clear","()V","invokevirtual",17);}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5397(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5398(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardState$LandTraitChanges:5398:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/CardState$LandTraitChanges;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5399(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/card/CardState$LandTraitChanges:5399:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/CardState$LandTraitChanges;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5400(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/game/card/CardState$LandTraitChanges:5400:2:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/card/CardState$LandTraitChanges;Ljava/lang/Object;)Z",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5401(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardState$LandTraitChanges","state","Lforge/game/card/CardState;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5402(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/CardState$LandTraitChanges","copy","(Lforge/game/card/Card;Z)Lforge/game/card/CardState$LandTraitChanges;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5403(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/CardState$LandTraitChanges","copy","(Lforge/game/card/Card;Z)Lforge/game/card/CardState$LandTraitChanges;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
