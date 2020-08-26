using ScriptableObjects.Prototypes;
using UnityEngine;
using Util;
using Util.Attributes;

namespace Motion {
    public class LinearAccelerateXz: LinearAccelerate {
        public override Vector3 Modify(Vector3 direction) {
            return base.ShouldDecelerate(direction)
                ? direction.MoveTowardsXz(traits.Target, traits.Deceleration * Time.deltaTime)
                : direction.MoveTowardsXz(traits.Target, traits.Acceleration * Time.deltaTime);
        }
    }
}