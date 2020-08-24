using System;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using Util;

namespace Motion {
    /// <summary>
    /// Linearly accelerates owner towards a target direction.
    /// </summary>
    /// <remarks>
    /// Adapted from Celeste's Running Implementation
    /// https://github.com/NoelFB/Celeste/blob/master/Source/Player/Player.cs#L2879
    /// </remarks>
    [Serializable]
    public class LinearAccelerate: MovementMod {
        protected Vector3 Target = Vector3.zero;
        private float _acceleration = 0f;
        private float _deceleration = 0f;
        private float _maxSpeed = 0f;
        private bool _isDecelerating = true;
        public void Tick(Vector3 target, float acceleration, float deceleration, float maxSpeed) {
            Target = target.normalized * _maxSpeed;
            _acceleration = acceleration;
            _deceleration = deceleration;
            _maxSpeed = maxSpeed;
        }

        public override Vector3 Influence(Vector3 direction) {
            _isDecelerating = direction.magnitude > _maxSpeed && Vector3.Angle(direction, Target) < 90;
            return direction.magnitude > _maxSpeed && Vector3.Angle(direction, Target ) < 90
                ? Vector3.MoveTowards(direction, Target, _deceleration * Time.deltaTime)
                : Vector3.MoveTowards(direction, Target, _acceleration * Time.deltaTime);
        }
    }
}