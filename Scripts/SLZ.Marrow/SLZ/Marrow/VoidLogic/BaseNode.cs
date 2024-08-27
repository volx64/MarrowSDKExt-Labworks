// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.
// SLZ.Marrow, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// SLZ.Marrow.VoidLogic.BaseNode
using System;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
    public abstract class BaseNode : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicSource
    {
        [SerializeField]
        [HideInInspector]
        private bool _deprecated;

        [Tooltip("Dead Field: Please remove")]
        [SerializeField]
        [Obsolete("Dead Field: Please remove")]
        [NonReorderable]
        protected internal MonoBehaviour[] _previous;

        [SerializeField]
        [NonReorderable]
        [Tooltip("Previous node(s) in the chain")]
        protected internal OutputPortReference[] _previousConnections;

        [field: SerializeField]
        [field: NotUsedInEditMode]
        [field: ReadOnly(false)]
        public VoidLogicSubgraph Subgraph { get; set; }

        public bool Deprecated => false;

        public abstract PortMetadata PortMetadata { get; }

        public int InputCount => 0;

        public virtual int OutputCount => 0;

        protected virtual void Awake()
        {
        }

        protected virtual void OnEnable()
        {
        }

        protected virtual void OnDisable()
        {
        }

        protected virtual void OnDestroy()
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected static bool EqualWithTolerance(float term1, float term2, float tolerance)
        {
            return false;
        }

        public bool TryGetInputConnection(uint inputIndex, out OutputPortReference connectedPort)
        {
            connectedPort = default;
            return false;
        }

        public bool TryConnectPortToInput(OutputPortReference output, uint inputIndex)
        {
            return false;
        }

        public abstract void Initialize(ref NodeState nodeState);

        public abstract void Calculate(ref NodeState nodeState);
    }
}