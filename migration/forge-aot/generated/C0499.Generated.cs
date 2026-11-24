// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C499{
internal static JClass Build(){var c=new JClass("forge/game/card/sticker/AppliedSticker","java/lang/Object",new string[]{"forge/game/card/perpetual/PerpetualInterface"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("HAS_ATTACK_EFFECT","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"HasAttackEffect"));
c.Add(new JField("sticker","Lforge/game/card/sticker/Sticker;",false,JValue.Default("Lforge/game/card/sticker/Sticker;"),null));
c.Add(new JField("timestamp","J",false,JValue.Default("J"),null));
c.Add(new JField("namePosition","I",false,JValue.Default("I"),null));
c.Add(new JMethod(5900,"forge/game/card/sticker/AppliedSticker","<init>","(Lforge/game/card/sticker/Sticker;J)V",1,4,5,new JHandler[]{},M5900));
c.Add(new JMethod(5901,"forge/game/card/sticker/AppliedSticker","<init>","(Lforge/game/card/sticker/Sticker;JI)V",1,5,3,new JHandler[]{},M5901));
c.Add(new JMethod(5902,"forge/game/card/sticker/AppliedSticker","getSticker","()Lforge/game/card/sticker/Sticker;",1,1,1,new JHandler[]{},M5902));
c.Add(new JMethod(5903,"forge/game/card/sticker/AppliedSticker","getTimestamp","()J",1,1,2,new JHandler[]{},M5903));
c.Add(new JMethod(5904,"forge/game/card/sticker/AppliedSticker","getNamePosition","()I",1,1,1,new JHandler[]{},M5904));
c.Add(new JMethod(5905,"forge/game/card/sticker/AppliedSticker","getKind","()Lforge/game/card/sticker/StickerKind;",1,1,1,new JHandler[]{},M5905));
c.Add(new JMethod(5906,"forge/game/card/sticker/AppliedSticker","applyEffect","(Lforge/game/card/Card;)V",1,2,7,new JHandler[]{},M5906));
c.Add(new JMethod(5907,"forge/game/card/sticker/AppliedSticker","removeEffect","(Lforge/game/card/Card;)V",1,2,5,new JHandler[]{},M5907));
c.Add(new JMethod(5908,"forge/game/card/sticker/AppliedSticker","grantAbility","(Lforge/game/card/Card;)V",2,4,7,new JHandler[]{},M5908));
c.Add(new JMethod(5909,"forge/game/card/sticker/AppliedSticker","grantsAttackTrigger","(Lforge/game/card/CardTraitChanges;)Z",9,1,2,new JHandler[]{},M5909));
c.Add(new JMethod(5910,"forge/game/card/sticker/AppliedSticker","getGrantedKeywords","()Ljava/util/List;",1,1,2,new JHandler[]{},M5910));
c.Add(new JMethod(5911,"forge/game/card/sticker/AppliedSticker","getGrantedTraits","(Lforge/game/card/Card;)Lforge/game/card/CardTraitChanges;",1,10,7,new JHandler[]{},M5911));
c.Add(new JMethod(5912,"forge/game/card/sticker/AppliedSticker","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M5912));
c.Add(new JMethod(5913,"forge/game/card/sticker/AppliedSticker","lambda$grantsAttackTrigger$0","(Lforge/game/trigger/Trigger;)Z",4106,1,2,new JHandler[]{},M5913));
}

internal static JStep M5900(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/sticker/AppliedSticker","<init>","(Lforge/game/card/sticker/Sticker;JI)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5901(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/sticker/AppliedSticker","sticker","Lforge/game/card/sticker/Sticker;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/sticker/AppliedSticker","timestamp","J",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/sticker/AppliedSticker","namePosition","I",value);f.Pc=20;continue;}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5902(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","sticker","Lforge/game/card/sticker/Sticker;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5903(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","timestamp","J"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5904(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","namePosition","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5905(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","sticker","Lforge/game/card/sticker/Sticker;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/sticker/Sticker","getKind","()Lforge/game/card/sticker/StickerKind;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5906(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/card/sticker/AppliedSticker$1","$SwitchMap$forge$game$card$sticker$StickerKind","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/sticker/AppliedSticker$1","$SwitchMap$forge$game$card$sticker$StickerKind","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","sticker","Lforge/game/card/sticker/Sticker;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/sticker/Sticker","getKind","()Lforge/game/card/sticker/StickerKind;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/game/card/sticker/StickerKind","ordinal","()I","invokevirtual",13);}
case 13:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=14;continue;}
case 14:{switch(f.Pop().Int){case 1:f.Pc=44;break;case 2:f.Pc=76;break;case 3:f.Pc=83;break;case 4:f.Pc=91;break;default:f.Pc=91;break;}continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","sticker","Lforge/game/card/sticker/Sticker;"));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/card/sticker/Sticker","getPower","()I","invokevirtual",52);}
case 52:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",55);}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","sticker","Lforge/game/card/sticker/Sticker;"));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/card/sticker/Sticker","getToughness","()I","invokevirtual",62);}
case 62:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",65);}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","timestamp","J"));f.Pc=69;continue;}
case 69:{f.Push(JValue.L(0));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/card/Card","addNewPT","(Ljava/lang/Integer;Ljava/lang/Integer;JJ)V","invokevirtual",73);}
case 73:{f.Pc=91;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/game/card/Card","recomputeStickerName","()V","invokevirtual",80);}
case 80:{f.Pc=91;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/card/sticker/AppliedSticker","grantAbility","(Lforge/game/card/Card;)V","invokevirtual",88);}
case 88:{f.Pc=91;continue;}
case 91:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5907(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/card/sticker/AppliedSticker$1","$SwitchMap$forge$game$card$sticker$StickerKind","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/sticker/AppliedSticker$1","$SwitchMap$forge$game$card$sticker$StickerKind","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","sticker","Lforge/game/card/sticker/Sticker;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/sticker/Sticker","getKind","()Lforge/game/card/sticker/StickerKind;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/game/card/sticker/StickerKind","ordinal","()I","invokevirtual",13);}
case 13:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=14;continue;}
case 14:{switch(f.Pop().Int){case 1:f.Pc=44;break;case 2:f.Pc=56;break;case 3:f.Pc=69;break;case 4:f.Pc=101;break;default:f.Pc=101;break;}continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","timestamp","J"));f.Pc=49;continue;}
case 49:{f.Push(JValue.L(0));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/card/Card","removeNewPT","(JJ)V","invokevirtual",53);}
case 53:{f.Pc=101;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","timestamp","J"));f.Pc=61;continue;}
case 61:{f.Push(JValue.L(0));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/Card","removeChangedName","(JJ)Z","invokevirtual",65);}
case 65:{f.StackOp("pop");f.Pc=66;continue;}
case 66:{f.Pc=101;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","timestamp","J"));f.Pc=74;continue;}
case 74:{f.Push(JValue.L(0));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/card/Card","removeChangedCardKeywords","(JJ)Z","invokevirtual",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","timestamp","J"));f.Pc=84;continue;}
case 84:{f.Push(JValue.L(0));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/card/Card","removeChangedCardTraits","(JJ)Z","invokevirtual",88);}
case 88:{f.StackOp("pop");f.Pc=89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","timestamp","J"));f.Pc=94;continue;}
case 94:{f.Push(JValue.L(0));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/card/Card","removeChangedSVars","(JJ)V","invokevirtual",98);}
case 98:{f.Pc=101;continue;}
case 101:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5908(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/sticker/AppliedSticker","getGrantedKeywords","()Ljava/util/List;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",11);}
case 11:{f.Pc=f.Pop().Int!=0?26:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","timestamp","J"));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(null));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/Card","addChangedCardKeywords","(Ljava/util/List;Ljava/util/List;ZJLforge/game/staticability/StaticAbility;)V","invokevirtual",26);}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/sticker/AppliedSticker","getGrantedTraits","(Lforge/game/card/Card;)Lforge/game/card/CardTraitChanges;","invokevirtual",31);}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/CardTraitChanges","getAbilities","()Ljava/util/Collection;","invokevirtual",36);}
case 36:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",41);}
case 41:{f.Pc=f.Pop().Int==0?68:44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/CardTraitChanges","getTriggers","()Ljava/util/Collection;","invokevirtual",48);}
case 48:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",53);}
case 53:{f.Pc=f.Pop().Int==0?68:56;continue;}
case 56:{f.Push(f.Locals[3]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/card/CardTraitChanges","getStaticAbilities","()Ljava/util/Collection;","invokevirtual",60);}
case 60:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int!=0?80:68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[3]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","timestamp","J"));f.Pc=74;continue;}
case 74:{f.Push(JValue.L(0));f.Pc=75;continue;}
case 75:{f.Push(JValue.I(1));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/card/Card","addChangedCardTraits","(Lforge/game/card/ICardTraitChanges;JJZ)Lforge/game/card/ICardTraitChanges;","invokevirtual",79);}
case 79:{f.StackOp("pop");f.Pc=80;continue;}
case 80:{f.Push(f.Locals[3]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/sticker/AppliedSticker","grantsAttackTrigger","(Lforge/game/card/CardTraitChanges;)Z","invokestatic",84);}
case 84:{f.Pc=f.Pop().Int==0?103:87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String("HasAttackEffect")));f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("TRUE")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/Map","of","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;","invokestatic",95);}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","timestamp","J"));f.Pc=99;continue;}
case 99:{f.Push(JValue.L(0));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/card/Card","addChangedSVars","(Ljava/util/Map;JJ)V","invokevirtual",103);}
case 103:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5909(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardTraitChanges","getTriggers","()Ljava/util/Collection;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/util/Collection","stream","()Ljava/util/stream/Stream;","invokeinterface",9);}
case 9:{return rt.DynamicCall(f,"forge/game/card/sticker/AppliedSticker:5909:9:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",14);}
case 14:{return rt.Call(f,"java/util/stream/Stream","anyMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",19);}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5910(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","sticker","Lforge/game/card/sticker/Sticker;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/sticker/Sticker","getKeywords","()Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Reference!=null?14:10;continue;}
case 10:{return rt.Call(f,"java/util/List","of","()Ljava/util/List;","invokestatic",13);}
case 13:{return JStep.Return(f.Pop());}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","sticker","Lforge/game/card/sticker/Sticker;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/sticker/Sticker","getKeywords","()Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Push(JValue.R(rt.String(",")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",26);}
case 26:{return rt.Call(f,"java/util/Arrays","stream","([Ljava/lang/Object;)Ljava/util/stream/Stream;","invokestatic",29);}
case 29:{return rt.DynamicCall(f,"forge/game/card/sticker/AppliedSticker:5910:29:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",34);}
case 34:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",39);}
case 39:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",42);}
case 42:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5911(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","sticker","Lforge/game/card/sticker/Sticker;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/sticker/Sticker","getSheet","()Lforge/game/card/Card;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",23);}
case 23:{f.Locals[5]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","sticker","Lforge/game/card/sticker/Sticker;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/sticker/Sticker","getAbilitySVar","()Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Reference==null?94:35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","sticker","Lforge/game/card/sticker/Sticker;"));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/card/sticker/Sticker","getAbilitySVar","()Ljava/lang/String;","invokevirtual",42);}
case 42:{f.Push(JValue.R(rt.String(",")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",47);}
case 47:{f.Locals[6]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[6]);f.Pc=51;continue;}
case 51:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=52;continue;}
case 52:{f.Locals[7]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{f.Locals[8]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[8]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[7]);f.Pc=61;continue;}
case 61:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?94:64;continue;}
case 64:{f.Push(f.Locals[6]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[8]);f.Pc=68;continue;}
case 68:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=69;continue;}
case 69:{f.Locals[9]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[9]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",78);}
case 78:{f.Push(f.Locals[2]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/IHasSVars;)Lforge/game/spellability/SpellAbility;","invokestatic",82);}
case 82:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",87);}
case 87:{f.StackOp("pop");f.Pc=88;continue;}
case 88:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=91;continue;}
case 91:{f.Pc=57;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","sticker","Lforge/game/card/sticker/Sticker;"));f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/card/sticker/Sticker","getTriggers","()Ljava/lang/String;","invokevirtual",101);}
case 101:{f.Pc=f.Pop().Reference==null?169:104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","sticker","Lforge/game/card/sticker/Sticker;"));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/card/sticker/Sticker","getTriggers","()Ljava/lang/String;","invokevirtual",111);}
case 111:{f.Push(JValue.R(rt.String(",")));f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",116);}
case 116:{f.Locals[6]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[6]);f.Pc=120;continue;}
case 120:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=121;continue;}
case 121:{f.Locals[7]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(JValue.I(0));f.Pc=124;continue;}
case 124:{f.Locals[8]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[8]);f.Pc=128;continue;}
case 128:{f.Push(f.Locals[7]);f.Pc=130;continue;}
case 130:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?169:133;continue;}
case 133:{f.Push(f.Locals[6]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[8]);f.Pc=137;continue;}
case 137:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=138;continue;}
case 138:{f.Locals[9]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(f.Locals[4]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[2]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[9]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",148);}
case 148:{return rt.Call(f,"forge/game/card/CardState","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",151);}
case 151:{f.Push(f.Locals[1]);f.Pc=152;continue;}
case 152:{f.Push(JValue.I(0));f.Pc=153;continue;}
case 153:{f.Push(f.Locals[2]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/trigger/TriggerHandler","parseTrigger","(Ljava/lang/String;Lforge/game/card/Card;ZLforge/game/IHasSVars;)Lforge/game/trigger/Trigger;","invokestatic",157);}
case 157:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",162);}
case 162:{f.StackOp("pop");f.Pc=163;continue;}
case 163:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=166;continue;}
case 166:{f.Pc=126;continue;}
case 169:{f.Push(f.Locals[0]);f.Pc=170;continue;}
case 170:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","sticker","Lforge/game/card/sticker/Sticker;"));f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/card/sticker/Sticker","getStatics","()Ljava/lang/String;","invokevirtual",176);}
case 176:{f.Pc=f.Pop().Reference==null?244:179;continue;}
case 179:{f.Push(f.Locals[0]);f.Pc=180;continue;}
case 180:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","sticker","Lforge/game/card/sticker/Sticker;"));f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/card/sticker/Sticker","getStatics","()Ljava/lang/String;","invokevirtual",186);}
case 186:{f.Push(JValue.R(rt.String(",")));f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",191);}
case 191:{f.Locals[6]=f.Pop();f.Pc=193;continue;}
case 193:{f.Push(f.Locals[6]);f.Pc=195;continue;}
case 195:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=196;continue;}
case 196:{f.Locals[7]=f.Pop();f.Pc=198;continue;}
case 198:{f.Push(JValue.I(0));f.Pc=199;continue;}
case 199:{f.Locals[8]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(f.Locals[8]);f.Pc=203;continue;}
case 203:{f.Push(f.Locals[7]);f.Pc=205;continue;}
case 205:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?244:208;continue;}
case 208:{f.Push(f.Locals[6]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[8]);f.Pc=212;continue;}
case 212:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=213;continue;}
case 213:{f.Locals[9]=f.Pop();f.Pc=215;continue;}
case 215:{f.Push(f.Locals[5]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[2]);f.Pc=218;continue;}
case 218:{f.Push(f.Locals[9]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",223);}
case 223:{return rt.Call(f,"forge/game/card/CardState","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",226);}
case 226:{f.Push(f.Locals[1]);f.Pc=227;continue;}
case 227:{f.Push(f.Locals[2]);f.Pc=228;continue;}
case 228:{f.Push(JValue.I(0));f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/staticability/StaticAbility","create","(Ljava/lang/String;Lforge/game/card/Card;Lforge/game/card/CardState;Z)Lforge/game/staticability/StaticAbility;","invokestatic",232);}
case 232:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",237);}
case 237:{f.StackOp("pop");f.Pc=238;continue;}
case 238:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=241;continue;}
case 241:{f.Pc=201;continue;}
case 244:{if(!rt.EnsureInitialized(f,"forge/game/card/CardTraitChanges"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardTraitChanges")));f.Pc=247;continue;}
case 247:{f.StackOp("dup");f.Pc=248;continue;}
case 248:{f.Push(f.Locals[3]);f.Pc=249;continue;}
case 249:{f.Push(f.Locals[4]);f.Pc=251;continue;}
case 251:{f.Push(JValue.R(null));f.Pc=252;continue;}
case 252:{f.Push(f.Locals[5]);f.Pc=254;continue;}
case 254:{f.Push(JValue.R(null));f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/card/CardTraitChanges","<init>","(Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/function/Predicate;)V","invokespecial",258);}
case 258:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5912(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/sticker/AppliedSticker","sticker","Lforge/game/card/sticker/Sticker;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/sticker/Sticker","toString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5913(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/trigger/Trigger","getMode","()Lforge/game/trigger/TriggerType;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","Attacks","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","Attacks","Lforge/game/trigger/TriggerType;"));f.Pc=7;continue;}
case 7:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?14:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Pc=15;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
