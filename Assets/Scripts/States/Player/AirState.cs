using Util;

namespace States.Player {
    public class AirState : MovableState {
        public override void Transition() {
            base.Transition();
            if (!Controller.isGrounded) return;
            if (Input.InputDirection.IsZero())
                stateMachine.SetState<IdleState>();
            else
                stateMachine.SetState<RunState>();
        }
    }
}