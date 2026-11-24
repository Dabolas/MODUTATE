using Planeswalker.ForgeAot;
using Planeswalker.ForgeConsole;

public sealed partial class L3Game
{
    private sealed record CatalogueFace(CardDefinition Definition,string Name,string Types);

    private void InstallFaceStream(JValue data,JValue catalogue,JValue variantCatalogue)
    {
        const string proxy="l3/CatalogueFace";
        if(!Rt.Program.Classes.ContainsKey(proxy))
            Rt.Program.Add(new(proxy,"java/lang/Object",["forge/card/ICardFace"],1));
        // The logical catalogue spans every pinned shard. CardDb's
        // original random selection operates on these faces without a Java file reader.
        Rt.PutField(data,"forge/StaticData","allCardsLoaded","Z",JValue.I(1));
        InstallRulesLookup(catalogue,variantCatalogue);
        var types=new Dictionary<string,JValue>(StringComparer.Ordinal);
        JValue TypeOf(string line)
        {
            if(!types.TryGetValue(line,out var value))
                types[line]=value=Static("forge/card/CardType","parse","(Ljava/lang/String;Z)Lforge/card/CardType;",S(line),JValue.I(0));
            return value;
        }
        JValue RealFace(CatalogueFace face)
        {
            var rules=Call(Paper(face.Definition.Name),"getRules","()Lforge/card/CardRules;");
            return Rt.ListItems(Call(rules,"getAllFaces","()Ljava/util/List;")).Single(f=>
                f.Reference!=null&&Rt.StringValue(Call(f,"getName","()Ljava/lang/String;"))==face.Name);
        }
        foreach(string contract in new[]{"forge/card/ICardFace","forge/card/ICardCharacteristics","forge/card/ICardRawAbilites","forge/util/IHasName","java/lang/Comparable"})
        {
            if(!Rt.Program.Classes.TryGetValue(contract,out var metadata))continue;
            foreach(var method in metadata.Methods.Values.Where(m=>(m.Access&8)==0))
                Rt.Bind(proxy,method.Name,method.Descriptor,(r,self,args)=>{
                    var face=r.HostPayload<CatalogueFace>(self);
                    return JHostResult.Complete(method.Name switch {
                        "getName"=>S(face.Name),
                        "getType"=>TypeOf(face.Types),
                        _=>Call(RealFace(face),method.Name,method.Descriptor,args)
                    });
                });
        }
        var streams=new Dictionary<bool,JValue>();
        Rt.Bind("forge/card/CardDb","streamAllFaces","()Ljava/util/stream/Stream;",(r,self,args)=>{
            bool wantVariant=ReferenceEquals(self.Reference,variantCatalogue.Reference);
            if(!wantVariant&&!ReferenceEquals(self.Reference,catalogue.Reference))throw new HostDecisionGap("Unknown card catalogue");
            if(!streams.TryGetValue(wantVariant,out var all))
            {
                var faces=new SortedDictionary<string,JValue>(StringComparer.OrdinalIgnoreCase);
                var variants=new Dictionary<string,bool>(StringComparer.Ordinal);
                foreach(var definition in database.Cards)
                {
                    string typeLine=definition.Value("Types");
                    if(!variants.TryGetValue(typeLine,out bool variant))
                    {
                        var primary=TypeOf(typeLine);
                        variants[typeLine]=variant=new[]{"isVanguard","isScheme","isPlane","isPhenomenon","isConspiracy","isDungeon","isAttraction","isContraption","isStickers"}.Any(test=>Call(primary,test,"()Z").Int!=0);
                    }
                    if(variant!=wantVariant)continue;
                    if(definition.Fields.Any(f=>f.Key is "Variant" or "FlavorName" or "CopyFaceFrom"))
                    {
                        var rules=Call(Paper(definition.Name),"getRules","()Lforge/card/CardRules;");
                        foreach(var face in r.ListItems(Call(rules,"getAllFaces","()Ljava/util/List;")).Where(f=>f.Reference!=null))
                        {
                            faces[r.StringValue(Call(face,"getName","()Ljava/lang/String;"))]=face;
                            void AddAlias(JValue named)
                            {
                                var alias=Call(named,"getFlavorName","()Ljava/lang/String;");
                                if(alias.Reference!=null)faces.TryAdd(r.StringValue(alias),named);
                            }
                            AddAlias(face);
                            if(Call(face,"hasFunctionalVariants","()Z").Int!=0)
                                foreach(var entry in r.MapItems(Call(face,"getFunctionalVariants","()Ljava/util/Map;")))AddAlias(entry.Value);
                        }
                        continue;
                    }
                    string? name=null;
                    foreach(var field in definition.Fields)
                    {
                        if(field.Key=="Name")name=field.Value;
                        if(field.Key=="Types"&&name!=null)faces[name]=JValue.R(r.HostObject(proxy,new CatalogueFace(definition,name,field.Value)));
                    }
                }
                streams[wantVariant]=all=r.ListOf(faces.Values.ToArray());
            }
            return JHostResult.Complete(Call(all,"stream","()Ljava/util/stream/Stream;"));
        });
    }

    private void InstallRulesLookup(JValue common,JValue variants)
    {
        // The console loads definitions from verified shards and has no Java
        // CardReader or printing index. Keep CardDb's unsupported-name fallback.
        Rt.Bind("forge/card/CardDb","getRules","(Ljava/lang/String;Z)Lforge/card/CardRules;",(r,self,args)=>{
            bool variant=ReferenceEquals(self.Reference,variants.Reference);
            if(!variant&&!ReferenceEquals(self.Reference,common.Reference))throw new HostDecisionGap("Unknown rules catalogue");
            string query=r.StringValue(args[0]);
            JValue Find(bool alternate)
            {
                foreach(string name in database.FindRuleNames(query,alternate))
                {
                    var rules=Call(Paper(name),"getRules","()Lforge/card/CardRules;");
                    if((Call(rules,"isVariant","()Z").Int!=0)==variant)return rules;
                }
                return default;
            }
            var result=Find(false);
            if(result.Reference==null&&args[1].Int!=0)result=Find(true);
            return JHostResult.Complete(result);
        });
    }
}
