using System;
using ScriptableObjects.Prototypes;
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
    public class Jump: MovementMod {
        [Expandable] public JumpTraits jumpTraits;
        private Movement _movement;

        public void Awake() {
            _movement = GetComponent<Movement>();
            jumpTraits.timer = new Timer(jumpTraits.Duration);
        }

        private Vector3 StartJump(Vector3 direction) {
            jumpTraits.timer.Reset();
            return new Vector3(direction.x, jumpTraits.Speed, direction.z);
        }

        private Vector3 ContinueJump(Vector3 direction) {
            jumpTraits.timer.Tick(Time.deltaTime);
            float continueVelocity = Mathf.Min(jumpTraits.Speed, _movement.Direction.y);
            return new Vector3(direction.x, continueVelocity, direction.z);
        }
        
        private Vector3 EndJump(Vector3 direction) {
            jumpTraits.timer.End();
            return direction;
            // return new Vector3(direction.x, direction.y.ClampMax(0f), direction.z);
        }

        public override Vector3 Modify(Vector3 direction) {
            if (jumpTraits.Action == Action.StartJump) {
                return StartJump(direction);
            }

            if (jumpTraits.Action == Action.ContinueJump) {
                return ContinueJump(direction);
            }
            return EndJump(direction);
        }
    }
}