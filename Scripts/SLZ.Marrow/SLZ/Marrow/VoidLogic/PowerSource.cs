using SLZ.Marrow.Utilities;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Sources/VoidLogic Power")]
	[Support(SupportFlags.Supported, null)]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/PowerSource")]
    public sealed class PowerSource : MonoBehaviour, IVoidLogicSource, IVoidLogicNode
    {
        [SerializeField]
        [HideInInspector]
        private bool _deprecated;

        [Tooltip("Amount of power supplied by this source")]
        [SerializeField]
        private float _value;

        private static readonly PortMetadata _portMetadata;

        [field: SerializeField]
        [field: NotUsedInEditMode]
        [field: ReadOnly(false)]
        public VoidLogicSubgraph Subgraph { get; set; }

        public bool Deprecated => false;

        public int OutputCount => 0;

        public float OutputValue
        {
            get
            {
                return 0f;
            }
            set
            {
            }
        }

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

        void SLZ.Marrow.VoidLogic.IVoidLogicSource.Calculate(ref NodeState nodeState)
        {
        }
    }
}
