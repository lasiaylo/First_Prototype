using System;
using Cinemachine;
using Events;
using JetBrains.Annotations;
using ScriptableObjects.Prototypes.Trait;
using UnityEngine;
using Util;
using Util.Attributes;

namespace Translate.Movement {
/// <summary>
///     Handles Gravity for GameObjects
/// </summary>
/// <remarks>
///     Adapted from Celeste's Gravity Implementation:
///     https://github.com/NoelFB/Celeste/blob/master/Source/Player/Player.cs#L2927
/// </remarks>
[Serializable]
public class Gravity : Mod<Vector3> {
    [Expandable, NotNull] public GravityTraits traits;
    public GameEvent<bool> arcEvent; 
    private CharacterController _controller;
    private bool _arcStart;
    private Toggle ThisIsBadCode;
    
    public void Awake() {
        _controller = GetComponent<CharacterController>();
        ThisIsBadCode = new Toggle(false);
    }

    public override Vector3 Modify(Vector3 val) {
        float arcMult = ShouldArc(val) ? traits.ArcMult : 1;
        if (_controller.isGrounded) {
            return val.MoveTowardsY(-1, traits.GroundGravity * Time.deltaTime);
        }
        return val.MoveTowardsY(
            -traits.MaxFallSpeed,
            traits.Gravity * arcMult * Time.deltaTime
        );
    }

    private bool ShouldArc(Vector3 direction) {
        bool shouldArc = !_controller.isGrounded && Math.Abs(direction.y) < traits.ArcThreshold;
        if (shouldArc && direction.y > 0 && _arcStart) {
            arcEvent?.Raise(direction.y > 0);
            _arcStart = false;
        }
        _arcStart = _controller.isGrounded || _arcStart;
        
        return shouldArc;
    }
}
}