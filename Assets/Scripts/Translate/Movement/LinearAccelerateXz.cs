using UnityEngine;
using Util;

namespace Translate.Movement {
public class LinearAccelerateXz : LinearAccelerate {
    public override Vector3 Modify(Vector3 val) {
        return val.MoveTowardsXz(Target, Speed(val) * Time.deltaTime);
    }
}
}