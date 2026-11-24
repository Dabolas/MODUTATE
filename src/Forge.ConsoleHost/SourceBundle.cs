using System.IO.Compression;
using System.Security.Cryptography;
using System.Text.Json;

namespace Planeswalker.ForgeConsole;

public static class SourceBundle
{
    public static void Create(string root,string reportDirectory)
    {
        var paths=new SortedSet<string>(StringComparer.Ordinal);
        foreach(string folder in new[]{"src/Forge.Aot","src/Forge.ConsoleHost","tests/ForgeIgnition","migration/forge-aot/generated"})
        foreach(string file in Directory.EnumerateFiles(Path.Combine(root,folder),"*",SearchOption.TopDirectoryOnly))
            if(Path.GetExtension(file) is ".cs" or ".csproj")paths.Add(Path.GetRelativePath(root,file));
        foreach(string folder in new[]{"data/forge"})
        foreach(string file in Directory.EnumerateFiles(Path.Combine(root,folder),"*.json",SearchOption.AllDirectories))paths.Add(Path.GetRelativePath(root,file));
        foreach(string file in new[]{"NuGet.Config","tools/run-forge-console.ps1","migration/forge-aot/Forge.Generated.csproj","migration/forge-aot/linkage-gaps.json","migration/forge-aot/host-contracts.json","external/forge/LICENSE"})
            if(File.Exists(Path.Combine(root,file)))paths.Add(file);
        paths.Add("src/Forge.ConsoleHost/Data/TypeLists.txt");
        foreach(string file in Directory.EnumerateFiles(Path.Combine(root,"src/Forge.Aot/Unicode13"),"*",SearchOption.TopDirectoryOnly))paths.Add(Path.GetRelativePath(root,file));
        foreach(string file in Directory.EnumerateFiles(reportDirectory,"*",SearchOption.TopDirectoryOnly))paths.Add(Path.GetRelativePath(root,file));
        if(File.Exists(Path.Combine(root,"HANDOFF.md")))paths.Add("HANDOFF.md");
        if(File.Exists(Path.Combine(root,"README.md")))paths.Add("README.md");
        string followup=Path.Combine(root,"release/forge-followup");
        if(Directory.Exists(followup))foreach(string file in Directory.EnumerateFiles(followup,"*",SearchOption.TopDirectoryOnly))paths.Add(Path.GetRelativePath(root,file));
        string l3=Path.Combine(root,"release/forge-l3");
        if(Directory.Exists(l3))foreach(string file in Directory.EnumerateFiles(l3,"*",SearchOption.TopDirectoryOnly))paths.Add(Path.GetRelativePath(root,file));
        string matrix=Path.Combine(root,"release/forge-l3-matrix");
        if(Directory.Exists(matrix))foreach(string file in Directory.EnumerateFiles(matrix,"*",SearchOption.TopDirectoryOnly))paths.Add(Path.GetRelativePath(root,file));
        string advanced=Path.Combine(root,"release/forge-advanced");
        if(Directory.Exists(advanced))foreach(string file in Directory.EnumerateFiles(advanced,"*",SearchOption.TopDirectoryOnly))paths.Add(Path.GetRelativePath(root,file));
        foreach(string file in new[]{"tools/run-forge-advanced.ps1","Advanced_Mechanism_Coverage.md"})if(File.Exists(Path.Combine(root,file)))paths.Add(file);
        // Include the audited originals so taxonomy hashing also works from the source bundle.
        foreach(string module in new[]{"ability/effects","replacement","staticability","trigger","phase","keyword"})
        foreach(string file in Directory.EnumerateFiles(Path.Combine(root,"external/forge/forge-game/src/main/java/forge/game",module),"*.java",SearchOption.AllDirectories))paths.Add(Path.GetRelativePath(root,file));
        foreach(string file in new[]{"GameAction.java","StaticEffect.java","StaticEffects.java"})
        {string original="external/forge/forge-game/src/main/java/forge/game/"+file;if(File.Exists(Path.Combine(root,original)))paths.Add(original);}
        foreach(string file in new[]{"tools/run-forge-l3-matrix.ps1","L3_Full_Report.md"})if(File.Exists(Path.Combine(root,file)))paths.Add(file);
        foreach(string file in new[]{"tools/run-forge-l3.ps1","docs/MINIMUM_PLAYABLE_STATE.md","data/runtime/en-US.properties"})if(File.Exists(Path.Combine(root,file)))paths.Add(file);
        foreach(string file in new[]{"tools/run-forge-headless.ps1","docs/HEADLESS_FUZZING.md","docs/DISCOVERY_MODE.md","docs/REPRESENTATIVE_CARDS.md","Headless_Fuzz_Report.md"})if(File.Exists(Path.Combine(root,file)))paths.Add(file);
        foreach(string folder in new[]{"release/forge-turn","release/forge-headless","release/forge-discovery","tests/ForgeIgnition/Corpus"})
        {
            string directory=Path.Combine(root,folder);if(!Directory.Exists(directory))continue;
            foreach(string file in Directory.EnumerateFiles(directory,"*",SearchOption.AllDirectories))
            {
                string relative=Path.GetRelativePath(root,file).Replace('\\','/');
                if(relative.Split('/').Any(p=>p.StartsWith("runner",StringComparison.Ordinal)||p is "bin" or "obj"))continue;
                // Full traces stay in the local artifact directory. Reproducer inputs,
                // decisions, state snapshots and reports travel with the source.
                if(Path.GetExtension(file) is ".json" or ".jsonl" or ".md")paths.Add(relative);
            }
        }
        var hashRows=new List<object>();
        var binaries=Directory.EnumerateFiles(AppContext.BaseDirectory,"*.dll").Select(file=>new{name=Path.GetFileName(file),sha256=Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(file))).ToLowerInvariant()}).ToArray();
        string binaryManifest=Path.Combine(reportDirectory,"binary-hashes.json");File.WriteAllText(binaryManifest,JsonSerializer.Serialize(binaries,new JsonSerializerOptions{WriteIndented=true}));paths.Add(Path.GetRelativePath(root,binaryManifest));
        foreach(string relative in paths.Where(p=>Path.GetExtension(p) is ".cs" or ".csproj"))
            hashRows.Add(new{path=relative.Replace('\\','/'),sha256=Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(Path.Combine(root,relative)))).ToLowerInvariant()});
        string manifest=Path.Combine(reportDirectory,"source-hashes.json");File.WriteAllText(manifest,JsonSerializer.Serialize(hashRows,new JsonSerializerOptions{WriteIndented=true}));paths.Add(Path.GetRelativePath(root,manifest));
        string target=Path.Combine(root,"release/ForgeConsoleIgnition.Source.zip");
        string temporary=target+".tmp";
        using(var file=File.Create(temporary))using(var archive=new ZipArchive(file,ZipArchiveMode.Create))
        foreach(string relative in paths)
        {
            // Console redirection may still hold a report log open while this command
            // packages it. Read with sharing; final packaging runs after reports close.
            using var input=new FileStream(Path.Combine(root,relative),FileMode.Open,FileAccess.Read,FileShare.ReadWrite);
            using var output=archive.CreateEntry(relative.Replace('\\','/'),CompressionLevel.Optimal).Open();input.CopyTo(output);
        }
        File.Move(temporary,target,true);
        File.WriteAllText(target+".sha256",Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(target))).ToLowerInvariant()+"  ForgeConsoleIgnition.Source.zip\n");
    }
}
