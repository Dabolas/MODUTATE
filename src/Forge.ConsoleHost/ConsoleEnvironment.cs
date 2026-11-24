using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeConsole;

public sealed class ConsoleEnvironment : IJavaEnvironmentHost,IJavaPlatformHost
{
    private readonly Action<string> log;
    public ConsoleEnvironment(Action<string> log){this.log=log;}
#if NETSTANDARD2_1
    public long MaximumMemory {get;set;}=int.MaxValue;
#else
    public static JHostResult Wait(long remaining)
    {
        do{
            int wait=(int)Math.Min(int.MaxValue,remaining);
            Thread.Sleep(wait);
            remaining-=wait;
        }while(remaining>0);
        return JHostResult.Complete();
    }
    public long MaximumMemory=>GC.GetGCMemoryInfo().TotalAvailableMemoryBytes;
#endif
    public long UsedMemory=>GC.GetTotalMemory(false);
    public int ProcessorCount=>Environment.ProcessorCount;
    public string? Property(string key)=>key switch{"java.awt.headless"=>"true","line.separator"=>"\n",_=>null};
    public long CurrentTimeMillis()=>DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    public long NanoTime()=>checked((long)(System.Diagnostics.Stopwatch.GetTimestamp()*(1_000_000_000.0/System.Diagnostics.Stopwatch.Frequency)));
    public string LineSeparator=>"\n";
    public void Write(string text)=>log(text);
}
