// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C462{
internal static JClass Build(){var c=new JClass("forge/game/card/CardPlayOption","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("players","Lforge/game/player/PlayerCollection;",false,JValue.Default("Lforge/game/player/PlayerCollection;"),null));
c.Add(new JField("sta","Lforge/game/staticability/StaticAbility;",false,JValue.Default("Lforge/game/staticability/StaticAbility;"),null));
c.Add(new JField("payManaCost","Lforge/game/card/CardPlayOption$PayManaCost;",false,JValue.Default("Lforge/game/card/CardPlayOption$PayManaCost;"),null));
c.Add(new JField("withFlash","Z",false,JValue.Default("Z"),null));
c.Add(new JField("grantsZonePermissions","Z",false,JValue.Default("Z"),null));
c.Add(new JField("altManaCost","Lforge/game/cost/Cost;",false,JValue.Default("Lforge/game/cost/Cost;"),null));
c.Add(new JMethod(5113,"forge/game/card/CardPlayOption","<init>","(Lforge/game/player/PlayerCollection;Lforge/game/staticability/StaticAbility;ZLforge/game/cost/Cost;ZZ)V",1,7,7,new JHandler[]{},M5113));
c.Add(new JMethod(5114,"forge/game/card/CardPlayOption","<init>","(Lforge/game/player/PlayerCollection;Lforge/game/staticability/StaticAbility;Lforge/game/card/CardPlayOption$PayManaCost;Lforge/game/cost/Cost;ZZ)V",2,7,2,new JHandler[]{},M5114));
c.Add(new JMethod(5115,"forge/game/card/CardPlayOption","getPlayers","()Lforge/game/player/PlayerCollection;",1,1,1,new JHandler[]{},M5115));
c.Add(new JMethod(5116,"forge/game/card/CardPlayOption","appliesTo","(Lforge/game/player/Player;)Z",1,2,2,new JHandler[]{},M5116));
c.Add(new JMethod(5117,"forge/game/card/CardPlayOption","getHost","()Lforge/game/card/Card;",1,1,1,new JHandler[]{},M5117));
c.Add(new JMethod(5118,"forge/game/card/CardPlayOption","getAbility","()Lforge/game/staticability/StaticAbility;",1,1,1,new JHandler[]{},M5118));
c.Add(new JMethod(5119,"forge/game/card/CardPlayOption","getPayManaCost","()Lforge/game/card/CardPlayOption$PayManaCost;",1,1,1,new JHandler[]{},M5119));
c.Add(new JMethod(5120,"forge/game/card/CardPlayOption","isIgnoreManaCostColor","()Z",1,1,2,new JHandler[]{},M5120));
c.Add(new JMethod(5121,"forge/game/card/CardPlayOption","isIgnoreManaCostType","()Z",1,1,2,new JHandler[]{},M5121));
c.Add(new JMethod(5122,"forge/game/card/CardPlayOption","isIgnoreSnowSourceManaCostColor","()Z",1,1,2,new JHandler[]{},M5122));
c.Add(new JMethod(5123,"forge/game/card/CardPlayOption","applyManaConvert","(Lforge/game/mana/ManaConversionMatrix;)Z",1,2,2,new JHandler[]{},M5123));
c.Add(new JMethod(5124,"forge/game/card/CardPlayOption","isWithFlash","()Z",1,1,1,new JHandler[]{},M5124));
c.Add(new JMethod(5125,"forge/game/card/CardPlayOption","grantsZonePermissions","()Z",1,1,1,new JHandler[]{},M5125));
c.Add(new JMethod(5126,"forge/game/card/CardPlayOption","getAltManaCost","()Lforge/game/cost/Cost;",1,1,1,new JHandler[]{},M5126));
c.Add(new JMethod(5127,"forge/game/card/CardPlayOption","getFormattedAltManaCost","()Ljava/lang/String;",2,1,1,new JHandler[]{},M5127));
c.Add(new JMethod(5128,"forge/game/card/CardPlayOption","toString","()Ljava/lang/String;",1,1,2,new JHandler[]{},M5128));
c.Add(new JMethod(5129,"forge/game/card/CardPlayOption","toString","(Z)Ljava/lang/String;",1,4,5,new JHandler[]{},M5129));
}

internal static JStep M5113(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?13:7;continue;}
case 7:{if(!rt.StaticReady(f,"forge/game/card/CardPlayOption$PayManaCost","NO","Lforge/game/card/CardPlayOption$PayManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPlayOption$PayManaCost","NO","Lforge/game/card/CardPlayOption$PayManaCost;"));f.Pc=10;continue;}
case 10:{f.Pc=16;continue;}
case 13:{if(!rt.StaticReady(f,"forge/game/card/CardPlayOption$PayManaCost","YES","Lforge/game/card/CardPlayOption$PayManaCost;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPlayOption$PayManaCost","YES","Lforge/game/card/CardPlayOption$PayManaCost;"));f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[6]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/card/CardPlayOption","<init>","(Lforge/game/player/PlayerCollection;Lforge/game/staticability/StaticAbility;Lforge/game/card/CardPlayOption$PayManaCost;Lforge/game/cost/Cost;ZZ)V","invokespecial",25);}
case 25:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5114(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardPlayOption","players","Lforge/game/player/PlayerCollection;",value);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardPlayOption","sta","Lforge/game/staticability/StaticAbility;",value);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardPlayOption","payManaCost","Lforge/game/card/CardPlayOption$PayManaCost;",value);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[5]);f.Pc=22;continue;}
case 22:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardPlayOption","withFlash","Z",value);f.Pc=25;continue;}
case 25:{f.Push(f.Locals[0]);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[6]);f.Pc=28;continue;}
case 28:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardPlayOption","grantsZonePermissions","Z",value);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[4]);f.Pc=34;continue;}
case 34:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/CardPlayOption","altManaCost","Lforge/game/cost/Cost;",value);f.Pc=37;continue;}
case 37:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5115(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardPlayOption","players","Lforge/game/player/PlayerCollection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5116(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardPlayOption","players","Lforge/game/player/PlayerCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/player/PlayerCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5117(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardPlayOption","sta","Lforge/game/staticability/StaticAbility;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5118(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardPlayOption","sta","Lforge/game/staticability/StaticAbility;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5119(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardPlayOption","payManaCost","Lforge/game/card/CardPlayOption$PayManaCost;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5120(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardPlayOption","sta","Lforge/game/staticability/StaticAbility;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("MayPlayIgnoreColor")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5121(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardPlayOption","sta","Lforge/game/staticability/StaticAbility;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("MayPlayIgnoreType")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5122(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardPlayOption","sta","Lforge/game/staticability/StaticAbility;"));f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("MayPlaySnowIgnoreColor")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",9);}
case 9:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5123(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardPlayOption","isIgnoreManaCostType","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?15:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("AnyType->AnyType")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"forge/game/ability/AbilityUtils","applyManaColorConversion","(Lforge/game/mana/ManaConversionMatrix;Ljava/lang/String;)V","invokestatic",13);}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/CardPlayOption","isIgnoreManaCostColor","()Z","invokevirtual",19);}
case 19:{f.Pc=f.Pop().Int==0?30:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("AnyType->AnyColor")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/ability/AbilityUtils","applyManaColorConversion","(Lforge/game/mana/ManaConversionMatrix;Ljava/lang/String;)V","invokestatic",28);}
case 28:{f.Push(JValue.I(1));f.Pc=29;continue;}
case 29:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 30:{f.Push(JValue.I(0));f.Pc=31;continue;}
case 31:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5124(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardPlayOption","withFlash","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5125(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardPlayOption","grantsZonePermissions","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5126(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardPlayOption","altManaCost","Lforge/game/cost/Cost;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5127(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardPlayOption","altManaCost","Lforge/game/cost/Cost;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/cost/Cost","toSimpleString","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5128(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/card/CardPlayOption","toString","(Z)Ljava/lang/String;","invokevirtual",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5129(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Int==0?18:8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardPlayOption","players","Lforge/game/player/PlayerCollection;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",15);}
case 15:{f.Pc=20;continue;}
case 18:{f.Push(JValue.R(rt.String("")));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/StringBuilder","<init>","(Ljava/lang/String;)V","invokespecial",23);}
case 23:{f.Locals[2]=f.Pop();f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/card/CardPlayOption$1","$SwitchMap$forge$game$card$CardPlayOption$PayManaCost","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/CardPlayOption$1","$SwitchMap$forge$game$card$CardPlayOption$PayManaCost","[I"));f.Pc=27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/game/card/CardPlayOption","getPayManaCost","()Lforge/game/card/CardPlayOption$PayManaCost;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/game/card/CardPlayOption$PayManaCost","ordinal","()I","invokevirtual",34);}
case 34:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=35;continue;}
case 35:{switch(f.Pop().Int){case 1:f.Pc=60;break;case 2:f.Pc=209;break;default:f.Pc=237;break;}continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardPlayOption","altManaCost","Lforge/game/cost/Cost;"));f.Pc=64;continue;}
case 64:{f.Pc=f.Pop().Reference==null?118:67;continue;}
case 67:{f.Push(f.Locals[0]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"forge/game/card/CardPlayOption","getFormattedAltManaCost","()Ljava/lang/String;","invokevirtual",71);}
case 71:{f.Locals[3]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{f.Push(JValue.R(rt.String("Pay ")));f.Pc=75;continue;}
case 75:{f.Push(JValue.R(rt.String("")));f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",80);}
case 80:{f.Locals[3]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[2]);f.Pc=82;continue;}
case 82:{f.Push(JValue.R(rt.String(" (by paying ")));f.Pc=84;continue;}
case 84:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",87);}
case 87:{f.Push(f.Locals[3]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",91);}
case 91:{f.Push(JValue.R(rt.String(" instead of paying its mana cost")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",96);}
case 96:{f.StackOp("pop");f.Pc=97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/card/CardPlayOption","isWithFlash","()Z","invokevirtual",101);}
case 101:{f.Pc=f.Pop().Int==0?111:104;continue;}
case 104:{f.Push(f.Locals[2]);f.Pc=105;continue;}
case 105:{f.Push(JValue.R(rt.String(" and as though it has flash")));f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",110);}
case 110:{f.StackOp("pop");f.Pc=111;continue;}
case 111:{f.Push(f.Locals[2]);f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String(")")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",117);}
case 117:{f.StackOp("pop");f.Pc=118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/card/CardPlayOption","isIgnoreManaCostType","()Z","invokevirtual",122);}
case 122:{f.Pc=f.Pop().Int==0?135:125;continue;}
case 125:{f.Push(f.Locals[2]);f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String(" (may spend mana as though it were mana of any type to cast it)")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",131);}
case 131:{f.StackOp("pop");f.Pc=132;continue;}
case 132:{f.Pc=149;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/game/card/CardPlayOption","isIgnoreManaCostColor","()Z","invokevirtual",139);}
case 139:{f.Pc=f.Pop().Int==0?149:142;continue;}
case 142:{f.Push(f.Locals[2]);f.Pc=143;continue;}
case 143:{f.Push(JValue.R(rt.String(" (may spend mana as though it were mana of any color to cast it)")));f.Pc=145;continue;}
case 145:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",148);}
case 148:{f.StackOp("pop");f.Pc=149;continue;}
case 149:{f.Push(f.Locals[0]);f.Pc=150;continue;}
case 150:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardPlayOption","sta","Lforge/game/staticability/StaticAbility;"));f.Pc=153;continue;}
case 153:{f.Push(JValue.R(rt.String("RaiseCost")));f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/staticability/StaticAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",158);}
case 158:{f.Pc=f.Pop().Int==0?237:161;continue;}
case 161:{f.Push(f.Locals[0]);f.Pc=162;continue;}
case 162:{f.Push(rt.GetField(f.Pop(),"forge/game/card/CardPlayOption","sta","Lforge/game/staticability/StaticAbility;"));f.Pc=165;continue;}
case 165:{f.Push(JValue.R(rt.String("Description")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/staticability/StaticAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",170);}
case 170:{f.Locals[3]=f.Pop();f.Pc=171;continue;}
case 171:{f.Push(f.Locals[2]);f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.String(" (")));f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",177);}
case 177:{f.Push(f.Locals[3]);f.Pc=178;continue;}
case 178:{f.Push(f.Locals[3]);f.Pc=179;continue;}
case 179:{f.Push(JValue.R(rt.String("by ")));f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",184);}
case 184:{f.Push(f.Locals[3]);f.Pc=185;continue;}
case 185:{f.Push(JValue.R(rt.String("pay ")));f.Pc=187;continue;}
case 187:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",190);}
case 190:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=191;continue;}
case 191:{f.Push(f.Locals[3]);f.Pc=192;continue;}
case 192:{f.Push(JValue.R(rt.String(".")));f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/lang/String","indexOf","(Ljava/lang/String;)I","invokevirtual",197);}
case 197:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;","invokevirtual",200);}
case 200:{f.Push(JValue.R(rt.String(")")));f.Pc=202;continue;}
case 202:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",205);}
case 205:{f.StackOp("pop");f.Pc=206;continue;}
case 206:{f.Pc=237;continue;}
case 209:{f.Push(f.Locals[2]);f.Pc=210;continue;}
case 210:{f.Push(JValue.R(rt.String(" (without paying its mana cost")));f.Pc=212;continue;}
case 212:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",215);}
case 215:{f.StackOp("pop");f.Pc=216;continue;}
case 216:{f.Push(f.Locals[0]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"forge/game/card/CardPlayOption","isWithFlash","()Z","invokevirtual",220);}
case 220:{f.Pc=f.Pop().Int==0?230:223;continue;}
case 223:{f.Push(f.Locals[2]);f.Pc=224;continue;}
case 224:{f.Push(JValue.R(rt.String(" and as though it has flash")));f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",229);}
case 229:{f.StackOp("pop");f.Pc=230;continue;}
case 230:{f.Push(f.Locals[2]);f.Pc=231;continue;}
case 231:{f.Push(JValue.R(rt.String(")")));f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",236);}
case 236:{f.StackOp("pop");f.Pc=237;continue;}
case 237:{f.Push(f.Locals[2]);f.Pc=238;continue;}
case 238:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",241);}
case 241:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
