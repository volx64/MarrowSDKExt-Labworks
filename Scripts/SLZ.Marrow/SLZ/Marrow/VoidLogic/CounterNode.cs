// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.
// SLZ.Marrow, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// SLZ.Marrow.VoidLogic.CounterNode
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
    [AddComponentMenu("VoidLogic/VoidLogic Counter")]
    [Support(SupportFlags.BetaSupported, "Should be stable, but needs more usage for full confidence")]
    public sealed class CounterNode : BaseNode
    {
        private static readonly PortMetadata _portMetadata;

        [field: SerializeField]
        [field: Tooltip("Counter initial value")]
        public int Value { get; set; }

        [field: Tooltip("Minimum allowable value")]
        [field: SerializeField]
        public int Min { get; set; }

        [field: Tooltip("Maximum allowable value")]
        [field: SerializeField]
        public int Max { get; set; }

        [field: Tooltip("Edge detection configuration for decrement input")]
        [field: SerializeField]
        private EdgeDetector DecrementEdgeDetector { get; set; }

        [field: Tooltip("Edge detection configuration for increment input")]
        [field: SerializeField]
        private EdgeDetector IncrementEdgeDetector { get; set; }

        [field: Tooltip("Edge detection configuration for reset input")]
        [field: SerializeField]
        private EdgeDetector ResetEdgeDetector { get; set; }

        public override PortMetadata PortMetadata => default;

        public override void Initialize(ref NodeState nodeState)
        {
        }

        public override void Calculate(ref NodeState nodeState)
        {
        }
    }
}