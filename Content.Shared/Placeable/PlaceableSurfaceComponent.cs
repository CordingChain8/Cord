using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Placeable
{
    [RegisterComponent, NetworkedComponent]
    [Friend(typeof(PlaceableSurfaceSystem))]
    public sealed class PlaceableSurfaceComponent : Component
    {
        [ViewVariables]
        [DataField("isPlaceable")]
        public bool IsPlaceable { get; set; } = true;

        [ViewVariables]
        [DataField("placeCentered")]
        public bool PlaceCentered { get; set; }

        [ViewVariables]
        [DataField("positionOffset")]
        public Vector2 PositionOffset { get; set; }
    }

    [Serializable, NetSerializable]
    public sealed class PlaceableSurfaceComponentState : ComponentState
    {
        public readonly bool IsPlaceable;
        public readonly bool PlaceCentered;
        public readonly Vector2 PositionOffset;

        public PlaceableSurfaceComponentState(bool placeable, bool centered, Vector2 offset)
        {
            IsPlaceable = placeable;
            PlaceCentered = centered;
            PositionOffset = offset;
        }
    }
}
