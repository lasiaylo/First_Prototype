using System;
using ScriptableObjects.Prototypes;
using UnityEngine;
using Util;
using Util.Attributes;

namespace Translate.Movement {
    /// <summary>
    /// Linearly accelerates owner towards a target direction.
    /// </summary>
    /// <remarks>
    /// Adapted from Celeste's Running Implementation
    /// https://github.com/NoelFB/Celeste/blob/master/Source/Player/Player.cs#L2879
    /// </remarks>
    [Serializable]
    public class LinearAccelerate : Mod<Vector3> {
        [Expandable] public WLinearAccelerateTraits traits;

        [Expandable] public Vector3Variable input;

        protected Vector3 Target {
            get => Vector3.Scale(input.val, traits.obj.MaxSpeed);
        }

        public override Vector3 Modify(Vector3 val) {
            return Vector3.MoveTowards(val, Target, Speed(val) * Time.deltaTime);
        }

        protected float Speed(Vector3 val) {
            return  !input.val.IsZero() && Vector3.Angle(val.GetXz(), input.val.GetXz()) <= 90
                ? traits.obj.Acceleration 
                : traits.obj.Deceleration;
        }
    }
}