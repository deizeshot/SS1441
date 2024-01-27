using Content.Client.Sirnea.Components;
using Robust.Client.GameObjects;
using Robust.Shared.Utility;
using System.Numerics;

namespace Content.Client.Sirnea.Systems;

public sealed class HaloSystem : EntitySystem
{
    public override void Initialize()
    {
        SubscribeLocalEvent<HaloComponent, ComponentStartup>(HaloAdded);
        SubscribeLocalEvent<HaloComponent, ComponentShutdown>(HaloRemoved);
    }

    private void HaloRemoved(EntityUid uid, HaloComponent comp, ComponentShutdown args)
    {
        if (!TryComp<SpriteComponent>(uid, out var sprite))
            return;

        if (!sprite.LayerMapTryGet(HaloKey.Key, out var layer))
            return;

        sprite.RemoveLayer(layer);
    }

    private void HaloAdded(EntityUid uid, HaloComponent comp, ComponentStartup args)
    {
        if (!TryComp<SpriteComponent>(uid, out var sprite))
            return;

        if (sprite.LayerMapTryGet(HaloKey.Key, out var _))
            return;

        if (comp.TexturePath == string.Empty)
            return;

        var adj = sprite.Bounds.Height / 2 + 1.0f / 32 * 4.5f;

        var layer = sprite.AddLayer(new SpriteSpecifier.Rsi(new ResPath(comp.TexturePath), comp.TextureState));
        sprite.LayerMapSet(HaloKey.Key, layer);

        sprite.LayerSetOffset(layer, new Vector2(0.0f, adj));
        sprite.LayerSetShader(layer, "unshaded");
    }

    private enum HaloKey
    {
        Key,
    }
}
