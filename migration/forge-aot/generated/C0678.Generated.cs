// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C678{
internal static JClass Build(){var c=new JClass("forge/game/mana/Mana","java/lang/Record",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("color","B",false,JValue.Default("B"),null));
c.Add(new JField("sourceCard","Lforge/game/card/Card;",false,JValue.Default("Lforge/game/card/Card;"),null));
c.Add(new JField("manaAbility","Lforge/game/spellability/AbilityManaPart;",false,JValue.Default("Lforge/game/spellability/AbilityManaPart;"),null));
c.Add(new JField("player","Lforge/game/player/Player;",false,JValue.Default("Lforge/game/player/Player;"),null));
c.Add(new JMethod(7685,"forge/game/mana/Mana","<init>","(BLforge/game/card/Card;Lforge/game/spellability/AbilityManaPart;Lforge/game/player/Player;)V",1,5,3,new JHandler[]{},M7685));
c.Add(new JMethod(7686,"forge/game/mana/Mana","equals","(Ljava/lang/Object;)Z",1,5,3,new JHandler[]{},M7686));
c.Add(new JMethod(7687,"forge/game/mana/Mana","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7687));
c.Add(new JMethod(7688,"forge/game/mana/Mana","isSnow","()Z",1,1,1,new JHandler[]{},M7688));
c.Add(new JMethod(7689,"forge/game/mana/Mana","isRestricted","()Z",1,1,1,new JHandler[]{},M7689));
c.Add(new JMethod(7690,"forge/game/mana/Mana","meetsManaRestrictions","(Lforge/game/spellability/SpellAbility;)Z",1,2,2,new JHandler[]{},M7690));
c.Add(new JMethod(7691,"forge/game/mana/Mana","addsNoCounterMagic","(Lforge/game/spellability/SpellAbility;)Z",1,2,2,new JHandler[]{},M7691));
c.Add(new JMethod(7692,"forge/game/mana/Mana","addsCounters","(Lforge/game/spellability/SpellAbility;)Z",1,2,2,new JHandler[]{},M7692));
c.Add(new JMethod(7693,"forge/game/mana/Mana","addsKeywords","(Lforge/game/spellability/SpellAbility;)Z",1,2,2,new JHandler[]{},M7693));
c.Add(new JMethod(7694,"forge/game/mana/Mana","addsKeywordsType","()Z",1,1,1,new JHandler[]{},M7694));
c.Add(new JMethod(7695,"forge/game/mana/Mana","addsKeywordsUntil","()Z",1,1,1,new JHandler[]{},M7695));
c.Add(new JMethod(7696,"forge/game/mana/Mana","getAddedKeywords","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7696));
c.Add(new JMethod(7697,"forge/game/mana/Mana","triggersWhenSpent","()Z",1,1,1,new JHandler[]{},M7697));
c.Add(new JMethod(7698,"forge/game/mana/Mana","isPersistentMana","()Z",1,1,1,new JHandler[]{},M7698));
c.Add(new JMethod(7699,"forge/game/mana/Mana","isCombatMana","()Z",1,1,1,new JHandler[]{},M7699));
c.Add(new JMethod(7700,"forge/game/mana/Mana","getColor","()B",1,1,1,new JHandler[]{},M7700));
c.Add(new JMethod(7701,"forge/game/mana/Mana","getSourceCard","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M7701));
c.Add(new JMethod(7702,"forge/game/mana/Mana","getManaAbility","()Lforge/game/spellability/AbilityManaPart;",1,1,1,new JHandler[]{},M7702));
c.Add(new JMethod(7703,"forge/game/mana/Mana","getPlayer","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M7703));
c.Add(new JMethod(7704,"forge/game/mana/Mana","isColorless","()Z",1,1,2,new JHandler[]{},M7704));
c.Add(new JMethod(7705,"forge/game/mana/Mana","convertColor","(B)Lforge/game/mana/Mana;",1,2,6,new JHandler[]{},M7705));
c.Add(new JMethod(7706,"forge/game/mana/Mana","hashCode","()I",17,1,1,new JHandler[]{},M7706));
c.Add(new JMethod(7707,"forge/game/mana/Mana","color","()B",1,1,1,new JHandler[]{},M7707));
c.Add(new JMethod(7708,"forge/game/mana/Mana","sourceCard","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M7708));
c.Add(new JMethod(7709,"forge/game/mana/Mana","manaAbility","()Lforge/game/spellability/AbilityManaPart;",1,1,1,new JHandler[]{},M7709));
c.Add(new JMethod(7710,"forge/game/mana/Mana","player","()Lforge/game/player/Player;",1,1,1,new JHandler[]{},M7710));
}

internal static JStep M7685(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Record","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/Mana","color","B",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?29:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/CardCopyService","getLKICopy","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokestatic",26);}
case 26:{f.Pc=37;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",33);}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/Game","getChangeZoneLKIInfo","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",37);}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/Mana","sourceCard","Lforge/game/card/Card;",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[4]);f.Pc=43;continue;}
case 43:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/Mana","player","Lforge/game/player/Player;",value);f.Pc=46;continue;}
case 46:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7686(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/mana/Mana")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","color","B"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","color","B"));f.Pc=22;continue;}
case 22:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?27:25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/mana/Mana","getManaAbility","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",31);}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/mana/Mana","getManaAbility","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",36);}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Pc=f.Pop().Reference!=null?46:42;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{f.Pc=47;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{f.Pc=f.Pop().Reference!=null?56:52;continue;}
case 52:{f.Push(JValue.I(1));f.Pc=53;continue;}
case 53:{f.Pc=57;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?62:60;continue;}
case 60:{f.Push(JValue.I(0));f.Pc=61;continue;}
case 61:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","sourceCard","Lforge/game/card/Card;"));f.Pc=66;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","sourceCard","Lforge/game/card/Card;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/card/Card","equals","(Ljava/lang/Object;)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int!=0?166:76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{f.Pc=f.Pop().Reference==null?166:80;continue;}
case 80:{f.Push(f.Locals[0]);f.Pc=81;continue;}
case 81:{f.Push(JValue.R(null));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/mana/Mana","addsKeywords","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",85);}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Push(JValue.R(null));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/mana/Mana","addsKeywords","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",90);}
case 90:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?95:93;continue;}
case 93:{f.Push(JValue.I(0));f.Pc=94;continue;}
case 94:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(JValue.R(null));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/mana/Mana","addsCounters","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",100);}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(null));f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/mana/Mana","addsCounters","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",105);}
case 105:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?110:108;continue;}
case 108:{f.Push(JValue.I(0));f.Pc=109;continue;}
case 109:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 110:{f.Push(f.Locals[3]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isCannotCounterPaidWith","()Z","invokevirtual",114);}
case 114:{f.Push(f.Locals[4]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isCannotCounterPaidWith","()Z","invokevirtual",119);}
case 119:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?124:122;continue;}
case 122:{f.Push(JValue.I(0));f.Pc=123;continue;}
case 123:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 124:{f.Push(f.Locals[3]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getTriggersWhenSpent","()Z","invokevirtual",128);}
case 128:{f.Push(f.Locals[4]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getTriggersWhenSpent","()Z","invokevirtual",133);}
case 133:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?138:136;continue;}
case 136:{f.Push(JValue.I(0));f.Pc=137;continue;}
case 137:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 138:{f.Push(f.Locals[3]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isPersistentMana","()Z","invokevirtual",142);}
case 142:{f.Push(f.Locals[4]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isPersistentMana","()Z","invokevirtual",147);}
case 147:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?152:150;continue;}
case 150:{f.Push(JValue.I(0));f.Pc=151;continue;}
case 151:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 152:{f.Push(f.Locals[3]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isCombatMana","()Z","invokevirtual",156);}
case 156:{f.Push(f.Locals[4]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isCombatMana","()Z","invokevirtual",161);}
case 161:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?166:164;continue;}
case 164:{f.Push(JValue.I(0));f.Pc=165;continue;}
case 165:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 166:{f.Push(f.Locals[3]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[4]);f.Pc=169;continue;}
case 169:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?202:172;continue;}
case 172:{f.Push(f.Locals[3]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getManaRestrictions","()Ljava/lang/String;","invokevirtual",176);}
case 176:{f.Push(f.Locals[4]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getManaRestrictions","()Ljava/lang/String;","invokevirtual",181);}
case 181:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",184);}
case 184:{f.Pc=f.Pop().Int==0?206:187;continue;}
case 187:{f.Push(f.Locals[3]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getExtraManaRestriction","()Ljava/lang/String;","invokevirtual",191);}
case 191:{f.Push(f.Locals[4]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getExtraManaRestriction","()Ljava/lang/String;","invokevirtual",196);}
case 196:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",199);}
case 199:{f.Pc=f.Pop().Int==0?206:202;continue;}
case 202:{f.Push(JValue.I(1));f.Pc=203;continue;}
case 203:{f.Pc=207;continue;}
case 206:{f.Push(JValue.I(0));f.Pc=207;continue;}
case 207:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7687(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","color","B"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/MagicColor","toShortString","(B)Ljava/lang/String;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7688(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","sourceCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","isSnow","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7689(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?37:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getManaRestrictions","()Ljava/lang/String;","invokevirtual",14);}
case 14:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?33:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getExtraManaRestriction","()Ljava/lang/String;","invokevirtual",27);}
case 27:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",30);}
case 30:{f.Pc=f.Pop().Int!=0?37:33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{f.Pc=38;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7690(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","meetsManaRestrictions","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?22:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Pc=23;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7691(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?22:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","cannotCounterPaidWith","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?22:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Pc=23;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7692(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?22:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","addsCounters","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?22:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Pc=23;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7693(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?22:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","addKeywords","(Lforge/game/spellability/SpellAbility;)Z","invokevirtual",15);}
case 15:{f.Pc=f.Pop().Int==0?22:18;continue;}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{f.Pc=23;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7694(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getAddsKeywordsType","()Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Reference==null?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7695(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getAddsKeywordsUntil","()Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Reference==null?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7696(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getKeywords","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7697(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getTriggersWhenSpent","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7698(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isPersistentMana","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7699(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?21:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","isCombatMana","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?21:17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Pc=22;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7700(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","color","B"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7701(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","sourceCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7702(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7703(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","player","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7704(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","color","B"));f.Pc=4;continue;}
case 4:{f.Push(JValue.I(32));f.Pc=6;continue;}
case 6:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?13:9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{f.Pc=14;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7705(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/mana/Mana"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/Mana")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","sourceCard","Lforge/game/card/Card;"));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","player","Lforge/game/player/Player;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/mana/Mana","<init>","(BLforge/game/card/Card;Lforge/game/spellability/AbilityManaPart;Lforge/game/player/Player;)V","invokespecial",20);}
case 20:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7706(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/game/mana/Mana:7706:1:java/lang/runtime/ObjectMethods.bootstrap","(Lforge/game/mana/Mana;)I",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7707(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","color","B"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7708(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","sourceCard","Lforge/game/card/Card;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7709(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","manaAbility","Lforge/game/spellability/AbilityManaPart;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7710(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/Mana","player","Lforge/game/player/Player;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
