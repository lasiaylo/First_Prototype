using ScriptableObjects.Prototypes;
using UnityEngine;
using Util;

namespace States.Player {
    public class JumpState: AirState {
        public JumpTraits jump;

        public override void Enter() { 
            Debug.Log("JUMPING");
        }

        public override void Transition() {
            base.Transition();
            if (jump.Timer.IsEnd()) {
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