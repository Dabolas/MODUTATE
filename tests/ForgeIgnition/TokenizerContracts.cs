using Planeswalker.ForgeAot;

public static class TokenizerContracts
{
    public static void Run(JRuntime r,Action<bool,string> check)
    {
        const string type="java/util/StringTokenizer";
        JValue S(string text)=>JValue.R(r.String(text));
        JValue Call(JValue t,string name,string desc,params JValue[] args)=>r.InvokeSynchronous(type,name,desc,t,args);
        JValue New(string text,string delimiter,bool keep){var t=JValue.R(r.Allocate(type));Call(t,"<init>","(Ljava/lang/String;Ljava/lang/String;Z)V",S(text),S(delimiter),JValue.I(keep?1:0));return t;}
        string[] Drain(JValue t){var result=new List<string>();while(Call(t,"hasMoreTokens","()Z").Int!=0)result.Add(r.StringValue(Call(t,"nextToken","()Ljava/lang/String;")));return result.ToArray();}
        var tokens=New(" a,,b "," ,",true);
        check(Call(tokens,"countTokens","()I").Int==6&&Drain(tokens).SequenceEqual(new[]{" ","a",",",",","b"," "}),"Effect text tokenizer preserves adjacent separators and count does not consume input");
        var skipped=New(" a,,b "," ,",false);check(Drain(skipped).SequenceEqual(new[]{"a","b"}),"Tokenizer skips delimiters without empty tokens");
        try{Call(skipped,"nextToken","()Ljava/lang/String;");check(false,"Tokenizer exhaustion must throw");}catch(JavaFault e){check(e.Value.ClassName=="java/util/NoSuchElementException","Tokenizer exhaustion throws instead of returning default");check(e.Data["Forge.JavaStack"] is string origin&&origin.Length>0&&e.ToString().Contains("NoSuchElementException",StringComparison.Ordinal),"Failure preserves its exception kind and original frame stack after unwinding");}
        var changed=New("a,b;c",",",false);Call(changed,"nextToken","()Ljava/lang/String;");check(r.StringValue(Call(changed,"nextToken","(Ljava/lang/String;)Ljava/lang/String;",S(";")))==",b"&&Drain(changed).SequenceEqual(new[]{"c"}),"Changed delimiters apply at the current cursor and persist");
        check(Drain(New("A😀B😀","😀",true)).SequenceEqual(new[]{"A","😀","B","😀"}),"Tokenizer treats supplementary Unicode delimiters as whole code points");
    }
}
