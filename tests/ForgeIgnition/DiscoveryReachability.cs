using System.Security.Cryptography;
using System.Text.Json;
using System.Text.RegularExpressions;

public static class DiscoveryReachability
{
    public static void Write(string root,string directory)
    {
        // Conservative evidence inventory: generated calls and executed bindings
        // establish possible/live references. Absence is NOT an unreachable proof
        // because dispatch, reflection and callbacks are data-dependent.
        string[] families=["java/io/","java/net/","javax/crypto/","java/time/","java/security/"];
        var evidence=new List<object>();var call= new Regex("rt\\.(?:Call|InvokeSynchronous)\\(.*?\"(?<owner>(?:java/(?:io|net|time|security)|javax/crypto)/[^\"]+)\",\"(?<name>[^\"]+)\",\"(?<descriptor>[^\"]+)\"",RegexOptions.Compiled);
        foreach(string path in Directory.EnumerateFiles(Path.Combine(root,"migration/forge-aot/generated"),"*.cs"))
        {
            int line=0;foreach(string text in File.ReadLines(path)){line++;var match=call.Match(text);if(match.Success)evidence.Add(new{file=Path.GetRelativePath(root,path),line,signature=match.Groups["owner"].Value+"."+match.Groups["name"].Value+match.Groups["descriptor"].Value});}
        }
        string snapshotPath=Path.Combine(root,"external/forge/forge-game/src/main/java/forge/game/GameSnapshot.java");
        var omissions=File.ReadLines(snapshotPath).Select((text,index)=>new{line=index+1,text=text.Trim()}).Where(row=>row.text.Contains("TODO")||row.text.Contains("FIXME")).ToArray();
        File.WriteAllText(Path.Combine(directory,"reachability.json"),JsonSerializer.Serialize(new{snapshot=HeadlessSuite.Snapshot,
            families=families.Select(f=>new{family=f,status="unproven-not-dead",dead=false,reason="Package name and headless operation do not prove unreachability; dynamic dispatch/reflection prevent pruning on this evidence."}),
            sourceCallSites=evidence,deadFamilies=0,deletedBindings=0,
            rollbackAudit=new{file=Path.GetRelativePath(root,snapshotPath),sha256=Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(snapshotPath))),omissions,durableResumeSupported=false}
        },new JsonSerializerOptions{WriteIndented=true}));
    }
}
