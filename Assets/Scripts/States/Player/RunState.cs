

using Motion;
using UnityEngine;
using Util;

namespace States.Player {
    public class RunState: GroundedState {
        private Movement _movement;

        public void Awake() {
            base.Awake();
            _movement = GetComponent<Movement>();
        }
        
        public override void Enter() {
            Debug.Log("RUNNING");
        }

        public void Tick(PlayerController player) {
            base.Tick();
            if (Input.Direction.IsZero() && _movement.Direction.GetXz().IsZero()) {
                stateMachine.SetState<StandState>();
            }
        }
    }
}