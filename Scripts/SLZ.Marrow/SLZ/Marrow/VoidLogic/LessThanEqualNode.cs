using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
    [HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/LessThanEqualNode")]
	[Support(SupportFlags.Supported, null)]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Less Than or Equal")]
	public class LessThanEqualNode : BaseNode
	{
		[SerializeField]
		[Tooltip("Amount of approximation allowed in the equality check.\n0 will use Mathf.Approximately/Mathf.Epsilon to approximate.\nMake sure your tolerances match for consistent results!")]
		private float _tolerance;

		private static readonly PortMetadata _portMetadata;

		public override PortMetadata PortMetadata => default(PortMetadata);

		public override void Calculate(ref NodeState nodeState)
		{
		}

        public override void Initialize(ref NodeState nodeState)
        {
        }
    }
}
