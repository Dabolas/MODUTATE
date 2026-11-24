// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C99{
internal static JClass Build(){var c=new JClass("forge/deck/DeckRecognizer$PortablePattern","java/lang/Object",new string[]{},48);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("regex","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("groupIndexes","Ljava/util/Map;",false,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JMethod(1567,"forge/deck/DeckRecognizer$PortablePattern","<init>","(Ljava/lang/String;Ljava/util/Map;)V",2,3,2,new JHandler[]{},M1567));
}

internal static JStep M1567(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$PortablePattern","regex","Ljava/lang/String;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$PortablePattern","groupIndexes","Ljava/util/Map;",value);f.Pc=14;continue;}
case 14:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
