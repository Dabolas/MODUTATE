// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C700{
internal static JClass Build(){var c=new JClass("forge/game/phase/Untap","forge/game/phase/Phase",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(4515266331266259123L),null));
c.Add(new JField("game","Lforge/game/Game;",false,JValue.Default("Lforge/game/Game;"),null));
c.Add(new JMethod(7950,"forge/game/phase/Untap","<init>","(Lforge/game/Game;)V",1,2,2,new JHandler[]{},M7950));
c.Add(new JMethod(7951,"forge/game/phase/Untap","executeAt","()V",1,3,2,new JHandler[]{},M7951));
c.Add(new JMethod(7952,"forge/game/phase/Untap","doUntap","(Lforge/game/player/Player;)V",2,14,7,new JHandler[]{},M7952));
c.Add(new JMethod(7953,"forge/game/phase/Untap","optionalUntap","(Lforge/game/card/Card;Lforge/game/player/Player;)Z",10,8,5,new JHandler[]{},M7953));
c.Add(new JMethod(7954,"forge/game/phase/Untap","doPhasing","(Lforge/game/player/Player;)V",9,8,4,new JHandler[]{},M7954));
c.Add(new JMethod(7955,"forge/game/phase/Untap","doDayTime","(Lforge/game/player/Player;)V",10,4,2,new JHandler[]{},M7955));
c.Add(new JMethod(7956,"forge/game/phase/Untap","lambda$doDayTime$4","(Lforge/game/player/Player;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M7956));
c.Add(new JMethod(7957,"forge/game/phase/Untap","lambda$doPhasing$3","(Lforge/game/player/Player;Lforge/game/card/Card;)Z",4106,2,2,new JHandler[]{},M7957));
c.Add(new JMethod(7958,"forge/game/phase/Untap","lambda$doUntap$2","(Lforge/game/player/Player;)Lforge/game/card/CardCollection;",4106,1,2,new JHandler[]{},M7958));
c.Add(new JMethod(7959,"forge/game/phase/Untap","lambda$doUntap$1","(Lforge/game/player/Player;)Lforge/game/card/CardCollection;",4106,1,2,new JHandler[]{},M7959));
c.Add(new JMethod(7960,"forge/game/phase/Untap","lambda$doUntap$0","(Lforge/game/player/Player;Lforge/game/card/Card;)Z",4106,2,3,new JHandler[]{},M7960));
}

internal static JStep M7950(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/phase/PhaseType","UNTAP","Lforge/game/phase/PhaseType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/phase/PhaseType","UNTAP","Lforge/game/phase/PhaseType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/phase/Phase","<init>","(Lforge/game/phase/PhaseType;)V","invokespecial",7);}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/phase/Untap","game","Lforge/game/Game;",value);f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7951(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/phase/Phase","executeAt","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Untap","game","Lforge/game/Game;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",17);}
case 17:{f.Locals[1]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",24);}
case 24:{f.Pc=f.Pop().Int==0?44:27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[2]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/phase/Untap","doPhasing","(Lforge/game/player/Player;)V","invokestatic",41);}
case 41:{f.Pc=18;continue;}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Untap","game","Lforge/game/Game;"));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",51);}
case 51:{return rt.Call(f,"forge/game/phase/PhaseHandler","getPreviousPlayerTurn","()Lforge/game/player/Player;","invokevirtual",54);}
case 54:{return rt.Call(f,"forge/game/phase/Untap","doDayTime","(Lforge/game/player/Player;)V","invokestatic",57);}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Untap","game","Lforge/game/Game;"));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",64);}
case 64:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","()V","invokevirtual",67);}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Untap","game","Lforge/game/Game;"));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",74);}
case 74:{return rt.Call(f,"forge/game/phase/PhaseHandler","getActivePlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",77);}
case 77:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",80);}
case 80:{f.Locals[1]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",87);}
case 87:{f.Pc=f.Pop().Int==0?108:90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",96);}
case 96:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=99;continue;}
case 99:{f.Locals[2]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[0]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/phase/Untap","doUntap","(Lforge/game/player/Player;)V","invokevirtual",105);}
case 105:{f.Pc=81;continue;}
case 108:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7952(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",3);}
case 3:{f.Locals[2]=f.Pop();f.Pc=4;continue;}
case 4:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=7;continue;}
case 7:{f.StackOp("dup");f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",15);}
case 15:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",18);}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"forge/game/card/CardZoneTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardZoneTable")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Untap","game","Lforge/game/Game;"));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/Game","getLastStateBattlefield","()Lforge/game/card/CardCollectionView;","invokevirtual",30);}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Untap","game","Lforge/game/Game;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/Game","getLastStateGraveyard","()Lforge/game/card/CardCollectionView;","invokevirtual",37);}
case 37:{return rt.Call(f,"forge/game/card/CardZoneTable","<init>","(Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;)V","invokespecial",40);}
case 40:{f.Locals[4]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("During your next untap step, as you untap your permanents, return CARDNAME to its owner's hand.")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/card/CardLists","getKeyword","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",48);}
case 48:{f.Locals[5]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",55);}
case 55:{f.Locals[6]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[6]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",64);}
case 64:{f.Pc=f.Pop().Int==0?116:67;continue;}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",74);}
case 74:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=77;continue;}
case 77:{f.Locals[7]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Untap","game","Lforge/game/Game;"));f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",86);}
case 86:{f.Push(f.Locals[7]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(null));f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/GameAction","moveToHand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/game/card/Card;","invokevirtual",92);}
case 92:{f.Locals[8]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[4]);f.Pc=96;continue;}
case 96:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=99;continue;}
case 99:{f.Push(f.Locals[8]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",104);}
case 104:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",107);}
case 107:{f.Push(f.Locals[8]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/card/CardZoneTable","put","(Lforge/game/zone/ZoneType;Lforge/game/zone/ZoneType;Lforge/game/card/Card;)Lforge/game/card/CardCollection;","invokevirtual",112);}
case 112:{f.StackOp("pop");f.Pc=113;continue;}
case 113:{f.Pc=57;continue;}
case 116:{f.Push(f.Locals[4]);f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Untap","game","Lforge/game/Game;"));f.Pc=122;continue;}
case 122:{f.Push(JValue.R(null));f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",126);}
case 126:{f.Push(f.Locals[3]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[5]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",132);}
case 132:{f.StackOp("pop");f.Pc=133;continue;}
case 133:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",136);}
case 136:{f.Locals[6]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/player/Player","getKeywords","()Lforge/game/keyword/KeywordCollection;","invokevirtual",142);}
case 142:{return rt.Call(f,"forge/game/keyword/KeywordCollection","iterator","()Ljava/util/Iterator;","invokevirtual",145);}
case 145:{f.Locals[7]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[7]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",154);}
case 154:{f.Pc=f.Pop().Int==0?324:157;continue;}
case 157:{f.Push(f.Locals[7]);f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",164);}
case 164:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=167;continue;}
case 167:{f.Locals[8]=f.Pop();f.Pc=169;continue;}
case 169:{f.Push(f.Locals[8]);f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",176);}
case 176:{f.Locals[9]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[9]);f.Pc=180;continue;}
case 180:{f.Push(JValue.R(rt.String("UntapAdjust")));f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",185);}
case 185:{f.Pc=f.Pop().Int==0?260:188;continue;}
case 188:{f.Push(f.Locals[9]);f.Pc=190;continue;}
case 190:{f.Push(JValue.R(rt.String(":")));f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",195);}
case 195:{f.Locals[10]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(f.Locals[6]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[10]);f.Pc=201;continue;}
case 201:{f.Push(JValue.I(1));f.Pc=202;continue;}
case 202:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=203;continue;}
case 203:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",208);}
case 208:{f.Pc=f.Pop().Int==0?238:211;continue;}
case 211:{f.Push(f.Locals[10]);f.Pc=213;continue;}
case 213:{f.Push(JValue.I(2));f.Pc=214;continue;}
case 214:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=215;continue;}
case 215:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",218);}
case 218:{f.Push(f.Locals[6]);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[10]);f.Pc=222;continue;}
case 222:{f.Push(JValue.I(1));f.Pc=223;continue;}
case 223:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=224;continue;}
case 224:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",229);}
case 229:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=232;continue;}
case 232:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",235);}
case 235:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?260:238;continue;}
case 238:{f.Push(f.Locals[6]);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[10]);f.Pc=242;continue;}
case 242:{f.Push(JValue.I(1));f.Pc=243;continue;}
case 243:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=244;continue;}
case 244:{f.Push(f.Locals[10]);f.Pc=246;continue;}
case 246:{f.Push(JValue.I(2));f.Pc=247;continue;}
case 247:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=248;continue;}
case 248:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",251);}
case 251:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",254);}
case 254:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",259);}
case 259:{f.StackOp("pop");f.Pc=260;continue;}
case 260:{f.Push(f.Locals[9]);f.Pc=262;continue;}
case 262:{f.Push(JValue.R(rt.String("OnlyUntapChosen")));f.Pc=264;continue;}
case 264:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",267);}
case 267:{f.Pc=f.Pop().Int==0?321:270;continue;}
case 270:{f.Push(f.Locals[9]);f.Pc=272;continue;}
case 272:{f.Push(JValue.R(rt.String(":")));f.Pc=274;continue;}
case 274:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",277);}
case 277:{f.Push(JValue.I(1));f.Pc=278;continue;}
case 278:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=279;continue;}
case 279:{f.Push(JValue.R(rt.String(",")));f.Pc=281;continue;}
case 281:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",284);}
case 284:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",287);}
case 287:{f.Locals[10]=f.Pop();f.Pc=289;continue;}
case 289:{f.Push(f.Locals[1]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",293);}
case 293:{f.Push(JValue.R(rt.String("Card")));f.Pc=295;continue;}
case 295:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbility$EmptySa"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbility$EmptySa")));f.Pc=298;continue;}
case 298:{f.StackOp("dup");f.Pc=299;continue;}
case 299:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","ChooseType","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","ChooseType","Lforge/game/ability/ApiType;"));f.Pc=302;continue;}
case 302:{f.Push(JValue.R(null));f.Pc=303;continue;}
case 303:{f.Push(f.Locals[1]);f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;Lforge/game/player/Player;)V","invokespecial",307);}
case 307:{f.Push(f.Locals[10]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"forge/game/player/PlayerController","chooseSomeType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Ljava/util/Collection;)Ljava/lang/String;","invokevirtual",312);}
case 312:{f.Locals[11]=f.Pop();f.Pc=314;continue;}
case 314:{f.Push(f.Locals[3]);f.Pc=315;continue;}
case 315:{f.Push(f.Locals[11]);f.Pc=317;continue;}
case 317:{return rt.Call(f,"forge/game/card/CardLists","getType","(Ljava/lang/Iterable;Ljava/lang/String;)Lforge/game/card/CardCollection;","invokestatic",320);}
case 320:{f.Locals[3]=f.Pop();f.Pc=321;continue;}
case 321:{f.Pc=147;continue;}
case 324:{f.Push(f.Locals[3]);f.Pc=325;continue;}
case 325:{f.Push(f.Locals[1]);f.Pc=326;continue;}
case 326:{return rt.DynamicCall(f,"forge/game/phase/Untap:7952:326:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",331);}
case 331:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",334);}
case 334:{f.Locals[3]=f.Pop();f.Pc=335;continue;}
case 335:{f.Push(f.Locals[6]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",342);}
case 342:{f.Push(JValue.I(0));f.Pc=343;continue;}
case 343:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=346;continue;}
case 346:{return rt.Call(f,"java/util/Set","toArray","([Ljava/lang/Object;)[Ljava/lang/Object;","invokeinterface",351);}
case 351:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Ljava/lang/String;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=354;continue;}
case 354:{f.Locals[7]=f.Pop();f.Pc=356;continue;}
case 356:{f.Push(f.Locals[3]);f.Pc=357;continue;}
case 357:{f.Push(f.Locals[7]);f.Pc=359;continue;}
case 359:{f.Push(f.Locals[1]);f.Pc=360;continue;}
case 360:{f.Push(JValue.R(null));f.Pc=361;continue;}
case 361:{f.Push(JValue.R(null));f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",365);}
case 365:{f.Locals[8]=f.Pop();f.Pc=367;continue;}
case 367:{f.Push(f.Locals[3]);f.Pc=368;continue;}
case 368:{f.Push(f.Locals[8]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",373);}
case 373:{f.StackOp("pop");f.Pc=374;continue;}
case 374:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=377;continue;}
case 377:{f.StackOp("dup");f.Pc=378;continue;}
case 378:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",381);}
case 381:{f.Locals[9]=f.Pop();f.Pc=383;continue;}
case 383:{f.Push(f.Locals[8]);f.Pc=385;continue;}
case 385:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",388);}
case 388:{f.Pc=f.Pop().Int!=0?653:391;continue;}
case 391:{f.Push(f.Locals[6]);f.Pc=393;continue;}
case 393:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","(Ljava/util/Map;)Ljava/util/HashMap;","invokestatic",396);}
case 396:{f.Locals[10]=f.Pop();f.Pc=398;continue;}
case 398:{f.Push(f.Locals[10]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",405);}
case 405:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",410);}
case 410:{f.Locals[11]=f.Pop();f.Pc=412;continue;}
case 412:{f.Push(f.Locals[11]);f.Pc=414;continue;}
case 414:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",419);}
case 419:{f.Pc=f.Pop().Int==0?492:422;continue;}
case 422:{f.Push(f.Locals[11]);f.Pc=424;continue;}
case 424:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",429);}
case 429:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=432;continue;}
case 432:{f.Locals[12]=f.Pop();f.Pc=434;continue;}
case 434:{f.Push(f.Locals[12]);f.Pc=436;continue;}
case 436:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",441);}
case 441:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=444;continue;}
case 444:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",447);}
case 447:{f.Pc=f.Pop().Int!=0?489:450;continue;}
case 450:{f.Push(f.Locals[8]);f.Pc=452;continue;}
case 452:{f.Push(f.Locals[8]);f.Pc=454;continue;}
case 454:{f.Push(f.Locals[12]);f.Pc=456;continue;}
case 456:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",461);}
case 461:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=464;continue;}
case 464:{f.Push(f.Locals[1]);f.Pc=465;continue;}
case 465:{f.Push(JValue.R(null));f.Pc=466;continue;}
case 466:{f.Push(JValue.R(null));f.Pc=467;continue;}
case 467:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",470);}
case 470:{return rt.Call(f,"forge/game/card/CardCollection","removeAll","(Ljava/util/Collection;)Z","invokevirtual",473);}
case 473:{f.StackOp("pop");f.Pc=474;continue;}
case 474:{f.Push(f.Locals[6]);f.Pc=476;continue;}
case 476:{f.Push(f.Locals[12]);f.Pc=478;continue;}
case 478:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",483);}
case 483:{return rt.Call(f,"java/util/Map","remove","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",488);}
case 488:{f.StackOp("pop");f.Pc=489;continue;}
case 489:{f.Pc=412;continue;}
case 492:{f.Push(f.Locals[1]);f.Pc=493;continue;}
case 493:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",496);}
case 496:{f.Push(f.Locals[8]);f.Pc=498;continue;}
case 498:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbility$EmptySa"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbility$EmptySa")));f.Pc=501;continue;}
case 501:{f.StackOp("dup");f.Pc=502;continue;}
case 502:{if(!rt.StaticReady(f,"forge/game/ability/ApiType","Untap","Lforge/game/ability/ApiType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/ApiType","Untap","Lforge/game/ability/ApiType;"));f.Pc=505;continue;}
case 505:{f.Push(JValue.R(null));f.Pc=506;continue;}
case 506:{f.Push(f.Locals[1]);f.Pc=507;continue;}
case 507:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;Lforge/game/player/Player;)V","invokespecial",510);}
case 510:{f.Push(f.Locals[9]);f.Pc=512;continue;}
case 512:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",515);}
case 515:{f.Push(f.Locals[10]);f.Pc=517;continue;}
case 517:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",520);}
case 520:{return rt.DynamicCall(f,"forge/game/phase/Untap:7952:520:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",525);}
case 525:{f.Push(JValue.R(null));f.Pc=526;continue;}
case 526:{return rt.Call(f,"forge/game/player/PlayerController","chooseSingleEntityForEffect","(Lforge/util/collect/FCollectionView;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Ljava/util/Map;)Lforge/game/GameEntity;","invokevirtual",529);}
case 529:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=532;continue;}
case 532:{f.Locals[11]=f.Pop();f.Pc=534;continue;}
case 534:{f.Push(f.Locals[11]);f.Pc=536;continue;}
case 536:{f.Pc=f.Pop().Reference==null?650:539;continue;}
case 539:{f.Push(f.Locals[6]);f.Pc=541;continue;}
case 541:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",546);}
case 546:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",551);}
case 551:{f.Locals[12]=f.Pop();f.Pc=553;continue;}
case 553:{f.Push(f.Locals[12]);f.Pc=555;continue;}
case 555:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",560);}
case 560:{f.Pc=f.Pop().Int==0?635:563;continue;}
case 563:{f.Push(f.Locals[12]);f.Pc=565;continue;}
case 565:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",570);}
case 570:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=573;continue;}
case 573:{f.Locals[13]=f.Pop();f.Pc=575;continue;}
case 575:{f.Push(f.Locals[11]);f.Pc=577;continue;}
case 577:{f.Push(f.Locals[13]);f.Pc=579;continue;}
case 579:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",584);}
case 584:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=587;continue;}
case 587:{f.Push(f.Locals[1]);f.Pc=588;continue;}
case 588:{f.Push(JValue.R(null));f.Pc=589;continue;}
case 589:{f.Push(JValue.R(null));f.Pc=590;continue;}
case 590:{return rt.Call(f,"forge/game/card/Card","isValid","(Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",593);}
case 593:{f.Pc=f.Pop().Int==0?632:596;continue;}
case 596:{f.Push(f.Locals[6]);f.Pc=598;continue;}
case 598:{f.Push(f.Locals[13]);f.Pc=600;continue;}
case 600:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",605);}
case 605:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=608;continue;}
case 608:{f.Push(f.Locals[13]);f.Pc=610;continue;}
case 610:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",615);}
case 615:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=618;continue;}
case 618:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",621);}
case 621:{f.Push(JValue.I(1));f.Pc=622;continue;}
case 622:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=623;continue;}
case 623:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",626);}
case 626:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",631);}
case 631:{f.StackOp("pop");f.Pc=632;continue;}
case 632:{f.Pc=553;continue;}
case 635:{f.Push(f.Locals[3]);f.Pc=636;continue;}
case 636:{f.Push(f.Locals[11]);f.Pc=638;continue;}
case 638:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",641);}
case 641:{f.StackOp("pop");f.Pc=642;continue;}
case 642:{f.Push(f.Locals[8]);f.Pc=644;continue;}
case 644:{f.Push(f.Locals[11]);f.Pc=646;continue;}
case 646:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",649);}
case 649:{f.StackOp("pop");f.Pc=650;continue;}
case 650:{f.Pc=383;continue;}
case 653:{f.Push(f.Locals[3]);f.Pc=654;continue;}
case 654:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",657);}
case 657:{f.Locals[10]=f.Pop();f.Pc=659;continue;}
case 659:{f.Push(f.Locals[10]);f.Pc=661;continue;}
case 661:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",666);}
case 666:{f.Pc=f.Pop().Int==0?714:669;continue;}
case 669:{f.Push(f.Locals[10]);f.Pc=671;continue;}
case 671:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",676);}
case 676:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=679;continue;}
case 679:{f.Locals[11]=f.Pop();f.Pc=681;continue;}
case 681:{f.Push(f.Locals[11]);f.Pc=683;continue;}
case 683:{f.Push(f.Locals[1]);f.Pc=684;continue;}
case 684:{return rt.Call(f,"forge/game/phase/Untap","optionalUntap","(Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokestatic",687);}
case 687:{f.Pc=f.Pop().Int==0?711:690;continue;}
case 690:{f.Push(f.Locals[2]);f.Pc=691;continue;}
case 691:{f.Push(f.Locals[1]);f.Pc=692;continue;}
case 692:{return rt.DynamicCall(f,"forge/game/phase/Untap:7952:692:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",697);}
case 697:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",702);}
case 702:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=705;continue;}
case 705:{f.Push(f.Locals[11]);f.Pc=707;continue;}
case 707:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",710);}
case 710:{f.StackOp("pop");f.Pc=711;continue;}
case 711:{f.Pc=659;continue;}
case 714:{f.Push(f.Locals[1]);f.Pc=715;continue;}
case 715:{return rt.Call(f,"forge/game/player/Player","getAllOtherPlayers","()Lforge/game/player/PlayerCollection;","invokevirtual",718);}
case 718:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=721;continue;}
case 721:{return rt.Call(f,"forge/game/player/PlayerCollection","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollection;","invokevirtual",724);}
case 724:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",727);}
case 727:{f.Locals[10]=f.Pop();f.Pc=729;continue;}
case 729:{f.Push(f.Locals[10]);f.Pc=731;continue;}
case 731:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",736);}
case 736:{f.Pc=f.Pop().Int==0?805:739;continue;}
case 739:{f.Push(f.Locals[10]);f.Pc=741;continue;}
case 741:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",746);}
case 746:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=749;continue;}
case 749:{f.Locals[11]=f.Pop();f.Pc=751;continue;}
case 751:{f.Push(f.Locals[11]);f.Pc=753;continue;}
case 753:{return rt.Call(f,"forge/game/card/Card","isTapped","()Z","invokevirtual",756);}
case 756:{f.Pc=f.Pop().Int==0?802:759;continue;}
case 759:{f.Push(f.Locals[11]);f.Pc=761;continue;}
case 761:{f.Push(f.Locals[1]);f.Pc=762;continue;}
case 762:{return rt.Call(f,"forge/game/staticability/StaticAbilityUntapOtherPlayer","untap","(Lforge/game/card/Card;Lforge/game/player/Player;)Z","invokestatic",765);}
case 765:{f.Pc=f.Pop().Int==0?802:768;continue;}
case 768:{f.Push(f.Locals[11]);f.Pc=770;continue;}
case 770:{f.Push(f.Locals[1]);f.Pc=771;continue;}
case 771:{return rt.Call(f,"forge/game/card/Card","untap","(Lforge/game/player/Player;)Z","invokevirtual",774);}
case 774:{f.Pc=f.Pop().Int==0?802:777;continue;}
case 777:{f.Push(f.Locals[2]);f.Pc=778;continue;}
case 778:{f.Push(f.Locals[11]);f.Pc=780;continue;}
case 780:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",783);}
case 783:{return rt.DynamicCall(f,"forge/game/phase/Untap:7952:783:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",788);}
case 788:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",793);}
case 793:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=796;continue;}
case 796:{f.Push(f.Locals[11]);f.Pc=798;continue;}
case 798:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",801);}
case 801:{f.StackOp("pop");f.Pc=802;continue;}
case 802:{f.Pc=729;continue;}
case 805:{f.Push(f.Locals[1]);f.Pc=806;continue;}
case 806:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=809;continue;}
case 809:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",812);}
case 812:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",817);}
case 817:{f.Locals[10]=f.Pop();f.Pc=819;continue;}
case 819:{f.Push(f.Locals[10]);f.Pc=821;continue;}
case 821:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",826);}
case 826:{f.Pc=f.Pop().Int==0?852:829;continue;}
case 829:{f.Push(f.Locals[10]);f.Pc=831;continue;}
case 831:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",836);}
case 836:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=839;continue;}
case 839:{f.Locals[11]=f.Pop();f.Pc=841;continue;}
case 841:{f.Push(f.Locals[11]);f.Pc=843;continue;}
case 843:{f.Push(JValue.R(rt.String("This card doesn't untap during your next untap step.")));f.Pc=846;continue;}
case 846:{return rt.Call(f,"forge/game/card/Card","removeHiddenExtrinsicKeyword","(Ljava/lang/String;)V","invokevirtual",849);}
case 849:{f.Pc=819;continue;}
case 852:{f.Push(f.Locals[0]);f.Pc=853;continue;}
case 853:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Untap","game","Lforge/game/Game;"));f.Pc=856;continue;}
case 856:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=859;continue;}
case 859:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",862);}
case 862:{return rt.Call(f,"forge/game/card/CardCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",867);}
case 867:{f.Locals[10]=f.Pop();f.Pc=869;continue;}
case 869:{f.Push(f.Locals[10]);f.Pc=871;continue;}
case 871:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",876);}
case 876:{f.Pc=f.Pop().Int==0?900:879;continue;}
case 879:{f.Push(f.Locals[10]);f.Pc=881;continue;}
case 881:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",886);}
case 886:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=889;continue;}
case 889:{f.Locals[11]=f.Pop();f.Pc=891;continue;}
case 891:{f.Push(f.Locals[11]);f.Pc=893;continue;}
case 893:{f.Push(f.Locals[1]);f.Pc=894;continue;}
case 894:{return rt.Call(f,"forge/game/card/Card","removeExertedBy","(Lforge/game/player/Player;)V","invokevirtual",897);}
case 897:{f.Pc=869;continue;}
case 900:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",903);}
case 903:{f.Locals[10]=f.Pop();f.Pc=905;continue;}
case 905:{f.Push(f.Locals[10]);f.Pc=907;continue;}
case 907:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Map","Lforge/game/ability/AbilityKey;"));f.Pc=910;continue;}
case 910:{f.Push(f.Locals[2]);f.Pc=911;continue;}
case 911:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",916);}
case 916:{f.StackOp("pop");f.Pc=917;continue;}
case 917:{f.Push(f.Locals[0]);f.Pc=918;continue;}
case 918:{f.Push(rt.GetField(f.Pop(),"forge/game/phase/Untap","game","Lforge/game/Game;"));f.Pc=921;continue;}
case 921:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",924);}
case 924:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","UntapAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","UntapAll","Lforge/game/trigger/TriggerType;"));f.Pc=927;continue;}
case 927:{f.Push(f.Locals[10]);f.Pc=929;continue;}
case 929:{f.Push(JValue.I(0));f.Pc=930;continue;}
case 930:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",933);}
case 933:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7953(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.String("You may choose not to untap CARDNAME during your untap step.")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Ljava/lang/String;)Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?150:12;continue;}
case 12:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",20);}
case 20:{return rt.DynamicCall(f,"forge/game/phase/Untap:7953:20:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",25);}
case 25:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",28);}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{f.Locals[4]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/Card","hasGainControlTarget","()Z","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int==0?115:39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/card/Card","getGainControlTargets","()Lforge/game/card/CardCollectionView;","invokevirtual",43);}
case 43:{f.Locals[5]=f.Pop();f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("\r\n")));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",52);}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",56);}
case 56:{f.Push(JValue.R(rt.String(" is controlling: ")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",62);}
case 62:{f.StackOp("pop");f.Pc=63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",70);}
case 70:{f.Locals[6]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",79);}
case 79:{f.Pc=f.Pop().Int==0?115:82;continue;}
case 82:{f.Push(f.Locals[6]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",89);}
case 89:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=92;continue;}
case 92:{f.Locals[7]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[7]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",100);}
case 100:{f.StackOp("pop");f.Pc=101;continue;}
case 101:{f.Push(f.Locals[7]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?112:109;continue;}
case 109:{f.Push(JValue.I(0));f.Pc=110;continue;}
case 110:{f.Locals[4]=f.Pop();f.Pc=112;continue;}
case 112:{f.Pc=72;continue;}
case 115:{f.Push(f.Locals[0]);f.Pc=116;continue;}
case 116:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",119);}
case 119:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",122);}
case 122:{if(!rt.EnsureInitialized(f,"forge/game/spellability/SpellAbility$EmptySa"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/SpellAbility$EmptySa")));f.Pc=125;continue;}
case 125:{f.StackOp("dup");f.Pc=126;continue;}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",131);}
case 131:{return rt.Call(f,"forge/game/spellability/SpellAbility$EmptySa","<init>","(Lforge/game/card/Card;Lforge/game/player/Player;)V","invokespecial",134);}
case 134:{f.Push(f.Locals[3]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",138);}
case 138:{if(!rt.StaticReady(f,"forge/game/player/PlayerController$BinaryChoiceType","UntapOrLeaveTapped","Lforge/game/player/PlayerController$BinaryChoiceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerController$BinaryChoiceType","UntapOrLeaveTapped","Lforge/game/player/PlayerController$BinaryChoiceType;"));f.Pc=141;continue;}
case 141:{f.Push(f.Locals[4]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",146);}
case 146:{return rt.Call(f,"forge/game/player/PlayerController","chooseBinary","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/PlayerController$BinaryChoiceType;Ljava/lang/Boolean;)Z","invokevirtual",149);}
case 149:{f.Locals[2]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[2]);f.Pc=151;continue;}
case 151:{f.Pc=f.Pop().Int==0?164:154;continue;}
case 154:{f.Push(f.Locals[0]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/card/Card","untap","(Lforge/game/player/Player;)Z","invokevirtual",159);}
case 159:{f.Pc=f.Pop().Int!=0?164:162;continue;}
case 162:{f.Push(JValue.I(0));f.Pc=163;continue;}
case 163:{f.Locals[2]=f.Pop();f.Pc=164;continue;}
case 164:{f.Push(f.Locals[2]);f.Pc=165;continue;}
case 165:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7954(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/Game","getCardsIncludePhasingIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",12);}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.DynamicCall(f,"forge/game/phase/Untap:7954:13:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",18);}
case 18:{return rt.Call(f,"forge/game/card/CardLists","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Lforge/game/card/CardCollection;","invokestatic",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",29);}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",36);}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[4]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",45);}
case 45:{f.Pc=f.Pop().Int==0?108:48;continue;}
case 48:{f.Push(f.Locals[4]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",55);}
case 55:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=58;continue;}
case 58:{f.Locals[5]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[5]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",65);}
case 65:{f.Pc=f.Pop().Int==0?79:68;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantPhase","cantPhaseIn","(Lforge/game/card/Card;)Z","invokestatic",73);}
case 73:{f.Pc=f.Pop().Int==0?79:76;continue;}
case 76:{f.Pc=38;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int!=0?98:87;continue;}
case 87:{f.Push(f.Locals[5]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantPhase","cantPhaseOut","(Lforge/game/card/Card;)Z","invokestatic",92);}
case 92:{f.Pc=f.Pop().Int==0?98:95;continue;}
case 95:{f.Pc=38;continue;}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{f.Push(f.Locals[5]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",104);}
case 104:{f.StackOp("pop");f.Pc=105;continue;}
case 105:{f.Pc=38;continue;}
case 108:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=111;continue;}
case 111:{f.StackOp("dup");f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",115);}
case 115:{f.Locals[4]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[3]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",121);}
case 121:{f.Locals[5]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[5]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",130);}
case 130:{f.Pc=f.Pop().Int==0?240:133;continue;}
case 133:{f.Push(f.Locals[5]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",140);}
case 140:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=143;continue;}
case 143:{f.Locals[6]=f.Pop();f.Pc=145;continue;}
case 145:{f.Push(f.Locals[6]);f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",150);}
case 150:{f.Pc=f.Pop().Int==0?170:153;continue;}
case 153:{f.Push(f.Locals[6]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/card/Card","isDirectlyPhasedOut","()Z","invokevirtual",158);}
case 158:{f.Pc=f.Pop().Int==0?170:161;continue;}
case 161:{f.Push(f.Locals[6]);f.Pc=163;continue;}
case 163:{f.Push(JValue.I(1));f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/card/Card","phase","(Z)V","invokevirtual",167);}
case 167:{f.Pc=237;continue;}
case 170:{f.Push(f.Locals[6]);f.Pc=172;continue;}
case 172:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","PHASING","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","PHASING","Lforge/game/keyword/Keyword;"));f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",178);}
case 178:{f.Pc=f.Pop().Int==0?237:181;continue;}
case 181:{f.Push(f.Locals[6]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"forge/game/card/Card","isAttachment","()Z","invokevirtual",186);}
case 186:{f.Pc=f.Pop().Int==0?223:189;continue;}
case 189:{f.Push(f.Locals[6]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/card/Card","getAttachedTo","()Lforge/game/card/Card;","invokevirtual",194);}
case 194:{f.Locals[7]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[7]);f.Pc=198;continue;}
case 198:{f.Pc=f.Pop().Reference==null?223:201;continue;}
case 201:{f.Push(f.Locals[2]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[7]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",209);}
case 209:{f.Pc=f.Pop().Int==0?223:212;continue;}
case 212:{f.Push(f.Locals[7]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/game/staticability/StaticAbilityCantPhase","cantPhaseOut","(Lforge/game/card/Card;)Z","invokestatic",217);}
case 217:{f.Pc=f.Pop().Int!=0?223:220;continue;}
case 220:{f.Pc=123;continue;}
case 223:{f.Push(f.Locals[6]);f.Pc=225;continue;}
case 225:{f.Push(JValue.I(1));f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/card/Card","phase","(Z)V","invokevirtual",229);}
case 229:{f.Push(f.Locals[4]);f.Pc=231;continue;}
case 231:{f.Push(f.Locals[6]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",236);}
case 236:{f.StackOp("pop");f.Pc=237;continue;}
case 237:{f.Pc=123;continue;}
case 240:{f.Push(f.Locals[4]);f.Pc=242;continue;}
case 242:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",245);}
case 245:{f.Pc=f.Pop().Int!=0?279:248;continue;}
case 248:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",251);}
case 251:{f.Locals[5]=f.Pop();f.Pc=253;continue;}
case 253:{f.Push(f.Locals[5]);f.Pc=255;continue;}
case 255:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cards","Lforge/game/ability/AbilityKey;"));f.Pc=258;continue;}
case 258:{f.Push(f.Locals[4]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",265);}
case 265:{f.StackOp("pop");f.Pc=266;continue;}
case 266:{f.Push(f.Locals[1]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",270);}
case 270:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","PhaseOutAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","PhaseOutAll","Lforge/game/trigger/TriggerType;"));f.Pc=273;continue;}
case 273:{f.Push(f.Locals[5]);f.Pc=275;continue;}
case 275:{f.Push(JValue.I(0));f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",279);}
case 279:{f.Push(f.Locals[3]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",283);}
case 283:{f.Pc=f.Pop().Int!=0?300:286;continue;}
case 286:{f.Push(f.Locals[1]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",290);}
case 290:{return rt.Call(f,"forge/game/GameAction","checkStaticAbilities","()V","invokevirtual",293);}
case 293:{f.Push(f.Locals[1]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",297);}
case 297:{return rt.Call(f,"forge/game/trigger/TriggerHandler","collectTriggerForWaiting","()V","invokevirtual",300);}
case 300:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7955(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?5:4;continue;}
case 4:{return JStep.ReturnVoid;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[1]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",14);}
case 14:{return rt.Call(f,"forge/game/zone/MagicStack","getSpellsCastLastTurn","()Ljava/util/List;","invokevirtual",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.DynamicCall(f,"forge/game/phase/Untap:7955:19:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/game/player/Player;)Ljava/util/function/Predicate;",24);}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/Game","isDay","()Z","invokevirtual",29);}
case 29:{f.Pc=f.Pop().Int==0?58:32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",38);}
case 38:{f.Push(f.Locals[3]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/stream/Stream","noneMatch","(Ljava/util/function/Predicate;)Z","invokeinterface",44);}
case 44:{f.Pc=f.Pop().Int==0?58:47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(JValue.I(1));f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",52);}
case 52:{return rt.Call(f,"forge/game/Game","setDayTime","(Ljava/lang/Boolean;)V","invokevirtual",55);}
case 55:{f.Pc=82;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/Game","isNight","()Z","invokevirtual",62);}
case 62:{f.Pc=f.Pop().Int==0?82:65;continue;}
case 65:{f.Push(f.Locals[2]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/card/CardLists","count","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)I","invokestatic",70);}
case 70:{f.Push(JValue.I(1));f.Pc=71;continue;}
case 71:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?82:74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{f.Push(JValue.I(0));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",79);}
case 79:{return rt.Call(f,"forge/game/Game","setDayTime","(Ljava/lang/Boolean;)V","invokevirtual",82);}
case 82:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7956(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/player/Player","sharesTeamWith","(Lforge/game/player/Player;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7957(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","(Lforge/game/player/Player;)Z","invokevirtual",5);}
case 5:{f.Pc=f.Pop().Int==0?15:8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","isDirectlyPhasedOut","()Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int!=0?36:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","PHASING","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","PHASING","Lforge/game/keyword/Keyword;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",22);}
case 22:{f.Pc=f.Pop().Int==0?40:25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",29);}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?40:36;continue;}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{f.Pc=41;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7958(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7959(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7960(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/card/Card","canUntap","(Lforge/game/player/Player;Z)Z","invokevirtual",6);}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
