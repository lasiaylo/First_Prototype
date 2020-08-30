using System;
using ScriptableObjects.Prototypes;
using UnityEngine;
using Util;
using Util.Attributes;

namespace Translate.Movement {
    [Serializable]
    public class Gravity : Mod<Vector3> {
        [Expandable] public GravityTraits gravityTraits;
        private CharacterController _controller;
        
        public void Awake() {
            _controller = GetComponent<CharacterController>();
        } 

        public override Vector3 Modify(Vector3 val) {
            float speed = _controller.isGrounded ? gravityTraits.GroundGravity : gravityTraits.Gravity;
            float arcMult = ShouldArc(val) ? gravityTraits.ArcMult : 1;
            return val.MoveTowardsY(
                -gravityTraits.MaxFallSpeed, 
                speed * arcMult * Time.deltaTime
            );
        }

        private Boolean ShouldArc(Vector3 direction) {
            return (Math.Abs(direction.y) < gravityTraits.ArcThreshold);
        }
    }
}