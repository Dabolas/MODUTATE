// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C793{
internal static JClass Build(){var c=new JClass("forge/game/spellability/AlternativeCost","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("Awaken","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("BeamMeUp","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Bestow","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Blitz","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Dash","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Disturb","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Emerge","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Escape","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Evoke","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Flashback","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Harmonize","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Foretold","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Freerunning","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Impending","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Madness","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Mayhem","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("MTMtE","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Mutate","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Overload","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Prowl","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Plotted","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Sneak","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Spectacle","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Surge","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("Warp","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("WebSlinging","Lforge/game/spellability/AlternativeCost;",true,JValue.Default("Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JField("$VALUES","[Lforge/game/spellability/AlternativeCost;",true,JValue.Default("[Lforge/game/spellability/AlternativeCost;"),null));
c.Add(new JMethod(9145,"forge/game/spellability/AlternativeCost","values","()[Lforge/game/spellability/AlternativeCost;",9,0,1,new JHandler[]{},M9145));
c.Add(new JMethod(9146,"forge/game/spellability/AlternativeCost","valueOf","(Ljava/lang/String;)Lforge/game/spellability/AlternativeCost;",9,1,2,new JHandler[]{},M9146));
c.Add(new JMethod(9147,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M9147));
c.Add(new JMethod(9148,"forge/game/spellability/AlternativeCost","$values","()[Lforge/game/spellability/AlternativeCost;",4106,0,4,new JHandler[]{},M9148));
c.Add(new JMethod(9149,"forge/game/spellability/AlternativeCost","<clinit>","()V",8,0,4,new JHandler[]{},M9149));
}

internal static JStep M9145(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","$VALUES","[Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","$VALUES","[Lforge/game/spellability/AlternativeCost;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/game/spellability/AlternativeCost;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/spellability/AlternativeCost;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9146(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/spellability/AlternativeCost")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AlternativeCost"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9147(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9148(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(26));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/game/spellability/AlternativeCost;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Awaken","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Awaken","Lforge/game/spellability/AlternativeCost;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","BeamMeUp","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","BeamMeUp","Lforge/game/spellability/AlternativeCost;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Bestow","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Bestow","Lforge/game/spellability/AlternativeCost;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Blitz","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Blitz","Lforge/game/spellability/AlternativeCost;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Dash","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Dash","Lforge/game/spellability/AlternativeCost;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Disturb","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Disturb","Lforge/game/spellability/AlternativeCost;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Emerge","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Emerge","Lforge/game/spellability/AlternativeCost;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Escape","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Escape","Lforge/game/spellability/AlternativeCost;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Evoke","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Evoke","Lforge/game/spellability/AlternativeCost;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Flashback","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Flashback","Lforge/game/spellability/AlternativeCost;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Harmonize","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Harmonize","Lforge/game/spellability/AlternativeCost;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(11));f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Foretold","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Foretold","Lforge/game/spellability/AlternativeCost;"));f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(12));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Freerunning","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Freerunning","Lforge/game/spellability/AlternativeCost;"));f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(13));f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Impending","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Impending","Lforge/game/spellability/AlternativeCost;"));f.Pc=96;continue;}
case 96:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(JValue.I(14));f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Madness","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Madness","Lforge/game/spellability/AlternativeCost;"));f.Pc=103;continue;}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{f.StackOp("dup");f.Pc=105;continue;}
case 105:{f.Push(JValue.I(15));f.Pc=107;continue;}
case 107:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Mayhem","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Mayhem","Lforge/game/spellability/AlternativeCost;"));f.Pc=110;continue;}
case 110:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=111;continue;}
case 111:{f.StackOp("dup");f.Pc=112;continue;}
case 112:{f.Push(JValue.I(16));f.Pc=114;continue;}
case 114:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","MTMtE","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","MTMtE","Lforge/game/spellability/AlternativeCost;"));f.Pc=117;continue;}
case 117:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{f.Push(JValue.I(17));f.Pc=121;continue;}
case 121:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Mutate","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Mutate","Lforge/game/spellability/AlternativeCost;"));f.Pc=124;continue;}
case 124:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=125;continue;}
case 125:{f.StackOp("dup");f.Pc=126;continue;}
case 126:{f.Push(JValue.I(18));f.Pc=128;continue;}
case 128:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Overload","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Overload","Lforge/game/spellability/AlternativeCost;"));f.Pc=131;continue;}
case 131:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=132;continue;}
case 132:{f.StackOp("dup");f.Pc=133;continue;}
case 133:{f.Push(JValue.I(19));f.Pc=135;continue;}
case 135:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Prowl","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Prowl","Lforge/game/spellability/AlternativeCost;"));f.Pc=138;continue;}
case 138:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=139;continue;}
case 139:{f.StackOp("dup");f.Pc=140;continue;}
case 140:{f.Push(JValue.I(20));f.Pc=142;continue;}
case 142:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Plotted","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Plotted","Lforge/game/spellability/AlternativeCost;"));f.Pc=145;continue;}
case 145:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=146;continue;}
case 146:{f.StackOp("dup");f.Pc=147;continue;}
case 147:{f.Push(JValue.I(21));f.Pc=149;continue;}
case 149:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Sneak","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Sneak","Lforge/game/spellability/AlternativeCost;"));f.Pc=152;continue;}
case 152:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=153;continue;}
case 153:{f.StackOp("dup");f.Pc=154;continue;}
case 154:{f.Push(JValue.I(22));f.Pc=156;continue;}
case 156:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Spectacle","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Spectacle","Lforge/game/spellability/AlternativeCost;"));f.Pc=159;continue;}
case 159:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=160;continue;}
case 160:{f.StackOp("dup");f.Pc=161;continue;}
case 161:{f.Push(JValue.I(23));f.Pc=163;continue;}
case 163:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Surge","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Surge","Lforge/game/spellability/AlternativeCost;"));f.Pc=166;continue;}
case 166:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=167;continue;}
case 167:{f.StackOp("dup");f.Pc=168;continue;}
case 168:{f.Push(JValue.I(24));f.Pc=170;continue;}
case 170:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Warp","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","Warp","Lforge/game/spellability/AlternativeCost;"));f.Pc=173;continue;}
case 173:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=174;continue;}
case 174:{f.StackOp("dup");f.Pc=175;continue;}
case 175:{f.Push(JValue.I(25));f.Pc=177;continue;}
case 177:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","WebSlinging","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/spellability/AlternativeCost","WebSlinging","Lforge/game/spellability/AlternativeCost;"));f.Pc=180;continue;}
case 180:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=181;continue;}
case 181:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M9149(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Awaken")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Awaken","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Awaken","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("BeamMeUp")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","BeamMeUp","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","BeamMeUp","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("Bestow")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Bestow","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Bestow","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("Blitz")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",49);}
case 49:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Blitz","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Blitz","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=52;continue;}
case 52:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("Dash")));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(4));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",62);}
case 62:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Dash","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Dash","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=65;continue;}
case 65:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("Disturb")));f.Pc=71;continue;}
case 71:{f.Push(JValue.I(5));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",75);}
case 75:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Disturb","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Disturb","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=78;continue;}
case 78:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("Emerge")));f.Pc=84;continue;}
case 84:{f.Push(JValue.I(6));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",89);}
case 89:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Emerge","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Emerge","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=92;continue;}
case 92:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=95;continue;}
case 95:{f.StackOp("dup");f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("Escape")));f.Pc=98;continue;}
case 98:{f.Push(JValue.I(7));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",103);}
case 103:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Escape","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Escape","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=106;continue;}
case 106:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=109;continue;}
case 109:{f.StackOp("dup");f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("Evoke")));f.Pc=112;continue;}
case 112:{f.Push(JValue.I(8));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",117);}
case 117:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Evoke","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Evoke","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=120;continue;}
case 120:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=123;continue;}
case 123:{f.StackOp("dup");f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("Flashback")));f.Pc=126;continue;}
case 126:{f.Push(JValue.I(9));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",131);}
case 131:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Flashback","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Flashback","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=134;continue;}
case 134:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=137;continue;}
case 137:{f.StackOp("dup");f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("Harmonize")));f.Pc=140;continue;}
case 140:{f.Push(JValue.I(10));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",145);}
case 145:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Harmonize","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Harmonize","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=148;continue;}
case 148:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=151;continue;}
case 151:{f.StackOp("dup");f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String("Foretold")));f.Pc=154;continue;}
case 154:{f.Push(JValue.I(11));f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",159);}
case 159:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Foretold","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Foretold","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=162;continue;}
case 162:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=165;continue;}
case 165:{f.StackOp("dup");f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("Freerunning")));f.Pc=168;continue;}
case 168:{f.Push(JValue.I(12));f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",173);}
case 173:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Freerunning","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Freerunning","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=176;continue;}
case 176:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=179;continue;}
case 179:{f.StackOp("dup");f.Pc=180;continue;}
case 180:{f.Push(JValue.R(rt.String("Impending")));f.Pc=182;continue;}
case 182:{f.Push(JValue.I(13));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",187);}
case 187:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Impending","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Impending","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=190;continue;}
case 190:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=193;continue;}
case 193:{f.StackOp("dup");f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.String("Madness")));f.Pc=196;continue;}
case 196:{f.Push(JValue.I(14));f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",201);}
case 201:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Madness","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Madness","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=204;continue;}
case 204:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=207;continue;}
case 207:{f.StackOp("dup");f.Pc=208;continue;}
case 208:{f.Push(JValue.R(rt.String("Mayhem")));f.Pc=210;continue;}
case 210:{f.Push(JValue.I(15));f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",215);}
case 215:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Mayhem","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Mayhem","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=218;continue;}
case 218:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=221;continue;}
case 221:{f.StackOp("dup");f.Pc=222;continue;}
case 222:{f.Push(JValue.R(rt.String("MTMtE")));f.Pc=224;continue;}
case 224:{f.Push(JValue.I(16));f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",229);}
case 229:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","MTMtE","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","MTMtE","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=232;continue;}
case 232:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=235;continue;}
case 235:{f.StackOp("dup");f.Pc=236;continue;}
case 236:{f.Push(JValue.R(rt.String("Mutate")));f.Pc=238;continue;}
case 238:{f.Push(JValue.I(17));f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",243);}
case 243:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Mutate","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Mutate","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=246;continue;}
case 246:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=249;continue;}
case 249:{f.StackOp("dup");f.Pc=250;continue;}
case 250:{f.Push(JValue.R(rt.String("Overload")));f.Pc=252;continue;}
case 252:{f.Push(JValue.I(18));f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",257);}
case 257:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Overload","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Overload","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=260;continue;}
case 260:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=263;continue;}
case 263:{f.StackOp("dup");f.Pc=264;continue;}
case 264:{f.Push(JValue.R(rt.String("Prowl")));f.Pc=266;continue;}
case 266:{f.Push(JValue.I(19));f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",271);}
case 271:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Prowl","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Prowl","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=274;continue;}
case 274:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=277;continue;}
case 277:{f.StackOp("dup");f.Pc=278;continue;}
case 278:{f.Push(JValue.R(rt.String("Plotted")));f.Pc=280;continue;}
case 280:{f.Push(JValue.I(20));f.Pc=282;continue;}
case 282:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",285);}
case 285:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Plotted","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Plotted","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=288;continue;}
case 288:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=291;continue;}
case 291:{f.StackOp("dup");f.Pc=292;continue;}
case 292:{f.Push(JValue.R(rt.String("Sneak")));f.Pc=294;continue;}
case 294:{f.Push(JValue.I(21));f.Pc=296;continue;}
case 296:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",299);}
case 299:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Sneak","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Sneak","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=302;continue;}
case 302:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=305;continue;}
case 305:{f.StackOp("dup");f.Pc=306;continue;}
case 306:{f.Push(JValue.R(rt.String("Spectacle")));f.Pc=308;continue;}
case 308:{f.Push(JValue.I(22));f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",313);}
case 313:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Spectacle","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Spectacle","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=316;continue;}
case 316:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=319;continue;}
case 319:{f.StackOp("dup");f.Pc=320;continue;}
case 320:{f.Push(JValue.R(rt.String("Surge")));f.Pc=322;continue;}
case 322:{f.Push(JValue.I(23));f.Pc=324;continue;}
case 324:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",327);}
case 327:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Surge","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Surge","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=330;continue;}
case 330:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=333;continue;}
case 333:{f.StackOp("dup");f.Pc=334;continue;}
case 334:{f.Push(JValue.R(rt.String("Warp")));f.Pc=336;continue;}
case 336:{f.Push(JValue.I(24));f.Pc=338;continue;}
case 338:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",341);}
case 341:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","Warp","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","Warp","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=344;continue;}
case 344:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AlternativeCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AlternativeCost")));f.Pc=347;continue;}
case 347:{f.StackOp("dup");f.Pc=348;continue;}
case 348:{f.Push(JValue.R(rt.String("WebSlinging")));f.Pc=350;continue;}
case 350:{f.Push(JValue.I(25));f.Pc=352;continue;}
case 352:{return rt.Call(f,"forge/game/spellability/AlternativeCost","<init>","(Ljava/lang/String;I)V","invokespecial",355);}
case 355:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","WebSlinging","Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","WebSlinging","Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=358;continue;}
case 358:{return rt.Call(f,"forge/game/spellability/AlternativeCost","$values","()[Lforge/game/spellability/AlternativeCost;","invokestatic",361);}
case 361:{if(!rt.StaticReady(f,"forge/game/spellability/AlternativeCost","$VALUES","[Lforge/game/spellability/AlternativeCost;"))return JStep.Continue;rt.PutStatic("forge/game/spellability/AlternativeCost","$VALUES","[Lforge/game/spellability/AlternativeCost;",f.Pop());f.Pc=364;continue;}
case 364:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
