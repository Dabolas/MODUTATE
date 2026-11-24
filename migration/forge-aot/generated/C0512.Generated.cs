// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C512{
internal static JClass Build(){var c=new JClass("forge/game/combat/AttackingBand","java/lang/Object",new string[]{},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("attackers","Lforge/game/card/CardCollection;",false,JValue.Default("Lforge/game/card/CardCollection;"),null));
c.Add(new JField("blocked","Ljava/lang/Boolean;",false,JValue.Default("Ljava/lang/Boolean;"),null));
c.Add(new JMethod(6015,"forge/game/combat/AttackingBand","<init>","(Ljava/util/List;)V",1,2,3,new JHandler[]{},M6015));
c.Add(new JMethod(6016,"forge/game/combat/AttackingBand","<init>","(Lforge/game/card/Card;)V",1,2,3,new JHandler[]{},M6016));
c.Add(new JMethod(6017,"forge/game/combat/AttackingBand","getAttackers","()Lforge/game/card/CardCollectionView;",1,1,1,new JHandler[]{},M6017));
c.Add(new JMethod(6018,"forge/game/combat/AttackingBand","addAttacker","(Lforge/game/card/Card;)V",1,2,2,new JHandler[]{},M6018));
c.Add(new JMethod(6019,"forge/game/combat/AttackingBand","removeAttacker","(Lforge/game/card/Card;)V",1,2,2,new JHandler[]{},M6019));
c.Add(new JMethod(6020,"forge/game/combat/AttackingBand","isValidBand","(Lforge/game/card/CardCollectionView;Z)Z",9,10,5,new JHandler[]{},M6020));
c.Add(new JMethod(6021,"forge/game/combat/AttackingBand","canJoinBand","(Lforge/game/card/Card;)Z",1,3,3,new JHandler[]{},M6021));
c.Add(new JMethod(6022,"forge/game/combat/AttackingBand","contains","(Lforge/game/card/Card;)Z",1,2,2,new JHandler[]{},M6022));
c.Add(new JMethod(6023,"forge/game/combat/AttackingBand","isBlocked","()Ljava/lang/Boolean;",1,1,1,new JHandler[]{},M6023));
c.Add(new JMethod(6024,"forge/game/combat/AttackingBand","setBlocked","(Z)V",1,2,2,new JHandler[]{},M6024));
c.Add(new JMethod(6025,"forge/game/combat/AttackingBand","isEmpty","()Z",1,1,1,new JHandler[]{},M6025));
c.Add(new JMethod(6026,"forge/game/combat/AttackingBand","toString","()Ljava/lang/String;",1,1,5,new JHandler[]{},M6026));
}

internal static JStep M6015(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackingBand","attackers","Lforge/game/card/CardCollection;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackingBand","blocked","Ljava/lang/Boolean;",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackingBand","attackers","Lforge/game/card/CardCollection;"));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/CardCollection","addAll","(Ljava/util/Collection;)Z","invokevirtual",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6016(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/card/CardCollection","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackingBand","attackers","Lforge/game/card/CardCollection;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{f.Push(JValue.R(null));f.Pc=17;continue;}
case 17:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackingBand","blocked","Ljava/lang/Boolean;",value);f.Pc=20;continue;}
case 20:{f.Push(f.Locals[0]);f.Pc=21;continue;}
case 21:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackingBand","attackers","Lforge/game/card/CardCollection;"));f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",28);}
case 28:{f.StackOp("pop");f.Pc=29;continue;}
case 29:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6017(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackingBand","attackers","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6018(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackingBand","attackers","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.StackOp("pop");f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6019(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackingBand","attackers","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCollection","remove","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{f.StackOp("pop");f.Pc=9;continue;}
case 9:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6020(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/card/CardCollectionView","isEmpty","()Z","invokeinterface",6);}
case 6:{f.Pc=f.Pop().Int==0?11:9;continue;}
case 9:{f.Push(JValue.I(0));f.Pc=10;continue;}
case 10:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 11:{f.Push(f.Locals[0]);f.Pc=12;continue;}
case 12:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","BANDING","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","BANDING","Lforge/game/keyword/Keyword;"));f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/card/CardLists","getKeyword","(Ljava/lang/Iterable;Lforge/game/keyword/Keyword;)Lforge/game/card/CardCollection;","invokestatic",18);}
case 18:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",21);}
case 21:{f.Locals[2]=f.Pop();f.Pc=22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{f.Pc=f.Pop().Int==0?30:26;continue;}
case 26:{f.Push(JValue.I(1));f.Pc=27;continue;}
case 27:{f.Pc=38;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",36);}
case 36:{f.Push(JValue.I(1));f.Pc=37;continue;}
case 37:{var b=f.Pop();var a=f.Pop();f.Push(JNumbers.Binary(rt,"isub",a,b));f.Pc=38;continue;}
case 38:{f.Locals[3]=f.Pop();f.Pc=39;continue;}
case 39:{f.Push(f.Locals[3]);f.Pc=40;continue;}
case 40:{f.Push(f.Locals[2]);f.Pc=41;continue;}
case 41:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a>b?46:44;continue;}
case 44:{f.Push(JValue.I(1));f.Pc=45;continue;}
case 45:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 46:{f.Push(f.Locals[0]);f.Pc=47;continue;}
case 47:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","BANDSWITH","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","BANDSWITH","Lforge/game/keyword/Keyword;"));f.Pc=50;continue;}
case 50:{return rt.Call(f,"forge/game/card/CardLists","getKeyword","(Ljava/lang/Iterable;Lforge/game/keyword/Keyword;)Lforge/game/card/CardCollection;","invokestatic",53);}
case 53:{return rt.Call(f,"forge/game/card/CardCollection","iterator","()Ljava/util/Iterator;","invokevirtual",56);}
case 56:{f.Locals[4]=f.Pop();f.Pc=58;continue;}
case 58:{f.Push(f.Locals[4]);f.Pc=60;continue;}
case 60:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",65);}
case 65:{f.Pc=f.Pop().Int==0?171:68;continue;}
case 68:{f.Push(f.Locals[4]);f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",75);}
case 75:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/card/Card"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=78;continue;}
case 78:{f.Locals[5]=f.Pop();f.Pc=80;continue;}
case 80:{f.Push(f.Locals[5]);f.Pc=82;continue;}
case 82:{if(!rt.StaticReady(f,"forge/game/keyword/Keyword","BANDSWITH","Lforge/game/keyword/Keyword;"))return JStep.Continue;f.Push(rt.GetStatic("forge/game/keyword/Keyword","BANDSWITH","Lforge/game/keyword/Keyword;"));f.Pc=85;continue;}
case 85:{return rt.Call(f,"forge/game/card/Card","getKeywords","(Lforge/game/keyword/Keyword;)Ljava/util/Collection;","invokevirtual",88);}
case 88:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",93);}
case 93:{f.Locals[6]=f.Pop();f.Pc=95;continue;}
case 95:{f.Push(f.Locals[6]);f.Pc=97;continue;}
case 97:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",102);}
case 102:{f.Pc=f.Pop().Int==0?168:105;continue;}
case 105:{f.Push(f.Locals[6]);f.Pc=107;continue;}
case 107:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",112);}
case 112:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=115;continue;}
case 115:{f.Locals[7]=f.Pop();f.Pc=117;continue;}
case 117:{f.Push(f.Locals[7]);f.Pc=119;continue;}
case 119:{return rt.Call(f,"forge/game/keyword/KeywordInterface","getOriginal","()Ljava/lang/String;","invokeinterface",124);}
case 124:{f.Locals[8]=f.Pop();f.Pc=126;continue;}
case 126:{f.Push(f.Locals[8]);f.Pc=128;continue;}
case 128:{f.Push(JValue.R(rt.String(":")));f.Pc=130;continue;}
case 130:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",133);}
case 133:{f.Locals[9]=f.Pop();f.Pc=135;continue;}
case 135:{f.Push(f.Locals[0]);f.Pc=136;continue;}
case 136:{f.Push(f.Locals[9]);f.Pc=138;continue;}
case 138:{f.Push(JValue.I(1));f.Pc=139;continue;}
case 139:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=140;continue;}
case 140:{f.Push(f.Locals[5]);f.Pc=142;continue;}
case 142:{return rt.Call(f,"forge/game/card/Card","getController","()Lforge/game/player/Player;","invokevirtual",145);}
case 145:{f.Push(f.Locals[5]);f.Pc=147;continue;}
case 147:{f.Push(JValue.R(null));f.Pc=148;continue;}
case 148:{return rt.Call(f,"forge/game/card/CardLists","getValidCards","(Ljava/lang/Iterable;Ljava/lang/String;Lforge/game/player/Player;Lforge/game/card/Card;Lforge/game/CardTraitBase;)Lforge/game/card/CardCollection;","invokestatic",151);}
case 151:{return rt.Call(f,"forge/game/card/CardCollection","size","()I","invokevirtual",154);}
case 154:{f.Push(f.Locals[0]);f.Pc=155;continue;}
case 155:{return rt.Call(f,"forge/game/card/CardCollectionView","size","()I","invokeinterface",160);}
case 160:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a!=b?165:163;continue;}
case 163:{f.Push(JValue.I(1));f.Pc=164;continue;}
case 164:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 165:{f.Pc=95;continue;}
case 168:{f.Pc=58;continue;}
case 171:{f.Push(JValue.I(0));f.Pc=172;continue;}
case 172:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6021(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/game/card/CardCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/card/CardCollection")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackingBand","attackers","Lforge/game/card/CardCollection;"));f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/card/CardCollection","<init>","(Ljava/lang/Iterable;)V","invokespecial",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[1]);f.Pc=13;continue;}
case 13:{f.Pc=f.Pop().Reference==null?22:16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{f.Push(f.Locals[1]);f.Pc=18;continue;}
case 18:{return rt.Call(f,"forge/game/card/CardCollection","add","(Ljava/lang/Object;)Z","invokevirtual",21);}
case 21:{f.StackOp("pop");f.Pc=22;continue;}
case 22:{f.Push(f.Locals[2]);f.Pc=23;continue;}
case 23:{f.Push(JValue.I(0));f.Pc=24;continue;}
case 24:{return rt.Call(f,"forge/game/combat/AttackingBand","isValidBand","(Lforge/game/card/CardCollectionView;Z)Z","invokestatic",27);}
case 27:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6022(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackingBand","attackers","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/card/CardCollection","contains","(Ljava/lang/Object;)Z","invokevirtual",8);}
case 8:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6023(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackingBand","blocked","Ljava/lang/Boolean;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6024(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/lang/Boolean","valueOf","(Z)Ljava/lang/Boolean;","invokestatic",5);}
case 5:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/combat/AttackingBand","blocked","Ljava/lang/Boolean;",value);f.Pc=8;continue;}
case 8:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6025(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackingBand","attackers","Lforge/game/card/CardCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/card/CardCollection","isEmpty","()Z","invokevirtual",7);}
case 7:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M6026(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("%s %s")));f.Pc=2;continue;}
case 2:{f.Push(JValue.I(2));f.Pc=3;continue;}
case 3:{f.Push(JValue.R(rt.NewArray("Ljava/lang/Object;",f.Pop().Int)));f.Pc=6;continue;}
case 6:{f.StackOp("dup");f.Pc=7;continue;}
case 7:{f.Push(JValue.I(0));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackingBand","attackers","Lforge/game/card/CardCollection;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/card/CardCollection","toString","()Ljava/lang/String;","invokevirtual",15);}
case 15:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=16;continue;}
case 16:{f.StackOp("dup");f.Pc=17;continue;}
case 17:{f.Push(JValue.I(1));f.Pc=18;continue;}
case 18:{f.Push(f.Locals[0]);f.Pc=19;continue;}
case 19:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackingBand","blocked","Ljava/lang/Boolean;"));f.Pc=22;continue;}
case 22:{f.Pc=f.Pop().Reference!=null?30:25;continue;}
case 25:{f.Push(JValue.R(rt.String(" ? ")));f.Pc=27;continue;}
case 27:{f.Pc=47;continue;}
case 30:{f.Push(f.Locals[0]);f.Pc=31;continue;}
case 31:{f.Push(rt.GetField(f.Pop(),"forge/game/combat/AttackingBand","blocked","Ljava/lang/Boolean;"));f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/lang/Boolean","booleanValue","()Z","invokevirtual",37);}
case 37:{f.Pc=f.Pop().Int==0?45:40;continue;}
case 40:{f.Push(JValue.R(rt.String(">||")));f.Pc=42;continue;}
case 42:{f.Pc=47;continue;}
case 45:{f.Push(JValue.R(rt.String(">>>")));f.Pc=47;continue;}
case 47:{var value=f.Pop();int at=f.Pop().Int;rt.ArrayStore(f.Pop(),at,value);f.Pc=48;continue;}
case 48:{return rt.Call(f,"java/lang/String","format","(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;","invokestatic",51);}
case 51:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
