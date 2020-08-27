using UnityEngine;

namespace States.Player {
    public abstract class GroundedState: MovableState {
        public override void Enter() {
            
        }

        public override void Transition() {
            if (Input.Action == Action.Jumping) {
                StateMachine.SetState<JumpState>();
            }
        }
    }                       
}