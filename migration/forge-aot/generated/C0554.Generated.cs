// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C554{
internal static JClass Build(){var c=new JClass("forge/game/cost/CostRemoveCounter","forge/game/cost/CostPart",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("serialVersionUID","J",true,JValue.L(1L),null));
c.Add(new JField("counter","Lforge/game/card/CounterType;",false,JValue.Default("Lforge/game/card/CounterType;"),null));
c.Add(new JField("zone","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("oneOrMore","Ljava/lang/Boolean;",false,JValue.Default("Ljava/lang/Boolean;"),null));
c.Add(new JMethod(6535,"forge/game/cost/CostRemoveCounter","<init>","(Ljava/lang/String;Lforge/game/card/CounterType;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Z)V",1,7,4,new JHandler[]{},M6535));
c.Add(new JMethod(6536,"forge/game/cost/CostRemoveCounter","paymentOrder","()I",1,1,1,new JHandler[]{},M6536));
c.Add(new JMethod(6537,"forge/game/cost/CostRemoveCounter","getMaxAmountX","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Ljava/lang/Integer;",1,12,5,new JHandler[]{},M6537));
c.Add(new JMethod(6538,"forge/game/cost/CostRemoveCounter","toString","()Ljava/lang/String;",17,5,3,new JHandler[]{},M6538));
c.Add(new JMethod(6539,"forge/game/cost/CostRemoveCounter","canPay","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Z",17,12,5,new JHandler[]{},M6539));
c.Add(new JMethod(6540,"forge/game/cost/CostRemoveCounter","payAsDecided","(Lforge/game/player/Player;Lforge/game/cost/PaymentDecision;Lforge/game/spellability/SpellAbility;Z)Z",1,10,4,new JHandler[]{},M6540));
c.Add(new JMethod(6541,"forge/game/cost/CostRemoveCounter","accept","(Lforge/game/cost/ICostVisitor;)Ljava/lang/Object;",1,2,2,new JHandler[]{},M6541));
}

internal static JStep M6535(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[3]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[4]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/cost/CostPart","<init>","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V","invokespecial",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[2]);f.Pc=10;continue;}
case 10:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostRemoveCounter","counter","Lforge/game/card/CounterType;",value);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[5]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostRemoveCounter","zone","Ljava/util/List;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[6]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",25);}
case 25:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/cost/CostRemoveCounter","oneOrMore","Ljava/lang/Boolean;",value);f.Pc=28;continue;}
case 28:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6536(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(8));f.Pc=2;continue;}
case 2:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6537(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostRemoveCounter","counter","Lforge/game/card/CounterType;"));f.Pc=4;continue;}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",10);}
case 10:{f.Locals[5]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/cost/CostRemoveCounter","getType","()Ljava/lang/String;","invokevirtual",16);}
case 16:{f.Locals[6]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Reference!=null?27:23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Pc=28;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{f.Locals[7]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/cost/CostRemoveCounter","payCostFromSource","()Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?61:37;continue;}
case 37:{f.Push(f.Locals[7]);f.Pc=39;continue;}
case 39:{f.Pc=f.Pop().Int==0?50:42;continue;}
case 42:{f.Push(f.Locals[5]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/game/card/Card","getNumAllCounters","()I","invokevirtual",47);}
case 47:{f.Pc=57;continue;}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[4]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",57);}
case 57:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",60);}
case 60:{return JStep.Return(f.Pop());}
case 61:{f.Push(f.Locals[6]);f.Pc=63;continue;}
case 63:{f.Push(JValue.R(rt.String("OriginalHost")));f.Pc=65;continue;}
case 65:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",68);}
case 68:{f.Pc=f.Pop().Int==0?90:71;continue;}
case 71:{f.Push(JValue.I(1));f.Pc=72;continue;}
case 72:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=75;continue;}
case 75:{f.StackOp("dup");f.Pc=76;continue;}
case 76:{f.Push(JValue.I(0));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",81);}
case 81:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=82;continue;}
case 82:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",85);}
case 85:{f.Locals[8]=f.Pop();f.Pc=87;continue;}
case 87:{f.Pc=114;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[0]);f.Pc=92;continue;}
case 92:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostRemoveCounter","zone","Ljava/util/List;"));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",98);}
case 98:{f.Push(f.Locals[6]);f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.String(";")));f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",105);}
case 105:{f.Push(f.Locals[2]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[5]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[1]);f.Pc=109;continue;}
case 109:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",112);}
case 112:{f.Locals[8]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(JValue.I(0));f.Pc=115;continue;}
case 115:{f.Locals[9]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[8]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",124);}
case 124:{f.Locals[10]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[10]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",133);}
case 133:{f.Pc=f.Pop().Int==0?183:136;continue;}
case 136:{f.Push(f.Locals[10]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",143);}
case 143:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=146;continue;}
case 146:{f.Locals[11]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[7]);f.Pc=150;continue;}
case 150:{f.Pc=f.Pop().Int==0?166:153;continue;}
case 153:{f.Push(f.Locals[9]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[11]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/game/card/Card","getNumAllCounters","()I","invokevirtual",160);}
case 160:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",163);}
case 163:{f.Pc=178;continue;}
case 166:{f.Push(f.Locals[9]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[11]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[4]);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",175);}
case 175:{return rt.Call(f,"java/lang/Math","max","(II)I","invokestatic",178);}
case 178:{f.Locals[9]=f.Pop();f.Pc=180;continue;}
case 180:{f.Pc=126;continue;}
case 183:{f.Push(f.Locals[9]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",188);}
case 188:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6538(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostRemoveCounter","counter","Lforge/game/card/CounterType;"));f.Pc=12;continue;}
case 12:{f.Pc=f.Pop().Reference!=null?19:15;continue;}
case 15:{f.Push(JValue.I(1));f.Pc=16;continue;}
case 16:{f.Pc=20;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{f.Locals[2]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[2]);f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Int==0?30:25;continue;}
case 25:{f.Push(JValue.R(rt.String("counters")));f.Pc=27;continue;}
case 27:{f.Pc=47;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostRemoveCounter","counter","Lforge/game/card/CounterType;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",39);}
case 39:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",42);}
case 42:{return rt.DynamicCall(f,"forge/game/cost/CostRemoveCounter:6538:42:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",47);}
case 47:{f.Locals[3]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostRemoveCounter","counter","Lforge/game/card/CounterType;"));f.Pc=52;continue;}
case 52:{f.Pc=f.Pop().Reference==null?94:55;continue;}
case 55:{f.Push(f.Locals[0]);f.Pc=56;continue;}
case 56:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostRemoveCounter","counter","Lforge/game/card/CounterType;"));f.Pc=59;continue;}
case 59:{if(!rt.StaticReady(f,"forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CounterEnumType","LOYALTY","Lforge/game/card/CounterEnumType;"));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/card/CounterType","is","(Lforge/game/card/CounterEnumType;)Z","invokeinterface",67);}
case 67:{f.Pc=f.Pop().Int==0?94:70;continue;}
case 70:{f.Push(f.Locals[0]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/cost/CostRemoveCounter","payCostFromSource","()Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int==0?94:77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("-")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",83);}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{return rt.Call(f,"forge/game/cost/CostRemoveCounter","getAmount","()Ljava/lang/String;","invokevirtual",87);}
case 87:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",90);}
case 90:{f.StackOp("pop");f.Pc=91;continue;}
case 91:{f.Pc=280;continue;}
case 94:{f.Push(f.Locals[1]);f.Pc=95;continue;}
case 95:{f.Push(JValue.R(rt.String("Remove ")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",100);}
case 100:{f.StackOp("pop");f.Pc=101;continue;}
case 101:{f.Push(f.Locals[0]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"forge/game/cost/CostRemoveCounter","getAmount","()Ljava/lang/String;","invokevirtual",105);}
case 105:{f.Push(JValue.R(rt.String("X")));f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",110);}
case 110:{f.Pc=f.Pop().Int==0?163:113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostRemoveCounter","oneOrMore","Ljava/lang/Boolean;"));f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",120);}
case 120:{f.Pc=f.Pop().Int==0?133:123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{f.Push(JValue.R(rt.String("one or more ")));f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",129);}
case 129:{f.StackOp("pop");f.Pc=130;continue;}
case 130:{f.Pc=154;continue;}
case 133:{f.Push(f.Locals[2]);f.Pc=134;continue;}
case 134:{f.Pc=f.Pop().Int==0?147:137;continue;}
case 137:{f.Push(f.Locals[1]);f.Pc=138;continue;}
case 138:{f.Push(JValue.R(rt.String("X ")));f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",143);}
case 143:{f.StackOp("pop");f.Pc=144;continue;}
case 144:{f.Pc=154;continue;}
case 147:{f.Push(f.Locals[1]);f.Pc=148;continue;}
case 148:{f.Push(JValue.R(rt.String("any number of ")));f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",153);}
case 153:{f.StackOp("pop");f.Pc=154;continue;}
case 154:{f.Push(f.Locals[1]);f.Pc=155;continue;}
case 155:{f.Push(f.Locals[3]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",159);}
case 159:{f.StackOp("pop");f.Pc=160;continue;}
case 160:{f.Pc=227;continue;}
case 163:{f.Push(f.Locals[0]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/game/cost/CostRemoveCounter","getAmount","()Ljava/lang/String;","invokevirtual",167);}
case 167:{f.Push(JValue.R(rt.String("All")));f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",172);}
case 172:{f.Pc=f.Pop().Int==0?189:175;continue;}
case 175:{f.Push(f.Locals[1]);f.Pc=176;continue;}
case 176:{f.Push(JValue.R(rt.String("all ")));f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",181);}
case 181:{f.Push(f.Locals[3]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",185);}
case 185:{f.StackOp("pop");f.Pc=186;continue;}
case 186:{f.Pc=227;continue;}
case 189:{f.Push(f.Locals[1]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[0]);f.Pc=191;continue;}
case 191:{return rt.Call(f,"forge/game/cost/CostRemoveCounter","getAmount","()Ljava/lang/String;","invokevirtual",194);}
case 194:{f.Push(f.Locals[2]);f.Pc=195;continue;}
case 195:{f.Pc=f.Pop().Int==0?203:198;continue;}
case 198:{f.Push(JValue.R(rt.String("counter")));f.Pc=200;continue;}
case 200:{f.Pc=220;continue;}
case 203:{f.Push(f.Locals[0]);f.Pc=204;continue;}
case 204:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostRemoveCounter","counter","Lforge/game/card/CounterType;"));f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/game/card/CounterType","getName","()Ljava/lang/String;","invokeinterface",212);}
case 212:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",215);}
case 215:{return rt.DynamicCall(f,"forge/game/cost/CostRemoveCounter:6538:215:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",220);}
case 220:{return rt.Call(f,"forge/util/Lang","nounWithNumeralExceptOne","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",223);}
case 223:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",226);}
case 226:{f.StackOp("pop");f.Pc=227;continue;}
case 227:{f.Push(f.Locals[1]);f.Pc=228;continue;}
case 228:{f.Push(JValue.R(rt.String(" from ")));f.Pc=230;continue;}
case 230:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",233);}
case 233:{f.StackOp("pop");f.Pc=234;continue;}
case 234:{f.Push(f.Locals[0]);f.Pc=235;continue;}
case 235:{return rt.Call(f,"forge/game/cost/CostRemoveCounter","payCostFromSource","()Z","invokevirtual",238);}
case 238:{f.Pc=f.Pop().Int==0?253:241;continue;}
case 241:{f.Push(f.Locals[1]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[0]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/cost/CostRemoveCounter","getType","()Ljava/lang/String;","invokevirtual",246);}
case 246:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",249);}
case 249:{f.StackOp("pop");f.Pc=250;continue;}
case 250:{f.Pc=280;continue;}
case 253:{f.Push(f.Locals[0]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/cost/CostRemoveCounter","getTypeDescription","()Ljava/lang/String;","invokevirtual",257);}
case 257:{f.Pc=f.Pop().Reference!=null?267:260;continue;}
case 260:{f.Push(f.Locals[0]);f.Pc=261;continue;}
case 261:{return rt.Call(f,"forge/game/cost/CostRemoveCounter","getType","()Ljava/lang/String;","invokevirtual",264);}
case 264:{f.Pc=271;continue;}
case 267:{f.Push(f.Locals[0]);f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/cost/CostRemoveCounter","getTypeDescription","()Ljava/lang/String;","invokevirtual",271);}
case 271:{f.Locals[4]=f.Pop();f.Pc=273;continue;}
case 273:{f.Push(f.Locals[1]);f.Pc=274;continue;}
case 274:{f.Push(f.Locals[4]);f.Pc=276;continue;}
case 276:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",279);}
case 279:{f.StackOp("pop");f.Pc=280;continue;}
case 280:{f.Push(f.Locals[1]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",284);}
case 284:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6539(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostRemoveCounter","counter","Lforge/game/card/CounterType;"));f.Pc=4;continue;}
case 4:{f.Locals[4]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",10);}
case 10:{f.Locals[5]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/cost/CostRemoveCounter","getType","()Ljava/lang/String;","invokevirtual",16);}
case 16:{f.Locals[6]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[4]);f.Pc=20;continue;}
case 20:{f.Pc=f.Pop().Reference!=null?27:23;continue;}
case 23:{f.Push(JValue.I(1));f.Pc=24;continue;}
case 24:{f.Pc=28;continue;}
case 27:{f.Push(JValue.I(0));f.Pc=28;continue;}
case 28:{f.Locals[7]=f.Pop();f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/cost/CostRemoveCounter","getAmount","()Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Push(JValue.R(rt.String("All")));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int==0?67:42;continue;}
case 42:{f.Push(f.Locals[7]);f.Pc=44;continue;}
case 44:{f.Pc=f.Pop().Int==0?55:47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/card/Card","getNumAllCounters","()I","invokevirtual",52);}
case 52:{f.Pc=62;continue;}
case 55:{f.Push(f.Locals[5]);f.Pc=57;continue;}
case 57:{f.Push(f.Locals[4]);f.Pc=59;continue;}
case 59:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",62);}
case 62:{f.Locals[8]=f.Pop();f.Pc=64;continue;}
case 64:{f.Pc=74;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"forge/game/cost/CostRemoveCounter","getAbilityAmount","(Lforge/game/spellability/SpellAbility;)I","invokevirtual",72);}
case 72:{f.Locals[8]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{return rt.Call(f,"forge/game/cost/CostRemoveCounter","payCostFromSource","()Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int==0?121:81;continue;}
case 81:{f.Push(f.Locals[5]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int!=0?119:89;continue;}
case 89:{f.Push(f.Locals[7]);f.Pc=91;continue;}
case 91:{f.Pc=f.Pop().Int==0?102:94;continue;}
case 94:{f.Push(f.Locals[5]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/card/Card","getNumAllCounters","()I","invokevirtual",99);}
case 99:{f.Pc=109;continue;}
case 102:{f.Push(f.Locals[5]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[4]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",109);}
case 109:{f.Push(f.Locals[8]);f.Pc=111;continue;}
case 111:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=112;continue;}
case 112:{f.Pc=f.Pop().Int<0?119:115;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{f.Pc=120;continue;}
case 119:{f.Push(JValue.I(0));f.Pc=120;continue;}
case 120:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 121:{f.Push(f.Locals[6]);f.Pc=123;continue;}
case 123:{f.Push(JValue.R(rt.String("OriginalHost")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int==0?150:131;continue;}
case 131:{f.Push(JValue.I(1));f.Pc=132;continue;}
case 132:{f.Push(JValue.R(rt.NewArray("Lforge/game/card/Card;",f.Pop().Int)));f.Pc=135;continue;}
case 135:{f.StackOp("dup");f.Pc=136;continue;}
case 136:{f.Push(JValue.I(0));f.Pc=137;continue;}
case 137:{f.Push(f.Locals[1]);f.Pc=138;continue;}
case 138:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",141);}
case 141:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=142;continue;}
case 142:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",145);}
case 145:{f.Locals[9]=f.Pop();f.Pc=147;continue;}
case 147:{f.Pc=174;continue;}
case 150:{f.Push(f.Locals[2]);f.Pc=151;continue;}
case 151:{f.Push(f.Locals[0]);f.Pc=152;continue;}
case 152:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/CostRemoveCounter","zone","Ljava/util/List;"));f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/player/Player","getCardsIn","(Ljava/lang/Iterable;)Lforge/game/card/CardCollectionView;","invokevirtual",158);}
case 158:{f.Push(f.Locals[6]);f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String(";")));f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",165);}
case 165:{f.Push(f.Locals[2]);f.Pc=166;continue;}
case 166:{f.Push(f.Locals[5]);f.Pc=168;continue;}
case 168:{f.Push(f.Locals[1]);f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;[Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",172);}
case 172:{f.Locals[9]=f.Pop();f.Pc=174;continue;}
case 174:{f.Push(f.Locals[9]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",181);}
case 181:{f.Locals[10]=f.Pop();f.Pc=183;continue;}
case 183:{f.Push(f.Locals[10]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",190);}
case 190:{f.Pc=f.Pop().Int==0?236:193;continue;}
case 193:{f.Push(f.Locals[10]);f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",200);}
case 200:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=203;continue;}
case 203:{f.Locals[11]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(f.Locals[7]);f.Pc=207;continue;}
case 207:{f.Pc=f.Pop().Int==0?218:210;continue;}
case 210:{f.Push(f.Locals[11]);f.Pc=212;continue;}
case 212:{return rt.Call(f,"forge/game/card/Card","getNumAllCounters","()I","invokevirtual",215);}
case 215:{f.Pc=225;continue;}
case 218:{f.Push(f.Locals[11]);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[4]);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/game/card/Card","getCounters","(Lforge/game/card/CounterType;)I","invokevirtual",225);}
case 225:{f.Push(f.Locals[8]);f.Pc=227;continue;}
case 227:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=228;continue;}
case 228:{f.Pc=f.Pop().Int<0?233:231;continue;}
case 231:{f.Push(JValue.I(1));f.Pc=232;continue;}
case 232:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 233:{f.Pc=183;continue;}
case 236:{f.Push(JValue.I(0));f.Pc=237;continue;}
case 237:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6540(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(0));f.Pc=1;continue;}
case 1:{f.Locals[5]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[2]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/game/cost/PaymentDecision","counterTable","Lforge/game/GameEntityCounterTable;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/util/Optional","empty","()Ljava/util/Optional;","invokestatic",10);}
case 10:{return rt.Call(f,"forge/game/GameEntityCounterTable","row","(Ljava/lang/Object;)Ljava/util/Map;","invokevirtual",13);}
case 13:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",18);}
case 18:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",23);}
case 23:{f.Locals[6]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[6]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?183:35;continue;}
case 35:{f.Push(f.Locals[6]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[7]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[7]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",54);}
case 54:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=57;continue;}
case 57:{return rt.Call(f,"com/google/common/collect/Multiset","entrySet","()Ljava/util/Set;","invokeinterface",62);}
case 62:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",67);}
case 67:{f.Locals[8]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[8]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",76);}
case 76:{f.Pc=f.Pop().Int==0?138:79;continue;}
case 79:{f.Push(f.Locals[8]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",86);}
case 86:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"com/google/common/collect/Multiset$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=89;continue;}
case 89:{f.Locals[9]=f.Pop();f.Pc=91;continue;}
case 91:{f.Push(f.Locals[5]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[9]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getCount","()I","invokeinterface",100);}
case 100:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=101;continue;}
case 101:{f.Locals[5]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[7]);f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",110);}
case 110:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[9]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getElement","()Ljava/lang/Object;","invokeinterface",120);}
case 120:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/CounterType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[9]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"com/google/common/collect/Multiset$Entry","getCount","()I","invokeinterface",130);}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/GameEntity","subtractCounter","(Lforge/game/card/CounterType;ILforge/game/player/Player;)I","invokevirtual",134);}
case 134:{f.StackOp("pop");f.Pc=135;continue;}
case 135:{f.Pc=69;continue;}
case 138:{f.Push(f.Locals[7]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",145);}
case 145:{f.Locals[9]=f.Pop();f.Pc=147;continue;}
case 147:{f.Push(f.Locals[9]);f.Pc=149;continue;}
case 149:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=152;continue;}
case 152:{f.Pc=f.Pop().Int==0?180:155;continue;}
case 155:{f.Push(f.Locals[9]);f.Pc=157;continue;}
case 157:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=160;continue;}
case 160:{f.Locals[8]=f.Pop();f.Pc=162;continue;}
case 162:{f.Push(f.Locals[7]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",169);}
case 169:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=172;continue;}
case 172:{return rt.Call(f,"forge/game/GameEntity","getGame","()Lforge/game/Game;","invokevirtual",175);}
case 175:{f.Push(f.Locals[8]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/game/Game","updateLastStateForCard","(Lforge/game/card/Card;)V","invokevirtual",180);}
case 180:{f.Pc=25;continue;}
case 183:{f.Push(f.Locals[3]);f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("CostCountersRemoved")));f.Pc=186;continue;}
case 186:{f.Push(f.Locals[5]);f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/Integer","toString","(I)Ljava/lang/String;","invokestatic",191);}
case 191:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSVar","(Ljava/lang/String;Ljava/lang/String;)V","invokevirtual",194);}
case 194:{f.Push(JValue.I(1));f.Pc=195;continue;}
case 195:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6541(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/cost/ICostVisitor","visit","(Lforge/game/cost/CostRemoveCounter;)Ljava/lang/Object;","invokeinterface",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
