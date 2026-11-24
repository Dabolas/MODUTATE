// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C182{
internal static JClass Build(){var c=new JClass("forge/game/ability/AbilityFactory$AbilityRecordType","java/lang/Enum",new string[]{},16433);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("Ability","Lforge/game/ability/AbilityFactory$AbilityRecordType;",true,JValue.Default("Lforge/game/ability/AbilityFactory$AbilityRecordType;"),null));
c.Add(new JField("Spell","Lforge/game/ability/AbilityFactory$AbilityRecordType;",true,JValue.Default("Lforge/game/ability/AbilityFactory$AbilityRecordType;"),null));
c.Add(new JField("StaticAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;",true,JValue.Default("Lforge/game/ability/AbilityFactory$AbilityRecordType;"),null));
c.Add(new JField("SubAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;",true,JValue.Default("Lforge/game/ability/AbilityFactory$AbilityRecordType;"),null));
c.Add(new JField("prefix","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("$VALUES","[Lforge/game/ability/AbilityFactory$AbilityRecordType;",true,JValue.Default("[Lforge/game/ability/AbilityFactory$AbilityRecordType;"),null));
c.Add(new JMethod(2802,"forge/game/ability/AbilityFactory$AbilityRecordType","values","()[Lforge/game/ability/AbilityFactory$AbilityRecordType;",9,0,1,new JHandler[]{},M2802));
c.Add(new JMethod(2803,"forge/game/ability/AbilityFactory$AbilityRecordType","valueOf","(Ljava/lang/String;)Lforge/game/ability/AbilityFactory$AbilityRecordType;",9,1,2,new JHandler[]{},M2803));
c.Add(new JMethod(2804,"forge/game/ability/AbilityFactory$AbilityRecordType","<init>","(Ljava/lang/String;ILjava/lang/String;)V",2,4,3,new JHandler[]{},M2804));
c.Add(new JMethod(2805,"forge/game/ability/AbilityFactory$AbilityRecordType","getPrefix","()Ljava/lang/String;",1,1,1,new JHandler[]{},M2805));
c.Add(new JMethod(2806,"forge/game/ability/AbilityFactory$AbilityRecordType","buildSpellAbility","(Lforge/game/ability/ApiType;Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;Ljava/util/Map;)Lforge/game/spellability/SpellAbility;",1,6,7,new JHandler[]{},M2806));
c.Add(new JMethod(2807,"forge/game/ability/AbilityFactory$AbilityRecordType","getApiTypeOf","(Ljava/util/Map;)Lforge/game/ability/ApiType;",1,2,2,new JHandler[]{},M2807));
c.Add(new JMethod(2808,"forge/game/ability/AbilityFactory$AbilityRecordType","getRecordType","(Ljava/util/Map;)Lforge/game/ability/AbilityFactory$AbilityRecordType;",9,1,2,new JHandler[]{},M2808));
c.Add(new JMethod(2809,"forge/game/ability/AbilityFactory$AbilityRecordType","$values","()[Lforge/game/ability/AbilityFactory$AbilityRecordType;",4106,0,4,new JHandler[]{},M2809));
c.Add(new JMethod(2810,"forge/game/ability/AbilityFactory$AbilityRecordType","<clinit>","()V",8,0,5,new JHandler[]{},M2810));
}

internal static JStep M2802(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","$VALUES","[Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","$VALUES","[Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=3;continue;}
case 3:{return rt.Call(f,"[Lforge/game/ability/AbilityFactory$AbilityRecordType;","clone","()Ljava/lang/Object;","invokevirtual",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"[Lforge/game/ability/AbilityFactory$AbilityRecordType;"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2803(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.ClassObject("forge/game/ability/AbilityFactory$AbilityRecordType")));f.Pc=2;continue;}
case 2:{f.Push(f.Locals[0]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","valueOf","(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;","invokestatic",6);}
case 6:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/ability/AbilityFactory$AbilityRecordType"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=9;continue;}
case 9:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2804(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"java/lang/Enum","<init>","(Ljava/lang/String;I)V","invokespecial",6);}
case 6:{f.Push(f.Locals[0]);f.Pc=7;continue;}
case 7:{f.Push(f.Locals[3]);f.Pc=8;continue;}
case 8:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/ability/AbilityFactory$AbilityRecordType","prefix","Ljava/lang/String;",value);f.Pc=11;continue;}
case 11:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2805(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/ability/AbilityFactory$AbilityRecordType","prefix","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2806(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$1","$SwitchMap$forge$game$ability$AbilityFactory$AbilityRecordType","[I"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$1","$SwitchMap$forge$game$ability$AbilityFactory$AbilityRecordType","[I"));f.Pc=3;continue;}
case 3:{f.Push(f.Locals[0]);f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","ordinal","()I","invokevirtual",7);}
case 7:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=8;continue;}
case 8:{switch(f.Pop().Int){case 1:f.Pc=40;break;case 2:f.Pc=55;break;case 3:f.Pc=70;break;case 4:f.Pc=85;break;default:f.Pc=99;break;}continue;}
case 40:{if(!rt.EnsureInitialized(f,"forge/game/ability/AbilityApiBased"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/AbilityApiBased")));f.Pc=43;continue;}
case 43:{f.StackOp("dup");f.Pc=44;continue;}
case 44:{f.Push(f.Locals[1]);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[2]);f.Pc=46;continue;}
case 46:{f.Push(f.Locals[3]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[4]);f.Pc=49;continue;}
case 49:{f.Push(f.Locals[5]);f.Pc=51;continue;}
case 51:{return rt.Call(f,"forge/game/ability/AbilityApiBased","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;Ljava/util/Map;)V","invokespecial",54);}
case 54:{return JStep.Return(f.Pop());}
case 55:{if(!rt.EnsureInitialized(f,"forge/game/ability/SpellApiBased"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/SpellApiBased")));f.Pc=58;continue;}
case 58:{f.StackOp("dup");f.Pc=59;continue;}
case 59:{f.Push(f.Locals[1]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[2]);f.Pc=61;continue;}
case 61:{f.Push(f.Locals[3]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[4]);f.Pc=64;continue;}
case 64:{f.Push(f.Locals[5]);f.Pc=66;continue;}
case 66:{return rt.Call(f,"forge/game/ability/SpellApiBased","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;Ljava/util/Map;)V","invokespecial",69);}
case 69:{return JStep.Return(f.Pop());}
case 70:{if(!rt.EnsureInitialized(f,"forge/game/ability/StaticAbilityApiBased"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/StaticAbilityApiBased")));f.Pc=73;continue;}
case 73:{f.StackOp("dup");f.Pc=74;continue;}
case 74:{f.Push(f.Locals[1]);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[2]);f.Pc=76;continue;}
case 76:{f.Push(f.Locals[3]);f.Pc=77;continue;}
case 77:{f.Push(f.Locals[4]);f.Pc=79;continue;}
case 79:{f.Push(f.Locals[5]);f.Pc=81;continue;}
case 81:{return rt.Call(f,"forge/game/ability/StaticAbilityApiBased","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;Lforge/game/cost/Cost;Lforge/game/spellability/TargetRestrictions;Ljava/util/Map;)V","invokespecial",84);}
case 84:{return JStep.Return(f.Pop());}
case 85:{if(!rt.EnsureInitialized(f,"forge/game/spellability/AbilitySub"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/spellability/AbilitySub")));f.Pc=88;continue;}
case 88:{f.StackOp("dup");f.Pc=89;continue;}
case 89:{f.Push(f.Locals[1]);f.Pc=90;continue;}
case 90:{f.Push(f.Locals[2]);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[4]);f.Pc=93;continue;}
case 93:{f.Push(f.Locals[5]);f.Pc=95;continue;}
case 95:{return rt.Call(f,"forge/game/spellability/AbilitySub","<init>","(Lforge/game/ability/ApiType;Lforge/game/card/Card;Lforge/game/spellability/TargetRestrictions;Ljava/util/Map;)V","invokespecial",98);}
case 98:{return JStep.Return(f.Pop());}
case 99:{f.Push(JValue.R(null));f.Pc=100;continue;}
case 100:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2807(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[1]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[0]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","getPrefix","()Ljava/lang/String;","invokevirtual",5);}
case 5:{return rt.Call(f,"java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;","invokeinterface",10);}
case 10:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/String"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=13;continue;}
case 13:{return rt.Call(f,"forge/game/ability/ApiType","smartValueOf","(Ljava/lang/String;)Lforge/game/ability/ApiType;","invokestatic",16);}
case 16:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2808(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","Ability","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","Ability","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","getPrefix","()Ljava/lang/String;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",12);}
case 12:{f.Pc=f.Pop().Int==0?19:15;continue;}
case 15:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","Ability","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","Ability","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=18;continue;}
case 18:{return JStep.Return(f.Pop());}
case 19:{f.Push(f.Locals[0]);f.Pc=20;continue;}
case 20:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","Spell","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","Spell","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","getPrefix","()Ljava/lang/String;","invokevirtual",26);}
case 26:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",31);}
case 31:{f.Pc=f.Pop().Int==0?38:34;continue;}
case 34:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","Spell","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","Spell","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=37;continue;}
case 37:{return JStep.Return(f.Pop());}
case 38:{f.Push(f.Locals[0]);f.Pc=39;continue;}
case 39:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","StaticAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","StaticAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","getPrefix","()Ljava/lang/String;","invokevirtual",45);}
case 45:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",50);}
case 50:{f.Pc=f.Pop().Int==0?57:53;continue;}
case 53:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","StaticAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","StaticAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=56;continue;}
case 56:{return JStep.Return(f.Pop());}
case 57:{f.Push(f.Locals[0]);f.Pc=58;continue;}
case 58:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","SubAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","SubAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=61;continue;}
case 61:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","getPrefix","()Ljava/lang/String;","invokevirtual",64);}
case 64:{return rt.Call(f,"java/util/Map","containsKey","(Ljava/lang/Object;)Z","invokeinterface",69);}
case 69:{f.Pc=f.Pop().Int==0?76:72;continue;}
case 72:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","SubAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","SubAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=75;continue;}
case 75:{return JStep.Return(f.Pop());}
case 76:{f.Push(JValue.R(null));f.Pc=77;continue;}
case 77:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2809(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.I(4));f.Pc=1;continue;}
case 1:{f.Push(JValue.R(rt.NewArray("Lforge/game/ability/AbilityFactory$AbilityRecordType;",f.Pop().Int)));f.Pc=4;continue;}
case 4:{f.StackOp("dup");f.Pc=5;continue;}
case 5:{f.Push(JValue.I(0));f.Pc=6;continue;}
case 6:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","Ability","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","Ability","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=9;continue;}
case 9:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=10;continue;}
case 10:{f.StackOp("dup");f.Pc=11;continue;}
case 11:{f.Push(JValue.I(1));f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","Spell","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","Spell","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=15;continue;}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(2));f.Pc=18;continue;}
case 18:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","StaticAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","StaticAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=21;continue;}
case 21:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(JValue.I(3));f.Pc=24;continue;}
case 24:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","SubAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/ability/AbilityFactory$AbilityRecordType","SubAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"));f.Pc=27;continue;}
case 27:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=28;continue;}
case 28:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M2810(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/ability/AbilityFactory$AbilityRecordType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/AbilityFactory$AbilityRecordType")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(JValue.R(rt.String("Ability")));f.Pc=6;continue;}
case 6:{f.Push(JValue.I(0));f.Pc=7;continue;}
case 7:{f.Push(JValue.R(rt.String("AB")));f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",12);}
case 12:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","Ability","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;rt.PutStatic("forge/game/ability/AbilityFactory$AbilityRecordType","Ability","Lforge/game/ability/AbilityFactory$AbilityRecordType;",f.Pop());f.Pc=15;continue;}
case 15:{if(!rt.EnsureInitialized(f,"forge/game/ability/AbilityFactory$AbilityRecordType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/AbilityFactory$AbilityRecordType")));f.Pc=18;continue;}
case 18:{f.StackOp("dup");f.Pc=19;continue;}
case 19:{f.Push(JValue.R(rt.String("Spell")));f.Pc=21;continue;}
case 21:{f.Push(JValue.I(1));f.Pc=22;continue;}
case 22:{f.Push(JValue.R(rt.String("SP")));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",27);}
case 27:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","Spell","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;rt.PutStatic("forge/game/ability/AbilityFactory$AbilityRecordType","Spell","Lforge/game/ability/AbilityFactory$AbilityRecordType;",f.Pop());f.Pc=30;continue;}
case 30:{if(!rt.EnsureInitialized(f,"forge/game/ability/AbilityFactory$AbilityRecordType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/AbilityFactory$AbilityRecordType")));f.Pc=33;continue;}
case 33:{f.StackOp("dup");f.Pc=34;continue;}
case 34:{f.Push(JValue.R(rt.String("StaticAbility")));f.Pc=36;continue;}
case 36:{f.Push(JValue.I(2));f.Pc=37;continue;}
case 37:{f.Push(JValue.R(rt.String("ST")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",42);}
case 42:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","StaticAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;rt.PutStatic("forge/game/ability/AbilityFactory$AbilityRecordType","StaticAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;",f.Pop());f.Pc=45;continue;}
case 45:{if(!rt.EnsureInitialized(f,"forge/game/ability/AbilityFactory$AbilityRecordType"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/ability/AbilityFactory$AbilityRecordType")));f.Pc=48;continue;}
case 48:{f.StackOp("dup");f.Pc=49;continue;}
case 49:{f.Push(JValue.R(rt.String("SubAbility")));f.Pc=51;continue;}
case 51:{f.Push(JValue.I(3));f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("DB")));f.Pc=54;continue;}
case 54:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","<init>","(Ljava/lang/String;ILjava/lang/String;)V","invokespecial",57);}
case 57:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","SubAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;rt.PutStatic("forge/game/ability/AbilityFactory$AbilityRecordType","SubAbility","Lforge/game/ability/AbilityFactory$AbilityRecordType;",f.Pop());f.Pc=60;continue;}
case 60:{return rt.Call(f,"forge/game/ability/AbilityFactory$AbilityRecordType","$values","()[Lforge/game/ability/AbilityFactory$AbilityRecordType;","invokestatic",63);}
case 63:{if(!rt.StaticReady(f,"forge/game/ability/AbilityFactory$AbilityRecordType","$VALUES","[Lforge/game/ability/AbilityFactory$AbilityRecordType;"))return JStep.Continue;rt.PutStatic("forge/game/ability/AbilityFactory$AbilityRecordType","$VALUES","[Lforge/game/ability/AbilityFactory$AbilityRecordType;",f.Pop());f.Pc=66;continue;}
case 66:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
