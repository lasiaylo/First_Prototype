using UnityEngine;
using Util;

namespace Motion {
    public class LinearAccelerateXz: LinearAccelerate {
        public override Vector3 Modify(Vector3 direction) {
            traits.Target = new Vector3(traits.Target.x, direction.y, traits.Target.z);
            return base.Modify(direction);
        }
    }
}