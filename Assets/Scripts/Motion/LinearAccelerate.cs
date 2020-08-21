using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Util;

namespace Motion {
    [Serializable]
    public class LinearAccelerate: MovementMod {
        public void Tick(float acceleration, float friction, float maxSpeed, Vector3 direction) {
            if (!base.Enabled) return;
            Direction = direction.IsZero()
                ? Vector3.MoveTowards(Direction, direction, friction)
                : Vector3.MoveTowards(Direction, direction * maxSpeed, acceleration);
        }
    }
}