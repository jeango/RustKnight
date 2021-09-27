using System;
using UnityEditor;
using UnityEngine;

namespace Ipl.Movement
{
    public class PlayerMovement : MovementControllerBase
    {
        [SerializeField] private int speed;
        [SerializeField] private float jumpPower;
        [SerializeField] private GroundCheckBase groundCheck;
        private Vector2 _direction;
        private bool _jumpRequested;
        private bool _canJump;

        private void FixedUpdate()
        {
            var v = rb.velocity;
            v.x = _direction.x * speed;
            _canJump = groundCheck.IsGrounded();
            if (_canJump && _jumpRequested)
            {
                v.y = jumpPower;
                _jumpRequested = false;
                _canJump = false;
            }
            rb.velocity = v;
        }

        public override void Move(Vector2 direction)
        {
            _direction = direction;
        }

        public override void Jump()
        {
            if (_canJump)
            {
                _jumpRequested = true;
            }
        }
    }
}