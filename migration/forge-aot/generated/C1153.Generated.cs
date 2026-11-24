// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1153{
internal static JClass Build(){var c=new JClass("forge/util/ReflectionUtil","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(12001,"forge/util/ReflectionUtil","<init>","()V",2,1,1,new JHandler[]{},M12001));
c.Add(new JMethod(12002,"forge/util/ReflectionUtil","makeDefaultInstanceOf","(Ljava/lang/Class;)Ljava/lang/Object;",9,2,6,new JHandler[]{new JHandler(15,32,33,"java/lang/NoSuchMethodException"),new JHandler(15,32,61,"java/lang/SecurityException"),new JHandler(15,32,61,"java/lang/InstantiationException"),new JHandler(15,32,61,"java/lang/IllegalAccessException"),new JHandler(15,32,61,"java/lang/IllegalArgumentException"),new JHandler(15,32,61,"java/lang/reflect/InvocationTargetException")},M12002));
c.Add(new JMethod(12003,"forge/util/ReflectionUtil","safeCast","(Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;",9,2,2,new JHandler[]{},M12003));
c.Add(new JMethod(12004,"forge/util/ReflectionUtil","isInstance","(Ljava/lang/Object;Ljava/lang/Class;)Z",9,2,2,new JHandler[]{},M12004));
}

internal static JStep M12001(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12002(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?15:5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Class<? extends T> cls must not be null")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",14);}
case 14:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Class;",f.Pop().Int)));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/Class","getConstructor","([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;","invokevirtual",23);}
case 23:{f.Locals[1]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/reflect/Constructor","newInstance","([Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",32);}
case 32:{return JStep.Return(f.Pop());}
case 33:{f.Locals[1]=f.Pop();f.Pc=34;continue;}
case 34:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{f.Push(JValue.I(2));f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("No default constructor found in class")));f.Pc=46;continue;}
case 46:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=47;continue;}
case 47:{f.StackOp("dup");f.Pc=48;continue;}
case 48:{f.Push(JValue.I(1));f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/Class","getName","()Ljava/lang/String;","invokevirtual",53);}
case 53:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",57);}
case 57:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",60);}
case 60:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 61:{f.Locals[1]=f.Pop();f.Pc=62;continue;}
case 62:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=65;continue;}
case 65:{f.StackOp("dup");f.Pc=66;continue;}
case 66:{f.Push(JValue.I(3));f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=70;continue;}
case 70:{f.StackOp("dup");f.Pc=71;continue;}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("Can't instantiate class")));f.Pc=74;continue;}
case 74:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=75;continue;}
case 75:{f.StackOp("dup");f.Pc=76;continue;}
case 76:{f.Push(JValue.I(1));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/Class","getName","()Ljava/lang/String;","invokevirtual",81);}
case 81:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=82;continue;}
case 82:{f.StackOp("dup");f.Pc=83;continue;}
case 83:{f.Push(JValue.I(2));f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("using default constructor")));f.Pc=86;continue;}
case 86:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",90);}
case 90:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",93);}
case 93:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12003(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/lang/Class","isInstance","(Ljava/lang/Object;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?10:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12004(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("java/lang/reflect/Array")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?17:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/Object","getClass","()Ljava/lang/Class;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/lang/Class","isArray","()Z","invokevirtual",16);}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"org/apache/commons/lang3/reflect/TypeUtils","isInstance","(Ljava/lang/Object;Ljava/lang/reflect/Type;)Z","invokestatic",22);}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
