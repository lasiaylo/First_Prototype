using System;
using ScriptableObjects.Prototypes;
using UnityEngine;
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
    public class LinearAccelerate : MovementMod {
        [Expandable] public LinearAccelerateTraits traits;

        public override Vector3 Modify(Vector3 direction) {
            return ShouldDecelerate(direction)
                ? Vector3.MoveTowards(direction, traits.Target, traits.Deceleration * Time.deltaTime)
                : Vector3.MoveTowards(direction, traits.Target, traits.Acceleration * Time.deltaTime);
        }

        protected Boolean ShouldDecelerate(Vector3 direction) {
            return direction.magnitude > traits.MaxSpeed.magnitude && Vector3.Angle(direction, traits.Target) <= 90;
        }
    }
}