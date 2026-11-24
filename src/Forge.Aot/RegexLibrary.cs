using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class PatternValue
        {internal readonly Regex Regex;internal readonly bool AsciiOnly;internal PatternValue(Regex regex,bool asciiOnly=false){Regex=regex;AsciiOnly=asciiOnly;}}
        private sealed class MatcherValue
        {internal readonly Regex Regex;internal readonly string Input;internal Match? Current;internal int At,AppendPosition;internal MatcherValue(Regex regex,string input){Regex=regex;Input=input;}}
        private void InstallRegex()
        {
            NativeClass("java/util/regex/Pattern");NativeClass("java/util/regex/Matcher");
            StandardBind("java/util/regex/Matcher","quoteReplacement","(Ljava/lang/String;)Ljava/lang/String;",(r,s,a)=>{
                string literal=r.Text(a[0]);
                string quoted=literal.Replace("\\","\\\\").Replace("$","\\$");
                return Done(ReferenceEquals(quoted,literal)?a[0]:JValue.R(r.NewString(quoted)));
            });
            foreach(string buffer in new[]{"StringBuffer","StringBuilder"})
            {
                StandardBind("java/util/regex/Matcher","appendReplacement","(Ljava/lang/"+buffer+";Ljava/lang/String;)Ljava/util/regex/Matcher;",(r,s,a)=>{var m=r.HostPayload<MatcherValue>(s);var match=r.CurrentMatch(s);var b=r.HostPayload<StringBuilder>(a[0]);b.Append(m.Input,m.AppendPosition,match.Index-m.AppendPosition);b.Append(r.JavaReplacement(match,r.Text(a[1])));m.AppendPosition=match.Index+match.Length;return Done(s);});
                StandardBind("java/util/regex/Matcher","appendTail","(Ljava/lang/"+buffer+";)Ljava/lang/"+buffer+";",(r,s,a)=>{var m=r.HostPayload<MatcherValue>(s);r.HostPayload<StringBuilder>(a[0]).Append(m.Input,m.AppendPosition,m.Input.Length-m.AppendPosition);return Done(a[0]);});
            }
            StandardBind("java/lang/String","replaceFirst","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",(r,s,a)=>{var pattern=r.HostPayload<PatternValue>(r.Pattern(a[0],0));string input=r.Text(s),replacement=r.Text(a[1]);if(pattern.AsciiOnly)AssertAscii(input);return Done(JValue.R(r.NewString(pattern.Regex.Replace(input,m=>r.JavaReplacement(m,replacement),1))));});
            StandardBind("java/lang/String","replaceAll","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",(r,s,a)=>
            {var pattern=r.HostPayload<PatternValue>(r.Pattern(a[0],0));string input=r.Text(s),replacement=r.Text(a[1]);if(pattern.AsciiOnly)AssertAscii(input);return Done(JValue.R(r.NewString(pattern.Regex.Replace(input,m=>r.JavaReplacement(m,replacement)))));});
            StandardBind("java/util/regex/Pattern","quote","(Ljava/lang/String;)Ljava/lang/String;",(r,s,a)=>Done(JValue.R(r.NewString("\\Q"+r.Text(a[0]).Replace("\\E","\\E\\\\E\\Q")+"\\E"))));
            StandardBind("java/lang/String","split","(Ljava/lang/String;)[Ljava/lang/String;",(r,s,a)=>Done(r.SplitJava(s,a[0],0)));
            StandardBind("java/lang/String","split","(Ljava/lang/String;I)[Ljava/lang/String;",(r,s,a)=>Done(r.SplitJava(s,a[0],a[1].Int)));
            StandardBind("java/util/regex/Pattern","compile","(Ljava/lang/String;)Ljava/util/regex/Pattern;",(r,s,a)=>Done(r.Pattern(a[0],0)));
            StandardBind("java/util/regex/Pattern","compile","(Ljava/lang/String;I)Ljava/util/regex/Pattern;",(r,s,a)=>Done(r.Pattern(a[0],a[1].Int)));
            StandardBind("java/util/regex/Pattern","split","(Ljava/lang/CharSequence;I)[Ljava/lang/String;",(r,s,a)=>Done(r.SplitJava(r.CharSequence(a[0]),r.HostPayload<PatternValue>(s),a[1].Int)));
            StandardBind("java/util/regex/Pattern","split","(Ljava/lang/CharSequence;)[Ljava/lang/String;",(r,s,a)=>Done(r.SplitJava(r.CharSequence(a[0]),r.HostPayload<PatternValue>(s),0)));
            StandardBind("java/util/regex/Pattern","matcher","(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;",(r,s,a)=>{var pattern=r.HostPayload<PatternValue>(s);string input=r.Text(a[0]);if(pattern.AsciiOnly)AssertAscii(input);return Done(JValue.R(r.HostObject("java/util/regex/Matcher",new MatcherValue(pattern.Regex,input))));});
            StandardBind("java/util/regex/Matcher","find","()Z",(r,s,a)=>
            {var m=r.HostPayload<MatcherValue>(s);if(m.At>m.Input.Length)return Done(JValue.I(0));m.Current=m.Regex.Match(m.Input,m.At);if(!m.Current.Success){m.At=m.Input.Length+1;return Done(JValue.I(0));}m.At=m.Current.Index+Math.Max(1,m.Current.Length);return Done(JValue.I(1));});
            StandardBind("java/util/regex/Matcher","matches","()Z",(r,s,a)=>
            {var m=r.HostPayload<MatcherValue>(s);m.Current=new Regex("\\A(?:"+m.Regex+ ")\\z",m.Regex.Options,TimeSpan.FromMilliseconds(250)).Match(m.Input);return Done(JValue.I(m.Current.Success?1:0));});
            StandardBind("java/util/regex/Matcher","group","()Ljava/lang/String;",(r,s,a)=>Done(r.MatchGroupValue(s,0)));
            StandardBind("java/util/regex/Matcher","replaceAll","(Ljava/lang/String;)Ljava/lang/String;",(r,s,a)=>{var matcher=r.HostPayload<MatcherValue>(s);string replacement=r.Text(a[0]);matcher.At=0;matcher.Current=null;string result=matcher.Regex.Replace(matcher.Input,m=>r.JavaReplacement(m,replacement));matcher.At=matcher.Input.Length+1;return Done(JValue.R(r.NewString(result)));});
            StandardBind("java/util/regex/Matcher","group","(I)Ljava/lang/String;",(r,s,a)=>Done(r.MatchGroupValue(s,a[0].Int)));
            StandardBind("java/util/regex/Matcher","start","()I",(r,s,a)=>Done(JValue.I(r.CurrentMatch(s).Index)));
            StandardBind("java/util/regex/Matcher","end","()I",(r,s,a)=>{var m=r.CurrentMatch(s);return Done(JValue.I(m.Index+m.Length));});
        }
        private Match CurrentMatch(JValue receiver)
        {var m=HostPayload<MatcherValue>(receiver).Current;if(m==null||!m.Success)throw Fault("java/lang/IllegalStateException");return m;}
        private string JavaReplacement(Match match,string replacement)
        {
            var result=new StringBuilder();
            for(int i=0;i<replacement.Length;i++)
            {
                char c=replacement[i];
                if(c=='\\'){if(++i==replacement.Length)throw Fault("java/lang/IllegalArgumentException","Trailing replacement escape");result.Append(replacement[i]);continue;}
                if(c!='$'){result.Append(c);continue;}
                if(++i==replacement.Length||replacement[i]<'0'||replacement[i]>'9')throw Fault("java/lang/IllegalArgumentException","Expected numeric capture group");
                int group=replacement[i]-'0';if(group>=match.Groups.Count)throw Fault("java/lang/IndexOutOfBoundsException","Unknown capture group");
                while(i+1<replacement.Length&&replacement[i+1]>='0'&&replacement[i+1]<='9')
                {int next=group*10+replacement[i+1]-'0';if(next>=match.Groups.Count)break;group=next;i++;}
                if(match.Groups[group].Success)result.Append(match.Groups[group].Value);
            }
            return result.ToString();
        }
        private JValue MatchGroupValue(JValue receiver,int index)
        {var m=CurrentMatch(receiver);if(index<0||index>=m.Groups.Count)throw Fault("java/lang/IndexOutOfBoundsException");return m.Groups[index].Success?JValue.R(NewString(m.Groups[index].Value)):JValue.R(null);}
        private JValue SplitJava(JValue source,JValue expression,int limit)
            =>SplitJava(Text(source),HostPayload<PatternValue>(Pattern(expression,0)),limit);
        private JValue SplitJava(string input,PatternValue pattern,int limit)
        {
            if(pattern.AsciiOnly)AssertAscii(input);var regex=pattern.Regex;
            var parts=new System.Collections.Generic.List<string>();int at=0;
            foreach(Match match in regex.Matches(input))
            {
                if(limit>0&&parts.Count==limit-1)break;
                if(match.Index==0&&match.Length==0&&at==0)continue;
                parts.Add(input.Substring(at,match.Index-at));at=match.Index+match.Length;
            }
            if(parts.Count==0)return StringArray(new[]{input});
            parts.Add(input.Substring(at));
            if(limit==0)while(parts.Count>0&&parts[parts.Count-1].Length==0)parts.RemoveAt(parts.Count-1);
            return StringArray(parts);
        }
        private JValue StringArray(System.Collections.Generic.IEnumerable<string> values)
        {var items=new System.Collections.Generic.List<string>(values);var result=NewArray("Ljava/lang/String;",items.Count);for(int i=0;i<items.Count;i++)result.Items[i]=JValue.R(NewString(items[i]));return JValue.R(result);}
        private JValue Pattern(JValue source,int flags)
        {
            string pattern=ExpandQuoted(Text(source));
            if((flags&~(2|4|8|16|32))!=0||pattern.Contains("&&")||Regex.IsMatch(pattern,@"\(\?<[^=!]" )||pattern.Contains("\\p{")||pattern.Contains("\\P{")||pattern.Contains("\\Q"))throw new PortGap("Java regex syntax/flags require a compatibility adapter: "+pattern);
            var options=RegexOptions.CultureInvariant;
            bool asciiOnly=(flags&2)!=0;if(asciiOnly){AssertAscii(pattern);options|=RegexOptions.IgnoreCase;}
            if((flags&4)!=0)options|=RegexOptions.IgnorePatternWhitespace;if((flags&8)!=0)options|=RegexOptions.Multiline;if((flags&32)!=0)options|=RegexOptions.Singleline;
            if((flags&16)!=0)pattern=Regex.Escape(Text(source));else pattern=AtomicPossessiveQuantifiers(pattern);
            try{return JValue.R(HostObject("java/util/regex/Pattern",new PatternValue(new Regex(pattern,options,TimeSpan.FromMilliseconds(250)),asciiOnly)));}
            catch(ArgumentException ex){throw Fault("java/util/regex/PatternSyntaxException",ex.Message);}
        }
        // Java's possessive Curly.match2 consumes without giving repetitions
        // back to the following node. A .NET atomic group has that same behavior.
        private static string AtomicPossessiveQuantifiers(string source)
        {
            var result=new StringBuilder();var groups=new System.Collections.Generic.Stack<int>();int atom=-1;
            for(int i=0;i<source.Length;i++)
            {
                char c=source[i];
                if(c=='\\')
                {
                    atom=result.Length;result.Append(c);if(++i>=source.Length)break;
                    char escape=source[i];result.Append(escape);
                    int extra=escape=='u'?4:escape=='x'?2:escape=='c'?1:0;
                    if(escape=='x'&&i+1<source.Length&&source[i+1]=='{'){do{result.Append(source[++i]);}while(i+1<source.Length&&source[i]!='}');}
                    else for(int n=0;n<extra&&i+1<source.Length;n++)result.Append(source[++i]);
                    if(char.IsDigit(escape))while(i+1<source.Length&&char.IsDigit(source[i+1]))result.Append(source[++i]);
                    continue;
                }
                if(c=='[')
                {
                    atom=result.Length;result.Append(c);
                    while(++i<source.Length){result.Append(source[i]);if(source[i]=='\\'&&i+1<source.Length){result.Append(source[++i]);continue;}if(source[i]==']')break;}
                    continue;
                }
                if(c=='('){groups.Push(result.Length);result.Append(c);atom=-1;continue;}
                if(c==')'){result.Append(c);atom=groups.Count==0?-1:groups.Pop();continue;}
                if(c=='|'){result.Append(c);atom=-1;continue;}
                int end=i;
                bool quantified=atom>=0&&(c=='*'||c=='+'||c=='?');
                if(atom>=0&&c=='{')
                {
                    var bound=Regex.Match(source.Substring(i),@"^\{\d+(?:,\d*)?\}");
                    if(bound.Success){quantified=true;end=i+bound.Length-1;}
                }
                if(quantified)
                {
                    result.Append(source,i,end-i+1);i=end;
                    if(i+1<source.Length&&source[i+1]=='+')
                    {string body=result.ToString(atom,result.Length-atom);result.Length=atom;result.Append("(?>").Append(body).Append(')');i++;}
                    else if(i+1<source.Length&&source[i+1]=='?')result.Append(source[++i]);
                    continue;
                }
                atom=result.Length;result.Append(c);
            }
            return result.ToString();
        }
        private static string ExpandQuoted(string source)
        {
            var result=new StringBuilder();
            for(int i=0;i<source.Length;i++)
            {
                if(source[i]!='\\'||i+1==source.Length){result.Append(source[i]);continue;}
                if(source[i+1]!='Q'){result.Append(source[i]).Append(source[++i]);continue;}
                int start=i+2,end=source.IndexOf("\\E",start,StringComparison.Ordinal);if(end<0)end=source.Length;
                result.Append(Regex.Escape(source.Substring(start,end-start)));i=end==source.Length?source.Length-1:end+1;
            }
            return result.ToString();
        }
    }
}
