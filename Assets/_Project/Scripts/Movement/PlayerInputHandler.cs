using UnityEngine;

namespace Ipl.Movement
{
    public class PlayerInputHandler : MonoBehaviour
    {
        [SerializeField] private MovementControllerBase movementCtrl;

        private void Update()
        {
            var dir = new Vector2(Input.GetAxis("Horizontal"), 0);
            movementCtrl.Move(dir);
            if (Input.GetButtonDown("Jump"))
                movementCtrl.Jump();
        }
    }
}