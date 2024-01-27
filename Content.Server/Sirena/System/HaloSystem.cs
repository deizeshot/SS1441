using Content.Server.Sirnea.Components;
using Content.Shared.Examine;

namespace Content.Server.Sirnea.EntitySystems;

/// <summary>
/// Description when examining a person with a halo
/// </summary>
public sealed class HaloSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<HaloComponent, ExaminedEvent>(OnHaloExamined);
    }

    private void OnHaloExamined(EntityUid uid, HaloComponent comp, ExaminedEvent args)
    {
        if (!args.IsInDetailsRange)
            return;

        if (comp.OnExamined == string.Empty)
            return;

        args.PushMarkup(Loc.GetString(comp.OnExamined));
    }
}
