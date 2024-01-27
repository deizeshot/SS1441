namespace Content.Shared.Sirena.Components;

public abstract partial class SharedHaloComponent : Component
{
    [DataField("path")]
    public string TexturePath = "Sirena/Objects/Misc/halo.rsi";

    [DataField("state")]
    public string TextureState = "halo";

    [DataField("desc")]
    public string OnExamined = "halo-component-on-examine-detailed-message";
}
