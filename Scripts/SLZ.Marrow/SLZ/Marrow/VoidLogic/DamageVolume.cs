using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Algorithms.Unity;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using SLZ.Marrow.PuppetMasta;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Bonelab/Sinks/VoidLogic Damage Volume")]
	[Support(SupportFlags.AlphaSupported, "This works, but should use Marrow primitives.")]
    public sealed class DamageVolume : MonoBehaviour, IVoidLogicSink, IVoidLogicNode
    {
        [HideInInspector]
        [SerializeField]
        private bool _deprecated;

        [Tooltip("Dead Field: Please remove")]
        [Obsolete("Dead Field: Please remove")]
        [SerializeField]
        [NonReorderable]
        protected internal MonoBehaviour _previousNode;

        [Tooltip("Previous node in the chain")]
        [SerializeField]
        private OutputPortReference _previousConnection;

        [SerializeField]
        [Header("Damage")]
        [Range(0.25f, 10f)]
        private float _tickFrequency;

        [SerializeField]
        [Tooltip("Base damage - This can get modified by Velocity or Distance")]
        private float _damage;

        [SerializeField]
        [Tooltip("Damage Type for modfying receiver behavior")]
        private AttackType _damageType;

        [SerializeField]
        [Tooltip("Determines attack origin location")]
        [Header("Source / Range")]
        private Transform _damageSourceTransform;

        [Tooltip("Setting 0 will make damage always be at an effective distance. NOTE: This should likely be greater than the trigger volume")]
        [SerializeField]
        private float _effectiveDistance;

        [SerializeField]
        private float _mapLow;

        [SerializeField]
        private float _mapHigh;

        [Tooltip("Damage modifier for Velocity")]
        [Header("Velocity Damage")]
        public bool staticVelocityDamage;

        public bool invertVelocity;

        [Tooltip("You may want a train or fast moving object to apply damage")]
        public Rigidbody associatedRb;

        public float velocityMinimum;

        public float velocityMaximum;

        [Header("Distance Settings")]
        public bool scaleDamageWithDistance;

        public float distanceMinimum;

        public float distanceMaximum;

        private Dictionary<GameObject, Rigidbody> _gameObjectToRigidbodyMap;

        private Dictionary<Rigidbody, int> _rigidbodyRefcounts;

        private Dictionary<GameObject, MuscleCollisionBroadcaster> _rootToTriggerRefProxy;

        private List<PlayerDamageReceiver> _playerDamageRecievers;

        private List<ObjectDestructible> _objectDamageRecievers;

        private float _damageScale;

        private float _lastTickTime;

        private List<Rigidbody> _rigidbodiesToRemove;

        private static readonly PortMetadata _portMetadata;

        [field: ReadOnly(false)]
        [field: NotUsedInEditMode]
        [field: SerializeField]
        public VoidLogicSubgraph Subgraph { get; set; }

        public bool Deprecated => false;

        private int _AffectedProxiesCount => 0;

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

        private void Update()
        {
        }

        private bool OnFirstRigidbodyAdded(Rigidbody rb)
        {
            return false;
        }

        private bool AddDamageReceiverInformation(Rigidbody rb)
        {
            return false;
        }

        private void OnLastRigidbodyRemoved(Rigidbody rb, int removedCount)
        {
        }

        private bool RemoveDamageReceiverInformation(Rigidbody rb)
        {
            return false;
        }

        private void OnDespawn(GameObject go)
        {
        }

        private void OnTriggerEnter(Collider other)
        {
        }

        private void OnTriggerExit(Collider other)
        {
        }

        public void ProcessDamage(Rigidbody rb, float mult)
        {
        }

        void SLZ.Marrow.VoidLogic.IVoidLogicNode.Initialize(ref NodeState nodeState)
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
