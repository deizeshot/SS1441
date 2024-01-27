using Content.Server.Administration.Logs;
using Content.Server.Body.Systems;
using Content.Server.Chat.Systems;
using Content.Server.Explosion.EntitySystems;
using Content.Server.NPC.Components;
using Content.Shared.Database;
using Content.Shared.Inventory;
using Content.Shared.Inventory.Events;
using Content.Shared.Sirena.HardsuitIdentification;
using Timer = Robust.Shared.Timing.Timer;

namespace Content.Server.Sirena.HardsuitIdentification;

public sealed class HardsuitIdentificationSystem : EntitySystem
{
    [Dependency] private readonly BodySystem _bodySystem = default!;
    [Dependency] private readonly ExplosionSystem _explosionSystem = default!;
    [Dependency] private readonly ChatSystem _chat = default!;
    [Dependency] private readonly InventorySystem _inventory = default!;
    [Dependency] private readonly IAdminLogManager _adminLogger = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<HardsuitIdentificationComponent, GotEquippedEvent>(OnEquip);
    }

    public void OnEquip(EntityUid uid, HardsuitIdentificationComponent component, GotEquippedEvent args)
    {
        if (component.Activated == true)
            return;

        var factionComp = EnsureComp<NpcFactionMemberComponent>(args.Equipee);
        foreach (var faction in new List<string>(factionComp.Factions))
        {
            if (faction == component.Faction)
                return;
        }

        component.Activated = true;
        _adminLogger.Add(LogType.Trigger, LogImpact.Medium,
            $"{ToPrettyString(args.Equipee):user} activated hardsuit self destruction system of {ToPrettyString(args.Equipment):target}");

        Timer.Spawn(500,
            () =>
            {
                _chat.TrySendInGameICMessage(args.Equipment, Loc.GetString("hardsuit-identification-error"), InGameICChatType.Speak, false);

                if (!EntityManager.EntityExists(args.Equipment))
                    return;

                _explosionSystem.QueueExplosion(Transform(args.Equipment).MapPosition, ExplosionSystem.DefaultExplosionPrototypeId,
                    4, 1, 2, maxTileBreak: 0);

                if (_inventory.TryGetSlotEntity(args.Equipee, "outerClothing", out var hardsuitEntity) && hardsuitEntity == args.Equipment)
                    _bodySystem.GibBody(args.Equipee);

                EntityManager.DeleteEntity(args.Equipment);
            });
    }
}
