using System;
using ScriptableObjects;
using ScriptableObjects.Prototypes;
using UnityEngine;
using Util;
using Util.Attributes;

namespace Motion {
    [Serializable]
    public class Gravity : MovementMod {
        [Expandable] public GravityTraits traits;

        public override Vector3 Modify(Vector3 direction) {
            float speed = traits.IsGrounded ? traits.GroundGravity : traits.Gravity; 
            return direction.MoveTowardsY(
                -traits.MaxFallSpeed, 
                speed * Time.deltaTime
            );
        }
    }
}