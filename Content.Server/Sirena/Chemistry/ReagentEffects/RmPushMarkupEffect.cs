using Content.Server.Sirnea.Components;
using Content.Shared.Chemistry.Reagent;
using Robust.Shared.Prototypes;

namespace Content.Server.Sirena.Chemistry.ReagentEffects;

public sealed partial class RmPushMarkup : ReagentEffect
{
    public override void Effect(ReagentEffectArgs args)
    {
        args.EntityManager.RemoveComponent<PushMarkupEffectComponent>(args.SolutionEntity);
    }
    protected override string? ReagentEffectGuidebookText(IPrototypeManager prototype, IEntitySystemManager entSys)
        => Loc.GetString("reagent-effect-guidebook-create-rm-pushmarkup-effect");
}
