// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C664{
internal static JClass Build(){var c=new JClass("forge/game/keyword/KeywordsChange","java/lang/Object",new string[]{"forge/game/card/ICardTraitChanges","forge/game/keyword/IKeywordsChange","java/lang/Cloneable"},33);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("keywords","Lforge/game/keyword/KeywordCollection;",false,JValue.Default("Lforge/game/keyword/KeywordCollection;"),null));
c.Add(new JField("removeKeywordInterfaces","Lforge/game/keyword/KeywordCollection;",false,JValue.Default("Lforge/game/keyword/KeywordCollection;"),null));
c.Add(new JField("removeKeywords","Ljava/util/List;",false,JValue.Default("Ljava/util/List;"),null));
c.Add(new JField("removeAllKeywords","Z",false,JValue.Default("Z"),null));
c.Add(new JMethod(7617,"forge/game/keyword/KeywordsChange","<init>","(Ljava/lang/Iterable;Ljava/util/Collection;Z)V",1,4,3,new JHandler[]{},M7617));
c.Add(new JMethod(7618,"forge/game/keyword/KeywordsChange","<init>","(Ljava/util/Collection;Ljava/util/Collection;Z)V",1,4,3,new JHandler[]{},M7618));
c.Add(new JMethod(7619,"forge/game/keyword/KeywordsChange","getKeywords","()Ljava/util/Collection;",17,1,1,new JHandler[]{},M7619));
c.Add(new JMethod(7620,"forge/game/keyword/KeywordsChange","getRemovedKeywordInstances","()Ljava/util/Collection;",17,1,1,new JHandler[]{},M7620));
c.Add(new JMethod(7621,"forge/game/keyword/KeywordsChange","getRemoveKeywords","()Ljava/util/List;",17,1,1,new JHandler[]{},M7621));
c.Add(new JMethod(7622,"forge/game/keyword/KeywordsChange","isRemoveAllKeywords","()Z",17,1,1,new JHandler[]{},M7622));
c.Add(new JMethod(7623,"forge/game/keyword/KeywordsChange","isEmpty","()Z",17,1,1,new JHandler[]{},M7623));
c.Add(new JMethod(7624,"forge/game/keyword/KeywordsChange","setHostCard","(Lforge/game/card/Card;)V",1,4,2,new JHandler[]{},M7624));
c.Add(new JMethod(7625,"forge/game/keyword/KeywordsChange","copy","(Lforge/game/card/Card;Z)Lforge/game/keyword/KeywordsChange;",1,4,4,new JHandler[]{new JHandler(0,46,47,"java/lang/Exception")},M7625));
c.Add(new JMethod(7626,"forge/game/keyword/KeywordsChange","applySpellAbility","(Ljava/util/List;)Ljava/util/List;",1,2,2,new JHandler[]{},M7626));
c.Add(new JMethod(7627,"forge/game/keyword/KeywordsChange","applyTrigger","(Ljava/util/List;)Ljava/util/List;",1,2,2,new JHandler[]{},M7627));
c.Add(new JMethod(7628,"forge/game/keyword/KeywordsChange","applyReplacementEffect","(Ljava/util/List;)Ljava/util/List;",1,2,2,new JHandler[]{},M7628));
c.Add(new JMethod(7629,"forge/game/keyword/KeywordsChange","applyStaticAbility","(Ljava/util/List;)Ljava/util/List;",1,2,2,new JHandler[]{},M7629));
c.Add(new JMethod(7630,"forge/game/keyword/KeywordsChange","applyKeywords","(Lforge/game/keyword/KeywordCollection;)V",1,2,2,new JHandler[]{},M7630));
c.Add(new JMethod(7631,"forge/game/keyword/KeywordsChange","hasTraits","()Z",1,3,1,new JHandler[]{},M7631));
c.Add(new JMethod(7632,"forge/game/keyword/KeywordsChange","toString","()Ljava/lang/String;",1,2,2,new JHandler[]{},M7632));
c.Add(new JMethod(7633,"forge/game/keyword/KeywordsChange","copy","(Lforge/game/card/Card;Z)Lforge/game/card/ICardTraitChanges;",4161,3,3,new JHandler[]{},M7633));
c.Add(new JMethod(7634,"forge/game/keyword/KeywordsChange","copy","(Lforge/game/card/Card;Z)Lforge/game/keyword/IKeywordsChange;",4161,3,3,new JHandler[]{},M7634));
}

internal static JStep M7617(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/game/keyword/KeywordCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/keyword/KeywordCollection")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/keyword/KeywordCollection","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordsChange","keywords","Lforge/game/keyword/KeywordCollection;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"forge/game/keyword/KeywordCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/keyword/KeywordCollection")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/keyword/KeywordCollection","<init>","()V","invokespecial",23);}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordsChange","removeKeywordInterfaces","Lforge/game/keyword/KeywordCollection;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",30);}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordsChange","removeKeywords","Ljava/util/List;",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Pc=f.Pop().Reference==null?46:37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","keywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/keyword/KeywordCollection","insertAll","(Ljava/lang/Iterable;)Z","invokevirtual",45);}
case 45:{f.StackOp("pop");f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Pc=f.Pop().Reference==null?61:50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","removeKeywords","Ljava/util/List;"));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/util/List","addAll","(Ljava/util/Collection;)Z","invokeinterface",60);}
case 60:{f.StackOp("pop");f.Pc=61;continue;}
case 61:{f.Push(f.Locals[0]);f.Pc=62;continue;}
case 62:{f.Push(f.Locals[3]);f.Pc=63;continue;}
case 63:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordsChange","removeAllKeywords","Z",value);f.Pc=66;continue;}
case 66:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7618(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{if(!rt.EnsureInitialized(f,"forge/game/keyword/KeywordCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/keyword/KeywordCollection")));f.Pc=8;continue;}
case 8:{f.StackOp("dup");f.Pc=9;continue;}
case 9:{return rt.Call(f,"forge/game/keyword/KeywordCollection","<init>","()V","invokespecial",12);}
case 12:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordsChange","keywords","Lforge/game/keyword/KeywordCollection;",value);f.Pc=15;continue;}
case 15:{f.Push(f.Locals[0]);f.Pc=16;continue;}
case 16:{if(!rt.EnsureInitialized(f,"forge/game/keyword/KeywordCollection"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/game/keyword/KeywordCollection")));f.Pc=19;continue;}
case 19:{f.StackOp("dup");f.Pc=20;continue;}
case 20:{return rt.Call(f,"forge/game/keyword/KeywordCollection","<init>","()V","invokespecial",23);}
case 23:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordsChange","removeKeywordInterfaces","Lforge/game/keyword/KeywordCollection;",value);f.Pc=26;continue;}
case 26:{f.Push(f.Locals[0]);f.Pc=27;continue;}
case 27:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","()Ljava/util/ArrayList;","invokestatic",30);}
case 30:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordsChange","removeKeywords","Ljava/util/List;",value);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[1]);f.Pc=34;continue;}
case 34:{f.Pc=f.Pop().Reference==null?46:37;continue;}
case 37:{f.Push(f.Locals[0]);f.Pc=38;continue;}
case 38:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","keywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=41;continue;}
case 41:{f.Push(f.Locals[1]);f.Pc=42;continue;}
case 42:{return rt.Call(f,"forge/game/keyword/KeywordCollection","insertAll","(Ljava/lang/Iterable;)Z","invokevirtual",45);}
case 45:{f.StackOp("pop");f.Pc=46;continue;}
case 46:{f.Push(f.Locals[2]);f.Pc=47;continue;}
case 47:{f.Pc=f.Pop().Reference==null?59:50;continue;}
case 50:{f.Push(f.Locals[0]);f.Pc=51;continue;}
case 51:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","removeKeywordInterfaces","Lforge/game/keyword/KeywordCollection;"));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[2]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"forge/game/keyword/KeywordCollection","insertAll","(Ljava/lang/Iterable;)Z","invokevirtual",58);}
case 58:{f.StackOp("pop");f.Pc=59;continue;}
case 59:{f.Push(f.Locals[0]);f.Pc=60;continue;}
case 60:{f.Push(f.Locals[3]);f.Pc=61;continue;}
case 61:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordsChange","removeAllKeywords","Z",value);f.Pc=64;continue;}
case 64:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7619(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","keywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/keyword/KeywordCollection","getValues","()Ljava/util/Collection;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7620(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","removeKeywordInterfaces","Lforge/game/keyword/KeywordCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/keyword/KeywordCollection","getValues","()Ljava/util/Collection;","invokevirtual",7);}
case 7:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7621(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","removeKeywords","Ljava/util/List;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7622(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","removeAllKeywords","Z"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7623(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","removeAllKeywords","Z"));f.Pc=4;continue;}
case 4:{f.Pc=f.Pop().Int!=0?33:7;continue;}
case 7:{f.Push(f.Locals[0]);f.Pc=8;continue;}
case 8:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","keywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=11;continue;}
case 11:{return rt.Call(f,"forge/game/keyword/KeywordCollection","isEmpty","()Z","invokevirtual",14);}
case 14:{f.Pc=f.Pop().Int==0?33:17;continue;}
case 17:{f.Push(f.Locals[0]);f.Pc=18;continue;}
case 18:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","removeKeywords","Ljava/util/List;"));f.Pc=21;continue;}
case 21:{return rt.Call(f,"java/util/List","isEmpty","()Z","invokeinterface",26);}
case 26:{f.Pc=f.Pop().Int==0?33:29;continue;}
case 29:{f.Push(JValue.I(1));f.Pc=30;continue;}
case 30:{f.Pc=34;continue;}
case 33:{f.Push(JValue.I(0));f.Pc=34;continue;}
case 34:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7624(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","keywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/keyword/KeywordCollection","setHostCard","(Lforge/game/card/Card;)V","invokevirtual",8);}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","removeKeywordInterfaces","Lforge/game/keyword/KeywordCollection;"));f.Pc=12;continue;}
case 12:{return rt.Call(f,"forge/game/keyword/KeywordCollection","iterator","()Ljava/util/Iterator;","invokevirtual",15);}
case 15:{f.Locals[2]=f.Pop();f.Pc=16;continue;}
case 16:{f.Push(f.Locals[2]);f.Pc=17;continue;}
case 17:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",22);}
case 22:{f.Pc=f.Pop().Int==0?45:25;continue;}
case 25:{f.Push(f.Locals[2]);f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",31);}
case 31:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=34;continue;}
case 34:{f.Locals[3]=f.Pop();f.Pc=35;continue;}
case 35:{f.Push(f.Locals[3]);f.Pc=36;continue;}
case 36:{f.Push(f.Locals[1]);f.Pc=37;continue;}
case 37:{return rt.Call(f,"forge/game/keyword/KeywordInterface","setHostCard","(Lforge/game/card/Card;)V","invokeinterface",42);}
case 42:{f.Pc=16;continue;}
case 45:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7625(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","clone","()Ljava/lang/Object;","invokespecial",4);}
case 4:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordsChange"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=7;continue;}
case 7:{f.Locals[3]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[3]);f.Pc=9;continue;}
case 9:{f.Push(f.Locals[0]);f.Pc=10;continue;}
case 10:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","keywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{f.Push(f.Locals[2]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/keyword/KeywordCollection","copy","(Lforge/game/card/Card;Z)Lforge/game/keyword/KeywordCollection;","invokevirtual",18);}
case 18:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordsChange","keywords","Lforge/game/keyword/KeywordCollection;",value);f.Pc=21;continue;}
case 21:{f.Push(f.Locals[3]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","removeKeywords","Ljava/util/List;"));f.Pc=26;continue;}
case 26:{return rt.Call(f,"com/google/common/collect/Lists","newArrayList","(Ljava/lang/Iterable;)Ljava/util/ArrayList;","invokestatic",29);}
case 29:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordsChange","removeKeywords","Ljava/util/List;",value);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[3]);f.Pc=33;continue;}
case 33:{f.Push(f.Locals[0]);f.Pc=34;continue;}
case 34:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","removeKeywordInterfaces","Lforge/game/keyword/KeywordCollection;"));f.Pc=37;continue;}
case 37:{f.Push(f.Locals[1]);f.Pc=38;continue;}
case 38:{f.Push(f.Locals[2]);f.Pc=39;continue;}
case 39:{return rt.Call(f,"forge/game/keyword/KeywordCollection","copy","(Lforge/game/card/Card;Z)Lforge/game/keyword/KeywordCollection;","invokevirtual",42);}
case 42:{var value=f.Pop();rt.PutField(f.Pop(),"forge/game/keyword/KeywordsChange","removeKeywordInterfaces","Lforge/game/keyword/KeywordCollection;",value);f.Pc=45;continue;}
case 45:{f.Push(f.Locals[3]);f.Pc=46;continue;}
case 46:{return JStep.Return(f.Pop());}
case 47:{f.Locals[3]=f.Pop();f.Pc=48;continue;}
case 48:{if(!rt.EnsureInitialized(f,"java/lang/RuntimeException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/RuntimeException")));f.Pc=51;continue;}
case 51:{f.StackOp("dup");f.Pc=52;continue;}
case 52:{f.Push(JValue.R(rt.String("KeywordsChange : clone() error")));f.Pc=54;continue;}
case 54:{f.Push(f.Locals[3]);f.Pc=55;continue;}
case 55:{return rt.Call(f,"java/lang/RuntimeException","<init>","(Ljava/lang/String;Ljava/lang/Throwable;)V","invokespecial",58);}
case 58:{throw new JavaFault(rt.NonNull(f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7626(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","keywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/keyword/KeywordCollection","applySpellAbility","(Ljava/util/List;)Ljava/util/List;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7627(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","keywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/keyword/KeywordCollection","applyTrigger","(Ljava/util/List;)Ljava/util/List;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7628(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","keywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/keyword/KeywordCollection","applyReplacementEffect","(Ljava/util/List;)Ljava/util/List;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7629(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","keywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[1]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/game/keyword/KeywordCollection","applyStaticAbility","(Ljava/util/List;)Ljava/util/List;","invokevirtual",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7630(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"forge/game/keyword/KeywordsChange","isRemoveAllKeywords","()Z","invokevirtual",4);}
case 4:{f.Pc=f.Pop().Int==0?14:7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"forge/game/keyword/KeywordCollection","clear","()V","invokevirtual",11);}
case 11:{f.Pc=30;continue;}
case 14:{f.Push(f.Locals[0]);f.Pc=15;continue;}
case 15:{return rt.Call(f,"forge/game/keyword/KeywordsChange","getRemoveKeywords","()Ljava/util/List;","invokevirtual",18);}
case 18:{f.Pc=f.Pop().Reference==null?30:21;continue;}
case 21:{f.Push(f.Locals[1]);f.Pc=22;continue;}
case 22:{f.Push(f.Locals[0]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"forge/game/keyword/KeywordsChange","getRemoveKeywords","()Ljava/util/List;","invokevirtual",26);}
case 26:{return rt.Call(f,"forge/game/keyword/KeywordCollection","removeAll","(Ljava/lang/Iterable;)Z","invokevirtual",29);}
case 29:{f.StackOp("pop");f.Pc=30;continue;}
case 30:{f.Push(f.Locals[1]);f.Pc=31;continue;}
case 31:{f.Push(f.Locals[0]);f.Pc=32;continue;}
case 32:{return rt.Call(f,"forge/game/keyword/KeywordsChange","getRemovedKeywordInstances","()Ljava/util/Collection;","invokevirtual",35);}
case 35:{return rt.Call(f,"forge/game/keyword/KeywordCollection","removeInstances","(Ljava/lang/Iterable;)Z","invokevirtual",38);}
case 38:{f.StackOp("pop");f.Pc=39;continue;}
case 39:{f.Push(f.Locals[0]);f.Pc=40;continue;}
case 40:{return rt.Call(f,"forge/game/keyword/KeywordsChange","getKeywords","()Ljava/util/Collection;","invokevirtual",43);}
case 43:{f.Pc=f.Pop().Reference==null?55:46;continue;}
case 46:{f.Push(f.Locals[1]);f.Pc=47;continue;}
case 47:{f.Push(f.Locals[0]);f.Pc=48;continue;}
case 48:{return rt.Call(f,"forge/game/keyword/KeywordsChange","getKeywords","()Ljava/util/Collection;","invokevirtual",51);}
case 51:{return rt.Call(f,"forge/game/keyword/KeywordCollection","insertAll","(Ljava/lang/Iterable;)Z","invokevirtual",54);}
case 54:{f.StackOp("pop");f.Pc=55;continue;}
case 55:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7631(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","keywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=4;continue;}
case 4:{return rt.Call(f,"forge/game/keyword/KeywordCollection","getValues","()Ljava/util/Collection;","invokevirtual",7);}
case 7:{return rt.Call(f,"java/util/Collection","iterator","()Ljava/util/Iterator;","invokeinterface",12);}
case 12:{f.Locals[1]=f.Pop();f.Pc=13;continue;}
case 13:{f.Push(f.Locals[1]);f.Pc=14;continue;}
case 14:{return rt.Call(f,"java/util/Iterator","hasNext","()Z","invokeinterface",19);}
case 19:{f.Pc=f.Pop().Int==0?46:22;continue;}
case 22:{f.Push(f.Locals[1]);f.Pc=23;continue;}
case 23:{return rt.Call(f,"java/util/Iterator","next","()Ljava/lang/Object;","invokeinterface",28);}
case 28:{var value=f.Pop();if(value.Reference!=null&&!rt.IsInstance(value.Reference,"forge/game/keyword/KeywordInterface"))throw rt.Fault("java/lang/ClassCastException");f.Push(value);f.Pc=31;continue;}
case 31:{f.Locals[2]=f.Pop();f.Pc=32;continue;}
case 32:{f.Push(f.Locals[2]);f.Pc=33;continue;}
case 33:{return rt.Call(f,"forge/game/keyword/KeywordInterface","hasTraits","()Z","invokeinterface",38);}
case 38:{f.Pc=f.Pop().Int==0?43:41;continue;}
case 41:{f.Push(JValue.I(1));f.Pc=42;continue;}
case 42:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
case 43:{f.Pc=13;continue;}
case 46:{f.Push(JValue.I(0));f.Pc=47;continue;}
case 47:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7632(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"java/lang/StringBuilder"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/StringBuilder")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{return rt.Call(f,"java/lang/StringBuilder","<init>","()V","invokespecial",7);}
case 7:{f.Locals[1]=f.Pop();f.Pc=8;continue;}
case 8:{f.Push(f.Locals[1]);f.Pc=9;continue;}
case 9:{f.Push(JValue.R(rt.String("<+")));f.Pc=11;continue;}
case 11:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",14);}
case 14:{f.StackOp("pop");f.Pc=15;continue;}
case 15:{f.Push(f.Locals[1]);f.Pc=16;continue;}
case 16:{f.Push(f.Locals[0]);f.Pc=17;continue;}
case 17:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","keywords","Lforge/game/keyword/KeywordCollection;"));f.Pc=20;continue;}
case 20:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",23);}
case 23:{f.StackOp("pop");f.Pc=24;continue;}
case 24:{f.Push(f.Locals[1]);f.Pc=25;continue;}
case 25:{f.Push(JValue.R(rt.String("|-")));f.Pc=27;continue;}
case 27:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",30);}
case 30:{f.StackOp("pop");f.Pc=31;continue;}
case 31:{f.Push(f.Locals[1]);f.Pc=32;continue;}
case 32:{f.Push(f.Locals[0]);f.Pc=33;continue;}
case 33:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","removeKeywordInterfaces","Lforge/game/keyword/KeywordCollection;"));f.Pc=36;continue;}
case 36:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",39);}
case 39:{f.StackOp("pop");f.Pc=40;continue;}
case 40:{f.Push(f.Locals[1]);f.Pc=41;continue;}
case 41:{f.Push(JValue.R(rt.String("|-")));f.Pc=43;continue;}
case 43:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",46);}
case 46:{f.StackOp("pop");f.Pc=47;continue;}
case 47:{f.Push(f.Locals[1]);f.Pc=48;continue;}
case 48:{f.Push(f.Locals[0]);f.Pc=49;continue;}
case 49:{f.Push(rt.GetField(f.Pop(),"forge/game/keyword/KeywordsChange","removeKeywords","Ljava/util/List;"));f.Pc=52;continue;}
case 52:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/Object;)Ljava/lang/StringBuilder;","invokevirtual",55);}
case 55:{f.StackOp("pop");f.Pc=56;continue;}
case 56:{f.Push(f.Locals[1]);f.Pc=57;continue;}
case 57:{f.Push(JValue.R(rt.String(">")));f.Pc=59;continue;}
case 59:{return rt.Call(f,"java/lang/StringBuilder","append","(Ljava/lang/String;)Ljava/lang/StringBuilder;","invokevirtual",62);}
case 62:{f.StackOp("pop");f.Pc=63;continue;}
case 63:{f.Push(f.Locals[1]);f.Pc=64;continue;}
case 64:{return rt.Call(f,"java/lang/StringBuilder","toString","()Ljava/lang/String;","invokevirtual",67);}
case 67:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7633(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/keyword/KeywordsChange","copy","(Lforge/game/card/Card;Z)Lforge/game/keyword/KeywordsChange;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M7634(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(f.Locals[1]);f.Pc=2;continue;}
case 2:{f.Push(f.Locals[2]);f.Pc=3;continue;}
case 3:{return rt.Call(f,"forge/game/keyword/KeywordsChange","copy","(Lforge/game/card/Card;Z)Lforge/game/keyword/KeywordsChange;","invokevirtual",6);}
case 6:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
