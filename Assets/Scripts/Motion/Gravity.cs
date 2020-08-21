using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Motion {
    [Serializable]
    public class Gravity : MovementMod {
        [FormerlySerializedAs("_gravity")] [SerializeField] private float gravity = 1;
        [FormerlySerializedAs("_grounded")] [SerializeField] private float grounded = 1;
        
        public void Tick(bool isGrounded) {
            if (!enabled) {
                Debug.Log("DISABLED");
                return;
            }
            float magnitude = isGrounded ? grounded : gravity;
            Direction = Vector3.down * magnitude;
        }
    }
}