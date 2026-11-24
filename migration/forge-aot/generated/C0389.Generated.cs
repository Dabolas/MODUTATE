// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C389{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/RollDiceEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3673,"forge/game/ability/effects/RollDiceEffect","<init>","()V",1,1,1,new JHandler[]{},M3673));
c.Add(new JMethod(3674,"forge/game/ability/effects/RollDiceEffect","makeFormatedDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",9,10,3,new JHandler[]{},M3674));
c.Add(new JMethod(3675,"forge/game/ability/effects/RollDiceEffect","getResultsList","(Ljava/util/List;)Ljava/util/List;",9,4,5,new JHandler[]{},M3675));
c.Add(new JMethod(3676,"forge/game/ability/effects/RollDiceEffect","getNaturalResults","(Ljava/util/List;)Ljava/util/List;",9,4,2,new JHandler[]{},M3676));
c.Add(new JMethod(3677,"forge/game/ability/effects/RollDiceEffect","getFinalResults","(Ljava/util/List;)Ljava/util/List;",9,4,2,new JHandler[]{},M3677));
c.Add(new JMethod(3678,"forge/game/ability/effects/RollDiceEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,6,new JHandler[]{},M3678));
c.Add(new JMethod(3679,"forge/game/ability/effects/RollDiceEffect","rollDiceForPlayer","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;II)I",9,5,8,new JHandler[]{},M3679));
c.Add(new JMethod(3680,"forge/game/ability/effects/RollDiceEffect","rollDiceForPlayerToVisitAttractions","(Lforge/game/player/Player;)I",9,1,8,new JHandler[]{},M3680));
c.Add(new JMethod(3681,"forge/game/ability/effects/RollDiceEffect","rollDiceForPlayer","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;IIIILjava/util/List;Z)I",10,34,9,new JHandler[]{},M3681));
c.Add(new JMethod(3682,"forge/game/ability/effects/RollDiceEffect","getRerollCards","(Lforge/game/player/Player;Ljava/lang/String;)Lforge/game/card/CardCollection;",9,3,2,new JHandler[]{},M3682));
c.Add(new JMethod(3683,"forge/game/ability/effects/RollDiceEffect","getIncrementCards","(Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;",9,11,4,new JHandler[]{},M3683));
c.Add(new JMethod(3684,"forge/game/ability/effects/RollDiceEffect","rollAction","(IIILjava/util/List;Ljava/util/List;Ljava/util/Map;Ljava/util/Set;Lforge/game/player/Player;Ljava/util/Map;)Ljava/util/List;",10,15,5,new JHandler[]{},M3684));
c.Add(new JMethod(3685,"forge/game/ability/effects/RollDiceEffect","resolveSub","(Lforge/game/spellability/SpellAbility;I)V",10,8,2,new JHandler[]{},M3685));
c.Add(new JMethod(3686,"forge/game/ability/effects/RollDiceEffect","rollDice","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;II)I",2,14,9,new JHandler[]{},M3686));
c.Add(new JMethod(3687,"forge/game/ability/effects/RollDiceEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,11,5,new JHandler[]{},M3687));
c.Add(new JMethod(3688,"forge/game/ability/effects/RollDiceEffect","rerollDice","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;I)V",2,10,9,new JHandler[]{},M3688));
c.Add(new JMethod(3689,"forge/game/ability/effects/RollDiceEffect","lambda$getRerollCards$0","(Lforge/game/card/Card;)Z",4106,4,2,new JHandler[]{},M3689));
}

internal static JStep M3673(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3674(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("ResultSubAbilities")));f.Pc=10;continue;}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("ResultSubAbilities")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?105:20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(JValue.R(rt.String("ResultSubAbilities")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",26);}
case 26:{f.Push(JValue.R(rt.String(",")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",31);}
case 31:{f.Locals[3]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=38;continue;}
case 38:{f.Locals[5]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{f.Locals[6]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[6]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?105:50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[6]);f.Pc=54;continue;}
case 54:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=55;continue;}
case 55:{f.Locals[7]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[7]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String(":")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",64);}
case 64:{f.Locals[8]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[8]);f.Pc=69;continue;}
case 69:{f.Push(JValue.I(0));f.Pc=70;continue;}
case 70:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",74);}
case 74:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDescription","()Ljava/lang/String;","invokevirtual",77);}
case 77:{f.Locals[9]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[9]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int!=0?99:87;continue;}
case 87:{f.Push(f.Locals[1]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String("\n")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",93);}
case 93:{f.Push(f.Locals[9]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",98);}
case 98:{f.StackOp("pop");f.Pc=99;continue;}
case 99:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=102;continue;}
case 102:{f.Pc=43;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",109);}
case 109:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3675(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?56:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",36);}
case 36:{f.Locals[3]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/RollDiceEffect$DieRollResult")));f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult","<init>","(II)V","invokespecial",47);}
case 47:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Pc=15;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3676(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?51:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/ability/effects/RollDiceEffect$DieRollResult"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult","getNaturalValue","()I","invokevirtual",39);}
case 39:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",42);}
case 42:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",47);}
case 47:{f.StackOp("pop");f.Pc=48;continue;}
case 48:{f.Pc=15;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3677(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?51:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/ability/effects/RollDiceEffect$DieRollResult"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult","getModifiedValue","()I","invokevirtual",39);}
case 39:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",42);}
case 42:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",47);}
case 47:{f.StackOp("pop");f.Pc=48;continue;}
case 48:{f.Pc=15;continue;}
case 51:{f.Push(f.Locals[1]);f.Pc=52;continue;}
case 52:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3678(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("ToVisitYourAttractions")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?69:14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",18);}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?43:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",34);}
case 34:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?43:40;continue;}
case 40:{f.Push(JValue.R(rt.String("Roll to Visit Your Attractions.")));f.Pc=42;continue;}
case 42:{return JStep.Return(f.Pop());}
case 43:{f.Push(JValue.R(rt.String("%s %s to visit their Attractions.")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(2));f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=49;continue;}
case 49:{f.StackOp("dup");f.Pc=50;continue;}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",55);}
case 55:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=56;continue;}
case 56:{f.StackOp("dup");f.Pc=57;continue;}
case 57:{f.Push(JValue.I(1));f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{f.Push(JValue.R(rt.String("roll")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/util/Lang","joinVerb","(Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;","invokestatic",64);}
case 64:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",68);}
case 68:{return JStep.Return(f.Pop());}
case 69:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=72;continue;}
case 72:{f.StackOp("dup");f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",76);}
case 76:{f.Locals[3]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",81);}
case 81:{f.Push(JValue.I(1));f.Pc=82;continue;}
case 82:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?113:85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Push(JValue.I(0));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",90);}
case 90:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",97);}
case 97:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int==0?113:103;continue;}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("Roll ")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",109);}
case 109:{f.StackOp("pop");f.Pc=110;continue;}
case 110:{f.Pc=124;continue;}
case 113:{f.Push(f.Locals[3]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",118);}
case 118:{f.Push(JValue.R(rt.String(" rolls ")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",123);}
case 123:{f.StackOp("pop");f.Pc=124;continue;}
case 124:{f.Push(f.Locals[3]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[1]);f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("Amount")));f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String("a")));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",133);}
case 133:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",136);}
case 136:{f.Push(JValue.R(rt.String(" d")));f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",141);}
case 141:{f.StackOp("pop");f.Pc=142;continue;}
case 142:{f.Push(f.Locals[3]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{f.Push(JValue.R(rt.String("Sides")));f.Pc=146;continue;}
case 146:{f.Push(JValue.R(rt.String("6")));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",151);}
case 151:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",154);}
case 154:{f.StackOp("pop");f.Pc=155;continue;}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.String("IgnoreLower")));f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",161);}
case 161:{f.Pc=f.Pop().Int==0?171:164;continue;}
case 164:{f.Push(f.Locals[3]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String(" and ignore the lower roll")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",170);}
case 170:{f.StackOp("pop");f.Pc=171;continue;}
case 171:{f.Push(f.Locals[3]);f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.String(".")));f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",177);}
case 177:{f.StackOp("pop");f.Pc=178;continue;}
case 178:{f.Push(f.Locals[3]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",182);}
case 182:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3679(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?17:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String("ToVisitYourAttractions")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int==0?17:13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Pc=18;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{f.Push(JValue.I(0));f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(null));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","rollDiceForPlayer","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;IIIILjava/util/List;Z)I","invokestatic",32);}
case 32:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3680(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{f.Push(JValue.I(6));f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","rollDiceForPlayer","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;IIIILjava/util/List;Z)I","invokestatic",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3681(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int!=0?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",9);}
case 9:{f.Locals[8]=f.Pop();f.Pc=11;continue;}
case 11:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=14;continue;}
case 14:{f.StackOp("dup");f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",18);}
case 18:{f.Locals[9]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",24);}
case 24:{f.Locals[10]=f.Pop();f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",33);}
case 33:{f.Locals[11]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[4]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[6]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[11]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[8]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[9]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[10]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","rollAction","(IIILjava/util/List;Ljava/util/List;Ljava/util/Map;Ljava/util/Set;Lforge/game/player/Player;Ljava/util/Map;)Ljava/util/List;","invokestatic",53);}
case 53:{f.Locals[12]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Pc=f.Pop().Reference==null?90:59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("UseHighestRoll")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?90:68;continue;}
case 68:{f.Push(f.Locals[12]);f.Pc=70;continue;}
case 70:{f.Push(JValue.I(0));f.Pc=71;continue;}
case 71:{f.Push(f.Locals[12]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",78);}
case 78:{f.Push(JValue.I(1));f.Pc=79;continue;}
case 79:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/List","subList","(II)Ljava/util/List;","invokeinterface",85);}
case 85:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",90);}
case 90:{f.Push(JValue.R(rt.String("Once each turn, you may pay {1} to reroll one or more dice you rolled.")));f.Pc=92;continue;}
case 92:{f.Locals[13]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[13]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","getRerollCards","(Lforge/game/player/Player;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",100);}
case 100:{f.Locals[14]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[14]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int!=0?343:110;continue;}
case 110:{f.Push(f.Locals[1]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",114);}
case 114:{f.Push(f.Locals[12]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/player/PlayerController","chooseDiceToReroll","(Ljava/util/List;)Ljava/util/List;","invokevirtual",119);}
case 119:{f.Locals[15]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[15]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",128);}
case 128:{f.Pc=f.Pop().Int==0?134:131;continue;}
case 131:{f.Pc=343;continue;}
case 134:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",137);}
case 137:{f.Push(JValue.R(rt.String("lblChooseRerollCard")));f.Pc=139;continue;}
case 139:{f.Push(JValue.I(0));f.Pc=140;continue;}
case 140:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",146);}
case 146:{f.Locals[16]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",152);}
case 152:{f.Push(f.Locals[14]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[0]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[16]);f.Pc=157;continue;}
case 157:{f.Push(JValue.R(null));f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",161);}
case 161:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=164;continue;}
case 164:{f.Locals[17]=f.Pop();f.Pc=166;continue;}
case 166:{f.Push(f.Locals[17]);f.Pc=168;continue;}
case 168:{f.Push(JValue.R(rt.String("ModsThisTurn")));f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",173);}
case 173:{f.Push(JValue.R(rt.String("\\$")));f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",178);}
case 178:{f.Locals[18]=f.Pop();f.Pc=180;continue;}
case 180:{f.Push(f.Locals[18]);f.Pc=182;continue;}
case 182:{f.Push(JValue.I(1));f.Pc=183;continue;}
case 183:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=184;continue;}
case 184:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",187);}
case 187:{f.Locals[19]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[17]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/card/Card","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",194);}
case 194:{f.Locals[20]=f.Pop();f.Pc=196;continue;}
case 196:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=199;continue;}
case 199:{f.StackOp("dup");f.Pc=200;continue;}
case 200:{f.Push(f.Locals[17]);f.Pc=202;continue;}
case 202:{f.Push(JValue.R(rt.String("RollRerollCost")));f.Pc=205;continue;}
case 205:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",208);}
case 208:{f.Push(JValue.I(0));f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",212);}
case 212:{f.Locals[21]=f.Pop();f.Pc=214;continue;}
case 214:{f.Push(f.Locals[1]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",218);}
case 218:{f.Push(f.Locals[21]);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[20]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/player/PlayerController","payCostDuringRoll","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",225);}
case 225:{f.Locals[22]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(f.Locals[22]);f.Pc=229;continue;}
case 229:{f.Pc=f.Pop().Int==0?340:232;continue;}
case 232:{f.Push(f.Locals[15]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",239);}
case 239:{f.Locals[23]=f.Pop();f.Pc=241;continue;}
case 241:{f.Push(f.Locals[23]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",248);}
case 248:{f.Pc=f.Pop().Int==0?276:251;continue;}
case 251:{f.Push(f.Locals[23]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",258);}
case 258:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=261;continue;}
case 261:{f.Locals[24]=f.Pop();f.Pc=263;continue;}
case 263:{f.Push(f.Locals[12]);f.Pc=265;continue;}
case 265:{f.Push(f.Locals[24]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",272);}
case 272:{f.StackOp("pop");f.Pc=273;continue;}
case 273:{f.Pc=241;continue;}
case 276:{f.Push(f.Locals[15]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",283);}
case 283:{f.Locals[23]=f.Pop();f.Pc=285;continue;}
case 285:{f.Push(f.Locals[23]);f.Pc=287;continue;}
case 287:{f.Push(f.Locals[3]);f.Pc=288;continue;}
case 288:{f.Push(JValue.I(0));f.Pc=289;continue;}
case 289:{f.Push(JValue.R(null));f.Pc=290;continue;}
case 290:{f.Push(f.Locals[11]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",295);}
case 295:{f.Push(f.Locals[9]);f.Pc=297;continue;}
case 297:{f.Push(f.Locals[1]);f.Pc=298;continue;}
case 298:{f.Push(f.Locals[10]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","rollAction","(IIILjava/util/List;Ljava/util/List;Ljava/util/Map;Ljava/util/Set;Lforge/game/player/Player;Ljava/util/Map;)Ljava/util/List;","invokestatic",303);}
case 303:{f.Locals[24]=f.Pop();f.Pc=305;continue;}
case 305:{f.Push(f.Locals[12]);f.Pc=307;continue;}
case 307:{f.Push(f.Locals[24]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",314);}
case 314:{f.StackOp("pop");f.Pc=315;continue;}
case 315:{f.Locals[19]=JValue.I(unchecked(f.Locals[19].Int+(1)));f.Pc=318;continue;}
case 318:{f.Push(f.Locals[17]);f.Pc=320;continue;}
case 320:{f.Push(JValue.R(rt.String("ModsThisTurn")));f.Pc=322;continue;}
case 322:{f.Push(f.Locals[19]);f.Pc=324;continue;}
case 324:{return rt.DynamicCall(f,"forge/game/ability/effects/RollDiceEffect:3681:324:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",329);}
case 329:{return rt.Call(f,"forge/game/card/Card","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",332);}
case 332:{f.Push(f.Locals[14]);f.Pc=334;continue;}
case 334:{f.Push(f.Locals[17]);f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",339);}
case 339:{f.StackOp("pop");f.Pc=340;continue;}
case 340:{f.Pc=102;continue;}
case 343:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=346;continue;}
case 346:{f.StackOp("dup");f.Pc=347;continue;}
case 347:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",350);}
case 350:{f.Locals[15]=f.Pop();f.Pc=352;continue;}
case 352:{f.Push(JValue.R(rt.String("After you roll a die, you may remove a +1/+1 counter from Xenosquirrels. If you do, increase or decrease the result by 1.")));f.Pc=355;continue;}
case 355:{f.Locals[17]=f.Pop();f.Pc=357;continue;}
case 357:{f.Push(JValue.R(rt.String("After you roll a die, you may pay 1 life. If you do, increase or decrease the result by 1. Do this only once each turn.")));f.Pc=360;continue;}
case 360:{f.Locals[18]=f.Pop();f.Pc=362;continue;}
case 362:{f.Push(f.Locals[1]);f.Pc=363;continue;}
case 363:{f.Push(f.Locals[17]);f.Pc=365;continue;}
case 365:{f.Push(f.Locals[18]);f.Pc=367;continue;}
case 367:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","getIncrementCards","(Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;","invokestatic",370);}
case 370:{f.Locals[19]=f.Pop();f.Pc=372;continue;}
case 372:{f.Push(JValue.I(0));f.Pc=373;continue;}
case 373:{f.Locals[20]=f.Pop();f.Pc=375;continue;}
case 375:{f.Push(f.Locals[19]);f.Pc=377;continue;}
case 377:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",382);}
case 382:{f.Pc=f.Pop().Int!=0?714:385;continue;}
case 385:{f.Push(f.Locals[1]);f.Pc=386;continue;}
case 386:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",389);}
case 389:{f.Push(f.Locals[12]);f.Pc=391;continue;}
case 391:{return rt.Call(f,"forge/game/player/PlayerController","chooseRollToModify","(Ljava/util/List;)Ljava/lang/Integer;","invokevirtual",394);}
case 394:{f.Locals[16]=f.Pop();f.Pc=396;continue;}
case 396:{f.Push(f.Locals[16]);f.Pc=398;continue;}
case 398:{f.Pc=f.Pop().Reference!=null?404:401;continue;}
case 401:{f.Pc=714;continue;}
case 404:{f.Push(JValue.I(0));f.Pc=405;continue;}
case 405:{f.Locals[21]=f.Pop();f.Pc=407;continue;}
case 407:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/RollDiceEffect$DieRollResult")));f.Pc=410;continue;}
case 410:{f.StackOp("dup");f.Pc=411;continue;}
case 411:{f.Push(f.Locals[16]);f.Pc=413;continue;}
case 413:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",416);}
case 416:{f.Push(f.Locals[16]);f.Pc=418;continue;}
case 418:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",421);}
case 421:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult","<init>","(II)V","invokespecial",424);}
case 424:{f.Locals[22]=f.Pop();f.Pc=426;continue;}
case 426:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=429;continue;}
case 429:{f.StackOp("dup");f.Pc=430;continue;}
case 430:{f.Push(f.Locals[19]);f.Pc=432;continue;}
case 432:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",435);}
case 435:{f.Locals[23]=f.Pop();f.Pc=437;continue;}
case 437:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",440);}
case 440:{f.Push(JValue.R(rt.String("lblChooseRollIncrementCard")));f.Pc=443;continue;}
case 443:{f.Push(JValue.I(1));f.Pc=444;continue;}
case 444:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=447;continue;}
case 447:{f.StackOp("dup");f.Pc=448;continue;}
case 448:{f.Push(JValue.I(0));f.Pc=449;continue;}
case 449:{f.Push(f.Locals[16]);f.Pc=451;continue;}
case 451:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=452;continue;}
case 452:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",455);}
case 455:{f.Locals[25]=f.Pop();f.Pc=457;continue;}
case 457:{f.Push(f.Locals[1]);f.Pc=458;continue;}
case 458:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",461);}
case 461:{f.Push(f.Locals[23]);f.Pc=463;continue;}
case 463:{f.Push(f.Locals[0]);f.Pc=464;continue;}
case 464:{f.Push(f.Locals[25]);f.Pc=466;continue;}
case 466:{f.Push(JValue.R(null));f.Pc=467;continue;}
case 467:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",470);}
case 470:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=473;continue;}
case 473:{f.Locals[24]=f.Pop();f.Pc=475;continue;}
case 475:{f.Push(f.Locals[24]);f.Pc=477;continue;}
case 477:{f.Push(JValue.R(rt.String("ModsThisTurn")));f.Pc=479;continue;}
case 479:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",482);}
case 482:{f.Push(JValue.R(rt.String("\\$")));f.Pc=484;continue;}
case 484:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",487);}
case 487:{f.Locals[26]=f.Pop();f.Pc=489;continue;}
case 489:{f.Push(f.Locals[26]);f.Pc=491;continue;}
case 491:{f.Push(JValue.I(1));f.Pc=492;continue;}
case 492:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=493;continue;}
case 493:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",496);}
case 496:{f.Locals[27]=f.Pop();f.Pc=498;continue;}
case 498:{f.Push(f.Locals[24]);f.Pc=500;continue;}
case 500:{return rt.Call(f,"forge/game/card/Card","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",503);}
case 503:{f.Locals[28]=f.Pop();f.Pc=505;continue;}
case 505:{f.Push(f.Locals[24]);f.Pc=507;continue;}
case 507:{f.Push(JValue.R(rt.String("RollModifyCost")));f.Pc=510;continue;}
case 510:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",513);}
case 513:{f.Locals[29]=f.Pop();f.Pc=515;continue;}
case 515:{if(!rt.EnsureInitialized(f,"forge/game/cost/Cost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/cost/Cost")));f.Pc=518;continue;}
case 518:{f.StackOp("dup");f.Pc=519;continue;}
case 519:{f.Push(f.Locals[29]);f.Pc=521;continue;}
case 521:{f.Push(JValue.I(0));f.Pc=522;continue;}
case 522:{return rt.Call(f,"forge/game/cost/Cost","<init>","(Ljava/lang/String;Z)V","invokespecial",525);}
case 525:{f.Locals[30]=f.Pop();f.Pc=527;continue;}
case 527:{f.Push(f.Locals[1]);f.Pc=528;continue;}
case 528:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",531);}
case 531:{f.Push(f.Locals[30]);f.Pc=533;continue;}
case 533:{f.Push(f.Locals[28]);f.Pc=535;continue;}
case 535:{return rt.Call(f,"forge/game/player/PlayerController","payCostDuringRoll","(Lforge/game/cost/Cost;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",538);}
case 538:{f.Locals[31]=f.Pop();f.Pc=540;continue;}
case 540:{f.Push(f.Locals[31]);f.Pc=542;continue;}
case 542:{f.Pc=f.Pop().Int==0?648:545;continue;}
case 545:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",548);}
case 548:{f.Push(JValue.R(rt.String("lblChooseRollIncrement")));f.Pc=551;continue;}
case 551:{f.Push(JValue.I(1));f.Pc=552;continue;}
case 552:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=555;continue;}
case 555:{f.StackOp("dup");f.Pc=556;continue;}
case 556:{f.Push(JValue.I(0));f.Pc=557;continue;}
case 557:{f.Push(f.Locals[16]);f.Pc=559;continue;}
case 559:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=560;continue;}
case 560:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",563);}
case 563:{f.Locals[25]=f.Pop();f.Pc=565;continue;}
case 565:{f.Push(f.Locals[1]);f.Pc=566;continue;}
case 566:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",569);}
case 569:{f.Push(f.Locals[0]);f.Pc=570;continue;}
case 570:{f.Push(f.Locals[25]);f.Pc=572;continue;}
case 572:{if(!rt.StaticReady(f,"forge/game/player/PlayerController$BinaryChoiceType","IncreaseOrDecrease","Lforge/game/player/PlayerController$BinaryChoiceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerController$BinaryChoiceType","IncreaseOrDecrease","Lforge/game/player/PlayerController$BinaryChoiceType;"));f.Pc=575;continue;}
case 575:{return rt.Call(f,"forge/game/player/PlayerController","chooseBinary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/PlayerController$BinaryChoiceType;)Z","invokevirtual",578);}
case 578:{f.Locals[32]=f.Pop();f.Pc=580;continue;}
case 580:{f.Push(f.Locals[32]);f.Pc=582;continue;}
case 582:{f.Pc=f.Pop().Int==0?589:585;continue;}
case 585:{f.Push(JValue.I(1));f.Pc=586;continue;}
case 586:{f.Pc=590;continue;}
case 589:{f.Push(JValue.I(-1));f.Pc=590;continue;}
case 590:{f.Locals[33]=f.Pop();f.Pc=592;continue;}
case 592:{f.Push(f.Locals[21]);f.Pc=594;continue;}
case 594:{f.Pc=f.Pop().Int!=0?610:597;continue;}
case 597:{f.Push(f.Locals[12]);f.Pc=599;continue;}
case 599:{f.Push(f.Locals[16]);f.Pc=601;continue;}
case 601:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",606);}
case 606:{f.StackOp("pop");f.Pc=607;continue;}
case 607:{f.Push(JValue.I(1));f.Pc=608;continue;}
case 608:{f.Locals[21]=f.Pop();f.Pc=610;continue;}
case 610:{f.Push(f.Locals[16]);f.Pc=612;continue;}
case 612:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",615);}
case 615:{f.Push(f.Locals[33]);f.Pc=617;continue;}
case 617:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=618;continue;}
case 618:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",621);}
case 621:{f.Locals[16]=f.Pop();f.Pc=623;continue;}
case 623:{f.Locals[27]=JValue.I(unchecked(f.Locals[27].Int+(1)));f.Pc=626;continue;}
case 626:{f.Push(f.Locals[24]);f.Pc=628;continue;}
case 628:{f.Push(JValue.R(rt.String("ModsThisTurn")));f.Pc=630;continue;}
case 630:{f.Push(f.Locals[27]);f.Pc=632;continue;}
case 632:{return rt.DynamicCall(f,"forge/game/ability/effects/RollDiceEffect:3681:632:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(I)Ljava/lang/String;",637);}
case 637:{return rt.Call(f,"forge/game/card/Card","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",640);}
case 640:{f.Push(f.Locals[23]);f.Pc=642;continue;}
case 642:{f.Push(f.Locals[24]);f.Pc=644;continue;}
case 644:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",647);}
case 647:{f.StackOp("pop");f.Pc=648;continue;}
case 648:{f.Push(f.Locals[23]);f.Pc=650;continue;}
case 650:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",653);}
case 653:{f.Pc=f.Pop().Int==0?437:656;continue;}
case 656:{f.Push(f.Locals[21]);f.Pc=658;continue;}
case 658:{f.Pc=f.Pop().Int==0?684:661;continue;}
case 661:{f.Push(f.Locals[22]);f.Pc=663;continue;}
case 663:{f.Push(f.Locals[16]);f.Pc=665;continue;}
case 665:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",668);}
case 668:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult","setModifiedValue","(I)V","invokevirtual",671);}
case 671:{f.Push(f.Locals[15]);f.Pc=673;continue;}
case 673:{f.Push(f.Locals[22]);f.Pc=675;continue;}
case 675:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",680);}
case 680:{f.StackOp("pop");f.Pc=681;continue;}
case 681:{f.Push(JValue.I(1));f.Pc=682;continue;}
case 682:{f.Locals[20]=f.Pop();f.Pc=684;continue;}
case 684:{f.Push(f.Locals[1]);f.Pc=685;continue;}
case 685:{f.Push(f.Locals[17]);f.Pc=687;continue;}
case 687:{f.Push(f.Locals[18]);f.Pc=689;continue;}
case 689:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","getIncrementCards","(Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;","invokestatic",692);}
case 692:{f.Locals[19]=f.Pop();f.Pc=694;continue;}
case 694:{f.Push(f.Locals[12]);f.Pc=696;continue;}
case 696:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",701);}
case 701:{f.Pc=f.Pop().Int!=0?714:704;continue;}
case 704:{f.Push(f.Locals[19]);f.Pc=706;continue;}
case 706:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",711);}
case 711:{f.Pc=f.Pop().Int==0?385:714;continue;}
case 714:{f.Push(f.Locals[12]);f.Pc=716;continue;}
case 716:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",721);}
case 721:{f.Locals[21]=f.Pop();f.Pc=723;continue;}
case 723:{f.Push(f.Locals[21]);f.Pc=725;continue;}
case 725:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",730);}
case 730:{f.Pc=f.Pop().Int==0?773:733;continue;}
case 733:{f.Push(f.Locals[21]);f.Pc=735;continue;}
case 735:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",740);}
case 740:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=743;continue;}
case 743:{f.Locals[22]=f.Pop();f.Pc=745;continue;}
case 745:{f.Push(f.Locals[15]);f.Pc=747;continue;}
case 747:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/RollDiceEffect$DieRollResult")));f.Pc=750;continue;}
case 750:{f.StackOp("dup");f.Pc=751;continue;}
case 751:{f.Push(f.Locals[22]);f.Pc=753;continue;}
case 753:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",756);}
case 756:{f.Push(f.Locals[22]);f.Pc=758;continue;}
case 758:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",761);}
case 761:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult","<init>","(II)V","invokespecial",764);}
case 764:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",769);}
case 769:{f.StackOp("pop");f.Pc=770;continue;}
case 770:{f.Pc=723;continue;}
case 773:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=776;continue;}
case 776:{f.StackOp("dup");f.Pc=777;continue;}
case 777:{f.Push(f.Locals[9]);f.Pc=779;continue;}
case 779:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",782);}
case 782:{f.Locals[21]=f.Pop();f.Pc=784;continue;}
case 784:{f.Push(f.Locals[21]);f.Pc=786;continue;}
case 786:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",789);}
case 789:{f.Pc=f.Pop().Int!=0?1070:792;continue;}
case 792:{f.Push(f.Locals[1]);f.Pc=793;continue;}
case 793:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",796);}
case 796:{f.Push(f.Locals[15]);f.Pc=798;continue;}
case 798:{return rt.Call(f,"forge/game/player/PlayerController","chooseRollToSwap","(Ljava/util/List;)Lforge/game/ability/effects/RollDiceEffect$DieRollResult;","invokevirtual",801);}
case 801:{f.Locals[22]=f.Pop();f.Pc=803;continue;}
case 803:{f.Push(f.Locals[22]);f.Pc=805;continue;}
case 805:{f.Pc=f.Pop().Reference!=null?811:808;continue;}
case 808:{f.Pc=1070;continue;}
case 811:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",814);}
case 814:{f.Push(JValue.R(rt.String("lblChooseCardToDiceSwap")));f.Pc=817;continue;}
case 817:{f.Push(JValue.I(1));f.Pc=818;continue;}
case 818:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=821;continue;}
case 821:{f.StackOp("dup");f.Pc=822;continue;}
case 822:{f.Push(JValue.I(0));f.Pc=823;continue;}
case 823:{f.Push(f.Locals[22]);f.Pc=825;continue;}
case 825:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult","getModifiedValue","()I","invokevirtual",828);}
case 828:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",831);}
case 831:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=832;continue;}
case 832:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",835);}
case 835:{f.Locals[23]=f.Pop();f.Pc=837;continue;}
case 837:{f.Push(f.Locals[1]);f.Pc=838;continue;}
case 838:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",841);}
case 841:{f.Push(f.Locals[21]);f.Pc=843;continue;}
case 843:{f.Push(f.Locals[0]);f.Pc=844;continue;}
case 844:{f.Push(f.Locals[23]);f.Pc=846;continue;}
case 846:{f.Push(JValue.R(null));f.Pc=847;continue;}
case 847:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",850);}
case 850:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=853;continue;}
case 853:{f.Locals[24]=f.Pop();f.Pc=855;continue;}
case 855:{f.Push(f.Locals[24]);f.Pc=857;continue;}
case 857:{return rt.Call(f,"forge/game/card/Card","getCurrentPower","()I","invokevirtual",860);}
case 860:{f.Locals[25]=f.Pop();f.Pc=862;continue;}
case 862:{f.Push(f.Locals[24]);f.Pc=864;continue;}
case 864:{return rt.Call(f,"forge/game/card/Card","getCurrentToughness","()I","invokevirtual",867);}
case 867:{f.Locals[26]=f.Pop();f.Pc=869;continue;}
case 869:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",872);}
case 872:{f.Push(JValue.R(rt.String("lblPower")));f.Pc=875;continue;}
case 875:{f.Push(JValue.I(0));f.Pc=876;continue;}
case 876:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=879;continue;}
case 879:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",882);}
case 882:{f.Locals[27]=f.Pop();f.Pc=884;continue;}
case 884:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",887);}
case 887:{f.Push(JValue.R(rt.String("lblToughness")));f.Pc=890;continue;}
case 890:{f.Push(JValue.I(0));f.Pc=891;continue;}
case 891:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=894;continue;}
case 894:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",897);}
case 897:{f.Locals[28]=f.Pop();f.Pc=899;continue;}
case 899:{f.Push(JValue.I(2));f.Pc=900;continue;}
case 900:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=903;continue;}
case 903:{f.StackOp("dup");f.Pc=904;continue;}
case 904:{f.Push(JValue.I(0));f.Pc=905;continue;}
case 905:{f.Push(f.Locals[27]);f.Pc=907;continue;}
case 907:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=908;continue;}
case 908:{f.StackOp("dup");f.Pc=909;continue;}
case 909:{f.Push(JValue.I(1));f.Pc=910;continue;}
case 910:{f.Push(f.Locals[28]);f.Pc=912;continue;}
case 912:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=913;continue;}
case 913:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",916);}
case 916:{f.Locals[29]=f.Pop();f.Pc=918;continue;}
case 918:{f.Push(f.Locals[1]);f.Pc=919;continue;}
case 919:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",922);}
case 922:{f.Push(f.Locals[29]);f.Pc=924;continue;}
case 924:{f.Push(f.Locals[22]);f.Pc=926;continue;}
case 926:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult","getModifiedValue","()I","invokevirtual",929);}
case 929:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",932);}
case 932:{f.Push(f.Locals[25]);f.Pc=934;continue;}
case 934:{f.Push(f.Locals[26]);f.Pc=936;continue;}
case 936:{return rt.Call(f,"forge/game/player/PlayerController","chooseRollSwapValue","(Ljava/util/List;Ljava/lang/Integer;II)Ljava/lang/String;","invokevirtual",939);}
case 939:{f.Locals[30]=f.Pop();f.Pc=941;continue;}
case 941:{f.Push(f.Locals[30]);f.Pc=943;continue;}
case 943:{f.Pc=f.Pop().Reference==null?1062:946;continue;}
case 946:{f.Push(f.Locals[22]);f.Pc=948;continue;}
case 948:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult","getModifiedValue","()I","invokevirtual",951);}
case 951:{f.Locals[31]=f.Pop();f.Pc=953;continue;}
case 953:{f.Push(f.Locals[30]);f.Pc=955;continue;}
case 955:{f.Push(f.Locals[27]);f.Pc=957;continue;}
case 957:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",960);}
case 960:{f.Pc=f.Pop().Int==0?996:963;continue;}
case 963:{f.Push(f.Locals[22]);f.Pc=965;continue;}
case 965:{f.Push(f.Locals[25]);f.Pc=967;continue;}
case 967:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult","setModifiedValue","(I)V","invokevirtual",970);}
case 970:{f.Push(f.Locals[24]);f.Pc=972;continue;}
case 972:{f.Push(f.Locals[31]);f.Pc=974;continue;}
case 974:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",977);}
case 977:{f.Push(f.Locals[26]);f.Pc=979;continue;}
case 979:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",982);}
case 982:{f.Push(f.Locals[1]);f.Pc=983;continue;}
case 983:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",986);}
case 986:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",989);}
case 989:{f.Push(JValue.L(0));f.Pc=990;continue;}
case 990:{return rt.Call(f,"forge/game/card/Card","addNewPT","(Ljava/lang/Integer;Ljava/lang/Integer;JJ)V","invokevirtual",993);}
case 993:{f.Pc=1054;continue;}
case 996:{f.Push(f.Locals[30]);f.Pc=998;continue;}
case 998:{f.Push(f.Locals[28]);f.Pc=1000;continue;}
case 1000:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1003);}
case 1003:{f.Pc=f.Pop().Int==0?1039:1006;continue;}
case 1006:{f.Push(f.Locals[22]);f.Pc=1008;continue;}
case 1008:{f.Push(f.Locals[26]);f.Pc=1010;continue;}
case 1010:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult","setModifiedValue","(I)V","invokevirtual",1013);}
case 1013:{f.Push(f.Locals[24]);f.Pc=1015;continue;}
case 1015:{f.Push(f.Locals[25]);f.Pc=1017;continue;}
case 1017:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1020);}
case 1020:{f.Push(f.Locals[31]);f.Pc=1022;continue;}
case 1022:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1025);}
case 1025:{f.Push(f.Locals[1]);f.Pc=1026;continue;}
case 1026:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",1029);}
case 1029:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",1032);}
case 1032:{f.Push(JValue.L(0));f.Pc=1033;continue;}
case 1033:{return rt.Call(f,"forge/game/card/Card","addNewPT","(Ljava/lang/Integer;Ljava/lang/Integer;JJ)V","invokevirtual",1036);}
case 1036:{f.Pc=1054;continue;}
case 1039:{if(!rt.EnsureInitialized(f,"java/lang/IllegalStateException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalStateException")));f.Pc=1042;continue;}
case 1042:{f.StackOp("dup");f.Pc=1043;continue;}
case 1043:{f.Push(f.Locals[30]);f.Pc=1045;continue;}
case 1045:{return rt.DynamicCall(f,"forge/game/ability/effects/RollDiceEffect:3681:1045:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",1050);}
case 1050:{return rt.Call(f,"java/lang/IllegalStateException","<init>","(Ljava/lang/String;)V","invokespecial",1053);}
case 1053:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 1054:{f.Push(f.Locals[21]);f.Pc=1056;continue;}
case 1056:{f.Push(f.Locals[24]);f.Pc=1058;continue;}
case 1058:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",1061);}
case 1061:{f.StackOp("pop");f.Pc=1062;continue;}
case 1062:{f.Push(f.Locals[21]);f.Pc=1064;continue;}
case 1064:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",1067);}
case 1067:{f.Pc=f.Pop().Int==0?792:1070;continue;}
case 1070:{f.Push(f.Locals[2]);f.Pc=1071;continue;}
case 1071:{f.Pc=f.Pop().Int<=0?1256:1074;continue;}
case 1074:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=1077;continue;}
case 1077:{f.StackOp("dup");f.Pc=1078;continue;}
case 1078:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",1081);}
case 1081:{f.Locals[22]=f.Pop();f.Pc=1083;continue;}
case 1083:{f.Push(f.Locals[15]);f.Pc=1085;continue;}
case 1085:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","getFinalResults","(Ljava/util/List;)Ljava/util/List;","invokestatic",1088);}
case 1088:{f.Push(JValue.R(rt.String(", ")));f.Pc=1091;continue;}
case 1091:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1094);}
case 1094:{f.Locals[23]=f.Pop();f.Pc=1096;continue;}
case 1096:{f.Push(f.Locals[7]);f.Pc=1098;continue;}
case 1098:{f.Pc=f.Pop().Int==0?1107:1101;continue;}
case 1101:{f.Push(JValue.R(rt.String("lblAttractionRollResult")));f.Pc=1104;continue;}
case 1104:{f.Pc=1110;continue;}
case 1107:{f.Push(JValue.R(rt.String("lblPlayerRolledResult")));f.Pc=1110;continue;}
case 1110:{f.Locals[24]=f.Pop();f.Pc=1112;continue;}
case 1112:{f.Push(f.Locals[22]);f.Pc=1114;continue;}
case 1114:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1117);}
case 1117:{f.Push(f.Locals[24]);f.Pc=1119;continue;}
case 1119:{f.Push(JValue.I(2));f.Pc=1120;continue;}
case 1120:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1123;continue;}
case 1123:{f.StackOp("dup");f.Pc=1124;continue;}
case 1124:{f.Push(JValue.I(0));f.Pc=1125;continue;}
case 1125:{f.Push(f.Locals[1]);f.Pc=1126;continue;}
case 1126:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1127;continue;}
case 1127:{f.StackOp("dup");f.Pc=1128;continue;}
case 1128:{f.Push(JValue.I(1));f.Pc=1129;continue;}
case 1129:{f.Push(f.Locals[23]);f.Pc=1131;continue;}
case 1131:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1132;continue;}
case 1132:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1135);}
case 1135:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1138);}
case 1138:{f.StackOp("pop");f.Pc=1139;continue;}
case 1139:{f.Push(f.Locals[11]);f.Pc=1141;continue;}
case 1141:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",1146);}
case 1146:{f.Pc=f.Pop().Int!=0?1185:1149;continue;}
case 1149:{f.Push(f.Locals[22]);f.Pc=1151;continue;}
case 1151:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=1154;continue;}
case 1154:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1157);}
case 1157:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1160);}
case 1160:{f.Push(JValue.R(rt.String("lblIgnoredRolls")));f.Pc=1163;continue;}
case 1163:{f.Push(JValue.I(1));f.Pc=1164;continue;}
case 1164:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1167;continue;}
case 1167:{f.StackOp("dup");f.Pc=1168;continue;}
case 1168:{f.Push(JValue.I(0));f.Pc=1169;continue;}
case 1169:{f.Push(f.Locals[11]);f.Pc=1171;continue;}
case 1171:{f.Push(JValue.R(rt.String(", ")));f.Pc=1174;continue;}
case 1174:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1177);}
case 1177:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1178;continue;}
case 1178:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1181);}
case 1181:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1184);}
case 1184:{f.StackOp("pop");f.Pc=1185;continue;}
case 1185:{f.Push(f.Locals[20]);f.Pc=1187;continue;}
case 1187:{f.Pc=f.Pop().Int==0?1229:1190;continue;}
case 1190:{f.Push(f.Locals[22]);f.Pc=1192;continue;}
case 1192:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=1195;continue;}
case 1195:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1198);}
case 1198:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",1201);}
case 1201:{f.Push(JValue.R(rt.String("lblNaturalRolls")));f.Pc=1204;continue;}
case 1204:{f.Push(JValue.I(1));f.Pc=1205;continue;}
case 1205:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=1208;continue;}
case 1208:{f.StackOp("dup");f.Pc=1209;continue;}
case 1209:{f.Push(JValue.I(0));f.Pc=1210;continue;}
case 1210:{f.Push(f.Locals[15]);f.Pc=1212;continue;}
case 1212:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","getNaturalResults","(Ljava/util/List;)Ljava/util/List;","invokestatic",1215);}
case 1215:{f.Push(JValue.R(rt.String(", ")));f.Pc=1218;continue;}
case 1218:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",1221);}
case 1221:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=1222;continue;}
case 1222:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",1225);}
case 1225:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",1228);}
case 1228:{f.StackOp("pop");f.Pc=1229;continue;}
case 1229:{f.Push(f.Locals[1]);f.Pc=1230;continue;}
case 1230:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",1233);}
case 1233:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1236);}
case 1236:{f.Push(f.Locals[0]);f.Pc=1237;continue;}
case 1237:{f.Push(f.Locals[1]);f.Pc=1238;continue;}
case 1238:{f.Push(f.Locals[22]);f.Pc=1240;continue;}
case 1240:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",1243);}
case 1243:{f.Push(JValue.R(null));f.Pc=1244;continue;}
case 1244:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",1247);}
case 1247:{f.Push(f.Locals[1]);f.Pc=1248;continue;}
case 1248:{f.Push(f.Locals[15]);f.Pc=1250;continue;}
case 1250:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","getFinalResults","(Ljava/util/List;)Ljava/util/List;","invokestatic",1253);}
case 1253:{return rt.Call(f,"forge/game/player/Player","addDieRollThisTurn","(Ljava/util/List;)V","invokevirtual",1256);}
case 1256:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",1259);}
case 1259:{f.Locals[22]=f.Pop();f.Pc=1261;continue;}
case 1261:{f.Push(JValue.I(0));f.Pc=1262;continue;}
case 1262:{f.Locals[23]=f.Pop();f.Pc=1264;continue;}
case 1264:{f.Push(JValue.I(0));f.Pc=1265;continue;}
case 1265:{f.Locals[24]=f.Pop();f.Pc=1267;continue;}
case 1267:{f.Push(JValue.I(0));f.Pc=1268;continue;}
case 1268:{f.Locals[25]=f.Pop();f.Pc=1270;continue;}
case 1270:{f.Push(JValue.I(0));f.Pc=1271;continue;}
case 1271:{f.Locals[26]=f.Pop();f.Pc=1273;continue;}
case 1273:{f.Push(f.Locals[15]);f.Pc=1275;continue;}
case 1275:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1280);}
case 1280:{f.Locals[27]=f.Pop();f.Pc=1282;continue;}
case 1282:{f.Push(f.Locals[27]);f.Pc=1284;continue;}
case 1284:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1289);}
case 1289:{f.Pc=f.Pop().Int==0?1387:1292;continue;}
case 1292:{f.Push(f.Locals[27]);f.Pc=1294;continue;}
case 1294:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1299);}
case 1299:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/ability/effects/RollDiceEffect$DieRollResult"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1302;continue;}
case 1302:{f.Locals[28]=f.Pop();f.Pc=1304;continue;}
case 1304:{f.Push(f.Locals[28]);f.Pc=1306;continue;}
case 1306:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult","getNaturalValue","()I","invokevirtual",1309);}
case 1309:{f.Locals[29]=f.Pop();f.Pc=1311;continue;}
case 1311:{f.Push(f.Locals[28]);f.Pc=1313;continue;}
case 1313:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult","getModifiedValue","()I","invokevirtual",1316);}
case 1316:{f.Push(f.Locals[5]);f.Pc=1318;continue;}
case 1318:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1319;continue;}
case 1319:{f.Locals[30]=f.Pop();f.Pc=1321;continue;}
case 1321:{f.Push(f.Locals[28]);f.Pc=1323;continue;}
case 1323:{f.Push(f.Locals[30]);f.Pc=1325;continue;}
case 1325:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult","setModifiedValue","(I)V","invokevirtual",1328);}
case 1328:{f.Push(f.Locals[22]);f.Pc=1330;continue;}
case 1330:{f.Push(f.Locals[30]);f.Pc=1332;continue;}
case 1332:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1335);}
case 1335:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",1340);}
case 1340:{f.Pc=f.Pop().Int!=0?1346:1343;continue;}
case 1343:{f.Locals[25]=JValue.I(unchecked(f.Locals[25].Int+(1)));f.Pc=1346;continue;}
case 1346:{f.Push(f.Locals[22]);f.Pc=1348;continue;}
case 1348:{f.Push(f.Locals[30]);f.Pc=1350;continue;}
case 1350:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1353);}
case 1353:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1358);}
case 1358:{f.StackOp("pop");f.Pc=1359;continue;}
case 1359:{f.Push(f.Locals[30]);f.Pc=1361;continue;}
case 1361:{f.Push(JValue.I(2));f.Pc=1362;continue;}
case 1362:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"irem",a,b));f.Pc=1363;continue;}
case 1363:{f.Pc=f.Pop().Int!=0?1372:1366;continue;}
case 1366:{f.Locals[24]=JValue.I(unchecked(f.Locals[24].Int+(1)));f.Pc=1369;continue;}
case 1369:{f.Pc=1375;continue;}
case 1372:{f.Locals[23]=JValue.I(unchecked(f.Locals[23].Int+(1)));f.Pc=1375;continue;}
case 1375:{f.Push(f.Locals[29]);f.Pc=1377;continue;}
case 1377:{f.Push(f.Locals[3]);f.Pc=1378;continue;}
case 1378:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?1384:1381;continue;}
case 1381:{f.Locals[26]=JValue.I(unchecked(f.Locals[26].Int+(1)));f.Pc=1384;continue;}
case 1384:{f.Pc=1282;continue;}
case 1387:{f.Push(f.Locals[0]);f.Pc=1388;continue;}
case 1388:{f.Pc=f.Pop().Reference==null?1469:1391;continue;}
case 1391:{f.Push(f.Locals[0]);f.Pc=1392;continue;}
case 1392:{f.Push(JValue.R(rt.String("EvenOddResults")));f.Pc=1395;continue;}
case 1395:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1398);}
case 1398:{f.Pc=f.Pop().Int==0?1425:1401;continue;}
case 1401:{f.Push(f.Locals[0]);f.Pc=1402;continue;}
case 1402:{f.Push(JValue.R(rt.String("EvenResults")));f.Pc=1405;continue;}
case 1405:{f.Push(f.Locals[24]);f.Pc=1407;continue;}
case 1407:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",1410);}
case 1410:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1413);}
case 1413:{f.Push(f.Locals[0]);f.Pc=1414;continue;}
case 1414:{f.Push(JValue.R(rt.String("OddResults")));f.Pc=1417;continue;}
case 1417:{f.Push(f.Locals[23]);f.Pc=1419;continue;}
case 1419:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",1422);}
case 1422:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1425);}
case 1425:{f.Push(f.Locals[0]);f.Pc=1426;continue;}
case 1426:{f.Push(JValue.R(rt.String("DifferentResults")));f.Pc=1429;continue;}
case 1429:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1432);}
case 1432:{f.Pc=f.Pop().Int==0?1447:1435;continue;}
case 1435:{f.Push(f.Locals[0]);f.Pc=1436;continue;}
case 1436:{f.Push(JValue.R(rt.String("DifferentResults")));f.Pc=1439;continue;}
case 1439:{f.Push(f.Locals[25]);f.Pc=1441;continue;}
case 1441:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",1444);}
case 1444:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1447);}
case 1447:{f.Push(f.Locals[0]);f.Pc=1448;continue;}
case 1448:{f.Push(JValue.R(rt.String("MaxRollsResults")));f.Pc=1451;continue;}
case 1451:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",1454);}
case 1454:{f.Pc=f.Pop().Int==0?1469:1457;continue;}
case 1457:{f.Push(f.Locals[0]);f.Pc=1458;continue;}
case 1458:{f.Push(JValue.R(rt.String("MaxRolls")));f.Pc=1461;continue;}
case 1461:{f.Push(f.Locals[26]);f.Pc=1463;continue;}
case 1463:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",1466);}
case 1466:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",1469);}
case 1469:{f.Push(f.Locals[0]);f.Pc=1470;continue;}
case 1470:{f.Pc=f.Pop().Reference==null?1480:1473;continue;}
case 1473:{f.Push(f.Locals[0]);f.Pc=1474;continue;}
case 1474:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRootAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",1477);}
case 1477:{f.Pc=1481;continue;}
case 1480:{f.Push(JValue.R(null));f.Pc=1481;continue;}
case 1481:{f.Locals[27]=f.Pop();f.Pc=1483;continue;}
case 1483:{f.Push(JValue.I(1));f.Pc=1484;continue;}
case 1484:{f.Locals[28]=f.Pop();f.Pc=1486;continue;}
case 1486:{f.Push(f.Locals[15]);f.Pc=1488;continue;}
case 1488:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1493);}
case 1493:{f.Locals[29]=f.Pop();f.Pc=1495;continue;}
case 1495:{f.Push(f.Locals[29]);f.Pc=1497;continue;}
case 1497:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1502);}
case 1502:{f.Pc=f.Pop().Int==0?1650:1505;continue;}
case 1505:{f.Push(f.Locals[29]);f.Pc=1507;continue;}
case 1507:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1512);}
case 1512:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/ability/effects/RollDiceEffect$DieRollResult"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1515;continue;}
case 1515:{f.Locals[30]=f.Pop();f.Pc=1517;continue;}
case 1517:{f.Push(f.Locals[1]);f.Pc=1518;continue;}
case 1518:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",1521);}
case 1521:{f.Locals[31]=f.Pop();f.Pc=1523;continue;}
case 1523:{f.Push(f.Locals[31]);f.Pc=1525;continue;}
case 1525:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Sides","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Sides","Lforge/game/ability/AbilityKey;"));f.Pc=1528;continue;}
case 1528:{f.Push(f.Locals[3]);f.Pc=1529;continue;}
case 1529:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1532);}
case 1532:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1537);}
case 1537:{f.StackOp("pop");f.Pc=1538;continue;}
case 1538:{f.Push(f.Locals[31]);f.Pc=1540;continue;}
case 1540:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Result","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Result","Lforge/game/ability/AbilityKey;"));f.Pc=1543;continue;}
case 1543:{f.Push(f.Locals[30]);f.Pc=1545;continue;}
case 1545:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult","getModifiedValue","()I","invokevirtual",1548);}
case 1548:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1551);}
case 1551:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1556);}
case 1556:{f.StackOp("pop");f.Pc=1557;continue;}
case 1557:{f.Push(f.Locals[31]);f.Pc=1559;continue;}
case 1559:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","NaturalResult","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","NaturalResult","Lforge/game/ability/AbilityKey;"));f.Pc=1562;continue;}
case 1562:{f.Push(f.Locals[30]);f.Pc=1564;continue;}
case 1564:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect$DieRollResult","getNaturalValue","()I","invokevirtual",1567);}
case 1567:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1570);}
case 1570:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1575);}
case 1575:{f.StackOp("pop");f.Pc=1576;continue;}
case 1576:{f.Push(f.Locals[31]);f.Pc=1578;continue;}
case 1578:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","RolledToVisitAttractions","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","RolledToVisitAttractions","Lforge/game/ability/AbilityKey;"));f.Pc=1581;continue;}
case 1581:{f.Push(f.Locals[7]);f.Pc=1583;continue;}
case 1583:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",1586);}
case 1586:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1591);}
case 1591:{f.StackOp("pop");f.Pc=1592;continue;}
case 1592:{f.Push(f.Locals[31]);f.Pc=1594;continue;}
case 1594:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"));f.Pc=1597;continue;}
case 1597:{f.Push(f.Locals[1]);f.Pc=1598;continue;}
case 1598:{return rt.Call(f,"forge/game/player/Player","getNumRollsThisTurn","()I","invokevirtual",1601);}
case 1601:{f.Push(f.Locals[2]);f.Pc=1602;continue;}
case 1602:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=1603;continue;}
case 1603:{f.Push(f.Locals[28]);f.Pc=1605;continue;}
case 1605:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=1606;continue;}
case 1606:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1609);}
case 1609:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1614);}
case 1614:{f.StackOp("pop");f.Pc=1615;continue;}
case 1615:{f.Push(f.Locals[31]);f.Pc=1617;continue;}
case 1617:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SourceSA","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SourceSA","Lforge/game/ability/AbilityKey;"));f.Pc=1620;continue;}
case 1620:{f.Push(f.Locals[27]);f.Pc=1622;continue;}
case 1622:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1627);}
case 1627:{f.StackOp("pop");f.Pc=1628;continue;}
case 1628:{f.Push(f.Locals[1]);f.Pc=1629;continue;}
case 1629:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",1632);}
case 1632:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1635);}
case 1635:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","RolledDie","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","RolledDie","Lforge/game/trigger/TriggerType;"));f.Pc=1638;continue;}
case 1638:{f.Push(f.Locals[31]);f.Pc=1640;continue;}
case 1640:{f.Push(JValue.I(0));f.Pc=1641;continue;}
case 1641:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1644);}
case 1644:{f.Locals[28]=JValue.I(unchecked(f.Locals[28].Int+(1)));f.Pc=1647;continue;}
case 1647:{f.Pc=1495;continue;}
case 1650:{f.Push(f.Locals[1]);f.Pc=1651;continue;}
case 1651:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",1654);}
case 1654:{f.Locals[29]=f.Pop();f.Pc=1656;continue;}
case 1656:{f.Push(f.Locals[29]);f.Pc=1658;continue;}
case 1658:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Sides","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Sides","Lforge/game/ability/AbilityKey;"));f.Pc=1661;continue;}
case 1661:{f.Push(f.Locals[3]);f.Pc=1662;continue;}
case 1662:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1665);}
case 1665:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1670);}
case 1670:{f.StackOp("pop");f.Pc=1671;continue;}
case 1671:{f.Push(f.Locals[29]);f.Pc=1673;continue;}
case 1673:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Result","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Result","Lforge/game/ability/AbilityKey;"));f.Pc=1676;continue;}
case 1676:{f.Push(f.Locals[15]);f.Pc=1678;continue;}
case 1678:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","getFinalResults","(Ljava/util/List;)Ljava/util/List;","invokestatic",1681);}
case 1681:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1686);}
case 1686:{f.StackOp("pop");f.Pc=1687;continue;}
case 1687:{f.Push(f.Locals[29]);f.Pc=1689;continue;}
case 1689:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","RolledToVisitAttractions","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","RolledToVisitAttractions","Lforge/game/ability/AbilityKey;"));f.Pc=1692;continue;}
case 1692:{f.Push(f.Locals[7]);f.Pc=1694;continue;}
case 1694:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",1697);}
case 1697:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1702);}
case 1702:{f.StackOp("pop");f.Pc=1703;continue;}
case 1703:{f.Push(f.Locals[29]);f.Pc=1705;continue;}
case 1705:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","SourceSA","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","SourceSA","Lforge/game/ability/AbilityKey;"));f.Pc=1708;continue;}
case 1708:{f.Push(f.Locals[27]);f.Pc=1710;continue;}
case 1710:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",1715);}
case 1715:{f.StackOp("pop");f.Pc=1716;continue;}
case 1716:{f.Push(f.Locals[1]);f.Pc=1717;continue;}
case 1717:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",1720);}
case 1720:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",1723);}
case 1723:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","RolledDieOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","RolledDieOnce","Lforge/game/trigger/TriggerType;"));f.Pc=1726;continue;}
case 1726:{f.Push(f.Locals[29]);f.Pc=1728;continue;}
case 1728:{f.Push(JValue.I(0));f.Pc=1729;continue;}
case 1729:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",1732);}
case 1732:{f.Push(f.Locals[15]);f.Pc=1734;continue;}
case 1734:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","getFinalResults","(Ljava/util/List;)Ljava/util/List;","invokestatic",1737);}
case 1737:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",1742);}
case 1742:{f.Push(JValue.I(0));f.Pc=1743;continue;}
case 1743:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1746);}
case 1746:{return rt.DynamicCall(f,"forge/game/ability/effects/RollDiceEffect:3681:1746:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/BinaryOperator;",1751);}
case 1751:{return rt.Call(f,"java/util/stream/Stream","reduce","(Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;","invokeinterface",1756);}
case 1756:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1759;continue;}
case 1759:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",1762);}
case 1762:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3682(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",7);}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardLists","getKeyword","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.DynamicCall(f,"forge/game/ability/effects/RollDiceEffect:3682:13:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",18);}
case 18:{return rt.Call(f,"forge/game/card/CardCollection","filter","(Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokevirtual",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3683(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",7);}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardLists","getKeyword","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",19);}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/CardLists","getKeyword","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",32);}
case 32:{f.Locals[5]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",38);}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",47);}
case 47:{f.Pc=f.Pop().Int==0?101:50;continue;}
case 50:{f.Push(f.Locals[6]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",57);}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{f.Locals[7]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[7]);f.Pc=64;continue;}
case 64:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"));f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",70);}
case 70:{f.Locals[8]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[8]);f.Pc=74;continue;}
case 74:{f.Pc=f.Pop().Int<=0?98:77;continue;}
case 77:{f.Push(f.Locals[7]);f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","P1P1","Lforge/game/card/CounterEnumType;"));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/card/Card","canRemoveCounters","(Lforge/game/card/CounterType;)Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int==0?98:88;continue;}
case 88:{f.Push(f.Locals[5]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[7]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",97);}
case 97:{f.StackOp("pop");f.Pc=98;continue;}
case 98:{f.Pc=40;continue;}
case 101:{f.Push(f.Locals[4]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",106);}
case 106:{f.Locals[6]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[6]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",115);}
case 115:{f.Pc=f.Pop().Int==0?211:118;continue;}
case 118:{f.Push(f.Locals[6]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",125);}
case 125:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=128;continue;}
case 128:{f.Locals[7]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[7]);f.Pc=132;continue;}
case 132:{f.Push(JValue.R(rt.String("RollModificationsLimit")));f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",138);}
case 138:{f.Locals[8]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(f.Locals[7]);f.Pc=142;continue;}
case 142:{f.Push(JValue.R(rt.String("ModsThisTurn")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",147);}
case 147:{f.Push(JValue.R(rt.String("\\$")));f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",152);}
case 152:{f.Locals[9]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[9]);f.Pc=156;continue;}
case 156:{f.Push(JValue.I(1));f.Pc=157;continue;}
case 157:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",161);}
case 161:{f.Locals[10]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(f.Locals[8]);f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("None")));f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",171);}
case 171:{f.Pc=f.Pop().Int!=0?184:174;continue;}
case 174:{f.Push(f.Locals[10]);f.Pc=176;continue;}
case 176:{f.Push(f.Locals[8]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",181);}
case 181:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?208:184;continue;}
case 184:{f.Push(f.Locals[0]);f.Pc=185;continue;}
case 185:{f.Push(JValue.I(1));f.Pc=186;continue;}
case 186:{f.Push(JValue.I(1));f.Pc=187;continue;}
case 187:{f.Push(f.Locals[7]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"forge/game/card/Card","getFirstSpellAbility","()Lforge/game/spellability/SpellAbility;","invokevirtual",192);}
case 192:{return rt.Call(f,"forge/game/player/Player","canPayLife","(IZLforge/game/spellability/SpellAbility;)Z","invokevirtual",195);}
case 195:{f.Pc=f.Pop().Int==0?208:198;continue;}
case 198:{f.Push(f.Locals[5]);f.Pc=200;continue;}
case 200:{f.Push(f.Locals[7]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",207);}
case 207:{f.StackOp("pop");f.Pc=208;continue;}
case 208:{f.Pc=108;continue;}
case 211:{f.Push(f.Locals[5]);f.Pc=213;continue;}
case 213:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3684(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[8]);f.Pc=2;continue;}
case 2:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Sides","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Sides","Lforge/game/ability/AbilityKey;"));f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",9);}
case 9:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[8]);f.Pc=17;continue;}
case 17:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"));f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",24);}
case 24:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{f.Push(f.Locals[8]);f.Pc=32;continue;}
case 32:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Ignore","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Ignore","Lforge/game/ability/AbilityKey;"));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",39);}
case 39:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",44);}
case 44:{f.StackOp("pop");f.Pc=45;continue;}
case 45:{f.Push(f.Locals[8]);f.Pc=47;continue;}
case 47:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","DicePTExchanges","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","DicePTExchanges","Lforge/game/ability/AbilityKey;"));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[6]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",57);}
case 57:{f.StackOp("pop");f.Pc=58;continue;}
case 58:{f.Push(f.Locals[8]);f.Pc=60;continue;}
case 60:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IgnoreChosen","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IgnoreChosen","Lforge/game/ability/AbilityKey;"));f.Pc=63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{if(!rt.StaticReady(f,"forge/game/ability/effects/RollDiceEffect$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/effects/RollDiceEffect$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"));f.Pc=74;continue;}
case 74:{f.Push(f.Locals[7]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",79);}
case 79:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",82);}
case 82:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","RollDice","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","RollDice","Lforge/game/replacement/ReplacementType;"));f.Pc=85;continue;}
case 85:{f.Push(f.Locals[8]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",90);}
case 90:{return rt.Call(f,"forge/game/replacement/ReplacementResult","ordinal","()I","invokevirtual",93);}
case 93:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=94;continue;}
case 94:{switch(f.Pop().Int){case 1:f.Pc=120;break;case 2:f.Pc=123;break;default:f.Pc=175;break;}continue;}
case 120:{f.Pc=175;continue;}
case 123:{f.Push(f.Locals[8]);f.Pc=125;continue;}
case 125:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",133);}
case 133:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=136;continue;}
case 136:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",139);}
case 139:{f.Locals[0]=f.Pop();f.Pc=140;continue;}
case 140:{f.Push(f.Locals[8]);f.Pc=142;continue;}
case 142:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Ignore","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Ignore","Lforge/game/ability/AbilityKey;"));f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",150);}
case 150:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",156);}
case 156:{f.Locals[2]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[8]);f.Pc=159;continue;}
case 159:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","IgnoreChosen","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","IgnoreChosen","Lforge/game/ability/AbilityKey;"));f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",167);}
case 167:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=170;continue;}
case 170:{f.Locals[5]=f.Pop();f.Pc=172;continue;}
case 172:{f.Pc=175;continue;}
case 175:{f.Push(f.Locals[3]);f.Pc=176;continue;}
case 176:{f.Pc=f.Pop().Reference!=null?189:179;continue;}
case 179:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=182;continue;}
case 182:{f.StackOp("dup");f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",186);}
case 186:{f.Pc=190;continue;}
case 189:{f.Push(f.Locals[3]);f.Pc=190;continue;}
case 190:{f.Locals[9]=f.Pop();f.Pc=192;continue;}
case 192:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=195;continue;}
case 195:{f.StackOp("dup");f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",199);}
case 199:{f.Locals[10]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(JValue.I(0));f.Pc=202;continue;}
case 202:{f.Locals[11]=f.Pop();f.Pc=204;continue;}
case 204:{f.Push(f.Locals[11]);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[0]);f.Pc=207;continue;}
case 207:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?276:210;continue;}
case 210:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",213);}
case 213:{f.Push(f.Locals[1]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",217);}
case 217:{f.Push(JValue.I(1));f.Pc=218;continue;}
case 218:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=219;continue;}
case 219:{f.Locals[12]=f.Pop();f.Pc=221;continue;}
case 221:{f.Push(f.Locals[7]);f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",226);}
case 226:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventRollDie"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventRollDie")));f.Pc=229;continue;}
case 229:{f.StackOp("dup");f.Pc=230;continue;}
case 230:{f.Push(f.Locals[1]);f.Pc=231;continue;}
case 231:{f.Push(f.Locals[12]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/event/GameEventRollDie","<init>","(II)V","invokespecial",236);}
case 236:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",239);}
case 239:{f.Push(f.Locals[7]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/player/Player","roll","()V","invokevirtual",244);}
case 244:{f.Push(f.Locals[9]);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[12]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",251);}
case 251:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",256);}
case 256:{f.StackOp("pop");f.Pc=257;continue;}
case 257:{f.Push(f.Locals[10]);f.Pc=259;continue;}
case 259:{f.Push(f.Locals[12]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",264);}
case 264:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",269);}
case 269:{f.StackOp("pop");f.Pc=270;continue;}
case 270:{f.Locals[11]=JValue.I(unchecked(f.Locals[11].Int+(1)));f.Pc=273;continue;}
case 273:{f.Pc=204;continue;}
case 276:{f.Push(f.Locals[7]);f.Pc=278;continue;}
case 278:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",281);}
case 281:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventRollDice"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventRollDice")));f.Pc=284;continue;}
case 284:{f.StackOp("dup");f.Pc=285;continue;}
case 285:{f.Push(f.Locals[1]);f.Pc=286;continue;}
case 286:{f.Push(f.Locals[10]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/game/event/GameEventRollDice","<init>","(ILjava/util/List;)V","invokespecial",291);}
case 291:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",294);}
case 294:{f.Push(f.Locals[9]);f.Pc=296;continue;}
case 296:{f.Push(JValue.R(null));f.Pc=297;continue;}
case 297:{return rt.Call(f,"java/util/List","sort","(Ljava/util/Comparator;)V","invokeinterface",302);}
case 302:{f.Push(f.Locals[2]);f.Pc=303;continue;}
case 303:{f.Pc=f.Pop().Int<=0?352:306;continue;}
case 306:{f.Push(f.Locals[2]);f.Pc=307;continue;}
case 307:{f.Push(JValue.I(1));f.Pc=308;continue;}
case 308:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=309;continue;}
case 309:{f.Locals[11]=f.Pop();f.Pc=311;continue;}
case 311:{f.Push(f.Locals[11]);f.Pc=313;continue;}
case 313:{f.Pc=f.Pop().Int<0?352:316;continue;}
case 316:{f.Push(f.Locals[4]);f.Pc=318;continue;}
case 318:{f.Push(f.Locals[9]);f.Pc=320;continue;}
case 320:{f.Push(f.Locals[11]);f.Pc=322;continue;}
case 322:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",327);}
case 327:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=330;continue;}
case 330:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",335);}
case 335:{f.StackOp("pop");f.Pc=336;continue;}
case 336:{f.Push(f.Locals[9]);f.Pc=338;continue;}
case 338:{f.Push(f.Locals[11]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"java/util/List","remove","(I)Ljava/lang/Object;","invokeinterface",345);}
case 345:{f.StackOp("pop");f.Pc=346;continue;}
case 346:{f.Locals[11]=JValue.I(unchecked(f.Locals[11].Int+(-1)));f.Pc=349;continue;}
case 349:{f.Pc=311;continue;}
case 352:{f.Push(f.Locals[5]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",359);}
case 359:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",364);}
case 364:{f.Locals[11]=f.Pop();f.Pc=366;continue;}
case 366:{f.Push(f.Locals[11]);f.Pc=368;continue;}
case 368:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",373);}
case 373:{f.Pc=f.Pop().Int==0?452:376;continue;}
case 376:{f.Push(f.Locals[11]);f.Pc=378;continue;}
case 378:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",383);}
case 383:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=386;continue;}
case 386:{f.Locals[12]=f.Pop();f.Pc=388;continue;}
case 388:{f.Push(JValue.I(0));f.Pc=389;continue;}
case 389:{f.Locals[13]=f.Pop();f.Pc=391;continue;}
case 391:{f.Push(f.Locals[13]);f.Pc=393;continue;}
case 393:{f.Push(f.Locals[5]);f.Pc=395;continue;}
case 395:{f.Push(f.Locals[12]);f.Pc=397;continue;}
case 397:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",402);}
case 402:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=405;continue;}
case 405:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",408);}
case 408:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?449:411;continue;}
case 411:{f.Push(f.Locals[12]);f.Pc=413;continue;}
case 413:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",416);}
case 416:{f.Push(f.Locals[9]);f.Pc=418;continue;}
case 418:{return rt.Call(f,"forge/game/player/PlayerController","chooseRollToIgnore","(Ljava/util/List;)Ljava/lang/Integer;","invokevirtual",421);}
case 421:{f.Locals[14]=f.Pop();f.Pc=423;continue;}
case 423:{f.Push(f.Locals[4]);f.Pc=425;continue;}
case 425:{f.Push(f.Locals[14]);f.Pc=427;continue;}
case 427:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",432);}
case 432:{f.StackOp("pop");f.Pc=433;continue;}
case 433:{f.Push(f.Locals[9]);f.Pc=435;continue;}
case 435:{f.Push(f.Locals[14]);f.Pc=437;continue;}
case 437:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",442);}
case 442:{f.StackOp("pop");f.Pc=443;continue;}
case 443:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(1)));f.Pc=446;continue;}
case 446:{f.Pc=391;continue;}
case 449:{f.Pc=366;continue;}
case 452:{f.Push(f.Locals[9]);f.Pc=454;continue;}
case 454:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3685(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbilities","()Ljava/util/Map;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",13);}
case 13:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",18);}
case 18:{f.Locals[4]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[4]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",27);}
case 27:{f.Pc=f.Pop().Int==0?148:30;continue;}
case 30:{f.Push(f.Locals[4]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[5]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[5]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",49);}
case 49:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=52;continue;}
case 52:{f.Locals[6]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[6]);f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("-")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int==0?114:65;continue;}
case 65:{f.Push(f.Locals[6]);f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.String("-")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",73);}
case 73:{f.Locals[7]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[7]);f.Pc=77;continue;}
case 77:{f.Push(JValue.I(0));f.Pc=78;continue;}
case 78:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",82);}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?111:86;continue;}
case 86:{f.Push(f.Locals[7]);f.Pc=88;continue;}
case 88:{f.Push(JValue.I(1));f.Pc=89;continue;}
case 89:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",93);}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?111:97;continue;}
case 97:{f.Push(f.Locals[5]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",104);}
case 104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=107;continue;}
case 107:{f.Locals[3]=f.Pop();f.Pc=108;continue;}
case 108:{f.Pc=148;continue;}
case 111:{f.Pc=145;continue;}
case 114:{f.Push(f.Locals[6]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isNumeric","(Ljava/lang/CharSequence;)Z","invokestatic",119);}
case 119:{f.Pc=f.Pop().Int==0?145:122;continue;}
case 122:{f.Push(f.Locals[6]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",127);}
case 127:{f.Push(f.Locals[1]);f.Pc=128;continue;}
case 128:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?145:131;continue;}
case 131:{f.Push(f.Locals[5]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",138);}
case 138:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=141;continue;}
case 141:{f.Locals[3]=f.Pop();f.Pc=142;continue;}
case 142:{f.Pc=148;continue;}
case 145:{f.Pc=20;continue;}
case 148:{f.Push(f.Locals[3]);f.Pc=149;continue;}
case 149:{f.Pc=f.Pop().Reference==null?159:152;continue;}
case 152:{f.Push(f.Locals[3]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",156);}
case 156:{f.Pc=179;continue;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("Else")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasAdditionalAbility","(Ljava/lang/String;)Z","invokevirtual",166);}
case 166:{f.Pc=f.Pop().Int==0?179:169;continue;}
case 169:{f.Push(f.Locals[0]);f.Pc=170;continue;}
case 170:{f.Push(JValue.R(rt.String("Else")));f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",176);}
case 176:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",179);}
case 179:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3686(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[5]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Modifier")));f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("0")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",22);}
case 22:{f.Locals[6]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[5]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("IgnoreLower")));f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("0")));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",35);}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",39);}
case 39:{f.Locals[7]=f.Pop();f.Pc=41;continue;}
case 41:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=44;continue;}
case 44:{f.StackOp("dup");f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",48);}
case 48:{f.Locals[8]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(f.Locals[2]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[3]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[4]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[7]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[8]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{f.Push(JValue.R(rt.String("ToVisitYourAttractions")));f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",67);}
case 67:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","rollDiceForPlayer","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;IIIILjava/util/List;Z)I","invokestatic",70);}
case 70:{f.Locals[9]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("UseDifferenceBetweenRolls")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int==0?107:82;continue;}
case 82:{f.Push(f.Locals[8]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Collections","max","(Ljava/util/Collection;)Ljava/lang/Object;","invokestatic",87);}
case 87:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",93);}
case 93:{f.Push(f.Locals[8]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"java/util/Collections","min","(Ljava/util/Collection;)Ljava/lang/Object;","invokestatic",98);}
case 98:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",104);}
case 104:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=105;continue;}
case 105:{f.Locals[9]=f.Pop();f.Pc=107;continue;}
case 107:{f.Push(f.Locals[1]);f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("StoreResults")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?124:117;continue;}
case 117:{f.Push(f.Locals[5]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[8]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/card/Card","addStoredRolls","(Ljava/util/List;)V","invokevirtual",124);}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String("ResultSVar")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int==0?150:134;continue;}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[1]);f.Pc=136;continue;}
case 136:{f.Push(JValue.R(rt.String("ResultSVar")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",142);}
case 142:{f.Push(f.Locals[9]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",147);}
case 147:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",150);}
case 150:{f.Push(f.Locals[1]);f.Pc=151;continue;}
case 151:{f.Push(JValue.R(rt.String("ChosenSVar")));f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",157);}
case 157:{f.Pc=f.Pop().Int==0?347:160;continue;}
case 160:{f.Push(f.Locals[2]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",164);}
case 164:{f.Push(f.Locals[1]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",168);}
case 168:{f.Push(JValue.R(rt.String("lblChooseAResult")));f.Pc=171;continue;}
case 171:{f.Push(JValue.I(0));f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",178);}
case 178:{f.Push(f.Locals[8]);f.Pc=180;continue;}
case 180:{f.Push(f.Locals[2]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/List;Lforge/game/player/Player;)I","invokevirtual",184);}
case 184:{f.Locals[10]=f.Pop();f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",189);}
case 189:{f.Push(JValue.R(rt.String("lblPlayerChooseValue")));f.Pc=192;continue;}
case 192:{f.Push(JValue.I(2));f.Pc=193;continue;}
case 193:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=196;continue;}
case 196:{f.StackOp("dup");f.Pc=197;continue;}
case 197:{f.Push(JValue.I(0));f.Pc=198;continue;}
case 198:{f.Push(f.Locals[2]);f.Pc=199;continue;}
case 199:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=200;continue;}
case 200:{f.StackOp("dup");f.Pc=201;continue;}
case 201:{f.Push(JValue.I(1));f.Pc=202;continue;}
case 202:{f.Push(f.Locals[10]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",207);}
case 207:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",211);}
case 211:{f.Locals[11]=f.Pop();f.Pc=213;continue;}
case 213:{f.Push(f.Locals[2]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",217);}
case 217:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",220);}
case 220:{f.Push(f.Locals[1]);f.Pc=221;continue;}
case 221:{f.Push(f.Locals[2]);f.Pc=222;continue;}
case 222:{f.Push(f.Locals[11]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[2]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",228);}
case 228:{f.Push(f.Locals[1]);f.Pc=229;continue;}
case 229:{f.Push(f.Locals[1]);f.Pc=230;continue;}
case 230:{f.Push(JValue.R(rt.String("ChosenSVar")));f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",236);}
case 236:{f.Push(f.Locals[10]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",241);}
case 241:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",244);}
case 244:{f.Push(f.Locals[1]);f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.String("OtherSVar")));f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",251);}
case 251:{f.Pc=f.Pop().Int==0?347:254;continue;}
case 254:{f.Push(f.Locals[8]);f.Pc=256;continue;}
case 256:{f.Push(JValue.I(0));f.Pc=257;continue;}
case 257:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",262);}
case 262:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=265;continue;}
case 265:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",268);}
case 268:{f.Locals[12]=f.Pop();f.Pc=270;continue;}
case 270:{f.Push(JValue.I(1));f.Pc=271;continue;}
case 271:{f.Locals[13]=f.Pop();f.Pc=273;continue;}
case 273:{f.Push(f.Locals[13]);f.Pc=275;continue;}
case 275:{f.Push(f.Locals[8]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",282);}
case 282:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?331:285;continue;}
case 285:{f.Push(f.Locals[8]);f.Pc=287;continue;}
case 287:{f.Push(f.Locals[13]);f.Pc=289;continue;}
case 289:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",294);}
case 294:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=297;continue;}
case 297:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",300);}
case 300:{f.Push(f.Locals[10]);f.Pc=302;continue;}
case 302:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?325:305;continue;}
case 305:{f.Push(f.Locals[8]);f.Pc=307;continue;}
case 307:{f.Push(f.Locals[13]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",314);}
case 314:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=317;continue;}
case 317:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",320);}
case 320:{f.Locals[12]=f.Pop();f.Pc=322;continue;}
case 322:{f.Pc=331;continue;}
case 325:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(1)));f.Pc=328;continue;}
case 328:{f.Pc=273;continue;}
case 331:{f.Push(f.Locals[1]);f.Pc=332;continue;}
case 332:{f.Push(f.Locals[1]);f.Pc=333;continue;}
case 333:{f.Push(JValue.R(rt.String("OtherSVar")));f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",339);}
case 339:{f.Push(f.Locals[12]);f.Pc=341;continue;}
case 341:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",344);}
case 344:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",347);}
case 347:{f.Push(f.Locals[1]);f.Pc=348;continue;}
case 348:{f.Push(JValue.R(rt.String("SubsForEach")));f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",354);}
case 354:{f.Pc=f.Pop().Int==0?403:357;continue;}
case 357:{f.Push(f.Locals[8]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",364);}
case 364:{f.Locals[10]=f.Pop();f.Pc=366;continue;}
case 366:{f.Push(f.Locals[10]);f.Pc=368;continue;}
case 368:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",373);}
case 373:{f.Pc=f.Pop().Int==0?400:376;continue;}
case 376:{f.Push(f.Locals[10]);f.Pc=378;continue;}
case 378:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",383);}
case 383:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=386;continue;}
case 386:{f.Locals[11]=f.Pop();f.Pc=388;continue;}
case 388:{f.Push(f.Locals[1]);f.Pc=389;continue;}
case 389:{f.Push(f.Locals[11]);f.Pc=391;continue;}
case 391:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",394);}
case 394:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","resolveSub","(Lforge/game/spellability/SpellAbility;I)V","invokestatic",397);}
case 397:{f.Pc=366;continue;}
case 400:{f.Pc=409;continue;}
case 403:{f.Push(f.Locals[1]);f.Pc=404;continue;}
case 404:{f.Push(f.Locals[9]);f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","resolveSub","(Lforge/game/spellability/SpellAbility;I)V","invokestatic",409);}
case 409:{f.Push(f.Locals[1]);f.Pc=410;continue;}
case 410:{f.Push(JValue.R(rt.String("NoteDoubles")));f.Pc=413;continue;}
case 413:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",416);}
case 416:{f.Pc=f.Pop().Int==0?484:419;continue;}
case 419:{if(!rt.EnsureInitialized(f,"java/util/HashSet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashSet")));f.Pc=422;continue;}
case 422:{f.StackOp("dup");f.Pc=423;continue;}
case 423:{return rt.Call(f,"java/util/HashSet","<init>","()V","invokespecial",426);}
case 426:{f.Locals[10]=f.Pop();f.Pc=428;continue;}
case 428:{f.Push(f.Locals[8]);f.Pc=430;continue;}
case 430:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",435);}
case 435:{f.Locals[11]=f.Pop();f.Pc=437;continue;}
case 437:{f.Push(f.Locals[11]);f.Pc=439;continue;}
case 439:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",444);}
case 444:{f.Pc=f.Pop().Int==0?484:447;continue;}
case 447:{f.Push(f.Locals[11]);f.Pc=449;continue;}
case 449:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",454);}
case 454:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=457;continue;}
case 457:{f.Locals[12]=f.Pop();f.Pc=459;continue;}
case 459:{f.Push(f.Locals[10]);f.Pc=461;continue;}
case 461:{f.Push(f.Locals[12]);f.Pc=463;continue;}
case 463:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",468);}
case 468:{f.Pc=f.Pop().Int!=0?481:471;continue;}
case 471:{f.Push(f.Locals[1]);f.Pc=472;continue;}
case 472:{f.Push(JValue.R(rt.String("Doubles")));f.Pc=475;continue;}
case 475:{f.Push(JValue.R(rt.String("1")));f.Pc=478;continue;}
case 478:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",481);}
case 481:{f.Pc=437;continue;}
case 484:{f.Push(f.Locals[9]);f.Pc=486;continue;}
case 486:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3687(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("Amount")));f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("1")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",15);}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",19);}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("Sides")));f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("6")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",29);}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",33);}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("RememberHighestPlayer")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",42);}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",48);}
case 48:{f.Locals[6]=f.Pop();f.Pc=50;continue;}
case 50:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=53;continue;}
case 53:{f.StackOp("dup");f.Pc=54;continue;}
case 54:{f.Push(f.Locals[6]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/player/PlayerCollection","size","()I","invokevirtual",59);}
case 59:{return rt.Call(f,"java/util/ArrayList","<init>","(I)V","invokespecial",62);}
case 62:{f.Locals[7]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[6]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",69);}
case 69:{f.Locals[8]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[8]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",78);}
case 78:{f.Pc=f.Pop().Int==0?160:81;continue;}
case 81:{f.Push(f.Locals[8]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",88);}
case 88:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=91;continue;}
case 91:{f.Locals[9]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("RerollResults")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",100);}
case 100:{f.Pc=f.Pop().Int==0?116:103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[2]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[9]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[4]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","rerollDice","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/player/Player;I)V","invokevirtual",113);}
case 113:{f.Pc=157;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[9]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[3]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[4]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","rollDice","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;II)I","invokevirtual",126);}
case 126:{f.Locals[10]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[7]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[10]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",135);}
case 135:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",140);}
case 140:{f.StackOp("pop");f.Pc=141;continue;}
case 141:{f.Push(f.Locals[1]);f.Pc=142;continue;}
case 142:{f.Push(JValue.R(rt.String("ToVisitYourAttractions")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",147);}
case 147:{f.Pc=f.Pop().Int==0?157:150;continue;}
case 150:{f.Push(f.Locals[9]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[10]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/player/Player","visitAttractions","(I)V","invokevirtual",157);}
case 157:{f.Pc=71;continue;}
case 160:{f.Push(f.Locals[5]);f.Pc=162;continue;}
case 162:{f.Pc=f.Pop().Int==0?274:165;continue;}
case 165:{f.Push(JValue.I(0));f.Pc=166;continue;}
case 166:{f.Locals[8]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[7]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",175);}
case 175:{f.Locals[9]=f.Pop();f.Pc=177;continue;}
case 177:{f.Push(f.Locals[9]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",184);}
case 184:{f.Pc=f.Pop().Int==0?219:187;continue;}
case 187:{f.Push(f.Locals[9]);f.Pc=189;continue;}
case 189:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",194);}
case 194:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=197;continue;}
case 197:{f.Locals[10]=f.Pop();f.Pc=199;continue;}
case 199:{f.Push(f.Locals[8]);f.Pc=201;continue;}
case 201:{f.Push(f.Locals[10]);f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",206);}
case 206:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?216:209;continue;}
case 209:{f.Push(f.Locals[10]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",214);}
case 214:{f.Locals[8]=f.Pop();f.Pc=216;continue;}
case 216:{f.Pc=177;continue;}
case 219:{f.Push(JValue.I(0));f.Pc=220;continue;}
case 220:{f.Locals[9]=f.Pop();f.Pc=222;continue;}
case 222:{f.Push(f.Locals[9]);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[7]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",231);}
case 231:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?274:234;continue;}
case 234:{f.Push(f.Locals[8]);f.Pc=236;continue;}
case 236:{f.Push(f.Locals[7]);f.Pc=238;continue;}
case 238:{f.Push(f.Locals[9]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",245);}
case 245:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=248;continue;}
case 248:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",251);}
case 251:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?268:254;continue;}
case 254:{f.Push(f.Locals[2]);f.Pc=255;continue;}
case 255:{f.Push(f.Locals[6]);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[9]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/game/player/PlayerCollection","get","(I)Ljava/lang/Object;","invokevirtual",262);}
case 262:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",268);}
case 268:{f.Locals[9]=JValue.I(unchecked(f.Locals[9].Int+(1)));f.Pc=271;continue;}
case 271:{f.Pc=222;continue;}
case 274:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3688(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[5]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getStoredRolls","()Ljava/util/List;","invokevirtual",9);}
case 9:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[6]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[6]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?82:26;continue;}
case 26:{f.Push(f.Locals[6]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[7]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",42);}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(null));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",47);}
case 47:{f.Push(JValue.R(rt.String("lblRerollResult")));f.Pc=50;continue;}
case 50:{f.Push(JValue.I(1));f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=54;continue;}
case 54:{f.StackOp("dup");f.Pc=55;continue;}
case 55:{f.Push(JValue.I(0));f.Pc=56;continue;}
case 56:{f.Push(f.Locals[7]);f.Pc=58;continue;}
case 58:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",62);}
case 62:{f.Push(JValue.R(null));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int==0?79:69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[7]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Pc=16;continue;}
case 82:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",85);}
case 85:{f.Locals[6]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",94);}
case 94:{f.Locals[7]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[7]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",103);}
case 103:{f.Pc=f.Pop().Int==0?147:106;continue;}
case 106:{f.Push(f.Locals[7]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",113);}
case 113:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=116;continue;}
case 116:{f.Locals[8]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[1]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[3]);f.Pc=121;continue;}
case 121:{f.Push(JValue.I(1));f.Pc=122;continue;}
case 122:{f.Push(f.Locals[4]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/ability/effects/RollDiceEffect","rollDice","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;II)I","invokevirtual",127);}
case 127:{f.Locals[9]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[6]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[8]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[9]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",138);}
case 138:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",143);}
case 143:{f.StackOp("pop");f.Pc=144;continue;}
case 144:{f.Pc=96;continue;}
case 147:{f.Push(f.Locals[2]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[6]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/card/Card","replaceStoredRoll","(Ljava/util/Map;)V","invokevirtual",153);}
case 153:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3689(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("RollModificationsLimit")));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("ModsThisTurn")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getSVar","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Push(JValue.R(rt.String("\\$")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Locals[2]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",26);}
case 26:{f.Locals[3]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("None")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int!=0?45:37;continue;}
case 37:{f.Push(f.Locals[3]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",42);}
case 42:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?49:45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{f.Pc=50;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
