// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C422{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/UnattachEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3801,"forge/game/ability/effects/UnattachEffect","<init>","()V",1,1,1,new JHandler[]{},M3801));
c.Add(new JMethod(3802,"forge/game/ability/effects/UnattachEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,3,2,new JHandler[]{},M3802));
c.Add(new JMethod(3803,"forge/game/ability/effects/UnattachEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,6,3,new JHandler[]{},M3803));
}

internal static JStep M3801(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3802(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Unattach ")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/ability/effects/UnattachEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",20);}
case 20:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",23);}
case 23:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",31);}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3803(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/UnattachEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",12);}
case 12:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?103:25;continue;}
case 25:{f.Push(f.Locals[3]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[4]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int!=0?47:44;continue;}
case 44:{f.Pc=16;continue;}
case 47:{f.Push(f.Locals[2]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(null));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",54);}
case 54:{f.Locals[5]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{f.Pc=f.Pop().Reference==null?16:61;continue;}
case 61:{f.Push(f.Locals[4]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int!=0?74:71;continue;}
case 71:{f.Pc=16;continue;}
case 74:{f.Push(f.Locals[5]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/card/Card","isAttachment","()Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int==0?100:82;continue;}
case 82:{f.Push(f.Locals[5]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/card/Card","isAttachedToEntity","()Z","invokevirtual",87);}
case 87:{f.Pc=f.Pop().Int==0?100:90;continue;}
case 90:{f.Push(f.Locals[5]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[5]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/card/Card","getEntityAttachedTo","()Lforge/game/GameEntity;","invokevirtual",97);}
case 97:{return rt.Call(f,"forge/game/card/Card","unattachFromEntity","(Lforge/game/GameEntity;)V","invokevirtual",100);}
case 100:{f.Pc=16;continue;}
case 103:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
