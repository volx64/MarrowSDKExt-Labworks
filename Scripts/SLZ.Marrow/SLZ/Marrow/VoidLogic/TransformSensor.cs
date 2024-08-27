using SLZ.Marrow.Utilities;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[Support(SupportFlags.BetaSupported, null)]
	[AddComponentMenu("VoidLogic/Bonelab/VoidLogic Transform Sensor")]
    public sealed class TransformSensor : MonoBehaviour, IVoidLogicSource, IVoidLogicNode, IVoidLogicSensor
    {
        [HideInInspector]
        [SerializeField]
        private bool _deprecated;

        [SerializeField]
        private Transform _anchor;

        [SerializeField]
        private Transform _connectedTransform;

        [SerializeField]
        private bool _negate;

        private static readonly PortMetadata _portMetadata;

        [field: ReadOnly(false)]
        [field: NotUsedInEditMode]
        [field: SerializeField]
        public VoidLogicSubgraph Subgraph { get; set; }

        public bool Deprecated => false;

        public int OutputCount => 0;

        public PortMetadata PortMetadata => default(PortMetadata);

        private void Awake()
        {
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void OnDestroy()
        {
        }

        void SLZ.Marrow.VoidLogic.IVoidLogicNode.Initialize(ref NodeState nodeState)
        {
        }

        void SLZ.Marrow.VoidLogic.IVoidLogicSensor.ReadSensors(ref NodeState nodeState)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private float _wrap(float angleDegrees)
        {
            return 0f;
        }

        void SLZ.Marrow.VoidLogic.IVoidLogicSource.Calculate(ref NodeState nodeState)
        {
        }
    }
}
