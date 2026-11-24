using System.Collections.Generic;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private void InstallTeamDayNightAdapter()
        {
            const string owner="forge/game/phase/Untap",descriptor="(Lforge/game/player/Player;)V";
            var original=Resolve(owner,"doDayTime",descriptor);
            if(original?.Body==null)return;
            Bind(owner,"doDayTime",descriptor,(runtime,receiver,args)=>{
                JHostResult Original()=>JHostResult.Schedule(new JFrame(original,receiver,args));
                var previous=args[0];
                if(previous.Reference==null)return Original();
                JValue Call(JValue obj,string method,string signature,params JValue[] values)=>
                    runtime.InlineCall(obj.Reference!.ClassName,method,signature,obj,values);
                var game=Call(previous,"getGame","()Lforge/game/Game;");
                if(Call(game,"isNight","()Z").Int==0)return Original();
                var rules=Call(game,"getRules","()Lforge/game/GameRules;");
                if(Call(rules,"hasSharedTeamTurns","()Z").Int==0)return Original();
                var stack=Call(game,"getStack","()Lforge/game/zone/MagicStack;");
                var casters=new HashSet<JObject>();
                // CR 502.2a counts each teammate separately. Delegate the change
                // itself (including prohibitions and triggers) to Forge.
                foreach(var spell in runtime.ListItems(Call(stack,"getSpellsCastLastTurn","()Ljava/util/List;"))){
                    var caster=Call(spell,"getController","()Lforge/game/player/Player;");
                    if(Call(previous,"sharesTeamWith","(Lforge/game/player/Player;)Z",caster).Int!=0&&!casters.Add(caster.Reference!))
                        return Original();
                }
                return Done();
            });
        }
    }
}
