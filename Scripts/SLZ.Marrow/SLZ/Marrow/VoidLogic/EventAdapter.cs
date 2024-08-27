using System;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UltEvents;
using UnityEngine;


namespace SLZ.Marrow.VoidLogic
{
	[Support(SupportFlags.Supported, "<b>Reminder</b>: Is there a better way to do this?")]
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Event Adapter")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/EventAdapter")]
    public sealed class EventAdapter : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
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

        [SerializeField]
        private float lowThreshold;

        [SerializeField]
        private float highThreshold;

        [Header("Events")]
        [Tooltip("When the input value changes (EXPENSIVE, runs all callbacks on every value update)")]
        public UltEvent<EventAdapter, IVoidLogicSource, float> InputUpdated;

        [Tooltip("When the input value rises above the high threshold")]
        public UltEvent<EventAdapter, IVoidLogicSource, float> InputRose;

        [Tooltip("When the input value holds above the high threshold")]
        public UltEvent<EventAdapter, IVoidLogicSource, float> InputHeld;

        [Tooltip("When the input value lowers beneath the low threshold")]
        public UltEvent<EventAdapter, IVoidLogicSource, float> InputFell;

        [Tooltip("When the input value rises above the high threshold (for the first time only)")]
        public UltEvent<EventAdapter, IVoidLogicSource, float> InputRoseOneShot;

        private float _priorValue;

        private bool _isHigh;

        private bool _hasBeenHigh;

        private static readonly PortMetadata _portMetadata;

        [field: NotUsedInEditMode]
        [field: SerializeField]
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

        private void _invokeInputUpdated(IVoidLogicSource source, float f)
        {
        }

        private void _invokeInputRose(IVoidLogicSource source, float f)
        {
        }

        private void _invokeInputRoseOneShot(IVoidLogicSource source, float f)
        {
        }

        private void _invokeInputFell(IVoidLogicSource source, float f)
        {
        }

        private void _invokeInputHeld(IVoidLogicSource source, float f)
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
