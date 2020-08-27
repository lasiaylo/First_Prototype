using Translate.Movement;
using UnityEngine;

namespace States.Player {
    public abstract class GroundedState : MovableState {
        protected Movement Movement;

        public override void Awake() {
            base.Awake();
        }

        public override void Transition() {
            Debug.Log("CHECK");
            if (Input.Action == Action.StartJump) {
                Debug.Log("WOWEE");
                StateMachine.SetState<JumpState>();
            }

            if (!Controller.isGrounded) {
                StateMachine.SetState<FallState>();
            }
        }
    }
}