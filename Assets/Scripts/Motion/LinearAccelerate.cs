﻿using System;
using System.IO;
using ScriptableObjects;
using ScriptableObjects.Prototypes;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using Util;
using Util.Attributes;

namespace Motion {
    /// <summary>
    /// Linearly accelerates owner towards a target direction.
    /// </summary>
    /// <remarks>
    /// Adapted from Celeste's Running Implementation
    /// https://github.com/NoelFB/Celeste/blob/master/Source/Player/Player.cs#L2879
    /// </remarks>
    [Serializable]
    public class LinearAccelerate : MovementMod {
        [Expandable] public LinearAccelerateTraits traits;

        public override Vector3 Modify(Vector3 direction) {
            Vector3 target = traits.Target;
            float acceleration = traits.Acceleration; 
            float deceleration = traits.Deceleration;
            float maxSpeed = traits.MaxSpeed.magnitude;
            
            return direction.magnitude > maxSpeed && Vector3.Angle(direction, target) < 90
                ? Vector3.MoveTowards(direction, target, deceleration * Time.deltaTime)
                : Vector3.MoveTowards(direction, target, acceleration * Time.deltaTime);
        }
    }
}