using System;
using System.Runtime.CompilerServices;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Legacy Sound Player")]
	[Support(SupportFlags.Deprecated, "It's unclear how exactly we want to properly support playing sound. This could break at any time.")]
    public sealed class LegacySoundPlayer : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
    {
        [SerializeField]
        [HideInInspector]
        private bool _deprecated;

        [NonReorderable]
        [SerializeField]
        [Obsolete("Dead Field: Please remove")]
        [Tooltip("Dead Field: Please remove")]
        protected internal MonoBehaviour _previousNode;

        [Tooltip("Previous node in the chain")]
        [SerializeField]
        private OutputPortReference _previousConnection;

        [SerializeField]
        private AnimationCurve _curve;

        private float _priorValue;

        protected bool _wasOn;

        [Header("Audio")]
        [SerializeField]
        private AudioClip _onSound;

        [SerializeField]
        private AudioClip _offSound;

        private static readonly PortMetadata _portMetadata;

        [field: SerializeField]
        [field: NotUsedInEditMode]
        [field: ReadOnly(false)]
        public VoidLogicSubgraph Subgraph { get; set; }

        public bool Deprecated => false;

        public int InputCount => 0;

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

        void SLZ.Marrow.VoidLogic.IVoidLogicActuator.Actuate(ref NodeState nodeState)
        {
        }

        public bool TryGetInputConnection(uint inputIndex, out OutputPortReference connectedPort)
        {
            connectedPort = default(OutputPortReference);
            return false;
        }

        public bool TryConnectPortToInput(OutputPortReference output, uint inputIndex)
        {
            return false;
        }
    }
}
