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
    public class LinearAccelerate : MovementMod {
        [Expandable] public LinearAccelerateTraits traits;
        public bool decelerate;

        public override Vector3 Modify(Vector3 direction) {
            decelerate = ShouldAccelerate(direction);
            float speed = ShouldAccelerate(direction) ? traits.Acceleration : traits.Deceleration;
            return Vector3.MoveTowards(direction, traits.Target, speed * Time.deltaTime);
        }

        protected bool ShouldAccelerate(Vector3 direction) {
            return  !traits.Target.IsZero() && Vector3.Angle(direction.GetXz(), traits.Target.GetXz()) <= 90;
        }
    }
}