using System.Numerics;
using Content.Shared.Shuttles.Components;
using Content.Shared.DeviceLinking;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.Shuttles.Components
{
    [RegisterComponent]
    public sealed partial class ShuttleConsoleComponent : SharedShuttleConsoleComponent
    {
        [ViewVariables]
        public readonly List<EntityUid> SubscribedPilots = new();

        /// <summary>
        /// How much should the pilot's eye be zoomed by when piloting using this console?
        /// </summary>
        [DataField("zoom")]
        public Vector2 Zoom = new(1.5f, 1.5f);

        /// <summary>
        /// Should this console have access to restricted FTL destinations?
        /// </summary>
        [ViewVariables(VVAccess.ReadWrite), DataField("whitelistSpecific")]
        public List<EntityUid> FTLWhitelist = new List<EntityUid>();

        [DataField(customTypeSerializer: typeof(PrototypeIdSerializer<SourcePortPrototype>))]
        public string LinkingPort = "ShuttleConsoleSender";
    }
}
