// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C44{
internal static JClass Build(){var c=new JClass("forge/card/CardRulesPredicates$LeafString","forge/util/PredicateString",new string[]{},32);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("operand","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("field","Lforge/card/CardRulesPredicates$LeafString$CardField;",false,JValue.Default("Lforge/card/CardRulesPredicates$LeafString$CardField;"),null));
c.Add(new JMethod(757,"forge/card/CardRulesPredicates$LeafString","checkName","(Ljava/lang/String;)Z",4,2,3,new JHandler[]{},M757));
c.Add(new JMethod(758,"forge/card/CardRulesPredicates$LeafString","checkOracle","(Lforge/card/ICardFace;)Z",4,7,3,new JHandler[]{},M758));
c.Add(new JMethod(759,"forge/card/CardRulesPredicates$LeafString","checkType","(Lforge/card/ICardFace;)Z",4,7,3,new JHandler[]{},M759));
c.Add(new JMethod(760,"forge/card/CardRulesPredicates$LeafString","test","(Lforge/card/CardRules;)Z",1,5,3,new JHandler[]{},M760));
c.Add(new JMethod(761,"forge/card/CardRulesPredicates$LeafString","<init>","(Lforge/card/CardRulesPredicates$LeafString$CardField;Lforge/util/PredicateString$StringOp;Ljava/lang/String;)V",1,4,2,new JHandler[]{},M761));
c.Add(new JMethod(762,"forge/card/CardRulesPredicates$LeafString","test","(Ljava/lang/Object;)Z",4161,2,2,new JHandler[]{},M762));
}

internal static JStep M757(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafString","operand","Ljava/lang/String;"));f.Pc=6;continue;}
case 6:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","op","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int!=0?42:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedName","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafString","operand","Ljava/lang/String;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","op","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",24);}
case 24:{f.Pc=f.Pop().Int!=0?42:27;continue;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[1]);f.Pc=29;continue;}
case 29:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","stripAccents","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",32);}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafString","operand","Ljava/lang/String;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","op","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",39);}
case 39:{f.Pc=f.Pop().Int==0?46:42;continue;}
case 42:{f.Push(JValue.I(1));f.Pc=43;continue;}
case 43:{f.Pc=47;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M758(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/ICardFace","hasFunctionalVariants","()Z","invokeinterface",12);}
case 12:{f.Pc=f.Pop().Int==0?163:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/card/ICardFace","getFunctionalVariants","()Ljava/util/Map;","invokeinterface",21);}
case 21:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",26);}
case 26:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",31);}
case 31:{f.Locals[2]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",38);}
case 38:{f.Pc=f.Pop().Int==0?163:41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{f.Locals[3]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",57);}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{f.Locals[4]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/card/ICardFace","getFlavorName","()Ljava/lang/String;","invokeinterface",69);}
case 69:{f.Pc=f.Pop().Reference==null?75:72;continue;}
case 72:{f.Pc=32;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/card/ICardFace","getOracleText","()Ljava/lang/String;","invokeinterface",82);}
case 82:{f.Locals[5]=f.Pop();f.Pc=84;continue;}
case 84:{f.Push(f.Locals[0]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[5]);f.Pc=87;continue;}
case 87:{f.Push(f.Locals[0]);f.Pc=88;continue;}
case 88:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafString","operand","Ljava/lang/String;"));f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","op","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",94);}
case 94:{f.Pc=f.Pop().Int==0?99:97;continue;}
case 97:{f.Push(JValue.I(1));f.Pc=98;continue;}
case 98:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 99:{f.Push(f.Locals[4]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/card/ICardFace","getFlavorName","()Ljava/lang/String;","invokeinterface",106);}
case 106:{f.Pc=f.Pop().Reference==null?119:109;continue;}
case 109:{f.Push(f.Locals[4]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/card/ICardFace","getFlavorName","()Ljava/lang/String;","invokeinterface",116);}
case 116:{f.Pc=140;continue;}
case 119:{f.Push(f.Locals[4]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",126);}
case 126:{f.Push(f.Locals[3]);f.Pc=127;continue;}
case 127:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",132);}
case 132:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=135;continue;}
case 135:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates$LeafString:758:135:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",140);}
case 140:{f.Locals[6]=f.Pop();f.Pc=142;continue;}
case 142:{f.Push(f.Locals[0]);f.Pc=143;continue;}
case 143:{f.Push(f.Locals[6]);f.Pc=145;continue;}
case 145:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedOracle","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",148);}
case 148:{f.Push(f.Locals[0]);f.Pc=149;continue;}
case 149:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafString","operand","Ljava/lang/String;"));f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","op","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",155);}
case 155:{f.Pc=f.Pop().Int==0?160:158;continue;}
case 158:{f.Push(JValue.I(1));f.Pc=159;continue;}
case 159:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 160:{f.Pc=32;continue;}
case 163:{f.Push(f.Locals[0]);f.Pc=164;continue;}
case 164:{f.Push(f.Locals[1]);f.Pc=165;continue;}
case 165:{return rt.Call(f,"forge/card/ICardFace","getOracleText","()Ljava/lang/String;","invokeinterface",170);}
case 170:{f.Push(f.Locals[0]);f.Pc=171;continue;}
case 171:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafString","operand","Ljava/lang/String;"));f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","op","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",177);}
case 177:{f.Pc=f.Pop().Int!=0?200:180;continue;}
case 180:{f.Push(f.Locals[0]);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[1]);f.Pc=182;continue;}
case 182:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",187);}
case 187:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedOracle","(Ljava/lang/String;)Ljava/lang/String;","invokestatic",190);}
case 190:{f.Push(f.Locals[0]);f.Pc=191;continue;}
case 191:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafString","operand","Ljava/lang/String;"));f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","op","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",197);}
case 197:{f.Pc=f.Pop().Int==0?202:200;continue;}
case 200:{f.Push(JValue.I(1));f.Pc=201;continue;}
case 201:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 202:{f.Push(JValue.I(0));f.Pc=203;continue;}
case 203:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M759(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.I(0));f.Pc=5;continue;}
case 5:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/ICardFace","hasFunctionalVariants","()Z","invokeinterface",12);}
case 12:{f.Pc=f.Pop().Int==0?155:15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/card/ICardFace","getFunctionalVariants","()Ljava/util/Map;","invokeinterface",21);}
case 21:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",26);}
case 26:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",31);}
case 31:{f.Locals[2]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",38);}
case 38:{f.Pc=f.Pop().Int==0?155:41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",47);}
case 47:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=50;continue;}
case 50:{f.Locals[3]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(f.Locals[3]);f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",57);}
case 57:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=60;continue;}
case 60:{f.Locals[4]=f.Pop();f.Pc=62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",69);}
case 69:{return rt.Call(f,"forge/card/CardType","toString","()Ljava/lang/String;","invokevirtual",72);}
case 72:{f.Locals[5]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[5]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[0]);f.Pc=78;continue;}
case 78:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafString","operand","Ljava/lang/String;"));f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","op","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",84);}
case 84:{f.Pc=f.Pop().Int==0?89:87;continue;}
case 87:{f.Push(JValue.I(1));f.Pc=88;continue;}
case 88:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{return rt.Call(f,"forge/card/ICardFace","getFlavorName","()Ljava/lang/String;","invokeinterface",96);}
case 96:{f.Pc=f.Pop().Reference==null?109:99;continue;}
case 99:{f.Push(f.Locals[4]);f.Pc=101;continue;}
case 101:{return rt.Call(f,"forge/card/ICardFace","getFlavorName","()Ljava/lang/String;","invokeinterface",106);}
case 106:{f.Pc=130;continue;}
case 109:{f.Push(f.Locals[4]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",116);}
case 116:{f.Push(f.Locals[3]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",122);}
case 122:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=125;continue;}
case 125:{return rt.DynamicCall(f,"forge/card/CardRulesPredicates$LeafString:759:125:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",130);}
case 130:{f.Locals[6]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[0]);f.Pc=133;continue;}
case 133:{f.Push(f.Locals[6]);f.Pc=135;continue;}
case 135:{f.Push(f.Locals[5]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedType","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",140);}
case 140:{f.Push(f.Locals[0]);f.Pc=141;continue;}
case 141:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafString","operand","Ljava/lang/String;"));f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","op","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",147);}
case 147:{f.Pc=f.Pop().Int==0?152:150;continue;}
case 150:{f.Push(JValue.I(1));f.Pc=151;continue;}
case 151:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 152:{f.Pc=32;continue;}
case 155:{f.Push(f.Locals[0]);f.Pc=156;continue;}
case 156:{f.Push(f.Locals[1]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",162);}
case 162:{f.Push(f.Locals[1]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",168);}
case 168:{return rt.Call(f,"forge/card/CardType","toString","()Ljava/lang/String;","invokevirtual",171);}
case 171:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedType","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",174);}
case 174:{f.Push(f.Locals[0]);f.Pc=175;continue;}
case 175:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafString","operand","Ljava/lang/String;"));f.Pc=178;continue;}
case 178:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","op","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",181);}
case 181:{f.Pc=f.Pop().Int!=0?204:184;continue;}
case 184:{f.Push(f.Locals[0]);f.Pc=185;continue;}
case 185:{f.Push(f.Locals[1]);f.Pc=186;continue;}
case 186:{return rt.Call(f,"forge/card/ICardFace","getType","()Lforge/card/CardType;","invokeinterface",191);}
case 191:{return rt.Call(f,"forge/card/CardType","toString","()Ljava/lang/String;","invokevirtual",194);}
case 194:{f.Push(f.Locals[0]);f.Pc=195;continue;}
case 195:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafString","operand","Ljava/lang/String;"));f.Pc=198;continue;}
case 198:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","op","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",201);}
case 201:{f.Pc=f.Pop().Int==0?208:204;continue;}
case 204:{f.Push(JValue.I(1));f.Pc=205;continue;}
case 205:{f.Pc=209;continue;}
case 208:{f.Push(JValue.I(0));f.Pc=209;continue;}
case 209:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M760(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafString$CardField","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRulesPredicates$1","$SwitchMap$forge$card$CardRulesPredicates$LeafString$CardField","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafString","field","Lforge/card/CardRulesPredicates$LeafString$CardField;"));f.Pc=7;continue;}
case 7:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString$CardField","ordinal","()I","invokevirtual",10);}
case 10:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=11;continue;}
case 11:{switch(f.Pop().Int){case 1:f.Pc=44;break;case 2:f.Pc=95;break;case 3:f.Pc=142;break;case 4:f.Pc=188;break;case 5:f.Pc=279;break;default:f.Pc=297;break;}continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"forge/card/CardRules","getAllFaces","()Ljava/util/List;","invokevirtual",48);}
case 48:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",53);}
case 53:{f.Locals[3]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",60);}
case 60:{f.Pc=f.Pop().Int==0?93:63;continue;}
case 63:{f.Push(f.Locals[3]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",69);}
case 69:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=72;continue;}
case 72:{f.Locals[4]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[0]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[4]);f.Pc=77;continue;}
case 77:{return rt.Call(f,"forge/card/ICardFace","getName","()Ljava/lang/String;","invokeinterface",82);}
case 82:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","checkName","(Ljava/lang/String;)Z","invokevirtual",85);}
case 85:{f.Pc=f.Pop().Int==0?90:88;continue;}
case 88:{f.Push(JValue.I(1));f.Pc=89;continue;}
case 89:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 90:{f.Pc=54;continue;}
case 93:{f.Push(JValue.I(0));f.Pc=94;continue;}
case 94:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 95:{f.Push(f.Locals[0]);f.Pc=96;continue;}
case 96:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","getOperator","()Lforge/util/PredicateString$StringOp;","invokevirtual",99);}
case 99:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","CONTAINS","Lforge/util/PredicateString$StringOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/PredicateString$StringOp","CONTAINS","Lforge/util/PredicateString$StringOp;"));f.Pc=102;continue;}
case 102:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?115:105;continue;}
case 105:{f.Push(f.Locals[0]);f.Pc=106;continue;}
case 106:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","getOperator","()Lforge/util/PredicateString$StringOp;","invokevirtual",109);}
case 109:{if(!rt.StaticReady(f,"forge/util/PredicateString$StringOp","EQUALS","Lforge/util/PredicateString$StringOp;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/PredicateString$StringOp","EQUALS","Lforge/util/PredicateString$StringOp;"));f.Pc=112;continue;}
case 112:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?119:115;continue;}
case 115:{f.Push(JValue.I(1));f.Pc=116;continue;}
case 116:{f.Pc=120;continue;}
case 119:{f.Push(JValue.I(0));f.Pc=120;continue;}
case 120:{f.Locals[2]=f.Pop();f.Pc=121;continue;}
case 121:{f.Push(f.Locals[2]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[1]);f.Pc=123;continue;}
case 123:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",126);}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafString","operand","Ljava/lang/String;"));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/card/CardType","hasSubtype","(Ljava/lang/String;)Z","invokevirtual",133);}
case 133:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?140:136;continue;}
case 136:{f.Push(JValue.I(1));f.Pc=137;continue;}
case 137:{f.Pc=141;continue;}
case 140:{f.Push(JValue.I(0));f.Pc=141;continue;}
case 141:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 142:{f.Push(f.Locals[1]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"forge/card/CardRules","getAllFaces","()Ljava/util/List;","invokevirtual",146);}
case 146:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",151);}
case 151:{f.Locals[3]=f.Pop();f.Pc=152;continue;}
case 152:{f.Push(f.Locals[3]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",158);}
case 158:{f.Pc=f.Pop().Int==0?186:161;continue;}
case 161:{f.Push(f.Locals[3]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",167);}
case 167:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=170;continue;}
case 170:{f.Locals[4]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(f.Locals[0]);f.Pc=173;continue;}
case 173:{f.Push(f.Locals[4]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","checkOracle","(Lforge/card/ICardFace;)Z","invokevirtual",178);}
case 178:{f.Pc=f.Pop().Int==0?183:181;continue;}
case 181:{f.Push(JValue.I(1));f.Pc=182;continue;}
case 182:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 183:{f.Pc=152;continue;}
case 186:{f.Push(JValue.I(0));f.Pc=187;continue;}
case 187:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 188:{f.Push(f.Locals[0]);f.Pc=189;continue;}
case 189:{f.Push(f.Locals[1]);f.Pc=190;continue;}
case 190:{return rt.Call(f,"forge/card/CardRules","getName","()Ljava/lang/String;","invokevirtual",193);}
case 193:{f.Push(f.Locals[1]);f.Pc=194;continue;}
case 194:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",197);}
case 197:{return rt.Call(f,"forge/card/CardType","toString","()Ljava/lang/String;","invokevirtual",200);}
case 200:{return rt.Call(f,"forge/util/CardTranslation","getTranslatedType","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",203);}
case 203:{f.Push(f.Locals[0]);f.Pc=204;continue;}
case 204:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafString","operand","Ljava/lang/String;"));f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","op","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",210);}
case 210:{f.Pc=f.Pop().Int!=0?231:213;continue;}
case 213:{f.Push(f.Locals[0]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[1]);f.Pc=215;continue;}
case 215:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",218);}
case 218:{return rt.Call(f,"forge/card/CardType","toString","()Ljava/lang/String;","invokevirtual",221);}
case 221:{f.Push(f.Locals[0]);f.Pc=222;continue;}
case 222:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafString","operand","Ljava/lang/String;"));f.Pc=225;continue;}
case 225:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","op","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",228);}
case 228:{f.Pc=f.Pop().Int==0?233:231;continue;}
case 231:{f.Push(JValue.I(1));f.Pc=232;continue;}
case 232:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 233:{f.Push(f.Locals[1]);f.Pc=234;continue;}
case 234:{return rt.Call(f,"forge/card/CardRules","getAllFaces","()Ljava/util/List;","invokevirtual",237);}
case 237:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",242);}
case 242:{f.Locals[3]=f.Pop();f.Pc=243;continue;}
case 243:{f.Push(f.Locals[3]);f.Pc=244;continue;}
case 244:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",249);}
case 249:{f.Pc=f.Pop().Int==0?277:252;continue;}
case 252:{f.Push(f.Locals[3]);f.Pc=253;continue;}
case 253:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",258);}
case 258:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/ICardFace"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=261;continue;}
case 261:{f.Locals[4]=f.Pop();f.Pc=263;continue;}
case 263:{f.Push(f.Locals[0]);f.Pc=264;continue;}
case 264:{f.Push(f.Locals[4]);f.Pc=266;continue;}
case 266:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","checkType","(Lforge/card/ICardFace;)Z","invokevirtual",269);}
case 269:{f.Pc=f.Pop().Int==0?274:272;continue;}
case 272:{f.Push(JValue.I(1));f.Pc=273;continue;}
case 273:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 274:{f.Pc=243;continue;}
case 277:{f.Push(JValue.I(0));f.Pc=278;continue;}
case 278:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 279:{f.Push(f.Locals[1]);f.Pc=280;continue;}
case 280:{return rt.Call(f,"forge/card/CardRules","getManaCost","()Lforge/card/mana/ManaCost;","invokevirtual",283);}
case 283:{return rt.Call(f,"forge/card/mana/ManaCost","toString","()Ljava/lang/String;","invokevirtual",286);}
case 286:{f.Locals[3]=f.Pop();f.Pc=287;continue;}
case 287:{f.Push(f.Locals[0]);f.Pc=288;continue;}
case 288:{f.Push(f.Locals[3]);f.Pc=289;continue;}
case 289:{f.Push(f.Locals[0]);f.Pc=290;continue;}
case 290:{f.Push(rt.GetField(f.Pop(),"forge/card/CardRulesPredicates$LeafString","operand","Ljava/lang/String;"));f.Pc=293;continue;}
case 293:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","op","(Ljava/lang/String;Ljava/lang/String;)Z","invokevirtual",296);}
case 296:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 297:{f.Push(JValue.I(0));f.Pc=298;continue;}
case 298:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M761(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[2]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/util/PredicateString","<init>","(Lforge/util/PredicateString$StringOp;)V","invokespecial",5);}
case 5:{f.Push(f.Locals[0]);f.Pc=6;continue;}
case 6:{f.Push(f.Locals[1]);f.Pc=7;continue;}
case 7:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRulesPredicates$LeafString","field","Lforge/card/CardRulesPredicates$LeafString$CardField;",value);f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{f.Push(f.Locals[3]);f.Pc=12;continue;}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/card/CardRulesPredicates$LeafString","operand","Ljava/lang/String;",value);f.Pc=15;continue;}
case 15:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M762(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/CardRules"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/CardRulesPredicates$LeafString","test","(Lforge/card/CardRules;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
