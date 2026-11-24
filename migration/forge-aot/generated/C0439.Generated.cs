// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C439{
internal static JClass Build(){var c=new JClass("forge/game/card/Card$ParsedRestriction","java/lang/Object",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("MAX_CACHE_SIZE","I",true,JValue.I(8192),null));
c.Add(new JField("CACHE","Ljava/util/concurrent/ConcurrentHashMap;",true,JValue.Default("Ljava/util/concurrent/ConcurrentHashMap;"),null));
c.Add(new JField("type","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("negated","Z",false,JValue.Default("Z"),null));
c.Add(new JField("props","[Ljava/lang/String;",false,JValue.Default("[Ljava/lang/String;"),null));
c.Add(new JMethod(4875,"forge/game/card/Card$ParsedRestriction","<init>","(Ljava/lang/String;)V",2,4,4,new JHandler[]{},M4875));
c.Add(new JMethod(4876,"forge/game/card/Card$ParsedRestriction","get","(Ljava/lang/String;)Lforge/game/card/Card$ParsedRestriction;",8,2,3,new JHandler[]{},M4876));
c.Add(new JMethod(4877,"forge/game/card/Card$ParsedRestriction","<clinit>","()V",8,0,2,new JHandler[]{},M4877));
}

internal static JStep M4875(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(46));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[2]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Int>=0?19:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Pc=25;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(0));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",25);}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("!")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?49:35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/Card$ParsedRestriction","negated","Z",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[3]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",45);}
case 45:{f.Locals[3]=f.Pop();f.Pc=46;continue;}
case 46:{f.Pc=54;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/Card$ParsedRestriction","negated","Z",value);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[3]);f.Pc=56;continue;}
case 56:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/Card$ParsedRestriction","type","Ljava/lang/String;",value);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Pc=f.Pop().Int>=0?68:64;continue;}
case 64:{f.Push(JValue.R(null));f.Pc=65;continue;}
case 65:{f.Pc=80;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{f.Push(JValue.I(1));f.Pc=71;continue;}
case 71:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",75);}
case 75:{f.Push(JValue.R(rt.String("\\+")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",80);}
case 80:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/Card$ParsedRestriction","props","[Ljava/lang/String;",value);f.Pc=83;continue;}
case 83:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4876(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/card/Card$ParsedRestriction","CACHE","Ljava/util/concurrent/ConcurrentHashMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/Card$ParsedRestriction","CACHE","Ljava/util/concurrent/ConcurrentHashMap;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",7);}
case 7:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card$ParsedRestriction"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=10;continue;}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference!=null?51:15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/game/card/Card$ParsedRestriction","CACHE","Ljava/util/concurrent/ConcurrentHashMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/Card$ParsedRestriction","CACHE","Ljava/util/concurrent/ConcurrentHashMap;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","size","()I","invokevirtual",21);}
case 21:{f.Push(JValue.I(8192));f.Pc=24;continue;}
case 24:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?33:27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/game/card/Card$ParsedRestriction","CACHE","Ljava/util/concurrent/ConcurrentHashMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/Card$ParsedRestriction","CACHE","Ljava/util/concurrent/ConcurrentHashMap;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","clear","()V","invokevirtual",33);}
case 33:{if(!rt.EnsureInitialized(f,"forge/game/card/Card$ParsedRestriction"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/Card$ParsedRestriction")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/Card$ParsedRestriction","<init>","(Ljava/lang/String;)V","invokespecial",41);}
case 41:{f.Locals[1]=f.Pop();f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/game/card/Card$ParsedRestriction","CACHE","Ljava/util/concurrent/ConcurrentHashMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/Card$ParsedRestriction","CACHE","Ljava/util/concurrent/ConcurrentHashMap;"));f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokevirtual",50);}
case 50:{f.StackOp("pop");f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M4877(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentHashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","<init>","()V","invokespecial",7);}
case 7:{if(!rt.StaticReady(f,"forge/game/card/Card$ParsedRestriction","CACHE","Ljava/util/concurrent/ConcurrentHashMap;"))return JStep.Continue;rt.PutStatic("forge/game/card/Card$ParsedRestriction","CACHE","Ljava/util/concurrent/ConcurrentHashMap;",f.Pop());f.Pc=10;continue;}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
