// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C559{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostSacrifice","forge/game/cost/CostPartWithList",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JMethod(6578,"forge/game/cost/CostSacrifice","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",1,4,4,new JHandler[]{},M6578));
c.Add(new JMethod(6579,"forge/game/cost/CostSacrifice","paymentOrder","()I",1,1,1,new JHandler[]{},M6579));
c.Add(new JMethod(6580,"forge/game/cost/CostSacrifice","getMaxAmountX","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/lang/Integer;",1,8,5,new JHandler[]{},M6580));
c.Add(new JMethod(6581,"forge/game/cost/CostSacrifice","toString","()Ljava/lang/String;",17,4,3,new JHandler[]{},M6581));
c.Add(new JMethod(6582,"forge/game/cost/CostSacrifice","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,6,5,new JHandler[]{},M6582));
c.Add(new JMethod(6583,"forge/game/cost/CostSacrifice","doPayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Z)Lforge/game/card/Card;",4,5,1,new JHandler[]{},M6583));
c.Add(new JMethod(6584,"forge/game/cost/CostSacrifice","canPayListAtOnce","()Z",4,1,1,new JHandler[]{},M6584));
c.Add(new JMethod(6585,"forge/game/cost/CostSacrifice","doListPayment","(Lforge/game/player/Player;Lforge/game/spellability/SpellAbility;Lforge/game/card/CardCollectionView;Z)Lforge/game/card/CardCollectionView;",4,7,5,new JHandler[]{},M6585));
c.Add(new JMethod(6586,"forge/game/cost/CostSacrifice","getHashForLKIList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6586));
c.Add(new JMethod(6587,"forge/game/cost/CostSacrifice","getHashForCardList","()Ljava/lang/String;",1,1,1,new JHandler[]{},M6587));
c.Add(new JMethod(6588,"forge/game/cost/CostSacrifice","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6588));
}

internal static JStep M6578(JRuntime rt,JFrame f)
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

internal static JStep M6579(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(15));f.Pc=2;continue;}
case 2:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6580(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/cost/CostSacrifice","getType","()Ljava/lang/String;","invokevirtual",10);}
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
case 40:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",46);}
case 46:{f.Locals[7]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("X")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int!=0?76:58;continue;}
case 58:{f.Push(f.Locals[7]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{f.Push(JValue.R(rt.String(";")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",67);}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",74);}
case 74:{f.Locals[7]=f.Pop();f.Pc=76;continue;}
case 76:{f.Push(f.Locals[7]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[3]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/card/CardPredicates","canBeSacrificedBy","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/function/Predicate;","invokestatic",83);}
case 83:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",86);}
case 86:{f.Locals[7]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[6]);f.Pc=90;continue;}
case 90:{f.Pc=f.Pop().Int==0?102:93;continue;}
case 93:{f.Push(f.Locals[7]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/card/CardLists","getDifferentNamesCount","(Ljava/lang/Iterable;)I","invokestatic",98);}
case 98:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",101);}
case 101:{return JStep.Return(f.Pop());}
case 102:{f.Push(f.Locals[7]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",109);}
case 109:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",112);}
case 112:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6581(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/CostSacrifice","getAmount","()Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Push(JValue.R(rt.String("X")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?30:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("You may sacrifice ")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Pc=37;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("Sacrifice ")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",36);}
case 36:{f.StackOp("pop");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/cost/CostSacrifice","payCostFromSource","()Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?82:44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/cost/CostSacrifice","getTypeDescription","()Ljava/lang/String;","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Reference==null?64:52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/cost/CostSacrifice","getTypeDescription","()Ljava/lang/String;","invokevirtual",56);}
case 56:{f.Push(JValue.R(rt.String("this")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int!=0?71:64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/cost/CostSacrifice","getType","()Ljava/lang/String;","invokevirtual",68);}
case 68:{f.Pc=75;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/cost/CostSacrifice","getTypeDescription","()Ljava/lang/String;","invokevirtual",75);}
case 75:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Pc=234;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/cost/CostSacrifice","getAmount","()Ljava/lang/String;","invokevirtual",86);}
case 86:{f.Push(JValue.R(rt.String("X")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?128:94;continue;}
case 94:{f.Push(f.Locals[0]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/cost/CostSacrifice","getType","()Ljava/lang/String;","invokevirtual",98);}
case 98:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",101);}
case 101:{f.Push(JValue.R(rt.String(";")));f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("s and/or ")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",108);}
case 108:{f.Locals[2]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("any number of ")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",115);}
case 115:{f.Push(f.Locals[2]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",119);}
case 119:{f.Push(JValue.R(rt.String("s")));f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",124);}
case 124:{f.StackOp("pop");f.Pc=125;continue;}
case 125:{f.Pc=234;continue;}
case 128:{f.Push(f.Locals[0]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/cost/CostSacrifice","getTypeDescription","()Ljava/lang/String;","invokevirtual",132);}
case 132:{f.Pc=f.Pop().Reference!=null?168:135;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/cost/CostSacrifice","getType","()Ljava/lang/String;","invokevirtual",139);}
case 139:{f.Locals[3]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(f.Locals[3]);f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",146);}
case 146:{f.Pc=f.Pop().Int!=0?156:149;continue;}
case 149:{f.Push(f.Locals[3]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/card/CardType$CoreType","isValidEnum","(Ljava/lang/String;)Z","invokestatic",153);}
case 153:{f.Pc=f.Pop().Int==0?163:156;continue;}
case 156:{f.Push(f.Locals[3]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",160);}
case 160:{f.Pc=164;continue;}
case 163:{f.Push(f.Locals[3]);f.Pc=164;continue;}
case 164:{f.Locals[2]=f.Pop();f.Pc=165;continue;}
case 165:{f.Pc=173;continue;}
case 168:{f.Push(f.Locals[0]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/cost/CostSacrifice","getTypeDescription","()Ljava/lang/String;","invokevirtual",172);}
case 172:{f.Locals[2]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[2]);f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("^an? ")));f.Pc=176;continue;}
case 176:{f.Push(JValue.R(rt.String("")));f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/lang/String","replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",181);}
case 181:{f.Locals[2]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(f.Locals[2]);f.Pc=183;continue;}
case 183:{f.Push(JValue.R(rt.String("another")));f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",188);}
case 188:{f.Pc=f.Pop().Int==0?200:191;continue;}
case 191:{f.Push(f.Locals[1]);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[2]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",196);}
case 196:{f.StackOp("pop");f.Pc=197;continue;}
case 197:{f.Pc=234;continue;}
case 200:{f.Push(f.Locals[1]);f.Pc=201;continue;}
case 201:{f.Push(f.Locals[0]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/cost/CostSacrifice","convertAmount","()Ljava/lang/Integer;","invokevirtual",205);}
case 205:{f.Pc=f.Pop().Reference!=null?219:208;continue;}
case 208:{f.Push(f.Locals[0]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/cost/CostSacrifice","getAmount","()Ljava/lang/String;","invokevirtual",212);}
case 212:{f.Push(f.Locals[2]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",216);}
case 216:{f.Pc=230;continue;}
case 219:{f.Push(f.Locals[0]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/cost/CostSacrifice","convertAmount","()Ljava/lang/Integer;","invokevirtual",223);}
case 223:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",226);}
case 226:{f.Push(f.Locals[2]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",230);}
case 230:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",233);}
case 233:{f.StackOp("pop");f.Pc=234;continue;}
case 234:{f.Push(f.Locals[1]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",238);}
case 238:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6582(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/cost/CostSacrifice","getType","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Push(JValue.R(rt.String("OriginalHost")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?48:18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",22);}
case 22:{f.Locals[5]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/Card","isEquipping","()Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?46:32;continue;}
case 32:{f.Push(f.Locals[5]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/Card","canBeSacrificedBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int==0?46:42;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{f.Pc=47;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/cost/CostSacrifice","payCostFromSource","()Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int==0?63:55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/card/Card","canBeSacrificedBy","(Lforge/game/spellability/SpellAbility;Z)Z","invokevirtual",62);}
case 62:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 63:{f.Push(JValue.R(rt.String("All")));f.Pc=65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/cost/CostSacrifice","getAmount","()Ljava/lang/String;","invokevirtual",69);}
case 69:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?117:75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",82);}
case 82:{f.Locals[5]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[5]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/cost/CostSacrifice","getType","()Ljava/lang/String;","invokevirtual",90);}
case 90:{f.Push(JValue.R(rt.String(";")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",95);}
case 95:{f.Push(f.Locals[2]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[4]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",102);}
case 102:{f.Locals[5]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[5]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[1]);f.Pc=107;continue;}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/card/CardPredicates","canBeSacrificedBy","(Lforge/game/spellability/SpellAbility;Z)Ljava/util/function/Predicate;","invokestatic",111);}
case 111:{return rt.Call(f,"forge/game/card/CardCollectionView","allMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",116);}
case 116:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/cost/CostSacrifice","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",122);}
case 122:{f.Locals[5]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[1]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[3]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/cost/CostSacrifice","getMaxAmountX","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/lang/Integer;","invokevirtual",131);}
case 131:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",134);}
case 134:{f.Push(f.Locals[5]);f.Pc=136;continue;}
case 136:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?143:139;continue;}
case 139:{f.Push(JValue.I(1));f.Pc=140;continue;}
case 140:{f.Pc=144;continue;}
case 143:{f.Push(JValue.I(0));f.Pc=144;continue;}
case 144:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6583(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6584(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6585(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[5]=f.Pop();f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",12);}
case 12:{f.Locals[6]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[6]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostSacrifice","table","Lforge/game/card/CardZoneTable;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/card/CardZoneTable;)V","invokestatic",23);}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",28);}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[6]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/GameAction","sacrifice","(Ljava/lang/Iterable;Lforge/game/spellability/SpellAbility;ZLjava/util/Map;)Lforge/game/card/CardCollection;","invokevirtual",37);}
case 37:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6586(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Sacrificed")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6587(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("SacrificedCards")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6588(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostSacrifice;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
