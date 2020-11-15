using Util;

namespace States.Player {
public class StandOldState : GroundedOldState {
    public override void Transition() { 
        base.Transition();
        if (!Input.InputDirection.IsZero())
            StateMachineTicker.SetState<RunOldState>();
    }
}
}