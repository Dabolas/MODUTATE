// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C42{
internal static JClass Build(){var c=new JClass("forge/card/CardRulesPredicates$LeafNumber","java/lang/Object",new string[]{"java/util/function/Predicate"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("field","Lforge/card/CardRulesPredicates$LeafNumber$CardField;",false,JValue.Default("Lforge/card/CardRulesPredicates$LeafNumber$CardField;"),null));
c.Add(new JField("operator","Lforge/util/ComparableOp;",false,JValue.Default("Lforge/util/ComparableOp;"),null));
c.Add(new JField("operand","I",false,JValue.Default("I"),null));
c.Add(new JMethod(749,"forge/card/CardRulesPredicates$LeafNumber","<init>","(Lforge/card/CardRulesPredicates$LeafNumber$CardField;Lforge/util/ComparableOp;I)V",1,4,2,new JHandler[]{},M749));
c.Add(new JMethod(750,"forge/card/CardRulesPredicates$LeafNumber","test","(Lforge/card/CardRules;)Z",1,5,3,new JHandler[]{new JHandler(121,126,129,"java/lang/NumberFormatException")},M750));
c.Add(new JMethod(751,"forge/card/CardRulesPredicates$LeafNumber","test","(Ljava/lang/Object;)Z",4161,2,2,new JHandler[]{},M751));
}

internal static JStep M749(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRulesPredicates$LeafNumber","field","Lforge/card/CardRulesPredicates$LeafNumber$CardField;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRulesPredicates$LeafNumber","operand","I",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRulesPredicates$LeafNumber","operator","Lforge/util/ComparableOp;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M750(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafNumber$CardField","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafNumber$CardField","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafNumber","field","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","ordinal","()I","invokevirtual",10);}
case 10:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=11;continue;}
case 11:{switch(f.Pop().Int){case 1:f.Pc=48;break;case 2:f.Pc=73;break;case 3:f.Pc=98;break;case 4:f.Pc=152;break;case 5:f.Pc=190;break;case 6:f.Pc=228;break;default:f.Pc=271;break;}continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafNumber","operator","Lforge/util/ComparableOp;"));f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/card/CardRules","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",56);}
case 56:{return rt.Call(f,"forge/card/mana/ManaCost","getCMC","()I","invokevirtual",59);}
case 59:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",62);}
case 62:{f.Push(f.Locals[0]);f.Pc=63;continue;}
case 63:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafNumber","operand","I"));f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",69);}
case 69:{return rt.Call(f,"forge/util/ComparableOp","apply","(Ljava/lang/Integer;Ljava/lang/Integer;)Z","invokevirtual",72);}
case 72:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafNumber","operator","Lforge/util/ComparableOp;"));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/card/CardRules","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",81);}
case 81:{return rt.Call(f,"forge/card/mana/ManaCost","getGenericCost","()I","invokevirtual",84);}
case 84:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",87);}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafNumber","operand","I"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",94);}
case 94:{return rt.Call(f,"forge/util/ComparableOp","apply","(Ljava/lang/Integer;Ljava/lang/Integer;)Z","invokevirtual",97);}
case 97:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/card/CardRules","getInitialLoyalty","()Ljava/lang/String;","invokevirtual",102);}
case 102:{f.Locals[3]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isBlank","(Ljava/lang/CharSequence;)Z","invokestatic",107);}
case 107:{f.Pc=f.Pop().Int!=0?119:110;continue;}
case 110:{f.Push(f.Locals[3]);f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.String("\\d+")));f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/lang/String","matches","(Ljava/lang/String;)Z","invokevirtual",116);}
case 116:{f.Pc=f.Pop().Int!=0?121:119;continue;}
case 119:{f.Push(JValue.I(0));f.Pc=120;continue;}
case 120:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 121:{f.Push(f.Locals[3]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",125);}
case 125:{f.Locals[2]=f.Pop();f.Pc=126;continue;}
case 126:{f.Pc=133;continue;}
case 129:{f.Locals[4]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(JValue.I(0));f.Pc=132;continue;}
case 132:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 133:{f.Push(f.Locals[0]);f.Pc=134;continue;}
case 134:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafNumber","operator","Lforge/util/ComparableOp;"));f.Pc=137;continue;}
case 137:{f.Push(f.Locals[2]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",141);}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafNumber","operand","I"));f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",148);}
case 148:{return rt.Call(f,"forge/util/ComparableOp","apply","(Ljava/lang/Integer;Ljava/lang/Integer;)Z","invokevirtual",151);}
case 151:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 152:{f.Push(f.Locals[1]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/card/CardRules","getIntPower","()I","invokevirtual",156);}
case 156:{f.Locals[2]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[2]);f.Pc=158;continue;}
case 158:{f.Push(JValue.I(2147483647));f.Pc=160;continue;}
case 160:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?188:163;continue;}
case 163:{f.Push(f.Locals[0]);f.Pc=164;continue;}
case 164:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafNumber","operator","Lforge/util/ComparableOp;"));f.Pc=167;continue;}
case 167:{f.Push(f.Locals[2]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",171);}
case 171:{f.Push(f.Locals[0]);f.Pc=172;continue;}
case 172:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafNumber","operand","I"));f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",178);}
case 178:{return rt.Call(f,"forge/util/ComparableOp","apply","(Ljava/lang/Integer;Ljava/lang/Integer;)Z","invokevirtual",181);}
case 181:{f.Pc=f.Pop().Int==0?188:184;continue;}
case 184:{f.Push(JValue.I(1));f.Pc=185;continue;}
case 185:{f.Pc=189;continue;}
case 188:{f.Push(JValue.I(0));f.Pc=189;continue;}
case 189:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 190:{f.Push(f.Locals[1]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/card/CardRules","getIntToughness","()I","invokevirtual",194);}
case 194:{f.Locals[2]=f.Pop();f.Pc=195;continue;}
case 195:{f.Push(f.Locals[2]);f.Pc=196;continue;}
case 196:{f.Push(JValue.I(2147483647));f.Pc=198;continue;}
case 198:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?226:201;continue;}
case 201:{f.Push(f.Locals[0]);f.Pc=202;continue;}
case 202:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafNumber","operator","Lforge/util/ComparableOp;"));f.Pc=205;continue;}
case 205:{f.Push(f.Locals[2]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",209);}
case 209:{f.Push(f.Locals[0]);f.Pc=210;continue;}
case 210:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafNumber","operand","I"));f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",216);}
case 216:{return rt.Call(f,"forge/util/ComparableOp","apply","(Ljava/lang/Integer;Ljava/lang/Integer;)Z","invokevirtual",219);}
case 219:{f.Pc=f.Pop().Int==0?226:222;continue;}
case 222:{f.Push(JValue.I(1));f.Pc=223;continue;}
case 223:{f.Pc=227;continue;}
case 226:{f.Push(JValue.I(0));f.Pc=227;continue;}
case 227:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 228:{f.Push(f.Locals[1]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/card/CardRules","getIntPower","()I","invokevirtual",232);}
case 232:{f.Push(f.Locals[1]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/card/CardRules","getIntToughness","()I","invokevirtual",236);}
case 236:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=237;continue;}
case 237:{f.Locals[2]=f.Pop();f.Pc=238;continue;}
case 238:{f.Push(f.Locals[2]);f.Pc=239;continue;}
case 239:{f.Push(JValue.I(2147483647));f.Pc=241;continue;}
case 241:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?269:244;continue;}
case 244:{f.Push(f.Locals[0]);f.Pc=245;continue;}
case 245:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafNumber","operator","Lforge/util/ComparableOp;"));f.Pc=248;continue;}
case 248:{f.Push(f.Locals[2]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",252);}
case 252:{f.Push(f.Locals[0]);f.Pc=253;continue;}
case 253:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafNumber","operand","I"));f.Pc=256;continue;}
case 256:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",259);}
case 259:{return rt.Call(f,"forge/util/ComparableOp","apply","(Ljava/lang/Integer;Ljava/lang/Integer;)Z","invokevirtual",262);}
case 262:{f.Pc=f.Pop().Int==0?269:265;continue;}
case 265:{f.Push(JValue.I(1));f.Pc=266;continue;}
case 266:{f.Pc=270;continue;}
case 269:{f.Push(JValue.I(0));f.Pc=270;continue;}
case 270:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 271:{f.Push(JValue.I(0));f.Pc=272;continue;}
case 272:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M751(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber","test","(Lforge/card/CardRules;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
