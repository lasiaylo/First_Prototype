using ScriptableObjects.Prototypes.Event;
using Translate.Movement;
using UnityEngine;
using Util;

namespace States.Player {
public class RunState : GroundedState {

    public override void Transition() {
        base.Transition();
        if (Input.InputDirection.IsZero()) StateMachine.SetState<StandState>();
    }
}
}