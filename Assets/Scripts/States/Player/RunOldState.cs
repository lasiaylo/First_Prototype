using Translate.Movement;
using UnityEngine;
using Util;

namespace States.Player {
public class RunOldState : GroundedOldState {

    public override void Transition() {
        base.Transition();
        if (Input.InputDirection.IsZero()) StateMachineTicker.SetState<StandOldState>();
    }
}
}