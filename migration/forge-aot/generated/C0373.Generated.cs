// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C373{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/RemoveFromMatchEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3628,"forge/game/ability/effects/RemoveFromMatchEffect","<init>","()V",1,1,1,new JHandler[]{},M3628));
c.Add(new JMethod(3629,"forge/game/ability/effects/RemoveFromMatchEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,10,5,new JHandler[]{},M3629));
}

internal static JStep M3628(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3629(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("RemoveFromInventory")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("RemoveType")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?88:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/card/Card","getOwner","()Lforge/game/player/Player;","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/game/Game","getCardsInGame","()Lforge/game/card/CardCollectionView;","invokevirtual",32);}
case 32:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=35;continue;}
case 35:{f.Locals[5]=f.Pop();f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(JValue.R(rt.String("IncludeSideboard")));f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int==0?69:46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",50);}
case 50:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",56);}
case 56:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=59;continue;}
case 59:{f.Locals[6]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(f.Locals[5]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[6]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",68);}
case 68:{f.StackOp("pop");f.Pc=69;continue;}
case 69:{f.Push(f.Locals[5]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[1]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("RemoveType")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",77);}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/ability/AbilityUtils","filterListByType","(Lforge/game/card/CardCollectionView;Ljava/lang/String;Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollectionView;","invokestatic",81);}
case 81:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CardCollection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=84;continue;}
case 84:{f.Locals[3]=f.Pop();f.Pc=85;continue;}
case 85:{f.Pc=93;continue;}
case 88:{f.Push(f.Locals[1]);f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/ability/effects/RemoveFromMatchEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",92);}
case 92:{f.Locals[3]=f.Pop();f.Pc=93;continue;}
case 93:{f.Push(f.Locals[1]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("LogMessage")));f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("Removed from match")));f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",101);}
case 101:{f.Locals[5]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/card/CardCollection","toString","()Ljava/lang/String;","invokevirtual",107);}
case 107:{f.Push(JValue.R(rt.String("[")));f.Pc=109;continue;}
case 109:{f.Push(JValue.R(rt.String("")));f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",114);}
case 114:{f.Push(JValue.R(rt.String("]")));f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",121);}
case 121:{f.Locals[6]=f.Pop();f.Pc=123;continue;}
case 123:{f.Push(f.Locals[2]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",127);}
case 127:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",130);}
case 130:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventRandomLog"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventRandomLog")));f.Pc=133;continue;}
case 133:{f.StackOp("dup");f.Pc=134;continue;}
case 134:{f.Push(f.Locals[5]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[6]);f.Pc=138;continue;}
case 138:{return rt.DynamicCall(f,"forge/game/ability/effects/RemoveFromMatchEffect:3629:138:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",143);}
case 143:{return rt.Call(f,"forge/game/event/GameEventRandomLog","<init>","(Ljava/lang/String;)V","invokespecial",146);}
case 146:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",149);}
case 149:{f.Push(f.Locals[3]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",153);}
case 153:{f.Locals[7]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[7]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",162);}
case 162:{f.Pc=f.Pop().Int==0?230:165;continue;}
case 165:{f.Push(f.Locals[7]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",172);}
case 172:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=175;continue;}
case 175:{f.Locals[8]=f.Pop();f.Pc=177;continue;}
case 177:{f.Push(f.Locals[8]);f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",182);}
case 182:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",185);}
case 185:{f.Push(f.Locals[8]);f.Pc=187;continue;}
case 187:{f.Push(JValue.I(1));f.Pc=188;continue;}
case 188:{return rt.Call(f,"forge/game/GameAction","ceaseToExist","(Lforge/game/card/Card;Z)V","invokevirtual",191);}
case 191:{f.Push(f.Locals[8]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/card/Card","getPaperCard","()Lforge/item/IPaperCard;","invokevirtual",196);}
case 196:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=199;continue;}
case 199:{f.Locals[9]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(f.Locals[2]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",205);}
case 205:{return rt.Call(f,"forge/game/Game","getMatch","()Lforge/game/Match;","invokevirtual",208);}
case 208:{f.Push(f.Locals[9]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/Match","removeCard","(Lforge/item/PaperCard;)V","invokevirtual",213);}
case 213:{f.Push(f.Locals[4]);f.Pc=215;continue;}
case 215:{f.Pc=f.Pop().Int==0?227:218;continue;}
case 218:{f.Push(f.Locals[2]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",222);}
case 222:{f.Push(f.Locals[8]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/player/Player","destroyPhysicalCard","(Lforge/game/card/Card;)V","invokevirtual",227);}
case 227:{f.Pc=155;continue;}
case 230:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
