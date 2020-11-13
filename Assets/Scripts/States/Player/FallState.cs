using UnityEngine;
using Util;

namespace States.Player {
    [CreateAssetMenu(fileName = "FallState", menuName = "States/FallState", order = 4)]

    public class FallState : AirState {
        public override PlayerState PlayerState => PlayerState.Fall;

        public override void Transition() {
            if (!Controller.isGrounded) return;
            if (Input.InputDirection.IsZero())
                stateMachine.SetState<IdleState>();
            else
                stateMachine.SetState<RunState>();
        }
    }
}