using Content.Server.Sirnea.Components;
using Content.Shared.Chemistry.Reagent;
using Robust.Shared.Prototypes;

namespace Content.Server.Sirena.Chemistry.ReagentEffects;

public sealed partial class AddPushMarkup : ReagentEffect
{
    [DataField(required: true)]
    public string[] Text;

    public override void Effect(ReagentEffectArgs args)
    {
        var entityManager = args.EntityManager;

        var comp = entityManager.EnsureComponent<PushMarkupEffectComponent>(args.SolutionEntity);
        comp.OnExamined = Text;
    }
    protected override string? ReagentEffectGuidebookText(IPrototypeManager prototype, IEntitySystemManager entSys)
        => Loc.GetString("reagent-effect-guidebook-create-add-pushmarkup-effect");
}
