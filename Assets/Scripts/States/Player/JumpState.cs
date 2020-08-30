using ScriptableObjects.Prototypes;
using ScriptableObjects.Prototypes.Traits;
using UnityEngine;
using Util;

namespace States.Player {
    public class JumpState: AirState {
        public JumpTraits jump;

        public override void Enter() {
            base.Enter();
            jump.Action = Action.StartJump;
        }

        public override void Transition() {
            base.Transition();
            if (jump.timer.IsEnd() || Movement.Value.y <= 0) {
                StateMachine.SetState<FallState>();
            }
        }

        public override void Tick() {
            jump.Action = Input.Action;
        }

        public override void Exit() {
            jump.Action = Action.NotJumping;
        }
    }
}