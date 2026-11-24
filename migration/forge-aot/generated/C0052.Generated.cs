// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C52{
internal static JClass Build(){var c=new JClass("forge/card/CardType$CoreType","java/lang/Enum",new string[]{"forge/util/ITranslatable"},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("Kindred","Lforge/card/CardType$CoreType;",true,JValue.Default("Lforge/card/CardType$CoreType;"),null));
c.Add(new JField("Artifact","Lforge/card/CardType$CoreType;",true,JValue.Default("Lforge/card/CardType$CoreType;"),null));
c.Add(new JField("Battle","Lforge/card/CardType$CoreType;",true,JValue.Default("Lforge/card/CardType$CoreType;"),null));
c.Add(new JField("Conspiracy","Lforge/card/CardType$CoreType;",true,JValue.Default("Lforge/card/CardType$CoreType;"),null));
c.Add(new JField("Enchantment","Lforge/card/CardType$CoreType;",true,JValue.Default("Lforge/card/CardType$CoreType;"),null));
c.Add(new JField("Creature","Lforge/card/CardType$CoreType;",true,JValue.Default("Lforge/card/CardType$CoreType;"),null));
c.Add(new JField("Dungeon","Lforge/card/CardType$CoreType;",true,JValue.Default("Lforge/card/CardType$CoreType;"),null));
c.Add(new JField("Instant","Lforge/card/CardType$CoreType;",true,JValue.Default("Lforge/card/CardType$CoreType;"),null));
c.Add(new JField("Land","Lforge/card/CardType$CoreType;",true,JValue.Default("Lforge/card/CardType$CoreType;"),null));
c.Add(new JField("Phenomenon","Lforge/card/CardType$CoreType;",true,JValue.Default("Lforge/card/CardType$CoreType;"),null));
c.Add(new JField("Plane","Lforge/card/CardType$CoreType;",true,JValue.Default("Lforge/card/CardType$CoreType;"),null));
c.Add(new JField("Planeswalker","Lforge/card/CardType$CoreType;",true,JValue.Default("Lforge/card/CardType$CoreType;"),null));
c.Add(new JField("Scheme","Lforge/card/CardType$CoreType;",true,JValue.Default("Lforge/card/CardType$CoreType;"),null));
c.Add(new JField("Sorcery","Lforge/card/CardType$CoreType;",true,JValue.Default("Lforge/card/CardType$CoreType;"),null));
c.Add(new JField("Stickers","Lforge/card/CardType$CoreType;",true,JValue.Default("Lforge/card/CardType$CoreType;"),null));
c.Add(new JField("Vanguard","Lforge/card/CardType$CoreType;",true,JValue.Default("Lforge/card/CardType$CoreType;"),null));
c.Add(new JField("isPermanent","Z",false,JValue.Default("Z"),null));
c.Add(new JField("pluralName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("label","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("stringToCoreType","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("allCoreTypeNames","Ljava/util/Set;",true,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("spellTypes","Ljava/util/Set;",true,JValue.Default("Ljava/util/Set;"),null));
c.Add(new JField("$VALUES","[Lforge/card/CardType$CoreType;",true,JValue.Default("[Lforge/card/CardType$CoreType;"),null));
c.Add(new JMethod(897,"forge/card/CardType$CoreType","values","()[Lforge/card/CardType$CoreType;",9,0,1,new JHandler[]{},M897));
c.Add(new JMethod(898,"forge/card/CardType$CoreType","valueOf","(Ljava/lang/String;)Lforge/card/CardType$CoreType;",9,1,2,new JHandler[]{},M898));
c.Add(new JMethod(899,"forge/card/CardType$CoreType","getEnum","(Ljava/lang/String;)Lforge/card/CardType$CoreType;",9,1,2,new JHandler[]{},M899));
c.Add(new JMethod(900,"forge/card/CardType$CoreType","isValidEnum","(Ljava/lang/String;)Z",9,1,2,new JHandler[]{},M900));
c.Add(new JMethod(901,"forge/card/CardType$CoreType","<init>","(Ljava/lang/String;IZLjava/lang/String;Ljava/lang/String;)V",2,6,3,new JHandler[]{},M901));
c.Add(new JMethod(902,"forge/card/CardType$CoreType","toGamePieceType","()Lforge/card/GamePieceType;",1,1,2,new JHandler[]{},M902));
c.Add(new JMethod(903,"forge/card/CardType$CoreType","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M903));
c.Add(new JMethod(904,"forge/card/CardType$CoreType","getTranslatedName","()Ljava/lang/String;",1,1,3,new JHandler[]{},M904));
c.Add(new JMethod(905,"forge/card/CardType$CoreType","$values","()[Lforge/card/CardType$CoreType;",4106,0,4,new JHandler[]{},M905));
c.Add(new JMethod(906,"forge/card/CardType$CoreType","<clinit>","()V",8,0,7,new JHandler[]{},M906));
}

internal static JStep M897(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","$VALUES","[Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","$VALUES","[Lforge/card/CardType$CoreType;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/card/CardType$CoreType;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/card/CardType$CoreType;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M898(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/CardType$CoreType")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$CoreType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M899(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","stringToCoreType","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","stringToCoreType","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$CoreType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M900(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","stringToCoreType","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","stringToCoreType","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M901(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType$CoreType","isPermanent","Z",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType$CoreType","pluralName","Ljava/lang/String;",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardType$CoreType","label","Ljava/lang/String;",value);f.Pc=23;continue;}
case 23:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M902(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardType$1","$SwitchMap$forge$card$CardType$CoreType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$1","$SwitchMap$forge$card$CardType$CoreType","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/card/CardType$CoreType","ordinal","()I","invokevirtual",7);}
case 7:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8;continue;}
case 8:{switch(f.Pop().Int){case 1:f.Pc=48;break;case 2:f.Pc=48;break;case 3:f.Pc=54;break;case 4:f.Pc=60;break;case 5:f.Pc=66;break;case 6:f.Pc=72;break;default:f.Pc=78;break;}continue;}
case 48:{if(!rt.StaticReady(f,"forge/card/GamePieceType","PLANAR","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","PLANAR","Lforge/card/GamePieceType;"));f.Pc=51;continue;}
case 51:{f.Pc=81;continue;}
case 54:{if(!rt.StaticReady(f,"forge/card/GamePieceType","SCHEME","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","SCHEME","Lforge/card/GamePieceType;"));f.Pc=57;continue;}
case 57:{f.Pc=81;continue;}
case 60:{if(!rt.StaticReady(f,"forge/card/GamePieceType","DUNGEON","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","DUNGEON","Lforge/card/GamePieceType;"));f.Pc=63;continue;}
case 63:{f.Pc=81;continue;}
case 66:{if(!rt.StaticReady(f,"forge/card/GamePieceType","STICKER_SHEET","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","STICKER_SHEET","Lforge/card/GamePieceType;"));f.Pc=69;continue;}
case 69:{f.Pc=81;continue;}
case 72:{if(!rt.StaticReady(f,"forge/card/GamePieceType","AVATAR","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","AVATAR","Lforge/card/GamePieceType;"));f.Pc=75;continue;}
case 75:{f.Pc=81;continue;}
case 78:{if(!rt.StaticReady(f,"forge/card/GamePieceType","CARD","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","CARD","Lforge/card/GamePieceType;"));f.Pc=81;continue;}
case 81:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M903(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardType$CoreType","name","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M904(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/card/CardType$CoreType","label","Ljava/lang/String;"));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M905(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(16));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/card/CardType$CoreType;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Kindred","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Kindred","Lforge/card/CardType$CoreType;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Artifact","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Artifact","Lforge/card/CardType$CoreType;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Battle","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Battle","Lforge/card/CardType$CoreType;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Conspiracy","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Conspiracy","Lforge/card/CardType$CoreType;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Enchantment","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Enchantment","Lforge/card/CardType$CoreType;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Creature","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Creature","Lforge/card/CardType$CoreType;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Dungeon","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Dungeon","Lforge/card/CardType$CoreType;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Instant","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Instant","Lforge/card/CardType$CoreType;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Land","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Land","Lforge/card/CardType$CoreType;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Phenomenon","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Phenomenon","Lforge/card/CardType$CoreType;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Plane","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Plane","Lforge/card/CardType$CoreType;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(11));f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Planeswalker","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Planeswalker","Lforge/card/CardType$CoreType;"));f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(12));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Scheme","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Scheme","Lforge/card/CardType$CoreType;"));f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(13));f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Sorcery","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Sorcery","Lforge/card/CardType$CoreType;"));f.Pc=96;continue;}
case 96:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(JValue.I(14));f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Stickers","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Stickers","Lforge/card/CardType$CoreType;"));f.Pc=103;continue;}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{f.StackOp("dup");f.Pc=105;continue;}
case 105:{f.Push(JValue.I(15));f.Pc=107;continue;}
case 107:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Vanguard","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Vanguard","Lforge/card/CardType$CoreType;"));f.Pc=110;continue;}
case 110:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=111;continue;}
case 111:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M906(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardType$CoreType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$CoreType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Kindred")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("kindreds")));f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.String("lblKindred")));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/card/CardType$CoreType","<init>","(Ljava/lang/String;IZLjava/lang/String;Ljava/lang/String;)V","invokespecial",15);}
case 15:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Kindred","Lforge/card/CardType$CoreType;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","Kindred","Lforge/card/CardType$CoreType;",f.Pop());f.Pc=18;continue;}
case 18:{if(!rt.EnsureInitialized(f,"forge/card/CardType$CoreType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$CoreType")));f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("Artifact")));f.Pc=24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Push(JValue.I(1));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("artifacts")));f.Pc=28;continue;}
case 28:{f.Push(JValue.R(rt.String("lblArtifact")));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/card/CardType$CoreType","<init>","(Ljava/lang/String;IZLjava/lang/String;Ljava/lang/String;)V","invokespecial",33);}
case 33:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Artifact","Lforge/card/CardType$CoreType;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","Artifact","Lforge/card/CardType$CoreType;",f.Pop());f.Pc=36;continue;}
case 36:{if(!rt.EnsureInitialized(f,"forge/card/CardType$CoreType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$CoreType")));f.Pc=39;continue;}
case 39:{f.StackOp("dup");f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("Battle")));f.Pc=42;continue;}
case 42:{f.Push(JValue.I(2));f.Pc=43;continue;}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{f.Push(JValue.R(rt.String("battles")));f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("lblBattle")));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/card/CardType$CoreType","<init>","(Ljava/lang/String;IZLjava/lang/String;Ljava/lang/String;)V","invokespecial",51);}
case 51:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Battle","Lforge/card/CardType$CoreType;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","Battle","Lforge/card/CardType$CoreType;",f.Pop());f.Pc=54;continue;}
case 54:{if(!rt.EnsureInitialized(f,"forge/card/CardType$CoreType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$CoreType")));f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("Conspiracy")));f.Pc=60;continue;}
case 60:{f.Push(JValue.I(3));f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{f.Push(JValue.R(rt.String("conspiracies")));f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.String("lblConspiracy")));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/card/CardType$CoreType","<init>","(Ljava/lang/String;IZLjava/lang/String;Ljava/lang/String;)V","invokespecial",69);}
case 69:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Conspiracy","Lforge/card/CardType$CoreType;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","Conspiracy","Lforge/card/CardType$CoreType;",f.Pop());f.Pc=72;continue;}
case 72:{if(!rt.EnsureInitialized(f,"forge/card/CardType$CoreType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$CoreType")));f.Pc=75;continue;}
case 75:{f.StackOp("dup");f.Pc=76;continue;}
case 76:{f.Push(JValue.R(rt.String("Enchantment")));f.Pc=78;continue;}
case 78:{f.Push(JValue.I(4));f.Pc=79;continue;}
case 79:{f.Push(JValue.I(1));f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("enchantments")));f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("lblEnchantment")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/card/CardType$CoreType","<init>","(Ljava/lang/String;IZLjava/lang/String;Ljava/lang/String;)V","invokespecial",87);}
case 87:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Enchantment","Lforge/card/CardType$CoreType;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","Enchantment","Lforge/card/CardType$CoreType;",f.Pop());f.Pc=90;continue;}
case 90:{if(!rt.EnsureInitialized(f,"forge/card/CardType$CoreType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$CoreType")));f.Pc=93;continue;}
case 93:{f.StackOp("dup");f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String("Creature")));f.Pc=96;continue;}
case 96:{f.Push(JValue.I(5));f.Pc=97;continue;}
case 97:{f.Push(JValue.I(1));f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("creatures")));f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.String("lblCreature")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/card/CardType$CoreType","<init>","(Ljava/lang/String;IZLjava/lang/String;Ljava/lang/String;)V","invokespecial",105);}
case 105:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Creature","Lforge/card/CardType$CoreType;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","Creature","Lforge/card/CardType$CoreType;",f.Pop());f.Pc=108;continue;}
case 108:{if(!rt.EnsureInitialized(f,"forge/card/CardType$CoreType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$CoreType")));f.Pc=111;continue;}
case 111:{f.StackOp("dup");f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("Dungeon")));f.Pc=114;continue;}
case 114:{f.Push(JValue.I(6));f.Pc=116;continue;}
case 116:{f.Push(JValue.I(0));f.Pc=117;continue;}
case 117:{f.Push(JValue.R(rt.String("dungeons")));f.Pc=119;continue;}
case 119:{f.Push(JValue.R(rt.String("lblDungeon")));f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/card/CardType$CoreType","<init>","(Ljava/lang/String;IZLjava/lang/String;Ljava/lang/String;)V","invokespecial",124);}
case 124:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Dungeon","Lforge/card/CardType$CoreType;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","Dungeon","Lforge/card/CardType$CoreType;",f.Pop());f.Pc=127;continue;}
case 127:{if(!rt.EnsureInitialized(f,"forge/card/CardType$CoreType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$CoreType")));f.Pc=130;continue;}
case 130:{f.StackOp("dup");f.Pc=131;continue;}
case 131:{f.Push(JValue.R(rt.String("Instant")));f.Pc=133;continue;}
case 133:{f.Push(JValue.I(7));f.Pc=135;continue;}
case 135:{f.Push(JValue.I(0));f.Pc=136;continue;}
case 136:{f.Push(JValue.R(rt.String("instants")));f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("lblInstant")));f.Pc=140;continue;}
case 140:{return rt.Call(f,"forge/card/CardType$CoreType","<init>","(Ljava/lang/String;IZLjava/lang/String;Ljava/lang/String;)V","invokespecial",143);}
case 143:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Instant","Lforge/card/CardType$CoreType;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","Instant","Lforge/card/CardType$CoreType;",f.Pop());f.Pc=146;continue;}
case 146:{if(!rt.EnsureInitialized(f,"forge/card/CardType$CoreType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$CoreType")));f.Pc=149;continue;}
case 149:{f.StackOp("dup");f.Pc=150;continue;}
case 150:{f.Push(JValue.R(rt.String("Land")));f.Pc=152;continue;}
case 152:{f.Push(JValue.I(8));f.Pc=154;continue;}
case 154:{f.Push(JValue.I(1));f.Pc=155;continue;}
case 155:{f.Push(JValue.R(rt.String("lands")));f.Pc=157;continue;}
case 157:{f.Push(JValue.R(rt.String("lblLand")));f.Pc=159;continue;}
case 159:{return rt.Call(f,"forge/card/CardType$CoreType","<init>","(Ljava/lang/String;IZLjava/lang/String;Ljava/lang/String;)V","invokespecial",162);}
case 162:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Land","Lforge/card/CardType$CoreType;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","Land","Lforge/card/CardType$CoreType;",f.Pop());f.Pc=165;continue;}
case 165:{if(!rt.EnsureInitialized(f,"forge/card/CardType$CoreType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$CoreType")));f.Pc=168;continue;}
case 168:{f.StackOp("dup");f.Pc=169;continue;}
case 169:{f.Push(JValue.R(rt.String("Phenomenon")));f.Pc=171;continue;}
case 171:{f.Push(JValue.I(9));f.Pc=173;continue;}
case 173:{f.Push(JValue.I(0));f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("phenomenons")));f.Pc=176;continue;}
case 176:{f.Push(JValue.R(rt.String("lblPhenomenon")));f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/card/CardType$CoreType","<init>","(Ljava/lang/String;IZLjava/lang/String;Ljava/lang/String;)V","invokespecial",181);}
case 181:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Phenomenon","Lforge/card/CardType$CoreType;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","Phenomenon","Lforge/card/CardType$CoreType;",f.Pop());f.Pc=184;continue;}
case 184:{if(!rt.EnsureInitialized(f,"forge/card/CardType$CoreType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$CoreType")));f.Pc=187;continue;}
case 187:{f.StackOp("dup");f.Pc=188;continue;}
case 188:{f.Push(JValue.R(rt.String("Plane")));f.Pc=190;continue;}
case 190:{f.Push(JValue.I(10));f.Pc=192;continue;}
case 192:{f.Push(JValue.I(0));f.Pc=193;continue;}
case 193:{f.Push(JValue.R(rt.String("planes")));f.Pc=195;continue;}
case 195:{f.Push(JValue.R(rt.String("lblPlane")));f.Pc=197;continue;}
case 197:{return rt.Call(f,"forge/card/CardType$CoreType","<init>","(Ljava/lang/String;IZLjava/lang/String;Ljava/lang/String;)V","invokespecial",200);}
case 200:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Plane","Lforge/card/CardType$CoreType;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","Plane","Lforge/card/CardType$CoreType;",f.Pop());f.Pc=203;continue;}
case 203:{if(!rt.EnsureInitialized(f,"forge/card/CardType$CoreType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$CoreType")));f.Pc=206;continue;}
case 206:{f.StackOp("dup");f.Pc=207;continue;}
case 207:{f.Push(JValue.R(rt.String("Planeswalker")));f.Pc=209;continue;}
case 209:{f.Push(JValue.I(11));f.Pc=211;continue;}
case 211:{f.Push(JValue.I(1));f.Pc=212;continue;}
case 212:{f.Push(JValue.R(rt.String("planeswalkers")));f.Pc=214;continue;}
case 214:{f.Push(JValue.R(rt.String("lblPlaneswalker")));f.Pc=216;continue;}
case 216:{return rt.Call(f,"forge/card/CardType$CoreType","<init>","(Ljava/lang/String;IZLjava/lang/String;Ljava/lang/String;)V","invokespecial",219);}
case 219:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Planeswalker","Lforge/card/CardType$CoreType;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","Planeswalker","Lforge/card/CardType$CoreType;",f.Pop());f.Pc=222;continue;}
case 222:{if(!rt.EnsureInitialized(f,"forge/card/CardType$CoreType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$CoreType")));f.Pc=225;continue;}
case 225:{f.StackOp("dup");f.Pc=226;continue;}
case 226:{f.Push(JValue.R(rt.String("Scheme")));f.Pc=228;continue;}
case 228:{f.Push(JValue.I(12));f.Pc=230;continue;}
case 230:{f.Push(JValue.I(0));f.Pc=231;continue;}
case 231:{f.Push(JValue.R(rt.String("schemes")));f.Pc=233;continue;}
case 233:{f.Push(JValue.R(rt.String("lblScheme")));f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/card/CardType$CoreType","<init>","(Ljava/lang/String;IZLjava/lang/String;Ljava/lang/String;)V","invokespecial",238);}
case 238:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Scheme","Lforge/card/CardType$CoreType;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","Scheme","Lforge/card/CardType$CoreType;",f.Pop());f.Pc=241;continue;}
case 241:{if(!rt.EnsureInitialized(f,"forge/card/CardType$CoreType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$CoreType")));f.Pc=244;continue;}
case 244:{f.StackOp("dup");f.Pc=245;continue;}
case 245:{f.Push(JValue.R(rt.String("Sorcery")));f.Pc=247;continue;}
case 247:{f.Push(JValue.I(13));f.Pc=249;continue;}
case 249:{f.Push(JValue.I(0));f.Pc=250;continue;}
case 250:{f.Push(JValue.R(rt.String("sorceries")));f.Pc=252;continue;}
case 252:{f.Push(JValue.R(rt.String("lblSorcery")));f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/card/CardType$CoreType","<init>","(Ljava/lang/String;IZLjava/lang/String;Ljava/lang/String;)V","invokespecial",257);}
case 257:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Sorcery","Lforge/card/CardType$CoreType;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","Sorcery","Lforge/card/CardType$CoreType;",f.Pop());f.Pc=260;continue;}
case 260:{if(!rt.EnsureInitialized(f,"forge/card/CardType$CoreType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$CoreType")));f.Pc=263;continue;}
case 263:{f.StackOp("dup");f.Pc=264;continue;}
case 264:{f.Push(JValue.R(rt.String("Stickers")));f.Pc=266;continue;}
case 266:{f.Push(JValue.I(14));f.Pc=268;continue;}
case 268:{f.Push(JValue.I(0));f.Pc=269;continue;}
case 269:{f.Push(JValue.R(rt.String("stickers")));f.Pc=271;continue;}
case 271:{f.Push(JValue.R(rt.String("lblStickers")));f.Pc=273;continue;}
case 273:{return rt.Call(f,"forge/card/CardType$CoreType","<init>","(Ljava/lang/String;IZLjava/lang/String;Ljava/lang/String;)V","invokespecial",276);}
case 276:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Stickers","Lforge/card/CardType$CoreType;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","Stickers","Lforge/card/CardType$CoreType;",f.Pop());f.Pc=279;continue;}
case 279:{if(!rt.EnsureInitialized(f,"forge/card/CardType$CoreType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType$CoreType")));f.Pc=282;continue;}
case 282:{f.StackOp("dup");f.Pc=283;continue;}
case 283:{f.Push(JValue.R(rt.String("Vanguard")));f.Pc=285;continue;}
case 285:{f.Push(JValue.I(15));f.Pc=287;continue;}
case 287:{f.Push(JValue.I(0));f.Pc=288;continue;}
case 288:{f.Push(JValue.R(rt.String("vanguards")));f.Pc=290;continue;}
case 290:{f.Push(JValue.R(rt.String("lblVanguard")));f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/card/CardType$CoreType","<init>","(Ljava/lang/String;IZLjava/lang/String;Ljava/lang/String;)V","invokespecial",295);}
case 295:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Vanguard","Lforge/card/CardType$CoreType;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","Vanguard","Lforge/card/CardType$CoreType;",f.Pop());f.Pc=298;continue;}
case 298:{return rt.Call(f,"forge/card/CardType$CoreType","$values","()[Lforge/card/CardType$CoreType;","invokestatic",301);}
case 301:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","$VALUES","[Lforge/card/CardType$CoreType;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","$VALUES","[Lforge/card/CardType$CoreType;",f.Pop());f.Pc=304;continue;}
case 304:{f.Push(JValue.R(rt.ClassObject("forge/card/CardType$CoreType")));f.Pc=306;continue;}
case 306:{return rt.Call(f,"org/apache/commons/lang3/EnumUtils","getEnumMap","(Ljava/lang/Class;)Ljava/util/Map;","invokestatic",309);}
case 309:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","stringToCoreType","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","stringToCoreType","Ljava/util/Map;",f.Pop());f.Pc=312;continue;}
case 312:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","stringToCoreType","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","stringToCoreType","Ljava/util/Map;"));f.Pc=315;continue;}
case 315:{return rt.Call(f,"java/util/Map","keySet","()Ljava/util/Set;","invokeinterface",320);}
case 320:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","allCoreTypeNames","Ljava/util/Set;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","allCoreTypeNames","Ljava/util/Set;",f.Pop());f.Pc=323;continue;}
case 323:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Instant","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Instant","Lforge/card/CardType$CoreType;"));f.Pc=326;continue;}
case 326:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","Sorcery","Lforge/card/CardType$CoreType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$CoreType","Sorcery","Lforge/card/CardType$CoreType;"));f.Pc=329;continue;}
case 329:{return rt.Call(f,"com/google/common/collect/ImmutableSet","of","(Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSet;","invokestatic",332);}
case 332:{if(!rt.StaticReady(f,"forge/card/CardType$CoreType","spellTypes","Ljava/util/Set;"))return JStep.Continue;rt.PutStatic("forge/card/CardType$CoreType","spellTypes","Ljava/util/Set;",f.Pop());f.Pc=335;continue;}
case 335:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
