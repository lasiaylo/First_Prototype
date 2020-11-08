using Util;

namespace States.Player {
public class StandState : GroundedState {
    public override void Transition() { 
        base.Transition();
        if (!Input.InputDirection.IsZero())
            StateMachineTicker.SetState<RunState>();
    }
}
}