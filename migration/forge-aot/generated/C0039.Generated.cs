// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C39{
internal static JClass Build(){var c=new JClass("forge/card/CardRulesPredicates$1","java/lang/Object",new string[]{},4128);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("$SwitchMap$forge$card$CardRulesPredicates$LeafString$CardField","[I",true,JValue.Default("[I"),null));
c.Add(new JField("$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I",true,JValue.Default("[I"),null));
c.Add(new JField("$SwitchMap$forge$card$CardRulesPredicates$LeafNumber$CardField","[I",true,JValue.Default("[I"),null));
c.Add(new JMethod(740,"forge/card/CardRulesPredicates$1","<clinit>","()V",8,1,3,new JHandler[]{new JHandler(9,20,23,"java/lang/NoSuchFieldError"),new JHandler(24,35,38,"java/lang/NoSuchFieldError"),new JHandler(39,50,53,"java/lang/NoSuchFieldError"),new JHandler(54,65,68,"java/lang/NoSuchFieldError"),new JHandler(69,80,83,"java/lang/NoSuchFieldError"),new JHandler(84,96,99,"java/lang/NoSuchFieldError"),new JHandler(109,120,123,"java/lang/NoSuchFieldError"),new JHandler(124,135,138,"java/lang/NoSuchFieldError"),new JHandler(139,150,153,"java/lang/NoSuchFieldError"),new JHandler(154,165,168,"java/lang/NoSuchFieldError"),new JHandler(169,180,183,"java/lang/NoSuchFieldError"),new JHandler(184,196,199,"java/lang/NoSuchFieldError"),new JHandler(200,212,215,"java/lang/NoSuchFieldError"),new JHandler(216,228,231,"java/lang/NoSuchFieldError"),new JHandler(232,244,247,"java/lang/NoSuchFieldError"),new JHandler(257,268,271,"java/lang/NoSuchFieldError"),new JHandler(272,283,286,"java/lang/NoSuchFieldError"),new JHandler(287,298,301,"java/lang/NoSuchFieldError"),new JHandler(302,313,316,"java/lang/NoSuchFieldError"),new JHandler(317,328,331,"java/lang/NoSuchFieldError")},M740));
}

internal static JStep M740(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","values","()[Lforge/card/CardRulesPredicates$LeafNumber$CardField;","invokestatic",3);}
case 3:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafNumber$CardField","[I"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafNumber$CardField","[I",f.Pop());f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafNumber$CardField","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafNumber$CardField","[I"));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","CMC","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","CMC","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","ordinal","()I","invokevirtual",18);}
case 18:{f.Push(JValue.I(1));f.Pc=19;continue;}
case 19:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=20;continue;}
case 20:{f.Pc=24;continue;}
case 23:{f.Locals[0]=f.Pop();f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafNumber$CardField","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafNumber$CardField","[I"));f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","GENERIC_COST","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","GENERIC_COST","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","ordinal","()I","invokevirtual",33);}
case 33:{f.Push(JValue.I(2));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.Pc=39;continue;}
case 38:{f.Locals[0]=f.Pop();f.Pc=39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafNumber$CardField","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafNumber$CardField","[I"));f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","LOYALTY","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","LOYALTY","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","ordinal","()I","invokevirtual",48);}
case 48:{f.Push(JValue.I(3));f.Pc=49;continue;}
case 49:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=50;continue;}
case 50:{f.Pc=54;continue;}
case 53:{f.Locals[0]=f.Pop();f.Pc=54;continue;}
case 54:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafNumber$CardField","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafNumber$CardField","[I"));f.Pc=57;continue;}
case 57:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","POWER","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","POWER","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","ordinal","()I","invokevirtual",63);}
case 63:{f.Push(JValue.I(4));f.Pc=64;continue;}
case 64:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=65;continue;}
case 65:{f.Pc=69;continue;}
case 68:{f.Locals[0]=f.Pop();f.Pc=69;continue;}
case 69:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafNumber$CardField","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafNumber$CardField","[I"));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","TOUGHNESS","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","TOUGHNESS","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","ordinal","()I","invokevirtual",78);}
case 78:{f.Push(JValue.I(5));f.Pc=79;continue;}
case 79:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=80;continue;}
case 80:{f.Pc=84;continue;}
case 83:{f.Locals[0]=f.Pop();f.Pc=84;continue;}
case 84:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafNumber$CardField","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafNumber$CardField","[I"));f.Pc=87;continue;}
case 87:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","PT","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafNumber$CardField","PT","Lforge/card/CardRulesPredicates$LeafNumber$CardField;"));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafNumber$CardField","ordinal","()I","invokevirtual",93);}
case 93:{f.Push(JValue.I(6));f.Pc=95;continue;}
case 95:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=96;continue;}
case 96:{f.Pc=100;continue;}
case 99:{f.Locals[0]=f.Pop();f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","values","()[Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;","invokestatic",103);}
case 103:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=106;continue;}
case 106:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I",f.Pop());f.Pc=109;continue;}
case 109:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"));f.Pc=112;continue;}
case 112:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColors","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColors","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","ordinal","()I","invokevirtual",118);}
case 118:{f.Push(JValue.I(1));f.Pc=119;continue;}
case 119:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=120;continue;}
case 120:{f.Pc=124;continue;}
case 123:{f.Locals[0]=f.Pop();f.Pc=124;continue;}
case 124:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"));f.Pc=127;continue;}
case 127:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsGreaterOrEqual","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsGreaterOrEqual","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","ordinal","()I","invokevirtual",133);}
case 133:{f.Push(JValue.I(2));f.Pc=134;continue;}
case 134:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=135;continue;}
case 135:{f.Pc=139;continue;}
case 138:{f.Locals[0]=f.Pop();f.Pc=139;continue;}
case 139:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"));f.Pc=142;continue;}
case 142:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsGreater","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsGreater","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","ordinal","()I","invokevirtual",148);}
case 148:{f.Push(JValue.I(3));f.Pc=149;continue;}
case 149:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=150;continue;}
case 150:{f.Pc=154;continue;}
case 153:{f.Locals[0]=f.Pop();f.Pc=154;continue;}
case 154:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"));f.Pc=157;continue;}
case 157:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsSmallerOrEqual","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsSmallerOrEqual","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=160;continue;}
case 160:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","ordinal","()I","invokevirtual",163);}
case 163:{f.Push(JValue.I(4));f.Pc=164;continue;}
case 164:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=165;continue;}
case 165:{f.Pc=169;continue;}
case 168:{f.Locals[0]=f.Pop();f.Pc=169;continue;}
case 169:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"));f.Pc=172;continue;}
case 172:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsSmaller","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CountColorsSmaller","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","ordinal","()I","invokevirtual",178);}
case 178:{f.Push(JValue.I(5));f.Pc=179;continue;}
case 179:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=180;continue;}
case 180:{f.Pc=184;continue;}
case 183:{f.Locals[0]=f.Pop();f.Pc=184;continue;}
case 184:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"));f.Pc=187;continue;}
case 187:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","Equals","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","Equals","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","ordinal","()I","invokevirtual",193);}
case 193:{f.Push(JValue.I(6));f.Pc=195;continue;}
case 195:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=196;continue;}
case 196:{f.Pc=200;continue;}
case 199:{f.Locals[0]=f.Pop();f.Pc=200;continue;}
case 200:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"));f.Pc=203;continue;}
case 203:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","HasAllOf","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","HasAllOf","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=206;continue;}
case 206:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","ordinal","()I","invokevirtual",209);}
case 209:{f.Push(JValue.I(7));f.Pc=211;continue;}
case 211:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=212;continue;}
case 212:{f.Pc=216;continue;}
case 215:{f.Locals[0]=f.Pop();f.Pc=216;continue;}
case 216:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"));f.Pc=219;continue;}
case 219:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","HasAnyOf","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","HasAnyOf","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","ordinal","()I","invokevirtual",225);}
case 225:{f.Push(JValue.I(8));f.Pc=227;continue;}
case 227:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=228;continue;}
case 228:{f.Pc=232;continue;}
case 231:{f.Locals[0]=f.Pop();f.Pc=232;continue;}
case 232:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafColor$ColorOperator","[I"));f.Pc=235;continue;}
case 235:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","CanCast","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafColor$ColorOperator","CanCast","Lforge/card/CardRulesPredicates$LeafColor$ColorOperator;"));f.Pc=238;continue;}
case 238:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafColor$ColorOperator","ordinal","()I","invokevirtual",241);}
case 241:{f.Push(JValue.I(9));f.Pc=243;continue;}
case 243:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=244;continue;}
case 244:{f.Pc=248;continue;}
case 247:{f.Locals[0]=f.Pop();f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString$CardField","values","()[Lforge/card/CardRulesPredicates$LeafString$CardField;","invokestatic",251);}
case 251:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=252;continue;}
case 252:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=254;continue;}
case 254:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafString$CardField","[I"))return JStep.Continue;rt.PutStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafString$CardField","[I",f.Pop());f.Pc=257;continue;}
case 257:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafString$CardField","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafString$CardField","[I"));f.Pc=260;continue;}
case 260:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafString$CardField","NAME","Lforge/card/CardRulesPredicates$LeafString$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafString$CardField","NAME","Lforge/card/CardRulesPredicates$LeafString$CardField;"));f.Pc=263;continue;}
case 263:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString$CardField","ordinal","()I","invokevirtual",266);}
case 266:{f.Push(JValue.I(1));f.Pc=267;continue;}
case 267:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=268;continue;}
case 268:{f.Pc=272;continue;}
case 271:{f.Locals[0]=f.Pop();f.Pc=272;continue;}
case 272:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafString$CardField","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafString$CardField","[I"));f.Pc=275;continue;}
case 275:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafString$CardField","SUBTYPE","Lforge/card/CardRulesPredicates$LeafString$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafString$CardField","SUBTYPE","Lforge/card/CardRulesPredicates$LeafString$CardField;"));f.Pc=278;continue;}
case 278:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString$CardField","ordinal","()I","invokevirtual",281);}
case 281:{f.Push(JValue.I(2));f.Pc=282;continue;}
case 282:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=283;continue;}
case 283:{f.Pc=287;continue;}
case 286:{f.Locals[0]=f.Pop();f.Pc=287;continue;}
case 287:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafString$CardField","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafString$CardField","[I"));f.Pc=290;continue;}
case 290:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafString$CardField","ORACLE_TEXT","Lforge/card/CardRulesPredicates$LeafString$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafString$CardField","ORACLE_TEXT","Lforge/card/CardRulesPredicates$LeafString$CardField;"));f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString$CardField","ordinal","()I","invokevirtual",296);}
case 296:{f.Push(JValue.I(3));f.Pc=297;continue;}
case 297:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=298;continue;}
case 298:{f.Pc=302;continue;}
case 301:{f.Locals[0]=f.Pop();f.Pc=302;continue;}
case 302:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafString$CardField","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafString$CardField","[I"));f.Pc=305;continue;}
case 305:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafString$CardField","JOINED_TYPE","Lforge/card/CardRulesPredicates$LeafString$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafString$CardField","JOINED_TYPE","Lforge/card/CardRulesPredicates$LeafString$CardField;"));f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString$CardField","ordinal","()I","invokevirtual",311);}
case 311:{f.Push(JValue.I(4));f.Pc=312;continue;}
case 312:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=313;continue;}
case 313:{f.Pc=317;continue;}
case 316:{f.Locals[0]=f.Pop();f.Pc=317;continue;}
case 317:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafString$CardField","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafString$CardField","[I"));f.Pc=320;continue;}
case 320:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$LeafString$CardField","COST","Lforge/card/CardRulesPredicates$LeafString$CardField;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$LeafString$CardField","COST","Lforge/card/CardRulesPredicates$LeafString$CardField;"));f.Pc=323;continue;}
case 323:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString$CardField","ordinal","()I","invokevirtual",326);}
case 326:{f.Push(JValue.I(5));f.Pc=327;continue;}
case 327:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=328;continue;}
case 328:{f.Pc=332;continue;}
case 331:{f.Locals[0]=f.Pop();f.Pc=332;continue;}
case 332:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
