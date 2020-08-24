using System;
using System.Collections.Generic;
using UnityEngine;
using Util;

namespace Motion {
    /// <summary>
    /// Handles Jumping for GameObjects     
    /// </summary>
    /// <remarks>
    /// Adapted from Celeste's Jump Implementation:
    /// https://github.com/NoelFB/Celeste/blob/master/Source/Player/Player.cs#L2960
    /// </remarks>
    public class Jump: MovementMod {
        private Movement _movement;
        private float _timer;
        private Action _action;
        private float _continue;

        public void Awake() {
            _movement = GetComponent<Movement>();
            _timer = 0f;
        }

        public void Tick(float velocity, float duration, Action action) {
            _action = action;
            if (action == Action.Jumping) {
                if (_timer <= 0)
                    StartJump(velocity, duration);                    
                else
                    ContinueJump(velocity);
            } else
                EndJump();
            
            _timer -= Time.deltaTime;
            _timer = _timer.ClampMin(0f);
        }
        
        private Vector3 StartJump(float velocity, float duration) {
            _timer = duration;
            return Vector3.up * velocity;
        }
        
        private Vector3 ContinueJump(float velocity) {
            float continueVelocity = Math.Min(velocity, _movement.PrevDirection.y);
            continueVelocity = continueVelocity.ClampMin(0f);
            _continue = continueVelocity;
            Direction = Vector3.up * continueVelocity;
        }
        
        private void EndJump() {
            _timer = 0;
            Direction = Vector3.zero;
        }

        public override Vector3 Influence(Vector3 direction) {
            return Vector3.zero;
        }
    }
}