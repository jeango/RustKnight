using System;
using UnityEngine;

namespace Ipl.Movement
{
    [Serializable]
    public struct BoxOverlap
    {
        public Vector2 origin;
        public Vector2 size;

        public bool Check(Vector2 offset, LayerMask layers)
        {
            return Physics2D.OverlapBox(origin + offset, size, 0f,layers);
        }

        public void Debug(Vector2 offset, LayerMask layers, Color hit, Color miss)
        {
            Gizmos.color = Check(offset, layers) ? hit : miss;
            var center = offset + origin;
            var flip = new Vector2(-size.x, size.y);
            var p0 = center - size / 2;
            var p1 = center + flip / 2;
            var p2 = center + size / 2;
            var p3 = center - flip / 2;
            Gizmos.DrawLine(p0, p1);
            Gizmos.DrawLine(p1, p2);
            Gizmos.DrawLine(p2, p3);
            Gizmos.DrawLine(p3, p0);
            
        }
    }
}