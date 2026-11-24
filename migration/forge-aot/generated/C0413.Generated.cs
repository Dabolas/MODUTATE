// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C413{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/TextBoxExchangeEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3771,"forge/game/ability/effects/TextBoxExchangeEffect","<init>","()V",1,1,1,new JHandler[]{},M3771));
c.Add(new JMethod(3772,"forge/game/ability/effects/TextBoxExchangeEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,5,2,new JHandler[]{},M3772));
c.Add(new JMethod(3773,"forge/game/ability/effects/TextBoxExchangeEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,12,8,new JHandler[]{},M3773));
c.Add(new JMethod(3774,"forge/game/ability/effects/TextBoxExchangeEffect","swapTextBox","(Lforge/game/card/Card;Lforge/game/ability/effects/TextBoxExchangeEffect$TextBoxData;J)V",10,11,9,new JHandler[]{},M3774));
c.Add(new JMethod(3775,"forge/game/ability/effects/TextBoxExchangeEffect","captureTextBoxData","(Lforge/game/card/Card;)Lforge/game/ability/effects/TextBoxExchangeEffect$TextBoxData;",10,5,2,new JHandler[]{},M3775));
}

internal static JStep M3771(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3772(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/TextBoxExchangeEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",11);}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?35:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",19);}
case 19:{f.Locals[3]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{f.Locals[4]=f.Pop();f.Pc=32;continue;}
case 32:{f.Pc=58;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(JValue.I(0));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[3]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Push(JValue.I(1));f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",53);}
case 53:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=56;continue;}
case 56:{f.Locals[4]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[3]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",62);}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",67);}
case 67:{return rt.DynamicCall(f,"forge/game/ability/effects/TextBoxExchangeEffect:3772:67:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",72);}
case 72:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3773(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("Duration")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",6);}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/ability/effects/TextBoxExchangeEffect","checkValidDuration","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Z","invokestatic",10);}
case 10:{f.Pc=f.Pop().Int!=0?14:13;continue;}
case 13:{return JStep.ReturnVoid;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/ability/effects/TextBoxExchangeEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",25);}
case 25:{f.Push(JValue.I(2));f.Pc=26;continue;}
case 26:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?30:29;continue;}
case 29:{return JStep.ReturnVoid;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Push(JValue.I(0));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[3]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{f.Locals[4]=f.Pop();f.Pc=53;continue;}
case 53:{f.Push(f.Locals[3]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/ability/effects/TextBoxExchangeEffect","captureTextBoxData","(Lforge/game/card/Card;)Lforge/game/ability/effects/TextBoxExchangeEffect$TextBoxData;","invokestatic",57);}
case 57:{f.Locals[5]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/ability/effects/TextBoxExchangeEffect","captureTextBoxData","(Lforge/game/card/Card;)Lforge/game/ability/effects/TextBoxExchangeEffect$TextBoxData;","invokestatic",64);}
case 64:{f.Locals[6]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",70);}
case 70:{f.Locals[7]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[7]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",77);}
case 77:{f.Locals[8]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[8]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",84);}
case 84:{f.Locals[9]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[3]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[6]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[9]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/game/ability/effects/TextBoxExchangeEffect","swapTextBox","(Lforge/game/card/Card;Lforge/game/ability/effects/TextBoxExchangeEffect$TextBoxData;J)V","invokestatic",94);}
case 94:{f.Push(f.Locals[4]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[5]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[9]);f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/ability/effects/TextBoxExchangeEffect","swapTextBox","(Lforge/game/card/Card;Lforge/game/ability/effects/TextBoxExchangeEffect$TextBoxData;J)V","invokestatic",103);}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("Duration")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int==0?135:112;continue;}
case 112:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/TextBoxExchangeEffect$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/TextBoxExchangeEffect$1")));f.Pc=115;continue;}
case 115:{f.StackOp("dup");f.Pc=116;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[8]);f.Pc=119;continue;}
case 119:{f.Push(f.Locals[3]);f.Pc=120;continue;}
case 120:{f.Push(f.Locals[4]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[9]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/ability/effects/TextBoxExchangeEffect$1","<init>","(Lforge/game/ability/effects/TextBoxExchangeEffect;Lforge/game/Game;Lforge/game/card/Card;Lforge/game/card/Card;J)V","invokespecial",127);}
case 127:{f.Locals[11]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[11]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/ability/effects/TextBoxExchangeEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;)V","invokestatic",135);}
case 135:{f.Push(f.Locals[8]);f.Pc=137;continue;}
case 137:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=140;continue;}
case 140:{f.StackOp("dup");f.Pc=141;continue;}
case 141:{f.Push(f.Locals[3]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",145);}
case 145:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",148);}
case 148:{f.Push(f.Locals[8]);f.Pc=150;continue;}
case 150:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=153;continue;}
case 153:{f.StackOp("dup");f.Pc=154;continue;}
case 154:{f.Push(f.Locals[4]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",159);}
case 159:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",162);}
case 162:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3774(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[4]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData","spellabilities","Ljava/util/List;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[5]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?76:26;continue;}
case 26:{f.Push(f.Locals[5]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",33);}
case 33:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=36;continue;}
case 36:{f.Locals[6]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[6]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;ZZ)Lforge/game/spellability/SpellAbility;","invokevirtual",46);}
case 46:{f.Locals[7]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[7]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[7]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/spellability/SpellAbility","getChangedTextColors","()Ljava/util/Map;","invokevirtual",55);}
case 55:{f.Push(f.Locals[7]);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/game/spellability/SpellAbility","getChangedTextTypes","()Ljava/util/Map;","invokevirtual",60);}
case 60:{return rt.Call(f,"forge/game/spellability/SpellAbility","changeTextIntrinsic","(Ljava/util/Map;Ljava/util/Map;)V","invokevirtual",63);}
case 63:{f.Push(f.Locals[4]);f.Pc=65;continue;}
case 65:{f.Push(f.Locals[7]);f.Pc=67;continue;}
case 67:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",72);}
case 72:{f.StackOp("pop");f.Pc=73;continue;}
case 73:{f.Pc=16;continue;}
case 76:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",79);}
case 79:{f.Locals[5]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData","triggers","Ljava/util/List;"));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",90);}
case 90:{f.Locals[6]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[6]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",99);}
case 99:{f.Pc=f.Pop().Int==0?152:102;continue;}
case 102:{f.Push(f.Locals[6]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",109);}
case 109:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=112;continue;}
case 112:{f.Locals[7]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[7]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[0]);f.Pc=117;continue;}
case 117:{f.Push(JValue.I(0));f.Pc=118;continue;}
case 118:{f.Push(JValue.I(1));f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/trigger/Trigger","copy","(Lforge/game/card/Card;ZZ)Lforge/game/trigger/Trigger;","invokevirtual",122);}
case 122:{f.Locals[8]=f.Pop();f.Pc=124;continue;}
case 124:{f.Push(f.Locals[8]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[8]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/trigger/Trigger","getChangedTextColors","()Ljava/util/Map;","invokevirtual",131);}
case 131:{f.Push(f.Locals[8]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"forge/game/trigger/Trigger","getChangedTextTypes","()Ljava/util/Map;","invokevirtual",136);}
case 136:{return rt.Call(f,"forge/game/trigger/Trigger","changeTextIntrinsic","(Ljava/util/Map;Ljava/util/Map;)V","invokevirtual",139);}
case 139:{f.Push(f.Locals[5]);f.Pc=141;continue;}
case 141:{f.Push(f.Locals[8]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",148);}
case 148:{f.StackOp("pop");f.Pc=149;continue;}
case 149:{f.Pc=92;continue;}
case 152:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",155);}
case 155:{f.Locals[6]=f.Pop();f.Pc=157;continue;}
case 157:{f.Push(f.Locals[1]);f.Pc=158;continue;}
case 158:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData","replacements","Ljava/util/List;"));f.Pc=161;continue;}
case 161:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",166);}
case 166:{f.Locals[7]=f.Pop();f.Pc=168;continue;}
case 168:{f.Push(f.Locals[7]);f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",175);}
case 175:{f.Pc=f.Pop().Int==0?228:178;continue;}
case 178:{f.Push(f.Locals[7]);f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",185);}
case 185:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=188;continue;}
case 188:{f.Locals[8]=f.Pop();f.Pc=190;continue;}
case 190:{f.Push(f.Locals[8]);f.Pc=192;continue;}
case 192:{f.Push(f.Locals[0]);f.Pc=193;continue;}
case 193:{f.Push(JValue.I(0));f.Pc=194;continue;}
case 194:{f.Push(JValue.I(1));f.Pc=195;continue;}
case 195:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","copy","(Lforge/game/card/Card;ZZ)Lforge/game/replacement/ReplacementEffect;","invokevirtual",198);}
case 198:{f.Locals[9]=f.Pop();f.Pc=200;continue;}
case 200:{f.Push(f.Locals[9]);f.Pc=202;continue;}
case 202:{f.Push(f.Locals[9]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getChangedTextColors","()Ljava/util/Map;","invokevirtual",207);}
case 207:{f.Push(f.Locals[9]);f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getChangedTextTypes","()Ljava/util/Map;","invokevirtual",212);}
case 212:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","changeTextIntrinsic","(Ljava/util/Map;Ljava/util/Map;)V","invokevirtual",215);}
case 215:{f.Push(f.Locals[6]);f.Pc=217;continue;}
case 217:{f.Push(f.Locals[9]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",224);}
case 224:{f.StackOp("pop");f.Pc=225;continue;}
case 225:{f.Pc=168;continue;}
case 228:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",231);}
case 231:{f.Locals[7]=f.Pop();f.Pc=233;continue;}
case 233:{f.Push(f.Locals[1]);f.Pc=234;continue;}
case 234:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData","statics","Ljava/util/List;"));f.Pc=237;continue;}
case 237:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",242);}
case 242:{f.Locals[8]=f.Pop();f.Pc=244;continue;}
case 244:{f.Push(f.Locals[8]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",251);}
case 251:{f.Pc=f.Pop().Int==0?304:254;continue;}
case 254:{f.Push(f.Locals[8]);f.Pc=256;continue;}
case 256:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",261);}
case 261:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=264;continue;}
case 264:{f.Locals[9]=f.Pop();f.Pc=266;continue;}
case 266:{f.Push(f.Locals[9]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[0]);f.Pc=269;continue;}
case 269:{f.Push(JValue.I(0));f.Pc=270;continue;}
case 270:{f.Push(JValue.I(1));f.Pc=271;continue;}
case 271:{return rt.Call(f,"forge/game/staticability/StaticAbility","copy","(Lforge/game/card/Card;ZZ)Lforge/game/staticability/StaticAbility;","invokevirtual",274);}
case 274:{f.Locals[10]=f.Pop();f.Pc=276;continue;}
case 276:{f.Push(f.Locals[10]);f.Pc=278;continue;}
case 278:{f.Push(f.Locals[10]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/game/staticability/StaticAbility","getChangedTextColors","()Ljava/util/Map;","invokevirtual",283);}
case 283:{f.Push(f.Locals[10]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"forge/game/staticability/StaticAbility","getChangedTextTypes","()Ljava/util/Map;","invokevirtual",288);}
case 288:{return rt.Call(f,"forge/game/staticability/StaticAbility","changeTextIntrinsic","(Ljava/util/Map;Ljava/util/Map;)V","invokevirtual",291);}
case 291:{f.Push(f.Locals[7]);f.Pc=293;continue;}
case 293:{f.Push(f.Locals[10]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",300);}
case 300:{f.StackOp("pop");f.Pc=301;continue;}
case 301:{f.Pc=244;continue;}
case 304:{f.Push(f.Locals[0]);f.Pc=305;continue;}
case 305:{f.Push(f.Locals[4]);f.Pc=307;continue;}
case 307:{f.Push(f.Locals[5]);f.Pc=309;continue;}
case 309:{f.Push(f.Locals[6]);f.Pc=311;continue;}
case 311:{f.Push(f.Locals[7]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[2]);f.Pc=314;continue;}
case 314:{f.Push(JValue.L(0));f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/card/Card","addChangedCardTraitsByText","(Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;Ljava/util/Collection;JJ)V","invokevirtual",318);}
case 318:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",321);}
case 321:{f.Locals[8]=f.Pop();f.Pc=323;continue;}
case 323:{f.Push(f.Locals[1]);f.Pc=324;continue;}
case 324:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData","keywords","Ljava/util/List;"));f.Pc=327;continue;}
case 327:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",332);}
case 332:{f.Locals[9]=f.Pop();f.Pc=334;continue;}
case 334:{f.Push(f.Locals[9]);f.Pc=336;continue;}
case 336:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",341);}
case 341:{f.Pc=f.Pop().Int==0?376:344;continue;}
case 344:{f.Push(f.Locals[9]);f.Pc=346;continue;}
case 346:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",351);}
case 351:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=354;continue;}
case 354:{f.Locals[10]=f.Pop();f.Pc=356;continue;}
case 356:{f.Push(f.Locals[8]);f.Pc=358;continue;}
case 358:{f.Push(f.Locals[10]);f.Pc=360;continue;}
case 360:{f.Push(f.Locals[0]);f.Pc=361;continue;}
case 361:{f.Push(JValue.I(0));f.Pc=362;continue;}
case 362:{return rt.Call(f,"forge/game/keyword/KeywordInterface","copy","(Lforge/game/card/Card;Z)Lforge/game/keyword/KeywordInterface;","invokeinterface",367);}
case 367:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",372);}
case 372:{f.StackOp("pop");f.Pc=373;continue;}
case 373:{f.Pc=334;continue;}
case 376:{f.Push(f.Locals[0]);f.Pc=377;continue;}
case 377:{f.Push(f.Locals[8]);f.Pc=379;continue;}
case 379:{f.Push(f.Locals[2]);f.Pc=380;continue;}
case 380:{f.Push(JValue.L(0));f.Pc=381;continue;}
case 381:{f.Push(JValue.I(0));f.Pc=382;continue;}
case 382:{return rt.Call(f,"forge/game/card/Card","addChangedCardKeywordsByText","(Ljava/util/List;JJZ)V","invokevirtual",385);}
case 385:{f.Push(f.Locals[0]);f.Pc=386;continue;}
case 386:{return rt.Call(f,"forge/game/card/Card","updateChangedText","()V","invokevirtual",389);}
case 389:{f.Push(f.Locals[0]);f.Pc=390;continue;}
case 390:{return rt.Call(f,"forge/game/card/Card","updateStateForView","()V","invokevirtual",393);}
case 393:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3775(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",17);}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData","spellabilities","Ljava/util/List;",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[2]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/CardState","getSpellAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",24);}
case 24:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",29);}
case 29:{f.Locals[3]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",36);}
case 36:{f.Pc=f.Pop().Int==0?81:39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",45);}
case 45:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=48;continue;}
case 48:{f.Locals[4]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",55);}
case 55:{f.Pc=f.Pop().Int==0?78:58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Reference!=null?78:66;continue;}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData","spellabilities","Ljava/util/List;"));f.Pc=70;continue;}
case 70:{f.Push(f.Locals[4]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",77);}
case 77:{f.StackOp("pop");f.Pc=78;continue;}
case 78:{f.Pc=30;continue;}
case 81:{f.Push(f.Locals[1]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",85);}
case 85:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData","triggers","Ljava/util/List;",value);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[2]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/card/CardState","getTriggers","()Lforge/util/collect/FCollectionView;","invokevirtual",92);}
case 92:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",97);}
case 97:{f.Locals[3]=f.Pop();f.Pc=98;continue;}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",104);}
case 104:{f.Pc=f.Pop().Int==0?149:107;continue;}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",113);}
case 113:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/trigger/Trigger"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=116;continue;}
case 116:{f.Locals[4]=f.Pop();f.Pc=118;continue;}
case 118:{f.Push(f.Locals[4]);f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/trigger/Trigger","isIntrinsic","()Z","invokevirtual",123);}
case 123:{f.Pc=f.Pop().Int==0?146:126;continue;}
case 126:{f.Push(f.Locals[4]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/trigger/Trigger","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Reference!=null?146:134;continue;}
case 134:{f.Push(f.Locals[1]);f.Pc=135;continue;}
case 135:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData","triggers","Ljava/util/List;"));f.Pc=138;continue;}
case 138:{f.Push(f.Locals[4]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",145);}
case 145:{f.StackOp("pop");f.Pc=146;continue;}
case 146:{f.Pc=98;continue;}
case 149:{f.Push(f.Locals[1]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",153);}
case 153:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData","replacements","Ljava/util/List;",value);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[2]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/card/CardState","getReplacementEffects","()Lforge/util/collect/FCollectionView;","invokevirtual",160);}
case 160:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",165);}
case 165:{f.Locals[3]=f.Pop();f.Pc=166;continue;}
case 166:{f.Push(f.Locals[3]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",172);}
case 172:{f.Pc=f.Pop().Int==0?217:175;continue;}
case 175:{f.Push(f.Locals[3]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",181);}
case 181:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/replacement/ReplacementEffect"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=184;continue;}
case 184:{f.Locals[4]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(f.Locals[4]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","isIntrinsic","()Z","invokevirtual",191);}
case 191:{f.Pc=f.Pop().Int==0?214:194;continue;}
case 194:{f.Push(f.Locals[4]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",199);}
case 199:{f.Pc=f.Pop().Reference!=null?214:202;continue;}
case 202:{f.Push(f.Locals[1]);f.Pc=203;continue;}
case 203:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData","replacements","Ljava/util/List;"));f.Pc=206;continue;}
case 206:{f.Push(f.Locals[4]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",213);}
case 213:{f.StackOp("pop");f.Pc=214;continue;}
case 214:{f.Pc=166;continue;}
case 217:{f.Push(f.Locals[1]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",221);}
case 221:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData","statics","Ljava/util/List;",value);f.Pc=224;continue;}
case 224:{f.Push(f.Locals[2]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"forge/game/card/CardState","getStaticAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",228);}
case 228:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",233);}
case 233:{f.Locals[3]=f.Pop();f.Pc=234;continue;}
case 234:{f.Push(f.Locals[3]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",240);}
case 240:{f.Pc=f.Pop().Int==0?285:243;continue;}
case 243:{f.Push(f.Locals[3]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",249);}
case 249:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/staticability/StaticAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=252;continue;}
case 252:{f.Locals[4]=f.Pop();f.Pc=254;continue;}
case 254:{f.Push(f.Locals[4]);f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/game/staticability/StaticAbility","isIntrinsic","()Z","invokevirtual",259);}
case 259:{f.Pc=f.Pop().Int==0?282:262;continue;}
case 262:{f.Push(f.Locals[4]);f.Pc=264;continue;}
case 264:{return rt.Call(f,"forge/game/staticability/StaticAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",267);}
case 267:{f.Pc=f.Pop().Reference!=null?282:270;continue;}
case 270:{f.Push(f.Locals[1]);f.Pc=271;continue;}
case 271:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData","statics","Ljava/util/List;"));f.Pc=274;continue;}
case 274:{f.Push(f.Locals[4]);f.Pc=276;continue;}
case 276:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",281);}
case 281:{f.StackOp("pop");f.Pc=282;continue;}
case 282:{f.Pc=234;continue;}
case 285:{f.Push(f.Locals[1]);f.Pc=286;continue;}
case 286:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",289);}
case 289:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData","keywords","Ljava/util/List;",value);f.Pc=292;continue;}
case 292:{f.Push(f.Locals[0]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/card/Card","getKeywords","()Ljava/util/List;","invokevirtual",296);}
case 296:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",301);}
case 301:{f.Locals[3]=f.Pop();f.Pc=302;continue;}
case 302:{f.Push(f.Locals[3]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",308);}
case 308:{f.Pc=f.Pop().Int==0?347:311;continue;}
case 311:{f.Push(f.Locals[3]);f.Pc=312;continue;}
case 312:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",317);}
case 317:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=320;continue;}
case 320:{f.Locals[4]=f.Pop();f.Pc=322;continue;}
case 322:{f.Push(f.Locals[4]);f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/keyword/KeywordInterface","isIntrinsic","()Z","invokeinterface",329);}
case 329:{f.Pc=f.Pop().Int==0?344:332;continue;}
case 332:{f.Push(f.Locals[1]);f.Pc=333;continue;}
case 333:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/effects/TextBoxExchangeEffect$TextBoxData","keywords","Ljava/util/List;"));f.Pc=336;continue;}
case 336:{f.Push(f.Locals[4]);f.Pc=338;continue;}
case 338:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",343);}
case 343:{f.StackOp("pop");f.Pc=344;continue;}
case 344:{f.Pc=302;continue;}
case 347:{f.Push(f.Locals[1]);f.Pc=348;continue;}
case 348:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
