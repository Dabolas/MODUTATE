// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C425{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/UntapEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3810,"forge/game/ability/effects/UntapEffect","<init>","()V",1,1,1,new JHandler[]{},M3810));
c.Add(new JMethod(3811,"forge/game/ability/effects/UntapEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,3,3,new JHandler[]{},M3811));
c.Add(new JMethod(3812,"forge/game/ability/effects/UntapEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,10,4,new JHandler[]{},M3812));
c.Add(new JMethod(3813,"forge/game/ability/effects/UntapEffect","untapChoose","(Lforge/game/spellability/SpellAbility;Z)V",10,12,8,new JHandler[]{},M3813));
c.Add(new JMethod(3814,"forge/game/ability/effects/UntapEffect","lambda$untapChoose$0","(Lforge/game/card/Card;)Z",4106,1,3,new JHandler[]{},M3814));
}

internal static JStep M3810(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3811(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Untap ")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("UntapUpTo")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?64:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("up to ")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",30);}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.R(rt.String("Amount")));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",36);}
case 36:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",39);}
case 39:{f.Push(JValue.R(rt.String(" ")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",44);}
case 44:{f.StackOp("pop");f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(JValue.R(rt.String("UntapType")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",52);}
case 52:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",55);}
case 55:{f.Push(JValue.R(rt.String("s")));f.Pc=57;continue;}
case 57:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",60);}
case 60:{f.StackOp("pop");f.Pc=61;continue;}
case 61:{f.Pc=76;continue;}
case 64:{f.Push(f.Locals[2]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[1]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/ability/effects/UntapEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",69);}
case 69:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",72);}
case 72:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",75);}
case 75:{f.StackOp("pop");f.Pc=76;continue;}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.String(".")));f.Pc=79;continue;}
case 79:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",82);}
case 82:{f.StackOp("pop");f.Pc=83;continue;}
case 83:{f.Push(f.Locals[2]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",87);}
case 87:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3812(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("ETB")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",16);}
case 16:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("UntapUpTo")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",27);}
case 27:{f.Pc=f.Pop().Int==0?38:30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/ability/effects/UntapEffect","untapChoose","(Lforge/game/spellability/SpellAbility;Z)V","invokestatic",35);}
case 35:{f.Pc=247;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String("UntapExactly")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",44);}
case 44:{f.Pc=f.Pop().Int==0?55:47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(JValue.I(1));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/ability/effects/UntapEffect","untapChoose","(Lforge/game/spellability/SpellAbility;Z)V","invokestatic",52);}
case 52:{f.Pc=247;continue;}
case 55:{f.Push(f.Locals[1]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/game/ability/effects/UntapEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",59);}
case 59:{f.Locals[5]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/CardUtil","getRadiance","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",67);}
case 67:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=74;continue;}
case 74:{f.StackOp("dup");f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",78);}
case 78:{f.Locals[6]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",85);}
case 85:{f.Locals[7]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[7]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",94);}
case 94:{f.Pc=f.Pop().Int==0?185:97;continue;}
case 97:{f.Push(f.Locals[7]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",104);}
case 104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=107;continue;}
case 107:{f.Locals[8]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[8]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?120:117;continue;}
case 117:{f.Pc=87;continue;}
case 120:{f.Push(f.Locals[8]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",125);}
case 125:{f.Pc=f.Pop().Int==0?172:128;continue;}
case 128:{f.Push(f.Locals[4]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[8]);f.Pc=132;continue;}
case 132:{f.Push(JValue.R(null));f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",136);}
case 136:{f.Locals[9]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[9]);f.Pc=140;continue;}
case 140:{f.Pc=f.Pop().Reference==null?87:143;continue;}
case 143:{f.Push(f.Locals[8]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[9]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",150);}
case 150:{f.Pc=f.Pop().Int!=0?156:153;continue;}
case 153:{f.Pc=87;continue;}
case 156:{f.Push(f.Locals[9]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/card/Card","untap","()Z","invokevirtual",161);}
case 161:{f.Pc=f.Pop().Int==0?172:164;continue;}
case 164:{f.Push(f.Locals[6]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[9]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",171);}
case 171:{f.StackOp("pop");f.Pc=172;continue;}
case 172:{f.Push(f.Locals[3]);f.Pc=173;continue;}
case 173:{f.Pc=f.Pop().Int==0?182:176;continue;}
case 176:{f.Push(f.Locals[8]);f.Pc=178;continue;}
case 178:{f.Push(JValue.I(0));f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/card/Card","setTapped","(Z)V","invokevirtual",182);}
case 182:{f.Pc=87;continue;}
case 185:{f.Push(f.Locals[6]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",190);}
case 190:{f.Pc=f.Pop().Int!=0?247:193;continue;}
case 193:{f.Push(f.Locals[3]);f.Pc=194;continue;}
case 194:{f.Pc=f.Pop().Int!=0?247:197;continue;}
case 197:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",200);}
case 200:{f.Locals[7]=f.Pop();f.Pc=202;continue;}
case 202:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",205);}
case 205:{f.Locals[8]=f.Pop();f.Pc=207;continue;}
case 207:{f.Push(f.Locals[8]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[2]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[6]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",217);}
case 217:{f.StackOp("pop");f.Pc=218;continue;}
case 218:{f.Push(f.Locals[7]);f.Pc=220;continue;}
case 220:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"));f.Pc=223;continue;}
case 223:{f.Push(f.Locals[8]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",230);}
case 230:{f.StackOp("pop");f.Pc=231;continue;}
case 231:{f.Push(f.Locals[2]);f.Pc=232;continue;}
case 232:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",235);}
case 235:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",238);}
case 238:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","UntapAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","UntapAll","Lforge/game/trigger/TriggerType;"));f.Pc=241;continue;}
case 241:{f.Push(f.Locals[7]);f.Pc=243;continue;}
case 243:{f.Push(JValue.I(0));f.Pc=244;continue;}
case 244:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",247);}
case 247:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3813(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Amount")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",18);}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("UntapType")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",25);}
case 25:{f.Locals[4]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",31);}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("Defined")));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",41);}
case 41:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",44);}
case 44:{f.Locals[5]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[5]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",53);}
case 53:{f.Pc=f.Pop().Int==0?249:56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",63);}
case 63:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=66;continue;}
case 66:{f.Locals[6]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[6]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",73);}
case 73:{f.Pc=f.Pop().Int!=0?79:76;continue;}
case 76:{f.Pc=46;continue;}
case 79:{f.Push(f.Locals[6]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",84);}
case 84:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",90);}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",96);}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",100);}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",104);}
case 104:{f.Locals[7]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[7]);f.Pc=108;continue;}
case 108:{return rt.DynamicCall(f,"forge/game/ability/effects/UntapEffect:3813:108:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",113);}
case 113:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",116);}
case 116:{f.Locals[7]=f.Pop();f.Pc=118;continue;}
case 118:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=121;continue;}
case 121:{f.StackOp("dup");f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",125);}
case 125:{f.Locals[8]=f.Pop();f.Pc=127;continue;}
case 127:{f.Push(f.Locals[6]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",132);}
case 132:{f.Push(f.Locals[7]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[0]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",138);}
case 138:{f.Push(JValue.R(rt.String("lblSelectCardToUntap")));f.Pc=140;continue;}
case 140:{f.Push(JValue.I(0));f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",147);}
case 147:{f.Push(f.Locals[1]);f.Pc=148;continue;}
case 148:{f.Pc=f.Pop().Int==0?155:151;continue;}
case 151:{f.Push(f.Locals[3]);f.Pc=152;continue;}
case 152:{f.Pc=156;continue;}
case 155:{f.Push(JValue.I(0));f.Pc=156;continue;}
case 156:{f.Push(f.Locals[3]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[1]);f.Pc=158;continue;}
case 158:{f.Pc=f.Pop().Int!=0?165:161;continue;}
case 161:{f.Push(JValue.I(1));f.Pc=162;continue;}
case 162:{f.Pc=166;continue;}
case 165:{f.Push(JValue.I(0));f.Pc=166;continue;}
case 166:{f.Push(JValue.R(null));f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/player/PlayerController","chooseCardsForEffect","(Lforge/game/card/CardCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;IIZLjava/util/Map;)Lforge/game/card/CardCollectionView;","invokevirtual",170);}
case 170:{f.Locals[9]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(f.Locals[9]);f.Pc=174;continue;}
case 174:{f.Pc=f.Pop().Reference==null?227:177;continue;}
case 177:{f.Push(f.Locals[9]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",184);}
case 184:{f.Locals[10]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(f.Locals[10]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",193);}
case 193:{f.Pc=f.Pop().Int==0?227:196;continue;}
case 196:{f.Push(f.Locals[10]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",203);}
case 203:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=206;continue;}
case 206:{f.Locals[11]=f.Pop();f.Pc=208;continue;}
case 208:{f.Push(f.Locals[11]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/card/Card","untap","()Z","invokevirtual",213);}
case 213:{f.Pc=f.Pop().Int==0?224:216;continue;}
case 216:{f.Push(f.Locals[8]);f.Pc=218;continue;}
case 218:{f.Push(f.Locals[11]);f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",223);}
case 223:{f.StackOp("pop");f.Pc=224;continue;}
case 224:{f.Pc=186;continue;}
case 227:{f.Push(f.Locals[8]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",232);}
case 232:{f.Pc=f.Pop().Int!=0?246:235;continue;}
case 235:{f.Push(f.Locals[2]);f.Pc=236;continue;}
case 236:{f.Push(f.Locals[6]);f.Pc=238;continue;}
case 238:{f.Push(f.Locals[8]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",245);}
case 245:{f.StackOp("pop");f.Pc=246;continue;}
case 246:{f.Pc=46;continue;}
case 249:{f.Push(f.Locals[2]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",255);}
case 255:{f.Pc=f.Pop().Int!=0?294:258;continue;}
case 258:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",261);}
case 261:{f.Locals[5]=f.Pop();f.Pc=263;continue;}
case 263:{f.Push(f.Locals[5]);f.Pc=265;continue;}
case 265:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"));f.Pc=268;continue;}
case 268:{f.Push(f.Locals[2]);f.Pc=269;continue;}
case 269:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",274);}
case 274:{f.StackOp("pop");f.Pc=275;continue;}
case 275:{f.Push(f.Locals[0]);f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",279);}
case 279:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",282);}
case 282:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",285);}
case 285:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","UntapAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","UntapAll","Lforge/game/trigger/TriggerType;"));f.Pc=288;continue;}
case 288:{f.Push(f.Locals[5]);f.Pc=290;continue;}
case 290:{f.Push(JValue.I(0));f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",294);}
case 294:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3814(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/Card","canUntap","(Lforge/game/player/Player;Z)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
