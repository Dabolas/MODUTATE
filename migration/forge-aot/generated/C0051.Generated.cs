// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C51{
internal static JClass Build(){var c=new JClass("forge/card/CardType$Constant","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("LOADED","Lforge/util/Settable;",true,JValue.Default("Lforge/util/Settable;"),null));
c.Add(new JField("BASIC_TYPES","Ljava/util/Set;",true,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("LAND_TYPES","Ljava/util/Set;",true,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("CREATURE_TYPES","Ljava/util/Set;",true,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("SPELL_TYPES","Ljava/util/Set;",true,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("ENCHANTMENT_TYPES","Ljava/util/Set;",true,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("ARTIFACT_TYPES","Ljava/util/Set;",true,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("WALKER_TYPES","Ljava/util/Set;",true,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("DUNGEON_TYPES","Ljava/util/Set;",true,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("BATTLE_TYPES","Ljava/util/Set;",true,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("PLANAR_TYPES","Ljava/util/Set;",true,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("MultiwordTypes","Ljava/util/Set;",true,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("pluralTypes","Lcom/google/common/collect/BiMap;",true,JValue.Default("Lcom/google/common/collect/BiMap;"),null));
c.Add(new JField("singularTypes","Lcom/google/common/collect/BiMap;",true,JValue.Default("Lcom/google/common/collect/BiMap;"),null));
c.Add(new JField("OUTLAW_TYPES","Ljava/util/Set;",true,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("PARTY_TYPES","Ljava/util/Set;",true,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JMethod(895,"forge/card/CardType$Constant","<init>","()V",1,1,1,new JHandler[]{},M895));
c.Add(new JMethod(896,"forge/card/CardType$Constant","<clinit>","()V",8,4,4,new JHandler[]{},M896));
}

internal static JStep M895(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M896(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/Settable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/Settable")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/util/Settable","<init>","()V","invokespecial",7);}
case 7:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","LOADED","Lforge/util/Settable;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Constant","LOADED","Lforge/util/Settable;",f.Pop());f.Pc=10;continue;}
case 10:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",13);}
case 13:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","BASIC_TYPES","Ljava/util/Set;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Constant","BASIC_TYPES","Ljava/util/Set;",f.Pop());f.Pc=16;continue;}
case 16:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",19);}
case 19:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","LAND_TYPES","Ljava/util/Set;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Constant","LAND_TYPES","Ljava/util/Set;",f.Pop());f.Pc=22;continue;}
case 22:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",25);}
case 25:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","CREATURE_TYPES","Ljava/util/Set;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Constant","CREATURE_TYPES","Ljava/util/Set;",f.Pop());f.Pc=28;continue;}
case 28:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",31);}
case 31:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","SPELL_TYPES","Ljava/util/Set;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Constant","SPELL_TYPES","Ljava/util/Set;",f.Pop());f.Pc=34;continue;}
case 34:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",37);}
case 37:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","ENCHANTMENT_TYPES","Ljava/util/Set;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Constant","ENCHANTMENT_TYPES","Ljava/util/Set;",f.Pop());f.Pc=40;continue;}
case 40:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",43);}
case 43:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","ARTIFACT_TYPES","Ljava/util/Set;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Constant","ARTIFACT_TYPES","Ljava/util/Set;",f.Pop());f.Pc=46;continue;}
case 46:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",49);}
case 49:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","WALKER_TYPES","Ljava/util/Set;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Constant","WALKER_TYPES","Ljava/util/Set;",f.Pop());f.Pc=52;continue;}
case 52:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",55);}
case 55:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","DUNGEON_TYPES","Ljava/util/Set;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Constant","DUNGEON_TYPES","Ljava/util/Set;",f.Pop());f.Pc=58;continue;}
case 58:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",61);}
case 61:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","BATTLE_TYPES","Ljava/util/Set;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Constant","BATTLE_TYPES","Ljava/util/Set;",f.Pop());f.Pc=64;continue;}
case 64:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",67);}
case 67:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","PLANAR_TYPES","Ljava/util/Set;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Constant","PLANAR_TYPES","Ljava/util/Set;",f.Pop());f.Pc=70;continue;}
case 70:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",73);}
case 73:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","MultiwordTypes","Ljava/util/Set;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Constant","MultiwordTypes","Ljava/util/Set;",f.Pop());f.Pc=76;continue;}
case 76:{return rt.Call(f,"com/google/common/collect/HashBiMap","create","()Lcom/google/common/collect/HashBiMap;","invokestatic",79);}
case 79:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","pluralTypes","Lcom/google/common/collect/BiMap;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Constant","pluralTypes","Lcom/google/common/collect/BiMap;",f.Pop());f.Pc=82;continue;}
case 82:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","pluralTypes","Lcom/google/common/collect/BiMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","pluralTypes","Lcom/google/common/collect/BiMap;"));f.Pc=85;continue;}
case 85:{return rt.Call(f,"com/google/common/collect/BiMap","inverse","()Lcom/google/common/collect/BiMap;","invokeinterface",90);}
case 90:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","singularTypes","Lcom/google/common/collect/BiMap;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Constant","singularTypes","Lcom/google/common/collect/BiMap;",f.Pop());f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/card/CardType$CoreType","values","()[Lforge/card/CardType$CoreType;","invokestatic",96);}
case 96:{f.Locals[0]=f.Pop();f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=99;continue;}
case 99:{f.Locals[1]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(JValue.I(0));f.Pc=101;continue;}
case 101:{f.Locals[2]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[2]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[1]);f.Pc=104;continue;}
case 104:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?134:107;continue;}
case 107:{f.Push(f.Locals[0]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[2]);f.Pc=109;continue;}
case 109:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=110;continue;}
case 110:{f.Locals[3]=f.Pop();f.Pc=111;continue;}
case 111:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","pluralTypes","Lcom/google/common/collect/BiMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","pluralTypes","Lcom/google/common/collect/BiMap;"));f.Pc=114;continue;}
case 114:{f.Push(f.Locals[3]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/card/CardType$CoreType","name","()Ljava/lang/String;","invokevirtual",118);}
case 118:{f.Push(f.Locals[3]);f.Pc=119;continue;}
case 119:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType$CoreType","pluralName","Ljava/lang/String;"));f.Pc=122;continue;}
case 122:{return rt.Call(f,"com/google/common/collect/BiMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",127);}
case 127:{f.StackOp("pop");f.Pc=128;continue;}
case 128:{f.Locals[2]=JValue.I(unchecked(f.Locals[2].Int+(1)));f.Pc=131;continue;}
case 131:{f.Pc=102;continue;}
case 134:{f.Push(JValue.I(5));f.Pc=135;continue;}
case 135:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=138;continue;}
case 138:{f.StackOp("dup");f.Pc=139;continue;}
case 139:{f.Push(JValue.I(0));f.Pc=140;continue;}
case 140:{f.Push(JValue.R(rt.String("Assassin")));f.Pc=142;continue;}
case 142:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=143;continue;}
case 143:{f.StackOp("dup");f.Pc=144;continue;}
case 144:{f.Push(JValue.I(1));f.Pc=145;continue;}
case 145:{f.Push(JValue.R(rt.String("Mercenary")));f.Pc=147;continue;}
case 147:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=148;continue;}
case 148:{f.StackOp("dup");f.Pc=149;continue;}
case 149:{f.Push(JValue.I(2));f.Pc=150;continue;}
case 150:{f.Push(JValue.R(rt.String("Pirate")));f.Pc=152;continue;}
case 152:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=153;continue;}
case 153:{f.StackOp("dup");f.Pc=154;continue;}
case 154:{f.Push(JValue.I(3));f.Pc=155;continue;}
case 155:{f.Push(JValue.R(rt.String("Rogue")));f.Pc=157;continue;}
case 157:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=158;continue;}
case 158:{f.StackOp("dup");f.Pc=159;continue;}
case 159:{f.Push(JValue.I(4));f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("Warlock")));f.Pc=162;continue;}
case 162:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=163;continue;}
case 163:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","([Ljava/lang/Object;)Ljava/util/HashSet;","invokestatic",166);}
case 166:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","OUTLAW_TYPES","Ljava/util/Set;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Constant","OUTLAW_TYPES","Ljava/util/Set;",f.Pop());f.Pc=169;continue;}
case 169:{f.Push(JValue.I(4));f.Pc=170;continue;}
case 170:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=173;continue;}
case 173:{f.StackOp("dup");f.Pc=174;continue;}
case 174:{f.Push(JValue.I(0));f.Pc=175;continue;}
case 175:{f.Push(JValue.R(rt.String("Cleric")));f.Pc=177;continue;}
case 177:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=178;continue;}
case 178:{f.StackOp("dup");f.Pc=179;continue;}
case 179:{f.Push(JValue.I(1));f.Pc=180;continue;}
case 180:{f.Push(JValue.R(rt.String("Rogue")));f.Pc=182;continue;}
case 182:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=183;continue;}
case 183:{f.StackOp("dup");f.Pc=184;continue;}
case 184:{f.Push(JValue.I(2));f.Pc=185;continue;}
case 185:{f.Push(JValue.R(rt.String("Warrior")));f.Pc=187;continue;}
case 187:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=188;continue;}
case 188:{f.StackOp("dup");f.Pc=189;continue;}
case 189:{f.Push(JValue.I(3));f.Pc=190;continue;}
case 190:{f.Push(JValue.R(rt.String("Wizard")));f.Pc=192;continue;}
case 192:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=193;continue;}
case 193:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","([Ljava/lang/Object;)Ljava/util/HashSet;","invokestatic",196);}
case 196:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","PARTY_TYPES","Ljava/util/Set;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$Constant","PARTY_TYPES","Ljava/util/Set;",f.Pop());f.Pc=199;continue;}
case 199:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
