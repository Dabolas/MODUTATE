// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C503{
internal static JClass Build(){var c=new JClass("forge/game/card/sticker/StickerKind","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("NAME","Lforge/game/card/sticker/StickerKind;",true,JValue.Default("Lforge/game/card/sticker/StickerKind;"),null));
c.Add(new JField("ART","Lforge/game/card/sticker/StickerKind;",true,JValue.Default("Lforge/game/card/sticker/StickerKind;"),null));
c.Add(new JField("ABILITY","Lforge/game/card/sticker/StickerKind;",true,JValue.Default("Lforge/game/card/sticker/StickerKind;"),null));
c.Add(new JField("PT","Lforge/game/card/sticker/StickerKind;",true,JValue.Default("Lforge/game/card/sticker/StickerKind;"),null));
c.Add(new JField("$VALUES","[Lforge/game/card/sticker/StickerKind;",true,JValue.Default("[Lforge/game/card/sticker/StickerKind;"),null));
c.Add(new JMethod(5936,"forge/game/card/sticker/StickerKind","values","()[Lforge/game/card/sticker/StickerKind;",9,0,1,new JHandler[]{},M5936));
c.Add(new JMethod(5937,"forge/game/card/sticker/StickerKind","valueOf","(Ljava/lang/String;)Lforge/game/card/sticker/StickerKind;",9,1,2,new JHandler[]{},M5937));
c.Add(new JMethod(5938,"forge/game/card/sticker/StickerKind","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M5938));
c.Add(new JMethod(5939,"forge/game/card/sticker/StickerKind","smartValueOf","(Ljava/lang/String;)Lforge/game/card/sticker/StickerKind;",9,5,2,new JHandler[]{},M5939));
c.Add(new JMethod(5940,"forge/game/card/sticker/StickerKind","$values","()[Lforge/game/card/sticker/StickerKind;",4106,0,4,new JHandler[]{},M5940));
c.Add(new JMethod(5941,"forge/game/card/sticker/StickerKind","<clinit>","()V",8,0,4,new JHandler[]{},M5941));
}

internal static JStep M5936(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/card/sticker/StickerKind","$VALUES","[Lforge/game/card/sticker/StickerKind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/sticker/StickerKind","$VALUES","[Lforge/game/card/sticker/StickerKind;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/game/card/sticker/StickerKind;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/card/sticker/StickerKind;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5937(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/card/sticker/StickerKind")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/sticker/StickerKind"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5938(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5939(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/game/card/sticker/StickerKind","values","()[Lforge/game/card/sticker/StickerKind;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[3]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?40:14;continue;}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=17;continue;}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/card/sticker/StickerKind","name","()Ljava/lang/String;","invokevirtual",24);}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",28);}
case 28:{f.Pc=f.Pop().Int==0?34:31;continue;}
case 31:{f.Push(f.Locals[4]);f.Pc=33;continue;}
case 33:{return JStep.Return(f.Pop());}
case 34:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=37;continue;}
case 37:{f.Pc=9;continue;}
case 40:{f.Push(JValue.R(null));f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5940(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(4));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/sticker/StickerKind;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/card/sticker/StickerKind","NAME","Lforge/game/card/sticker/StickerKind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/sticker/StickerKind","NAME","Lforge/game/card/sticker/StickerKind;"));f.Pc=9;continue;}
case 9:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/card/sticker/StickerKind","ART","Lforge/game/card/sticker/StickerKind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/sticker/StickerKind","ART","Lforge/game/card/sticker/StickerKind;"));f.Pc=15;continue;}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(2));f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/game/card/sticker/StickerKind","ABILITY","Lforge/game/card/sticker/StickerKind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/sticker/StickerKind","ABILITY","Lforge/game/card/sticker/StickerKind;"));f.Pc=21;continue;}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(JValue.I(3));f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/card/sticker/StickerKind","PT","Lforge/game/card/sticker/StickerKind;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/sticker/StickerKind","PT","Lforge/game/card/sticker/StickerKind;"));f.Pc=27;continue;}
case 27:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5941(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/sticker/StickerKind"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/sticker/StickerKind")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("NAME")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/card/sticker/StickerKind","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/game/card/sticker/StickerKind","NAME","Lforge/game/card/sticker/StickerKind;"))return JStep.Continue;rt.PutStatic("forge/game/card/sticker/StickerKind","NAME","Lforge/game/card/sticker/StickerKind;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/game/card/sticker/StickerKind"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/sticker/StickerKind")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("ART")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/sticker/StickerKind","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/game/card/sticker/StickerKind","ART","Lforge/game/card/sticker/StickerKind;"))return JStep.Continue;rt.PutStatic("forge/game/card/sticker/StickerKind","ART","Lforge/game/card/sticker/StickerKind;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/game/card/sticker/StickerKind"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/sticker/StickerKind")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("ABILITY")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/sticker/StickerKind","<init>","(Ljava/lang/String;I)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/game/card/sticker/StickerKind","ABILITY","Lforge/game/card/sticker/StickerKind;"))return JStep.Continue;rt.PutStatic("forge/game/card/sticker/StickerKind","ABILITY","Lforge/game/card/sticker/StickerKind;",f.Pop());f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/game/card/sticker/StickerKind"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/sticker/StickerKind")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("PT")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/game/card/sticker/StickerKind","<init>","(Ljava/lang/String;I)V","invokespecial",49);}
case 49:{if(!rt.StaticReady(f,"forge/game/card/sticker/StickerKind","PT","Lforge/game/card/sticker/StickerKind;"))return JStep.Continue;rt.PutStatic("forge/game/card/sticker/StickerKind","PT","Lforge/game/card/sticker/StickerKind;",f.Pop());f.Pc=52;continue;}
case 52:{return rt.Call(f,"forge/game/card/sticker/StickerKind","$values","()[Lforge/game/card/sticker/StickerKind;","invokestatic",55);}
case 55:{if(!rt.StaticReady(f,"forge/game/card/sticker/StickerKind","$VALUES","[Lforge/game/card/sticker/StickerKind;"))return JStep.Continue;rt.PutStatic("forge/game/card/sticker/StickerKind","$VALUES","[Lforge/game/card/sticker/StickerKind;",f.Pop());f.Pc=58;continue;}
case 58:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
