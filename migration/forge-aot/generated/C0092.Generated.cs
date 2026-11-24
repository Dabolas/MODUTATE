// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C92{
internal static JClass Build(){var c=new JClass("forge/deck/DeckFormat$3","java/lang/Object",new string[]{"java/util/function/Predicate"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("bannedCards","Ljava/util/Set;",false,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JMethod(1481,"forge/deck/DeckFormat$3","<init>","()V",0,1,11,new JHandler[]{},M1481));
c.Add(new JMethod(1482,"forge/deck/DeckFormat$3","test","(Lforge/card/CardRules;)Z",1,3,2,new JHandler[]{},M1482));
c.Add(new JMethod(1483,"forge/deck/DeckFormat$3","test","(Ljava/lang/Object;)Z",4161,2,2,new JHandler[]{},M1483));
}

internal static JStep M1481(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("Ancestral Recall")));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("Balance")));f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Black Lotus")));f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Black Vise")));f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String("Channel")));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("Chaos Orb")));f.Pc=17;continue;}
case 17:{f.Push(JValue.I(45));f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Contract From Below")));f.Pc=26;continue;}
case 26:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=27;continue;}
case 27:{f.StackOp("dup");f.Pc=28;continue;}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("Counterbalance")));f.Pc=31;continue;}
case 31:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=32;continue;}
case 32:{f.StackOp("dup");f.Pc=33;continue;}
case 33:{f.Push(JValue.I(2));f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("Darkpact")));f.Pc=36;continue;}
case 36:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{f.Push(JValue.I(3));f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("Demonic Attorney")));f.Pc=41;continue;}
case 41:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.I(4));f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("Demonic Tutor")));f.Pc=46;continue;}
case 46:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=47;continue;}
case 47:{f.StackOp("dup");f.Pc=48;continue;}
case 48:{f.Push(JValue.I(5));f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("Earthcraft")));f.Pc=51;continue;}
case 51:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=52;continue;}
case 52:{f.StackOp("dup");f.Pc=53;continue;}
case 53:{f.Push(JValue.I(6));f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("Edric, Spymaster of Trest")));f.Pc=57;continue;}
case 57:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{f.Push(JValue.I(7));f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("Falling Star")));f.Pc=63;continue;}
case 63:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=64;continue;}
case 64:{f.StackOp("dup");f.Pc=65;continue;}
case 65:{f.Push(JValue.I(8));f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("Fastbond")));f.Pc=69;continue;}
case 69:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=70;continue;}
case 70:{f.StackOp("dup");f.Pc=71;continue;}
case 71:{f.Push(JValue.I(9));f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("Flash")));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(10));f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("Goblin Recruiter")));f.Pc=81;continue;}
case 81:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=82;continue;}
case 82:{f.StackOp("dup");f.Pc=83;continue;}
case 83:{f.Push(JValue.I(11));f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("Grindstone")));f.Pc=87;continue;}
case 87:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=88;continue;}
case 88:{f.StackOp("dup");f.Pc=89;continue;}
case 89:{f.Push(JValue.I(12));f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("Hermit Druid")));f.Pc=93;continue;}
case 93:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=94;continue;}
case 94:{f.StackOp("dup");f.Pc=95;continue;}
case 95:{f.Push(JValue.I(13));f.Pc=97;continue;}
case 97:{f.Push(JValue.R(rt.String("Imperial Seal")));f.Pc=99;continue;}
case 99:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=100;continue;}
case 100:{f.StackOp("dup");f.Pc=101;continue;}
case 101:{f.Push(JValue.I(14));f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("Jeweled Bird")));f.Pc=105;continue;}
case 105:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=106;continue;}
case 106:{f.StackOp("dup");f.Pc=107;continue;}
case 107:{f.Push(JValue.I(15));f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("Karakas")));f.Pc=111;continue;}
case 111:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=112;continue;}
case 112:{f.StackOp("dup");f.Pc=113;continue;}
case 113:{f.Push(JValue.I(16));f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String("Library of Alexandria")));f.Pc=117;continue;}
case 117:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{f.Push(JValue.I(17));f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("Mana Crypt")));f.Pc=123;continue;}
case 123:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=124;continue;}
case 124:{f.StackOp("dup");f.Pc=125;continue;}
case 125:{f.Push(JValue.I(18));f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String("Mana Drain")));f.Pc=129;continue;}
case 129:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=130;continue;}
case 130:{f.StackOp("dup");f.Pc=131;continue;}
case 131:{f.Push(JValue.I(19));f.Pc=133;continue;}
case 133:{f.Push(JValue.R(rt.String("Mana Vault")));f.Pc=135;continue;}
case 135:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=136;continue;}
case 136:{f.StackOp("dup");f.Pc=137;continue;}
case 137:{f.Push(JValue.I(20));f.Pc=139;continue;}
case 139:{f.Push(JValue.R(rt.String("Metalworker")));f.Pc=141;continue;}
case 141:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=142;continue;}
case 142:{f.StackOp("dup");f.Pc=143;continue;}
case 143:{f.Push(JValue.I(21));f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.String("Mind Twist")));f.Pc=147;continue;}
case 147:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=148;continue;}
case 148:{f.StackOp("dup");f.Pc=149;continue;}
case 149:{f.Push(JValue.I(22));f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String("Mishra's Workshop")));f.Pc=153;continue;}
case 153:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=154;continue;}
case 154:{f.StackOp("dup");f.Pc=155;continue;}
case 155:{f.Push(JValue.I(23));f.Pc=157;continue;}
case 157:{f.Push(JValue.R(rt.String("Mox Emerald")));f.Pc=159;continue;}
case 159:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=160;continue;}
case 160:{f.StackOp("dup");f.Pc=161;continue;}
case 161:{f.Push(JValue.I(24));f.Pc=163;continue;}
case 163:{f.Push(JValue.R(rt.String("Mox Jet")));f.Pc=165;continue;}
case 165:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=166;continue;}
case 166:{f.StackOp("dup");f.Pc=167;continue;}
case 167:{f.Push(JValue.I(25));f.Pc=169;continue;}
case 169:{f.Push(JValue.R(rt.String("Mox Pearl")));f.Pc=171;continue;}
case 171:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=172;continue;}
case 172:{f.StackOp("dup");f.Pc=173;continue;}
case 173:{f.Push(JValue.I(26));f.Pc=175;continue;}
case 175:{f.Push(JValue.R(rt.String("Mox Ruby")));f.Pc=177;continue;}
case 177:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=178;continue;}
case 178:{f.StackOp("dup");f.Pc=179;continue;}
case 179:{f.Push(JValue.I(27));f.Pc=181;continue;}
case 181:{f.Push(JValue.R(rt.String("Mox Sapphire")));f.Pc=183;continue;}
case 183:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=184;continue;}
case 184:{f.StackOp("dup");f.Pc=185;continue;}
case 185:{f.Push(JValue.I(28));f.Pc=187;continue;}
case 187:{f.Push(JValue.R(rt.String("Najeela, the Blade Blossom")));f.Pc=189;continue;}
case 189:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=190;continue;}
case 190:{f.StackOp("dup");f.Pc=191;continue;}
case 191:{f.Push(JValue.I(29));f.Pc=193;continue;}
case 193:{f.Push(JValue.R(rt.String("Necropotence")));f.Pc=195;continue;}
case 195:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=196;continue;}
case 196:{f.StackOp("dup");f.Pc=197;continue;}
case 197:{f.Push(JValue.I(30));f.Pc=199;continue;}
case 199:{f.Push(JValue.R(rt.String("Shahrazad")));f.Pc=201;continue;}
case 201:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=202;continue;}
case 202:{f.StackOp("dup");f.Pc=203;continue;}
case 203:{f.Push(JValue.I(31));f.Pc=205;continue;}
case 205:{f.Push(JValue.R(rt.String("Skullclamp")));f.Pc=207;continue;}
case 207:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=208;continue;}
case 208:{f.StackOp("dup");f.Pc=209;continue;}
case 209:{f.Push(JValue.I(32));f.Pc=211;continue;}
case 211:{f.Push(JValue.R(rt.String("Sol Ring")));f.Pc=213;continue;}
case 213:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=214;continue;}
case 214:{f.StackOp("dup");f.Pc=215;continue;}
case 215:{f.Push(JValue.I(33));f.Pc=217;continue;}
case 217:{f.Push(JValue.R(rt.String("Strip Mine")));f.Pc=219;continue;}
case 219:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=220;continue;}
case 220:{f.StackOp("dup");f.Pc=221;continue;}
case 221:{f.Push(JValue.I(34));f.Pc=223;continue;}
case 223:{f.Push(JValue.R(rt.String("Survival of the Fittest")));f.Pc=225;continue;}
case 225:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=226;continue;}
case 226:{f.StackOp("dup");f.Pc=227;continue;}
case 227:{f.Push(JValue.I(35));f.Pc=229;continue;}
case 229:{f.Push(JValue.R(rt.String("Sword of Body and Mind")));f.Pc=231;continue;}
case 231:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=232;continue;}
case 232:{f.StackOp("dup");f.Pc=233;continue;}
case 233:{f.Push(JValue.I(36));f.Pc=235;continue;}
case 235:{f.Push(JValue.R(rt.String("Time Vault")));f.Pc=237;continue;}
case 237:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=238;continue;}
case 238:{f.StackOp("dup");f.Pc=239;continue;}
case 239:{f.Push(JValue.I(37));f.Pc=241;continue;}
case 241:{f.Push(JValue.R(rt.String("Time Walk")));f.Pc=243;continue;}
case 243:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=244;continue;}
case 244:{f.StackOp("dup");f.Pc=245;continue;}
case 245:{f.Push(JValue.I(38));f.Pc=247;continue;}
case 247:{f.Push(JValue.R(rt.String("Timetwister")));f.Pc=249;continue;}
case 249:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=250;continue;}
case 250:{f.StackOp("dup");f.Pc=251;continue;}
case 251:{f.Push(JValue.I(39));f.Pc=253;continue;}
case 253:{f.Push(JValue.R(rt.String("Timmerian Fiends")));f.Pc=255;continue;}
case 255:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=256;continue;}
case 256:{f.StackOp("dup");f.Pc=257;continue;}
case 257:{f.Push(JValue.I(40));f.Pc=259;continue;}
case 259:{f.Push(JValue.R(rt.String("Tolarian Academy")));f.Pc=261;continue;}
case 261:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=262;continue;}
case 262:{f.StackOp("dup");f.Pc=263;continue;}
case 263:{f.Push(JValue.I(41));f.Pc=265;continue;}
case 265:{f.Push(JValue.R(rt.String("Umezawa's Jitte")));f.Pc=267;continue;}
case 267:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=268;continue;}
case 268:{f.StackOp("dup");f.Pc=269;continue;}
case 269:{f.Push(JValue.I(42));f.Pc=271;continue;}
case 271:{f.Push(JValue.R(rt.String("Vampiric Tutor")));f.Pc=273;continue;}
case 273:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=274;continue;}
case 274:{f.StackOp("dup");f.Pc=275;continue;}
case 275:{f.Push(JValue.I(43));f.Pc=277;continue;}
case 277:{f.Push(JValue.R(rt.String("Wheel of Fortune")));f.Pc=279;continue;}
case 279:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=280;continue;}
case 280:{f.StackOp("dup");f.Pc=281;continue;}
case 281:{f.Push(JValue.I(44));f.Pc=283;continue;}
case 283:{f.Push(JValue.R(rt.String("Yawgmoth's Will")));f.Pc=285;continue;}
case 285:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=286;continue;}
case 286:{return rt.Call(f,"com/google/common/collect/ImmutableSet","of","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSet;","invokestatic",289);}
case 289:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckFormat$3","bannedCards","Ljava/util/Set;",value);f.Pc=292;continue;}
case 292:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1482(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getMainPart","()Lforge/card/ICardFace;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/card/ICardFace","getManaCost","()Lforge/card/mana/ManaCost;","invokeinterface",9);}
case 9:{return rt.Call(f,"forge/card/mana/ManaCost","getCMC","()I","invokevirtual",12);}
case 12:{f.Push(JValue.I(3));f.Pc=13;continue;}
case 13:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?18:16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/card/CardRules","getOtherPart","()Lforge/card/ICardFace;","invokevirtual",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Pc=f.Pop().Reference==null?42:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/card/ICardFace","getManaCost","()Lforge/card/mana/ManaCost;","invokeinterface",33);}
case 33:{return rt.Call(f,"forge/card/mana/ManaCost","getCMC","()I","invokevirtual",36);}
case 36:{f.Push(JValue.I(3));f.Pc=37;continue;}
case 37:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?42:40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckFormat$3","bannedCards","Ljava/util/Set;"));f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",50);}
case 50:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int!=0?62:58;continue;}
case 58:{f.Push(JValue.I(1));f.Pc=59;continue;}
case 59:{f.Pc=63;continue;}
case 62:{f.Push(JValue.I(0));f.Pc=63;continue;}
case 63:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1483(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/DeckFormat$3","test","(Lforge/card/CardRules;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
