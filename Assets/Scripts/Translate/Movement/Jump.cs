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
        [Expandable] public JumpTraits traits;
        private Movement _movement;

        public void Awake() {
            _movement = GetComponent<Movement>();
            traits.Timer = new Timer(traits.Duration);
        }

        private Vector3 StartJump(Vector3 direction) {
            traits.Timer.Reset();
            Debug.Log("START");
            return new Vector3(direction.x, traits.Speed, direction.z);
        }

        private Vector3 ContinueJump(Vector3 direction) {
            Debug.Log("CONTINUING");
            traits.Timer.Tick(Time.deltaTime);
            return Math.Abs(direction.y) < traits.Threshold
                ? direction.MoveTowardsY(direction.y + 100, traits.ContinueSpeed * Time.deltaTime)
                : direction;
        }
        
        private Vector3 EndJump(Vector3 direction) {
            traits.Timer.End();
            return direction;
            // return new Vector3(direction.x, direction.y.ClampMax(0f), direction.z);
        }

        public override Vector3 Modify(Vector3 direction) {
            if (traits.Action == Action.StartJump) {
                return StartJump(direction);
            }

            if (traits.Action == Action.ContinueJump) {
                return ContinueJump(direction);
            }
            return EndJump(direction);
        }
    }
}