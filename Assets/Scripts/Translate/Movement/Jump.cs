using System;
using ScriptableObjects.Prototypes;
using ScriptableObjects.Prototypes.Traits;
using UnityEngine;
using Util;
using Util.Attributes;

namespace Translate.Movement {
    /// <summary>
    /// Handles Jumping for GameObjects     
    /// </summary>
    /// <remarks>
    /// Adapted from Celeste's Jump Implementation:
    /// https://github.com/NoelFB/Celeste/blob/master/Source/Player/Player.cs#L2960
    /// </remarks>
    public class Jump: Mod<Vector3> {
        [Expandable] public JumpTraits traits;
        private Movement _movement;

        public void Awake() {
            _movement = GetComponent<Movement>();
            traits.timer = new Timer(traits.Duration);
        }

        private Vector3 StartJump(Vector3 direction) {
            traits.timer.Reset();
            return new Vector3(direction.x, traits.Speed, direction.z);
        }

        private Vector3 ContinueJump(Vector3 direction) {
            traits.timer.Tick(Time.deltaTime);
            float continueVelocity = Mathf.Min(traits.Speed, direction.y);
            return new Vector3(direction.x, continueVelocity, direction.z);
        }
        
        private Vector3 EndJump(Vector3 direction) {
            traits.timer.End();
            return direction;
            // return new Vector3(direction.x, direction.y.ClampMax(0f), direction.z);
        }

        public override Vector3 Modify(Vector3 val) {
            if (traits.Action == Action.StartJump) {
                return StartJump(val);
            }

            if (traits.Action == Action.ContinueJump) {
                return ContinueJump(val);
            }
            return EndJump(val);
        }
    }
}