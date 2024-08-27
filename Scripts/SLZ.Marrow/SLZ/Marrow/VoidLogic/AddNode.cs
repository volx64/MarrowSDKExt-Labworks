// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.
// SLZ.Marrow, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// SLZ.Marrow.VoidLogic.AddNode
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
    [Support(SupportFlags.Supported, null)]
    [AddComponentMenu("VoidLogic/VoidLogic Add")]
    public sealed class AddNode : BaseNode
    {
        private static readonly PortMetadata _portMetadata;

        public override PortMetadata PortMetadata => default;

        public override void Initialize(ref NodeState nodeState)
        {
        }

        public override void Calculate(ref NodeState nodeState)
        {
        }
    }
}