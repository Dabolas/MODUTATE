// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C679{
internal static JClass Build(){var c=new JClass("forge/game/mana/ManaConversionMatrix","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("identityMatrix","[B",true,JValue.Default("[B"),null));
c.Add(new JField("colorConversionMatrix","[B",false,JValue.Default("[B"),null));
c.Add(new JField("colorRestrictionMatrix","[B",false,JValue.Default("[B"),null));
c.Add(new JField("snowForColor","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(7711,"forge/game/mana/ManaConversionMatrix","<init>","()V",1,1,2,new JHandler[]{},M7711));
c.Add(new JMethod(7712,"forge/game/mana/ManaConversionMatrix","isSnowForColor","()Z",1,1,1,new JHandler[]{},M7712));
c.Add(new JMethod(7713,"forge/game/mana/ManaConversionMatrix","setSnowForColor","(Z)V",1,2,2,new JHandler[]{},M7713));
c.Add(new JMethod(7714,"forge/game/mana/ManaConversionMatrix","getPossibleColorUses","(B)B",1,5,3,new JHandler[]{},M7714));
c.Add(new JMethod(7715,"forge/game/mana/ManaConversionMatrix","adjustColorReplacement","(BBZ)V",1,5,4,new JHandler[]{},M7715));
c.Add(new JMethod(7716,"forge/game/mana/ManaConversionMatrix","applyCardMatrix","(Lforge/game/mana/ManaConversionMatrix;)V",1,3,5,new JHandler[]{},M7716));
c.Add(new JMethod(7717,"forge/game/mana/ManaConversionMatrix","restoreColorReplacements","()V",1,1,5,new JHandler[]{},M7717));
c.Add(new JMethod(7718,"forge/game/mana/ManaConversionMatrix","<clinit>","()V",8,0,4,new JHandler[]{},M7718));
}

internal static JStep M7711(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/card/mana/ManaAtom","MANATYPES","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaAtom","MANATYPES","[B"));f.Pc=8;continue;}
case 8:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.NewArray("B",f.Pop().Int)));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaConversionMatrix","colorConversionMatrix","[B",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/card/mana/ManaAtom","MANATYPES","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/mana/ManaAtom","MANATYPES","[B"));f.Pc=18;continue;}
case 18:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.NewArray("B",f.Pop().Int)));f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaConversionMatrix","colorRestrictionMatrix","[B",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaConversionMatrix","snowForColor","Z",value);f.Pc=29;continue;}
case 29:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7712(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaConversionMatrix","snowForColor","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7713(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaConversionMatrix","snowForColor","Z",value);f.Pc=5;continue;}
case 5:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7714(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/mana/ManaAtom","getIndexOfFirstManaType","(B)I","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Int>=0?18:9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/game/mana/ManaConversionMatrix","identityMatrix","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/mana/ManaConversionMatrix","identityMatrix","[B"));f.Pc=12;continue;}
case 12:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaConversionMatrix","colorConversionMatrix","[B"));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=26;continue;}
case 26:{f.Locals[4]=f.Pop();f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaConversionMatrix","colorRestrictionMatrix","[B"));f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=36;continue;}
case 36:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=37;continue;}
case 37:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=38;continue;}
case 38:{f.Locals[4]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[4]);f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7715(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/mana/ManaAtom","getIndexOfFirstManaType","(B)I","invokestatic",4);}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[4]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int>=0?20:11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/game/mana/ManaConversionMatrix","identityMatrix","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/mana/ManaConversionMatrix","identityMatrix","[B"));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=17;continue;}
case 17:{f.Pc=22;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Int==0?43:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaConversionMatrix","colorConversionMatrix","[B"));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{f.StackOp("dup2");f.Pc=35;continue;}
case 35:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=38;continue;}
case 38:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=39;continue;}
case 39:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=40;continue;}
case 40:{f.Pc=55;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaConversionMatrix","colorRestrictionMatrix","[B"));f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{f.StackOp("dup2");f.Pc=50;continue;}
case 50:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=53;continue;}
case 53:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7716(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaConversionMatrix","colorConversionMatrix","[B"));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=8;continue;}
case 8:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?33:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaConversionMatrix","colorConversionMatrix","[B"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.StackOp("dup2");f.Pc=17;continue;}
case 17:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaConversionMatrix","colorConversionMatrix","[B"));f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=24;continue;}
case 24:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=25;continue;}
case 25:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=26;continue;}
case 26:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=27;continue;}
case 27:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=30;continue;}
case 30:{f.Pc=2;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{f.Locals[2]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaConversionMatrix","colorRestrictionMatrix","[B"));f.Pc=40;continue;}
case 40:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=41;continue;}
case 41:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?66:44;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaConversionMatrix","colorRestrictionMatrix","[B"));f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{f.StackOp("dup2");f.Pc=50;continue;}
case 50:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaConversionMatrix","colorRestrictionMatrix","[B"));f.Pc=55;continue;}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=57;continue;}
case 57:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=58;continue;}
case 58:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=59;continue;}
case 59:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=60;continue;}
case 60:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=63;continue;}
case 63:{f.Pc=35;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/mana/ManaConversionMatrix","isSnowForColor","()Z","invokevirtual",71);}
case 71:{return rt.Call(f,"forge/game/mana/ManaConversionMatrix","setSnowForColor","(Z)V","invokevirtual",74);}
case 74:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7717(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/mana/ManaConversionMatrix","identityMatrix","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/mana/ManaConversionMatrix","identityMatrix","[B"));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(0));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaConversionMatrix","colorConversionMatrix","[B"));f.Pc=8;continue;}
case 8:{f.Push(JValue.I(0));f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaConversionMatrix","colorConversionMatrix","[B"));f.Pc=13;continue;}
case 13:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/System","arraycopy","(Ljava/lang/Object;ILjava/lang/Object;II)V","invokestatic",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaConversionMatrix","colorRestrictionMatrix","[B"));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(63));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Arrays","fill","([BB)V","invokestatic",26);}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaConversionMatrix","snowForColor","Z",value);f.Pc=31;continue;}
case 31:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7718(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(6));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("B",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(1));f.Pc=7;continue;}
case 7:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{f.Push(JValue.I(1));f.Pc=10;continue;}
case 10:{f.Push(JValue.I(2));f.Pc=11;continue;}
case 11:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(JValue.I(2));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(4));f.Pc=15;continue;}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(3));f.Pc=18;continue;}
case 18:{f.Push(JValue.I(8));f.Pc=20;continue;}
case 20:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{f.Push(JValue.I(4));f.Pc=23;continue;}
case 23:{f.Push(JValue.I(16));f.Pc=25;continue;}
case 25:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{f.Push(JValue.I(5));f.Pc=28;continue;}
case 28:{f.Push(JValue.I(32));f.Pc=30;continue;}
case 30:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/mana/ManaConversionMatrix","identityMatrix","[B"))return JStep.Continue;rt.PutStatic("forge/game/mana/ManaConversionMatrix","identityMatrix","[B",f.Pop());f.Pc=34;continue;}
case 34:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
