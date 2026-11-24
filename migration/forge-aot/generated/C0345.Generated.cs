// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C345{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/PermanentCreatureEffect","forge/game/ability/effects/PermanentEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3532,"forge/game/ability/effects/PermanentCreatureEffect","<init>","()V",1,1,1,new JHandler[]{},M3532));
c.Add(new JMethod(3533,"forge/game/ability/effects/PermanentCreatureEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,4,4,new JHandler[]{},M3533));
}

internal static JStep M3532(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/PermanentEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3533(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCardState","()Lforge/game/card/CardState;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/CardState","getName","()Ljava/lang/String;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",21);}
case 21:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",24);}
case 24:{f.Push(JValue.R(rt.String(" - ")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",32);}
case 32:{f.Push(JValue.R(rt.String("lblCreature")));f.Pc=34;continue;}
case 34:{f.Push(JValue.I(0));f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",41);}
case 41:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",44);}
case 44:{f.Push(JValue.R(rt.String(" ")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",49);}
case 49:{f.StackOp("pop");f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("SetPower")));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/card/CardState","getBasePowerString","()Ljava/lang/String;","invokevirtual",58);}
case 58:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",61);}
case 61:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",64);}
case 64:{f.StackOp("pop");f.Pc=65;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String(" / ")));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",71);}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("SetToughness")));f.Pc=74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/card/CardState","getBaseToughnessString","()Ljava/lang/String;","invokevirtual",78);}
case 78:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",81);}
case 81:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",84);}
case 84:{f.StackOp("pop");f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",89);}
case 89:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
