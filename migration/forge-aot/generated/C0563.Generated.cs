// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C563{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostUnattach","forge/game/cost/CostPartWithList",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JMethod(6613,"forge/game/cost/CostUnattach","<init>","(Ljava/lang/String;Ljava/lang/String;)V",1,3,4,new JHandler[]{},M6613));
c.Add(new JMethod(6614,"forge/game/cost/CostUnattach","isUndoable","()Z",1,1,1,new JHandler[]{},M6614));
c.Add(new JMethod(6615,"forge/game/cost/CostUnattach","isReusable","()Z",1,1,1,new JHandler[]{},M6615));
c.Add(new JMethod(6616,"forge/game/cost/CostUnattach","toString","()Ljava/lang/String;",17,1,4,new JHandler[]{},M6616));
c.Add(new JMethod(6617,"forge/game/cost/CostUnattach","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,4,4,new JHandler[]{},M6617));
c.Add(new JMethod(6618,"forge/game/cost/CostUnattach","findCardToUnattach","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;",1,6,5,new JHandler[]{},M6618));
c.Add(new JMethod(6619,"forge/game/cost/CostUnattach","doPayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Z)Lforge/game/card/Card;",4,5,2,new JHandler[]{},M6619));
c.Add(new JMethod(6620,"forge/game/cost/CostUnattach","getHashForLKIList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6620));
c.Add(new JMethod(6621,"forge/game/cost/CostUnattach","getHashForCardList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6621));
c.Add(new JMethod(6622,"forge/game/cost/CostUnattach","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6622));
}

internal static JStep M6613(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("1")));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/cost/CostPartWithList","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",8);}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6614(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6615(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6616(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(2));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Unattach")));f.Pc=8;continue;}
case 8:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/cost/CostUnattach","getTypeDescription","()Ljava/lang/String;","invokevirtual",15);}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",19);}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6617(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",5);}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/cost/CostUnattach","findCardToUnattach","(Lforge/game/card/Card;Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokevirtual",10);}
case 10:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int!=0?20:16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{f.Pc=21;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6618(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{f.Locals[4]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/cost/CostUnattach","payCostFromSource","()Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int==0?33:16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","isEquipping","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?113:23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{f.Pc=113;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/cost/CostUnattach","getType","()Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Push(JValue.R(rt.String("OriginalHost")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?70:45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",49);}
case 49:{f.Locals[5]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[5]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/Card","isEquipping","()Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?67:59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",66);}
case 66:{f.StackOp("pop");f.Pc=67;continue;}
case 67:{f.Pc=113;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/card/Card","getEquippedBy","()Lforge/game/card/CardCollectionView;","invokevirtual",76);}
case 76:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",79);}
case 79:{f.StackOp("pop");f.Pc=80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/cost/CostUnattach","getType","()Ljava/lang/String;","invokevirtual",84);}
case 84:{f.Push(JValue.R(rt.String("X")));f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int==0?99:92;continue;}
case 92:{f.Push(f.Locals[3]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/spellability/SpellAbility","getXManaCostPaid","()Ljava/lang/Integer;","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Reference==null?113:99;continue;}
case 99:{f.Push(f.Locals[4]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/cost/CostUnattach","getType","()Ljava/lang/String;","invokevirtual",105);}
case 105:{f.Push(f.Locals[2]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[1]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",111);}
case 111:{f.Locals[4]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[4]);f.Pc=115;continue;}
case 115:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6619(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[3]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[3]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","getEntityAttachedTo","()Lforge/game/GameEntity;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/card/Card","unattachFromEntity","(Lforge/game/GameEntity;)V","invokevirtual",8);}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6620(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Unattached")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6621(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("UnattachedCards")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6622(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostUnattach;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
