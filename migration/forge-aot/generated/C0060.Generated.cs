// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C60{
internal static JClass Build(){var c=new JClass("forge/card/DraftOptions","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("doublePick","Lforge/card/DraftOptions$DoublePick;",false,JValue.Default("Lforge/card/DraftOptions$DoublePick;"),null));
c.Add(new JField("maxPodSize","I",false,JValue.Default("I"),null));
c.Add(new JField("recommendedPodSize","I",false,JValue.Default("I"),null));
c.Add(new JField("maxMatchPlayers","I",false,JValue.Default("I"),null));
c.Add(new JField("deckType","Lforge/card/CardEdition$DraftType;",false,JValue.Default("Lforge/card/CardEdition$DraftType;"),null));
c.Add(new JField("freeCommander","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("impliedPartner","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(1036,"forge/card/DraftOptions","<init>","(Ljava/lang/String;IIILforge/card/CardEdition$DraftType;Ljava/lang/String;Ljava/lang/String;)V",1,10,2,new JHandler[]{},M1036));
c.Add(new JMethod(1037,"forge/card/DraftOptions","getMaxPodSize","()I",1,1,1,new JHandler[]{},M1037));
c.Add(new JMethod(1038,"forge/card/DraftOptions","getRecommendedPodSize","()I",1,1,1,new JHandler[]{},M1038));
c.Add(new JMethod(1039,"forge/card/DraftOptions","getDoublePick","()Lforge/card/DraftOptions$DoublePick;",1,1,1,new JHandler[]{},M1039));
c.Add(new JMethod(1040,"forge/card/DraftOptions","isDoublePick","(I)Lforge/card/DraftOptions$DoublePick;",1,2,2,new JHandler[]{},M1040));
c.Add(new JMethod(1041,"forge/card/DraftOptions","getMaxMatchPlayers","()I",1,1,1,new JHandler[]{},M1041));
c.Add(new JMethod(1042,"forge/card/DraftOptions","getDeckType","()Lforge/card/CardEdition$DraftType;",1,1,1,new JHandler[]{},M1042));
c.Add(new JMethod(1043,"forge/card/DraftOptions","getFreeCommander","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1043));
c.Add(new JMethod(1044,"forge/card/DraftOptions","getImpliedPartner","()Ljava/lang/String;",1,1,1,new JHandler[]{},M1044));
}

internal static JStep M1036(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.StaticReady(f,"forge/card/DraftOptions$DoublePick","NEVER","Lforge/card/DraftOptions$DoublePick;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DraftOptions$DoublePick","NEVER","Lforge/card/DraftOptions$DoublePick;"));f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/DraftOptions","doublePick","Lforge/card/DraftOptions$DoublePick;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/DraftOptions","maxPodSize","I",value);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/DraftOptions","recommendedPodSize","I",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[4]);f.Pc=24;continue;}
case 24:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/DraftOptions","maxMatchPlayers","I",value);f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[5]);f.Pc=30;continue;}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/DraftOptions","deckType","Lforge/card/CardEdition$DraftType;",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[6]);f.Pc=36;continue;}
case 36:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/DraftOptions","freeCommander","Ljava/lang/String;",value);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[7]);f.Pc=42;continue;}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/DraftOptions","impliedPartner","Ljava/lang/String;",value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Pc=f.Pop().Reference==null?195:49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",53);}
case 53:{f.Locals[8]=f.Pop();f.Pc=55;continue;}
case 55:{f.Push(JValue.I(-1));f.Pc=56;continue;}
case 56:{f.Locals[9]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[8]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",63);}
case 63:{switch(f.Pop().Int){case -1414557169:f.Pc=112;break;case 133855953:f.Pc=96;break;case 569490814:f.Pc=128;break;default:f.Pc=141;break;}continue;}
case 96:{f.Push(f.Locals[8]);f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("firstpick")));f.Pc=100;continue;}
case 100:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",103);}
case 103:{f.Pc=f.Pop().Int==0?141:106;continue;}
case 106:{f.Push(JValue.I(0));f.Pc=107;continue;}
case 107:{f.Locals[9]=f.Pop();f.Pc=109;continue;}
case 109:{f.Pc=141;continue;}
case 112:{f.Push(f.Locals[8]);f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String("always")));f.Pc=116;continue;}
case 116:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",119);}
case 119:{f.Pc=f.Pop().Int==0?141:122;continue;}
case 122:{f.Push(JValue.I(1));f.Pc=123;continue;}
case 123:{f.Locals[9]=f.Pop();f.Pc=125;continue;}
case 125:{f.Pc=141;continue;}
case 128:{f.Push(f.Locals[8]);f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("whenpodsizeis4")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",135);}
case 135:{f.Pc=f.Pop().Int==0?141:138;continue;}
case 138:{f.Push(JValue.I(2));f.Pc=139;continue;}
case 139:{f.Locals[9]=f.Pop();f.Pc=141;continue;}
case 141:{f.Push(f.Locals[9]);f.Pc=143;continue;}
case 143:{switch(f.Pop().Int){case 0:f.Pc=168;break;case 1:f.Pc=178;break;case 2:f.Pc=188;break;default:f.Pc=195;break;}continue;}
case 168:{f.Push(f.Locals[0]);f.Pc=169;continue;}
case 169:{if(!rt.StaticReady(f,"forge/card/DraftOptions$DoublePick","FIRST_PICK","Lforge/card/DraftOptions$DoublePick;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DraftOptions$DoublePick","FIRST_PICK","Lforge/card/DraftOptions$DoublePick;"));f.Pc=172;continue;}
case 172:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/DraftOptions","doublePick","Lforge/card/DraftOptions$DoublePick;",value);f.Pc=175;continue;}
case 175:{f.Pc=195;continue;}
case 178:{f.Push(f.Locals[0]);f.Pc=179;continue;}
case 179:{if(!rt.StaticReady(f,"forge/card/DraftOptions$DoublePick","ALWAYS","Lforge/card/DraftOptions$DoublePick;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DraftOptions$DoublePick","ALWAYS","Lforge/card/DraftOptions$DoublePick;"));f.Pc=182;continue;}
case 182:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/DraftOptions","doublePick","Lforge/card/DraftOptions$DoublePick;",value);f.Pc=185;continue;}
case 185:{f.Pc=195;continue;}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{if(!rt.StaticReady(f,"forge/card/DraftOptions$DoublePick","WHEN_POD_SIZE_IS_4","Lforge/card/DraftOptions$DoublePick;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/DraftOptions$DoublePick","WHEN_POD_SIZE_IS_4","Lforge/card/DraftOptions$DoublePick;"));f.Pc=192;continue;}
case 192:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/DraftOptions","doublePick","Lforge/card/DraftOptions$DoublePick;",value);f.Pc=195;continue;}
case 195:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1037(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/DraftOptions","maxPodSize","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1038(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/DraftOptions","recommendedPodSize","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1039(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/DraftOptions","doublePick","Lforge/card/DraftOptions$DoublePick;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1040(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/DraftOptions","doublePick","Lforge/card/DraftOptions$DoublePick;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/DraftOptions$DoublePick","resolve","(I)Lforge/card/DraftOptions$DoublePick;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1041(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/DraftOptions","maxMatchPlayers","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1042(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/DraftOptions","deckType","Lforge/card/CardEdition$DraftType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1043(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/DraftOptions","freeCommander","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1044(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/card/DraftOptions","impliedPartner","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
