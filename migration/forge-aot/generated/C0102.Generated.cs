// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C102{
internal static JClass Build(){var c=new JClass("forge/deck/DeckRecognizer$TokenType","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("LEGAL_CARD","Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("LIMITED_CARD","Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("CARD_FROM_NOT_ALLOWED_SET","Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("CARD_FROM_INVALID_SET","Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("FREE_CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("WARNING_MESSAGE","Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("UNKNOWN_CARD","Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("UNSUPPORTED_CARD","Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("UNSUPPORTED_DECK_SECTION","Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("UNKNOWN_TEXT","Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("COMMENT","Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("DECK_NAME","Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("DECK_SECTION_NAME","Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("CARD_TYPE","Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("CARD_RARITY","Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("CARD_CMC","Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("MANA_COLOUR","Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("CARD_TOKEN_TYPES","Ljava/util/EnumSet;",true,JValue.Default("Ljava/util/EnumSet;"),null));
c.Add(new JField("IN_DECK_TOKEN_TYPES","Ljava/util/EnumSet;",true,JValue.Default("Ljava/util/EnumSet;"),null));
c.Add(new JField("CARD_PLACEHOLDER_TOKEN_TYPES","Ljava/util/EnumSet;",true,JValue.Default("Ljava/util/EnumSet;"),null));
c.Add(new JField("$VALUES","[Lforge/deck/DeckRecognizer$TokenType;",true,JValue.Default("[Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JMethod(1603,"forge/deck/DeckRecognizer$TokenType","values","()[Lforge/deck/DeckRecognizer$TokenType;",9,0,1,new JHandler[]{},M1603));
c.Add(new JMethod(1604,"forge/deck/DeckRecognizer$TokenType","valueOf","(Ljava/lang/String;)Lforge/deck/DeckRecognizer$TokenType;",9,1,2,new JHandler[]{},M1604));
c.Add(new JMethod(1605,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V",2,3,3,new JHandler[]{},M1605));
c.Add(new JMethod(1606,"forge/deck/DeckRecognizer$TokenType","$values","()[Lforge/deck/DeckRecognizer$TokenType;",4106,0,4,new JHandler[]{},M1606));
c.Add(new JMethod(1607,"forge/deck/DeckRecognizer$TokenType","<clinit>","()V",8,0,5,new JHandler[]{},M1607));
}

internal static JStep M1603(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","$VALUES","[Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","$VALUES","[Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/deck/DeckRecognizer$TokenType;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/deck/DeckRecognizer$TokenType;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1604(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/deck/DeckRecognizer$TokenType")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/deck/DeckRecognizer$TokenType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1605(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1606(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(18));f.Pc=2;continue;}
case 2:{f.Push(JValue.R(rt.NewArray("Lforge/deck/DeckRecognizer$TokenType;",f.Pop().Int)));f.Pc=5;continue;}
case 5:{f.StackOp("dup");f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","LEGAL_CARD","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","LEGAL_CARD","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=10;continue;}
case 10:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{f.Push(JValue.I(1));f.Pc=13;continue;}
case 13:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","LIMITED_CARD","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","LIMITED_CARD","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=16;continue;}
case 16:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=17;continue;}
case 17:{f.StackOp("dup");f.Pc=18;continue;}
case 18:{f.Push(JValue.I(2));f.Pc=19;continue;}
case 19:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_FROM_NOT_ALLOWED_SET","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_FROM_NOT_ALLOWED_SET","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=22;continue;}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(3));f.Pc=25;continue;}
case 25:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_FROM_INVALID_SET","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_FROM_INVALID_SET","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.I(4));f.Pc=31;continue;}
case 31:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=34;continue;}
case 34:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{f.Push(JValue.I(5));f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","FREE_CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","FREE_CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=40;continue;}
case 40:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=41;continue;}
case 41:{f.StackOp("dup");f.Pc=42;continue;}
case 42:{f.Push(JValue.I(6));f.Pc=44;continue;}
case 44:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","WARNING_MESSAGE","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","WARNING_MESSAGE","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.I(7));f.Pc=51;continue;}
case 51:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","UNKNOWN_CARD","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","UNKNOWN_CARD","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=54;continue;}
case 54:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.I(8));f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","UNSUPPORTED_CARD","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","UNSUPPORTED_CARD","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=61;continue;}
case 61:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{f.Push(JValue.I(9));f.Pc=65;continue;}
case 65:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","UNSUPPORTED_DECK_SECTION","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","UNSUPPORTED_DECK_SECTION","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=68;continue;}
case 68:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=69;continue;}
case 69:{f.StackOp("dup");f.Pc=70;continue;}
case 70:{f.Push(JValue.I(10));f.Pc=72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","UNKNOWN_TEXT","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","UNKNOWN_TEXT","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=75;continue;}
case 75:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=76;continue;}
case 76:{f.StackOp("dup");f.Pc=77;continue;}
case 77:{f.Push(JValue.I(11));f.Pc=79;continue;}
case 79:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","COMMENT","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","COMMENT","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=82;continue;}
case 82:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=83;continue;}
case 83:{f.StackOp("dup");f.Pc=84;continue;}
case 84:{f.Push(JValue.I(12));f.Pc=86;continue;}
case 86:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","DECK_NAME","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","DECK_NAME","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=89;continue;}
case 89:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=90;continue;}
case 90:{f.StackOp("dup");f.Pc=91;continue;}
case 91:{f.Push(JValue.I(13));f.Pc=93;continue;}
case 93:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","DECK_SECTION_NAME","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","DECK_SECTION_NAME","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=96;continue;}
case 96:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=97;continue;}
case 97:{f.StackOp("dup");f.Pc=98;continue;}
case 98:{f.Push(JValue.I(14));f.Pc=100;continue;}
case 100:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_TYPE","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_TYPE","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=103;continue;}
case 103:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=104;continue;}
case 104:{f.StackOp("dup");f.Pc=105;continue;}
case 105:{f.Push(JValue.I(15));f.Pc=107;continue;}
case 107:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_RARITY","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_RARITY","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=110;continue;}
case 110:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=111;continue;}
case 111:{f.StackOp("dup");f.Pc=112;continue;}
case 112:{f.Push(JValue.I(16));f.Pc=114;continue;}
case 114:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_CMC","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_CMC","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=117;continue;}
case 117:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=118;continue;}
case 118:{f.StackOp("dup");f.Pc=119;continue;}
case 119:{f.Push(JValue.I(17));f.Pc=121;continue;}
case 121:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","MANA_COLOUR","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","MANA_COLOUR","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=124;continue;}
case 124:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=125;continue;}
case 125:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1607(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$TokenType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$TokenType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("LEGAL_CARD")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V","invokespecial",10);}
case 10:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","LEGAL_CARD","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","LEGAL_CARD","Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=13;continue;}
case 13:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$TokenType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$TokenType")));f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.R(rt.String("LIMITED_CARD")));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V","invokespecial",23);}
case 23:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","LIMITED_CARD","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","LIMITED_CARD","Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=26;continue;}
case 26:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$TokenType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$TokenType")));f.Pc=29;continue;}
case 29:{f.StackOp("dup");f.Pc=30;continue;}
case 30:{f.Push(JValue.R(rt.String("CARD_FROM_NOT_ALLOWED_SET")));f.Pc=32;continue;}
case 32:{f.Push(JValue.I(2));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V","invokespecial",36);}
case 36:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_FROM_NOT_ALLOWED_SET","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","CARD_FROM_NOT_ALLOWED_SET","Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=39;continue;}
case 39:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$TokenType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$TokenType")));f.Pc=42;continue;}
case 42:{f.StackOp("dup");f.Pc=43;continue;}
case 43:{f.Push(JValue.R(rt.String("CARD_FROM_INVALID_SET")));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(3));f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V","invokespecial",49);}
case 49:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_FROM_INVALID_SET","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","CARD_FROM_INVALID_SET","Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=52;continue;}
case 52:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$TokenType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$TokenType")));f.Pc=55;continue;}
case 55:{f.StackOp("dup");f.Pc=56;continue;}
case 56:{f.Push(JValue.R(rt.String("CARD_NOT_IN_INVENTORY")));f.Pc=58;continue;}
case 58:{f.Push(JValue.I(4));f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V","invokespecial",62);}
case 62:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=65;continue;}
case 65:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$TokenType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$TokenType")));f.Pc=68;continue;}
case 68:{f.StackOp("dup");f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("FREE_CARD_NOT_IN_INVENTORY")));f.Pc=71;continue;}
case 71:{f.Push(JValue.I(5));f.Pc=72;continue;}
case 72:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V","invokespecial",75);}
case 75:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","FREE_CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","FREE_CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=78;continue;}
case 78:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$TokenType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$TokenType")));f.Pc=81;continue;}
case 81:{f.StackOp("dup");f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String("WARNING_MESSAGE")));f.Pc=84;continue;}
case 84:{f.Push(JValue.I(6));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V","invokespecial",89);}
case 89:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","WARNING_MESSAGE","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","WARNING_MESSAGE","Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=92;continue;}
case 92:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$TokenType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$TokenType")));f.Pc=95;continue;}
case 95:{f.StackOp("dup");f.Pc=96;continue;}
case 96:{f.Push(JValue.R(rt.String("UNKNOWN_CARD")));f.Pc=98;continue;}
case 98:{f.Push(JValue.I(7));f.Pc=100;continue;}
case 100:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V","invokespecial",103);}
case 103:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","UNKNOWN_CARD","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","UNKNOWN_CARD","Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=106;continue;}
case 106:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$TokenType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$TokenType")));f.Pc=109;continue;}
case 109:{f.StackOp("dup");f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("UNSUPPORTED_CARD")));f.Pc=112;continue;}
case 112:{f.Push(JValue.I(8));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V","invokespecial",117);}
case 117:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","UNSUPPORTED_CARD","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","UNSUPPORTED_CARD","Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=120;continue;}
case 120:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$TokenType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$TokenType")));f.Pc=123;continue;}
case 123:{f.StackOp("dup");f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("UNSUPPORTED_DECK_SECTION")));f.Pc=126;continue;}
case 126:{f.Push(JValue.I(9));f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V","invokespecial",131);}
case 131:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","UNSUPPORTED_DECK_SECTION","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","UNSUPPORTED_DECK_SECTION","Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=134;continue;}
case 134:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$TokenType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$TokenType")));f.Pc=137;continue;}
case 137:{f.StackOp("dup");f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("UNKNOWN_TEXT")));f.Pc=140;continue;}
case 140:{f.Push(JValue.I(10));f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V","invokespecial",145);}
case 145:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","UNKNOWN_TEXT","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","UNKNOWN_TEXT","Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=148;continue;}
case 148:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$TokenType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$TokenType")));f.Pc=151;continue;}
case 151:{f.StackOp("dup");f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String("COMMENT")));f.Pc=154;continue;}
case 154:{f.Push(JValue.I(11));f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V","invokespecial",159);}
case 159:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","COMMENT","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","COMMENT","Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=162;continue;}
case 162:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$TokenType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$TokenType")));f.Pc=165;continue;}
case 165:{f.StackOp("dup");f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("DECK_NAME")));f.Pc=168;continue;}
case 168:{f.Push(JValue.I(12));f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V","invokespecial",173);}
case 173:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","DECK_NAME","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","DECK_NAME","Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=176;continue;}
case 176:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$TokenType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$TokenType")));f.Pc=179;continue;}
case 179:{f.StackOp("dup");f.Pc=180;continue;}
case 180:{f.Push(JValue.R(rt.String("DECK_SECTION_NAME")));f.Pc=182;continue;}
case 182:{f.Push(JValue.I(13));f.Pc=184;continue;}
case 184:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V","invokespecial",187);}
case 187:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","DECK_SECTION_NAME","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","DECK_SECTION_NAME","Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=190;continue;}
case 190:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$TokenType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$TokenType")));f.Pc=193;continue;}
case 193:{f.StackOp("dup");f.Pc=194;continue;}
case 194:{f.Push(JValue.R(rt.String("CARD_TYPE")));f.Pc=196;continue;}
case 196:{f.Push(JValue.I(14));f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V","invokespecial",201);}
case 201:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_TYPE","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","CARD_TYPE","Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=204;continue;}
case 204:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$TokenType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$TokenType")));f.Pc=207;continue;}
case 207:{f.StackOp("dup");f.Pc=208;continue;}
case 208:{f.Push(JValue.R(rt.String("CARD_RARITY")));f.Pc=210;continue;}
case 210:{f.Push(JValue.I(15));f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V","invokespecial",215);}
case 215:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_RARITY","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","CARD_RARITY","Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=218;continue;}
case 218:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$TokenType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$TokenType")));f.Pc=221;continue;}
case 221:{f.StackOp("dup");f.Pc=222;continue;}
case 222:{f.Push(JValue.R(rt.String("CARD_CMC")));f.Pc=224;continue;}
case 224:{f.Push(JValue.I(16));f.Pc=226;continue;}
case 226:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V","invokespecial",229);}
case 229:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_CMC","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","CARD_CMC","Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=232;continue;}
case 232:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$TokenType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$TokenType")));f.Pc=235;continue;}
case 235:{f.StackOp("dup");f.Pc=236;continue;}
case 236:{f.Push(JValue.R(rt.String("MANA_COLOUR")));f.Pc=238;continue;}
case 238:{f.Push(JValue.I(17));f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","<init>","(Ljava/lang/String;I)V","invokespecial",243);}
case 243:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","MANA_COLOUR","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","MANA_COLOUR","Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=246;continue;}
case 246:{return rt.Call(f,"forge/deck/DeckRecognizer$TokenType","$values","()[Lforge/deck/DeckRecognizer$TokenType;","invokestatic",249);}
case 249:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","$VALUES","[Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","$VALUES","[Lforge/deck/DeckRecognizer$TokenType;",f.Pop());f.Pc=252;continue;}
case 252:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","LEGAL_CARD","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","LEGAL_CARD","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=255;continue;}
case 255:{f.Push(JValue.I(5));f.Pc=256;continue;}
case 256:{f.Push(JValue.R(rt.NewArray("Lforge/deck/DeckRecognizer$TokenType;",f.Pop().Int)));f.Pc=259;continue;}
case 259:{f.StackOp("dup");f.Pc=260;continue;}
case 260:{f.Push(JValue.I(0));f.Pc=261;continue;}
case 261:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","LIMITED_CARD","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","LIMITED_CARD","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=264;continue;}
case 264:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=265;continue;}
case 265:{f.StackOp("dup");f.Pc=266;continue;}
case 266:{f.Push(JValue.I(1));f.Pc=267;continue;}
case 267:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_FROM_NOT_ALLOWED_SET","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_FROM_NOT_ALLOWED_SET","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=270;continue;}
case 270:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=271;continue;}
case 271:{f.StackOp("dup");f.Pc=272;continue;}
case 272:{f.Push(JValue.I(2));f.Pc=273;continue;}
case 273:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_FROM_INVALID_SET","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_FROM_INVALID_SET","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=276;continue;}
case 276:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=277;continue;}
case 277:{f.StackOp("dup");f.Pc=278;continue;}
case 278:{f.Push(JValue.I(3));f.Pc=279;continue;}
case 279:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=282;continue;}
case 282:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=283;continue;}
case 283:{f.StackOp("dup");f.Pc=284;continue;}
case 284:{f.Push(JValue.I(4));f.Pc=285;continue;}
case 285:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","FREE_CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","FREE_CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=288;continue;}
case 288:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=289;continue;}
case 289:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;[Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",292);}
case 292:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_TOKEN_TYPES","Ljava/util/EnumSet;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","CARD_TOKEN_TYPES","Ljava/util/EnumSet;",f.Pop());f.Pc=295;continue;}
case 295:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","LEGAL_CARD","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","LEGAL_CARD","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=298;continue;}
case 298:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","LIMITED_CARD","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","LIMITED_CARD","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=301;continue;}
case 301:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","DECK_NAME","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","DECK_NAME","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=304;continue;}
case 304:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","FREE_CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","FREE_CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=307;continue;}
case 307:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",310);}
case 310:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","IN_DECK_TOKEN_TYPES","Ljava/util/EnumSet;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","IN_DECK_TOKEN_TYPES","Ljava/util/EnumSet;",f.Pop());f.Pc=313;continue;}
case 313:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_TYPE","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_TYPE","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=316;continue;}
case 316:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_RARITY","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_RARITY","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=319;continue;}
case 319:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_CMC","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_CMC","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=322;continue;}
case 322:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","MANA_COLOUR","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","MANA_COLOUR","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=325;continue;}
case 325:{return rt.Call(f,"java/util/EnumSet","of","(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;","invokestatic",328);}
case 328:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_PLACEHOLDER_TOKEN_TYPES","Ljava/util/EnumSet;"))return JStep.Continue;rt.PutStatic("forge/deck/DeckRecognizer$TokenType","CARD_PLACEHOLDER_TOKEN_TYPES","Ljava/util/EnumSet;",f.Pop());f.Pc=331;continue;}
case 331:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
