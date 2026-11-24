using Planeswalker.ForgeAot;
public static class ApacheStringContracts
{
    public static void Run(JRuntime r,Action<bool,string> check)
    {
        JValue S(string text)=>JValue.R(r.String(text));JValue nil=JValue.R(null);
        JValue Call(string name,string desc,params JValue[] args)=>r.InvokeSynchronous("org/apache/commons/lang3/StringUtils",name,desc,default,args,"invokestatic");
        JValue Array(string type,params JValue[] values){var array=r.NewArray("L"+type+";",values.Length);values.CopyTo(array.Items,0);return JValue.R(array);}
        void Fault(Action action,string label){try{action();check(false,label);}catch(JavaFault ex){check(ex.Value.ClassName=="java/lang/IllegalArgumentException",label);}}
        check(Call("contains","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z",S("abc"),S("")).Int==1&&Call("contains","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z",nil,S("")).Int==0,"Apache contains distinguishes empty search from null source");
        check(Call("countMatches","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I",S("aaaaa"),S("aa")).Int==2,"Apache countMatches counts nonoverlapping substrings");
        check(Call("countMatches","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I",S("abc"),S("")).Int==0,"Empty match string has zero occurrences");
        check(r.StringValue(Call("defaultString","(Ljava/lang/String;)Ljava/lang/String;",nil))=="","defaultString replaces null only");
        check(Call("equalsAnyIgnoreCase","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z",nil,Array("java/lang/CharSequence",S("x"),nil)).Int==1,"Case-insensitive candidate list allows null equal to null");
        check(Call("equalsAnyIgnoreCase","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z",S("JUZÁM"),Array("java/lang/CharSequence",S("Juzám"))).Int==1,"Case-insensitive names use pinned Unicode folding");
        check(Call("indexOfAny","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)I",S("xxabc"),Array("java/lang/CharSequence",nil,S("bc"),S("a"))).Int==2,"indexOfAny chooses earliest substring position rather than candidate order");
        check(Call("startsWithAny","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z",S("abc"),Array("java/lang/CharSequence",nil,S(""))).Int==1&&Call("startsWithAny","(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z",S(""),Array("java/lang/CharSequence",S(""))).Int==0,"startsWithAny handles empty prefix and empty source per Commons 3.18");
        var objects=Array("java/lang/Object",S("one"),nil,r.BoxInt(7));
        check(r.StringValue(Call("join","([Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;",objects,S("|")))=="one||7","Object join handles null elements and executes object toString");
        check(r.StringValue(Call("join","([Ljava/lang/Object;)Ljava/lang/String;",objects))=="one7","Separator-free Object join");
        check(r.StringValue(Call("join","([Ljava/lang/Object;Ljava/lang/String;II)Ljava/lang/String;",objects,S("|"),JValue.I(1),JValue.I(99)))=="|7","Pinned 3.18 Object join stream limits a range past array end");
        check(Call("join","([Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;",nil,S("|")).Reference==null,"Joining a null array returns null");
        Fault(()=>Call("join","([Ljava/lang/Object;Ljava/lang/String;II)Ljava/lang/String;",objects,S("|"),JValue.I(-1),JValue.I(2)),"Negative Object join skip throws");
        check(r.StringValue(Call("repeat","(Ljava/lang/String;I)Ljava/lang/String;",S("xy"),JValue.I(-2)))=="","Negative repeat count produces empty string");
        check(r.StringValue(Call("repeat","(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;",S("x"),S("/"),JValue.I(3)))=="x/x/x","Repeat inserts separators only between repetitions");
        var split=(JArray)Call("split","(Ljava/lang/String;C)[Ljava/lang/String;",S("::a::b:"),JValue.I(':')).Reference!;check(split.Items.Select(r.StringValue).SequenceEqual(["a","b"]),"Character split suppresses empty tokens");
        split=(JArray)Call("split","(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;",S(" a\t\u2003b "),nil).Reference!;check(split.Items.Select(r.StringValue).SequenceEqual(["a","b"]),"Null split separators use Java whitespace");
        split=(JArray)Call("split","(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;",S("a,b;c"),S(",;")).Reference!;check(split.Items.Select(r.StringValue).SequenceEqual(["a","b","c"]),"String split separators form a character set");
        check(r.StringValue(Call("strip","(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;",S("\u00a0 x \u00a0"),nil))=="\u00a0 x \u00a0","Java strip does not treat nonbreaking spaces as whitespace");
        var stripped=(JArray)Call("stripAll","([Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;",Array("java/lang/String",S("xyAbxy"),nil),S("xy")).Reference!;check(r.StringValue(stripped.Items[0])=="Ab"&&stripped.Items[1].Reference==null,"stripAll trims supplied characters and preserves null entries");
        check(r.StringValue(Call("truncate","(Ljava/lang/String;I)Ljava/lang/String;",S("abcdef"),JValue.I(3)))=="abc","truncate respects maximum UTF-16 length");
        Fault(()=>Call("truncate","(Ljava/lang/String;I)Ljava/lang/String;",nil,JValue.I(-1)),"truncate rejects negative width even for null input");
        check(Call("getLevenshteinDistance","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I",S("kitten"),S("sitting"),JValue.I(3)).Int==3&&Call("getLevenshteinDistance","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I",S("kitten"),S("sitting"),JValue.I(2)).Int==-1,"Levenshtein distance respects inclusive threshold and rejection boundary");
        Fault(()=>Call("getLevenshteinDistance","(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I",nil,S("x"),JValue.I(2)),"Levenshtein rejects null input");
    }
}
