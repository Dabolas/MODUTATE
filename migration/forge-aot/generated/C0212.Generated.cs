// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C212{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/BidLifeEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3057,"forge/game/ability/effects/BidLifeEffect","<init>","()V",1,1,1,new JHandler[]{},M3057));
c.Add(new JMethod(3058,"forge/game/ability/effects/BidLifeEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,2,1,new JHandler[]{},M3058));
c.Add(new JMethod(3059,"forge/game/ability/effects/BidLifeEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,12,9,new JHandler[]{},M3059));
}

internal static JStep M3057(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3058(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("Bid Life")));f.Pc=2;continue;}
case 2:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3059(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",17);}
case 17:{f.Locals[4]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{f.Push(JValue.R(rt.String("StartBidding")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?89:28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("StartBidding")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",34);}
case 34:{f.Locals[6]=f.Pop();f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("Any")));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[6]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Int==0?77:46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",50);}
case 50:{f.Push(f.Locals[1]);f.Pc=51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{f.Push(JValue.I(2147483647));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",57);}
case 57:{f.Push(JValue.R(rt.String("lblChooseStartingBid")));f.Pc=59;continue;}
case 59:{f.Push(JValue.I(0));f.Pc=60;continue;}
case 60:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",66);}
case 66:{return rt.Call(f,"forge/game/player/PlayerController","announceRequirements","(Lforge/game/spellability/SpellAbility;IILjava/lang/String;)Ljava/lang/Integer;","invokevirtual",69);}
case 69:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",72);}
case 72:{f.Locals[5]=f.Pop();f.Pc=74;continue;}
case 74:{f.Pc=86;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[6]);f.Pc=80;continue;}
case 80:{f.Push(f.Locals[1]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",84);}
case 84:{f.Locals[5]=f.Pop();f.Pc=86;continue;}
case 86:{f.Pc=92;continue;}
case 89:{f.Push(JValue.I(0));f.Pc=90;continue;}
case 90:{f.Locals[5]=f.Pop();f.Pc=92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("OtherBidder")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?128:101;continue;}
case 101:{f.Push(f.Locals[4]);f.Pc=103;continue;}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/util/collect/FCollection","add","(Ljava/lang/Object;)Z","invokevirtual",107);}
case 107:{f.StackOp("pop");f.Pc=108;continue;}
case 108:{f.Push(f.Locals[4]);f.Pc=110;continue;}
case 110:{f.Push(f.Locals[2]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[1]);f.Pc=112;continue;}
case 112:{f.Push(JValue.R(rt.String("OtherBidder")));f.Pc=114;continue;}
case 114:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",117);}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",121);}
case 121:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",124);}
case 124:{f.StackOp("pop");f.Pc=125;continue;}
case 125:{f.Pc=191;continue;}
case 128:{f.Push(f.Locals[4]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[3]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",134);}
case 134:{return rt.Call(f,"forge/game/Game","getPlayersInTurnOrder","()Lforge/game/player/PlayerCollection;","invokevirtual",137);}
case 137:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",140);}
case 140:{f.StackOp("pop");f.Pc=141;continue;}
case 141:{f.Push(f.Locals[4]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/util/collect/FCollection","size","()I","invokevirtual",146);}
case 146:{f.Locals[6]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[4]);f.Pc=150;continue;}
case 150:{f.Push(f.Locals[3]);f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/util/collect/FCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",154);}
case 154:{f.Pc=f.Pop().Int==0?191:157;continue;}
case 157:{f.Push(f.Locals[3]);f.Pc=158;continue;}
case 158:{f.Push(f.Locals[4]);f.Pc=160;continue;}
case 160:{f.Push(JValue.R(null));f.Pc=161;continue;}
case 161:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",164);}
case 164:{return rt.Call(f,"forge/game/player/Player","equals","(Ljava/lang/Object;)Z","invokevirtual",167);}
case 167:{f.Pc=f.Pop().Int!=0?191:170;continue;}
case 170:{f.Push(f.Locals[4]);f.Pc=172;continue;}
case 172:{f.Push(f.Locals[6]);f.Pc=174;continue;}
case 174:{f.Push(JValue.I(1));f.Pc=175;continue;}
case 175:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=176;continue;}
case 176:{f.Push(f.Locals[4]);f.Pc=178;continue;}
case 178:{f.Push(JValue.I(0));f.Pc=179;continue;}
case 179:{return rt.Call(f,"forge/util/collect/FCollection","remove","(I)Ljava/lang/Object;","invokevirtual",182);}
case 182:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/util/collect/FCollection","add","(ILjava/lang/Object;)V","invokevirtual",188);}
case 188:{f.Pc=148;continue;}
case 191:{f.Push(JValue.I(1));f.Pc=192;continue;}
case 192:{f.Locals[6]=f.Pop();f.Pc=194;continue;}
case 194:{f.Push(f.Locals[3]);f.Pc=195;continue;}
case 195:{f.Locals[7]=f.Pop();f.Pc=197;continue;}
case 197:{f.Push(f.Locals[5]);f.Pc=199;continue;}
case 199:{f.Locals[8]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(f.Locals[6]);f.Pc=203;continue;}
case 203:{f.Pc=f.Pop().Int==0?366:206;continue;}
case 206:{f.Push(JValue.I(0));f.Pc=207;continue;}
case 207:{f.Locals[6]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(f.Locals[4]);f.Pc=211;continue;}
case 211:{return rt.Call(f,"forge/util/collect/FCollection","iterator","()Ljava/util/Iterator;","invokevirtual",214);}
case 214:{f.Locals[9]=f.Pop();f.Pc=216;continue;}
case 216:{f.Push(f.Locals[9]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",223);}
case 223:{f.Pc=f.Pop().Int==0?363:226;continue;}
case 226:{f.Push(f.Locals[9]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",233);}
case 233:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=236;continue;}
case 236:{f.Locals[10]=f.Pop();f.Pc=238;continue;}
case 238:{f.Push(f.Locals[10]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",243);}
case 243:{f.Push(f.Locals[1]);f.Pc=244;continue;}
case 244:{if(!rt.StaticReady(f,"forge/game/player/PlayerActionConfirmMode","BidLife","Lforge/game/player/PlayerActionConfirmMode;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/player/PlayerActionConfirmMode","BidLife","Lforge/game/player/PlayerActionConfirmMode;"));f.Pc=247;continue;}
case 247:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",250);}
case 250:{f.Push(JValue.R(rt.String("lblDoYouWantTopBid")));f.Pc=252;continue;}
case 252:{f.Push(JValue.I(0));f.Pc=253;continue;}
case 253:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=256;continue;}
case 256:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",259);}
case 259:{f.Push(f.Locals[8]);f.Pc=261;continue;}
case 261:{return rt.DynamicCall(f,"forge/game/ability/effects/BidLifeEffect:3059:261:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;I)Ljava/lang/String;",266);}
case 266:{f.Push(f.Locals[8]);f.Pc=268;continue;}
case 268:{f.Push(f.Locals[7]);f.Pc=270;continue;}
case 270:{return rt.Call(f,"forge/game/player/PlayerController","confirmBidAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;ILforge/game/player/Player;)Z","invokevirtual",273);}
case 273:{f.Locals[11]=f.Pop();f.Pc=275;continue;}
case 275:{f.Push(f.Locals[6]);f.Pc=277;continue;}
case 277:{f.Push(f.Locals[11]);f.Pc=279;continue;}
case 279:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=280;continue;}
case 280:{f.Locals[6]=f.Pop();f.Pc=282;continue;}
case 282:{f.Push(f.Locals[11]);f.Pc=284;continue;}
case 284:{f.Pc=f.Pop().Int==0?360:287;continue;}
case 287:{f.Push(f.Locals[8]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[10]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",294);}
case 294:{f.Push(f.Locals[1]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",298);}
case 298:{f.Push(JValue.R(rt.String("lblBidLife")));f.Pc=300;continue;}
case 300:{f.Push(JValue.I(0));f.Pc=301;continue;}
case 301:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",307);}
case 307:{return rt.DynamicCall(f,"forge/game/ability/effects/BidLifeEffect:3059:307:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",312);}
case 312:{f.Push(JValue.I(1));f.Pc=313;continue;}
case 313:{f.Push(JValue.I(9));f.Pc=315;continue;}
case 315:{return rt.Call(f,"forge/game/player/PlayerController","chooseNumber","(Lforge/game/spellability/SpellAbility;Ljava/lang/String;II)I","invokevirtual",318);}
case 318:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=319;continue;}
case 319:{f.Locals[8]=f.Pop();f.Pc=321;continue;}
case 321:{f.Push(f.Locals[10]);f.Pc=323;continue;}
case 323:{f.Locals[7]=f.Pop();f.Pc=325;continue;}
case 325:{f.Push(f.Locals[2]);f.Pc=326;continue;}
case 326:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",329);}
case 329:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",332);}
case 332:{f.Push(f.Locals[1]);f.Pc=333;continue;}
case 333:{f.Push(f.Locals[10]);f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",338);}
case 338:{f.Push(JValue.R(rt.String("lblTopBidWithValueLife")));f.Pc=340;continue;}
case 340:{f.Push(JValue.I(1));f.Pc=341;continue;}
case 341:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=344;continue;}
case 344:{f.StackOp("dup");f.Pc=345;continue;}
case 345:{f.Push(JValue.I(0));f.Pc=346;continue;}
case 346:{f.Push(f.Locals[8]);f.Pc=348;continue;}
case 348:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",351);}
case 351:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=352;continue;}
case 352:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",355);}
case 355:{f.Push(f.Locals[10]);f.Pc=357;continue;}
case 357:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",360);}
case 360:{f.Pc=216;continue;}
case 363:{f.Pc=201;continue;}
case 366:{f.Push(f.Locals[2]);f.Pc=367;continue;}
case 367:{f.Push(f.Locals[8]);f.Pc=369;continue;}
case 369:{return rt.Call(f,"forge/game/card/Card","setChosenNumber","(I)V","invokevirtual",372);}
case 372:{f.Push(f.Locals[2]);f.Pc=373;continue;}
case 373:{f.Push(f.Locals[7]);f.Pc=375;continue;}
case 375:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",378);}
case 378:{f.Push(f.Locals[1]);f.Pc=379;continue;}
case 379:{f.Push(JValue.R(rt.String("BidSubAbility")));f.Pc=381;continue;}
case 381:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",384);}
case 384:{f.Locals[9]=f.Pop();f.Pc=386;continue;}
case 386:{f.Push(f.Locals[9]);f.Pc=388;continue;}
case 388:{f.Pc=f.Pop().Reference==null?396:391;continue;}
case 391:{f.Push(f.Locals[9]);f.Pc=393;continue;}
case 393:{return rt.Call(f,"forge/game/ability/AbilityUtils","resolve","(Lforge/game/spellability/SpellAbility;)V","invokestatic",396);}
case 396:{f.Push(f.Locals[2]);f.Pc=397;continue;}
case 397:{return rt.Call(f,"forge/game/card/Card","clearRemembered","()V","invokevirtual",400);}
case 400:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
