using System;
using System.Runtime.CompilerServices;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/RotatingJoint")]
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Rotating Joint")]
	[Support(SupportFlags.BetaSupported, "This works, but uses ConfigurableJoint instead of Marrow primitives.")]
    public sealed class RotatingJoint : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
    {
        [SerializeField]
        [HideInInspector]
        private bool _deprecated;

        [SerializeField]
        [NonReorderable]
        [Obsolete("Dead Field: Please remove")]
        [Tooltip("Dead Field: Please remove")]
        protected internal MonoBehaviour _previousNode;

        [Tooltip("Previous node in the chain")]
        [SerializeField]
        private OutputPortReference _previousConnection;

        private float? _priorValue;

        [SerializeField]
        private ConfigurableJoint _configurableJoint;

        private Rigidbody _rigidBody;

        [Header("Joint Control")]
        [SerializeField]
        private bool _varyTargetRotation;

        [SerializeField]
        private float _minDegreesX;

        [SerializeField]
        private float _maxDegreesX;

        [SerializeField]
        private bool _varyTargetAngVelocity;

        [SerializeField]
        private Vector3 _minAngVelocity;

        [SerializeField]
        private Vector3 _maxAngVelocity;

        [SerializeField]
        private bool _varyAngularDrive;

        [SerializeField]
        private Vector3 _xAngMinSpringDamperForce;

        [SerializeField]
        private Vector3 _xAngMaxSpringDamperForce;

        private static readonly PortMetadata _portMetadata;

        [field: ReadOnly(false)]
        [field: NotUsedInEditMode]
        [field: SerializeField]
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

        private void SETJOINT(float voltage = 1f)
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
