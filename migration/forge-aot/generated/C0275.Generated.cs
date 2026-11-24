// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C275{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/DamageDealEffect","forge/game/ability/effects/DamageBaseEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3289,"forge/game/ability/effects/DamageDealEffect","<init>","()V",1,1,1,new JHandler[]{},M3289));
c.Add(new JMethod(3290,"forge/game/ability/effects/DamageDealEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,13,4,new JHandler[]{},M3290));
c.Add(new JMethod(3291,"forge/game/ability/effects/DamageDealEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,22,10,new JHandler[]{},M3291));
c.Add(new JMethod(3292,"forge/game/ability/effects/DamageDealEffect","internalDamageDeal","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/card/Card;ILforge/game/card/CardDamageTable;)V",4,11,5,new JHandler[]{},M3292));
}

internal static JStep M3289(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/DamageBaseEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3290(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("NumDmg")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",19);}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",24);}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/ability/effects/DamageDealEffect","getTargets","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",30);}
case 30:{f.Locals[5]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",36);}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("DamageSource")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",42);}
case 42:{f.Push(f.Locals[1]);f.Pc=43;continue;}
case 43:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",46);}
case 46:{f.Locals[6]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int!=0?68:58;continue;}
case 58:{f.Push(f.Locals[6]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int==0?71:68;continue;}
case 68:{f.Push(JValue.R(rt.String("")));f.Pc=70;continue;}
case 70:{return JStep.Return(f.Pop());}
case 71:{f.Push(f.Locals[2]);f.Pc=72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{f.Push(JValue.I(0));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",80);}
case 80:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/card/Card","toString","()Ljava/lang/String;","invokevirtual",86);}
case 86:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",89);}
case 89:{f.Push(JValue.R(rt.String(" deals")));f.Pc=91;continue;}
case 91:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",94);}
case 94:{f.Push(JValue.R(rt.String(" ")));f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",99);}
case 99:{f.Push(f.Locals[4]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",104);}
case 104:{f.Push(JValue.R(rt.String(" damage ")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",109);}
case 109:{f.StackOp("pop");f.Pc=110;continue;}
case 110:{f.Push(f.Locals[1]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",114);}
case 114:{f.Pc=f.Pop().Int==0?416:117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("DivideEvenly")));f.Pc=120;continue;}
case 120:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",123);}
case 123:{f.Pc=f.Pop().Int==0?136:126;continue;}
case 126:{f.Push(f.Locals[2]);f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String("divided evenly (rounded down) to\n")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",132);}
case 132:{f.StackOp("pop");f.Pc=133;continue;}
case 133:{f.Pc=160;continue;}
case 136:{f.Push(f.Locals[1]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDividedAsYouChoose","()Z","invokevirtual",140);}
case 140:{f.Pc=f.Pop().Int==0?153:143;continue;}
case 143:{f.Push(f.Locals[2]);f.Pc=144;continue;}
case 144:{f.Push(JValue.R(rt.String("divided to\n")));f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",149);}
case 149:{f.StackOp("pop");f.Pc=150;continue;}
case 150:{f.Pc=160;continue;}
case 153:{f.Push(f.Locals[2]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("to ")));f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",159);}
case 159:{f.StackOp("pop");f.Pc=160;continue;}
case 160:{f.Push(f.Locals[1]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/ability/effects/DamageDealEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",164);}
case 164:{f.Locals[7]=f.Pop();f.Pc=166;continue;}
case 166:{f.Push(f.Locals[1]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/ability/effects/DamageDealEffect","getTargetPlayers","(Lforge/game/spellability/SpellAbility;)Lforge/game/player/PlayerCollection;","invokestatic",170);}
case 170:{f.Locals[8]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(f.Locals[7]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",179);}
case 179:{f.Push(f.Locals[8]);f.Pc=181;continue;}
case 181:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",186);}
case 186:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=187;continue;}
case 187:{f.Locals[9]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(JValue.I(0));f.Pc=190;continue;}
case 190:{f.Locals[10]=f.Pop();f.Pc=192;continue;}
case 192:{f.Push(f.Locals[10]);f.Pc=194;continue;}
case 194:{f.Push(f.Locals[7]);f.Pc=196;continue;}
case 196:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",201);}
case 201:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?296:204;continue;}
case 204:{f.Push(f.Locals[7]);f.Pc=206;continue;}
case 206:{f.Push(f.Locals[10]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",213);}
case 213:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=216;continue;}
case 216:{f.Locals[11]=f.Pop();f.Pc=218;continue;}
case 218:{f.Push(f.Locals[2]);f.Pc=219;continue;}
case 219:{f.Push(f.Locals[11]);f.Pc=221;continue;}
case 221:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",224);}
case 224:{f.StackOp("pop");f.Pc=225;continue;}
case 225:{f.Push(f.Locals[1]);f.Pc=226;continue;}
case 226:{f.Push(f.Locals[11]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDividedValue","(Lforge/game/GameObject;)Ljava/lang/Integer;","invokevirtual",231);}
case 231:{f.Locals[12]=f.Pop();f.Pc=233;continue;}
case 233:{f.Push(f.Locals[12]);f.Pc=235;continue;}
case 235:{f.Pc=f.Pop().Reference==null?255:238;continue;}
case 238:{f.Push(f.Locals[2]);f.Pc=239;continue;}
case 239:{f.Push(JValue.R(rt.String(" (")));f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",244);}
case 244:{f.Push(f.Locals[12]);f.Pc=246;continue;}
case 246:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",249);}
case 249:{f.Push(JValue.R(rt.String(" damage)")));f.Pc=251;continue;}
case 251:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",254);}
case 254:{f.StackOp("pop");f.Pc=255;continue;}
case 255:{f.Push(f.Locals[10]);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[9]);f.Pc=259;continue;}
case 259:{f.Push(JValue.I(2));f.Pc=260;continue;}
case 260:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=261;continue;}
case 261:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?274:264;continue;}
case 264:{f.Push(f.Locals[2]);f.Pc=265;continue;}
case 265:{f.Push(JValue.R(rt.String(" and ")));f.Pc=267;continue;}
case 267:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",270);}
case 270:{f.StackOp("pop");f.Pc=271;continue;}
case 271:{f.Pc=290;continue;}
case 274:{f.Push(f.Locals[10]);f.Pc=276;continue;}
case 276:{f.Push(JValue.I(1));f.Pc=277;continue;}
case 277:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=278;continue;}
case 278:{f.Push(f.Locals[9]);f.Pc=280;continue;}
case 280:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?290:283;continue;}
case 283:{f.Push(f.Locals[2]);f.Pc=284;continue;}
case 284:{f.Push(JValue.R(rt.String(", ")));f.Pc=286;continue;}
case 286:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",289);}
case 289:{f.StackOp("pop");f.Pc=290;continue;}
case 290:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=293;continue;}
case 293:{f.Pc=192;continue;}
case 296:{f.Push(JValue.I(0));f.Pc=297;continue;}
case 297:{f.Locals[10]=f.Pop();f.Pc=299;continue;}
case 299:{f.Push(f.Locals[10]);f.Pc=301;continue;}
case 301:{f.Push(f.Locals[8]);f.Pc=303;continue;}
case 303:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",308);}
case 308:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?413:311;continue;}
case 311:{f.Push(f.Locals[8]);f.Pc=313;continue;}
case 313:{f.Push(f.Locals[10]);f.Pc=315;continue;}
case 315:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",320);}
case 320:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=323;continue;}
case 323:{f.Locals[11]=f.Pop();f.Pc=325;continue;}
case 325:{f.Push(f.Locals[2]);f.Pc=326;continue;}
case 326:{f.Push(f.Locals[11]);f.Pc=328;continue;}
case 328:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",331);}
case 331:{f.StackOp("pop");f.Pc=332;continue;}
case 332:{f.Push(f.Locals[1]);f.Pc=333;continue;}
case 333:{f.Push(f.Locals[11]);f.Pc=335;continue;}
case 335:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDividedValue","(Lforge/game/GameObject;)Ljava/lang/Integer;","invokevirtual",338);}
case 338:{f.Locals[12]=f.Pop();f.Pc=340;continue;}
case 340:{f.Push(f.Locals[12]);f.Pc=342;continue;}
case 342:{f.Pc=f.Pop().Reference==null?362:345;continue;}
case 345:{f.Push(f.Locals[2]);f.Pc=346;continue;}
case 346:{f.Push(JValue.R(rt.String(" (")));f.Pc=348;continue;}
case 348:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",351);}
case 351:{f.Push(f.Locals[12]);f.Pc=353;continue;}
case 353:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",356);}
case 356:{f.Push(JValue.R(rt.String(" damage)")));f.Pc=358;continue;}
case 358:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",361);}
case 361:{f.StackOp("pop");f.Pc=362;continue;}
case 362:{f.Push(f.Locals[10]);f.Pc=364;continue;}
case 364:{f.Push(f.Locals[8]);f.Pc=366;continue;}
case 366:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",371);}
case 371:{f.Push(JValue.I(2));f.Pc=372;continue;}
case 372:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=373;continue;}
case 373:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?386:376;continue;}
case 376:{f.Push(f.Locals[2]);f.Pc=377;continue;}
case 377:{f.Push(JValue.R(rt.String(" and ")));f.Pc=379;continue;}
case 379:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",382);}
case 382:{f.StackOp("pop");f.Pc=383;continue;}
case 383:{f.Pc=407;continue;}
case 386:{f.Push(f.Locals[10]);f.Pc=388;continue;}
case 388:{f.Push(JValue.I(1));f.Pc=389;continue;}
case 389:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=390;continue;}
case 390:{f.Push(f.Locals[8]);f.Pc=392;continue;}
case 392:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",397);}
case 397:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?407:400;continue;}
case 400:{f.Push(f.Locals[2]);f.Pc=401;continue;}
case 401:{f.Push(JValue.R(rt.String(", ")));f.Pc=403;continue;}
case 403:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",406);}
case 406:{f.StackOp("pop");f.Pc=407;continue;}
case 407:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=410;continue;}
case 410:{f.Pc=299;continue;}
case 413:{f.Pc=464;continue;}
case 416:{f.Push(f.Locals[1]);f.Pc=417;continue;}
case 417:{f.Push(JValue.R(rt.String("DivideEvenly")));f.Pc=419;continue;}
case 419:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",422);}
case 422:{f.Pc=f.Pop().Int==0?435:425;continue;}
case 425:{f.Push(f.Locals[2]);f.Pc=426;continue;}
case 426:{f.Push(JValue.R(rt.String("divided evenly (rounded down) ")));f.Pc=428;continue;}
case 428:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",431);}
case 431:{f.StackOp("pop");f.Pc=432;continue;}
case 432:{f.Pc=449;continue;}
case 435:{f.Push(f.Locals[1]);f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDividedAsYouChoose","()Z","invokevirtual",439);}
case 439:{f.Pc=f.Pop().Int==0?449:442;continue;}
case 442:{f.Push(f.Locals[2]);f.Pc=443;continue;}
case 443:{f.Push(JValue.R(rt.String("divided as you choose ")));f.Pc=445;continue;}
case 445:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",448);}
case 448:{f.StackOp("pop");f.Pc=449;continue;}
case 449:{f.Push(f.Locals[2]);f.Pc=450;continue;}
case 450:{f.Push(JValue.R(rt.String("to ")));f.Pc=452;continue;}
case 452:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",455);}
case 455:{f.Push(f.Locals[5]);f.Pc=457;continue;}
case 457:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",460);}
case 460:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",463);}
case 463:{f.StackOp("pop");f.Pc=464;continue;}
case 464:{f.Push(f.Locals[1]);f.Pc=465;continue;}
case 465:{f.Push(JValue.R(rt.String("Radiance")));f.Pc=467;continue;}
case 467:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",470);}
case 470:{f.Pc=f.Pop().Int==0?528:473;continue;}
case 473:{f.Push(f.Locals[2]);f.Pc=474;continue;}
case 474:{f.Push(JValue.R(rt.String(" and each other ")));f.Pc=476;continue;}
case 476:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",479);}
case 479:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",482);}
case 482:{f.Push(f.Locals[1]);f.Pc=483;continue;}
case 483:{f.Push(JValue.R(rt.String("ValidTgts")));f.Pc=485;continue;}
case 485:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",488);}
case 488:{return rt.Call(f,"forge/util/Lang","describeValidList","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",491);}
case 491:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",494);}
case 494:{f.Push(JValue.R(rt.String(" that shares a color with ")));f.Pc=496;continue;}
case 496:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",499);}
case 499:{f.StackOp("pop");f.Pc=500;continue;}
case 500:{f.Push(f.Locals[5]);f.Pc=502;continue;}
case 502:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",507);}
case 507:{f.Push(JValue.I(1));f.Pc=508;continue;}
case 508:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?521:511;continue;}
case 511:{f.Push(f.Locals[2]);f.Pc=512;continue;}
case 512:{f.Push(JValue.R(rt.String("them")));f.Pc=514;continue;}
case 514:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",517);}
case 517:{f.StackOp("pop");f.Pc=518;continue;}
case 518:{f.Pc=528;continue;}
case 521:{f.Push(f.Locals[2]);f.Pc=522;continue;}
case 522:{f.Push(JValue.R(rt.String("it")));f.Pc=524;continue;}
case 524:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",527);}
case 527:{f.StackOp("pop");f.Pc=528;continue;}
case 528:{f.Push(f.Locals[2]);f.Pc=529;continue;}
case 529:{f.Push(JValue.R(rt.String(".")));f.Pc=531;continue;}
case 531:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",534);}
case 534:{f.StackOp("pop");f.Pc=535;continue;}
case 535:{f.Push(f.Locals[1]);f.Pc=536;continue;}
case 536:{f.Push(JValue.R(rt.String("ReplaceDyingDefined")));f.Pc=538;continue;}
case 538:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",541);}
case 541:{f.Pc=f.Pop().Int==0?624:544;continue;}
case 544:{f.Push(JValue.R(rt.String("If that creature would die this turn, exile it instead.")));f.Pc=546;continue;}
case 546:{f.Locals[7]=f.Pop();f.Pc=548;continue;}
case 548:{f.Push(f.Locals[1]);f.Pc=549;continue;}
case 549:{f.Push(JValue.R(rt.String("SpellDescription")));f.Pc=551;continue;}
case 551:{f.Push(JValue.R(rt.String("")));f.Pc=553;continue;}
case 553:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParamOrDefault","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",556);}
case 556:{f.Push(JValue.R(rt.String("\\.")));f.Pc=558;continue;}
case 558:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",561);}
case 561:{f.Locals[8]=f.Pop();f.Pc=563;continue;}
case 563:{f.Push(f.Locals[8]);f.Pc=565;continue;}
case 565:{f.Locals[9]=f.Pop();f.Pc=567;continue;}
case 567:{f.Push(f.Locals[9]);f.Pc=569;continue;}
case 569:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=570;continue;}
case 570:{f.Locals[10]=f.Pop();f.Pc=572;continue;}
case 572:{f.Push(JValue.I(0));f.Pc=573;continue;}
case 573:{f.Locals[11]=f.Pop();f.Pc=575;continue;}
case 575:{f.Push(f.Locals[11]);f.Pc=577;continue;}
case 577:{f.Push(f.Locals[10]);f.Pc=579;continue;}
case 579:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?612:582;continue;}
case 582:{f.Push(f.Locals[9]);f.Pc=584;continue;}
case 584:{f.Push(f.Locals[11]);f.Pc=586;continue;}
case 586:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=587;continue;}
case 587:{f.Locals[12]=f.Pop();f.Pc=589;continue;}
case 589:{f.Push(f.Locals[12]);f.Pc=591;continue;}
case 591:{f.Push(JValue.R(rt.String("would die")));f.Pc=593;continue;}
case 593:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",596);}
case 596:{f.Pc=f.Pop().Int==0?606:599;continue;}
case 599:{f.Push(f.Locals[12]);f.Pc=601;continue;}
case 601:{f.Locals[7]=f.Pop();f.Pc=603;continue;}
case 603:{f.Pc=612;continue;}
case 606:{f.Locals[11]=JValue.I(unchecked(f.Locals[11].Int+(1)));f.Pc=609;continue;}
case 609:{f.Pc=575;continue;}
case 612:{f.Push(f.Locals[2]);f.Pc=613;continue;}
case 613:{f.Push(JValue.R(rt.String(" ")));f.Pc=615;continue;}
case 615:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",618);}
case 618:{f.Push(f.Locals[7]);f.Pc=620;continue;}
case 620:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",623);}
case 623:{f.StackOp("pop");f.Pc=624;continue;}
case 624:{f.Push(f.Locals[2]);f.Pc=625;continue;}
case 625:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",628);}
case 628:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3291(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[1]);f.Pc=12;continue;}
case 12:{f.Push(JValue.R(rt.String("DamageSource")));f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",17);}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",21);}
case 21:{f.Locals[4]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[4]);f.Pc=25;continue;}
case 25:{f.Pc=f.Pop().Reference==null?38:28;continue;}
case 28:{f.Push(f.Locals[4]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",35);}
case 35:{f.Pc=f.Pop().Int==0?39:38;continue;}
case 38:{return JStep.ReturnVoid;}
case 39:{f.Push(f.Locals[4]);f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",46);}
case 46:{f.Locals[5]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int==0?89:58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{f.Locals[6]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[3]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/Game","getReplacementHandler","()Lforge/game/replacement/ReplacementHandler;","invokevirtual",74);}
case 74:{if(!rt.StaticReady(f,"forge/game/replacement/ReplacementType","AssignDealDamage","Lforge/game/replacement/ReplacementType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/replacement/ReplacementType","AssignDealDamage","Lforge/game/replacement/ReplacementType;"));f.Pc=77;continue;}
case 77:{f.Push(f.Locals[6]);f.Pc=79;continue;}
case 79:{return rt.Call(f,"forge/game/ability/AbilityKey","mapFromAffected","(Lforge/game/GameEntity;)Ljava/util/Map;","invokestatic",82);}
case 82:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","run","(Lforge/game/replacement/ReplacementType;Ljava/util/Map;)Lforge/game/replacement/ReplacementResult;","invokevirtual",85);}
case 85:{f.StackOp("pop");f.Pc=86;continue;}
case 86:{f.Pc=48;continue;}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[1]);f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("NumDmg")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",96);}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",100);}
case 100:{f.Locals[5]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{f.Push(JValue.R(rt.String("DividerOnResolution")));f.Pc=105;continue;}
case 105:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",108);}
case 108:{f.Locals[6]=f.Pop();f.Pc=110;continue;}
case 110:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",113);}
case 113:{f.Locals[7]=f.Pop();f.Pc=115;continue;}
case 115:{f.Push(f.Locals[1]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("CardChoices")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int!=0?133:124;continue;}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{f.Push(JValue.R(rt.String("PlayerChoices")));f.Pc=127;continue;}
case 127:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",130);}
case 130:{f.Pc=f.Pop().Int==0?366:133;continue;}
case 133:{f.Push(f.Locals[1]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",137);}
case 137:{f.Locals[8]=f.Pop();f.Pc=139;continue;}
case 139:{if(!rt.EnsureInitialized(f,"forge/util/collect/FCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/collect/FCollection")));f.Pc=142;continue;}
case 142:{f.StackOp("dup");f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/util/collect/FCollection","<init>","()V","invokespecial",146);}
case 146:{f.Locals[9]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[1]);f.Pc=149;continue;}
case 149:{f.Push(JValue.R(rt.String("CardChoices")));f.Pc=151;continue;}
case 151:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",154);}
case 154:{f.Pc=f.Pop().Int==0?183:157;continue;}
case 157:{f.Push(f.Locals[9]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[3]);f.Pc=160;continue;}
case 160:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/game/Game","getCardsIn","(Lforge/game/zone/ZoneType;)Lforge/game/card/CardCollectionView;","invokevirtual",166);}
case 166:{f.Push(f.Locals[1]);f.Pc=167;continue;}
case 167:{f.Push(JValue.R(rt.String("CardChoices")));f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",172);}
case 172:{f.Push(f.Locals[8]);f.Pc=174;continue;}
case 174:{f.Push(f.Locals[2]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[1]);f.Pc=176;continue;}
case 176:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",179);}
case 179:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",182);}
case 182:{f.StackOp("pop");f.Pc=183;continue;}
case 183:{f.Push(f.Locals[1]);f.Pc=184;continue;}
case 184:{f.Push(JValue.R(rt.String("PlayerChoices")));f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",189);}
case 189:{f.Pc=f.Pop().Int==0?209:192;continue;}
case 192:{f.Push(f.Locals[9]);f.Pc=194;continue;}
case 194:{f.Push(f.Locals[2]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[1]);f.Pc=196;continue;}
case 196:{f.Push(JValue.R(rt.String("PlayerChoices")));f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",201);}
case 201:{f.Push(f.Locals[1]);f.Pc=202;continue;}
case 202:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",205);}
case 205:{return rt.Call(f,"forge/util/collect/FCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",208);}
case 208:{f.StackOp("pop");f.Pc=209;continue;}
case 209:{f.Push(f.Locals[1]);f.Pc=210;continue;}
case 210:{f.Push(JValue.R(rt.String("ChoiceAmount")));f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",216);}
case 216:{f.Pc=f.Pop().Int==0?234:219;continue;}
case 219:{f.Push(f.Locals[2]);f.Pc=220;continue;}
case 220:{f.Push(f.Locals[1]);f.Pc=221;continue;}
case 221:{f.Push(JValue.R(rt.String("ChoiceAmount")));f.Pc=224;continue;}
case 224:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",227);}
case 227:{f.Push(f.Locals[1]);f.Pc=228;continue;}
case 228:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",231);}
case 231:{f.Pc=235;continue;}
case 234:{f.Push(JValue.I(1));f.Pc=235;continue;}
case 235:{f.Locals[10]=f.Pop();f.Pc=237;continue;}
case 237:{f.Push(f.Locals[1]);f.Pc=238;continue;}
case 238:{f.Push(JValue.R(rt.String("Random")));f.Pc=241;continue;}
case 241:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",244);}
case 244:{f.Pc=f.Pop().Int==0?300:247;continue;}
case 247:{f.Push(JValue.I(0));f.Pc=248;continue;}
case 248:{f.Locals[11]=f.Pop();f.Pc=250;continue;}
case 250:{f.Push(f.Locals[11]);f.Pc=252;continue;}
case 252:{f.Push(f.Locals[10]);f.Pc=254;continue;}
case 254:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?297:257;continue;}
case 257:{f.Push(f.Locals[9]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",262);}
case 262:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=265;continue;}
case 265:{f.Locals[12]=f.Pop();f.Pc=267;continue;}
case 267:{f.Push(f.Locals[7]);f.Pc=269;continue;}
case 269:{f.Push(f.Locals[12]);f.Pc=271;continue;}
case 271:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",276);}
case 276:{f.StackOp("pop");f.Pc=277;continue;}
case 277:{f.Push(f.Locals[9]);f.Pc=279;continue;}
case 279:{f.Push(f.Locals[12]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/util/collect/FCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",284);}
case 284:{f.StackOp("pop");f.Pc=285;continue;}
case 285:{f.Push(f.Locals[2]);f.Pc=286;continue;}
case 286:{f.Push(f.Locals[12]);f.Pc=288;continue;}
case 288:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",291);}
case 291:{f.Locals[11]=JValue.I(unchecked(f.Locals[11].Int+(1)));f.Pc=294;continue;}
case 294:{f.Pc=250;continue;}
case 297:{f.Pc=363;continue;}
case 300:{f.Push(f.Locals[1]);f.Pc=301;continue;}
case 301:{f.Push(JValue.R(rt.String("ChoicePrompt")));f.Pc=304;continue;}
case 304:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",307);}
case 307:{f.Pc=f.Pop().Int==0?320:310;continue;}
case 310:{f.Push(f.Locals[1]);f.Pc=311;continue;}
case 311:{f.Push(JValue.R(rt.String("ChoicePrompt")));f.Pc=314;continue;}
case 314:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",317);}
case 317:{f.Pc=333;continue;}
case 320:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",323);}
case 323:{f.Push(JValue.R(rt.String("lblChooseEntityDmg")));f.Pc=326;continue;}
case 326:{f.Push(JValue.I(0));f.Pc=327;continue;}
case 327:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=330;continue;}
case 330:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",333);}
case 333:{f.Locals[11]=f.Pop();f.Pc=335;continue;}
case 335:{f.Push(f.Locals[7]);f.Pc=337;continue;}
case 337:{f.Push(f.Locals[8]);f.Pc=339;continue;}
case 339:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",342);}
case 342:{f.Push(f.Locals[9]);f.Pc=344;continue;}
case 344:{f.Push(f.Locals[10]);f.Pc=346;continue;}
case 346:{f.Push(f.Locals[10]);f.Pc=348;continue;}
case 348:{f.Push(JValue.R(null));f.Pc=349;continue;}
case 349:{f.Push(f.Locals[1]);f.Pc=350;continue;}
case 350:{f.Push(f.Locals[11]);f.Pc=352;continue;}
case 352:{f.Push(JValue.R(null));f.Pc=353;continue;}
case 353:{f.Push(JValue.R(null));f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/game/player/PlayerController","chooseEntitiesForEffect","(Lforge/util/collect/FCollectionView;IILforge/game/player/DelayedReveal;Lforge/game/spellability/SpellAbility;Ljava/lang/String;Lforge/game/player/Player;Ljava/util/Map;)Ljava/util/List;","invokevirtual",357);}
case 357:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",362);}
case 362:{f.StackOp("pop");f.Pc=363;continue;}
case 363:{f.Pc=372;continue;}
case 366:{f.Push(f.Locals[1]);f.Pc=367;continue;}
case 367:{return rt.Call(f,"forge/game/ability/effects/DamageDealEffect","getTargetEntities","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",370);}
case 370:{f.Locals[7]=f.Pop();f.Pc=372;continue;}
case 372:{f.Push(f.Locals[1]);f.Pc=373;continue;}
case 373:{f.Push(JValue.R(rt.String("OptionalDecider")));f.Pc=376;continue;}
case 376:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",379);}
case 379:{f.Pc=f.Pop().Int==0?493:382;continue;}
case 382:{f.Push(f.Locals[2]);f.Pc=383;continue;}
case 383:{f.Push(f.Locals[1]);f.Pc=384;continue;}
case 384:{f.Push(JValue.R(rt.String("OptionalDecider")));f.Pc=387;continue;}
case 387:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",390);}
case 390:{f.Push(f.Locals[1]);f.Pc=391;continue;}
case 391:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",394);}
case 394:{f.Push(JValue.R(null));f.Pc=395;continue;}
case 395:{return rt.Call(f,"com/google/common/collect/Iterables","getFirst","(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",398);}
case 398:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=401;continue;}
case 401:{f.Locals[8]=f.Pop();f.Pc=403;continue;}
case 403:{f.Push(f.Locals[7]);f.Pc=405;continue;}
case 405:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",410);}
case 410:{f.Push(JValue.I(1));f.Pc=411;continue;}
case 411:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?442:414;continue;}
case 414:{f.Push(f.Locals[7]);f.Pc=416;continue;}
case 416:{f.Push(JValue.I(0));f.Pc=417;continue;}
case 417:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",422);}
case 422:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=425;continue;}
case 425:{f.Pc=f.Pop().Int==0?442:428;continue;}
case 428:{f.Push(f.Locals[7]);f.Pc=430;continue;}
case 430:{f.Push(JValue.I(0));f.Pc=431;continue;}
case 431:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",436);}
case 436:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=439;continue;}
case 439:{f.Pc=443;continue;}
case 442:{f.Push(JValue.R(null));f.Pc=443;continue;}
case 443:{f.Locals[9]=f.Pop();f.Pc=445;continue;}
case 445:{f.Push(f.Locals[8]);f.Pc=447;continue;}
case 447:{f.Pc=f.Pop().Reference==null?493:450;continue;}
case 450:{f.Push(f.Locals[8]);f.Pc=452;continue;}
case 452:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",455);}
case 455:{f.Push(f.Locals[1]);f.Pc=456;continue;}
case 456:{f.Push(JValue.R(null));f.Pc=457;continue;}
case 457:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",460);}
case 460:{f.Push(JValue.R(rt.String("lblDoyouWantDealTargetDamageToTarget")));f.Pc=463;continue;}
case 463:{f.Push(JValue.I(2));f.Pc=464;continue;}
case 464:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=467;continue;}
case 467:{f.StackOp("dup");f.Pc=468;continue;}
case 468:{f.Push(JValue.I(0));f.Pc=469;continue;}
case 469:{f.Push(f.Locals[5]);f.Pc=471;continue;}
case 471:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",474);}
case 474:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=475;continue;}
case 475:{f.StackOp("dup");f.Pc=476;continue;}
case 476:{f.Push(JValue.I(1));f.Pc=477;continue;}
case 477:{f.Push(f.Locals[7]);f.Pc=479;continue;}
case 479:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=480;continue;}
case 480:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",483);}
case 483:{f.Push(f.Locals[9]);f.Pc=485;continue;}
case 485:{f.Push(JValue.R(null));f.Pc=486;continue;}
case 486:{return rt.Call(f,"forge/game/player/PlayerController","confirmAction","(Lforge/game/spellability/SpellAbility;Lforge/game/player/PlayerActionConfirmMode;Ljava/lang/String;Lforge/game/card/Card;Ljava/util/Map;)Z","invokevirtual",489);}
case 489:{f.Pc=f.Pop().Int!=0?493:492;continue;}
case 492:{return JStep.ReturnVoid;}
case 493:{f.Push(f.Locals[1]);f.Pc=494;continue;}
case 494:{f.Push(JValue.R(rt.String("DivideEvenly")));f.Pc=496;continue;}
case 496:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",499);}
case 499:{f.Pc=f.Pop().Int==0?547:502;continue;}
case 502:{f.Push(f.Locals[1]);f.Pc=503;continue;}
case 503:{f.Push(JValue.R(rt.String("DivideEvenly")));f.Pc=505;continue;}
case 505:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",508);}
case 508:{f.Locals[8]=f.Pop();f.Pc=510;continue;}
case 510:{f.Push(f.Locals[8]);f.Pc=512;continue;}
case 512:{f.Push(JValue.R(rt.String("RoundedDown")));f.Pc=515;continue;}
case 515:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",518);}
case 518:{f.Pc=f.Pop().Int==0?547:521;continue;}
case 521:{f.Push(f.Locals[7]);f.Pc=523;continue;}
case 523:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",528);}
case 528:{f.Pc=f.Pop().Int==0?535:531;continue;}
case 531:{f.Push(JValue.I(0));f.Pc=532;continue;}
case 532:{f.Pc=545;continue;}
case 535:{f.Push(f.Locals[5]);f.Pc=537;continue;}
case 537:{f.Push(f.Locals[7]);f.Pc=539;continue;}
case 539:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",544);}
case 544:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"idiv",a,b));f.Pc=545;continue;}
case 545:{f.Locals[5]=f.Pop();f.Pc=547;continue;}
case 547:{f.Push(f.Locals[1]);f.Pc=548;continue;}
case 548:{return rt.Call(f,"forge/game/card/CardUtil","getRadiance","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",551);}
case 551:{f.Locals[8]=f.Pop();f.Pc=553;continue;}
case 553:{f.Push(JValue.I(1));f.Pc=554;continue;}
case 554:{f.Locals[9]=f.Pop();f.Pc=556;continue;}
case 556:{f.Push(f.Locals[1]);f.Pc=557;continue;}
case 557:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDamageMap","()Lforge/game/card/CardDamageTable;","invokevirtual",560);}
case 560:{f.Locals[10]=f.Pop();f.Pc=562;continue;}
case 562:{f.Push(f.Locals[1]);f.Pc=563;continue;}
case 563:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPreventMap","()Lforge/game/card/CardDamageTable;","invokevirtual",566);}
case 566:{f.Locals[11]=f.Pop();f.Pc=568;continue;}
case 568:{f.Push(f.Locals[1]);f.Pc=569;continue;}
case 569:{return rt.Call(f,"forge/game/spellability/SpellAbility","getCounterTable","()Lforge/game/GameEntityCounterTable;","invokevirtual",572);}
case 572:{f.Locals[12]=f.Pop();f.Pc=574;continue;}
case 574:{f.Push(f.Locals[10]);f.Pc=576;continue;}
case 576:{f.Pc=f.Pop().Reference!=null?609:579;continue;}
case 579:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=582;continue;}
case 582:{f.StackOp("dup");f.Pc=583;continue;}
case 583:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","()V","invokespecial",586);}
case 586:{f.Locals[10]=f.Pop();f.Pc=588;continue;}
case 588:{if(!rt.EnsureInitialized(f,"forge/game/card/CardDamageTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardDamageTable")));f.Pc=591;continue;}
case 591:{f.StackOp("dup");f.Pc=592;continue;}
case 592:{return rt.Call(f,"forge/game/card/CardDamageTable","<init>","()V","invokespecial",595);}
case 595:{f.Locals[11]=f.Pop();f.Pc=597;continue;}
case 597:{if(!rt.EnsureInitialized(f,"forge/game/GameEntityCounterTable"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/GameEntityCounterTable")));f.Pc=600;continue;}
case 600:{f.StackOp("dup");f.Pc=601;continue;}
case 601:{return rt.Call(f,"forge/game/GameEntityCounterTable","<init>","()V","invokespecial",604);}
case 604:{f.Locals[12]=f.Pop();f.Pc=606;continue;}
case 606:{f.Push(JValue.I(0));f.Pc=607;continue;}
case 607:{f.Locals[9]=f.Pop();f.Pc=609;continue;}
case 609:{f.Push(f.Locals[1]);f.Pc=610;continue;}
case 610:{f.Push(JValue.R(rt.String("DamageMap")));f.Pc=613;continue;}
case 613:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",616);}
case 616:{f.Pc=f.Pop().Int==0?640:619;continue;}
case 619:{f.Push(f.Locals[1]);f.Pc=620;continue;}
case 620:{f.Push(f.Locals[10]);f.Pc=622;continue;}
case 622:{return rt.Call(f,"forge/game/spellability/SpellAbility","setDamageMap","(Lforge/game/card/CardDamageTable;)V","invokevirtual",625);}
case 625:{f.Push(f.Locals[1]);f.Pc=626;continue;}
case 626:{f.Push(f.Locals[11]);f.Pc=628;continue;}
case 628:{return rt.Call(f,"forge/game/spellability/SpellAbility","setPreventMap","(Lforge/game/card/CardDamageTable;)V","invokevirtual",631);}
case 631:{f.Push(f.Locals[1]);f.Pc=632;continue;}
case 632:{f.Push(f.Locals[12]);f.Pc=634;continue;}
case 634:{return rt.Call(f,"forge/game/spellability/SpellAbility","setCounterTable","(Lforge/game/GameEntityCounterTable;)V","invokevirtual",637);}
case 637:{f.Push(JValue.I(1));f.Pc=638;continue;}
case 638:{f.Locals[9]=f.Pop();f.Pc=640;continue;}
case 640:{f.Push(f.Locals[4]);f.Pc=642;continue;}
case 642:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",647);}
case 647:{f.Locals[13]=f.Pop();f.Pc=649;continue;}
case 649:{f.Push(f.Locals[13]);f.Pc=651;continue;}
case 651:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",656);}
case 656:{f.Pc=f.Pop().Int==0?1108:659;continue;}
case 659:{f.Push(f.Locals[13]);f.Pc=661;continue;}
case 661:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",666);}
case 666:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=669;continue;}
case 669:{f.Locals[14]=f.Pop();f.Pc=671;continue;}
case 671:{f.Push(f.Locals[2]);f.Pc=672;continue;}
case 672:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",675);}
case 675:{f.Push(f.Locals[14]);f.Pc=677;continue;}
case 677:{return rt.Call(f,"forge/game/Game","getChangeZoneLKIInfo","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",680);}
case 680:{f.Locals[15]=f.Pop();f.Pc=682;continue;}
case 682:{f.Push(f.Locals[6]);f.Pc=684;continue;}
case 684:{f.Pc=f.Pop().Int==0?851:687;continue;}
case 687:{f.Push(f.Locals[2]);f.Pc=688;continue;}
case 688:{f.Push(f.Locals[1]);f.Pc=689;continue;}
case 689:{f.Push(JValue.R(rt.String("DividerOnResolution")));f.Pc=691;continue;}
case 691:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",694);}
case 694:{f.Push(f.Locals[1]);f.Pc=695;continue;}
case 695:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedPlayers","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/player/PlayerCollection;","invokestatic",698);}
case 698:{f.Locals[16]=f.Pop();f.Pc=700;continue;}
case 700:{f.Push(f.Locals[16]);f.Pc=702;continue;}
case 702:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",707);}
case 707:{f.Pc=f.Pop().Int==0?711:710;continue;}
case 710:{return JStep.ReturnVoid;}
case 711:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=714;continue;}
case 714:{f.StackOp("dup");f.Pc=715;continue;}
case 715:{f.Push(f.Locals[7]);f.Pc=717;continue;}
case 717:{f.Push(JValue.R(rt.ClassObject("forge/game/card/Card")));f.Pc=719;continue;}
case 719:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/lang/Class;)Ljava/lang/Iterable;","invokestatic",722);}
case 722:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",725);}
case 725:{f.Locals[17]=f.Pop();f.Pc=727;continue;}
case 727:{f.Push(f.Locals[16]);f.Pc=729;continue;}
case 729:{f.Push(JValue.I(0));f.Pc=730;continue;}
case 730:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",735);}
case 735:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=738;continue;}
case 738:{f.Locals[18]=f.Pop();f.Pc=740;continue;}
case 740:{f.Push(f.Locals[18]);f.Pc=742;continue;}
case 742:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",745);}
case 745:{f.Push(f.Locals[15]);f.Pc=747;continue;}
case 747:{f.Push(f.Locals[17]);f.Pc=749;continue;}
case 749:{f.Push(JValue.R(null));f.Pc=750;continue;}
case 750:{f.Push(f.Locals[5]);f.Pc=752;continue;}
case 752:{f.Push(JValue.R(null));f.Pc=753;continue;}
case 753:{f.Push(JValue.I(1));f.Pc=754;continue;}
case 754:{return rt.Call(f,"forge/game/player/PlayerController","assignCombatDamage","(Lforge/game/card/Card;Lforge/game/card/CardCollectionView;Lforge/game/card/CardCollectionView;ILforge/game/GameEntity;Z)Ljava/util/Map;","invokevirtual",757);}
case 757:{f.Locals[19]=f.Pop();f.Pc=759;continue;}
case 759:{f.Push(f.Locals[19]);f.Pc=761;continue;}
case 761:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",766);}
case 766:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",771);}
case 771:{f.Locals[20]=f.Pop();f.Pc=773;continue;}
case 773:{f.Push(f.Locals[20]);f.Pc=775;continue;}
case 775:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",780);}
case 780:{f.Pc=f.Pop().Int==0?826:783;continue;}
case 783:{f.Push(f.Locals[20]);f.Pc=785;continue;}
case 785:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",790);}
case 790:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=793;continue;}
case 793:{f.Locals[21]=f.Pop();f.Pc=795;continue;}
case 795:{f.Push(f.Locals[10]);f.Pc=797;continue;}
case 797:{f.Push(f.Locals[15]);f.Pc=799;continue;}
case 799:{f.Push(f.Locals[21]);f.Pc=801;continue;}
case 801:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",806);}
case 806:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=809;continue;}
case 809:{f.Push(f.Locals[21]);f.Pc=811;continue;}
case 811:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",816);}
case 816:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=819;continue;}
case 819:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",822);}
case 822:{f.StackOp("pop");f.Pc=823;continue;}
case 823:{f.Pc=773;continue;}
case 826:{f.Push(f.Locals[9]);f.Pc=828;continue;}
case 828:{f.Pc=f.Pop().Int!=0?846:831;continue;}
case 831:{f.Push(f.Locals[3]);f.Pc=832;continue;}
case 832:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",835);}
case 835:{f.Push(JValue.I(0));f.Pc=836;continue;}
case 836:{f.Push(f.Locals[10]);f.Pc=838;continue;}
case 838:{f.Push(f.Locals[11]);f.Pc=840;continue;}
case 840:{f.Push(f.Locals[12]);f.Pc=842;continue;}
case 842:{f.Push(f.Locals[1]);f.Pc=843;continue;}
case 843:{return rt.Call(f,"forge/game/GameAction","dealDamage","(ZLforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;Lforge/game/GameEntityCounterTable;Lforge/game/spellability/SpellAbility;)V","invokevirtual",846);}
case 846:{f.Push(f.Locals[1]);f.Pc=847;continue;}
case 847:{return rt.Call(f,"forge/game/ability/effects/DamageDealEffect","replaceDying","(Lforge/game/spellability/SpellAbility;)V","invokestatic",850);}
case 850:{return JStep.ReturnVoid;}
case 851:{f.Push(f.Locals[1]);f.Pc=852;continue;}
case 852:{f.Push(JValue.R(rt.String("RelativeTarget")));f.Pc=855;continue;}
case 855:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",858);}
case 858:{f.Pc=f.Pop().Int==0?876:861;continue;}
case 861:{f.Push(f.Locals[14]);f.Pc=863;continue;}
case 863:{f.Push(f.Locals[1]);f.Pc=864;continue;}
case 864:{f.Push(JValue.R(rt.String("Defined")));f.Pc=867;continue;}
case 867:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",870);}
case 870:{f.Push(f.Locals[1]);f.Pc=871;continue;}
case 871:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedEntities","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",874);}
case 874:{f.Locals[7]=f.Pop();f.Pc=876;continue;}
case 876:{f.Push(f.Locals[7]);f.Pc=878;continue;}
case 878:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",883);}
case 883:{f.Locals[16]=f.Pop();f.Pc=885;continue;}
case 885:{f.Push(f.Locals[16]);f.Pc=887;continue;}
case 887:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",892);}
case 892:{f.Pc=f.Pop().Int==0?1052:895;continue;}
case 895:{f.Push(f.Locals[16]);f.Pc=897;continue;}
case 897:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",902);}
case 902:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=905;continue;}
case 905:{f.Locals[17]=f.Pop();f.Pc=907;continue;}
case 907:{f.Push(f.Locals[1]);f.Pc=908;continue;}
case 908:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",911);}
case 911:{f.Pc=f.Pop().Int==0?933:914;continue;}
case 914:{f.Push(f.Locals[1]);f.Pc=915;continue;}
case 915:{return rt.Call(f,"forge/game/spellability/SpellAbility","isDividedAsYouChoose","()Z","invokevirtual",918);}
case 918:{f.Pc=f.Pop().Int==0?933:921;continue;}
case 921:{f.Push(f.Locals[1]);f.Pc=922;continue;}
case 922:{f.Push(f.Locals[17]);f.Pc=924;continue;}
case 924:{return rt.Call(f,"forge/game/spellability/SpellAbility","getDividedValue","(Lforge/game/GameObject;)Ljava/lang/Integer;","invokevirtual",927);}
case 927:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",930);}
case 930:{f.Pc=935;continue;}
case 933:{f.Push(f.Locals[5]);f.Pc=935;continue;}
case 935:{f.Locals[5]=f.Pop();f.Pc=937;continue;}
case 937:{f.Push(f.Locals[5]);f.Pc=939;continue;}
case 939:{f.Pc=f.Pop().Int>0?945:942;continue;}
case 942:{f.Pc=885;continue;}
case 945:{f.Push(f.Locals[17]);f.Pc=947;continue;}
case 947:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/card/Card")?1:0));f.Pc=950;continue;}
case 950:{f.Pc=f.Pop().Int==0?1019:953;continue;}
case 953:{f.Push(f.Locals[17]);f.Pc=955;continue;}
case 955:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=958;continue;}
case 958:{f.Locals[18]=f.Pop();f.Pc=960;continue;}
case 960:{f.Push(f.Locals[3]);f.Pc=961;continue;}
case 961:{f.Push(f.Locals[18]);f.Pc=963;continue;}
case 963:{f.Push(JValue.R(null));f.Pc=964;continue;}
case 964:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",967);}
case 967:{f.Locals[20]=f.Pop();f.Pc=969;continue;}
case 969:{f.Push(f.Locals[20]);f.Pc=971;continue;}
case 971:{f.Pc=f.Pop().Reference==null?885:974;continue;}
case 974:{f.Push(f.Locals[18]);f.Pc=976;continue;}
case 976:{f.Push(f.Locals[20]);f.Pc=978;continue;}
case 978:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",981);}
case 981:{f.Pc=f.Pop().Int==0?885:984;continue;}
case 984:{f.Push(f.Locals[20]);f.Pc=986;continue;}
case 986:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",989);}
case 989:{f.Pc=f.Pop().Int==0?885:992;continue;}
case 992:{f.Push(f.Locals[20]);f.Pc=994;continue;}
case 994:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",997);}
case 997:{f.Pc=f.Pop().Int==0?1003:1000;continue;}
case 1000:{f.Pc=885;continue;}
case 1003:{f.Push(f.Locals[0]);f.Pc=1004;continue;}
case 1004:{f.Push(f.Locals[1]);f.Pc=1005;continue;}
case 1005:{f.Push(f.Locals[15]);f.Pc=1007;continue;}
case 1007:{f.Push(f.Locals[20]);f.Pc=1009;continue;}
case 1009:{f.Push(f.Locals[5]);f.Pc=1011;continue;}
case 1011:{f.Push(f.Locals[10]);f.Pc=1013;continue;}
case 1013:{return rt.Call(f,"forge/game/ability/effects/DamageDealEffect","internalDamageDeal","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/card/Card;ILforge/game/card/CardDamageTable;)V","invokevirtual",1016);}
case 1016:{f.Pc=1049;continue;}
case 1019:{f.Push(f.Locals[17]);f.Pc=1021;continue;}
case 1021:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/player/Player")?1:0));f.Pc=1024;continue;}
case 1024:{f.Pc=f.Pop().Int==0?1049:1027;continue;}
case 1027:{f.Push(f.Locals[17]);f.Pc=1029;continue;}
case 1029:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1032;continue;}
case 1032:{f.Locals[19]=f.Pop();f.Pc=1034;continue;}
case 1034:{f.Push(f.Locals[10]);f.Pc=1036;continue;}
case 1036:{f.Push(f.Locals[15]);f.Pc=1038;continue;}
case 1038:{f.Push(f.Locals[19]);f.Pc=1040;continue;}
case 1040:{f.Push(f.Locals[5]);f.Pc=1042;continue;}
case 1042:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",1045);}
case 1045:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",1048);}
case 1048:{f.StackOp("pop");f.Pc=1049;continue;}
case 1049:{f.Pc=885;continue;}
case 1052:{f.Push(f.Locals[8]);f.Pc=1054;continue;}
case 1054:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",1057);}
case 1057:{f.Locals[16]=f.Pop();f.Pc=1059;continue;}
case 1059:{f.Push(f.Locals[16]);f.Pc=1061;continue;}
case 1061:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1066);}
case 1066:{f.Pc=f.Pop().Int==0?1105:1069;continue;}
case 1069:{f.Push(f.Locals[16]);f.Pc=1071;continue;}
case 1071:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1076);}
case 1076:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1079;continue;}
case 1079:{f.Locals[17]=f.Pop();f.Pc=1081;continue;}
case 1081:{f.Push(f.Locals[17]);f.Pc=1083;continue;}
case 1083:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",1086);}
case 1086:{f.Pc=f.Pop().Int==0?1102:1089;continue;}
case 1089:{f.Push(f.Locals[0]);f.Pc=1090;continue;}
case 1090:{f.Push(f.Locals[1]);f.Pc=1091;continue;}
case 1091:{f.Push(f.Locals[15]);f.Pc=1093;continue;}
case 1093:{f.Push(f.Locals[17]);f.Pc=1095;continue;}
case 1095:{f.Push(f.Locals[5]);f.Pc=1097;continue;}
case 1097:{f.Push(f.Locals[10]);f.Pc=1099;continue;}
case 1099:{return rt.Call(f,"forge/game/ability/effects/DamageDealEffect","internalDamageDeal","(Lforge/game/spellability/SpellAbility;Lforge/game/card/Card;Lforge/game/card/Card;ILforge/game/card/CardDamageTable;)V","invokevirtual",1102);}
case 1102:{f.Pc=1059;continue;}
case 1105:{f.Pc=649;continue;}
case 1108:{f.Push(f.Locals[9]);f.Pc=1110;continue;}
case 1110:{f.Pc=f.Pop().Int!=0?1128:1113;continue;}
case 1113:{f.Push(f.Locals[3]);f.Pc=1114;continue;}
case 1114:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",1117);}
case 1117:{f.Push(JValue.I(0));f.Pc=1118;continue;}
case 1118:{f.Push(f.Locals[10]);f.Pc=1120;continue;}
case 1120:{f.Push(f.Locals[11]);f.Pc=1122;continue;}
case 1122:{f.Push(f.Locals[12]);f.Pc=1124;continue;}
case 1124:{f.Push(f.Locals[1]);f.Pc=1125;continue;}
case 1125:{return rt.Call(f,"forge/game/GameAction","dealDamage","(ZLforge/game/card/CardDamageTable;Lforge/game/card/CardDamageTable;Lforge/game/GameEntityCounterTable;Lforge/game/spellability/SpellAbility;)V","invokevirtual",1128);}
case 1128:{f.Push(f.Locals[1]);f.Pc=1129;continue;}
case 1129:{return rt.Call(f,"forge/game/ability/effects/DamageDealEffect","replaceDying","(Lforge/game/spellability/SpellAbility;)V","invokestatic",1132);}
case 1132:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3292(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[6]=f.Pop();f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",10);}
case 10:{f.Locals[7]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{f.Locals[8]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(JValue.I(0));f.Pc=16;continue;}
case 16:{f.Locals[9]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("ExcessDamage")));f.Pc=22;continue;}
case 22:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",25);}
case 25:{f.Pc=f.Pop().Int==0?57:28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","DEATHTOUCH","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","DEATHTOUCH","Lforge/game/keyword/Keyword;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/card/Card","hasKeyword","(Lforge/game/keyword/Keyword;)Z","invokevirtual",36);}
case 36:{return rt.Call(f,"forge/game/card/Card","getExcessDamageValue","(Z)I","invokevirtual",39);}
case 39:{f.Locals[10]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[10]);f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",48);}
case 48:{f.Locals[9]=f.Pop();f.Pc=50;continue;}
case 50:{f.Push(f.Locals[4]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[9]);f.Pc=54;continue;}
case 54:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=55;continue;}
case 55:{f.Locals[8]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{f.Push(JValue.R(rt.String("ExcessDamage")));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",64);}
case 64:{f.Pc=f.Pop().Int==0?186:67;continue;}
case 67:{f.Push(f.Locals[1]);f.Pc=68;continue;}
case 68:{f.Push(JValue.R(rt.String("ExcessDamageCondition")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int==0?102:77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{f.Push(f.Locals[1]);f.Pc=79;continue;}
case 79:{f.Push(JValue.R(rt.String("ExcessDamageCondition")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",85);}
case 85:{f.Push(JValue.R(rt.String(",")));f.Pc=88;continue;}
case 88:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",91);}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[6]);f.Pc=95;continue;}
case 95:{f.Push(f.Locals[1]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/game/card/Card","isValid","([Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Z","invokevirtual",99);}
case 99:{f.Pc=f.Pop().Int==0?186:102;continue;}
case 102:{f.Push(f.Locals[5]);f.Pc=104;continue;}
case 104:{f.Push(f.Locals[2]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[3]);f.Pc=106;continue;}
case 106:{f.Push(f.Locals[9]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",111);}
case 111:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",114);}
case 114:{f.StackOp("pop");f.Pc=115;continue;}
case 115:{f.Push(f.Locals[6]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{f.Push(JValue.R(rt.String("ExcessDamage")));f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",124);}
case 124:{f.Push(f.Locals[1]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedEntities","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",128);}
case 128:{f.Locals[10]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[10]);f.Pc=132;continue;}
case 132:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",137);}
case 137:{f.Pc=f.Pop().Int!=0?163:140;continue;}
case 140:{f.Push(f.Locals[5]);f.Pc=142;continue;}
case 142:{f.Push(f.Locals[2]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[10]);f.Pc=145;continue;}
case 145:{f.Push(JValue.I(0));f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",151);}
case 151:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/GameEntity"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[8]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",159);}
case 159:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",162);}
case 162:{f.StackOp("pop");f.Pc=163;continue;}
case 163:{f.Push(f.Locals[1]);f.Pc=164;continue;}
case 164:{f.Push(JValue.R(rt.String("RememberRedirectedExcess")));f.Pc=167;continue;}
case 167:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",170);}
case 170:{f.Pc=f.Pop().Int==0?183:173;continue;}
case 173:{f.Push(f.Locals[6]);f.Pc=175;continue;}
case 175:{f.Push(f.Locals[8]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",180);}
case 180:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Object;)V","invokevirtual",183);}
case 183:{f.Pc=199;continue;}
case 186:{f.Push(f.Locals[5]);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[2]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[3]);f.Pc=190;continue;}
case 190:{f.Push(f.Locals[4]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"java/lang/Integer","valueOf","(I)Ljava/lang/Integer;","invokestatic",195);}
case 195:{return rt.Call(f,"forge/game/card/CardDamageTable","put","(Lforge/game/card/Card;Lforge/game/GameEntity;Ljava/lang/Integer;)Ljava/lang/Integer;","invokevirtual",198);}
case 198:{f.StackOp("pop");f.Pc=199;continue;}
case 199:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
