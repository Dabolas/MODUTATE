using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Planeswalker.ForgeAot
{
    // Java 17's Unicode 13 data is pinned, independent of the OS globalization version.
    // No-argument String casing uses the headless host's deterministic English locale.
    internal static class UnicodeCase
    {
        private sealed class Mapping
        {
            public string Lower="",Upper="";
            public string[] Conditions=Array.Empty<string>();
        }
        private static readonly Dictionary<int,int> Lower=new Dictionary<int,int>(),Upper=new Dictionary<int,int>(),Combining=new Dictionary<int,int>();
        private static readonly Dictionary<int,List<Mapping>> Special=new Dictionary<int,List<Mapping>>();
        private static readonly HashSet<int> Cased=new HashSet<int>(),Ignorable=new HashSet<int>(),SoftDotted=new HashSet<int>();
        private static int Hex(string s)=>int.Parse(s.Trim(),NumberStyles.HexNumber,CultureInfo.InvariantCulture);
        private static IEnumerable<string> Lines(string file)
        {
            var assembly=typeof(UnicodeCase).Assembly;
            string name=assembly.GetManifestResourceNames().Single(n=>n.EndsWith(".Unicode13."+file,StringComparison.Ordinal));
            using(var stream=assembly.GetManifestResourceStream(name)!)using(var reader=new StreamReader(stream))
            {string? line;while((line=reader.ReadLine())!=null)yield return line;}
        }
        private static string Code(int cp)=>cp<=0xffff?((char)cp).ToString():char.ConvertFromUtf32(cp);
        private static string MappingText(string text)=>string.Concat(text.Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries).Select(p=>Code(Hex(p))));
        static UnicodeCase()
        {
            foreach(string line in Lines("UnicodeData.txt"))
            {
                var f=line.Split(';');int cp=Hex(f[0]),ccc=int.Parse(f[3],CultureInfo.InvariantCulture);
                if(ccc!=0)Combining.Add(cp,ccc);
                if(f[12].Length!=0)Upper.Add(cp,Hex(f[12]));if(f[13].Length!=0)Lower.Add(cp,Hex(f[13]));
            }
            foreach(string file in new[]{"DerivedCoreProperties.txt","PropList.txt"})foreach(string line in Lines(file))
            {
                string text=line.Split('#')[0].Trim();if(text.Length==0)continue;
                var fields=text.Split(';');HashSet<int>? set=fields[1].Trim() switch{"Cased"=>Cased,"Case_Ignorable"=>Ignorable,"Soft_Dotted"=>SoftDotted,_=>null};if(set==null)continue;
                string[] range=fields[0].Trim().Split(new[]{".."},StringSplitOptions.None);int first=Hex(range[0]),last=Hex(range[range.Length-1]);for(int i=first;i<=last;i++)set.Add(i);
            }
            foreach(string line in Lines("SpecialCasing.txt"))
            {
                string text=line.Split('#')[0].Trim();if(text.Length==0)continue;var f=text.Split(';');int cp=Hex(f[0]);
                if(!Special.TryGetValue(cp,out var list))Special.Add(cp,list=new List<Mapping>());
                list.Add(new Mapping{Lower=MappingText(f[1].Trim()),Upper=MappingText(f[3].Trim()),Conditions=f[4].Trim().Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries)});
            }
        }
        private static int Ccc(int cp)=>Combining.TryGetValue(cp,out int c)?c:0;
        private static int Fold(int cp)=>Lower.TryGetValue(Upper.TryGetValue(cp,out int u)?u:cp,out int lower)?lower:(Upper.TryGetValue(cp,out u)?u:cp);
        private static int Including(string text,ref int index)
        {
            char c=text[index];
            if(char.IsLowSurrogate(c)&&index>0&&char.IsHighSurrogate(text[index-1]))return char.ConvertToUtf32(text[index-1],c);
            if(char.IsHighSurrogate(c)&&index+1<text.Length&&char.IsLowSurrogate(text[index+1]))return char.ConvertToUtf32(c,text[++index]);
            return c;
        }
        public static int CompareIgnoreCase(string left,string right)
        {
            for(int i=0,j=0;i<left.Length&&j<right.Length;i++,j++)
            {
                if(left[i]==right[j]||Fold(left[i])==Fold(right[j]))continue;
                int diff=Fold(Including(left,ref i))-Fold(Including(right,ref j));if(diff!=0)return diff;
            }
            return left.Length-right.Length;
        }
        private static bool Context(string condition,int[] points,int index,string language)
        {
            switch(condition)
            {
                case "tr":case "az":case "lt":return language==condition;
                case "Final_Sigma":
                    bool before=false;
                    for(int i=index-1;i>=0;i--){if(Ignorable.Contains(points[i]))continue;before=Cased.Contains(points[i]);break;}
                    if(!before)return false;
                    for(int i=index+1;i<points.Length;i++){if(Ignorable.Contains(points[i]))continue;return !Cased.Contains(points[i]);}return true;
                case "More_Above":
                    for(int i=index+1;i<points.Length;i++){int c=Ccc(points[i]);if(c==230)return true;if(c==0)return false;}return false;
                case "Before_Dot":
                    for(int i=index+1;i<points.Length;i++){if(points[i]==0x307)return true;int c=Ccc(points[i]);if(c==0||c==230)return false;}return false;
                case "Not_Before_Dot":return !Context("Before_Dot",points,index,language);
                case "After_I":case "After_Soft_Dotted":
                    for(int i=index-1;i>=0;i--){if(condition=="After_I"?points[i]==0x49:SoftDotted.Contains(points[i]))return true;int c=Ccc(points[i]);if(c==0||c==230)return false;}return false;
                default:throw new PortGap("Unknown pinned Unicode casing condition: "+condition);
            }
        }
        public static string Convert(string text,bool upper,string language)
        {
            var list=new List<int>(text.Length);
            for(int i=0;i<text.Length;i++){int cp=text[i];if(char.IsHighSurrogate(text[i])&&i+1<text.Length&&char.IsLowSurrogate(text[i+1])){cp=char.ConvertToUtf32(text[i],text[i+1]);i++;}list.Add(cp);}
            int[] points=list.ToArray();var result=new StringBuilder(text.Length);var simple=upper?Upper:Lower;
            for(int i=0;i<points.Length;i++)
            {
                int cp=points[i];Mapping? match=null;
                if(Special.TryGetValue(cp,out var mappings))
                {
                    foreach(var mapping in mappings)
                    {
                        if(mapping.Conditions.Length==0){match??=mapping;continue;}
                        if(mapping.Conditions.All(c=>Context(c,points,i,language))){match=mapping;break;}
                    }
                }
                if(match!=null)result.Append(upper?match.Upper:match.Lower);
                else result.Append(Code(simple.TryGetValue(cp,out int mapped)?mapped:cp));
            }
            return result.ToString();
        }
    }
}
