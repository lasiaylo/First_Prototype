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
        [Expandable] public LinearAccelerateTraits traits;
        public bool decelerate;

        public override Vector3 Modify(Vector3 val) {
            decelerate = ShouldAccelerate(val);
            float speed = ShouldAccelerate(val) ? traits.Acceleration : traits.Deceleration;
            return Vector3.MoveTowards(val, traits.Target, speed * Time.deltaTime);
        }

        protected bool ShouldAccelerate(Vector3 direction) {
            return  !traits.Target.IsZero() && Vector3.Angle(direction.GetXz(), traits.Target.GetXz()) <= 90;
        }
    }
}