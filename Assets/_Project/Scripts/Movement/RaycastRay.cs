using System;
using UnityEngine;

namespace Ipl.Movement
{
    [Serializable]
    public struct RaycastRay
    {
        public Vector2 origin;
        public Vector2 direction;
        public float distance;

        public bool Check(Vector2 offset, LayerMask layers)
        {
            return Physics2D.Raycast(origin + offset, direction, distance, layers);
        }

        public void Debug(Vector2 offset, LayerMask layers, Color hit, Color miss)
        {
            Gizmos.color = Check(offset, layers) ? hit : miss;
            Gizmos.DrawRay(origin + offset, direction * distance);
        }
    }
}