using UnityEngine;
using Util;

namespace Translate.Movement {
    public class LinearAccelerateXz: LinearAccelerate {
        public override Vector3 Modify(Vector3 direction) {
            return base.ShouldDecelerate(new Vector3(direction.x, traits.Target.y, direction.z))
                ? direction.MoveTowardsXz(traits.Target, traits.Deceleration * Time.deltaTime)
                : direction.MoveTowardsXz(traits.Target, traits.Acceleration * Time.deltaTime);
        }
    }
}