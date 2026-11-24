// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C365{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/PutStickerEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("PLACED","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"StickersPlaced"));
c.Add(new JField("VOWELS","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"StickerUniqueVowels"));
c.Add(new JMethod(3600,"forge/game/ability/effects/PutStickerEffect","<init>","()V",1,1,1,new JHandler[]{},M3600));
c.Add(new JMethod(3601,"forge/game/ability/effects/PutStickerEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,4,new JHandler[]{},M3601));
c.Add(new JMethod(3602,"forge/game/ability/effects/PutStickerEffect","chooseObjects","(Lforge/game/spellability/SpellAbility;Lforge/game/Game;)Ljava/util/List;",10,8,6,new JHandler[]{},M3602));
c.Add(new JMethod(3603,"forge/game/ability/effects/PutStickerEffect","availableStickers","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Ljava/util/List;",9,7,4,new JHandler[]{},M3603));
c.Add(new JMethod(3604,"forge/game/ability/effects/PutStickerEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,12,7,new JHandler[]{},M3604));
}

internal static JStep M3600(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3601(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",16);}
case 16:{f.Push(JValue.R(rt.String(" puts ")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("Kind")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?72:31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("Kind")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",37);}
case 37:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",40);}
case 40:{f.Locals[3]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/util/Lang","startsWithVowel","(Ljava/lang/String;)Z","invokestatic",46);}
case 46:{f.Pc=f.Pop().Int==0?54:49;continue;}
case 49:{f.Push(JValue.R(rt.String("an ")));f.Pc=51;continue;}
case 51:{f.Pc=56;continue;}
case 54:{f.Push(JValue.R(rt.String("a ")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",59);}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",63);}
case 63:{f.Push(JValue.R(rt.String(" ")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",68);}
case 68:{f.StackOp("pop");f.Pc=69;continue;}
case 69:{f.Pc=79;continue;}
case 72:{f.Push(f.Locals[2]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("a ")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("sticker on ")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",85);}
case 85:{f.StackOp("pop");f.Pc=86;continue;}
case 86:{f.Push(f.Locals[1]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int!=0?102:93;continue;}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("Defined")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Int==0?119:102;continue;}
case 102:{f.Push(f.Locals[2]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/ability/effects/PutStickerEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",107);}
case 107:{f.Push(JValue.R(rt.String(", ")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",112);}
case 112:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",115);}
case 115:{f.StackOp("pop");f.Pc=116;continue;}
case 116:{f.Pc=142;continue;}
case 119:{f.Push(f.Locals[2]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=123;continue;}
case 123:{f.Push(JValue.R(rt.String("a permanent they own")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",128);}
case 128:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",131);}
case 131:{f.Push(JValue.R(rt.String("choose ")));f.Pc=133;continue;}
case 133:{f.Push(JValue.R(rt.String("")));f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",138);}
case 138:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",141);}
case 141:{f.StackOp("pop");f.Pc=142;continue;}
case 142:{f.Push(f.Locals[2]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",146);}
case 146:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3602(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Choices")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int!=0?14:9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/effects/PutStickerEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",13);}
case 13:{return JStep.Return(f.Pop());}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?40:28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("ChoiceZone")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",34);}
case 34:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",37);}
case 37:{f.Pc=43;continue;}
case 40:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=43;continue;}
case 43:{f.Locals[3]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",49);}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(JValue.R(rt.String("Choices")));f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",55);}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",60);}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",64);}
case 64:{f.Locals[4]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/card/CardPredicates","isOwner","(Lforge/game/player/Player;)Ljava/util/function/Predicate;","invokestatic",72);}
case 72:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",75);}
case 75:{f.Locals[4]=f.Pop();f.Pc=77;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",82);}
case 82:{f.Pc=f.Pop().Int==0?93:85;continue;}
case 85:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=88;continue;}
case 88:{f.StackOp("dup");f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",92);}
case 92:{return JStep.Return(f.Pop());}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Int==0?111:102;continue;}
case 102:{f.Push(f.Locals[0]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("ChoiceTitle")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",108);}
case 108:{f.Pc=113;continue;}
case 111:{f.Push(JValue.R(rt.String("Choose a permanent to put a sticker on")));f.Pc=113;continue;}
case 113:{f.Locals[5]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[2]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",119);}
case 119:{f.Push(f.Locals[4]);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[5]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[0]);f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String("Optional")));f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",130);}
case 130:{f.Push(JValue.R(null));f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;ZLjava/util/Map;)Lforge/game/GameEntity;","invokevirtual",134);}
case 134:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=137;continue;}
case 137:{f.Locals[6]=f.Pop();f.Pc=139;continue;}
case 139:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=142;continue;}
case 142:{f.StackOp("dup");f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",146);}
case 146:{f.Locals[7]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[6]);f.Pc=150;continue;}
case 150:{f.Pc=f.Pop().Reference==null?161:153;continue;}
case 153:{f.Push(f.Locals[7]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[6]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",160);}
case 160:{f.StackOp("pop");f.Pc=161;continue;}
case 161:{f.Push(f.Locals[7]);f.Pc=163;continue;}
case 163:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3603(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("NoTicketCost")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?14:9;continue;}
case 9:{f.Push(JValue.I(2147483647));f.Pc=11;continue;}
case 11:{f.Pc=21;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","TICKET","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","TICKET","Lforge/game/card/CounterEnumType;"));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/player/Player","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("MaxTickets")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?50:31;continue;}
case 31:{f.Push(f.Locals[2]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",36);}
case 36:{f.Push(f.Locals[0]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("MaxTickets")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",42);}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",46);}
case 46:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",49);}
case 49:{f.Locals[2]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("Kind")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?71:59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.String("Kind")));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",65);}
case 65:{return rt.Call(f,"forge/game/card/sticker/StickerKind","smartValueOf","(Ljava/lang/String;)Lforge/game/card/sticker/StickerKind;","invokestatic",68);}
case 68:{f.Pc=72;continue;}
case 71:{f.Push(JValue.R(null));f.Pc=72;continue;}
case 72:{f.Locals[3]=f.Pop();f.Pc=73;continue;}
case 73:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",80);}
case 80:{f.Locals[4]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/card/sticker/StickerSheet","getAvailableStickers","(Lforge/game/player/Player;I)Ljava/util/List;","invokestatic",87);}
case 87:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",92);}
case 92:{f.Locals[5]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[5]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",101);}
case 101:{f.Pc=f.Pop().Int==0?142:104;continue;}
case 104:{f.Push(f.Locals[5]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",111);}
case 111:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/sticker/Sticker"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=114;continue;}
case 114:{f.Locals[6]=f.Pop();f.Pc=116;continue;}
case 116:{f.Push(f.Locals[3]);f.Pc=117;continue;}
case 117:{f.Pc=f.Pop().Reference==null?129:120;continue;}
case 120:{f.Push(f.Locals[6]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/card/sticker/Sticker","getKind","()Lforge/game/card/sticker/StickerKind;","invokevirtual",125);}
case 125:{f.Push(f.Locals[3]);f.Pc=126;continue;}
case 126:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?139:129;continue;}
case 129:{f.Push(f.Locals[4]);f.Pc=131;continue;}
case 131:{f.Push(f.Locals[6]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",138);}
case 138:{f.StackOp("pop");f.Pc=139;continue;}
case 139:{f.Pc=94;continue;}
case 142:{f.Push(f.Locals[4]);f.Pc=144;continue;}
case 144:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3604(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Optional")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("StickerUniqueVowels")));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("0")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",23);}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("StickersPlaced")));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("0")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",31);}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{f.Locals[4]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/ability/effects/PutStickerEffect","chooseObjects","(Lforge/game/spellability/SpellAbility;Lforge/game/Game;)Ljava/util/List;","invokestatic",39);}
case 39:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",44);}
case 44:{f.Locals[5]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",53);}
case 53:{f.Pc=f.Pop().Int==0?330:56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{f.Locals[6]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[6]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",73);}
case 73:{f.Locals[7]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[7]);f.Pc=77;continue;}
case 77:{f.Pc=f.Pop().Reference==null?46:80;continue;}
case 80:{f.Push(f.Locals[7]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[1]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",86);}
case 86:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int!=0?95:92;continue;}
case 92:{f.Pc=46;continue;}
case 95:{f.Push(f.Locals[2]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[6]);f.Pc=98;continue;}
case 98:{f.Push(JValue.R(null));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",102);}
case 102:{f.Push(f.Locals[6]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int!=0?113:110;continue;}
case 110:{f.Pc=46;continue;}
case 113:{f.Push(f.Locals[1]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[7]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/ability/effects/PutStickerEffect","availableStickers","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Ljava/util/List;","invokestatic",119);}
case 119:{f.Locals[8]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[8]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",128);}
case 128:{f.Pc=f.Pop().Int==0?134:131;continue;}
case 131:{f.Pc=46;continue;}
case 134:{f.Push(f.Locals[7]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",139);}
case 139:{f.Push(f.Locals[8]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[6]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{f.Push(f.Locals[3]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/player/PlayerController","chooseSticker","(Ljava/util/List;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Z)Lforge/game/card/sticker/Sticker;","invokevirtual",148);}
case 148:{f.Locals[9]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[9]);f.Pc=152;continue;}
case 152:{f.Pc=f.Pop().Reference!=null?158:155;continue;}
case 155:{f.Pc=46;continue;}
case 158:{f.Push(f.Locals[9]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/card/sticker/Sticker","getTickets","()I","invokevirtual",163);}
case 163:{f.Pc=f.Pop().Int<=0?191:166;continue;}
case 166:{f.Push(f.Locals[1]);f.Pc=167;continue;}
case 167:{f.Push(JValue.R(rt.String("NoTicketCost")));f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",172);}
case 172:{f.Pc=f.Pop().Int!=0?191:175;continue;}
case 175:{f.Push(f.Locals[7]);f.Pc=177;continue;}
case 177:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","TICKET","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","TICKET","Lforge/game/card/CounterEnumType;"));f.Pc=180;continue;}
case 180:{f.Push(f.Locals[9]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/card/sticker/Sticker","getTickets","()I","invokevirtual",185);}
case 185:{f.Push(f.Locals[7]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/player/Player","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",190);}
case 190:{f.StackOp("pop");f.Pc=191;continue;}
case 191:{f.Push(JValue.I(0));f.Pc=192;continue;}
case 192:{f.Locals[10]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(f.Locals[9]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/card/sticker/Sticker","getKind","()Lforge/game/card/sticker/StickerKind;","invokevirtual",199);}
case 199:{if(!rt.StaticReady(f,"forge/game/card/sticker/StickerKind","NAME","Lforge/game/card/sticker/StickerKind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/sticker/StickerKind","NAME","Lforge/game/card/sticker/StickerKind;"));f.Pc=202;continue;}
case 202:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?233:205;continue;}
case 205:{f.Push(f.Locals[7]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",210);}
case 210:{f.Push(f.Locals[9]);f.Pc=212;continue;}
case 212:{f.Push(f.Locals[6]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/player/PlayerController","chooseStickerNamePosition","(Lforge/game/card/sticker/Sticker;Lforge/game/card/Card;)I","invokevirtual",217);}
case 217:{f.Locals[10]=f.Pop();f.Pc=219;continue;}
case 219:{f.Push(f.Locals[1]);f.Pc=220;continue;}
case 220:{f.Push(JValue.R(rt.String("StickerUniqueVowels")));f.Pc=222;continue;}
case 222:{f.Push(f.Locals[9]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/card/sticker/Sticker","getUniqueVowelCount","()I","invokevirtual",227);}
case 227:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",230);}
case 230:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",233);}
case 233:{f.Push(f.Locals[6]);f.Pc=235;continue;}
case 235:{if(!rt.EnsureInitialized(f,"forge/game/card/sticker/AppliedSticker"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/sticker/AppliedSticker")));f.Pc=238;continue;}
case 238:{f.StackOp("dup");f.Pc=239;continue;}
case 239:{f.Push(f.Locals[9]);f.Pc=241;continue;}
case 241:{f.Push(f.Locals[2]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",245);}
case 245:{f.Push(f.Locals[10]);f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/game/card/sticker/AppliedSticker","<init>","(Lforge/game/card/sticker/Sticker;JI)V","invokespecial",250);}
case 250:{return rt.Call(f,"forge/game/card/Card","addSticker","(Lforge/game/card/sticker/AppliedSticker;)V","invokevirtual",253);}
case 253:{f.Push(f.Locals[1]);f.Pc=254;continue;}
case 254:{f.Push(JValue.R(rt.String("StickersPlaced")));f.Pc=256;continue;}
case 256:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=259;continue;}
case 259:{f.Push(f.Locals[4]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",264);}
case 264:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",267);}
case 267:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",270);}
case 270:{f.Locals[11]=f.Pop();f.Pc=272;continue;}
case 272:{f.Push(f.Locals[11]);f.Pc=274;continue;}
case 274:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Card","Lforge/game/ability/AbilityKey;"));f.Pc=277;continue;}
case 277:{f.Push(f.Locals[6]);f.Pc=279;continue;}
case 279:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",284);}
case 284:{f.StackOp("pop");f.Pc=285;continue;}
case 285:{f.Push(f.Locals[11]);f.Pc=287;continue;}
case 287:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=290;continue;}
case 290:{f.Push(f.Locals[7]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",297);}
case 297:{f.StackOp("pop");f.Pc=298;continue;}
case 298:{f.Push(f.Locals[11]);f.Pc=300;continue;}
case 300:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","StickerKind","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","StickerKind","Lforge/game/ability/AbilityKey;"));f.Pc=303;continue;}
case 303:{f.Push(f.Locals[9]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"forge/game/card/sticker/Sticker","getKind","()Lforge/game/card/sticker/StickerKind;","invokevirtual",308);}
case 308:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",313);}
case 313:{f.StackOp("pop");f.Pc=314;continue;}
case 314:{f.Push(f.Locals[2]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",318);}
case 318:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","StickerPlaced","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","StickerPlaced","Lforge/game/trigger/TriggerType;"));f.Pc=321;continue;}
case 321:{f.Push(f.Locals[11]);f.Pc=323;continue;}
case 323:{f.Push(JValue.I(0));f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",327);}
case 327:{f.Pc=46;continue;}
case 330:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
