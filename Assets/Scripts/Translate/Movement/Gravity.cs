using System;
using ScriptableObjects.Prototypes;
using UnityEngine;
using Util;
using Util.Attributes;

namespace Translate.Movement {
    [Serializable]
    public class Gravity : Mod<Vector3> {
        [Expandable] public GravityTraits gravityTraits;

        public override Vector3 Modify(Vector3 direction) {
            float speed = gravityTraits.IsGrounded ? gravityTraits.GroundGravity : gravityTraits.Gravity;
            float arcMult = ShouldArc(direction) ? gravityTraits.ArcMult : 1;
            return direction.MoveTowardsY(
                -gravityTraits.MaxFallSpeed, 
                speed * arcMult * Time.deltaTime
            );
        }

        private Boolean ShouldArc(Vector3 direction) {
            return (Math.Abs(direction.y) < gravityTraits.ArcThreshold);
        }
    }
}