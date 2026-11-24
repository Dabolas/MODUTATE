// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1134{
internal static JClass Build(){var c=new JClass("forge/util/Lang","java/lang/Object",new string[]{},1057);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("languages","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("instance","Lforge/util/Lang;",true,JValue.Default("Lforge/util/Lang;"),null));
c.Add(new JField("englishInstance","Lforge/util/Lang;",true,JValue.Default("Lforge/util/Lang;"),null));
c.Add(new JField("VOWEL_PATTERN","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("numbers0","[Ljava/lang/String;",true,JValue.Default("[Ljava/lang/String;"),null));
c.Add(new JField("numbers20","[Ljava/lang/String;",true,JValue.Default("[Ljava/lang/String;"),null));
c.Add(new JField("VALID_SCRIPT","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("VALID_SHARES_COLOR","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("VALID_NAMED","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("VALID_CMC_LIKE","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("VALID_COMMA_SEPARATOR","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("VALID_AND_SEPARATOR","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("VALID_PART_SEPARATOR","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("VALID_SPACE_BEFORE_CAPITAL","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("VALID_BASE_OBJECT","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("VALID_INTEGER","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("COMMON_VALID_NAMES","Ljava/util/List;",true,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("VALID_ADJECTIVES","Ljava/util/List;",true,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(11868,"forge/util/Lang","createInstance","(Ljava/lang/String;)V",9,1,1,new JHandler[]{},M11868));
c.Add(new JMethod(11869,"forge/util/Lang","initInstance","(Ljava/lang/String;)Lforge/util/Lang;",9,1,3,new JHandler[]{},M11869));
c.Add(new JMethod(11870,"forge/util/Lang","getInstance","()Lforge/util/Lang;",9,0,1,new JHandler[]{},M11870));
c.Add(new JMethod(11871,"forge/util/Lang","getEnglishInstance","()Lforge/util/Lang;",9,0,1,new JHandler[]{},M11871));
c.Add(new JMethod(11872,"forge/util/Lang","<init>","()V",4,1,1,new JHandler[]{},M11872));
c.Add(new JMethod(11873,"forge/util/Lang","getFontFile","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11873));
c.Add(new JMethod(11874,"forge/util/Lang","canDisplayCheck","()C",1,1,1,new JHandler[]{},M11874));
c.Add(new JMethod(11875,"forge/util/Lang","getOrdinal","(I)Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11876,"forge/util/Lang","joinHomogenous","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",9,4,2,new JHandler[]{},M11876));
c.Add(new JMethod(11877,"forge/util/Lang","joinHomogenous","(Ljava/lang/Iterable;)Ljava/lang/String;",9,1,1,new JHandler[]{},M11877));
c.Add(new JMethod(11878,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;",9,1,3,new JHandler[]{},M11878));
c.Add(new JMethod(11879,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;)Ljava/lang/String;",9,2,3,new JHandler[]{},M11879));
c.Add(new JMethod(11880,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;",9,7,3,new JHandler[]{},M11880));
c.Add(new JMethod(11881,"forge/util/Lang","joinVerb","(Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;",9,2,2,new JHandler[]{},M11881));
c.Add(new JMethod(11882,"forge/util/Lang","joinVerb","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",9,2,1,new JHandler[]{},M11882));
c.Add(new JMethod(11883,"forge/util/Lang","subjectIsSingle3rdPerson","(Ljava/lang/String;)Z",9,1,2,new JHandler[]{},M11883));
c.Add(new JMethod(11884,"forge/util/Lang","verbs3rdPersonSingular","(Ljava/lang/String;)Ljava/lang/String;",9,1,1,new JHandler[]{},M11884));
c.Add(new JMethod(11885,"forge/util/Lang","getPlural","(Ljava/lang/String;)Ljava/lang/String;",9,1,3,new JHandler[]{},M11885));
c.Add(new JMethod(11886,"forge/util/Lang","nounWithAmount","(ILjava/lang/String;)Ljava/lang/String;",9,4,2,new JHandler[]{},M11886));
c.Add(new JMethod(11887,"forge/util/Lang","nounWithNumeral","(ILjava/lang/String;)Ljava/lang/String;",9,3,2,new JHandler[]{},M11887));
c.Add(new JMethod(11888,"forge/util/Lang","nounWithNumeral","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",9,2,2,new JHandler[]{},M11888));
c.Add(new JMethod(11889,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;",9,4,2,new JHandler[]{},M11889));
c.Add(new JMethod(11890,"forge/util/Lang","nounWithNumeralExceptOne","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",9,2,2,new JHandler[]{},M11890));
c.Add(new JMethod(11891,"forge/util/Lang","getPossesive","(Ljava/lang/String;)Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11892,"forge/util/Lang","getPossessedObject","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11893,"forge/util/Lang","startsWithVowel","(Ljava/lang/String;)Z",9,1,2,new JHandler[]{},M11893));
c.Add(new JMethod(11894,"forge/util/Lang","isVowel","(C)Z",9,1,2,new JHandler[]{},M11894));
c.Add(new JMethod(11895,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;",9,4,4,new JHandler[]{},M11895));
c.Add(new JMethod(11896,"forge/util/Lang","getNickName","(Ljava/lang/String;)Ljava/lang/String;",1,3,2,new JHandler[]{},M11896));
c.Add(new JMethod(11897,"forge/util/Lang","buildValidDesc","(Ljava/util/Collection;Z)Ljava/lang/String;",1,3,3,new JHandler[]{},M11897));
c.Add(new JMethod(11898,"forge/util/Lang","buildValidDesc","(Ljava/util/Collection;Ljava/lang/String;)Ljava/lang/String;",1,3,3,new JHandler[]{},M11898));
c.Add(new JMethod(11899,"forge/util/Lang","buildValidCardDesc","(Ljava/util/Collection;Z)Ljava/lang/String;",1,3,3,new JHandler[]{},M11899));
c.Add(new JMethod(11900,"forge/util/Lang","formatValidDesc","(Ljava/lang/String;)Ljava/lang/String;",1,2,4,new JHandler[]{},M11900));
c.Add(new JMethod(11901,"forge/util/Lang","describeValidList","(Ljava/lang/String;)Ljava/lang/String;",1,2,3,new JHandler[]{},M11901));
c.Add(new JMethod(11902,"forge/util/Lang","formatValidDesc","(Ljava/lang/String;ZZ)Ljava/lang/String;",1,17,5,new JHandler[]{},M11902));
c.Add(new JMethod(11903,"forge/util/Lang","lambda$formatValidDesc$5","(ZZLjava/lang/String;)Ljava/lang/String;",4098,4,4,new JHandler[]{},M11903));
c.Add(new JMethod(11904,"forge/util/Lang","lambda$formatValidDesc$4","(Ljava/lang/String;)Z",4106,1,1,new JHandler[]{},M11904));
c.Add(new JMethod(11905,"forge/util/Lang","lambda$describeValidList$3","(Ljava/lang/String;)Ljava/lang/String;",4098,2,2,new JHandler[]{},M11905));
c.Add(new JMethod(11906,"forge/util/Lang","lambda$buildValidCardDesc$2","(Ljava/lang/String;)Ljava/lang/String;",4098,2,4,new JHandler[]{},M11906));
c.Add(new JMethod(11907,"forge/util/Lang","lambda$buildValidDesc$1","(Ljava/lang/String;)Ljava/lang/String;",4098,2,2,new JHandler[]{},M11907));
c.Add(new JMethod(11908,"forge/util/Lang","lambda$initInstance$0","(Ljava/lang/String;)Lforge/util/Lang;",4106,3,2,new JHandler[]{},M11908));
c.Add(new JMethod(11909,"forge/util/Lang","<clinit>","()V",8,0,5,new JHandler[]{},M11909));
}

internal static JStep M11868(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/Lang","initInstance","(Ljava/lang/String;)Lforge/util/Lang;","invokestatic",4);}
case 4:{if(!rt.StaticReady(f,"forge/util/Lang","instance","Lforge/util/Lang;"))return JStep.Continue;rt.PutStatic("forge/util/Lang","instance","Lforge/util/Lang;",f.Pop());f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("en-US")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/Lang","initInstance","(Ljava/lang/String;)Lforge/util/Lang;","invokestatic",12);}
case 12:{if(!rt.StaticReady(f,"forge/util/Lang","englishInstance","Lforge/util/Lang;"))return JStep.Continue;rt.PutStatic("forge/util/Lang","englishInstance","Lforge/util/Lang;",f.Pop());f.Pc=15;continue;}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11869(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/Lang","languages","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","languages","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.DynamicCall(f,"forge/util/Lang:11869:4:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",9);}
case 9:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",14);}
case 14:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/util/Lang"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11870(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/Lang","instance","Lforge/util/Lang;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","instance","Lforge/util/Lang;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11871(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/Lang","englishInstance","Lforge/util/Lang;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","englishInstance","Lforge/util/Lang;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11872(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11873(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11874(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(32));f.Pc=2;continue;}
case 2:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11876(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNotBlank","(Ljava/lang/CharSequence;)Z","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNotBlank","(Ljava/lang/CharSequence;)Z","invokestatic",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int==0?32:14;continue;}
case 14:{f.Push(f.Locals[3]);f.Pc=15;continue;}
case 15:{f.Pc=f.Pop().Int==0?28:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.DynamicCall(f,"forge/util/Lang:11876:20:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",25);}
case 25:{f.Pc=42;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Pc=42;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Int==0?40:36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Pc=42;continue;}
case 40:{f.Push(JValue.R(rt.String("")));f.Pc=42;continue;}
case 42:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11877(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",4);}
case 4:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11878(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String("and")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11879(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String("and")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;","invokestatic",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11880(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Collection","size","()I","invokeinterface",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[5]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",31);}
case 31:{f.Pc=f.Pop().Int==0?119:34;continue;}
case 34:{f.Push(f.Locals[5]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",41);}
case 41:{f.Locals[6]=f.Pop();f.Pc=43;continue;}
case 43:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(-1)));f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Pc=f.Pop().Reference==null?70:50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[1]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[6]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",60);}
case 60:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",66);}
case 66:{f.StackOp("pop");f.Pc=67;continue;}
case 67:{f.Pc=78;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",77);}
case 77:{f.StackOp("pop");f.Pc=78;continue;}
case 78:{f.Push(f.Locals[3]);f.Pc=79;continue;}
case 79:{f.Push(JValue.I(1));f.Pc=80;continue;}
case 80:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?94:83;continue;}
case 83:{f.Push(f.Locals[4]);f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String(", ")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",90);}
case 90:{f.StackOp("pop");f.Pc=91;continue;}
case 91:{f.Pc=116;continue;}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{f.Push(JValue.I(1));f.Pc=96;continue;}
case 96:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?116:99;continue;}
case 99:{f.Push(f.Locals[4]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String(" ")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",106);}
case 106:{f.Push(f.Locals[2]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",110);}
case 110:{f.Push(JValue.R(rt.String(" ")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",115);}
case 115:{f.StackOp("pop");f.Pc=116;continue;}
case 116:{f.Pc=24;continue;}
case 119:{f.Push(f.Locals[4]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",124);}
case 124:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11881(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",6);}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?25:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("it")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",16);}
case 16:{return rt.Call(f,"java/lang/Object","toString","()Ljava/lang/String;","invokevirtual",19);}
case 19:{return rt.Call(f,"forge/util/Lang","subjectIsSingle3rdPerson","(Ljava/lang/String;)Z","invokestatic",22);}
case 22:{f.Pc=f.Pop().Int!=0?29:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Pc=33;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/util/Lang","verbs3rdPersonSingular","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",33);}
case 33:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11882(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/util/Lang","subjectIsSingle3rdPerson","(Ljava/lang/String;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Pc=15;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/util/Lang","verbs3rdPersonSingular","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",15);}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11883(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("You")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int!=0?13:9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{f.Pc=14;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11884(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.DynamicCall(f,"forge/util/Lang:11884:1:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11885(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String("s")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?19:10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("ds")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int==0?37:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("x")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int!=0?37:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("ch")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?42:37;continue;}
case 37:{f.Push(JValue.R(rt.String("es")));f.Pc=39;continue;}
case 39:{f.Pc=58;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("ds")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",48);}
case 48:{f.Pc=f.Pop().Int==0?56:51;continue;}
case 51:{f.Push(JValue.R(rt.String("")));f.Pc=53;continue;}
case 53:{f.Pc=58;continue;}
case 56:{f.Push(JValue.R(rt.String("s")));f.Pc=58;continue;}
case 58:{return rt.DynamicCall(f,"forge/util/Lang:11885:58:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",63);}
case 63:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11886(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?9:5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=13;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/Lang","getPlural","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?37:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/util/Lang","startsWithVowel","(Ljava/lang/String;)Z","invokestatic",23);}
case 23:{f.Pc=f.Pop().Int==0?31:26;continue;}
case 26:{f.Push(JValue.R(rt.String("an ")));f.Pc=28;continue;}
case 28:{f.Pc=33;continue;}
case 31:{f.Push(JValue.R(rt.String("a ")));f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Pc=44;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.DynamicCall(f,"forge/util/Lang:11886:38:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",43);}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.DynamicCall(f,"forge/util/Lang:11886:46:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",51);}
case 51:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11887(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?9:5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=13;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/Lang","getPlural","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",18);}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return rt.DynamicCall(f,"forge/util/Lang:11887:19:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",24);}
case 24:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11888(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int==0?16:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",11);}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/util/Lang","nounWithNumeral","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",15);}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/Lang","getPlural","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",21);}
case 21:{return rt.DynamicCall(f,"forge/util/Lang:11888:21:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",26);}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11889(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?9:5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=13;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/util/Lang","getPlural","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",13);}
case 13:{f.Locals[2]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?36:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/util/Lang","startsWithVowel","(Ljava/lang/String;)Z","invokestatic",23);}
case 23:{f.Pc=f.Pop().Int==0?31:26;continue;}
case 26:{f.Push(JValue.R(rt.String("an")));f.Pc=28;continue;}
case 28:{f.Pc=40;continue;}
case 31:{f.Push(JValue.R(rt.String("a")));f.Pc=33;continue;}
case 33:{f.Pc=40;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",40);}
case 40:{f.Locals[3]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[2]);f.Pc=43;continue;}
case 43:{return rt.DynamicCall(f,"forge/util/Lang:11889:43:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",48);}
case 48:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11890(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int==0?16:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",11);}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(ILjava/lang/String;)Ljava/lang/String;","invokestatic",15);}
case 15:{return JStep.Return(f.Pop());}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/Lang","getPlural","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",21);}
case 21:{return rt.DynamicCall(f,"forge/util/Lang:11890:21:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",26);}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11893(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/util/Lang","isVowel","(C)Z","invokestatic",11);}
case 11:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11894(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/util/Lang","VOWEL_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","VOWEL_PATTERN","Ljava/util/regex/Pattern;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","valueOf","(C)Ljava/lang/String;","invokestatic",7);}
case 7:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",10);}
case 10:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11895(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int>=0?9:4;continue;}
case 4:{f.Push(JValue.R(rt.String("minus ")));f.Pc=6;continue;}
case 6:{f.Pc=11;continue;}
case 9:{f.Push(JValue.R(rt.String("")));f.Pc=11;continue;}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/Math","abs","(I)I","invokestatic",16);}
case 16:{f.Locals[0]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Pc=f.Pop().Int<0?39:21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(JValue.I(20));f.Pc=24;continue;}
case 24:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?39:27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{if(!rt.StaticReady(f,"forge/util/Lang","numbers0","[Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","numbers0","[Ljava/lang/String;"));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=33;continue;}
case 33:{return rt.DynamicCall(f,"forge/util/Lang:11895:33:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",38);}
case 38:{return JStep.Return(f.Pop());}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(JValue.I(100));f.Pc=42;continue;}
case 42:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?83:45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(10));f.Pc=48;continue;}
case 48:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=49;continue;}
case 49:{f.Locals[2]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{f.Pc=f.Pop().Int!=0?59:54;continue;}
case 54:{f.Push(JValue.R(rt.String("")));f.Pc=56;continue;}
case 56:{f.Pc=64;continue;}
case 59:{if(!rt.StaticReady(f,"forge/util/Lang","numbers0","[Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","numbers0","[Ljava/lang/String;"));f.Pc=62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=64;continue;}
case 64:{f.Locals[3]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{if(!rt.StaticReady(f,"forge/util/Lang","numbers20","[Ljava/lang/String;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","numbers20","[Ljava/lang/String;"));f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=73;continue;}
case 73:{f.Push(JValue.I(2));f.Pc=74;continue;}
case 74:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=75;continue;}
case 75:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{return rt.DynamicCall(f,"forge/util/Lang:11895:77:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",82);}
case 82:{return JStep.Return(f.Pop());}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",87);}
case 87:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11896(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String(",")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?18:9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String(",")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String(":")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int==0?36:27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String(":")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",33);}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=35;continue;}
case 35:{return JStep.Return(f.Pop());}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String(" ")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",42);}
case 42:{f.Locals[2]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[2]);f.Pc=44;continue;}
case 44:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?66:49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String(".")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?66:60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(1));f.Pc=62;continue;}
case 62:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=63;continue;}
case 63:{f.Pc=69;continue;}
case 66:{f.Push(f.Locals[2]);f.Pc=67;continue;}
case 67:{f.Push(JValue.I(0));f.Pc=68;continue;}
case 68:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=69;continue;}
case 69:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11897(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Pc=f.Pop().Int==0?11:6;continue;}
case 6:{f.Push(JValue.R(rt.String("and/or")));f.Pc=8;continue;}
case 8:{f.Pc=13;continue;}
case 11:{f.Push(JValue.R(rt.String("or")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/util/Lang","buildValidDesc","(Ljava/util/Collection;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11898(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/util/Lang:11898:2:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/util/Lang;)Ljava/util/function/Function;",7);}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;","invokestatic",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11899(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/util/Lang:11899:2:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/util/Lang;)Ljava/util/function/Function;",7);}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int==0?16:11;continue;}
case 11:{f.Push(JValue.R(rt.String("and/or")));f.Pc=13;continue;}
case 13:{f.Pc=18;continue;}
case 16:{f.Push(JValue.R(rt.String("or")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;","invokestatic",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11900(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/Lang","formatValidDesc","(Ljava/lang/String;ZZ)Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11901(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?11:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?15:11;continue;}
case 11:{f.Push(JValue.R(rt.String("permanent")));f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
case 15:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_COMMA_SEPARATOR","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","VALID_COMMA_SEPARATOR","Ljava/util/regex/Pattern;"));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/regex/Pattern","split","(Ljava/lang/CharSequence;)[Ljava/lang/String;","invokevirtual",22);}
case 22:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",25);}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.DynamicCall(f,"forge/util/Lang:11901:26:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/util/Lang;)Ljava/util/function/Function;",31);}
case 31:{f.Push(JValue.R(rt.String("or")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;","invokestatic",36);}
case 36:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11902(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("EACH ")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?278:10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_AND_SEPARATOR","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","VALID_AND_SEPARATOR","Ljava/util/regex/Pattern;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("EACH ")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",20);}
case 20:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",23);}
case 23:{return rt.Call(f,"java/util/regex/Pattern","split","(Ljava/lang/CharSequence;)[Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",31);}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",36);}
case 36:{f.Locals[6]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{f.Locals[7]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[7]);f.Pc=44;continue;}
case 44:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=45;continue;}
case 45:{f.Locals[8]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{f.Locals[9]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[9]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[8]);f.Pc=54;continue;}
case 54:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?145:57;continue;}
case 57:{f.Push(f.Locals[7]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[9]);f.Pc=61;continue;}
case 61:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=62;continue;}
case 62:{f.Locals[10]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[10]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",70);}
case 70:{f.Push(f.Locals[2]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[3]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/util/Lang","formatValidDesc","(Ljava/lang/String;ZZ)Ljava/lang/String;","invokevirtual",75);}
case 75:{f.Locals[11]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[11]);f.Pc=79;continue;}
case 79:{f.Push(JValue.I(32));f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/String","lastIndexOf","(I)I","invokevirtual",84);}
case 84:{f.Locals[12]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[5]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[12]);f.Pc=90;continue;}
case 90:{f.Pc=f.Pop().Int>=0?98:93;continue;}
case 93:{f.Push(f.Locals[11]);f.Pc=95;continue;}
case 95:{f.Pc=107;continue;}
case 98:{f.Push(f.Locals[11]);f.Pc=100;continue;}
case 100:{f.Push(f.Locals[12]);f.Pc=102;continue;}
case 102:{f.Push(JValue.I(1));f.Pc=103;continue;}
case 103:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",107);}
case 107:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",112);}
case 112:{f.StackOp("pop");f.Pc=113;continue;}
case 113:{f.Push(f.Locals[6]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[12]);f.Pc=117;continue;}
case 117:{f.Pc=f.Pop().Int>=0?125:120;continue;}
case 120:{f.Push(JValue.R(rt.String("")));f.Pc=122;continue;}
case 122:{f.Pc=133;continue;}
case 125:{f.Push(f.Locals[11]);f.Pc=127;continue;}
case 127:{f.Push(JValue.I(0));f.Pc=128;continue;}
case 128:{f.Push(f.Locals[12]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",133);}
case 133:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",138);}
case 138:{f.StackOp("pop");f.Pc=139;continue;}
case 139:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=142;continue;}
case 142:{f.Pc=50;continue;}
case 145:{f.Push(f.Locals[5]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",152);}
case 152:{return rt.Call(f,"java/util/stream/Stream","distinct","()Ljava/util/stream/Stream;","invokeinterface",157);}
case 157:{return rt.Call(f,"java/util/stream/Stream","count","()J","invokeinterface",162);}
case 162:{f.Push(JValue.L(1));f.Pc=163;continue;}
case 163:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=164;continue;}
case 164:{f.Pc=f.Pop().Int!=0?242:167;continue;}
case 167:{f.Push(f.Locals[6]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",174);}
case 174:{return rt.DynamicCall(f,"forge/util/Lang:11902:174:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",179);}
case 179:{return rt.Call(f,"java/util/stream/Stream","filter","(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;","invokeinterface",184);}
case 184:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",187);}
case 187:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",192);}
case 192:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/List"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=195;continue;}
case 195:{f.Locals[7]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(f.Locals[7]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",204);}
case 204:{f.Pc=f.Pop().Int==0?212:207;continue;}
case 207:{f.Push(JValue.R(rt.String("")));f.Pc=209;continue;}
case 209:{f.Pc=225;continue;}
case 212:{f.Push(f.Locals[7]);f.Pc=214;continue;}
case 214:{f.Push(JValue.R(null));f.Pc=215;continue;}
case 215:{f.Push(JValue.R(rt.String("and")));f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;","invokestatic",220);}
case 220:{return rt.DynamicCall(f,"forge/util/Lang:11902:220:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",225);}
case 225:{f.Push(f.Locals[5]);f.Pc=227;continue;}
case 227:{f.Push(JValue.I(0));f.Pc=228;continue;}
case 228:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",233);}
case 233:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=236;continue;}
case 236:{return rt.DynamicCall(f,"forge/util/Lang:11902:236:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",241);}
case 241:{return JStep.Return(f.Pop());}
case 242:{f.Push(f.Locals[4]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"java/util/Arrays","stream","([Ljava/lang/Object;)Ljava/util/stream/Stream;","invokestatic",247);}
case 247:{f.Push(f.Locals[0]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[2]);f.Pc=249;continue;}
case 249:{f.Push(f.Locals[3]);f.Pc=250;continue;}
case 250:{return rt.DynamicCall(f,"forge/util/Lang:11902:250:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/util/Lang;ZZ)Ljava/util/function/Function;",255);}
case 255:{return rt.Call(f,"java/util/stream/Stream","map","(Ljava/util/function/Function;)Ljava/util/stream/Stream;","invokeinterface",260);}
case 260:{return rt.Call(f,"java/util/stream/Collectors","toList","()Ljava/util/stream/Collector;","invokestatic",263);}
case 263:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",268);}
case 268:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=271;continue;}
case 271:{f.Push(JValue.R(null));f.Pc=272;continue;}
case 272:{f.Push(JValue.R(rt.String("and")));f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;","invokestatic",277);}
case 277:{return JStep.Return(f.Pop());}
case 278:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_SHARES_COLOR","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","VALID_SHARES_COLOR","Ljava/util/regex/Pattern;"));f.Pc=281;continue;}
case 281:{f.Push(f.Locals[1]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",285);}
case 285:{f.Locals[4]=f.Pop();f.Pc=287;continue;}
case 287:{f.Push(f.Locals[4]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",292);}
case 292:{f.Pc=f.Pop().Int==0?381:295;continue;}
case 295:{f.Push(f.Locals[0]);f.Pc=296;continue;}
case 296:{f.Push(f.Locals[4]);f.Pc=298;continue;}
case 298:{f.Push(JValue.I(1));f.Pc=299;continue;}
case 299:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",302);}
case 302:{f.Push(f.Locals[4]);f.Pc=304;continue;}
case 304:{f.Push(JValue.I(2));f.Pc=305;continue;}
case 305:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",308);}
case 308:{return rt.DynamicCall(f,"forge/util/Lang:11902:308:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",313);}
case 313:{return rt.Call(f,"forge/util/Lang","formatValidDesc","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",316);}
case 316:{f.Locals[5]=f.Pop();f.Pc=318;continue;}
case 318:{f.Push(f.Locals[0]);f.Pc=319;continue;}
case 319:{f.Push(f.Locals[1]);f.Pc=320;continue;}
case 320:{f.Push(JValue.I(0));f.Pc=321;continue;}
case 321:{f.Push(f.Locals[4]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/util/regex/Matcher","start","()I","invokevirtual",326);}
case 326:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",329);}
case 329:{f.Push(f.Locals[1]);f.Pc=330;continue;}
case 330:{f.Push(f.Locals[4]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"java/util/regex/Matcher","end","()I","invokevirtual",335);}
case 335:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",338);}
case 338:{return rt.DynamicCall(f,"forge/util/Lang:11902:338:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",343);}
case 343:{f.Push(f.Locals[2]);f.Pc=344;continue;}
case 344:{f.Push(f.Locals[3]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/util/Lang","formatValidDesc","(Ljava/lang/String;ZZ)Ljava/lang/String;","invokevirtual",348);}
case 348:{f.Locals[6]=f.Pop();f.Pc=350;continue;}
case 350:{f.Push(f.Locals[6]);f.Pc=352;continue;}
case 352:{f.Push(JValue.R(rt.String("SHARESREF")));f.Pc=355;continue;}
case 355:{f.Push(f.Locals[5]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/util/Lang","startsWithVowel","(Ljava/lang/String;)Z","invokestatic",360);}
case 360:{f.Pc=f.Pop().Int==0?368:363;continue;}
case 363:{f.Push(JValue.R(rt.String("an ")));f.Pc=365;continue;}
case 365:{f.Pc=370;continue;}
case 368:{f.Push(JValue.R(rt.String("a ")));f.Pc=370;continue;}
case 370:{f.Push(f.Locals[5]);f.Pc=372;continue;}
case 372:{return rt.DynamicCall(f,"forge/util/Lang:11902:372:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",377);}
case 377:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",380);}
case 380:{return JStep.Return(f.Pop());}
case 381:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_NAMED","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","VALID_NAMED","Ljava/util/regex/Pattern;"));f.Pc=384;continue;}
case 384:{f.Push(f.Locals[1]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",388);}
case 388:{f.Locals[5]=f.Pop();f.Pc=390;continue;}
case 390:{f.Push(f.Locals[5]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",395);}
case 395:{f.Pc=f.Pop().Int==0?494:398;continue;}
case 398:{f.Push(f.Locals[5]);f.Pc=400;continue;}
case 400:{f.Push(JValue.I(2));f.Pc=401;continue;}
case 401:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",404);}
case 404:{f.Push(JValue.I(59));f.Pc=406;continue;}
case 406:{f.Push(JValue.I(44));f.Pc=408;continue;}
case 408:{return rt.Call(f,"java/lang/String","replace","(CC)Ljava/lang/String;","invokevirtual",411);}
case 411:{f.Locals[6]=f.Pop();f.Pc=413;continue;}
case 413:{f.Push(f.Locals[5]);f.Pc=415;continue;}
case 415:{f.Push(JValue.I(1));f.Pc=416;continue;}
case 416:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",419);}
case 419:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",422);}
case 422:{f.Pc=f.Pop().Int!=0?429:425;continue;}
case 425:{f.Push(JValue.I(1));f.Pc=426;continue;}
case 426:{f.Pc=430;continue;}
case 429:{f.Push(JValue.I(0));f.Pc=430;continue;}
case 430:{f.Locals[7]=f.Pop();f.Pc=432;continue;}
case 432:{f.Push(f.Locals[0]);f.Pc=433;continue;}
case 433:{f.Push(f.Locals[1]);f.Pc=434;continue;}
case 434:{f.Push(JValue.I(0));f.Pc=435;continue;}
case 435:{f.Push(f.Locals[5]);f.Pc=437;continue;}
case 437:{return rt.Call(f,"java/util/regex/Matcher","start","()I","invokevirtual",440);}
case 440:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",443);}
case 443:{f.Push(f.Locals[1]);f.Pc=444;continue;}
case 444:{f.Push(f.Locals[5]);f.Pc=446;continue;}
case 446:{return rt.Call(f,"java/util/regex/Matcher","end","()I","invokevirtual",449);}
case 449:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",452);}
case 452:{return rt.DynamicCall(f,"forge/util/Lang:11902:452:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",457);}
case 457:{f.Push(f.Locals[2]);f.Pc=458;continue;}
case 458:{f.Push(f.Locals[3]);f.Pc=459;continue;}
case 459:{return rt.Call(f,"forge/util/Lang","formatValidDesc","(Ljava/lang/String;ZZ)Ljava/lang/String;","invokevirtual",462);}
case 462:{f.Locals[8]=f.Pop();f.Pc=464;continue;}
case 464:{f.Push(f.Locals[8]);f.Pc=466;continue;}
case 466:{f.Push(JValue.R(rt.String("NAMEDREF")));f.Pc=469;continue;}
case 469:{f.Push(f.Locals[7]);f.Pc=471;continue;}
case 471:{f.Pc=f.Pop().Int==0?480:474;continue;}
case 474:{f.Push(JValue.R(rt.String("not named ")));f.Pc=477;continue;}
case 477:{f.Pc=483;continue;}
case 480:{f.Push(JValue.R(rt.String("named ")));f.Pc=483;continue;}
case 483:{f.Push(f.Locals[6]);f.Pc=485;continue;}
case 485:{return rt.DynamicCall(f,"forge/util/Lang:11902:485:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",490);}
case 490:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",493);}
case 493:{return JStep.Return(f.Pop());}
case 494:{f.Push(f.Locals[1]);f.Pc=495;continue;}
case 495:{f.Push(JValue.R(rt.String(" & ")));f.Pc=498;continue;}
case 498:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",501);}
case 501:{f.Pc=f.Pop().Int==0?574:504;continue;}
case 504:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",507);}
case 507:{f.Locals[6]=f.Pop();f.Pc=509;continue;}
case 509:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_AND_SEPARATOR","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","VALID_AND_SEPARATOR","Ljava/util/regex/Pattern;"));f.Pc=512;continue;}
case 512:{f.Push(f.Locals[1]);f.Pc=513;continue;}
case 513:{return rt.Call(f,"java/util/regex/Pattern","split","(Ljava/lang/CharSequence;)[Ljava/lang/String;","invokevirtual",516);}
case 516:{f.Locals[7]=f.Pop();f.Pc=518;continue;}
case 518:{f.Push(f.Locals[7]);f.Pc=520;continue;}
case 520:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=521;continue;}
case 521:{f.Locals[8]=f.Pop();f.Pc=523;continue;}
case 523:{f.Push(JValue.I(0));f.Pc=524;continue;}
case 524:{f.Locals[9]=f.Pop();f.Pc=526;continue;}
case 526:{f.Push(f.Locals[9]);f.Pc=528;continue;}
case 528:{f.Push(f.Locals[8]);f.Pc=530;continue;}
case 530:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?565:533;continue;}
case 533:{f.Push(f.Locals[7]);f.Pc=535;continue;}
case 535:{f.Push(f.Locals[9]);f.Pc=537;continue;}
case 537:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=538;continue;}
case 538:{f.Locals[10]=f.Pop();f.Pc=540;continue;}
case 540:{f.Push(f.Locals[6]);f.Pc=542;continue;}
case 542:{f.Push(f.Locals[0]);f.Pc=543;continue;}
case 543:{f.Push(f.Locals[10]);f.Pc=545;continue;}
case 545:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",548);}
case 548:{f.Push(f.Locals[2]);f.Pc=549;continue;}
case 549:{f.Push(f.Locals[3]);f.Pc=550;continue;}
case 550:{return rt.Call(f,"forge/util/Lang","formatValidDesc","(Ljava/lang/String;ZZ)Ljava/lang/String;","invokevirtual",553);}
case 553:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",558);}
case 558:{f.StackOp("pop");f.Pc=559;continue;}
case 559:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=562;continue;}
case 562:{f.Pc=526;continue;}
case 565:{f.Push(f.Locals[6]);f.Pc=567;continue;}
case 567:{f.Push(JValue.R(null));f.Pc=568;continue;}
case 568:{f.Push(JValue.R(rt.String("and")));f.Pc=570;continue;}
case 570:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;Ljava/util/function/Function;Ljava/lang/String;)Ljava/lang/String;","invokestatic",573);}
case 573:{return JStep.Return(f.Pop());}
case 574:{f.Push(f.Locals[1]);f.Pc=575;continue;}
case 575:{f.Push(JValue.R(rt.String(".")));f.Pc=577;continue;}
case 577:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",580);}
case 580:{f.Pc=f.Pop().Int!=0?637:583;continue;}
case 583:{f.Push(f.Locals[1]);f.Pc=584;continue;}
case 584:{f.Push(JValue.R(rt.String("+")));f.Pc=587;continue;}
case 587:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",590);}
case 590:{f.Pc=f.Pop().Int!=0?637:593;continue;}
case 593:{if(!rt.StaticReady(f,"forge/util/Lang","COMMON_VALID_NAMES","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","COMMON_VALID_NAMES","Ljava/util/List;"));f.Pc=596;continue;}
case 596:{f.Push(f.Locals[1]);f.Pc=597;continue;}
case 597:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",602);}
case 602:{f.Pc=f.Pop().Int!=0?612:605;continue;}
case 605:{f.Push(f.Locals[1]);f.Pc=606;continue;}
case 606:{return rt.Call(f,"forge/card/CardType","isACardType","(Ljava/lang/String;)Z","invokestatic",609);}
case 609:{f.Pc=f.Pop().Int==0?635:612;continue;}
case 612:{f.Push(f.Locals[1]);f.Pc=613;continue;}
case 613:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",616);}
case 616:{f.Locals[1]=f.Pop();f.Pc=617;continue;}
case 617:{f.Push(f.Locals[2]);f.Pc=618;continue;}
case 618:{f.Pc=f.Pop().Int==0?635:621;continue;}
case 621:{f.Push(f.Locals[1]);f.Pc=622;continue;}
case 622:{f.Push(JValue.R(rt.String("s")));f.Pc=624;continue;}
case 624:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",627);}
case 627:{f.Pc=f.Pop().Int!=0?635:630;continue;}
case 630:{f.Push(f.Locals[1]);f.Pc=631;continue;}
case 631:{return rt.Call(f,"forge/util/Lang","getPlural","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",634);}
case 634:{f.Locals[1]=f.Pop();f.Pc=635;continue;}
case 635:{f.Push(f.Locals[1]);f.Pc=636;continue;}
case 636:{return JStep.Return(f.Pop());}
case 637:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_SPACE_BEFORE_CAPITAL","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","VALID_SPACE_BEFORE_CAPITAL","Ljava/util/regex/Pattern;"));f.Pc=640;continue;}
case 640:{f.Push(f.Locals[1]);f.Pc=641;continue;}
case 641:{f.Push(JValue.R(rt.String("!")));f.Pc=644;continue;}
case 644:{f.Push(JValue.R(rt.String("non")));f.Pc=647;continue;}
case 647:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",650);}
case 650:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",653);}
case 653:{f.Push(JValue.R(rt.String("")));f.Pc=655;continue;}
case 655:{return rt.Call(f,"java/util/regex/Matcher","replaceAll","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",658);}
case 658:{f.Locals[1]=f.Pop();f.Pc=659;continue;}
case 659:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_SCRIPT","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","VALID_SCRIPT","Ljava/util/regex/Pattern;"));f.Pc=662;continue;}
case 662:{f.Push(f.Locals[1]);f.Pc=663;continue;}
case 663:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",666);}
case 666:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",669);}
case 669:{f.Pc=f.Pop().Int!=0?674:672;continue;}
case 672:{f.Push(f.Locals[1]);f.Pc=673;continue;}
case 673:{return JStep.Return(f.Pop());}
case 674:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_PART_SEPARATOR","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","VALID_PART_SEPARATOR","Ljava/util/regex/Pattern;"));f.Pc=677;continue;}
case 677:{f.Push(f.Locals[1]);f.Pc=678;continue;}
case 678:{return rt.Call(f,"java/util/regex/Pattern","split","(Ljava/lang/CharSequence;)[Ljava/lang/String;","invokevirtual",681);}
case 681:{f.Locals[6]=f.Pop();f.Pc=683;continue;}
case 683:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_BASE_OBJECT","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","VALID_BASE_OBJECT","Ljava/util/regex/Pattern;"));f.Pc=686;continue;}
case 686:{f.Push(f.Locals[6]);f.Pc=688;continue;}
case 688:{f.Push(JValue.I(0));f.Pc=689;continue;}
case 689:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=690;continue;}
case 690:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",693);}
case 693:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",696);}
case 696:{f.Pc=f.Pop().Int==0?706:699;continue;}
case 699:{f.Push(f.Locals[6]);f.Pc=701;continue;}
case 701:{f.Push(JValue.I(0));f.Pc=702;continue;}
case 702:{f.Push(JValue.R(rt.String("Card")));f.Pc=705;continue;}
case 705:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=706;continue;}
case 706:{if(!rt.StaticReady(f,"forge/util/Lang","COMMON_VALID_NAMES","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","COMMON_VALID_NAMES","Ljava/util/List;"));f.Pc=709;continue;}
case 709:{f.Push(f.Locals[6]);f.Pc=711;continue;}
case 711:{f.Push(JValue.I(0));f.Pc=712;continue;}
case 712:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=713;continue;}
case 713:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",718);}
case 718:{f.Pc=f.Pop().Int!=0?731:721;continue;}
case 721:{f.Push(f.Locals[6]);f.Pc=723;continue;}
case 723:{f.Push(JValue.I(0));f.Pc=724;continue;}
case 724:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=725;continue;}
case 725:{return rt.Call(f,"forge/card/CardType","isACardType","(Ljava/lang/String;)Z","invokestatic",728);}
case 728:{f.Pc=f.Pop().Int==0?741:731;continue;}
case 731:{f.Push(f.Locals[6]);f.Pc=733;continue;}
case 733:{f.Push(JValue.I(0));f.Pc=734;continue;}
case 734:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=735;continue;}
case 735:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",738);}
case 738:{f.Pc=745;continue;}
case 741:{f.Push(f.Locals[6]);f.Pc=743;continue;}
case 743:{f.Push(JValue.I(0));f.Pc=744;continue;}
case 744:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=745;continue;}
case 745:{f.Locals[7]=f.Pop();f.Pc=747;continue;}
case 747:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",750);}
case 750:{f.Locals[8]=f.Pop();f.Pc=752;continue;}
case 752:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",755);}
case 755:{f.Locals[9]=f.Pop();f.Pc=757;continue;}
case 757:{f.Push(JValue.I(1));f.Pc=758;continue;}
case 758:{f.Locals[10]=f.Pop();f.Pc=760;continue;}
case 760:{f.Push(f.Locals[10]);f.Pc=762;continue;}
case 762:{f.Push(f.Locals[6]);f.Pc=764;continue;}
case 764:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=765;continue;}
case 765:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?1980:768;continue;}
case 768:{f.Push(f.Locals[6]);f.Pc=770;continue;}
case 770:{f.Push(f.Locals[10]);f.Pc=772;continue;}
case 772:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=773;continue;}
case 773:{f.Locals[11]=f.Pop();f.Pc=775;continue;}
case 775:{f.Push(f.Locals[11]);f.Pc=777;continue;}
case 777:{f.Push(JValue.R(rt.String("nonColorless")));f.Pc=780;continue;}
case 780:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",783);}
case 783:{f.Pc=f.Pop().Int==0?800:786;continue;}
case 786:{f.Push(f.Locals[8]);f.Pc=788;continue;}
case 788:{f.Push(JValue.R(rt.String("colored")));f.Pc=791;continue;}
case 791:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",796);}
case 796:{f.StackOp("pop");f.Pc=797;continue;}
case 797:{f.Pc=1974;continue;}
case 800:{f.Push(f.Locals[11]);f.Pc=802;continue;}
case 802:{f.Push(JValue.R(rt.String("nonColored")));f.Pc=805;continue;}
case 805:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",808);}
case 808:{f.Pc=f.Pop().Int==0?825:811;continue;}
case 811:{f.Push(f.Locals[8]);f.Pc=813;continue;}
case 813:{f.Push(JValue.R(rt.String("colorless")));f.Pc=816;continue;}
case 816:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",821);}
case 821:{f.StackOp("pop");f.Pc=822;continue;}
case 822:{f.Pc=1974;continue;}
case 825:{f.Push(f.Locals[11]);f.Pc=827;continue;}
case 827:{f.Push(JValue.R(rt.String("Other")));f.Pc=830;continue;}
case 830:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",833);}
case 833:{f.Pc=f.Pop().Int!=0?847:836;continue;}
case 836:{f.Push(f.Locals[11]);f.Pc=838;continue;}
case 838:{f.Push(JValue.R(rt.String("nonSelf")));f.Pc=841;continue;}
case 841:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",844);}
case 844:{f.Pc=f.Pop().Int==0?861:847;continue;}
case 847:{f.Push(f.Locals[8]);f.Pc=849;continue;}
case 849:{f.Push(JValue.R(rt.String("other")));f.Pc=852;continue;}
case 852:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",857);}
case 857:{f.StackOp("pop");f.Pc=858;continue;}
case 858:{f.Pc=1974;continue;}
case 861:{f.Push(f.Locals[11]);f.Pc=863;continue;}
case 863:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",866);}
case 866:{f.Push(JValue.I(3));f.Pc=867;continue;}
case 867:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?918:870;continue;}
case 870:{f.Push(f.Locals[11]);f.Pc=872;continue;}
case 872:{f.Push(JValue.R(rt.String("non")));f.Pc=875;continue;}
case 875:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",878);}
case 878:{f.Pc=f.Pop().Int==0?918:881;continue;}
case 881:{f.Push(f.Locals[11]);f.Pc=883;continue;}
case 883:{f.Push(JValue.I(3));f.Pc=884;continue;}
case 884:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",887);}
case 887:{return rt.Call(f,"java/lang/Character","isUpperCase","(C)Z","invokestatic",890);}
case 890:{f.Pc=f.Pop().Int==0?918:893;continue;}
case 893:{f.Push(f.Locals[8]);f.Pc=895;continue;}
case 895:{f.Push(f.Locals[11]);f.Pc=897;continue;}
case 897:{f.Push(JValue.I(3));f.Pc=898;continue;}
case 898:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",901);}
case 901:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",904);}
case 904:{return rt.DynamicCall(f,"forge/util/Lang:11902:904:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",909);}
case 909:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",914);}
case 914:{f.StackOp("pop");f.Pc=915;continue;}
case 915:{f.Pc=1974;continue;}
case 918:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_ADJECTIVES","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","VALID_ADJECTIVES","Ljava/util/List;"));f.Pc=921;continue;}
case 921:{f.Push(f.Locals[11]);f.Pc=923;continue;}
case 923:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",928);}
case 928:{f.Pc=f.Pop().Int==0?947:931;continue;}
case 931:{f.Push(f.Locals[8]);f.Pc=933;continue;}
case 933:{f.Push(f.Locals[11]);f.Pc=935;continue;}
case 935:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",938);}
case 938:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",943);}
case 943:{f.StackOp("pop");f.Pc=944;continue;}
case 944:{f.Pc=1974;continue;}
case 947:{f.Push(f.Locals[11]);f.Pc=949;continue;}
case 949:{return rt.Call(f,"forge/card/CardType","isACardType","(Ljava/lang/String;)Z","invokestatic",952);}
case 952:{f.Pc=f.Pop().Int==0?987:955;continue;}
case 955:{f.Push(f.Locals[7]);f.Pc=957;continue;}
case 957:{f.Push(JValue.R(rt.String("card")));f.Pc=960;continue;}
case 960:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",963);}
case 963:{f.Pc=f.Pop().Int!=0?977:966;continue;}
case 966:{f.Push(f.Locals[7]);f.Pc=968;continue;}
case 968:{f.Push(JValue.R(rt.String("permanent")));f.Pc=971;continue;}
case 971:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",974);}
case 974:{f.Pc=f.Pop().Int==0?987:977;continue;}
case 977:{f.Push(f.Locals[11]);f.Pc=979;continue;}
case 979:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",982);}
case 982:{f.Locals[7]=f.Pop();f.Pc=984;continue;}
case 984:{f.Pc=1974;continue;}
case 987:{f.Push(f.Locals[11]);f.Pc=989;continue;}
case 989:{return rt.Call(f,"forge/card/CardType","isACardType","(Ljava/lang/String;)Z","invokestatic",992);}
case 992:{f.Pc=f.Pop().Int==0?1011:995;continue;}
case 995:{f.Push(f.Locals[8]);f.Pc=997;continue;}
case 997:{f.Push(f.Locals[11]);f.Pc=999;continue;}
case 999:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",1002);}
case 1002:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1007);}
case 1007:{f.StackOp("pop");f.Pc=1008;continue;}
case 1008:{f.Pc=1974;continue;}
case 1011:{f.Push(f.Locals[11]);f.Pc=1013;continue;}
case 1013:{f.Push(JValue.I(0));f.Pc=1014;continue;}
case 1014:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",1017);}
case 1017:{return rt.Call(f,"java/lang/Character","isUpperCase","(C)Z","invokestatic",1020);}
case 1020:{f.Pc=f.Pop().Int==0?1085:1023;continue;}
case 1023:{f.Push(f.Locals[11]);f.Pc=1025;continue;}
case 1025:{f.Push(JValue.R(rt.String("Ctrl")));f.Pc=1028;continue;}
case 1028:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",1031);}
case 1031:{f.Pc=f.Pop().Int!=0?1085:1034;continue;}
case 1034:{f.Push(f.Locals[11]);f.Pc=1036;continue;}
case 1036:{f.Push(JValue.R(rt.String("Own")));f.Pc=1039;continue;}
case 1039:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",1042);}
case 1042:{f.Pc=f.Pop().Int!=0?1085:1045;continue;}
case 1045:{f.Push(f.Locals[11]);f.Pc=1047;continue;}
case 1047:{f.Push(JValue.R(rt.String("Self")));f.Pc=1050;continue;}
case 1050:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1053);}
case 1053:{f.Pc=f.Pop().Int!=0?1085:1056;continue;}
case 1056:{f.Push(f.Locals[11]);f.Pc=1058;continue;}
case 1058:{return rt.Call(f,"forge/card/CardType","isASubType","(Ljava/lang/String;)Z","invokestatic",1061);}
case 1061:{f.Pc=f.Pop().Int!=0?1072:1064;continue;}
case 1064:{f.Push(f.Locals[11]);f.Pc=1066;continue;}
case 1066:{return rt.Call(f,"forge/card/CardType","isASupertype","(Ljava/lang/String;)Z","invokestatic",1069);}
case 1069:{f.Pc=f.Pop().Int==0?1085:1072;continue;}
case 1072:{f.Push(f.Locals[8]);f.Pc=1074;continue;}
case 1074:{f.Push(f.Locals[11]);f.Pc=1076;continue;}
case 1076:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1081);}
case 1081:{f.StackOp("pop");f.Pc=1082;continue;}
case 1082:{f.Pc=1974;continue;}
case 1085:{f.Push(f.Locals[11]);f.Pc=1087;continue;}
case 1087:{f.Push(JValue.R(rt.String("NAMEDREF")));f.Pc=1090;continue;}
case 1090:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1093);}
case 1093:{f.Pc=f.Pop().Int==0?1110:1096;continue;}
case 1096:{f.Push(f.Locals[9]);f.Pc=1098;continue;}
case 1098:{f.Push(JValue.R(rt.String("NAMEDREF")));f.Pc=1101;continue;}
case 1101:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1106);}
case 1106:{f.StackOp("pop");f.Pc=1107;continue;}
case 1107:{f.Pc=1974;continue;}
case 1110:{f.Push(f.Locals[11]);f.Pc=1112;continue;}
case 1112:{f.Push(JValue.R(rt.String("ControlledBy")));f.Pc=1115;continue;}
case 1115:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1118);}
case 1118:{f.Pc=f.Pop().Int==0?1165:1121;continue;}
case 1121:{f.Push(f.Locals[11]);f.Pc=1123;continue;}
case 1123:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",1126);}
case 1126:{f.Push(JValue.R(rt.String("ControlledBy")));f.Pc=1129;continue;}
case 1129:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",1132);}
case 1132:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?1165:1135;continue;}
case 1135:{f.Push(f.Locals[9]);f.Pc=1137;continue;}
case 1137:{f.Push(f.Locals[11]);f.Pc=1139;continue;}
case 1139:{f.Push(JValue.R(rt.String("You")));f.Pc=1141;continue;}
case 1141:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",1144);}
case 1144:{f.Pc=f.Pop().Int==0?1153:1147;continue;}
case 1147:{f.Push(JValue.R(rt.String("you control")));f.Pc=1150;continue;}
case 1150:{f.Pc=1156;continue;}
case 1153:{f.Push(JValue.R(rt.String("that player controls")));f.Pc=1156;continue;}
case 1156:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1161);}
case 1161:{f.StackOp("pop");f.Pc=1162;continue;}
case 1162:{f.Pc=1974;continue;}
case 1165:{f.Push(f.Locals[11]);f.Pc=1167;continue;}
case 1167:{f.Push(JValue.R(rt.String("multicolor")));f.Pc=1170;continue;}
case 1170:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",1173);}
case 1173:{f.Pc=f.Pop().Int==0?1190:1176;continue;}
case 1176:{f.Push(f.Locals[8]);f.Pc=1178;continue;}
case 1178:{f.Push(JValue.R(rt.String("multicolored")));f.Pc=1181;continue;}
case 1181:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1186);}
case 1186:{f.StackOp("pop");f.Pc=1187;continue;}
case 1187:{f.Pc=1974;continue;}
case 1190:{f.Push(f.Locals[11]);f.Pc=1192;continue;}
case 1192:{f.Push(JValue.R(rt.String("SHARESREF")));f.Pc=1195;continue;}
case 1195:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1198);}
case 1198:{f.Pc=f.Pop().Int==0?1215:1201;continue;}
case 1201:{f.Push(f.Locals[9]);f.Pc=1203;continue;}
case 1203:{f.Push(JValue.R(rt.String("SHARESREF")));f.Pc=1206;continue;}
case 1206:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1211);}
case 1211:{f.StackOp("pop");f.Pc=1212;continue;}
case 1212:{f.Pc=1974;continue;}
case 1215:{f.Push(f.Locals[11]);f.Pc=1217;continue;}
case 1217:{f.Push(JValue.R(rt.String("SharesColorWith")));f.Pc=1220;continue;}
case 1220:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1223);}
case 1223:{f.Pc=f.Pop().Int==0?1240:1226;continue;}
case 1226:{f.Push(f.Locals[9]);f.Pc=1228;continue;}
case 1228:{f.Push(JValue.R(rt.String("that shares a color with it")));f.Pc=1231;continue;}
case 1231:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1236);}
case 1236:{f.StackOp("pop");f.Pc=1237;continue;}
case 1237:{f.Pc=1974;continue;}
case 1240:{f.Push(f.Locals[11]);f.Pc=1242;continue;}
case 1242:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=1245;continue;}
case 1245:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1248);}
case 1248:{f.Pc=f.Pop().Int==0?1265:1251;continue;}
case 1251:{f.Push(f.Locals[9]);f.Pc=1253;continue;}
case 1253:{f.Push(JValue.R(rt.String("of the chosen color")));f.Pc=1256;continue;}
case 1256:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1261);}
case 1261:{f.StackOp("pop");f.Pc=1262;continue;}
case 1262:{f.Pc=1974;continue;}
case 1265:{f.Push(f.Locals[11]);f.Pc=1267;continue;}
case 1267:{f.Push(JValue.R(rt.String("ChosenType")));f.Pc=1270;continue;}
case 1270:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1273);}
case 1273:{f.Pc=f.Pop().Int==0?1290:1276;continue;}
case 1276:{f.Push(f.Locals[9]);f.Pc=1278;continue;}
case 1278:{f.Push(JValue.R(rt.String("of the chosen type")));f.Pc=1281;continue;}
case 1281:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1286);}
case 1286:{f.StackOp("pop");f.Pc=1287;continue;}
case 1287:{f.Pc=1974;continue;}
case 1290:{f.Push(f.Locals[11]);f.Pc=1292;continue;}
case 1292:{f.Push(JValue.R(rt.String("sharesNameWith")));f.Pc=1295;continue;}
case 1295:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1298);}
case 1298:{f.Pc=f.Pop().Int==0?1332:1301;continue;}
case 1301:{f.Push(f.Locals[9]);f.Pc=1303;continue;}
case 1303:{f.Push(f.Locals[11]);f.Pc=1305;continue;}
case 1305:{f.Push(JValue.R(rt.String("ChosenCard")));f.Pc=1308;continue;}
case 1308:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",1311);}
case 1311:{f.Pc=f.Pop().Int==0?1320:1314;continue;}
case 1314:{f.Push(JValue.R(rt.String("with the same name as the chosen card")));f.Pc=1317;continue;}
case 1317:{f.Pc=1323;continue;}
case 1320:{f.Push(JValue.R(rt.String("with the same name as it")));f.Pc=1323;continue;}
case 1323:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1328);}
case 1328:{f.StackOp("pop");f.Pc=1329;continue;}
case 1329:{f.Pc=1974;continue;}
case 1332:{f.Push(f.Locals[11]);f.Pc=1334;continue;}
case 1334:{f.Push(JValue.R(rt.String("doesNotShareNameWith")));f.Pc=1337;continue;}
case 1337:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1340);}
case 1340:{f.Pc=f.Pop().Int==0?1357:1343;continue;}
case 1343:{f.Push(f.Locals[9]);f.Pc=1345;continue;}
case 1345:{f.Push(JValue.R(rt.String("with a different name")));f.Pc=1348;continue;}
case 1348:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1353);}
case 1353:{f.StackOp("pop");f.Pc=1354;continue;}
case 1354:{f.Pc=1974;continue;}
case 1357:{f.Push(f.Locals[11]);f.Pc=1359;continue;}
case 1359:{f.Push(JValue.R(rt.String("sharesCreatureTypeWith")));f.Pc=1362;continue;}
case 1362:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1365);}
case 1365:{f.Pc=f.Pop().Int==0?1399:1368;continue;}
case 1368:{f.Push(f.Locals[9]);f.Pc=1370;continue;}
case 1370:{f.Push(f.Locals[11]);f.Pc=1372;continue;}
case 1372:{f.Push(JValue.R(rt.String("Enchanted")));f.Pc=1375;continue;}
case 1375:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",1378);}
case 1378:{f.Pc=f.Pop().Int==0?1387:1381;continue;}
case 1381:{f.Push(JValue.R(rt.String("that shares a creature type with the enchanted creature")));f.Pc=1384;continue;}
case 1384:{f.Pc=1390;continue;}
case 1387:{f.Push(JValue.R(rt.String("that shares a creature type with it")));f.Pc=1390;continue;}
case 1390:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1395);}
case 1395:{f.StackOp("pop");f.Pc=1396;continue;}
case 1396:{f.Pc=1974;continue;}
case 1399:{f.Push(f.Locals[11]);f.Pc=1401;continue;}
case 1401:{f.Push(JValue.R(rt.String("YouCtrl")));f.Pc=1404;continue;}
case 1404:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1407);}
case 1407:{f.Pc=f.Pop().Int!=0?1421:1410;continue;}
case 1410:{f.Push(f.Locals[11]);f.Pc=1412;continue;}
case 1412:{f.Push(JValue.R(rt.String("YouCtrls")));f.Pc=1415;continue;}
case 1415:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1418);}
case 1418:{f.Pc=f.Pop().Int==0?1435:1421;continue;}
case 1421:{f.Push(f.Locals[9]);f.Pc=1423;continue;}
case 1423:{f.Push(JValue.R(rt.String("you control")));f.Pc=1426;continue;}
case 1426:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1431);}
case 1431:{f.StackOp("pop");f.Pc=1432;continue;}
case 1432:{f.Pc=1974;continue;}
case 1435:{f.Push(f.Locals[11]);f.Pc=1437;continue;}
case 1437:{f.Push(JValue.R(rt.String("OppCtrl")));f.Pc=1440;continue;}
case 1440:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1443);}
case 1443:{f.Pc=f.Pop().Int==0?1460:1446;continue;}
case 1446:{f.Push(f.Locals[9]);f.Pc=1448;continue;}
case 1448:{f.Push(JValue.R(rt.String("an opponent controls")));f.Pc=1451;continue;}
case 1451:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1456);}
case 1456:{f.StackOp("pop");f.Pc=1457;continue;}
case 1457:{f.Pc=1974;continue;}
case 1460:{f.Push(f.Locals[11]);f.Pc=1462;continue;}
case 1462:{f.Push(JValue.R(rt.String("YouOwn")));f.Pc=1465;continue;}
case 1465:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1468);}
case 1468:{f.Pc=f.Pop().Int==0?1485:1471;continue;}
case 1471:{f.Push(f.Locals[9]);f.Pc=1473;continue;}
case 1473:{f.Push(JValue.R(rt.String("you own")));f.Pc=1476;continue;}
case 1476:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1481);}
case 1481:{f.StackOp("pop");f.Pc=1482;continue;}
case 1482:{f.Pc=1974;continue;}
case 1485:{f.Push(f.Locals[11]);f.Pc=1487;continue;}
case 1487:{f.Push(JValue.R(rt.String("OppOwn")));f.Pc=1490;continue;}
case 1490:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1493);}
case 1493:{f.Pc=f.Pop().Int==0?1510:1496;continue;}
case 1496:{f.Push(f.Locals[9]);f.Pc=1498;continue;}
case 1498:{f.Push(JValue.R(rt.String("an opponent owns")));f.Pc=1501;continue;}
case 1501:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1506);}
case 1506:{f.StackOp("pop");f.Pc=1507;continue;}
case 1507:{f.Pc=1974;continue;}
case 1510:{f.Push(f.Locals[11]);f.Pc=1512;continue;}
case 1512:{f.Push(JValue.R(rt.String("tapped")));f.Pc=1515;continue;}
case 1515:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1518);}
case 1518:{f.Pc=f.Pop().Int!=0?1576:1521;continue;}
case 1521:{f.Push(f.Locals[11]);f.Pc=1523;continue;}
case 1523:{f.Push(JValue.R(rt.String("untapped")));f.Pc=1526;continue;}
case 1526:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1529);}
case 1529:{f.Pc=f.Pop().Int!=0?1576:1532;continue;}
case 1532:{f.Push(f.Locals[11]);f.Pc=1534;continue;}
case 1534:{f.Push(JValue.R(rt.String("attacking")));f.Pc=1537;continue;}
case 1537:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1540);}
case 1540:{f.Pc=f.Pop().Int!=0?1576:1543;continue;}
case 1543:{f.Push(f.Locals[11]);f.Pc=1545;continue;}
case 1545:{f.Push(JValue.R(rt.String("blocking")));f.Pc=1548;continue;}
case 1548:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1551);}
case 1551:{f.Pc=f.Pop().Int!=0?1576:1554;continue;}
case 1554:{f.Push(f.Locals[11]);f.Pc=1556;continue;}
case 1556:{f.Push(JValue.R(rt.String("token")));f.Pc=1559;continue;}
case 1559:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1562);}
case 1562:{f.Pc=f.Pop().Int!=0?1576:1565;continue;}
case 1565:{f.Push(f.Locals[11]);f.Pc=1567;continue;}
case 1567:{f.Push(JValue.R(rt.String("nontoken")));f.Pc=1570;continue;}
case 1570:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1573);}
case 1573:{f.Pc=f.Pop().Int==0?1589:1576;continue;}
case 1576:{f.Push(f.Locals[8]);f.Pc=1578;continue;}
case 1578:{f.Push(f.Locals[11]);f.Pc=1580;continue;}
case 1580:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1585);}
case 1585:{f.StackOp("pop");f.Pc=1586;continue;}
case 1586:{f.Pc=1974;continue;}
case 1589:{f.Push(f.Locals[11]);f.Pc=1591;continue;}
case 1591:{f.Push(JValue.R(rt.String("cmc")));f.Pc=1594;continue;}
case 1594:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1597);}
case 1597:{f.Pc=f.Pop().Int!=0?1622:1600;continue;}
case 1600:{f.Push(f.Locals[11]);f.Pc=1602;continue;}
case 1602:{f.Push(JValue.R(rt.String("power")));f.Pc=1605;continue;}
case 1605:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1608);}
case 1608:{f.Pc=f.Pop().Int!=0?1622:1611;continue;}
case 1611:{f.Push(f.Locals[11]);f.Pc=1613;continue;}
case 1613:{f.Push(JValue.R(rt.String("toughness")));f.Pc=1616;continue;}
case 1616:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",1619);}
case 1619:{f.Pc=f.Pop().Int==0?1974:1622;continue;}
case 1622:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_CMC_LIKE","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","VALID_CMC_LIKE","Ljava/util/regex/Pattern;"));f.Pc=1625;continue;}
case 1625:{f.Push(f.Locals[11]);f.Pc=1627;continue;}
case 1627:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",1630);}
case 1630:{f.Locals[12]=f.Pop();f.Pc=1632;continue;}
case 1632:{f.Push(f.Locals[12]);f.Pc=1634;continue;}
case 1634:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",1637);}
case 1637:{f.Pc=f.Pop().Int==0?1974:1640;continue;}
case 1640:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_INTEGER","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/Lang","VALID_INTEGER","Ljava/util/regex/Pattern;"));f.Pc=1643;continue;}
case 1643:{f.Push(f.Locals[12]);f.Pc=1645;continue;}
case 1645:{f.Push(JValue.I(3));f.Pc=1646;continue;}
case 1646:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",1649);}
case 1649:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",1652);}
case 1652:{return rt.Call(f,"java/util/regex/Matcher","matches","()Z","invokevirtual",1655);}
case 1655:{f.Pc=f.Pop().Int!=0?1673:1658;continue;}
case 1658:{f.Push(JValue.R(rt.String("X")));f.Pc=1661;continue;}
case 1661:{f.Push(f.Locals[12]);f.Pc=1663;continue;}
case 1663:{f.Push(JValue.I(3));f.Pc=1664;continue;}
case 1664:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",1667);}
case 1667:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1670);}
case 1670:{f.Pc=f.Pop().Int==0?1974:1673;continue;}
case 1673:{f.Push(f.Locals[12]);f.Pc=1675;continue;}
case 1675:{f.Push(JValue.I(1));f.Pc=1676;continue;}
case 1676:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",1679);}
case 1679:{f.Push(JValue.R(rt.String("cmc")));f.Pc=1682;continue;}
case 1682:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1685);}
case 1685:{f.Pc=f.Pop().Int==0?1694:1688;continue;}
case 1688:{f.Push(JValue.R(rt.String("mana value")));f.Pc=1691;continue;}
case 1691:{f.Pc=1700;continue;}
case 1694:{f.Push(f.Locals[12]);f.Pc=1696;continue;}
case 1696:{f.Push(JValue.I(1));f.Pc=1697;continue;}
case 1697:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",1700);}
case 1700:{f.Locals[13]=f.Pop();f.Pc=1702;continue;}
case 1702:{f.Push(f.Locals[12]);f.Pc=1704;continue;}
case 1704:{f.Push(JValue.I(2));f.Pc=1705;continue;}
case 1705:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",1708);}
case 1708:{f.Locals[15]=f.Pop();f.Pc=1710;continue;}
case 1710:{f.Push(JValue.I(-1));f.Pc=1711;continue;}
case 1711:{f.Locals[16]=f.Pop();f.Pc=1713;continue;}
case 1713:{f.Push(f.Locals[15]);f.Pc=1715;continue;}
case 1715:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",1718);}
case 1718:{switch(f.Pop().Int){case 2270:f.Pc=1777;break;case 2285:f.Pc=1811;break;case 2425:f.Pc=1760;break;case 2440:f.Pc=1794;break;default:f.Pc=1825;break;}continue;}
case 1760:{f.Push(f.Locals[15]);f.Pc=1762;continue;}
case 1762:{f.Push(JValue.R(rt.String("LE")));f.Pc=1765;continue;}
case 1765:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1768);}
case 1768:{f.Pc=f.Pop().Int==0?1825:1771;continue;}
case 1771:{f.Push(JValue.I(0));f.Pc=1772;continue;}
case 1772:{f.Locals[16]=f.Pop();f.Pc=1774;continue;}
case 1774:{f.Pc=1825;continue;}
case 1777:{f.Push(f.Locals[15]);f.Pc=1779;continue;}
case 1779:{f.Push(JValue.R(rt.String("GE")));f.Pc=1782;continue;}
case 1782:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1785);}
case 1785:{f.Pc=f.Pop().Int==0?1825:1788;continue;}
case 1788:{f.Push(JValue.I(1));f.Pc=1789;continue;}
case 1789:{f.Locals[16]=f.Pop();f.Pc=1791;continue;}
case 1791:{f.Pc=1825;continue;}
case 1794:{f.Push(f.Locals[15]);f.Pc=1796;continue;}
case 1796:{f.Push(JValue.R(rt.String("LT")));f.Pc=1799;continue;}
case 1799:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1802);}
case 1802:{f.Pc=f.Pop().Int==0?1825:1805;continue;}
case 1805:{f.Push(JValue.I(2));f.Pc=1806;continue;}
case 1806:{f.Locals[16]=f.Pop();f.Pc=1808;continue;}
case 1808:{f.Pc=1825;continue;}
case 1811:{f.Push(f.Locals[15]);f.Pc=1813;continue;}
case 1813:{f.Push(JValue.R(rt.String("GT")));f.Pc=1816;continue;}
case 1816:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1819);}
case 1819:{f.Pc=f.Pop().Int==0?1825:1822;continue;}
case 1822:{f.Push(JValue.I(3));f.Pc=1823;continue;}
case 1823:{f.Locals[16]=f.Pop();f.Pc=1825;continue;}
case 1825:{f.Push(f.Locals[16]);f.Pc=1827;continue;}
case 1827:{switch(f.Pop().Int){case 0:f.Pc=1856;break;case 1:f.Pc=1864;break;case 2:f.Pc=1872;break;case 3:f.Pc=1880;break;default:f.Pc=1888;break;}continue;}
case 1856:{f.Push(JValue.R(rt.String(" or less")));f.Pc=1859;continue;}
case 1859:{f.Locals[14]=f.Pop();f.Pc=1861;continue;}
case 1861:{f.Pc=1892;continue;}
case 1864:{f.Push(JValue.R(rt.String(" or greater")));f.Pc=1867;continue;}
case 1867:{f.Locals[14]=f.Pop();f.Pc=1869;continue;}
case 1869:{f.Pc=1892;continue;}
case 1872:{f.Push(JValue.R(rt.String(" less than ")));f.Pc=1875;continue;}
case 1875:{f.Locals[14]=f.Pop();f.Pc=1877;continue;}
case 1877:{f.Pc=1892;continue;}
case 1880:{f.Push(JValue.R(rt.String(" greater than ")));f.Pc=1883;continue;}
case 1883:{f.Locals[14]=f.Pop();f.Pc=1885;continue;}
case 1885:{f.Pc=1892;continue;}
case 1888:{f.Push(JValue.R(rt.String("")));f.Pc=1890;continue;}
case 1890:{f.Locals[14]=f.Pop();f.Pc=1892;continue;}
case 1892:{f.Push(f.Locals[9]);f.Pc=1894;continue;}
case 1894:{f.Push(f.Locals[12]);f.Pc=1896;continue;}
case 1896:{f.Push(JValue.I(2));f.Pc=1897;continue;}
case 1897:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",1900);}
case 1900:{f.Push(JValue.R(rt.String("NE")));f.Pc=1903;continue;}
case 1903:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1906);}
case 1906:{f.Pc=f.Pop().Int==0?1925:1909;continue;}
case 1909:{f.Push(f.Locals[13]);f.Pc=1911;continue;}
case 1911:{f.Push(f.Locals[12]);f.Pc=1913;continue;}
case 1913:{f.Push(JValue.I(3));f.Pc=1914;continue;}
case 1914:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",1917);}
case 1917:{return rt.DynamicCall(f,"forge/util/Lang:11902:1917:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1922);}
case 1922:{f.Pc=1968;continue;}
case 1925:{f.Push(f.Locals[14]);f.Pc=1927;continue;}
case 1927:{f.Push(JValue.R(rt.String(" ")));f.Pc=1929;continue;}
case 1929:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",1932);}
case 1932:{f.Pc=f.Pop().Int==0?1953:1935;continue;}
case 1935:{f.Push(f.Locals[13]);f.Pc=1937;continue;}
case 1937:{f.Push(f.Locals[14]);f.Pc=1939;continue;}
case 1939:{f.Push(f.Locals[12]);f.Pc=1941;continue;}
case 1941:{f.Push(JValue.I(3));f.Pc=1942;continue;}
case 1942:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",1945);}
case 1945:{return rt.DynamicCall(f,"forge/util/Lang:11902:1945:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1950);}
case 1950:{f.Pc=1968;continue;}
case 1953:{f.Push(f.Locals[13]);f.Pc=1955;continue;}
case 1955:{f.Push(f.Locals[12]);f.Pc=1957;continue;}
case 1957:{f.Push(JValue.I(3));f.Pc=1958;continue;}
case 1958:{return rt.Call(f,"java/util/regex/Matcher","group","(I)Ljava/lang/String;","invokevirtual",1961);}
case 1961:{f.Push(f.Locals[14]);f.Pc=1963;continue;}
case 1963:{return rt.DynamicCall(f,"forge/util/Lang:11902:1963:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",1968);}
case 1968:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1973);}
case 1973:{f.StackOp("pop");f.Pc=1974;continue;}
case 1974:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=1977;continue;}
case 1977:{f.Pc=760;continue;}
case 1980:{f.Push(f.Locals[3]);f.Pc=1981;continue;}
case 1981:{f.Pc=f.Pop().Int==0?2037:1984;continue;}
case 1984:{f.Push(f.Locals[7]);f.Pc=1986;continue;}
case 1986:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","capitalize","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",1989);}
case 1989:{return rt.Call(f,"forge/card/CardType","isACardType","(Ljava/lang/String;)Z","invokestatic",1992);}
case 1992:{f.Pc=f.Pop().Int==0?2037:1995;continue;}
case 1995:{f.Push(f.Locals[7]);f.Pc=1997;continue;}
case 1997:{f.Push(JValue.R(rt.String("card")));f.Pc=2000;continue;}
case 2000:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2003);}
case 2003:{f.Pc=f.Pop().Int!=0?2037:2006;continue;}
case 2006:{f.Push(f.Locals[7]);f.Pc=2008;continue;}
case 2008:{f.Push(JValue.R(rt.String("permanent")));f.Pc=2011;continue;}
case 2011:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2014);}
case 2014:{f.Pc=f.Pop().Int!=0?2037:2017;continue;}
case 2017:{f.Push(f.Locals[7]);f.Pc=2019;continue;}
case 2019:{f.Push(JValue.R(rt.String("spell")));f.Pc=2022;continue;}
case 2022:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",2025);}
case 2025:{f.Pc=f.Pop().Int!=0?2037:2028;continue;}
case 2028:{f.Push(f.Locals[7]);f.Pc=2030;continue;}
case 2030:{return rt.DynamicCall(f,"forge/util/Lang:11902:2030:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",2035);}
case 2035:{f.Locals[7]=f.Pop();f.Pc=2037;continue;}
case 2037:{f.Push(f.Locals[2]);f.Pc=2038;continue;}
case 2038:{f.Pc=f.Pop().Int==0?2048:2041;continue;}
case 2041:{f.Push(f.Locals[7]);f.Pc=2043;continue;}
case 2043:{return rt.Call(f,"forge/util/Lang","getPlural","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",2046);}
case 2046:{f.Locals[7]=f.Pop();f.Pc=2048;continue;}
case 2048:{f.Push(f.Locals[8]);f.Pc=2050;continue;}
case 2050:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",2053);}
case 2053:{f.Locals[10]=f.Pop();f.Pc=2055;continue;}
case 2055:{f.Push(f.Locals[10]);f.Pc=2057;continue;}
case 2057:{f.Push(f.Locals[7]);f.Pc=2059;continue;}
case 2059:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",2064);}
case 2064:{f.StackOp("pop");f.Pc=2065;continue;}
case 2065:{f.Push(f.Locals[10]);f.Pc=2067;continue;}
case 2067:{f.Push(f.Locals[9]);f.Pc=2069;continue;}
case 2069:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",2074);}
case 2074:{f.StackOp("pop");f.Pc=2075;continue;}
case 2075:{f.Push(JValue.R(rt.String(" ")));f.Pc=2077;continue;}
case 2077:{f.Push(f.Locals[10]);f.Pc=2079;continue;}
case 2079:{return rt.Call(f,"java/lang/String","join","(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/String;","invokestatic",2082);}
case 2082:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11903(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[3]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[2]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/util/Lang","formatValidDesc","(Ljava/lang/String;ZZ)Ljava/lang/String;","invokevirtual",10);}
case 10:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11904(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11905(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/Lang","formatValidDesc","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11906(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(1));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/Lang","formatValidDesc","(Ljava/lang/String;ZZ)Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11907(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/Lang","formatValidDesc","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11908(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("-")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=9;continue;}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(JValue.I(-1));f.Pc=11;continue;}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",16);}
case 16:{switch(f.Pop().Int){case 3201:f.Pc=92;break;case 3246:f.Pc=107;break;case 3276:f.Pc=180;break;case 3371:f.Pc=121;break;case 3383:f.Pc=150;break;case 3428:f.Pc=165;break;case 3651:f.Pc=196;break;case 3886:f.Pc=135;break;default:f.Pc=209;break;}continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("de")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Int==0?209:102;continue;}
case 102:{f.Push(JValue.I(0));f.Pc=103;continue;}
case 103:{f.Locals[2]=f.Pop();f.Pc=104;continue;}
case 104:{f.Pc=209;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("es")));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",113);}
case 113:{f.Pc=f.Pop().Int==0?209:116;continue;}
case 116:{f.Push(JValue.I(1));f.Pc=117;continue;}
case 117:{f.Locals[2]=f.Pop();f.Pc=118;continue;}
case 118:{f.Pc=209;continue;}
case 121:{f.Push(f.Locals[1]);f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("it")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",127);}
case 127:{f.Pc=f.Pop().Int==0?209:130;continue;}
case 130:{f.Push(JValue.I(2));f.Pc=131;continue;}
case 131:{f.Locals[2]=f.Pop();f.Pc=132;continue;}
case 132:{f.Pc=209;continue;}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{f.Push(JValue.R(rt.String("zh")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",142);}
case 142:{f.Pc=f.Pop().Int==0?209:145;continue;}
case 145:{f.Push(JValue.I(3));f.Pc=146;continue;}
case 146:{f.Locals[2]=f.Pop();f.Pc=147;continue;}
case 147:{f.Pc=209;continue;}
case 150:{f.Push(f.Locals[1]);f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String("ja")));f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",157);}
case 157:{f.Pc=f.Pop().Int==0?209:160;continue;}
case 160:{f.Push(JValue.I(4));f.Pc=161;continue;}
case 161:{f.Locals[2]=f.Pop();f.Pc=162;continue;}
case 162:{f.Pc=209;continue;}
case 165:{f.Push(f.Locals[1]);f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("ko")));f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",172);}
case 172:{f.Pc=f.Pop().Int==0?209:175;continue;}
case 175:{f.Push(JValue.I(5));f.Pc=176;continue;}
case 176:{f.Locals[2]=f.Pop();f.Pc=177;continue;}
case 177:{f.Pc=209;continue;}
case 180:{f.Push(f.Locals[1]);f.Pc=181;continue;}
case 181:{f.Push(JValue.R(rt.String("fr")));f.Pc=184;continue;}
case 184:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",187);}
case 187:{f.Pc=f.Pop().Int==0?209:190;continue;}
case 190:{f.Push(JValue.I(6));f.Pc=192;continue;}
case 192:{f.Locals[2]=f.Pop();f.Pc=193;continue;}
case 193:{f.Pc=209;continue;}
case 196:{f.Push(f.Locals[1]);f.Pc=197;continue;}
case 197:{f.Push(JValue.R(rt.String("ru")));f.Pc=200;continue;}
case 200:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",203);}
case 203:{f.Pc=f.Pop().Int==0?209:206;continue;}
case 206:{f.Push(JValue.I(7));f.Pc=208;continue;}
case 208:{f.Locals[2]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[2]);f.Pc=210;continue;}
case 210:{switch(f.Pop().Int){case 0:f.Pc=256;break;case 1:f.Pc=266;break;case 2:f.Pc=276;break;case 3:f.Pc=286;break;case 4:f.Pc=296;break;case 5:f.Pc=306;break;case 6:f.Pc=316;break;case 7:f.Pc=326;break;default:f.Pc=336;break;}continue;}
case 256:{if(!rt.EnsureInitialized(f,"forge/util/lang/LangGerman"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/lang/LangGerman")));f.Pc=259;continue;}
case 259:{f.StackOp("dup");f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/util/lang/LangGerman","<init>","()V","invokespecial",263);}
case 263:{f.Pc=343;continue;}
case 266:{if(!rt.EnsureInitialized(f,"forge/util/lang/LangSpanish"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/lang/LangSpanish")));f.Pc=269;continue;}
case 269:{f.StackOp("dup");f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/util/lang/LangSpanish","<init>","()V","invokespecial",273);}
case 273:{f.Pc=343;continue;}
case 276:{if(!rt.EnsureInitialized(f,"forge/util/lang/LangItalian"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/lang/LangItalian")));f.Pc=279;continue;}
case 279:{f.StackOp("dup");f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/util/lang/LangItalian","<init>","()V","invokespecial",283);}
case 283:{f.Pc=343;continue;}
case 286:{if(!rt.EnsureInitialized(f,"forge/util/lang/LangChinese"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/lang/LangChinese")));f.Pc=289;continue;}
case 289:{f.StackOp("dup");f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/util/lang/LangChinese","<init>","()V","invokespecial",293);}
case 293:{f.Pc=343;continue;}
case 296:{if(!rt.EnsureInitialized(f,"forge/util/lang/LangJapanese"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/lang/LangJapanese")));f.Pc=299;continue;}
case 299:{f.StackOp("dup");f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/util/lang/LangJapanese","<init>","()V","invokespecial",303);}
case 303:{f.Pc=343;continue;}
case 306:{if(!rt.EnsureInitialized(f,"forge/util/lang/LangKorean"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/lang/LangKorean")));f.Pc=309;continue;}
case 309:{f.StackOp("dup");f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/util/lang/LangKorean","<init>","()V","invokespecial",313);}
case 313:{f.Pc=343;continue;}
case 316:{if(!rt.EnsureInitialized(f,"forge/util/lang/LangFrench"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/lang/LangFrench")));f.Pc=319;continue;}
case 319:{f.StackOp("dup");f.Pc=320;continue;}
case 320:{return rt.Call(f,"forge/util/lang/LangFrench","<init>","()V","invokespecial",323);}
case 323:{f.Pc=343;continue;}
case 326:{if(!rt.EnsureInitialized(f,"forge/util/lang/LangRussian"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/lang/LangRussian")));f.Pc=329;continue;}
case 329:{f.StackOp("dup");f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/util/lang/LangRussian","<init>","()V","invokespecial",333);}
case 333:{f.Pc=343;continue;}
case 336:{if(!rt.EnsureInitialized(f,"forge/util/lang/LangEnglish"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/lang/LangEnglish")));f.Pc=339;continue;}
case 339:{f.StackOp("dup");f.Pc=340;continue;}
case 340:{return rt.Call(f,"forge/util/lang/LangEnglish","<init>","()V","invokespecial",343);}
case 343:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11909(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",3);}
case 3:{return rt.Call(f,"java/util/Collections","synchronizedMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",6);}
case 6:{if(!rt.StaticReady(f,"forge/util/Lang","languages","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/util/Lang","languages","Ljava/util/Map;",f.Pop());f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("[aeiou]")));f.Pc=12;continue;}
case 12:{f.Push(JValue.I(2));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;I)Ljava/util/regex/Pattern;","invokestatic",16);}
case 16:{if(!rt.StaticReady(f,"forge/util/Lang","VOWEL_PATTERN","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/Lang","VOWEL_PATTERN","Ljava/util/regex/Pattern;",f.Pop());f.Pc=19;continue;}
case 19:{f.Push(JValue.I(20));f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("zero")));f.Pc=29;continue;}
case 29:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{f.Push(JValue.I(1));f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("one")));f.Pc=35;continue;}
case 35:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(JValue.I(2));f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("two")));f.Pc=41;continue;}
case 41:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.I(3));f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("three")));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(4));f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("four")));f.Pc=53;continue;}
case 53:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=54;continue;}
case 54:{f.StackOp("dup");f.Pc=55;continue;}
case 55:{f.Push(JValue.I(5));f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("five")));f.Pc=59;continue;}
case 59:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=60;continue;}
case 60:{f.StackOp("dup");f.Pc=61;continue;}
case 61:{f.Push(JValue.I(6));f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("six")));f.Pc=66;continue;}
case 66:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=67;continue;}
case 67:{f.StackOp("dup");f.Pc=68;continue;}
case 68:{f.Push(JValue.I(7));f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("seven")));f.Pc=73;continue;}
case 73:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=74;continue;}
case 74:{f.StackOp("dup");f.Pc=75;continue;}
case 75:{f.Push(JValue.I(8));f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String("eight")));f.Pc=80;continue;}
case 80:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Push(JValue.I(9));f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("nine")));f.Pc=87;continue;}
case 87:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=88;continue;}
case 88:{f.StackOp("dup");f.Pc=89;continue;}
case 89:{f.Push(JValue.I(10));f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("ten")));f.Pc=94;continue;}
case 94:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=95;continue;}
case 95:{f.StackOp("dup");f.Pc=96;continue;}
case 96:{f.Push(JValue.I(11));f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("eleven")));f.Pc=101;continue;}
case 101:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=102;continue;}
case 102:{f.StackOp("dup");f.Pc=103;continue;}
case 103:{f.Push(JValue.I(12));f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.String("twelve")));f.Pc=108;continue;}
case 108:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=109;continue;}
case 109:{f.StackOp("dup");f.Pc=110;continue;}
case 110:{f.Push(JValue.I(13));f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("thirteen")));f.Pc=115;continue;}
case 115:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=116;continue;}
case 116:{f.StackOp("dup");f.Pc=117;continue;}
case 117:{f.Push(JValue.I(14));f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("fourteen")));f.Pc=122;continue;}
case 122:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=123;continue;}
case 123:{f.StackOp("dup");f.Pc=124;continue;}
case 124:{f.Push(JValue.I(15));f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("fifteen")));f.Pc=129;continue;}
case 129:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=130;continue;}
case 130:{f.StackOp("dup");f.Pc=131;continue;}
case 131:{f.Push(JValue.I(16));f.Pc=133;continue;}
case 133:{f.Push(JValue.R(rt.String("sixteen")));f.Pc=136;continue;}
case 136:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=137;continue;}
case 137:{f.StackOp("dup");f.Pc=138;continue;}
case 138:{f.Push(JValue.I(17));f.Pc=140;continue;}
case 140:{f.Push(JValue.R(rt.String("seventeen")));f.Pc=143;continue;}
case 143:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=144;continue;}
case 144:{f.StackOp("dup");f.Pc=145;continue;}
case 145:{f.Push(JValue.I(18));f.Pc=147;continue;}
case 147:{f.Push(JValue.R(rt.String("eighteen")));f.Pc=150;continue;}
case 150:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=151;continue;}
case 151:{f.StackOp("dup");f.Pc=152;continue;}
case 152:{f.Push(JValue.I(19));f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("nineteen")));f.Pc=157;continue;}
case 157:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=158;continue;}
case 158:{if(!rt.StaticReady(f,"forge/util/Lang","numbers0","[Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/util/Lang","numbers0","[Ljava/lang/String;",f.Pop());f.Pc=161;continue;}
case 161:{f.Push(JValue.I(8));f.Pc=163;continue;}
case 163:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=166;continue;}
case 166:{f.StackOp("dup");f.Pc=167;continue;}
case 167:{f.Push(JValue.I(0));f.Pc=168;continue;}
case 168:{f.Push(JValue.R(rt.String("twenty")));f.Pc=171;continue;}
case 171:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=172;continue;}
case 172:{f.StackOp("dup");f.Pc=173;continue;}
case 173:{f.Push(JValue.I(1));f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("thirty")));f.Pc=177;continue;}
case 177:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=178;continue;}
case 178:{f.StackOp("dup");f.Pc=179;continue;}
case 179:{f.Push(JValue.I(2));f.Pc=180;continue;}
case 180:{f.Push(JValue.R(rt.String("forty")));f.Pc=183;continue;}
case 183:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=184;continue;}
case 184:{f.StackOp("dup");f.Pc=185;continue;}
case 185:{f.Push(JValue.I(3));f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.String("fifty")));f.Pc=189;continue;}
case 189:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=190;continue;}
case 190:{f.StackOp("dup");f.Pc=191;continue;}
case 191:{f.Push(JValue.I(4));f.Pc=192;continue;}
case 192:{f.Push(JValue.R(rt.String("sixty")));f.Pc=195;continue;}
case 195:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=196;continue;}
case 196:{f.StackOp("dup");f.Pc=197;continue;}
case 197:{f.Push(JValue.I(5));f.Pc=198;continue;}
case 198:{f.Push(JValue.R(rt.String("seventy")));f.Pc=201;continue;}
case 201:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=202;continue;}
case 202:{f.StackOp("dup");f.Pc=203;continue;}
case 203:{f.Push(JValue.I(6));f.Pc=205;continue;}
case 205:{f.Push(JValue.R(rt.String("eighty")));f.Pc=208;continue;}
case 208:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=209;continue;}
case 209:{f.StackOp("dup");f.Pc=210;continue;}
case 210:{f.Push(JValue.I(7));f.Pc=212;continue;}
case 212:{f.Push(JValue.R(rt.String("ninety")));f.Pc=215;continue;}
case 215:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=216;continue;}
case 216:{if(!rt.StaticReady(f,"forge/util/Lang","numbers20","[Ljava/lang/String;"))return JStep.Continue;rt.PutStatic("forge/util/Lang","numbers20","[Ljava/lang/String;",f.Pop());f.Pc=219;continue;}
case 219:{f.Push(JValue.R(rt.String("[A-Za-z]+([.+][A-Za-z0-9_]+)*")));f.Pc=222;continue;}
case 222:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",225);}
case 225:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_SCRIPT","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/Lang","VALID_SCRIPT","Ljava/util/regex/Pattern;",f.Pop());f.Pc=228;continue;}
case 228:{f.Push(JValue.R(rt.String("SharesColorWith Valid ?(\\w+)\\.([\\w.+!]+)")));f.Pc=231;continue;}
case 231:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",234);}
case 234:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_SHARES_COLOR","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/Lang","VALID_SHARES_COLOR","Ljava/util/regex/Pattern;",f.Pop());f.Pc=237;continue;}
case 237:{f.Push(JValue.R(rt.String("(?<=[.+])(!?)named([^+]+?)(?=\\+|$|\\.(?:You|Opp|Other|non)\\w*(?:\\+|$))")));f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",243);}
case 243:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_NAMED","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/Lang","VALID_NAMED","Ljava/util/regex/Pattern;",f.Pop());f.Pc=246;continue;}
case 246:{f.Push(JValue.R(rt.String("(cmc|power|toughness)(LE|GE|EQ|LT|GT|NE)(\\w+)")));f.Pc=249;continue;}
case 249:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",252);}
case 252:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_CMC_LIKE","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/Lang","VALID_CMC_LIKE","Ljava/util/regex/Pattern;",f.Pop());f.Pc=255;continue;}
case 255:{f.Push(JValue.R(rt.String(",")));f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",260);}
case 260:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_COMMA_SEPARATOR","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/Lang","VALID_COMMA_SEPARATOR","Ljava/util/regex/Pattern;",f.Pop());f.Pc=263;continue;}
case 263:{f.Push(JValue.R(rt.String(" & ")));f.Pc=266;continue;}
case 266:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",269);}
case 269:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_AND_SEPARATOR","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/Lang","VALID_AND_SEPARATOR","Ljava/util/regex/Pattern;",f.Pop());f.Pc=272;continue;}
case 272:{f.Push(JValue.R(rt.String("[.+]")));f.Pc=275;continue;}
case 275:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",278);}
case 278:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_PART_SEPARATOR","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/Lang","VALID_PART_SEPARATOR","Ljava/util/regex/Pattern;",f.Pop());f.Pc=281;continue;}
case 281:{f.Push(JValue.R(rt.String("(?<=\\w) (?=[A-Z]\\w*(?:[+.]|$))")));f.Pc=284;continue;}
case 284:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",287);}
case 287:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_SPACE_BEFORE_CAPITAL","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/Lang","VALID_SPACE_BEFORE_CAPITAL","Ljava/util/regex/Pattern;",f.Pop());f.Pc=290;continue;}
case 290:{f.Push(JValue.R(rt.String("(?:Targeted|Triggered|Remembered|Imprinted|Enchanted|Equipped|Defined)\\w*")));f.Pc=293;continue;}
case 293:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",296);}
case 296:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_BASE_OBJECT","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/Lang","VALID_BASE_OBJECT","Ljava/util/regex/Pattern;",f.Pop());f.Pc=299;continue;}
case 299:{f.Push(JValue.R(rt.String("\\d+")));f.Pc=302;continue;}
case 302:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",305);}
case 305:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_INTEGER","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/Lang","VALID_INTEGER","Ljava/util/regex/Pattern;",f.Pop());f.Pc=308;continue;}
case 308:{f.Push(JValue.R(rt.String("Player")));f.Pc=311;continue;}
case 311:{f.Push(JValue.R(rt.String("Opponent")));f.Pc=314;continue;}
case 314:{f.Push(JValue.R(rt.String("Card")));f.Pc=317;continue;}
case 317:{f.Push(JValue.R(rt.String("Spell")));f.Pc=320;continue;}
case 320:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;","invokestatic",326);}
case 326:{if(!rt.StaticReady(f,"forge/util/Lang","COMMON_VALID_NAMES","Ljava/util/List;"))return JStep.Continue;rt.PutStatic("forge/util/Lang","COMMON_VALID_NAMES","Ljava/util/List;",f.Pop());f.Pc=329;continue;}
case 329:{f.Push(JValue.I(12));f.Pc=331;continue;}
case 331:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=334;continue;}
case 334:{f.StackOp("dup");f.Pc=335;continue;}
case 335:{f.Push(JValue.I(0));f.Pc=336;continue;}
case 336:{f.Push(JValue.R(rt.String("Basic")));f.Pc=339;continue;}
case 339:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=340;continue;}
case 340:{f.StackOp("dup");f.Pc=341;continue;}
case 341:{f.Push(JValue.I(1));f.Pc=342;continue;}
case 342:{f.Push(JValue.R(rt.String("Legendary")));f.Pc=345;continue;}
case 345:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=346;continue;}
case 346:{f.StackOp("dup");f.Pc=347;continue;}
case 347:{f.Push(JValue.I(2));f.Pc=348;continue;}
case 348:{f.Push(JValue.R(rt.String("Snow")));f.Pc=351;continue;}
case 351:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=352;continue;}
case 352:{f.StackOp("dup");f.Pc=353;continue;}
case 353:{f.Push(JValue.I(3));f.Pc=354;continue;}
case 354:{f.Push(JValue.R(rt.String("White")));f.Pc=357;continue;}
case 357:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=358;continue;}
case 358:{f.StackOp("dup");f.Pc=359;continue;}
case 359:{f.Push(JValue.I(4));f.Pc=360;continue;}
case 360:{f.Push(JValue.R(rt.String("Blue")));f.Pc=363;continue;}
case 363:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=364;continue;}
case 364:{f.StackOp("dup");f.Pc=365;continue;}
case 365:{f.Push(JValue.I(5));f.Pc=366;continue;}
case 366:{f.Push(JValue.R(rt.String("Black")));f.Pc=369;continue;}
case 369:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=370;continue;}
case 370:{f.StackOp("dup");f.Pc=371;continue;}
case 371:{f.Push(JValue.I(6));f.Pc=373;continue;}
case 373:{f.Push(JValue.R(rt.String("Red")));f.Pc=376;continue;}
case 376:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=377;continue;}
case 377:{f.StackOp("dup");f.Pc=378;continue;}
case 378:{f.Push(JValue.I(7));f.Pc=380;continue;}
case 380:{f.Push(JValue.R(rt.String("Green")));f.Pc=383;continue;}
case 383:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=384;continue;}
case 384:{f.StackOp("dup");f.Pc=385;continue;}
case 385:{f.Push(JValue.I(8));f.Pc=387;continue;}
case 387:{f.Push(JValue.R(rt.String("Colorless")));f.Pc=390;continue;}
case 390:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=391;continue;}
case 391:{f.StackOp("dup");f.Pc=392;continue;}
case 392:{f.Push(JValue.I(9));f.Pc=394;continue;}
case 394:{f.Push(JValue.R(rt.String("Multicolor")));f.Pc=397;continue;}
case 397:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=398;continue;}
case 398:{f.StackOp("dup");f.Pc=399;continue;}
case 399:{f.Push(JValue.I(10));f.Pc=401;continue;}
case 401:{f.Push(JValue.R(rt.String("Monocolored")));f.Pc=404;continue;}
case 404:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=405;continue;}
case 405:{f.StackOp("dup");f.Pc=406;continue;}
case 406:{f.Push(JValue.I(11));f.Pc=408;continue;}
case 408:{f.Push(JValue.R(rt.String("Historic")));f.Pc=411;continue;}
case 411:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=412;continue;}
case 412:{return rt.Call(f,"java/util/List","of","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",415);}
case 415:{if(!rt.StaticReady(f,"forge/util/Lang","VALID_ADJECTIVES","Ljava/util/List;"))return JStep.Continue;rt.PutStatic("forge/util/Lang","VALID_ADJECTIVES","Ljava/util/List;",f.Pop());f.Pc=418;continue;}
case 418:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
