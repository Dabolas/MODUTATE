// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C90{
internal static JClass Build(){var c=new JClass("forge/deck/DeckFormat$1","forge/deck/DeckFormat",new string[]{},16432);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(1473,"forge/deck/DeckFormat$1","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;I)V",2,6,6,new JHandler[]{},M1473));
c.Add(new JMethod(1474,"forge/deck/DeckFormat$1","getAttractionDeckConformanceProblem","(Lforge/deck/Deck;)Ljava/lang/String;",1,2,2,new JHandler[]{},M1474));
c.Add(new JMethod(1475,"forge/deck/DeckFormat$1","getContraptionDeckConformanceProblem","(Lforge/deck/Deck;)Ljava/lang/String;",1,2,1,new JHandler[]{},M1475));
c.Add(new JMethod(1476,"forge/deck/DeckFormat$1","getStickerSheetConformanceProblem","(Lforge/deck/Deck;)Ljava/lang/String;",1,2,4,new JHandler[]{},M1476));
c.Add(new JMethod(1477,"forge/deck/DeckFormat$1","getExtraSectionMaxCopies","(Lforge/deck/DeckSection;)I",1,2,2,new JHandler[]{},M1477));
}

internal static JStep M1473(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[4]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[5]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/deck/DeckFormat","<init>","(Ljava/lang/String;ILorg/apache/commons/lang3/Range;Lorg/apache/commons/lang3/Range;I)V","invokespecial",11);}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1474(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",10);}
case 10:{f.Push(JValue.I(3));f.Pc=11;continue;}
case 11:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?17:14;continue;}
case 14:{f.Push(JValue.R(rt.String("must contain at least 3 attractions, or none at all")));f.Pc=16;continue;}
case 16:{return JStep.Return(f.Pop());}
case 17:{f.Push(JValue.R(null));f.Pc=18;continue;}
case 18:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1475(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1476(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/Deck","get","(Lforge/deck/DeckSection;)Lforge/deck/CardPool;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/deck/CardPool","countAll","()I","invokevirtual",10);}
case 10:{f.Push(JValue.I(3));f.Pc=11;continue;}
case 11:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?39:14;continue;}
case 14:{f.Push(JValue.I(3));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("must contain no more than")));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Push(JValue.I(3));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/String","valueOf","(I)Ljava/lang/String;","invokestatic",29);}
case 29:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=30;continue;}
case 30:{f.StackOp("dup");f.Pc=31;continue;}
case 31:{f.Push(JValue.I(2));f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("sticker sheets")));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",38);}
case 38:{return JStep.Return(f.Pop());}
case 39:{f.Push(JValue.R(null));f.Pc=40;continue;}
case 40:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1477(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"));f.Pc=4;continue;}
case 4:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?14:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"));f.Pc=11;continue;}
case 11:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?17:14;continue;}
case 14:{f.Push(JValue.I(2147483647));f.Pc=16;continue;}
case 16:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/deck/DeckFormat","getExtraSectionMaxCopies","(Lforge/deck/DeckSection;)I","invokespecial",22);}
case 22:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
