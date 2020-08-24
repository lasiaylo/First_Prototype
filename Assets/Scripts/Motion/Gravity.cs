using System;
using ScriptableObjects;
using UnityEngine;
using UnityEngine.Serialization;
using Util;

namespace Motion {
    [Serializable]
    public class Gravity : MovementMod {
        [SerializeField] private GravityTraits traits;

        public override Vector3 Modify(Vector3 direction) {
            float speed = traits.IsGrounded ? traits.GroundGravity : traits.Gravity; 
            return direction.MoveTowardsY(
                -traits.MaxFallSpeed, 
                speed * Time.deltaTime
            );
        }
    }
}