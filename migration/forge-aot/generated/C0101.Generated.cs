// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C101{
internal static JClass Build(){var c=new JClass("forge/deck/DeckRecognizer$Token$TokenKey","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("KEYSEP","Ljava/lang/String;",true,JValue.Default("Ljava/lang/String;"),"|"));
c.Add(new JField("cardName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("setCode","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("collectorNumber","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("deckSection","Lforge/deck/DeckSection;",false,JValue.Default("Lforge/deck/DeckSection;"),null));
c.Add(new JField("tokenType","Lforge/deck/DeckRecognizer$TokenType;",false,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("limitedType","Lforge/deck/DeckRecognizer$LimitedCardType;",false,JValue.Default("Lforge/deck/DeckRecognizer$LimitedCardType;"),null));
c.Add(new JMethod(1599,"forge/deck/DeckRecognizer$Token$TokenKey","<init>","()V",1,1,1,new JHandler[]{},M1599));
c.Add(new JMethod(1600,"forge/deck/DeckRecognizer$Token$TokenKey","fromToken","(Lforge/deck/DeckRecognizer$Token;)Lforge/deck/DeckRecognizer$Token$TokenKey;",9,2,3,new JHandler[]{},M1600));
c.Add(new JMethod(1601,"forge/deck/DeckRecognizer$Token$TokenKey","toString","()Ljava/lang/String;",1,2,6,new JHandler[]{},M1601));
c.Add(new JMethod(1602,"forge/deck/DeckRecognizer$Token$TokenKey","fromString","(Ljava/lang/String;)Lforge/deck/DeckRecognizer$Token$TokenKey;",9,5,4,new JHandler[]{},M1602));
}

internal static JStep M1599(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1600(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","isCardToken","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?9:7;continue;}
case 7:{f.Push(JValue.R(null));f.Pc=8;continue;}
case 8:{return JStep.Return(f.Pop());}
case 9:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token$TokenKey"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token$TokenKey")));f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/deck/DeckRecognizer$Token$TokenKey","<init>","()V","invokespecial",16);}
case 16:{f.Locals[1]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","card","Lforge/item/PaperCard;"));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",25);}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","getCard","()Lforge/item/PaperCard;","invokevirtual",29);}
case 29:{return rt.Call(f,"forge/item/PaperCard","isFoil","()Z","invokevirtual",32);}
case 32:{return rt.Call(f,"forge/card/CardDb$CardRequest","compose","(Ljava/lang/String;Z)Ljava/lang/String;","invokestatic",35);}
case 35:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","cardName","Ljava/lang/String;",value);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","card","Lforge/item/PaperCard;"));f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",46);}
case 46:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","setCode","Ljava/lang/String;",value);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[1]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","card","Lforge/item/PaperCard;"));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",57);}
case 57:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","collectorNumber","Ljava/lang/String;",value);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","getType","()Lforge/deck/DeckRecognizer$TokenType;","invokevirtual",65);}
case 65:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","tokenType","Lforge/deck/DeckRecognizer$TokenType;",value);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","tokenSection","Lforge/deck/DeckSection;"));f.Pc=72;continue;}
case 72:{f.Pc=f.Pop().Reference==null?83:75;continue;}
case 75:{f.Push(f.Locals[1]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[0]);f.Pc=77;continue;}
case 77:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","tokenSection","Lforge/deck/DeckSection;"));f.Pc=80;continue;}
case 80:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","deckSection","Lforge/deck/DeckSection;",value);f.Pc=83;continue;}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","limitedCardType","Lforge/deck/DeckRecognizer$LimitedCardType;"));f.Pc=87;continue;}
case 87:{f.Pc=f.Pop().Reference==null?98:90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","limitedCardType","Lforge/deck/DeckRecognizer$LimitedCardType;"));f.Pc=95;continue;}
case 95:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","limitedType","Lforge/deck/DeckRecognizer$LimitedCardType;",value);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1601(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("%s%s%s%s%s")));f.Pc=11;continue;}
case 11:{f.Push(JValue.I(5));f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=15;continue;}
case 15:{f.StackOp("dup");f.Pc=16;continue;}
case 16:{f.Push(JValue.I(0));f.Pc=17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","cardName","Ljava/lang/String;"));f.Pc=21;continue;}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("|")));f.Pc=26;continue;}
case 26:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=27;continue;}
case 27:{f.StackOp("dup");f.Pc=28;continue;}
case 28:{f.Push(JValue.I(2));f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","setCode","Ljava/lang/String;"));f.Pc=33;continue;}
case 33:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=34;continue;}
case 34:{f.StackOp("dup");f.Pc=35;continue;}
case 35:{f.Push(JValue.I(3));f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("|")));f.Pc=38;continue;}
case 38:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=39;continue;}
case 39:{f.StackOp("dup");f.Pc=40;continue;}
case 40:{f.Push(JValue.I(4));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","collectorNumber","Ljava/lang/String;"));f.Pc=45;continue;}
case 45:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",49);}
case 49:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",52);}
case 52:{f.StackOp("pop");f.Pc=53;continue;}
case 53:{f.Push(f.Locals[0]);f.Pc=54;continue;}
case 54:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","deckSection","Lforge/deck/DeckSection;"));f.Pc=57;continue;}
case 57:{f.Pc=f.Pop().Reference==null?89:60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("%sD%s")));f.Pc=63;continue;}
case 63:{f.Push(JValue.I(2));f.Pc=64;continue;}
case 64:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=67;continue;}
case 67:{f.StackOp("dup");f.Pc=68;continue;}
case 68:{f.Push(JValue.I(0));f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("|")));f.Pc=71;continue;}
case 71:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=72;continue;}
case 72:{f.StackOp("dup");f.Pc=73;continue;}
case 73:{f.Push(JValue.I(1));f.Pc=74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","deckSection","Lforge/deck/DeckSection;"));f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/deck/DeckSection","name","()Ljava/lang/String;","invokevirtual",81);}
case 81:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",85);}
case 85:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",88);}
case 88:{f.StackOp("pop");f.Pc=89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("%sT%s")));f.Pc=92;continue;}
case 92:{f.Push(JValue.I(2));f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=96;continue;}
case 96:{f.StackOp("dup");f.Pc=97;continue;}
case 97:{f.Push(JValue.I(0));f.Pc=98;continue;}
case 98:{f.Push(JValue.R(rt.String("|")));f.Pc=100;continue;}
case 100:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=101;continue;}
case 101:{f.StackOp("dup");f.Pc=102;continue;}
case 102:{f.Push(JValue.I(1));f.Pc=103;continue;}
case 103:{f.Push(f.Locals[0]);f.Pc=104;continue;}
case 104:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","tokenType","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","name","()Ljava/lang/String;","invokevirtual",110);}
case 110:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",114);}
case 114:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",117);}
case 117:{f.StackOp("pop");f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","limitedType","Lforge/deck/DeckRecognizer$LimitedCardType;"));f.Pc=122;continue;}
case 122:{f.Pc=f.Pop().Reference==null?154:125;continue;}
case 125:{f.Push(f.Locals[1]);f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("%sL%s")));f.Pc=128;continue;}
case 128:{f.Push(JValue.I(2));f.Pc=129;continue;}
case 129:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=132;continue;}
case 132:{f.StackOp("dup");f.Pc=133;continue;}
case 133:{f.Push(JValue.I(0));f.Pc=134;continue;}
case 134:{f.Push(JValue.R(rt.String("|")));f.Pc=136;continue;}
case 136:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=137;continue;}
case 137:{f.StackOp("dup");f.Pc=138;continue;}
case 138:{f.Push(JValue.I(1));f.Pc=139;continue;}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","limitedType","Lforge/deck/DeckRecognizer$LimitedCardType;"));f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/deck/DeckRecognizer$LimitedCardType","name","()Ljava/lang/String;","invokevirtual",146);}
case 146:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=147;continue;}
case 147:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",150);}
case 150:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",153);}
case 153:{f.StackOp("pop");f.Pc=154;continue;}
case 154:{f.Push(f.Locals[1]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",158);}
case 158:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1602(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.String("|")));f.Pc=3;continue;}
case 3:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","split","(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;","invokestatic",6);}
case 6:{f.Locals[1]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=9;continue;}
case 9:{f.Push(JValue.I(4));f.Pc=10;continue;}
case 10:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?15:13;continue;}
case 13:{f.Push(JValue.R(null));f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
case 15:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token$TokenKey"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token$TokenKey")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/deck/DeckRecognizer$Token$TokenKey","<init>","()V","invokespecial",22);}
case 22:{f.Locals[2]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[2]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(JValue.I(0));f.Pc=26;continue;}
case 26:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=27;continue;}
case 27:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","cardName","Ljava/lang/String;",value);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[2]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(JValue.I(1));f.Pc=33;continue;}
case 33:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=34;continue;}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","setCode","Ljava/lang/String;",value);f.Pc=37;continue;}
case 37:{f.Push(f.Locals[2]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(JValue.I(2));f.Pc=40;continue;}
case 40:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=41;continue;}
case 41:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","collectorNumber","Ljava/lang/String;",value);f.Pc=44;continue;}
case 44:{f.Push(JValue.I(3));f.Pc=45;continue;}
case 45:{f.Locals[3]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[3]);f.Pc=48;continue;}
case 48:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("D")));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",54);}
case 54:{f.Pc=f.Pop().Int==0?74:57;continue;}
case 57:{f.Push(f.Locals[2]);f.Pc=58;continue;}
case 58:{f.Push(f.Locals[1]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=61;continue;}
case 61:{f.Push(JValue.I(1));f.Pc=62;continue;}
case 62:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",65);}
case 65:{return rt.Call(f,"forge/deck/DeckSection","valueOf","(Ljava/lang/String;)Lforge/deck/DeckSection;","invokestatic",68);}
case 68:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","deckSection","Lforge/deck/DeckSection;",value);f.Pc=71;continue;}
case 71:{f.Locals[3]=JValue.I(unchecked(f.Locals[3].Int+(1)));f.Pc=74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[3]);f.Pc=76;continue;}
case 76:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=77;continue;}
case 77:{f.Push(JValue.I(1));f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",81);}
case 81:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","valueOf","(Ljava/lang/String;)Lforge/deck/DeckRecognizer$TokenType;","invokestatic",84);}
case 84:{f.Locals[4]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[2]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[4]);f.Pc=89;continue;}
case 89:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","tokenType","Lforge/deck/DeckRecognizer$TokenType;",value);f.Pc=92;continue;}
case 92:{f.Push(f.Locals[4]);f.Pc=94;continue;}
case 94:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","LIMITED_CARD","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","LIMITED_CARD","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=97;continue;}
case 97:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?116:100;continue;}
case 100:{f.Push(f.Locals[2]);f.Pc=101;continue;}
case 101:{f.Push(f.Locals[1]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[3]);f.Pc=103;continue;}
case 103:{f.Push(JValue.I(1));f.Pc=104;continue;}
case 104:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=105;continue;}
case 105:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=106;continue;}
case 106:{f.Push(JValue.I(1));f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",110);}
case 110:{return rt.Call(f,"forge/deck/DeckRecognizer$LimitedCardType","valueOf","(Ljava/lang/String;)Lforge/deck/DeckRecognizer$LimitedCardType;","invokestatic",113);}
case 113:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token$TokenKey","limitedType","Lforge/deck/DeckRecognizer$LimitedCardType;",value);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[2]);f.Pc=117;continue;}
case 117:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
