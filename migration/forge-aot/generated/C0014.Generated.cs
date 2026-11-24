// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C14{
internal static JClass Build(){var c=new JClass("forge/card/CardDb$CardArtPreference","java/lang/Enum",new string[]{"java/util/Comparator"},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("LATEST_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;",true,JValue.Default("Lforge/card/CardDb$CardArtPreference;"),null));
c.Add(new JField("LATEST_ART_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;",true,JValue.Default("Lforge/card/CardDb$CardArtPreference;"),null));
c.Add(new JField("ORIGINAL_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;",true,JValue.Default("Lforge/card/CardDb$CardArtPreference;"),null));
c.Add(new JField("ORIGINAL_ART_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;",true,JValue.Default("Lforge/card/CardDb$CardArtPreference;"),null));
c.Add(new JField("ORIGINAL_ART_BLACK_BORDER_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;",true,JValue.Default("Lforge/card/CardDb$CardArtPreference;"),null));
c.Add(new JField("ORIGINAL_ART_BLACK_BORDER_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;",true,JValue.Default("Lforge/card/CardDb$CardArtPreference;"),null));
c.Add(new JField("filterSets","Z",false,JValue.Default("Z"),null));
c.Add(new JField("latestFirst","Z",false,JValue.Default("Z"),null));
c.Add(new JField("blackBorderOnly","Z",false,JValue.Default("Z"),null));
c.Add(new JField("ALLOWED_SET_TYPES","Ljava/util/EnumSet;",true,JValue.Default("Ljava/util/EnumSet;"),null));
c.Add(new JField("RANK_ORIGINAL","I",true,JValue.I(0),null));
c.Add(new JField("RANK_OTHER","I",true,JValue.I(1),null));
c.Add(new JField("RANK_COMPILATION","I",true,JValue.I(2),null));
c.Add(new JField("COMPILATION_SET_TYPES","Ljava/util/EnumSet;",true,JValue.Default("Ljava/util/EnumSet;"),null));
c.Add(new JField("$VALUES","[Lforge/card/CardDb$CardArtPreference;",true,JValue.Default("[Lforge/card/CardDb$CardArtPreference;"),null));
c.Add(new JMethod(321,"forge/card/CardDb$CardArtPreference","values","()[Lforge/card/CardDb$CardArtPreference;",9,0,1,new JHandler[]{},M321));
c.Add(new JMethod(322,"forge/card/CardDb$CardArtPreference","valueOf","(Ljava/lang/String;)Lforge/card/CardDb$CardArtPreference;",9,1,2,new JHandler[]{},M322));
c.Add(new JMethod(323,"forge/card/CardDb$CardArtPreference","<init>","(Ljava/lang/String;IZZZ)V",2,6,3,new JHandler[]{},M323));
c.Add(new JMethod(324,"forge/card/CardDb$CardArtPreference","of","(ZZZ)Lforge/card/CardDb$CardArtPreference;",9,3,1,new JHandler[]{},M324));
c.Add(new JMethod(325,"forge/card/CardDb$CardArtPreference","isBlackBordered","(Lforge/card/CardEdition;)Z",2,2,2,new JHandler[]{},M325));
c.Add(new JMethod(326,"forge/card/CardDb$CardArtPreference","acceptsSetType","(Lforge/card/CardEdition;)Z",1,2,2,new JHandler[]{},M326));
c.Add(new JMethod(327,"forge/card/CardDb$CardArtPreference","accept","(Lforge/card/CardEdition;)Z",1,2,2,new JHandler[]{},M327));
c.Add(new JMethod(328,"forge/card/CardDb$CardArtPreference","getEditionRank","(Lforge/card/CardEdition;)I",1,3,2,new JHandler[]{},M328));
c.Add(new JMethod(329,"forge/card/CardDb$CardArtPreference","compare","(Lforge/card/CardEdition;Lforge/card/CardEdition;)I",1,4,3,new JHandler[]{},M329));
c.Add(new JMethod(330,"forge/card/CardDb$CardArtPreference","compare","(Ljava/lang/Object;Ljava/lang/Object;)I",4161,3,3,new JHandler[]{},M330));
c.Add(new JMethod(331,"forge/card/CardDb$CardArtPreference","$values","()[Lforge/card/CardDb$CardArtPreference;",4106,0,4,new JHandler[]{},M331));
c.Add(new JMethod(332,"forge/card/CardDb$CardArtPreference","<clinit>","()V",8,0,7,new JHandler[]{},M332));
}

internal static JStep M321(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","$VALUES","[Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","$VALUES","[Lforge/card/CardDb$CardArtPreference;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/card/CardDb$CardArtPreference;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/card/CardDb$CardArtPreference;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M322(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/card/CardDb$CardArtPreference")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardDb$CardArtPreference"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M323(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb$CardArtPreference","filterSets","Z",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb$CardArtPreference","latestFirst","Z",value);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardDb$CardArtPreference","blackBorderOnly","Z",value);f.Pc=23;continue;}
case 23:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M324(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Int==0?18:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Int==0?14:8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","LATEST_ART_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","LATEST_ART_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"));f.Pc=11;continue;}
case 11:{f.Pc=17;continue;}
case 14:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","LATEST_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","LATEST_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"));f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Pc=f.Pop().Int==0?36:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Int==0?32:26;continue;}
case 26:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ORIGINAL_ART_BLACK_BORDER_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","ORIGINAL_ART_BLACK_BORDER_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"));f.Pc=29;continue;}
case 29:{f.Pc=35;continue;}
case 32:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ORIGINAL_ART_BLACK_BORDER_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","ORIGINAL_ART_BLACK_BORDER_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"));f.Pc=35;continue;}
case 35:{return JStep.Return(f.Pop());}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Pc=f.Pop().Int==0?46:40;continue;}
case 40:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ORIGINAL_ART_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","ORIGINAL_ART_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"));f.Pc=43;continue;}
case 43:{f.Pc=49;continue;}
case 46:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ORIGINAL_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","ORIGINAL_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"));f.Pc=49;continue;}
case 49:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M325(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/card/CardEdition","getBorderColor","()Lforge/card/CardEdition$BorderColor;","invokevirtual",4);}
case 4:{if(!rt.StaticReady(f,"forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$BorderColor","BLACK","Lforge/card/CardEdition$BorderColor;"));f.Pc=7;continue;}
case 7:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?14:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Pc=15;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M326(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?28:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardArtPreference","filterSets","Z"));f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Int==0?24:11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ALLOWED_SET_TYPES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","ALLOWED_SET_TYPES","Ljava/util/EnumSet;"));f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",18);}
case 18:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?28:24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Pc=29;continue;}
case 28:{f.Push(JValue.I(0));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M327(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardArtPreference","blackBorderOnly","Z"));f.Pc=10;continue;}
case 10:{f.Pc=f.Pop().Int==0?23:13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","isBlackBordered","(Lforge/card/CardEdition;)Z","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Int!=0?23:21;continue;}
case 21:{f.Push(JValue.I(0));f.Pc=22;continue;}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardArtPreference","filterSets","Z"));f.Pc=27;continue;}
case 27:{f.Pc=f.Pop().Int==0?43:30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ALLOWED_SET_TYPES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","ALLOWED_SET_TYPES","Ljava/util/EnumSet;"));f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",37);}
case 37:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",40);}
case 40:{f.Pc=f.Pop().Int==0?47:43;continue;}
case 43:{f.Push(JValue.I(1));f.Pc=44;continue;}
case 44:{f.Pc=48;continue;}
case 47:{f.Push(JValue.I(0));f.Pc=48;continue;}
case 48:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M328(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardArtPreference","blackBorderOnly","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?11:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Pc=f.Pop().Reference!=null?13:11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","CORE","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","CORE","Lforge/card/CardEdition$Type;"));f.Pc=22;continue;}
case 22:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?32:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"));f.Pc=29;continue;}
case 29:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?34:32;continue;}
case 32:{f.Push(JValue.I(0));f.Pc=33;continue;}
case 33:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 34:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","COMPILATION_SET_TYPES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","COMPILATION_SET_TYPES","Ljava/util/EnumSet;"));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",41);}
case 41:{f.Pc=f.Pop().Int==0?48:44;continue;}
case 44:{f.Push(JValue.I(2));f.Pc=45;continue;}
case 45:{f.Pc=49;continue;}
case 48:{f.Push(JValue.I(1));f.Pc=49;continue;}
case 49:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M329(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?7:5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardArtPreference","filterSets","Z"));f.Pc=11;continue;}
case 11:{f.Pc=f.Pop().Int==0?56:14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ALLOWED_SET_TYPES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","ALLOWED_SET_TYPES","Ljava/util/EnumSet;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",24);}
case 24:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ALLOWED_SET_TYPES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","ALLOWED_SET_TYPES","Ljava/util/EnumSet;"));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",31);}
case 31:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",34);}
case 34:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?56:37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ALLOWED_SET_TYPES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","ALLOWED_SET_TYPES","Ljava/util/EnumSet;"));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"forge/card/CardEdition","getType","()Lforge/card/CardEdition$Type;","invokevirtual",44);}
case 44:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",47);}
case 47:{f.Pc=f.Pop().Int==0?54:50;continue;}
case 50:{f.Push(JValue.I(-1));f.Pc=51;continue;}
case 51:{f.Pc=55;continue;}
case 54:{f.Push(JValue.I(1));f.Pc=55;continue;}
case 55:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 56:{f.Push(f.Locals[0]);f.Pc=57;continue;}
case 57:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardArtPreference","blackBorderOnly","Z"));f.Pc=60;continue;}
case 60:{f.Pc=f.Pop().Int==0?90:63;continue;}
case 63:{f.Push(f.Locals[0]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[1]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","isBlackBordered","(Lforge/card/CardEdition;)Z","invokevirtual",68);}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","isBlackBordered","(Lforge/card/CardEdition;)Z","invokevirtual",73);}
case 73:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?90:76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","isBlackBordered","(Lforge/card/CardEdition;)Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int==0?88:84;continue;}
case 84:{f.Push(JValue.I(-1));f.Pc=85;continue;}
case 85:{f.Pc=89;continue;}
case 88:{f.Push(JValue.I(1));f.Pc=89;continue;}
case 89:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 90:{f.Push(f.Locals[0]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[1]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","getEditionRank","(Lforge/card/CardEdition;)I","invokevirtual",95);}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[2]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","getEditionRank","(Lforge/card/CardEdition;)I","invokevirtual",100);}
case 100:{return rt.Call(f,"java/lang/Integer","compare","(II)I","invokestatic",103);}
case 103:{f.Locals[3]=f.Pop();f.Pc=104;continue;}
case 104:{f.Push(f.Locals[3]);f.Pc=105;continue;}
case 105:{f.Pc=f.Pop().Int==0?110:108;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 110:{f.Push(f.Locals[0]);f.Pc=111;continue;}
case 111:{f.Push(rt.GetField(f.Pop(),"forge/card/CardDb$CardArtPreference","latestFirst","Z"));f.Pc=114;continue;}
case 114:{f.Pc=f.Pop().Int==0?121:117;continue;}
case 117:{f.Push(JValue.I(-1));f.Pc=118;continue;}
case 118:{f.Pc=122;continue;}
case 121:{f.Push(JValue.I(1));f.Pc=122;continue;}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",126);}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/card/CardEdition","getDate","()Ljava/util/Date;","invokevirtual",130);}
case 130:{return rt.Call(f,"java/util/Date","compareTo","(Ljava/util/Date;)I","invokevirtual",133);}
case 133:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"imul",a,b));f.Pc=134;continue;}
case 134:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M330(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardEdition"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","compare","(Lforge/card/CardEdition;Lforge/card/CardEdition;)I","invokevirtual",12);}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M331(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(6));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/card/CardDb$CardArtPreference;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","LATEST_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","LATEST_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","LATEST_ART_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","LATEST_ART_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ORIGINAL_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","ORIGINAL_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ORIGINAL_ART_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","ORIGINAL_ART_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ORIGINAL_ART_BLACK_BORDER_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","ORIGINAL_ART_BLACK_BORDER_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ORIGINAL_ART_BLACK_BORDER_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardDb$CardArtPreference","ORIGINAL_ART_BLACK_BORDER_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M332(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/CardDb$CardArtPreference"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardDb$CardArtPreference")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("LATEST_ART_ALL_EDITIONS")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Push(JValue.I(1));f.Pc=9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","<init>","(Ljava/lang/String;IZZZ)V","invokespecial",13);}
case 13:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","LATEST_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;rt.PutStatic("forge/card/CardDb$CardArtPreference","LATEST_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;",f.Pop());f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"forge/card/CardDb$CardArtPreference"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardDb$CardArtPreference")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("LATEST_ART_CORE_EXPANSIONS_REPRINT_ONLY")));f.Pc=22;continue;}
case 22:{f.Push(JValue.I(1));f.Pc=23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","<init>","(Ljava/lang/String;IZZZ)V","invokespecial",29);}
case 29:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","LATEST_ART_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;rt.PutStatic("forge/card/CardDb$CardArtPreference","LATEST_ART_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;",f.Pop());f.Pc=32;continue;}
case 32:{if(!rt.EnsureInitialized(f,"forge/card/CardDb$CardArtPreference"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardDb$CardArtPreference")));f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("ORIGINAL_ART_ALL_EDITIONS")));f.Pc=38;continue;}
case 38:{f.Push(JValue.I(2));f.Pc=39;continue;}
case 39:{f.Push(JValue.I(0));f.Pc=40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","<init>","(Ljava/lang/String;IZZZ)V","invokespecial",45);}
case 45:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ORIGINAL_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;rt.PutStatic("forge/card/CardDb$CardArtPreference","ORIGINAL_ART_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;",f.Pop());f.Pc=48;continue;}
case 48:{if(!rt.EnsureInitialized(f,"forge/card/CardDb$CardArtPreference"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardDb$CardArtPreference")));f.Pc=51;continue;}
case 51:{f.StackOp("dup");f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("ORIGINAL_ART_CORE_EXPANSIONS_REPRINT_ONLY")));f.Pc=54;continue;}
case 54:{f.Push(JValue.I(3));f.Pc=55;continue;}
case 55:{f.Push(JValue.I(1));f.Pc=56;continue;}
case 56:{f.Push(JValue.I(0));f.Pc=57;continue;}
case 57:{f.Push(JValue.I(0));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","<init>","(Ljava/lang/String;IZZZ)V","invokespecial",61);}
case 61:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ORIGINAL_ART_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;rt.PutStatic("forge/card/CardDb$CardArtPreference","ORIGINAL_ART_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;",f.Pop());f.Pc=64;continue;}
case 64:{if(!rt.EnsureInitialized(f,"forge/card/CardDb$CardArtPreference"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardDb$CardArtPreference")));f.Pc=67;continue;}
case 67:{f.StackOp("dup");f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("ORIGINAL_ART_BLACK_BORDER_ALL_EDITIONS")));f.Pc=70;continue;}
case 70:{f.Push(JValue.I(4));f.Pc=71;continue;}
case 71:{f.Push(JValue.I(0));f.Pc=72;continue;}
case 72:{f.Push(JValue.I(0));f.Pc=73;continue;}
case 73:{f.Push(JValue.I(1));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","<init>","(Ljava/lang/String;IZZZ)V","invokespecial",77);}
case 77:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ORIGINAL_ART_BLACK_BORDER_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;rt.PutStatic("forge/card/CardDb$CardArtPreference","ORIGINAL_ART_BLACK_BORDER_ALL_EDITIONS","Lforge/card/CardDb$CardArtPreference;",f.Pop());f.Pc=80;continue;}
case 80:{if(!rt.EnsureInitialized(f,"forge/card/CardDb$CardArtPreference"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardDb$CardArtPreference")));f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("ORIGINAL_ART_BLACK_BORDER_CORE_EXPANSIONS_REPRINT_ONLY")));f.Pc=86;continue;}
case 86:{f.Push(JValue.I(5));f.Pc=87;continue;}
case 87:{f.Push(JValue.I(1));f.Pc=88;continue;}
case 88:{f.Push(JValue.I(0));f.Pc=89;continue;}
case 89:{f.Push(JValue.I(1));f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","<init>","(Ljava/lang/String;IZZZ)V","invokespecial",93);}
case 93:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ORIGINAL_ART_BLACK_BORDER_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;rt.PutStatic("forge/card/CardDb$CardArtPreference","ORIGINAL_ART_BLACK_BORDER_CORE_EXPANSIONS_REPRINT_ONLY","Lforge/card/CardDb$CardArtPreference;",f.Pop());f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/card/CardDb$CardArtPreference","$values","()[Lforge/card/CardDb$CardArtPreference;","invokestatic",99);}
case 99:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","$VALUES","[Lforge/card/CardDb$CardArtPreference;"))return JStep.Continue;rt.PutStatic("forge/card/CardDb$CardArtPreference","$VALUES","[Lforge/card/CardDb$CardArtPreference;",f.Pop());f.Pc=102;continue;}
case 102:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","CORE","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","CORE","Lforge/card/CardEdition$Type;"));f.Pc=105;continue;}
case 105:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","EXPANSION","Lforge/card/CardEdition$Type;"));f.Pc=108;continue;}
case 108:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","REPRINT","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","REPRINT","Lforge/card/CardEdition$Type;"));f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",114);}
case 114:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","ALLOWED_SET_TYPES","Ljava/util/EnumSet;"))return JStep.Continue;rt.PutStatic("forge/card/CardDb$CardArtPreference","ALLOWED_SET_TYPES","Ljava/util/EnumSet;",f.Pop());f.Pc=117;continue;}
case 117:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","REPRINT","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","REPRINT","Lforge/card/CardEdition$Type;"));f.Pc=120;continue;}
case 120:{f.Push(JValue.I(5));f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.NewArray("Lforge/card/CardEdition$Type;",f.Pop().Int)));f.Pc=124;continue;}
case 124:{f.StackOp("dup");f.Pc=125;continue;}
case 125:{f.Push(JValue.I(0));f.Pc=126;continue;}
case 126:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","PROMO","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","PROMO","Lforge/card/CardEdition$Type;"));f.Pc=129;continue;}
case 129:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=130;continue;}
case 130:{f.StackOp("dup");f.Pc=131;continue;}
case 131:{f.Push(JValue.I(1));f.Pc=132;continue;}
case 132:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","COLLECTOR_EDITION","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","COLLECTOR_EDITION","Lforge/card/CardEdition$Type;"));f.Pc=135;continue;}
case 135:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=136;continue;}
case 136:{f.StackOp("dup");f.Pc=137;continue;}
case 137:{f.Push(JValue.I(2));f.Pc=138;continue;}
case 138:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","ONLINE","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","ONLINE","Lforge/card/CardEdition$Type;"));f.Pc=141;continue;}
case 141:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=142;continue;}
case 142:{f.StackOp("dup");f.Pc=143;continue;}
case 143:{f.Push(JValue.I(3));f.Pc=144;continue;}
case 144:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","BOXED_SET","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","BOXED_SET","Lforge/card/CardEdition$Type;"));f.Pc=147;continue;}
case 147:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=148;continue;}
case 148:{f.StackOp("dup");f.Pc=149;continue;}
case 149:{f.Push(JValue.I(4));f.Pc=150;continue;}
case 150:{if(!rt.StaticReady(f,"forge/card/CardEdition$Type","DUEL_DECK","Lforge/card/CardEdition$Type;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$Type","DUEL_DECK","Lforge/card/CardEdition$Type;"));f.Pc=153;continue;}
case 153:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;[Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",157);}
case 157:{if(!rt.StaticReady(f,"forge/card/CardDb$CardArtPreference","COMPILATION_SET_TYPES","Ljava/util/EnumSet;"))return JStep.Continue;rt.PutStatic("forge/card/CardDb$CardArtPreference","COMPILATION_SET_TYPES","Ljava/util/EnumSet;",f.Pop());f.Pc=160;continue;}
case 160:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
