// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C529{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostDiscard","forge/game/cost/CostPartWithList",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("discardedBefore","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JMethod(6281,"forge/game/cost/CostDiscard","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",1,4,4,new JHandler[]{},M6281));
c.Add(new JMethod(6282,"forge/game/cost/CostDiscard","paymentOrder","()I",1,1,1,new JHandler[]{},M6282));
c.Add(new JMethod(6283,"forge/game/cost/CostDiscard","getMaxAmountX","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/lang/Integer;",1,8,5,new JHandler[]{},M6283));
c.Add(new JMethod(6284,"forge/game/cost/CostDiscard","toString","()Ljava/lang/String;",17,4,4,new JHandler[]{},M6284));
c.Add(new JMethod(6285,"forge/game/cost/CostDiscard","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,12,5,new JHandler[]{},M6285));
c.Add(new JMethod(6286,"forge/game/cost/CostDiscard","doPayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Z)Lforge/game/card/Card;",4,7,5,new JHandler[]{},M6286));
c.Add(new JMethod(6287,"forge/game/cost/CostDiscard","getHashForLKIList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6287));
c.Add(new JMethod(6288,"forge/game/cost/CostDiscard","getHashForCardList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6288));
c.Add(new JMethod(6289,"forge/game/cost/CostDiscard","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6289));
c.Add(new JMethod(6290,"forge/game/cost/CostDiscard","handleBeforePayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;)V",4,4,2,new JHandler[]{},M6290));
c.Add(new JMethod(6291,"forge/game/cost/CostDiscard","handleChangeZoneTrigger","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;)V",4,5,5,new JHandler[]{},M6291));
}

internal static JStep M6281(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/CostPartWithList","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6282(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(10));f.Pc=2;continue;}
case 2:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6283(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/cost/CostDiscard","getType","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[5]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{f.Locals[6]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[5]);f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("+WithDifferentNames")));f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?39:25;continue;}
case 25:{f.Push(f.Locals[5]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("+WithDifferentNames")));f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Locals[5]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{f.Locals[6]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/player/Player","canDiscardBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int==0?58:48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",55);}
case 55:{f.Pc=61;continue;}
case 58:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=61;continue;}
case 61:{f.Locals[7]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("Random")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",70);}
case 70:{f.Pc=f.Pop().Int!=0?91:73;continue;}
case 73:{f.Push(f.Locals[7]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[5]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String(";")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",82);}
case 82:{f.Push(f.Locals[2]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[1]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",89);}
case 89:{f.Locals[7]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[6]);f.Pc=93;continue;}
case 93:{f.Pc=f.Pop().Int==0?105:96;continue;}
case 96:{f.Push(f.Locals[7]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/card/CardLists","getDifferentNamesCount","(Ljava/lang/Iterable;)I","invokestatic",101);}
case 101:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",104);}
case 104:{return JStep.Return(f.Pop());}
case 105:{f.Push(f.Locals[7]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",112);}
case 112:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",115);}
case 115:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6284(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Discard ")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/cost/CostDiscard","convertAmount","()Ljava/lang/Integer;","invokevirtual",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/cost/CostDiscard","payCostFromSource","()Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?39:27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/cost/CostDiscard","getType","()Ljava/lang/String;","invokevirtual",32);}
case 32:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{f.Pc=224;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/cost/CostDiscard","getType","()Ljava/lang/String;","invokevirtual",43);}
case 43:{f.Push(JValue.R(rt.String("Hand")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?61:51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("your hand")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",57);}
case 57:{f.StackOp("pop");f.Pc=58;continue;}
case 58:{f.Pc=224;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/cost/CostDiscard","getType","()Ljava/lang/String;","invokevirtual",65);}
case 65:{f.Push(JValue.R(rt.String("LastDrawn")));f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",70);}
case 70:{f.Pc=f.Pop().Int==0?83:73;continue;}
case 73:{f.Push(f.Locals[1]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("the last card you drew this turn")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",79);}
case 79:{f.StackOp("pop");f.Pc=80;continue;}
case 80:{f.Pc=224;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/cost/CostDiscard","getType","()Ljava/lang/String;","invokevirtual",87);}
case 87:{f.Push(JValue.R(rt.String("+WithDifferentNames")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",92);}
case 92:{f.Pc=f.Pop().Int==0?118:95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/cost/CostDiscard","getAmount","()Ljava/lang/String;","invokevirtual",101);}
case 101:{f.Push(JValue.R(rt.String("Card")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/cost/Cost","convertAmountTypeToWords","(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",106);}
case 106:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",109);}
case 109:{f.Push(JValue.R(rt.String(" with different names")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",114);}
case 114:{f.StackOp("pop");f.Pc=115;continue;}
case 115:{f.Pc=224;continue;}
case 118:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=121;continue;}
case 121:{f.StackOp("dup");f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",125);}
case 125:{f.Locals[3]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/cost/CostDiscard","getType","()Ljava/lang/String;","invokevirtual",130);}
case 130:{f.Push(JValue.R(rt.String("Card")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",135);}
case 135:{f.Pc=f.Pop().Int!=0?150:138;continue;}
case 138:{f.Push(f.Locals[0]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/cost/CostDiscard","getType","()Ljava/lang/String;","invokevirtual",142);}
case 142:{f.Push(JValue.R(rt.String("Random")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",147);}
case 147:{f.Pc=f.Pop().Int==0?160:150;continue;}
case 150:{f.Push(f.Locals[3]);f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String("card")));f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",156);}
case 156:{f.StackOp("pop");f.Pc=157;continue;}
case 157:{f.Pc=188;continue;}
case 160:{f.Push(f.Locals[3]);f.Pc=161;continue;}
case 161:{f.Push(f.Locals[0]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/cost/CostDiscard","getDescriptiveType","()Ljava/lang/String;","invokevirtual",165);}
case 165:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",168);}
case 168:{f.StackOp("pop");f.Pc=169;continue;}
case 169:{f.Push(f.Locals[3]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",173);}
case 173:{f.Push(JValue.R(rt.String("(?i).*\\bcards?$")));f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",178);}
case 178:{f.Pc=f.Pop().Int!=0?188:181;continue;}
case 181:{f.Push(f.Locals[3]);f.Pc=182;continue;}
case 182:{f.Push(JValue.R(rt.String(" card")));f.Pc=184;continue;}
case 184:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",187);}
case 187:{f.StackOp("pop");f.Pc=188;continue;}
case 188:{f.Push(f.Locals[1]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[2]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[0]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/cost/CostDiscard","getAmount","()Ljava/lang/String;","invokevirtual",194);}
case 194:{f.Push(f.Locals[3]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",198);}
case 198:{return rt.Call(f,"forge/game/cost/Cost","convertAmountTypeToWords","(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",201);}
case 201:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",204);}
case 204:{f.StackOp("pop");f.Pc=205;continue;}
case 205:{f.Push(f.Locals[0]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/cost/CostDiscard","getType","()Ljava/lang/String;","invokevirtual",209);}
case 209:{f.Push(JValue.R(rt.String("Random")));f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",214);}
case 214:{f.Pc=f.Pop().Int==0?224:217;continue;}
case 217:{f.Push(f.Locals[1]);f.Pc=218;continue;}
case 218:{f.Push(JValue.R(rt.String(" at random")));f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",223);}
case 223:{f.StackOp("pop");f.Pc=224;continue;}
case 224:{f.Push(f.Locals[1]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",228);}
case 228:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6285(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/player/Player","canDiscardBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?25:15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",22);}
case 22:{f.Pc=28;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardCollection","EMPTY","Lforge/game/card/CardCollectionView;"));f.Pc=28;continue;}
case 28:{f.Locals[5]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/cost/CostDiscard","getType","()Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Locals[6]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/cost/CostDiscard","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",41);}
case 41:{f.Locals[7]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/cost/CostDiscard","payCostFromSource","()Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?58:50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/Card","canBeDiscardedBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",57);}
case 57:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 58:{f.Push(f.Locals[6]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("Hand")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?90:68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",75);}
case 75:{return rt.Call(f,"forge/game/zone/PlayerZone","isEmpty","()Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int==0?83:81;continue;}
case 81:{f.Push(JValue.I(1));f.Pc=82;continue;}
case 82:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/player/Player","canDiscardBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",89);}
case 89:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 90:{f.Push(f.Locals[6]);f.Pc=92;continue;}
case 92:{f.Push(JValue.R(rt.String("LastDrawn")));f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",97);}
case 97:{f.Pc=f.Pop().Int==0?116:100;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/player/Player","getLastDrawnCard","()Lforge/game/card/Card;","invokevirtual",104);}
case 104:{f.Locals[8]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[5]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[8]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",115);}
case 115:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 116:{f.Push(JValue.I(0));f.Pc=117;continue;}
case 117:{f.Locals[8]=f.Pop();f.Pc=119;continue;}
case 119:{f.Push(JValue.I(0));f.Pc=120;continue;}
case 120:{f.Locals[9]=f.Pop();f.Pc=122;continue;}
case 122:{f.Push(f.Locals[6]);f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("+WithSameName")));f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",129);}
case 129:{f.Pc=f.Pop().Int==0?146:132;continue;}
case 132:{f.Push(JValue.I(1));f.Pc=133;continue;}
case 133:{f.Locals[8]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[6]);f.Pc=137;continue;}
case 137:{f.Push(JValue.R(rt.String("+WithSameName")));f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String("")));f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/util/TextUtil","fastReplace","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",144);}
case 144:{f.Locals[6]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[6]);f.Pc=148;continue;}
case 148:{f.Push(JValue.R(rt.String("+WithDifferentNames")));f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",153);}
case 153:{f.Pc=f.Pop().Int==0?170:156;continue;}
case 156:{f.Push(f.Locals[6]);f.Pc=158;continue;}
case 158:{f.Push(JValue.R(rt.String("+WithDifferentNames")));f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("")));f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",165);}
case 165:{f.Locals[6]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(JValue.I(1));f.Pc=168;continue;}
case 168:{f.Locals[9]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[6]);f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",177);}
case 177:{f.Pc=f.Pop().Int==0?191:180;continue;}
case 180:{f.Push(f.Locals[4]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/card/Card","hasChosenColor","()Z","invokevirtual",185);}
case 185:{f.Pc=f.Pop().Int!=0?191:188;continue;}
case 188:{f.Pc=229;continue;}
case 191:{f.Push(f.Locals[6]);f.Pc=193;continue;}
case 193:{f.Push(JValue.R(rt.String("Random")));f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",198);}
case 198:{f.Pc=f.Pop().Int!=0?229:201;continue;}
case 201:{f.Push(f.Locals[6]);f.Pc=203;continue;}
case 203:{f.Push(JValue.R(rt.String("X")));f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",208);}
case 208:{f.Pc=f.Pop().Int!=0?229:211;continue;}
case 211:{f.Push(f.Locals[5]);f.Pc=213;continue;}
case 213:{f.Push(f.Locals[6]);f.Pc=215;continue;}
case 215:{f.Push(JValue.R(rt.String(";")));f.Pc=217;continue;}
case 217:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",220);}
case 220:{f.Push(f.Locals[2]);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[4]);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[1]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",227);}
case 227:{f.Locals[5]=f.Pop();f.Pc=229;continue;}
case 229:{f.Push(f.Locals[8]);f.Pc=231;continue;}
case 231:{f.Pc=f.Pop().Int==0?289:234;continue;}
case 234:{f.Push(f.Locals[5]);f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",241);}
case 241:{f.Locals[10]=f.Pop();f.Pc=243;continue;}
case 243:{f.Push(f.Locals[10]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",250);}
case 250:{f.Pc=f.Pop().Int==0?287:253;continue;}
case 253:{f.Push(f.Locals[10]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",260);}
case 260:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=263;continue;}
case 263:{f.Locals[11]=f.Pop();f.Pc=265;continue;}
case 265:{f.Push(f.Locals[5]);f.Pc=267;continue;}
case 267:{f.Push(f.Locals[11]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",272);}
case 272:{return rt.Call(f,"forge/game/card/CardPredicates","nameEquals","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",275);}
case 275:{return rt.Call(f,"forge/game/card/CardLists","count","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)I","invokestatic",278);}
case 278:{f.Push(JValue.I(1));f.Pc=279;continue;}
case 279:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?284:282;continue;}
case 282:{f.Push(JValue.I(1));f.Pc=283;continue;}
case 283:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 284:{f.Pc=243;continue;}
case 287:{f.Push(JValue.I(0));f.Pc=288;continue;}
case 288:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 289:{f.Push(f.Locals[9]);f.Pc=291;continue;}
case 291:{f.Pc=f.Pop().Int==0?306:294;continue;}
case 294:{f.Push(f.Locals[5]);f.Pc=296;continue;}
case 296:{return rt.Call(f,"forge/game/card/CardLists","getDifferentNamesCount","(Ljava/lang/Iterable;)I","invokestatic",299);}
case 299:{f.Push(f.Locals[7]);f.Pc=301;continue;}
case 301:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?306:304;continue;}
case 304:{f.Push(JValue.I(0));f.Pc=305;continue;}
case 305:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 306:{f.Push(JValue.I(0));f.Pc=307;continue;}
case 307:{f.Locals[10]=f.Pop();f.Pc=309;continue;}
case 309:{f.Push(f.Locals[4]);f.Pc=311;continue;}
case 311:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/card/Card","isInZone","(Lforge/game/zone/ZoneType;)Z","invokevirtual",317);}
case 317:{f.Pc=f.Pop().Int==0?347:320;continue;}
case 320:{f.Push(f.Locals[2]);f.Pc=321;continue;}
case 321:{f.Push(f.Locals[4]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",326);}
case 326:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",329);}
case 329:{f.Pc=f.Pop().Int==0?347:332;continue;}
case 332:{f.Push(f.Locals[5]);f.Pc=334;continue;}
case 334:{f.Push(f.Locals[4]);f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/card/CardCollectionView","contains","(Ljava/lang/Object;)Z","invokeinterface",341);}
case 341:{f.Pc=f.Pop().Int==0?347:344;continue;}
case 344:{f.Push(JValue.I(1));f.Pc=345;continue;}
case 345:{f.Locals[10]=f.Pop();f.Pc=347;continue;}
case 347:{f.Push(f.Locals[7]);f.Pc=349;continue;}
case 349:{f.Push(f.Locals[5]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",356);}
case 356:{f.Push(f.Locals[10]);f.Pc=358;continue;}
case 358:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=359;continue;}
case 359:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?364:362;continue;}
case 362:{f.Push(JValue.I(0));f.Pc=363;continue;}
case 363:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 364:{f.Push(JValue.I(1));f.Pc=365;continue;}
case 365:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6286(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",3);}
case 3:{f.Locals[5]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[5]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostDiscard","table","Lforge/game/card/CardZoneTable;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",14);}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","isCycling","()Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int==0?47:21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?47:32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cycling","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cycling","Lforge/game/ability/AbilityKey;"));f.Pc=37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",41);}
case 41:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",46);}
case 46:{f.StackOp("pop");f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",51);}
case 51:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",54);}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",58);}
case 58:{return rt.Call(f,"forge/game/zone/MagicStack","isResolving","(Lforge/game/card/Card;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int==0?68:64;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Pc=69;continue;}
case 68:{f.Push(JValue.R(null));f.Pc=69;continue;}
case 69:{f.Locals[6]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{f.Push(f.Locals[6]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[5]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/player/Player","discard","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Lforge/game/card/Card;","invokevirtual",82);}
case 82:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6287(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Discarded")));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6288(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("DiscardedCards")));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6289(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostDiscard;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6290(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/player/Player","getDiscardedThisTurn","()Ljava/util/List;","invokevirtual",5);}
case 5:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",8);}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostDiscard","discardedBefore","Ljava/util/List;",value);f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6291(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/CostPartWithList","handleChangeZoneTrigger","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;)V","invokespecial",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostDiscard","cardList","Lforge/game/card/CardCollection;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int!=0?88:17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=28;continue;}
case 28:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=31;continue;}
case 31:{f.StackOp("dup");f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostDiscard","cardList","Lforge/game/card/CardCollection;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",39);}
case 39:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",44);}
case 44:{f.StackOp("pop");f.Pc=45;continue;}
case 45:{f.Push(f.Locals[4]);f.Pc=47;continue;}
case 47:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",56);}
case 56:{f.StackOp("pop");f.Pc=57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DiscardedBefore","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DiscardedBefore","Lforge/game/ability/AbilityKey;"));f.Pc=62;continue;}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostDiscard","discardedBefore","Ljava/util/List;"));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",71);}
case 71:{f.StackOp("pop");f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",76);}
case 76:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",79);}
case 79:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","DiscardedAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","DiscardedAll","Lforge/game/trigger/TriggerType;"));f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{f.Push(JValue.I(0));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",88);}
case 88:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
