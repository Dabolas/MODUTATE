// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C100{
internal static JClass Build(){var c=new JClass("forge/deck/DeckRecognizer$Token","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("type","Lforge/deck/DeckRecognizer$TokenType;",false,JValue.Default("Lforge/deck/DeckRecognizer$TokenType;"),null));
c.Add(new JField("number","I",false,JValue.Default("I"),null));
c.Add(new JField("text","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("limitedCardType","Lforge/deck/DeckRecognizer$LimitedCardType;",false,JValue.Default("Lforge/deck/DeckRecognizer$LimitedCardType;"),null));
c.Add(new JField("card","Lforge/item/PaperCard;",false,JValue.Default("Lforge/item/PaperCard;"),null));
c.Add(new JField("tokenSection","Lforge/deck/DeckSection;",false,JValue.Default("Lforge/deck/DeckSection;"),null));
c.Add(new JField("cardRequestHasSetCode","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(1568,"forge/deck/DeckRecognizer$Token","LegalCard","(Lforge/item/PaperCard;ILforge/deck/DeckSection;Z)Lforge/deck/DeckRecognizer$Token;",9,4,7,new JHandler[]{},M1568));
c.Add(new JMethod(1569,"forge/deck/DeckRecognizer$Token","LimitedCard","(Lforge/item/PaperCard;ILforge/deck/DeckSection;Lforge/deck/DeckRecognizer$LimitedCardType;Z)Lforge/deck/DeckRecognizer$Token;",9,5,8,new JHandler[]{},M1569));
c.Add(new JMethod(1570,"forge/deck/DeckRecognizer$Token","NotAllowedCard","(Lforge/item/PaperCard;IZ)Lforge/deck/DeckRecognizer$Token;",9,3,6,new JHandler[]{},M1570));
c.Add(new JMethod(1571,"forge/deck/DeckRecognizer$Token","CardInInvalidSet","(Lforge/item/PaperCard;IZ)Lforge/deck/DeckRecognizer$Token;",9,3,6,new JHandler[]{},M1571));
c.Add(new JMethod(1572,"forge/deck/DeckRecognizer$Token","NotInInventoryFree","(Lforge/item/PaperCard;ILforge/deck/DeckSection;)Lforge/deck/DeckRecognizer$Token;",9,3,7,new JHandler[]{},M1572));
c.Add(new JMethod(1573,"forge/deck/DeckRecognizer$Token","UnknownCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/deck/DeckRecognizer$Token;",9,4,5,new JHandler[]{},M1573));
c.Add(new JMethod(1574,"forge/deck/DeckRecognizer$Token","UnsupportedCard","(Ljava/lang/String;Ljava/lang/String;I)Lforge/deck/DeckRecognizer$Token;",9,4,5,new JHandler[]{},M1574));
c.Add(new JMethod(1575,"forge/deck/DeckRecognizer$Token","WarningMessage","(Ljava/lang/String;)Lforge/deck/DeckRecognizer$Token;",9,1,4,new JHandler[]{},M1575));
c.Add(new JMethod(1576,"forge/deck/DeckRecognizer$Token","NotInInventory","(Lforge/item/PaperCard;ILforge/deck/DeckSection;)Lforge/deck/DeckRecognizer$Token;",9,3,7,new JHandler[]{},M1576));
c.Add(new JMethod(1577,"forge/deck/DeckRecognizer$Token","UnsupportedDeckSection","(Ljava/lang/String;)Lforge/deck/DeckRecognizer$Token;",10,1,4,new JHandler[]{},M1577));
c.Add(new JMethod(1578,"forge/deck/DeckRecognizer$Token","DeckSection","(Ljava/lang/String;Ljava/util/List;)Lforge/deck/DeckRecognizer$Token;",9,4,4,new JHandler[]{},M1578));
c.Add(new JMethod(1579,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;ILforge/item/PaperCard;Z)V",2,5,2,new JHandler[]{},M1579));
c.Add(new JMethod(1580,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;ILforge/item/PaperCard;Lforge/deck/DeckSection;Z)V",2,6,5,new JHandler[]{},M1580));
c.Add(new JMethod(1581,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;ILforge/item/PaperCard;Lforge/deck/DeckSection;Lforge/deck/DeckRecognizer$LimitedCardType;Z)V",2,7,5,new JHandler[]{},M1581));
c.Add(new JMethod(1582,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;ILjava/lang/String;)V",1,4,2,new JHandler[]{},M1582));
c.Add(new JMethod(1583,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;Ljava/lang/String;)V",1,3,4,new JHandler[]{},M1583));
c.Add(new JMethod(1584,"forge/deck/DeckRecognizer$Token","getText","()Ljava/lang/String;",17,1,5,new JHandler[]{},M1584));
c.Add(new JMethod(1585,"forge/deck/DeckRecognizer$Token","getCard","()Lforge/item/PaperCard;",17,1,1,new JHandler[]{},M1585));
c.Add(new JMethod(1586,"forge/deck/DeckRecognizer$Token","getType","()Lforge/deck/DeckRecognizer$TokenType;",17,1,1,new JHandler[]{},M1586));
c.Add(new JMethod(1587,"forge/deck/DeckRecognizer$Token","getQuantity","()I",17,1,1,new JHandler[]{},M1587));
c.Add(new JMethod(1588,"forge/deck/DeckRecognizer$Token","cardRequestHasNoCode","()Z",17,1,1,new JHandler[]{},M1588));
c.Add(new JMethod(1589,"forge/deck/DeckRecognizer$Token","getTokenSection","()Lforge/deck/DeckSection;",17,1,1,new JHandler[]{},M1589));
c.Add(new JMethod(1590,"forge/deck/DeckRecognizer$Token","resetTokenSection","(Lforge/deck/DeckSection;)V",1,2,2,new JHandler[]{},M1590));
c.Add(new JMethod(1591,"forge/deck/DeckRecognizer$Token","replaceTokenCard","(Lforge/item/PaperCard;)V",1,2,2,new JHandler[]{},M1591));
c.Add(new JMethod(1592,"forge/deck/DeckRecognizer$Token","getLimitedCardType","()Lforge/deck/DeckRecognizer$LimitedCardType;",17,1,1,new JHandler[]{},M1592));
c.Add(new JMethod(1593,"forge/deck/DeckRecognizer$Token","isCardToken","()Z",1,1,2,new JHandler[]{},M1593));
c.Add(new JMethod(1594,"forge/deck/DeckRecognizer$Token","isTokenForDeck","()Z",1,1,2,new JHandler[]{},M1594));
c.Add(new JMethod(1595,"forge/deck/DeckRecognizer$Token","isCardTokenForDeck","()Z",1,1,1,new JHandler[]{},M1595));
c.Add(new JMethod(1596,"forge/deck/DeckRecognizer$Token","isCardPlaceholder","()Z",1,1,2,new JHandler[]{},M1596));
c.Add(new JMethod(1597,"forge/deck/DeckRecognizer$Token","isDeckSection","()Z",1,1,2,new JHandler[]{},M1597));
c.Add(new JMethod(1598,"forge/deck/DeckRecognizer$Token","getKey","()Lforge/deck/DeckRecognizer$Token$TokenKey;",1,1,1,new JHandler[]{},M1598));
}

internal static JStep M1568(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","LEGAL_CARD","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","LEGAL_CARD","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;ILforge/item/PaperCard;Lforge/deck/DeckSection;Z)V","invokespecial",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1569(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","LIMITED_CARD","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","LIMITED_CARD","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[4]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;ILforge/item/PaperCard;Lforge/deck/DeckSection;Lforge/deck/DeckRecognizer$LimitedCardType;Z)V","invokespecial",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1570(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_FROM_NOT_ALLOWED_SET","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_FROM_NOT_ALLOWED_SET","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;ILforge/item/PaperCard;Z)V","invokespecial",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1571(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_FROM_INVALID_SET","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_FROM_INVALID_SET","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;ILforge/item/PaperCard;Z)V","invokespecial",13);}
case 13:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1572(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","FREE_CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","FREE_CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;ILforge/item/PaperCard;Lforge/deck/DeckSection;Z)V","invokespecial",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1573(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?11:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?15:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Pc=32;continue;}
case 15:{f.Push(JValue.R(rt.String("%s [%s]")));f.Pc=17;continue;}
case 17:{f.Push(JValue.I(2));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",32);}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","UNKNOWN_CARD","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","UNKNOWN_CARD","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;ILjava/lang/String;)V","invokespecial",45);}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1574(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?11:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",8);}
case 8:{f.Pc=f.Pop().Int==0?15:11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Pc=32;continue;}
case 15:{f.Push(JValue.R(rt.String("%s [%s]")));f.Pc=17;continue;}
case 17:{f.Push(JValue.I(2));f.Pc=18;continue;}
case 18:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=21;continue;}
case 21:{f.StackOp("dup");f.Pc=22;continue;}
case 22:{f.Push(JValue.I(0));f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=25;continue;}
case 25:{f.StackOp("dup");f.Pc=26;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[1]);f.Pc=28;continue;}
case 28:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",32);}
case 32:{f.Locals[3]=f.Pop();f.Pc=33;continue;}
case 33:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token")));f.Pc=36;continue;}
case 36:{f.StackOp("dup");f.Pc=37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","UNSUPPORTED_CARD","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","UNSUPPORTED_CARD","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;ILjava/lang/String;)V","invokespecial",45);}
case 45:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1575(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","WARNING_MESSAGE","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","WARNING_MESSAGE","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;Ljava/lang/String;)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1576(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_NOT_IN_INVENTORY","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(0));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;ILforge/item/PaperCard;Lforge/deck/DeckSection;Z)V","invokespecial",14);}
case 14:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1577(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","UNSUPPORTED_DECK_SECTION","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","UNSUPPORTED_DECK_SECTION","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;Ljava/lang/String;)V","invokespecial",11);}
case 11:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1578(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(JValue.R(rt.String("side")));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int!=0?37:19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("sideboard")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int!=0?37:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("sb")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?44:37;continue;}
case 37:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Sideboard","Lforge/deck/DeckSection;"));f.Pc=40;continue;}
case 40:{f.Locals[3]=f.Pop();f.Pc=41;continue;}
case 41:{f.Pc=196;continue;}
case 44:{f.Push(f.Locals[2]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("main")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int!=0?80:53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{f.Push(JValue.R(rt.String("card")));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",59);}
case 59:{f.Pc=f.Pop().Int!=0?80:62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("mainboard")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int!=0?80:71;continue;}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.String("deck")));f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",77);}
case 77:{f.Pc=f.Pop().Int==0?87:80;continue;}
case 80:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=83;continue;}
case 83:{f.Locals[3]=f.Pop();f.Pc=84;continue;}
case 84:{f.Pc=196;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String("avatar")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int==0?103:96;continue;}
case 96:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Avatar","Lforge/deck/DeckSection;"));f.Pc=99;continue;}
case 99:{f.Locals[3]=f.Pop();f.Pc=100;continue;}
case 100:{f.Pc=196;continue;}
case 103:{f.Push(f.Locals[2]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("commander")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int==0?119:112;continue;}
case 112:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Commander","Lforge/deck/DeckSection;"));f.Pc=115;continue;}
case 115:{f.Locals[3]=f.Pop();f.Pc=116;continue;}
case 116:{f.Pc=196;continue;}
case 119:{f.Push(f.Locals[2]);f.Pc=120;continue;}
case 120:{f.Push(JValue.R(rt.String("schemes")));f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",125);}
case 125:{f.Pc=f.Pop().Int==0?135:128;continue;}
case 128:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Schemes","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Schemes","Lforge/deck/DeckSection;"));f.Pc=131;continue;}
case 131:{f.Locals[3]=f.Pop();f.Pc=132;continue;}
case 132:{f.Pc=196;continue;}
case 135:{f.Push(f.Locals[2]);f.Pc=136;continue;}
case 136:{f.Push(JValue.R(rt.String("conspiracy")));f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",141);}
case 141:{f.Pc=f.Pop().Int==0?151:144;continue;}
case 144:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Conspiracy","Lforge/deck/DeckSection;"));f.Pc=147;continue;}
case 147:{f.Locals[3]=f.Pop();f.Pc=148;continue;}
case 148:{f.Pc=196;continue;}
case 151:{f.Push(f.Locals[2]);f.Pc=152;continue;}
case 152:{f.Push(JValue.R(rt.String("planes")));f.Pc=154;continue;}
case 154:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",157);}
case 157:{f.Pc=f.Pop().Int==0?167:160;continue;}
case 160:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Planes","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Planes","Lforge/deck/DeckSection;"));f.Pc=163;continue;}
case 163:{f.Locals[3]=f.Pop();f.Pc=164;continue;}
case 164:{f.Pc=196;continue;}
case 167:{f.Push(f.Locals[2]);f.Pc=168;continue;}
case 168:{f.Push(JValue.R(rt.String("attractions")));f.Pc=170;continue;}
case 170:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",173);}
case 173:{f.Pc=f.Pop().Int==0?183:176;continue;}
case 176:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Attractions","Lforge/deck/DeckSection;"));f.Pc=179;continue;}
case 179:{f.Locals[3]=f.Pop();f.Pc=180;continue;}
case 180:{f.Pc=196;continue;}
case 183:{f.Push(f.Locals[2]);f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("contraptions")));f.Pc=186;continue;}
case 186:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",189);}
case 189:{f.Pc=f.Pop().Int==0?196:192;continue;}
case 192:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Contraptions","Lforge/deck/DeckSection;"));f.Pc=195;continue;}
case 195:{f.Locals[3]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[3]);f.Pc=197;continue;}
case 197:{f.Pc=f.Pop().Reference!=null?202:200;continue;}
case 200:{f.Push(JValue.R(null));f.Pc=201;continue;}
case 201:{return JStep.Return(f.Pop());}
case 202:{f.Push(f.Locals[1]);f.Pc=203;continue;}
case 203:{f.Pc=f.Pop().Reference==null?221:206;continue;}
case 206:{f.Push(f.Locals[1]);f.Pc=207;continue;}
case 207:{f.Push(f.Locals[3]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",213);}
case 213:{f.Pc=f.Pop().Int!=0?221:216;continue;}
case 216:{f.Push(f.Locals[0]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","UnsupportedDeckSection","(Ljava/lang/String;)Lforge/deck/DeckRecognizer$Token;","invokestatic",220);}
case 220:{return JStep.Return(f.Pop());}
case 221:{if(!rt.EnsureInitialized(f,"forge/deck/DeckRecognizer$Token"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/deck/DeckRecognizer$Token")));f.Pc=224;continue;}
case 224:{f.StackOp("dup");f.Pc=225;continue;}
case 225:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","DECK_SECTION_NAME","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","DECK_SECTION_NAME","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=228;continue;}
case 228:{f.Push(f.Locals[3]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/deck/DeckSection","name","()Ljava/lang/String;","invokevirtual",232);}
case 232:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;Ljava/lang/String;)V","invokespecial",235);}
case 235:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1579(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","limitedCardType","Lforge/deck/DeckRecognizer$LimitedCardType;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","card","Lforge/item/PaperCard;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(null));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","tokenSection","Lforge/deck/DeckSection;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","cardRequestHasSetCode","Z",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","number","I",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","type","Lforge/deck/DeckRecognizer$TokenType;",value);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(JValue.R(rt.String("")));f.Pc=37;continue;}
case 37:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","text","Ljava/lang/String;",value);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[0]);f.Pc=41;continue;}
case 41:{f.Push(f.Locals[3]);f.Pc=42;continue;}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","card","Lforge/item/PaperCard;",value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(JValue.R(null));f.Pc=47;continue;}
case 47:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","tokenSection","Lforge/deck/DeckSection;",value);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(null));f.Pc=52;continue;}
case 52:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","limitedCardType","Lforge/deck/DeckRecognizer$LimitedCardType;",value);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","cardRequestHasSetCode","Z",value);f.Pc=61;continue;}
case 61:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1580(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[5]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;ILforge/item/PaperCard;Z)V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","tokenSection","Lforge/deck/DeckSection;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","limitedCardType","Lforge/deck/DeckRecognizer$LimitedCardType;",value);f.Pc=20;continue;}
case 20:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1581(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Push(f.Locals[6]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;ILforge/item/PaperCard;Z)V","invokespecial",9);}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[4]);f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","tokenSection","Lforge/deck/DeckSection;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[5]);f.Pc=18;continue;}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","limitedCardType","Lforge/deck/DeckRecognizer$LimitedCardType;",value);f.Pc=21;continue;}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1582(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(null));f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","limitedCardType","Lforge/deck/DeckRecognizer$LimitedCardType;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.R(null));f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","card","Lforge/item/PaperCard;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(JValue.R(null));f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","tokenSection","Lforge/deck/DeckSection;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","cardRequestHasSetCode","Z",value);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","number","I",value);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","type","Lforge/deck/DeckRecognizer$TokenType;",value);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","text","Ljava/lang/String;",value);f.Pc=39;continue;}
case 39:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1583(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(0));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","<init>","(Lforge/deck/DeckRecognizer$TokenType;ILjava/lang/String;)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1584(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","isCardToken","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?47:7;continue;}
case 7:{f.Push(JValue.R(rt.String("%s [%s] #%s")));f.Pc=9;continue;}
case 9:{f.Push(JValue.I(3));f.Pc=10;continue;}
case 10:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","card","Lforge/item/PaperCard;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/item/PaperCard","getName","()Ljava/lang/String;","invokevirtual",22);}
case 22:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=23;continue;}
case 23:{f.StackOp("dup");f.Pc=24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","card","Lforge/item/PaperCard;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/item/PaperCard","getEdition","()Ljava/lang/String;","invokevirtual",32);}
case 32:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{f.Push(JValue.I(2));f.Pc=35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","card","Lforge/item/PaperCard;"));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/item/PaperCard","getCollectorNumber","()Ljava/lang/String;","invokevirtual",42);}
case 42:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",46);}
case 46:{return JStep.Return(f.Pop());}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","text","Ljava/lang/String;"));f.Pc=51;continue;}
case 51:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1585(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","card","Lforge/item/PaperCard;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1586(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","type","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1587(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","number","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1588(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","cardRequestHasSetCode","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?11:7;continue;}
case 7:{f.Push(JValue.I(1));f.Pc=8;continue;}
case 8:{f.Pc=12;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1589(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","tokenSection","Lforge/deck/DeckSection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1590(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Pc=f.Pop().Reference==null?9:5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Pc=12;continue;}
case 9:{if(!rt.StaticReady(f,"forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckSection","Main","Lforge/deck/DeckSection;"));f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","tokenSection","Lforge/deck/DeckSection;",value);f.Pc=15;continue;}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1591(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","isCardToken","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int!=0?8:7;continue;}
case 7:{return JStep.ReturnVoid;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[1]);f.Pc=10;continue;}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/deck/DeckRecognizer$Token","card","Lforge/item/PaperCard;",value);f.Pc=13;continue;}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1592(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","limitedCardType","Lforge/deck/DeckRecognizer$LimitedCardType;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1593(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_TOKEN_TYPES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_TOKEN_TYPES","Ljava/util/EnumSet;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","type","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1594(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","IN_DECK_TOKEN_TYPES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","IN_DECK_TOKEN_TYPES","Ljava/util/EnumSet;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","type","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1595(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","isCardToken","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?18:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/deck/DeckRecognizer$Token","isTokenForDeck","()Z","invokevirtual",11);}
case 11:{f.Pc=f.Pop().Int==0?18:14;continue;}
case 14:{f.Push(JValue.I(1));f.Pc=15;continue;}
case 15:{f.Pc=19;continue;}
case 18:{f.Push(JValue.I(0));f.Pc=19;continue;}
case 19:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1596(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","CARD_PLACEHOLDER_TOKEN_TYPES","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","CARD_PLACEHOLDER_TOKEN_TYPES","Ljava/util/EnumSet;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","type","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",10);}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1597(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/deck/DeckRecognizer$Token","type","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=4;continue;}
case 4:{if(!rt.StaticReady(f,"forge/deck/DeckRecognizer$TokenType","DECK_SECTION_NAME","Lforge/deck/DeckRecognizer$TokenType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/deck/DeckRecognizer$TokenType","DECK_SECTION_NAME","Lforge/deck/DeckRecognizer$TokenType;"));f.Pc=7;continue;}
case 7:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?14:10;continue;}
case 10:{f.Push(JValue.I(1));f.Pc=11;continue;}
case 11:{f.Pc=15;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M1598(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/deck/DeckRecognizer$Token$TokenKey","fromToken","(Lforge/deck/DeckRecognizer$Token;)Lforge/deck/DeckRecognizer$Token$TokenKey;","invokestatic",4);}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
