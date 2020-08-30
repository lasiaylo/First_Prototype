using System;
using UnityEngine;

namespace States.Player {
    public class StandState : GroundedState {

        public override void Transition() {
            base.Transition();
            if (Input.Direction != Vector3.zero)
                StateMachine.SetState<RunState>();
        }

        public override void Tick() {
            // Throw event
        }
    }
}
    