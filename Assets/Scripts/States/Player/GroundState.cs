using UnityEngine;

namespace States.Player {
    public class GroundState : MovableState {
        public override void Transition() {
            base.Transition();
            if (Input.Phase == Phase.Continue)
                stateMachine.SetState<JumpState>();
            else if (!Controller.isGrounded) 
                stateMachine.SetState<FallState>();
        }
    }
}