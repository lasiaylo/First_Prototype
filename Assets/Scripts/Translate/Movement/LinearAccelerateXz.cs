using UnityEngine;
using Util;

namespace Translate.Movement {
    public class LinearAccelerateXz: LinearAccelerate {
        public override Vector3 Modify(Vector3 val) {
            float speed = ShouldAccelerate(val) ? traits.obj.Acceleration : traits.obj.Deceleration;
            return val.MoveTowardsXz(traits.obj.Target, speed * Time.deltaTime);
        }
    }
}