using System.Globalization;
using System.Text;
using Planeswalker.ForgeAot;

namespace Planeswalker.ForgeConsole;

public interface IForgeTextHost
{
    string Message(string key,IReadOnlyList<string> arguments,bool english);
}

// Localization is presentation policy, not a replacement for card or game rules.
public sealed class ConsoleLocalization : IForgeTextHost
{
    private readonly Dictionary<string,string> messages=new(StringComparer.Ordinal);
#if !NETSTANDARD2_1
    public ConsoleLocalization(string path):this(File.ReadLines(path,Encoding.UTF8)){}
#endif
    public ConsoleLocalization(IEnumerable<string> lines)
    {
        string pending="";
        foreach(string raw in lines)
        {
            string line=pending+raw.TrimStart();int slash=0;for(int i=line.Length-1;i>=0&&line[i]=='\\';i--)slash++;
            if(slash%2!=0){pending=line[..^1];continue;}pending="";
            if(line.Length==0||line[0] is '#' or '!')continue;
            int split=-1;bool escape=false;
            for(int i=0;i<line.Length;i++){if(!escape&&(line[i] is '=' or ':'||char.IsWhiteSpace(line[i]))){split=i;break;}escape=line[i]=='\\'&&!escape;}
            string key=split<0?line:line[..split];int start=split<0?line.Length:split;
            while(start<line.Length&&char.IsWhiteSpace(line[start]))start++;
            if(start<line.Length&&line[start] is '=' or ':')start++;
            while(start<line.Length&&char.IsWhiteSpace(line[start]))start++;
            messages[Unescape(key)]=Unescape(line[start..]);
        }
    }
    private static string Unescape(string value)
    {
        var b=new StringBuilder();for(int i=0;i<value.Length;i++)
        {char c=value[i];if(c!='\\'){b.Append(c);continue;}if(++i==value.Length)break;c=value[i];if(c=='u'){b.Append((char)int.Parse(value.AsSpan(i+1,4),NumberStyles.HexNumber,CultureInfo.InvariantCulture));i+=4;}else b.Append(c switch{'n'=>'\n','r'=>'\r','t'=>'\t','f'=>'\f',_=>c});}return b.ToString();
    }
    public string Message(string key,IReadOnlyList<string> arguments,bool english)
    {
        if(!messages.TryGetValue(key,out var text)){
            // Card scripts can supply literal prompts to the same Forge API as resource keys.
            if(arguments.Count==0&&key.Any(char.IsWhiteSpace))return key;
            throw new PortGap("Missing console translation: "+key);
        }
        var output=new StringBuilder();bool quoted=false;
        for(int i=0;i<text.Length;i++)
        {
            char c=text[i];
            if(c=='\''){if(i+1<text.Length&&text[i+1]=='\''){output.Append('\'');i++;}else quoted=!quoted;continue;}
            if(c=='{'&&!quoted)
            {
                int end=text.IndexOf('}',i+1);if(end<0)throw new FormatException("Unclosed message placeholder: "+key);
                string spec=text[(i+1)..end];if(!int.TryParse(spec,NumberStyles.None,CultureInfo.InvariantCulture,out int index))throw new PortGap("Typed MessageFormat style requires an adapter: "+key+" / "+spec);
                output.Append(index<arguments.Count?arguments[index]:"{"+index+"}");i=end;
            }
            else output.Append(c);
        }
        return output.ToString();
    }
    public static void Install(JRuntime runtime,IForgeTextHost host)
    {
        foreach(string name in new[]{"getMessage","getEnglishMessage"})
            runtime.Bind("forge/util/Localizer",name,"(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;",(r,s,a)=>
            {var args=((JArray)r.NonNull(a[1])).Items.Select(v=>v.Reference==null?"null":r.StringValue(r.InvokeSynchronous("java/lang/Object","toString","()Ljava/lang/String;",v,[]))).ToArray();return JHostResult.Complete(JValue.R(r.String(host.Message(r.StringValue(a[0]),args,name=="getEnglishMessage"))));});
    }
}
