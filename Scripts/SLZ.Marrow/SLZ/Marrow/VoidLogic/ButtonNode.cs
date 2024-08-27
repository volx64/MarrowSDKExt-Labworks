// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.
// SLZ.Marrow, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// SLZ.Marrow.VoidLogic.ButtonNode
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
    [AddComponentMenu("VoidLogic/VoidLogic Button")]
    [Support(SupportFlags.Supported, null)]
    public class ButtonNode : BaseNode, IVoidLogicSensor, IVoidLogicNode, IVoidLogicActuator
    {
        [SerializeField]
        protected float _lowThreshold;

        [SerializeField]
        protected float _highThreshold;

        [SerializeField]
        protected ConfigurableJoint _joint;

        [SerializeField]
        protected Transform _endTransform;

        [Header("Audio")]
        [SerializeField]
        [Tooltip("Clip(s) to be played on button press")]
        protected AudioClip[] _pressClips;

        [SerializeField]
        [Tooltip("Clip(s) to be played on button unpress")]
        protected AudioClip[] _depressClips;

        [SerializeField]
        [Tooltip("Colliders that the button shaft collider will ignore")]
        protected Collider[] _ignoreColliders;

        [SerializeField]
        protected Collider _buttonShaftCollider;

        protected Rigidbody _rigidBody;

        private Vector3 _initialDisplacement;

        protected bool _isPressed;

        private bool _performedInitialRead;

        private static readonly PortMetadata _portMetadata;

        public override PortMetadata PortMetadata => default(PortMetadata);

        protected override void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        void IVoidLogicSensor.ReadSensors(ref NodeState nodeState)
        {
        }

        public override void Initialize(ref NodeState nodeState)
        {
        }

        public override void Calculate(ref NodeState nodeState)
        {
        }

        void IVoidLogicActuator.Actuate(ref NodeState nodeState)
        {
        }
    }
}