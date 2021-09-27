using UnityEngine;

namespace Ipl.Movement
{
    public class BoxGroundCheck : GroundCheckBase
    {
        [SerializeField] private BoxOverlap box;
        [SerializeField] private LayerMask groundLayers;

        public override bool IsGrounded()
        {
            return box.Check(transform.position, groundLayers);
        }

        private void OnDrawGizmos()
        {
            box.Debug(transform.position, groundLayers, Color.green, Color.red);
        }
    }
}