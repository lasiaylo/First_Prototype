using UnityEngine;
using Util;

namespace Translate.Movement {
    public class LinearAccelerateXz: LinearAccelerate {
        public override Vector3 Modify(Vector3 val) {
            float speed = ShouldAccelerate(val) ? traits.Acceleration : traits.Deceleration;
            return val.MoveTowardsXz(traits.Target, speed * Time.deltaTime);
        }
    }
}