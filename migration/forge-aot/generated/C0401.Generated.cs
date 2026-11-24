// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C401{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/SkipPhaseEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3726,"forge/game/ability/effects/SkipPhaseEffect","<init>","()V",1,1,1,new JHandler[]{},M3726));
c.Add(new JMethod(3727,"forge/game/ability/effects/SkipPhaseEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,8,2,new JHandler[]{},M3727));
c.Add(new JMethod(3728,"forge/game/ability/effects/SkipPhaseEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,7,5,new JHandler[]{},M3728));
c.Add(new JMethod(3729,"forge/game/ability/effects/SkipPhaseEffect","createSkipPhaseEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V",9,16,5,new JHandler[]{},M3729));
c.Add(new JMethod(3730,"forge/game/ability/effects/SkipPhaseEffect","$deserializeLambda$","(Ljava/lang/invoke/SerializedLambda;)Ljava/lang/Object;",4106,3,4,new JHandler[]{},M3730));
c.Add(new JMethod(3731,"forge/game/ability/effects/SkipPhaseEffect","lambda$createSkipPhaseEffect$48de41fd$1","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V",4106,3,3,new JHandler[]{},M3731));
c.Add(new JMethod(3732,"forge/game/ability/effects/SkipPhaseEffect","lambda$createSkipPhaseEffect$361eb38a$1","(Lforge/game/Game;Lforge/game/card/Card;)V",4106,2,2,new JHandler[]{},M3732));
}

internal static JStep M3726(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3727(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Duration")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("Phase")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("Step")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",29);}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/ability/effects/SkipPhaseEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",35);}
case 35:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",38);}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",47);}
case 47:{f.Pc=f.Pop().Int==0?133:50;continue;}
case 50:{f.Push(f.Locals[6]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",57);}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{f.Locals[7]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[7]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",68);}
case 68:{f.Push(JValue.R(rt.String(" ")));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",73);}
case 73:{f.StackOp("pop");f.Pc=74;continue;}
case 74:{f.Push(f.Locals[2]);f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("skips their ")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",80);}
case 80:{f.StackOp("pop");f.Pc=81;continue;}
case 81:{f.Push(f.Locals[3]);f.Pc=82;continue;}
case 82:{f.Pc=f.Pop().Reference!=null?92:85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.String("next ")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",91);}
case 91:{f.StackOp("pop");f.Pc=92;continue;}
case 92:{f.Push(f.Locals[4]);f.Pc=94;continue;}
case 94:{f.Pc=f.Pop().Reference==null?115:97;continue;}
case 97:{f.Push(f.Locals[2]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[4]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",103);}
case 103:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",106);}
case 106:{f.Push(JValue.R(rt.String(" phase.")));f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",111);}
case 111:{f.StackOp("pop");f.Pc=112;continue;}
case 112:{f.Pc=130;continue;}
case 115:{f.Push(f.Locals[2]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[5]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",121);}
case 121:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",124);}
case 124:{f.Push(JValue.R(rt.String(" step.")));f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",129);}
case 129:{f.StackOp("pop");f.Pc=130;continue;}
case 130:{f.Pc=40;continue;}
case 133:{f.Push(f.Locals[2]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",137);}
case 137:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3728(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Duration")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("Phase")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",13);}
case 13:{f.Locals[3]=f.Pop();f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.String("Step")));f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",20);}
case 20:{f.Locals[4]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/ability/effects/SkipPhaseEffect","getTargetPlayersOnePerTeam","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",26);}
case 26:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",29);}
case 29:{f.Locals[5]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",38);}
case 38:{f.Pc=f.Pop().Int==0?66:41;continue;}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{f.Locals[6]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[6]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[2]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/ability/effects/SkipPhaseEffect","createSkipPhaseEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokestatic",63);}
case 63:{f.Pc=31;continue;}
case 66:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3729(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[5]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[5]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",11);}
case 11:{f.Locals[6]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[5]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",18);}
case 18:{return rt.DynamicCall(f,"forge/game/ability/effects/SkipPhaseEffect:3729:18:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",23);}
case 23:{f.Locals[7]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[5]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",30);}
case 30:{f.Locals[8]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{f.Pc=f.Pop().Reference==null?49:36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("NextThisTurn")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?49:45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{f.Pc=50;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{f.Locals[9]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{f.Push(f.Locals[1]);f.Pc=54;continue;}
case 54:{f.Push(f.Locals[7]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[8]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/ability/effects/SkipPhaseEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Lforge/game/card/Card;","invokestatic",61);}
case 61:{f.Locals[10]=f.Pop();f.Pc=63;continue;}
case 63:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=66;continue;}
case 66:{f.StackOp("dup");f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",70);}
case 70:{f.Locals[11]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[11]);f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.String("Event$ BeginPhase | ActiveZones$ Command | ValidPlayer$ You | Phase$ ")));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",79);}
case 79:{f.StackOp("pop");f.Pc=80;continue;}
case 80:{f.Push(f.Locals[11]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[3]);f.Pc=83;continue;}
case 83:{f.Pc=f.Pop().Reference==null?90:86;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{f.Pc=92;continue;}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",95);}
case 95:{f.StackOp("pop");f.Pc=96;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{f.Pc=f.Pop().Reference==null?113:100;continue;}
case 100:{f.Push(f.Locals[9]);f.Pc=102;continue;}
case 102:{f.Pc=f.Pop().Int!=0?113:105;continue;}
case 105:{f.Push(f.Locals[11]);f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String(" | Skip$ True")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",112);}
case 112:{f.StackOp("pop");f.Pc=113;continue;}
case 113:{f.Push(f.Locals[11]);f.Pc=115;continue;}
case 115:{f.Push(JValue.R(rt.String("| Description$ Skip ")));f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",120);}
case 120:{f.StackOp("pop");f.Pc=121;continue;}
case 121:{f.Push(f.Locals[2]);f.Pc=122;continue;}
case 122:{f.Pc=f.Pop().Reference==null?130:125;continue;}
case 125:{f.Push(f.Locals[9]);f.Pc=127;continue;}
case 127:{f.Pc=f.Pop().Int==0?141:130;continue;}
case 130:{f.Push(f.Locals[11]);f.Pc=132;continue;}
case 132:{f.Push(JValue.R(rt.String("your next ")));f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",137);}
case 137:{f.StackOp("pop");f.Pc=138;continue;}
case 138:{f.Pc=149;continue;}
case 141:{f.Push(f.Locals[11]);f.Pc=143;continue;}
case 143:{f.Push(JValue.R(rt.String("each ")));f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",148);}
case 148:{f.StackOp("pop");f.Pc=149;continue;}
case 149:{f.Push(f.Locals[3]);f.Pc=150;continue;}
case 150:{f.Pc=f.Pop().Reference==null?171:153;continue;}
case 153:{f.Push(f.Locals[11]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[3]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",159);}
case 159:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",162);}
case 162:{f.Push(JValue.R(rt.String(" phase")));f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",167);}
case 167:{f.StackOp("pop");f.Pc=168;continue;}
case 168:{f.Pc=187;continue;}
case 171:{f.Push(f.Locals[11]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[4]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",178);}
case 178:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",181);}
case 181:{f.Push(JValue.R(rt.String(" step")));f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",186);}
case 186:{f.StackOp("pop");f.Pc=187;continue;}
case 187:{f.Push(f.Locals[2]);f.Pc=188;continue;}
case 188:{f.Pc=f.Pop().Reference!=null?202:191;continue;}
case 191:{f.Push(f.Locals[11]);f.Pc=193;continue;}
case 193:{f.Push(JValue.R(rt.String(".")));f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",198);}
case 198:{f.StackOp("pop");f.Pc=199;continue;}
case 199:{f.Pc=233;continue;}
case 202:{f.Push(f.Locals[6]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/Game","getPhaseHandler","()Lforge/game/phase/PhaseHandler;","invokevirtual",207);}
case 207:{f.Push(f.Locals[1]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"forge/game/phase/PhaseHandler","isPlayerTurn","(Lforge/game/player/Player;)Z","invokevirtual",211);}
case 211:{f.Pc=f.Pop().Int==0?225:214;continue;}
case 214:{f.Push(f.Locals[11]);f.Pc=216;continue;}
case 216:{f.Push(JValue.R(rt.String(" of this turn.")));f.Pc=218;continue;}
case 218:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",221);}
case 221:{f.StackOp("pop");f.Pc=222;continue;}
case 222:{f.Pc=233;continue;}
case 225:{f.Push(f.Locals[11]);f.Pc=227;continue;}
case 227:{f.Push(JValue.R(rt.String(" of your next turn.")));f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",232);}
case 232:{f.StackOp("pop");f.Pc=233;continue;}
case 233:{f.Push(f.Locals[11]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",238);}
case 238:{f.Locals[12]=f.Pop();f.Pc=240;continue;}
case 240:{f.Push(f.Locals[12]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[10]);f.Pc=244;continue;}
case 244:{f.Push(JValue.I(1));f.Pc=245;continue;}
case 245:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",248);}
case 248:{f.Locals[13]=f.Pop();f.Pc=250;continue;}
case 250:{f.Push(f.Locals[13]);f.Pc=252;continue;}
case 252:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementLayer","Control","Lforge/game/replacement/ReplacementLayer;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementLayer","Control","Lforge/game/replacement/ReplacementLayer;"));f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setLayer","(Lforge/game/replacement/ReplacementLayer;)V","invokevirtual",258);}
case 258:{f.Push(f.Locals[2]);f.Pc=259;continue;}
case 259:{f.Pc=f.Pop().Reference==null?267:262;continue;}
case 262:{f.Push(f.Locals[9]);f.Pc=264;continue;}
case 264:{f.Pc=f.Pop().Int==0?287:267;continue;}
case 267:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Self | Origin$ Command | Destination$ Exile")));f.Pc=269;continue;}
case 269:{f.Locals[14]=f.Pop();f.Pc=271;continue;}
case 271:{f.Push(f.Locals[14]);f.Pc=273;continue;}
case 273:{f.Push(f.Locals[10]);f.Pc=275;continue;}
case 275:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",278);}
case 278:{f.Locals[15]=f.Pop();f.Pc=280;continue;}
case 280:{f.Push(f.Locals[13]);f.Pc=282;continue;}
case 282:{f.Push(f.Locals[15]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",287);}
case 287:{f.Push(f.Locals[2]);f.Pc=288;continue;}
case 288:{f.Pc=f.Pop().Reference==null?304:291;continue;}
case 291:{f.Push(f.Locals[0]);f.Pc=292;continue;}
case 292:{f.Push(f.Locals[6]);f.Pc=294;continue;}
case 294:{f.Push(f.Locals[10]);f.Pc=296;continue;}
case 296:{return rt.DynamicCall(f,"forge/game/ability/effects/SkipPhaseEffect:3729:296:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/GameCommand;",301);}
case 301:{return rt.Call(f,"forge/game/ability/effects/SkipPhaseEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;)V","invokestatic",304);}
case 304:{f.Push(f.Locals[10]);f.Pc=306;continue;}
case 306:{f.Push(f.Locals[13]);f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/game/card/Card","addReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)Lforge/game/replacement/ReplacementEffect;","invokevirtual",311);}
case 311:{f.StackOp("pop");f.Pc=312;continue;}
case 312:{f.Push(f.Locals[0]);f.Pc=313;continue;}
case 313:{f.Push(JValue.R(rt.String("Start")));f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",318);}
case 318:{f.Pc=f.Pop().Int==0?343:321;continue;}
case 321:{f.Push(f.Locals[6]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"forge/game/Game","getUpkeep","()Lforge/game/phase/Phase;","invokevirtual",326);}
case 326:{f.Push(f.Locals[1]);f.Pc=327;continue;}
case 327:{f.Push(f.Locals[6]);f.Pc=329;continue;}
case 329:{f.Push(f.Locals[10]);f.Pc=331;continue;}
case 331:{f.Push(f.Locals[0]);f.Pc=332;continue;}
case 332:{return rt.DynamicCall(f,"forge/game/ability/effects/SkipPhaseEffect:3729:332:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/GameCommand;",337);}
case 337:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/game/player/Player;Lforge/GameCommand;)V","invokevirtual",340);}
case 340:{f.Pc=354;continue;}
case 343:{f.Push(f.Locals[6]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",348);}
case 348:{f.Push(f.Locals[10]);f.Pc=350;continue;}
case 350:{f.Push(f.Locals[0]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",354);}
case 354:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3730(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(-1));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",11);}
case 11:{switch(f.Pop().Int){case -878937987:f.Pc=36;break;case 1265917998:f.Pc=50;break;default:f.Pc=61;break;}continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("lambda$createSkipPhaseEffect$48de41fd$1")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int==0?61:45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{f.Locals[2]=f.Pop();f.Pc=47;continue;}
case 47:{f.Pc=61;continue;}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("lambda$createSkipPhaseEffect$361eb38a$1")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int==0?61:59;continue;}
case 59:{f.Push(JValue.I(1));f.Pc=60;continue;}
case 60:{f.Locals[2]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{switch(f.Pop().Int){case 0:f.Pc=88;break;case 1:f.Pc=187;break;default:f.Pc=279;break;}continue;}
case 88:{f.Push(f.Locals[0]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodKind","()I","invokevirtual",92);}
case 92:{f.Push(JValue.I(6));f.Pc=94;continue;}
case 94:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?279:97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceClass","()Ljava/lang/String;","invokevirtual",101);}
case 101:{f.Push(JValue.R(rt.String("forge/GameCommand")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?279:109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodName","()Ljava/lang/String;","invokevirtual",113);}
case 113:{f.Push(JValue.R(rt.String("run")));f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",118);}
case 118:{f.Pc=f.Pop().Int==0?279:121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodSignature","()Ljava/lang/String;","invokevirtual",125);}
case 125:{f.Push(JValue.R(rt.String("()V")));f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",130);}
case 130:{f.Pc=f.Pop().Int==0?279:133;continue;}
case 133:{f.Push(f.Locals[0]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplClass","()Ljava/lang/String;","invokevirtual",137);}
case 137:{f.Push(JValue.R(rt.String("forge/game/ability/effects/SkipPhaseEffect")));f.Pc=139;continue;}
case 139:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",142);}
case 142:{f.Pc=f.Pop().Int==0?279:145;continue;}
case 145:{f.Push(f.Locals[0]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodSignature","()Ljava/lang/String;","invokevirtual",149);}
case 149:{f.Push(JValue.R(rt.String("(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V")));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",154);}
case 154:{f.Pc=f.Pop().Int==0?279:157;continue;}
case 157:{f.Push(f.Locals[0]);f.Pc=158;continue;}
case 158:{f.Push(JValue.I(0));f.Pc=159;continue;}
case 159:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",162);}
case 162:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/Game"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=165;continue;}
case 165:{f.Push(f.Locals[0]);f.Pc=166;continue;}
case 166:{f.Push(JValue.I(1));f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",170);}
case 170:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[0]);f.Pc=174;continue;}
case 174:{f.Push(JValue.I(2));f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",178);}
case 178:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=181;continue;}
case 181:{return rt.DynamicCall(f,"forge/game/ability/effects/SkipPhaseEffect:3730:181:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/Game;Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Lforge/GameCommand;",186);}
case 186:{return JStep.Return(f.Pop());}
case 187:{f.Push(f.Locals[0]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodKind","()I","invokevirtual",191);}
case 191:{f.Push(JValue.I(6));f.Pc=193;continue;}
case 193:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?279:196;continue;}
case 196:{f.Push(f.Locals[0]);f.Pc=197;continue;}
case 197:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceClass","()Ljava/lang/String;","invokevirtual",200);}
case 200:{f.Push(JValue.R(rt.String("forge/GameCommand")));f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",205);}
case 205:{f.Pc=f.Pop().Int==0?279:208;continue;}
case 208:{f.Push(f.Locals[0]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodName","()Ljava/lang/String;","invokevirtual",212);}
case 212:{f.Push(JValue.R(rt.String("run")));f.Pc=214;continue;}
case 214:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",217);}
case 217:{f.Pc=f.Pop().Int==0?279:220;continue;}
case 220:{f.Push(f.Locals[0]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodSignature","()Ljava/lang/String;","invokevirtual",224);}
case 224:{f.Push(JValue.R(rt.String("()V")));f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",229);}
case 229:{f.Pc=f.Pop().Int==0?279:232;continue;}
case 232:{f.Push(f.Locals[0]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplClass","()Ljava/lang/String;","invokevirtual",236);}
case 236:{f.Push(JValue.R(rt.String("forge/game/ability/effects/SkipPhaseEffect")));f.Pc=238;continue;}
case 238:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",241);}
case 241:{f.Pc=f.Pop().Int==0?279:244;continue;}
case 244:{f.Push(f.Locals[0]);f.Pc=245;continue;}
case 245:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodSignature","()Ljava/lang/String;","invokevirtual",248);}
case 248:{f.Push(JValue.R(rt.String("(Lforge/game/Game;Lforge/game/card/Card;)V")));f.Pc=251;continue;}
case 251:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",254);}
case 254:{f.Pc=f.Pop().Int==0?279:257;continue;}
case 257:{f.Push(f.Locals[0]);f.Pc=258;continue;}
case 258:{f.Push(JValue.I(0));f.Pc=259;continue;}
case 259:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",262);}
case 262:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/Game"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=265;continue;}
case 265:{f.Push(f.Locals[0]);f.Pc=266;continue;}
case 266:{f.Push(JValue.I(1));f.Pc=267;continue;}
case 267:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",270);}
case 270:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=273;continue;}
case 273:{return rt.DynamicCall(f,"forge/game/ability/effects/SkipPhaseEffect:3730:273:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/GameCommand;",278);}
case 278:{return JStep.Return(f.Pop());}
case 279:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=282;continue;}
case 282:{f.StackOp("dup");f.Pc=283;continue;}
case 283:{f.Push(JValue.R(rt.String("Invalid lambda deserialization")));f.Pc=286;continue;}
case 286:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",289);}
case 289:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3731(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3732(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameAction","exileEffect","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",8);}
case 8:{f.StackOp("pop");f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
