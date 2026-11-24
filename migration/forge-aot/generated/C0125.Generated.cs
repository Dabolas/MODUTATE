// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C125{
internal static JClass Build(){var c=new JClass("forge/game/Direction","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("Left","Lforge/game/Direction;",true,JValue.Default("Lforge/game/Direction;"),null));
c.Add(new JField("Right","Lforge/game/Direction;",true,JValue.Default("Lforge/game/Direction;"),null));
c.Add(new JField("LEFT","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Left"));
c.Add(new JField("RIGHT","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"Right"));
c.Add(new JField("listOfDirections","Ljava/util/List;",true,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("$VALUES","[Lforge/game/Direction;",true,JValue.Default("[Lforge/game/Direction;"),null));
c.Add(new JMethod(1846,"forge/game/Direction","values","()[Lforge/game/Direction;",9,0,1,new JHandler[]{},M1846));
c.Add(new JMethod(1847,"forge/game/Direction","valueOf","(Ljava/lang/String;)Lforge/game/Direction;",9,1,2,new JHandler[]{},M1847));
c.Add(new JMethod(1848,"forge/game/Direction","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M1848));
c.Add(new JMethod(1849,"forge/game/Direction","getDefaultDirection","()Lforge/game/Direction;",25,0,1,new JHandler[]{},M1849));
c.Add(new JMethod(1850,"forge/game/Direction","getListOfDirections","()Ljava/util/List;",9,0,1,new JHandler[]{},M1850));
c.Add(new JMethod(1851,"forge/game/Direction","isDefaultDirection","()Z",1,1,2,new JHandler[]{},M1851));
c.Add(new JMethod(1852,"forge/game/Direction","getShift","()I",1,1,1,new JHandler[]{},M1852));
c.Add(new JMethod(1853,"forge/game/Direction","getOtherDirection","()Lforge/game/Direction;",1,1,2,new JHandler[]{},M1853));
c.Add(new JMethod(1854,"forge/game/Direction","toString","()Ljava/lang/String;",1,1,2,new JHandler[]{},M1854));
c.Add(new JMethod(1855,"forge/game/Direction","$values","()[Lforge/game/Direction;",4106,0,4,new JHandler[]{},M1855));
c.Add(new JMethod(1856,"forge/game/Direction","<clinit>","()V",8,0,4,new JHandler[]{},M1856));
}

internal static JStep M1846(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/Direction","$VALUES","[Lforge/game/Direction;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/Direction","$VALUES","[Lforge/game/Direction;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/game/Direction;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/Direction;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1847(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/Direction")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/Direction"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1848(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1849(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/Direction","Left","Lforge/game/Direction;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/Direction","Left","Lforge/game/Direction;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1850(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/Direction","listOfDirections","Ljava/util/List;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/Direction","listOfDirections","Ljava/util/List;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1851(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Direction","getDefaultDirection","()Lforge/game/Direction;","invokestatic",4);}
case 4:{return rt.Call(f,"forge/game/Direction","equals","(Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1852(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Direction","isDefaultDirection","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?9:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(JValue.I(-1));f.Pc=10;continue;}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1853(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/Direction$1","$SwitchMap$forge$game$Direction","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/Direction$1","$SwitchMap$forge$game$Direction","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Direction","ordinal","()I","invokevirtual",7);}
case 7:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8;continue;}
case 8:{switch(f.Pop().Int){case 1:f.Pc=36;break;case 2:f.Pc=40;break;default:f.Pc=44;break;}continue;}
case 36:{if(!rt.StaticReady(f,"forge/game/Direction","Right","Lforge/game/Direction;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/Direction","Right","Lforge/game/Direction;"));f.Pc=39;continue;}
case 39:{return JStep.Return(f.Pop());}
case 40:{if(!rt.StaticReady(f,"forge/game/Direction","Left","Lforge/game/Direction;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/Direction","Left","Lforge/game/Direction;"));f.Pc=43;continue;}
case 43:{return JStep.Return(f.Pop());}
case 44:{f.Push(JValue.R(null));f.Pc=45;continue;}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1854(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/Direction$1","$SwitchMap$forge$game$Direction","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/Direction$1","$SwitchMap$forge$game$Direction","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/Direction","ordinal","()I","invokevirtual",7);}
case 7:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8;continue;}
case 8:{switch(f.Pop().Int){case 1:f.Pc=36;break;case 2:f.Pc=39;break;default:f.Pc=42;break;}continue;}
case 36:{f.Push(JValue.R(rt.String("Left")));f.Pc=38;continue;}
case 38:{return JStep.Return(f.Pop());}
case 39:{f.Push(JValue.R(rt.String("Right")));f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
case 42:{f.Push(JValue.R(null));f.Pc=43;continue;}
case 43:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1855(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(2));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Lforge/game/Direction;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/Direction","Left","Lforge/game/Direction;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/Direction","Left","Lforge/game/Direction;"));f.Pc=9;continue;}
case 9:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/Direction","Right","Lforge/game/Direction;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/Direction","Right","Lforge/game/Direction;"));f.Pc=15;continue;}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1856(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/Direction"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/Direction")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Left")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/Direction","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/game/Direction","Left","Lforge/game/Direction;"))return JStep.Continue;rt.PutStatic("forge/game/Direction","Left","Lforge/game/Direction;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/game/Direction"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/Direction")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Right")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/Direction","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/game/Direction","Right","Lforge/game/Direction;"))return JStep.Continue;rt.PutStatic("forge/game/Direction","Right","Lforge/game/Direction;",f.Pop());f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/Direction","$values","()[Lforge/game/Direction;","invokestatic",29);}
case 29:{if(!rt.StaticReady(f,"forge/game/Direction","$VALUES","[Lforge/game/Direction;"))return JStep.Continue;rt.PutStatic("forge/game/Direction","$VALUES","[Lforge/game/Direction;",f.Pop());f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/Direction","getDefaultDirection","()Lforge/game/Direction;","invokestatic",35);}
case 35:{return rt.Call(f,"forge/game/Direction","getDefaultDirection","()Lforge/game/Direction;","invokestatic",38);}
case 38:{return rt.Call(f,"forge/game/Direction","getOtherDirection","()Lforge/game/Direction;","invokevirtual",41);}
case 41:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;","invokestatic",44);}
case 44:{if(!rt.StaticReady(f,"forge/game/Direction","listOfDirections","Ljava/util/List;"))return JStep.Continue;rt.PutStatic("forge/game/Direction","listOfDirections","Ljava/util/List;",f.Pop());f.Pc=47;continue;}
case 47:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
