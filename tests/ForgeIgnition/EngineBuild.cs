using System.Security.Cryptography;
using System.Text.Json;

public static class EngineBuild
{
    public static SortedDictionary<string,string> Fingerprint(string root)
    {
        var result=new SortedDictionary<string,string>(StringComparer.Ordinal);
        foreach(string name in new[]{"Forge.Aot.dll","Forge.Generated.dll","Forge.ConsoleHost.dll","ForgeIgnition.dll"})
            result.Add(name,Hash(Path.Combine(AppContext.BaseDirectory,name)));
        result.Add("card-data-manifest",Hash(Path.Combine(root,"data/forge/manifest.json")));
        return result;
    }
    private static string Hash(string path){using var stream=File.OpenRead(path);return Convert.ToHexString(SHA256.HashData(stream)).ToLowerInvariant();}
    public static void RequireStageZero(string root)
    {
        using var gate=JsonDocument.Parse(File.ReadAllText(BatchPaths.StageZero(root)));
        var data=gate.RootElement;
        if(!data.GetProperty("executed").GetBoolean()||!data.GetProperty("passed").GetBoolean())throw new InvalidOperationException("Stage 0 gate is closed; run --minimum-turn first");
        if(!data.TryGetProperty("build",out var build))throw new InvalidOperationException("Stage 0 has no build fingerprint; rerun --minimum-turn with this build");
        foreach(var pair in Fingerprint(root))
            if(!build.TryGetProperty(pair.Key,out var expected)||expected.GetString()!=pair.Value)throw new InvalidOperationException("Stage 0 is stale for "+pair.Key+"; rerun --minimum-turn before headless execution");
    }
}
