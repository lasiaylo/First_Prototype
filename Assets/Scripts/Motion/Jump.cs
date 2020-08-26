using System;
using System.Collections.Generic;
using System.IO;
using ScriptableObjects;
using ScriptableObjects.Prototypes;
using UnityEngine;
using Util;
using Util.Attributes;

namespace Motion {
    /// <summary>
    /// Handles Jumping for GameObjects     
    /// </summary>
    /// <remarks>
    /// Adapted from Celeste's Jump Implementation:
    /// https://github.com/NoelFB/Celeste/blob/master/Source/Player/Player.cs#L2960
    /// </remarks>
    public class Jump: MovementMod {
        [Expandable] public JumpTraits traits;
        private Movement _movement;
        private Timer _timer;

        public void Awake() {
            _movement = GetComponent<Movement>();
            _timer = new Timer(traits.Duration);
        }

        private Vector3 StartJump(Vector3 direction) {
            _timer.Reset();
            return new Vector3(direction.x, traits.Speed, direction.z);
        }
        
        private Vector3 ContinueJump(Vector3 direction) {
            float continueVelocity = Mathf.Min(traits.Speed, _movement.Direction.y).ClampMin(0f);
            return new Vector3(direction.x, continueVelocity, direction.z);
        }
        
        private Vector3 EndJump(Vector3 direction) {
            _timer.End();
            return direction;
        }

        public override Vector3 Modify(Vector3 direction) {
            _timer.Tick(Time.deltaTime);
            if (traits.Action == Action.Jumping) {
                return _timer.Remaining <= 0f 
                    ? StartJump(direction) 
                    : ContinueJump(direction);
            }
            return EndJump(direction);
        }
    }
}