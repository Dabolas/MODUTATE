// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C106{
internal static JClass Build(){var c=new JClass("forge/deck/DeckSection","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("Main","Lforge/deck/DeckSection;",true,JValue.Default("Lforge/deck/DeckSection;"),null));
c.Add(new JField("Sideboard","Lforge/deck/DeckSection;",true,JValue.Default("Lforge/deck/DeckSection;"),null));
c.Add(new JField("Commander","Lforge/deck/DeckSection;",true,JValue.Default("Lforge/deck/DeckSection;"),null));
c.Add(new JField("Avatar","Lforge/deck/DeckSection;",true,JValue.Default("Lforge/deck/DeckSection;"),null));
c.Add(new JField("Planes","Lforge/deck/DeckSection;",true,JValue.Default("Lforge/deck/DeckSection;"),null));
c.Add(new JField("Schemes","Lforge/deck/DeckSection;",true,JValue.Default("Lforge/deck/DeckSection;"),null));
c.Add(new JField("Conspiracy","Lforge/deck/DeckSection;",true,JValue.Default("Lforge/deck/DeckSection;"),null));
c.Add(new JField("Dungeon","Lforge/deck/DeckSection;",true,JValue.Default("Lforge/deck/DeckSection;"),null));
c.Add(new JField("Attractions","Lforge/deck/DeckSection;",true,JValue.Default("Lforge/deck/DeckSection;"),null));
c.Add(new JField("Contraptions","Lforge/deck/DeckSection;",true,JValue.Default("Lforge/deck/DeckSection;"),null));
c.Add(new JField("Stickers","Lforge/deck/DeckSection;",true,JValue.Default("Lforge/deck/DeckSection;"),null));
c.Add(new JField("NONTRADITIONAL_SECTIONS","[Lforge/deck/DeckSection;",true,JValue.Default("[Lforge/deck/DeckSection;"),null));
c.Add(new JField("nameLbl","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("fnValidator","Ljava/util/function/Predicate;",false,JValue.Default("Ljava/util/function/Predicate;"),null));
c.Add(new JField("$VALUES","[Lforge/deck/DeckSection;",true,JValue.Default("[Lforge/deck/DeckSection;"),null));
c.Add(new JMethod(1628,"forge/deck/DeckSection","values","()[Lforge/deck/DeckSection;",9,0,1,new JHandler[]{},M1628));
c.Add(new JMethod(1629,"forge/deck/DeckSection","valueOf","(Ljava/lang/String;)Lforge/deck/DeckSection;",9,1,2,new JHandler[]{},M1629));
c.Add(new JMethod(1630,"forge/deck/DeckSection","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/util/function/Predicate;)V",2,5,3,new JHandler[]{},M1630));
c.Add(new JMethod(1631,"forge/deck/DeckSection","getLocalizedName","()Ljava/lang/String;",1,1,3,new JHandler[]{},M1631));
c.Add(new JMethod(1632,"forge/deck/DeckSection","getLocalizedShortName","()Ljava/lang/String;",1,2,3,new JHandler[]{},M1632));
c.Add(new JMethod(1633,"forge/deck/DeckSection","validate","(Lforge/item/PaperCard;)Z",1,2,2,new JHandler[]{},M1633));
c.Add(new JMethod(1634,"forge/deck/DeckSection","matchingSection","(Lforge/item/PaperCard;)Lforge/deck/DeckSection;",9,1,2,new JHandler[]{},M1634));
c.Add(new JMethod(1635,"forge/deck/DeckSection","smartValueOf","(Ljava/lang/String;)Lforge/deck/DeckSection;",9,6,2,new JHandler[]{},M1635));
c.Add(new JMethod(1636,"forge/deck/DeckSection","$values","()[Lforge/deck/DeckSection;",4106,0,4,new JHandler[]{},M1636));
c.Add(new JMethod(1637,"forge/deck/DeckSection","<clinit>","()V",8,0,6,new JHandler[]{},M1637));
}

internal static JStep M1628(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/deck/DeckSection","$VALUES","[Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","$VALUES","[Lforge/deck/DeckSection;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/deck/DeckSection;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/deck/DeckSection;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1629(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/deck/DeckSection")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckSection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1630(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckSection","nameLbl","Ljava/lang/String;",value);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[4]);f.Pc=14;continue;}
case 14:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckSection","fnValidator","Ljava/util/function/Predicate;",value);f.Pc=17;continue;}
case 17:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1631(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckSection","nameLbl","Ljava/lang/String;"));f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1632(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/deck/DeckSection$1","$SwitchMap$forge$deck$DeckSection","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection$1","$SwitchMap$forge$deck$DeckSection","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/DeckSection","ordinal","()I","invokevirtual",7);}
case 7:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8;continue;}
case 8:{switch(f.Pop().Int){case 1:f.Pc=40;break;case 2:f.Pc=46;break;case 3:f.Pc=52;break;case 4:f.Pc=58;break;default:f.Pc=64;break;}continue;}
case 40:{f.Push(JValue.R(rt.String("lblMain")));f.Pc=42;continue;}
case 42:{f.Locals[1]=f.Pop();f.Pc=43;continue;}
case 43:{f.Pc=69;continue;}
case 46:{f.Push(JValue.R(rt.String("lblSide")));f.Pc=48;continue;}
case 48:{f.Locals[1]=f.Pop();f.Pc=49;continue;}
case 49:{f.Pc=69;continue;}
case 52:{f.Push(JValue.R(rt.String("lblPlanes")));f.Pc=54;continue;}
case 54:{f.Locals[1]=f.Pop();f.Pc=55;continue;}
case 55:{f.Pc=69;continue;}
case 58:{f.Push(JValue.R(rt.String("lblSchemes")));f.Pc=60;continue;}
case 60:{f.Locals[1]=f.Pop();f.Pc=61;continue;}
case 61:{f.Pc=69;continue;}
case 64:{f.Push(f.Locals[0]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/deck/DeckSection","getLocalizedName","()Ljava/lang/String;","invokevirtual",68);}
case 68:{return JStep.Return(f.Pop());}
case 69:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",72);}
case 72:{f.Push(f.Locals[1]);f.Pc=73;continue;}
case 73:{f.Push(JValue.I(0));f.Pc=74;continue;}
case 74:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",80);}
case 80:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1633(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckSection","fnValidator","Ljava/util/function/Predicate;"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Reference!=null?9:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckSection","fnValidator","Ljava/util/function/Predicate;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",19);}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1634(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/DeckSection","validate","(Lforge/item/PaperCard;)Z","invokevirtual",7);}
case 7:{f.Pc=f.Pop().Int==0?14:10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"));f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
case 14:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Schemes","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Schemes","Lforge/deck/DeckSection;"));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/deck/DeckSection","validate","(Lforge/item/PaperCard;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?28:24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Schemes","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Schemes","Lforge/deck/DeckSection;"));f.Pc=27;continue;}
case 27:{return JStep.Return(f.Pop());}
case 28:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"));f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/deck/DeckSection","validate","(Lforge/item/PaperCard;)Z","invokevirtual",35);}
case 35:{f.Pc=f.Pop().Int==0?42:38;continue;}
case 38:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"));f.Pc=41;continue;}
case 41:{return JStep.Return(f.Pop());}
case 42:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Planes","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Planes","Lforge/deck/DeckSection;"));f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/deck/DeckSection","validate","(Lforge/item/PaperCard;)Z","invokevirtual",49);}
case 49:{f.Pc=f.Pop().Int==0?56:52;continue;}
case 52:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Planes","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Planes","Lforge/deck/DeckSection;"));f.Pc=55;continue;}
case 55:{return JStep.Return(f.Pop());}
case 56:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Dungeon","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Dungeon","Lforge/deck/DeckSection;"));f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/deck/DeckSection","validate","(Lforge/item/PaperCard;)Z","invokevirtual",63);}
case 63:{f.Pc=f.Pop().Int==0?70:66;continue;}
case 66:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Dungeon","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Dungeon","Lforge/deck/DeckSection;"));f.Pc=69;continue;}
case 69:{return JStep.Return(f.Pop());}
case 70:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"));f.Pc=73;continue;}
case 73:{f.Push(f.Locals[0]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/deck/DeckSection","validate","(Lforge/item/PaperCard;)Z","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Int==0?84:80;continue;}
case 80:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"));f.Pc=83;continue;}
case 83:{return JStep.Return(f.Pop());}
case 84:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"));f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/deck/DeckSection","validate","(Lforge/item/PaperCard;)Z","invokevirtual",91);}
case 91:{f.Pc=f.Pop().Int==0?98:94;continue;}
case 94:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"));f.Pc=97;continue;}
case 97:{return JStep.Return(f.Pop());}
case 98:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"));f.Pc=101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/deck/DeckSection","validate","(Lforge/item/PaperCard;)Z","invokevirtual",105);}
case 105:{f.Pc=f.Pop().Int==0?112:108;continue;}
case 108:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"));f.Pc=111;continue;}
case 111:{return JStep.Return(f.Pop());}
case 112:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=115;continue;}
case 115:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1635(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[1]=f.Pop();f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/deck/DeckSection","values","()[Lforge/deck/DeckSection;","invokestatic",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=17;continue;}
case 17:{f.Locals[3]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[4]);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?54:27;continue;}
case 27:{f.Push(f.Locals[2]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=31;continue;}
case 31:{f.Locals[5]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[5]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/deck/DeckSection","name","()Ljava/lang/String;","invokevirtual",38);}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","compareToIgnoreCase","(Ljava/lang/String;)I","invokevirtual",42);}
case 42:{f.Pc=f.Pop().Int!=0?48:45;continue;}
case 45:{f.Push(f.Locals[5]);f.Pc=47;continue;}
case 47:{return JStep.Return(f.Pop());}
case 48:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=51;continue;}
case 51:{f.Pc=21;continue;}
case 54:{f.Push(JValue.R(null));f.Pc=55;continue;}
case 55:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1636(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(11));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/deck/DeckSection;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Planes","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Planes","Lforge/deck/DeckSection;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Schemes","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Schemes","Lforge/deck/DeckSection;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Dungeon","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Dungeon","Lforge/deck/DeckSection;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1637(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/DeckSection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckSection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Main")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("lblMainDeck")));f.Pc=9;continue;}
case 9:{if(!rt.StaticReady(f,"forge/deck/DeckSection$Validators","DECK_AND_SIDE_VALIDATOR","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection$Validators","DECK_AND_SIDE_VALIDATOR","Ljava/util/function/Predicate;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/deck/DeckSection","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/util/function/Predicate;)V","invokespecial",15);}
case 15:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;",f.Pop());f.Pc=18;continue;}
case 18:{if(!rt.EnsureInitialized(f,"forge/deck/DeckSection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckSection")));f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("Sideboard")));f.Pc=24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("lblSideboard")));f.Pc=27;continue;}
case 27:{if(!rt.StaticReady(f,"forge/deck/DeckSection$Validators","DECK_AND_SIDE_VALIDATOR","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection$Validators","DECK_AND_SIDE_VALIDATOR","Ljava/util/function/Predicate;"));f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/deck/DeckSection","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/util/function/Predicate;)V","invokespecial",33);}
case 33:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;",f.Pop());f.Pc=36;continue;}
case 36:{if(!rt.EnsureInitialized(f,"forge/deck/DeckSection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckSection")));f.Pc=39;continue;}
case 39:{f.StackOp("dup");f.Pc=40;continue;}
case 40:{f.Push(JValue.R(rt.String("Commander")));f.Pc=42;continue;}
case 42:{f.Push(JValue.I(2));f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("lblCommander")));f.Pc=45;continue;}
case 45:{if(!rt.StaticReady(f,"forge/deck/DeckSection$Validators","COMMANDER_VALIDATOR","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection$Validators","COMMANDER_VALIDATOR","Ljava/util/function/Predicate;"));f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/deck/DeckSection","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/util/function/Predicate;)V","invokespecial",51);}
case 51:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;",f.Pop());f.Pc=54;continue;}
case 54:{if(!rt.EnsureInitialized(f,"forge/deck/DeckSection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckSection")));f.Pc=57;continue;}
case 57:{f.StackOp("dup");f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("Avatar")));f.Pc=60;continue;}
case 60:{f.Push(JValue.I(3));f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("lblAvatar")));f.Pc=63;continue;}
case 63:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_VANGUARD","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_VANGUARD","Ljava/util/function/Predicate;"));f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",69);}
case 69:{return rt.Call(f,"forge/deck/DeckSection","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/util/function/Predicate;)V","invokespecial",72);}
case 72:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;",f.Pop());f.Pc=75;continue;}
case 75:{if(!rt.EnsureInitialized(f,"forge/deck/DeckSection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckSection")));f.Pc=78;continue;}
case 78:{f.StackOp("dup");f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("Planes")));f.Pc=81;continue;}
case 81:{f.Push(JValue.I(4));f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("lblPlanarDeck")));f.Pc=84;continue;}
case 84:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_PLANE_OR_PHENOMENON","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_PLANE_OR_PHENOMENON","Ljava/util/function/Predicate;"));f.Pc=87;continue;}
case 87:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",90);}
case 90:{return rt.Call(f,"forge/deck/DeckSection","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/util/function/Predicate;)V","invokespecial",93);}
case 93:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Planes","Lforge/deck/DeckSection;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckSection","Planes","Lforge/deck/DeckSection;",f.Pop());f.Pc=96;continue;}
case 96:{if(!rt.EnsureInitialized(f,"forge/deck/DeckSection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckSection")));f.Pc=99;continue;}
case 99:{f.StackOp("dup");f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.String("Schemes")));f.Pc=102;continue;}
case 102:{f.Push(JValue.I(5));f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("lblSchemeDeck")));f.Pc=105;continue;}
case 105:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_SCHEME","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_SCHEME","Ljava/util/function/Predicate;"));f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",111);}
case 111:{return rt.Call(f,"forge/deck/DeckSection","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/util/function/Predicate;)V","invokespecial",114);}
case 114:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Schemes","Lforge/deck/DeckSection;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckSection","Schemes","Lforge/deck/DeckSection;",f.Pop());f.Pc=117;continue;}
case 117:{if(!rt.EnsureInitialized(f,"forge/deck/DeckSection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckSection")));f.Pc=120;continue;}
case 120:{f.StackOp("dup");f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("Conspiracy")));f.Pc=123;continue;}
case 123:{f.Push(JValue.I(6));f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String("lblConspiracies")));f.Pc=127;continue;}
case 127:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_CONSPIRACY","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_CONSPIRACY","Ljava/util/function/Predicate;"));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",133);}
case 133:{return rt.Call(f,"forge/deck/DeckSection","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/util/function/Predicate;)V","invokespecial",136);}
case 136:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;",f.Pop());f.Pc=139;continue;}
case 139:{if(!rt.EnsureInitialized(f,"forge/deck/DeckSection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckSection")));f.Pc=142;continue;}
case 142:{f.StackOp("dup");f.Pc=143;continue;}
case 143:{f.Push(JValue.R(rt.String("Dungeon")));f.Pc=145;continue;}
case 145:{f.Push(JValue.I(7));f.Pc=147;continue;}
case 147:{f.Push(JValue.R(rt.String("lblDungeons")));f.Pc=149;continue;}
case 149:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_DUNGEON","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_DUNGEON","Ljava/util/function/Predicate;"));f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",155);}
case 155:{return rt.Call(f,"forge/deck/DeckSection","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/util/function/Predicate;)V","invokespecial",158);}
case 158:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Dungeon","Lforge/deck/DeckSection;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckSection","Dungeon","Lforge/deck/DeckSection;",f.Pop());f.Pc=161;continue;}
case 161:{if(!rt.EnsureInitialized(f,"forge/deck/DeckSection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckSection")));f.Pc=164;continue;}
case 164:{f.StackOp("dup");f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("Attractions")));f.Pc=167;continue;}
case 167:{f.Push(JValue.I(8));f.Pc=169;continue;}
case 169:{f.Push(JValue.R(rt.String("lblAttractions")));f.Pc=171;continue;}
case 171:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_ATTRACTION","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_ATTRACTION","Ljava/util/function/Predicate;"));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",177);}
case 177:{return rt.Call(f,"forge/deck/DeckSection","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/util/function/Predicate;)V","invokespecial",180);}
case 180:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;",f.Pop());f.Pc=183;continue;}
case 183:{if(!rt.EnsureInitialized(f,"forge/deck/DeckSection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckSection")));f.Pc=186;continue;}
case 186:{f.StackOp("dup");f.Pc=187;continue;}
case 187:{f.Push(JValue.R(rt.String("Contraptions")));f.Pc=189;continue;}
case 189:{f.Push(JValue.I(9));f.Pc=191;continue;}
case 191:{f.Push(JValue.R(rt.String("lblContraptions")));f.Pc=193;continue;}
case 193:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_CONTRAPTION","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_CONTRAPTION","Ljava/util/function/Predicate;"));f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",199);}
case 199:{return rt.Call(f,"forge/deck/DeckSection","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/util/function/Predicate;)V","invokespecial",202);}
case 202:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;",f.Pop());f.Pc=205;continue;}
case 205:{if(!rt.EnsureInitialized(f,"forge/deck/DeckSection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckSection")));f.Pc=208;continue;}
case 208:{f.StackOp("dup");f.Pc=209;continue;}
case 209:{f.Push(JValue.R(rt.String("Stickers")));f.Pc=211;continue;}
case 211:{f.Push(JValue.I(10));f.Pc=213;continue;}
case 213:{f.Push(JValue.R(rt.String("lblStickerSheets")));f.Pc=215;continue;}
case 215:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates","IS_STICKER_SHEET","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates","IS_STICKER_SHEET","Ljava/util/function/Predicate;"));f.Pc=218;continue;}
case 218:{return rt.Call(f,"forge/item/PaperCardPredicates","fromRules","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokestatic",221);}
case 221:{return rt.Call(f,"forge/deck/DeckSection","<init>","(Ljava/lang/String;ILjava/lang/String;Ljava/util/function/Predicate;)V","invokespecial",224);}
case 224:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;",f.Pop());f.Pc=227;continue;}
case 227:{return rt.Call(f,"forge/deck/DeckSection","$values","()[Lforge/deck/DeckSection;","invokestatic",230);}
case 230:{if(!rt.StaticReady(f,"forge/deck/DeckSection","$VALUES","[Lforge/deck/DeckSection;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckSection","$VALUES","[Lforge/deck/DeckSection;",f.Pop());f.Pc=233;continue;}
case 233:{f.Push(JValue.I(8));f.Pc=235;continue;}
case 235:{f.Push(JValue.R(rt.NewArray("Lforge/deck/DeckSection;",f.Pop().Int)));f.Pc=238;continue;}
case 238:{f.StackOp("dup");f.Pc=239;continue;}
case 239:{f.Push(JValue.I(0));f.Pc=240;continue;}
case 240:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"));f.Pc=243;continue;}
case 243:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=244;continue;}
case 244:{f.StackOp("dup");f.Pc=245;continue;}
case 245:{f.Push(JValue.I(1));f.Pc=246;continue;}
case 246:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Planes","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Planes","Lforge/deck/DeckSection;"));f.Pc=249;continue;}
case 249:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=250;continue;}
case 250:{f.StackOp("dup");f.Pc=251;continue;}
case 251:{f.Push(JValue.I(2));f.Pc=252;continue;}
case 252:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Schemes","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Schemes","Lforge/deck/DeckSection;"));f.Pc=255;continue;}
case 255:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=256;continue;}
case 256:{f.StackOp("dup");f.Pc=257;continue;}
case 257:{f.Push(JValue.I(3));f.Pc=258;continue;}
case 258:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"));f.Pc=261;continue;}
case 261:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=262;continue;}
case 262:{f.StackOp("dup");f.Pc=263;continue;}
case 263:{f.Push(JValue.I(4));f.Pc=264;continue;}
case 264:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Dungeon","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Dungeon","Lforge/deck/DeckSection;"));f.Pc=267;continue;}
case 267:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=268;continue;}
case 268:{f.StackOp("dup");f.Pc=269;continue;}
case 269:{f.Push(JValue.I(5));f.Pc=270;continue;}
case 270:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"));f.Pc=273;continue;}
case 273:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=274;continue;}
case 274:{f.StackOp("dup");f.Pc=275;continue;}
case 275:{f.Push(JValue.I(6));f.Pc=277;continue;}
case 277:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"));f.Pc=280;continue;}
case 280:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=281;continue;}
case 281:{f.StackOp("dup");f.Pc=282;continue;}
case 282:{f.Push(JValue.I(7));f.Pc=284;continue;}
case 284:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Stickers","Lforge/deck/DeckSection;"));f.Pc=287;continue;}
case 287:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=288;continue;}
case 288:{if(!rt.StaticReady(f,"forge/deck/DeckSection","NONTRADITIONAL_SECTIONS","[Lforge/deck/DeckSection;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckSection","NONTRADITIONAL_SECTIONS","[Lforge/deck/DeckSection;",f.Pop());f.Pc=291;continue;}
case 291:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
