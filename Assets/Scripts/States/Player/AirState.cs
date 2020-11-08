using Translate.Movement;
using Util;

namespace States.Player {
public abstract class AirState : MovableState {

    public override void Transition() {
        if (!Controller.isGrounded) return;
        if (Input.InputDirection.IsZero())
            StateMachineTicker.SetState<StandState>();
        else
            StateMachineTicker.SetState<RunState>();
    }
}
}