using ScriptableObjects.Prototypes;
using Translate.Movement;
using UnityEngine;

namespace States.Player {
    public abstract class GroundedState : MovableState {
        public override void Transition() {
            if (Input.Phase == Phase.Continue) {
                StateMachine.SetState<JumpState>();
            } else if (!Controller.isGrounded) {
                StateMachine.SetState<FallState>();
            }
        }
    }
}