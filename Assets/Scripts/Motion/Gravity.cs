using System;
using UnityEngine;
using UnityEngine.Serialization;
using Util;

namespace Motion {
    [Serializable]
    public class Gravity : MovementMod {
        [SerializeField] private float gravity = 1;
        [SerializeField] private float grounded = 1;
        [SerializeField] private float maxFallSpeed = 10;
        private float _speed;

        public void Tick(bool isGrounded) {
            _speed = isGrounded ? grounded : gravity;
        }

        public override Vector3 Influence(Vector3 direction) {
            return direction.MoveTowardsY(-maxFallSpeed, _speed * Time.deltaTime);
        }
    }
}