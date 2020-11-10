using Util;

namespace States.Player {
    public abstract class AirState : MovableState {
        public override void Transition() {
            if (!Controller.isGrounded) return;
            if (Input.InputDirection.IsZero())
                stateMachine.SetState<IdleState>();
            else
                stateMachine.SetState<RunState>();
        }
    }
}