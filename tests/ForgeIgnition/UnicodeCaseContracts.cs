using System.Globalization;
using Planeswalker.ForgeAot;

public static class UnicodeCaseContracts
{
    public static void Run(JRuntime r,Action<bool,string> check)
    {
        string Case(string text,bool upper,string? locale=null)
        {
            var receiver=JValue.R(r.String(text));
            return r.StringValue(locale==null?r.InvokeSynchronous("java/lang/String",upper?"toUpperCase":"toLowerCase","()Ljava/lang/String;",receiver,[]):r.InvokeSynchronous("java/lang/String",upper?"toUpperCase":"toLowerCase","(Ljava/util/Locale;)Ljava/lang/String;",receiver,[JValue.R(r.HostObject("java/util/Locale",CultureInfo.GetCultureInfo(locale)))]));
        }
        check(Case("Juzám Djinn ÉOWYN",false)=="juzám djinn éowyn","Seed 43 card names support accented lowercasing");
        check(Case("straße ﬃ",true)=="STRASSE FFI","Unicode full uppercasing expands sharp-s and ligatures");
        check(Case("İ",false)=="i\u0307","Root dotted I lowercasing preserves the combining dot");
        check(Case("ΟΣ ΟΣΑ ΟΣ\u0301",false)=="ος οσα ος\u0301","Final sigma uses original-string context and ignores combining marks");
        check(Case("I İ I\u0307",false,"tr")=="ı i i"&&Case("i ı",true,"tr")=="İ I","Turkish casing observes before-dot and after-I context");
        check(Case("I\u0301",false,"lt")=="i\u0307\u0301"&&Case("i\u0307\u0301",true,"lt")=="I\u0301","Lithuanian casing preserves and removes contextual dots");
        check(Case("\U00010400😀\ud800",false)=="\U00010428😀\ud800","Supplementary characters map without changing emoji or isolated UTF16 surrogates");
        var sorted=r.InvokeSynchronous("forge/util/TextUtil","toSortableName","(Ljava/lang/String;)Ljava/lang/String;",default,[JValue.R(r.String("Juzám Djinn"))],"invokestatic");
        check(r.StringValue(sorted)=="juzm djinn","Seed 43 original TextUtil.toSortableName completes through casing and its explicit non-ASCII filtering");
        int Compare(string left,string right)=>r.InvokeSynchronous("java/lang/String","compareToIgnoreCase","(Ljava/lang/String;)I",JValue.R(r.String(left)),[JValue.R(r.String(right))]).Int;
        check(Compare("Juzám Djinn","JUZÁM DJINN")==0&&Compare("á","b")=='á'-'b',"Seed 43 paper-card comparison accepts accents and preserves code-point ordering");
        check(Compare("Iİıi","iiii")==0&&Compare("Σσς","σσσ")==0&&Compare("ß","SS")!=0,"Simple case-insensitive comparison does not use expanding full-string mappings");
        check(Compare("\U00010400","\U00010428")==0&&Compare("\ud800","\ud801")==-1&&Compare("AB","abc")==-1,"Case comparison handles supplementary pairs, isolated surrogates and UTF16 length tie-breaks");
    }
}
