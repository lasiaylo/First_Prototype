using UnityEngine;

namespace States.Player {
    public abstract class GroundState : MovableState {
        public override void Transition() {
            if (Input.Phase == Phase.Continue)
                stateMachine.SetState<JumpSquatState>();
            else if (!Controller.isGrounded) 
                stateMachine.SetState<FallState>();
        }
    }
}