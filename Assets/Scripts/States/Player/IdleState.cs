using Data.Util;
using UnityEngine;
using Util;

namespace States.Player {
    [CreateAssetMenu(fileName = "IdleState", menuName = "States/IdleState", order = 0)]
    public class IdleState : GroundState {
        public override void Transition() {
            base.Transition();
            if (!Input.InputDirection.IsZero())
                stateMachine.SetState<RunState>();                
        }
    }
}