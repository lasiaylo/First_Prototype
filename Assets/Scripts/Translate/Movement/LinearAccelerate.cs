using System;
using ScriptableObjects.Prototypes.Variable;
using ScriptableObjects.Prototypes.Wrapper;
using UnityEngine;
using Util;
using Util.Attributes;

namespace Translate.Movement {
/// <summary>
///     Linearly accelerates owner towards a target direction.
/// </summary>
/// <remarks>
///     Adapted from Celeste's Running Implementation
///     https://github.com/NoelFB/Celeste/blob/master/Source/Player/Player.cs#L2879
/// </remarks>
[Serializable]
public class LinearAccelerate : Mod<Vector3> {
    [Expandable] public Vector3Variable inputDirection;
    [Expandable] public WLinearAccelerateTraits traits;

    protected Vector3 Target => Vector3.Scale(inputDirection.val, traits.val.MaxSpeed);

    public override Vector3 Modify(Vector3 val) {
        return Vector3.MoveTowards(val, Target, Speed(val) * Time.deltaTime);
    }

    protected float Speed(Vector3 val) {
        return !inputDirection.val.IsZero() && Vector3.Angle(val.GetXz(), inputDirection.val.GetXz()) <= 90
            ? traits.val.Acceleration
            : traits.val.Deceleration;
    }
}
}