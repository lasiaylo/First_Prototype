using UnityEngine;
using Util;

namespace States.Player {
    public abstract class AirState : MovableState {
        public override void Transition() {
            // Debug.Log(Controller.isGrounded);
            if (!Controller.isGrounded) return;
            if (Input.InputDirection.IsZero())
                stateMachine.SetState<IdleState>();
            else
                stateMachine.SetState<RunState>();
        }
    }
}