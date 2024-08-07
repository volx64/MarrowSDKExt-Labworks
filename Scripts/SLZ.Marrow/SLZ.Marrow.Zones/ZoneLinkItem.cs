using System;
 
using UnityEngine;

namespace SLZ.Marrow.Zones
{
    public class ZoneLinkItem : MonoBehaviour, IZoneLinkListenable, IZoneLinkPrimaryListenable, IZoneLinkSecondaryListenable
    {
        [Flags]
        public enum EventTypes
        {
            Primary = 1 << 0,
            Secondary = 1 << 1
        }

        [SerializeField]
        public ZoneLink _zoneLink;
        [EnumFlags, SerializeField]
        public EventTypes _eventTypes = EventTypes.Primary | EventTypes.Secondary;
#if UNITY_EDITOR
        protected virtual void Reset()
        {
            _zoneLink = GetComponent<ZoneLink>();
            if (_zoneLink != null || transform.parent == null)
                return;
            _zoneLink = transform.parent.GetComponent<ZoneLink>();
        }
#endif
    }
}
