using UnityEngine;
using Util;

namespace Motion {
    public class LinearAccelerateXz: LinearAccelerate {
        public override Vector3 Influence(Vector3 direction) {
            Target.Set(Target.x, direction.y, Target.z);
            return base.Influence(direction);
        }
    }
}