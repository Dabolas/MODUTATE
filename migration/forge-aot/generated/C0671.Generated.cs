// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C671{
internal static JClass Build(){var c=new JClass("forge/game/keyword/Protection","forge/game/keyword/KeywordWithType",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(7656,"forge/game/keyword/Protection","<init>","()V",1,1,1,new JHandler[]{},M7656));
c.Add(new JMethod(7657,"forge/game/keyword/Protection","getTitle","()Ljava/lang/String;",1,1,1,new JHandler[]{},M7657));
c.Add(new JMethod(7658,"forge/game/keyword/Protection","getProtectionValid","(Ljava/lang/String;Z)Ljava/lang/String;",9,5,3,new JHandler[]{},M7658));
}

internal static JStep M7656(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordWithType","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7657(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/Protection","getTypeDescription","()Ljava/lang/String;","invokevirtual",4);}
case 4:{return rt.DynamicCall(f,"forge/game/keyword/Protection:7657:4:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",9);}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7658(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("")));f.Pc=2;continue;}
case 2:{f.Locals[2]=f.Pop();f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Protection:")));f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",9);}
case 9:{f.Pc=f.Pop().Int==0?154:12;continue;}
case 12:{f.Push(f.Locals[0]);f.Pc=13;continue;}
case 13:{f.Push(JValue.R(rt.String(":")));f.Pc=15;continue;}
case 15:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",18);}
case 18:{f.Locals[3]=f.Pop();f.Pc=19;continue;}
case 19:{f.Push(f.Locals[3]);f.Pc=20;continue;}
case 20:{f.Push(JValue.I(1));f.Pc=21;continue;}
case 21:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=22;continue;}
case 22:{f.Locals[4]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[4]);f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String("Player")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",31);}
case 31:{f.Pc=f.Pop().Int==0?45:34;continue;}
case 34:{f.Push(f.Locals[4]);f.Pc=36;continue;}
case 36:{return rt.DynamicCall(f,"forge/game/keyword/Protection:7658:36:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",41);}
case 41:{f.Locals[2]=f.Pop();f.Pc=42;continue;}
case 42:{f.Pc=151;continue;}
case 45:{f.Push(f.Locals[1]);f.Pc=46;continue;}
case 46:{f.Pc=f.Pop().Int==0?148:49;continue;}
case 49:{f.Push(f.Locals[4]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("White")));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",56);}
case 56:{f.Pc=f.Pop().Int!=0?139:59;continue;}
case 59:{f.Push(f.Locals[4]);f.Pc=61;continue;}
case 61:{f.Push(JValue.R(rt.String("Blue")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",66);}
case 66:{f.Pc=f.Pop().Int!=0?139:69;continue;}
case 69:{f.Push(f.Locals[4]);f.Pc=71;continue;}
case 71:{f.Push(JValue.R(rt.String("Black")));f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",76);}
case 76:{f.Pc=f.Pop().Int!=0?139:79;continue;}
case 79:{f.Push(f.Locals[4]);f.Pc=81;continue;}
case 81:{f.Push(JValue.R(rt.String("Red")));f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",86);}
case 86:{f.Pc=f.Pop().Int!=0?139:89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{f.Push(JValue.R(rt.String("Green")));f.Pc=93;continue;}
case 93:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",96);}
case 96:{f.Pc=f.Pop().Int!=0?139:99;continue;}
case 99:{f.Push(f.Locals[4]);f.Pc=101;continue;}
case 101:{f.Push(JValue.R(rt.String("Colorless")));f.Pc=103;continue;}
case 103:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",106);}
case 106:{f.Pc=f.Pop().Int!=0?139:109;continue;}
case 109:{f.Push(f.Locals[4]);f.Pc=111;continue;}
case 111:{f.Push(JValue.R(rt.String("MonoColor")));f.Pc=113;continue;}
case 113:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",116);}
case 116:{f.Pc=f.Pop().Int!=0?139:119;continue;}
case 119:{f.Push(f.Locals[4]);f.Pc=121;continue;}
case 121:{f.Push(JValue.R(rt.String("MultiColor")));f.Pc=123;continue;}
case 123:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",126);}
case 126:{f.Pc=f.Pop().Int!=0?139:129;continue;}
case 129:{f.Push(f.Locals[4]);f.Pc=131;continue;}
case 131:{f.Push(JValue.R(rt.String("EnemyColor")));f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",136);}
case 136:{f.Pc=f.Pop().Int==0?148:139;continue;}
case 139:{f.Push(f.Locals[4]);f.Pc=141;continue;}
case 141:{return rt.DynamicCall(f,"forge/game/keyword/Protection:7658:141:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",146);}
case 146:{f.Locals[4]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[4]);f.Pc=150;continue;}
case 150:{return JStep.Return(f.Pop());}
case 151:{f.Pc=402;continue;}
case 154:{f.Push(f.Locals[0]);f.Pc=155;continue;}
case 155:{f.Push(JValue.R(rt.String("Protection from ")));f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",160);}
case 160:{f.Pc=f.Pop().Int==0?402:163;continue;}
case 163:{f.Push(f.Locals[0]);f.Pc=164;continue;}
case 164:{f.Push(JValue.R(rt.String("Protection from ")));f.Pc=166;continue;}
case 166:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",169);}
case 169:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",172);}
case 172:{f.Locals[3]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[3]);f.Pc=174;continue;}
case 174:{f.Push(JValue.R(rt.String("white")));f.Pc=176;continue;}
case 176:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",179);}
case 179:{f.Pc=f.Pop().Int==0?202:182;continue;}
case 182:{f.Push(f.Locals[1]);f.Pc=183;continue;}
case 183:{f.Pc=f.Pop().Int==0?191:186;continue;}
case 186:{f.Push(JValue.R(rt.String("Source")));f.Pc=188;continue;}
case 188:{f.Pc=193;continue;}
case 191:{f.Push(JValue.R(rt.String("")));f.Pc=193;continue;}
case 193:{return rt.DynamicCall(f,"forge/game/keyword/Protection:7658:193:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",198);}
case 198:{f.Locals[2]=f.Pop();f.Pc=199;continue;}
case 199:{f.Pc=402;continue;}
case 202:{f.Push(f.Locals[3]);f.Pc=203;continue;}
case 203:{f.Push(JValue.R(rt.String("blue")));f.Pc=205;continue;}
case 205:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",208);}
case 208:{f.Pc=f.Pop().Int==0?231:211;continue;}
case 211:{f.Push(f.Locals[1]);f.Pc=212;continue;}
case 212:{f.Pc=f.Pop().Int==0?220:215;continue;}
case 215:{f.Push(JValue.R(rt.String("Source")));f.Pc=217;continue;}
case 217:{f.Pc=222;continue;}
case 220:{f.Push(JValue.R(rt.String("")));f.Pc=222;continue;}
case 222:{return rt.DynamicCall(f,"forge/game/keyword/Protection:7658:222:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",227);}
case 227:{f.Locals[2]=f.Pop();f.Pc=228;continue;}
case 228:{f.Pc=402;continue;}
case 231:{f.Push(f.Locals[3]);f.Pc=232;continue;}
case 232:{f.Push(JValue.R(rt.String("black")));f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",237);}
case 237:{f.Pc=f.Pop().Int==0?260:240;continue;}
case 240:{f.Push(f.Locals[1]);f.Pc=241;continue;}
case 241:{f.Pc=f.Pop().Int==0?249:244;continue;}
case 244:{f.Push(JValue.R(rt.String("Source")));f.Pc=246;continue;}
case 246:{f.Pc=251;continue;}
case 249:{f.Push(JValue.R(rt.String("")));f.Pc=251;continue;}
case 251:{return rt.DynamicCall(f,"forge/game/keyword/Protection:7658:251:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",256);}
case 256:{f.Locals[2]=f.Pop();f.Pc=257;continue;}
case 257:{f.Pc=402;continue;}
case 260:{f.Push(f.Locals[3]);f.Pc=261;continue;}
case 261:{f.Push(JValue.R(rt.String("red")));f.Pc=263;continue;}
case 263:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",266);}
case 266:{f.Pc=f.Pop().Int==0?289:269;continue;}
case 269:{f.Push(f.Locals[1]);f.Pc=270;continue;}
case 270:{f.Pc=f.Pop().Int==0?278:273;continue;}
case 273:{f.Push(JValue.R(rt.String("Source")));f.Pc=275;continue;}
case 275:{f.Pc=280;continue;}
case 278:{f.Push(JValue.R(rt.String("")));f.Pc=280;continue;}
case 280:{return rt.DynamicCall(f,"forge/game/keyword/Protection:7658:280:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",285);}
case 285:{f.Locals[2]=f.Pop();f.Pc=286;continue;}
case 286:{f.Pc=402;continue;}
case 289:{f.Push(f.Locals[3]);f.Pc=290;continue;}
case 290:{f.Push(JValue.R(rt.String("green")));f.Pc=292;continue;}
case 292:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",295);}
case 295:{f.Pc=f.Pop().Int==0?318:298;continue;}
case 298:{f.Push(f.Locals[1]);f.Pc=299;continue;}
case 299:{f.Pc=f.Pop().Int==0?307:302;continue;}
case 302:{f.Push(JValue.R(rt.String("Source")));f.Pc=304;continue;}
case 304:{f.Pc=309;continue;}
case 307:{f.Push(JValue.R(rt.String("")));f.Pc=309;continue;}
case 309:{return rt.DynamicCall(f,"forge/game/keyword/Protection:7658:309:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",314);}
case 314:{f.Locals[2]=f.Pop();f.Pc=315;continue;}
case 315:{f.Pc=402;continue;}
case 318:{f.Push(f.Locals[3]);f.Pc=319;continue;}
case 319:{f.Push(JValue.R(rt.String("colorless")));f.Pc=321;continue;}
case 321:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",324);}
case 324:{f.Pc=f.Pop().Int==0?347:327;continue;}
case 327:{f.Push(f.Locals[1]);f.Pc=328;continue;}
case 328:{f.Pc=f.Pop().Int==0?336:331;continue;}
case 331:{f.Push(JValue.R(rt.String("Source")));f.Pc=333;continue;}
case 333:{f.Pc=338;continue;}
case 336:{f.Push(JValue.R(rt.String("")));f.Pc=338;continue;}
case 338:{return rt.DynamicCall(f,"forge/game/keyword/Protection:7658:338:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",343);}
case 343:{f.Locals[2]=f.Pop();f.Pc=344;continue;}
case 344:{f.Pc=402;continue;}
case 347:{f.Push(f.Locals[3]);f.Pc=348;continue;}
case 348:{f.Push(JValue.R(rt.String("each color")));f.Pc=350;continue;}
case 350:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",353);}
case 353:{f.Pc=f.Pop().Int==0?376:356;continue;}
case 356:{f.Push(f.Locals[1]);f.Pc=357;continue;}
case 357:{f.Pc=f.Pop().Int==0?365:360;continue;}
case 360:{f.Push(JValue.R(rt.String("Source")));f.Pc=362;continue;}
case 362:{f.Pc=367;continue;}
case 365:{f.Push(JValue.R(rt.String("")));f.Pc=367;continue;}
case 367:{return rt.DynamicCall(f,"forge/game/keyword/Protection:7658:367:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",372);}
case 372:{f.Locals[2]=f.Pop();f.Pc=373;continue;}
case 373:{f.Pc=402;continue;}
case 376:{f.Push(f.Locals[3]);f.Pc=377;continue;}
case 377:{f.Push(JValue.R(rt.String("everything")));f.Pc=379;continue;}
case 379:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",382);}
case 382:{f.Pc=f.Pop().Int==0?388:385;continue;}
case 385:{f.Push(JValue.R(rt.String("")));f.Pc=387;continue;}
case 387:{return JStep.Return(f.Pop());}
case 388:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=391;continue;}
case 391:{f.StackOp("dup");f.Pc=392;continue;}
case 392:{f.Push(f.Locals[0]);f.Pc=393;continue;}
case 393:{return rt.DynamicCall(f,"forge/game/keyword/Protection:7658:393:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",398);}
case 398:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",401);}
case 401:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 402:{f.Push(f.Locals[2]);f.Pc=403;continue;}
case 403:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",406);}
case 406:{f.Pc=f.Pop().Int==0?411:409;continue;}
case 409:{f.Push(f.Locals[2]);f.Pc=410;continue;}
case 410:{return JStep.Return(f.Pop());}
case 411:{f.Push(f.Locals[2]);f.Pc=412;continue;}
case 412:{f.Push(f.Locals[2]);f.Pc=413;continue;}
case 413:{return rt.DynamicCall(f,"forge/game/keyword/Protection:7658:413:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",418);}
case 418:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
