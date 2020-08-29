using UnityEngine;
using Util;

namespace Translate.Movement {
    public class LinearAccelerateXz: LinearAccelerate {
        public override Vector3 Modify(Vector3 direction) {
            float speed = ShouldAccelerate(direction) ? traits.Acceleration : traits.Deceleration;
            return direction.MoveTowardsXz(traits.Target, speed * Time.deltaTime);
        }
    }
}