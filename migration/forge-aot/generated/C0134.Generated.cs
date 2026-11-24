// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C134{
internal static JClass Build(){var c=new JClass("forge/game/GameAction$1","java/lang/Object",new string[]{},4128);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("$SwitchMap$forge$game$zone$ZoneType","[I",true,JValue.Default("[I"),null));
c.Add(new JField("$SwitchMap$forge$game$replacement$ReplacementResult","[I",true,JValue.Default("[I"),null));
c.Add(new JMethod(2144,"forge/game/GameAction$1","<clinit>","()V",8,1,3,new JHandler[]{new JHandler(9,20,23,"java/lang/NoSuchFieldError"),new JHandler(24,35,38,"java/lang/NoSuchFieldError"),new JHandler(48,59,62,"java/lang/NoSuchFieldError"),new JHandler(63,74,77,"java/lang/NoSuchFieldError"),new JHandler(78,89,92,"java/lang/NoSuchFieldError"),new JHandler(93,104,107,"java/lang/NoSuchFieldError"),new JHandler(108,119,122,"java/lang/NoSuchFieldError"),new JHandler(123,135,138,"java/lang/NoSuchFieldError"),new JHandler(139,151,154,"java/lang/NoSuchFieldError"),new JHandler(155,167,170,"java/lang/NoSuchFieldError"),new JHandler(171,183,186,"java/lang/NoSuchFieldError"),new JHandler(187,199,202,"java/lang/NoSuchFieldError"),new JHandler(203,215,218,"java/lang/NoSuchFieldError")},M2144));
}

internal static JStep M2144(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/game/replacement/ReplacementResult","values","()[Lforge/game/replacement/ReplacementResult;","invokestatic",3);}
case 3:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/GameAction$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;rt.PutStatic("forge/game/GameAction$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I",f.Pop());f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/game/GameAction$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameAction$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","NotReplaced","Lforge/game/replacement/ReplacementResult;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/replacement/ReplacementResult","ordinal","()I","invokevirtual",18);}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Locals[0]=f.Pop();f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/GameAction$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameAction$1","$SwitchMap$forge$game$replacement$ReplacementResult","[I"));f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementResult","Updated","Lforge/game/replacement/ReplacementResult;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/replacement/ReplacementResult","ordinal","()I","invokevirtual",33);}
case 33:{f.Push(JValue.I(2));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.Pc=39;continue;}
case 38:{f.Locals[0]=f.Pop();f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/zone/ZoneType","values","()[Lforge/game/zone/ZoneType;","invokestatic",42);}
case 42:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=45;continue;}
case 45:{if(!rt.StaticReady(f,"forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"))return JStep.Continue;rt.PutStatic("forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I",f.Pop());f.Pc=48;continue;}
case 48:{if(!rt.StaticReady(f,"forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/zone/ZoneType","ordinal","()I","invokevirtual",57);}
case 57:{f.Push(JValue.I(1));f.Pc=58;continue;}
case 58:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=59;continue;}
case 59:{f.Pc=63;continue;}
case 62:{f.Locals[0]=f.Pop();f.Pc=63;continue;}
case 63:{if(!rt.StaticReady(f,"forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"));f.Pc=66;continue;}
case 66:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/zone/ZoneType","ordinal","()I","invokevirtual",72);}
case 72:{f.Push(JValue.I(2));f.Pc=73;continue;}
case 73:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=74;continue;}
case 74:{f.Pc=78;continue;}
case 77:{f.Locals[0]=f.Pop();f.Pc=78;continue;}
case 78:{if(!rt.StaticReady(f,"forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"));f.Pc=81;continue;}
case 81:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/zone/ZoneType","ordinal","()I","invokevirtual",87);}
case 87:{f.Push(JValue.I(3));f.Pc=88;continue;}
case 88:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=89;continue;}
case 89:{f.Pc=93;continue;}
case 92:{f.Locals[0]=f.Pop();f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"));f.Pc=96;continue;}
case 96:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/zone/ZoneType","ordinal","()I","invokevirtual",102);}
case 102:{f.Push(JValue.I(4));f.Pc=103;continue;}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{f.Pc=108;continue;}
case 107:{f.Locals[0]=f.Pop();f.Pc=108;continue;}
case 108:{if(!rt.StaticReady(f,"forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"));f.Pc=111;continue;}
case 111:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/zone/ZoneType","ordinal","()I","invokevirtual",117);}
case 117:{f.Push(JValue.I(5));f.Pc=118;continue;}
case 118:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=119;continue;}
case 119:{f.Pc=123;continue;}
case 122:{f.Locals[0]=f.Pop();f.Pc=123;continue;}
case 123:{if(!rt.StaticReady(f,"forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"));f.Pc=126;continue;}
case 126:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=129;continue;}
case 129:{return rt.Call(f,"forge/game/zone/ZoneType","ordinal","()I","invokevirtual",132);}
case 132:{f.Push(JValue.I(6));f.Pc=134;continue;}
case 134:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=135;continue;}
case 135:{f.Pc=139;continue;}
case 138:{f.Locals[0]=f.Pop();f.Pc=139;continue;}
case 139:{if(!rt.StaticReady(f,"forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"));f.Pc=142;continue;}
case 142:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"));f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/zone/ZoneType","ordinal","()I","invokevirtual",148);}
case 148:{f.Push(JValue.I(7));f.Pc=150;continue;}
case 150:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=151;continue;}
case 151:{f.Pc=155;continue;}
case 154:{f.Locals[0]=f.Pop();f.Pc=155;continue;}
case 155:{if(!rt.StaticReady(f,"forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"));f.Pc=158;continue;}
case 158:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"));f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/zone/ZoneType","ordinal","()I","invokevirtual",164);}
case 164:{f.Push(JValue.I(8));f.Pc=166;continue;}
case 166:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=167;continue;}
case 167:{f.Pc=171;continue;}
case 170:{f.Locals[0]=f.Pop();f.Pc=171;continue;}
case 171:{if(!rt.StaticReady(f,"forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"));f.Pc=174;continue;}
case 174:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"));f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/zone/ZoneType","ordinal","()I","invokevirtual",180);}
case 180:{f.Push(JValue.I(9));f.Pc=182;continue;}
case 182:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=183;continue;}
case 183:{f.Pc=187;continue;}
case 186:{f.Locals[0]=f.Pop();f.Pc=187;continue;}
case 187:{if(!rt.StaticReady(f,"forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"));f.Pc=190;continue;}
case 190:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"));f.Pc=193;continue;}
case 193:{return rt.Call(f,"forge/game/zone/ZoneType","ordinal","()I","invokevirtual",196);}
case 196:{f.Push(JValue.I(10));f.Pc=198;continue;}
case 198:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=199;continue;}
case 199:{f.Pc=203;continue;}
case 202:{f.Locals[0]=f.Pop();f.Pc=203;continue;}
case 203:{if(!rt.StaticReady(f,"forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/GameAction$1","$SwitchMap$forge$game$zone$ZoneType","[I"));f.Pc=206;continue;}
case 206:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Junkyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Junkyard","Lforge/game/zone/ZoneType;"));f.Pc=209;continue;}
case 209:{return rt.Call(f,"forge/game/zone/ZoneType","ordinal","()I","invokevirtual",212);}
case 212:{f.Push(JValue.I(11));f.Pc=214;continue;}
case 214:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=215;continue;}
case 215:{f.Pc=219;continue;}
case 218:{f.Locals[0]=f.Pop();f.Pc=219;continue;}
case 219:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
