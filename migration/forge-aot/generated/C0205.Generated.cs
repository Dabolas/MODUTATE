// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C205{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/AssembleContraptionEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3035,"forge/game/ability/effects/AssembleContraptionEffect","<init>","()V",1,1,1,new JHandler[]{},M3035));
c.Add(new JMethod(3036,"forge/game/ability/effects/AssembleContraptionEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,11,4,new JHandler[]{},M3036));
c.Add(new JMethod(3037,"forge/game/ability/effects/AssembleContraptionEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,20,4,new JHandler[]{},M3037));
}

internal static JStep M3035(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3036(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",17);}
case 17:{f.Pc=f.Pop().Int==0?25:20;continue;}
case 20:{f.Push(JValue.R(rt.String("Self")));f.Pc=22;continue;}
case 22:{f.Pc=27;continue;}
case 25:{f.Push(JValue.R(rt.String("You")));f.Pc=27;continue;}
case 27:{f.Locals[4]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("DefinedAssembler")));f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Locals[5]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[5]);f.Pc=42;continue;}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedEntities","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",46);}
case 46:{f.Locals[6]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[6]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int==0?61:58;continue;}
case 58:{f.Push(JValue.R(rt.String("")));f.Pc=60;continue;}
case 60:{return JStep.Return(f.Pop());}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[6]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",67);}
case 67:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",70);}
case 70:{f.StackOp("pop");f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("DefinedContraption")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",77);}
case 77:{f.Locals[7]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[7]);f.Pc=81;continue;}
case 81:{f.Pc=f.Pop().Reference!=null?88:84;continue;}
case 84:{f.Push(JValue.R(null));f.Pc=85;continue;}
case 85:{f.Pc=95;continue;}
case 88:{f.Push(f.Locals[3]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[7]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",95);}
case 95:{f.Locals[8]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[8]);f.Pc=99;continue;}
case 99:{f.Pc=f.Pop().Reference==null?153:102;continue;}
case 102:{f.Push(f.Locals[2]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[8]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[1]);f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("Reassemble")));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",111);}
case 111:{f.Pc=f.Pop().Int==0?119:114;continue;}
case 114:{f.Push(JValue.R(rt.String(" reassemble")));f.Pc=116;continue;}
case 116:{f.Pc=121;continue;}
case 119:{f.Push(JValue.R(rt.String(" assemble")));f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/util/Lang","joinVerb","(Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;","invokestatic",124);}
case 124:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",127);}
case 127:{f.Push(JValue.R(rt.String(" ")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",132);}
case 132:{f.StackOp("pop");f.Pc=133;continue;}
case 133:{f.Push(f.Locals[2]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[8]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",139);}
case 139:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",142);}
case 142:{f.Push(JValue.R(rt.String(".")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",147);}
case 147:{f.StackOp("pop");f.Pc=148;continue;}
case 148:{f.Push(f.Locals[2]);f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",152);}
case 152:{return JStep.Return(f.Pop());}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("Amount")));f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",159);}
case 159:{f.Pc=f.Pop().Int==0?207:162;continue;}
case 162:{f.Push(f.Locals[1]);f.Pc=163;continue;}
case 163:{f.Push(JValue.R(rt.String("Amount")));f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",168);}
case 168:{f.Locals[10]=f.Pop();f.Pc=170;continue;}
case 170:{f.Push(f.Locals[10]);f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.String("Result")));f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",177);}
case 177:{f.Pc=f.Pop().Int==0?192:180;continue;}
case 180:{f.Push(f.Locals[2]);f.Pc=181;continue;}
case 181:{f.Push(JValue.R(rt.String(" assembles a number of Contraptions equal to the result.")));f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",186);}
case 186:{f.StackOp("pop");f.Pc=187;continue;}
case 187:{f.Push(f.Locals[2]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",191);}
case 191:{return JStep.Return(f.Pop());}
case 192:{f.Push(f.Locals[1]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",196);}
case 196:{f.Push(f.Locals[10]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[1]);f.Pc=199;continue;}
case 199:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",202);}
case 202:{f.Locals[9]=f.Pop();f.Pc=204;continue;}
case 204:{f.Pc=210;continue;}
case 207:{f.Push(JValue.I(1));f.Pc=208;continue;}
case 208:{f.Locals[9]=f.Pop();f.Pc=210;continue;}
case 210:{f.Push(f.Locals[6]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",217);}
case 217:{f.Push(JValue.I(1));f.Pc=218;continue;}
case 218:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?228:221;continue;}
case 221:{f.Push(f.Locals[2]);f.Pc=222;continue;}
case 222:{f.Push(JValue.R(rt.String(" each")));f.Pc=224;continue;}
case 224:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",227);}
case 227:{f.StackOp("pop");f.Pc=228;continue;}
case 228:{f.Push(f.Locals[2]);f.Pc=229;continue;}
case 229:{f.Push(f.Locals[6]);f.Pc=231;continue;}
case 231:{f.Push(JValue.R(rt.String(" assemble")));f.Pc=233;continue;}
case 233:{return rt.Call(f,"forge/util/Lang","joinVerb","(Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;","invokestatic",236);}
case 236:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",239);}
case 239:{f.Push(JValue.R(rt.String(" ")));f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",244);}
case 244:{f.StackOp("pop");f.Pc=245;continue;}
case 245:{f.Push(f.Locals[2]);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[9]);f.Pc=248;continue;}
case 248:{f.Push(JValue.I(1));f.Pc=249;continue;}
case 249:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?257:252;continue;}
case 252:{f.Push(JValue.R(rt.String("a Contraption.")));f.Pc=254;continue;}
case 254:{f.Pc=267;continue;}
case 257:{f.Push(f.Locals[9]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/util/Lang","getNumeral","(I)Ljava/lang/String;","invokestatic",262);}
case 262:{return rt.DynamicCall(f,"forge/game/ability/effects/AssembleContraptionEffect:3036:262:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",267);}
case 267:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",270);}
case 270:{f.StackOp("pop");f.Pc=271;continue;}
case 271:{f.Push(f.Locals[2]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",275);}
case 275:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3037(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[3]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/card/Card","isCreature","()Z","invokevirtual",20);}
case 20:{f.Pc=f.Pop().Int==0?28:23;continue;}
case 23:{f.Push(JValue.R(rt.String("Self")));f.Pc=25;continue;}
case 25:{f.Pc=30;continue;}
case 28:{f.Push(JValue.R(rt.String("You")));f.Pc=30;continue;}
case 30:{f.Locals[5]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{f.Push(JValue.R(rt.String("DefinedAssembler")));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[5]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",40);}
case 40:{f.Locals[6]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[6]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedEntities","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",49);}
case 49:{f.Locals[7]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[7]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",58);}
case 58:{f.Pc=f.Pop().Int==0?62:61;continue;}
case 61:{return JStep.ReturnVoid;}
case 62:{return rt.Call(f,"forge/game/ability/AbilityKey","newMap","()Ljava/util/EnumMap;","invokestatic",65);}
case 65:{f.Locals[8]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[8]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[1]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/ability/AbilityKey","addCardZoneTableParams","(Ljava/util/Map;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardZoneTable;","invokestatic",73);}
case 73:{f.Locals[9]=f.Pop();f.Pc=75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("DefinedContraption")));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",81);}
case 81:{f.Locals[10]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[10]);f.Pc=85;continue;}
case 85:{f.Pc=f.Pop().Reference==null?390:88;continue;}
case 88:{f.Push(f.Locals[3]);f.Pc=89;continue;}
case 89:{f.Push(f.Locals[10]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",95);}
case 95:{f.Locals[11]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[11]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",104);}
case 104:{f.Pc=f.Pop().Int==0?108:107;continue;}
case 107:{return JStep.ReturnVoid;}
case 108:{f.Push(f.Locals[7]);f.Pc=110;continue;}
case 110:{f.Push(JValue.I(0));f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",116);}
case 116:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=119;continue;}
case 119:{f.Locals[12]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[12]);f.Pc=123;continue;}
case 123:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=126;continue;}
case 126:{f.Pc=f.Pop().Int==0?137:129;continue;}
case 129:{f.Push(f.Locals[12]);f.Pc=131;continue;}
case 131:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=134;continue;}
case 134:{f.Pc=157;continue;}
case 137:{f.Push(f.Locals[12]);f.Pc=139;continue;}
case 139:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=142;continue;}
case 142:{f.Pc=f.Pop().Int==0?156:145;continue;}
case 145:{f.Push(f.Locals[12]);f.Pc=147;continue;}
case 147:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",153);}
case 153:{f.Pc=157;continue;}
case 156:{f.Push(JValue.R(null));f.Pc=157;continue;}
case 157:{f.Locals[13]=f.Pop();f.Pc=159;continue;}
case 159:{f.Push(f.Locals[13]);f.Pc=161;continue;}
case 161:{f.Pc=f.Pop().Reference==null?172:164;continue;}
case 164:{f.Push(f.Locals[13]);f.Pc=166;continue;}
case 166:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",169);}
case 169:{f.Pc=f.Pop().Int!=0?173:172;continue;}
case 172:{return JStep.ReturnVoid;}
case 173:{f.Push(f.Locals[11]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",180);}
case 180:{f.Locals[14]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(f.Locals[14]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",189);}
case 189:{f.Pc=f.Pop().Int==0?376:192;continue;}
case 192:{f.Push(f.Locals[14]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",199);}
case 199:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=202;continue;}
case 202:{f.Locals[15]=f.Pop();f.Pc=204;continue;}
case 204:{f.Push(f.Locals[15]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",209);}
case 209:{f.Push(f.Locals[13]);f.Pc=211;continue;}
case 211:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?218:214;continue;}
case 214:{f.Push(JValue.I(1));f.Pc=215;continue;}
case 215:{f.Pc=219;continue;}
case 218:{f.Push(JValue.I(0));f.Pc=219;continue;}
case 219:{f.Locals[16]=f.Pop();f.Pc=221;continue;}
case 221:{f.Push(f.Locals[15]);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[13]);f.Pc=225;continue;}
case 225:{f.Push(f.Locals[4]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",230);}
case 230:{return rt.Call(f,"forge/game/card/Card","setController","(Lforge/game/player/Player;J)V","invokevirtual",233);}
case 233:{f.Push(f.Locals[15]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/card/Card","getZone","()Lforge/game/zone/Zone;","invokevirtual",238);}
case 238:{return rt.Call(f,"forge/game/zone/Zone","getZoneType","()Lforge/game/zone/ZoneType;","invokevirtual",241);}
case 241:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=244;continue;}
case 244:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?264:247;continue;}
case 247:{f.Push(f.Locals[15]);f.Pc=249;continue;}
case 249:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",252);}
case 252:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",255);}
case 255:{f.Push(f.Locals[15]);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[1]);f.Pc=258;continue;}
case 258:{f.Push(f.Locals[8]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/GameAction","moveToPlay","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",263);}
case 263:{f.StackOp("pop");f.Pc=264;continue;}
case 264:{f.Push(f.Locals[1]);f.Pc=265;continue;}
case 265:{f.Push(JValue.R(rt.String("Remember")));f.Pc=267;continue;}
case 267:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",270);}
case 270:{f.Pc=f.Pop().Int==0?279:273;continue;}
case 273:{f.Push(f.Locals[2]);f.Pc=274;continue;}
case 274:{f.Push(f.Locals[15]);f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",279);}
case 279:{f.Push(f.Locals[16]);f.Pc=281;continue;}
case 281:{f.Pc=f.Pop().Int==0?294:284;continue;}
case 284:{f.Push(f.Locals[4]);f.Pc=286;continue;}
case 286:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",289);}
case 289:{f.Push(f.Locals[15]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/game/GameAction","controllerChangeZoneCorrection","(Lforge/game/card/Card;)V","invokevirtual",294);}
case 294:{f.Push(JValue.I(3));f.Pc=295;continue;}
case 295:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Integer;",f.Pop().Int)));f.Pc=298;continue;}
case 298:{f.StackOp("dup");f.Pc=299;continue;}
case 299:{f.Push(JValue.I(0));f.Pc=300;continue;}
case 300:{f.Push(JValue.I(1));f.Pc=301;continue;}
case 301:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",304);}
case 304:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=305;continue;}
case 305:{f.StackOp("dup");f.Pc=306;continue;}
case 306:{f.Push(JValue.I(1));f.Pc=307;continue;}
case 307:{f.Push(JValue.I(2));f.Pc=308;continue;}
case 308:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",311);}
case 311:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=312;continue;}
case 312:{f.StackOp("dup");f.Pc=313;continue;}
case 313:{f.Push(JValue.I(2));f.Pc=314;continue;}
case 314:{f.Push(JValue.I(3));f.Pc=315;continue;}
case 315:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",318);}
case 318:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=319;continue;}
case 319:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",322);}
case 322:{f.Locals[17]=f.Pop();f.Pc=324;continue;}
case 324:{f.Push(f.Locals[1]);f.Pc=325;continue;}
case 325:{f.Push(JValue.R(rt.String("Reassemble")));f.Pc=327;continue;}
case 327:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",330);}
case 330:{f.Pc=f.Pop().Int==0?349:333;continue;}
case 333:{f.Push(f.Locals[17]);f.Pc=335;continue;}
case 335:{f.Push(f.Locals[15]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/game/card/Card","getSprocket","()I","invokevirtual",340);}
case 340:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",343);}
case 343:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",348);}
case 348:{f.StackOp("pop");f.Pc=349;continue;}
case 349:{f.Push(f.Locals[15]);f.Pc=351;continue;}
case 351:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",354);}
case 354:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",357);}
case 357:{f.Push(f.Locals[15]);f.Pc=359;continue;}
case 359:{f.Push(f.Locals[17]);f.Pc=361;continue;}
case 361:{return rt.Call(f,"forge/game/player/PlayerController","chooseSprocket","(Lforge/game/card/Card;Ljava/util/List;)I","invokevirtual",364);}
case 364:{f.Locals[18]=f.Pop();f.Pc=366;continue;}
case 366:{f.Push(f.Locals[15]);f.Pc=368;continue;}
case 368:{f.Push(f.Locals[18]);f.Pc=370;continue;}
case 370:{return rt.Call(f,"forge/game/card/Card","setSprocket","(I)V","invokevirtual",373);}
case 373:{f.Pc=182;continue;}
case 376:{f.Push(f.Locals[9]);f.Pc=378;continue;}
case 378:{f.Push(f.Locals[1]);f.Pc=379;continue;}
case 379:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",382);}
case 382:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",385);}
case 385:{f.Push(f.Locals[1]);f.Pc=386;continue;}
case 386:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",389);}
case 389:{return JStep.ReturnVoid;}
case 390:{f.Push(f.Locals[1]);f.Pc=391;continue;}
case 391:{f.Push(JValue.R(rt.String("Amount")));f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",396);}
case 396:{f.Pc=f.Pop().Int==0?416:399;continue;}
case 399:{f.Push(f.Locals[1]);f.Pc=400;continue;}
case 400:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",403);}
case 403:{f.Push(f.Locals[1]);f.Pc=404;continue;}
case 404:{f.Push(JValue.R(rt.String("Amount")));f.Pc=406;continue;}
case 406:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",409);}
case 409:{f.Push(f.Locals[1]);f.Pc=410;continue;}
case 410:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",413);}
case 413:{f.Pc=417;continue;}
case 416:{f.Push(JValue.I(1));f.Pc=417;continue;}
case 417:{f.Locals[11]=f.Pop();f.Pc=419;continue;}
case 419:{f.Push(f.Locals[7]);f.Pc=421;continue;}
case 421:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",426);}
case 426:{f.Locals[12]=f.Pop();f.Pc=428;continue;}
case 428:{f.Push(f.Locals[12]);f.Pc=430;continue;}
case 430:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",435);}
case 435:{f.Pc=f.Pop().Int==0?662:438;continue;}
case 438:{f.Push(f.Locals[12]);f.Pc=440;continue;}
case 440:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",445);}
case 445:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=448;continue;}
case 448:{f.Locals[13]=f.Pop();f.Pc=450;continue;}
case 450:{f.Push(f.Locals[13]);f.Pc=452;continue;}
case 452:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=455;continue;}
case 455:{f.Pc=f.Pop().Int==0?466:458;continue;}
case 458:{f.Push(f.Locals[13]);f.Pc=460;continue;}
case 460:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=463;continue;}
case 463:{f.Pc=486;continue;}
case 466:{f.Push(f.Locals[13]);f.Pc=468;continue;}
case 468:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=471;continue;}
case 471:{f.Pc=f.Pop().Int==0?485:474;continue;}
case 474:{f.Push(f.Locals[13]);f.Pc=476;continue;}
case 476:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=479;continue;}
case 479:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",482);}
case 482:{f.Pc=486;continue;}
case 485:{f.Push(JValue.R(null));f.Pc=486;continue;}
case 486:{f.Locals[14]=f.Pop();f.Pc=488;continue;}
case 488:{f.Push(f.Locals[14]);f.Pc=490;continue;}
case 490:{f.Pc=f.Pop().Reference==null?428:493;continue;}
case 493:{f.Push(f.Locals[14]);f.Pc=495;continue;}
case 495:{return rt.Call(f,"forge/game/player/Player","isInGame","()Z","invokevirtual",498);}
case 498:{f.Pc=f.Pop().Int!=0?504:501;continue;}
case 501:{f.Pc=428;continue;}
case 504:{f.Push(f.Locals[14]);f.Pc=506;continue;}
case 506:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",509);}
case 509:{f.Locals[15]=f.Pop();f.Pc=511;continue;}
case 511:{f.Push(f.Locals[15]);f.Pc=513;continue;}
case 513:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Player","Lforge/game/ability/AbilityKey;"));f.Pc=516;continue;}
case 516:{f.Push(f.Locals[14]);f.Pc=518;continue;}
case 518:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",523);}
case 523:{f.StackOp("pop");f.Pc=524;continue;}
case 524:{f.Push(f.Locals[15]);f.Pc=526;continue;}
case 526:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Cause","Lforge/game/ability/AbilityKey;"));f.Pc=529;continue;}
case 529:{f.Push(f.Locals[13]);f.Pc=531;continue;}
case 531:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",536);}
case 536:{f.StackOp("pop");f.Pc=537;continue;}
case 537:{f.Push(f.Locals[14]);f.Pc=539;continue;}
case 539:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"));f.Pc=542;continue;}
case 542:{return rt.Call(f,"forge/game/player/Player","getZone","(Lforge/game/zone/ZoneType;)Lforge/game/zone/PlayerZone;","invokevirtual",545);}
case 545:{f.Locals[16]=f.Pop();f.Pc=547;continue;}
case 547:{f.Push(JValue.I(0));f.Pc=548;continue;}
case 548:{f.Locals[17]=f.Pop();f.Pc=550;continue;}
case 550:{f.Push(f.Locals[17]);f.Pc=552;continue;}
case 552:{f.Push(f.Locals[11]);f.Pc=554;continue;}
case 554:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?659:557;continue;}
case 557:{f.Push(f.Locals[4]);f.Pc=559;continue;}
case 559:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",562);}
case 562:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","AssembleContraption","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","AssembleContraption","Lforge/game/replacement/ReplacementType;"));f.Pc=565;continue;}
case 565:{f.Push(f.Locals[15]);f.Pc=567;continue;}
case 567:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",570);}
case 570:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=573;continue;}
case 573:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?579:576;continue;}
case 576:{f.Pc=653;continue;}
case 579:{f.Push(f.Locals[16]);f.Pc=581;continue;}
case 581:{return rt.Call(f,"forge/game/zone/PlayerZone","isEmpty","()Z","invokevirtual",584);}
case 584:{f.Pc=f.Pop().Int==0?590:587;continue;}
case 587:{f.Pc=653;continue;}
case 590:{f.Push(f.Locals[16]);f.Pc=592;continue;}
case 592:{f.Push(JValue.I(0));f.Pc=593;continue;}
case 593:{return rt.Call(f,"forge/game/zone/PlayerZone","get","(I)Lforge/game/card/Card;","invokevirtual",596);}
case 596:{f.Locals[18]=f.Pop();f.Pc=598;continue;}
case 598:{f.Push(f.Locals[14]);f.Pc=600;continue;}
case 600:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",603);}
case 603:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",606);}
case 606:{f.Push(f.Locals[18]);f.Pc=608;continue;}
case 608:{f.Push(f.Locals[1]);f.Pc=609;continue;}
case 609:{f.Push(f.Locals[8]);f.Pc=611;continue;}
case 611:{return rt.Call(f,"forge/game/GameAction","moveToPlay","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;Ljava/util/Map;)Lforge/game/card/Card;","invokevirtual",614);}
case 614:{f.Locals[18]=f.Pop();f.Pc=616;continue;}
case 616:{f.Push(f.Locals[18]);f.Pc=618;continue;}
case 618:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",621);}
case 621:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",624);}
case 624:{f.Push(f.Locals[18]);f.Pc=626;continue;}
case 626:{return rt.Call(f,"forge/game/player/PlayerController","chooseSprocket","(Lforge/game/card/Card;)I","invokevirtual",629);}
case 629:{f.Locals[19]=f.Pop();f.Pc=631;continue;}
case 631:{f.Push(f.Locals[18]);f.Pc=633;continue;}
case 633:{f.Push(f.Locals[19]);f.Pc=635;continue;}
case 635:{return rt.Call(f,"forge/game/card/Card","setSprocket","(I)V","invokevirtual",638);}
case 638:{f.Push(f.Locals[1]);f.Pc=639;continue;}
case 639:{f.Push(JValue.R(rt.String("Remember")));f.Pc=641;continue;}
case 641:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",644);}
case 644:{f.Pc=f.Pop().Int==0?653:647;continue;}
case 647:{f.Push(f.Locals[2]);f.Pc=648;continue;}
case 648:{f.Push(f.Locals[18]);f.Pc=650;continue;}
case 650:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",653);}
case 653:{f.Locals[17]=JValue.I(unchecked(f.Locals[17].Int+(1)));f.Pc=656;continue;}
case 656:{f.Pc=550;continue;}
case 659:{f.Pc=428;continue;}
case 662:{f.Push(f.Locals[9]);f.Pc=664;continue;}
case 664:{f.Push(f.Locals[1]);f.Pc=665;continue;}
case 665:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",668);}
case 668:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",671);}
case 671:{f.Push(f.Locals[1]);f.Pc=672;continue;}
case 672:{return rt.Call(f,"forge/game/card/CardZoneTable","triggerChangesZoneAll","(Lforge/game/Game;Lforge/game/spellability/SpellAbility;)V","invokevirtual",675);}
case 675:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
