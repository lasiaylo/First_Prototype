using UnityEngine;

namespace States.Player {
    public abstract class GroundedState: MovableState {
        public override void Enter() {
            
        }

        public override void Tick() {
            base.Tick();
            if (Input.Action == Action.Jumping) {
                stateMachine.SetState<JumpState>();
            }
        }
    }                       
}