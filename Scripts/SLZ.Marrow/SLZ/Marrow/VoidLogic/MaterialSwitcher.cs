using System;
using System.Runtime.CompilerServices;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/MaterialSwitcher")]
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Material Switcher")]
	[Support(SupportFlags.Supported, null)]
    public sealed class MaterialSwitcher : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
    {
        [SerializeField]
        [HideInInspector]
        private bool _deprecated;

        [Obsolete("Dead Field: Please remove")]
        [Tooltip("Dead Field: Please remove")]
        [NonReorderable]
        [SerializeField]
        protected internal MonoBehaviour _previousNode;

        [SerializeField]
        [Tooltip("Previous node in the chain")]
        private OutputPortReference _previousConnection;

        private float _priorValue;

        [SerializeField]
        private Renderer[] _renderers;

        [SerializeField]
        private int[] _materialIndex;

        [SerializeField]
        private Material _offMat;

        [SerializeField]
        private Material _onMat;

        [SerializeField]
        private float lowThreshold;

        [SerializeField]
        private float highThreshold;

        private bool _isHigh;

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

        private void UpdateMats(Material mat)
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
