using System;
using System.Runtime.CompilerServices;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/ToneGenerator")]
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Tone Generator")]
	[Support(SupportFlags.AlphaSupported, "This is intended mainly for debugging, and as such its serialization compatibility is not guaranteed.")]
    public sealed class ToneGenerator : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
    {
        [SerializeField]
        [HideInInspector]
        private bool _deprecated;

        [Obsolete("Dead Field: Please remove")]
        [Tooltip("Dead Field: Please remove")]
        [SerializeField]
        [NonReorderable]
        protected internal MonoBehaviour[] _previous;

        [Tooltip("Previous node(s) in the chain")]
        [NonReorderable]
        [SerializeField]
        protected internal OutputPortReference[] _previousConnections;

        [Range(0f, 1f)]
        [SerializeField]
        private float _volume;

        [SerializeField]
        private AnimationCurve _curve;

        private float _frequency;

        private int _sampleRate;

        private float _phase;

        private bool _running;

        private static readonly PortMetadata _portMetadata;

        [field: ReadOnly(false)]
        [field: SerializeField]
        [field: NotUsedInEditMode]
        public VoidLogicSubgraph Subgraph { get; set; }

        public bool Deprecated => false;

        public float Volume
        {
            get
            {
                return 0f;
            }
            set
            {
            }
        }

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

        private void Start()
        {
        }

        void SLZ.Marrow.VoidLogic.IVoidLogicNode.Initialize(ref NodeState nodeState)
        {
        }

        void SLZ.Marrow.VoidLogic.IVoidLogicActuator.Actuate(ref NodeState nodeState)
        {
        }

        private void OnAudioFilterRead(float[] data, int channels)
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
