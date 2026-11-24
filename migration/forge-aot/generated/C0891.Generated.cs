// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C891{
internal static JClass Build(){var c=new JClass("forge/game/trigger/TriggerAttackerBlockedByCreature","forge/game/trigger/Trigger",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(10204,"forge/game/trigger/TriggerAttackerBlockedByCreature","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V",1,4,4,new JHandler[]{},M10204));
c.Add(new JMethod(10205,"forge/game/trigger/TriggerAttackerBlockedByCreature","performTest","(Ljava/util/Map;)Z",17,5,4,new JHandler[]{},M10205));
c.Add(new JMethod(10206,"forge/game/trigger/TriggerAttackerBlockedByCreature","setTriggeringObjects","(Ljava/util/Map;Ljava/util/Map;)V",17,3,6,new JHandler[]{},M10206));
c.Add(new JMethod(10207,"forge/game/trigger/TriggerAttackerBlockedByCreature","getImportantStackObjects","(Lforge/game/spellability/SpellAbility;)Ljava/lang/String;",1,3,4,new JHandler[]{},M10207));
}

internal static JStep M10204(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{f.Push(f.Locals[3]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/trigger/Trigger","<init>","(Ljava/util/Map;Lforge/game/card/Card;Z)V","invokespecial",7);}
case 7:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10205(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",9);}
case 9:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=12;continue;}
case 12:{f.Locals[2]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Blocker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Blocker","Lforge/game/ability/AbilityKey;"));f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",22);}
case 22:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=25;continue;}
case 25:{f.Locals[3]=f.Pop();f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=29;continue;}
case 29:{return rt.Call(f,"forge/game/trigger/TriggerAttackerBlockedByCreature","hasParam","(Ljava/lang/String;)Z","invokevirtual",32);}
case 32:{f.Pc=f.Pop().Int==0?83:35;continue;}
case 35:{f.Push(f.Locals[0]);f.Pc=36;continue;}
case 36:{f.Push(JValue.R(rt.String("ValidCard")));f.Pc=38;continue;}
case 38:{return rt.Call(f,"forge/game/trigger/TriggerAttackerBlockedByCreature","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",41);}
case 41:{f.Locals[4]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[4]);f.Pc=45;continue;}
case 45:{f.Push(JValue.R(rt.String("LessPowerThanBlocker")));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",50);}
case 50:{f.Pc=f.Pop().Int==0?66:53;continue;}
case 53:{f.Push(f.Locals[2]);f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",57);}
case 57:{f.Push(f.Locals[3]);f.Pc=58;continue;}
case 58:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",61);}
case 61:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?83:64;continue;}
case 64:{f.Push(JValue.I(0));f.Pc=65;continue;}
case 65:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 66:{f.Push(f.Locals[0]);f.Pc=67;continue;}
case 67:{f.Push(f.Locals[2]);f.Pc=68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{f.Push(JValue.R(rt.String(",")));f.Pc=72;continue;}
case 72:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",75);}
case 75:{return rt.Call(f,"forge/game/trigger/TriggerAttackerBlockedByCreature","matchesValid","(Ljava/lang/Object;[Ljava/lang/String;)Z","invokevirtual",78);}
case 78:{f.Pc=f.Pop().Int!=0?83:81;continue;}
case 81:{f.Push(JValue.I(0));f.Pc=82;continue;}
case 82:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 83:{f.Push(f.Locals[0]);f.Pc=84;continue;}
case 84:{f.Push(JValue.R(rt.String("ValidBlocker")));f.Pc=86;continue;}
case 86:{return rt.Call(f,"forge/game/trigger/TriggerAttackerBlockedByCreature","hasParam","(Ljava/lang/String;)Z","invokevirtual",89);}
case 89:{f.Pc=f.Pop().Int==0?140:92;continue;}
case 92:{f.Push(f.Locals[0]);f.Pc=93;continue;}
case 93:{f.Push(JValue.R(rt.String("ValidBlocker")));f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/trigger/TriggerAttackerBlockedByCreature","getParam","(Ljava/lang/String;)Ljava/lang/String;","invokevirtual",98);}
case 98:{f.Locals[4]=f.Pop();f.Pc=100;continue;}
case 100:{f.Push(f.Locals[4]);f.Pc=102;continue;}
case 102:{f.Push(JValue.R(rt.String("LessPowerThanAttacker")));f.Pc=104;continue;}
case 104:{return rt.Call(f,"java/lang/String","equals","(Ljava/lang/Object;)Z","invokevirtual",107);}
case 107:{f.Pc=f.Pop().Int==0?123:110;continue;}
case 110:{f.Push(f.Locals[3]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",114);}
case 114:{f.Push(f.Locals[2]);f.Pc=115;continue;}
case 115:{return rt.Call(f,"forge/game/card/Card","getNetPower","()I","invokevirtual",118);}
case 118:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?140:121;continue;}
case 121:{f.Push(JValue.I(0));f.Pc=122;continue;}
case 122:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 123:{f.Push(f.Locals[0]);f.Pc=124;continue;}
case 124:{f.Push(f.Locals[3]);f.Pc=125;continue;}
case 125:{f.Push(f.Locals[4]);f.Pc=127;continue;}
case 127:{f.Push(JValue.R(rt.String(",")));f.Pc=129;continue;}
case 129:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",132);}
case 132:{return rt.Call(f,"forge/game/trigger/TriggerAttackerBlockedByCreature","matchesValid","(Ljava/lang/Object;[Ljava/lang/String;)Z","invokevirtual",135);}
case 135:{f.Pc=f.Pop().Int!=0?140:138;continue;}
case 138:{f.Push(JValue.I(0));f.Pc=139;continue;}
case 139:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 140:{f.Push(JValue.I(1));f.Pc=141;continue;}
case 141:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10206(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[2]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(JValue.I(2));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.NewArray("Lforge/game/ability/AbilityKey;",f.Pop().Int)));f.Pc=6;continue;}
case 6:{f.StackOp("dup");f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=11;continue;}
case 11:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=12;continue;}
case 12:{f.StackOp("dup");f.Pc=13;continue;}
case 13:{f.Push(JValue.I(1));f.Pc=14;continue;}
case 14:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Blocker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Blocker","Lforge/game/ability/AbilityKey;"));f.Pc=17;continue;}
case 17:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/ability/AbilityKey","copyKeys","(Ljava/util/Map;Ljava/util/Map;[Lforge/game/ability/AbilityKey;)V","invokestatic",21);}
case 21:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M10207(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[2]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[2]);f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",12);}
case 12:{f.Push(JValue.R(rt.String("lblAttacker")));f.Pc=14;continue;}
case 14:{f.Push(JValue.I(0));f.Pc=15;continue;}
case 15:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",21);}
case 21:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",24);}
case 24:{f.Push(JValue.R(rt.String(": ")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",29);}
case 29:{f.Push(f.Locals[1]);f.Pc=30;continue;}
case 30:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Attacker","Lforge/game/ability/AbilityKey;"));f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",36);}
case 36:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",39);}
case 39:{f.Push(JValue.R(rt.String(", ")));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",44);}
case 44:{f.StackOp("pop");f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{return rt.Call(f,"forge/util/Localizer","getInstance","()Lforge/util/Localizer;","invokestatic",49);}
case 49:{f.Push(JValue.R(rt.String("lblBlocker")));f.Pc=51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/util/Localizer","getMessage","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokevirtual",58);}
case 58:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",61);}
case 61:{f.Push(JValue.R(rt.String(": ")));f.Pc=63;continue;}
case 63:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",66);}
case 66:{f.Push(f.Locals[1]);f.Pc=67;continue;}
case 67:{if(!rt.StaticReady(f,"forge/game/ability/AbilityKey","Blocker","Lforge/game/ability/AbilityKey;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityKey","Blocker","Lforge/game/ability/AbilityKey;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"forge/game/spellability/SpellAbility","getTriggeringObject","(Lforge/game/ability/AbilityKey;)Ljava/lang/Object;","invokevirtual",73);}
case 73:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",76);}
case 76:{f.StackOp("pop");f.Pc=77;continue;}
case 77:{f.Push(f.Locals[2]);f.Pc=78;continue;}
case 78:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",81);}
case 81:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
