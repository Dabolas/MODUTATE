using System;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        // The pinned common-requirements body handles CheckSVar and CheckSecondSVar.
        // Some pinned abilities declare third and fourth comparisons as well.
        public void InstallExtendedTraitRequirements()
        {
            const string owner="forge/game/CardTraitBase", name="meetsCommonRequirements", descriptor="(Ljava/util/Map;)Z";
            var original=Program.Classes[owner].Methods[name+descriptor];
            var extended=new JMethod(original.Id,owner,name,descriptor,original.Access,original.MaxLocals,original.MaxStack,original.Handlers,(r,frame)=>{
                var step=original.Body!(r,frame);
                if(step.Kind!=JStepKind.Return||step.Value.Int==0)return step;
                var trait=frame.Locals[0];
                var parameters=frame.Locals[1];
                JValue Get(string key)=>r.InlineCall("java/util/Map","get","(Ljava/lang/Object;)Ljava/lang/Object;",parameters,new[]{JValue.R(r.String(key))},"invokeinterface");
                var source=r.InlineCall(owner,"getHostCard","()Lforge/game/card/Card;",trait,Array.Empty<JValue>());
                int Amount(JValue expr)=>r.InlineCall("forge/game/ability/AbilityUtils","calculateAmount","(Lforge/game/card/Card;Ljava/lang/String;Lforge/game/CardTraitBase;)I",default,new[]{source,expr,trait},"invokestatic").Int;
                foreach(string position in new[]{"Third","Fourth"}){
                    var variable=Get("Check"+position+"SVar");
                    if(variable.Reference==null)continue;
                    var comparison=Get(position+"SVarCompare");
                    string text=comparison.Reference==null?"GE1":r.StringValue(comparison);
                    var arguments=new[]{JValue.I(Amount(variable)),JValue.R(r.String(text.Substring(0,2))),JValue.I(Amount(JValue.R(r.String(text.Substring(2)))))};
                    if(r.InlineCall("forge/util/Expressions","compare","(ILjava/lang/String;I)Z",default,arguments,"invokestatic").Int==0)return JStep.Return(JValue.I(0));
                }
                return step;
            });
            Bind(owner,name,descriptor,(r,trait,args)=>{
                // Plain parameter maps take the original path without making a copy.
                if(args[0].Reference?.Payload is JavaMap map){
                    foreach(var item in map.Entries){
                        if(item.Key.Reference?.Text is "CheckThirdSVar" or "CheckFourthSVar")
                            return JHostResult.Schedule(new JFrame(extended,trait,args));
                    }
                    return JHostResult.Schedule(new JFrame(original,trait,args));
                }
                return JHostResult.Schedule(new JFrame(extended,trait,args));
            });
        }
    }
}
