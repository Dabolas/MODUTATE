// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C358{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/ProtectEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3575,"forge/game/ability/effects/ProtectEffect","<init>","()V",1,1,1,new JHandler[]{},M3575));
c.Add(new JMethod(3576,"forge/game/ability/effects/ProtectEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,9,4,new JHandler[]{},M3576));
c.Add(new JMethod(3577,"forge/game/ability/effects/ProtectEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,15,7,new JHandler[]{},M3577));
c.Add(new JMethod(3578,"forge/game/ability/effects/ProtectEffect","getProtectionList","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;",9,4,3,new JHandler[]{},M3578));
}

internal static JStep M3575(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3576(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/effects/ProtectEffect","getProtectionList","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{f.Push(JValue.R(rt.String("Choices")));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",11);}
case 11:{f.Locals[3]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[3]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Int==0?21:16;continue;}
case 16:{f.Push(JValue.R(rt.String("or")));f.Pc=18;continue;}
case 18:{f.Pc=23;continue;}
case 21:{f.Push(JValue.R(rt.String("and")));f.Pc=23;continue;}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=28;continue;}
case 28:{f.StackOp("dup");f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",32);}
case 32:{f.Locals[5]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[1]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"forge/game/ability/effects/ProtectEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",38);}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(f.Locals[6]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",47);}
case 47:{f.Pc=f.Pop().Int!=0?356:50;continue;}
case 50:{f.Push(f.Locals[6]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",57);}
case 57:{f.Locals[7]=f.Pop();f.Pc=59;continue;}
case 59:{f.Push(f.Locals[7]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",66);}
case 66:{f.Pc=f.Pop().Int==0?129:69;continue;}
case 69:{f.Push(f.Locals[7]);f.Pc=71;continue;}
case 71:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",76);}
case 76:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=79;continue;}
case 79:{f.Locals[8]=f.Pop();f.Pc=81;continue;}
case 81:{f.Push(f.Locals[8]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/card/Card","isFaceDown","()Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int==0?100:89;continue;}
case 89:{f.Push(f.Locals[5]);f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("Morph")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",96);}
case 96:{f.StackOp("pop");f.Pc=97;continue;}
case 97:{f.Pc=108;continue;}
case 100:{f.Push(f.Locals[5]);f.Pc=102;continue;}
case 102:{f.Push(f.Locals[8]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",107);}
case 107:{f.StackOp("pop");f.Pc=108;continue;}
case 108:{f.Push(f.Locals[7]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",115);}
case 115:{f.Pc=f.Pop().Int==0?126:118;continue;}
case 118:{f.Push(f.Locals[5]);f.Pc=120;continue;}
case 120:{f.Push(JValue.R(rt.String(", ")));f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",125);}
case 125:{f.StackOp("pop");f.Pc=126;continue;}
case 126:{f.Pc=59;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{f.Push(JValue.R(rt.String("Radiance")));f.Pc=132;continue;}
case 132:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",135);}
case 135:{f.Pc=f.Pop().Int==0?203:138;continue;}
case 138:{f.Push(f.Locals[1]);f.Pc=139;continue;}
case 139:{return rt.Call(f,"forge/game/spellability/SpellAbility","usesTargeting","()Z","invokevirtual",142);}
case 142:{f.Pc=f.Pop().Int==0?203:145;continue;}
case 145:{f.Push(f.Locals[5]);f.Pc=147;continue;}
case 147:{f.Push(JValue.R(rt.String(" and each other ")));f.Pc=149;continue;}
case 149:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",152);}
case 152:{return rt.Call(f,"forge/util/Lang","getInstance","()Lforge/util/Lang;","invokestatic",155);}
case 155:{f.Push(f.Locals[1]);f.Pc=156;continue;}
case 156:{f.Push(JValue.R(rt.String("ValidTgts")));f.Pc=158;continue;}
case 158:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",161);}
case 161:{return rt.Call(f,"forge/util/Lang","describeValidList","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",164);}
case 164:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",167);}
case 167:{f.Push(JValue.R(rt.String(" that shares a color with ")));f.Pc=169;continue;}
case 169:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",172);}
case 172:{f.StackOp("pop");f.Pc=173;continue;}
case 173:{f.Push(f.Locals[6]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",180);}
case 180:{f.Push(JValue.I(1));f.Pc=181;continue;}
case 181:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?195:184;continue;}
case 184:{f.Push(f.Locals[5]);f.Pc=186;continue;}
case 186:{f.Push(JValue.R(rt.String("them")));f.Pc=188;continue;}
case 188:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",191);}
case 191:{f.StackOp("pop");f.Pc=192;continue;}
case 192:{f.Pc=203;continue;}
case 195:{f.Push(f.Locals[5]);f.Pc=197;continue;}
case 197:{f.Push(JValue.R(rt.String("it")));f.Pc=199;continue;}
case 199:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",202);}
case 202:{f.StackOp("pop");f.Pc=203;continue;}
case 203:{f.Push(f.Locals[5]);f.Pc=205;continue;}
case 205:{f.Push(JValue.R(rt.String(" gain")));f.Pc=207;continue;}
case 207:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",210);}
case 210:{f.StackOp("pop");f.Pc=211;continue;}
case 211:{f.Push(f.Locals[6]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",218);}
case 218:{f.Push(JValue.I(1));f.Pc=219;continue;}
case 219:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?230:222;continue;}
case 222:{f.Push(f.Locals[5]);f.Pc=224;continue;}
case 224:{f.Push(JValue.R(rt.String("s")));f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",229);}
case 229:{f.StackOp("pop");f.Pc=230;continue;}
case 230:{f.Push(f.Locals[5]);f.Pc=232;continue;}
case 232:{f.Push(JValue.R(rt.String(" protection from ")));f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",237);}
case 237:{f.StackOp("pop");f.Pc=238;continue;}
case 238:{f.Push(f.Locals[3]);f.Pc=239;continue;}
case 239:{f.Pc=f.Pop().Int==0?250:242;continue;}
case 242:{f.Push(f.Locals[5]);f.Pc=244;continue;}
case 244:{f.Push(JValue.R(rt.String("your choice of ")));f.Pc=246;continue;}
case 246:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",249);}
case 249:{f.StackOp("pop");f.Pc=250;continue;}
case 250:{f.Push(JValue.I(0));f.Pc=251;continue;}
case 251:{f.Locals[8]=f.Pop();f.Pc=253;continue;}
case 253:{f.Push(f.Locals[8]);f.Pc=255;continue;}
case 255:{f.Push(f.Locals[2]);f.Pc=256;continue;}
case 256:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",261);}
case 261:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?326:264;continue;}
case 264:{f.Push(f.Locals[8]);f.Pc=266;continue;}
case 266:{f.Pc=f.Pop().Int==0?277:269;continue;}
case 269:{f.Push(f.Locals[5]);f.Pc=271;continue;}
case 271:{f.Push(JValue.R(rt.String(", ")));f.Pc=273;continue;}
case 273:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",276);}
case 276:{f.StackOp("pop");f.Pc=277;continue;}
case 277:{f.Push(f.Locals[8]);f.Pc=279;continue;}
case 279:{f.Push(f.Locals[2]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",285);}
case 285:{f.Push(JValue.I(1));f.Pc=286;continue;}
case 286:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=287;continue;}
case 287:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?303:290;continue;}
case 290:{f.Push(f.Locals[5]);f.Pc=292;continue;}
case 292:{f.Push(f.Locals[4]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",297);}
case 297:{f.Push(JValue.R(rt.String(" ")));f.Pc=299;continue;}
case 299:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",302);}
case 302:{f.StackOp("pop");f.Pc=303;continue;}
case 303:{f.Push(f.Locals[5]);f.Pc=305;continue;}
case 305:{f.Push(f.Locals[2]);f.Pc=306;continue;}
case 306:{f.Push(f.Locals[8]);f.Pc=308;continue;}
case 308:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",313);}
case 313:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=316;continue;}
case 316:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",319);}
case 319:{f.StackOp("pop");f.Pc=320;continue;}
case 320:{f.Locals[8]=JValue.I(unchecked(f.Locals[8].Int+(1)));f.Pc=323;continue;}
case 323:{f.Pc=253;continue;}
case 326:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=328;continue;}
case 328:{f.Push(f.Locals[1]);f.Pc=329;continue;}
case 329:{f.Push(JValue.R(rt.String("Duration")));f.Pc=331;continue;}
case 331:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",334);}
case 334:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",337);}
case 337:{f.Pc=f.Pop().Int!=0?348:340;continue;}
case 340:{f.Push(f.Locals[5]);f.Pc=342;continue;}
case 342:{f.Push(JValue.R(rt.String(" until end of turn")));f.Pc=344;continue;}
case 344:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",347);}
case 347:{f.StackOp("pop");f.Pc=348;continue;}
case 348:{f.Push(f.Locals[5]);f.Pc=350;continue;}
case 350:{f.Push(JValue.R(rt.String(".")));f.Pc=352;continue;}
case 352:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",355);}
case 355:{f.StackOp("pop");f.Pc=356;continue;}
case 356:{f.Push(f.Locals[5]);f.Pc=358;continue;}
case 358:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",361);}
case 361:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3577(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(JValue.R(rt.String("Gains")));f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Push(JValue.R(rt.String("Choice")));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",24);}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[1]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/ability/effects/ProtectEffect","getProtectionList","(Lforge/game/spellability/SpellAbility;)Ljava/util/List;","invokestatic",30);}
case 30:{f.Locals[5]=f.Pop();f.Pc=32;continue;}
case 32:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=35;continue;}
case 35:{f.StackOp("dup");f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",39);}
case 39:{f.Locals[6]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/ability/effects/ProtectEffect","getTargetCards","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",45);}
case 45:{f.Locals[7]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{f.Pc=f.Pop().Int==0?167:52;continue;}
case 52:{f.Push(f.Locals[5]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",59);}
case 59:{f.Pc=f.Pop().Int!=0?167:62;continue;}
case 62:{f.Push(f.Locals[1]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",66);}
case 66:{f.Locals[8]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[1]);f.Pc=69;continue;}
case 69:{f.Push(JValue.R(rt.String("Choser")));f.Pc=71;continue;}
case 71:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",74);}
case 74:{f.Pc=f.Pop().Int==0?117:77;continue;}
case 77:{f.Push(f.Locals[1]);f.Pc=78;continue;}
case 78:{f.Push(JValue.R(rt.String("Choser")));f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",83);}
case 83:{f.Push(JValue.R(rt.String("Controller")));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",88);}
case 88:{f.Pc=f.Pop().Int==0?117:91;continue;}
case 91:{f.Push(f.Locals[7]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",98);}
case 98:{f.Pc=f.Pop().Int!=0?117:101;continue;}
case 101:{f.Push(f.Locals[7]);f.Pc=103;continue;}
case 103:{f.Push(JValue.I(0));f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",109);}
case 109:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",115);}
case 115:{f.Locals[8]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[8]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/player/Player","getController","()Lforge/game/player/PlayerController;","invokevirtual",122);}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[5]);f.Pc=125;continue;}
case 125:{return rt.Call(f,"forge/game/player/PlayerController","chooseProtectionType","(Lforge/game/spellability/SpellAbility;Ljava/util/List;)Ljava/lang/String;","invokevirtual",128);}
case 128:{f.Locals[9]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(JValue.R(null));f.Pc=131;continue;}
case 131:{f.Push(f.Locals[9]);f.Pc=133;continue;}
case 133:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?137:136;continue;}
case 136:{return JStep.ReturnVoid;}
case 137:{f.Push(f.Locals[6]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[9]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",146);}
case 146:{f.StackOp("pop");f.Pc=147;continue;}
case 147:{f.Push(f.Locals[3]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",151);}
case 151:{f.Push(f.Locals[1]);f.Pc=152;continue;}
case 152:{f.Push(f.Locals[8]);f.Pc=154;continue;}
case 154:{f.Push(f.Locals[6]);f.Pc=156;continue;}
case 156:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",159);}
case 159:{f.Push(f.Locals[8]);f.Pc=161;continue;}
case 161:{return rt.Call(f,"forge/game/GameAction","notifyOfValue","(Lforge/game/spellability/SpellAbility;Lforge/game/GameObject;Ljava/lang/String;Lforge/game/player/Player;)V","invokevirtual",164);}
case 164:{f.Pc=333;continue;}
case 167:{f.Push(f.Locals[1]);f.Pc=168;continue;}
case 168:{f.Push(JValue.R(rt.String("Gains")));f.Pc=170;continue;}
case 170:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",173);}
case 173:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",178);}
case 178:{f.Pc=f.Pop().Int==0?233:181;continue;}
case 181:{f.Push(f.Locals[2]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/game/card/Card","getChosenColors","()Ljava/lang/Iterable;","invokevirtual",185);}
case 185:{return rt.Call(f,"java/lang/Iterable","iterator","()Ljava/util/Iterator;","invokeinterface",190);}
case 190:{f.Locals[8]=f.Pop();f.Pc=192;continue;}
case 192:{f.Push(f.Locals[8]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",199);}
case 199:{f.Pc=f.Pop().Int==0?230:202;continue;}
case 202:{f.Push(f.Locals[8]);f.Pc=204;continue;}
case 204:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",209);}
case 209:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=212;continue;}
case 212:{f.Locals[9]=f.Pop();f.Pc=214;continue;}
case 214:{f.Push(f.Locals[6]);f.Pc=216;continue;}
case 216:{f.Push(f.Locals[9]);f.Pc=218;continue;}
case 218:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",221);}
case 221:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",226);}
case 226:{f.StackOp("pop");f.Pc=227;continue;}
case 227:{f.Pc=192;continue;}
case 230:{f.Pc=333;continue;}
case 233:{f.Push(f.Locals[1]);f.Pc=234;continue;}
case 234:{f.Push(JValue.R(rt.String("Gains")));f.Pc=236;continue;}
case 236:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",239);}
case 239:{f.Push(JValue.R(rt.String("Defined")));f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",244);}
case 244:{f.Pc=f.Pop().Int==0?323:247;continue;}
case 247:{f.Push(f.Locals[2]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[1]);f.Pc=249;continue;}
case 249:{f.Push(JValue.R(rt.String("Gains")));f.Pc=251;continue;}
case 251:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",254);}
case 254:{f.Push(JValue.I(8));f.Pc=256;continue;}
case 256:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",259);}
case 259:{f.Push(f.Locals[1]);f.Pc=260;continue;}
case 260:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedCards","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",263);}
case 263:{f.Locals[8]=f.Pop();f.Pc=265;continue;}
case 265:{f.Push(f.Locals[8]);f.Pc=267;continue;}
case 267:{f.Push(JValue.I(0));f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/game/card/CardCollection","get","(I)Ljava/lang/Object;","invokevirtual",271);}
case 271:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=274;continue;}
case 274:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",277);}
case 277:{return rt.Call(f,"forge/card/ColorSet","iterator","()Ljava/util/Iterator;","invokevirtual",280);}
case 280:{f.Locals[9]=f.Pop();f.Pc=282;continue;}
case 282:{f.Push(f.Locals[9]);f.Pc=284;continue;}
case 284:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",289);}
case 289:{f.Pc=f.Pop().Int==0?320:292;continue;}
case 292:{f.Push(f.Locals[9]);f.Pc=294;continue;}
case 294:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",299);}
case 299:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/MagicColor$Color"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=302;continue;}
case 302:{f.Locals[10]=f.Pop();f.Pc=304;continue;}
case 304:{f.Push(f.Locals[6]);f.Pc=306;continue;}
case 306:{f.Push(f.Locals[10]);f.Pc=308;continue;}
case 308:{return rt.Call(f,"forge/card/MagicColor$Color","getName","()Ljava/lang/String;","invokevirtual",311);}
case 311:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",316);}
case 316:{f.StackOp("pop");f.Pc=317;continue;}
case 317:{f.Pc=282;continue;}
case 320:{f.Pc=333;continue;}
case 323:{f.Push(f.Locals[6]);f.Pc=325;continue;}
case 325:{f.Push(f.Locals[5]);f.Pc=327;continue;}
case 327:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",332);}
case 332:{f.StackOp("pop");f.Pc=333;continue;}
case 333:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",336);}
case 336:{f.Locals[8]=f.Pop();f.Pc=338;continue;}
case 338:{f.Push(f.Locals[6]);f.Pc=340;continue;}
case 340:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",345);}
case 345:{f.Locals[9]=f.Pop();f.Pc=347;continue;}
case 347:{f.Push(f.Locals[9]);f.Pc=349;continue;}
case 349:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",354);}
case 354:{f.Pc=f.Pop().Int==0?423:357;continue;}
case 357:{f.Push(f.Locals[9]);f.Pc=359;continue;}
case 359:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",364);}
case 364:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=367;continue;}
case 367:{f.Locals[10]=f.Pop();f.Pc=369;continue;}
case 369:{f.Push(f.Locals[10]);f.Pc=371;continue;}
case 371:{return rt.Call(f,"forge/card/CardType","isACardType","(Ljava/lang/String;)Z","invokestatic",374);}
case 374:{f.Pc=f.Pop().Int==0?395:377;continue;}
case 377:{f.Push(f.Locals[8]);f.Pc=379;continue;}
case 379:{f.Push(f.Locals[10]);f.Pc=381;continue;}
case 381:{return rt.DynamicCall(f,"forge/game/ability/effects/ProtectEffect:3577:381:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",386);}
case 386:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",391);}
case 391:{f.StackOp("pop");f.Pc=392;continue;}
case 392:{f.Pc=420;continue;}
case 395:{f.Push(f.Locals[8]);f.Pc=397;continue;}
case 397:{f.Push(JValue.I(2));f.Pc=398;continue;}
case 398:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=401;continue;}
case 401:{f.StackOp("dup");f.Pc=402;continue;}
case 402:{f.Push(JValue.I(0));f.Pc=403;continue;}
case 403:{f.Push(JValue.R(rt.String("Protection from")));f.Pc=405;continue;}
case 405:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=406;continue;}
case 406:{f.StackOp("dup");f.Pc=407;continue;}
case 407:{f.Push(JValue.I(1));f.Pc=408;continue;}
case 408:{f.Push(f.Locals[10]);f.Pc=410;continue;}
case 410:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=411;continue;}
case 411:{return rt.Call(f,"forge/util/TextUtil","concatWithSpace","([Ljava/lang/String;)Ljava/lang/String;","invokestatic",414);}
case 414:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",419);}
case 419:{f.StackOp("pop");f.Pc=420;continue;}
case 420:{f.Pc=347;continue;}
case 423:{f.Push(f.Locals[7]);f.Pc=425;continue;}
case 425:{f.Push(f.Locals[1]);f.Pc=426;continue;}
case 426:{return rt.Call(f,"forge/game/card/CardUtil","getRadiance","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",429);}
case 429:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",434);}
case 434:{f.StackOp("pop");f.Pc=435;continue;}
case 435:{f.Push(f.Locals[3]);f.Pc=436;continue;}
case 436:{return rt.Call(f,"forge/game/Game","getNextTimestamp","()J","invokevirtual",439);}
case 439:{f.Locals[9]=f.Pop();f.Pc=441;continue;}
case 441:{f.Push(f.Locals[7]);f.Pc=443;continue;}
case 443:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",448);}
case 448:{f.Locals[11]=f.Pop();f.Pc=450;continue;}
case 450:{f.Push(f.Locals[11]);f.Pc=452;continue;}
case 452:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",457);}
case 457:{f.Pc=f.Pop().Int==0?584:460;continue;}
case 460:{f.Push(f.Locals[11]);f.Pc=462;continue;}
case 462:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",467);}
case 467:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=470;continue;}
case 470:{f.Locals[12]=f.Pop();f.Pc=472;continue;}
case 472:{f.Push(f.Locals[12]);f.Pc=474;continue;}
case 474:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",477);}
case 477:{f.Pc=f.Pop().Int!=0?483:480;continue;}
case 480:{f.Pc=450;continue;}
case 483:{f.Push(f.Locals[12]);f.Pc=485;continue;}
case 485:{return rt.Call(f,"forge/game/card/Card","isPhasedOut","()Z","invokevirtual",488);}
case 488:{f.Pc=f.Pop().Int==0?494:491;continue;}
case 491:{f.Pc=450;continue;}
case 494:{f.Push(f.Locals[3]);f.Pc=495;continue;}
case 495:{f.Push(f.Locals[12]);f.Pc=497;continue;}
case 497:{f.Push(JValue.R(null));f.Pc=498;continue;}
case 498:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",501);}
case 501:{f.Locals[13]=f.Pop();f.Pc=503;continue;}
case 503:{f.Push(f.Locals[13]);f.Pc=505;continue;}
case 505:{f.Pc=f.Pop().Reference==null?450:508;continue;}
case 508:{f.Push(f.Locals[12]);f.Pc=510;continue;}
case 510:{f.Push(f.Locals[13]);f.Pc=512;continue;}
case 512:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",515);}
case 515:{f.Pc=f.Pop().Int!=0?521:518;continue;}
case 518:{f.Pc=450;continue;}
case 521:{f.Push(f.Locals[13]);f.Pc=523;continue;}
case 523:{f.Push(f.Locals[8]);f.Pc=525;continue;}
case 525:{f.Push(JValue.R(null));f.Pc=526;continue;}
case 526:{f.Push(JValue.I(0));f.Pc=527;continue;}
case 527:{f.Push(f.Locals[9]);f.Pc=529;continue;}
case 529:{f.Push(JValue.R(null));f.Pc=530;continue;}
case 530:{return rt.Call(f,"forge/game/card/Card","addChangedCardKeywords","(Ljava/util/List;Ljava/util/List;ZJLforge/game/staticability/StaticAbility;)V","invokevirtual",533);}
case 533:{f.Push(f.Locals[3]);f.Pc=534;continue;}
case 534:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventCardStatsChanged"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventCardStatsChanged")));f.Pc=537;continue;}
case 537:{f.StackOp("dup");f.Pc=538;continue;}
case 538:{f.Push(f.Locals[13]);f.Pc=540;continue;}
case 540:{return rt.Call(f,"forge/game/event/GameEventCardStatsChanged","<init>","(Lforge/game/card/Card;)V","invokespecial",543);}
case 543:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",546);}
case 546:{f.Push(JValue.R(rt.String("Permanent")));f.Pc=548;continue;}
case 548:{f.Push(f.Locals[1]);f.Pc=549;continue;}
case 549:{f.Push(JValue.R(rt.String("Duration")));f.Pc=551;continue;}
case 551:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",554);}
case 554:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",557);}
case 557:{f.Pc=f.Pop().Int!=0?581:560;continue;}
case 560:{if(!rt.EnsureInitialized(f,"forge/game/ability/effects/ProtectEffect$1"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/effects/ProtectEffect$1")));f.Pc=563;continue;}
case 563:{f.StackOp("dup");f.Pc=564;continue;}
case 564:{f.Push(f.Locals[0]);f.Pc=565;continue;}
case 565:{f.Push(f.Locals[13]);f.Pc=567;continue;}
case 567:{f.Push(f.Locals[9]);f.Pc=569;continue;}
case 569:{f.Push(f.Locals[3]);f.Pc=570;continue;}
case 570:{return rt.Call(f,"forge/game/ability/effects/ProtectEffect$1","<init>","(Lforge/game/ability/effects/ProtectEffect;Lforge/game/card/Card;JLforge/game/Game;)V","invokespecial",573);}
case 573:{f.Locals[14]=f.Pop();f.Pc=575;continue;}
case 575:{f.Push(f.Locals[1]);f.Pc=576;continue;}
case 576:{f.Push(f.Locals[14]);f.Pc=578;continue;}
case 578:{return rt.Call(f,"forge/game/ability/effects/ProtectEffect","addUntilCommand","(Lforge/game/spellability/SpellAbility;Lforge/GameCommand;)V","invokestatic",581);}
case 581:{f.Pc=450;continue;}
case 584:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3578(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("Gains")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("Choice")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",21);}
case 21:{f.Pc=f.Pop().Int==0?112:24;continue;}
case 24:{f.Push(f.Locals[0]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("Choices")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",30);}
case 30:{f.Locals[3]=f.Pop();f.Pc=31;continue;}
case 31:{f.Push(f.Locals[3]);f.Pc=32;continue;}
case 32:{f.Push(JValue.R(rt.String("AnyColor")));f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",38);}
case 38:{f.Pc=f.Pop().Int==0?65:41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{if(!rt.StaticReady(f,"forge/card/MagicColor$Constant","ONLY_COLORS","Lcom/google/common/collect/ImmutableList;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor$Constant","ONLY_COLORS","Lcom/google/common/collect/ImmutableList;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",50);}
case 50:{f.StackOp("pop");f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("AnyColor,?")));f.Pc=55;continue;}
case 55:{f.Push(JValue.R(rt.String("")));f.Pc=58;continue;}
case 58:{return rt.Call(f,"java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",61);}
case 61:{f.Locals[3]=f.Pop();f.Pc=62;continue;}
case 62:{f.Pc=85;continue;}
case 65:{f.Push(f.Locals[3]);f.Pc=66;continue;}
case 66:{f.Push(JValue.R(rt.String("CardType")));f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/String","contains","(Ljava/lang/CharSequence;)Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?85:75;continue;}
case 75:{return rt.Call(f,"forge/card/CardType","getAllCardTypes","()Ljava/util/Set;","invokestatic",78);}
case 78:{f.Push(JValue.R(rt.String(",")));f.Pc=81;continue;}
case 81:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",84);}
case 84:{f.Locals[3]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int<=0?109:92;continue;}
case 92:{f.Push(f.Locals[1]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[3]);f.Pc=94;continue;}
case 94:{f.Push(JValue.R(rt.String(",")));f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",100);}
case 100:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",103);}
case 103:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",108);}
case 108:{f.StackOp("pop");f.Pc=109;continue;}
case 109:{f.Pc=129;continue;}
case 112:{f.Push(f.Locals[1]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[2]);f.Pc=114;continue;}
case 114:{f.Push(JValue.R(rt.String(",")));f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",120);}
case 120:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",123);}
case 123:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",128);}
case 128:{f.StackOp("pop");f.Pc=129;continue;}
case 129:{f.Push(f.Locals[1]);f.Pc=130;continue;}
case 130:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
