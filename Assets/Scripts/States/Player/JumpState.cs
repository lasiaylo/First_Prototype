using ScriptableObjects.Prototypes;
using UnityEngine;
using Util;

namespace States.Player {
    public class JumpState: AirState {
        public JumpTraits jump;

        public override void Enter() {
            jump.Action = Action.StartJump;
        }

        public override void Transition() {
            base.Transition();
            if (jump.Timer.IsEnd() || Movement.Direction.y <= 0) {
                StateMachine.SetState<FallState>();
            }
        }

        public override void Tick() {
            base.Tick();
            jump.Action = Input.Action;
        }

        public override void Exit() {
            jump.Action = Action.NotJumping;
        }
    }
}