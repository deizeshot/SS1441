using Content.Server.Sirnea.Components;
using Content.Shared.Examine;

namespace Content.Server.Sirnea.EntitySystems;

/// <summary>
///     This system is used for AddPushMarkupEffect and RmPushMarkupEffect for add and rm markup
/// </summary>
public sealed class PushMarkupEffectSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<PushMarkupEffectComponent, ExaminedEvent>(OnExamined);
    }

    private void OnExamined(EntityUid uid, PushMarkupEffectComponent component, ExaminedEvent args)
    {
        if (!args.IsInDetailsRange)
            return;

        foreach (var text in new List<string>(component.OnExamined))
        {
            args.PushMarkup(Loc.GetString(text));
        }
    }
}
