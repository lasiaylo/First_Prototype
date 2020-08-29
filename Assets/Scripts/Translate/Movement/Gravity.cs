using System;
using ScriptableObjects.Prototypes;
using UnityEngine;
using Util;
using Util.Attributes;

namespace Translate.Movement {
    [Serializable]
    public class Gravity : MovementMod {
        [Expandable] public GravityTraits GravityTraits;
        [Expandable] public JumpTraits JumpTraits;

        public override Vector3 Modify(Vector3 direction) {
            float speed = traits.IsGrounded ? traits.GroundGravity : traits.Gravity;
            float arcMult = (Math.Abs(direction.y) < traits.ArcThreshold) ? traits.ArcMult : 1;
            return direction.MoveTowardsY(
                -traits.MaxFallSpeed, 
                speed * arcMult * Time.deltaTime
            );
        }
    }
}