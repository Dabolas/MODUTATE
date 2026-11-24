// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1154{
internal static JClass Build(){var c=new JClass("forge/util/RuntimeVersion","java/lang/Object",new string[]{},49);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JField("versionNumberPattern","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("preReleasePattern","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("buildNumberPattern","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("buildInformationPattern","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("versionStringPattern1","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("versionStringPattern2","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("versionStringPattern3","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("versionStringPattern4","Ljava/util/regex/Pattern;",true,JValue.Default("Ljava/util/regex/Pattern;"),null));
c.Add(new JField("major","I",false,JValue.Default("I"),null));
c.Add(new JField("minor","I",false,JValue.Default("I"),null));
c.Add(new JField("securityLevel","I",false,JValue.Default("I"),null));
c.Add(new JField("update","I",false,JValue.Default("I"),null));
c.Add(new JField("preReleaseIdentifier","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JField("buildNumber","I",false,JValue.Default("I"),null));
c.Add(new JField("buildInformation","Ljava/lang/String;",false,JValue.Default("Ljava/lang/String;"),null));
c.Add(new JMethod(12005,"forge/util/RuntimeVersion","<init>","(Ljava/lang/String;)V",2,5,3,new JHandler[]{},M12005));
c.Add(new JMethod(12006,"forge/util/RuntimeVersion","of","(Ljava/lang/String;)Lforge/util/RuntimeVersion;",9,1,3,new JHandler[]{},M12006));
c.Add(new JMethod(12007,"forge/util/RuntimeVersion","toString","()Ljava/lang/String;",1,1,3,new JHandler[]{},M12007));
c.Add(new JMethod(12008,"forge/util/RuntimeVersion","getMajor","()I",1,1,1,new JHandler[]{},M12008));
c.Add(new JMethod(12009,"forge/util/RuntimeVersion","getMinor","()I",1,1,1,new JHandler[]{},M12009));
c.Add(new JMethod(12010,"forge/util/RuntimeVersion","getSecurityLevel","()I",1,1,1,new JHandler[]{},M12010));
c.Add(new JMethod(12011,"forge/util/RuntimeVersion","getUpdate","()I",1,1,1,new JHandler[]{},M12011));
c.Add(new JMethod(12012,"forge/util/RuntimeVersion","getPreReleaseIdentifier","()Ljava/lang/String;",1,1,1,new JHandler[]{},M12012));
c.Add(new JMethod(12013,"forge/util/RuntimeVersion","getBuildNumber","()I",1,1,1,new JHandler[]{},M12013));
c.Add(new JMethod(12014,"forge/util/RuntimeVersion","getBuildInformation","()Ljava/lang/String;",1,1,1,new JHandler[]{},M12014));
c.Add(new JMethod(12015,"forge/util/RuntimeVersion","<clinit>","()V",8,0,4,new JHandler[]{},M12015));
}

internal static JStep M12005(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{return rt.Call(f,"java/lang/Object","<init>","()V","invokespecial",4);}
case 4:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","versionNumberPattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","versionNumberPattern","Ljava/util/regex/Pattern;"));f.Pc=7;continue;}
case 7:{f.Push(f.Locals[1]);f.Pc=8;continue;}
case 8:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",11);}
case 11:{f.Locals[2]=f.Pop();f.Pc=12;continue;}
case 12:{f.Push(f.Locals[2]);f.Pc=13;continue;}
case 13:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",16);}
case 16:{f.Pc=f.Pop().Int!=0?33:19;continue;}
case 19:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=22;continue;}
case 22:{f.StackOp("dup");f.Pc=23;continue;}
case 23:{f.Push(f.Locals[1]);f.Pc=24;continue;}
case 24:{return rt.DynamicCall(f,"forge/util/RuntimeVersion:12005:24:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",29);}
case 29:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",32);}
case 32:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 33:{f.Push(f.Locals[2]);f.Pc=34;continue;}
case 34:{return rt.Call(f,"java/util/regex/Matcher","group","()Ljava/lang/String;","invokevirtual",37);}
case 37:{f.Push(JValue.R(rt.String("[._]")));f.Pc=39;continue;}
case 39:{return rt.Call(f,"java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;","invokevirtual",42);}
case 42:{f.Locals[3]=f.Pop();f.Pc=43;continue;}
case 43:{f.Push(f.Locals[3]);f.Pc=44;continue;}
case 44:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=45;continue;}
case 45:{f.Push(JValue.I(1));f.Pc=46;continue;}
case 46:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?59:49;continue;}
case 49:{f.Push(f.Locals[0]);f.Pc=50;continue;}
case 50:{f.Push(f.Locals[3]);f.Pc=51;continue;}
case 51:{f.Push(JValue.I(0));f.Pc=52;continue;}
case 52:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",56);}
case 56:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/RuntimeVersion","major","I",value);f.Pc=59;continue;}
case 59:{f.Push(f.Locals[3]);f.Pc=60;continue;}
case 60:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=61;continue;}
case 61:{f.Push(JValue.I(2));f.Pc=62;continue;}
case 62:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?75:65;continue;}
case 65:{f.Push(f.Locals[0]);f.Pc=66;continue;}
case 66:{f.Push(f.Locals[3]);f.Pc=67;continue;}
case 67:{f.Push(JValue.I(1));f.Pc=68;continue;}
case 68:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=69;continue;}
case 69:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",72);}
case 72:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/RuntimeVersion","minor","I",value);f.Pc=75;continue;}
case 75:{f.Push(f.Locals[3]);f.Pc=76;continue;}
case 76:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=77;continue;}
case 77:{f.Push(JValue.I(3));f.Pc=78;continue;}
case 78:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?91:81;continue;}
case 81:{f.Push(f.Locals[0]);f.Pc=82;continue;}
case 82:{f.Push(f.Locals[3]);f.Pc=83;continue;}
case 83:{f.Push(JValue.I(2));f.Pc=84;continue;}
case 84:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=85;continue;}
case 85:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",88);}
case 88:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/RuntimeVersion","securityLevel","I",value);f.Pc=91;continue;}
case 91:{f.Push(f.Locals[3]);f.Pc=92;continue;}
case 92:{f.Push(JValue.I(rt.ArrayLength(f.Pop())));f.Pc=93;continue;}
case 93:{f.Push(JValue.I(4));f.Pc=94;continue;}
case 94:{int b=f.Pop().Int;int a=f.Pop().Int;f.Pc=a<b?107:97;continue;}
case 97:{f.Push(f.Locals[0]);f.Pc=98;continue;}
case 98:{f.Push(f.Locals[3]);f.Pc=99;continue;}
case 99:{f.Push(JValue.I(3));f.Pc=100;continue;}
case 100:{int at=f.Pop().Int;var array=f.Pop();f.Push(rt.ArrayLoad(array,at));f.Pc=101;continue;}
case 101:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",104);}
case 104:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/RuntimeVersion","update","I",value);f.Pc=107;continue;}
case 107:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","versionStringPattern1","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","versionStringPattern1","Ljava/util/regex/Pattern;"));f.Pc=110;continue;}
case 110:{f.Push(f.Locals[1]);f.Pc=111;continue;}
case 111:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",114);}
case 114:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",117);}
case 117:{f.Pc=f.Pop().Int==0?202:120;continue;}
case 120:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","preReleasePattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","preReleasePattern","Ljava/util/regex/Pattern;"));f.Pc=123;continue;}
case 123:{f.Push(f.Locals[1]);f.Pc=124;continue;}
case 124:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",127);}
case 127:{f.Locals[4]=f.Pop();f.Pc=129;continue;}
case 129:{f.Push(f.Locals[4]);f.Pc=131;continue;}
case 131:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",134);}
case 134:{f.Pc=f.Pop().Int==0?146:137;continue;}
case 137:{f.Push(f.Locals[0]);f.Pc=138;continue;}
case 138:{f.Push(f.Locals[4]);f.Pc=140;continue;}
case 140:{return rt.Call(f,"java/util/regex/Matcher","group","()Ljava/lang/String;","invokevirtual",143);}
case 143:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/RuntimeVersion","preReleaseIdentifier","Ljava/lang/String;",value);f.Pc=146;continue;}
case 146:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","buildNumberPattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","buildNumberPattern","Ljava/util/regex/Pattern;"));f.Pc=149;continue;}
case 149:{f.Push(f.Locals[1]);f.Pc=150;continue;}
case 150:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",153);}
case 153:{f.Locals[4]=f.Pop();f.Pc=155;continue;}
case 155:{f.Push(f.Locals[4]);f.Pc=157;continue;}
case 157:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",160);}
case 160:{f.StackOp("pop");f.Pc=161;continue;}
case 161:{f.Push(f.Locals[0]);f.Pc=162;continue;}
case 162:{f.Push(f.Locals[4]);f.Pc=164;continue;}
case 164:{return rt.Call(f,"java/util/regex/Matcher","group","()Ljava/lang/String;","invokevirtual",167);}
case 167:{return rt.Call(f,"java/lang/Integer","parseInt","(Ljava/lang/String;)I","invokestatic",170);}
case 170:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/RuntimeVersion","buildNumber","I",value);f.Pc=173;continue;}
case 173:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","buildInformationPattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","buildInformationPattern","Ljava/util/regex/Pattern;"));f.Pc=176;continue;}
case 176:{f.Push(f.Locals[1]);f.Pc=177;continue;}
case 177:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",180);}
case 180:{f.Locals[4]=f.Pop();f.Pc=182;continue;}
case 182:{f.Push(f.Locals[4]);f.Pc=184;continue;}
case 184:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",187);}
case 187:{f.Pc=f.Pop().Int==0?199:190;continue;}
case 190:{f.Push(f.Locals[0]);f.Pc=191;continue;}
case 191:{f.Push(f.Locals[4]);f.Pc=193;continue;}
case 193:{return rt.Call(f,"java/util/regex/Matcher","group","()Ljava/lang/String;","invokevirtual",196);}
case 196:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/RuntimeVersion","buildInformation","Ljava/lang/String;",value);f.Pc=199;continue;}
case 199:{f.Pc=366;continue;}
case 202:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","versionStringPattern2","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","versionStringPattern2","Ljava/util/regex/Pattern;"));f.Pc=205;continue;}
case 205:{f.Push(f.Locals[1]);f.Pc=206;continue;}
case 206:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",209);}
case 209:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",212);}
case 212:{f.Pc=f.Pop().Int==0?268:215;continue;}
case 215:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","preReleasePattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","preReleasePattern","Ljava/util/regex/Pattern;"));f.Pc=218;continue;}
case 218:{f.Push(f.Locals[1]);f.Pc=219;continue;}
case 219:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",222);}
case 222:{f.Locals[4]=f.Pop();f.Pc=224;continue;}
case 224:{f.Push(f.Locals[4]);f.Pc=226;continue;}
case 226:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",229);}
case 229:{f.StackOp("pop");f.Pc=230;continue;}
case 230:{f.Push(f.Locals[0]);f.Pc=231;continue;}
case 231:{f.Push(f.Locals[4]);f.Pc=233;continue;}
case 233:{return rt.Call(f,"java/util/regex/Matcher","group","()Ljava/lang/String;","invokevirtual",236);}
case 236:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/RuntimeVersion","preReleaseIdentifier","Ljava/lang/String;",value);f.Pc=239;continue;}
case 239:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","buildInformationPattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","buildInformationPattern","Ljava/util/regex/Pattern;"));f.Pc=242;continue;}
case 242:{f.Push(f.Locals[1]);f.Pc=243;continue;}
case 243:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",246);}
case 246:{f.Locals[4]=f.Pop();f.Pc=248;continue;}
case 248:{f.Push(f.Locals[4]);f.Pc=250;continue;}
case 250:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",253);}
case 253:{f.Pc=f.Pop().Int==0?265:256;continue;}
case 256:{f.Push(f.Locals[0]);f.Pc=257;continue;}
case 257:{f.Push(f.Locals[4]);f.Pc=259;continue;}
case 259:{return rt.Call(f,"java/util/regex/Matcher","group","()Ljava/lang/String;","invokevirtual",262);}
case 262:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/RuntimeVersion","buildInformation","Ljava/lang/String;",value);f.Pc=265;continue;}
case 265:{f.Pc=366;continue;}
case 268:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","versionStringPattern3","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","versionStringPattern3","Ljava/util/regex/Pattern;"));f.Pc=271;continue;}
case 271:{f.Push(f.Locals[1]);f.Pc=272;continue;}
case 272:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",275);}
case 275:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",278);}
case 278:{f.Pc=f.Pop().Int==0?310:281;continue;}
case 281:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","buildInformationPattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","buildInformationPattern","Ljava/util/regex/Pattern;"));f.Pc=284;continue;}
case 284:{f.Push(f.Locals[1]);f.Pc=285;continue;}
case 285:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",288);}
case 288:{f.Locals[4]=f.Pop();f.Pc=290;continue;}
case 290:{f.Push(f.Locals[4]);f.Pc=292;continue;}
case 292:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",295);}
case 295:{f.Pc=f.Pop().Int==0?307:298;continue;}
case 298:{f.Push(f.Locals[0]);f.Pc=299;continue;}
case 299:{f.Push(f.Locals[4]);f.Pc=301;continue;}
case 301:{return rt.Call(f,"java/util/regex/Matcher","group","()Ljava/lang/String;","invokevirtual",304);}
case 304:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/RuntimeVersion","buildInformation","Ljava/lang/String;",value);f.Pc=307;continue;}
case 307:{f.Pc=366;continue;}
case 310:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","versionStringPattern4","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","versionStringPattern4","Ljava/util/regex/Pattern;"));f.Pc=313;continue;}
case 313:{f.Push(f.Locals[1]);f.Pc=314;continue;}
case 314:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",317);}
case 317:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",320);}
case 320:{f.Pc=f.Pop().Int==0?352:323;continue;}
case 323:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","preReleasePattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","preReleasePattern","Ljava/util/regex/Pattern;"));f.Pc=326;continue;}
case 326:{f.Push(f.Locals[1]);f.Pc=327;continue;}
case 327:{return rt.Call(f,"java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;","invokevirtual",330);}
case 330:{f.Locals[4]=f.Pop();f.Pc=332;continue;}
case 332:{f.Push(f.Locals[4]);f.Pc=334;continue;}
case 334:{return rt.Call(f,"java/util/regex/Matcher","find","()Z","invokevirtual",337);}
case 337:{f.Pc=f.Pop().Int==0?349:340;continue;}
case 340:{f.Push(f.Locals[0]);f.Pc=341;continue;}
case 341:{f.Push(f.Locals[4]);f.Pc=343;continue;}
case 343:{return rt.Call(f,"java/util/regex/Matcher","group","()Ljava/lang/String;","invokevirtual",346);}
case 346:{var value=f.Pop();rt.PutField(f.Pop(),"forge/util/RuntimeVersion","preReleaseIdentifier","Ljava/lang/String;",value);f.Pc=349;continue;}
case 349:{f.Pc=366;continue;}
case 352:{if(!rt.EnsureInitialized(f,"java/lang/IllegalArgumentException"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("java/lang/IllegalArgumentException")));f.Pc=355;continue;}
case 355:{f.StackOp("dup");f.Pc=356;continue;}
case 356:{f.Push(f.Locals[1]);f.Pc=357;continue;}
case 357:{return rt.DynamicCall(f,"forge/util/RuntimeVersion:12005:357:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;)Ljava/lang/String;",362);}
case 362:{return rt.Call(f,"java/lang/IllegalArgumentException","<init>","(Ljava/lang/String;)V","invokespecial",365);}
case 365:{throw new JavaFault(rt.NonNull(f.Pop()));}
case 366:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12006(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{if(!rt.EnsureInitialized(f,"forge/util/RuntimeVersion"))return JStep.Continue;f.Push(JValue.R(rt.Allocate("forge/util/RuntimeVersion")));f.Pc=3;continue;}
case 3:{f.StackOp("dup");f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{return rt.Call(f,"forge/util/RuntimeVersion","<init>","(Ljava/lang/String;)V","invokespecial",8);}
case 8:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12007(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/RuntimeVersion","minor","I"));f.Pc=4;continue;}
case 4:{f.Push(f.Locals[0]);f.Pc=5;continue;}
case 5:{f.Push(rt.GetField(f.Pop(),"forge/util/RuntimeVersion","securityLevel","I"));f.Pc=8;continue;}
case 8:{f.Push(f.Locals[0]);f.Pc=9;continue;}
case 9:{f.Push(rt.GetField(f.Pop(),"forge/util/RuntimeVersion","update","I"));f.Pc=12;continue;}
case 12:{return rt.DynamicCall(f,"forge/util/RuntimeVersion:12007:12:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(III)Ljava/lang/String;",17);}
case 17:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12008(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/RuntimeVersion","major","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12009(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/RuntimeVersion","minor","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12010(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/RuntimeVersion","securityLevel","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12011(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/RuntimeVersion","update","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12012(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/RuntimeVersion","preReleaseIdentifier","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12013(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/RuntimeVersion","buildNumber","I"));f.Pc=4;continue;}
case 4:{return JStep.Return(JNumbers.Narrow(f.Method.ReturnType,f.Pop()));}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12014(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(f.Locals[0]);f.Pc=1;continue;}
case 1:{f.Push(rt.GetField(f.Pop(),"forge/util/RuntimeVersion","buildInformation","Ljava/lang/String;"));f.Pc=4;continue;}
case 4:{return JStep.Return(f.Pop());}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}

internal static JStep M12015(JRuntime rt,JFrame f)
{
while(rt.Tick()){f.LastPc=f.Pc;switch(f.Pc){
case 0:{f.Push(JValue.R(rt.String("([1-9][0-9]*((\\.0)*\\.[0-9]*)*(_[0-9]+)?)")));f.Pc=2;continue;}
case 2:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",5);}
case 5:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","versionNumberPattern","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/RuntimeVersion","versionNumberPattern","Ljava/util/regex/Pattern;",f.Pop());f.Pc=8;continue;}
case 8:{f.Push(JValue.R(rt.String("([a-zA-Z0-9]+)")));f.Pc=10;continue;}
case 10:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",13);}
case 13:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","preReleasePattern","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/RuntimeVersion","preReleasePattern","Ljava/util/regex/Pattern;",f.Pop());f.Pc=16;continue;}
case 16:{f.Push(JValue.R(rt.String("(0|[1-9][0-9]*)")));f.Pc=18;continue;}
case 18:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",21);}
case 21:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","buildNumberPattern","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/RuntimeVersion","buildNumberPattern","Ljava/util/regex/Pattern;",f.Pop());f.Pc=24;continue;}
case 24:{f.Push(JValue.R(rt.String("([-a-zA-Z0-9.]+)")));f.Pc=26;continue;}
case 26:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",29);}
case 29:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","buildInformationPattern","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/RuntimeVersion","buildInformationPattern","Ljava/util/regex/Pattern;",f.Pop());f.Pc=32;continue;}
case 32:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","versionNumberPattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","versionNumberPattern","Ljava/util/regex/Pattern;"));f.Pc=35;continue;}
case 35:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",38);}
case 38:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","preReleasePattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","preReleasePattern","Ljava/util/regex/Pattern;"));f.Pc=41;continue;}
case 41:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",44);}
case 44:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","buildNumberPattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","buildNumberPattern","Ljava/util/regex/Pattern;"));f.Pc=47;continue;}
case 47:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",50);}
case 50:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","buildInformationPattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","buildInformationPattern","Ljava/util/regex/Pattern;"));f.Pc=53;continue;}
case 53:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",56);}
case 56:{return rt.DynamicCall(f,"forge/util/RuntimeVersion:12015:56:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",61);}
case 61:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",64);}
case 64:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","versionStringPattern1","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/RuntimeVersion","versionStringPattern1","Ljava/util/regex/Pattern;",f.Pop());f.Pc=67;continue;}
case 67:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","versionNumberPattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","versionNumberPattern","Ljava/util/regex/Pattern;"));f.Pc=70;continue;}
case 70:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",73);}
case 73:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","preReleasePattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","preReleasePattern","Ljava/util/regex/Pattern;"));f.Pc=76;continue;}
case 76:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",79);}
case 79:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","buildInformationPattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","buildInformationPattern","Ljava/util/regex/Pattern;"));f.Pc=82;continue;}
case 82:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",85);}
case 85:{return rt.DynamicCall(f,"forge/util/RuntimeVersion:12015:85:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",90);}
case 90:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",93);}
case 93:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","versionStringPattern2","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/RuntimeVersion","versionStringPattern2","Ljava/util/regex/Pattern;",f.Pop());f.Pc=96;continue;}
case 96:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","versionNumberPattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","versionNumberPattern","Ljava/util/regex/Pattern;"));f.Pc=99;continue;}
case 99:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",102);}
case 102:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","buildInformationPattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","buildInformationPattern","Ljava/util/regex/Pattern;"));f.Pc=105;continue;}
case 105:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",108);}
case 108:{return rt.DynamicCall(f,"forge/util/RuntimeVersion:12015:108:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",113);}
case 113:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",116);}
case 116:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","versionStringPattern3","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/RuntimeVersion","versionStringPattern3","Ljava/util/regex/Pattern;",f.Pop());f.Pc=119;continue;}
case 119:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","versionNumberPattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","versionNumberPattern","Ljava/util/regex/Pattern;"));f.Pc=122;continue;}
case 122:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",125);}
case 125:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","preReleasePattern","Ljava/util/regex/Pattern;"))return JStep.Continue;f.Push(rt.GetStatic("forge/util/RuntimeVersion","preReleasePattern","Ljava/util/regex/Pattern;"));f.Pc=128;continue;}
case 128:{return rt.Call(f,"java/lang/String","valueOf","(Ljava/lang/Object;)Ljava/lang/String;","invokestatic",131);}
case 131:{return rt.DynamicCall(f,"forge/util/RuntimeVersion:12015:131:java/lang/invoke/StringConcatFactory.makeConcatWithConstants","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",136);}
case 136:{return rt.Call(f,"java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;","invokestatic",139);}
case 139:{if(!rt.StaticReady(f,"forge/util/RuntimeVersion","versionStringPattern4","Ljava/util/regex/Pattern;"))return JStep.Continue;rt.PutStatic("forge/util/RuntimeVersion","versionStringPattern4","Ljava/util/regex/Pattern;",f.Pop());f.Pc=142;continue;}
case 142:{return JStep.ReturnVoid;}
default:throw new PortGap("Invalid generated program position");}}return JStep.Yield;
}
}}
