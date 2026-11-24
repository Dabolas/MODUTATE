// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C541{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostPart","java/lang/Object",new string[]{"java/lang/Comparable","java/lang/Cloneable","java/io/Serializable"},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("originalAmount","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("amount","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("originalType","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("originalTypeDescription","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("typeDescription","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("type","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("payingTrigSA","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JMethod(6384,"forge/game/cost/CostPart","<init>","()V",1,1,4,new JHandler[]{},M6384));
c.Add(new JMethod(6385,"forge/game/cost/CostPart","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",1,4,2,new JHandler[]{},M6385));
c.Add(new JMethod(6386,"forge/game/cost/CostPart","getAmount","()Ljava/lang/String;",17,1,1,new JHandler[]{},M6386));
c.Add(new JMethod(6387,"forge/game/cost/CostPart","getMaxAmountX","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/lang/Integer;",1,4,1,new JHandler[]{},M6387));
c.Add(new JMethod(6388,"forge/game/cost/CostPart","getType","()Ljava/lang/String;",17,1,1,new JHandler[]{},M6388));
c.Add(new JMethod(6389,"forge/game/cost/CostPart","payCostFromSource","()Z",17,1,2,new JHandler[]{},M6389));
c.Add(new JMethod(6390,"forge/game/cost/CostPart","getTypeDescription","()Ljava/lang/String;",17,1,1,new JHandler[]{},M6390));
c.Add(new JMethod(6391,"forge/game/cost/CostPart","getDescriptiveType","()Ljava/lang/String;",1,3,2,new JHandler[]{},M6391));
c.Add(new JMethod(6392,"forge/game/cost/CostPart","isReusable","()Z",1,1,1,new JHandler[]{},M6392));
c.Add(new JMethod(6393,"forge/game/cost/CostPart","isRenewable","()Z",1,1,1,new JHandler[]{},M6393));
c.Add(new JMethod(6394,"forge/game/cost/CostPart","isUndoable","()Z",1,1,1,new JHandler[]{},M6394));
c.Add(new JMethod(6395,"forge/game/cost/CostPart","convertAmount","()Ljava/lang/Integer;",17,1,1,new JHandler[]{},M6395));
c.Add(new JMethod(6396,"forge/game/cost/CostPart","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I",17,2,3,new JHandler[]{},M6396));
c.Add(new JMethod(6397,"forge/game/cost/CostPart","setTrigger","(Lforge/game/spellability/SpellAbility;)V",1,2,2,new JHandler[]{},M6397));
c.Add(new JMethod(6398,"forge/game/cost/CostPart","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6399,"forge/game/cost/CostPart","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6400,"forge/game/cost/CostPart","toString","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6401,"forge/game/cost/CostPart","refund","(Lforge/game/card/Card;)V",1,2,0,new JHandler[]{},M6401));
c.Add(new JMethod(6402,"forge/game/cost/CostPart","setAmount","(Ljava/lang/String;)V",1,2,2,new JHandler[]{},M6402));
c.Add(new JMethod(6403,"forge/game/cost/CostPart","applyTextChangeEffects","(Lforge/game/CardTraitBase;)V",17,2,3,new JHandler[]{},M6403));
c.Add(new JMethod(6404,"forge/game/cost/CostPart","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(6405,"forge/game/cost/CostPart","paymentOrder","()I",1,1,1,new JHandler[]{},M6405));
c.Add(new JMethod(6406,"forge/game/cost/CostPart","copy","()Lforge/game/cost/CostPart;",1,3,2,new JHandler[]{new JHandler(2,10,13,"java/lang/CloneNotSupportedException")},M6406));
c.Add(new JMethod(6407,"forge/game/cost/CostPart","compareTo","(Lforge/game/cost/CostPart;)I",1,2,2,new JHandler[]{},M6407));
c.Add(new JMethod(6408,"forge/game/cost/CostPart","compareTo","(Ljava/lang/Object;)I",4161,2,2,new JHandler[]{},M6408));
}

internal static JStep M6384(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("1")));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("Card")));f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/cost/CostPart","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6385(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/cost/CostPart","setAmount","(Ljava/lang/String;)V","invokevirtual",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPart","originalType","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPart","originalType","Ljava/lang/String;"));f.Pc=19;continue;}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPart","type","Ljava/lang/String;",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPart","originalTypeDescription","Ljava/lang/String;",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPart","originalTypeDescription","Ljava/lang/String;"));f.Pc=32;continue;}
case 32:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPart","typeDescription","Ljava/lang/String;",value);f.Pc=35;continue;}
case 35:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6386(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPart","amount","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6387(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6388(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPart","type","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6389(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(JValue.R(rt.String("CARDNAME")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int!=0?24:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",16);}
case 16:{f.Push(JValue.R(rt.String("NICKNAME")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6390(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPart","typeDescription","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6391(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostPart","getTypeDescription","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?39:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/cost/CostPart","getType","()Ljava/lang/String;","invokevirtual",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardType$CoreType","isValidEnum","(Ljava/lang/String;)Z","invokestatic",18);}
case 18:{f.Pc=f.Pop().Int!=0?30:21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("Card")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?37:30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Pc=38;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Locals[1]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6392(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6393(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6394(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6395(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPart","amount","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",7);}
case 7:{f.Pc=f.Pop().Int==0?23:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPart","amount","Ljava/lang/String;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",17);}
case 17:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",20);}
case 20:{f.Pc=24;continue;}
case 23:{f.Push(JValue.R(null));f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6396(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/cost/CostPart","getAmount","()Ljava/lang/String;","invokevirtual",8);}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6397(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPart","payingTrigSA","Lforge/game/spellability/SpellAbility;",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6401(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6402(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPart","originalAmount","Ljava/lang/String;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPart","originalAmount","Ljava/lang/String;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPart","amount","Ljava/lang/String;",value);f.Pc=13;continue;}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6403(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPart","originalAmount","Ljava/lang/String;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/ability/AbilityUtils","applyAbilityTextChangeEffects","(Ljava/lang/String;Lforge/game/CardTraitBase;)Ljava/lang/String;","invokestatic",9);}
case 9:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPart","amount","Ljava/lang/String;",value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPart","originalType","Ljava/lang/String;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/ability/AbilityUtils","applyAbilityTextChangeEffects","(Ljava/lang/String;Lforge/game/CardTraitBase;)Ljava/lang/String;","invokestatic",21);}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPart","type","Ljava/lang/String;",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostPart","originalTypeDescription","Ljava/lang/String;"));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/ability/AbilityUtils","applyDescriptionTextChangeEffects","(Ljava/lang/String;Lforge/game/CardTraitBase;)Ljava/lang/String;","invokestatic",33);}
case 33:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostPart","typeDescription","Ljava/lang/String;",value);f.Pc=36;continue;}
case 36:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6405(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(5));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6406(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[1]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Object","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Pc=21;continue;}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"java/lang/System","err","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","err","Ljava/io/PrintStream;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[2]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/Object;)V","invokevirtual",21);}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6407(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/cost/CostPart","paymentOrder","()I","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/cost/CostPart","paymentOrder","()I","invokevirtual",8);}
case 8:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=9;continue;}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6408(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/cost/CostPart"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/cost/CostPart","compareTo","(Lforge/game/cost/CostPart;)I","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
