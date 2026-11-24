// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C505{
internal static JClass Build(){var c=new JClass("forge/game/card/token/TokenInfo","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("TOKEN_EDITION_PINS","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("name","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("imageName","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("manaCost","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("types","[Ljava/lang/String;",false,JValue.Default("[Ljava/lang/String;"),null));
c.Add(new JField("intrinsicKeywords","[Ljava/lang/String;",false,JValue.Default("[Ljava/lang/String;"),null));
c.Add(new JField("basePower","I",false,JValue.Default("I"),null));
c.Add(new JField("baseToughness","I",false,JValue.Default("I"),null));
c.Add(new JField("color","Lforge/card/ColorSet;",false,JValue.Default("Lforge/card/ColorSet;"),null));
c.Add(new JMethod(5955,"forge/game/card/token/TokenInfo","getPinsFor","(Lforge/game/Game;)Ljava/util/Map;",10,1,3,new JHandler[]{},M5955));
c.Add(new JMethod(5956,"forge/game/card/token/TokenInfo","<init>","(Lforge/game/card/Card;)V",1,5,3,new JHandler[]{},M5956));
c.Add(new JMethod(5957,"forge/game/card/token/TokenInfo","<init>","(Ljava/lang/String;)V",1,16,4,new JHandler[]{},M5957));
c.Add(new JMethod(5958,"forge/game/card/token/TokenInfo","getCardTypes","(Lforge/game/card/Card;)[Ljava/lang/String;",10,4,3,new JHandler[]{},M5958));
c.Add(new JMethod(5959,"forge/game/card/token/TokenInfo","toCard","(Lforge/game/Game;)Lforge/game/card/Card;",2,2,3,new JHandler[]{},M5959));
c.Add(new JMethod(5960,"forge/game/card/token/TokenInfo","toCard","(Lforge/game/Game;I)Lforge/game/card/Card;",2,8,4,new JHandler[]{},M5960));
c.Add(new JMethod(5961,"forge/game/card/token/TokenInfo","toString","()Ljava/lang/String;",1,2,3,new JHandler[]{},M5961));
c.Add(new JMethod(5962,"forge/game/card/token/TokenInfo","makeOneToken","(Lforge/game/player/Player;)Lforge/game/card/Card;",1,2,3,new JHandler[]{},M5962));
c.Add(new JMethod(5963,"forge/game/card/token/TokenInfo","makeOneToken","(Lforge/game/player/Player;I)Lforge/game/card/Card;",1,9,3,new JHandler[]{},M5963));
c.Add(new JMethod(5964,"forge/game/card/token/TokenInfo","protoTypeApplyTextChange","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V",12,12,3,new JHandler[]{},M5964));
c.Add(new JMethod(5965,"forge/game/card/token/TokenInfo","tokenSetFor","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",9,3,2,new JHandler[]{},M5965));
c.Add(new JMethod(5966,"forge/game/card/token/TokenInfo","getProtoType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;)Lforge/game/card/Card;",9,3,5,new JHandler[]{},M5966));
c.Add(new JMethod(5967,"forge/game/card/token/TokenInfo","getProtoType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Lforge/game/card/Card;",9,13,4,new JHandler[]{},M5967));
c.Add(new JMethod(5968,"forge/game/card/token/TokenInfo","lambda$getPinsFor$0","(Lforge/game/Game;)Ljava/util/Map;",4106,1,2,new JHandler[]{},M5968));
c.Add(new JMethod(5969,"forge/game/card/token/TokenInfo","<clinit>","()V",8,0,2,new JHandler[]{},M5969));
}

internal static JStep M5955(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/card/token/TokenInfo","TOKEN_EDITION_PINS","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/card/token/TokenInfo","TOKEN_EDITION_PINS","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.DynamicCall(f,"forge/game/card/token/TokenInfo:5955:4:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",9);}
case 9:{return rt.Call(f,"java/util/Map","computeIfAbsent","(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;","invokeinterface",14);}
case 14:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5956(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",9);}
case 9:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/token/TokenInfo","name","Ljava/lang/String;",value);f.Pc=12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/game/card/Card","getImageKey","()Ljava/lang/String;","invokevirtual",17);}
case 17:{return rt.Call(f,"forge/ImageKeys","getTokenImageName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",20);}
case 20:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/token/TokenInfo","imageName","Ljava/lang/String;",value);f.Pc=23;continue;}
case 23:{f.Push(f.Locals[0]);f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/Card","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",28);}
case 28:{return rt.Call(f,"forge/card/mana/ManaCost","toString","()Ljava/lang/String;","invokevirtual",31);}
case 31:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/token/TokenInfo","manaCost","Ljava/lang/String;",value);f.Pc=34;continue;}
case 34:{f.Push(f.Locals[0]);f.Pc=35;continue;}
case 35:{f.Push(f.Locals[1]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",39);}
case 39:{return rt.Call(f,"forge/game/card/CardState","getColor","()Lforge/card/ColorSet;","invokevirtual",42);}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/token/TokenInfo","color","Lforge/card/ColorSet;",value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[0]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/game/card/token/TokenInfo","getCardTypes","(Lforge/game/card/Card;)[Ljava/lang/String;","invokestatic",50);}
case 50:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/token/TokenInfo","types","[Ljava/lang/String;",value);f.Pc=53;continue;}
case 53:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",56);}
case 56:{f.Locals[2]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[1]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/Card","getKeywords","()Ljava/util/List;","invokevirtual",61);}
case 61:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",66);}
case 66:{f.Locals[3]=f.Pop();f.Pc=67;continue;}
case 67:{f.Push(f.Locals[3]);f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",73);}
case 73:{f.Pc=f.Pop().Int==0?104:76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",82);}
case 82:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=85;continue;}
case 85:{f.Locals[4]=f.Pop();f.Pc=87;continue;}
case 87:{f.Push(f.Locals[2]);f.Pc=88;continue;}
case 88:{f.Push(f.Locals[4]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",95);}
case 95:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",100);}
case 100:{f.StackOp("pop");f.Pc=101;continue;}
case 101:{f.Pc=67;continue;}
case 104:{f.Push(f.Locals[0]);f.Pc=105;continue;}
case 105:{f.Push(f.Locals[2]);f.Pc=106;continue;}
case 106:{f.Push(JValue.I(0));f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=110;continue;}
case 110:{return rt.Call(f,"java/util/List","toArray","([Ljava/lang/Object;)[Ljava/lang/Object;","invokeinterface",115);}
case 115:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Ljava/lang/String;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=118;continue;}
case 118:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/token/TokenInfo","intrinsicKeywords","[Ljava/lang/String;",value);f.Pc=121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/game/card/Card","getBasePower","()I","invokevirtual",126);}
case 126:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/token/TokenInfo","basePower","I",value);f.Pc=129;continue;}
case 129:{f.Push(f.Locals[0]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[1]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"forge/game/card/Card","getBaseToughness","()I","invokevirtual",134);}
case 134:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/token/TokenInfo","baseToughness","I",value);f.Pc=137;continue;}
case 137:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5957(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Push(JValue.R(rt.String(",")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",10);}
case 10:{f.Locals[2]=f.Pop();f.Pc=11;continue;}
case 11:{f.Push(JValue.I(0));f.Pc=12;continue;}
case 12:{f.Locals[3]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(JValue.I(0));f.Pc=14;continue;}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("0")));f.Pc=18;continue;}
case 18:{f.Locals[5]=f.Pop();f.Pc=20;continue;}
case 20:{f.Push(JValue.R(null));f.Pc=21;continue;}
case 21:{f.Locals[6]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(JValue.R(null));f.Pc=24;continue;}
case 24:{f.Locals[7]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(JValue.R(null));f.Pc=27;continue;}
case 27:{f.Locals[8]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(JValue.R(null));f.Pc=30;continue;}
case 30:{f.Locals[9]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{f.Locals[10]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[10]);f.Pc=37;continue;}
case 37:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=38;continue;}
case 38:{f.Locals[11]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(JValue.I(0));f.Pc=41;continue;}
case 41:{f.Locals[12]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[12]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[11]);f.Pc=47;continue;}
case 47:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?233:50;continue;}
case 50:{f.Push(f.Locals[10]);f.Pc=52;continue;}
case 52:{f.Push(f.Locals[12]);f.Pc=54;continue;}
case 54:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=55;continue;}
case 55:{f.Locals[13]=f.Pop();f.Pc=57;continue;}
case 57:{f.Push(f.Locals[13]);f.Pc=59;continue;}
case 59:{f.Push(JValue.I(58));f.Pc=61;continue;}
case 61:{return rt.Call(f,"java/lang/String","indexOf","(I)I","invokevirtual",64);}
case 64:{f.Locals[14]=f.Pop();f.Pc=66;continue;}
case 66:{f.Push(f.Locals[14]);f.Pc=68;continue;}
case 68:{f.Push(JValue.I(-1));f.Pc=69;continue;}
case 69:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?75:72;continue;}
case 72:{f.Pc=227;continue;}
case 75:{f.Push(f.Locals[13]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[14]);f.Pc=79;continue;}
case 79:{f.Push(JValue.I(1));f.Pc=80;continue;}
case 80:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=81;continue;}
case 81:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",84);}
case 84:{f.Locals[15]=f.Pop();f.Pc=86;continue;}
case 86:{f.Push(f.Locals[13]);f.Pc=88;continue;}
case 88:{f.Push(JValue.R(rt.String("P:")));f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int==0?105:96;continue;}
case 96:{f.Push(f.Locals[15]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",101);}
case 101:{f.Locals[3]=f.Pop();f.Pc=102;continue;}
case 102:{f.Pc=227;continue;}
case 105:{f.Push(f.Locals[13]);f.Pc=107;continue;}
case 107:{f.Push(JValue.R(rt.String("T:")));f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",112);}
case 112:{f.Pc=f.Pop().Int==0?125:115;continue;}
case 115:{f.Push(f.Locals[15]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",120);}
case 120:{f.Locals[4]=f.Pop();f.Pc=122;continue;}
case 122:{f.Pc=227;continue;}
case 125:{f.Push(f.Locals[13]);f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String("Cost:")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",132);}
case 132:{f.Pc=f.Pop().Int==0?142:135;continue;}
case 135:{f.Push(f.Locals[15]);f.Pc=137;continue;}
case 137:{f.Locals[5]=f.Pop();f.Pc=139;continue;}
case 139:{f.Pc=227;continue;}
case 142:{f.Push(f.Locals[13]);f.Pc=144;continue;}
case 144:{f.Push(JValue.R(rt.String("Types:")));f.Pc=146;continue;}
case 146:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",149);}
case 149:{f.Pc=f.Pop().Int==0?164:152;continue;}
case 152:{f.Push(f.Locals[15]);f.Pc=154;continue;}
case 154:{f.Push(JValue.R(rt.String("-")));f.Pc=156;continue;}
case 156:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",159);}
case 159:{f.Locals[6]=f.Pop();f.Pc=161;continue;}
case 161:{f.Pc=227;continue;}
case 164:{f.Push(f.Locals[13]);f.Pc=166;continue;}
case 166:{f.Push(JValue.R(rt.String("Keywords:")));f.Pc=168;continue;}
case 168:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",171);}
case 171:{f.Pc=f.Pop().Int==0?186:174;continue;}
case 174:{f.Push(f.Locals[15]);f.Pc=176;continue;}
case 176:{f.Push(JValue.R(rt.String("-")));f.Pc=178;continue;}
case 178:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",181);}
case 181:{f.Locals[7]=f.Pop();f.Pc=183;continue;}
case 183:{f.Pc=227;continue;}
case 186:{f.Push(f.Locals[13]);f.Pc=188;continue;}
case 188:{f.Push(JValue.R(rt.String("Image:")));f.Pc=190;continue;}
case 190:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",193);}
case 193:{f.Pc=f.Pop().Int==0?203:196;continue;}
case 196:{f.Push(f.Locals[15]);f.Pc=198;continue;}
case 198:{f.Locals[8]=f.Pop();f.Pc=200;continue;}
case 200:{f.Pc=227;continue;}
case 203:{f.Push(f.Locals[13]);f.Pc=205;continue;}
case 205:{f.Push(JValue.R(rt.String("Color:")));f.Pc=207;continue;}
case 207:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",210);}
case 210:{f.Pc=f.Pop().Int==0?227:213;continue;}
case 213:{f.Push(JValue.I(1));f.Pc=214;continue;}
case 214:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=217;continue;}
case 217:{f.StackOp("dup");f.Pc=218;continue;}
case 218:{f.Push(JValue.I(0));f.Pc=219;continue;}
case 219:{f.Push(f.Locals[15]);f.Pc=221;continue;}
case 221:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=222;continue;}
case 222:{return rt.Call(f,"forge/card/ColorSet","fromNames","([Ljava/lang/String;)Lforge/card/ColorSet;","invokestatic",225);}
case 225:{f.Locals[9]=f.Pop();f.Pc=227;continue;}
case 227:{f.Locals[12]=JValue.I(unchecked(f.Locals[12].Int+(1)));f.Pc=230;continue;}
case 230:{f.Pc=43;continue;}
case 233:{f.Push(f.Locals[0]);f.Pc=234;continue;}
case 234:{f.Push(f.Locals[2]);f.Pc=235;continue;}
case 235:{f.Push(JValue.I(0));f.Pc=236;continue;}
case 236:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=237;continue;}
case 237:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/token/TokenInfo","name","Ljava/lang/String;",value);f.Pc=240;continue;}
case 240:{f.Push(f.Locals[0]);f.Pc=241;continue;}
case 241:{f.Push(f.Locals[8]);f.Pc=243;continue;}
case 243:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/token/TokenInfo","imageName","Ljava/lang/String;",value);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[0]);f.Pc=247;continue;}
case 247:{f.Push(f.Locals[5]);f.Pc=249;continue;}
case 249:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/token/TokenInfo","manaCost","Ljava/lang/String;",value);f.Pc=252;continue;}
case 252:{f.Push(f.Locals[0]);f.Pc=253;continue;}
case 253:{f.Push(f.Locals[6]);f.Pc=255;continue;}
case 255:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/token/TokenInfo","types","[Ljava/lang/String;",value);f.Pc=258;continue;}
case 258:{f.Push(f.Locals[0]);f.Pc=259;continue;}
case 259:{f.Push(f.Locals[7]);f.Pc=261;continue;}
case 261:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/token/TokenInfo","intrinsicKeywords","[Ljava/lang/String;",value);f.Pc=264;continue;}
case 264:{f.Push(f.Locals[0]);f.Pc=265;continue;}
case 265:{f.Push(f.Locals[3]);f.Pc=266;continue;}
case 266:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/token/TokenInfo","basePower","I",value);f.Pc=269;continue;}
case 269:{f.Push(f.Locals[0]);f.Pc=270;continue;}
case 270:{f.Push(f.Locals[4]);f.Pc=272;continue;}
case 272:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/token/TokenInfo","baseToughness","I",value);f.Pc=275;continue;}
case 275:{f.Push(f.Locals[0]);f.Pc=276;continue;}
case 276:{f.Push(f.Locals[9]);f.Pc=278;continue;}
case 278:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/card/token/TokenInfo","color","Lforge/card/ColorSet;",value);f.Pc=281;continue;}
case 281:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5958(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",3);}
case 3:{f.Locals[1]=f.Pop();f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",8);}
case 8:{return rt.Call(f,"forge/card/CardTypeView","getCoreTypes","()Ljava/util/Collection;","invokeinterface",13);}
case 13:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",18);}
case 18:{f.Locals[2]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[2]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?52:28;continue;}
case 28:{f.Push(f.Locals[2]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",34);}
case 34:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardType$CoreType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=37;continue;}
case 37:{f.Locals[3]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[1]);f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/card/CardType$CoreType","name","()Ljava/lang/String;","invokevirtual",43);}
case 43:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",48);}
case 48:{f.StackOp("pop");f.Pc=49;continue;}
case 49:{f.Pc=19;continue;}
case 52:{f.Push(f.Locals[0]);f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",56);}
case 56:{return rt.Call(f,"forge/card/CardTypeView","getSubtypes","()Ljava/util/Collection;","invokeinterface",61);}
case 61:{f.Push(f.Locals[1]);f.Pc=62;continue;}
case 62:{f.StackOp("dup");f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",66);}
case 66:{f.StackOp("pop");f.Pc=67;continue;}
case 67:{return rt.DynamicCall(f,"forge/game/card/token/TokenInfo:5958:67:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/List;)Ljava/util/function/Consumer;",72);}
case 72:{return rt.Call(f,"java/util/Collection","forEach","(Ljava/util/function/Consumer;)V","invokeinterface",77);}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",81);}
case 81:{return rt.Call(f,"forge/card/CardTypeView","isLegendary","()Z","invokeinterface",86);}
case 86:{f.Pc=f.Pop().Int==0?98:89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(JValue.R(rt.String("Legendary")));f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",97);}
case 97:{f.StackOp("pop");f.Pc=98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{f.Push(JValue.I(0));f.Pc=100;continue;}
case 100:{f.Push(JValue.R(rt.NewArray("Ljava/lang/String;",f.Pop().Int)));f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/util/List","toArray","([Ljava/lang/Object;)[Ljava/lang/Object;","invokeinterface",108);}
case 108:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Ljava/lang/String;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=111;continue;}
case 111:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5959(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/Game","nextCardId","()I","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/game/card/token/TokenInfo","toCard","(Lforge/game/Game;I)Lforge/game/card/Card;","invokevirtual",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5960(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/Card"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/Card")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[2]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/card/Card","<init>","(ILforge/game/Game;)V","invokespecial",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[3]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{f.Push(rt.GetField(f.Pop(),"forge/game/card/token/TokenInfo","name","Ljava/lang/String;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/Card","setName","(Ljava/lang/String;)V","invokevirtual",18);}
case 18:{f.Push(f.Locals[3]);f.Pc=19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{f.Push(rt.GetField(f.Pop(),"forge/game/card/token/TokenInfo","imageName","Ljava/lang/String;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/ImageKeys","getTokenKey","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",26);}
case 26:{return rt.Call(f,"forge/game/card/Card","setImageKey","(Ljava/lang/String;)V","invokevirtual",29);}
case 29:{f.Push(f.Locals[3]);f.Pc=30;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/card/token/TokenInfo","color","Lforge/card/ColorSet;"));f.Pc=34;continue;}
case 34:{f.Pc=f.Pop().Reference!=null?54:37;continue;}
case 37:{if(!rt.EnsureInitialized(f,"forge/card/mana/ManaCost"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/mana/ManaCost")));f.Pc=40;continue;}
case 40:{f.StackOp("dup");f.Pc=41;continue;}
case 41:{f.Push(f.Locals[0]);f.Pc=42;continue;}
case 42:{f.Push(rt.GetField(f.Pop(),"forge/game/card/token/TokenInfo","manaCost","Ljava/lang/String;"));f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/card/mana/ManaCost","<init>","(Ljava/lang/String;)V","invokespecial",48);}
case 48:{return rt.Call(f,"forge/card/ColorSet","fromManaCost","(Lforge/card/mana/ManaCost;)Lforge/card/ColorSet;","invokestatic",51);}
case 51:{f.Pc=58;continue;}
case 54:{f.Push(f.Locals[0]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/game/card/token/TokenInfo","color","Lforge/card/ColorSet;"));f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/Card","setColor","(Lforge/card/ColorSet;)V","invokevirtual",61);}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{if(!rt.StaticReady(f,"forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"));f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/game/card/Card","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",68);}
case 68:{f.Push(f.Locals[0]);f.Pc=69;continue;}
case 69:{f.Push(rt.GetField(f.Pop(),"forge/game/card/token/TokenInfo","types","[Ljava/lang/String;"));f.Pc=72;continue;}
case 72:{f.Locals[4]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[4]);f.Pc=76;continue;}
case 76:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=77;continue;}
case 77:{f.Locals[5]=f.Pop();f.Pc=79;continue;}
case 79:{f.Push(JValue.I(0));f.Pc=80;continue;}
case 80:{f.Locals[6]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[6]);f.Pc=84;continue;}
case 84:{f.Push(f.Locals[5]);f.Pc=86;continue;}
case 86:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?108:89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[6]);f.Pc=93;continue;}
case 93:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=94;continue;}
case 94:{f.Locals[7]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[3]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[7]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"forge/game/card/Card","addType","(Ljava/lang/String;)V","invokevirtual",102);}
case 102:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=105;continue;}
case 105:{f.Pc=82;continue;}
case 108:{f.Push(f.Locals[3]);f.Pc=109;continue;}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(rt.GetField(f.Pop(),"forge/game/card/token/TokenInfo","basePower","I"));f.Pc=113;continue;}
case 113:{return rt.Call(f,"forge/game/card/Card","setBasePower","(I)V","invokevirtual",116);}
case 116:{f.Push(f.Locals[3]);f.Pc=117;continue;}
case 117:{f.Push(f.Locals[0]);f.Pc=118;continue;}
case 118:{f.Push(rt.GetField(f.Pop(),"forge/game/card/token/TokenInfo","baseToughness","I"));f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/game/card/Card","setBaseToughness","(I)V","invokevirtual",124);}
case 124:{f.Push(f.Locals[3]);f.Pc=125;continue;}
case 125:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5961(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/card/token/TokenInfo","name","Ljava/lang/String;"));f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",16);}
case 16:{f.Push(JValue.I(44));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Push(JValue.R(rt.String("P:")));f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",28);}
case 28:{f.Push(f.Locals[0]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/card/token/TokenInfo","basePower","I"));f.Pc=32;continue;}
case 32:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",35);}
case 35:{f.Push(JValue.I(44));f.Pc=37;continue;}
case 37:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",40);}
case 40:{f.StackOp("pop");f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{f.Push(JValue.R(rt.String("T:")));f.Pc=44;continue;}
case 44:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",47);}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{f.Push(rt.GetField(f.Pop(),"forge/game/card/token/TokenInfo","baseToughness","I"));f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/StringBuilder","append","(I)Ljava/lang/StringBuilder;","invokevirtual",54);}
case 54:{f.Push(JValue.I(44));f.Pc=56;continue;}
case 56:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{f.Push(f.Locals[1]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("Cost:")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",66);}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(rt.GetField(f.Pop(),"forge/game/card/token/TokenInfo","manaCost","Ljava/lang/String;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",73);}
case 73:{f.Push(JValue.I(44));f.Pc=75;continue;}
case 75:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",78);}
case 78:{f.StackOp("pop");f.Pc=79;continue;}
case 79:{f.Push(f.Locals[1]);f.Pc=80;continue;}
case 80:{f.Push(JValue.R(rt.String("Color:")));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",85);}
case 85:{f.Push(f.Locals[0]);f.Pc=86;continue;}
case 86:{f.Push(rt.GetField(f.Pop(),"forge/game/card/token/TokenInfo","color","Lforge/card/ColorSet;"));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",92);}
case 92:{f.Push(JValue.R(rt.String(",")));f.Pc=94;continue;}
case 94:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",97);}
case 97:{f.StackOp("pop");f.Pc=98;continue;}
case 98:{f.Push(f.Locals[1]);f.Pc=99;continue;}
case 99:{f.Push(JValue.R(rt.String("Types:")));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",104);}
case 104:{f.Push(JValue.I(45));f.Pc=106;continue;}
case 106:{return rt.Call(f,"com/google/common/base/Joiner","on","(C)Lcom/google/common/base/Joiner;","invokestatic",109);}
case 109:{f.Push(f.Locals[0]);f.Pc=110;continue;}
case 110:{f.Push(rt.GetField(f.Pop(),"forge/game/card/token/TokenInfo","types","[Ljava/lang/String;"));f.Pc=113;continue;}
case 113:{return rt.Call(f,"com/google/common/base/Joiner","join","([Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",116);}
case 116:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",119);}
case 119:{f.Push(JValue.I(44));f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",124);}
case 124:{f.StackOp("pop");f.Pc=125;continue;}
case 125:{f.Push(f.Locals[1]);f.Pc=126;continue;}
case 126:{f.Push(JValue.R(rt.String("Keywords:")));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",131);}
case 131:{f.Push(JValue.I(45));f.Pc=133;continue;}
case 133:{return rt.Call(f,"com/google/common/base/Joiner","on","(C)Lcom/google/common/base/Joiner;","invokestatic",136);}
case 136:{f.Push(f.Locals[0]);f.Pc=137;continue;}
case 137:{f.Push(rt.GetField(f.Pop(),"forge/game/card/token/TokenInfo","intrinsicKeywords","[Ljava/lang/String;"));f.Pc=140;continue;}
case 140:{return rt.Call(f,"com/google/common/base/Joiner","join","([Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",143);}
case 143:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",146);}
case 146:{f.Push(JValue.I(44));f.Pc=148;continue;}
case 148:{return rt.Call(f,"java/lang/StringBuilder","append","(C)Ljava/lang/StringBuilder;","invokevirtual",151);}
case 151:{f.StackOp("pop");f.Pc=152;continue;}
case 152:{f.Push(f.Locals[1]);f.Pc=153;continue;}
case 153:{f.Push(JValue.R(rt.String("Image:")));f.Pc=155;continue;}
case 155:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",158);}
case 158:{f.Push(f.Locals[0]);f.Pc=159;continue;}
case 159:{f.Push(rt.GetField(f.Pop(),"forge/game/card/token/TokenInfo","imageName","Ljava/lang/String;"));f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",165);}
case 165:{f.StackOp("pop");f.Pc=166;continue;}
case 166:{f.Push(f.Locals[1]);f.Pc=167;continue;}
case 167:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",170);}
case 170:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5962(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[1]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",6);}
case 6:{return rt.Call(f,"forge/game/Game","nextCardId","()I","invokevirtual",9);}
case 9:{return rt.Call(f,"forge/game/card/token/TokenInfo","makeOneToken","(Lforge/game/player/Player;I)Lforge/game/card/Card;","invokevirtual",12);}
case 12:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5963(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",4);}
case 4:{f.Locals[3]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[3]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[2]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/token/TokenInfo","toCard","(Lforge/game/Game;I)Lforge/game/card/Card;","invokevirtual",11);}
case 11:{f.Locals[4]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[4]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/game/card/Card","setOwner","(Lforge/game/player/Player;)V","invokevirtual",19);}
case 19:{f.Push(f.Locals[4]);f.Pc=21;continue;}
case 21:{if(!rt.StaticReady(f,"forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/GamePieceType","TOKEN","Lforge/card/GamePieceType;"));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/card/Card","setGamePieceType","(Lforge/card/GamePieceType;)V","invokevirtual",27);}
case 27:{f.Push(f.Locals[4]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/card/CardFactoryUtil","setupKeywordedAbilities","(Lforge/game/card/Card;)V","invokestatic",32);}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/card/token/TokenInfo","intrinsicKeywords","[Ljava/lang/String;"));f.Pc=36;continue;}
case 36:{f.Locals[5]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(f.Locals[5]);f.Pc=40;continue;}
case 40:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=41;continue;}
case 41:{f.Locals[6]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(JValue.I(0));f.Pc=44;continue;}
case 44:{f.Locals[7]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[7]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[6]);f.Pc=50;continue;}
case 50:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?74:53;continue;}
case 53:{f.Push(f.Locals[5]);f.Pc=55;continue;}
case 55:{f.Push(f.Locals[7]);f.Pc=57;continue;}
case 57:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=58;continue;}
case 58:{f.Locals[8]=f.Pop();f.Pc=60;continue;}
case 60:{f.Push(f.Locals[4]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[8]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/Card","addIntrinsicKeyword","(Ljava/lang/String;)Lforge/game/keyword/KeywordInterface;","invokevirtual",67);}
case 67:{f.StackOp("pop");f.Pc=68;continue;}
case 68:{f.Locals[7]=JValue.I(unchecked(f.Locals[7].Int+(1)));f.Pc=71;continue;}
case 71:{f.Pc=46;continue;}
case 74:{f.Push(f.Locals[4]);f.Pc=76;continue;}
case 76:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5964(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/spellability/SpellAbility","getChangedTextColors","()Ljava/util/Map;","invokevirtual",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/game/spellability/SpellAbility","getChangedTextTypes","()Ljava/util/Map;","invokevirtual",9);}
case 9:{f.Locals[3]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",16);}
case 16:{f.Pc=f.Pop().Int!=0?216:19;continue;}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/card/Card","isColorless","()Z","invokevirtual",23);}
case 23:{f.Pc=f.Pop().Int!=0?216:26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"forge/game/card/Card","getColor","()Lforge/card/ColorSet;","invokevirtual",30);}
case 30:{return rt.Call(f,"forge/card/ColorSet","getColor","()B","invokevirtual",33);}
case 33:{f.Locals[4]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[2]);f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",41);}
case 41:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",46);}
case 46:{f.Locals[5]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[5]);f.Pc=50;continue;}
case 50:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",55);}
case 55:{f.Pc=f.Pop().Int==0?207:58;continue;}
case 58:{f.Push(f.Locals[5]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",65);}
case 65:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=68;continue;}
case 68:{f.Locals[6]=f.Pop();f.Pc=70;continue;}
case 70:{f.Push(f.Locals[6]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",77);}
case 77:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=80;continue;}
case 80:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",83);}
case 83:{f.Locals[7]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(JValue.R(rt.String("Any")));f.Pc=88;continue;}
case 88:{f.Push(f.Locals[6]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",95);}
case 95:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",98);}
case 98:{f.Pc=f.Pop().Int==0?163:101;continue;}
case 101:{if(!rt.StaticReady(f,"forge/card/MagicColor","WUBRG","[B"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/MagicColor","WUBRG","[B"));f.Pc=104;continue;}
case 104:{f.Locals[8]=f.Pop();f.Pc=106;continue;}
case 106:{f.Push(f.Locals[8]);f.Pc=108;continue;}
case 108:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=109;continue;}
case 109:{f.Locals[9]=f.Pop();f.Pc=111;continue;}
case 111:{f.Push(JValue.I(0));f.Pc=112;continue;}
case 112:{f.Locals[10]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[10]);f.Pc=116;continue;}
case 116:{f.Push(f.Locals[9]);f.Pc=118;continue;}
case 118:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?160:121;continue;}
case 121:{f.Push(f.Locals[8]);f.Pc=123;continue;}
case 123:{f.Push(f.Locals[10]);f.Pc=125;continue;}
case 125:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=126;continue;}
case 126:{f.Locals[11]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[4]);f.Pc=130;continue;}
case 130:{f.Push(f.Locals[11]);f.Pc=132;continue;}
case 132:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=133;continue;}
case 133:{f.Pc=f.Pop().Int==0?154:136;continue;}
case 136:{f.Push(f.Locals[4]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[11]);f.Pc=140;continue;}
case 140:{f.Push(JValue.I(-1));f.Pc=141;continue;}
case 141:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ixor",a,b));f.Pc=142;continue;}
case 142:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=143;continue;}
case 143:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=144;continue;}
case 144:{f.Locals[4]=f.Pop();f.Pc=146;continue;}
case 146:{f.Push(f.Locals[4]);f.Pc=148;continue;}
case 148:{f.Push(f.Locals[7]);f.Pc=150;continue;}
case 150:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=151;continue;}
case 151:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=152;continue;}
case 152:{f.Locals[4]=f.Pop();f.Pc=154;continue;}
case 154:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=157;continue;}
case 157:{f.Pc=114;continue;}
case 160:{f.Pc=204;continue;}
case 163:{f.Push(f.Locals[6]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",170);}
case 170:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=173;continue;}
case 173:{return rt.Call(f,"forge/card/MagicColor","fromName","(Ljava/lang/String;)B","invokestatic",176);}
case 176:{f.Locals[8]=f.Pop();f.Pc=178;continue;}
case 178:{f.Push(f.Locals[4]);f.Pc=180;continue;}
case 180:{f.Push(f.Locals[8]);f.Pc=182;continue;}
case 182:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=183;continue;}
case 183:{f.Pc=f.Pop().Int==0?204:186;continue;}
case 186:{f.Push(f.Locals[4]);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[8]);f.Pc=190;continue;}
case 190:{f.Push(JValue.I(-1));f.Pc=191;continue;}
case 191:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ixor",a,b));f.Pc=192;continue;}
case 192:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iand",a,b));f.Pc=193;continue;}
case 193:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=194;continue;}
case 194:{f.Locals[4]=f.Pop();f.Pc=196;continue;}
case 196:{f.Push(f.Locals[4]);f.Pc=198;continue;}
case 198:{f.Push(f.Locals[7]);f.Pc=200;continue;}
case 200:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ior",a,b));f.Pc=201;continue;}
case 201:{f.Push(JNumbers.Unary("i2b",f.Pop()));f.Pc=202;continue;}
case 202:{f.Locals[4]=f.Pop();f.Pc=204;continue;}
case 204:{f.Pc=48;continue;}
case 207:{f.Push(f.Locals[0]);f.Pc=208;continue;}
case 208:{f.Push(f.Locals[4]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/card/ColorSet","fromMask","(I)Lforge/card/ColorSet;","invokestatic",213);}
case 213:{return rt.Call(f,"forge/game/card/Card","setColor","(Lforge/card/ColorSet;)V","invokevirtual",216);}
case 216:{f.Push(f.Locals[3]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"java/util/Map","isEmpty","()Z","invokeinterface",222);}
case 222:{f.Pc=f.Pop().Int!=0?393:225;continue;}
case 225:{if(!rt.EnsureInitialized(f,"forge/card/CardType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/CardType")));f.Pc=228;continue;}
case 228:{f.StackOp("dup");f.Pc=229;continue;}
case 229:{f.Push(f.Locals[0]);f.Pc=230;continue;}
case 230:{return rt.Call(f,"forge/game/card/Card","getType","()Lforge/card/CardTypeView;","invokevirtual",233);}
case 233:{return rt.Call(f,"forge/card/CardType","<init>","(Lforge/card/CardTypeView;)V","invokespecial",236);}
case 236:{f.Locals[4]=f.Pop();f.Pc=238;continue;}
case 238:{f.Push(f.Locals[0]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/game/card/Card","getName","()Ljava/lang/String;","invokevirtual",242);}
case 242:{f.Push(JValue.R(rt.String(" Token")));f.Pc=245;continue;}
case 245:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",248);}
case 248:{f.Locals[5]=f.Pop();f.Pc=250;continue;}
case 250:{f.Push(JValue.I(0));f.Pc=251;continue;}
case 251:{f.Locals[6]=f.Pop();f.Pc=253;continue;}
case 253:{f.Push(f.Locals[4]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/card/CardType","getSubtypes","()Ljava/util/Collection;","invokevirtual",258);}
case 258:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",263);}
case 263:{f.Pc=f.Pop().Int!=0?357:266;continue;}
case 266:{f.Push(f.Locals[3]);f.Pc=267;continue;}
case 267:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",272);}
case 272:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",277);}
case 277:{f.Locals[7]=f.Pop();f.Pc=279;continue;}
case 279:{f.Push(f.Locals[7]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",286);}
case 286:{f.Pc=f.Pop().Int==0?357:289;continue;}
case 289:{f.Push(f.Locals[7]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",296);}
case 296:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=299;continue;}
case 299:{f.Locals[8]=f.Pop();f.Pc=301;continue;}
case 301:{f.Push(f.Locals[4]);f.Pc=303;continue;}
case 303:{f.Push(f.Locals[8]);f.Pc=305;continue;}
case 305:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",310);}
case 310:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=313;continue;}
case 313:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",316);}
case 316:{f.Pc=f.Pop().Int==0?354:319;continue;}
case 319:{f.Push(f.Locals[4]);f.Pc=321;continue;}
case 321:{f.Push(f.Locals[8]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",328);}
case 328:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=331;continue;}
case 331:{return rt.Call(f,"forge/card/CardType","remove","(Ljava/lang/String;)Z","invokevirtual",334);}
case 334:{f.StackOp("pop");f.Pc=335;continue;}
case 335:{f.Push(f.Locals[4]);f.Pc=337;continue;}
case 337:{f.Push(f.Locals[8]);f.Pc=339;continue;}
case 339:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",344);}
case 344:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=347;continue;}
case 347:{return rt.Call(f,"forge/card/CardType","add","(Ljava/lang/String;)Z","invokevirtual",350);}
case 350:{f.StackOp("pop");f.Pc=351;continue;}
case 351:{f.Push(JValue.I(1));f.Pc=352;continue;}
case 352:{f.Locals[6]=f.Pop();f.Pc=354;continue;}
case 354:{f.Pc=279;continue;}
case 357:{f.Push(f.Locals[6]);f.Pc=359;continue;}
case 359:{f.Pc=f.Pop().Int==0?393:362;continue;}
case 362:{f.Push(f.Locals[0]);f.Pc=363;continue;}
case 363:{f.Push(f.Locals[4]);f.Pc=365;continue;}
case 365:{return rt.Call(f,"forge/game/card/Card","setType","(Lforge/card/CardType;)V","invokevirtual",368);}
case 368:{f.Push(f.Locals[5]);f.Pc=370;continue;}
case 370:{f.Pc=f.Pop().Int==0?393:373;continue;}
case 373:{f.Push(f.Locals[0]);f.Pc=374;continue;}
case 374:{f.Push(f.Locals[4]);f.Pc=376;continue;}
case 376:{return rt.Call(f,"forge/card/CardType","getSubtypes","()Ljava/util/Collection;","invokevirtual",379);}
case 379:{f.Push(JValue.R(rt.String(" ")));f.Pc=382;continue;}
case 382:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","join","(Ljava/lang/Iterable;Ljava/lang/String;)Ljava/lang/String;","invokestatic",385);}
case 385:{return rt.DynamicCall(f,"forge/game/card/token/TokenInfo:5964:385:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",390);}
case 390:{return rt.Call(f,"forge/game/card/Card","setName","(Ljava/lang/String;)V","invokevirtual",393);}
case 393:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",396);}
case 396:{f.Locals[4]=f.Pop();f.Pc=398;continue;}
case 398:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",401);}
case 401:{f.Locals[5]=f.Pop();f.Pc=403;continue;}
case 403:{f.Push(f.Locals[0]);f.Pc=404;continue;}
case 404:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",407);}
case 407:{return rt.Call(f,"forge/game/card/CardState","getIntrinsicKeywords","()Ljava/util/Collection;","invokevirtual",410);}
case 410:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",415);}
case 415:{f.Locals[6]=f.Pop();f.Pc=417;continue;}
case 417:{f.Push(f.Locals[6]);f.Pc=419;continue;}
case 419:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",424);}
case 424:{f.Pc=f.Pop().Int==0?490:427;continue;}
case 427:{f.Push(f.Locals[6]);f.Pc=429;continue;}
case 429:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",434);}
case 434:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=437;continue;}
case 437:{f.Locals[7]=f.Pop();f.Pc=439;continue;}
case 439:{f.Push(f.Locals[7]);f.Pc=441;continue;}
case 441:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",446);}
case 446:{f.Locals[8]=f.Pop();f.Pc=448;continue;}
case 448:{f.Push(f.Locals[8]);f.Pc=450;continue;}
case 450:{f.Push(f.Locals[2]);f.Pc=451;continue;}
case 451:{f.Push(f.Locals[3]);f.Pc=452;continue;}
case 452:{return rt.Call(f,"forge/game/ability/AbilityUtils","applyKeywordTextChangeEffects","(Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;)Ljava/lang/String;","invokestatic",455);}
case 455:{f.Locals[9]=f.Pop();f.Pc=457;continue;}
case 457:{f.Push(f.Locals[9]);f.Pc=459;continue;}
case 459:{f.Push(f.Locals[8]);f.Pc=461;continue;}
case 461:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",464);}
case 464:{f.Pc=f.Pop().Int!=0?487:467;continue;}
case 467:{f.Push(f.Locals[4]);f.Pc=469;continue;}
case 469:{f.Push(f.Locals[7]);f.Pc=471;continue;}
case 471:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",476);}
case 476:{f.StackOp("pop");f.Pc=477;continue;}
case 477:{f.Push(f.Locals[5]);f.Pc=479;continue;}
case 479:{f.Push(f.Locals[9]);f.Pc=481;continue;}
case 481:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",486);}
case 486:{f.StackOp("pop");f.Pc=487;continue;}
case 487:{f.Pc=417;continue;}
case 490:{f.Push(f.Locals[4]);f.Pc=492;continue;}
case 492:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",497);}
case 497:{f.Locals[6]=f.Pop();f.Pc=499;continue;}
case 499:{f.Push(f.Locals[6]);f.Pc=501;continue;}
case 501:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",506);}
case 506:{f.Pc=f.Pop().Int==0?534:509;continue;}
case 509:{f.Push(f.Locals[6]);f.Pc=511;continue;}
case 511:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",516);}
case 516:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=519;continue;}
case 519:{f.Locals[7]=f.Pop();f.Pc=521;continue;}
case 521:{f.Push(f.Locals[0]);f.Pc=522;continue;}
case 522:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",525);}
case 525:{f.Push(f.Locals[7]);f.Pc=527;continue;}
case 527:{return rt.Call(f,"forge/game/card/CardState","removeIntrinsicKeyword","(Lforge/game/keyword/KeywordInterface;)Z","invokevirtual",530);}
case 530:{f.StackOp("pop");f.Pc=531;continue;}
case 531:{f.Pc=499;continue;}
case 534:{f.Push(f.Locals[0]);f.Pc=535;continue;}
case 535:{f.Push(f.Locals[5]);f.Pc=537;continue;}
case 537:{return rt.Call(f,"forge/game/card/Card","addIntrinsicKeywords","(Ljava/lang/Iterable;)V","invokevirtual",540);}
case 540:{f.Push(f.Locals[0]);f.Pc=541;continue;}
case 541:{return rt.Call(f,"forge/game/card/Card","getCurrentState","()Lforge/game/card/CardState;","invokevirtual",544);}
case 544:{f.Push(f.Locals[2]);f.Pc=545;continue;}
case 545:{f.Push(f.Locals[3]);f.Pc=546;continue;}
case 546:{return rt.Call(f,"forge/game/card/CardState","changeTextIntrinsic","(Ljava/util/Map;Ljava/util/Map;)V","invokevirtual",549);}
case 549:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5965(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",3);}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/StaticData","getCardEdition","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{f.Pc=f.Pop().Reference!=null?14:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{return JStep.Return(f.Pop());}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/card/CardEdition","getTokenSet","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",19);}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",23);}
case 23:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=26;continue;}
case 26:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5966(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("LockTokenScript")));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",10);}
case 10:{f.Pc=f.Pop().Int!=0?17:13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{f.Pc=18;continue;}
case 17:{f.Push(JValue.I(0));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/token/TokenInfo","getProtoType","(Ljava/lang/String;Lforge/game/spellability/SpellAbility;Lforge/game/player/Player;Z)Lforge/game/card/Card;","invokestatic",21);}
case 21:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5967(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?8:4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{f.Pc=f.Pop().Reference!=null?10:8;continue;}
case 8:{f.Push(JValue.R(null));f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
case 10:{f.Push(f.Locals[1]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",14);}
case 14:{f.Locals[4]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[4]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",21);}
case 21:{f.Locals[5]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/spellability/SpellAbility","getOriginalHost","()Lforge/game/card/Card;","invokevirtual",27);}
case 27:{f.Locals[6]=f.Pop();f.Pc=29;continue;}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",33);}
case 33:{f.Pc=f.Pop().Reference==null?62:36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",40);}
case 40:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;","invokeinterface",45);}
case 45:{f.Pc=f.Pop().Reference==null?62:48;continue;}
case 48:{f.Push(f.Locals[1]);f.Pc=49;continue;}
case 49:{return rt.Call(f,"forge/game/spellability/SpellAbility","getKeyword","()Lforge/game/keyword/KeywordInterface;","invokevirtual",52);}
case 52:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getStatic","()Lforge/game/staticability/StaticAbility;","invokeinterface",57);}
case 57:{return rt.Call(f,"forge/game/staticability/StaticAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",60);}
case 60:{f.Locals[6]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[5]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/game/card/token/TokenInfo","getPinsFor","(Lforge/game/Game;)Ljava/util/Map;","invokestatic",67);}
case 67:{f.Locals[8]=f.Pop();f.Pc=69;continue;}
case 69:{f.Push(f.Locals[8]);f.Pc=71;continue;}
case 71:{f.Push(f.Locals[0]);f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",77);}
case 77:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=80;continue;}
case 80:{f.Locals[9]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[9]);f.Pc=84;continue;}
case 84:{f.Pc=f.Pop().Reference==null?94:87;continue;}
case 87:{f.Push(f.Locals[9]);f.Pc=89;continue;}
case 89:{f.Locals[7]=f.Pop();f.Pc=91;continue;}
case 91:{f.Pc=117;continue;}
case 94:{f.Push(f.Locals[6]);f.Pc=96;continue;}
case 96:{f.Push(f.Locals[4]);f.Pc=98;continue;}
case 98:{return rt.Call(f,"java/util/Objects","requireNonNullElse","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",101);}
case 101:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=104;continue;}
case 104:{return rt.Call(f,"forge/game/card/Card","getSetCode","()Ljava/lang/String;","invokevirtual",107);}
case 107:{f.Locals[7]=f.Pop();f.Pc=109;continue;}
case 109:{f.Push(f.Locals[7]);f.Pc=111;continue;}
case 111:{f.Push(f.Locals[0]);f.Pc=112;continue;}
case 112:{return rt.Call(f,"forge/game/card/token/TokenInfo","tokenSetFor","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",115);}
case 115:{f.Locals[7]=f.Pop();f.Pc=117;continue;}
case 117:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",120);}
case 120:{return rt.Call(f,"forge/StaticData","getAllTokens","()Lforge/token/TokenDb;","invokevirtual",123);}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[7]);f.Pc=126;continue;}
case 126:{return rt.Call(f,"forge/token/TokenDb","getToken","(Ljava/lang/String;Ljava/lang/String;)Lforge/item/PaperToken;","invokevirtual",129);}
case 129:{f.Locals[10]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[10]);f.Pc=133;continue;}
case 133:{f.Pc=f.Pop().Reference!=null?138:136;continue;}
case 136:{f.Push(JValue.R(null));f.Pc=137;continue;}
case 137:{return JStep.Return(f.Pop());}
case 138:{f.Push(f.Locals[9]);f.Pc=140;continue;}
case 140:{f.Pc=f.Pop().Reference!=null?157:143;continue;}
case 143:{f.Push(f.Locals[8]);f.Pc=145;continue;}
case 145:{f.Push(f.Locals[0]);f.Pc=146;continue;}
case 146:{f.Push(f.Locals[10]);f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/item/PaperToken","getEdition","()Ljava/lang/String;","invokevirtual",151);}
case 151:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",156);}
case 156:{f.StackOp("pop");f.Pc=157;continue;}
case 157:{f.Push(f.Locals[10]);f.Pc=159;continue;}
case 159:{f.Push(f.Locals[2]);f.Pc=160;continue;}
case 160:{f.Push(f.Locals[5]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"forge/game/card/CardFactory","getCard","(Lforge/item/IPaperCard;Lforge/game/player/Player;Lforge/game/Game;)Lforge/game/card/Card;","invokestatic",165);}
case 165:{f.Locals[11]=f.Pop();f.Pc=167;continue;}
case 167:{f.Push(f.Locals[1]);f.Pc=168;continue;}
case 168:{f.Push(JValue.R(rt.String("TokenPower")));f.Pc=171;continue;}
case 171:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",174);}
case 174:{f.Pc=f.Pop().Int==0?206:177;continue;}
case 177:{f.Push(f.Locals[1]);f.Pc=178;continue;}
case 178:{f.Push(JValue.R(rt.String("TokenPower")));f.Pc=181;continue;}
case 181:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",184);}
case 184:{f.Locals[12]=f.Pop();f.Pc=186;continue;}
case 186:{f.Push(f.Locals[11]);f.Pc=188;continue;}
case 188:{f.Push(f.Locals[12]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/game/card/Card","setBasePowerString","(Ljava/lang/String;)V","invokevirtual",193);}
case 193:{f.Push(f.Locals[11]);f.Pc=195;continue;}
case 195:{f.Push(f.Locals[4]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[12]);f.Pc=199;continue;}
case 199:{f.Push(f.Locals[1]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",203);}
case 203:{return rt.Call(f,"forge/game/card/Card","setBasePower","(I)V","invokevirtual",206);}
case 206:{f.Push(f.Locals[1]);f.Pc=207;continue;}
case 207:{f.Push(JValue.R(rt.String("TokenToughness")));f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",213);}
case 213:{f.Pc=f.Pop().Int==0?245:216;continue;}
case 216:{f.Push(f.Locals[1]);f.Pc=217;continue;}
case 217:{f.Push(JValue.R(rt.String("TokenToughness")));f.Pc=220;continue;}
case 220:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",223);}
case 223:{f.Locals[12]=f.Pop();f.Pc=225;continue;}
case 225:{f.Push(f.Locals[11]);f.Pc=227;continue;}
case 227:{f.Push(f.Locals[12]);f.Pc=229;continue;}
case 229:{return rt.Call(f,"forge/game/card/Card","setBaseToughnessString","(Ljava/lang/String;)V","invokevirtual",232);}
case 232:{f.Push(f.Locals[11]);f.Pc=234;continue;}
case 234:{f.Push(f.Locals[4]);f.Pc=236;continue;}
case 236:{f.Push(f.Locals[12]);f.Pc=238;continue;}
case 238:{f.Push(f.Locals[1]);f.Pc=239;continue;}
case 239:{return rt.Call(f,"forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I","invokestatic",242);}
case 242:{return rt.Call(f,"forge/game/card/Card","setBaseToughness","(I)V","invokevirtual",245);}
case 245:{f.Push(f.Locals[3]);f.Pc=246;continue;}
case 246:{f.Pc=f.Pop().Int==0?255:249;continue;}
case 249:{f.Push(f.Locals[11]);f.Pc=251;continue;}
case 251:{f.Push(f.Locals[1]);f.Pc=252;continue;}
case 252:{return rt.Call(f,"forge/game/card/token/TokenInfo","protoTypeApplyTextChange","(Lforge/game/card/Card;Lforge/game/spellability/SpellAbility;)V","invokestatic",255);}
case 255:{f.Push(f.Locals[1]);f.Pc=256;continue;}
case 256:{f.Push(JValue.R(rt.String("TokenTypes")));f.Pc=259;continue;}
case 259:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",262);}
case 262:{f.Pc=f.Pop().Int==0?303:265;continue;}
case 265:{f.Push(f.Locals[1]);f.Pc=266;continue;}
case 266:{f.Push(JValue.R(rt.String("TokenTypes")));f.Pc=269;continue;}
case 269:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",272);}
case 272:{f.Locals[12]=f.Pop();f.Pc=274;continue;}
case 274:{f.Push(f.Locals[12]);f.Pc=276;continue;}
case 276:{f.Push(JValue.R(rt.String("ChosenType")));f.Pc=279;continue;}
case 279:{f.Push(f.Locals[4]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/game/card/Card","getChosenType","()Ljava/lang/String;","invokevirtual",284);}
case 284:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",287);}
case 287:{f.Locals[12]=f.Pop();f.Pc=289;continue;}
case 289:{f.Push(f.Locals[11]);f.Pc=291;continue;}
case 291:{f.Push(f.Locals[12]);f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/game/card/Card","addType","(Ljava/lang/String;)V","invokevirtual",296);}
case 296:{f.Push(f.Locals[11]);f.Pc=298;continue;}
case 298:{f.Push(f.Locals[12]);f.Pc=300;continue;}
case 300:{return rt.Call(f,"forge/game/card/Card","setName","(Ljava/lang/String;)V","invokevirtual",303);}
case 303:{f.Push(f.Locals[1]);f.Pc=304;continue;}
case 304:{f.Push(JValue.R(rt.String("TokenColors")));f.Pc=307;continue;}
case 307:{return rt.Call(f,"forge/game/spellability/SpellAbility","hasParam","(Ljava/lang/String;)Z","invokevirtual",310);}
case 310:{f.Pc=f.Pop().Int==0?349:313;continue;}
case 313:{f.Push(f.Locals[1]);f.Pc=314;continue;}
case 314:{f.Push(JValue.R(rt.String("TokenColors")));f.Pc=317;continue;}
case 317:{return rt.Call(f,"forge/game/spellability/SpellAbility","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",320);}
case 320:{f.Locals[12]=f.Pop();f.Pc=322;continue;}
case 322:{f.Push(f.Locals[12]);f.Pc=324;continue;}
case 324:{f.Push(JValue.R(rt.String("ChosenColor")));f.Pc=327;continue;}
case 327:{f.Push(f.Locals[4]);f.Pc=329;continue;}
case 329:{return rt.Call(f,"forge/game/card/Card","getChosenColor","()Ljava/lang/String;","invokevirtual",332);}
case 332:{return rt.Call(f,"java/lang/String","replace","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;","invokevirtual",335);}
case 335:{f.Locals[12]=f.Pop();f.Pc=337;continue;}
case 337:{f.Push(f.Locals[11]);f.Pc=339;continue;}
case 339:{f.Push(f.Locals[12]);f.Pc=341;continue;}
case 341:{f.Push(JValue.R(rt.String(",")));f.Pc=343;continue;}
case 343:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",346);}
case 346:{return rt.Call(f,"forge/game/card/Card","setColor","([Ljava/lang/String;)V","invokevirtual",349);}
case 349:{f.Push(f.Locals[11]);f.Pc=351;continue;}
case 351:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5968(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/concurrent/ConcurrentHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/concurrent/ConcurrentHashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/concurrent/ConcurrentHashMap","<init>","()V","invokespecial",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M5969(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/WeakHashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/WeakHashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/WeakHashMap","<init>","()V","invokespecial",7);}
case 7:{return rt.Call(f,"java/util/Collections","synchronizedMap","(Ljava/util/Map;)Ljava/util/Map;","invokestatic",10);}
case 10:{if(!rt.StaticReady(f,"forge/game/card/token/TokenInfo","TOKEN_EDITION_PINS","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/game/card/token/TokenInfo","TOKEN_EDITION_PINS","Ljava/util/Map;",f.Pop());f.Pc=13;continue;}
case 13:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
