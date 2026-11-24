// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1126{
internal static JClass Build(){var c=new JClass("forge/util/IItemReader","java/lang/Object",new string[]{},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(11774,"forge/util/IItemReader","getFullPath","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11775,"forge/util/IItemReader","readAll","()Ljava/util/Map;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11776,"forge/util/IItemReader","getItemKey","(Ljava/lang/Object;)Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11777,"forge/util/IItemReader","getSubFolders","()Ljava/lang/Iterable;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(11778,"forge/util/IItemReader","getReaderForFolder","(Ljava/io/File;)Lforge/util/IItemReader;",1025,0,0,new JHandler[]{},null));
}
}}
