// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1077{
internal static JClass Build(){var c=new JClass("forge/item/PreconDeck$Reader","forge/util/storage/StorageReaderFolder",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11405,"forge/item/PreconDeck$Reader","<init>","(Ljava/io/File;)V",1,2,3,new JHandler[]{},M11405));
c.Add(new JMethod(11406,"forge/item/PreconDeck$Reader","read","(Ljava/io/File;)Lforge/item/PreconDeck;",4,2,2,new JHandler[]{},M11406));
c.Add(new JMethod(11407,"forge/item/PreconDeck$Reader","getPreconDeckFromSections","(Ljava/util/Map;)Lforge/item/PreconDeck;",4,8,5,new JHandler[]{},M11407));
c.Add(new JMethod(11408,"forge/item/PreconDeck$Reader","getFileFilter","()Ljava/io/FilenameFilter;",4,1,1,new JHandler[]{},M11408));
c.Add(new JMethod(11409,"forge/item/PreconDeck$Reader","read","(Ljava/io/File;)Ljava/lang/Object;",4164,2,2,new JHandler[]{},M11409));
}

internal static JStep M11405(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.DynamicCall(f,"forge/item/PreconDeck$Reader:11405:2:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",7);}
case 7:{return rt.Call(f,"forge/util/storage/StorageReaderFolder","<init>","(Ljava/io/File;Ljava/util/function/Function;)V","invokespecial",10);}
case 10:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11406(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/FileUtil","readFile","(Ljava/io/File;)Ljava/util/List;","invokestatic",5);}
case 5:{return rt.Call(f,"forge/util/FileSection","parseSections","(Ljava/util/List;)Ljava/util/Map;","invokestatic",8);}
case 8:{return rt.Call(f,"forge/item/PreconDeck$Reader","getPreconDeckFromSections","(Ljava/util/Map;)Lforge/item/PreconDeck;","invokevirtual",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11407(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("metadata")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",8);}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{if(!rt.StaticReady(f,"forge/util/FileSection","EQUALS_KV_SEPARATOR","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/FileSection","EQUALS_KV_SEPARATOR","Ljava/util/regex/Pattern;"));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/util/FileSection","parse","(Ljava/lang/Iterable;Ljava/util/regex/Pattern;)Lforge/util/FileSection;","invokestatic",17);}
case 17:{f.Locals[2]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[2]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Image")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Locals[3]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("Description")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",31);}
case 31:{f.Locals[4]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("set")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/util/FileSection","get","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",39);}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[5]);f.Pc=43;continue;}
case 43:{f.Pc=f.Pop().Reference==null?63:46;continue;}
case 46:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",49);}
case 49:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",52);}
case 52:{f.Push(f.Locals[5]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","toUpperCase","()Ljava/lang/String;","invokevirtual",57);}
case 57:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",60);}
case 60:{f.Pc=f.Pop().Reference!=null?68:63;continue;}
case 63:{f.Push(JValue.R(rt.String("n/a")));f.Pc=65;continue;}
case 65:{f.Pc=70;continue;}
case 68:{f.Push(f.Locals[5]);f.Pc=70;continue;}
case 70:{f.Locals[6]=f.Pop();f.Pc=72;continue;}
case 72:{if(!rt.EnsureInitialized(f,"forge/item/PreconDeck"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/item/PreconDeck")));f.Pc=75;continue;}
case 75:{f.StackOp("dup");f.Pc=76;continue;}
case 76:{f.Push(f.Locals[1]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/deck/io/DeckSerializer","fromSections","(Ljava/util/Map;)Lforge/deck/Deck;","invokestatic",80);}
case 80:{f.Push(f.Locals[6]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[4]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/item/PreconDeck","<init>","(Lforge/deck/Deck;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",87);}
case 87:{f.Locals[7]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[7]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[3]);f.Pc=92;continue;}
case 92:{var value=f.Pop();rt.PutField(f.Pop(),"forge/item/PreconDeck","imageFilename","Ljava/lang/String;",value);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[7]);f.Pc=97;continue;}
case 97:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11408(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/deck/io/DeckStorage","DCK_FILE_FILTER","Ljava/io/FilenameFilter;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/io/DeckStorage","DCK_FILE_FILTER","Ljava/io/FilenameFilter;"));f.Pc=3;continue;}
case 3:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11409(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/item/PreconDeck$Reader","read","(Ljava/io/File;)Lforge/item/PreconDeck;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
