using Content.Shared.Sound;
using Robust.Shared.GameStates;

namespace Content.Shared.Standing
{
    [Friend(typeof(StandingStateSystem))]
    [RegisterComponent, NetworkedComponent]
    public sealed class StandingStateComponent : Component
    {
        [ViewVariables(VVAccess.ReadWrite)]
        [DataField("downSound")]
        public SoundSpecifier DownSound { get; } = new SoundCollectionSpecifier("BodyFall");

        [DataField("standing")]
        public bool Standing { get; set; } = true;

        /// <summary>
        ///     List of fixtures that had their collision mask changed when the entity was downed.
        ///     Required for re-adding the collision mask.
        /// </summary>
        [DataField("changedFixtures")]
        public List<string> ChangedFixtures = new();
    }
}
