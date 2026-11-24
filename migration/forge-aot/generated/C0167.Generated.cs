// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C167{
internal static JClass Build(){var c=new JClass("forge/game/GameType","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("Sealed","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("Draft","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("CommanderDraft","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("Winston","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("Gauntlet","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("Tournament","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("CommanderGauntlet","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("Quest","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("QuestCommander","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("QuestDraft","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("PlanarConquest","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("Adventure","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("AdventureEvent","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("Puzzle","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("Constructed","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("DeckManager","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("Vanguard","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("Commander","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("Oathbreaker","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("TinyLeaders","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("Brawl","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("Planeswalker","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("Planechase","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("Archenemy","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("ArchenemyRumble","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("TwoHeadedGiant","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("MomirBasic","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("MoJhoSto","Lforge/game/GameType;",true,JValue.Default("Lforge/game/GameType;"),null));
c.Add(new JField("DRAFT_FORMATS","Ljava/util/EnumSet;",true,JValue.Default("Ljava/util/EnumSet;"),null));
c.Add(new JField("deckFormat","Lforge/deck/DeckFormat;",false,JValue.Default("Lforge/deck/DeckFormat;"),null));
c.Add(new JField("isCardPoolLimited","Z",false,JValue.Default("Z"),null));
c.Add(new JField("canSideboard","Z",false,JValue.Default("Z"),null));
c.Add(new JField("addWonCardsMidGame","Z",false,JValue.Default("Z"),null));
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("englishName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("description","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("deckAutoGenerator","Ljava/util/function/Function;",false,JValue.Default("Ljava/util/function/Function;"),null));
c.Add(new JField("$VALUES","[Lforge/game/GameType;",true,JValue.Default("[Lforge/game/GameType;"),null));
c.Add(new JMethod(2624,"forge/game/GameType","values","()[Lforge/game/GameType;",9,0,1,new JHandler[]{},M2624));
c.Add(new JMethod(2625,"forge/game/GameType","valueOf","(Ljava/lang/String;)Lforge/game/GameType;",9,1,2,new JHandler[]{},M2625));
c.Add(new JMethod(2626,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V",2,9,10,new JHandler[]{},M2626));
c.Add(new JMethod(2627,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;Ljava/util/function/Function;)V",2,11,4,new JHandler[]{},M2627));
c.Add(new JMethod(2628,"forge/game/GameType","getDeckFormat","()Lforge/deck/DeckFormat;",1,1,1,new JHandler[]{},M2628));
c.Add(new JMethod(2629,"forge/game/GameType","isAutoGenerated","()Z",1,1,1,new JHandler[]{},M2629));
c.Add(new JMethod(2630,"forge/game/GameType","autoGenerateDeck","(Lforge/game/player/RegisteredPlayer;)Lforge/deck/Deck;",1,2,2,new JHandler[]{},M2630));
c.Add(new JMethod(2631,"forge/game/GameType","isCardPoolLimited","()Z",1,1,1,new JHandler[]{},M2631));
c.Add(new JMethod(2632,"forge/game/GameType","isSideboardingAllowed","()Z",1,1,1,new JHandler[]{},M2632));
c.Add(new JMethod(2633,"forge/game/GameType","canAddWonCardsMidGame","()Z",1,1,1,new JHandler[]{},M2633));
c.Add(new JMethod(2634,"forge/game/GameType","isDraft","()Z",1,1,2,new JHandler[]{},M2634));
c.Add(new JMethod(2635,"forge/game/GameType","toString","()Ljava/lang/String;",1,1,1,new JHandler[]{},M2635));
c.Add(new JMethod(2636,"forge/game/GameType","getEnglishName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M2636));
c.Add(new JMethod(2637,"forge/game/GameType","getDescription","()Ljava/lang/String;",1,1,1,new JHandler[]{},M2637));
c.Add(new JMethod(2638,"forge/game/GameType","getPrimaryDeckSections","()Ljava/util/EnumSet;",1,1,1,new JHandler[]{},M2638));
c.Add(new JMethod(2639,"forge/game/GameType","getSupplimentalDeckSections","()Ljava/util/EnumSet;",1,1,5,new JHandler[]{},M2639));
c.Add(new JMethod(2640,"forge/game/GameType","smartValueOf","(Ljava/lang/String;)Lforge/game/GameType;",9,1,2,new JHandler[]{},M2640));
c.Add(new JMethod(2641,"forge/game/GameType","listValueOf","(Ljava/lang/String;)Ljava/util/Set;",9,7,2,new JHandler[]{},M2641));
c.Add(new JMethod(2642,"forge/game/GameType","lambda$static$1","(Lforge/game/player/RegisteredPlayer;)Lforge/deck/Deck;",4106,3,3,new JHandler[]{},M2642));
c.Add(new JMethod(2643,"forge/game/GameType","lambda$static$0","(Lforge/game/player/RegisteredPlayer;)Lforge/deck/Deck;",4106,3,3,new JHandler[]{},M2643));
c.Add(new JMethod(2644,"forge/game/GameType","$values","()[Lforge/game/GameType;",4106,0,4,new JHandler[]{},M2644));
c.Add(new JMethod(2645,"forge/game/GameType","<clinit>","()V",8,0,11,new JHandler[]{},M2645));
}

internal static JStep M2624(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/GameType","$VALUES","[Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","$VALUES","[Lforge/game/GameType;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/game/GameType;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/GameType;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2625(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/GameType")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2626(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[5]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[6]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[7]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[8]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(null));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;Ljava/util/function/Function;)V","invokespecial",18);}
case 18:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2627(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",9);}
case 9:{f.Locals[10]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameType","deckFormat","Lforge/deck/DeckFormat;",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[4]);f.Pc=19;continue;}
case 19:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameType","isCardPoolLimited","Z",value);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[5]);f.Pc=25;continue;}
case 25:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameType","canSideboard","Z",value);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[6]);f.Pc=31;continue;}
case 31:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameType","addWonCardsMidGame","Z",value);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[10]);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[7]);f.Pc=39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",46);}
case 46:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameType","name","Ljava/lang/String;",value);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[10]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[7]);f.Pc=54;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/util/Localizer","getEnglishMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",61);}
case 61:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameType","englishName","Ljava/lang/String;",value);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[8]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",69);}
case 69:{f.Pc=f.Pop().Int!=0?85:72;continue;}
case 72:{f.Push(f.Locals[10]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[8]);f.Pc=76;continue;}
case 76:{f.Push(JValue.I(0));f.Pc=77;continue;}
case 77:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",83);}
case 83:{f.Locals[8]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[8]);f.Pc=88;continue;}
case 88:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameType","description","Ljava/lang/String;",value);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[9]);f.Pc=94;continue;}
case 94:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/GameType","deckAutoGenerator","Ljava/util/function/Function;",value);f.Pc=97;continue;}
case 97:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2628(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameType","deckFormat","Lforge/deck/DeckFormat;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2629(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameType","deckAutoGenerator","Ljava/util/function/Function;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference==null?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2630(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameType","deckAutoGenerator","Ljava/util/function/Function;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/function/Function","apply","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/Deck"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2631(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameType","isCardPoolLimited","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2632(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameType","canSideboard","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2633(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameType","addWonCardsMidGame","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2634(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/GameType","DRAFT_FORMATS","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","DRAFT_FORMATS","Ljava/util/EnumSet;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2635(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameType","name","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2636(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameType","englishName","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2637(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameType","description","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2638(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameType","deckFormat","Lforge/deck/DeckFormat;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/DeckFormat","getPrimaryDeckSections","()Ljava/util/EnumSet;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2639(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/GameType","deckFormat","Lforge/deck/DeckFormat;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/DeckFormat","getPrimaryDeckSections","()Ljava/util/EnumSet;","invokevirtual",7);}
case 7:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",13);}
case 13:{f.Pc=f.Pop().Int!=0?22:16;continue;}
case 16:{f.Push(JValue.R(rt.ClassObject("forge/deck/DeckSection")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",21);}
case 21:{return JStep.Return(f.Pop());}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/GameType","deckFormat","Lforge/deck/DeckFormat;"));f.Pc=26;continue;}
case 26:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Limited","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Limited","Lforge/deck/DeckFormat;"));f.Pc=29;continue;}
case 29:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?48:32;continue;}
case 32:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"));f.Pc=35;continue;}
case 35:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"));f.Pc=38;continue;}
case 38:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"));f.Pc=41;continue;}
case 41:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",47);}
case 47:{return JStep.Return(f.Pop());}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{if(!rt.StaticReady(f,"forge/game/GameType","Constructed","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Constructed","Lforge/game/GameType;"));f.Pc=52;continue;}
case 52:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?62:55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{if(!rt.StaticReady(f,"forge/game/GameType","Commander","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Commander","Lforge/game/GameType;"));f.Pc=59;continue;}
case 59:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?110:62;continue;}
case 62:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"));f.Pc=65;continue;}
case 65:{f.Push(JValue.I(6));f.Pc=67;continue;}
case 67:{f.Push(JValue.R(rt.NewArray("Lforge/deck/DeckSection;",f.Pop().Int)));f.Pc=70;continue;}
case 70:{f.StackOp("dup");f.Pc=71;continue;}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Schemes","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Schemes","Lforge/deck/DeckSection;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(1));f.Pc=78;continue;}
case 78:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Planes","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Planes","Lforge/deck/DeckSection;"));f.Pc=81;continue;}
case 81:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=82;continue;}
case 82:{f.StackOp("dup");f.Pc=83;continue;}
case 83:{f.Push(JValue.I(2));f.Pc=84;continue;}
case 84:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"));f.Pc=87;continue;}
case 87:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=88;continue;}
case 88:{f.StackOp("dup");f.Pc=89;continue;}
case 89:{f.Push(JValue.I(3));f.Pc=90;continue;}
case 90:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"));f.Pc=93;continue;}
case 93:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=94;continue;}
case 94:{f.StackOp("dup");f.Pc=95;continue;}
case 95:{f.Push(JValue.I(4));f.Pc=96;continue;}
case 96:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"));f.Pc=99;continue;}
case 99:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=100;continue;}
case 100:{f.StackOp("dup");f.Pc=101;continue;}
case 101:{f.Push(JValue.I(5));f.Pc=102;continue;}
case 102:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"));f.Pc=105;continue;}
case 105:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;[Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",109);}
case 109:{return JStep.Return(f.Pop());}
case 110:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"));f.Pc=113;continue;}
case 113:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"));f.Pc=116;continue;}
case 116:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"));f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",122);}
case 122:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2640(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/GameType")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"com/google/common/base/Enums","getIfPresent","(Ljava/lang/Class;Ljava/lang/String;)Lcom/google/common/base/Optional;","invokestatic",6);}
case 6:{return rt.Call(f,"com/google/common/base/Optional","orNull","()Ljava/lang/Object;","invokevirtual",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2641(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/GameType")));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/EnumSet","noneOf","(Ljava/lang/Class;)Ljava/util/EnumSet;","invokestatic",5);}
case 5:{f.Locals[1]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String(",")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=15;continue;}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?58:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=29;continue;}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/GameType","smartValueOf","(Ljava/lang/String;)Lforge/game/GameType;","invokestatic",36);}
case 36:{f.Locals[6]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[6]);f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Reference==null?52:43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{f.Push(f.Locals[6]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",51);}
case 51:{f.StackOp("pop");f.Pc=52;continue;}
case 52:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=55;continue;}
case 55:{f.Pc=19;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2642(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/Deck"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/Deck")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/Deck","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",17);}
case 17:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",20);}
case 20:{f.Push(JValue.R(rt.String("Plains")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",26);}
case 26:{f.Push(JValue.I(12));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",31);}
case 31:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/Iterable;)V","invokevirtual",34);}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",38);}
case 38:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",41);}
case 41:{f.Push(JValue.R(rt.String("Island")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",47);}
case 47:{f.Push(JValue.I(12));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",52);}
case 52:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/Iterable;)V","invokevirtual",55);}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",59);}
case 59:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",62);}
case 62:{f.Push(JValue.R(rt.String("Swamp")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",68);}
case 68:{f.Push(JValue.I(12));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",73);}
case 73:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/Iterable;)V","invokevirtual",76);}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",80);}
case 80:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",83);}
case 83:{f.Push(JValue.R(rt.String("Mountain")));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",89);}
case 89:{f.Push(JValue.I(12));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",94);}
case 94:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/Iterable;)V","invokevirtual",97);}
case 97:{f.Push(f.Locals[2]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",101);}
case 101:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",104);}
case 104:{f.Push(JValue.R(rt.String("Forest")));f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",110);}
case 110:{f.Push(JValue.I(12));f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",115);}
case 115:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/Iterable;)V","invokevirtual",118);}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"));f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/deck/Deck","getOrCreate","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",125);}
case 125:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",128);}
case 128:{return rt.Call(f,"forge/StaticData","getVariantCards","()Lforge/card/CardDb;","invokevirtual",131);}
case 131:{f.Push(JValue.R(rt.String("Momir Vig, Simic Visionary Avatar")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",137);}
case 137:{f.Push(JValue.I(1));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;I)V","invokevirtual",141);}
case 141:{f.Push(f.Locals[1]);f.Pc=142;continue;}
case 142:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"));f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/deck/Deck","getOrCreate","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",148);}
case 148:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",151);}
case 151:{return rt.Call(f,"forge/StaticData","getVariantCards","()Lforge/card/CardDb;","invokevirtual",154);}
case 154:{f.Push(JValue.R(rt.String("Jhoira of the Ghitu Avatar")));f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",160);}
case 160:{f.Push(JValue.I(1));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;I)V","invokevirtual",164);}
case 164:{f.Push(f.Locals[1]);f.Pc=165;continue;}
case 165:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"));f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/deck/Deck","getOrCreate","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",171);}
case 171:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",174);}
case 174:{return rt.Call(f,"forge/StaticData","getVariantCards","()Lforge/card/CardDb;","invokevirtual",177);}
case 177:{f.Push(JValue.R(rt.String("Stonehewer Giant Avatar")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",183);}
case 183:{f.Push(JValue.I(1));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;I)V","invokevirtual",187);}
case 187:{f.Push(f.Locals[1]);f.Pc=188;continue;}
case 188:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2643(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/Deck"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/Deck")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/Deck","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/deck/Deck","getMain","()Lforge/deck/CardPool;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[2]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",17);}
case 17:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",20);}
case 20:{f.Push(JValue.R(rt.String("Plains")));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",26);}
case 26:{f.Push(JValue.I(12));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",31);}
case 31:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/Iterable;)V","invokevirtual",34);}
case 34:{f.Push(f.Locals[2]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",38);}
case 38:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",41);}
case 41:{f.Push(JValue.R(rt.String("Island")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",47);}
case 47:{f.Push(JValue.I(12));f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",52);}
case 52:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/Iterable;)V","invokevirtual",55);}
case 55:{f.Push(f.Locals[2]);f.Pc=56;continue;}
case 56:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",59);}
case 59:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",62);}
case 62:{f.Push(JValue.R(rt.String("Swamp")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",68);}
case 68:{f.Push(JValue.I(12));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",73);}
case 73:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/Iterable;)V","invokevirtual",76);}
case 76:{f.Push(f.Locals[2]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",80);}
case 80:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",83);}
case 83:{f.Push(JValue.R(rt.String("Mountain")));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",89);}
case 89:{f.Push(JValue.I(12));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",94);}
case 94:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/Iterable;)V","invokevirtual",97);}
case 97:{f.Push(f.Locals[2]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",101);}
case 101:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",104);}
case 104:{f.Push(JValue.R(rt.String("Forest")));f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/card/CardDb","getAllCards","(Ljava/lang/String;)Ljava/util/List;","invokevirtual",110);}
case 110:{f.Push(JValue.I(12));f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;I)Ljava/util/List;","invokestatic",115);}
case 115:{return rt.Call(f,"forge/deck/CardPool","add","(Ljava/lang/Iterable;)V","invokevirtual",118);}
case 118:{f.Push(f.Locals[1]);f.Pc=119;continue;}
case 119:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"));f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/deck/Deck","getOrCreate","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",125);}
case 125:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",128);}
case 128:{return rt.Call(f,"forge/StaticData","getVariantCards","()Lforge/card/CardDb;","invokevirtual",131);}
case 131:{f.Push(JValue.R(rt.String("Momir Vig, Simic Visionary Avatar")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",137);}
case 137:{f.Push(JValue.I(1));f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/deck/CardPool","add","(Lforge/item/InventoryItem;I)V","invokevirtual",141);}
case 141:{f.Push(f.Locals[1]);f.Pc=142;continue;}
case 142:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2644(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(28));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/game/GameType;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/GameType","Sealed","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Sealed","Lforge/game/GameType;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/GameType","Draft","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Draft","Lforge/game/GameType;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/GameType","CommanderDraft","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","CommanderDraft","Lforge/game/GameType;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/GameType","Winston","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Winston","Lforge/game/GameType;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/GameType","Gauntlet","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Gauntlet","Lforge/game/GameType;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/GameType","Tournament","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Tournament","Lforge/game/GameType;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/game/GameType","CommanderGauntlet","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","CommanderGauntlet","Lforge/game/GameType;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/game/GameType","Quest","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Quest","Lforge/game/GameType;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/game/GameType","QuestCommander","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","QuestCommander","Lforge/game/GameType;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/game/GameType","QuestDraft","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","QuestDraft","Lforge/game/GameType;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/GameType","PlanarConquest","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","PlanarConquest","Lforge/game/GameType;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(11));f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/game/GameType","Adventure","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Adventure","Lforge/game/GameType;"));f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(12));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/game/GameType","AdventureEvent","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","AdventureEvent","Lforge/game/GameType;"));f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(13));f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/game/GameType","Puzzle","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Puzzle","Lforge/game/GameType;"));f.Pc=96;continue;}
case 96:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(JValue.I(14));f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/game/GameType","Constructed","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Constructed","Lforge/game/GameType;"));f.Pc=103;continue;}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{f.StackOp("dup");f.Pc=105;continue;}
case 105:{f.Push(JValue.I(15));f.Pc=107;continue;}
case 107:{if(!rt.StaticReady(f,"forge/game/GameType","DeckManager","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","DeckManager","Lforge/game/GameType;"));f.Pc=110;continue;}
case 110:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=111;continue;}
case 111:{f.StackOp("dup");f.Pc=112;continue;}
case 112:{f.Push(JValue.I(16));f.Pc=114;continue;}
case 114:{if(!rt.StaticReady(f,"forge/game/GameType","Vanguard","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Vanguard","Lforge/game/GameType;"));f.Pc=117;continue;}
case 117:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{f.Push(JValue.I(17));f.Pc=121;continue;}
case 121:{if(!rt.StaticReady(f,"forge/game/GameType","Commander","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Commander","Lforge/game/GameType;"));f.Pc=124;continue;}
case 124:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=125;continue;}
case 125:{f.StackOp("dup");f.Pc=126;continue;}
case 126:{f.Push(JValue.I(18));f.Pc=128;continue;}
case 128:{if(!rt.StaticReady(f,"forge/game/GameType","Oathbreaker","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Oathbreaker","Lforge/game/GameType;"));f.Pc=131;continue;}
case 131:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=132;continue;}
case 132:{f.StackOp("dup");f.Pc=133;continue;}
case 133:{f.Push(JValue.I(19));f.Pc=135;continue;}
case 135:{if(!rt.StaticReady(f,"forge/game/GameType","TinyLeaders","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","TinyLeaders","Lforge/game/GameType;"));f.Pc=138;continue;}
case 138:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=139;continue;}
case 139:{f.StackOp("dup");f.Pc=140;continue;}
case 140:{f.Push(JValue.I(20));f.Pc=142;continue;}
case 142:{if(!rt.StaticReady(f,"forge/game/GameType","Brawl","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Brawl","Lforge/game/GameType;"));f.Pc=145;continue;}
case 145:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=146;continue;}
case 146:{f.StackOp("dup");f.Pc=147;continue;}
case 147:{f.Push(JValue.I(21));f.Pc=149;continue;}
case 149:{if(!rt.StaticReady(f,"forge/game/GameType","Planeswalker","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Planeswalker","Lforge/game/GameType;"));f.Pc=152;continue;}
case 152:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=153;continue;}
case 153:{f.StackOp("dup");f.Pc=154;continue;}
case 154:{f.Push(JValue.I(22));f.Pc=156;continue;}
case 156:{if(!rt.StaticReady(f,"forge/game/GameType","Planechase","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Planechase","Lforge/game/GameType;"));f.Pc=159;continue;}
case 159:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=160;continue;}
case 160:{f.StackOp("dup");f.Pc=161;continue;}
case 161:{f.Push(JValue.I(23));f.Pc=163;continue;}
case 163:{if(!rt.StaticReady(f,"forge/game/GameType","Archenemy","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Archenemy","Lforge/game/GameType;"));f.Pc=166;continue;}
case 166:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=167;continue;}
case 167:{f.StackOp("dup");f.Pc=168;continue;}
case 168:{f.Push(JValue.I(24));f.Pc=170;continue;}
case 170:{if(!rt.StaticReady(f,"forge/game/GameType","ArchenemyRumble","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","ArchenemyRumble","Lforge/game/GameType;"));f.Pc=173;continue;}
case 173:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=174;continue;}
case 174:{f.StackOp("dup");f.Pc=175;continue;}
case 175:{f.Push(JValue.I(25));f.Pc=177;continue;}
case 177:{if(!rt.StaticReady(f,"forge/game/GameType","TwoHeadedGiant","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","TwoHeadedGiant","Lforge/game/GameType;"));f.Pc=180;continue;}
case 180:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=181;continue;}
case 181:{f.StackOp("dup");f.Pc=182;continue;}
case 182:{f.Push(JValue.I(26));f.Pc=184;continue;}
case 184:{if(!rt.StaticReady(f,"forge/game/GameType","MomirBasic","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","MomirBasic","Lforge/game/GameType;"));f.Pc=187;continue;}
case 187:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=188;continue;}
case 188:{f.StackOp("dup");f.Pc=189;continue;}
case 189:{f.Push(JValue.I(27));f.Pc=191;continue;}
case 191:{if(!rt.StaticReady(f,"forge/game/GameType","MoJhoSto","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","MoJhoSto","Lforge/game/GameType;"));f.Pc=194;continue;}
case 194:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=195;continue;}
case 195:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2645(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Sealed")));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Limited","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Limited","Lforge/deck/DeckFormat;"));f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("lblSealed")));f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/game/GameType","Sealed","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","Sealed","Lforge/game/GameType;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("Draft")));f.Pc=33;continue;}
case 33:{f.Push(JValue.I(1));f.Pc=34;continue;}
case 34:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Limited","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Limited","Lforge/deck/DeckFormat;"));f.Pc=37;continue;}
case 37:{f.Push(JValue.I(1));f.Pc=38;continue;}
case 38:{f.Push(JValue.I(1));f.Pc=39;continue;}
case 39:{f.Push(JValue.I(1));f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("lblDraft")));f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("")));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",49);}
case 49:{if(!rt.StaticReady(f,"forge/game/GameType","Draft","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","Draft","Lforge/game/GameType;",f.Pop());f.Pc=52;continue;}
case 52:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("CommanderDraft")));f.Pc=59;continue;}
case 59:{f.Push(JValue.I(2));f.Pc=60;continue;}
case 60:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","CommanderDraft","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","CommanderDraft","Lforge/deck/DeckFormat;"));f.Pc=63;continue;}
case 63:{f.Push(JValue.I(1));f.Pc=64;continue;}
case 64:{f.Push(JValue.I(1));f.Pc=65;continue;}
case 65:{f.Push(JValue.I(1));f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("lblCommanderDraft")));f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("lblCommanderDraftDesc")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",75);}
case 75:{if(!rt.StaticReady(f,"forge/game/GameType","CommanderDraft","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","CommanderDraft","Lforge/game/GameType;",f.Pop());f.Pc=78;continue;}
case 78:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("Winston")));f.Pc=85;continue;}
case 85:{f.Push(JValue.I(3));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Limited","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Limited","Lforge/deck/DeckFormat;"));f.Pc=89;continue;}
case 89:{f.Push(JValue.I(1));f.Pc=90;continue;}
case 90:{f.Push(JValue.I(1));f.Pc=91;continue;}
case 91:{f.Push(JValue.I(1));f.Pc=92;continue;}
case 92:{f.Push(JValue.R(rt.String("lblWinston")));f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("")));f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",101);}
case 101:{if(!rt.StaticReady(f,"forge/game/GameType","Winston","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","Winston","Lforge/game/GameType;",f.Pop());f.Pc=104;continue;}
case 104:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=107;continue;}
case 107:{f.StackOp("dup");f.Pc=108;continue;}
case 108:{f.Push(JValue.R(rt.String("Gauntlet")));f.Pc=111;continue;}
case 111:{f.Push(JValue.I(4));f.Pc=112;continue;}
case 112:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"));f.Pc=115;continue;}
case 115:{f.Push(JValue.I(0));f.Pc=116;continue;}
case 116:{f.Push(JValue.I(1));f.Pc=117;continue;}
case 117:{f.Push(JValue.I(1));f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("lblGauntlet")));f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",127);}
case 127:{if(!rt.StaticReady(f,"forge/game/GameType","Gauntlet","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","Gauntlet","Lforge/game/GameType;",f.Pop());f.Pc=130;continue;}
case 130:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=133;continue;}
case 133:{f.StackOp("dup");f.Pc=134;continue;}
case 134:{f.Push(JValue.R(rt.String("Tournament")));f.Pc=137;continue;}
case 137:{f.Push(JValue.I(5));f.Pc=138;continue;}
case 138:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"));f.Pc=141;continue;}
case 141:{f.Push(JValue.I(0));f.Pc=142;continue;}
case 142:{f.Push(JValue.I(1));f.Pc=143;continue;}
case 143:{f.Push(JValue.I(1));f.Pc=144;continue;}
case 144:{f.Push(JValue.R(rt.String("lblTournament")));f.Pc=147;continue;}
case 147:{f.Push(JValue.R(rt.String("")));f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",153);}
case 153:{if(!rt.StaticReady(f,"forge/game/GameType","Tournament","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","Tournament","Lforge/game/GameType;",f.Pop());f.Pc=156;continue;}
case 156:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=159;continue;}
case 159:{f.StackOp("dup");f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("CommanderGauntlet")));f.Pc=163;continue;}
case 163:{f.Push(JValue.I(6));f.Pc=165;continue;}
case 165:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Commander","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Commander","Lforge/deck/DeckFormat;"));f.Pc=168;continue;}
case 168:{f.Push(JValue.I(0));f.Pc=169;continue;}
case 169:{f.Push(JValue.I(0));f.Pc=170;continue;}
case 170:{f.Push(JValue.I(0));f.Pc=171;continue;}
case 171:{f.Push(JValue.R(rt.String("lblCommanderGauntlet")));f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("lblCommanderDesc")));f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",180);}
case 180:{if(!rt.StaticReady(f,"forge/game/GameType","CommanderGauntlet","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","CommanderGauntlet","Lforge/game/GameType;",f.Pop());f.Pc=183;continue;}
case 183:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=186;continue;}
case 186:{f.StackOp("dup");f.Pc=187;continue;}
case 187:{f.Push(JValue.R(rt.String("Quest")));f.Pc=190;continue;}
case 190:{f.Push(JValue.I(7));f.Pc=192;continue;}
case 192:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","QuestDeck","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","QuestDeck","Lforge/deck/DeckFormat;"));f.Pc=195;continue;}
case 195:{f.Push(JValue.I(1));f.Pc=196;continue;}
case 196:{f.Push(JValue.I(1));f.Pc=197;continue;}
case 197:{f.Push(JValue.I(0));f.Pc=198;continue;}
case 198:{f.Push(JValue.R(rt.String("lblQuest")));f.Pc=201;continue;}
case 201:{f.Push(JValue.R(rt.String("")));f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",207);}
case 207:{if(!rt.StaticReady(f,"forge/game/GameType","Quest","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","Quest","Lforge/game/GameType;",f.Pop());f.Pc=210;continue;}
case 210:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=213;continue;}
case 213:{f.StackOp("dup");f.Pc=214;continue;}
case 214:{f.Push(JValue.R(rt.String("QuestCommander")));f.Pc=217;continue;}
case 217:{f.Push(JValue.I(8));f.Pc=219;continue;}
case 219:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Commander","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Commander","Lforge/deck/DeckFormat;"));f.Pc=222;continue;}
case 222:{f.Push(JValue.I(1));f.Pc=223;continue;}
case 223:{f.Push(JValue.I(1));f.Pc=224;continue;}
case 224:{f.Push(JValue.I(0));f.Pc=225;continue;}
case 225:{f.Push(JValue.R(rt.String("lblQuestCommander")));f.Pc=228;continue;}
case 228:{f.Push(JValue.R(rt.String("")));f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",234);}
case 234:{if(!rt.StaticReady(f,"forge/game/GameType","QuestCommander","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","QuestCommander","Lforge/game/GameType;",f.Pop());f.Pc=237;continue;}
case 237:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=240;continue;}
case 240:{f.StackOp("dup");f.Pc=241;continue;}
case 241:{f.Push(JValue.R(rt.String("QuestDraft")));f.Pc=244;continue;}
case 244:{f.Push(JValue.I(9));f.Pc=246;continue;}
case 246:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Limited","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Limited","Lforge/deck/DeckFormat;"));f.Pc=249;continue;}
case 249:{f.Push(JValue.I(1));f.Pc=250;continue;}
case 250:{f.Push(JValue.I(1));f.Pc=251;continue;}
case 251:{f.Push(JValue.I(1));f.Pc=252;continue;}
case 252:{f.Push(JValue.R(rt.String("lblQuestDraft")));f.Pc=255;continue;}
case 255:{f.Push(JValue.R(rt.String("")));f.Pc=258;continue;}
case 258:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",261);}
case 261:{if(!rt.StaticReady(f,"forge/game/GameType","QuestDraft","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","QuestDraft","Lforge/game/GameType;",f.Pop());f.Pc=264;continue;}
case 264:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=267;continue;}
case 267:{f.StackOp("dup");f.Pc=268;continue;}
case 268:{f.Push(JValue.R(rt.String("PlanarConquest")));f.Pc=271;continue;}
case 271:{f.Push(JValue.I(10));f.Pc=273;continue;}
case 273:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","PlanarConquest","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","PlanarConquest","Lforge/deck/DeckFormat;"));f.Pc=276;continue;}
case 276:{f.Push(JValue.I(1));f.Pc=277;continue;}
case 277:{f.Push(JValue.I(0));f.Pc=278;continue;}
case 278:{f.Push(JValue.I(0));f.Pc=279;continue;}
case 279:{f.Push(JValue.R(rt.String("lblPlanarConquest")));f.Pc=282;continue;}
case 282:{f.Push(JValue.R(rt.String("")));f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",288);}
case 288:{if(!rt.StaticReady(f,"forge/game/GameType","PlanarConquest","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","PlanarConquest","Lforge/game/GameType;",f.Pop());f.Pc=291;continue;}
case 291:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=294;continue;}
case 294:{f.StackOp("dup");f.Pc=295;continue;}
case 295:{f.Push(JValue.R(rt.String("Adventure")));f.Pc=298;continue;}
case 298:{f.Push(JValue.I(11));f.Pc=300;continue;}
case 300:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Adventure","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Adventure","Lforge/deck/DeckFormat;"));f.Pc=303;continue;}
case 303:{f.Push(JValue.I(1));f.Pc=304;continue;}
case 304:{f.Push(JValue.I(0));f.Pc=305;continue;}
case 305:{f.Push(JValue.I(0));f.Pc=306;continue;}
case 306:{f.Push(JValue.R(rt.String("lblAdventure")));f.Pc=309;continue;}
case 309:{f.Push(JValue.R(rt.String("")));f.Pc=312;continue;}
case 312:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",315);}
case 315:{if(!rt.StaticReady(f,"forge/game/GameType","Adventure","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","Adventure","Lforge/game/GameType;",f.Pop());f.Pc=318;continue;}
case 318:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=321;continue;}
case 321:{f.StackOp("dup");f.Pc=322;continue;}
case 322:{f.Push(JValue.R(rt.String("AdventureEvent")));f.Pc=325;continue;}
case 325:{f.Push(JValue.I(12));f.Pc=327;continue;}
case 327:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Limited","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Limited","Lforge/deck/DeckFormat;"));f.Pc=330;continue;}
case 330:{f.Push(JValue.I(1));f.Pc=331;continue;}
case 331:{f.Push(JValue.I(1));f.Pc=332;continue;}
case 332:{f.Push(JValue.I(1));f.Pc=333;continue;}
case 333:{f.Push(JValue.R(rt.String("lblAdventure")));f.Pc=336;continue;}
case 336:{f.Push(JValue.R(rt.String("")));f.Pc=339;continue;}
case 339:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",342);}
case 342:{if(!rt.StaticReady(f,"forge/game/GameType","AdventureEvent","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","AdventureEvent","Lforge/game/GameType;",f.Pop());f.Pc=345;continue;}
case 345:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=348;continue;}
case 348:{f.StackOp("dup");f.Pc=349;continue;}
case 349:{f.Push(JValue.R(rt.String("Puzzle")));f.Pc=352;continue;}
case 352:{f.Push(JValue.I(13));f.Pc=354;continue;}
case 354:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Puzzle","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Puzzle","Lforge/deck/DeckFormat;"));f.Pc=357;continue;}
case 357:{f.Push(JValue.I(0));f.Pc=358;continue;}
case 358:{f.Push(JValue.I(0));f.Pc=359;continue;}
case 359:{f.Push(JValue.I(0));f.Pc=360;continue;}
case 360:{f.Push(JValue.R(rt.String("lblPuzzle")));f.Pc=363;continue;}
case 363:{f.Push(JValue.R(rt.String("lblPuzzleDesc")));f.Pc=366;continue;}
case 366:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",369);}
case 369:{if(!rt.StaticReady(f,"forge/game/GameType","Puzzle","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","Puzzle","Lforge/game/GameType;",f.Pop());f.Pc=372;continue;}
case 372:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=375;continue;}
case 375:{f.StackOp("dup");f.Pc=376;continue;}
case 376:{f.Push(JValue.R(rt.String("Constructed")));f.Pc=379;continue;}
case 379:{f.Push(JValue.I(14));f.Pc=381;continue;}
case 381:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"));f.Pc=384;continue;}
case 384:{f.Push(JValue.I(0));f.Pc=385;continue;}
case 385:{f.Push(JValue.I(1));f.Pc=386;continue;}
case 386:{f.Push(JValue.I(1));f.Pc=387;continue;}
case 387:{f.Push(JValue.R(rt.String("lblConstructed")));f.Pc=390;continue;}
case 390:{f.Push(JValue.R(rt.String("")));f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",396);}
case 396:{if(!rt.StaticReady(f,"forge/game/GameType","Constructed","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","Constructed","Lforge/game/GameType;",f.Pop());f.Pc=399;continue;}
case 399:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=402;continue;}
case 402:{f.StackOp("dup");f.Pc=403;continue;}
case 403:{f.Push(JValue.R(rt.String("DeckManager")));f.Pc=406;continue;}
case 406:{f.Push(JValue.I(15));f.Pc=408;continue;}
case 408:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"));f.Pc=411;continue;}
case 411:{f.Push(JValue.I(0));f.Pc=412;continue;}
case 412:{f.Push(JValue.I(1));f.Pc=413;continue;}
case 413:{f.Push(JValue.I(1));f.Pc=414;continue;}
case 414:{f.Push(JValue.R(rt.String("lblDeckManager")));f.Pc=417;continue;}
case 417:{f.Push(JValue.R(rt.String("")));f.Pc=420;continue;}
case 420:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",423);}
case 423:{if(!rt.StaticReady(f,"forge/game/GameType","DeckManager","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","DeckManager","Lforge/game/GameType;",f.Pop());f.Pc=426;continue;}
case 426:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=429;continue;}
case 429:{f.StackOp("dup");f.Pc=430;continue;}
case 430:{f.Push(JValue.R(rt.String("Vanguard")));f.Pc=433;continue;}
case 433:{f.Push(JValue.I(16));f.Pc=435;continue;}
case 435:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Vanguard","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Vanguard","Lforge/deck/DeckFormat;"));f.Pc=438;continue;}
case 438:{f.Push(JValue.I(1));f.Pc=439;continue;}
case 439:{f.Push(JValue.I(1));f.Pc=440;continue;}
case 440:{f.Push(JValue.I(1));f.Pc=441;continue;}
case 441:{f.Push(JValue.R(rt.String("lblVanguard")));f.Pc=444;continue;}
case 444:{f.Push(JValue.R(rt.String("lblVanguardDesc")));f.Pc=447;continue;}
case 447:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",450);}
case 450:{if(!rt.StaticReady(f,"forge/game/GameType","Vanguard","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","Vanguard","Lforge/game/GameType;",f.Pop());f.Pc=453;continue;}
case 453:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=456;continue;}
case 456:{f.StackOp("dup");f.Pc=457;continue;}
case 457:{f.Push(JValue.R(rt.String("Commander")));f.Pc=460;continue;}
case 460:{f.Push(JValue.I(17));f.Pc=462;continue;}
case 462:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Commander","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Commander","Lforge/deck/DeckFormat;"));f.Pc=465;continue;}
case 465:{f.Push(JValue.I(0));f.Pc=466;continue;}
case 466:{f.Push(JValue.I(0));f.Pc=467;continue;}
case 467:{f.Push(JValue.I(0));f.Pc=468;continue;}
case 468:{f.Push(JValue.R(rt.String("lblCommander")));f.Pc=471;continue;}
case 471:{f.Push(JValue.R(rt.String("lblCommanderDesc")));f.Pc=474;continue;}
case 474:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",477);}
case 477:{if(!rt.StaticReady(f,"forge/game/GameType","Commander","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","Commander","Lforge/game/GameType;",f.Pop());f.Pc=480;continue;}
case 480:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=483;continue;}
case 483:{f.StackOp("dup");f.Pc=484;continue;}
case 484:{f.Push(JValue.R(rt.String("Oathbreaker")));f.Pc=487;continue;}
case 487:{f.Push(JValue.I(18));f.Pc=489;continue;}
case 489:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Oathbreaker","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Oathbreaker","Lforge/deck/DeckFormat;"));f.Pc=492;continue;}
case 492:{f.Push(JValue.I(0));f.Pc=493;continue;}
case 493:{f.Push(JValue.I(0));f.Pc=494;continue;}
case 494:{f.Push(JValue.I(0));f.Pc=495;continue;}
case 495:{f.Push(JValue.R(rt.String("lblOathbreaker")));f.Pc=498;continue;}
case 498:{f.Push(JValue.R(rt.String("lblOathbreakerDesc")));f.Pc=501;continue;}
case 501:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",504);}
case 504:{if(!rt.StaticReady(f,"forge/game/GameType","Oathbreaker","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","Oathbreaker","Lforge/game/GameType;",f.Pop());f.Pc=507;continue;}
case 507:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=510;continue;}
case 510:{f.StackOp("dup");f.Pc=511;continue;}
case 511:{f.Push(JValue.R(rt.String("TinyLeaders")));f.Pc=514;continue;}
case 514:{f.Push(JValue.I(19));f.Pc=516;continue;}
case 516:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","TinyLeaders","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","TinyLeaders","Lforge/deck/DeckFormat;"));f.Pc=519;continue;}
case 519:{f.Push(JValue.I(0));f.Pc=520;continue;}
case 520:{f.Push(JValue.I(0));f.Pc=521;continue;}
case 521:{f.Push(JValue.I(0));f.Pc=522;continue;}
case 522:{f.Push(JValue.R(rt.String("lblTinyLeaders")));f.Pc=525;continue;}
case 525:{f.Push(JValue.R(rt.String("lblTinyLeadersDesc")));f.Pc=528;continue;}
case 528:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",531);}
case 531:{if(!rt.StaticReady(f,"forge/game/GameType","TinyLeaders","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","TinyLeaders","Lforge/game/GameType;",f.Pop());f.Pc=534;continue;}
case 534:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=537;continue;}
case 537:{f.StackOp("dup");f.Pc=538;continue;}
case 538:{f.Push(JValue.R(rt.String("Brawl")));f.Pc=541;continue;}
case 541:{f.Push(JValue.I(20));f.Pc=543;continue;}
case 543:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Brawl","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Brawl","Lforge/deck/DeckFormat;"));f.Pc=546;continue;}
case 546:{f.Push(JValue.I(0));f.Pc=547;continue;}
case 547:{f.Push(JValue.I(0));f.Pc=548;continue;}
case 548:{f.Push(JValue.I(0));f.Pc=549;continue;}
case 549:{f.Push(JValue.R(rt.String("lblBrawl")));f.Pc=552;continue;}
case 552:{f.Push(JValue.R(rt.String("lblBrawlDesc")));f.Pc=555;continue;}
case 555:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",558);}
case 558:{if(!rt.StaticReady(f,"forge/game/GameType","Brawl","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","Brawl","Lforge/game/GameType;",f.Pop());f.Pc=561;continue;}
case 561:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=564;continue;}
case 564:{f.StackOp("dup");f.Pc=565;continue;}
case 565:{f.Push(JValue.R(rt.String("Planeswalker")));f.Pc=568;continue;}
case 568:{f.Push(JValue.I(21));f.Pc=570;continue;}
case 570:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","PlanarConquest","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","PlanarConquest","Lforge/deck/DeckFormat;"));f.Pc=573;continue;}
case 573:{f.Push(JValue.I(0));f.Pc=574;continue;}
case 574:{f.Push(JValue.I(0));f.Pc=575;continue;}
case 575:{f.Push(JValue.I(1));f.Pc=576;continue;}
case 576:{f.Push(JValue.R(rt.String("lblPlaneswalker")));f.Pc=579;continue;}
case 579:{f.Push(JValue.R(rt.String("lblPlaneswalkerDesc")));f.Pc=582;continue;}
case 582:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",585);}
case 585:{if(!rt.StaticReady(f,"forge/game/GameType","Planeswalker","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","Planeswalker","Lforge/game/GameType;",f.Pop());f.Pc=588;continue;}
case 588:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=591;continue;}
case 591:{f.StackOp("dup");f.Pc=592;continue;}
case 592:{f.Push(JValue.R(rt.String("Planechase")));f.Pc=595;continue;}
case 595:{f.Push(JValue.I(22));f.Pc=597;continue;}
case 597:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Planechase","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Planechase","Lforge/deck/DeckFormat;"));f.Pc=600;continue;}
case 600:{f.Push(JValue.I(0));f.Pc=601;continue;}
case 601:{f.Push(JValue.I(0));f.Pc=602;continue;}
case 602:{f.Push(JValue.I(1));f.Pc=603;continue;}
case 603:{f.Push(JValue.R(rt.String("lblPlanechase")));f.Pc=606;continue;}
case 606:{f.Push(JValue.R(rt.String("lblPlanechaseDesc")));f.Pc=609;continue;}
case 609:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",612);}
case 612:{if(!rt.StaticReady(f,"forge/game/GameType","Planechase","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","Planechase","Lforge/game/GameType;",f.Pop());f.Pc=615;continue;}
case 615:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=618;continue;}
case 618:{f.StackOp("dup");f.Pc=619;continue;}
case 619:{f.Push(JValue.R(rt.String("Archenemy")));f.Pc=622;continue;}
case 622:{f.Push(JValue.I(23));f.Pc=624;continue;}
case 624:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Archenemy","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Archenemy","Lforge/deck/DeckFormat;"));f.Pc=627;continue;}
case 627:{f.Push(JValue.I(0));f.Pc=628;continue;}
case 628:{f.Push(JValue.I(0));f.Pc=629;continue;}
case 629:{f.Push(JValue.I(1));f.Pc=630;continue;}
case 630:{f.Push(JValue.R(rt.String("lblArchenemy")));f.Pc=633;continue;}
case 633:{f.Push(JValue.R(rt.String("lblArchenemyDesc")));f.Pc=636;continue;}
case 636:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",639);}
case 639:{if(!rt.StaticReady(f,"forge/game/GameType","Archenemy","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","Archenemy","Lforge/game/GameType;",f.Pop());f.Pc=642;continue;}
case 642:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=645;continue;}
case 645:{f.StackOp("dup");f.Pc=646;continue;}
case 646:{f.Push(JValue.R(rt.String("ArchenemyRumble")));f.Pc=649;continue;}
case 649:{f.Push(JValue.I(24));f.Pc=651;continue;}
case 651:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Archenemy","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Archenemy","Lforge/deck/DeckFormat;"));f.Pc=654;continue;}
case 654:{f.Push(JValue.I(0));f.Pc=655;continue;}
case 655:{f.Push(JValue.I(0));f.Pc=656;continue;}
case 656:{f.Push(JValue.I(1));f.Pc=657;continue;}
case 657:{f.Push(JValue.R(rt.String("lblArchenemyRumble")));f.Pc=660;continue;}
case 660:{f.Push(JValue.R(rt.String("lblArchenemyRumbleDesc")));f.Pc=663;continue;}
case 663:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",666);}
case 666:{if(!rt.StaticReady(f,"forge/game/GameType","ArchenemyRumble","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","ArchenemyRumble","Lforge/game/GameType;",f.Pop());f.Pc=669;continue;}
case 669:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=672;continue;}
case 672:{f.StackOp("dup");f.Pc=673;continue;}
case 673:{f.Push(JValue.R(rt.String("TwoHeadedGiant")));f.Pc=676;continue;}
case 676:{f.Push(JValue.I(25));f.Pc=678;continue;}
case 678:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"));f.Pc=681;continue;}
case 681:{f.Push(JValue.I(0));f.Pc=682;continue;}
case 682:{f.Push(JValue.I(1));f.Pc=683;continue;}
case 683:{f.Push(JValue.I(1));f.Pc=684;continue;}
case 684:{f.Push(JValue.R(rt.String("lblTwoHeadedGiant")));f.Pc=687;continue;}
case 687:{f.Push(JValue.R(rt.String("lblTwoHeadedGiantDesc")));f.Pc=690;continue;}
case 690:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;)V","invokespecial",693);}
case 693:{if(!rt.StaticReady(f,"forge/game/GameType","TwoHeadedGiant","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","TwoHeadedGiant","Lforge/game/GameType;",f.Pop());f.Pc=696;continue;}
case 696:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=699;continue;}
case 699:{f.StackOp("dup");f.Pc=700;continue;}
case 700:{f.Push(JValue.R(rt.String("MomirBasic")));f.Pc=703;continue;}
case 703:{f.Push(JValue.I(26));f.Pc=705;continue;}
case 705:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"));f.Pc=708;continue;}
case 708:{f.Push(JValue.I(0));f.Pc=709;continue;}
case 709:{f.Push(JValue.I(0));f.Pc=710;continue;}
case 710:{f.Push(JValue.I(0));f.Pc=711;continue;}
case 711:{f.Push(JValue.R(rt.String("lblMomirBasic")));f.Pc=714;continue;}
case 714:{f.Push(JValue.R(rt.String("lblMomirBasicDesc")));f.Pc=717;continue;}
case 717:{return rt.DynamicCall(f,"forge/game/GameType:2645:717:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",722);}
case 722:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;Ljava/util/function/Function;)V","invokespecial",725);}
case 725:{if(!rt.StaticReady(f,"forge/game/GameType","MomirBasic","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","MomirBasic","Lforge/game/GameType;",f.Pop());f.Pc=728;continue;}
case 728:{if(!rt.EnsureInitialized(f,"forge/game/GameType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameType")));f.Pc=731;continue;}
case 731:{f.StackOp("dup");f.Pc=732;continue;}
case 732:{f.Push(JValue.R(rt.String("MoJhoSto")));f.Pc=735;continue;}
case 735:{f.Push(JValue.I(27));f.Pc=737;continue;}
case 737:{if(!rt.StaticReady(f,"forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckFormat","Constructed","Lforge/deck/DeckFormat;"));f.Pc=740;continue;}
case 740:{f.Push(JValue.I(0));f.Pc=741;continue;}
case 741:{f.Push(JValue.I(0));f.Pc=742;continue;}
case 742:{f.Push(JValue.I(0));f.Pc=743;continue;}
case 743:{f.Push(JValue.R(rt.String("lblMoJhoSto")));f.Pc=746;continue;}
case 746:{f.Push(JValue.R(rt.String("lblMoJhoStoDesc")));f.Pc=749;continue;}
case 749:{return rt.DynamicCall(f,"forge/game/GameType:2645:749:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",754);}
case 754:{return rt.Call(f,"forge/game/GameType","<init>","(Ljava/lang/String;ILforge/deck/DeckFormat;ZZZLjava/lang/String;Ljava/lang/String;Ljava/util/function/Function;)V","invokespecial",757);}
case 757:{if(!rt.StaticReady(f,"forge/game/GameType","MoJhoSto","Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","MoJhoSto","Lforge/game/GameType;",f.Pop());f.Pc=760;continue;}
case 760:{return rt.Call(f,"forge/game/GameType","$values","()[Lforge/game/GameType;","invokestatic",763);}
case 763:{if(!rt.StaticReady(f,"forge/game/GameType","$VALUES","[Lforge/game/GameType;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","$VALUES","[Lforge/game/GameType;",f.Pop());f.Pc=766;continue;}
case 766:{if(!rt.StaticReady(f,"forge/game/GameType","Draft","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","Draft","Lforge/game/GameType;"));f.Pc=769;continue;}
case 769:{if(!rt.StaticReady(f,"forge/game/GameType","CommanderDraft","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","CommanderDraft","Lforge/game/GameType;"));f.Pc=772;continue;}
case 772:{if(!rt.StaticReady(f,"forge/game/GameType","QuestDraft","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","QuestDraft","Lforge/game/GameType;"));f.Pc=775;continue;}
case 775:{if(!rt.StaticReady(f,"forge/game/GameType","AdventureEvent","Lforge/game/GameType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameType","AdventureEvent","Lforge/game/GameType;"));f.Pc=778;continue;}
case 778:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",781);}
case 781:{if(!rt.StaticReady(f,"forge/game/GameType","DRAFT_FORMATS","Ljava/util/EnumSet;"))return JStep.Continue;rt.PutStatic("forge/game/GameType","DRAFT_FORMATS","Ljava/util/EnumSet;",f.Pop());f.Pc=784;continue;}
case 784:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
