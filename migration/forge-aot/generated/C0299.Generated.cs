// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C299{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/EncodeEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3379,"forge/game/ability/effects/EncodeEffect","<init>","()V",1,1,1,new JHandler[]{},M3379));
c.Add(new JMethod(3380,"forge/game/ability/effects/EncodeEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,3,2,new JHandler[]{},M3380));
c.Add(new JMethod(3381,"forge/game/ability/effects/EncodeEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,11,9,new JHandler[]{},M3381));
}

internal static JStep M3379(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3380(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?13:10;continue;}
case 10:{f.Push(JValue.R(rt.String("")));f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
case 13:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",20);}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",26);}
case 26:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String(" chooses a card to encode with Cipher.")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",36);}
case 36:{f.StackOp("pop");f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",41);}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3381(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","isToken","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?24:23;continue;}
case 23:{return JStep.ReturnVoid;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",28);}
case 28:{return rt.Call(f,"forge/game/player/Player","getCreaturesInPlay","()Lforge/game/card/CardCollection;","invokevirtual",31);}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Int==0?44:43;continue;}
case 43:{return JStep.ReturnVoid;}
case 44:{f.Push(f.Locals[3]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",48);}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{f.Push(JValue.R(null));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",53);}
case 53:{f.Push(JValue.R(rt.String("lblDoYouWantExileCardAndEncodeOntoYouCreature")));f.Pc=55;continue;}
case 55:{f.Push(JValue.I(1));f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=59;continue;}
case 59:{f.StackOp("dup");f.Pc=60;continue;}
case 60:{f.Push(JValue.I(0));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/Card","getTranslatedName","()Ljava/lang/String;","invokevirtual",65);}
case 65:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",69);}
case 69:{f.Push(JValue.R(null));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Ljava/util/Map;)Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int!=0?77:76;continue;}
case 76:{return JStep.ReturnVoid;}
case 77:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",80);}
case 80:{f.Locals[6]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[6]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",88);}
case 88:{f.Locals[7]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",95);}
case 95:{f.Push(f.Locals[2]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[6]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/GameAction","exile","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",102);}
case 102:{f.Locals[8]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[7]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[4]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",112);}
case 112:{f.Push(f.Locals[3]);f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",116);}
case 116:{f.Push(f.Locals[5]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",122);}
case 122:{f.Push(JValue.R(rt.String("lblChooseACreatureYouControlToEncode")));f.Pc=124;continue;}
case 124:{f.Push(JValue.I(0));f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",131);}
case 131:{return rt.DynamicCall(f,"forge/game/ability/effects/EncodeEffect:3381:131:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",136);}
case 136:{f.Push(JValue.I(0));f.Pc=137;continue;}
case 137:{f.Push(JValue.R(null));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",141);}
case 141:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=144;continue;}
case 144:{f.Locals[9]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[9]);f.Pc=148;continue;}
case 148:{f.Pc=f.Pop().Reference!=null?152:151;continue;}
case 151:{return JStep.ReturnVoid;}
case 152:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=155;continue;}
case 155:{f.StackOp("dup");f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",159);}
case 159:{f.Locals[10]=f.Pop();f.Pc=161;continue;}
case 161:{f.Push(f.Locals[10]);f.Pc=163;continue;}
case 163:{f.Push(JValue.R(rt.String("Encoding ")));f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",168);}
case 168:{f.Push(f.Locals[2]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",172);}
case 172:{f.Push(JValue.R(rt.String(" to ")));f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",177);}
case 177:{f.Push(f.Locals[9]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",182);}
case 182:{f.StackOp("pop");f.Pc=183;continue;}
case 183:{f.Push(f.Locals[4]);f.Pc=185;continue;}
case 185:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventAddLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventAddLog")));f.Pc=188;continue;}
case 188:{f.StackOp("dup");f.Pc=189;continue;}
case 189:{if(!rt.StaticReady(f,"forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameLogEntryType","STACK_RESOLVE","Lforge/game/GameLogEntryType;"));f.Pc=192;continue;}
case 192:{f.Push(f.Locals[10]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",197);}
case 197:{return rt.Call(f,"forge/game/event/GameEventAddLog","<init>","(Lforge/game/GameLogEntryType;Ljava/lang/String;)V","invokespecial",200);}
case 200:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",203);}
case 203:{f.Push(f.Locals[9]);f.Pc=205;continue;}
case 205:{f.Push(f.Locals[8]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/card/Card","addEncodedCard","(Lforge/game/card/Card;)V","invokevirtual",210);}
case 210:{f.Push(f.Locals[8]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[9]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/card/Card","setEncodingCard","(Lforge/game/card/Card;)V","invokevirtual",217);}
case 217:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
