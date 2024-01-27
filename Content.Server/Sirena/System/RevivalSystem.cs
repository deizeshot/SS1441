using Content.Server.Atmos.Rotting;
using Content.Server.EUI;
using Content.Server.Ghost;
using Content.Shared.Damage;
using Content.Shared.Mind;
using Content.Shared.Mobs;
using Content.Shared.Mobs.Components;
using Content.Shared.Mobs.Systems;

namespace Content.Server.Sirnea.EntitySystems;

public sealed partial class RevivalSystem : EntitySystem
{
    [Dependency] private readonly DamageableSystem _damageable = default!;
    [Dependency] private readonly MobStateSystem _mobState = default!;
    [Dependency] private readonly RottingSystem _rotting = default!;
    [Dependency] private readonly SharedMindSystem _mind = default!;
    [Dependency] private readonly EuiManager _euiManager = default!;
    [Dependency] private readonly EntityManager _manager = default!;
    public void Revival(EntityUid target, DamageSpecifier changeDamage, bool revivalRotten)
    {
        if (!_manager.HasComponent<MobStateComponent>(target))
            return;

        var comp = _manager.GetComponent<MobStateComponent>(target);
        if (_mobState.IsDead(target, comp))
        {
            if (!_rotting.IsRotten(target) || revivalRotten)
            {
                _damageable.TryChangeDamage(target, changeDamage, true);

                _mobState.ChangeMobState(target, MobState.Critical, comp);

                if (_mind.TryGetMind(target, out var _, out var mind) &&
                mind.Session is { } playerSession)
                {
                    var session = playerSession;
                    if (mind.CurrentEntity != target)
                        _euiManager.OpenEui(new ReturnToBodyEui(mind, _mind), session);
                }
            }
        }
    }
}
