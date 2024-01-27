using Content.Shared.Chemistry.Reagent;
using Content.Shared.Humanoid;
using Robust.Shared.Prototypes;

namespace Content.Server.Sirena.Chemistry.ReagentEffectsCondition;

public sealed partial class SexCondition : ReagentEffectCondition
{
    [DataField]
    public Sex Sex = default!;

    [DataField]
    public bool ShouldHave = true;

    public override bool Condition(ReagentEffectArgs args)
    {
        return args.EntityManager.GetComponent<HumanoidAppearanceComponent>(args.SolutionEntity).Sex == Sex
            ? ShouldHave
            : !ShouldHave;
    }

    public override string GuidebookExplanation(IPrototypeManager prototype)
    {
        return Loc.GetString("reagent-effect-condition-guidebook-sex", ("sex", Sex), ("shouldHave", ShouldHave));
    }
}
