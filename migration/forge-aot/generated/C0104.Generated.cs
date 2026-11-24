// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C104{
internal static JClass Build(){var c=new JClass("forge/deck/DeckRuleColorIdentity","forge/deck/DeckRule",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("exemptPredicate","Ljava/util/function/Predicate;",false,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("disabled","Z",false,JValue.Default("Z"),null));
c.Add(new JField("additionalColorPredicate","Ljava/util/function/Predicate;",false,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("additionalColorCount","I",false,JValue.Default("I"),null));
c.Add(new JField("allowedAdditionalColors","B",false,JValue.Default("B"),null));
c.Add(new JMethod(1616,"forge/deck/DeckRuleColorIdentity","<init>","(Ljava/util/Map;B)V",0,6,4,new JHandler[]{},M1616));
c.Add(new JMethod(1617,"forge/deck/DeckRuleColorIdentity","disablesColorIdentityCheck","()Z",1,1,1,new JHandler[]{},M1617));
c.Add(new JMethod(1618,"forge/deck/DeckRuleColorIdentity","allowsOffColorIdentity","(Lforge/card/CardRules;)Z",1,2,2,new JHandler[]{},M1618));
c.Add(new JMethod(1619,"forge/deck/DeckRuleColorIdentity","hasAllowedAdditionalColorBudget","()Z",1,1,1,new JHandler[]{},M1619));
c.Add(new JMethod(1620,"forge/deck/DeckRuleColorIdentity","getAdditionalColorCount","()I",1,1,1,new JHandler[]{},M1620));
c.Add(new JMethod(1621,"forge/deck/DeckRuleColorIdentity","getAllowedAdditionalColors","()B",1,1,1,new JHandler[]{},M1621));
c.Add(new JMethod(1622,"forge/deck/DeckRuleColorIdentity","approvesAdditionalColor","(Lforge/card/CardRules;B)Z",1,3,3,new JHandler[]{},M1622));
c.Add(new JMethod(1623,"forge/deck/DeckRuleColorIdentity","lambda$new$1","(Lforge/card/CardRules;)Z",4106,1,1,new JHandler[]{},M1623));
c.Add(new JMethod(1624,"forge/deck/DeckRuleColorIdentity","lambda$new$0","(Lforge/card/CardRules;)Z",4106,1,1,new JHandler[]{},M1624));
}

internal static JStep M1616(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/deck/DeckRule","<init>","(Ljava/util/Map;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("True")));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Disable")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",16);}
case 16:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",22);}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRuleColorIdentity","disabled","Z",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("Exempt")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{f.Pc=f.Pop().Reference==null?49:42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/card/CardRulesPredicates","restrictionList","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",46);}
case 46:{f.Pc=54;continue;}
case 49:{return rt.DynamicCall(f,"forge/deck/DeckRuleColorIdentity:1616:49:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",54);}
case 54:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRuleColorIdentity","exemptPredicate","Ljava/util/function/Predicate;",value);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("AllowedAdditionalColor")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{f.Locals[4]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[4]);f.Pc=73;continue;}
case 73:{f.Pc=f.Pop().Reference==null?87:76;continue;}
case 76:{f.Push(f.Locals[4]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",81);}
case 81:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",84);}
case 84:{f.Pc=88;continue;}
case 87:{f.Push(JValue.I(0));f.Pc=88;continue;}
case 88:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRuleColorIdentity","additionalColorCount","I",value);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{f.Push(JValue.R(rt.String("AllowedAdditionalColorType")));f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",99);}
case 99:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=102;continue;}
case 102:{f.Locals[5]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRuleColorIdentity","additionalColorCount","I"));f.Pc=109;continue;}
case 109:{f.Pc=f.Pop().Int<=0?125:112;continue;}
case 112:{f.Push(f.Locals[5]);f.Pc=114;continue;}
case 114:{f.Pc=f.Pop().Reference==null?125:117;continue;}
case 117:{f.Push(f.Locals[5]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/card/CardRulesPredicates","restrictionList","(Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",122);}
case 122:{f.Pc=130;continue;}
case 125:{return rt.DynamicCall(f,"forge/deck/DeckRuleColorIdentity:1616:125:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",130);}
case 130:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRuleColorIdentity","additionalColorPredicate","Ljava/util/function/Predicate;",value);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[0]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[2]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",138);}
case 138:{return rt.Call(f,"forge/card/ColorSet","countColors","()I","invokevirtual",141);}
case 141:{f.Push(f.Locals[0]);f.Pc=142;continue;}
case 142:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRuleColorIdentity","additionalColorCount","I"));f.Pc=145;continue;}
case 145:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?152:148;continue;}
case 148:{f.Push(f.Locals[2]);f.Pc=149;continue;}
case 149:{f.Pc=153;continue;}
case 152:{f.Push(JValue.I(0));f.Pc=153;continue;}
case 153:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRuleColorIdentity","allowedAdditionalColors","B",value);f.Pc=156;continue;}
case 156:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1617(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRuleColorIdentity","disabled","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1618(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRuleColorIdentity","disabled","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?20:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRuleColorIdentity","exemptPredicate","Ljava/util/function/Predicate;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int==0?24:20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{f.Pc=25;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1619(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRuleColorIdentity","additionalColorCount","I"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int<=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1620(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRuleColorIdentity","additionalColorCount","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1621(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRuleColorIdentity","allowedAdditionalColors","B"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1622(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRuleColorIdentity","additionalColorCount","I"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?20:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRuleColorIdentity","additionalColorPredicate","Ljava/util/function/Predicate;"));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",17);}
case 17:{f.Pc=f.Pop().Int!=0?22:20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/card/CardRules","getColorIdentity","()Lforge/card/ColorSet;","invokevirtual",26);}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRuleColorIdentity","allowedAdditionalColors","B"));f.Pc=31;continue;}
case 31:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/card/ColorSet","hasNoColorsExcept","(I)Z","invokevirtual",35);}
case 35:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1623(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1624(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
