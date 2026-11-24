// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C53{
internal static JClass Build(){var c=new JClass("forge/card/CardType$Helper","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(907,"forge/card/CardType$Helper","<init>","()V",1,1,1,new JHandler[]{},M907));
c.Add(new JMethod(908,"forge/card/CardType$Helper","parseTypes","(Ljava/lang/String;Ljava/util/List;)V",25,6,4,new JHandler[]{},M908));
}

internal static JStep M907(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M908(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(null));f.Pc=1;continue;}
case 1:{f.Locals[2]=f.Pop();f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Locals[3]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(JValue.I(-1));f.Pc=5;continue;}
case 5:{f.Locals[4]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",11);}
case 11:{switch(f.Pop().Int){case -943754813:f.Pc=190;break;case -888311506:f.Pc=115;break;case -551171678:f.Pc=160;break;case 270060378:f.Pc=130;break;case 467385425:f.Pc=145;break;case 859495691:f.Pc=100;break;case 908554881:f.Pc=222;break;case 968900447:f.Pc=238;break;case 1435133351:f.Pc=175;break;case 1661257215:f.Pc=206;break;default:f.Pc=251;break;}continue;}
case 100:{f.Push(f.Locals[3]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("BasicTypes")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?251:109;continue;}
case 109:{f.Push(JValue.I(0));f.Pc=110;continue;}
case 110:{f.Locals[4]=f.Pop();f.Pc=112;continue;}
case 112:{f.Pc=251;continue;}
case 115:{f.Push(f.Locals[3]);f.Pc=116;continue;}
case 116:{f.Push(JValue.R(rt.String("LandTypes")));f.Pc=118;continue;}
case 118:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",121);}
case 121:{f.Pc=f.Pop().Int==0?251:124;continue;}
case 124:{f.Push(JValue.I(1));f.Pc=125;continue;}
case 125:{f.Locals[4]=f.Pop();f.Pc=127;continue;}
case 127:{f.Pc=251;continue;}
case 130:{f.Push(f.Locals[3]);f.Pc=131;continue;}
case 131:{f.Push(JValue.R(rt.String("CreatureTypes")));f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",136);}
case 136:{f.Pc=f.Pop().Int==0?251:139;continue;}
case 139:{f.Push(JValue.I(2));f.Pc=140;continue;}
case 140:{f.Locals[4]=f.Pop();f.Pc=142;continue;}
case 142:{f.Pc=251;continue;}
case 145:{f.Push(f.Locals[3]);f.Pc=146;continue;}
case 146:{f.Push(JValue.R(rt.String("SpellTypes")));f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",151);}
case 151:{f.Pc=f.Pop().Int==0?251:154;continue;}
case 154:{f.Push(JValue.I(3));f.Pc=155;continue;}
case 155:{f.Locals[4]=f.Pop();f.Pc=157;continue;}
case 157:{f.Pc=251;continue;}
case 160:{f.Push(f.Locals[3]);f.Pc=161;continue;}
case 161:{f.Push(JValue.R(rt.String("EnchantmentTypes")));f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",166);}
case 166:{f.Pc=f.Pop().Int==0?251:169;continue;}
case 169:{f.Push(JValue.I(4));f.Pc=170;continue;}
case 170:{f.Locals[4]=f.Pop();f.Pc=172;continue;}
case 172:{f.Pc=251;continue;}
case 175:{f.Push(f.Locals[3]);f.Pc=176;continue;}
case 176:{f.Push(JValue.R(rt.String("ArtifactTypes")));f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",181);}
case 181:{f.Pc=f.Pop().Int==0?251:184;continue;}
case 184:{f.Push(JValue.I(5));f.Pc=185;continue;}
case 185:{f.Locals[4]=f.Pop();f.Pc=187;continue;}
case 187:{f.Pc=251;continue;}
case 190:{f.Push(f.Locals[3]);f.Pc=191;continue;}
case 191:{f.Push(JValue.R(rt.String("WalkerTypes")));f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",196);}
case 196:{f.Pc=f.Pop().Int==0?251:199;continue;}
case 199:{f.Push(JValue.I(6));f.Pc=201;continue;}
case 201:{f.Locals[4]=f.Pop();f.Pc=203;continue;}
case 203:{f.Pc=251;continue;}
case 206:{f.Push(f.Locals[3]);f.Pc=207;continue;}
case 207:{f.Push(JValue.R(rt.String("DungeonTypes")));f.Pc=209;continue;}
case 209:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",212);}
case 212:{f.Pc=f.Pop().Int==0?251:215;continue;}
case 215:{f.Push(JValue.I(7));f.Pc=217;continue;}
case 217:{f.Locals[4]=f.Pop();f.Pc=219;continue;}
case 219:{f.Pc=251;continue;}
case 222:{f.Push(f.Locals[3]);f.Pc=223;continue;}
case 223:{f.Push(JValue.R(rt.String("BattleTypes")));f.Pc=225;continue;}
case 225:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",228);}
case 228:{f.Pc=f.Pop().Int==0?251:231;continue;}
case 231:{f.Push(JValue.I(8));f.Pc=233;continue;}
case 233:{f.Locals[4]=f.Pop();f.Pc=235;continue;}
case 235:{f.Pc=251;continue;}
case 238:{f.Push(f.Locals[3]);f.Pc=239;continue;}
case 239:{f.Push(JValue.R(rt.String("PlanarTypes")));f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",244);}
case 244:{f.Pc=f.Pop().Int==0?251:247;continue;}
case 247:{f.Push(JValue.I(9));f.Pc=249;continue;}
case 249:{f.Locals[4]=f.Pop();f.Pc=251;continue;}
case 251:{f.Push(f.Locals[4]);f.Pc=253;continue;}
case 253:{switch(f.Pop().Int){case 0:f.Pc=308;break;case 1:f.Pc=315;break;case 2:f.Pc=322;break;case 3:f.Pc=329;break;case 4:f.Pc=336;break;case 5:f.Pc=343;break;case 6:f.Pc=350;break;case 7:f.Pc=357;break;case 8:f.Pc=364;break;case 9:f.Pc=371;break;default:f.Pc=375;break;}continue;}
case 308:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","BASIC_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","BASIC_TYPES","Ljava/util/Set;"));f.Pc=311;continue;}
case 311:{f.Locals[2]=f.Pop();f.Pc=312;continue;}
case 312:{f.Pc=375;continue;}
case 315:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","LAND_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","LAND_TYPES","Ljava/util/Set;"));f.Pc=318;continue;}
case 318:{f.Locals[2]=f.Pop();f.Pc=319;continue;}
case 319:{f.Pc=375;continue;}
case 322:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","CREATURE_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","CREATURE_TYPES","Ljava/util/Set;"));f.Pc=325;continue;}
case 325:{f.Locals[2]=f.Pop();f.Pc=326;continue;}
case 326:{f.Pc=375;continue;}
case 329:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","SPELL_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","SPELL_TYPES","Ljava/util/Set;"));f.Pc=332;continue;}
case 332:{f.Locals[2]=f.Pop();f.Pc=333;continue;}
case 333:{f.Pc=375;continue;}
case 336:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","ENCHANTMENT_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","ENCHANTMENT_TYPES","Ljava/util/Set;"));f.Pc=339;continue;}
case 339:{f.Locals[2]=f.Pop();f.Pc=340;continue;}
case 340:{f.Pc=375;continue;}
case 343:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","ARTIFACT_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","ARTIFACT_TYPES","Ljava/util/Set;"));f.Pc=346;continue;}
case 346:{f.Locals[2]=f.Pop();f.Pc=347;continue;}
case 347:{f.Pc=375;continue;}
case 350:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","WALKER_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","WALKER_TYPES","Ljava/util/Set;"));f.Pc=353;continue;}
case 353:{f.Locals[2]=f.Pop();f.Pc=354;continue;}
case 354:{f.Pc=375;continue;}
case 357:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","DUNGEON_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","DUNGEON_TYPES","Ljava/util/Set;"));f.Pc=360;continue;}
case 360:{f.Locals[2]=f.Pop();f.Pc=361;continue;}
case 361:{f.Pc=375;continue;}
case 364:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","BATTLE_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","BATTLE_TYPES","Ljava/util/Set;"));f.Pc=367;continue;}
case 367:{f.Locals[2]=f.Pop();f.Pc=368;continue;}
case 368:{f.Pc=375;continue;}
case 371:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","PLANAR_TYPES","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","PLANAR_TYPES","Ljava/util/Set;"));f.Pc=374;continue;}
case 374:{f.Locals[2]=f.Pop();f.Pc=375;continue;}
case 375:{f.Push(f.Locals[2]);f.Pc=376;continue;}
case 376:{f.Pc=f.Pop().Reference!=null?380:379;continue;}
case 379:{return JStep.ReturnVoid;}
case 380:{f.Push(f.Locals[1]);f.Pc=381;continue;}
case 381:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",386);}
case 386:{f.Locals[3]=f.Pop();f.Pc=387;continue;}
case 387:{f.Push(f.Locals[3]);f.Pc=388;continue;}
case 388:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",393);}
case 393:{f.Pc=f.Pop().Int==0?556:396;continue;}
case 396:{f.Push(f.Locals[3]);f.Pc=397;continue;}
case 397:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",402);}
case 402:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=405;continue;}
case 405:{f.Locals[4]=f.Pop();f.Pc=407;continue;}
case 407:{f.Push(f.Locals[4]);f.Pc=409;continue;}
case 409:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",412);}
case 412:{f.Pc=f.Pop().Int!=0?418:415;continue;}
case 415:{f.Pc=387;continue;}
case 418:{f.Push(f.Locals[4]);f.Pc=420;continue;}
case 420:{f.Push(JValue.R(rt.String(":")));f.Pc=422;continue;}
case 422:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",425);}
case 425:{f.Pc=f.Pop().Int==0?509:428;continue;}
case 428:{f.Push(f.Locals[4]);f.Pc=430;continue;}
case 430:{f.Push(JValue.R(rt.String(":")));f.Pc=432;continue;}
case 432:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",435);}
case 435:{f.Locals[5]=f.Pop();f.Pc=437;continue;}
case 437:{f.Push(f.Locals[2]);f.Pc=438;continue;}
case 438:{f.Push(f.Locals[5]);f.Pc=440;continue;}
case 440:{f.Push(JValue.I(0));f.Pc=441;continue;}
case 441:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=442;continue;}
case 442:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",447);}
case 447:{f.Pc=f.Pop().Int==0?453:450;continue;}
case 450:{f.Pc=387;continue;}
case 453:{f.Push(f.Locals[2]);f.Pc=454;continue;}
case 454:{f.Push(f.Locals[5]);f.Pc=456;continue;}
case 456:{f.Push(JValue.I(0));f.Pc=457;continue;}
case 457:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=458;continue;}
case 458:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",463);}
case 463:{f.StackOp("pop");f.Pc=464;continue;}
case 464:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","pluralTypes","Lcom/google/common/collect/BiMap;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","pluralTypes","Lcom/google/common/collect/BiMap;"));f.Pc=467;continue;}
case 467:{f.Push(f.Locals[5]);f.Pc=469;continue;}
case 469:{f.Push(JValue.I(0));f.Pc=470;continue;}
case 470:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=471;continue;}
case 471:{f.Push(f.Locals[5]);f.Pc=473;continue;}
case 473:{f.Push(JValue.I(1));f.Pc=474;continue;}
case 474:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=475;continue;}
case 475:{return rt.Call(f,"com/google/common/collect/BiMap","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",480);}
case 480:{f.StackOp("pop");f.Pc=481;continue;}
case 481:{f.Push(f.Locals[5]);f.Pc=483;continue;}
case 483:{f.Push(JValue.I(0));f.Pc=484;continue;}
case 484:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=485;continue;}
case 485:{f.Push(JValue.R(rt.String(" ")));f.Pc=487;continue;}
case 487:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",490);}
case 490:{f.Pc=f.Pop().Int==0?506:493;continue;}
case 493:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","MultiwordTypes","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","MultiwordTypes","Ljava/util/Set;"));f.Pc=496;continue;}
case 496:{f.Push(f.Locals[5]);f.Pc=498;continue;}
case 498:{f.Push(JValue.I(0));f.Pc=499;continue;}
case 499:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=500;continue;}
case 500:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",505);}
case 505:{f.StackOp("pop");f.Pc=506;continue;}
case 506:{f.Pc=553;continue;}
case 509:{f.Push(f.Locals[2]);f.Pc=510;continue;}
case 510:{f.Push(f.Locals[4]);f.Pc=512;continue;}
case 512:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",517);}
case 517:{f.Pc=f.Pop().Int==0?523:520;continue;}
case 520:{f.Pc=387;continue;}
case 523:{f.Push(f.Locals[2]);f.Pc=524;continue;}
case 524:{f.Push(f.Locals[4]);f.Pc=526;continue;}
case 526:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",531);}
case 531:{f.StackOp("pop");f.Pc=532;continue;}
case 532:{f.Push(f.Locals[4]);f.Pc=534;continue;}
case 534:{f.Push(JValue.R(rt.String(" ")));f.Pc=536;continue;}
case 536:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",539);}
case 539:{f.Pc=f.Pop().Int==0?553:542;continue;}
case 542:{if(!rt.StaticReady(f,"forge/card/CardType$Constant","MultiwordTypes","Ljava/util/Set;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardType$Constant","MultiwordTypes","Ljava/util/Set;"));f.Pc=545;continue;}
case 545:{f.Push(f.Locals[4]);f.Pc=547;continue;}
case 547:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",552);}
case 552:{f.StackOp("pop");f.Pc=553;continue;}
case 553:{f.Pc=387;continue;}
case 556:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
