using System;
using ScriptableObjects.Prototypes.Trait;
using UnityEngine;
using Util;
using Util.Attributes;

namespace Translate.Movement {
[Serializable]
public class Gravity : Mod<Vector3> {
    private CharacterController _controller;
    [Expandable] public GravityTraits traits;

    public void Awake() {
        _controller = GetComponent<CharacterController>();
    }

    public override Vector3 Modify(Vector3 val) {
        var speed = _controller.isGrounded ? traits.GroundGravity : traits.Gravity;
        var arcMult = ShouldArc(val) ? traits.ArcMult : 1;
        return val.MoveTowardsY(
            -traits.MaxFallSpeed,
            speed * arcMult * Time.deltaTime
        );
    }

    private bool ShouldArc(Vector3 direction) {
        return Math.Abs(direction.y) < traits.ArcThreshold;
    }
}
}