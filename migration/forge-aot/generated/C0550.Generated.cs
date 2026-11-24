// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C550{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostPutCardToLib","forge/game/cost/CostPartWithList",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("from","Lforge/game/zone/ZoneType;",false,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("sameZone","Z",false,JValue.Default("Z"),null));
c.Add(new JField("libPosition","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(6489,"forge/game/cost/CostPutCardToLib","getFrom","()Lforge/game/zone/ZoneType;",17,1,1,new JHandler[]{},M6489));
c.Add(new JMethod(6490,"forge/game/cost/CostPutCardToLib","getLibPos","()Ljava/lang/String;",17,1,1,new JHandler[]{},M6490));
c.Add(new JMethod(6491,"forge/game/cost/CostPutCardToLib","isSameZone","()Z",17,1,1,new JHandler[]{},M6491));
c.Add(new JMethod(6492,"forge/game/cost/CostPutCardToLib","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;)V",1,6,7,new JHandler[]{},M6492));
c.Add(new JMethod(6493,"forge/game/cost/CostPutCardToLib","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;Z)V",1,7,4,new JHandler[]{},M6493));
c.Add(new JMethod(6494,"forge/game/cost/CostPutCardToLib","paymentOrder","()I",1,1,1,new JHandler[]{},M6494));
c.Add(new JMethod(6495,"forge/game/cost/CostPutCardToLib","toString","()Ljava/lang/String;",17,4,4,new JHandler[]{},M6495));
c.Add(new JMethod(6496,"forge/game/cost/CostPutCardToLib","getHashForLKIList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6496));
c.Add(new JMethod(6497,"forge/game/cost/CostPutCardToLib","getHashForCardList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6497));
c.Add(new JMethod(6498,"forge/game/cost/CostPutCardToLib","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,12,5,new JHandler[]{},M6498));
c.Add(new JMethod(6499,"forge/game/cost/CostPutCardToLib","doPayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Z)Lforge/game/card/Card;",4,6,5,new JHandler[]{},M6499));
c.Add(new JMethod(6500,"forge/game/cost/CostPutCardToLib","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6500));
}

internal static JStep M6489(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCardToLib","from","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6490(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCardToLib","libPosition","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6491(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCardToLib","sameZone","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6492(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[5]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lforge/game/zone/ZoneType;Z)V","invokespecial",12);}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6493(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[4]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/cost/CostPartWithList","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("0")));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPutCardToLib","libPosition","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[5]);f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Reference!=null?26:20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=23;continue;}
case 23:{f.Pc=28;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPutCardToLib","from","Lforge/game/zone/ZoneType;",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPutCardToLib","libPosition","Ljava/lang/String;",value);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[6]);f.Pc=39;continue;}
case 39:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPutCardToLib","sameZone","Z",value);f.Pc=42;continue;}
case 42:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6494(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(10));f.Pc=2;continue;}
case 2:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6495(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","convertAmount","()Ljava/lang/Integer;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Put ")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","getTypeDescription","()Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Reference!=null?34:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","getType","()Ljava/lang/String;","invokevirtual",31);}
case 31:{f.Pc=38;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","getTypeDescription","()Ljava/lang/String;","invokevirtual",38);}
case 38:{f.Locals[3]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","payCostFromSource","()Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int==0?58:46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","getType","()Ljava/lang/String;","invokevirtual",51);}
case 51:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{f.Pc=72;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","getAmount","()Ljava/lang/String;","invokevirtual",64);}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/cost/Cost","convertAmountTypeToWords","(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",68);}
case 68:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",71);}
case 71:{f.StackOp("pop");f.Pc=72;continue;}
case 72:{f.Push(f.Locals[0]);f.Pc=73;continue;}
case 73:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCardToLib","sameZone","Z"));f.Pc=76;continue;}
case 76:{f.Pc=f.Pop().Int==0?96:79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String(" from the same ")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",85);}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCardToLib","from","Lforge/game/zone/ZoneType;"));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",92);}
case 92:{f.StackOp("pop");f.Pc=93;continue;}
case 93:{f.Pc=117;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","payCostFromSource","()Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int!=0?117:103;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String(" from your ")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",109);}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCardToLib","from","Lforge/game/zone/ZoneType;"));f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",116);}
case 116:{f.StackOp("pop");f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String(" on ")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",123);}
case 123:{f.StackOp("pop");f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCardToLib","libPosition","Ljava/lang/String;"));f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String("0")));f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",133);}
case 133:{f.Pc=f.Pop().Int==0?146:136;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{f.Push(JValue.R(rt.String("top of")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",142);}
case 142:{f.StackOp("pop");f.Pc=143;continue;}
case 143:{f.Pc=153;continue;}
case 146:{f.Push(f.Locals[1]);f.Pc=147;continue;}
case 147:{f.Push(JValue.R(rt.String("the bottom of")));f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",152);}
case 152:{f.StackOp("pop");f.Pc=153;continue;}
case 153:{f.Push(f.Locals[0]);f.Pc=154;continue;}
case 154:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCardToLib","sameZone","Z"));f.Pc=157;continue;}
case 157:{f.Pc=f.Pop().Int==0?170:160;continue;}
case 160:{f.Push(f.Locals[1]);f.Pc=161;continue;}
case 161:{f.Push(JValue.R(rt.String(" their owner's library")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",166);}
case 166:{f.StackOp("pop");f.Pc=167;continue;}
case 167:{f.Pc=194;continue;}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","payCostFromSource","()Z","invokevirtual",174);}
case 174:{f.Pc=f.Pop().Int==0?187:177;continue;}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String(" its owner's library")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",183);}
case 183:{f.StackOp("pop");f.Pc=184;continue;}
case 184:{f.Pc=194;continue;}
case 187:{f.Push(f.Locals[1]);f.Pc=188;continue;}
case 188:{f.Push(JValue.R(rt.String(" your library")));f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",193);}
case 193:{f.StackOp("pop");f.Pc=194;continue;}
case 194:{f.Push(f.Locals[1]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",198);}
case 198:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6496(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("CardPutToLib")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6497(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("CardPutToLibCards")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6498(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[4]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",11);}
case 11:{f.Locals[5]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",18);}
case 18:{f.Locals[6]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCardToLib","sameZone","Z"));f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Int==0?41:27;continue;}
case 27:{f.Push(f.Locals[5]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","getFrom","()Lforge/game/zone/ZoneType;","invokevirtual",33);}
case 33:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",36);}
case 36:{f.Locals[7]=f.Pop();f.Pc=38;continue;}
case 38:{f.Pc=51;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","getFrom","()Lforge/game/zone/ZoneType;","invokevirtual",46);}
case 46:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",49);}
case 49:{f.Locals[7]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[0]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","payCostFromSource","()Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int==0?68:58;continue;}
case 58:{f.Push(f.Locals[7]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",67);}
case 67:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 68:{f.Push(f.Locals[7]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","getType","()Ljava/lang/String;","invokevirtual",74);}
case 74:{f.Push(JValue.R(rt.String(";")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",79);}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[4]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",86);}
case 86:{f.Locals[7]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[7]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",95);}
case 95:{f.Push(f.Locals[6]);f.Pc=97;continue;}
case 97:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?102:100;continue;}
case 100:{f.Push(JValue.I(0));f.Pc=101;continue;}
case 101:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCardToLib","sameZone","Z"));f.Pc=106;continue;}
case 106:{f.Pc=f.Pop().Int==0?177:109;continue;}
case 109:{f.Push(JValue.I(0));f.Pc=110;continue;}
case 110:{f.Locals[8]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[5]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/Game","getPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",117);}
case 117:{f.Locals[9]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(f.Locals[9]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",126);}
case 126:{f.Locals[10]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[10]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",135);}
case 135:{f.Pc=f.Pop().Int==0?174:138;continue;}
case 138:{f.Push(f.Locals[10]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",145);}
case 145:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=148;continue;}
case 148:{f.Locals[11]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[7]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[11]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/card/CardPredicates","isController","(Lforge/game/player/Player;)Ljava/util/function/Predicate;","invokestatic",157);}
case 157:{return rt.Call(f,"forge/game/card/CardLists","count","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)I","invokestatic",160);}
case 160:{f.Push(f.Locals[6]);f.Pc=162;continue;}
case 162:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?171:165;continue;}
case 165:{f.Push(JValue.I(1));f.Pc=166;continue;}
case 166:{f.Locals[8]=f.Pop();f.Pc=168;continue;}
case 168:{f.Pc=174;continue;}
case 171:{f.Pc=128;continue;}
case 174:{f.Push(f.Locals[8]);f.Pc=176;continue;}
case 176:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 177:{f.Push(JValue.I(1));f.Pc=178;continue;}
case 178:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6499(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",3);}
case 3:{f.Locals[5]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[5]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPutCardToLib","table","Lforge/game/card/CardZoneTable;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",14);}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",21);}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/cost/CostPutCardToLib","getLibPos","()Ljava/lang/String;","invokevirtual",26);}
case 26:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",29);}
case 29:{f.Push(JValue.R(null));f.Pc=30;continue;}
case 30:{f.Push(f.Locals[5]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/GameAction","moveToLibrary","(Lforge/game/card/Card;ILforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",35);}
case 35:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6500(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostPutCardToLib;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
