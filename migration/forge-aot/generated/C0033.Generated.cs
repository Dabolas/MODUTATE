// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C33{
internal static JClass Build(){var c=new JClass("forge/card/CardFacePredicates$ValidPredicate","java/lang/Object",new string[]{"java/util/function/Predicate"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("valid","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(581,"forge/card/CardFacePredicates$ValidPredicate","<init>","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M581));
c.Add(new JMethod(582,"forge/card/CardFacePredicates$ValidPredicate","test","(Lforge/card/ICardFace;)Z",1,8,3,new JHandler[]{},M582));
c.Add(new JMethod(583,"forge/card/CardFacePredicates$ValidPredicate","hasProperty","(Lforge/card/ICardFace;Ljava/lang/String;)Z",12,2,3,new JHandler[]{},M583));
c.Add(new JMethod(584,"forge/card/CardFacePredicates$ValidPredicate","hasManaCost","(Lforge/card/ICardFace;Ljava/lang/String;)Z",12,2,2,new JHandler[]{},M584));
c.Add(new JMethod(585,"forge/card/CardFacePredicates$ValidPredicate","hasCMC","(Lforge/card/ICardFace;I)Z",12,3,2,new JHandler[]{},M585));
c.Add(new JMethod(586,"forge/card/CardFacePredicates$ValidPredicate","test","(Ljava/lang/Object;)Z",4161,2,2,new JHandler[]{},M586));
}

internal static JStep M581(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardFacePredicates$ValidPredicate","valid","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M582(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardFacePredicates$ValidPredicate","valid","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("\\.")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(2));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("Card")));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?25:22;continue;}
case 22:{f.Pc=79;continue;}
case 25:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?62:36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",42);}
case 42:{return rt.Call(f,"forge/card/CardType","isInstant","()Z","invokevirtual",45);}
case 45:{f.Pc=f.Pop().Int!=0?60:48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",54);}
case 54:{return rt.Call(f,"forge/card/CardType","isSorcery","()Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?79:60;continue;}
case 60:{f.Push(JValue.I(0));f.Pc=61;continue;}
case 61:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",68);}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{f.Push(JValue.I(0));f.Pc=70;continue;}
case 70:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/card/CardType","hasStringType","(Ljava/lang/String;)Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int!=0?79:77;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=81;continue;}
case 81:{f.Push(JValue.I(1));f.Pc=82;continue;}
case 82:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?199:85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Push(JValue.I(1));f.Pc=87;continue;}
case 87:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String("\\+")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",93);}
case 93:{f.Locals[3]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=96;continue;}
case 96:{f.Locals[4]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(JValue.I(0));f.Pc=99;continue;}
case 99:{f.Locals[5]=f.Pop();f.Pc=101;continue;}
case 101:{f.Push(f.Locals[5]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[4]);f.Pc=105;continue;}
case 105:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?199:108;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[5]);f.Pc=111;continue;}
case 111:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=112;continue;}
case 112:{f.Locals[6]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[6]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("ManaCost")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int==0?147:124;continue;}
case 124:{f.Push(f.Locals[6]);f.Pc=126;continue;}
case 126:{f.Push(JValue.I(8));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",131);}
case 131:{f.Locals[7]=f.Pop();f.Pc=133;continue;}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[7]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/card/CardFacePredicates$ValidPredicate","hasManaCost","(Lforge/card/ICardFace;Ljava/lang/String;)Z","invokestatic",139);}
case 139:{f.Pc=f.Pop().Int!=0?144:142;continue;}
case 142:{f.Push(JValue.I(0));f.Pc=143;continue;}
case 143:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 144:{f.Pc=193;continue;}
case 147:{f.Push(f.Locals[6]);f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.String("cmcEQ")));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",154);}
case 154:{f.Pc=f.Pop().Int==0?182:157;continue;}
case 157:{f.Push(f.Locals[6]);f.Pc=159;continue;}
case 159:{f.Push(JValue.I(5));f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",163);}
case 163:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",166);}
case 166:{f.Locals[7]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[1]);f.Pc=169;continue;}
case 169:{f.Push(f.Locals[7]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/card/CardFacePredicates$ValidPredicate","hasCMC","(Lforge/card/ICardFace;I)Z","invokestatic",174);}
case 174:{f.Pc=f.Pop().Int!=0?179:177;continue;}
case 177:{f.Push(JValue.I(0));f.Pc=178;continue;}
case 178:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 179:{f.Pc=193;continue;}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{f.Push(f.Locals[6]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/card/CardFacePredicates$ValidPredicate","hasProperty","(Lforge/card/ICardFace;Ljava/lang/String;)Z","invokestatic",188);}
case 188:{f.Pc=f.Pop().Int!=0?193:191;continue;}
case 191:{f.Push(JValue.I(0));f.Pc=192;continue;}
case 192:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 193:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=196;continue;}
case 196:{f.Pc=101;continue;}
case 199:{f.Push(JValue.I(1));f.Pc=200;continue;}
case 200:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M583(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("non")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?27:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{f.Push(JValue.I(3));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/card/CardFacePredicates$ValidPredicate","hasProperty","(Lforge/card/ICardFace;Ljava/lang/String;)Z","invokestatic",18);}
case 18:{f.Pc=f.Pop().Int!=0?25:21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Pc=26;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",33);}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/card/CardType","hasStringType","(Ljava/lang/String;)Z","invokevirtual",37);}
case 37:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M584(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/card/ICardFace","getManaCost","()Lforge/card/mana/ManaCost;","invokeinterface",7);}
case 7:{return rt.Call(f,"forge/card/mana/ManaCost","getShortString","()Ljava/lang/String;","invokevirtual",10);}
case 10:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M585(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/ICardFace","getManaCost","()Lforge/card/mana/ManaCost;","invokeinterface",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference==null?23:11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/card/mana/ManaCost","getCMC","()I","invokevirtual",15);}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?23:19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M586(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardFacePredicates$ValidPredicate","test","(Lforge/card/ICardFace;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
