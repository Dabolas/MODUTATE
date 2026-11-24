// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C729{
internal static JClass Build(){var c=new JClass("forge/game/player/actions/ModeChoiceAction","forge/game/player/actions/PlayerAction",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("modeDescriptions","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JMethod(8841,"forge/game/player/actions/ModeChoiceAction","<init>","(Ljava/util/List;)V",1,2,3,new JHandler[]{},M8841));
c.Add(new JMethod(8842,"forge/game/player/actions/ModeChoiceAction","getModeDescriptions","()Ljava/util/List;",1,1,1,new JHandler[]{},M8842));
c.Add(new JMethod(8843,"forge/game/player/actions/ModeChoiceAction","appendDetails","(Ljava/lang/StringBuilder;)V",4,2,2,new JHandler[]{},M8843));
}

internal static JStep M8841(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String("Choose mode")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/actions/PlayerAction","<init>","(Lforge/game/GameEntityView;Ljava/lang/String;)V","invokespecial",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/actions/ModeChoiceAction","modeDescriptions","Ljava/util/List;",value);f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8842(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/actions/ModeChoiceAction","modeDescriptions","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8843(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String(" modes=")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/player/actions/ModeChoiceAction","modeDescriptions","Ljava/util/List;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",13);}
case 13:{f.StackOp("pop");f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
