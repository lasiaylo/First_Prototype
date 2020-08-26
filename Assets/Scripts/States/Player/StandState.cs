using System;
using UnityEngine;

namespace States.Player {
    public class StandState : GroundedState {
        public override void Enter() {
            // Play Idle Animation   
            Debug.Log("IDLE");
        }

        public override void Tick() {
            base.Tick();
            if (Input.Direction != Vector3.zero)
                stateMachine.SetState<RunState>();
        }
    }
}
    