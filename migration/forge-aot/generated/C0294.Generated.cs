// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C294{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DrainManaEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3360,"forge/game/ability/effects/DrainManaEffect","<init>","()V",1,1,1,new JHandler[]{},M3360));
c.Add(new JMethod(3361,"forge/game/ability/effects/DrainManaEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,3,2,new JHandler[]{},M3361));
c.Add(new JMethod(3362,"forge/game/ability/effects/DrainManaEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,9,5,new JHandler[]{},M3362));
}

internal static JStep M3360(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3361(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/effects/DrainManaEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",13);}
case 13:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",16);}
case 16:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",19);}
case 19:{f.StackOp("pop");f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String(" loses all unspent mana.")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",26);}
case 26:{f.StackOp("pop");f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",31);}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3362(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/ability/effects/DrainManaEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",25);}
case 25:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",28);}
case 28:{f.Locals[5]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[5]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",37);}
case 37:{f.Pc=f.Pop().Int==0?131:40;continue;}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{f.Locals[6]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[6]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int!=0?63:60;continue;}
case 60:{f.Pc=30;continue;}
case 63:{f.Push(f.Locals[6]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",68);}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/mana/ManaPool","clearPool","(Z)Ljava/util/List;","invokevirtual",72);}
case 72:{f.Locals[7]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[3]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[7]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/staticability/StaticAbilityUnspentMana","hasManaBurn","(Lforge/game/player/Player;)Z","invokestatic",88);}
case 88:{f.Pc=f.Pop().Int==0?128:91;continue;}
case 91:{f.Push(f.Locals[6]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[7]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",100);}
case 100:{f.Push(JValue.I(0));f.Pc=101;continue;}
case 101:{f.Push(JValue.I(1));f.Pc=102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/player/Player","loseLife","(IZZLforge/game/spellability/SpellAbility;)I","invokevirtual",106);}
case 106:{f.Locals[8]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[8]);f.Pc=110;continue;}
case 110:{f.Pc=f.Pop().Int<=0?128:113;continue;}
case 113:{f.Push(f.Locals[4]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[6]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[8]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",122);}
case 122:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",127);}
case 127:{f.StackOp("pop");f.Pc=128;continue;}
case 128:{f.Pc=30;continue;}
case 131:{f.Push(f.Locals[4]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",138);}
case 138:{f.Pc=f.Pop().Int!=0?161:141;continue;}
case 141:{f.Push(f.Locals[4]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPIMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",146);}
case 146:{f.Locals[5]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[2]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",152);}
case 152:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","LifeLostAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","LifeLostAll","Lforge/game/trigger/TriggerType;"));f.Pc=155;continue;}
case 155:{f.Push(f.Locals[5]);f.Pc=157;continue;}
case 157:{f.Push(JValue.I(0));f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",161);}
case 161:{f.Push(f.Locals[1]);f.Pc=162;continue;}
case 162:{f.Push(JValue.R(rt.String("DrainMana")));f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",167);}
case 167:{f.Pc=f.Pop().Int==0?181:170;continue;}
case 170:{f.Push(f.Locals[1]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",174);}
case 174:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",177);}
case 177:{f.Push(f.Locals[3]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/mana/ManaPool","addMana","(Ljava/lang/Iterable;)V","invokevirtual",181);}
case 181:{f.Push(f.Locals[1]);f.Pc=182;continue;}
case 182:{f.Push(JValue.R(rt.String("RememberDrainedMana")));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",187);}
case 187:{f.Pc=f.Pop().Int==0?206:190;continue;}
case 190:{f.Push(f.Locals[1]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",194);}
case 194:{f.Push(f.Locals[3]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",200);}
case 200:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",203);}
case 203:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",206);}
case 206:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
