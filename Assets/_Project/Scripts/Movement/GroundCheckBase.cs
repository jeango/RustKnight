using UnityEngine;

namespace Ipl.Movement
{
    public abstract class GroundCheckBase:MonoBehaviour
    {
        public abstract bool IsGrounded();
    }
}