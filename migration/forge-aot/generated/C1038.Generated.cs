// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1038{
internal static JClass Build(){var c=new JClass("forge/game/undo/GameMemento$UndoDelta","forge/game/undo/GameMemento$HistoryData",new string[]{},1056);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10972,"forge/game/undo/GameMemento$UndoDelta","<init>","()V",2,1,1,new JHandler[]{},M10972));
c.Add(new JMethod(10973,"forge/game/undo/GameMemento$UndoDelta","restore","(Lforge/game/undo/GameMemento$Snap;)Lforge/game/undo/GameMemento$Snap;",1024,0,0,new JHandler[]{},null));
c.Add(new JMethod(10974,"forge/game/undo/GameMemento$UndoDelta","between","(Lforge/game/undo/GameMemento$Snap;Lforge/game/undo/GameMemento$Snap;)Lforge/game/undo/GameMemento$HistoryData;",8,12,7,new JHandler[]{},M10974));
}

internal static JStep M10972(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/undo/GameMemento$HistoryData","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10974(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$ObjSnap")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?349:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$ObjSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$ObjSnap")?1:0));f.Pc=16;continue;}
case 16:{f.Pc=f.Pop().Int==0?349:19;continue;}
case 19:{f.Push(f.Locals[1]);f.Pc=20;continue;}
case 20:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$ObjSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=23;continue;}
case 23:{f.Locals[3]=f.Pop();f.Pc=24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","ci","Lforge/game/undo/GameMemento$ClassInfo;"));f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","ci","Lforge/game/undo/GameMemento$ClassInfo;"));f.Pc=32;continue;}
case 32:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?349:35;continue;}
case 35:{f.Push(JValue.I(0));f.Pc=36;continue;}
case 36:{f.Locals[4]=f.Pop();f.Pc=38;continue;}
case 38:{f.Push(JValue.I(0));f.Pc=39;continue;}
case 39:{f.Locals[5]=f.Pop();f.Pc=41;continue;}
case 41:{f.Push(JValue.I(0));f.Pc=42;continue;}
case 42:{f.Locals[6]=f.Pop();f.Pc=44;continue;}
case 44:{f.Push(f.Locals[6]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","refs","[Ljava/lang/Object;"));f.Pc=50;continue;}
case 50:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=51;continue;}
case 51:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?80:54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","refs","[Ljava/lang/Object;"));f.Pc=58;continue;}
case 58:{f.Push(f.Locals[6]);f.Pc=60;continue;}
case 60:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=61;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","refs","[Ljava/lang/Object;"));f.Pc=65;continue;}
case 65:{f.Push(f.Locals[6]);f.Pc=67;continue;}
case 67:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=68;continue;}
case 68:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?74:71;continue;}
case 71:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=74;continue;}
case 74:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=77;continue;}
case 77:{f.Pc=44;continue;}
case 80:{f.Push(JValue.I(0));f.Pc=81;continue;}
case 81:{f.Locals[6]=f.Pop();f.Pc=83;continue;}
case 83:{f.Push(f.Locals[6]);f.Pc=85;continue;}
case 85:{f.Push(f.Locals[2]);f.Pc=86;continue;}
case 86:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","prims","[J"));f.Pc=89;continue;}
case 89:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=90;continue;}
case 90:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?120:93;continue;}
case 93:{f.Push(f.Locals[2]);f.Pc=94;continue;}
case 94:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","prims","[J"));f.Pc=97;continue;}
case 97:{f.Push(f.Locals[6]);f.Pc=99;continue;}
case 99:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=100;continue;}
case 100:{f.Push(f.Locals[3]);f.Pc=101;continue;}
case 101:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","prims","[J"));f.Pc=104;continue;}
case 104:{f.Push(f.Locals[6]);f.Pc=106;continue;}
case 106:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=107;continue;}
case 107:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=108;continue;}
case 108:{f.Pc=f.Pop().Int==0?114:111;continue;}
case 111:{f.Locals[5]=JValue.I(unchecked(f.Locals[5].Int+(1)));f.Pc=114;continue;}
case 114:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=117;continue;}
case 117:{f.Pc=83;continue;}
case 120:{f.Push(f.Locals[4]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[5]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"forge/game/undo/GameMemento$ObjDelta","estimatedBytes","(II)J","invokestatic",127);}
case 127:{f.Push(f.Locals[0]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"forge/game/undo/GameMemento$Snap","bytes","()J","invokevirtual",131);}
case 131:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=132;continue;}
case 132:{f.Pc=f.Pop().Int<0?137:135;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{return JStep.Return(f.Pop());}
case 137:{f.Push(f.Locals[4]);f.Pc=139;continue;}
case 139:{f.Pc=f.Pop().Int!=0?148:142;continue;}
case 142:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_INTS","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","NO_INTS","[I"));f.Pc=145;continue;}
case 145:{f.Pc=152;continue;}
case 148:{f.Push(f.Locals[4]);f.Pc=150;continue;}
case 150:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=152;continue;}
case 152:{f.Locals[6]=f.Pop();f.Pc=154;continue;}
case 154:{f.Push(f.Locals[4]);f.Pc=156;continue;}
case 156:{f.Pc=f.Pop().Int!=0?165:159;continue;}
case 159:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_OBJECTS","[Ljava/lang/Object;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","NO_OBJECTS","[Ljava/lang/Object;"));f.Pc=162;continue;}
case 162:{f.Pc=170;continue;}
case 165:{f.Push(f.Locals[4]);f.Pc=167;continue;}
case 167:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=170;continue;}
case 170:{f.Locals[7]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(f.Locals[5]);f.Pc=174;continue;}
case 174:{f.Pc=f.Pop().Int!=0?183:177;continue;}
case 177:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_INTS","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","NO_INTS","[I"));f.Pc=180;continue;}
case 180:{f.Pc=187;continue;}
case 183:{f.Push(f.Locals[5]);f.Pc=185;continue;}
case 185:{f.Push(JValue.R(rt.NewArray("I",f.Pop().Int)));f.Pc=187;continue;}
case 187:{f.Locals[8]=f.Pop();f.Pc=189;continue;}
case 189:{f.Push(f.Locals[5]);f.Pc=191;continue;}
case 191:{f.Pc=f.Pop().Int!=0?200:194;continue;}
case 194:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_LONGS","[J"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","NO_LONGS","[J"));f.Pc=197;continue;}
case 197:{f.Pc=204;continue;}
case 200:{f.Push(f.Locals[5]);f.Pc=202;continue;}
case 202:{f.Push(JValue.R(rt.NewArray("J",f.Pop().Int)));f.Pc=204;continue;}
case 204:{f.Locals[9]=f.Pop();f.Pc=206;continue;}
case 206:{f.Push(JValue.I(0));f.Pc=207;continue;}
case 207:{f.Locals[10]=f.Pop();f.Pc=209;continue;}
case 209:{f.Push(JValue.I(0));f.Pc=210;continue;}
case 210:{f.Locals[11]=f.Pop();f.Pc=212;continue;}
case 212:{f.Push(f.Locals[10]);f.Pc=214;continue;}
case 214:{f.Push(f.Locals[2]);f.Pc=215;continue;}
case 215:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","refs","[Ljava/lang/Object;"));f.Pc=218;continue;}
case 218:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=219;continue;}
case 219:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?267:222;continue;}
case 222:{f.Push(f.Locals[2]);f.Pc=223;continue;}
case 223:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","refs","[Ljava/lang/Object;"));f.Pc=226;continue;}
case 226:{f.Push(f.Locals[10]);f.Pc=228;continue;}
case 228:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=229;continue;}
case 229:{f.Push(f.Locals[3]);f.Pc=230;continue;}
case 230:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","refs","[Ljava/lang/Object;"));f.Pc=233;continue;}
case 233:{f.Push(f.Locals[10]);f.Pc=235;continue;}
case 235:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=236;continue;}
case 236:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?261:239;continue;}
case 239:{f.Push(f.Locals[6]);f.Pc=241;continue;}
case 241:{f.Push(f.Locals[11]);f.Pc=243;continue;}
case 243:{f.Push(f.Locals[10]);f.Pc=245;continue;}
case 245:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=246;continue;}
case 246:{f.Push(f.Locals[7]);f.Pc=248;continue;}
case 248:{f.Push(f.Locals[11]);f.Pc=250;continue;}
case 250:{f.Locals[11]=JValue.I(unchecked(f.Locals[11].Int+(1)));f.Pc=253;continue;}
case 253:{f.Push(f.Locals[2]);f.Pc=254;continue;}
case 254:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","refs","[Ljava/lang/Object;"));f.Pc=257;continue;}
case 257:{f.Push(f.Locals[10]);f.Pc=259;continue;}
case 259:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=260;continue;}
case 260:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=261;continue;}
case 261:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=264;continue;}
case 264:{f.Pc=212;continue;}
case 267:{f.Push(JValue.I(0));f.Pc=268;continue;}
case 268:{f.Locals[10]=f.Pop();f.Pc=270;continue;}
case 270:{f.Push(JValue.I(0));f.Pc=271;continue;}
case 271:{f.Locals[11]=f.Pop();f.Pc=273;continue;}
case 273:{f.Push(f.Locals[10]);f.Pc=275;continue;}
case 275:{f.Push(f.Locals[2]);f.Pc=276;continue;}
case 276:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","prims","[J"));f.Pc=279;continue;}
case 279:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=280;continue;}
case 280:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?329:283;continue;}
case 283:{f.Push(f.Locals[2]);f.Pc=284;continue;}
case 284:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","prims","[J"));f.Pc=287;continue;}
case 287:{f.Push(f.Locals[10]);f.Pc=289;continue;}
case 289:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=290;continue;}
case 290:{f.Push(f.Locals[3]);f.Pc=291;continue;}
case 291:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","prims","[J"));f.Pc=294;continue;}
case 294:{f.Push(f.Locals[10]);f.Pc=296;continue;}
case 296:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=297;continue;}
case 297:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=298;continue;}
case 298:{f.Pc=f.Pop().Int==0?323:301;continue;}
case 301:{f.Push(f.Locals[8]);f.Pc=303;continue;}
case 303:{f.Push(f.Locals[11]);f.Pc=305;continue;}
case 305:{f.Push(f.Locals[10]);f.Pc=307;continue;}
case 307:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=308;continue;}
case 308:{f.Push(f.Locals[9]);f.Pc=310;continue;}
case 310:{f.Push(f.Locals[11]);f.Pc=312;continue;}
case 312:{f.Locals[11]=JValue.I(unchecked(f.Locals[11].Int+(1)));f.Pc=315;continue;}
case 315:{f.Push(f.Locals[2]);f.Pc=316;continue;}
case 316:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","prims","[J"));f.Pc=319;continue;}
case 319:{f.Push(f.Locals[10]);f.Pc=321;continue;}
case 321:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=322;continue;}
case 322:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=323;continue;}
case 323:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=326;continue;}
case 326:{f.Pc=273;continue;}
case 329:{if(!rt.EnsureInitialized(f,"forge/game/undo/GameMemento$ObjDelta"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/undo/GameMemento$ObjDelta")));f.Pc=332;continue;}
case 332:{f.StackOp("dup");f.Pc=333;continue;}
case 333:{f.Push(f.Locals[2]);f.Pc=334;continue;}
case 334:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$ObjSnap","ci","Lforge/game/undo/GameMemento$ClassInfo;"));f.Pc=337;continue;}
case 337:{f.Push(f.Locals[6]);f.Pc=339;continue;}
case 339:{f.Push(f.Locals[7]);f.Pc=341;continue;}
case 341:{f.Push(f.Locals[8]);f.Pc=343;continue;}
case 343:{f.Push(f.Locals[9]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"forge/game/undo/GameMemento$ObjDelta","<init>","(Lforge/game/undo/GameMemento$ClassInfo;[I[Ljava/lang/Object;[I[J)V","invokespecial",348);}
case 348:{return JStep.Return(f.Pop());}
case 349:{f.Push(f.Locals[0]);f.Pc=350;continue;}
case 350:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$SeqSnap")?1:0));f.Pc=353;continue;}
case 353:{f.Pc=f.Pop().Int==0?567:356;continue;}
case 356:{f.Push(f.Locals[0]);f.Pc=357;continue;}
case 357:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$SeqSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=360;continue;}
case 360:{f.Locals[2]=f.Pop();f.Pc=361;continue;}
case 361:{f.Push(f.Locals[1]);f.Pc=362;continue;}
case 362:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/game/undo/GameMemento$SeqSnap")?1:0));f.Pc=365;continue;}
case 365:{f.Pc=f.Pop().Int==0?567:368;continue;}
case 368:{f.Push(f.Locals[1]);f.Pc=369;continue;}
case 369:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/undo/GameMemento$SeqSnap"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=372;continue;}
case 372:{f.Locals[3]=f.Pop();f.Pc=373;continue;}
case 373:{f.Push(JValue.I(0));f.Pc=374;continue;}
case 374:{f.Locals[4]=f.Pop();f.Pc=376;continue;}
case 376:{f.Push(f.Locals[2]);f.Pc=377;continue;}
case 377:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=380;continue;}
case 380:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=381;continue;}
case 381:{f.Push(f.Locals[3]);f.Pc=382;continue;}
case 382:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=385;continue;}
case 385:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=386;continue;}
case 386:{return rt.Call(f,"java/lang/Math","min","(II)I","invokestatic",389);}
case 389:{f.Locals[5]=f.Pop();f.Pc=391;continue;}
case 391:{f.Push(f.Locals[4]);f.Pc=393;continue;}
case 393:{f.Push(f.Locals[5]);f.Pc=395;continue;}
case 395:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?421:398;continue;}
case 398:{f.Push(f.Locals[2]);f.Pc=399;continue;}
case 399:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=402;continue;}
case 402:{f.Push(f.Locals[4]);f.Pc=404;continue;}
case 404:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=405;continue;}
case 405:{f.Push(f.Locals[3]);f.Pc=406;continue;}
case 406:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=409;continue;}
case 409:{f.Push(f.Locals[4]);f.Pc=411;continue;}
case 411:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=412;continue;}
case 412:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?421:415;continue;}
case 415:{f.Locals[4]=JValue.I(unchecked(f.Locals[4].Int+(1)));f.Pc=418;continue;}
case 418:{f.Pc=391;continue;}
case 421:{f.Push(JValue.I(0));f.Pc=422;continue;}
case 422:{f.Locals[6]=f.Pop();f.Pc=424;continue;}
case 424:{f.Push(f.Locals[6]);f.Pc=426;continue;}
case 426:{f.Push(f.Locals[2]);f.Pc=427;continue;}
case 427:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=430;continue;}
case 430:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=431;continue;}
case 431:{f.Push(f.Locals[4]);f.Pc=433;continue;}
case 433:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=434;continue;}
case 434:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?489:437;continue;}
case 437:{f.Push(f.Locals[6]);f.Pc=439;continue;}
case 439:{f.Push(f.Locals[3]);f.Pc=440;continue;}
case 440:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=443;continue;}
case 443:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=444;continue;}
case 444:{f.Push(f.Locals[4]);f.Pc=446;continue;}
case 446:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=447;continue;}
case 447:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?489:450;continue;}
case 450:{f.Push(f.Locals[2]);f.Pc=451;continue;}
case 451:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=454;continue;}
case 454:{f.Push(f.Locals[2]);f.Pc=455;continue;}
case 455:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=458;continue;}
case 458:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=459;continue;}
case 459:{f.Push(JValue.I(1));f.Pc=460;continue;}
case 460:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=461;continue;}
case 461:{f.Push(f.Locals[6]);f.Pc=463;continue;}
case 463:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=464;continue;}
case 464:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=465;continue;}
case 465:{f.Push(f.Locals[3]);f.Pc=466;continue;}
case 466:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=469;continue;}
case 469:{f.Push(f.Locals[3]);f.Pc=470;continue;}
case 470:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=473;continue;}
case 473:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=474;continue;}
case 474:{f.Push(JValue.I(1));f.Pc=475;continue;}
case 475:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=476;continue;}
case 476:{f.Push(f.Locals[6]);f.Pc=478;continue;}
case 478:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=479;continue;}
case 479:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=480;continue;}
case 480:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?489:483;continue;}
case 483:{f.Locals[6]=JValue.I(unchecked(f.Locals[6].Int+(1)));f.Pc=486;continue;}
case 486:{f.Pc=424;continue;}
case 489:{f.Push(f.Locals[2]);f.Pc=490;continue;}
case 490:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=493;continue;}
case 493:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=494;continue;}
case 494:{f.Push(f.Locals[4]);f.Pc=496;continue;}
case 496:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=497;continue;}
case 497:{f.Push(f.Locals[6]);f.Pc=499;continue;}
case 499:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=500;continue;}
case 500:{f.Locals[7]=f.Pop();f.Pc=502;continue;}
case 502:{f.Push(JValue.L(32L));f.Pc=505;continue;}
case 505:{f.Push(f.Locals[7]);f.Pc=507;continue;}
case 507:{return rt.Call(f,"forge/game/undo/GameMemento","arr","(I)J","invokestatic",510);}
case 510:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"ladd",a,b));f.Pc=511;continue;}
case 511:{f.Push(f.Locals[0]);f.Pc=512;continue;}
case 512:{return rt.Call(f,"forge/game/undo/GameMemento$Snap","bytes","()J","invokevirtual",515);}
case 515:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"lcmp",a,b));f.Pc=516;continue;}
case 516:{f.Pc=f.Pop().Int<0?521:519;continue;}
case 519:{f.Push(f.Locals[0]);f.Pc=520;continue;}
case 520:{return JStep.Return(f.Pop());}
case 521:{f.Push(f.Locals[7]);f.Pc=523;continue;}
case 523:{f.Pc=f.Pop().Int!=0?532:526;continue;}
case 526:{if(!rt.StaticReady(f,"forge/game/undo/GameMemento","NO_OBJECTS","[Ljava/lang/Object;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/undo/GameMemento","NO_OBJECTS","[Ljava/lang/Object;"));f.Pc=529;continue;}
case 529:{f.Pc=546;continue;}
case 532:{f.Push(f.Locals[2]);f.Pc=533;continue;}
case 533:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=536;continue;}
case 536:{f.Push(f.Locals[4]);f.Pc=538;continue;}
case 538:{f.Push(f.Locals[4]);f.Pc=540;continue;}
case 540:{f.Push(f.Locals[7]);f.Pc=542;continue;}
case 542:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=543;continue;}
case 543:{return rt.Call(f,"java/util/Arrays","copyOfRange","([Ljava/lang/Object;II)[Ljava/lang/Object;","invokestatic",546);}
case 546:{f.Locals[8]=f.Pop();f.Pc=548;continue;}
case 548:{if(!rt.EnsureInitialized(f,"forge/game/undo/GameMemento$SeqDelta"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/undo/GameMemento$SeqDelta")));f.Pc=551;continue;}
case 551:{f.StackOp("dup");f.Pc=552;continue;}
case 552:{f.Push(f.Locals[4]);f.Pc=554;continue;}
case 554:{f.Push(f.Locals[6]);f.Pc=556;continue;}
case 556:{f.Push(f.Locals[2]);f.Pc=557;continue;}
case 557:{f.Push(rt.GetField(f.Pop(),"forge/game/undo/GameMemento$SeqSnap","items","[Ljava/lang/Object;"));f.Pc=560;continue;}
case 560:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=561;continue;}
case 561:{f.Push(f.Locals[8]);f.Pc=563;continue;}
case 563:{return rt.Call(f,"forge/game/undo/GameMemento$SeqDelta","<init>","(III[Ljava/lang/Object;)V","invokespecial",566);}
case 566:{return JStep.Return(f.Pop());}
case 567:{f.Push(f.Locals[0]);f.Pc=568;continue;}
case 568:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
