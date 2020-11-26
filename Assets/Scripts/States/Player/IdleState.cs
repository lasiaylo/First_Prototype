using Data.Util;
using UnityEngine;
using Util;

namespace States.Player {
    [CreateAssetMenu(fileName = "IdleState", menuName = "States/Idle", order = 0)]
    public class IdleState : GroundState {
        public override PlayerState PlayerState => PlayerState.Idle;

        public override void Transition() {
            base.Transition();
            if (!Input.InputDirection.IsZero())
                stateMachine.SetState<RunState>();
        }
    }
}