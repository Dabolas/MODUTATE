// Static C# generated from pinned Forge class files. GPL-3.0-or-later.
using System;
using Planeswalker.ForgeAot;
namespace Planeswalker.ForgeAot.Generated{internal static class C1196{
internal static JClass Build(){var c=new JClass("forge/util/storage/IStorage","java/lang/Object",new string[]{"java/lang/Iterable","forge/util/IHasName"},1537);Add0(c);return c;}
private static void Add0(JClass c){
c.Add(new JMethod(12427,"forge/util/storage/IStorage","getFullPath","()Ljava/lang/String;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(12428,"forge/util/storage/IStorage","get","(Ljava/lang/String;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(12429,"forge/util/storage/IStorage","find","(Ljava/util/function/Predicate;)Ljava/lang/Object;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(12430,"forge/util/storage/IStorage","getItemNames","()Ljava/util/Collection;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(12431,"forge/util/storage/IStorage","contains","(Ljava/lang/String;)Z",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(12432,"forge/util/storage/IStorage","size","()I",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(12433,"forge/util/storage/IStorage","add","(Ljava/lang/Object;)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(12434,"forge/util/storage/IStorage","add","(Ljava/lang/String;Ljava/lang/Object;)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(12435,"forge/util/storage/IStorage","delete","(Ljava/lang/String;)V",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(12436,"forge/util/storage/IStorage","getFolders","()Lforge/util/storage/IStorage;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(12437,"forge/util/storage/IStorage","tryGetFolder","(Ljava/lang/String;)Lforge/util/storage/IStorage;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(12438,"forge/util/storage/IStorage","getFolderOrCreate","(Ljava/lang/String;)Lforge/util/storage/IStorage;",1025,0,0,new JHandler[]{},null));
c.Add(new JMethod(12439,"forge/util/storage/IStorage","stream","()Ljava/util/stream/Stream;",1025,0,0,new JHandler[]{},null));
}
}}
