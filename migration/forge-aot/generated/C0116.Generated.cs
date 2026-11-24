// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C116{
internal static JClass Build(){var c=new JClass("forge/deck/generation/DeckGeneratorBase$MatchColorIdentity","java/lang/Object",new string[]{"java/util/function/Predicate"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("allowedColor","Lforge/card/ColorSet;",false,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JMethod(1715,"forge/deck/generation/DeckGeneratorBase$MatchColorIdentity","<init>","(Lforge/card/ColorSet;)V",1,2,2,new JHandler[]{},M1715));
c.Add(new JMethod(1716,"forge/deck/generation/DeckGeneratorBase$MatchColorIdentity","test","(Lforge/card/CardRules;)Z",1,3,2,new JHandler[]{},M1716));
c.Add(new JMethod(1717,"forge/deck/generation/DeckGeneratorBase$MatchColorIdentity","test","(Ljava/lang/Object;)Z",4161,2,2,new JHandler[]{},M1717));
}

internal static JStep M1715(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/generation/DeckGeneratorBase$MatchColorIdentity","allowedColor","Lforge/card/ColorSet;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1716(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardRules","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/mana/ManaCost","isPureGeneric","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int!=0?33:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(rt.GetField(f.Pop(),"forge/deck/generation/DeckGeneratorBase$MatchColorIdentity","allowedColor","Lforge/card/ColorSet;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/card/CardRules","getColorIdentity","()Lforge/card/ColorSet;","invokevirtual",20);}
case 20:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/card/ColorSet","containsAllColorsFrom","(I)Z","invokevirtual",26);}
case 26:{f.Pc=f.Pop().Int==0?33:29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{f.Pc=34;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1717(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/deck/generation/DeckGeneratorBase$MatchColorIdentity","test","(Lforge/card/CardRules;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
