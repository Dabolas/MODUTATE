// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C570{
internal static JClass Build(){var c=new JClass("forge/game/cost/PaymentDecision","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("c","I",false,JValue.Default("I"),null));
c.Add(new JField("type","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("colors","Lforge/card/ColorSet;",false,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JField("cards","Lforge/game/card/CardCollection;",false,JValue.Default("Lforge/game/card/CardCollection;"),null));
c.Add(new JField("mana","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("players","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("sp","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("counterTable","Lforge/game/GameEntityCounterTable;",false,JValue.Default("Lforge/game/GameEntityCounterTable;"),null));
c.Add(new JField("matrix","Lforge/game/mana/ManaConversionMatrix;",false,JValue.Default("Lforge/game/mana/ManaConversionMatrix;"),null));
c.Add(new JMethod(6741,"forge/game/cost/PaymentDecision","<init>","(I)V",1,2,6,new JHandler[]{},M6741));
c.Add(new JMethod(6742,"forge/game/cost/PaymentDecision","<init>","(Ljava/lang/Iterable;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lforge/game/GameEntityCounterTable;)V",2,6,3,new JHandler[]{},M6742));
c.Add(new JMethod(6743,"forge/game/cost/PaymentDecision","<init>","(Lforge/game/card/Card;)V",2,2,6,new JHandler[]{},M6743));
c.Add(new JMethod(6744,"forge/game/cost/PaymentDecision","<init>","(Ljava/lang/String;)V",1,2,6,new JHandler[]{},M6744));
c.Add(new JMethod(6745,"forge/game/cost/PaymentDecision","<init>","(Lforge/card/ColorSet;)V",1,2,6,new JHandler[]{},M6745));
c.Add(new JMethod(6746,"forge/game/cost/PaymentDecision","card","(Lforge/game/card/Card;)Lforge/game/cost/PaymentDecision;",9,1,3,new JHandler[]{},M6746));
c.Add(new JMethod(6747,"forge/game/cost/PaymentDecision","card","(Lforge/game/card/Card;I)Lforge/game/cost/PaymentDecision;",9,3,3,new JHandler[]{},M6747));
c.Add(new JMethod(6748,"forge/game/cost/PaymentDecision","number","(I)Lforge/game/cost/PaymentDecision;",9,1,3,new JHandler[]{},M6748));
c.Add(new JMethod(6749,"forge/game/cost/PaymentDecision","card","(Ljava/lang/Iterable;)Lforge/game/cost/PaymentDecision;",9,1,7,new JHandler[]{},M6749));
c.Add(new JMethod(6750,"forge/game/cost/PaymentDecision","card","(Ljava/lang/Iterable;I)Lforge/game/cost/PaymentDecision;",9,3,7,new JHandler[]{},M6750));
c.Add(new JMethod(6751,"forge/game/cost/PaymentDecision","mana","(Ljava/util/List;)Lforge/game/cost/PaymentDecision;",9,1,7,new JHandler[]{},M6751));
c.Add(new JMethod(6752,"forge/game/cost/PaymentDecision","toString","()Ljava/lang/String;",1,1,5,new JHandler[]{},M6752));
c.Add(new JMethod(6753,"forge/game/cost/PaymentDecision","type","(Ljava/lang/String;)Lforge/game/cost/PaymentDecision;",9,1,3,new JHandler[]{},M6753));
c.Add(new JMethod(6754,"forge/game/cost/PaymentDecision","colors","(Lforge/card/ColorSet;)Lforge/game/cost/PaymentDecision;",9,1,3,new JHandler[]{},M6754));
c.Add(new JMethod(6755,"forge/game/cost/PaymentDecision","players","(Ljava/util/List;)Lforge/game/cost/PaymentDecision;",9,1,7,new JHandler[]{},M6755));
c.Add(new JMethod(6756,"forge/game/cost/PaymentDecision","spellabilities","(Ljava/util/List;)Lforge/game/cost/PaymentDecision;",9,1,7,new JHandler[]{},M6756));
c.Add(new JMethod(6757,"forge/game/cost/PaymentDecision","counters","(Lforge/game/GameEntityCounterTable;)Lforge/game/cost/PaymentDecision;",9,1,7,new JHandler[]{},M6757));
}

internal static JStep M6741(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/cost/PaymentDecision","<init>","(Ljava/lang/Iterable;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lforge/game/GameEntityCounterTable;)V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/PaymentDecision","c","I",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6742(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/PaymentDecision","c","I",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",17);}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/PaymentDecision","cards","Lforge/game/card/CardCollection;",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(null));f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/PaymentDecision","matrix","Lforge/game/mana/ManaConversionMatrix;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Pc=f.Pop().Reference==null?38:29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/PaymentDecision","cards","Lforge/game/card/CardCollection;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/lang/Iterable;)Z","invokevirtual",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/PaymentDecision","mana","Ljava/util/List;",value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/PaymentDecision","players","Ljava/util/List;",value);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/PaymentDecision","sp","Ljava/util/List;",value);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/PaymentDecision","counterTable","Lforge/game/GameEntityCounterTable;",value);f.Pc=60;continue;}
case 60:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6743(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/cost/PaymentDecision","<init>","(Ljava/lang/Iterable;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lforge/game/GameEntityCounterTable;)V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/PaymentDecision","cards","Lforge/game/card/CardCollection;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",17);}
case 17:{f.StackOp("pop");f.Pc=18;continue;}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6744(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/cost/PaymentDecision","<init>","(Ljava/lang/Iterable;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lforge/game/GameEntityCounterTable;)V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/PaymentDecision","type","Ljava/lang/String;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6745(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(null));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(null));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/cost/PaymentDecision","<init>","(Ljava/lang/Iterable;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lforge/game/GameEntityCounterTable;)V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/PaymentDecision","colors","Lforge/card/ColorSet;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6746(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/cost/PaymentDecision"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/PaymentDecision")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/cost/PaymentDecision","<init>","(Lforge/game/card/Card;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6747(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/cost/PaymentDecision"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/PaymentDecision")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/cost/PaymentDecision","<init>","(Lforge/game/card/Card;)V","invokespecial",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/PaymentDecision","c","I",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6748(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/cost/PaymentDecision"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/PaymentDecision")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/cost/PaymentDecision","<init>","(I)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6749(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/cost/PaymentDecision"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/PaymentDecision")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/PaymentDecision","<init>","(Ljava/lang/Iterable;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lforge/game/GameEntityCounterTable;)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6750(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/cost/PaymentDecision"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/PaymentDecision")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/PaymentDecision","<init>","(Ljava/lang/Iterable;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lforge/game/GameEntityCounterTable;)V","invokespecial",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/PaymentDecision","c","I",value);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6751(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/cost/PaymentDecision"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/PaymentDecision")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/PaymentDecision","<init>","(Ljava/lang/Iterable;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lforge/game/GameEntityCounterTable;)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6752(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(3));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Payment Decision:")));f.Pc=8;continue;}
case 8:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=9;continue;}
case 9:{f.StackOp("dup");f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/PaymentDecision","c","I"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",18);}
case 18:{f.Push(JValue.R(rt.String(",")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/util/TextUtil","addSuffix","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",23);}
case 23:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=24;continue;}
case 24:{f.StackOp("dup");f.Pc=25;continue;}
case 25:{f.Push(JValue.I(2));f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/PaymentDecision","cards","Lforge/game/card/CardCollection;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/CardCollection","toString","()Ljava/lang/String;","invokevirtual",33);}
case 33:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",37);}
case 37:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6753(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/cost/PaymentDecision"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/PaymentDecision")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/cost/PaymentDecision","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6754(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/cost/PaymentDecision"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/PaymentDecision")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/cost/PaymentDecision","<init>","(Lforge/card/ColorSet;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6755(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/cost/PaymentDecision"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/PaymentDecision")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/PaymentDecision","<init>","(Ljava/lang/Iterable;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lforge/game/GameEntityCounterTable;)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6756(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/cost/PaymentDecision"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/PaymentDecision")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/PaymentDecision","<init>","(Ljava/lang/Iterable;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lforge/game/GameEntityCounterTable;)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6757(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/cost/PaymentDecision"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/PaymentDecision")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/cost/PaymentDecision","<init>","(Ljava/lang/Iterable;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lforge/game/GameEntityCounterTable;)V","invokespecial",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
