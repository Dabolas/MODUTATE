// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C40{
internal static JClass Build(){var c=new JClass("forge/card/CardRulesPredicates$LeafColor","java/lang/Object",new string[]{"java/util/function/Predicate"},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("op","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",false,JValue.Default("Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"),null));
c.Add(new JField("color","B",false,JValue.Default("B"),null));
c.Add(new JMethod(741,"forge/card/CardRulesPredicates$LeafColor","<init>","(Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;B)V",1,3,2,new JHandler[]{},M741));
c.Add(new JMethod(742,"forge/card/CardRulesPredicates$LeafColor","test","(Lforge/card/CardRules;)Z",1,3,2,new JHandler[]{},M742));
c.Add(new JMethod(743,"forge/card/CardRulesPredicates$LeafColor","test","(Ljava/lang/Object;)Z",4161,2,2,new JHandler[]{},M743));
}

internal static JStep M741(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRulesPredicates$LeafColor","op","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRulesPredicates$LeafColor","color","B",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M742(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?7:5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/card/CardRules","getColor","()Lforge/card/ColorSet;","invokevirtual",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafColor","op","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","ordinal","()I","invokevirtual",22);}
case 22:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=23;continue;}
case 23:{switch(f.Pop().Int){case 1:f.Pc=72;break;case 2:f.Pc=89;break;case 3:f.Pc=106;break;case 4:f.Pc=123;break;case 5:f.Pc=140;break;case 6:f.Pc=157;break;case 7:f.Pc=166;break;case 8:f.Pc=175;break;case 9:f.Pc=184;break;default:f.Pc=193;break;}continue;}
case 72:{f.Push(f.Locals[2]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",76);}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafColor","color","B"));f.Pc=80;continue;}
case 80:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?87:83;continue;}
case 83:{f.Push(JValue.I(1));f.Pc=84;continue;}
case 84:{f.Pc=88;continue;}
case 87:{f.Push(JValue.I(0));f.Pc=88;continue;}
case 88:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",93);}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafColor","color","B"));f.Pc=97;continue;}
case 97:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?104:100;continue;}
case 100:{f.Push(JValue.I(1));f.Pc=101;continue;}
case 101:{f.Pc=105;continue;}
case 104:{f.Push(JValue.I(0));f.Pc=105;continue;}
case 105:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",110);}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafColor","color","B"));f.Pc=114;continue;}
case 114:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?121:117;continue;}
case 117:{f.Push(JValue.I(1));f.Pc=118;continue;}
case 118:{f.Pc=122;continue;}
case 121:{f.Push(JValue.I(0));f.Pc=122;continue;}
case 122:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",127);}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafColor","color","B"));f.Pc=131;continue;}
case 131:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?138:134;continue;}
case 134:{f.Push(JValue.I(1));f.Pc=135;continue;}
case 135:{f.Pc=139;continue;}
case 138:{f.Push(JValue.I(0));f.Pc=139;continue;}
case 139:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 140:{f.Push(f.Locals[2]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",144);}
case 144:{f.Push(f.Locals[0]);f.Pc=145;continue;}
case 145:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafColor","color","B"));f.Pc=148;continue;}
case 148:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?155:151;continue;}
case 151:{f.Push(JValue.I(1));f.Pc=152;continue;}
case 152:{f.Pc=156;continue;}
case 155:{f.Push(JValue.I(0));f.Pc=156;continue;}
case 156:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 157:{f.Push(f.Locals[2]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[0]);f.Pc=159;continue;}
case 159:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafColor","color","B"));f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/card/ColorSet","isEqual","(B)Z","invokevirtual",165);}
case 165:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 166:{f.Push(f.Locals[2]);f.Pc=167;continue;}
case 167:{f.Push(f.Locals[0]);f.Pc=168;continue;}
case 168:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafColor","color","B"));f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/card/ColorSet","hasAllColors","(I)Z","invokevirtual",174);}
case 174:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 175:{f.Push(f.Locals[2]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[0]);f.Pc=177;continue;}
case 177:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafColor","color","B"));f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/card/ColorSet","hasAnyColor","(I)Z","invokevirtual",183);}
case 183:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 184:{f.Push(f.Locals[1]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[0]);f.Pc=186;continue;}
case 186:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafColor","color","B"));f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/card/CardRules","canCastWithAvailable","(B)Z","invokevirtual",192);}
case 192:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 193:{f.Push(JValue.I(0));f.Pc=194;continue;}
case 194:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M743(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor","test","(Lforge/card/CardRules;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
