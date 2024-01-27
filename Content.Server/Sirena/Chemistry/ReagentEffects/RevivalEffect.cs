using Content.Server.Sirnea.EntitySystems;
using Content.Shared.Chemistry.Reagent;
using Content.Shared.Damage;
using Robust.Shared.Prototypes;

namespace Content.Server.Sirena.Chemistry.ReagentEffects;

public sealed partial class Revival : ReagentEffect
{
    [DataField]
    public DamageSpecifier ChangeDamage = default!;

    [DataField]
    public bool RevivalRotten = true;
    public override void Effect(ReagentEffectArgs args)
    {
        var system = args.EntityManager.EntitySysManager.GetEntitySystem<RevivalSystem>();
        system.Revival(args.SolutionEntity, ChangeDamage, RevivalRotten);
    }
    protected override string? ReagentEffectGuidebookText(IPrototypeManager prototype, IEntitySystemManager entSys)
        => Loc.GetString("reagent-effect-guidebook-revival-effect");
}
