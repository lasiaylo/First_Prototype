using Translate.Movement;
using Util;

namespace States.Player {
public abstract class AirOldState : MovableOldState {

    public override void Transition() {
        if (!Controller.isGrounded) return;
        if (Input.InputDirection.IsZero())
            StateMachineTicker.SetState<StandOldState>();
        else
            StateMachineTicker.SetState<RunOldState>();
    }
}
}