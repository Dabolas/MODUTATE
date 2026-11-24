// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C87{
internal static JClass Build(){var c=new JClass("forge/deck/Deck$UnplayableAICards","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("unplayable","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("inMainDeck","I",false,JValue.Default("I"),null));
c.Add(new JMethod(1400,"forge/deck/Deck$UnplayableAICards","<init>","(Lforge/deck/Deck;)V",2,8,3,new JHandler[]{},M1400));
}

internal static JStep M1400(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck$UnplayableAICards","unplayable","Ljava/util/Map;",value);f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{f.Locals[2]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/deck/Deck","iterator","()Ljava/util/Iterator;","invokevirtual",21);}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[3]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",28);}
case 28:{f.Pc=f.Pop().Int==0?186:31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",37);}
case 37:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=40;continue;}
case 40:{f.Locals[4]=f.Pop();f.Pc=42;continue;}
case 42:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",45);}
case 45:{f.Locals[5]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",54);}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/CardPool"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{return rt.Call(f,"forge/deck/CardPool","iterator","()Ljava/util/Iterator;","invokevirtual",60);}
case 60:{f.Locals[6]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[6]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",69);}
case 69:{f.Pc=f.Pop().Int==0?124:72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",79);}
case 79:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=82;continue;}
case 82:{f.Locals[7]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[7]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",91);}
case 91:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",97);}
case 97:{return rt.Call(f,"forge/card/CardAiHints","isRemovedFromAiDecks","(Lforge/card/CardRules;)Z","invokestatic",100);}
case 100:{f.Pc=f.Pop().Int==0?121:103;continue;}
case 103:{f.Push(f.Locals[5]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[7]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",112);}
case 112:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",120);}
case 120:{f.StackOp("pop");f.Pc=121;continue;}
case 121:{f.Pc=62;continue;}
case 124:{f.Push(f.Locals[4]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",131);}
case 131:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckSection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=134;continue;}
case 134:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/deck/DeckSection","equals","(Ljava/lang/Object;)Z","invokevirtual",140);}
case 140:{f.Pc=f.Pop().Int==0?151:143;continue;}
case 143:{f.Push(f.Locals[5]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",150);}
case 150:{f.Locals[2]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(f.Locals[5]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",158);}
case 158:{f.Pc=f.Pop().Int!=0?183:161;continue;}
case 161:{f.Push(f.Locals[0]);f.Pc=162;continue;}
case 162:{f.Push(rt.GetField(f.Pop(),"forge/deck/Deck$UnplayableAICards","unplayable","Ljava/util/Map;"));f.Pc=165;continue;}
case 165:{f.Push(f.Locals[4]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",172);}
case 172:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckSection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[5]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",182);}
case 182:{f.StackOp("pop");f.Pc=183;continue;}
case 183:{f.Pc=22;continue;}
case 186:{f.Push(f.Locals[0]);f.Pc=187;continue;}
case 187:{f.Push(f.Locals[2]);f.Pc=188;continue;}
case 188:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/Deck$UnplayableAICards","inMainDeck","I",value);f.Pc=191;continue;}
case 191:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
