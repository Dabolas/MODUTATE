// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C196{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/AdvanceCrankEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3004,"forge/game/ability/effects/AdvanceCrankEffect","<init>","()V",1,1,1,new JHandler[]{},M3004));
c.Add(new JMethod(3005,"forge/game/ability/effects/AdvanceCrankEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,2,new JHandler[]{},M3005));
c.Add(new JMethod(3006,"forge/game/ability/effects/AdvanceCrankEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,2,2,new JHandler[]{},M3006));
}

internal static JStep M3004(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3005(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/AdvanceCrankEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?25:22;continue;}
case 22:{f.Push(JValue.R(rt.String("")));f.Pc=24;continue;}
case 24:{return JStep.Return(f.Pop());}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",30);}
case 30:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",33);}
case 33:{f.StackOp("pop");f.Pc=34;continue;}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String(" advances their CRANK! counter to the next sprocket and cranks any number of that sprocket's contraptions")));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",40);}
case 40:{f.StackOp("pop");f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",45);}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3006(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/AdvanceCrankEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",4);}
case 4:{return rt.DynamicCall(f,"forge/game/ability/effects/AdvanceCrankEffect:3006:4:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Consumer;",9);}
case 9:{return rt.Call(f,"forge/game/player/PlayerCollection","forEach","(Ljava/util/function/Consumer;)V","invokevirtual",12);}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
