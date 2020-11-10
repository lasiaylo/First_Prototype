﻿using UnityEngine;
using Util;

namespace States.Player {
    [CreateAssetMenu(fileName = "RunState", menuName = "States/RunState", order = 1)]
    public class RunState : GroundState {
        public override PlayerState PlayerState => PlayerState.Run;

        public override void Transition() {
            base.Transition();
            if (Input.InputDirection.IsZero())
                stateMachine.SetState<IdleState>();
        }
    }
}