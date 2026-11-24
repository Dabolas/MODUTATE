// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1083{
internal static JClass Build(){var c=new JClass("forge/item/generation/BoosterGenerator","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("staticSheetsCorrespondance","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("cachedSheets","Ljava/util/Map;",true,JValue.Default("Ljava/util/Map;"),null));
c.Add(new JField("EXCLUDED_NAMES","Ljava/lang/ThreadLocal;",true,JValue.Default("Ljava/lang/ThreadLocal;"),null));
c.Add(new JMethod(11449,"forge/item/generation/BoosterGenerator","<init>","()V",1,1,1,new JHandler[]{},M11449));
c.Add(new JMethod(11450,"forge/item/generation/BoosterGenerator","getPrintSheet","(Ljava/lang/String;)Lforge/card/PrintSheet;",42,1,4,new JHandler[]{},M11450));
c.Add(new JMethod(11451,"forge/item/generation/BoosterGenerator","applyExclusions","(Lforge/card/PrintSheet;)Lforge/card/PrintSheet;",10,2,2,new JHandler[]{},M11451));
c.Add(new JMethod(11452,"forge/item/generation/BoosterGenerator","generateFoilCard","(Lforge/card/PrintSheet;)Lforge/item/PaperCard;",10,2,3,new JHandler[]{},M11452));
c.Add(new JMethod(11453,"forge/item/generation/BoosterGenerator","generateFoilCard","(Ljava/util/List;)Lforge/item/PaperCard;",10,2,2,new JHandler[]{},M11453));
c.Add(new JMethod(11454,"forge/item/generation/BoosterGenerator","addFoilIfPresent","(Ljava/util/List;Lforge/item/PaperCard;)V",10,2,2,new JHandler[]{},M11454));
c.Add(new JMethod(11455,"forge/item/generation/BoosterGenerator","tryGetStaticSheet","(Ljava/lang/String;)Lforge/card/PrintSheet;",9,6,3,new JHandler[]{},M11455));
c.Add(new JMethod(11456,"forge/item/generation/BoosterGenerator","getBoosterPack","(Lforge/item/SealedTemplate;)Ljava/util/List;",9,1,2,new JHandler[]{},M11456));
c.Add(new JMethod(11457,"forge/item/generation/BoosterGenerator","getBoosterPack","(Lforge/item/SealedTemplate;Ljava/util/Collection;)Ljava/util/List;",9,5,2,new JHandler[]{new JHandler(10,22,44,""),new JHandler(44,46,44,"")},M11457));
c.Add(new JMethod(11458,"forge/item/generation/BoosterGenerator","getBoosterPackInternal","(Lforge/item/SealedTemplate;)Ljava/util/List;",10,24,4,new JHandler[]{},M11458));
c.Add(new JMethod(11459,"forge/item/generation/BoosterGenerator","getBoosterPack","(Lforge/item/SealedTemplateWithSlots;)Ljava/util/List;",9,19,4,new JHandler[]{new JHandler(260,274,277,"java/lang/Exception")},M11459));
c.Add(new JMethod(11460,"forge/item/generation/BoosterGenerator","bulkSlotReplacement","(Lforge/item/BoosterSlot;I)Ljava/util/Map;",10,2,3,new JHandler[]{},M11460));
c.Add(new JMethod(11461,"forge/item/generation/BoosterGenerator","ensureGuaranteedCardInBooster","(Ljava/util/List;Lforge/item/SealedTemplate;Ljava/lang/String;)V",10,20,2,new JHandler[]{},M11461));
c.Add(new JMethod(11462,"forge/item/generation/BoosterGenerator","replaceCardFromExtraSheet","(Ljava/util/List;Ljava/lang/String;)V",9,4,3,new JHandler[]{},M11462));
c.Add(new JMethod(11463,"forge/item/generation/BoosterGenerator","replaceCard","(Ljava/util/List;Lforge/item/PaperCard;)V",9,6,2,new JHandler[]{},M11463));
c.Add(new JMethod(11464,"forge/item/generation/BoosterGenerator","addCardsFromExtraSheet","(Ljava/util/List;Ljava/lang/String;)V",9,6,2,new JHandler[]{},M11464));
c.Add(new JMethod(11465,"forge/item/generation/BoosterGenerator","makeSheet","(Ljava/lang/String;Ljava/lang/Iterable;)Lforge/card/PrintSheet;",9,16,6,new JHandler[]{},M11465));
c.Add(new JMethod(11466,"forge/item/generation/BoosterGenerator","buildExtraPredicate","(Ljava/util/List;)Ljava/util/function/Predicate;",10,8,4,new JHandler[]{},M11466));
c.Add(new JMethod(11467,"forge/item/generation/BoosterGenerator","lambda$buildExtraPredicate$4","(Lforge/item/PaperCard;)Z",4106,1,1,new JHandler[]{},M11467));
c.Add(new JMethod(11468,"forge/item/generation/BoosterGenerator","lambda$buildExtraPredicate$3","(Lforge/item/PaperCard;)Z",4106,1,2,new JHandler[]{},M11468));
c.Add(new JMethod(11469,"forge/item/generation/BoosterGenerator","lambda$makeSheet$2","(Lforge/item/PaperCard;)Z",4106,1,1,new JHandler[]{},M11469));
c.Add(new JMethod(11470,"forge/item/generation/BoosterGenerator","lambda$makeSheet$1","(Lforge/item/PaperCard;)Z",4106,1,1,new JHandler[]{},M11470));
c.Add(new JMethod(11471,"forge/item/generation/BoosterGenerator","lambda$makeSheet$0","(Lforge/item/PaperCard;)Z",4106,1,1,new JHandler[]{},M11471));
c.Add(new JMethod(11472,"forge/item/generation/BoosterGenerator","<clinit>","()V",8,0,3,new JHandler[]{},M11472));
}

internal static JStep M11449(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11450(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator","cachedSheets","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/generation/BoosterGenerator","cachedSheets","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int!=0?35:12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator","cachedSheets","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/generation/BoosterGenerator","cachedSheets","Ljava/util/Map;"));f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",20);}
case 20:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",23);}
case 23:{return rt.Call(f,"forge/card/CardDb","getAllCards","()Ljava/util/Collection;","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/item/generation/BoosterGenerator","makeSheet","(Ljava/lang/String;Ljava/lang/Iterable;)Lforge/card/PrintSheet;","invokestatic",29);}
case 29:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",34);}
case 34:{f.StackOp("pop");f.Pc=35;continue;}
case 35:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator","cachedSheets","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/generation/BoosterGenerator","cachedSheets","Ljava/util/Map;"));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",44);}
case 44:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/PrintSheet"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=47;continue;}
case 47:{return rt.Call(f,"forge/item/generation/BoosterGenerator","applyExclusions","(Lforge/card/PrintSheet;)Lforge/card/PrintSheet;","invokestatic",50);}
case 50:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11451(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference!=null?6:4;continue;}
case 4:{f.Push(JValue.R(null));f.Pc=5;continue;}
case 5:{return JStep.Return(f.Pop());}
case 6:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator","EXCLUDED_NAMES","Ljava/lang/ThreadLocal;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/generation/BoosterGenerator","EXCLUDED_NAMES","Ljava/lang/ThreadLocal;"));f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/lang/ThreadLocal","get","()Ljava/lang/Object;","invokevirtual",12);}
case 12:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=15;continue;}
case 15:{f.Locals[1]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[1]);f.Pc=17;continue;}
case 17:{f.Pc=f.Pop().Reference==null?29:20;continue;}
case 20:{f.Push(f.Locals[1]);f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/Collection","isEmpty","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?31:29;continue;}
case 29:{f.Push(f.Locals[0]);f.Pc=30;continue;}
case 30:{return JStep.Return(f.Pop());}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[1]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/card/PrintSheet","copyWithoutNames","(Ljava/util/Collection;)Lforge/card/PrintSheet;","invokevirtual",36);}
case 36:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11452(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(1));f.Pc=2;continue;}
case 2:{f.Push(JValue.I(1));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/card/PrintSheet","random","(IZ)Ljava/util/List;","invokevirtual",6);}
case 6:{f.Locals[1]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",13);}
case 13:{f.Pc=f.Pop().Int==0?18:16;continue;}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{return JStep.Return(f.Pop());}
case 18:{f.Push(f.Locals[1]);f.Pc=19;continue;}
case 19:{f.Push(JValue.I(0));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",25);}
case 25:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=28;continue;}
case 28:{return rt.Call(f,"forge/item/PaperCard","getFoiled","()Lforge/item/PaperCard;","invokevirtual",31);}
case 31:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11453(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?13:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",10);}
case 10:{f.Pc=f.Pop().Int==0?15:13;continue;}
case 13:{f.Push(JValue.R(null));f.Pc=14;continue;}
case 14:{return JStep.Return(f.Pop());}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",19);}
case 19:{return rt.Call(f,"java/util/Collections","shuffle","(Ljava/util/List;Ljava/util/Random;)V","invokestatic",22);}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",29);}
case 29:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=32;continue;}
case 32:{f.Locals[1]=f.Pop();f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"forge/item/PaperCard","getFoiled","()Lforge/item/PaperCard;","invokevirtual",37);}
case 37:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11454(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Pc=f.Pop().Reference==null?12:4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",11);}
case 11:{f.StackOp("pop");f.Pc=12;continue;}
case 12:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11455(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator","staticSheetsCorrespondance","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/generation/BoosterGenerator","staticSheetsCorrespondance","Ljava/util/Map;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",9);}
case 9:{f.Pc=f.Pop().Int==0?44:12;continue;}
case 12:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",15);}
case 15:{return rt.Call(f,"forge/StaticData","getPrintSheets","()Lforge/util/storage/IStorage;","invokevirtual",18);}
case 18:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator","staticSheetsCorrespondance","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/generation/BoosterGenerator","staticSheetsCorrespondance","Ljava/util/Map;"));f.Pc=21;continue;}
case 21:{f.Push(f.Locals[0]);f.Pc=22;continue;}
case 22:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",27);}
case 27:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=30;continue;}
case 30:{return rt.Call(f,"forge/util/storage/IStorage","get","(Ljava/lang/String;)Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/PrintSheet"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[1]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[1]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/item/generation/BoosterGenerator","applyExclusions","(Lforge/card/PrintSheet;)Lforge/card/PrintSheet;","invokestatic",43);}
case 43:{return JStep.Return(f.Pop());}
case 44:{f.Push(f.Locals[0]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String(" ")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",50);}
case 50:{f.Push(JValue.I(0));f.Pc=51;continue;}
case 51:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=52;continue;}
case 52:{f.Locals[2]=f.Pop();f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",56);}
case 56:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",59);}
case 59:{f.Push(f.Locals[2]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",63);}
case 63:{f.Locals[3]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[3]);f.Pc=65;continue;}
case 65:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",68);}
case 68:{f.Push(f.Locals[2]);f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",72);}
case 72:{f.Pc=f.Pop().Int==0?107:75;continue;}
case 75:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator","staticSheetsCorrespondance","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/generation/BoosterGenerator","staticSheetsCorrespondance","Ljava/util/Map;"));f.Pc=78;continue;}
case 78:{f.Push(f.Locals[0]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[0]);f.Pc=80;continue;}
case 80:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",85);}
case 85:{f.StackOp("pop");f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",89);}
case 89:{return rt.Call(f,"forge/StaticData","getPrintSheets","()Lforge/util/storage/IStorage;","invokevirtual",92);}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{return rt.Call(f,"forge/util/storage/IStorage","get","(Ljava/lang/String;)Ljava/lang/Object;","invokeinterface",98);}
case 98:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/PrintSheet"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=101;continue;}
case 101:{f.Locals[1]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[1]);f.Pc=103;continue;}
case 103:{return rt.Call(f,"forge/item/generation/BoosterGenerator","applyExclusions","(Lforge/card/PrintSheet;)Lforge/card/PrintSheet;","invokestatic",106);}
case 106:{return JStep.Return(f.Pop());}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{return rt.Call(f,"forge/card/CardEdition","getCode","()Ljava/lang/String;","invokevirtual",111);}
case 111:{f.Locals[4]=f.Pop();f.Pc=113;continue;}
case 113:{f.Push(f.Locals[0]);f.Pc=114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[4]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/lang/String","replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokevirtual",120);}
case 120:{f.Locals[5]=f.Pop();f.Pc=122;continue;}
case 122:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator","staticSheetsCorrespondance","Ljava/util/Map;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/generation/BoosterGenerator","staticSheetsCorrespondance","Ljava/util/Map;"));f.Pc=125;continue;}
case 125:{f.Push(f.Locals[0]);f.Pc=126;continue;}
case 126:{f.Push(f.Locals[5]);f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/util/Map","put","(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",133);}
case 133:{f.StackOp("pop");f.Pc=134;continue;}
case 134:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",137);}
case 137:{return rt.Call(f,"forge/StaticData","getPrintSheets","()Lforge/util/storage/IStorage;","invokevirtual",140);}
case 140:{f.Push(f.Locals[5]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/util/storage/IStorage","get","(Ljava/lang/String;)Ljava/lang/Object;","invokeinterface",147);}
case 147:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/card/PrintSheet"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=150;continue;}
case 150:{f.Locals[1]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(f.Locals[1]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"forge/item/generation/BoosterGenerator","applyExclusions","(Lforge/card/PrintSheet;)Lforge/card/PrintSheet;","invokestatic",155);}
case 155:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11456(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.R(null));f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/item/generation/BoosterGenerator","getBoosterPack","(Lforge/item/SealedTemplate;Ljava/util/Collection;)Ljava/util/List;","invokestatic",5);}
case 5:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11457(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator","EXCLUDED_NAMES","Ljava/lang/ThreadLocal;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/generation/BoosterGenerator","EXCLUDED_NAMES","Ljava/lang/ThreadLocal;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/ThreadLocal","get","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Collection"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{f.Locals[2]=f.Pop();f.Pc=10;continue;}
case 10:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator","EXCLUDED_NAMES","Ljava/lang/ThreadLocal;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/generation/BoosterGenerator","EXCLUDED_NAMES","Ljava/lang/ThreadLocal;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/lang/ThreadLocal","set","(Ljava/lang/Object;)V","invokevirtual",17);}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/item/generation/BoosterGenerator","getBoosterPackInternal","(Lforge/item/SealedTemplate;)Ljava/util/List;","invokestatic",21);}
case 21:{f.Locals[3]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Reference!=null?35:26;continue;}
case 26:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator","EXCLUDED_NAMES","Ljava/lang/ThreadLocal;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/generation/BoosterGenerator","EXCLUDED_NAMES","Ljava/lang/ThreadLocal;"));f.Pc=29;continue;}
case 29:{return rt.Call(f,"java/lang/ThreadLocal","remove","()V","invokevirtual",32);}
case 32:{f.Pc=42;continue;}
case 35:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator","EXCLUDED_NAMES","Ljava/lang/ThreadLocal;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/generation/BoosterGenerator","EXCLUDED_NAMES","Ljava/lang/ThreadLocal;"));f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/ThreadLocal","set","(Ljava/lang/Object;)V","invokevirtual",42);}
case 42:{f.Push(f.Locals[3]);f.Pc=43;continue;}
case 43:{return JStep.Return(f.Pop());}
case 44:{f.Locals[4]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Pc=f.Pop().Reference!=null?59:50;continue;}
case 50:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator","EXCLUDED_NAMES","Ljava/lang/ThreadLocal;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/generation/BoosterGenerator","EXCLUDED_NAMES","Ljava/lang/ThreadLocal;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/ThreadLocal","remove","()V","invokevirtual",56);}
case 56:{f.Pc=66;continue;}
case 59:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator","EXCLUDED_NAMES","Ljava/lang/ThreadLocal;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/generation/BoosterGenerator","EXCLUDED_NAMES","Ljava/lang/ThreadLocal;"));f.Pc=62;continue;}
case 62:{f.Push(f.Locals[2]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/ThreadLocal","set","(Ljava/lang/Object;)V","invokevirtual",66);}
case 66:{f.Push(f.Locals[4]);f.Pc=68;continue;}
case 68:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11458(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(rt.IsInstance(f.Pop().Reference,"forge/item/SealedTemplateWithSlots")?1:0));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int==0?17:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/SealedTemplateWithSlots"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=11;continue;}
case 11:{f.Locals[1]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/item/generation/BoosterGenerator","getBoosterPack","(Lforge/item/SealedTemplateWithSlots;)Ljava/util/List;","invokestatic",16);}
case 16:{return JStep.Return(f.Pop());}
case 17:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=20;continue;}
case 20:{f.StackOp("dup");f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",24);}
case 24:{f.Locals[1]=f.Pop();f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",28);}
case 28:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",31);}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/item/SealedTemplate","getEdition","()Ljava/lang/String;","invokevirtual",35);}
case 35:{return rt.Call(f,"forge/card/CardEdition$Collection","get","(Ljava/lang/String;)Lforge/card/CardEdition;","invokevirtual",38);}
case 38:{f.Locals[2]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[2]);f.Pc=40;continue;}
case 40:{f.Pc=f.Pop().Reference==null?83:43;continue;}
case 43:{f.Push(f.Locals[0]);f.Pc=44;continue;}
case 44:{return rt.Call(f,"forge/item/SealedTemplate","getSlots","()Ljava/util/List;","invokevirtual",47);}
case 47:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",52);}
case 52:{f.Pc=f.Pop().Int!=0?83:55;continue;}
case 55:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",58);}
case 58:{return rt.Call(f,"java/util/Random","nextDouble","()D","invokevirtual",61);}
case 61:{f.Push(f.Locals[2]);f.Pc=62;continue;}
case 62:{return rt.Call(f,"forge/card/CardEdition","getFoilChanceInBooster","()D","invokevirtual",65);}
case 65:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"dcmpg",a,b));f.Pc=66;continue;}
case 66:{f.Pc=f.Pop().Int>=0?83:69;continue;}
case 69:{f.Push(f.Locals[2]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/card/CardEdition","getFoilType","()Lforge/card/CardEdition$FoilType;","invokevirtual",73);}
case 73:{if(!rt.StaticReady(f,"forge/card/CardEdition$FoilType","NOT_SUPPORTED","Lforge/card/CardEdition$FoilType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardEdition$FoilType","NOT_SUPPORTED","Lforge/card/CardEdition$FoilType;"));f.Pc=76;continue;}
case 76:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?83:79;continue;}
case 79:{f.Push(JValue.I(1));f.Pc=80;continue;}
case 80:{f.Pc=84;continue;}
case 83:{f.Push(JValue.I(0));f.Pc=84;continue;}
case 84:{f.Locals[3]=f.Pop();f.Pc=85;continue;}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{f.Pc=f.Pop().Int==0?100:89;continue;}
case 89:{f.Push(f.Locals[2]);f.Pc=90;continue;}
case 90:{return rt.Call(f,"forge/card/CardEdition","getFoilAlwaysInCommonSlot","()Z","invokevirtual",93);}
case 93:{f.Pc=f.Pop().Int==0?100:96;continue;}
case 96:{f.Push(JValue.I(1));f.Pc=97;continue;}
case 97:{f.Pc=101;continue;}
case 100:{f.Push(JValue.I(0));f.Pc=101;continue;}
case 101:{f.Locals[4]=f.Pop();f.Pc=103;continue;}
case 103:{if(!rt.StaticReady(f,"forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"));f.Pc=106;continue;}
case 106:{f.Locals[5]=f.Pop();f.Pc=108;continue;}
case 108:{f.Push(f.Locals[5]);f.Pc=110;continue;}
case 110:{if(!rt.StaticReady(f,"forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Unknown","Lforge/card/CardRarity;"));f.Pc=113;continue;}
case 113:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=!ReferenceEquals(a,b)?334:116;continue;}
case 116:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",119);}
case 119:{f.Push(JValue.I(10));f.Pc=121;continue;}
case 121:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",124);}
case 124:{f.Push(JValue.I(1));f.Pc=125;continue;}
case 125:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=126;continue;}
case 126:{f.Locals[6]=f.Pop();f.Pc=128;continue;}
case 128:{f.Push(f.Locals[6]);f.Pc=130;continue;}
case 130:{switch(f.Pop().Int){case 1:f.Pc=184;break;case 2:f.Pc=192;break;case 3:f.Pc=192;break;case 4:f.Pc=200;break;case 5:f.Pc=200;break;case 6:f.Pc=200;break;case 7:f.Pc=208;break;case 8:f.Pc=232;break;case 9:f.Pc=269;break;case 10:f.Pc=290;break;default:f.Pc=326;break;}continue;}
case 184:{if(!rt.StaticReady(f,"forge/card/CardRarity","Rare","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Rare","Lforge/card/CardRarity;"));f.Pc=187;continue;}
case 187:{f.Locals[5]=f.Pop();f.Pc=189;continue;}
case 189:{f.Pc=331;continue;}
case 192:{if(!rt.StaticReady(f,"forge/card/CardRarity","Uncommon","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Uncommon","Lforge/card/CardRarity;"));f.Pc=195;continue;}
case 195:{f.Locals[5]=f.Pop();f.Pc=197;continue;}
case 197:{f.Pc=331;continue;}
case 200:{if(!rt.StaticReady(f,"forge/card/CardRarity","Common","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Common","Lforge/card/CardRarity;"));f.Pc=203;continue;}
case 203:{f.Locals[5]=f.Pop();f.Pc=205;continue;}
case 205:{f.Pc=331;continue;}
case 208:{f.Push(f.Locals[2]);f.Pc=209;continue;}
case 209:{f.Pc=f.Pop().Reference==null?331:212;continue;}
case 212:{f.Push(f.Locals[2]);f.Pc=213;continue;}
case 213:{return rt.Call(f,"forge/card/CardEdition","getName","()Ljava/lang/String;","invokevirtual",216);}
case 216:{f.Push(JValue.R(rt.String("Time Spiral")));f.Pc=218;continue;}
case 218:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",221);}
case 221:{f.Pc=f.Pop().Int==0?331:224;continue;}
case 224:{if(!rt.StaticReady(f,"forge/card/CardRarity","Special","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Special","Lforge/card/CardRarity;"));f.Pc=227;continue;}
case 227:{f.Locals[5]=f.Pop();f.Pc=229;continue;}
case 229:{f.Pc=331;continue;}
case 232:{f.Push(f.Locals[2]);f.Pc=233;continue;}
case 233:{f.Pc=f.Pop().Reference==null?331:236;continue;}
case 236:{f.Push(f.Locals[2]);f.Pc=237;continue;}
case 237:{return rt.Call(f,"forge/card/CardEdition","getName","()Ljava/lang/String;","invokevirtual",240);}
case 240:{f.Push(JValue.R(rt.String("Vintage Masters")));f.Pc=242;continue;}
case 242:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",245);}
case 245:{f.Pc=f.Pop().Int==0?331:248;continue;}
case 248:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",251);}
case 251:{f.Push(JValue.I(53));f.Pc=253;continue;}
case 253:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",256);}
case 256:{f.Push(JValue.I(7));f.Pc=258;continue;}
case 258:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?331:261;continue;}
case 261:{if(!rt.StaticReady(f,"forge/card/CardRarity","Special","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Special","Lforge/card/CardRarity;"));f.Pc=264;continue;}
case 264:{f.Locals[5]=f.Pop();f.Pc=266;continue;}
case 266:{f.Pc=331;continue;}
case 269:{f.Push(f.Locals[2]);f.Pc=270;continue;}
case 270:{f.Pc=f.Pop().Reference==null?331:273;continue;}
case 273:{f.Push(f.Locals[0]);f.Pc=274;continue;}
case 274:{f.Push(JValue.R(rt.String("dfc")));f.Pc=276;continue;}
case 276:{return rt.Call(f,"forge/item/SealedTemplate","hasSlot","(Ljava/lang/String;)Z","invokevirtual",279);}
case 279:{f.Pc=f.Pop().Int==0?331:282;continue;}
case 282:{if(!rt.StaticReady(f,"forge/card/CardRarity","Special","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Special","Lforge/card/CardRarity;"));f.Pc=285;continue;}
case 285:{f.Locals[5]=f.Pop();f.Pc=287;continue;}
case 287:{f.Pc=331;continue;}
case 290:{f.Push(f.Locals[2]);f.Pc=291;continue;}
case 291:{f.Pc=f.Pop().Reference==null?331:294;continue;}
case 294:{f.Push(f.Locals[2]);f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/card/CardEdition","getName","()Ljava/lang/String;","invokevirtual",298);}
case 298:{f.Push(JValue.R(rt.String("Planeshift")));f.Pc=300;continue;}
case 300:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",303);}
case 303:{f.Pc=f.Pop().Int==0?331:306;continue;}
case 306:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",309);}
case 309:{f.Push(JValue.I(53));f.Pc=311;continue;}
case 311:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",314);}
case 314:{f.Push(JValue.I(3));f.Pc=315;continue;}
case 315:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?331:318;continue;}
case 318:{if(!rt.StaticReady(f,"forge/card/CardRarity","Special","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Special","Lforge/card/CardRarity;"));f.Pc=321;continue;}
case 321:{f.Locals[5]=f.Pop();f.Pc=323;continue;}
case 323:{f.Pc=331;continue;}
case 326:{if(!rt.StaticReady(f,"forge/card/CardRarity","Common","Lforge/card/CardRarity;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardRarity","Common","Lforge/card/CardRarity;"));f.Pc=329;continue;}
case 329:{f.Locals[5]=f.Pop();f.Pc=331;continue;}
case 331:{f.Pc=108;continue;}
case 334:{f.Push(f.Locals[2]);f.Pc=335;continue;}
case 335:{f.Pc=f.Pop().Reference==null?345:338;continue;}
case 338:{f.Push(f.Locals[2]);f.Pc=339;continue;}
case 339:{return rt.Call(f,"forge/card/CardEdition","getAdditionalSheetForFoils","()Ljava/lang/String;","invokevirtual",342);}
case 342:{f.Pc=347;continue;}
case 345:{f.Push(JValue.R(rt.String("")));f.Pc=347;continue;}
case 347:{f.Locals[6]=f.Pop();f.Pc=349;continue;}
case 349:{f.Push(f.Locals[2]);f.Pc=350;continue;}
case 350:{f.Pc=f.Pop().Reference==null?383:353;continue;}
case 353:{f.Push(f.Locals[0]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/item/SealedTemplate","getSlots","()Ljava/util/List;","invokevirtual",357);}
case 357:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",362);}
case 362:{f.Pc=f.Pop().Int!=0?383:365;continue;}
case 365:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",368);}
case 368:{return rt.Call(f,"java/util/Random","nextDouble","()D","invokevirtual",371);}
case 371:{f.Push(f.Locals[2]);f.Pc=372;continue;}
case 372:{return rt.Call(f,"forge/card/CardEdition","getChanceReplaceCommonWith","()D","invokevirtual",375);}
case 375:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"dcmpg",a,b));f.Pc=376;continue;}
case 376:{f.Pc=f.Pop().Int>=0?383:379;continue;}
case 379:{f.Push(JValue.I(1));f.Pc=380;continue;}
case 380:{f.Pc=384;continue;}
case 383:{f.Push(JValue.I(0));f.Pc=384;continue;}
case 384:{f.Locals[7]=f.Pop();f.Pc=386;continue;}
case 386:{f.Push(JValue.R(rt.String("")));f.Pc=388;continue;}
case 388:{f.Locals[8]=f.Pop();f.Pc=390;continue;}
case 390:{f.Push(f.Locals[3]);f.Pc=391;continue;}
case 391:{f.Pc=f.Pop().Int==0?639:394;continue;}
case 394:{f.Push(f.Locals[0]);f.Pc=395;continue;}
case 395:{return rt.Call(f,"forge/item/SealedTemplate","getSlots","()Ljava/util/List;","invokevirtual",398);}
case 398:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",401);}
case 401:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=404;continue;}
case 404:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",407);}
case 407:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=410;continue;}
case 410:{f.Push(JValue.R(rt.String("[ :!]")));f.Pc=412;continue;}
case 412:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",415);}
case 415:{f.Push(JValue.I(0));f.Pc=416;continue;}
case 416:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=417;continue;}
case 417:{f.Locals[8]=f.Pop();f.Pc=419;continue;}
case 419:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator$1","$SwitchMap$forge$card$CardRarity","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/generation/BoosterGenerator$1","$SwitchMap$forge$card$CardRarity","[I"));f.Pc=422;continue;}
case 422:{f.Push(f.Locals[5]);f.Pc=424;continue;}
case 424:{return rt.Call(f,"forge/card/CardRarity","ordinal","()I","invokevirtual",427);}
case 427:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=428;continue;}
case 428:{switch(f.Pop().Int){case 1:f.Pc=460;break;case 2:f.Pc=514;break;case 3:f.Pc=550;break;case 4:f.Pc=587;break;default:f.Pc=639;break;}continue;}
case 460:{f.Push(f.Locals[0]);f.Pc=461;continue;}
case 461:{f.Push(JValue.R(rt.String("RareMythic")));f.Pc=464;continue;}
case 464:{return rt.Call(f,"forge/item/SealedTemplate","hasSlot","(Ljava/lang/String;)Z","invokevirtual",467);}
case 467:{f.Pc=f.Pop().Int==0?478:470;continue;}
case 470:{f.Push(JValue.R(rt.String("RareMythic")));f.Pc=473;continue;}
case 473:{f.Locals[8]=f.Pop();f.Pc=475;continue;}
case 475:{f.Pc=639;continue;}
case 478:{f.Push(f.Locals[0]);f.Pc=479;continue;}
case 479:{f.Push(JValue.R(rt.String("Rare")));f.Pc=482;continue;}
case 482:{return rt.Call(f,"forge/item/SealedTemplate","hasSlot","(Ljava/lang/String;)Z","invokevirtual",485);}
case 485:{f.Pc=f.Pop().Int==0?496:488;continue;}
case 488:{f.Push(JValue.R(rt.String("Rare")));f.Pc=491;continue;}
case 491:{f.Locals[8]=f.Pop();f.Pc=493;continue;}
case 493:{f.Pc=639;continue;}
case 496:{f.Push(f.Locals[0]);f.Pc=497;continue;}
case 497:{f.Push(JValue.R(rt.String("UncommonRare")));f.Pc=500;continue;}
case 500:{return rt.Call(f,"forge/item/SealedTemplate","hasSlot","(Ljava/lang/String;)Z","invokevirtual",503);}
case 503:{f.Pc=f.Pop().Int==0?639:506;continue;}
case 506:{f.Push(JValue.R(rt.String("UncommonRare")));f.Pc=509;continue;}
case 509:{f.Locals[8]=f.Pop();f.Pc=511;continue;}
case 511:{f.Pc=639;continue;}
case 514:{f.Push(f.Locals[0]);f.Pc=515;continue;}
case 515:{f.Push(JValue.R(rt.String("Uncommon")));f.Pc=518;continue;}
case 518:{return rt.Call(f,"forge/item/SealedTemplate","hasSlot","(Ljava/lang/String;)Z","invokevirtual",521);}
case 521:{f.Pc=f.Pop().Int==0?532:524;continue;}
case 524:{f.Push(JValue.R(rt.String("Uncommon")));f.Pc=527;continue;}
case 527:{f.Locals[8]=f.Pop();f.Pc=529;continue;}
case 529:{f.Pc=639;continue;}
case 532:{f.Push(f.Locals[0]);f.Pc=533;continue;}
case 533:{f.Push(JValue.R(rt.String("UncommonRare")));f.Pc=536;continue;}
case 536:{return rt.Call(f,"forge/item/SealedTemplate","hasSlot","(Ljava/lang/String;)Z","invokevirtual",539);}
case 539:{f.Pc=f.Pop().Int==0?639:542;continue;}
case 542:{f.Push(JValue.R(rt.String("UncommonRare")));f.Pc=545;continue;}
case 545:{f.Locals[8]=f.Pop();f.Pc=547;continue;}
case 547:{f.Pc=639;continue;}
case 550:{f.Push(JValue.R(rt.String("Common")));f.Pc=553;continue;}
case 553:{f.Locals[8]=f.Pop();f.Pc=555;continue;}
case 555:{f.Push(f.Locals[0]);f.Pc=556;continue;}
case 556:{f.Push(JValue.R(rt.String("BasicLand")));f.Pc=559;continue;}
case 559:{return rt.Call(f,"forge/item/SealedTemplate","hasSlot","(Ljava/lang/String;)Z","invokevirtual",562);}
case 562:{f.Pc=f.Pop().Int==0?639:565;continue;}
case 565:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",568);}
case 568:{f.Push(JValue.I(130));f.Pc=571;continue;}
case 571:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",574);}
case 574:{f.Push(JValue.I(20));f.Pc=576;continue;}
case 576:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?639:579;continue;}
case 579:{f.Push(JValue.R(rt.String("BasicLand")));f.Pc=582;continue;}
case 582:{f.Locals[8]=f.Pop();f.Pc=584;continue;}
case 584:{f.Pc=639;continue;}
case 587:{f.Push(f.Locals[0]);f.Pc=588;continue;}
case 588:{f.Push(JValue.R(rt.String("TimeShifted")));f.Pc=591;continue;}
case 591:{return rt.Call(f,"forge/item/SealedTemplate","hasSlot","(Ljava/lang/String;)Z","invokevirtual",594);}
case 594:{f.Pc=f.Pop().Int==0?605:597;continue;}
case 597:{f.Push(JValue.R(rt.String("TimeShifted")));f.Pc=600;continue;}
case 600:{f.Locals[8]=f.Pop();f.Pc=602;continue;}
case 602:{f.Pc=639;continue;}
case 605:{f.Push(f.Locals[0]);f.Pc=606;continue;}
case 606:{f.Push(JValue.R(rt.String("dfc")));f.Pc=608;continue;}
case 608:{return rt.Call(f,"forge/item/SealedTemplate","hasSlot","(Ljava/lang/String;)Z","invokevirtual",611);}
case 611:{f.Pc=f.Pop().Int==0?621:614;continue;}
case 614:{f.Push(JValue.R(rt.String("dfc")));f.Pc=616;continue;}
case 616:{f.Locals[8]=f.Pop();f.Pc=618;continue;}
case 618:{f.Pc=639;continue;}
case 621:{f.Push(f.Locals[0]);f.Pc=622;continue;}
case 622:{f.Push(JValue.R(rt.String("Special")));f.Pc=625;continue;}
case 625:{return rt.Call(f,"forge/item/SealedTemplate","hasSlot","(Ljava/lang/String;)Z","invokevirtual",628);}
case 628:{f.Pc=f.Pop().Int==0?639:631;continue;}
case 631:{f.Push(JValue.R(rt.String("Special")));f.Pc=634;continue;}
case 634:{f.Locals[8]=f.Pop();f.Pc=636;continue;}
case 636:{f.Pc=639;continue;}
case 639:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=642;continue;}
case 642:{f.StackOp("dup");f.Pc=643;continue;}
case 643:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",646);}
case 646:{f.Locals[9]=f.Pop();f.Pc=648;continue;}
case 648:{f.Push(f.Locals[0]);f.Pc=649;continue;}
case 649:{return rt.Call(f,"forge/item/SealedTemplate","getSlots","()Ljava/util/List;","invokevirtual",652);}
case 652:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",657);}
case 657:{f.Locals[10]=f.Pop();f.Pc=659;continue;}
case 659:{f.Push(f.Locals[10]);f.Pc=661;continue;}
case 661:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",666);}
case 666:{f.Pc=f.Pop().Int==0?1423:669;continue;}
case 669:{f.Push(f.Locals[10]);f.Pc=671;continue;}
case 671:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",676);}
case 676:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=679;continue;}
case 679:{f.Locals[11]=f.Pop();f.Pc=681;continue;}
case 681:{f.Push(f.Locals[11]);f.Pc=683;continue;}
case 683:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",686);}
case 686:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=689;continue;}
case 689:{f.Locals[12]=f.Pop();f.Pc=691;continue;}
case 691:{f.Push(f.Locals[11]);f.Pc=693;continue;}
case 693:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",696);}
case 696:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=699;continue;}
case 699:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",702);}
case 702:{f.Locals[13]=f.Pop();f.Pc=704;continue;}
case 704:{f.Push(f.Locals[12]);f.Pc=706;continue;}
case 706:{f.Push(JValue.R(rt.String("+")));f.Pc=709;continue;}
case 709:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",712);}
case 712:{f.Locals[14]=f.Pop();f.Pc=714;continue;}
case 714:{f.Push(f.Locals[14]);f.Pc=716;continue;}
case 716:{f.Pc=f.Pop().Int==0?734:719;continue;}
case 719:{f.Push(f.Locals[12]);f.Pc=721;continue;}
case 721:{f.Push(JValue.I(0));f.Pc=722;continue;}
case 722:{f.Push(f.Locals[12]);f.Pc=724;continue;}
case 724:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",727);}
case 727:{f.Push(JValue.I(1));f.Pc=728;continue;}
case 728:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=729;continue;}
case 729:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",732);}
case 732:{f.Locals[12]=f.Pop();f.Pc=734;continue;}
case 734:{f.Push(f.Locals[12]);f.Pc=736;continue;}
case 736:{f.Push(JValue.I(32));f.Pc=738;continue;}
case 738:{return rt.Call(f,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;C)[Ljava/lang/String;","invokestatic",741);}
case 741:{f.Locals[15]=f.Pop();f.Pc=743;continue;}
case 743:{f.Push(f.Locals[15]);f.Pc=745;continue;}
case 745:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=746;continue;}
case 746:{f.Push(JValue.I(1));f.Pc=747;continue;}
case 747:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?764:750;continue;}
case 750:{f.Push(f.Locals[0]);f.Pc=751;continue;}
case 751:{return rt.Call(f,"forge/item/SealedTemplate","getEdition","()Ljava/lang/String;","invokevirtual",754);}
case 754:{f.Pc=f.Pop().Reference==null?764:757;continue;}
case 757:{f.Push(f.Locals[0]);f.Pc=758;continue;}
case 758:{return rt.Call(f,"forge/item/SealedTemplate","getEdition","()Ljava/lang/String;","invokevirtual",761);}
case 761:{f.Pc=765;continue;}
case 764:{f.Push(JValue.R(null));f.Pc=765;continue;}
case 765:{f.Locals[16]=f.Pop();f.Pc=767;continue;}
case 767:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",770);}
case 770:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",773);}
case 773:{f.Push(f.Locals[16]);f.Pc=775;continue;}
case 775:{return rt.Call(f,"forge/card/CardEdition$Collection","contains","(Ljava/lang/String;)Z","invokevirtual",778);}
case 778:{f.Pc=f.Pop().Int==0?796:781;continue;}
case 781:{f.Push(f.Locals[12]);f.Pc=783;continue;}
case 783:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",786);}
case 786:{f.Push(f.Locals[16]);f.Pc=788;continue;}
case 788:{return rt.DynamicCall(f,"forge/item/generation/BoosterGenerator:11458:788:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",793);}
case 793:{f.Pc=801;continue;}
case 796:{f.Push(f.Locals[12]);f.Pc=798;continue;}
case 798:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",801);}
case 801:{f.Locals[17]=f.Pop();f.Pc=803;continue;}
case 803:{f.Push(f.Locals[17]);f.Pc=805;continue;}
case 805:{f.Push(JValue.R(rt.String("wholeSheet")));f.Pc=808;continue;}
case 808:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",811);}
case 811:{f.Pc=f.Pop().Int==0?836:814;continue;}
case 814:{f.Push(f.Locals[17]);f.Pc=816;continue;}
case 816:{return rt.Call(f,"forge/item/generation/BoosterGenerator","getPrintSheet","(Ljava/lang/String;)Lforge/card/PrintSheet;","invokestatic",819);}
case 819:{f.Locals[18]=f.Pop();f.Pc=821;continue;}
case 821:{f.Push(f.Locals[1]);f.Pc=822;continue;}
case 822:{f.Push(f.Locals[18]);f.Pc=824;continue;}
case 824:{return rt.Call(f,"forge/card/PrintSheet","toFlatList","()Ljava/util/List;","invokevirtual",827);}
case 827:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",832);}
case 832:{f.StackOp("pop");f.Pc=833;continue;}
case 833:{f.Pc=659;continue;}
case 836:{f.Push(f.Locals[12]);f.Pc=838;continue;}
case 838:{f.Push(JValue.R(rt.String("[ :!]")));f.Pc=840;continue;}
case 840:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",843);}
case 843:{f.Push(JValue.I(0));f.Pc=844;continue;}
case 844:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=845;continue;}
case 845:{f.Locals[12]=f.Pop();f.Pc=847;continue;}
case 847:{f.Push(f.Locals[3]);f.Pc=848;continue;}
case 848:{f.Pc=f.Pop().Int==0?865:851;continue;}
case 851:{f.Push(f.Locals[12]);f.Pc=853;continue;}
case 853:{f.Push(f.Locals[8]);f.Pc=855;continue;}
case 855:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",858);}
case 858:{f.Pc=f.Pop().Int==0?865:861;continue;}
case 861:{f.Push(JValue.I(1));f.Pc=862;continue;}
case 862:{f.Pc=866;continue;}
case 865:{f.Push(JValue.I(0));f.Pc=866;continue;}
case 866:{f.Locals[18]=f.Pop();f.Pc=868;continue;}
case 868:{f.Push(f.Locals[4]);f.Pc=870;continue;}
case 870:{f.Pc=f.Pop().Int!=0?878:873;continue;}
case 873:{f.Push(f.Locals[18]);f.Pc=875;continue;}
case 875:{f.Pc=f.Pop().Int!=0?898:878;continue;}
case 878:{f.Push(f.Locals[4]);f.Pc=880;continue;}
case 880:{f.Pc=f.Pop().Int==0?901:883;continue;}
case 883:{f.Push(f.Locals[3]);f.Pc=884;continue;}
case 884:{f.Pc=f.Pop().Int==0?901:887;continue;}
case 887:{f.Push(f.Locals[12]);f.Pc=889;continue;}
case 889:{f.Push(JValue.R(rt.String("Common")));f.Pc=892;continue;}
case 892:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",895);}
case 895:{f.Pc=f.Pop().Int==0?901:898;continue;}
case 898:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(-1)));f.Pc=901;continue;}
case 901:{f.Push(f.Locals[2]);f.Pc=902;continue;}
case 902:{f.Pc=f.Pop().Reference==null?942:905;continue;}
case 905:{f.Push(f.Locals[2]);f.Pc=906;continue;}
case 906:{return rt.Call(f,"forge/card/CardEdition","getName","()Ljava/lang/String;","invokevirtual",909);}
case 909:{f.Push(JValue.R(rt.String("Planeshift")));f.Pc=911;continue;}
case 911:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",914);}
case 914:{f.Pc=f.Pop().Int==0?942:917;continue;}
case 917:{f.Push(f.Locals[12]);f.Pc=919;continue;}
case 919:{f.Push(JValue.R(rt.String("Rare")));f.Pc=922;continue;}
case 922:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",925);}
case 925:{f.Pc=f.Pop().Int==0?942:928;continue;}
case 928:{f.Push(f.Locals[8]);f.Pc=930;continue;}
case 930:{f.Push(JValue.R(rt.String("Special")));f.Pc=933;continue;}
case 933:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",936);}
case 936:{f.Pc=f.Pop().Int==0?942:939;continue;}
case 939:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(-1)));f.Pc=942;continue;}
case 942:{f.Push(f.Locals[7]);f.Pc=944;continue;}
case 944:{f.Pc=f.Pop().Int==0?1034:947;continue;}
case 947:{f.Push(f.Locals[12]);f.Pc=949;continue;}
case 949:{f.Push(JValue.R(rt.String("Common")));f.Pc=952;continue;}
case 952:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",955);}
case 955:{f.Pc=f.Pop().Int==0?1034:958;continue;}
case 958:{f.Locals[13]=JValue.I(unchecked(f.Locals[13].Int+(-1)));f.Pc=961;continue;}
case 961:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",964);}
case 964:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",967);}
case 967:{f.Push(f.Locals[16]);f.Pc=969;continue;}
case 969:{return rt.Call(f,"forge/card/CardEdition$Collection","contains","(Ljava/lang/String;)Z","invokevirtual",972);}
case 972:{f.Pc=f.Pop().Int==0?992:975;continue;}
case 975:{f.Push(f.Locals[2]);f.Pc=976;continue;}
case 976:{return rt.Call(f,"forge/card/CardEdition","getSlotReplaceCommonWith","()Ljava/lang/String;","invokevirtual",979);}
case 979:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",982);}
case 982:{f.Push(f.Locals[16]);f.Pc=984;continue;}
case 984:{return rt.DynamicCall(f,"forge/item/generation/BoosterGenerator:11458:984:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",989);}
case 989:{f.Pc=999;continue;}
case 992:{f.Push(f.Locals[2]);f.Pc=993;continue;}
case 993:{return rt.Call(f,"forge/card/CardEdition","getSlotReplaceCommonWith","()Ljava/lang/String;","invokevirtual",996);}
case 996:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",999);}
case 999:{f.Locals[19]=f.Pop();f.Pc=1001;continue;}
case 1001:{f.Push(f.Locals[19]);f.Pc=1003;continue;}
case 1003:{return rt.Call(f,"forge/item/generation/BoosterGenerator","getPrintSheet","(Ljava/lang/String;)Lforge/card/PrintSheet;","invokestatic",1006);}
case 1006:{f.Locals[20]=f.Pop();f.Pc=1008;continue;}
case 1008:{f.Push(f.Locals[1]);f.Pc=1009;continue;}
case 1009:{f.Push(f.Locals[20]);f.Pc=1011;continue;}
case 1011:{f.Push(JValue.I(1));f.Pc=1012;continue;}
case 1012:{f.Push(JValue.I(1));f.Pc=1013;continue;}
case 1013:{return rt.Call(f,"forge/card/PrintSheet","random","(IZ)Ljava/util/List;","invokevirtual",1016);}
case 1016:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",1021);}
case 1021:{f.StackOp("pop");f.Pc=1022;continue;}
case 1022:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=1025;continue;}
case 1025:{f.Push(JValue.R(rt.String("Common was replaced with something from the replace sheet...")));f.Pc=1028;continue;}
case 1028:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",1031);}
case 1031:{f.Push(JValue.I(0));f.Pc=1032;continue;}
case 1032:{f.Locals[7]=f.Pop();f.Pc=1034;continue;}
case 1034:{f.Push(f.Locals[17]);f.Pc=1036;continue;}
case 1036:{return rt.Call(f,"forge/item/generation/BoosterGenerator","getPrintSheet","(Ljava/lang/String;)Lforge/card/PrintSheet;","invokestatic",1039);}
case 1039:{f.Locals[19]=f.Pop();f.Pc=1041;continue;}
case 1041:{f.Push(f.Locals[14]);f.Pc=1043;continue;}
case 1043:{f.Pc=f.Pop().Int==0?1107:1046;continue;}
case 1046:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",1049);}
case 1049:{f.Locals[20]=f.Pop();f.Pc=1051;continue;}
case 1051:{f.Push(f.Locals[19]);f.Pc=1053;continue;}
case 1053:{f.Push(f.Locals[13]);f.Pc=1055;continue;}
case 1055:{f.Push(JValue.I(1));f.Pc=1056;continue;}
case 1056:{return rt.Call(f,"forge/card/PrintSheet","random","(IZ)Ljava/util/List;","invokevirtual",1059);}
case 1059:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1064);}
case 1064:{f.Locals[21]=f.Pop();f.Pc=1066;continue;}
case 1066:{f.Push(f.Locals[21]);f.Pc=1068;continue;}
case 1068:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1073);}
case 1073:{f.Pc=f.Pop().Int==0?1104:1076;continue;}
case 1076:{f.Push(f.Locals[21]);f.Pc=1078;continue;}
case 1078:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1083);}
case 1083:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1086;continue;}
case 1086:{f.Locals[22]=f.Pop();f.Pc=1088;continue;}
case 1088:{f.Push(f.Locals[20]);f.Pc=1090;continue;}
case 1090:{f.Push(f.Locals[22]);f.Pc=1092;continue;}
case 1092:{return rt.Call(f,"forge/item/PaperCard","getFoiled","()Lforge/item/PaperCard;","invokevirtual",1095);}
case 1095:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1100);}
case 1100:{f.StackOp("pop");f.Pc=1101;continue;}
case 1101:{f.Pc=1066;continue;}
case 1104:{f.Pc=1117;continue;}
case 1107:{f.Push(f.Locals[19]);f.Pc=1109;continue;}
case 1109:{f.Push(f.Locals[13]);f.Pc=1111;continue;}
case 1111:{f.Push(JValue.I(1));f.Pc=1112;continue;}
case 1112:{return rt.Call(f,"forge/card/PrintSheet","random","(IZ)Ljava/util/List;","invokevirtual",1115);}
case 1115:{f.Locals[20]=f.Pop();f.Pc=1117;continue;}
case 1117:{f.Push(f.Locals[1]);f.Pc=1118;continue;}
case 1118:{f.Push(f.Locals[20]);f.Pc=1120;continue;}
case 1120:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",1125);}
case 1125:{f.StackOp("pop");f.Pc=1126;continue;}
case 1126:{f.Push(f.Locals[18]);f.Pc=1128;continue;}
case 1128:{f.Pc=f.Pop().Int==0?1420:1131;continue;}
case 1131:{f.Push(f.Locals[4]);f.Pc=1133;continue;}
case 1133:{f.Pc=f.Pop().Int!=0?1245:1136;continue;}
case 1136:{f.Push(JValue.I(0));f.Pc=1137;continue;}
case 1137:{f.Locals[3]=f.Pop();f.Pc=1138;continue;}
case 1138:{f.Push(f.Locals[6]);f.Pc=1140;continue;}
case 1140:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",1143);}
case 1143:{f.Pc=f.Pop().Int!=0?1233:1146;continue;}
case 1146:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=1149;continue;}
case 1149:{f.StackOp("dup");f.Pc=1150;continue;}
case 1150:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",1153);}
case 1153:{f.Locals[21]=f.Pop();f.Pc=1155;continue;}
case 1155:{f.Push(f.Locals[19]);f.Pc=1157;continue;}
case 1157:{return rt.Call(f,"forge/card/PrintSheet","toFlatList","()Ljava/util/List;","invokevirtual",1160);}
case 1160:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1165);}
case 1165:{f.Locals[22]=f.Pop();f.Pc=1167;continue;}
case 1167:{f.Push(f.Locals[22]);f.Pc=1169;continue;}
case 1169:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1174);}
case 1174:{f.Pc=f.Pop().Int==0?1214:1177;continue;}
case 1177:{f.Push(f.Locals[22]);f.Pc=1179;continue;}
case 1179:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1184);}
case 1184:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1187;continue;}
case 1187:{f.Locals[23]=f.Pop();f.Pc=1189;continue;}
case 1189:{f.Push(f.Locals[21]);f.Pc=1191;continue;}
case 1191:{f.Push(f.Locals[23]);f.Pc=1193;continue;}
case 1193:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",1198);}
case 1198:{f.Pc=f.Pop().Int!=0?1211:1201;continue;}
case 1201:{f.Push(f.Locals[21]);f.Pc=1203;continue;}
case 1203:{f.Push(f.Locals[23]);f.Pc=1205;continue;}
case 1205:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1210);}
case 1210:{f.StackOp("pop");f.Pc=1211;continue;}
case 1211:{f.Pc=1167;continue;}
case 1214:{f.Push(f.Locals[21]);f.Pc=1216;continue;}
case 1216:{f.Push(f.Locals[6]);f.Pc=1218;continue;}
case 1218:{return rt.Call(f,"forge/item/generation/BoosterGenerator","addCardsFromExtraSheet","(Ljava/util/List;Ljava/lang/String;)V","invokestatic",1221);}
case 1221:{f.Push(f.Locals[1]);f.Pc=1222;continue;}
case 1222:{f.Push(f.Locals[21]);f.Pc=1224;continue;}
case 1224:{return rt.Call(f,"forge/item/generation/BoosterGenerator","generateFoilCard","(Ljava/util/List;)Lforge/item/PaperCard;","invokestatic",1227);}
case 1227:{return rt.Call(f,"forge/item/generation/BoosterGenerator","addFoilIfPresent","(Ljava/util/List;Lforge/item/PaperCard;)V","invokestatic",1230);}
case 1230:{f.Pc=1420;continue;}
case 1233:{f.Push(f.Locals[1]);f.Pc=1234;continue;}
case 1234:{f.Push(f.Locals[19]);f.Pc=1236;continue;}
case 1236:{return rt.Call(f,"forge/item/generation/BoosterGenerator","generateFoilCard","(Lforge/card/PrintSheet;)Lforge/item/PaperCard;","invokestatic",1239);}
case 1239:{return rt.Call(f,"forge/item/generation/BoosterGenerator","addFoilIfPresent","(Ljava/util/List;Lforge/item/PaperCard;)V","invokestatic",1242);}
case 1242:{f.Pc=1420;continue;}
case 1245:{f.Push(f.Locals[6]);f.Pc=1247;continue;}
case 1247:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",1250);}
case 1250:{f.Pc=f.Pop().Int!=0?1341:1253;continue;}
case 1253:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=1256;continue;}
case 1256:{f.StackOp("dup");f.Pc=1257;continue;}
case 1257:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",1260);}
case 1260:{f.Locals[21]=f.Pop();f.Pc=1262;continue;}
case 1262:{f.Push(f.Locals[19]);f.Pc=1264;continue;}
case 1264:{return rt.Call(f,"forge/card/PrintSheet","toFlatList","()Ljava/util/List;","invokevirtual",1267);}
case 1267:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1272);}
case 1272:{f.Locals[22]=f.Pop();f.Pc=1274;continue;}
case 1274:{f.Push(f.Locals[22]);f.Pc=1276;continue;}
case 1276:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1281);}
case 1281:{f.Pc=f.Pop().Int==0?1321:1284;continue;}
case 1284:{f.Push(f.Locals[22]);f.Pc=1286;continue;}
case 1286:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1291);}
case 1291:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1294;continue;}
case 1294:{f.Locals[23]=f.Pop();f.Pc=1296;continue;}
case 1296:{f.Push(f.Locals[21]);f.Pc=1298;continue;}
case 1298:{f.Push(f.Locals[23]);f.Pc=1300;continue;}
case 1300:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",1305);}
case 1305:{f.Pc=f.Pop().Int!=0?1318:1308;continue;}
case 1308:{f.Push(f.Locals[21]);f.Pc=1310;continue;}
case 1310:{f.Push(f.Locals[23]);f.Pc=1312;continue;}
case 1312:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",1317);}
case 1317:{f.StackOp("pop");f.Pc=1318;continue;}
case 1318:{f.Pc=1274;continue;}
case 1321:{f.Push(f.Locals[21]);f.Pc=1323;continue;}
case 1323:{f.Push(f.Locals[6]);f.Pc=1325;continue;}
case 1325:{return rt.Call(f,"forge/item/generation/BoosterGenerator","addCardsFromExtraSheet","(Ljava/util/List;Ljava/lang/String;)V","invokestatic",1328);}
case 1328:{f.Push(f.Locals[9]);f.Pc=1330;continue;}
case 1330:{f.Push(f.Locals[21]);f.Pc=1332;continue;}
case 1332:{return rt.Call(f,"forge/item/generation/BoosterGenerator","generateFoilCard","(Ljava/util/List;)Lforge/item/PaperCard;","invokestatic",1335);}
case 1335:{return rt.Call(f,"forge/item/generation/BoosterGenerator","addFoilIfPresent","(Ljava/util/List;Lforge/item/PaperCard;)V","invokestatic",1338);}
case 1338:{f.Pc=1420;continue;}
case 1341:{f.Push(f.Locals[2]);f.Pc=1342;continue;}
case 1342:{f.Pc=f.Pop().Reference==null?1420:1345;continue;}
case 1345:{f.Push(f.Locals[2]);f.Pc=1346;continue;}
case 1346:{return rt.Call(f,"forge/card/CardEdition","getName","()Ljava/lang/String;","invokevirtual",1349);}
case 1349:{f.Push(JValue.R(rt.String("Vintage Masters")));f.Pc=1351;continue;}
case 1351:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1354);}
case 1354:{f.Pc=f.Pop().Int==0?1410:1357;continue;}
case 1357:{return rt.Call(f,"forge/util/MyRandom","getRandom","()Ljava/util/Random;","invokestatic",1360);}
case 1360:{f.Push(JValue.I(30));f.Pc=1362;continue;}
case 1362:{return rt.Call(f,"java/util/Random","nextInt","(I)I","invokevirtual",1365);}
case 1365:{f.Push(JValue.I(1));f.Pc=1366;continue;}
case 1366:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a==b?1380:1369;continue;}
case 1369:{f.Push(f.Locals[8]);f.Pc=1371;continue;}
case 1371:{f.Push(JValue.R(rt.String("Special")));f.Pc=1374;continue;}
case 1374:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",1377);}
case 1377:{f.Pc=f.Pop().Int!=0?1393:1380;continue;}
case 1380:{f.Push(f.Locals[9]);f.Pc=1382;continue;}
case 1382:{f.Push(f.Locals[19]);f.Pc=1384;continue;}
case 1384:{return rt.Call(f,"forge/item/generation/BoosterGenerator","generateFoilCard","(Lforge/card/PrintSheet;)Lforge/item/PaperCard;","invokestatic",1387);}
case 1387:{return rt.Call(f,"forge/item/generation/BoosterGenerator","addFoilIfPresent","(Ljava/util/List;Lforge/item/PaperCard;)V","invokestatic",1390);}
case 1390:{f.Pc=1420;continue;}
case 1393:{f.Push(f.Locals[1]);f.Pc=1394;continue;}
case 1394:{f.Push(f.Locals[19]);f.Pc=1396;continue;}
case 1396:{f.Push(JValue.I(1));f.Pc=1397;continue;}
case 1397:{f.Push(JValue.I(1));f.Pc=1398;continue;}
case 1398:{return rt.Call(f,"forge/card/PrintSheet","random","(IZ)Ljava/util/List;","invokevirtual",1401);}
case 1401:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",1406);}
case 1406:{f.StackOp("pop");f.Pc=1407;continue;}
case 1407:{f.Pc=1420;continue;}
case 1410:{f.Push(f.Locals[9]);f.Pc=1412;continue;}
case 1412:{f.Push(f.Locals[19]);f.Pc=1414;continue;}
case 1414:{return rt.Call(f,"forge/item/generation/BoosterGenerator","generateFoilCard","(Lforge/card/PrintSheet;)Lforge/item/PaperCard;","invokestatic",1417);}
case 1417:{return rt.Call(f,"forge/item/generation/BoosterGenerator","addFoilIfPresent","(Ljava/util/List;Lforge/item/PaperCard;)V","invokestatic",1420);}
case 1420:{f.Pc=659;continue;}
case 1423:{f.Push(f.Locals[3]);f.Pc=1424;continue;}
case 1424:{f.Pc=f.Pop().Int==0?1441:1427;continue;}
case 1427:{f.Push(f.Locals[4]);f.Pc=1429;continue;}
case 1429:{f.Pc=f.Pop().Int==0?1441:1432;continue;}
case 1432:{f.Push(f.Locals[1]);f.Pc=1433;continue;}
case 1433:{f.Push(f.Locals[9]);f.Pc=1435;continue;}
case 1435:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",1440);}
case 1440:{f.StackOp("pop");f.Pc=1441;continue;}
case 1441:{f.Push(f.Locals[2]);f.Pc=1442;continue;}
case 1442:{f.Pc=f.Pop().Reference==null?1734:1445;continue;}
case 1445:{f.Push(f.Locals[2]);f.Pc=1446;continue;}
case 1446:{return rt.Call(f,"forge/card/CardEdition","getBoosterMustContain","()Ljava/lang/String;","invokevirtual",1449);}
case 1449:{f.Locals[10]=f.Pop();f.Pc=1451;continue;}
case 1451:{f.Push(f.Locals[10]);f.Pc=1453;continue;}
case 1453:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",1456);}
case 1456:{f.Pc=f.Pop().Int!=0?1466:1459;continue;}
case 1459:{f.Push(f.Locals[1]);f.Pc=1460;continue;}
case 1460:{f.Push(f.Locals[0]);f.Pc=1461;continue;}
case 1461:{f.Push(f.Locals[10]);f.Pc=1463;continue;}
case 1463:{return rt.Call(f,"forge/item/generation/BoosterGenerator","ensureGuaranteedCardInBooster","(Ljava/util/List;Lforge/item/SealedTemplate;Ljava/lang/String;)V","invokestatic",1466);}
case 1466:{f.Push(f.Locals[2]);f.Pc=1467;continue;}
case 1467:{return rt.Call(f,"forge/card/CardEdition","getBoosterReplaceSlotFromPrintSheet","()Ljava/lang/String;","invokevirtual",1470);}
case 1470:{f.Locals[11]=f.Pop();f.Pc=1472;continue;}
case 1472:{f.Push(f.Locals[11]);f.Pc=1474;continue;}
case 1474:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",1477);}
case 1477:{f.Pc=f.Pop().Int!=0?1486:1480;continue;}
case 1480:{f.Push(f.Locals[1]);f.Pc=1481;continue;}
case 1481:{f.Push(f.Locals[11]);f.Pc=1483;continue;}
case 1483:{return rt.Call(f,"forge/item/generation/BoosterGenerator","replaceCardFromExtraSheet","(Ljava/util/List;Ljava/lang/String;)V","invokestatic",1486);}
case 1486:{f.Push(f.Locals[2]);f.Pc=1487;continue;}
case 1487:{return rt.Call(f,"forge/card/CardEdition","getSheetReplaceCardFromSheet","()Ljava/lang/String;","invokevirtual",1490);}
case 1490:{f.Locals[12]=f.Pop();f.Pc=1492;continue;}
case 1492:{f.Push(f.Locals[12]);f.Pc=1494;continue;}
case 1494:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",1497);}
case 1497:{f.Pc=f.Pop().Int!=0?1610:1500;continue;}
case 1500:{f.Push(f.Locals[12]);f.Pc=1502;continue;}
case 1502:{f.Push(JValue.R(rt.String("_")));f.Pc=1505;continue;}
case 1505:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1508);}
case 1508:{f.Locals[13]=f.Pop();f.Pc=1510;continue;}
case 1510:{f.Push(f.Locals[13]);f.Pc=1512;continue;}
case 1512:{f.Push(JValue.I(0));f.Pc=1513;continue;}
case 1513:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1514;continue;}
case 1514:{return rt.Call(f,"forge/item/generation/BoosterGenerator","tryGetStaticSheet","(Ljava/lang/String;)Lforge/card/PrintSheet;","invokestatic",1517);}
case 1517:{f.Locals[14]=f.Pop();f.Pc=1519;continue;}
case 1519:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",1522);}
case 1522:{f.Locals[15]=f.Pop();f.Pc=1524;continue;}
case 1524:{f.Push(f.Locals[1]);f.Pc=1525;continue;}
case 1525:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1530);}
case 1530:{f.Locals[16]=f.Pop();f.Pc=1532;continue;}
case 1532:{f.Push(f.Locals[16]);f.Pc=1534;continue;}
case 1534:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1539);}
case 1539:{f.Pc=f.Pop().Int==0?1583:1542;continue;}
case 1542:{f.Push(f.Locals[16]);f.Pc=1544;continue;}
case 1544:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1549);}
case 1549:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1552;continue;}
case 1552:{f.Locals[17]=f.Pop();f.Pc=1554;continue;}
case 1554:{f.Push(f.Locals[14]);f.Pc=1556;continue;}
case 1556:{f.Push(f.Locals[17]);f.Pc=1558;continue;}
case 1558:{return rt.Call(f,"forge/card/PrintSheet","contains","(Lforge/item/PaperCard;)Z","invokevirtual",1561);}
case 1561:{f.Pc=f.Pop().Int==0?1580:1564;continue;}
case 1564:{f.Push(f.Locals[15]);f.Pc=1566;continue;}
case 1566:{f.Push(f.Locals[15]);f.Pc=1568;continue;}
case 1568:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1573);}
case 1573:{f.Push(f.Locals[17]);f.Pc=1575;continue;}
case 1575:{return rt.Call(f,"java/util/List","add","(ILjava/lang/Object;)V","invokeinterface",1580);}
case 1580:{f.Pc=1532;continue;}
case 1583:{f.Push(f.Locals[1]);f.Pc=1584;continue;}
case 1584:{f.Push(f.Locals[15]);f.Pc=1586;continue;}
case 1586:{return rt.Call(f,"java/util/List","removeAll","(Ljava/util/Collection;)Z","invokeinterface",1591);}
case 1591:{f.StackOp("pop");f.Pc=1592;continue;}
case 1592:{f.Push(f.Locals[15]);f.Pc=1594;continue;}
case 1594:{f.Push(f.Locals[13]);f.Pc=1596;continue;}
case 1596:{f.Push(JValue.I(1));f.Pc=1597;continue;}
case 1597:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1598;continue;}
case 1598:{return rt.Call(f,"forge/item/generation/BoosterGenerator","replaceCardFromExtraSheet","(Ljava/util/List;Ljava/lang/String;)V","invokestatic",1601);}
case 1601:{f.Push(f.Locals[1]);f.Pc=1602;continue;}
case 1602:{f.Push(f.Locals[15]);f.Pc=1604;continue;}
case 1604:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",1609);}
case 1609:{f.StackOp("pop");f.Pc=1610;continue;}
case 1610:{f.Push(f.Locals[2]);f.Pc=1611;continue;}
case 1611:{return rt.Call(f,"forge/card/CardEdition","getSheetReplaceCardFromSheet2","()Ljava/lang/String;","invokevirtual",1614);}
case 1614:{f.Locals[13]=f.Pop();f.Pc=1616;continue;}
case 1616:{f.Push(f.Locals[13]);f.Pc=1618;continue;}
case 1618:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",1621);}
case 1621:{f.Pc=f.Pop().Int!=0?1734:1624;continue;}
case 1624:{f.Push(f.Locals[13]);f.Pc=1626;continue;}
case 1626:{f.Push(JValue.R(rt.String("_")));f.Pc=1629;continue;}
case 1629:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",1632);}
case 1632:{f.Locals[14]=f.Pop();f.Pc=1634;continue;}
case 1634:{f.Push(f.Locals[14]);f.Pc=1636;continue;}
case 1636:{f.Push(JValue.I(0));f.Pc=1637;continue;}
case 1637:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1638;continue;}
case 1638:{return rt.Call(f,"forge/item/generation/BoosterGenerator","tryGetStaticSheet","(Ljava/lang/String;)Lforge/card/PrintSheet;","invokestatic",1641);}
case 1641:{f.Locals[15]=f.Pop();f.Pc=1643;continue;}
case 1643:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",1646);}
case 1646:{f.Locals[16]=f.Pop();f.Pc=1648;continue;}
case 1648:{f.Push(f.Locals[1]);f.Pc=1649;continue;}
case 1649:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",1654);}
case 1654:{f.Locals[17]=f.Pop();f.Pc=1656;continue;}
case 1656:{f.Push(f.Locals[17]);f.Pc=1658;continue;}
case 1658:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",1663);}
case 1663:{f.Pc=f.Pop().Int==0?1707:1666;continue;}
case 1666:{f.Push(f.Locals[17]);f.Pc=1668;continue;}
case 1668:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",1673);}
case 1673:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=1676;continue;}
case 1676:{f.Locals[18]=f.Pop();f.Pc=1678;continue;}
case 1678:{f.Push(f.Locals[15]);f.Pc=1680;continue;}
case 1680:{f.Push(f.Locals[18]);f.Pc=1682;continue;}
case 1682:{return rt.Call(f,"forge/card/PrintSheet","contains","(Lforge/item/PaperCard;)Z","invokevirtual",1685);}
case 1685:{f.Pc=f.Pop().Int==0?1704:1688;continue;}
case 1688:{f.Push(f.Locals[16]);f.Pc=1690;continue;}
case 1690:{f.Push(f.Locals[16]);f.Pc=1692;continue;}
case 1692:{return rt.Call(f,"java/util/List","size","()I","invokeinterface",1697);}
case 1697:{f.Push(f.Locals[18]);f.Pc=1699;continue;}
case 1699:{return rt.Call(f,"java/util/List","add","(ILjava/lang/Object;)V","invokeinterface",1704);}
case 1704:{f.Pc=1656;continue;}
case 1707:{f.Push(f.Locals[1]);f.Pc=1708;continue;}
case 1708:{f.Push(f.Locals[16]);f.Pc=1710;continue;}
case 1710:{return rt.Call(f,"java/util/List","removeAll","(Ljava/util/Collection;)Z","invokeinterface",1715);}
case 1715:{f.StackOp("pop");f.Pc=1716;continue;}
case 1716:{f.Push(f.Locals[16]);f.Pc=1718;continue;}
case 1718:{f.Push(f.Locals[14]);f.Pc=1720;continue;}
case 1720:{f.Push(JValue.I(1));f.Pc=1721;continue;}
case 1721:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=1722;continue;}
case 1722:{return rt.Call(f,"forge/item/generation/BoosterGenerator","replaceCardFromExtraSheet","(Ljava/util/List;Ljava/lang/String;)V","invokestatic",1725);}
case 1725:{f.Push(f.Locals[1]);f.Pc=1726;continue;}
case 1726:{f.Push(f.Locals[16]);f.Pc=1728;continue;}
case 1728:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",1733);}
case 1733:{f.StackOp("pop");f.Pc=1734;continue;}
case 1734:{f.Push(f.Locals[1]);f.Pc=1735;continue;}
case 1735:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11459(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/item/SealedTemplateWithSlots","getNamedSlots","()Ljava/util/Map;","invokevirtual",12);}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[0]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"forge/item/SealedTemplateWithSlots","getSlots","()Ljava/util/List;","invokevirtual",17);}
case 17:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",22);}
case 22:{f.Locals[3]=f.Pop();f.Pc=23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",29);}
case 29:{f.Pc=f.Pop().Int==0?383:32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",38);}
case 38:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=41;continue;}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",48);}
case 48:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=51;continue;}
case 51:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",54);}
case 54:{f.Locals[5]=f.Pop();f.Pc=56;continue;}
case 56:{f.Push(f.Locals[4]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getRight","()Ljava/lang/Object;","invokevirtual",61);}
case 61:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Integer"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/Integer","intValue","()I","invokevirtual",67);}
case 67:{f.Locals[6]=f.Pop();f.Pc=69;continue;}
case 69:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=72;continue;}
case 72:{f.Push(f.Locals[6]);f.Pc=74;continue;}
case 74:{f.Push(f.Locals[5]);f.Pc=76;continue;}
case 76:{return rt.DynamicCall(f,"forge/item/generation/BoosterGenerator:11459:76:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(ILjava/lang/String;)Ljava/lang/String;",81);}
case 81:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",84);}
case 84:{f.Push(f.Locals[5]);f.Pc=86;continue;}
case 86:{f.Push(JValue.R(rt.String("+")));f.Pc=89;continue;}
case 89:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",92);}
case 92:{f.Locals[7]=f.Pop();f.Pc=94;continue;}
case 94:{f.Push(f.Locals[7]);f.Pc=96;continue;}
case 96:{f.Pc=f.Pop().Int==0?114:99;continue;}
case 99:{f.Push(f.Locals[5]);f.Pc=101;continue;}
case 101:{f.Push(JValue.I(0));f.Pc=102;continue;}
case 102:{f.Push(f.Locals[5]);f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",107);}
case 107:{f.Push(JValue.I(1));f.Pc=108;continue;}
case 108:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=109;continue;}
case 109:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",112);}
case 112:{f.Locals[5]=f.Pop();f.Pc=114;continue;}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{f.Push(f.Locals[5]);f.Pc=117;continue;}
case 117:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",122);}
case 122:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/BoosterSlot"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=125;continue;}
case 125:{f.Locals[8]=f.Pop();f.Pc=127;continue;}
case 127:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",130);}
case 130:{f.Locals[9]=f.Pop();f.Pc=132;continue;}
case 132:{f.Push(f.Locals[8]);f.Pc=134;continue;}
case 134:{f.Push(f.Locals[6]);f.Pc=136;continue;}
case 136:{return rt.Call(f,"forge/item/generation/BoosterGenerator","bulkSlotReplacement","(Lforge/item/BoosterSlot;I)Ljava/util/Map;","invokestatic",139);}
case 139:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",144);}
case 144:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",149);}
case 149:{f.Locals[10]=f.Pop();f.Pc=151;continue;}
case 151:{f.Push(f.Locals[10]);f.Pc=153;continue;}
case 153:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",158);}
case 158:{f.Pc=f.Pop().Int==0?371:161;continue;}
case 161:{f.Push(f.Locals[10]);f.Pc=163;continue;}
case 163:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",168);}
case 168:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=171;continue;}
case 171:{f.Locals[11]=f.Pop();f.Pc=173;continue;}
case 173:{f.Push(f.Locals[11]);f.Pc=175;continue;}
case 175:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",180);}
case 180:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=183;continue;}
case 183:{f.Locals[12]=f.Pop();f.Pc=185;continue;}
case 185:{f.Push(f.Locals[11]);f.Pc=187;continue;}
case 187:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",192);}
case 192:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Long"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=195;continue;}
case 195:{return rt.Call(f,"java/lang/Long","longValue","()J","invokevirtual",198);}
case 198:{f.Push(JNumbers.Unary("l2i",f.Pop()));f.Pc=199;continue;}
case 199:{f.Locals[13]=f.Pop();f.Pc=201;continue;}
case 201:{f.Push(f.Locals[12]);f.Pc=203;continue;}
case 203:{f.Pc=f.Pop().Reference==null?151:206;continue;}
case 206:{f.Push(f.Locals[12]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"java/lang/String","isEmpty","()Z","invokevirtual",211);}
case 211:{f.Pc=f.Pop().Int!=0?151:214;continue;}
case 214:{f.Push(f.Locals[13]);f.Pc=216;continue;}
case 216:{f.Pc=f.Pop().Int!=0?222:219;continue;}
case 219:{f.Pc=151;continue;}
case 222:{f.Push(JValue.I(0));f.Pc=223;continue;}
case 223:{f.Locals[14]=f.Pop();f.Pc=225;continue;}
case 225:{f.Push(f.Locals[12]);f.Pc=227;continue;}
case 227:{f.Push(JValue.R(rt.String("+")));f.Pc=230;continue;}
case 230:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",233);}
case 233:{f.Pc=f.Pop().Int==0?254:236;continue;}
case 236:{f.Push(f.Locals[12]);f.Pc=238;continue;}
case 238:{f.Push(JValue.I(0));f.Pc=239;continue;}
case 239:{f.Push(f.Locals[12]);f.Pc=241;continue;}
case 241:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",244);}
case 244:{f.Push(JValue.I(1));f.Pc=245;continue;}
case 245:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=246;continue;}
case 246:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",249);}
case 249:{f.Locals[12]=f.Pop();f.Pc=251;continue;}
case 251:{f.Push(JValue.I(1));f.Pc=252;continue;}
case 252:{f.Locals[14]=f.Pop();f.Pc=254;continue;}
case 254:{f.Push(f.Locals[0]);f.Pc=255;continue;}
case 255:{return rt.Call(f,"forge/item/SealedTemplateWithSlots","getEdition","()Ljava/lang/String;","invokevirtual",258);}
case 258:{f.Locals[15]=f.Pop();f.Pc=260;continue;}
case 260:{f.Push(f.Locals[12]);f.Pc=262;continue;}
case 262:{f.Push(f.Locals[15]);f.Pc=264;continue;}
case 264:{return rt.DynamicCall(f,"forge/item/generation/BoosterGenerator:11459:264:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",269);}
case 269:{return rt.Call(f,"forge/item/generation/BoosterGenerator","getPrintSheet","(Ljava/lang/String;)Lforge/card/PrintSheet;","invokestatic",272);}
case 272:{f.Locals[16]=f.Pop();f.Pc=274;continue;}
case 274:{f.Pc=286;continue;}
case 277:{f.Locals[17]=f.Pop();f.Pc=279;continue;}
case 279:{f.Push(f.Locals[12]);f.Pc=281;continue;}
case 281:{return rt.Call(f,"forge/item/generation/BoosterGenerator","getPrintSheet","(Ljava/lang/String;)Lforge/card/PrintSheet;","invokestatic",284);}
case 284:{f.Locals[16]=f.Pop();f.Pc=286;continue;}
case 286:{f.Push(f.Locals[7]);f.Pc=288;continue;}
case 288:{f.Pc=f.Pop().Int!=0?296:291;continue;}
case 291:{f.Push(f.Locals[14]);f.Pc=293;continue;}
case 293:{f.Pc=f.Pop().Int==0?352:296;continue;}
case 296:{f.Push(f.Locals[16]);f.Pc=298;continue;}
case 298:{f.Push(f.Locals[13]);f.Pc=300;continue;}
case 300:{f.Push(JValue.I(1));f.Pc=301;continue;}
case 301:{return rt.Call(f,"forge/card/PrintSheet","random","(IZ)Ljava/util/List;","invokevirtual",304);}
case 304:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",309);}
case 309:{f.Locals[17]=f.Pop();f.Pc=311;continue;}
case 311:{f.Push(f.Locals[17]);f.Pc=313;continue;}
case 313:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",318);}
case 318:{f.Pc=f.Pop().Int==0?349:321;continue;}
case 321:{f.Push(f.Locals[17]);f.Pc=323;continue;}
case 323:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",328);}
case 328:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=331;continue;}
case 331:{f.Locals[18]=f.Pop();f.Pc=333;continue;}
case 333:{f.Push(f.Locals[9]);f.Pc=335;continue;}
case 335:{f.Push(f.Locals[18]);f.Pc=337;continue;}
case 337:{return rt.Call(f,"forge/item/PaperCard","getFoiled","()Lforge/item/PaperCard;","invokevirtual",340);}
case 340:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",345);}
case 345:{f.StackOp("pop");f.Pc=346;continue;}
case 346:{f.Pc=311;continue;}
case 349:{f.Pc=368;continue;}
case 352:{f.Push(f.Locals[9]);f.Pc=354;continue;}
case 354:{f.Push(f.Locals[16]);f.Pc=356;continue;}
case 356:{f.Push(f.Locals[13]);f.Pc=358;continue;}
case 358:{f.Push(JValue.I(1));f.Pc=359;continue;}
case 359:{return rt.Call(f,"forge/card/PrintSheet","random","(IZ)Ljava/util/List;","invokevirtual",362);}
case 362:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",367);}
case 367:{f.StackOp("pop");f.Pc=368;continue;}
case 368:{f.Pc=151;continue;}
case 371:{f.Push(f.Locals[1]);f.Pc=372;continue;}
case 372:{f.Push(f.Locals[9]);f.Pc=374;continue;}
case 374:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",379);}
case 379:{f.StackOp("pop");f.Pc=380;continue;}
case 380:{f.Pc=23;continue;}
case 383:{f.Push(f.Locals[1]);f.Pc=384;continue;}
case 384:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11460(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.StackOp("dup");f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",5);}
case 5:{f.StackOp("pop");f.Pc=6;continue;}
case 6:{return rt.DynamicCall(f,"forge/item/generation/BoosterGenerator:11460:6:java/lang/invoke/LambdaMetafactory.metafactory","(Lforge/item/BoosterSlot;)Ljava/util/function/Supplier;",11);}
case 11:{return rt.Call(f,"java/util/stream/Stream","generate","(Ljava/util/function/Supplier;)Ljava/util/stream/Stream;","invokestatic",14);}
case 14:{f.Push(f.Locals[1]);f.Pc=15;continue;}
case 15:{f.Push(JNumbers.Unary("i2l",f.Pop()));f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/stream/Stream","limit","(J)Ljava/util/stream/Stream;","invokeinterface",21);}
case 21:{return rt.Call(f,"java/util/function/Function","identity","()Ljava/util/function/Function;","invokestatic",24);}
case 24:{return rt.Call(f,"java/util/stream/Collectors","counting","()Ljava/util/stream/Collector;","invokestatic",27);}
case 27:{return rt.Call(f,"java/util/stream/Collectors","groupingBy","(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;","invokestatic",30);}
case 30:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11461(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(JValue.I(32));f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/util/TextUtil","split","(Ljava/lang/CharSequence;C)[Ljava/lang/String;","invokestatic",6);}
case 6:{f.Locals[3]=f.Pop();f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Locals[4]=f.Pop();f.Pc=10;continue;}
case 10:{f.Push(f.Locals[0]);f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",16);}
case 16:{f.Locals[5]=f.Pop();f.Pc=18;continue;}
case 18:{f.Push(f.Locals[5]);f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",25);}
case 25:{f.Pc=f.Pop().Int==0?110:28;continue;}
case 28:{f.Push(f.Locals[5]);f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{f.Locals[6]=f.Pop();f.Pc=40;continue;}
case 40:{f.Push(JValue.I(1));f.Pc=41;continue;}
case 41:{f.Locals[7]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{f.Locals[8]=f.Pop();f.Pc=46;continue;}
case 46:{f.Push(f.Locals[8]);f.Pc=48;continue;}
case 48:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=49;continue;}
case 49:{f.Locals[9]=f.Pop();f.Pc=51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{f.Locals[10]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[10]);f.Pc=56;continue;}
case 56:{f.Push(f.Locals[9]);f.Pc=58;continue;}
case 58:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?96:61;continue;}
case 61:{f.Push(f.Locals[8]);f.Pc=63;continue;}
case 63:{f.Push(f.Locals[10]);f.Pc=65;continue;}
case 65:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=66;continue;}
case 66:{f.Locals[11]=f.Pop();f.Pc=68;continue;}
case 68:{f.Push(f.Locals[6]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",73);}
case 73:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",76);}
case 76:{f.Push(f.Locals[11]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"forge/card/CardType","hasStringType","(Ljava/lang/String;)Z","invokevirtual",81);}
case 81:{f.Pc=f.Pop().Int!=0?90:84;continue;}
case 84:{f.Push(JValue.I(0));f.Pc=85;continue;}
case 85:{f.Locals[7]=f.Pop();f.Pc=87;continue;}
case 87:{f.Pc=96;continue;}
case 90:{f.Locals[10]=JValue.I(unchecked(f.Locals[10].Int+(1)));f.Pc=93;continue;}
case 93:{f.Pc=54;continue;}
case 96:{f.Push(f.Locals[7]);f.Pc=98;continue;}
case 98:{f.Pc=f.Pop().Int==0?107:101;continue;}
case 101:{f.Push(JValue.I(1));f.Pc=102;continue;}
case 102:{f.Locals[4]=f.Pop();f.Pc=104;continue;}
case 104:{f.Pc=110;continue;}
case 107:{f.Pc=18;continue;}
case 110:{f.Push(f.Locals[4]);f.Pc=112;continue;}
case 112:{f.Pc=f.Pop().Int!=0?368:115;continue;}
case 115:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",118);}
case 118:{f.Locals[5]=f.Pop();f.Pc=120;continue;}
case 120:{f.Push(f.Locals[1]);f.Pc=121;continue;}
case 121:{return rt.Call(f,"forge/item/SealedTemplate","getSlots","()Ljava/util/List;","invokevirtual",124);}
case 124:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",129);}
case 129:{f.Locals[6]=f.Pop();f.Pc=131;continue;}
case 131:{f.Push(f.Locals[6]);f.Pc=133;continue;}
case 133:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",138);}
case 138:{f.Pc=f.Pop().Int==0?342:141;continue;}
case 141:{f.Push(f.Locals[6]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",148);}
case 148:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"org/apache/commons/lang3/tuple/Pair"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=151;continue;}
case 151:{f.Locals[7]=f.Pop();f.Pc=153;continue;}
case 153:{f.Push(f.Locals[7]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"org/apache/commons/lang3/tuple/Pair","getLeft","()Ljava/lang/Object;","invokevirtual",158);}
case 158:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=161;continue;}
case 161:{f.Locals[8]=f.Pop();f.Pc=163;continue;}
case 163:{f.Push(f.Locals[1]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"forge/item/SealedTemplate","getEdition","()Ljava/lang/String;","invokevirtual",167);}
case 167:{f.Locals[9]=f.Pop();f.Pc=169;continue;}
case 169:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",172);}
case 172:{return rt.Call(f,"forge/StaticData","getEditions","()Lforge/card/CardEdition$Collection;","invokevirtual",175);}
case 175:{f.Push(f.Locals[9]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/card/CardEdition$Collection","contains","(Ljava/lang/String;)Z","invokevirtual",180);}
case 180:{f.Pc=f.Pop().Int==0?198:183;continue;}
case 183:{f.Push(f.Locals[8]);f.Pc=185;continue;}
case 185:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",188);}
case 188:{f.Push(f.Locals[9]);f.Pc=190;continue;}
case 190:{return rt.DynamicCall(f,"forge/item/generation/BoosterGenerator:11461:190:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",195);}
case 195:{f.Pc=203;continue;}
case 198:{f.Push(f.Locals[8]);f.Pc=200;continue;}
case 200:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",203);}
case 203:{f.Locals[10]=f.Pop();f.Pc=205;continue;}
case 205:{f.Push(f.Locals[10]);f.Pc=207;continue;}
case 207:{return rt.Call(f,"forge/item/generation/BoosterGenerator","getPrintSheet","(Ljava/lang/String;)Lforge/card/PrintSheet;","invokestatic",210);}
case 210:{f.Locals[11]=f.Pop();f.Pc=212;continue;}
case 212:{f.Push(f.Locals[11]);f.Pc=214;continue;}
case 214:{return rt.Call(f,"forge/card/PrintSheet","toFlatList","()Ljava/util/List;","invokevirtual",217);}
case 217:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",220);}
case 220:{f.Locals[12]=f.Pop();f.Pc=222;continue;}
case 222:{f.Push(f.Locals[12]);f.Pc=224;continue;}
case 224:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",229);}
case 229:{f.Locals[13]=f.Pop();f.Pc=231;continue;}
case 231:{f.Push(f.Locals[13]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",238);}
case 238:{f.Pc=f.Pop().Int==0?339:241;continue;}
case 241:{f.Push(f.Locals[13]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",248);}
case 248:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=251;continue;}
case 251:{f.Locals[14]=f.Pop();f.Pc=253;continue;}
case 253:{f.Push(JValue.I(1));f.Pc=254;continue;}
case 254:{f.Locals[15]=f.Pop();f.Pc=256;continue;}
case 256:{f.Push(f.Locals[3]);f.Pc=257;continue;}
case 257:{f.Locals[16]=f.Pop();f.Pc=259;continue;}
case 259:{f.Push(f.Locals[16]);f.Pc=261;continue;}
case 261:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=262;continue;}
case 262:{f.Locals[17]=f.Pop();f.Pc=264;continue;}
case 264:{f.Push(JValue.I(0));f.Pc=265;continue;}
case 265:{f.Locals[18]=f.Pop();f.Pc=267;continue;}
case 267:{f.Push(f.Locals[18]);f.Pc=269;continue;}
case 269:{f.Push(f.Locals[17]);f.Pc=271;continue;}
case 271:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?309:274;continue;}
case 274:{f.Push(f.Locals[16]);f.Pc=276;continue;}
case 276:{f.Push(f.Locals[18]);f.Pc=278;continue;}
case 278:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=279;continue;}
case 279:{f.Locals[19]=f.Pop();f.Pc=281;continue;}
case 281:{f.Push(f.Locals[14]);f.Pc=283;continue;}
case 283:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",286);}
case 286:{return rt.Call(f,"forge/card/CardRules","getType","()Lforge/card/CardType;","invokevirtual",289);}
case 289:{f.Push(f.Locals[19]);f.Pc=291;continue;}
case 291:{return rt.Call(f,"forge/card/CardType","hasStringType","(Ljava/lang/String;)Z","invokevirtual",294);}
case 294:{f.Pc=f.Pop().Int!=0?303:297;continue;}
case 297:{f.Push(JValue.I(0));f.Pc=298;continue;}
case 298:{f.Locals[15]=f.Pop();f.Pc=300;continue;}
case 300:{f.Pc=309;continue;}
case 303:{f.Locals[18]=JValue.I(unchecked(f.Locals[18].Int+(1)));f.Pc=306;continue;}
case 306:{f.Pc=267;continue;}
case 309:{f.Push(f.Locals[15]);f.Pc=311;continue;}
case 311:{f.Pc=f.Pop().Int==0?336:314;continue;}
case 314:{f.Push(f.Locals[5]);f.Pc=316;continue;}
case 316:{f.Push(f.Locals[14]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",323);}
case 323:{f.Pc=f.Pop().Int!=0?336:326;continue;}
case 326:{f.Push(f.Locals[5]);f.Pc=328;continue;}
case 328:{f.Push(f.Locals[14]);f.Pc=330;continue;}
case 330:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",335);}
case 335:{f.StackOp("pop");f.Pc=336;continue;}
case 336:{f.Pc=231;continue;}
case 339:{f.Pc=131;continue;}
case 342:{f.Push(f.Locals[5]);f.Pc=344;continue;}
case 344:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",349);}
case 349:{f.Pc=f.Pop().Int!=0?368:352;continue;}
case 352:{f.Push(f.Locals[5]);f.Pc=354;continue;}
case 354:{return rt.Call(f,"forge/util/Aggregates","random","(Ljava/lang/Iterable;)Ljava/lang/Object;","invokestatic",357);}
case 357:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=360;continue;}
case 360:{f.Locals[6]=f.Pop();f.Pc=362;continue;}
case 362:{f.Push(f.Locals[0]);f.Pc=363;continue;}
case 363:{f.Push(f.Locals[6]);f.Pc=365;continue;}
case 365:{return rt.Call(f,"forge/item/generation/BoosterGenerator","replaceCard","(Ljava/util/List;Lforge/item/PaperCard;)V","invokestatic",368);}
case 368:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11462(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/generation/BoosterGenerator","tryGetStaticSheet","(Ljava/lang/String;)Lforge/card/PrintSheet;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{f.Push(f.Locals[2]);f.Pc=6;continue;}
case 6:{f.Pc=f.Pop().Reference!=null?10:9;continue;}
case 9:{return JStep.ReturnVoid;}
case 10:{f.Push(f.Locals[2]);f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{f.Push(JValue.I(0));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/card/PrintSheet","random","(IZ)Ljava/util/List;","invokevirtual",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",23);}
case 23:{f.Pc=f.Pop().Int==0?27:26;continue;}
case 26:{return JStep.ReturnVoid;}
case 27:{f.Push(f.Locals[0]);f.Pc=28;continue;}
case 28:{f.Push(f.Locals[3]);f.Pc=29;continue;}
case 29:{f.Push(JValue.I(0));f.Pc=30;continue;}
case 30:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",35);}
case 35:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/item/generation/BoosterGenerator","replaceCard","(Ljava/util/List;Lforge/item/PaperCard;)V","invokestatic",41);}
case 41:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11463(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator$1","$SwitchMap$forge$card$CardRarity","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/generation/BoosterGenerator$1","$SwitchMap$forge$card$CardRarity","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[1]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/item/PaperCard","getRarity","()Lforge/card/CardRarity;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/card/CardRarity","ordinal","()I","invokevirtual",10);}
case 10:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=11;continue;}
case 11:{switch(f.Pop().Int){case 1:f.Pc=69;break;case 2:f.Pc=62;break;case 3:f.Pc=55;break;case 4:f.Pc=76;break;case 5:f.Pc=48;break;case 6:f.Pc=69;break;default:f.Pc=76;break;}continue;}
case 48:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_BASIC_LAND_RARITY","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_BASIC_LAND_RARITY","Ljava/util/function/Predicate;"));f.Pc=51;continue;}
case 51:{f.Locals[2]=f.Pop();f.Pc=52;continue;}
case 52:{f.Pc=80;continue;}
case 55:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_COMMON","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_COMMON","Ljava/util/function/Predicate;"));f.Pc=58;continue;}
case 58:{f.Locals[2]=f.Pop();f.Pc=59;continue;}
case 59:{f.Pc=80;continue;}
case 62:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_UNCOMMON","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_UNCOMMON","Ljava/util/function/Predicate;"));f.Pc=65;continue;}
case 65:{f.Locals[2]=f.Pop();f.Pc=66;continue;}
case 66:{f.Pc=80;continue;}
case 69:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_RARE_OR_MYTHIC","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_RARE_OR_MYTHIC","Ljava/util/function/Predicate;"));f.Pc=72;continue;}
case 72:{f.Locals[2]=f.Pop();f.Pc=73;continue;}
case 73:{f.Pc=80;continue;}
case 76:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_SPECIAL","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_SPECIAL","Ljava/util/function/Predicate;"));f.Pc=79;continue;}
case 79:{f.Locals[2]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(JValue.R(null));f.Pc=81;continue;}
case 81:{f.Locals[3]=f.Pop();f.Pc=82;continue;}
case 82:{f.Push(f.Locals[0]);f.Pc=83;continue;}
case 83:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",88);}
case 88:{f.Locals[4]=f.Pop();f.Pc=90;continue;}
case 90:{f.Push(f.Locals[4]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",97);}
case 97:{f.Pc=f.Pop().Int==0?132:100;continue;}
case 100:{f.Push(f.Locals[4]);f.Pc=102;continue;}
case 102:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",107);}
case 107:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=110;continue;}
case 110:{f.Locals[5]=f.Pop();f.Pc=112;continue;}
case 112:{f.Push(f.Locals[2]);f.Pc=113;continue;}
case 113:{f.Push(f.Locals[5]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"java/util/function/Predicate","test","(Ljava/lang/Object;)Z","invokeinterface",120);}
case 120:{f.Pc=f.Pop().Int==0?129:123;continue;}
case 123:{f.Push(f.Locals[5]);f.Pc=125;continue;}
case 125:{f.Locals[3]=f.Pop();f.Pc=126;continue;}
case 126:{f.Pc=132;continue;}
case 129:{f.Pc=90;continue;}
case 132:{f.Push(f.Locals[3]);f.Pc=133;continue;}
case 133:{f.Pc=f.Pop().Reference==null?164:136;continue;}
case 136:{f.Push(f.Locals[3]);f.Pc=137;continue;}
case 137:{return rt.Call(f,"forge/item/PaperCard","isFoil","()Z","invokevirtual",140);}
case 140:{f.Pc=f.Pop().Int==0?148:143;continue;}
case 143:{f.Push(f.Locals[1]);f.Pc=144;continue;}
case 144:{return rt.Call(f,"forge/item/PaperCard","getFoiled","()Lforge/item/PaperCard;","invokevirtual",147);}
case 147:{f.Locals[1]=f.Pop();f.Pc=148;continue;}
case 148:{f.Push(f.Locals[0]);f.Pc=149;continue;}
case 149:{f.Push(f.Locals[3]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/util/List","remove","(Ljava/lang/Object;)Z","invokeinterface",155);}
case 155:{f.StackOp("pop");f.Pc=156;continue;}
case 156:{f.Push(f.Locals[0]);f.Pc=157;continue;}
case 157:{f.Push(f.Locals[1]);f.Pc=158;continue;}
case 158:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",163);}
case 163:{f.StackOp("pop");f.Pc=164;continue;}
case 164:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11464(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/item/generation/BoosterGenerator","getPrintSheet","(Ljava/lang/String;)Lforge/card/PrintSheet;","invokestatic",4);}
case 4:{f.Locals[2]=f.Pop();f.Pc=5;continue;}
case 5:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","()Ljava/util/HashSet;","invokestatic",8);}
case 8:{f.Locals[3]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",15);}
case 15:{f.Pc=f.Pop().Int!=0?63:18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",24);}
case 24:{f.Locals[4]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[4]);f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",33);}
case 33:{f.Pc=f.Pop().Int==0?63:36;continue;}
case 36:{f.Push(f.Locals[4]);f.Pc=38;continue;}
case 38:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",43);}
case 43:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=46;continue;}
case 46:{f.Locals[5]=f.Pop();f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/item/PaperCard","getRarity","()Lforge/card/CardRarity;","invokevirtual",54);}
case 54:{return rt.Call(f,"java/util/Set","add","(Ljava/lang/Object;)Z","invokeinterface",59);}
case 59:{f.StackOp("pop");f.Pc=60;continue;}
case 60:{f.Pc=26;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"forge/card/PrintSheet","toFlatList","()Ljava/util/List;","invokevirtual",67);}
case 67:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",72);}
case 72:{f.Locals[4]=f.Pop();f.Pc=74;continue;}
case 74:{f.Push(f.Locals[4]);f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",81);}
case 81:{f.Pc=f.Pop().Int==0?133:84;continue;}
case 84:{f.Push(f.Locals[4]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",91);}
case 91:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/item/PaperCard"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=94;continue;}
case 94:{f.Locals[5]=f.Pop();f.Pc=96;continue;}
case 96:{f.Push(f.Locals[0]);f.Pc=97;continue;}
case 97:{f.Push(f.Locals[5]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",104);}
case 104:{f.Pc=f.Pop().Int!=0?130:107;continue;}
case 107:{f.Push(f.Locals[3]);f.Pc=108;continue;}
case 108:{f.Push(f.Locals[5]);f.Pc=110;continue;}
case 110:{return rt.Call(f,"forge/item/PaperCard","getRarity","()Lforge/card/CardRarity;","invokevirtual",113);}
case 113:{return rt.Call(f,"java/util/Set","contains","(Ljava/lang/Object;)Z","invokeinterface",118);}
case 118:{f.Pc=f.Pop().Int==0?130:121;continue;}
case 121:{f.Push(f.Locals[0]);f.Pc=122;continue;}
case 122:{f.Push(f.Locals[5]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",129);}
case 129:{f.StackOp("pop");f.Pc=130;continue;}
case 130:{f.Pc=74;continue;}
case 133:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11465(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/card/PrintSheet"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/card/PrintSheet")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/card/PrintSheet","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{f.Locals[2]=f.Pop();f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(JValue.I(32));f.Pc=12;continue;}
case 12:{f.Push(JValue.I(2));f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;CI)[Ljava/lang/String;","invokestatic",16);}
case 16:{f.Locals[3]=f.Pop();f.Pc=17;continue;}
case 17:{f.Push(f.Locals[3]);f.Pc=18;continue;}
case 18:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=19;continue;}
case 19:{f.Push(JValue.I(1));f.Pc=20;continue;}
case 20:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<=b?37:23;continue;}
case 23:{f.Push(f.Locals[3]);f.Pc=24;continue;}
case 24:{f.Push(JValue.I(1));f.Pc=25;continue;}
case 25:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=26;continue;}
case 26:{f.Push(JValue.R(rt.String(" ")));f.Pc=28;continue;}
case 28:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",31);}
case 31:{return rt.Call(f,"forge/item/PaperCardPredicates","printedInSets","([Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",34);}
case 34:{f.Pc=42;continue;}
case 37:{return rt.DynamicCall(f,"forge/item/generation/BoosterGenerator:11465:37:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",42);}
case 42:{f.Locals[4]=f.Pop();f.Pc=44;continue;}
case 44:{if(!rt.EnsureInitialized(f,"java/util/LinkedList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/LinkedList")));f.Pc=47;continue;}
case 47:{f.StackOp("dup");f.Pc=48;continue;}
case 48:{f.Push(f.Locals[3]);f.Pc=49;continue;}
case 49:{f.Push(JValue.I(0));f.Pc=50;continue;}
case 50:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=51;continue;}
case 51:{f.Push(JValue.I(58));f.Pc=53;continue;}
case 53:{return rt.Call(f,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;C)[Ljava/lang/String;","invokestatic",56);}
case 56:{return rt.Call(f,"java/util/Arrays","asList","([Ljava/lang/Object;)Ljava/util/List;","invokestatic",59);}
case 59:{return rt.Call(f,"java/util/LinkedList","<init>","(Ljava/util/Collection;)V","invokespecial",62);}
case 62:{f.Locals[5]=f.Pop();f.Pc=64;continue;}
case 64:{f.Push(f.Locals[5]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/item/generation/BoosterGenerator","buildExtraPredicate","(Ljava/util/List;)Ljava/util/function/Predicate;","invokestatic",69);}
case 69:{f.Locals[6]=f.Pop();f.Pc=71;continue;}
case 71:{f.Push(f.Locals[5]);f.Pc=73;continue;}
case 73:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",78);}
case 78:{f.Locals[7]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[7]);f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",87);}
case 87:{f.Pc=f.Pop().Int==0?353:90;continue;}
case 90:{f.Push(f.Locals[7]);f.Pc=92;continue;}
case 92:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",97);}
case 97:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=100;continue;}
case 100:{f.Locals[8]=f.Pop();f.Pc=102;continue;}
case 102:{f.Push(f.Locals[8]);f.Pc=104;continue;}
case 104:{f.Push(JValue.I(1));f.Pc=105;continue;}
case 105:{f.Push(JValue.I(0));f.Pc=106;continue;}
case 106:{f.Push(JValue.R(rt.String("fromSheet")));f.Pc=109;continue;}
case 109:{f.Push(JValue.I(0));f.Pc=110;continue;}
case 110:{f.Push(JValue.I(9));f.Pc=112;continue;}
case 112:{return rt.Call(f,"java/lang/String","regionMatches","(ZILjava/lang/String;II)Z","invokevirtual",115);}
case 115:{f.Pc=f.Pop().Int!=0?134:118;continue;}
case 118:{f.Push(f.Locals[8]);f.Pc=120;continue;}
case 120:{f.Push(JValue.I(1));f.Pc=121;continue;}
case 121:{f.Push(JValue.I(0));f.Pc=122;continue;}
case 122:{f.Push(JValue.R(rt.String("wholeSheet")));f.Pc=125;continue;}
case 125:{f.Push(JValue.I(0));f.Pc=126;continue;}
case 126:{f.Push(JValue.I(10));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/String","regionMatches","(ZILjava/lang/String;II)Z","invokevirtual",131);}
case 131:{f.Pc=f.Pop().Int==0?224:134;continue;}
case 134:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=137;continue;}
case 137:{f.Push(f.Locals[8]);f.Pc=139;continue;}
case 139:{return rt.DynamicCall(f,"forge/item/generation/BoosterGenerator:11465:139:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",144);}
case 144:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",147);}
case 147:{f.Push(f.Locals[8]);f.Pc=149;continue;}
case 149:{f.Push(JValue.I(10));f.Pc=151;continue;}
case 151:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",154);}
case 154:{f.Push(JValue.R(rt.String("()\" ")));f.Pc=157;continue;}
case 157:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","strip","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",160);}
case 160:{f.Locals[9]=f.Pop();f.Pc=162;continue;}
case 162:{if(!rt.StaticReady(f,"java/lang/System","out","Ljava/io/PrintStream;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/System","out","Ljava/io/PrintStream;"));f.Pc=165;continue;}
case 165:{f.Push(f.Locals[9]);f.Pc=167;continue;}
case 167:{return rt.DynamicCall(f,"forge/item/generation/BoosterGenerator:11465:167:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",172);}
case 172:{return rt.Call(f,"java/io/PrintStream","println","(Ljava/lang/String;)V","invokevirtual",175);}
case 175:{f.Push(f.Locals[9]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"forge/item/generation/BoosterGenerator","tryGetStaticSheet","(Ljava/lang/String;)Lforge/card/PrintSheet;","invokestatic",180);}
case 180:{f.Locals[10]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(f.Locals[10]);f.Pc=184;continue;}
case 184:{f.Pc=f.Pop().Reference!=null?208:187;continue;}
case 187:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=190;continue;}
case 190:{f.StackOp("dup");f.Pc=191;continue;}
case 191:{f.Push(f.Locals[2]);f.Pc=192;continue;}
case 192:{return rt.Call(f,"forge/card/PrintSheet","getName","()Ljava/lang/String;","invokevirtual",195);}
case 195:{f.Push(f.Locals[9]);f.Pc=197;continue;}
case 197:{f.Push(f.Locals[8]);f.Pc=199;continue;}
case 199:{return rt.DynamicCall(f,"forge/item/generation/BoosterGenerator:11465:199:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",204);}
case 204:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;)V","invokespecial",207);}
case 207:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 208:{f.Push(f.Locals[10]);f.Pc=210;continue;}
case 210:{return rt.Call(f,"forge/card/PrintSheet","toFlatList","()Ljava/util/List;","invokevirtual",213);}
case 213:{f.Locals[1]=f.Pop();f.Pc=214;continue;}
case 214:{return rt.DynamicCall(f,"forge/item/generation/BoosterGenerator:11465:214:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",219);}
case 219:{f.Locals[4]=f.Pop();f.Pc=221;continue;}
case 221:{f.Pc=343;continue;}
case 224:{f.Push(f.Locals[8]);f.Pc=226;continue;}
case 226:{f.Push(JValue.R(rt.String("promo")));f.Pc=229;continue;}
case 229:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",232);}
case 232:{f.Pc=f.Pop().Int!=0?246:235;continue;}
case 235:{f.Push(f.Locals[8]);f.Pc=237;continue;}
case 237:{f.Push(JValue.R(rt.String("name")));f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",243);}
case 243:{f.Pc=f.Pop().Int==0?80:246;continue;}
case 246:{f.Push(f.Locals[8]);f.Pc=248;continue;}
case 248:{f.Push(JValue.I(5));f.Pc=249;continue;}
case 249:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",252);}
case 252:{f.Push(JValue.R(rt.String("() ")));f.Pc=255;continue;}
case 255:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","strip","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",258);}
case 258:{f.Locals[9]=f.Pop();f.Pc=260;continue;}
case 260:{f.Push(f.Locals[9]);f.Pc=262;continue;}
case 262:{f.Push(JValue.I(44));f.Pc=264;continue;}
case 264:{f.Push(JValue.I(34));f.Pc=266;continue;}
case 266:{f.Push(JValue.I(34));f.Pc=268;continue;}
case 268:{return rt.Call(f,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;CCC)[Ljava/lang/String;","invokestatic",271);}
case 271:{f.Locals[10]=f.Pop();f.Pc=273;continue;}
case 273:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=276;continue;}
case 276:{f.StackOp("dup");f.Pc=277;continue;}
case 277:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",280);}
case 280:{f.Locals[11]=f.Pop();f.Pc=282;continue;}
case 282:{f.Push(f.Locals[10]);f.Pc=284;continue;}
case 284:{f.Locals[12]=f.Pop();f.Pc=286;continue;}
case 286:{f.Push(f.Locals[12]);f.Pc=288;continue;}
case 288:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=289;continue;}
case 289:{f.Locals[13]=f.Pop();f.Pc=291;continue;}
case 291:{f.Push(JValue.I(0));f.Pc=292;continue;}
case 292:{f.Locals[14]=f.Pop();f.Pc=294;continue;}
case 294:{f.Push(f.Locals[14]);f.Pc=296;continue;}
case 296:{f.Push(f.Locals[13]);f.Pc=298;continue;}
case 298:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>=b?333:301;continue;}
case 301:{f.Push(f.Locals[12]);f.Pc=303;continue;}
case 303:{f.Push(f.Locals[14]);f.Pc=305;continue;}
case 305:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=306;continue;}
case 306:{f.Locals[15]=f.Pop();f.Pc=308;continue;}
case 308:{f.Push(f.Locals[11]);f.Pc=310;continue;}
case 310:{return rt.Call(f,"forge/StaticData","instance","()Lforge/StaticData;","invokestatic",313);}
case 313:{return rt.Call(f,"forge/StaticData","getCommonCards","()Lforge/card/CardDb;","invokevirtual",316);}
case 316:{f.Push(f.Locals[15]);f.Pc=318;continue;}
case 318:{return rt.Call(f,"forge/card/CardDb","getCard","(Ljava/lang/String;)Lforge/item/PaperCard;","invokevirtual",321);}
case 321:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",326);}
case 326:{f.StackOp("pop");f.Pc=327;continue;}
case 327:{f.Locals[14]=JValue.I(unchecked(f.Locals[14].Int+(1)));f.Pc=330;continue;}
case 330:{f.Pc=294;continue;}
case 333:{f.Push(f.Locals[11]);f.Pc=335;continue;}
case 335:{f.Locals[1]=f.Pop();f.Pc=336;continue;}
case 336:{return rt.DynamicCall(f,"forge/item/generation/BoosterGenerator:11465:336:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",341);}
case 341:{f.Locals[4]=f.Pop();f.Pc=343;continue;}
case 343:{f.Push(f.Locals[7]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"java/util/Iterator","remove","()V","invokeinterface",350);}
case 350:{f.Pc=80;continue;}
case 353:{f.Push(f.Locals[5]);f.Pc=355;continue;}
case 355:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",360);}
case 360:{f.Pc=f.Pop().Int==0?367:363;continue;}
case 363:{f.Push(JValue.R(null));f.Pc=364;continue;}
case 364:{f.Pc=381;continue;}
case 367:{f.Push(f.Locals[5]);f.Pc=369;continue;}
case 369:{f.Push(JValue.I(0));f.Pc=370;continue;}
case 370:{return rt.Call(f,"java/util/List","get","(I)Ljava/lang/Object;","invokeinterface",375);}
case 375:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=378;continue;}
case 378:{return rt.Call(f,"java/lang/String","trim","()Ljava/lang/String;","invokevirtual",381);}
case 381:{f.Locals[8]=f.Pop();f.Pc=383;continue;}
case 383:{f.Push(JValue.R(null));f.Pc=384;continue;}
case 384:{f.Push(f.Locals[8]);f.Pc=386;continue;}
case 386:{var b=f.Pop().Reference;var a=f.Pop().Reference;f.Pc=ReferenceEquals(a,b)?400:389;continue;}
case 389:{f.Push(f.Locals[8]);f.Pc=391;continue;}
case 391:{f.Push(JValue.R(rt.String("Any")));f.Pc=394;continue;}
case 394:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",397);}
case 397:{f.Pc=f.Pop().Int==0?424:400;continue;}
case 400:{f.Push(f.Locals[4]);f.Pc=402;continue;}
case 402:{f.Push(f.Locals[6]);f.Pc=404;continue;}
case 404:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",409);}
case 409:{f.Locals[9]=f.Pop();f.Pc=411;continue;}
case 411:{f.Push(f.Locals[2]);f.Pc=412;continue;}
case 412:{f.Push(f.Locals[1]);f.Pc=413;continue;}
case 413:{f.Push(f.Locals[9]);f.Pc=415;continue;}
case 415:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",418);}
case 418:{return rt.Call(f,"forge/card/PrintSheet","addAll","(Ljava/lang/Iterable;)V","invokevirtual",421);}
case 421:{f.Pc=688;continue;}
case 424:{f.Push(f.Locals[8]);f.Pc=426;continue;}
case 426:{f.Push(JValue.R(rt.String("UncommonRare")));f.Pc=429;continue;}
case 429:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",432);}
case 432:{f.Pc=f.Pop().Int==0?497:435;continue;}
case 435:{f.Push(f.Locals[4]);f.Pc=437;continue;}
case 437:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_RARE","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_RARE","Ljava/util/function/Predicate;"));f.Pc=440;continue;}
case 440:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",445);}
case 445:{f.Push(f.Locals[6]);f.Pc=447;continue;}
case 447:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",452);}
case 452:{f.Locals[9]=f.Pop();f.Pc=454;continue;}
case 454:{f.Push(f.Locals[2]);f.Pc=455;continue;}
case 455:{f.Push(f.Locals[1]);f.Pc=456;continue;}
case 456:{f.Push(f.Locals[9]);f.Pc=458;continue;}
case 458:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",461);}
case 461:{return rt.Call(f,"forge/card/PrintSheet","addAll","(Ljava/lang/Iterable;)V","invokevirtual",464);}
case 464:{f.Push(f.Locals[4]);f.Pc=466;continue;}
case 466:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_UNCOMMON","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_UNCOMMON","Ljava/util/function/Predicate;"));f.Pc=469;continue;}
case 469:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",474);}
case 474:{f.Push(f.Locals[6]);f.Pc=476;continue;}
case 476:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",481);}
case 481:{f.Locals[10]=f.Pop();f.Pc=483;continue;}
case 483:{f.Push(f.Locals[2]);f.Pc=484;continue;}
case 484:{f.Push(f.Locals[1]);f.Pc=485;continue;}
case 485:{f.Push(f.Locals[10]);f.Pc=487;continue;}
case 487:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",490);}
case 490:{f.Push(JValue.I(3));f.Pc=491;continue;}
case 491:{return rt.Call(f,"forge/card/PrintSheet","addAll","(Ljava/lang/Iterable;I)V","invokevirtual",494);}
case 494:{f.Pc=688;continue;}
case 497:{f.Push(f.Locals[8]);f.Pc=499;continue;}
case 499:{f.Push(JValue.R(rt.String("RareMythic")));f.Pc=502;continue;}
case 502:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",505);}
case 505:{f.Pc=f.Pop().Int==0?570:508;continue;}
case 508:{f.Push(f.Locals[4]);f.Pc=510;continue;}
case 510:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_MYTHIC_RARE","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_MYTHIC_RARE","Ljava/util/function/Predicate;"));f.Pc=513;continue;}
case 513:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",518);}
case 518:{f.Push(f.Locals[6]);f.Pc=520;continue;}
case 520:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",525);}
case 525:{f.Locals[9]=f.Pop();f.Pc=527;continue;}
case 527:{f.Push(f.Locals[2]);f.Pc=528;continue;}
case 528:{f.Push(f.Locals[1]);f.Pc=529;continue;}
case 529:{f.Push(f.Locals[9]);f.Pc=531;continue;}
case 531:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",534);}
case 534:{return rt.Call(f,"forge/card/PrintSheet","addAll","(Ljava/lang/Iterable;)V","invokevirtual",537);}
case 537:{f.Push(f.Locals[4]);f.Pc=539;continue;}
case 539:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_RARE","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_RARE","Ljava/util/function/Predicate;"));f.Pc=542;continue;}
case 542:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",547);}
case 547:{f.Push(f.Locals[6]);f.Pc=549;continue;}
case 549:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",554);}
case 554:{f.Locals[10]=f.Pop();f.Pc=556;continue;}
case 556:{f.Push(f.Locals[2]);f.Pc=557;continue;}
case 557:{f.Push(f.Locals[1]);f.Pc=558;continue;}
case 558:{f.Push(f.Locals[10]);f.Pc=560;continue;}
case 560:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",563);}
case 563:{f.Push(JValue.I(2));f.Pc=564;continue;}
case 564:{return rt.Call(f,"forge/card/PrintSheet","addAll","(Ljava/lang/Iterable;I)V","invokevirtual",567);}
case 567:{f.Pc=688;continue;}
case 570:{f.Push(f.Locals[8]);f.Pc=572;continue;}
case 572:{f.Push(JValue.R(rt.String("UncommonRareMythic")));f.Pc=575;continue;}
case 575:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",578);}
case 578:{f.Pc=f.Pop().Int==0?673:581;continue;}
case 581:{f.Push(f.Locals[4]);f.Pc=583;continue;}
case 583:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_MYTHIC_RARE","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_MYTHIC_RARE","Ljava/util/function/Predicate;"));f.Pc=586;continue;}
case 586:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",591);}
case 591:{f.Push(f.Locals[6]);f.Pc=593;continue;}
case 593:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",598);}
case 598:{f.Locals[9]=f.Pop();f.Pc=600;continue;}
case 600:{f.Push(f.Locals[2]);f.Pc=601;continue;}
case 601:{f.Push(f.Locals[1]);f.Pc=602;continue;}
case 602:{f.Push(f.Locals[9]);f.Pc=604;continue;}
case 604:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",607);}
case 607:{return rt.Call(f,"forge/card/PrintSheet","addAll","(Ljava/lang/Iterable;)V","invokevirtual",610);}
case 610:{f.Push(f.Locals[4]);f.Pc=612;continue;}
case 612:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_RARE","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_RARE","Ljava/util/function/Predicate;"));f.Pc=615;continue;}
case 615:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",620);}
case 620:{f.Push(f.Locals[6]);f.Pc=622;continue;}
case 622:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",627);}
case 627:{f.Locals[10]=f.Pop();f.Pc=629;continue;}
case 629:{f.Push(f.Locals[2]);f.Pc=630;continue;}
case 630:{f.Push(f.Locals[1]);f.Pc=631;continue;}
case 631:{f.Push(f.Locals[10]);f.Pc=633;continue;}
case 633:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",636);}
case 636:{f.Push(JValue.I(2));f.Pc=637;continue;}
case 637:{return rt.Call(f,"forge/card/PrintSheet","addAll","(Ljava/lang/Iterable;I)V","invokevirtual",640);}
case 640:{f.Push(f.Locals[4]);f.Pc=642;continue;}
case 642:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_UNCOMMON","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_UNCOMMON","Ljava/util/function/Predicate;"));f.Pc=645;continue;}
case 645:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",650);}
case 650:{f.Push(f.Locals[6]);f.Pc=652;continue;}
case 652:{return rt.Call(f,"java/util/function/Predicate","and","(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;","invokeinterface",657);}
case 657:{f.Locals[11]=f.Pop();f.Pc=659;continue;}
case 659:{f.Push(f.Locals[2]);f.Pc=660;continue;}
case 660:{f.Push(f.Locals[1]);f.Pc=661;continue;}
case 661:{f.Push(f.Locals[11]);f.Pc=663;continue;}
case 663:{return rt.Call(f,"forge/util/IterableUtil","filter","(Ljava/lang/Iterable;Ljava/util/function/Predicate;)Ljava/lang/Iterable;","invokestatic",666);}
case 666:{f.Push(JValue.I(4));f.Pc=667;continue;}
case 667:{return rt.Call(f,"forge/card/PrintSheet","addAll","(Ljava/lang/Iterable;I)V","invokevirtual",670);}
case 670:{f.Pc=688;continue;}
case 673:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=676;continue;}
case 676:{f.StackOp("dup");f.Pc=677;continue;}
case 677:{f.Push(f.Locals[8]);f.Pc=679;continue;}
case 679:{return rt.DynamicCall(f,"forge/item/generation/BoosterGenerator:11465:679:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",684);}
case 684:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",687);}
case 687:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 688:{f.Push(f.Locals[2]);f.Pc=689;continue;}
case 689:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11466(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/ArrayList"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/ArrayList")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/ArrayList","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",14);}
case 14:{f.Locals[2]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[2]);f.Pc=16;continue;}
case 16:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",21);}
case 21:{f.Pc=f.Pop().Int==0?748:24;continue;}
case 24:{f.Push(f.Locals[2]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",30);}
case 30:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=33;continue;}
case 33:{f.Locals[3]=f.Pop();f.Pc=34;continue;}
case 34:{f.Push(f.Locals[3]);f.Pc=35;continue;}
case 35:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","isEmpty","(Ljava/lang/CharSequence;)Z","invokestatic",38);}
case 38:{f.Pc=f.Pop().Int==0?50:41;continue;}
case 41:{f.Push(f.Locals[2]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"java/util/Iterator","remove","()V","invokeinterface",47);}
case 47:{f.Pc=15;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(JValue.R(rt.String("s")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"java/lang/String","endsWith","(Ljava/lang/String;)Z","invokevirtual",57);}
case 57:{f.Pc=f.Pop().Int==0?72:60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{f.Push(JValue.I(0));f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",66);}
case 66:{f.Push(JValue.I(1));f.Pc=67;continue;}
case 67:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=68;continue;}
case 68:{return rt.Call(f,"java/lang/String","substring","(II)Ljava/lang/String;","invokevirtual",71);}
case 71:{f.Locals[3]=f.Pop();f.Pc=72;continue;}
case 72:{f.Push(f.Locals[3]);f.Pc=73;continue;}
case 73:{f.Push(JValue.I(0));f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/lang/String","charAt","(I)C","invokevirtual",77);}
case 77:{f.Push(JValue.I(33));f.Pc=79;continue;}
case 79:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?86:82;continue;}
case 82:{f.Push(JValue.I(1));f.Pc=83;continue;}
case 83:{f.Pc=87;continue;}
case 86:{f.Push(JValue.I(0));f.Pc=87;continue;}
case 87:{f.Locals[4]=f.Pop();f.Pc=89;continue;}
case 89:{f.Push(f.Locals[4]);f.Pc=91;continue;}
case 91:{f.Pc=f.Pop().Int==0?100:94;continue;}
case 94:{f.Push(f.Locals[3]);f.Pc=95;continue;}
case 95:{f.Push(JValue.I(1));f.Pc=96;continue;}
case 96:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",99);}
case 99:{f.Locals[3]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(JValue.R(null));f.Pc=101;continue;}
case 101:{f.Locals[5]=f.Pop();f.Pc=103;continue;}
case 103:{f.Push(f.Locals[3]);f.Pc=104;continue;}
case 104:{f.Push(JValue.R(rt.String("dfc")));f.Pc=106;continue;}
case 106:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",109);}
case 109:{f.Pc=f.Pop().Int==0?122:112;continue;}
case 112:{return rt.DynamicCall(f,"forge/item/generation/BoosterGenerator:11466:112:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",117);}
case 117:{f.Locals[5]=f.Pop();f.Pc=119;continue;}
case 119:{f.Pc=708;continue;}
case 122:{f.Push(f.Locals[3]);f.Pc=123;continue;}
case 123:{f.Push(JValue.R(rt.String("Land")));f.Pc=126;continue;}
case 126:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",129);}
case 129:{f.Pc=f.Pop().Int==0?140:132;continue;}
case 132:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_LAND","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_LAND","Ljava/util/function/Predicate;"));f.Pc=135;continue;}
case 135:{f.Locals[5]=f.Pop();f.Pc=137;continue;}
case 137:{f.Pc=708;continue;}
case 140:{f.Push(f.Locals[3]);f.Pc=141;continue;}
case 141:{f.Push(JValue.R(rt.String("BasicLand")));f.Pc=144;continue;}
case 144:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",147);}
case 147:{f.Pc=f.Pop().Int==0?158:150;continue;}
case 150:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_BASIC_LAND_RARITY","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_BASIC_LAND_RARITY","Ljava/util/function/Predicate;"));f.Pc=153;continue;}
case 153:{f.Locals[5]=f.Pop();f.Pc=155;continue;}
case 155:{f.Pc=708;continue;}
case 158:{f.Push(f.Locals[3]);f.Pc=159;continue;}
case 159:{f.Push(JValue.R(rt.String("TimeShifted")));f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",165);}
case 165:{f.Pc=f.Pop().Int==0?176:168;continue;}
case 168:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_SPECIAL","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_SPECIAL","Ljava/util/function/Predicate;"));f.Pc=171;continue;}
case 171:{f.Locals[5]=f.Pop();f.Pc=173;continue;}
case 173:{f.Pc=708;continue;}
case 176:{f.Push(f.Locals[3]);f.Pc=177;continue;}
case 177:{f.Push(JValue.R(rt.String("Special")));f.Pc=180;continue;}
case 180:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",183);}
case 183:{f.Pc=f.Pop().Int==0?194:186;continue;}
case 186:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_SPECIAL","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_SPECIAL","Ljava/util/function/Predicate;"));f.Pc=189;continue;}
case 189:{f.Locals[5]=f.Pop();f.Pc=191;continue;}
case 191:{f.Pc=708;continue;}
case 194:{f.Push(f.Locals[3]);f.Pc=195;continue;}
case 195:{f.Push(JValue.R(rt.String("Mythic")));f.Pc=198;continue;}
case 198:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",201);}
case 201:{f.Pc=f.Pop().Int==0?212:204;continue;}
case 204:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_MYTHIC_RARE","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_MYTHIC_RARE","Ljava/util/function/Predicate;"));f.Pc=207;continue;}
case 207:{f.Locals[5]=f.Pop();f.Pc=209;continue;}
case 209:{f.Pc=708;continue;}
case 212:{f.Push(f.Locals[3]);f.Pc=213;continue;}
case 213:{f.Push(JValue.R(rt.String("Rare")));f.Pc=216;continue;}
case 216:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",219);}
case 219:{f.Pc=f.Pop().Int==0?230:222;continue;}
case 222:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_RARE","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_RARE","Ljava/util/function/Predicate;"));f.Pc=225;continue;}
case 225:{f.Locals[5]=f.Pop();f.Pc=227;continue;}
case 227:{f.Pc=708;continue;}
case 230:{f.Push(f.Locals[3]);f.Pc=231;continue;}
case 231:{f.Push(JValue.R(rt.String("Uncommon")));f.Pc=234;continue;}
case 234:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",237);}
case 237:{f.Pc=f.Pop().Int==0?248:240;continue;}
case 240:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_UNCOMMON","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_UNCOMMON","Ljava/util/function/Predicate;"));f.Pc=243;continue;}
case 243:{f.Locals[5]=f.Pop();f.Pc=245;continue;}
case 245:{f.Pc=708;continue;}
case 248:{f.Push(f.Locals[3]);f.Pc=249;continue;}
case 249:{f.Push(JValue.R(rt.String("Common")));f.Pc=252;continue;}
case 252:{return rt.Call(f,"java/lang/String","equalsIgnoreCase","(Ljava/lang/String;)Z","invokevirtual",255);}
case 255:{f.Pc=f.Pop().Int==0?266:258;continue;}
case 258:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_COMMON","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_COMMON","Ljava/util/function/Predicate;"));f.Pc=261;continue;}
case 261:{f.Locals[5]=f.Pop();f.Pc=263;continue;}
case 263:{f.Pc=708;continue;}
case 266:{f.Push(f.Locals[3]);f.Pc=267;continue;}
case 267:{f.Push(JValue.R(rt.String("name(")));f.Pc=270;continue;}
case 270:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",273);}
case 273:{f.Pc=f.Pop().Int==0?313:276;continue;}
case 276:{f.Push(f.Locals[3]);f.Pc=277;continue;}
case 277:{f.Push(JValue.I(4));f.Pc=278;continue;}
case 278:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",281);}
case 281:{f.Push(JValue.R(rt.String("() ")));f.Pc=284;continue;}
case 284:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","strip","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",287);}
case 287:{f.Locals[3]=f.Pop();f.Pc=288;continue;}
case 288:{f.Push(f.Locals[3]);f.Pc=289;continue;}
case 289:{f.Push(JValue.I(44));f.Pc=291;continue;}
case 291:{f.Push(JValue.I(34));f.Pc=293;continue;}
case 293:{f.Push(JValue.I(34));f.Pc=295;continue;}
case 295:{return rt.Call(f,"forge/util/TextUtil","splitWithParenthesis","(Ljava/lang/CharSequence;CCC)[Ljava/lang/String;","invokestatic",298);}
case 298:{f.Locals[6]=f.Pop();f.Pc=300;continue;}
case 300:{f.Push(f.Locals[6]);f.Pc=302;continue;}
case 302:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","([Ljava/lang/Object;)Ljava/util/ArrayList;","invokestatic",305);}
case 305:{return rt.Call(f,"forge/item/PaperCardPredicates","names","(Ljava/util/List;)Ljava/util/function/Predicate;","invokestatic",308);}
case 308:{f.Locals[5]=f.Pop();f.Pc=310;continue;}
case 310:{f.Pc=708;continue;}
case 313:{f.Push(f.Locals[3]);f.Pc=314;continue;}
case 314:{f.Push(JValue.R(rt.String("color(")));f.Pc=317;continue;}
case 317:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",320);}
case 320:{f.Pc=f.Pop().Int==0?604:323;continue;}
case 323:{f.Push(f.Locals[3]);f.Pc=324;continue;}
case 324:{f.Push(JValue.R(rt.String("color(")));f.Pc=327;continue;}
case 327:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",330);}
case 330:{f.Push(JValue.I(1));f.Pc=331;continue;}
case 331:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=332;continue;}
case 332:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",335);}
case 335:{f.Push(JValue.R(rt.String("()\" ")));f.Pc=338;continue;}
case 338:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","strip","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",341);}
case 341:{f.Locals[3]=f.Pop();f.Pc=342;continue;}
case 342:{f.Push(f.Locals[3]);f.Pc=343;continue;}
case 343:{return rt.Call(f,"java/lang/String","toLowerCase","()Ljava/lang/String;","invokevirtual",346);}
case 346:{f.Locals[6]=f.Pop();f.Pc=348;continue;}
case 348:{f.Push(JValue.I(-1));f.Pc=349;continue;}
case 349:{f.Locals[7]=f.Pop();f.Pc=351;continue;}
case 351:{f.Push(f.Locals[6]);f.Pc=353;continue;}
case 353:{return rt.Call(f,"java/lang/String","hashCode","()I","invokevirtual",356);}
case 356:{switch(f.Pop().Int){case 112785:f.Pc=467;break;case 3027034:f.Pc=433;break;case 93818879:f.Pc=416;break;case 98619139:f.Pc=450;break;case 113101865:f.Pc=484;break;case 1981638524:f.Pc=501;break;default:f.Pc=515;break;}continue;}
case 416:{f.Push(f.Locals[6]);f.Pc=418;continue;}
case 418:{f.Push(JValue.R(rt.String("black")));f.Pc=421;continue;}
case 421:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",424);}
case 424:{f.Pc=f.Pop().Int==0?515:427;continue;}
case 427:{f.Push(JValue.I(0));f.Pc=428;continue;}
case 428:{f.Locals[7]=f.Pop();f.Pc=430;continue;}
case 430:{f.Pc=515;continue;}
case 433:{f.Push(f.Locals[6]);f.Pc=435;continue;}
case 435:{f.Push(JValue.R(rt.String("blue")));f.Pc=438;continue;}
case 438:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",441);}
case 441:{f.Pc=f.Pop().Int==0?515:444;continue;}
case 444:{f.Push(JValue.I(1));f.Pc=445;continue;}
case 445:{f.Locals[7]=f.Pop();f.Pc=447;continue;}
case 447:{f.Pc=515;continue;}
case 450:{f.Push(f.Locals[6]);f.Pc=452;continue;}
case 452:{f.Push(JValue.R(rt.String("green")));f.Pc=455;continue;}
case 455:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",458);}
case 458:{f.Pc=f.Pop().Int==0?515:461;continue;}
case 461:{f.Push(JValue.I(2));f.Pc=462;continue;}
case 462:{f.Locals[7]=f.Pop();f.Pc=464;continue;}
case 464:{f.Pc=515;continue;}
case 467:{f.Push(f.Locals[6]);f.Pc=469;continue;}
case 469:{f.Push(JValue.R(rt.String("red")));f.Pc=472;continue;}
case 472:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",475);}
case 475:{f.Pc=f.Pop().Int==0?515:478;continue;}
case 478:{f.Push(JValue.I(3));f.Pc=479;continue;}
case 479:{f.Locals[7]=f.Pop();f.Pc=481;continue;}
case 481:{f.Pc=515;continue;}
case 484:{f.Push(f.Locals[6]);f.Pc=486;continue;}
case 486:{f.Push(JValue.R(rt.String("white")));f.Pc=489;continue;}
case 489:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",492);}
case 492:{f.Pc=f.Pop().Int==0?515:495;continue;}
case 495:{f.Push(JValue.I(4));f.Pc=496;continue;}
case 496:{f.Locals[7]=f.Pop();f.Pc=498;continue;}
case 498:{f.Pc=515;continue;}
case 501:{f.Push(f.Locals[6]);f.Pc=503;continue;}
case 503:{f.Push(JValue.R(rt.String("colorless")));f.Pc=506;continue;}
case 506:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",509);}
case 509:{f.Pc=f.Pop().Int==0?515:512;continue;}
case 512:{f.Push(JValue.I(5));f.Pc=513;continue;}
case 513:{f.Locals[7]=f.Pop();f.Pc=515;continue;}
case 515:{f.Push(f.Locals[7]);f.Pc=517;continue;}
case 517:{switch(f.Pop().Int){case 0:f.Pc=556;break;case 1:f.Pc=564;break;case 2:f.Pc=572;break;case 3:f.Pc=580;break;case 4:f.Pc=588;break;case 5:f.Pc=596;break;default:f.Pc=601;break;}continue;}
case 556:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_BLACK","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_BLACK","Ljava/util/function/Predicate;"));f.Pc=559;continue;}
case 559:{f.Locals[5]=f.Pop();f.Pc=561;continue;}
case 561:{f.Pc=601;continue;}
case 564:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_BLUE","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_BLUE","Ljava/util/function/Predicate;"));f.Pc=567;continue;}
case 567:{f.Locals[5]=f.Pop();f.Pc=569;continue;}
case 569:{f.Pc=601;continue;}
case 572:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_GREEN","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_GREEN","Ljava/util/function/Predicate;"));f.Pc=575;continue;}
case 575:{f.Locals[5]=f.Pop();f.Pc=577;continue;}
case 577:{f.Pc=601;continue;}
case 580:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_RED","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_RED","Ljava/util/function/Predicate;"));f.Pc=583;continue;}
case 583:{f.Locals[5]=f.Pop();f.Pc=585;continue;}
case 585:{f.Pc=601;continue;}
case 588:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_WHITE","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_WHITE","Ljava/util/function/Predicate;"));f.Pc=591;continue;}
case 591:{f.Locals[5]=f.Pop();f.Pc=593;continue;}
case 593:{f.Pc=601;continue;}
case 596:{if(!rt.StaticReady(f,"forge/item/PaperCardPredicates","IS_COLORLESS","Ljava/util/function/Predicate;"))return JStep.Continue;f.Push(rt.GetStatic("forge/item/PaperCardPredicates","IS_COLORLESS","Ljava/util/function/Predicate;"));f.Pc=599;continue;}
case 599:{f.Locals[5]=f.Pop();f.Pc=601;continue;}
case 601:{f.Pc=708;continue;}
case 604:{f.Push(f.Locals[3]);f.Pc=605;continue;}
case 605:{f.Push(JValue.R(rt.String("fromSets(")));f.Pc=608;continue;}
case 608:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",611);}
case 611:{f.Pc=f.Pop().Int==0?652:614;continue;}
case 614:{f.Push(f.Locals[3]);f.Pc=615;continue;}
case 615:{f.Push(JValue.R(rt.String("fromSets(")));f.Pc=618;continue;}
case 618:{return rt.Call(f,"java/lang/String","length","()I","invokevirtual",621);}
case 621:{f.Push(JValue.I(1));f.Pc=622;continue;}
case 622:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"iadd",a,b));f.Pc=623;continue;}
case 623:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",626);}
case 626:{f.Push(JValue.R(rt.String("()\" ")));f.Pc=629;continue;}
case 629:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","strip","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",632);}
case 632:{f.Locals[3]=f.Pop();f.Pc=633;continue;}
case 633:{f.Push(f.Locals[3]);f.Pc=634;continue;}
case 634:{f.Push(JValue.R(rt.String(",")));f.Pc=637;continue;}
case 637:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",640);}
case 640:{f.Locals[6]=f.Pop();f.Pc=642;continue;}
case 642:{f.Push(f.Locals[6]);f.Pc=644;continue;}
case 644:{return rt.Call(f,"forge/item/PaperCardPredicates","printedInSets","([Ljava/lang/String;)Ljava/util/function/Predicate;","invokestatic",647);}
case 647:{f.Locals[5]=f.Pop();f.Pc=649;continue;}
case 649:{f.Pc=708;continue;}
case 652:{f.Push(f.Locals[3]);f.Pc=653;continue;}
case 653:{f.Push(JValue.R(rt.String("fromSheet(")));f.Pc=656;continue;}
case 656:{return rt.Call(f,"java/lang/String","startsWith","(Ljava/lang/String;)Z","invokevirtual",659);}
case 659:{f.Pc=f.Pop().Int==0?708:662;continue;}
case 662:{f.Push(f.Locals[4]);f.Pc=664;continue;}
case 664:{f.Pc=f.Pop().Int==0?708:667;continue;}
case 667:{f.Push(f.Locals[3]);f.Pc=668;continue;}
case 668:{f.Push(JValue.I(9));f.Pc=670;continue;}
case 670:{return rt.Call(f,"java/lang/String","substring","(I)Ljava/lang/String;","invokevirtual",673);}
case 673:{f.Push(JValue.R(rt.String("()\" ")));f.Pc=676;continue;}
case 676:{return rt.Call(f,"org/apache/commons/lang3/StringUtils","strip","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;","invokestatic",679);}
case 679:{f.Locals[6]=f.Pop();f.Pc=681;continue;}
case 681:{f.Push(f.Locals[6]);f.Pc=683;continue;}
case 683:{return rt.Call(f,"forge/item/generation/BoosterGenerator","tryGetStaticSheet","(Ljava/lang/String;)Lforge/card/PrintSheet;","invokestatic",686);}
case 686:{return rt.Call(f,"forge/card/PrintSheet","toFlatList","()Ljava/util/List;","invokevirtual",689);}
case 689:{return rt.Call(f,"com/google/common/collect/Sets","newHashSet","(Ljava/lang/Iterable;)Ljava/util/HashSet;","invokestatic",692);}
case 692:{f.Locals[7]=f.Pop();f.Pc=694;continue;}
case 694:{f.Push(f.Locals[7]);f.Pc=696;continue;}
case 696:{f.StackOp("dup");f.Pc=697;continue;}
case 697:{return rt.Call(f,"java/util/Objects","requireNonNull","(Ljava/lang/Object;)Ljava/lang/Object;","invokestatic",700);}
case 700:{f.StackOp("pop");f.Pc=701;continue;}
case 701:{return rt.DynamicCall(f,"forge/item/generation/BoosterGenerator:11466:701:java/lang/invoke/LambdaMetafactory.metafactory","(Ljava/util/Set;)Ljava/util/function/Predicate;",706);}
case 706:{f.Locals[5]=f.Pop();f.Pc=708;continue;}
case 708:{f.Push(f.Locals[5]);f.Pc=710;continue;}
case 710:{f.Pc=f.Pop().Reference!=null?716:713;continue;}
case 713:{f.Pc=15;continue;}
case 716:{f.Push(f.Locals[2]);f.Pc=717;continue;}
case 717:{return rt.Call(f,"java/util/Iterator","remove","()V","invokeinterface",722);}
case 722:{f.Push(f.Locals[4]);f.Pc=724;continue;}
case 724:{f.Pc=f.Pop().Int==0?736:727;continue;}
case 727:{f.Push(f.Locals[5]);f.Pc=729;continue;}
case 729:{return rt.Call(f,"java/util/function/Predicate","negate","()Ljava/util/function/Predicate;","invokeinterface",734);}
case 734:{f.Locals[5]=f.Pop();f.Pc=736;continue;}
case 736:{f.Push(f.Locals[1]);f.Pc=737;continue;}
case 737:{f.Push(f.Locals[5]);f.Pc=739;continue;}
case 739:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",744);}
case 744:{f.StackOp("pop");f.Pc=745;continue;}
case 745:{f.Pc=15;continue;}
case 748:{f.Push(f.Locals[1]);f.Pc=749;continue;}
case 749:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",754);}
case 754:{f.Pc=f.Pop().Int==0?763:757;continue;}
case 757:{return rt.DynamicCall(f,"forge/item/generation/BoosterGenerator:11466:757:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Predicate;",762);}
case 762:{return JStep.Return(f.Pop());}
case 763:{f.Push(f.Locals[1]);f.Pc=764;continue;}
case 764:{return rt.Call(f,"forge/util/IterableUtil","and","(Ljava/lang/Iterable;)Ljava/util/function/Predicate;","invokestatic",767);}
case 767:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11467(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11468(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/card/CardSplitType","DUAL_FACED_CARDS","Ljava/util/EnumSet;"))return JStep.Continue;f.Push(rt.GetStatic("forge/card/CardSplitType","DUAL_FACED_CARDS","Ljava/util/EnumSet;"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/item/PaperCard","getRules","()Lforge/card/CardRules;","invokevirtual",7);}
case 7:{return rt.Call(f,"forge/card/CardRules","getSplitType","()Lforge/card/CardSplitType;","invokevirtual",10);}
case 10:{return rt.Call(f,"java/util/EnumSet","contains","(Ljava/lang/Object;)Z","invokevirtual",13);}
case 13:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11469(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11470(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11471(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(1));f.Pc=1;continue;}
case 1:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M11472(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/util/HashMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/HashMap")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/HashMap","<init>","()V","invokespecial",7);}
case 7:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator","staticSheetsCorrespondance","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/item/generation/BoosterGenerator","staticSheetsCorrespondance","Ljava/util/Map;",f.Pop());f.Pc=10;continue;}
case 10:{if(!rt.EnsureInitialized(f,"java/util/TreeMap"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/util/TreeMap")));f.Pc=13;continue;}
case 13:{f.StackOp("dup");f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"))return JStep.Continue;f.Push(rt.GetStatic("java/lang/String","CASE_INSENSITIVE_ORDER","Ljava/util/Comparator;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/TreeMap","<init>","(Ljava/util/Comparator;)V","invokespecial",20);}
case 20:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator","cachedSheets","Ljava/util/Map;"))return JStep.Continue;rt.PutStatic("forge/item/generation/BoosterGenerator","cachedSheets","Ljava/util/Map;",f.Pop());f.Pc=23;continue;}
case 23:{if(!rt.EnsureInitialized(f,"java/lang/ThreadLocal"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/ThreadLocal")));f.Pc=26;continue;}
case 26:{f.StackOp("dup");f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/ThreadLocal","<init>","()V","invokespecial",30);}
case 30:{if(!rt.StaticReady(f,"forge/item/generation/BoosterGenerator","EXCLUDED_NAMES","Ljava/lang/ThreadLocal;"))return JStep.Continue;rt.PutStatic("forge/item/generation/BoosterGenerator","EXCLUDED_NAMES","Ljava/lang/ThreadLocal;",f.Pop());f.Pc=33;continue;}
case 33:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
