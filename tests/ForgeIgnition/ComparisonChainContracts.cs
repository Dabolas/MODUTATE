using Planeswalker.ForgeAot;

public static class ComparisonChainContracts
{
    public static void Run(JRuntime r,Action<bool,string> check)
    {
        const string type="com/google/common/collect/ComparisonChain";
        JValue Start()=>r.InvokeSynchronous(type,"start","()L"+type+";",default,[],"invokestatic");
        JValue Compare(JValue s,int left,int right)=>r.InvokeSynchronous(type,"compare","(II)L"+type+";",s,[JValue.I(left),JValue.I(right)]);
        int Result(JValue s)=>r.InvokeSynchronous(type,"result","()I",s,[]).Int;
        var start=Start();var lower=Compare(start,int.MinValue,int.MaxValue);
        check(Result(lower)==-1&&Result(start)==0,"Comparison chain handles integer extremes without subtraction overflow or mutating its start");
        check(Result(Compare(lower,9,1))==-1&&Result(Compare(Compare(start,2,2),9,1))==1,"Comparison chain uses later keys only when previous keys tie");
        var ignored=r.InvokeSynchronous(type,"compare","(Ljava/lang/Comparable;Ljava/lang/Comparable;)L"+type+";",lower,[JValue.R(null),JValue.R(null)]);
        check(Result(ignored)==-1,"Inactive comparison chain does not dereference later comparable operands");
        var ordered=r.InvokeSynchronous(type,"compare","(Ljava/lang/Comparable;Ljava/lang/Comparable;)L"+type+";",Start(),[JValue.R(r.String("A")),JValue.R(r.String("B"))]);
        check(Result(ordered)==-1,"Active comparison chain calls actual Comparable ordering");
        try{r.InvokeSynchronous(type,"compare","(Ljava/lang/Comparable;Ljava/lang/Comparable;)L"+type+";",Start(),[JValue.R(r.String("A")),r.BoxInt(1)]);check(false,"Incompatible Comparable operands must fail");}catch(JavaFault error){check(error.Value.ClassName=="java/lang/ClassCastException","String Comparable bridge rejects incompatible operands");}
        try{r.InvokeSynchronous(type,"compare","(Ljava/lang/Comparable;Ljava/lang/Comparable;)L"+type+";",Start(),[JValue.R(null),JValue.R(null)]);check(false,"Active null Comparable must fail");}catch(JavaFault error){check(error.Value.ClassName=="java/lang/NullPointerException","Active chain preserves Comparable null failure");}
    }
}
