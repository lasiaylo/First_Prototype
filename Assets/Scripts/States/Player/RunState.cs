﻿using Translate.Movement;
using Util;

namespace States.Player {
public class RunState : GroundedState {
    private Movement _movement;

    public override void Awake() {
        base.Awake();
        _movement = GetComponent<Movement>();
    }

    public override void Transition() {
        base.Transition();
        if (Input.InputDirection.IsZero() && _movement.Value.GetXz().IsZero()) StateMachine.SetState<StandState>();
    }

    public override void Tick() {
        // Throw event   
    }
}
}