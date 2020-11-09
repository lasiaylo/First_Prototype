﻿using JetBrains.Annotations;
using ScriptableObjects.Prototypes.Trait;
using Translate.Movement;
using UnityEngine;

namespace States.Player {
public class JumpOldState : AirOldState {
    [NotNull] public JumpTraits jump;
    private MovementTicker _movementTicker;

    public override void Awake() {
        base.Awake();
        _movementTicker = GetComponent<MovementTicker>();
    }

    public override void Enter() {
        base.Enter();
        jump.Phase = Phase.Start;
        Debug.Log("JUMP!");
    }

    public override void Transition() {
        base.Transition();
        if (jump.timer.IsEnd() || _movementTicker.Value.y <= 0) StateMachineTicker.SetState<FallOldState>();
    }

    public override void Tick() {
        base.Tick();
        jump.Phase = Input.Phase;
    }

    public override void Exit() {
        base.Exit();
        jump.Phase = Phase.End;
    }
}
}