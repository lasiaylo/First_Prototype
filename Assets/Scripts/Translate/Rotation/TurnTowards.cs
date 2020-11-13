using ScriptableObjects.Prototypes.Variable;
using Translate.Movement;
using UnityEngine;
using Util;
using Util.Attributes;

namespace Translate.Rotation {
public class TurnTowards : Mod<Quaternion> {
    [Expandable] public Vector3Variable direction;
    [Expandable] public FloatVariable turnSpeed;

    public override Quaternion Modify(Quaternion val) {
        return direction.Val.IsZero()
            ? val
            : Quaternion.RotateTowards(
                val,
                Quaternion.LookRotation(direction.Val),
                turnSpeed.Val * Time.deltaTime
            );
    }
}
}