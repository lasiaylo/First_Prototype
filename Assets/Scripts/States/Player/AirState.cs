using Motion;
using Util;

namespace States.Player {
    public abstract class AirState: MovableState {
        protected Movement Movement;
        
        public override void Awake() {
            base.Awake();
            Movement = GetComponent<Movement>();
        }

        public override void Transition() {
            if (Controller.isGrounded) {
                if (Movement.Direction.GetXz().IsZero()) {
                    StateMachine.SetState<StandState>();
                } else {
                    StateMachine.SetState<RunState>();
                }
            }
            if (Movement.Direction.y <= 0) {
                StateMachine.SetState<FallState>();
            }
        }
    }
}