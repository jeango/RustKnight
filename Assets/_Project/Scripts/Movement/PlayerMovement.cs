using System;
using UnityEditor;
using UnityEngine;

namespace Ipl.Movement
{
    public class PlayerMovement : MovementControllerBase
    {
        [SerializeField] private int speed;
        [SerializeField] private float jumpPower;
        private Vector2 _direction;
        private bool _jumpRequested;
        private bool _canJump;

        private void FixedUpdate()
        {
            var v = rb.velocity;
            v.x = _direction.x * speed;
            if (_canJump && _jumpRequested)
            {
                v.y = jumpPower;
                _jumpRequested = false;
                _canJump = false;
            }
            rb.velocity = v;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            _canJump = true;
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