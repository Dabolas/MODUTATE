using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        // Contracts checked against commons-lang 3.18.0, pinned by forge-core/pom.xml.
        // Independent managed implementations; no Java process or host I/O.
        private JValue StripString(JValue value,JValue characters)
        {
            if(value.Reference==null)return value;string text=CharSequence(value);string? set=characters.Reference==null?null:CharSequence(characters);
            bool Strip(char c)=>set==null?JavaBlank(c.ToString()):set.IndexOf(c)>=0;
            int start=0,end=text.Length;while(start<end&&Strip(text[start]))start++;while(end>start&&Strip(text[end-1]))end--;return JValue.R(String(text.Substring(start,end-start)));
        }
        private void InstallApacheStringFamily()
        {
            const string owner="org/apache/commons/lang3/StringUtils";
            StandardBind(owner,"contains","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z",(r,s,a)=>Done(JValue.I(a[0].Reference!=null&&a[1].Reference!=null&&r.CharSequence(a[0]).Contains(r.CharSequence(a[1]),StringComparison.Ordinal)?1:0)));
            StandardBind(owner,"defaultString","(Ljava/lang/String;)Ljava/lang/String;",(r,s,a)=>Done(a[0].Reference==null?JValue.R(r.String("")):a[0]));
            StandardBind(owner,"countMatches","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I",(r,s,a)=>
            {if(a.Any(v=>v.Reference==null))return Done(JValue.I(0));string text=r.CharSequence(a[0]),term=r.CharSequence(a[1]);int count=0,offset=0;if(term.Length>0)while((offset=text.IndexOf(term,offset,StringComparison.Ordinal))>=0){count++;offset+=term.Length;}return Done(JValue.I(count));});
            StandardBind(owner,"equalsAnyIgnoreCase","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z",(r,s,a)=>
            {if(a[1].Reference==null)return Done(JValue.I(0));return Done(JValue.I(r.ArrayObject(a[1]).Items.Any(v=>a[0].Reference==null?v.Reference==null:v.Reference!=null&&UnicodeCase.CompareIgnoreCase(r.CharSequence(a[0]),r.CharSequence(v))==0)?1:0));});
            StandardBind(owner,"startsWithAny","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z",(r,s,a)=>
            {if(a[0].Reference==null||a[1].Reference==null)return Done(JValue.I(0));string text=r.CharSequence(a[0]);return Done(JValue.I(text.Length>0&&r.ArrayObject(a[1]).Items.Any(v=>v.Reference!=null&&text.StartsWith(r.CharSequence(v),StringComparison.Ordinal))?1:0));});
            StandardBind(owner,"indexOfAny","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)I",(r,s,a)=>
            {if(a.Any(v=>v.Reference==null))return Done(JValue.I(-1));string text=r.CharSequence(a[0]);int best=int.MaxValue;foreach(var value in r.ArrayObject(a[1]).Items){if(value.Reference==null)continue;int found=text.IndexOf(r.CharSequence(value),StringComparison.Ordinal);if(found>=0)best=Math.Min(best,found);}return Done(JValue.I(best==int.MaxValue?-1:best));});
            foreach(string suffix in new[]{"","Ljava/lang/String;","Ljava/lang/String;II"})StandardBind(owner,"join","([Ljava/lang/Object;"+suffix+")Ljava/lang/String;",(r,s,a)=>
            {
                if(a[0].Reference==null)return Done(default);var values=r.ArrayObject(a[0]).Items;int from=a.Length==4?a[2].Int:0,to=a.Length==4?a[3].Int:values.Length;if(from<0)throw r.Fault("java/lang/IllegalArgumentException");
                string delimiter=a.Length<2||a[1].Reference==null?"":r.CharSequence(a[1]);var chunks=values.Skip(from).Take(Math.Max(0,unchecked(to-from))).Select(v=>v.Reference==null?"":r.CharSequence(r.InlineCall("java/lang/Object","toString","()Ljava/lang/String;",v,Array.Empty<JValue>())));
                return Done(JValue.R(r.String(string.Join(delimiter,chunks))));
            });
            foreach(bool separator in new[]{false,true})StandardBind(owner,"repeat",separator?"(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;":"(Ljava/lang/String;I)Ljava/lang/String;",(r,s,a)=>
            {
                if(a[0].Reference==null)return Done(default);string text=r.CharSequence(a[0]),delimiter=separator&&a[1].Reference!=null?r.CharSequence(a[1]):"";int count=a[a.Length-1].Int;if(count<=0)return Done(JValue.R(r.String("")));
                long length=(long)text.Length*count+(long)delimiter.Length*(count-1);if(length>int.MaxValue)throw r.Fault("java/lang/OutOfMemoryError");if(length==0)return Done(JValue.R(r.String("")));var result=new StringBuilder((int)length);for(int i=0;i<count;i++){if(i!=0)result.Append(delimiter);result.Append(text);}return Done(JValue.R(r.String(result.ToString())));
            });
            foreach(bool character in new[]{false,true})StandardBind(owner,"split",character?"(Ljava/lang/String;C)[Ljava/lang/String;":"(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;",(r,s,a)=>
            {
                if(a[0].Reference==null)return Done(default);string text=r.CharSequence(a[0]);string? separators=character?((char)a[1].Int).ToString():a[1].Reference==null?null:r.CharSequence(a[1]);var words=new List<string>();int begin=0;
                for(int i=0;i<=text.Length;i++)if(i==text.Length||(separators==null?JavaBlank(text[i].ToString()):separators.IndexOf(text[i])>=0)){if(i>begin)words.Add(text.Substring(begin,i-begin));begin=i+1;}return Done(r.StringArray(words));
            });
            StandardBind(owner,"strip","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",(r,s,a)=>Done(r.StripString(a[0],a[1])));
            StandardBind(owner,"stripAll","([Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;",(r,s,a)=>
            {if(a[0].Reference==null)return Done(default);var original=r.ArrayObject(a[0]);if(original.Items.Length==0)return Done(a[0]);var result=r.NewArray("Ljava/lang/String;",original.Items.Length);for(int i=0;i<original.Items.Length;i++)result.Items[i]=r.StripString(original.Items[i],a[1]);return Done(JValue.R(result));});
            StandardBind(owner,"truncate","(Ljava/lang/String;I)Ljava/lang/String;",(r,s,a)=>{if(a[1].Int<0)throw r.Fault("java/lang/IllegalArgumentException");if(a[0].Reference==null)return Done(default);string text=r.CharSequence(a[0]);return Done(text.Length<=a[1].Int?a[0]:JValue.R(r.String(text.Substring(0,a[1].Int))));});
            StandardBind(owner,"getLevenshteinDistance","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I",(r,s,a)=>
            {
                if(a[0].Reference==null||a[1].Reference==null||a[2].Int<0)throw r.Fault("java/lang/IllegalArgumentException");string left=r.CharSequence(a[0]),right=r.CharSequence(a[1]);int threshold=a[2].Int;
                if(Math.Abs((long)left.Length-right.Length)>threshold)return Done(JValue.I(-1));if((long)left.Length*right.Length>10000000)throw new PortGap("Levenshtein work budget exceeded");
                int[] row=Enumerable.Range(0,right.Length+1).ToArray();for(int i=0;i<left.Length;i++){int diagonal=row[0];row[0]=i+1;for(int j=0;j<right.Length;j++){int above=row[j+1];row[j+1]=Math.Min(Math.Min(above+1,row[j]+1),diagonal+(left[i]==right[j]?0:1));diagonal=above;}}
                return Done(JValue.I(row[right.Length]<=threshold?row[right.Length]:-1));
            });
        }
    }
}
