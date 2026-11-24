// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C643{
internal static JClass Build(){var c=new JClass("forge/game/keyword/Craft","forge/game/keyword/KeywordWithCost",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("desc","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("reminder","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(7400,"forge/game/keyword/Craft","<init>","()V",1,1,1,new JHandler[]{},M7400));
c.Add(new JMethod(7401,"forge/game/keyword/Craft","getTitle","()Ljava/lang/String;",1,2,2,new JHandler[]{},M7401));
c.Add(new JMethod(7402,"forge/game/keyword/Craft","getTitleWithoutCost","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7402));
c.Add(new JMethod(7403,"forge/game/keyword/Craft","parse","(Ljava/lang/String;)V",4,7,4,new JHandler[]{},M7403));
c.Add(new JMethod(7404,"forge/game/keyword/Craft","formatReminderText","(Ljava/lang/String;)Ljava/lang/String;",4,2,5,new JHandler[]{},M7404));
}

internal static JStep M7400(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7401(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/keyword/Craft","getTitleWithoutCost","()Ljava/lang/String;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",16);}
case 16:{f.StackOp("pop");f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String(" ")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Craft","cost","Lforge/game/cost/Cost;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",32);}
case 32:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",35);}
case 35:{f.StackOp("pop");f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",40);}
case 40:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7402(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Craft","desc","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.DynamicCall(f,"forge/game/keyword/Craft:7402:4:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7403(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String(":")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/keyword/KeywordWithCost","parse","(Ljava/lang/String;)V","invokespecial",14);}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=16;continue;}
case 16:{f.Push(JValue.I(2));f.Pc=17;continue;}
case 17:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?64:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Craft","desc","Ljava/lang/String;",value);f.Pc=27;continue;}
case 27:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",34);}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("Exile ")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",41);}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(2));f.Pc=43;continue;}
case 43:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",47);}
case 47:{f.Push(JValue.R(rt.String(" from among permanents you control and/or cards in your graveyard")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",58);}
case 58:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Craft","reminder","Ljava/lang/String;",value);f.Pc=61;continue;}
case 61:{f.Pc=290;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Craft","cost","Lforge/game/cost/Cost;"));f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.ClassObject("forge/game/cost/CostExile")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/cost/Cost","getCostPartByType","(Ljava/lang/Class;)Lforge/game/cost/CostPart;","invokevirtual",73);}
case 73:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostExile"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=76;continue;}
case 76:{f.Locals[3]=f.Pop();f.Pc=77;continue;}
case 77:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=80;continue;}
case 80:{f.StackOp("dup");f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",84);}
case 84:{f.Locals[4]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[0]);f.Pc=87;continue;}
case 87:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Craft","cost","Lforge/game/cost/Cost;"));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",93);}
case 93:{return rt.Call(f,"forge/game/cost/CostPartMana","getXMin","()I","invokevirtual",96);}
case 96:{f.Locals[5]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[5]);f.Pc=100;continue;}
case 100:{f.Pc=f.Pop().Int<=0?122:103;continue;}
case 103:{f.Push(f.Locals[4]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[5]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",110);}
case 110:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",113);}
case 113:{f.Push(JValue.R(rt.String(" or more")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",118);}
case 118:{f.StackOp("pop");f.Pc=119;continue;}
case 119:{f.Pc=150;continue;}
case 122:{f.Push(JValue.R(rt.String("1")));f.Pc=124;continue;}
case 124:{f.Push(f.Locals[3]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/cost/CostExile","getAmount","()Ljava/lang/String;","invokevirtual",128);}
case 128:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int!=0?150:134;continue;}
case 134:{f.Push(f.Locals[4]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[3]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/cost/CostExile","getAmount","()Ljava/lang/String;","invokevirtual",140);}
case 140:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",143);}
case 143:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",146);}
case 146:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",149);}
case 149:{f.StackOp("pop");f.Pc=150;continue;}
case 150:{f.Push(f.Locals[3]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/cost/CostExile","getTypeDescription","()Ljava/lang/String;","invokevirtual",154);}
case 154:{f.Pc=f.Pop().Reference==null?190:157;continue;}
case 157:{f.Push(JValue.R(rt.String("permanent")));f.Pc=159;continue;}
case 159:{f.Push(f.Locals[3]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/cost/CostExile","getTypeDescription","()Ljava/lang/String;","invokevirtual",163);}
case 163:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",166);}
case 166:{f.Pc=f.Pop().Int!=0?270:169;continue;}
case 169:{f.Push(f.Locals[4]);f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.String(" ")));f.Pc=173;continue;}
case 173:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",176);}
case 176:{f.StackOp("pop");f.Pc=177;continue;}
case 177:{f.Push(f.Locals[4]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[3]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/game/cost/CostExile","getTypeDescription","()Ljava/lang/String;","invokevirtual",183);}
case 183:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",186);}
case 186:{f.StackOp("pop");f.Pc=187;continue;}
case 187:{f.Pc=270;continue;}
case 190:{f.Push(f.Locals[4]);f.Pc=192;continue;}
case 192:{f.Push(JValue.R(rt.String(" ")));f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",197);}
case 197:{f.StackOp("pop");f.Pc=198;continue;}
case 198:{f.Push(f.Locals[3]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/cost/CostExile","getType","()Ljava/lang/String;","invokevirtual",202);}
case 202:{f.Locals[6]=f.Pop();f.Pc=204;continue;}
case 204:{f.Push(f.Locals[6]);f.Pc=206;continue;}
case 206:{f.Push(JValue.R(rt.String(".Other")));f.Pc=208;continue;}
case 208:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",211);}
case 211:{f.Pc=f.Pop().Int==0?225:214;continue;}
case 214:{f.Push(f.Locals[6]);f.Pc=216;continue;}
case 216:{f.Push(JValue.R(rt.String(".Other")));f.Pc=218;continue;}
case 218:{f.Push(JValue.R(rt.String("")));f.Pc=220;continue;}
case 220:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",223);}
case 223:{f.Locals[6]=f.Pop();f.Pc=225;continue;}
case 225:{f.Push(f.Locals[5]);f.Pc=227;continue;}
case 227:{f.Pc=f.Pop().Int>0?242:230;continue;}
case 230:{f.Push(JValue.R(rt.String("1")));f.Pc=232;continue;}
case 232:{f.Push(f.Locals[3]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/cost/CostExile","getAmount","()Ljava/lang/String;","invokevirtual",236);}
case 236:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",239);}
case 239:{f.Pc=f.Pop().Int!=0?256:242;continue;}
case 242:{f.Push(f.Locals[4]);f.Pc=244;continue;}
case 244:{f.Push(f.Locals[6]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/card/CardType","getPluralType","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",249);}
case 249:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",252);}
case 252:{f.StackOp("pop");f.Pc=253;continue;}
case 253:{f.Pc=270;continue;}
case 256:{f.Push(f.Locals[4]);f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",261);}
case 261:{f.Push(f.Locals[6]);f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/util/Lang","formatValidDesc","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",266);}
case 266:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",269);}
case 269:{f.StackOp("pop");f.Pc=270;continue;}
case 270:{f.Push(f.Locals[0]);f.Pc=271;continue;}
case 271:{f.Push(f.Locals[4]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",276);}
case 276:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Craft","desc","Ljava/lang/String;",value);f.Pc=279;continue;}
case 279:{f.Push(f.Locals[0]);f.Pc=280;continue;}
case 280:{f.Push(f.Locals[3]);f.Pc=281;continue;}
case 281:{f.Push(JValue.I(1));f.Pc=282;continue;}
case 282:{f.Push(f.Locals[5]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/cost/CostExile","exileMultiZoneCostString","(ZI)Ljava/lang/String;","invokevirtual",287);}
case 287:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/Craft","reminder","Ljava/lang/String;",value);f.Pc=290;continue;}
case 290:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7404(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(2));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Craft","cost","Lforge/game/cost/Cost;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/cost/Cost","getCostMana","()Lforge/game/cost/CostPartMana;","invokevirtual",14);}
case 14:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{f.Push(JValue.I(1));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/Craft","reminder","Ljava/lang/String;"));f.Pc=21;continue;}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",25);}
case 25:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
