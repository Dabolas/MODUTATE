// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C369{
internal static JClass Build(){var c=new JClass("forge/game/ability/effects/RegenerateEffect","forge/game/ability/SpellAbilityEffect",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(3615,"forge/game/ability/effects/RegenerateEffect","<init>","()V",1,1,1,new JHandler[]{},M3615));
c.Add(new JMethod(3616,"forge/game/ability/effects/RegenerateEffect","getStackDescription","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",4,4,2,new JHandler[]{},M3616));
c.Add(new JMethod(3617,"forge/game/ability/effects/RegenerateEffect","resolve","(Lforge/game/spellability/SpellAbility;)V",1,7,3,new JHandler[]{},M3617));
c.Add(new JMethod(3618,"forge/game/ability/effects/RegenerateEffect","createRegenerationEffect","(Lforge/game/spellability/SpellAbility;Ljava/util/Collection;)V",2,14,4,new JHandler[]{},M3618));
c.Add(new JMethod(3619,"forge/game/ability/effects/RegenerateEffect","$deserializeLambda$","(Ljava/lang/invoke/SerializedLambda;)Ljava/lang/Object;",4106,3,3,new JHandler[]{},M3619));
c.Add(new JMethod(3620,"forge/game/ability/effects/RegenerateEffect","lambda$createRegenerationEffect$c9d23c3b$1","(Lforge/game/Game;Lforge/game/card/Card;)V",4106,2,2,new JHandler[]{},M3620));
}

internal static JStep M3615(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/ability/SpellAbilityEffect","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3616(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/effects/RegenerateEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",12);}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[3]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int!=0?45:22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("Regenerate ")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{f.Push(f.Locals[2]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[3]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/util/Lang","joinHomogenous","(Ljava/util/Collection;)Ljava/lang/String;","invokestatic",34);}
case 34:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",37);}
case 37:{f.StackOp("pop");f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{f.Push(JValue.R(rt.String(".")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",44);}
case 44:{f.StackOp("pop");f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",49);}
case 49:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3617(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",4);}
case 4:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=11;continue;}
case 11:{f.StackOp("dup");f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",15);}
case 15:{f.Locals[3]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/game/ability/effects/RegenerateEffect","getDefinedCardsOrTargeted","(Lforge/game/spellability/SpellAbility;)Lforge/game/card/CardCollection;","invokestatic",20);}
case 20:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",23);}
case 23:{f.Locals[4]=f.Pop();f.Pc=25;continue;}
case 25:{f.Push(f.Locals[4]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",32);}
case 32:{f.Pc=f.Pop().Int==0?95:35;continue;}
case 35:{f.Push(f.Locals[4]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",42);}
case 42:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=45;continue;}
case 45:{f.Locals[5]=f.Pop();f.Pc=47;continue;}
case 47:{f.Push(f.Locals[5]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/card/Card","isInPlay","()Z","invokevirtual",52);}
case 52:{f.Pc=f.Pop().Int!=0?58:55;continue;}
case 55:{f.Pc=25;continue;}
case 58:{f.Push(f.Locals[2]);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[5]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(null));f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/game/Game","getCardState","(Lforge/game/card/Card;Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",65);}
case 65:{f.Locals[6]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[6]);f.Pc=69;continue;}
case 69:{f.Pc=f.Pop().Reference==null?25:72;continue;}
case 72:{f.Push(f.Locals[5]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[6]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"forge/game/card/Card","equalsWithGameTimestamp","(Lforge/game/card/Card;)Z","invokevirtual",79);}
case 79:{f.Pc=f.Pop().Int!=0?85:82;continue;}
case 82:{f.Pc=25;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{f.Push(f.Locals[6]);f.Pc=88;continue;}
case 88:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",91);}
case 91:{f.StackOp("pop");f.Pc=92;continue;}
case 92:{f.Pc=25;continue;}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[1]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[3]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"forge/game/ability/effects/RegenerateEffect","createRegenerationEffect","(Lforge/game/spellability/SpellAbility;Ljava/util/Collection;)V","invokevirtual",101);}
case 101:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3618(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",6);}
case 6:{f.Pc=f.Pop().Int==0?10:9;continue;}
case 9:{return JStep.ReturnVoid;}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",14);}
case 14:{f.Locals[3]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[3]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",19);}
case 19:{f.Locals[4]=f.Pop();f.Pc=21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",26);}
case 26:{f.Push(f.Locals[3]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",30);}
case 30:{return rt.DynamicCall(f,"forge/game/ability/effects/RegenerateEffect:3618:30:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",35);}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",39);}
case 39:{return rt.Call(f,"forge/game/ability/effects/RegenerateEffect","createEffect","(Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Ljava/lang/String;Ljava/lang/String;)Lforge/game/card/Card;","invokestatic",42);}
case 42:{f.Locals[5]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[5]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",50);}
case 50:{f.Push(f.Locals[5]);f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("Battlefield")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/ability/effects/RegenerateEffect","addForgetOnMovedTrigger","(Lforge/game/card/Card;Ljava/lang/String;)V","invokestatic",57);}
case 57:{f.Push(JValue.R(rt.String("Event$ Destroy | ActiveZones$ Command | ValidCard$ Card.IsRemembered | Regeneration$ True | Description$ Regeneration (if creature would be destroyed, regenerate it instead)")));f.Pc=59;continue;}
case 59:{f.Locals[6]=f.Pop();f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("DB$ Regeneration | Defined$ ReplacedCard")));f.Pc=63;continue;}
case 63:{f.Locals[7]=f.Pop();f.Pc=65;continue;}
case 65:{f.Push(JValue.R(rt.String("DB$ ChangeZone | Defined$ Self | Origin$ Command | Destination$ Exile | ConditionDefined$ Remembered | ConditionPresent$ Card | ConditionCompare$ EQ0")));f.Pc=67;continue;}
case 67:{f.Locals[8]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[6]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[5]);f.Pc=73;continue;}
case 73:{f.Push(JValue.I(1));f.Pc=74;continue;}
case 74:{return rt.Call(f,"forge/game/replacement/ReplacementHandler","parseReplacement","(Ljava/lang/String;Lforge/game/card/Card;Z)Lforge/game/replacement/ReplacementEffect;","invokestatic",77);}
case 77:{f.Locals[9]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(f.Locals[7]);f.Pc=81;continue;}
case 81:{f.Push(f.Locals[5]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",86);}
case 86:{f.Locals[10]=f.Pop();f.Pc=88;continue;}
case 88:{f.Push(f.Locals[8]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[5]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"forge/game/ability/AbilityFactory","getAbility","(Ljava/lang/String;Lforge/game/card/Card;)Lforge/game/spellability/SpellAbility;","invokestatic",95);}
case 95:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=98;continue;}
case 98:{f.Locals[11]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[1]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("RegenerationAbility")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasAdditionalAbility","(Ljava/lang/String;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int==0?137:109;continue;}
case 109:{f.Push(f.Locals[1]);f.Pc=110;continue;}
case 110:{f.Push(JValue.R(rt.String("RegenerationAbility")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/spellability/SpellAbility","getAdditionalAbility","(Ljava/lang/String;)Lforge/game/spellability/SpellAbility;","invokevirtual",115);}
case 115:{f.Push(f.Locals[5]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[1]);f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",121);}
case 121:{f.Push(JValue.I(0));f.Pc=122;continue;}
case 122:{return rt.Call(f,"forge/game/spellability/SpellAbility","copy","(Lforge/game/card/Card;Lforge/game/player/Player;Z)Lforge/game/spellability/SpellAbility;","invokevirtual",125);}
case 125:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/AbilitySub"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=128;continue;}
case 128:{f.Locals[12]=f.Pop();f.Pc=130;continue;}
case 130:{f.Push(f.Locals[11]);f.Pc=132;continue;}
case 132:{f.Push(f.Locals[12]);f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/game/spellability/AbilitySub","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",137);}
case 137:{f.Push(f.Locals[10]);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[11]);f.Pc=141;continue;}
case 141:{return rt.Call(f,"forge/game/spellability/SpellAbility","setSubAbility","(Lforge/game/spellability/AbilitySub;)V","invokevirtual",144);}
case 144:{f.Push(f.Locals[9]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[10]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/replacement/ReplacementEffect","setOverridingAbility","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",151);}
case 151:{f.Push(f.Locals[5]);f.Pc=153;continue;}
case 153:{f.Push(f.Locals[9]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/card/Card","addReplacementEffect","(Lforge/game/replacement/ReplacementEffect;)Lforge/game/replacement/ReplacementEffect;","invokevirtual",158);}
case 158:{f.StackOp("pop");f.Pc=159;continue;}
case 159:{f.Push(f.Locals[1]);f.Pc=160;continue;}
case 160:{f.Push(JValue.R(rt.String("RememberObjects")));f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",165);}
case 165:{f.Pc=f.Pop().Int==0?184:168;continue;}
case 168:{f.Push(f.Locals[5]);f.Pc=170;continue;}
case 170:{f.Push(f.Locals[3]);f.Pc=171;continue;}
case 171:{f.Push(f.Locals[1]);f.Pc=172;continue;}
case 172:{f.Push(JValue.R(rt.String("RememberObjects")));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",177);}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/game/ability/AbilityUtils","getDefinedObjects","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)Lforge/util/collect/FCollection;","invokestatic",181);}
case 181:{return rt.Call(f,"forge/game/card/Card","addRemembered","(Ljava/lang/Iterable;)V","invokevirtual",184);}
case 184:{f.Push(f.Locals[1]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"forge/game/spellability/SpellAbility","isIntrinsic","()Z","invokevirtual",188);}
case 188:{f.Pc=f.Pop().Int==0?197:191;continue;}
case 191:{f.Push(f.Locals[5]);f.Pc=193;continue;}
case 193:{f.Push(f.Locals[3]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/game/card/Card","copyChangedTextFrom","(Lforge/game/card/Card;)V","invokevirtual",197);}
case 197:{f.Push(f.Locals[2]);f.Pc=198;continue;}
case 198:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",203);}
case 203:{f.Locals[12]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(f.Locals[12]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",212);}
case 212:{f.Pc=f.Pop().Int==0?235:215;continue;}
case 215:{f.Push(f.Locals[12]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",222);}
case 222:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=225;continue;}
case 225:{f.Locals[13]=f.Pop();f.Pc=227;continue;}
case 227:{f.Push(f.Locals[13]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/card/Card","incShieldCount","()V","invokevirtual",232);}
case 232:{f.Pc=205;continue;}
case 235:{f.Push(f.Locals[4]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",240);}
case 240:{f.Push(f.Locals[5]);f.Pc=242;continue;}
case 242:{f.Push(f.Locals[1]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"forge/game/GameAction","moveToCommand","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokevirtual",246);}
case 246:{f.Push(f.Locals[4]);f.Pc=248;continue;}
case 248:{return rt.Call(f,"forge/game/Game","getEndOfTurn","()Lforge/game/phase/Phase;","invokevirtual",251);}
case 251:{f.Push(f.Locals[4]);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[5]);f.Pc=255;continue;}
case 255:{return rt.DynamicCall(f,"forge/game/ability/effects/RegenerateEffect:3618:255:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/GameCommand;",260);}
case 260:{return rt.Call(f,"forge/game/phase/Phase","addUntil","(Lforge/GameCommand;)V","invokevirtual",263);}
case 263:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3619(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodName","()Ljava/lang/String;","invokevirtual",4);}
case 4:{f.Locals[1]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(JValue.I(-1));f.Pc=6;continue;}
case 6:{f.Locals[2]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",11);}
case 11:{switch(f.Pop().Int){case -833723233:f.Pc=28;break;default:f.Pc=39;break;}continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{f.Push(JValue.R(rt.String("lambda$createRegenerationEffect$c9d23c3b$1")));f.Pc=31;continue;}
case 31:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",34);}
case 34:{f.Pc=f.Pop().Int==0?39:37;continue;}
case 37:{f.Push(JValue.I(0));f.Pc=38;continue;}
case 38:{f.Locals[2]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{switch(f.Pop().Int){case 0:f.Pc=60;break;default:f.Pc=153;break;}continue;}
case 60:{f.Push(f.Locals[0]);f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodKind","()I","invokevirtual",64);}
case 64:{f.Push(JValue.I(6));f.Pc=66;continue;}
case 66:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?153:69;continue;}
case 69:{f.Push(f.Locals[0]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceClass","()Ljava/lang/String;","invokevirtual",73);}
case 73:{f.Push(JValue.R(rt.String("forge/GameCommand")));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int==0?153:81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodName","()Ljava/lang/String;","invokevirtual",85);}
case 85:{f.Push(JValue.R(rt.String("run")));f.Pc=87;continue;}
case 87:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",90);}
case 90:{f.Pc=f.Pop().Int==0?153:93;continue;}
case 93:{f.Push(f.Locals[0]);f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getFunctionalInterfaceMethodSignature","()Ljava/lang/String;","invokevirtual",97);}
case 97:{f.Push(JValue.R(rt.String("()V")));f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",102);}
case 102:{f.Pc=f.Pop().Int==0?153:105;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplClass","()Ljava/lang/String;","invokevirtual",109);}
case 109:{f.Push(JValue.R(rt.String("forge/game/ability/effects/RegenerateEffect")));f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",115);}
case 115:{f.Pc=f.Pop().Int==0?153:118;continue;}
case 118:{f.Push(f.Locals[0]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getImplMethodSignature","()Ljava/lang/String;","invokevirtual",122);}
case 122:{f.Push(JValue.R(rt.String("(Lforge/game/Game;Lforge/game/card/Card;)V")));f.Pc=125;continue;}
case 125:{return rt.Call(f,"java/lang/Object","equals","(Ljava/lang/Object;)Z","invokevirtual",128);}
case 128:{f.Pc=f.Pop().Int==0?153:131;continue;}
case 131:{f.Push(f.Locals[0]);f.Pc=132;continue;}
case 132:{f.Push(JValue.I(0));f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",136);}
case 136:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/Game"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=139;continue;}
case 139:{f.Push(f.Locals[0]);f.Pc=140;continue;}
case 140:{f.Push(JValue.I(1));f.Pc=141;continue;}
case 141:{return rt.Call(f,"java/lang/invoke/SerializedLambda","getCapturedArg","(I)Ljava/lang/Object;","invokevirtual",144);}
case 144:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=147;continue;}
case 147:{return rt.DynamicCall(f,"forge/game/ability/effects/RegenerateEffect:3619:147:java/lang/invoke/LambdaMetafactory.altMetafactory","(Lforge/game/Game;Lforge/game/card/Card;)Lforge/GameCommand;",152);}
case 152:{return JStep.Return(f.Pop());}
case 153:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=156;continue;}
case 156:{f.StackOp("dup");f.Pc=157;continue;}
case 157:{f.Push(JValue.R(rt.String("Invalid lambda deserialization")));f.Pc=160;continue;}
case 160:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",163);}
case 163:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M3620(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/Game","getAction","()Lforge/game/GameAction;","invokevirtual",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/GameAction","exileEffect","(Lforge/game/card/Card;)Lforge/game/card/Card;","invokevirtual",8);}
case 8:{f.StackOp("pop");f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
