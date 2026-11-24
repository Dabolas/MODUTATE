// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C323{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/LifeExchangeVariantEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3462,"forge/game/ability/effects/LifeExchangeVariantEffect","<init>","()V",1,1,1,new JHandler[]{},M3462));
c.Add(new JMethod(3463,"forge/game/ability/effects/LifeExchangeVariantEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,5,2,new JHandler[]{},M3463));
c.Add(new JMethod(3464,"forge/game/ability/effects/LifeExchangeVariantEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,16,7,new JHandler[]{},M3464));
}

internal static JStep M3462(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3463(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Mode")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",26);}
case 26:{f.Push(JValue.R(rt.String(" exchanges life totals with ")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",31);}
case 31:{f.StackOp("pop");f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",37);}
case 37:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",40);}
case 40:{f.StackOp("pop");f.Pc=41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("'s ")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",47);}
case 47:{f.StackOp("pop");f.Pc=48;continue;}
case 48:{f.Push(f.Locals[2]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",54);}
case 54:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",57);}
case 57:{f.StackOp("pop");f.Pc=58;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",62);}
case 62:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3464(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Mode")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/ability/effects/LifeExchangeVariantEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",16);}
case 16:{f.Locals[4]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?29:28;continue;}
case 28:{return JStep.ReturnVoid;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Int==0?43:36;continue;}
case 36:{f.Push(f.Locals[2]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int!=0?44:43;continue;}
case 43:{return JStep.ReturnVoid;}
case 44:{f.Push(f.Locals[4]);f.Pc=46;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",52);}
case 52:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=55;continue;}
case 55:{f.Locals[5]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(JValue.R(null));f.Pc=58;continue;}
case 58:{f.Locals[6]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(JValue.R(null));f.Pc=61;continue;}
case 61:{f.Locals[7]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[5]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/player/Player","getLife","()I","invokevirtual",68);}
case 68:{f.Locals[8]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String("Power")));f.Pc=72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int==0?95:79;continue;}
case 79:{f.Push(f.Locals[2]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",83);}
case 83:{f.Locals[9]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[8]);f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",90);}
case 90:{f.Locals[6]=f.Pop();f.Pc=92;continue;}
case 92:{f.Pc=121;continue;}
case 95:{f.Push(JValue.R(rt.String("Toughness")));f.Pc=97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",101);}
case 101:{f.Pc=f.Pop().Int==0?120:104;continue;}
case 104:{f.Push(f.Locals[2]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/card/Card","getNetToughness","()I","invokevirtual",108);}
case 108:{f.Locals[9]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[8]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",115);}
case 115:{f.Locals[7]=f.Pop();f.Pc=117;continue;}
case 117:{f.Pc=121;continue;}
case 120:{return JStep.ReturnVoid;}
case 121:{f.Push(f.Locals[8]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[9]);f.Pc=125;continue;}
case 125:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?137:128;continue;}
case 128:{f.Push(f.Locals[5]);f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/player/Player","canLoseLife","()Z","invokevirtual",133);}
case 133:{f.Pc=f.Pop().Int!=0?137:136;continue;}
case 136:{return JStep.ReturnVoid;}
case 137:{f.Push(f.Locals[9]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[8]);f.Pc=141;continue;}
case 141:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?153:144;continue;}
case 144:{f.Push(f.Locals[5]);f.Pc=146;continue;}
case 146:{return rt.Call(f,"forge/game/player/Player","canGainLife","()Z","invokevirtual",149);}
case 149:{f.Pc=f.Pop().Int!=0?153:152;continue;}
case 152:{return JStep.ReturnVoid;}
case 153:{f.Push(f.Locals[5]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",158);}
case 158:{f.Locals[10]=f.Pop();f.Pc=160;continue;}
case 160:{f.Push(f.Locals[10]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",165);}
case 165:{f.Locals[11]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(JValue.I(0));f.Pc=168;continue;}
case 168:{f.Locals[13]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[8]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[9]);f.Pc=174;continue;}
case 174:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?195:177;continue;}
case 177:{f.Push(f.Locals[5]);f.Pc=179;continue;}
case 179:{f.Push(f.Locals[8]);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[9]);f.Pc=183;continue;}
case 183:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=184;continue;}
case 184:{f.Push(JValue.I(0));f.Pc=185;continue;}
case 185:{f.Push(JValue.I(0));f.Pc=186;continue;}
case 186:{f.Push(f.Locals[1]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"forge/game/player/Player","loseLife","(IZZLforge/game/spellability/SpellAbility;)I","invokevirtual",190);}
case 190:{f.Locals[13]=f.Pop();f.Pc=192;continue;}
case 192:{f.Pc=215;continue;}
case 195:{f.Push(f.Locals[9]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[8]);f.Pc=199;continue;}
case 199:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?215:202;continue;}
case 202:{f.Push(f.Locals[5]);f.Pc=204;continue;}
case 204:{f.Push(f.Locals[9]);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[8]);f.Pc=208;continue;}
case 208:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=209;continue;}
case 209:{f.Push(f.Locals[2]);f.Pc=210;continue;}
case 210:{f.Push(f.Locals[1]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/player/Player","gainLife","(ILforge/game/card/Card;Lforge/game/spellability/SpellAbility;)Z","invokevirtual",214);}
case 214:{f.StackOp("pop");f.Pc=215;continue;}
case 215:{f.Push(f.Locals[2]);f.Pc=216;continue;}
case 216:{f.Push(f.Locals[6]);f.Pc=218;continue;}
case 218:{f.Push(f.Locals[7]);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[11]);f.Pc=222;continue;}
case 222:{f.Push(JValue.L(0));f.Pc=223;continue;}
case 223:{return rt.Call(f,"forge/game/card/Card","addNewPT","(Ljava/lang/Integer;Ljava/lang/Integer;JJ)V","invokevirtual",226);}
case 226:{f.Push(f.Locals[10]);f.Pc=228;continue;}
case 228:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=231;continue;}
case 231:{f.StackOp("dup");f.Pc=232;continue;}
case 232:{f.Push(f.Locals[2]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",236);}
case 236:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",239);}
case 239:{f.Push(f.Locals[13]);f.Pc=241;continue;}
case 241:{f.Pc=f.Pop().Int<=0?285:244;continue;}
case 244:{return rt.Call(f,"com/google/common/collect/Maps","newHashMap","()Ljava/util/HashMap;","invokestatic",247);}
case 247:{f.Locals[14]=f.Pop();f.Pc=249;continue;}
case 249:{f.Push(f.Locals[14]);f.Pc=251;continue;}
case 251:{f.Push(f.Locals[5]);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[13]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",258);}
case 258:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",263);}
case 263:{f.StackOp("pop");f.Pc=264;continue;}
case 264:{f.Push(f.Locals[14]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromPIMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",269);}
case 269:{f.Locals[15]=f.Pop();f.Pc=271;continue;}
case 271:{f.Push(f.Locals[10]);f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/game/Game","getTriggerHandler","()Lforge/game/trigger/TriggerHandler;","invokevirtual",276);}
case 276:{if(!rt.StaticReady(f,"forge/game/trigger/TriggerType","LifeLostAll","Lforge/game/trigger/TriggerType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/trigger/TriggerType","LifeLostAll","Lforge/game/trigger/TriggerType;"));f.Pc=279;continue;}
case 279:{f.Push(f.Locals[15]);f.Pc=281;continue;}
case 281:{f.Push(JValue.I(0));f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/trigger/TriggerHandler","runTrigger","(Lforge/game/trigger/TriggerType;Ljava/util/Map;Z)V","invokevirtual",285);}
case 285:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
