// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1047{
internal static JClass Build(){var c=new JClass("forge/game/zone/PlayerZone$OwnCardsActivationFilter","java/lang/Object",new string[]{"java/util/function/Predicate"},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("this$0","Lforge/game/zone/PlayerZone;",false,JValue.Default("Lforge/game/zone/PlayerZone;"),null));
c.Add(new JMethod(11100,"forge/game/zone/PlayerZone$OwnCardsActivationFilter","<init>","(Lforge/game/zone/PlayerZone;)V",2,2,2,new JHandler[]{},M11100));
c.Add(new JMethod(11101,"forge/game/zone/PlayerZone$OwnCardsActivationFilter","test","(Lforge/game/card/Card;)Z",1,4,2,new JHandler[]{},M11101));
c.Add(new JMethod(11102,"forge/game/zone/PlayerZone$OwnCardsActivationFilter","test","(Ljava/lang/Object;)Z",4161,2,2,new JHandler[]{},M11102));
}

internal static JStep M11100(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/PlayerZone$OwnCardsActivationFilter","this$0","Lforge/game/zone/PlayerZone;",value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",9);}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11101(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",5);}
case 5:{return rt.Call(f,"forge/game/card/Card","mayPlayerLook","(Lforge/game/player/Player;)Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?13:11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",18);}
case 18:{return rt.Call(f,"forge/game/card/Card","mayPlay","(Lforge/game/player/Player;)Ljava/util/List;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int!=0?31:29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/PlayerZone$OwnCardsActivationFilter","this$0","Lforge/game/zone/PlayerZone;"));f.Pc=35;continue;}
case 35:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/zone/PlayerZone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?140:44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","FLASHBACK","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","FLASHBACK","Lforge/game/keyword/Keyword;"));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",51);}
case 51:{f.Pc=f.Pop().Int!=0?138:54;continue;}
case 54:{f.Push(f.Locals[1]);f.Pc=55;continue;}
case 55:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","RETRACE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","RETRACE","Lforge/game/keyword/Keyword;"));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",61);}
case 61:{f.Pc=f.Pop().Int!=0?138:64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","JUMP_START","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","JUMP_START","Lforge/game/keyword/Keyword;"));f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",71);}
case 71:{f.Pc=f.Pop().Int!=0?138:74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","ESCAPE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","ESCAPE","Lforge/game/keyword/Keyword;"));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int!=0?138:84;continue;}
case 84:{f.Push(f.Locals[1]);f.Pc=85;continue;}
case 85:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","DISTURB","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","DISTURB","Lforge/game/keyword/Keyword;"));f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int!=0?138:94;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","BEAM_ME_UP","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","BEAM_ME_UP","Lforge/game/keyword/Keyword;"));f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",101);}
case 101:{f.Pc=f.Pop().Int!=0?138:104;continue;}
case 104:{f.Push(f.Locals[1]);f.Pc=105;continue;}
case 105:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","HARMONIZE","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","HARMONIZE","Lforge/game/keyword/Keyword;"));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",111);}
case 111:{f.Pc=f.Pop().Int!=0?138:114;continue;}
case 114:{f.Push(f.Locals[1]);f.Pc=115;continue;}
case 115:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","MAYHEM","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","MAYHEM","Lforge/game/keyword/Keyword;"));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int==0?140:124;continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/card/Card","wasDiscarded","()Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int==0?140:131;continue;}
case 131:{f.Push(f.Locals[1]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/card/Card","enteredThisTurn","()Z","invokevirtual",135);}
case 135:{f.Pc=f.Pop().Int==0?140:138;continue;}
case 138:{f.Push(JValue.I(1));f.Pc=139;continue;}
case 139:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 140:{f.Push(f.Locals[0]);f.Pc=141;continue;}
case 141:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/PlayerZone$OwnCardsActivationFilter","this$0","Lforge/game/zone/PlayerZone;"));f.Pc=144;continue;}
case 144:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=147;continue;}
case 147:{return rt.Call(f,"forge/game/zone/PlayerZone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",150);}
case 150:{f.Pc=f.Pop().Int==0?176:153;continue;}
case 153:{f.Push(f.Locals[1]);f.Pc=154;continue;}
case 154:{return rt.Call(f,"forge/game/card/Card","isForetold","()Z","invokevirtual",157);}
case 157:{f.Pc=f.Pop().Int!=0?174:160;continue;}
case 160:{f.Push(f.Locals[1]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/card/Card","isOnAdventure","()Z","invokevirtual",164);}
case 164:{f.Pc=f.Pop().Int!=0?174:167;continue;}
case 167:{f.Push(f.Locals[1]);f.Pc=168;continue;}
case 168:{return rt.Call(f,"forge/game/card/Card","isPlotted","()Z","invokevirtual",171);}
case 171:{f.Pc=f.Pop().Int==0?176:174;continue;}
case 174:{f.Push(JValue.I(1));f.Pc=175;continue;}
case 175:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 176:{f.Push(f.Locals[1]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/card/Card","getSpellAbilities","()Lforge/util/collect/FCollectionView;","invokevirtual",180);}
case 180:{return rt.Call(f,"forge/util/collect/FCollectionView","iterator","()Ljava/util/Iterator;","invokeinterface",185);}
case 185:{f.Locals[2]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(f.Locals[2]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",192);}
case 192:{f.Pc=f.Pop().Int==0?227:195;continue;}
case 195:{f.Push(f.Locals[2]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",201);}
case 201:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=204;continue;}
case 204:{f.Locals[3]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(f.Locals[0]);f.Pc=206;continue;}
case 206:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/PlayerZone$OwnCardsActivationFilter","this$0","Lforge/game/zone/PlayerZone;"));f.Pc=209;continue;}
case 209:{f.Push(f.Locals[3]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/spellability/SpellAbility","getRestrictions","()Lforge/game/spellability/SpellAbilityRestriction;","invokevirtual",213);}
case 213:{return rt.Call(f,"forge/game/spellability/SpellAbilityRestriction","getZone","()Lforge/game/zone/ZoneType;","invokevirtual",216);}
case 216:{return rt.Call(f,"forge/game/zone/PlayerZone","is","(Lforge/game/zone/ZoneType;)Z","invokevirtual",219);}
case 219:{f.Pc=f.Pop().Int==0?224:222;continue;}
case 222:{f.Push(JValue.I(1));f.Pc=223;continue;}
case 223:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 224:{f.Pc=186;continue;}
case 227:{f.Push(JValue.I(0));f.Pc=228;continue;}
case 228:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11102(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/zone/PlayerZone$OwnCardsActivationFilter","test","(Lforge/game/card/Card;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
