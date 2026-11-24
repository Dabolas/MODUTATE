// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C728{
internal static JClass Build(){var c=new JClass("forge/game/player/actions/ManaComboAction","forge/game/player/actions/PlayerAction",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("manaCombo","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(8838,"forge/game/player/actions/ManaComboAction","<init>","(Ljava/util/Map;)V",1,2,4,new JHandler[]{},M8838));
c.Add(new JMethod(8839,"forge/game/player/actions/ManaComboAction","getManaCombo","()Ljava/util/Map;",1,1,1,new JHandler[]{},M8839));
c.Add(new JMethod(8840,"forge/game/player/actions/ManaComboAction","appendDetails","(Ljava/lang/StringBuilder;)V",4,2,2,new JHandler[]{},M8840));
}

internal static JStep M8838(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.String("Choose mana combination")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/actions/PlayerAction","<init>","(Lforge/game/GameEntityView;Ljava/lang/String;)V","invokespecial",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"java/util/LinkedHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/LinkedHashMap")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/LinkedHashMap","<init>","(Ljava/util/Map;)V","invokespecial",16);}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/player/actions/ManaComboAction","manaCombo","Ljava/util/Map;",value);f.Pc=19;continue;}
case 19:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8839(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/player/actions/ManaComboAction","manaCombo","Ljava/util/Map;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M8840(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String(" manaCombo=")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/game/player/actions/ManaComboAction","manaCombo","Ljava/util/Map;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",13);}
case 13:{f.StackOp("pop");f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
