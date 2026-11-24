using System.Text.Json;
using Planeswalker.ForgeAot;

namespace Planeswalker.ForgeConsole;

public static class LinkageAudit
{
    public static object Inspect(string generatedGapFile,JRuntime runtime)
    {
        using var doc=JsonDocument.Parse(File.ReadAllBytes(generatedGapFile));
        var bindings=runtime.BindingNames.ToHashSet(StringComparer.Ordinal);
        var rows=doc.RootElement.GetProperty("methods").EnumerateArray().Select(method=>
        {
            string owner=method.GetProperty("owner").GetString()!,name=method.GetProperty("name").GetString()!,descriptor=method.GetProperty("descriptor").GetString()!;
            string key=owner+"."+name+descriptor;
            bool direct=bindings.Contains(key)||owner.StartsWith('[')&&name=="clone"&&descriptor=="()Ljava/lang/Object;"&&bindings.Contains("java/lang/Object.clone()Ljava/lang/Object;");
            return new{owner,name,descriptor,key,directBinding=direct,isJavaLibrary=owner.StartsWith("java/")||owner.StartsWith("javax/")||owner.StartsWith("jdk/")};
        }).ToArray();
        return new{generatedExternalReferences=rows.Length,javaReferences=rows.Count(r=>r.isJavaLibrary),javaDirectBindings=rows.Count(r=>r.isJavaLibrary&&r.directBinding),javaWithoutDirectBinding=rows.Count(r=>r.isJavaLibrary&&!r.directBinding),remainingJava=rows.Where(r=>r.isJavaLibrary&&!r.directBinding).ToArray(),remainingThirdParty=rows.Where(r=>!r.isJavaLibrary&&!r.directBinding).ToArray(),scope="Direct call-site inventory plus array clone only. Inherited dispatch and transitive dependencies need additional linking; this is not a complete closure certificate.",fullClosureComplete=false};
    }
}
