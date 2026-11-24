// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C174{
internal static JClass Build(){var c=new JClass("forge/game/PlanarDice","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("Planeswalk","Lforge/game/PlanarDice;",true,JValue.Default("Lforge/game/PlanarDice;"),null));
c.Add(new JField("Chaos","Lforge/game/PlanarDice;",true,JValue.Default("Lforge/game/PlanarDice;"),null));
c.Add(new JField("Blank","Lforge/game/PlanarDice;",true,JValue.Default("Lforge/game/PlanarDice;"),null));
c.Add(new JField("values","Lcom/google/common/collect/ImmutableList;",true,JValue.Default("Lcom/google/common/collect/ImmutableList;"),null));
c.Add(new JField("$VALUES","[Lforge/game/PlanarDice;",true,JValue.Default("[Lforge/game/PlanarDice;"),null));
c.Add(new JMethod(2732,"forge/game/PlanarDice","values","()[Lforge/game/PlanarDice;",9,0,1,new JHandler[]{},M2732));
c.Add(new JMethod(2733,"forge/game/PlanarDice","valueOf","(Ljava/lang/String;)Lforge/game/PlanarDice;",9,1,2,new JHandler[]{},M2733));
c.Add(new JMethod(2734,"forge/game/PlanarDice","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M2734));
c.Add(new JMethod(2735,"forge/game/PlanarDice","roll","(Lforge/game/player/Player;Lforge/game/PlanarDice;)Lforge/game/PlanarDice;",9,11,6,new JHandler[]{},M2735));
c.Add(new JMethod(2736,"forge/game/PlanarDice","smartValueOf","(Ljava/lang/String;)Lforge/game/PlanarDice;",9,6,3,new JHandler[]{},M2736));
c.Add(new JMethod(2737,"forge/game/PlanarDice","$values","()[Lforge/game/PlanarDice;",4106,0,4,new JHandler[]{},M2737));
c.Add(new JMethod(2738,"forge/game/PlanarDice","<clinit>","()V",8,0,4,new JHandler[]{},M2738));
}

internal static JStep M2732(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/PlanarDice","$VALUES","[Lforge/game/PlanarDice;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/PlanarDice","$VALUES","[Lforge/game/PlanarDice;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/game/PlanarDice;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/PlanarDice;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2733(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/PlanarDice")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/PlanarDice"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2734(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2735(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(1));f.Pc=6;continue;}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",14);}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",25);}
case 25:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",30);}
case 30:{f.StackOp("pop");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[5]);f.Pc=33;continue;}
case 33:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Ignore","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Ignore","Lforge/game/ability/AbilityKey;"));f.Pc=36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",41);}
case 41:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",46);}
case 46:{f.StackOp("pop");f.Pc=47;continue;}
case 47:{if(!rt.StaticReady(f,"forge/game/PlanarDice$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/PlanarDice$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"));f.Pc=50;continue;}
case 50:{f.Push(f.Locals[2]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",54);}
case 54:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","RollPlanarDice","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","RollPlanarDice","Lforge/game/replacement/ReplacementType;"));f.Pc=57;continue;}
case 57:{f.Push(f.Locals[5]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",62);}
case 62:{return rt.Call(f,"forge/game/replacement/ReplacementResult","ordinal","()I","invokevirtual",65);}
case 65:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=66;continue;}
case 66:{switch(f.Pop().Int){case 1:f.Pc=92;break;case 2:f.Pc=95;break;default:f.Pc=130;break;}continue;}
case 92:{f.Pc=130;continue;}
case 95:{f.Push(f.Locals[5]);f.Pc=97;continue;}
case 97:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Number","Lforge/game/ability/AbilityKey;"));f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",105);}
case 105:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",111);}
case 111:{f.Locals[3]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[5]);f.Pc=114;continue;}
case 114:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Ignore","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Ignore","Lforge/game/ability/AbilityKey;"));f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",122);}
case 122:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",128);}
case 128:{f.Locals[4]=f.Pop();f.Pc=130;continue;}
case 130:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",133);}
case 133:{f.Locals[6]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{f.Locals[7]=f.Pop();f.Pc=138;continue;}
case 138:{f.Push(f.Locals[7]);f.Pc=140;continue;}
case 140:{f.Push(f.Locals[3]);f.Pc=141;continue;}
case 141:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?213:144;continue;}
case 144:{if(!rt.StaticReady(f,"forge/game/PlanarDice","Blank","Lforge/game/PlanarDice;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/PlanarDice","Blank","Lforge/game/PlanarDice;"));f.Pc=147;continue;}
case 147:{f.Locals[8]=f.Pop();f.Pc=149;continue;}
case 149:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",152);}
case 152:{f.Push(JValue.I(6));f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",157);}
case 157:{f.Locals[9]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[0]);f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/game/player/Player","roll","()V","invokevirtual",163);}
case 163:{f.Push(f.Locals[1]);f.Pc=164;continue;}
case 164:{f.Pc=f.Pop().Reference==null?173:167;continue;}
case 167:{f.Push(f.Locals[1]);f.Pc=168;continue;}
case 168:{f.Locals[8]=f.Pop();f.Pc=170;continue;}
case 170:{f.Pc=197;continue;}
case 173:{f.Push(f.Locals[9]);f.Pc=175;continue;}
case 175:{f.Pc=f.Pop().Int!=0?186:178;continue;}
case 178:{if(!rt.StaticReady(f,"forge/game/PlanarDice","Planeswalk","Lforge/game/PlanarDice;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/PlanarDice","Planeswalk","Lforge/game/PlanarDice;"));f.Pc=181;continue;}
case 181:{f.Locals[8]=f.Pop();f.Pc=183;continue;}
case 183:{f.Pc=197;continue;}
case 186:{f.Push(f.Locals[9]);f.Pc=188;continue;}
case 188:{f.Push(JValue.I(1));f.Pc=189;continue;}
case 189:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?197:192;continue;}
case 192:{if(!rt.StaticReady(f,"forge/game/PlanarDice","Chaos","Lforge/game/PlanarDice;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/PlanarDice","Chaos","Lforge/game/PlanarDice;"));f.Pc=195;continue;}
case 195:{f.Locals[8]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(f.Locals[6]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[8]);f.Pc=201;continue;}
case 201:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",206);}
case 206:{f.StackOp("pop");f.Pc=207;continue;}
case 207:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=210;continue;}
case 210:{f.Pc=138;continue;}
case 213:{f.Push(JValue.I(0));f.Pc=214;continue;}
case 214:{f.Locals[7]=f.Pop();f.Pc=216;continue;}
case 216:{f.Push(f.Locals[7]);f.Pc=218;continue;}
case 218:{f.Push(f.Locals[4]);f.Pc=220;continue;}
case 220:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?246:223;continue;}
case 223:{f.Push(f.Locals[6]);f.Pc=225;continue;}
case 225:{f.Push(f.Locals[0]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",229);}
case 229:{f.Push(f.Locals[6]);f.Pc=231;continue;}
case 231:{return rt.Call(f,"forge/game/player/PlayerController","choosePDRollToIgnore","(Ljava/util/List;)Lforge/game/PlanarDice;","invokevirtual",234);}
case 234:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",239);}
case 239:{f.StackOp("pop");f.Pc=240;continue;}
case 240:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=243;continue;}
case 243:{f.Pc=216;continue;}
case 246:{f.Push(f.Locals[6]);f.Pc=248;continue;}
case 248:{f.Push(JValue.I(0));f.Pc=249;continue;}
case 249:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",254);}
case 254:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/PlanarDice"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=257;continue;}
case 257:{f.Locals[7]=f.Pop();f.Pc=259;continue;}
case 259:{f.Push(f.Locals[0]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",263);}
case 263:{f.Locals[8]=f.Pop();f.Pc=265;continue;}
case 265:{f.Push(f.Locals[8]);f.Pc=267;continue;}
case 267:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Result","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Result","Lforge/game/ability/AbilityKey;"));f.Pc=270;continue;}
case 270:{f.Push(f.Locals[7]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",277);}
case 277:{f.StackOp("pop");f.Pc=278;continue;}
case 278:{if(!rt.StaticReady(f,"forge/game/PlanarDice$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/PlanarDice$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"));f.Pc=281;continue;}
case 281:{f.Push(f.Locals[2]);f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",285);}
case 285:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","PlanarDiceResult","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","PlanarDiceResult","Lforge/game/replacement/ReplacementType;"));f.Pc=288;continue;}
case 288:{f.Push(f.Locals[8]);f.Pc=290;continue;}
case 290:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",293);}
case 293:{return rt.Call(f,"forge/game/replacement/ReplacementResult","ordinal","()I","invokevirtual",296);}
case 296:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=297;continue;}
case 297:{switch(f.Pop().Int){case 1:f.Pc=324;break;case 2:f.Pc=327;break;default:f.Pc=342;break;}continue;}
case 324:{f.Pc=342;continue;}
case 327:{f.Push(f.Locals[8]);f.Pc=329;continue;}
case 329:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Result","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Result","Lforge/game/ability/AbilityKey;"));f.Pc=332;continue;}
case 332:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",337);}
case 337:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/PlanarDice"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=340;continue;}
case 340:{f.Locals[7]=f.Pop();f.Pc=342;continue;}
case 342:{f.Push(f.Locals[0]);f.Pc=343;continue;}
case 343:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",346);}
case 346:{f.Locals[9]=f.Pop();f.Pc=348;continue;}
case 348:{f.Push(f.Locals[9]);f.Pc=350;continue;}
case 350:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Result","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Result","Lforge/game/ability/AbilityKey;"));f.Pc=353;continue;}
case 353:{f.Push(f.Locals[7]);f.Pc=355;continue;}
case 355:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",360);}
case 360:{f.StackOp("pop");f.Pc=361;continue;}
case 361:{f.Push(f.Locals[2]);f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",365);}
case 365:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","PlanarDice","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","PlanarDice","Lforge/game/trigger/TriggerType;"));f.Pc=368;continue;}
case 368:{f.Push(f.Locals[9]);f.Pc=370;continue;}
case 370:{f.Push(JValue.I(0));f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",374);}
case 374:{f.Push(JValue.I(0));f.Pc=375;continue;}
case 375:{f.Locals[10]=f.Pop();f.Pc=377;continue;}
case 377:{f.Push(f.Locals[10]);f.Pc=379;continue;}
case 379:{f.Push(f.Locals[3]);f.Pc=380;continue;}
case 380:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?442:383;continue;}
case 383:{f.Push(f.Locals[0]);f.Pc=384;continue;}
case 384:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",387);}
case 387:{f.Locals[9]=f.Pop();f.Pc=389;continue;}
case 389:{f.Push(f.Locals[9]);f.Pc=391;continue;}
case 391:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Sides","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Sides","Lforge/game/ability/AbilityKey;"));f.Pc=394;continue;}
case 394:{f.Push(JValue.I(6));f.Pc=396;continue;}
case 396:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",399);}
case 399:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",404);}
case 404:{f.StackOp("pop");f.Pc=405;continue;}
case 405:{f.Push(f.Locals[9]);f.Pc=407;continue;}
case 407:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Result","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Result","Lforge/game/ability/AbilityKey;"));f.Pc=410;continue;}
case 410:{f.Push(JValue.I(0));f.Pc=411;continue;}
case 411:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",414);}
case 414:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",419);}
case 419:{f.StackOp("pop");f.Pc=420;continue;}
case 420:{f.Push(f.Locals[0]);f.Pc=421;continue;}
case 421:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",424);}
case 424:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",427);}
case 427:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","RolledDie","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","RolledDie","Lforge/game/trigger/TriggerType;"));f.Pc=430;continue;}
case 430:{f.Push(f.Locals[9]);f.Pc=432;continue;}
case 432:{f.Push(JValue.I(0));f.Pc=433;continue;}
case 433:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",436);}
case 436:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=439;continue;}
case 439:{f.Pc=377;continue;}
case 442:{f.Push(f.Locals[0]);f.Pc=443;continue;}
case 443:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",446);}
case 446:{f.Locals[9]=f.Pop();f.Pc=448;continue;}
case 448:{f.Push(f.Locals[9]);f.Pc=450;continue;}
case 450:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Sides","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Sides","Lforge/game/ability/AbilityKey;"));f.Pc=453;continue;}
case 453:{f.Push(JValue.I(6));f.Pc=455;continue;}
case 455:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",458);}
case 458:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",463);}
case 463:{f.StackOp("pop");f.Pc=464;continue;}
case 464:{f.Push(f.Locals[9]);f.Pc=466;continue;}
case 466:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Result","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Result","Lforge/game/ability/AbilityKey;"));f.Pc=469;continue;}
case 469:{f.Push(JValue.I(1));f.Pc=470;continue;}
case 470:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Integer;",f.Pop().Int)));f.Pc=473;continue;}
case 473:{f.StackOp("dup");f.Pc=474;continue;}
case 474:{f.Push(JValue.I(0));f.Pc=475;continue;}
case 475:{f.Push(JValue.I(0));f.Pc=476;continue;}
case 476:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",479);}
case 479:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=480;continue;}
case 480:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",483);}
case 483:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",488);}
case 488:{f.StackOp("pop");f.Pc=489;continue;}
case 489:{f.Push(f.Locals[0]);f.Pc=490;continue;}
case 490:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",493);}
case 493:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",496);}
case 496:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","RolledDieOnce","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","RolledDieOnce","Lforge/game/trigger/TriggerType;"));f.Pc=499;continue;}
case 499:{f.Push(f.Locals[9]);f.Pc=501;continue;}
case 501:{f.Push(JValue.I(0));f.Pc=502;continue;}
case 502:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",505);}
case 505:{f.Push(f.Locals[7]);f.Pc=507;continue;}
case 507:{if(!rt.StaticReady(f,"forge/game/PlanarDice","Chaos","Lforge/game/PlanarDice;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/PlanarDice","Chaos","Lforge/game/PlanarDice;"));f.Pc=510;continue;}
case 510:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?535:513;continue;}
case 513:{f.Push(f.Locals[0]);f.Pc=514;continue;}
case 514:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPlayer","(Lforge/game/player/Player;)Ljava/util/Map;","invokestatic",517);}
case 517:{f.Locals[9]=f.Pop();f.Pc=519;continue;}
case 519:{f.Push(f.Locals[0]);f.Pc=520;continue;}
case 520:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",523);}
case 523:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",526);}
case 526:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","ChaosEnsues","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","ChaosEnsues","Lforge/game/trigger/TriggerType;"));f.Pc=529;continue;}
case 529:{f.Push(f.Locals[9]);f.Pc=531;continue;}
case 531:{f.Push(JValue.I(0));f.Pc=532;continue;}
case 532:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",535);}
case 535:{f.Push(f.Locals[7]);f.Pc=537;continue;}
case 537:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2736(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/PlanarDice","values","()[Lforge/game/PlanarDice;","invokestatic",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=11;continue;}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{f.Locals[4]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[4]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?48:21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=25;continue;}
case 25:{f.Locals[5]=f.Pop();f.Pc=27;continue;}
case 27:{f.Push(f.Locals[5]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/PlanarDice","name","()Ljava/lang/String;","invokevirtual",32);}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/lang/String","compareToIgnoreCase","(Ljava/lang/String;)I","invokevirtual",36);}
case 36:{f.Pc=f.Pop().Int!=0?42:39;continue;}
case 39:{f.Push(f.Locals[5]);f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
case 42:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=45;continue;}
case 45:{f.Pc=15;continue;}
case 48:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=51;continue;}
case 51:{f.StackOp("dup");f.Pc=52;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{return rt.DynamicCall(f,"forge/game/PlanarDice:2736:53:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",58);}
case 58:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",61);}
case 61:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2737(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(3));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Lforge/game/PlanarDice;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/PlanarDice","Planeswalk","Lforge/game/PlanarDice;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/PlanarDice","Planeswalk","Lforge/game/PlanarDice;"));f.Pc=9;continue;}
case 9:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/PlanarDice","Chaos","Lforge/game/PlanarDice;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/PlanarDice","Chaos","Lforge/game/PlanarDice;"));f.Pc=15;continue;}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(2));f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/game/PlanarDice","Blank","Lforge/game/PlanarDice;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/PlanarDice","Blank","Lforge/game/PlanarDice;"));f.Pc=21;continue;}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2738(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/PlanarDice"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/PlanarDice")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Planeswalk")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/PlanarDice","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/game/PlanarDice","Planeswalk","Lforge/game/PlanarDice;"))return JStep.Continue;rt.PutStatic("forge/game/PlanarDice","Planeswalk","Lforge/game/PlanarDice;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/game/PlanarDice"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/PlanarDice")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("Chaos")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/PlanarDice","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/game/PlanarDice","Chaos","Lforge/game/PlanarDice;"))return JStep.Continue;rt.PutStatic("forge/game/PlanarDice","Chaos","Lforge/game/PlanarDice;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/game/PlanarDice"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/PlanarDice")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("Blank")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/PlanarDice","<init>","(Ljava/lang/String;I)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/game/PlanarDice","Blank","Lforge/game/PlanarDice;"))return JStep.Continue;rt.PutStatic("forge/game/PlanarDice","Blank","Lforge/game/PlanarDice;",f.Pop());f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/PlanarDice","$values","()[Lforge/game/PlanarDice;","invokestatic",42);}
case 42:{if(!rt.StaticReady(f,"forge/game/PlanarDice","$VALUES","[Lforge/game/PlanarDice;"))return JStep.Continue;rt.PutStatic("forge/game/PlanarDice","$VALUES","[Lforge/game/PlanarDice;",f.Pop());f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/game/PlanarDice","values","()[Lforge/game/PlanarDice;","invokestatic",48);}
case 48:{return rt.Call(f,"com/google/common/collect/ImmutableList","copyOf","([Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList;","invokestatic",51);}
case 51:{if(!rt.StaticReady(f,"forge/game/PlanarDice","values","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;rt.PutStatic("forge/game/PlanarDice","values","Lcom/google/common/collect/ImmutableList;",f.Pop());f.Pc=54;continue;}
case 54:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
