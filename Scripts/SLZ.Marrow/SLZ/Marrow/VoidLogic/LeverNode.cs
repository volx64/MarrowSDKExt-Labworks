using SLZ.Marrow;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Marrow.VoidLogic
{
    [Support(SupportFlags.BetaSupported, "This works, but should use Marrow primitives.")]
	[AddComponentMenu("VoidLogic/Bonelab/Nodes/VoidLogic Lever")]
    public sealed class LeverNode : BaseNode, IVoidLogicActuator, IVoidLogicNode, IVoidLogicSensor
    {
        [Tooltip("Output response curve (multiplied by input)")]
        [SerializeField]
        private AnimationCurve _curve;

        [SerializeField]
        [Tooltip("Lever Types:\n0 => Free\n1 => Momentary\n2+ => Stepped")]
        [Min(0f)]
        private int _steps;

        [SerializeField]
        [Tooltip("Lever joint that drives the output power value")]
        private Rigidbody _leverRigidBody;

        [SerializeField]
        [FormerlySerializedAs("servo")]
        private Servo _servo;

        [Tooltip("Interactable host i.e. for running haptics")]
        [SerializeField]
        private InteractableHost _interactableHost;

        [SerializeField]
        [Header("Force")]
        private float force_Spring;

        [SerializeField]
        private float force_Damper;

        [SerializeField]
        private float force_Max;

        [Tooltip("Only measures value and do not dive joint")]
        [SerializeField]
        private bool justMeasure;

        [SerializeField]
        [Header("Audio")]
        private AudioClip clip_clickOn;

        [SerializeField]
        private AudioClip clip_clickOff;

        private bool _canHaptic;

        private bool _leverThresholdHit;

        private bool _performedInitialRead;

        private static readonly PortMetadata _portMetadata;

        public ConfigurableJoint LeverConfigurableJoint => null;

        public Servo Servo
        {
            get
            {
                return null;
            }
            private set
            {
            }
        }

        public InteractableHost InteractableHost
        {
            get
            {
                return null;
            }
            private set
            {
            }
        }

        public int Steps
        {
            get
            {
                return 0;
            }
            set
            {
            }
        }

        public float ForceSpring
        {
            get
            {
                return 0f;
            }
            set
            {
            }
        }

        public float ForceDamper
        {
            get
            {
                return 0f;
            }
            set
            {
            }
        }

        public float ForceMax
        {
            get
            {
                return 0f;
            }
            set
            {
            }
        }

        public override PortMetadata PortMetadata => default(PortMetadata);

        private void Reset()
        {
        }

        private void Start()
        {
        }

        public override void Initialize(ref NodeState nodeState)
        {
        }

        void SLZ.Marrow.VoidLogic.IVoidLogicSensor.ReadSensors(ref NodeState nodeState)
        {
        }

        public override void Calculate(ref NodeState nodeState)
        {
        }

        void SLZ.Marrow.VoidLogic.IVoidLogicActuator.Actuate(ref NodeState nodeState)
        {
        }
    }
}
