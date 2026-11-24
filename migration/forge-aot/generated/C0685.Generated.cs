// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C685{
internal static JClass Build(){var c=new JClass("forge/game/mana/ManaRefundService","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("sa","Lforge/game/spellability/SpellAbility;",false,JValue.Default("Lforge/game/spellability/SpellAbility;"),null));
c.Add(new JMethod(7796,"forge/game/mana/ManaRefundService","<init>","(Lforge/game/spellability/SpellAbility;)V",1,2,2,new JHandler[]{},M7796));
c.Add(new JMethod(7797,"forge/game/mana/ManaRefundService","refundManaPaid","()V",1,9,7,new JHandler[]{},M7797));
}

internal static JStep M7796(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(f.Locals[1]);f.Pc=6;continue;}
case 6:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/mana/ManaRefundService","sa","Lforge/game/spellability/SpellAbility;",value);f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7797(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/player/PlayerCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/player/PlayerCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaRefundService","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/spellability/SpellAbility","getActivatingPlayer","()Lforge/game/player/Player;","invokevirtual",11);}
case 11:{return rt.Call(f,"forge/game/player/PlayerCollection","<init>","(Lforge/game/player/Player;)V","invokespecial",14);}
case 14:{f.Locals[1]=f.Pop();f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaRefundService","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=19;continue;}
case 19:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingMana","()Ljava/util/List;","invokevirtual",22);}
case 22:{return rt.Call(f,"java/util/List","stream","()Ljava/util/stream/Stream;","invokeinterface",27);}
case 27:{return rt.DynamicCall(f,"forge/game/mana/ManaRefundService:7797:27:java/lang/invoke/LambdaMetafactory.metafactory","()Ljava/util/function/Function;",32);}
case 32:{return rt.Call(f,"java/util/stream/Collectors","groupingBy","(Ljava/util/function/Function;)Ljava/util/stream/Collector;","invokestatic",35);}
case 35:{return rt.Call(f,"java/util/stream/Stream","collect","(Ljava/util/stream/Collector;)Ljava/lang/Object;","invokeinterface",40);}
case 40:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/util/Map","entrySet","()Ljava/util/Set;","invokeinterface",48);}
case 48:{return rt.Call(f,"java/util/Set","iterator","()Ljava/util/Iterator;","invokeinterface",53);}
case 53:{f.Locals[2]=f.Pop();f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",60);}
case 60:{f.Pc=f.Pop().Int==0?114:63;continue;}
case 63:{f.Push(f.Locals[2]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",69);}
case 69:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/util/Map$Entry"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=72;continue;}
case 72:{f.Locals[3]=f.Pop();f.Pc=73;continue;}
case 73:{f.Push(f.Locals[3]);f.Pc=74;continue;}
case 74:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",79);}
case 79:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=82;continue;}
case 82:{return rt.Call(f,"forge/game/player/Player","getManaPool","()Lforge/game/mana/ManaPool;","invokevirtual",85);}
case 85:{f.Push(f.Locals[3]);f.Pc=86;continue;}
case 86:{return rt.Call(f,"java/util/Map$Entry","getValue","()Ljava/lang/Object;","invokeinterface",91);}
case 91:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"java/lang/Iterable"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=94;continue;}
case 94:{return rt.Call(f,"forge/game/mana/ManaPool","addMana","(Ljava/lang/Iterable;)V","invokevirtual",97);}
case 97:{f.Push(f.Locals[1]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/util/Map$Entry","getKey","()Ljava/lang/Object;","invokeinterface",104);}
case 104:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=107;continue;}
case 107:{return rt.Call(f,"forge/game/player/PlayerCollection","add","(Ljava/lang/Object;)Z","invokevirtual",110);}
case 110:{f.StackOp("pop");f.Pc=111;continue;}
case 111:{f.Pc=54;continue;}
case 114:{f.Push(f.Locals[0]);f.Pc=115;continue;}
case 115:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaRefundService","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=118;continue;}
case 118:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingMana","()Ljava/util/List;","invokevirtual",121);}
case 121:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",126);}
case 126:{f.Push(f.Locals[0]);f.Pc=127;continue;}
case 127:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaRefundService","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=130;continue;}
case 130:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingManaAbilities","()Ljava/util/List;","invokevirtual",133);}
case 133:{f.Locals[2]=f.Pop();f.Pc=134;continue;}
case 134:{f.Push(f.Locals[2]);f.Pc=135;continue;}
case 135:{return rt.Call(f,"java/util/Collections","reverse","(Ljava/util/List;)V","invokestatic",138);}
case 138:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",141);}
case 141:{f.Locals[3]=f.Pop();f.Pc=142;continue;}
case 142:{f.Push(f.Locals[2]);f.Pc=143;continue;}
case 143:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",148);}
case 148:{f.Locals[4]=f.Pop();f.Pc=150;continue;}
case 150:{f.Push(f.Locals[4]);f.Pc=152;continue;}
case 152:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",157);}
case 157:{f.Pc=f.Pop().Int==0?192:160;continue;}
case 160:{f.Push(f.Locals[4]);f.Pc=162;continue;}
case 162:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",167);}
case 167:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=170;continue;}
case 170:{f.Locals[5]=f.Pop();f.Pc=172;continue;}
case 172:{f.Push(f.Locals[5]);f.Pc=174;continue;}
case 174:{return rt.Call(f,"forge/game/spellability/SpellAbility","undo","()Z","invokevirtual",177);}
case 177:{f.Pc=f.Pop().Int==0?189:180;continue;}
case 180:{f.Push(f.Locals[3]);f.Pc=181;continue;}
case 181:{f.Push(f.Locals[5]);f.Pc=183;continue;}
case 183:{return rt.Call(f,"java/util/List","add","(Ljava/lang/Object;)Z","invokeinterface",188);}
case 188:{f.StackOp("pop");f.Pc=189;continue;}
case 189:{f.Pc=150;continue;}
case 192:{f.Push(f.Locals[0]);f.Pc=193;continue;}
case 193:{f.Push(rt.GetField(f.Pop(),"forge/game/mana/ManaRefundService","sa","Lforge/game/spellability/SpellAbility;"));f.Pc=196;continue;}
case 196:{return rt.Call(f,"forge/game/spellability/SpellAbility","getHostCard","()Lforge/game/card/Card;","invokevirtual",199);}
case 199:{return rt.Call(f,"forge/game/card/Card","getGame","()Lforge/game/Game;","invokevirtual",202);}
case 202:{return rt.Call(f,"forge/game/Game","getStack","()Lforge/game/zone/MagicStack;","invokevirtual",205);}
case 205:{f.Locals[4]=f.Pop();f.Pc=207;continue;}
case 207:{f.Push(f.Locals[2]);f.Pc=208;continue;}
case 208:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",213);}
case 213:{f.Locals[5]=f.Pop();f.Pc=215;continue;}
case 215:{f.Push(f.Locals[5]);f.Pc=217;continue;}
case 217:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",222);}
case 222:{f.Pc=f.Pop().Int==0?331:225;continue;}
case 225:{f.Push(f.Locals[5]);f.Pc=227;continue;}
case 227:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",232);}
case 232:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/spellability/SpellAbility"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=235;continue;}
case 235:{f.Locals[6]=f.Pop();f.Pc=237;continue;}
case 237:{f.Push(f.Locals[3]);f.Pc=238;continue;}
case 238:{f.Push(f.Locals[6]);f.Pc=240;continue;}
case 240:{return rt.Call(f,"java/util/List","contains","(Ljava/lang/Object;)Z","invokeinterface",245);}
case 245:{f.Pc=f.Pop().Int==0?263:248;continue;}
case 248:{if(!rt.EnsureInitialized(f,"forge/game/mana/ManaRefundService"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/mana/ManaRefundService")));f.Pc=251;continue;}
case 251:{f.StackOp("dup");f.Pc=252;continue;}
case 252:{f.Push(f.Locals[6]);f.Pc=254;continue;}
case 254:{return rt.Call(f,"forge/game/mana/ManaRefundService","<init>","(Lforge/game/spellability/SpellAbility;)V","invokespecial",257);}
case 257:{return rt.Call(f,"forge/game/mana/ManaRefundService","refundManaPaid","()V","invokevirtual",260);}
case 260:{f.Pc=321;continue;}
case 263:{f.Push(f.Locals[6]);f.Pc=265;continue;}
case 265:{return rt.Call(f,"forge/game/spellability/SpellAbility","getPayingMana","()Ljava/util/List;","invokevirtual",268);}
case 268:{return rt.Call(f,"java/util/List","iterator","()Ljava/util/Iterator;","invokeinterface",273);}
case 273:{f.Locals[7]=f.Pop();f.Pc=275;continue;}
case 275:{f.Push(f.Locals[7]);f.Pc=277;continue;}
case 277:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",282);}
case 282:{f.Pc=f.Pop().Int==0?321:285;continue;}
case 285:{f.Push(f.Locals[7]);f.Pc=287;continue;}
case 287:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",292);}
case 292:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/mana/Mana"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=295;continue;}
case 295:{f.Locals[8]=f.Pop();f.Pc=297;continue;}
case 297:{f.Push(f.Locals[8]);f.Pc=299;continue;}
case 299:{return rt.Call(f,"forge/game/mana/Mana","getManaAbility","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",302);}
case 302:{f.Pc=f.Pop().Reference==null?318:305;continue;}
case 305:{f.Push(f.Locals[4]);f.Pc=307;continue;}
case 307:{f.Push(f.Locals[8]);f.Pc=309;continue;}
case 309:{return rt.Call(f,"forge/game/mana/Mana","getManaAbility","()Lforge/game/spellability/AbilityManaPart;","invokevirtual",312);}
case 312:{return rt.Call(f,"forge/game/spellability/AbilityManaPart","getSourceSA","()Lforge/game/spellability/SpellAbility;","invokevirtual",315);}
case 315:{return rt.Call(f,"forge/game/zone/MagicStack","clearUndoStack","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",318);}
case 318:{f.Pc=275;continue;}
case 321:{f.Push(f.Locals[4]);f.Pc=323;continue;}
case 323:{f.Push(f.Locals[6]);f.Pc=325;continue;}
case 325:{return rt.Call(f,"forge/game/zone/MagicStack","clearUndoStack","(Lforge/game/spellability/SpellAbility;)V","invokevirtual",328);}
case 328:{f.Pc=215;continue;}
case 331:{f.Push(f.Locals[2]);f.Pc=332;continue;}
case 332:{return rt.Call(f,"java/util/List","clear","()V","invokeinterface",337);}
case 337:{f.Push(f.Locals[1]);f.Pc=338;continue;}
case 338:{return rt.Call(f,"forge/game/player/PlayerCollection","iterator","()Ljava/util/Iterator;","invokevirtual",341);}
case 341:{f.Locals[5]=f.Pop();f.Pc=343;continue;}
case 343:{f.Push(f.Locals[5]);f.Pc=345;continue;}
case 345:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",350);}
case 350:{f.Pc=f.Pop().Int==0?392:353;continue;}
case 353:{f.Push(f.Locals[5]);f.Pc=355;continue;}
case 355:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",360);}
case 360:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/player/Player"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=363;continue;}
case 363:{f.Locals[6]=f.Pop();f.Pc=365;continue;}
case 365:{f.Push(f.Locals[6]);f.Pc=367;continue;}
case 367:{return rt.Call(f,"forge/game/player/Player","getGame","()Lforge/game/Game;","invokevirtual",370);}
case 370:{if(!rt.EnsureInitialized(f,"forge/game/event/GameEventZone"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/event/GameEventZone")));f.Pc=373;continue;}
case 373:{f.StackOp("dup");f.Pc=374;continue;}
case 374:{if(!rt.StaticReady(f,"forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/zone/ZoneType","Battlefield","Lforge/game/zone/ZoneType;"));f.Pc=377;continue;}
case 377:{f.Push(f.Locals[6]);f.Pc=379;continue;}
case 379:{if(!rt.StaticReady(f,"forge/game/event/EventValueChangeType","ComplexUpdate","Lforge/game/event/EventValueChangeType;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/event/EventValueChangeType","ComplexUpdate","Lforge/game/event/EventValueChangeType;"));f.Pc=382;continue;}
case 382:{f.Push(JValue.R(null));f.Pc=383;continue;}
case 383:{return rt.Call(f,"forge/game/event/GameEventZone","<init>","(Lforge/game/zone/ZoneType;Lforge/game/player/Player;Lforge/game/event/EventValueChangeType;Lforge/game/card/Card;)V","invokespecial",386);}
case 386:{return rt.Call(f,"forge/game/Game","fireEvent","(Lforge/game/event/Event;)V","invokevirtual",389);}
case 389:{f.Pc=343;continue;}
case 392:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
