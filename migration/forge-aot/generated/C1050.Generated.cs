// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1050{
internal static JClass Build(){var c=new JClass("forge/game/zone/ZoneType","java/lang/Enum",new string[]{"forge/util/ITranslatable"},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("Hand","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("Library","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("Graveyard","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("Battlefield","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("Exile","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("Flashback","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("Command","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("Stack","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("Sideboard","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("Ante","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("Merged","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("SchemeDeck","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("PlanarDeck","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("AttractionDeck","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("Junkyard","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("ContraptionDeck","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("StickerSheets","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("Subgame","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("ExtraHand","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("None","Lforge/game/zone/ZoneType;",true,JValue.Default("Lforge/game/zone/ZoneType;"),null));
c.Add(new JField("STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;",true,JValue.Default("Ljava/util/EnumSet;"),null));
c.Add(new JField("PART_OF_COMMAND_ZONE","Ljava/util/EnumSet;",true,JValue.Default("Ljava/util/EnumSet;"),null));
c.Add(new JField("DECK_ZONES","Ljava/util/EnumSet;",true,JValue.Default("Ljava/util/EnumSet;"),null));
c.Add(new JField("ORDERED_ZONES","Ljava/util/EnumSet;",true,JValue.Default("Ljava/util/EnumSet;"),null));
c.Add(new JField("holdsHiddenInfo","Z",false,JValue.Default("Z"),null));
c.Add(new JField("label","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("trackableProperty","Lforge/trackable/TrackableProperty;",false,JValue.Default("Lforge/trackable/TrackableProperty;"),null));
c.Add(new JField("$VALUES","[Lforge/game/zone/ZoneType;",true,JValue.Default("[Lforge/game/zone/ZoneType;"),null));
c.Add(new JMethod(11147,"forge/game/zone/ZoneType","values","()[Lforge/game/zone/ZoneType;",9,0,1,new JHandler[]{},M11147));
c.Add(new JMethod(11148,"forge/game/zone/ZoneType","valueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;",9,1,2,new JHandler[]{},M11148));
c.Add(new JMethod(11149,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;)V",2,5,6,new JHandler[]{},M11149));
c.Add(new JMethod(11150,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;Lforge/trackable/TrackableProperty;)V",2,6,3,new JHandler[]{},M11150));
c.Add(new JMethod(11151,"forge/game/zone/ZoneType","getTrackableProperty","()Lforge/trackable/TrackableProperty;",1,1,1,new JHandler[]{},M11151));
c.Add(new JMethod(11152,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;",9,6,3,new JHandler[]{},M11152));
c.Add(new JMethod(11153,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;",9,7,7,new JHandler[]{},M11153));
c.Add(new JMethod(11154,"forge/game/zone/ZoneType","isHidden","()Z",1,1,1,new JHandler[]{},M11154));
c.Add(new JMethod(11155,"forge/game/zone/ZoneType","isKnown","()Z",1,1,1,new JHandler[]{},M11155));
c.Add(new JMethod(11156,"forge/game/zone/ZoneType","isPartOfCommandZone","()Z",1,1,2,new JHandler[]{},M11156));
c.Add(new JMethod(11157,"forge/game/zone/ZoneType","isDeck","()Z",1,1,2,new JHandler[]{},M11157));
c.Add(new JMethod(11158,"forge/game/zone/ZoneType","isOrdered","()Z",1,1,2,new JHandler[]{},M11158));
c.Add(new JMethod(11159,"forge/game/zone/ZoneType","getName","()Ljava/lang/String;",1,1,1,new JHandler[]{},M11159));
c.Add(new JMethod(11160,"forge/game/zone/ZoneType","getTranslatedName","()Ljava/lang/String;",1,1,3,new JHandler[]{},M11160));
c.Add(new JMethod(11161,"forge/game/zone/ZoneType","isHidden","(Ljava/lang/String;)Z",9,4,1,new JHandler[]{},M11161));
c.Add(new JMethod(11162,"forge/game/zone/ZoneType","isKnown","(Ljava/lang/String;)Z",9,1,1,new JHandler[]{},M11162));
c.Add(new JMethod(11163,"forge/game/zone/ZoneType","$values","()[Lforge/game/zone/ZoneType;",4106,0,4,new JHandler[]{},M11163));
c.Add(new JMethod(11164,"forge/game/zone/ZoneType","<clinit>","()V",8,0,7,new JHandler[]{},M11164));
}

internal static JStep M11147(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","$VALUES","[Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","$VALUES","[Lforge/game/zone/ZoneType;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/game/zone/ZoneType;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/zone/ZoneType;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11148(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/zone/ZoneType")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11149(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(null));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;Lforge/trackable/TrackableProperty;)V","invokespecial",10);}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11150(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/ZoneType","holdsHiddenInfo","Z",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/ZoneType","label","Ljava/lang/String;",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/zone/ZoneType","trackableProperty","Lforge/trackable/TrackableProperty;",value);f.Pc=23;continue;}
case 23:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11151(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/ZoneType","trackableProperty","Lforge/trackable/TrackableProperty;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11152(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(JValue.R(rt.String("All")));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",12);}
case 12:{f.Pc=f.Pop().Int==0?17:15;continue;}
case 15:{f.Push(JValue.R(null));f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",21);}
case 21:{f.Locals[1]=f.Pop();f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/zone/ZoneType","values","()[Lforge/game/zone/ZoneType;","invokestatic",25);}
case 25:{f.Locals[2]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[2]);f.Pc=27;continue;}
case 27:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=28;continue;}
case 28:{f.Locals[3]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{f.Locals[4]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?65:38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=42;continue;}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/zone/ZoneType","name","()Ljava/lang/String;","invokevirtual",49);}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/String","compareToIgnoreCase","(Ljava/lang/String;)I","invokevirtual",53);}
case 53:{f.Pc=f.Pop().Int!=0?59:56;continue;}
case 56:{f.Push(f.Locals[5]);f.Pc=58;continue;}
case 58:{return JStep.Return(f.Pop());}
case 59:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=62;continue;}
case 62:{f.Pc=32;continue;}
case 65:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{return rt.DynamicCall(f,"forge/game/zone/ZoneType:11152:70:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",75);}
case 75:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",78);}
case 78:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11153(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("All")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",6);}
case 6:{f.Pc=f.Pop().Int==0?34:9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/List","of","(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;","invokestatic",33);}
case 33:{return JStep.Return(f.Pop());}
case 34:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=37;continue;}
case 37:{f.StackOp("dup");f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",41);}
case 41:{f.Locals[1]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[0]);f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("[, ]+")));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",48);}
case 48:{f.Locals[2]=f.Pop();f.Pc=49;continue;}
case 49:{f.Push(f.Locals[2]);f.Pc=50;continue;}
case 50:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=51;continue;}
case 51:{f.Locals[3]=f.Pop();f.Pc=52;continue;}
case 52:{f.Push(JValue.I(0));f.Pc=53;continue;}
case 53:{f.Locals[4]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(f.Locals[4]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?94:61;continue;}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=65;continue;}
case 65:{f.Locals[5]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[5]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/zone/ZoneType","smartValueOf","(Ljava/lang/String;)Lforge/game/zone/ZoneType;","invokestatic",72);}
case 72:{f.Locals[6]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{f.Pc=f.Pop().Reference==null?88:79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[6]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",87);}
case 87:{f.StackOp("pop");f.Pc=88;continue;}
case 88:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=91;continue;}
case 91:{f.Pc=55;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11154(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/ZoneType","holdsHiddenInfo","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11155(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/ZoneType","holdsHiddenInfo","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11156(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","PART_OF_COMMAND_ZONE","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","PART_OF_COMMAND_ZONE","Ljava/util/EnumSet;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11157(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","DECK_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","DECK_ZONES","Ljava/util/EnumSet;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11158(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","ORDERED_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","ORDERED_ZONES","Ljava/util/EnumSet;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11159(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/zone/ZoneType","name","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11160(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/zone/ZoneType","label","Ljava/lang/String;"));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11161(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/zone/ZoneType","listValueOf","(Ljava/lang/String;)Ljava/util/List;","invokestatic",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",11);}
case 11:{f.Pc=f.Pop().Int==0?16:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?54:32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/zone/ZoneType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[3]=f.Pop();f.Pc=42;continue;}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/zone/ZoneType","isHidden","()Z","invokevirtual",46);}
case 46:{f.Pc=f.Pop().Int==0?51:49;continue;}
case 49:{f.Push(JValue.I(1));f.Pc=50;continue;}
case 50:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 51:{f.Pc=23;continue;}
case 54:{f.Push(JValue.I(0));f.Pc=55;continue;}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11162(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/zone/ZoneType","isHidden","(Ljava/lang/String;)Z","invokestatic",4);}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11163(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(20));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/game/zone/ZoneType;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Flashback","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Flashback","Lforge/game/zone/ZoneType;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Ante","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Ante","Lforge/game/zone/ZoneType;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Merged","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Merged","Lforge/game/zone/ZoneType;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(11));f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"));f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(12));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"));f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(13));f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"));f.Pc=96;continue;}
case 96:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(JValue.I(14));f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Junkyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Junkyard","Lforge/game/zone/ZoneType;"));f.Pc=103;continue;}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{f.StackOp("dup");f.Pc=105;continue;}
case 105:{f.Push(JValue.I(15));f.Pc=107;continue;}
case 107:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"));f.Pc=110;continue;}
case 110:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=111;continue;}
case 111:{f.StackOp("dup");f.Pc=112;continue;}
case 112:{f.Push(JValue.I(16));f.Pc=114;continue;}
case 114:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","StickerSheets","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","StickerSheets","Lforge/game/zone/ZoneType;"));f.Pc=117;continue;}
case 117:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{f.Push(JValue.I(17));f.Pc=121;continue;}
case 121:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Subgame","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Subgame","Lforge/game/zone/ZoneType;"));f.Pc=124;continue;}
case 124:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=125;continue;}
case 125:{f.StackOp("dup");f.Pc=126;continue;}
case 126:{f.Push(JValue.I(18));f.Pc=128;continue;}
case 128:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","ExtraHand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","ExtraHand","Lforge/game/zone/ZoneType;"));f.Pc=131;continue;}
case 131:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=132;continue;}
case 132:{f.StackOp("dup");f.Pc=133;continue;}
case 133:{f.Push(JValue.I(19));f.Pc=135;continue;}
case 135:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"));f.Pc=138;continue;}
case 138:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=139;continue;}
case 139:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11164(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Hand")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("lblHandZone")));f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Hand","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Hand","Lforge/trackable/TrackableProperty;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;Lforge/trackable/TrackableProperty;)V","invokespecial",16);}
case 16:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("Library")));f.Pc=25;continue;}
case 25:{f.Push(JValue.I(1));f.Pc=26;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("lblLibraryZone")));f.Pc=29;continue;}
case 29:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Library","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Library","Lforge/trackable/TrackableProperty;"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;Lforge/trackable/TrackableProperty;)V","invokespecial",35);}
case 35:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=38;continue;}
case 38:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("Graveyard")));f.Pc=44;continue;}
case 44:{f.Push(JValue.I(2));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(0));f.Pc=46;continue;}
case 46:{f.Push(JValue.R(rt.String("lblGraveyardZone")));f.Pc=48;continue;}
case 48:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Graveyard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Graveyard","Lforge/trackable/TrackableProperty;"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;Lforge/trackable/TrackableProperty;)V","invokespecial",54);}
case 54:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=57;continue;}
case 57:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=60;continue;}
case 60:{f.StackOp("dup");f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=63;continue;}
case 63:{f.Push(JValue.I(3));f.Pc=64;continue;}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("lblBattlefieldZone")));f.Pc=67;continue;}
case 67:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Battlefield","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Battlefield","Lforge/trackable/TrackableProperty;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;Lforge/trackable/TrackableProperty;)V","invokespecial",73);}
case 73:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=76;continue;}
case 76:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=79;continue;}
case 79:{f.StackOp("dup");f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("Exile")));f.Pc=82;continue;}
case 82:{f.Push(JValue.I(4));f.Pc=83;continue;}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("lblExileZone")));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Exile","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Exile","Lforge/trackable/TrackableProperty;"));f.Pc=89;continue;}
case 89:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;Lforge/trackable/TrackableProperty;)V","invokespecial",92);}
case 92:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=95;continue;}
case 95:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=98;continue;}
case 98:{f.StackOp("dup");f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("Flashback")));f.Pc=101;continue;}
case 101:{f.Push(JValue.I(5));f.Pc=102;continue;}
case 102:{f.Push(JValue.I(0));f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("lblFlashbackZone")));f.Pc=105;continue;}
case 105:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Flashback","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Flashback","Lforge/trackable/TrackableProperty;"));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;Lforge/trackable/TrackableProperty;)V","invokespecial",111);}
case 111:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Flashback","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","Flashback","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=114;continue;}
case 114:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=117;continue;}
case 117:{f.StackOp("dup");f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("Command")));f.Pc=120;continue;}
case 120:{f.Push(JValue.I(6));f.Pc=122;continue;}
case 122:{f.Push(JValue.I(0));f.Pc=123;continue;}
case 123:{f.Push(JValue.R(rt.String("lblCommandZone")));f.Pc=125;continue;}
case 125:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Command","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Command","Lforge/trackable/TrackableProperty;"));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;Lforge/trackable/TrackableProperty;)V","invokespecial",131);}
case 131:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=134;continue;}
case 134:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=137;continue;}
case 137:{f.StackOp("dup");f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("Stack")));f.Pc=140;continue;}
case 140:{f.Push(JValue.I(7));f.Pc=142;continue;}
case 142:{f.Push(JValue.I(0));f.Pc=143;continue;}
case 143:{f.Push(JValue.R(rt.String("lblStackZone")));f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;)V","invokespecial",148);}
case 148:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=151;continue;}
case 151:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=154;continue;}
case 154:{f.StackOp("dup");f.Pc=155;continue;}
case 155:{f.Push(JValue.R(rt.String("Sideboard")));f.Pc=157;continue;}
case 157:{f.Push(JValue.I(8));f.Pc=159;continue;}
case 159:{f.Push(JValue.I(1));f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("lblSideboardZone")));f.Pc=162;continue;}
case 162:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Sideboard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Sideboard","Lforge/trackable/TrackableProperty;"));f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;Lforge/trackable/TrackableProperty;)V","invokespecial",168);}
case 168:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","Sideboard","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=171;continue;}
case 171:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=174;continue;}
case 174:{f.StackOp("dup");f.Pc=175;continue;}
case 175:{f.Push(JValue.R(rt.String("Ante")));f.Pc=177;continue;}
case 177:{f.Push(JValue.I(9));f.Pc=179;continue;}
case 179:{f.Push(JValue.I(0));f.Pc=180;continue;}
case 180:{f.Push(JValue.R(rt.String("lblAnteZone")));f.Pc=183;continue;}
case 183:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Ante","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Ante","Lforge/trackable/TrackableProperty;"));f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;Lforge/trackable/TrackableProperty;)V","invokespecial",189);}
case 189:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Ante","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","Ante","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=192;continue;}
case 192:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=195;continue;}
case 195:{f.StackOp("dup");f.Pc=196;continue;}
case 196:{f.Push(JValue.R(rt.String("Merged")));f.Pc=199;continue;}
case 199:{f.Push(JValue.I(10));f.Pc=201;continue;}
case 201:{f.Push(JValue.I(0));f.Pc=202;continue;}
case 202:{f.Push(JValue.R(rt.String("lblBattlefieldZone")));f.Pc=204;continue;}
case 204:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;)V","invokespecial",207);}
case 207:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Merged","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","Merged","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=210;continue;}
case 210:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=213;continue;}
case 213:{f.StackOp("dup");f.Pc=214;continue;}
case 214:{f.Push(JValue.R(rt.String("SchemeDeck")));f.Pc=217;continue;}
case 217:{f.Push(JValue.I(11));f.Pc=219;continue;}
case 219:{f.Push(JValue.I(1));f.Pc=220;continue;}
case 220:{f.Push(JValue.R(rt.String("lblSchemeDeckZone")));f.Pc=223;continue;}
case 223:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","SchemeDeck","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","SchemeDeck","Lforge/trackable/TrackableProperty;"));f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;Lforge/trackable/TrackableProperty;)V","invokespecial",229);}
case 229:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=232;continue;}
case 232:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=235;continue;}
case 235:{f.StackOp("dup");f.Pc=236;continue;}
case 236:{f.Push(JValue.R(rt.String("PlanarDeck")));f.Pc=239;continue;}
case 239:{f.Push(JValue.I(12));f.Pc=241;continue;}
case 241:{f.Push(JValue.I(1));f.Pc=242;continue;}
case 242:{f.Push(JValue.R(rt.String("lblPlanarDeckZone")));f.Pc=245;continue;}
case 245:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","PlanarDeck","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","PlanarDeck","Lforge/trackable/TrackableProperty;"));f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;Lforge/trackable/TrackableProperty;)V","invokespecial",251);}
case 251:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=254;continue;}
case 254:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=257;continue;}
case 257:{f.StackOp("dup");f.Pc=258;continue;}
case 258:{f.Push(JValue.R(rt.String("AttractionDeck")));f.Pc=261;continue;}
case 261:{f.Push(JValue.I(13));f.Pc=263;continue;}
case 263:{f.Push(JValue.I(1));f.Pc=264;continue;}
case 264:{f.Push(JValue.R(rt.String("lblAttractionDeckZone")));f.Pc=267;continue;}
case 267:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","AttractionDeck","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","AttractionDeck","Lforge/trackable/TrackableProperty;"));f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;Lforge/trackable/TrackableProperty;)V","invokespecial",273);}
case 273:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=276;continue;}
case 276:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=279;continue;}
case 279:{f.StackOp("dup");f.Pc=280;continue;}
case 280:{f.Push(JValue.R(rt.String("Junkyard")));f.Pc=283;continue;}
case 283:{f.Push(JValue.I(14));f.Pc=285;continue;}
case 285:{f.Push(JValue.I(0));f.Pc=286;continue;}
case 286:{f.Push(JValue.R(rt.String("lblJunkyardZone")));f.Pc=289;continue;}
case 289:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","Junkyard","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","Junkyard","Lforge/trackable/TrackableProperty;"));f.Pc=292;continue;}
case 292:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;Lforge/trackable/TrackableProperty;)V","invokespecial",295);}
case 295:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Junkyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","Junkyard","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=298;continue;}
case 298:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=301;continue;}
case 301:{f.StackOp("dup");f.Pc=302;continue;}
case 302:{f.Push(JValue.R(rt.String("ContraptionDeck")));f.Pc=305;continue;}
case 305:{f.Push(JValue.I(15));f.Pc=307;continue;}
case 307:{f.Push(JValue.I(1));f.Pc=308;continue;}
case 308:{f.Push(JValue.R(rt.String("lblContraptionDeckZone")));f.Pc=311;continue;}
case 311:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","ContraptionDeck","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","ContraptionDeck","Lforge/trackable/TrackableProperty;"));f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;Lforge/trackable/TrackableProperty;)V","invokespecial",317);}
case 317:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=320;continue;}
case 320:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=323;continue;}
case 323:{f.StackOp("dup");f.Pc=324;continue;}
case 324:{f.Push(JValue.R(rt.String("StickerSheets")));f.Pc=327;continue;}
case 327:{f.Push(JValue.I(16));f.Pc=329;continue;}
case 329:{f.Push(JValue.I(0));f.Pc=330;continue;}
case 330:{f.Push(JValue.R(rt.String("lblStickerSheetsZone")));f.Pc=333;continue;}
case 333:{if(!rt.StaticReady(f,"forge/trackable/TrackableProperty","StickerSheets","Lforge/trackable/TrackableProperty;"))return JStep.Continue;f.Push(rt.GetStatic("forge/trackable/TrackableProperty","StickerSheets","Lforge/trackable/TrackableProperty;"));f.Pc=336;continue;}
case 336:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;Lforge/trackable/TrackableProperty;)V","invokespecial",339);}
case 339:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","StickerSheets","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","StickerSheets","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=342;continue;}
case 342:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=345;continue;}
case 345:{f.StackOp("dup");f.Pc=346;continue;}
case 346:{f.Push(JValue.R(rt.String("Subgame")));f.Pc=349;continue;}
case 349:{f.Push(JValue.I(17));f.Pc=351;continue;}
case 351:{f.Push(JValue.I(1));f.Pc=352;continue;}
case 352:{f.Push(JValue.R(rt.String("lblSubgameZone")));f.Pc=355;continue;}
case 355:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;)V","invokespecial",358);}
case 358:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Subgame","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","Subgame","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=361;continue;}
case 361:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=364;continue;}
case 364:{f.StackOp("dup");f.Pc=365;continue;}
case 365:{f.Push(JValue.R(rt.String("ExtraHand")));f.Pc=368;continue;}
case 368:{f.Push(JValue.I(18));f.Pc=370;continue;}
case 370:{f.Push(JValue.I(1));f.Pc=371;continue;}
case 371:{f.Push(JValue.R(rt.String("lblHandZone")));f.Pc=373;continue;}
case 373:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;)V","invokespecial",376);}
case 376:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","ExtraHand","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","ExtraHand","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=379;continue;}
case 379:{if(!rt.EnsureInitialized(f,"forge/game/zone/ZoneType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/zone/ZoneType")));f.Pc=382;continue;}
case 382:{f.StackOp("dup");f.Pc=383;continue;}
case 383:{f.Push(JValue.R(rt.String("None")));f.Pc=386;continue;}
case 386:{f.Push(JValue.I(19));f.Pc=388;continue;}
case 388:{f.Push(JValue.I(1));f.Pc=389;continue;}
case 389:{f.Push(JValue.R(rt.String("lblNoneZone")));f.Pc=392;continue;}
case 392:{return rt.Call(f,"forge/game/zone/ZoneType","<init>","(Ljava/lang/String;IZLjava/lang/String;)V","invokespecial",395);}
case 395:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","None","Lforge/game/zone/ZoneType;",f.Pop());f.Pc=398;continue;}
case 398:{return rt.Call(f,"forge/game/zone/ZoneType","$values","()[Lforge/game/zone/ZoneType;","invokestatic",401);}
case 401:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","$VALUES","[Lforge/game/zone/ZoneType;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","$VALUES","[Lforge/game/zone/ZoneType;",f.Pop());f.Pc=404;continue;}
case 404:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=407;continue;}
case 407:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=410;continue;}
case 410:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Exile","Lforge/game/zone/ZoneType;"));f.Pc=413;continue;}
case 413:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=416;continue;}
case 416:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=419;continue;}
case 419:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",422);}
case 422:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","STATIC_ABILITIES_SOURCE_ZONES","Ljava/util/EnumSet;",f.Pop());f.Pc=425;continue;}
case 425:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Command","Lforge/game/zone/ZoneType;"));f.Pc=428;continue;}
case 428:{f.Push(JValue.I(6));f.Pc=430;continue;}
case 430:{f.Push(JValue.R(rt.NewArray("Lforge/game/zone/ZoneType;",f.Pop().Int)));f.Pc=433;continue;}
case 433:{f.StackOp("dup");f.Pc=434;continue;}
case 434:{f.Push(JValue.I(0));f.Pc=435;continue;}
case 435:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"));f.Pc=438;continue;}
case 438:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=439;continue;}
case 439:{f.StackOp("dup");f.Pc=440;continue;}
case 440:{f.Push(JValue.I(1));f.Pc=441;continue;}
case 441:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"));f.Pc=444;continue;}
case 444:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=445;continue;}
case 445:{f.StackOp("dup");f.Pc=446;continue;}
case 446:{f.Push(JValue.I(2));f.Pc=447;continue;}
case 447:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"));f.Pc=450;continue;}
case 450:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=451;continue;}
case 451:{f.StackOp("dup");f.Pc=452;continue;}
case 452:{f.Push(JValue.I(3));f.Pc=453;continue;}
case 453:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"));f.Pc=456;continue;}
case 456:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=457;continue;}
case 457:{f.StackOp("dup");f.Pc=458;continue;}
case 458:{f.Push(JValue.I(4));f.Pc=459;continue;}
case 459:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Junkyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Junkyard","Lforge/game/zone/ZoneType;"));f.Pc=462;continue;}
case 462:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=463;continue;}
case 463:{f.StackOp("dup");f.Pc=464;continue;}
case 464:{f.Push(JValue.I(5));f.Pc=465;continue;}
case 465:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","StickerSheets","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","StickerSheets","Lforge/game/zone/ZoneType;"));f.Pc=468;continue;}
case 468:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=469;continue;}
case 469:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;[Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",472);}
case 472:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","PART_OF_COMMAND_ZONE","Ljava/util/EnumSet;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","PART_OF_COMMAND_ZONE","Ljava/util/EnumSet;",f.Pop());f.Pc=475;continue;}
case 475:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=478;continue;}
case 478:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"));f.Pc=481;continue;}
case 481:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"));f.Pc=484;continue;}
case 484:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"));f.Pc=487;continue;}
case 487:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"));f.Pc=490;continue;}
case 490:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",493);}
case 493:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","DECK_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","DECK_ZONES","Ljava/util/EnumSet;",f.Pop());f.Pc=496;continue;}
case 496:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Library","Lforge/game/zone/ZoneType;"));f.Pc=499;continue;}
case 499:{f.Push(JValue.I(7));f.Pc=501;continue;}
case 501:{f.Push(JValue.R(rt.NewArray("Lforge/game/zone/ZoneType;",f.Pop().Int)));f.Pc=504;continue;}
case 504:{f.StackOp("dup");f.Pc=505;continue;}
case 505:{f.Push(JValue.I(0));f.Pc=506;continue;}
case 506:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","SchemeDeck","Lforge/game/zone/ZoneType;"));f.Pc=509;continue;}
case 509:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=510;continue;}
case 510:{f.StackOp("dup");f.Pc=511;continue;}
case 511:{f.Push(JValue.I(1));f.Pc=512;continue;}
case 512:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","PlanarDeck","Lforge/game/zone/ZoneType;"));f.Pc=515;continue;}
case 515:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=516;continue;}
case 516:{f.StackOp("dup");f.Pc=517;continue;}
case 517:{f.Push(JValue.I(2));f.Pc=518;continue;}
case 518:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","AttractionDeck","Lforge/game/zone/ZoneType;"));f.Pc=521;continue;}
case 521:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=522;continue;}
case 522:{f.StackOp("dup");f.Pc=523;continue;}
case 523:{f.Push(JValue.I(3));f.Pc=524;continue;}
case 524:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","ContraptionDeck","Lforge/game/zone/ZoneType;"));f.Pc=527;continue;}
case 527:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=528;continue;}
case 528:{f.StackOp("dup");f.Pc=529;continue;}
case 529:{f.Push(JValue.I(4));f.Pc=530;continue;}
case 530:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Hand","Lforge/game/zone/ZoneType;"));f.Pc=533;continue;}
case 533:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=534;continue;}
case 534:{f.StackOp("dup");f.Pc=535;continue;}
case 535:{f.Push(JValue.I(5));f.Pc=536;continue;}
case 536:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Graveyard","Lforge/game/zone/ZoneType;"));f.Pc=539;continue;}
case 539:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=540;continue;}
case 540:{f.StackOp("dup");f.Pc=541;continue;}
case 541:{f.Push(JValue.I(6));f.Pc=543;continue;}
case 543:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Stack","Lforge/game/zone/ZoneType;"));f.Pc=546;continue;}
case 546:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=547;continue;}
case 547:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;[Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",550);}
case 550:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","ORDERED_ZONES","Ljava/util/EnumSet;"))return JStep.Continue;rt.PutStatic("forge/game/zone/ZoneType","ORDERED_ZONES","Ljava/util/EnumSet;",f.Pop());f.Pc=553;continue;}
case 553:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
