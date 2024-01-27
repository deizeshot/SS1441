using Content.Server.DetailExaminable;
using Content.Shared.Chemistry.Reagent;
using Content.Shared.Sirena;
using Robust.Shared.Prototypes;

namespace Content.Server.Sirena.Chemistry.ReagentEffectsCondition;

public sealed partial class ERPStatusCondition : ReagentEffectCondition
{
    [DataField("erp")]
    public EnumERPStatus ERP = default!;

    [DataField]
    public bool ShouldHave = true;

    public override bool Condition(ReagentEffectArgs args)
    {
        if (!args.EntityManager.HasComponent<DetailExaminableComponent>(args.SolutionEntity))
        {
            return ERP == 0 ? ShouldHave : false;
        }

        return args.EntityManager.GetComponent<DetailExaminableComponent>(args.SolutionEntity).ERPStatus == ERP ? ShouldHave : !ShouldHave;
    }

    public override string GuidebookExplanation(IPrototypeManager prototype)
    {
        return Loc.GetString("reagent-effect-condition-guidebook-erpstatus", ("erp", ERP), ("shouldHave", ShouldHave));
    }
}
