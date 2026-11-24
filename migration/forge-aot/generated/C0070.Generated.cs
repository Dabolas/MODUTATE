// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C70{
internal static JClass Build(){var c=new JClass("forge/card/MagicColor$Constant","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("WHITE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"white"));
c.Add(new JField("BLUE","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"blue"));
c.Add(new JField("BLACK","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"black"));
c.Add(new JField("RED","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"red"));
c.Add(new JField("GREEN","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"green"));
c.Add(new JField("COLORLESS","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"colorless"));
c.Add(new JField("ONLY_COLORS","Lcom/google/common/collect/ImmutableList;",true,JValue.Default("Lcom/google/common/collect/ImmutableList;"),null));
c.Add(new JField("COLORS_AND_COLORLESS","Lcom/google/common/collect/ImmutableList;",true,JValue.Default("Lcom/google/common/collect/ImmutableList;"),null));
c.Add(new JField("SNOW","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"snow"));
c.Add(new JField("BASIC_LANDS","Lcom/google/common/collect/ImmutableList;",true,JValue.Default("Lcom/google/common/collect/ImmutableList;"),null));
c.Add(new JField("SNOW_LANDS","Lcom/google/common/collect/ImmutableList;",true,JValue.Default("Lcom/google/common/collect/ImmutableList;"),null));
c.Add(new JField("ANY_COLOR_CONVERSION","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"AnyType->AnyColor"));
c.Add(new JField("ANY_TYPE_CONVERSION","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"AnyType->AnyType"));
c.Add(new JMethod(1153,"forge/card/MagicColor$Constant","<init>","()V",2,1,1,new JHandler[]{},M1153));
c.Add(new JMethod(1154,"forge/card/MagicColor$Constant","<clinit>","()V",8,0,6,new JHandler[]{},M1154));
}

internal static JStep M1153(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1154(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("white")));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String("blue")));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("black")));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("red")));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("green")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/collect/ImmutableList","of","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList;","invokestatic",13);}
case 13:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","ONLY_COLORS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;rt.PutStatic("forge/card/MagicColor$Constant","ONLY_COLORS","Lcom/google/common/collect/ImmutableList;",f.Pop());f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("white")));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("blue")));f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("black")));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("red")));f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("green")));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("colorless")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"com/google/common/collect/ImmutableList","of","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList;","invokestatic",31);}
case 31:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","COLORS_AND_COLORLESS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;rt.PutStatic("forge/card/MagicColor$Constant","COLORS_AND_COLORLESS","Lcom/google/common/collect/ImmutableList;",f.Pop());f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("Plains")));f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("Island")));f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("Swamp")));f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("Mountain")));f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("Forest")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"com/google/common/collect/ImmutableList","of","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList;","invokestatic",47);}
case 47:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;rt.PutStatic("forge/card/MagicColor$Constant","BASIC_LANDS","Lcom/google/common/collect/ImmutableList;",f.Pop());f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("Snow-Covered Plains")));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("Snow-Covered Island")));f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("Snow-Covered Swamp")));f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("Snow-Covered Mountain")));f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("Snow-Covered Forest")));f.Pc=60;continue;}
case 60:{return rt.Call(f,"com/google/common/collect/ImmutableList","of","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList;","invokestatic",63);}
case 63:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","SNOW_LANDS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;rt.PutStatic("forge/card/MagicColor$Constant","SNOW_LANDS","Lcom/google/common/collect/ImmutableList;",f.Pop());f.Pc=66;continue;}
case 66:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
