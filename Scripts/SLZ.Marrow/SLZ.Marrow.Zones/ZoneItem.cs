 
 
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
    public class ZoneItem : MonoBehaviour, IZoneEntityListenable
    {
        [SerializeField]
        protected Zone _zone;
        public MarrowQuery activatorTags = new();
#if UNITY_EDITOR
        protected virtual void Reset()
        {
            var query = new TagQuery();
            BoneTagReference btRef = new BoneTagReference(MarrowSettings.RuntimeInstance.PlayerTag.Barcode);
            query.BoneTag = btRef;
            activatorTags.Tags.Add(query);
            _zone = GetComponent<Zone>();
            if (_zone != null || transform.parent == null)
                return;
            _zone = transform.parent.GetComponent<Zone>();
        }
#endif
        protected virtual void OnEnable()
        {
        }

        protected virtual void OnDisable()
        {
        }

        protected virtual void OnEnter(MarrowEntity entity)
        {
        }

        protected virtual void OnExit(MarrowEntity entity)
        {
        }

        public void OnZoneEntityEnter(MarrowEntity entity)
        {
        }

        public void OnZoneEntityExit(MarrowEntity entity)
        {
        }
    }
}
