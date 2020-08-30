using ScriptableObjects.Prototypes;
using ScriptableObjects.Prototypes.Trait;
using UnityEngine;
using Util;

namespace States.Player {
    public class JumpState: AirState {
        public JumpTraits jump;

        public override void Enter() {
            base.Enter();
            jump.Phase = Phase.Start;
        }

        public override void Transition() {
            base.Transition();
            if (jump.timer.IsEnd() || Movement.Value.y <= 0) {
                StateMachine.SetState<FallState>();
            }
        }

        public override void Tick() {
            jump.Phase = Input.Phase;
        }

        public override void Exit() {
            jump.Phase = Phase.End;
        }
    }
}