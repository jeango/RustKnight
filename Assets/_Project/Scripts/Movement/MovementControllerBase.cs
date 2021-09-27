using System;
using UnityEngine;

namespace Ipl.Movement
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class MovementControllerBase : MonoBehaviour
    {
        private Rigidbody2D _rb;

        protected Rigidbody2D rb => _rb;

        protected virtual void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        public abstract void Move(Vector2 direction);
        public abstract void Jump();
    }
}