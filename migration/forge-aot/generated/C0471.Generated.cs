// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C471{
internal static JClass Build(){var c=new JClass("forge/game/card/CardState$ReplacementEffectsCache","java/lang/Object",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("value","Lforge/util/collect/FCollection;",false,JValue.Default("Lforge/util/collect/FCollection;"),null));
c.Add(new JField("traits","Ljava/lang/Object;",false,JValue.Default("Ljava/lang/Object;"),null));
c.Add(new JField("traitsByText","Ljava/lang/Object;",false,JValue.Default("Ljava/lang/Object;"),null));
c.Add(new JField("keywords","Lforge/game/keyword/KeywordCollection;",false,JValue.Default("Lforge/game/keyword/KeywordCollection;"),null));
c.Add(new JField("flags","I",false,JValue.Default("I"),null));
c.Add(new JField("ownVersion","I",false,JValue.Default("I"),null));
c.Add(new JField("leftVersion","I",false,JValue.Default("I"),null));
c.Add(new JField("rightVersion","I",false,JValue.Default("I"),null));
c.Add(new JMethod(5404,"forge/game/card/CardState$ReplacementEffectsCache","<init>","(Lforge/util/collect/FCollection;Ljava/lang/Object;Ljava/lang/Object;Lforge/game/keyword/KeywordCollection;IIII)V",0,9,2,new JHandler[]{},M5404));
}

internal static JStep M5404(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState$ReplacementEffectsCache","value","Lforge/util/collect/FCollection;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState$ReplacementEffectsCache","traits","Ljava/lang/Object;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState$ReplacementEffectsCache","traitsByText","Ljava/lang/Object;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState$ReplacementEffectsCache","keywords","Lforge/game/keyword/KeywordCollection;",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState$ReplacementEffectsCache","flags","I",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[6]);f.Pc=34;continue;}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState$ReplacementEffectsCache","ownVersion","I",value);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[7]);f.Pc=40;continue;}
case 40:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState$ReplacementEffectsCache","leftVersion","I",value);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[8]);f.Pc=46;continue;}
case 46:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardState$ReplacementEffectsCache","rightVersion","I",value);f.Pc=49;continue;}
case 49:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
