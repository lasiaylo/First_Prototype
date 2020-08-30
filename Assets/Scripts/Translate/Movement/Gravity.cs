using System;
using ScriptableObjects.Prototypes;
using ScriptableObjects.Prototypes.Traits;
using UnityEngine;
using Util;
using Util.Attributes;

namespace Translate.Movement {
    [Serializable]
    public class Gravity : Mod<Vector3> {
        [Expandable] public GravityTraits traits;
        private CharacterController _controller;
        
        public void Awake() {
            _controller = GetComponent<CharacterController>();
        } 

        public override Vector3 Modify(Vector3 val) {
            float speed = _controller.isGrounded ? traits.GroundGravity : traits.Gravity;
            float arcMult = ShouldArc(val) ? traits.ArcMult : 1;
            return val.MoveTowardsY(
                -traits.MaxFallSpeed, 
                speed * arcMult * Time.deltaTime
            );
        }

        private Boolean ShouldArc(Vector3 direction) {
            return (Math.Abs(direction.y) < traits.ArcThreshold);
        }
    }
}