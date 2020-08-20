using System;
using UnityEngine;

namespace Motion {
    [Serializable]
    public class Gravity : MovementMod {
        [SerializeField] private float _gravity = 1;
        [SerializeField] private float _grounded = 1;
        
        public void Tick(bool isGrounded) {
            if (!base.Enabled) {
                Debug.Log("DISABLED");
                return;
            }
            float magnitude = isGrounded ? _grounded : _gravity;
            Direction = Vector3.down * magnitude;
        }
    }
}