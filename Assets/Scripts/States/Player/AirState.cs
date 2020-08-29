using Translate.Movement;
using UnityEngine;
using Util;


namespace States.Player {
    [RequireComponent(typeof(StandState))]
    [RequireComponent(typeof(RunState))]
    public abstract class AirState: MovableState {
        protected Movement Movement;
        
        public override void Awake() {
            base.Awake();
            Movement = GetComponent<Movement>();
        }

        public override void Transition() {
            if (Controller.isGrounded) {
                if (Movement.Value.GetXz().IsZero()) {
                    StateMachine.SetState<StandState>();
                } else {
                    StateMachine.SetState<RunState>();
                }
            }
            if (Movement.Value.y <= 0) {
                StateMachine.SetState<FallState>();
            }
        }
    }
}