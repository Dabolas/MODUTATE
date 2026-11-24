// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C258{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ControlSpellEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3220,"forge/game/ability/effects/ControlSpellEffect","<init>","()V",1,1,1,new JHandler[]{},M3220));
c.Add(new JMethod(3221,"forge/game/ability/effects/ControlSpellEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V",1,2,2,new JHandler[]{},M3221));
c.Add(new JMethod(3222,"forge/game/ability/effects/ControlSpellEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,7,2,new JHandler[]{},M3222));
c.Add(new JMethod(3223,"forge/game/ability/effects/ControlSpellEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,16,4,new JHandler[]{},M3223));
}

internal static JStep M3220(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3221(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","buildSpellAbility","(Lforge/game/spellability/SpellAbility;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?22:12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTargetRestrictions","()Lforge/game/spellability/TargetRestrictions;","invokevirtual",16);}
case 16:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/TargetRestrictions","setZone","(Lforge/game/zone/ZoneType;)V","invokevirtual",22);}
case 22:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3222(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("NewController")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/ability/effects/ControlSpellEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/player/PlayerCollection;","invokestatic",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?35:24;continue;}
case 24:{f.Push(f.Locals[3]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",29);}
case 29:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",34);}
case 34:{f.StackOp("pop");f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[3]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",40);}
case 40:{f.Push(JValue.R(rt.String(" gains control of ")));f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",45);}
case 45:{f.StackOp("pop");f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/ability/effects/ControlSpellEffect","getTargetSpells","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",50);}
case 50:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",55);}
case 55:{f.Locals[4]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",64);}
case 64:{f.Pc=f.Pop().Int==0?121:67;continue;}
case 67:{f.Push(f.Locals[4]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",74);}
case 74:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=77;continue;}
case 77:{f.Locals[5]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",84);}
case 84:{f.Locals[6]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{f.Push(JValue.R(rt.String(" ")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",92);}
case 92:{f.StackOp("pop");f.Pc=93;continue;}
case 93:{f.Push(f.Locals[6]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?111:101;continue;}
case 101:{f.Push(f.Locals[2]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("Morph")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",107);}
case 107:{f.StackOp("pop");f.Pc=108;continue;}
case 108:{f.Pc=118;continue;}
case 111:{f.Push(f.Locals[2]);f.Pc=112;continue;}
case 112:{f.Push(f.Locals[6]);f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",117);}
case 117:{f.StackOp("pop");f.Pc=118;continue;}
case 118:{f.Pc=57;continue;}
case 121:{f.Push(f.Locals[2]);f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String(".")));f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",127);}
case 127:{f.StackOp("pop");f.Pc=128;continue;}
case 128:{f.Push(f.Locals[2]);f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",132);}
case 132:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3223(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Mode")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",11);}
case 11:{f.Push(JValue.R(rt.String("Exchange")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.String("Remember")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[1]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("NewController")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/ability/effects/ControlSpellEffect","getDefinedPlayersOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Lforge/game/player/PlayerCollection;","invokestatic",31);}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",40);}
case 40:{f.Pc=f.Pop().Int==0?50:43;continue;}
case 43:{f.Push(f.Locals[1]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",47);}
case 47:{f.Pc=61;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",58);}
case 58:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=61;continue;}
case 61:{f.Locals[6]=f.Pop();f.Pc=63;continue;}
case 63:{f.Push(f.Locals[6]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",68);}
case 68:{f.Locals[7]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[1]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/ability/effects/ControlSpellEffect","getTargetSpells","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",74);}
case 74:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",79);}
case 79:{f.Locals[8]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[8]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",88);}
case 88:{f.Pc=f.Pop().Int==0?283:91;continue;}
case 91:{f.Push(f.Locals[8]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",98);}
case 98:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=101;continue;}
case 101:{f.Locals[9]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[9]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",108);}
case 108:{f.Locals[10]=f.Pop();f.Pc=110;continue;}
case 110:{f.Push(f.Locals[7]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",115);}
case 115:{f.Locals[11]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[7]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",122);}
case 122:{f.Push(f.Locals[9]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/zone/MagicStack","getInstanceMatchingSpellAbilityID","(Lforge/game/spellability/SpellAbility;)Lforge/game/spellability/SpellAbilityStackInstance;","invokevirtual",127);}
case 127:{f.Locals[13]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[3]);f.Pc=130;continue;}
case 130:{f.Pc=f.Pop().Int==0?238:133;continue;}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{f.Push(JValue.R(rt.String("DefinedExchange")));f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/ability/effects/ControlSpellEffect","getDefinedOrTargeted","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;)Ljava/util/List;","invokestatic",139);}
case 139:{f.Push(JValue.R(null));f.Pc=140;continue;}
case 140:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",143);}
case 143:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameObject"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=146;continue;}
case 146:{f.Locals[14]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[14]);f.Pc=150;continue;}
case 150:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=153;continue;}
case 153:{f.Pc=f.Pop().Int==0?238:156;continue;}
case 156:{f.Push(f.Locals[14]);f.Pc=158;continue;}
case 158:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=161;continue;}
case 161:{f.Locals[15]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(f.Locals[15]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",168);}
case 168:{f.Pc=f.Pop().Int==0?81:171;continue;}
case 171:{f.Push(f.Locals[15]);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",176);}
case 176:{f.Pc=f.Pop().Int!=0?81:179;continue;}
case 179:{f.Push(f.Locals[13]);f.Pc=181;continue;}
case 181:{f.Pc=f.Pop().Reference!=null?187:184;continue;}
case 184:{f.Pc=81;continue;}
case 187:{f.Push(f.Locals[15]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[13]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",194);}
case 194:{return rt.Call(f,"forge/game/card/Card","canBeControlledBy","(Lforge/game/player/Player;)Z","invokevirtual",197);}
case 197:{f.Pc=f.Pop().Int!=0?203:200;continue;}
case 200:{f.Pc=81;continue;}
case 203:{f.Push(f.Locals[4]);f.Pc=205;continue;}
case 205:{f.Pc=f.Pop().Int==0?214:208;continue;}
case 208:{f.Push(f.Locals[2]);f.Pc=209;continue;}
case 209:{f.Push(f.Locals[15]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",214);}
case 214:{f.Push(f.Locals[15]);f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",219);}
case 219:{f.Locals[6]=f.Pop();f.Pc=221;continue;}
case 221:{f.Push(f.Locals[15]);f.Pc=223;continue;}
case 223:{f.Push(f.Locals[13]);f.Pc=225;continue;}
case 225:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",228);}
case 228:{f.Push(f.Locals[11]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/card/Card","addTempController","(Lforge/game/player/Player;J)V","invokevirtual",233);}
case 233:{f.Push(f.Locals[15]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/card/Card","runChangeControllerCommands","()V","invokevirtual",238);}
case 238:{f.Push(f.Locals[4]);f.Pc=240;continue;}
case 240:{f.Pc=f.Pop().Int==0?249:243;continue;}
case 243:{f.Push(f.Locals[2]);f.Pc=244;continue;}
case 244:{f.Push(f.Locals[10]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",249);}
case 249:{f.Push(f.Locals[10]);f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",254);}
case 254:{f.Push(f.Locals[6]);f.Pc=256;continue;}
case 256:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?264:259;continue;}
case 259:{f.Push(f.Locals[10]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/card/Card","runChangeControllerCommands","()V","invokevirtual",264);}
case 264:{f.Push(f.Locals[10]);f.Pc=266;continue;}
case 266:{f.Push(f.Locals[6]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[11]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/card/Card","addTempController","(Lforge/game/player/Player;J)V","invokevirtual",273);}
case 273:{f.Push(f.Locals[13]);f.Pc=275;continue;}
case 275:{f.Push(f.Locals[6]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"forge/game/spellability/SpellAbilityStackInstance","setActivatingPlayer","(Lforge/game/player/Player;)V","invokevirtual",280);}
case 280:{f.Pc=81;continue;}
case 283:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
