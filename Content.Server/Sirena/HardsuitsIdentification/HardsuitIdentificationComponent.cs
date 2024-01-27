using Robust.Shared.Prototypes;
using Content.Server.NPC.Components;

namespace Content.Shared.Sirena.HardsuitIdentification;

[RegisterComponent]
public sealed partial class HardsuitIdentificationComponent : Component
{
    [DataField(required: true)]
    public ProtoId<NpcFactionPrototype> Faction = default!;

    public bool Activated = false;
}
