using System;
using System.Collections.Generic;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class TokenizerState
        {
            internal string Text="";
            internal HashSet<int>? Delimiters;
            internal bool ReturnDelimiters;
            internal int Position;
            internal static int Point(string text,int at,out int width)
            {width=char.IsHighSurrogate(text[at])&&at+1<text.Length&&char.IsLowSurrogate(text[at+1])?2:1;return width==2?char.ConvertToUtf32(text,at):text[at];}
            internal void SetDelimiters(string? text)
            {Delimiters=text==null?null:new HashSet<int>();if(text!=null)for(int i=0;i<text.Length;){Delimiters!.Add(Point(text,i,out int width));i+=width;}}
            internal int Skip(int at)
            {if(ReturnDelimiters)return at;while(at<Text.Length&&Delimiters!.Contains(Point(Text,at,out _))){Point(Text,at,out int width);at+=width;}return at;}
            internal int End(int at)
            {int start=at;while(at<Text.Length){int point=Point(Text,at,out int width);if(Delimiters!.Contains(point))return at==start&&ReturnDelimiters?at+width:at;at+=width;}return at;}
        }
        private void InstallStringTokenizer()
        {
            const string type="java/util/StringTokenizer";NativeClass("java/util/Enumeration");NativeClass(type,"java/lang/Object","java/util/Enumeration");
            foreach(string signature in new[]{"(Ljava/lang/String;)V","(Ljava/lang/String;Ljava/lang/String;)V","(Ljava/lang/String;Ljava/lang/String;Z)V"})
                StandardBind(type,"<init>",signature,(r,s,a)=>{r.NonNull(a[0]);var state=new TokenizerState{Text=r.Text(a[0]),ReturnDelimiters=a.Length==3&&a[2].Int!=0};state.SetDelimiters(a.Length==1?" \t\n\r\f":a[1].Reference==null?null:r.Text(a[1]));r.NonNull(s).Payload=state;return Done();});
            TokenizerState State(JRuntime r,JValue s)
            {var state=(TokenizerState)r.NonNull(s).Payload!;if(state.Delimiters==null)throw r.Fault("java/lang/NullPointerException");return state;}
            foreach(string name in new[]{"hasMoreTokens","hasMoreElements"})StandardBind(type,name,"()Z",(r,s,a)=>{var t=State(r,s);return Done(JValue.I(t.Skip(t.Position)<t.Text.Length?1:0));});
            foreach(var method in new[]{("nextToken","()Ljava/lang/String;"),("nextToken","(Ljava/lang/String;)Ljava/lang/String;"),("nextElement","()Ljava/lang/Object;")})
                StandardBind(type,method.Item1,method.Item2,(r,s,a)=>{if(a.Length!=0)((TokenizerState)r.NonNull(s).Payload!).SetDelimiters(a[0].Reference==null?null:r.Text(a[0]));var t=State(r,s);t.Position=t.Skip(t.Position);if(t.Position>=t.Text.Length)throw r.Fault("java/util/NoSuchElementException");int start=t.Position;t.Position=t.End(start);return Done(JValue.R(r.String(t.Text.Substring(start,t.Position-start))));});
            StandardBind(type,"countTokens","()I",(r,s,a)=>{var t=State(r,s);int count=0,at=t.Position;while((at=t.Skip(at))<t.Text.Length){at=t.End(at);count++;}return Done(JValue.I(count));});
        }
    }
}
