using Planeswalker.Core;
using Planeswalker.ForgeAot;

public sealed partial class HeadlessMatch
{
    void ProjectPermanentDetails(JValue card,CardView row,bool hidden)
    {
        if(B(card,"hasCardAttachments"))
            row.attachments=Items(C(card,"getAttachedCards","()Lforge/game/card/CardCollectionView;"))
                .Select(attached=>C(attached,"getId","()I").Int).ToArray();
        if(hidden)return;

        var prepared=C(card,"getPreparedSpell","()Lforge/game/card/Card;");
        if(prepared.Reference!=null){
            row.preparedSpellId=C(prepared,"getId","()I").Int;
            row.preparedSpell=Name(prepared);
        }
        var originalType=C(card,"getOriginalType","()Lforge/card/CardTypeView;");
        row.printedType=OptionalText(C(originalType,"toString","()Ljava/lang/String;"));
        if(B(originalType,"isCreature"))
            row.printedStats=OptionalText(C(card,"getBasePowerString","()Ljava/lang/String;"))+"/"+
                OptionalText(C(card,"getBaseToughnessString","()Ljava/lang/String;"));
        if(B(card,"hasNamedCard"))row.namedCards=Items(C(card,"getNamedCards","()Ljava/util/List;")).Select(OptionalText).ToArray();
        if(B(card,"hasChosenColor"))row.chosenColors=Items(C(card,"getChosenColors","()Ljava/lang/Iterable;")).Select(OptionalText).ToArray();
        if(B(card,"hasChosenType")||B(card,"hasChosenType2")){
            // A secretly chosen creature type only enters the public view when revealed.
            var publicFace=C(card,"getView","()Lforge/game/card/CardView;");
            row.chosenType=OptionalText(C(publicFace,"getChosenType","()Ljava/lang/String;"));
            string secondType=OptionalText(C(publicFace,"getChosenType2","()Ljava/lang/String;"));
            if(secondType.Length>0)row.chosenType=string.IsNullOrEmpty(row.chosenType)?secondType:row.chosenType+" / "+secondType;
        }

        bool Changed(string getter)=>!B(C(card,getter,"()Lcom/google/common/collect/Table;"),"isEmpty");
        var descriptions=new List<string>();
        if(Changed("getChangedCardKeywords")||Changed("getChangedCardKeywordsByText")){
            foreach(var keyword in Items(C(card,"getKeywords","()Ljava/util/List;"))){
                if(B(keyword,"isIntrinsic"))continue;
                var title=OptionalText(C(keyword,"getTitle","()Ljava/lang/String;"));
                if(title.Length==0)title=OptionalText(C(keyword,"getOriginal","()Ljava/lang/String;"));
                if(title.Length>0)descriptions.Add(title);
            }
        }
        if(Changed("getChangedCardTraits")||Changed("getChangedCardTraitsByText")){
            foreach(string getter in TraitGetters){
                foreach(var trait in Items(C(card,getter,"()Lforge/util/collect/FCollectionView;"))){
                    if(B(trait,"isIntrinsic")||B(trait,"isSuppressed")||C(trait,"getKeyword","()Lforge/game/keyword/KeywordInterface;").Reference!=null)continue;
                    string description=OptionalText(C(trait,"toString","()Ljava/lang/String;"));
                    if(description.Length>0)descriptions.Add(description);
                }
            }
        }
        if(descriptions.Count>0)row.grantedAbilities=descriptions.Distinct().ToArray();
    }

    static readonly string[] TraitGetters={"getSpellAbilities","getTriggers","getReplacementEffects","getStaticAbilities"};
}
